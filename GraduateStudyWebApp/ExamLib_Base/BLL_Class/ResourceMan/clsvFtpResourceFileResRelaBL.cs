
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFtpResourceFileResRelaBL
 表名:vFtpResourceFileResRela(01120376)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:41
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
public static class  clsvFtpResourceFileResRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFtpResourceFileResRelaEN GetObj(this K_mId_vFtpResourceFileResRela myKey)
{
clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = clsvFtpResourceFileResRelaBL.vFtpResourceFileResRelaDA.GetObjBymId(myKey.Value);
return objvFtpResourceFileResRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetmId(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, long lngmId, string strComparisonOp="")
	{
objvFtpResourceFileResRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.mId) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.mId, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.mId] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetFileResourceID(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, long lngFileResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngFileResourceID, convFtpResourceFileResRela.FileResourceID);
objvFtpResourceFileResRelaEN.FileResourceID = lngFileResourceID; //FileResourceID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.FileResourceID) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.FileResourceID, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.FileResourceID] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetIpAddress(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strIpAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIpAddress, 50, convFtpResourceFileResRela.IpAddress);
}
objvFtpResourceFileResRelaEN.IpAddress = strIpAddress; //Ip地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.IpAddress) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.IpAddress, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.IpAddress] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetFileDirName(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convFtpResourceFileResRela.FileDirName);
}
objvFtpResourceFileResRelaEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.FileDirName) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.FileDirName, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.FileDirName] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetFileName(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convFtpResourceFileResRela.FileName);
}
objvFtpResourceFileResRelaEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.FileName) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.FileName, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.FileName] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetFileNameBak(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strFileNameBak, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNameBak, 500, convFtpResourceFileResRela.FileNameBak);
}
objvFtpResourceFileResRelaEN.FileNameBak = strFileNameBak; //FileName_Bak
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.FileNameBak) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.FileNameBak, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.FileNameBak] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetExtension(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strExtension, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExtension, 10, convFtpResourceFileResRela.Extension);
}
objvFtpResourceFileResRelaEN.Extension = strExtension; //扩展名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.Extension) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.Extension, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.Extension] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetFileLength(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, long? lngFileLength, string strComparisonOp="")
	{
objvFtpResourceFileResRelaEN.FileLength = lngFileLength; //文件长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.FileLength) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.FileLength, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.FileLength] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetFileType(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convFtpResourceFileResRela.FileType);
}
objvFtpResourceFileResRelaEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.FileType) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.FileType, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.FileType] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetCreationTime(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strCreationTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreationTime, 20, convFtpResourceFileResRela.CreationTime);
}
objvFtpResourceFileResRelaEN.CreationTime = strCreationTime; //建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.CreationTime) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.CreationTime, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.CreationTime] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetLastWriteTime(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strLastWriteTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastWriteTime, 20, convFtpResourceFileResRela.LastWriteTime);
}
objvFtpResourceFileResRelaEN.LastWriteTime = strLastWriteTime; //最后修改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.LastWriteTime) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.LastWriteTime, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.LastWriteTime] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetCheckDateTime(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strCheckDateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckDateTime, 30, convFtpResourceFileResRela.CheckDateTime);
}
objvFtpResourceFileResRelaEN.CheckDateTime = strCheckDateTime; //CheckDateTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.CheckDateTime) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.CheckDateTime, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.CheckDateTime] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetInUse(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, bool bolInUse, string strComparisonOp="")
	{
objvFtpResourceFileResRelaEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.InUse) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.InUse, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.InUse] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetIsExistFile(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvFtpResourceFileResRelaEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.IsExistFile) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.IsExistFile, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.IsExistFile] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetIdFtpResource(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convFtpResourceFileResRela.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convFtpResourceFileResRela.IdFtpResource);
}
objvFtpResourceFileResRelaEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.IdFtpResource) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.IdFtpResource, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.IdFtpResource] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetFuncModuleId(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convFtpResourceFileResRela.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convFtpResourceFileResRela.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convFtpResourceFileResRela.FuncModuleId);
}
objvFtpResourceFileResRelaEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.FuncModuleId) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.FuncModuleId, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.FuncModuleId] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetFuncModuleName(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convFtpResourceFileResRela.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convFtpResourceFileResRela.FuncModuleName);
}
objvFtpResourceFileResRelaEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.FuncModuleName) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.FuncModuleName, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.FuncModuleName] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetFuncModuleNameSim(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convFtpResourceFileResRela.FuncModuleNameSim);
}
objvFtpResourceFileResRelaEN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.FuncModuleNameSim) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.FuncModuleNameSim, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.FuncModuleNameSim] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetOrderNum(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, int? intOrderNum, string strComparisonOp="")
	{
objvFtpResourceFileResRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.OrderNum) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.OrderNum, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.OrderNum] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetUpdDate(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFtpResourceFileResRela.UpdDate);
}
objvFtpResourceFileResRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.UpdDate) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.UpdDate, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.UpdDate] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetUpdUser(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFtpResourceFileResRela.UpdUser);
}
objvFtpResourceFileResRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.UpdUser) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.UpdUser, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.UpdUser] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFtpResourceFileResRelaEN SetMemo(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFtpResourceFileResRela.Memo);
}
objvFtpResourceFileResRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFtpResourceFileResRelaEN.dicFldComparisonOp.ContainsKey(convFtpResourceFileResRela.Memo) == false)
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp.Add(convFtpResourceFileResRela.Memo, strComparisonOp);
}
else
{
objvFtpResourceFileResRelaEN.dicFldComparisonOp[convFtpResourceFileResRela.Memo] = strComparisonOp;
}
}
return objvFtpResourceFileResRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaENS">源对象</param>
 /// <param name = "objvFtpResourceFileResRelaENT">目标对象</param>
 public static void CopyTo(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaENS, clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaENT)
{
try
{
objvFtpResourceFileResRelaENT.mId = objvFtpResourceFileResRelaENS.mId; //mId
objvFtpResourceFileResRelaENT.FileResourceID = objvFtpResourceFileResRelaENS.FileResourceID; //FileResourceID
objvFtpResourceFileResRelaENT.IpAddress = objvFtpResourceFileResRelaENS.IpAddress; //Ip地址
objvFtpResourceFileResRelaENT.FileDirName = objvFtpResourceFileResRelaENS.FileDirName; //文件目录名
objvFtpResourceFileResRelaENT.FileName = objvFtpResourceFileResRelaENS.FileName; //文件名称
objvFtpResourceFileResRelaENT.FileNameBak = objvFtpResourceFileResRelaENS.FileNameBak; //FileName_Bak
objvFtpResourceFileResRelaENT.Extension = objvFtpResourceFileResRelaENS.Extension; //扩展名
objvFtpResourceFileResRelaENT.FileLength = objvFtpResourceFileResRelaENS.FileLength; //文件长度
objvFtpResourceFileResRelaENT.FileType = objvFtpResourceFileResRelaENS.FileType; //文件类型
objvFtpResourceFileResRelaENT.CreationTime = objvFtpResourceFileResRelaENS.CreationTime; //建立时间
objvFtpResourceFileResRelaENT.LastWriteTime = objvFtpResourceFileResRelaENS.LastWriteTime; //最后修改时间
objvFtpResourceFileResRelaENT.CheckDateTime = objvFtpResourceFileResRelaENS.CheckDateTime; //CheckDateTime
objvFtpResourceFileResRelaENT.InUse = objvFtpResourceFileResRelaENS.InUse; //是否在用
objvFtpResourceFileResRelaENT.IsExistFile = objvFtpResourceFileResRelaENS.IsExistFile; //是否存在文件
objvFtpResourceFileResRelaENT.IdFtpResource = objvFtpResourceFileResRelaENS.IdFtpResource; //FTP资源流水号
objvFtpResourceFileResRelaENT.FuncModuleId = objvFtpResourceFileResRelaENS.FuncModuleId; //功能模块Id
objvFtpResourceFileResRelaENT.FuncModuleName = objvFtpResourceFileResRelaENS.FuncModuleName; //功能模块名称
objvFtpResourceFileResRelaENT.FuncModuleNameSim = objvFtpResourceFileResRelaENS.FuncModuleNameSim; //功能模块简称
objvFtpResourceFileResRelaENT.OrderNum = objvFtpResourceFileResRelaENS.OrderNum; //序号
objvFtpResourceFileResRelaENT.UpdDate = objvFtpResourceFileResRelaENS.UpdDate; //修改日期
objvFtpResourceFileResRelaENT.UpdUser = objvFtpResourceFileResRelaENS.UpdUser; //修改人
objvFtpResourceFileResRelaENT.Memo = objvFtpResourceFileResRelaENS.Memo; //备注
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
 /// <param name = "objvFtpResourceFileResRelaENS">源对象</param>
 /// <returns>目标对象=>clsvFtpResourceFileResRelaEN:objvFtpResourceFileResRelaENT</returns>
 public static clsvFtpResourceFileResRelaEN CopyTo(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaENS)
{
try
{
 clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaENT = new clsvFtpResourceFileResRelaEN()
{
mId = objvFtpResourceFileResRelaENS.mId, //mId
FileResourceID = objvFtpResourceFileResRelaENS.FileResourceID, //FileResourceID
IpAddress = objvFtpResourceFileResRelaENS.IpAddress, //Ip地址
FileDirName = objvFtpResourceFileResRelaENS.FileDirName, //文件目录名
FileName = objvFtpResourceFileResRelaENS.FileName, //文件名称
FileNameBak = objvFtpResourceFileResRelaENS.FileNameBak, //FileName_Bak
Extension = objvFtpResourceFileResRelaENS.Extension, //扩展名
FileLength = objvFtpResourceFileResRelaENS.FileLength, //文件长度
FileType = objvFtpResourceFileResRelaENS.FileType, //文件类型
CreationTime = objvFtpResourceFileResRelaENS.CreationTime, //建立时间
LastWriteTime = objvFtpResourceFileResRelaENS.LastWriteTime, //最后修改时间
CheckDateTime = objvFtpResourceFileResRelaENS.CheckDateTime, //CheckDateTime
InUse = objvFtpResourceFileResRelaENS.InUse, //是否在用
IsExistFile = objvFtpResourceFileResRelaENS.IsExistFile, //是否存在文件
IdFtpResource = objvFtpResourceFileResRelaENS.IdFtpResource, //FTP资源流水号
FuncModuleId = objvFtpResourceFileResRelaENS.FuncModuleId, //功能模块Id
FuncModuleName = objvFtpResourceFileResRelaENS.FuncModuleName, //功能模块名称
FuncModuleNameSim = objvFtpResourceFileResRelaENS.FuncModuleNameSim, //功能模块简称
OrderNum = objvFtpResourceFileResRelaENS.OrderNum, //序号
UpdDate = objvFtpResourceFileResRelaENS.UpdDate, //修改日期
UpdUser = objvFtpResourceFileResRelaENS.UpdUser, //修改人
Memo = objvFtpResourceFileResRelaENS.Memo, //备注
};
 return objvFtpResourceFileResRelaENT;
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
public static void CheckProperty4Condition(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN)
{
 clsvFtpResourceFileResRelaBL.vFtpResourceFileResRelaDA.CheckProperty4Condition(objvFtpResourceFileResRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.mId) == true)
{
string strComparisonOpmId = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFtpResourceFileResRela.mId, objvFtpResourceFileResRelaCond.mId, strComparisonOpmId);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.FileResourceID) == true)
{
string strComparisonOpFileResourceID = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.FileResourceID];
strWhereCond += string.Format(" And {0} {2} {1}", convFtpResourceFileResRela.FileResourceID, objvFtpResourceFileResRelaCond.FileResourceID, strComparisonOpFileResourceID);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.IpAddress) == true)
{
string strComparisonOpIpAddress = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.IpAddress, objvFtpResourceFileResRelaCond.IpAddress, strComparisonOpIpAddress);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.FileDirName) == true)
{
string strComparisonOpFileDirName = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.FileDirName, objvFtpResourceFileResRelaCond.FileDirName, strComparisonOpFileDirName);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.FileName) == true)
{
string strComparisonOpFileName = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.FileName, objvFtpResourceFileResRelaCond.FileName, strComparisonOpFileName);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.FileNameBak) == true)
{
string strComparisonOpFileNameBak = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.FileNameBak];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.FileNameBak, objvFtpResourceFileResRelaCond.FileNameBak, strComparisonOpFileNameBak);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.Extension) == true)
{
string strComparisonOpExtension = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.Extension];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.Extension, objvFtpResourceFileResRelaCond.Extension, strComparisonOpExtension);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.FileLength) == true)
{
string strComparisonOpFileLength = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.FileLength];
strWhereCond += string.Format(" And {0} {2} {1}", convFtpResourceFileResRela.FileLength, objvFtpResourceFileResRelaCond.FileLength, strComparisonOpFileLength);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.FileType) == true)
{
string strComparisonOpFileType = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.FileType, objvFtpResourceFileResRelaCond.FileType, strComparisonOpFileType);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.CreationTime) == true)
{
string strComparisonOpCreationTime = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.CreationTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.CreationTime, objvFtpResourceFileResRelaCond.CreationTime, strComparisonOpCreationTime);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.LastWriteTime) == true)
{
string strComparisonOpLastWriteTime = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.LastWriteTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.LastWriteTime, objvFtpResourceFileResRelaCond.LastWriteTime, strComparisonOpLastWriteTime);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.CheckDateTime) == true)
{
string strComparisonOpCheckDateTime = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.CheckDateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.CheckDateTime, objvFtpResourceFileResRelaCond.CheckDateTime, strComparisonOpCheckDateTime);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.InUse) == true)
{
if (objvFtpResourceFileResRelaCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFtpResourceFileResRela.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFtpResourceFileResRela.InUse);
}
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.IsExistFile) == true)
{
if (objvFtpResourceFileResRelaCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFtpResourceFileResRela.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFtpResourceFileResRela.IsExistFile);
}
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.IdFtpResource, objvFtpResourceFileResRelaCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.FuncModuleId, objvFtpResourceFileResRelaCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.FuncModuleName, objvFtpResourceFileResRelaCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.FuncModuleNameSim, objvFtpResourceFileResRelaCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFtpResourceFileResRela.OrderNum, objvFtpResourceFileResRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.UpdDate, objvFtpResourceFileResRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.UpdUser, objvFtpResourceFileResRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFtpResourceFileResRelaCond.IsUpdated(convFtpResourceFileResRela.Memo) == true)
{
string strComparisonOpMemo = objvFtpResourceFileResRelaCond.dicFldComparisonOp[convFtpResourceFileResRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFtpResourceFileResRela.Memo, objvFtpResourceFileResRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFtpResourceFileResRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vFtp资源文件资源关系(vFtpResourceFileResRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFtpResourceFileResRelaBL
{
public static RelatedActions_vFtpResourceFileResRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFtpResourceFileResRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFtpResourceFileResRelaDA vFtpResourceFileResRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFtpResourceFileResRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFtpResourceFileResRelaBL()
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
if (string.IsNullOrEmpty(clsvFtpResourceFileResRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFtpResourceFileResRelaEN._ConnectString);
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
public static DataTable GetDataTable_vFtpResourceFileResRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFtpResourceFileResRelaDA.GetDataTable_vFtpResourceFileResRela(strWhereCond);
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
objDT = vFtpResourceFileResRelaDA.GetDataTable(strWhereCond);
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
objDT = vFtpResourceFileResRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFtpResourceFileResRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFtpResourceFileResRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFtpResourceFileResRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vFtpResourceFileResRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFtpResourceFileResRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFtpResourceFileResRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvFtpResourceFileResRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvFtpResourceFileResRelaEN> arrObjLst = new List<clsvFtpResourceFileResRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = new clsvFtpResourceFileResRelaEN();
try
{
objvFtpResourceFileResRelaEN.mId = Int32.Parse(objRow[convFtpResourceFileResRela.mId].ToString().Trim()); //mId
objvFtpResourceFileResRelaEN.FileResourceID = Int32.Parse(objRow[convFtpResourceFileResRela.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceFileResRelaEN.IpAddress = objRow[convFtpResourceFileResRela.IpAddress] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IpAddress].ToString().Trim(); //Ip地址
objvFtpResourceFileResRelaEN.FileDirName = objRow[convFtpResourceFileResRela.FileDirName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceFileResRelaEN.FileName = objRow[convFtpResourceFileResRela.FileName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileName].ToString().Trim(); //文件名称
objvFtpResourceFileResRelaEN.FileNameBak = objRow[convFtpResourceFileResRela.FileNameBak] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceFileResRelaEN.Extension = objRow[convFtpResourceFileResRela.Extension] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Extension].ToString().Trim(); //扩展名
objvFtpResourceFileResRelaEN.FileLength = objRow[convFtpResourceFileResRela.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.FileLength].ToString().Trim()); //文件长度
objvFtpResourceFileResRelaEN.FileType = objRow[convFtpResourceFileResRela.FileType] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileType].ToString().Trim(); //文件类型
objvFtpResourceFileResRelaEN.CreationTime = objRow[convFtpResourceFileResRela.CreationTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CreationTime].ToString().Trim(); //建立时间
objvFtpResourceFileResRelaEN.LastWriteTime = objRow[convFtpResourceFileResRela.LastWriteTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.LastWriteTime].ToString().Trim(); //最后修改时间
objvFtpResourceFileResRelaEN.CheckDateTime = objRow[convFtpResourceFileResRela.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceFileResRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.InUse].ToString().Trim()); //是否在用
objvFtpResourceFileResRelaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceFileResRelaEN.IdFtpResource = objRow[convFtpResourceFileResRela.IdFtpResource] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceFileResRelaEN.FuncModuleId = objRow[convFtpResourceFileResRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceFileResRelaEN.FuncModuleName = objRow[convFtpResourceFileResRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceFileResRelaEN.FuncModuleNameSim = objRow[convFtpResourceFileResRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceFileResRelaEN.OrderNum = objRow[convFtpResourceFileResRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.OrderNum].ToString().Trim()); //序号
objvFtpResourceFileResRelaEN.UpdDate = objRow[convFtpResourceFileResRela.UpdDate] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceFileResRelaEN.UpdUser = objRow[convFtpResourceFileResRela.UpdUser] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdUser].ToString().Trim(); //修改人
objvFtpResourceFileResRelaEN.Memo = objRow[convFtpResourceFileResRela.Memo] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceFileResRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceFileResRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFtpResourceFileResRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvFtpResourceFileResRelaEN._CurrTabName);
List<clsvFtpResourceFileResRelaEN> arrvFtpResourceFileResRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFtpResourceFileResRelaEN> arrvFtpResourceFileResRelaObjLst_Sel =
arrvFtpResourceFileResRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvFtpResourceFileResRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFtpResourceFileResRelaEN> GetObjLst(string strWhereCond)
{
List<clsvFtpResourceFileResRelaEN> arrObjLst = new List<clsvFtpResourceFileResRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = new clsvFtpResourceFileResRelaEN();
try
{
objvFtpResourceFileResRelaEN.mId = Int32.Parse(objRow[convFtpResourceFileResRela.mId].ToString().Trim()); //mId
objvFtpResourceFileResRelaEN.FileResourceID = Int32.Parse(objRow[convFtpResourceFileResRela.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceFileResRelaEN.IpAddress = objRow[convFtpResourceFileResRela.IpAddress] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IpAddress].ToString().Trim(); //Ip地址
objvFtpResourceFileResRelaEN.FileDirName = objRow[convFtpResourceFileResRela.FileDirName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceFileResRelaEN.FileName = objRow[convFtpResourceFileResRela.FileName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileName].ToString().Trim(); //文件名称
objvFtpResourceFileResRelaEN.FileNameBak = objRow[convFtpResourceFileResRela.FileNameBak] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceFileResRelaEN.Extension = objRow[convFtpResourceFileResRela.Extension] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Extension].ToString().Trim(); //扩展名
objvFtpResourceFileResRelaEN.FileLength = objRow[convFtpResourceFileResRela.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.FileLength].ToString().Trim()); //文件长度
objvFtpResourceFileResRelaEN.FileType = objRow[convFtpResourceFileResRela.FileType] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileType].ToString().Trim(); //文件类型
objvFtpResourceFileResRelaEN.CreationTime = objRow[convFtpResourceFileResRela.CreationTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CreationTime].ToString().Trim(); //建立时间
objvFtpResourceFileResRelaEN.LastWriteTime = objRow[convFtpResourceFileResRela.LastWriteTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.LastWriteTime].ToString().Trim(); //最后修改时间
objvFtpResourceFileResRelaEN.CheckDateTime = objRow[convFtpResourceFileResRela.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceFileResRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.InUse].ToString().Trim()); //是否在用
objvFtpResourceFileResRelaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceFileResRelaEN.IdFtpResource = objRow[convFtpResourceFileResRela.IdFtpResource] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceFileResRelaEN.FuncModuleId = objRow[convFtpResourceFileResRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceFileResRelaEN.FuncModuleName = objRow[convFtpResourceFileResRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceFileResRelaEN.FuncModuleNameSim = objRow[convFtpResourceFileResRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceFileResRelaEN.OrderNum = objRow[convFtpResourceFileResRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.OrderNum].ToString().Trim()); //序号
objvFtpResourceFileResRelaEN.UpdDate = objRow[convFtpResourceFileResRela.UpdDate] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceFileResRelaEN.UpdUser = objRow[convFtpResourceFileResRela.UpdUser] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdUser].ToString().Trim(); //修改人
objvFtpResourceFileResRelaEN.Memo = objRow[convFtpResourceFileResRela.Memo] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceFileResRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceFileResRelaEN);
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
public static List<clsvFtpResourceFileResRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFtpResourceFileResRelaEN> arrObjLst = new List<clsvFtpResourceFileResRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = new clsvFtpResourceFileResRelaEN();
try
{
objvFtpResourceFileResRelaEN.mId = Int32.Parse(objRow[convFtpResourceFileResRela.mId].ToString().Trim()); //mId
objvFtpResourceFileResRelaEN.FileResourceID = Int32.Parse(objRow[convFtpResourceFileResRela.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceFileResRelaEN.IpAddress = objRow[convFtpResourceFileResRela.IpAddress] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IpAddress].ToString().Trim(); //Ip地址
objvFtpResourceFileResRelaEN.FileDirName = objRow[convFtpResourceFileResRela.FileDirName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceFileResRelaEN.FileName = objRow[convFtpResourceFileResRela.FileName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileName].ToString().Trim(); //文件名称
objvFtpResourceFileResRelaEN.FileNameBak = objRow[convFtpResourceFileResRela.FileNameBak] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceFileResRelaEN.Extension = objRow[convFtpResourceFileResRela.Extension] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Extension].ToString().Trim(); //扩展名
objvFtpResourceFileResRelaEN.FileLength = objRow[convFtpResourceFileResRela.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.FileLength].ToString().Trim()); //文件长度
objvFtpResourceFileResRelaEN.FileType = objRow[convFtpResourceFileResRela.FileType] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileType].ToString().Trim(); //文件类型
objvFtpResourceFileResRelaEN.CreationTime = objRow[convFtpResourceFileResRela.CreationTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CreationTime].ToString().Trim(); //建立时间
objvFtpResourceFileResRelaEN.LastWriteTime = objRow[convFtpResourceFileResRela.LastWriteTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.LastWriteTime].ToString().Trim(); //最后修改时间
objvFtpResourceFileResRelaEN.CheckDateTime = objRow[convFtpResourceFileResRela.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceFileResRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.InUse].ToString().Trim()); //是否在用
objvFtpResourceFileResRelaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceFileResRelaEN.IdFtpResource = objRow[convFtpResourceFileResRela.IdFtpResource] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceFileResRelaEN.FuncModuleId = objRow[convFtpResourceFileResRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceFileResRelaEN.FuncModuleName = objRow[convFtpResourceFileResRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceFileResRelaEN.FuncModuleNameSim = objRow[convFtpResourceFileResRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceFileResRelaEN.OrderNum = objRow[convFtpResourceFileResRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.OrderNum].ToString().Trim()); //序号
objvFtpResourceFileResRelaEN.UpdDate = objRow[convFtpResourceFileResRela.UpdDate] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceFileResRelaEN.UpdUser = objRow[convFtpResourceFileResRela.UpdUser] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdUser].ToString().Trim(); //修改人
objvFtpResourceFileResRelaEN.Memo = objRow[convFtpResourceFileResRela.Memo] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceFileResRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceFileResRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFtpResourceFileResRelaEN> GetSubObjLstCache(clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaCond)
{
List<clsvFtpResourceFileResRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFtpResourceFileResRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFtpResourceFileResRela.AttributeName)
{
if (objvFtpResourceFileResRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFtpResourceFileResRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFtpResourceFileResRelaCond[strFldName].ToString());
}
else
{
if (objvFtpResourceFileResRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFtpResourceFileResRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFtpResourceFileResRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFtpResourceFileResRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFtpResourceFileResRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFtpResourceFileResRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFtpResourceFileResRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFtpResourceFileResRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFtpResourceFileResRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFtpResourceFileResRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFtpResourceFileResRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFtpResourceFileResRelaCond[strFldName]));
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
public static List<clsvFtpResourceFileResRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFtpResourceFileResRelaEN> arrObjLst = new List<clsvFtpResourceFileResRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = new clsvFtpResourceFileResRelaEN();
try
{
objvFtpResourceFileResRelaEN.mId = Int32.Parse(objRow[convFtpResourceFileResRela.mId].ToString().Trim()); //mId
objvFtpResourceFileResRelaEN.FileResourceID = Int32.Parse(objRow[convFtpResourceFileResRela.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceFileResRelaEN.IpAddress = objRow[convFtpResourceFileResRela.IpAddress] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IpAddress].ToString().Trim(); //Ip地址
objvFtpResourceFileResRelaEN.FileDirName = objRow[convFtpResourceFileResRela.FileDirName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceFileResRelaEN.FileName = objRow[convFtpResourceFileResRela.FileName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileName].ToString().Trim(); //文件名称
objvFtpResourceFileResRelaEN.FileNameBak = objRow[convFtpResourceFileResRela.FileNameBak] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceFileResRelaEN.Extension = objRow[convFtpResourceFileResRela.Extension] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Extension].ToString().Trim(); //扩展名
objvFtpResourceFileResRelaEN.FileLength = objRow[convFtpResourceFileResRela.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.FileLength].ToString().Trim()); //文件长度
objvFtpResourceFileResRelaEN.FileType = objRow[convFtpResourceFileResRela.FileType] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileType].ToString().Trim(); //文件类型
objvFtpResourceFileResRelaEN.CreationTime = objRow[convFtpResourceFileResRela.CreationTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CreationTime].ToString().Trim(); //建立时间
objvFtpResourceFileResRelaEN.LastWriteTime = objRow[convFtpResourceFileResRela.LastWriteTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.LastWriteTime].ToString().Trim(); //最后修改时间
objvFtpResourceFileResRelaEN.CheckDateTime = objRow[convFtpResourceFileResRela.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceFileResRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.InUse].ToString().Trim()); //是否在用
objvFtpResourceFileResRelaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceFileResRelaEN.IdFtpResource = objRow[convFtpResourceFileResRela.IdFtpResource] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceFileResRelaEN.FuncModuleId = objRow[convFtpResourceFileResRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceFileResRelaEN.FuncModuleName = objRow[convFtpResourceFileResRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceFileResRelaEN.FuncModuleNameSim = objRow[convFtpResourceFileResRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceFileResRelaEN.OrderNum = objRow[convFtpResourceFileResRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.OrderNum].ToString().Trim()); //序号
objvFtpResourceFileResRelaEN.UpdDate = objRow[convFtpResourceFileResRela.UpdDate] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceFileResRelaEN.UpdUser = objRow[convFtpResourceFileResRela.UpdUser] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdUser].ToString().Trim(); //修改人
objvFtpResourceFileResRelaEN.Memo = objRow[convFtpResourceFileResRela.Memo] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceFileResRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceFileResRelaEN);
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
public static List<clsvFtpResourceFileResRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFtpResourceFileResRelaEN> arrObjLst = new List<clsvFtpResourceFileResRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = new clsvFtpResourceFileResRelaEN();
try
{
objvFtpResourceFileResRelaEN.mId = Int32.Parse(objRow[convFtpResourceFileResRela.mId].ToString().Trim()); //mId
objvFtpResourceFileResRelaEN.FileResourceID = Int32.Parse(objRow[convFtpResourceFileResRela.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceFileResRelaEN.IpAddress = objRow[convFtpResourceFileResRela.IpAddress] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IpAddress].ToString().Trim(); //Ip地址
objvFtpResourceFileResRelaEN.FileDirName = objRow[convFtpResourceFileResRela.FileDirName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceFileResRelaEN.FileName = objRow[convFtpResourceFileResRela.FileName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileName].ToString().Trim(); //文件名称
objvFtpResourceFileResRelaEN.FileNameBak = objRow[convFtpResourceFileResRela.FileNameBak] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceFileResRelaEN.Extension = objRow[convFtpResourceFileResRela.Extension] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Extension].ToString().Trim(); //扩展名
objvFtpResourceFileResRelaEN.FileLength = objRow[convFtpResourceFileResRela.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.FileLength].ToString().Trim()); //文件长度
objvFtpResourceFileResRelaEN.FileType = objRow[convFtpResourceFileResRela.FileType] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileType].ToString().Trim(); //文件类型
objvFtpResourceFileResRelaEN.CreationTime = objRow[convFtpResourceFileResRela.CreationTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CreationTime].ToString().Trim(); //建立时间
objvFtpResourceFileResRelaEN.LastWriteTime = objRow[convFtpResourceFileResRela.LastWriteTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.LastWriteTime].ToString().Trim(); //最后修改时间
objvFtpResourceFileResRelaEN.CheckDateTime = objRow[convFtpResourceFileResRela.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceFileResRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.InUse].ToString().Trim()); //是否在用
objvFtpResourceFileResRelaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceFileResRelaEN.IdFtpResource = objRow[convFtpResourceFileResRela.IdFtpResource] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceFileResRelaEN.FuncModuleId = objRow[convFtpResourceFileResRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceFileResRelaEN.FuncModuleName = objRow[convFtpResourceFileResRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceFileResRelaEN.FuncModuleNameSim = objRow[convFtpResourceFileResRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceFileResRelaEN.OrderNum = objRow[convFtpResourceFileResRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.OrderNum].ToString().Trim()); //序号
objvFtpResourceFileResRelaEN.UpdDate = objRow[convFtpResourceFileResRela.UpdDate] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceFileResRelaEN.UpdUser = objRow[convFtpResourceFileResRela.UpdUser] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdUser].ToString().Trim(); //修改人
objvFtpResourceFileResRelaEN.Memo = objRow[convFtpResourceFileResRela.Memo] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceFileResRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceFileResRelaEN);
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
List<clsvFtpResourceFileResRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFtpResourceFileResRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFtpResourceFileResRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFtpResourceFileResRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFtpResourceFileResRelaEN> arrObjLst = new List<clsvFtpResourceFileResRelaEN>(); 
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
	clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = new clsvFtpResourceFileResRelaEN();
try
{
objvFtpResourceFileResRelaEN.mId = Int32.Parse(objRow[convFtpResourceFileResRela.mId].ToString().Trim()); //mId
objvFtpResourceFileResRelaEN.FileResourceID = Int32.Parse(objRow[convFtpResourceFileResRela.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceFileResRelaEN.IpAddress = objRow[convFtpResourceFileResRela.IpAddress] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IpAddress].ToString().Trim(); //Ip地址
objvFtpResourceFileResRelaEN.FileDirName = objRow[convFtpResourceFileResRela.FileDirName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceFileResRelaEN.FileName = objRow[convFtpResourceFileResRela.FileName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileName].ToString().Trim(); //文件名称
objvFtpResourceFileResRelaEN.FileNameBak = objRow[convFtpResourceFileResRela.FileNameBak] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceFileResRelaEN.Extension = objRow[convFtpResourceFileResRela.Extension] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Extension].ToString().Trim(); //扩展名
objvFtpResourceFileResRelaEN.FileLength = objRow[convFtpResourceFileResRela.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.FileLength].ToString().Trim()); //文件长度
objvFtpResourceFileResRelaEN.FileType = objRow[convFtpResourceFileResRela.FileType] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileType].ToString().Trim(); //文件类型
objvFtpResourceFileResRelaEN.CreationTime = objRow[convFtpResourceFileResRela.CreationTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CreationTime].ToString().Trim(); //建立时间
objvFtpResourceFileResRelaEN.LastWriteTime = objRow[convFtpResourceFileResRela.LastWriteTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.LastWriteTime].ToString().Trim(); //最后修改时间
objvFtpResourceFileResRelaEN.CheckDateTime = objRow[convFtpResourceFileResRela.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceFileResRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.InUse].ToString().Trim()); //是否在用
objvFtpResourceFileResRelaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceFileResRelaEN.IdFtpResource = objRow[convFtpResourceFileResRela.IdFtpResource] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceFileResRelaEN.FuncModuleId = objRow[convFtpResourceFileResRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceFileResRelaEN.FuncModuleName = objRow[convFtpResourceFileResRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceFileResRelaEN.FuncModuleNameSim = objRow[convFtpResourceFileResRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceFileResRelaEN.OrderNum = objRow[convFtpResourceFileResRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.OrderNum].ToString().Trim()); //序号
objvFtpResourceFileResRelaEN.UpdDate = objRow[convFtpResourceFileResRela.UpdDate] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceFileResRelaEN.UpdUser = objRow[convFtpResourceFileResRela.UpdUser] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdUser].ToString().Trim(); //修改人
objvFtpResourceFileResRelaEN.Memo = objRow[convFtpResourceFileResRela.Memo] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceFileResRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceFileResRelaEN);
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
public static List<clsvFtpResourceFileResRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFtpResourceFileResRelaEN> arrObjLst = new List<clsvFtpResourceFileResRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = new clsvFtpResourceFileResRelaEN();
try
{
objvFtpResourceFileResRelaEN.mId = Int32.Parse(objRow[convFtpResourceFileResRela.mId].ToString().Trim()); //mId
objvFtpResourceFileResRelaEN.FileResourceID = Int32.Parse(objRow[convFtpResourceFileResRela.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceFileResRelaEN.IpAddress = objRow[convFtpResourceFileResRela.IpAddress] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IpAddress].ToString().Trim(); //Ip地址
objvFtpResourceFileResRelaEN.FileDirName = objRow[convFtpResourceFileResRela.FileDirName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceFileResRelaEN.FileName = objRow[convFtpResourceFileResRela.FileName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileName].ToString().Trim(); //文件名称
objvFtpResourceFileResRelaEN.FileNameBak = objRow[convFtpResourceFileResRela.FileNameBak] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceFileResRelaEN.Extension = objRow[convFtpResourceFileResRela.Extension] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Extension].ToString().Trim(); //扩展名
objvFtpResourceFileResRelaEN.FileLength = objRow[convFtpResourceFileResRela.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.FileLength].ToString().Trim()); //文件长度
objvFtpResourceFileResRelaEN.FileType = objRow[convFtpResourceFileResRela.FileType] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileType].ToString().Trim(); //文件类型
objvFtpResourceFileResRelaEN.CreationTime = objRow[convFtpResourceFileResRela.CreationTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CreationTime].ToString().Trim(); //建立时间
objvFtpResourceFileResRelaEN.LastWriteTime = objRow[convFtpResourceFileResRela.LastWriteTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.LastWriteTime].ToString().Trim(); //最后修改时间
objvFtpResourceFileResRelaEN.CheckDateTime = objRow[convFtpResourceFileResRela.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceFileResRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.InUse].ToString().Trim()); //是否在用
objvFtpResourceFileResRelaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceFileResRelaEN.IdFtpResource = objRow[convFtpResourceFileResRela.IdFtpResource] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceFileResRelaEN.FuncModuleId = objRow[convFtpResourceFileResRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceFileResRelaEN.FuncModuleName = objRow[convFtpResourceFileResRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceFileResRelaEN.FuncModuleNameSim = objRow[convFtpResourceFileResRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceFileResRelaEN.OrderNum = objRow[convFtpResourceFileResRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.OrderNum].ToString().Trim()); //序号
objvFtpResourceFileResRelaEN.UpdDate = objRow[convFtpResourceFileResRela.UpdDate] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceFileResRelaEN.UpdUser = objRow[convFtpResourceFileResRela.UpdUser] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdUser].ToString().Trim(); //修改人
objvFtpResourceFileResRelaEN.Memo = objRow[convFtpResourceFileResRela.Memo] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceFileResRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceFileResRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFtpResourceFileResRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFtpResourceFileResRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFtpResourceFileResRelaEN> arrObjLst = new List<clsvFtpResourceFileResRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = new clsvFtpResourceFileResRelaEN();
try
{
objvFtpResourceFileResRelaEN.mId = Int32.Parse(objRow[convFtpResourceFileResRela.mId].ToString().Trim()); //mId
objvFtpResourceFileResRelaEN.FileResourceID = Int32.Parse(objRow[convFtpResourceFileResRela.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceFileResRelaEN.IpAddress = objRow[convFtpResourceFileResRela.IpAddress] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IpAddress].ToString().Trim(); //Ip地址
objvFtpResourceFileResRelaEN.FileDirName = objRow[convFtpResourceFileResRela.FileDirName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceFileResRelaEN.FileName = objRow[convFtpResourceFileResRela.FileName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileName].ToString().Trim(); //文件名称
objvFtpResourceFileResRelaEN.FileNameBak = objRow[convFtpResourceFileResRela.FileNameBak] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceFileResRelaEN.Extension = objRow[convFtpResourceFileResRela.Extension] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Extension].ToString().Trim(); //扩展名
objvFtpResourceFileResRelaEN.FileLength = objRow[convFtpResourceFileResRela.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.FileLength].ToString().Trim()); //文件长度
objvFtpResourceFileResRelaEN.FileType = objRow[convFtpResourceFileResRela.FileType] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileType].ToString().Trim(); //文件类型
objvFtpResourceFileResRelaEN.CreationTime = objRow[convFtpResourceFileResRela.CreationTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CreationTime].ToString().Trim(); //建立时间
objvFtpResourceFileResRelaEN.LastWriteTime = objRow[convFtpResourceFileResRela.LastWriteTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.LastWriteTime].ToString().Trim(); //最后修改时间
objvFtpResourceFileResRelaEN.CheckDateTime = objRow[convFtpResourceFileResRela.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceFileResRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.InUse].ToString().Trim()); //是否在用
objvFtpResourceFileResRelaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceFileResRelaEN.IdFtpResource = objRow[convFtpResourceFileResRela.IdFtpResource] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceFileResRelaEN.FuncModuleId = objRow[convFtpResourceFileResRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceFileResRelaEN.FuncModuleName = objRow[convFtpResourceFileResRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceFileResRelaEN.FuncModuleNameSim = objRow[convFtpResourceFileResRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceFileResRelaEN.OrderNum = objRow[convFtpResourceFileResRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.OrderNum].ToString().Trim()); //序号
objvFtpResourceFileResRelaEN.UpdDate = objRow[convFtpResourceFileResRela.UpdDate] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceFileResRelaEN.UpdUser = objRow[convFtpResourceFileResRela.UpdUser] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdUser].ToString().Trim(); //修改人
objvFtpResourceFileResRelaEN.Memo = objRow[convFtpResourceFileResRela.Memo] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceFileResRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceFileResRelaEN);
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
public static List<clsvFtpResourceFileResRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFtpResourceFileResRelaEN> arrObjLst = new List<clsvFtpResourceFileResRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = new clsvFtpResourceFileResRelaEN();
try
{
objvFtpResourceFileResRelaEN.mId = Int32.Parse(objRow[convFtpResourceFileResRela.mId].ToString().Trim()); //mId
objvFtpResourceFileResRelaEN.FileResourceID = Int32.Parse(objRow[convFtpResourceFileResRela.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceFileResRelaEN.IpAddress = objRow[convFtpResourceFileResRela.IpAddress] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IpAddress].ToString().Trim(); //Ip地址
objvFtpResourceFileResRelaEN.FileDirName = objRow[convFtpResourceFileResRela.FileDirName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceFileResRelaEN.FileName = objRow[convFtpResourceFileResRela.FileName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileName].ToString().Trim(); //文件名称
objvFtpResourceFileResRelaEN.FileNameBak = objRow[convFtpResourceFileResRela.FileNameBak] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceFileResRelaEN.Extension = objRow[convFtpResourceFileResRela.Extension] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Extension].ToString().Trim(); //扩展名
objvFtpResourceFileResRelaEN.FileLength = objRow[convFtpResourceFileResRela.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.FileLength].ToString().Trim()); //文件长度
objvFtpResourceFileResRelaEN.FileType = objRow[convFtpResourceFileResRela.FileType] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileType].ToString().Trim(); //文件类型
objvFtpResourceFileResRelaEN.CreationTime = objRow[convFtpResourceFileResRela.CreationTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CreationTime].ToString().Trim(); //建立时间
objvFtpResourceFileResRelaEN.LastWriteTime = objRow[convFtpResourceFileResRela.LastWriteTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.LastWriteTime].ToString().Trim(); //最后修改时间
objvFtpResourceFileResRelaEN.CheckDateTime = objRow[convFtpResourceFileResRela.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceFileResRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.InUse].ToString().Trim()); //是否在用
objvFtpResourceFileResRelaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceFileResRelaEN.IdFtpResource = objRow[convFtpResourceFileResRela.IdFtpResource] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceFileResRelaEN.FuncModuleId = objRow[convFtpResourceFileResRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceFileResRelaEN.FuncModuleName = objRow[convFtpResourceFileResRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceFileResRelaEN.FuncModuleNameSim = objRow[convFtpResourceFileResRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceFileResRelaEN.OrderNum = objRow[convFtpResourceFileResRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.OrderNum].ToString().Trim()); //序号
objvFtpResourceFileResRelaEN.UpdDate = objRow[convFtpResourceFileResRela.UpdDate] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceFileResRelaEN.UpdUser = objRow[convFtpResourceFileResRela.UpdUser] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdUser].ToString().Trim(); //修改人
objvFtpResourceFileResRelaEN.Memo = objRow[convFtpResourceFileResRela.Memo] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceFileResRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceFileResRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFtpResourceFileResRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFtpResourceFileResRelaEN> arrObjLst = new List<clsvFtpResourceFileResRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = new clsvFtpResourceFileResRelaEN();
try
{
objvFtpResourceFileResRelaEN.mId = Int32.Parse(objRow[convFtpResourceFileResRela.mId].ToString().Trim()); //mId
objvFtpResourceFileResRelaEN.FileResourceID = Int32.Parse(objRow[convFtpResourceFileResRela.FileResourceID].ToString().Trim()); //FileResourceID
objvFtpResourceFileResRelaEN.IpAddress = objRow[convFtpResourceFileResRela.IpAddress] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IpAddress].ToString().Trim(); //Ip地址
objvFtpResourceFileResRelaEN.FileDirName = objRow[convFtpResourceFileResRela.FileDirName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileDirName].ToString().Trim(); //文件目录名
objvFtpResourceFileResRelaEN.FileName = objRow[convFtpResourceFileResRela.FileName] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileName].ToString().Trim(); //文件名称
objvFtpResourceFileResRelaEN.FileNameBak = objRow[convFtpResourceFileResRela.FileNameBak] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileNameBak].ToString().Trim(); //FileName_Bak
objvFtpResourceFileResRelaEN.Extension = objRow[convFtpResourceFileResRela.Extension] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Extension].ToString().Trim(); //扩展名
objvFtpResourceFileResRelaEN.FileLength = objRow[convFtpResourceFileResRela.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.FileLength].ToString().Trim()); //文件长度
objvFtpResourceFileResRelaEN.FileType = objRow[convFtpResourceFileResRela.FileType] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FileType].ToString().Trim(); //文件类型
objvFtpResourceFileResRelaEN.CreationTime = objRow[convFtpResourceFileResRela.CreationTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CreationTime].ToString().Trim(); //建立时间
objvFtpResourceFileResRelaEN.LastWriteTime = objRow[convFtpResourceFileResRela.LastWriteTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.LastWriteTime].ToString().Trim(); //最后修改时间
objvFtpResourceFileResRelaEN.CheckDateTime = objRow[convFtpResourceFileResRela.CheckDateTime] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.CheckDateTime].ToString().Trim(); //CheckDateTime
objvFtpResourceFileResRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.InUse].ToString().Trim()); //是否在用
objvFtpResourceFileResRelaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convFtpResourceFileResRela.IsExistFile].ToString().Trim()); //是否存在文件
objvFtpResourceFileResRelaEN.IdFtpResource = objRow[convFtpResourceFileResRela.IdFtpResource] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvFtpResourceFileResRelaEN.FuncModuleId = objRow[convFtpResourceFileResRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvFtpResourceFileResRelaEN.FuncModuleName = objRow[convFtpResourceFileResRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvFtpResourceFileResRelaEN.FuncModuleNameSim = objRow[convFtpResourceFileResRela.FuncModuleNameSim] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvFtpResourceFileResRelaEN.OrderNum = objRow[convFtpResourceFileResRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFtpResourceFileResRela.OrderNum].ToString().Trim()); //序号
objvFtpResourceFileResRelaEN.UpdDate = objRow[convFtpResourceFileResRela.UpdDate] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdDate].ToString().Trim(); //修改日期
objvFtpResourceFileResRelaEN.UpdUser = objRow[convFtpResourceFileResRela.UpdUser] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.UpdUser].ToString().Trim(); //修改人
objvFtpResourceFileResRelaEN.Memo = objRow[convFtpResourceFileResRela.Memo] == DBNull.Value ? null : objRow[convFtpResourceFileResRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFtpResourceFileResRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFtpResourceFileResRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFtpResourceFileResRela(ref clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN)
{
bool bolResult = vFtpResourceFileResRelaDA.GetvFtpResourceFileResRela(ref objvFtpResourceFileResRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFtpResourceFileResRelaEN GetObjBymId(long lngmId)
{
clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = vFtpResourceFileResRelaDA.GetObjBymId(lngmId);
return objvFtpResourceFileResRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFtpResourceFileResRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = vFtpResourceFileResRelaDA.GetFirstObj(strWhereCond);
 return objvFtpResourceFileResRelaEN;
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
public static clsvFtpResourceFileResRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = vFtpResourceFileResRelaDA.GetObjByDataRow(objRow);
 return objvFtpResourceFileResRelaEN;
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
public static clsvFtpResourceFileResRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN = vFtpResourceFileResRelaDA.GetObjByDataRow(objRow);
 return objvFtpResourceFileResRelaEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvFtpResourceFileResRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFtpResourceFileResRelaEN GetObjBymIdFromList(long lngmId, List<clsvFtpResourceFileResRelaEN> lstvFtpResourceFileResRelaObjLst)
{
foreach (clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN in lstvFtpResourceFileResRelaObjLst)
{
if (objvFtpResourceFileResRelaEN.mId == lngmId)
{
return objvFtpResourceFileResRelaEN;
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
 long lngmId;
 try
 {
 lngmId = new clsvFtpResourceFileResRelaDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vFtpResourceFileResRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vFtpResourceFileResRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vFtpResourceFileResRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvFtpResourceFileResRelaDA.IsExistTable();
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
 bolIsExist = vFtpResourceFileResRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvFtpResourceFileResRelaENS">源对象</param>
 /// <param name = "objvFtpResourceFileResRelaENT">目标对象</param>
 public static void CopyTo(clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaENS, clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaENT)
{
try
{
objvFtpResourceFileResRelaENT.mId = objvFtpResourceFileResRelaENS.mId; //mId
objvFtpResourceFileResRelaENT.FileResourceID = objvFtpResourceFileResRelaENS.FileResourceID; //FileResourceID
objvFtpResourceFileResRelaENT.IpAddress = objvFtpResourceFileResRelaENS.IpAddress; //Ip地址
objvFtpResourceFileResRelaENT.FileDirName = objvFtpResourceFileResRelaENS.FileDirName; //文件目录名
objvFtpResourceFileResRelaENT.FileName = objvFtpResourceFileResRelaENS.FileName; //文件名称
objvFtpResourceFileResRelaENT.FileNameBak = objvFtpResourceFileResRelaENS.FileNameBak; //FileName_Bak
objvFtpResourceFileResRelaENT.Extension = objvFtpResourceFileResRelaENS.Extension; //扩展名
objvFtpResourceFileResRelaENT.FileLength = objvFtpResourceFileResRelaENS.FileLength; //文件长度
objvFtpResourceFileResRelaENT.FileType = objvFtpResourceFileResRelaENS.FileType; //文件类型
objvFtpResourceFileResRelaENT.CreationTime = objvFtpResourceFileResRelaENS.CreationTime; //建立时间
objvFtpResourceFileResRelaENT.LastWriteTime = objvFtpResourceFileResRelaENS.LastWriteTime; //最后修改时间
objvFtpResourceFileResRelaENT.CheckDateTime = objvFtpResourceFileResRelaENS.CheckDateTime; //CheckDateTime
objvFtpResourceFileResRelaENT.InUse = objvFtpResourceFileResRelaENS.InUse; //是否在用
objvFtpResourceFileResRelaENT.IsExistFile = objvFtpResourceFileResRelaENS.IsExistFile; //是否存在文件
objvFtpResourceFileResRelaENT.IdFtpResource = objvFtpResourceFileResRelaENS.IdFtpResource; //FTP资源流水号
objvFtpResourceFileResRelaENT.FuncModuleId = objvFtpResourceFileResRelaENS.FuncModuleId; //功能模块Id
objvFtpResourceFileResRelaENT.FuncModuleName = objvFtpResourceFileResRelaENS.FuncModuleName; //功能模块名称
objvFtpResourceFileResRelaENT.FuncModuleNameSim = objvFtpResourceFileResRelaENS.FuncModuleNameSim; //功能模块简称
objvFtpResourceFileResRelaENT.OrderNum = objvFtpResourceFileResRelaENS.OrderNum; //序号
objvFtpResourceFileResRelaENT.UpdDate = objvFtpResourceFileResRelaENS.UpdDate; //修改日期
objvFtpResourceFileResRelaENT.UpdUser = objvFtpResourceFileResRelaENS.UpdUser; //修改人
objvFtpResourceFileResRelaENT.Memo = objvFtpResourceFileResRelaENS.Memo; //备注
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
 /// <param name = "objvFtpResourceFileResRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN)
{
try
{
objvFtpResourceFileResRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFtpResourceFileResRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFtpResourceFileResRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.mId = objvFtpResourceFileResRelaEN.mId; //mId
}
if (arrFldSet.Contains(convFtpResourceFileResRela.FileResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.FileResourceID = objvFtpResourceFileResRelaEN.FileResourceID; //FileResourceID
}
if (arrFldSet.Contains(convFtpResourceFileResRela.IpAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.IpAddress = objvFtpResourceFileResRelaEN.IpAddress == "[null]" ? null :  objvFtpResourceFileResRelaEN.IpAddress; //Ip地址
}
if (arrFldSet.Contains(convFtpResourceFileResRela.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.FileDirName = objvFtpResourceFileResRelaEN.FileDirName == "[null]" ? null :  objvFtpResourceFileResRelaEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convFtpResourceFileResRela.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.FileName = objvFtpResourceFileResRelaEN.FileName == "[null]" ? null :  objvFtpResourceFileResRelaEN.FileName; //文件名称
}
if (arrFldSet.Contains(convFtpResourceFileResRela.FileNameBak, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.FileNameBak = objvFtpResourceFileResRelaEN.FileNameBak == "[null]" ? null :  objvFtpResourceFileResRelaEN.FileNameBak; //FileName_Bak
}
if (arrFldSet.Contains(convFtpResourceFileResRela.Extension, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.Extension = objvFtpResourceFileResRelaEN.Extension == "[null]" ? null :  objvFtpResourceFileResRelaEN.Extension; //扩展名
}
if (arrFldSet.Contains(convFtpResourceFileResRela.FileLength, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.FileLength = objvFtpResourceFileResRelaEN.FileLength; //文件长度
}
if (arrFldSet.Contains(convFtpResourceFileResRela.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.FileType = objvFtpResourceFileResRelaEN.FileType == "[null]" ? null :  objvFtpResourceFileResRelaEN.FileType; //文件类型
}
if (arrFldSet.Contains(convFtpResourceFileResRela.CreationTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.CreationTime = objvFtpResourceFileResRelaEN.CreationTime == "[null]" ? null :  objvFtpResourceFileResRelaEN.CreationTime; //建立时间
}
if (arrFldSet.Contains(convFtpResourceFileResRela.LastWriteTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.LastWriteTime = objvFtpResourceFileResRelaEN.LastWriteTime == "[null]" ? null :  objvFtpResourceFileResRelaEN.LastWriteTime; //最后修改时间
}
if (arrFldSet.Contains(convFtpResourceFileResRela.CheckDateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.CheckDateTime = objvFtpResourceFileResRelaEN.CheckDateTime == "[null]" ? null :  objvFtpResourceFileResRelaEN.CheckDateTime; //CheckDateTime
}
if (arrFldSet.Contains(convFtpResourceFileResRela.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.InUse = objvFtpResourceFileResRelaEN.InUse; //是否在用
}
if (arrFldSet.Contains(convFtpResourceFileResRela.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.IsExistFile = objvFtpResourceFileResRelaEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convFtpResourceFileResRela.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.IdFtpResource = objvFtpResourceFileResRelaEN.IdFtpResource == "[null]" ? null :  objvFtpResourceFileResRelaEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convFtpResourceFileResRela.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.FuncModuleId = objvFtpResourceFileResRelaEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convFtpResourceFileResRela.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.FuncModuleName = objvFtpResourceFileResRelaEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convFtpResourceFileResRela.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.FuncModuleNameSim = objvFtpResourceFileResRelaEN.FuncModuleNameSim == "[null]" ? null :  objvFtpResourceFileResRelaEN.FuncModuleNameSim; //功能模块简称
}
if (arrFldSet.Contains(convFtpResourceFileResRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.OrderNum = objvFtpResourceFileResRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convFtpResourceFileResRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.UpdDate = objvFtpResourceFileResRelaEN.UpdDate == "[null]" ? null :  objvFtpResourceFileResRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFtpResourceFileResRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.UpdUser = objvFtpResourceFileResRelaEN.UpdUser == "[null]" ? null :  objvFtpResourceFileResRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convFtpResourceFileResRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFtpResourceFileResRelaEN.Memo = objvFtpResourceFileResRelaEN.Memo == "[null]" ? null :  objvFtpResourceFileResRelaEN.Memo; //备注
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
 /// <param name = "objvFtpResourceFileResRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN)
{
try
{
if (objvFtpResourceFileResRelaEN.IpAddress == "[null]") objvFtpResourceFileResRelaEN.IpAddress = null; //Ip地址
if (objvFtpResourceFileResRelaEN.FileDirName == "[null]") objvFtpResourceFileResRelaEN.FileDirName = null; //文件目录名
if (objvFtpResourceFileResRelaEN.FileName == "[null]") objvFtpResourceFileResRelaEN.FileName = null; //文件名称
if (objvFtpResourceFileResRelaEN.FileNameBak == "[null]") objvFtpResourceFileResRelaEN.FileNameBak = null; //FileName_Bak
if (objvFtpResourceFileResRelaEN.Extension == "[null]") objvFtpResourceFileResRelaEN.Extension = null; //扩展名
if (objvFtpResourceFileResRelaEN.FileType == "[null]") objvFtpResourceFileResRelaEN.FileType = null; //文件类型
if (objvFtpResourceFileResRelaEN.CreationTime == "[null]") objvFtpResourceFileResRelaEN.CreationTime = null; //建立时间
if (objvFtpResourceFileResRelaEN.LastWriteTime == "[null]") objvFtpResourceFileResRelaEN.LastWriteTime = null; //最后修改时间
if (objvFtpResourceFileResRelaEN.CheckDateTime == "[null]") objvFtpResourceFileResRelaEN.CheckDateTime = null; //CheckDateTime
if (objvFtpResourceFileResRelaEN.IdFtpResource == "[null]") objvFtpResourceFileResRelaEN.IdFtpResource = null; //FTP资源流水号
if (objvFtpResourceFileResRelaEN.FuncModuleNameSim == "[null]") objvFtpResourceFileResRelaEN.FuncModuleNameSim = null; //功能模块简称
if (objvFtpResourceFileResRelaEN.UpdDate == "[null]") objvFtpResourceFileResRelaEN.UpdDate = null; //修改日期
if (objvFtpResourceFileResRelaEN.UpdUser == "[null]") objvFtpResourceFileResRelaEN.UpdUser = null; //修改人
if (objvFtpResourceFileResRelaEN.Memo == "[null]") objvFtpResourceFileResRelaEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaEN)
{
 vFtpResourceFileResRelaDA.CheckProperty4Condition(objvFtpResourceFileResRelaEN);
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
if (clsFileResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileResourceBL没有刷新缓存机制(clsFileResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceFileResRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceFileResRelaBL没有刷新缓存机制(clsFtpResourceFileResRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvFtpResourceFileResRelaObjLstCache == null)
//{
//arrvFtpResourceFileResRelaObjLstCache = vFtpResourceFileResRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFtpResourceFileResRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFtpResourceFileResRelaEN._CurrTabName);
List<clsvFtpResourceFileResRelaEN> arrvFtpResourceFileResRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFtpResourceFileResRelaEN> arrvFtpResourceFileResRelaObjLst_Sel =
arrvFtpResourceFileResRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvFtpResourceFileResRelaObjLst_Sel.Count() == 0)
{
   clsvFtpResourceFileResRelaEN obj = clsvFtpResourceFileResRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFtpResourceFileResRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFtpResourceFileResRelaEN> GetAllvFtpResourceFileResRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvFtpResourceFileResRelaEN> arrvFtpResourceFileResRelaObjLstCache = GetObjLstCache(); 
return arrvFtpResourceFileResRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFtpResourceFileResRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFtpResourceFileResRelaEN._CurrTabName);
List<clsvFtpResourceFileResRelaEN> arrvFtpResourceFileResRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFtpResourceFileResRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvFtpResourceFileResRelaEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convFtpResourceFileResRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFtpResourceFileResRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFtpResourceFileResRela.AttributeName));
throw new Exception(strMsg);
}
var objvFtpResourceFileResRela = clsvFtpResourceFileResRelaBL.GetObjBymIdCache(lngmId);
if (objvFtpResourceFileResRela == null) return "";
return objvFtpResourceFileResRela[strOutFldName].ToString();
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
int intRecCount = clsvFtpResourceFileResRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvFtpResourceFileResRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFtpResourceFileResRelaDA.GetRecCount();
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
int intRecCount = clsvFtpResourceFileResRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFtpResourceFileResRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFtpResourceFileResRelaEN objvFtpResourceFileResRelaCond)
{
List<clsvFtpResourceFileResRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFtpResourceFileResRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFtpResourceFileResRela.AttributeName)
{
if (objvFtpResourceFileResRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFtpResourceFileResRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFtpResourceFileResRelaCond[strFldName].ToString());
}
else
{
if (objvFtpResourceFileResRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFtpResourceFileResRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFtpResourceFileResRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFtpResourceFileResRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFtpResourceFileResRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFtpResourceFileResRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFtpResourceFileResRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFtpResourceFileResRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFtpResourceFileResRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFtpResourceFileResRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFtpResourceFileResRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFtpResourceFileResRelaCond[strFldName]));
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
 List<string> arrList = clsvFtpResourceFileResRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFtpResourceFileResRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFtpResourceFileResRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}