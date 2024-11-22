﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFileResourceWApi
 表名:FileResource(01120373)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:29
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理
 模块英文名:ResourceMan
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
public static class clsFileResourceWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileResourceEN SetFileResourceID(this clsFileResourceEN objFileResourceEN, long lngFileResourceID, string strComparisonOp="")
	{
objFileResourceEN.FileResourceID = lngFileResourceID; //FileResourceID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.FileResourceID) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.FileResourceID, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.FileResourceID] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileResourceEN SetIpAddress(this clsFileResourceEN objFileResourceEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIpAddress, 50, conFileResource.IpAddress);
objFileResourceEN.IpAddress = strIpAddress; //Ip地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.IpAddress) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.IpAddress, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.IpAddress] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileResourceEN SetFileDirName(this clsFileResourceEN objFileResourceEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileDirName, conFileResource.FileDirName);
clsCheckSql.CheckFieldLen(strFileDirName, 200, conFileResource.FileDirName);
objFileResourceEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.FileDirName) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.FileDirName, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.FileDirName] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileResourceEN SetFileName(this clsFileResourceEN objFileResourceEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, conFileResource.FileName);
clsCheckSql.CheckFieldLen(strFileName, 500, conFileResource.FileName);
objFileResourceEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.FileName) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.FileName, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.FileName] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileResourceEN SetFileName_Bak(this clsFileResourceEN objFileResourceEN, string strFileName_Bak, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName_Bak, 500, conFileResource.FileName_Bak);
objFileResourceEN.FileName_Bak = strFileName_Bak; //FileName_Bak
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.FileName_Bak) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.FileName_Bak, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.FileName_Bak] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileResourceEN SetExtension(this clsFileResourceEN objFileResourceEN, string strExtension, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExtension, 10, conFileResource.Extension);
objFileResourceEN.Extension = strExtension; //扩展名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.Extension) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.Extension, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.Extension] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileResourceEN SetFileLength(this clsFileResourceEN objFileResourceEN, long lngFileLength, string strComparisonOp="")
	{
objFileResourceEN.FileLength = lngFileLength; //文件长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.FileLength) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.FileLength, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.FileLength] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileResourceEN SetFileType(this clsFileResourceEN objFileResourceEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, conFileResource.FileType);
objFileResourceEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.FileType) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.FileType, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.FileType] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileResourceEN SetCreationTime(this clsFileResourceEN objFileResourceEN, string strCreationTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreationTime, 20, conFileResource.CreationTime);
objFileResourceEN.CreationTime = strCreationTime; //建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.CreationTime) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.CreationTime, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.CreationTime] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileResourceEN SetLastWriteTime(this clsFileResourceEN objFileResourceEN, string strLastWriteTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLastWriteTime, 20, conFileResource.LastWriteTime);
objFileResourceEN.LastWriteTime = strLastWriteTime; //最后修改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.LastWriteTime) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.LastWriteTime, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.LastWriteTime] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileResourceEN SetCheckDateTime(this clsFileResourceEN objFileResourceEN, string strCheckDateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckDateTime, 30, conFileResource.CheckDateTime);
objFileResourceEN.CheckDateTime = strCheckDateTime; //CheckDateTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.CheckDateTime) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.CheckDateTime, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.CheckDateTime] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileResourceEN Setid_FtpResource(this clsFileResourceEN objFileResourceEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, conFileResource.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, conFileResource.id_FtpResource);
objFileResourceEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.id_FtpResource) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.id_FtpResource, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.id_FtpResource] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileResourceEN SetInUse(this clsFileResourceEN objFileResourceEN, bool bolInUse, string strComparisonOp="")
	{
objFileResourceEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.InUse) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.InUse, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.InUse] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileResourceEN SetIsExistFile(this clsFileResourceEN objFileResourceEN, bool bolIsExistFile, string strComparisonOp="")
	{
objFileResourceEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.IsExistFile) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.IsExistFile, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.IsExistFile] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileResourceEN SetUpdDate(this clsFileResourceEN objFileResourceEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFileResource.UpdDate);
objFileResourceEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.UpdDate) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.UpdDate, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.UpdDate] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileResourceEN SetUpdUser(this clsFileResourceEN objFileResourceEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFileResource.UpdUser);
objFileResourceEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.UpdUser) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.UpdUser, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.UpdUser] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileResourceEN SetMemo(this clsFileResourceEN objFileResourceEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFileResource.Memo);
objFileResourceEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.Memo) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.Memo, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.Memo] = strComparisonOp;
}
}
return objFileResourceEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFileResourceEN objFileResource_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFileResource_Cond.IsUpdated(conFileResource.FileResourceID) == true)
{
string strComparisonOp_FileResourceID = objFileResource_Cond.dicFldComparisonOp[conFileResource.FileResourceID];
strWhereCond += string.Format(" And {0} {2} {1}", conFileResource.FileResourceID, objFileResource_Cond.FileResourceID, strComparisonOp_FileResourceID);
}
if (objFileResource_Cond.IsUpdated(conFileResource.IpAddress) == true)
{
string strComparisonOp_IpAddress = objFileResource_Cond.dicFldComparisonOp[conFileResource.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.IpAddress, objFileResource_Cond.IpAddress, strComparisonOp_IpAddress);
}
if (objFileResource_Cond.IsUpdated(conFileResource.FileDirName) == true)
{
string strComparisonOp_FileDirName = objFileResource_Cond.dicFldComparisonOp[conFileResource.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.FileDirName, objFileResource_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objFileResource_Cond.IsUpdated(conFileResource.FileName) == true)
{
string strComparisonOp_FileName = objFileResource_Cond.dicFldComparisonOp[conFileResource.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.FileName, objFileResource_Cond.FileName, strComparisonOp_FileName);
}
if (objFileResource_Cond.IsUpdated(conFileResource.FileName_Bak) == true)
{
string strComparisonOp_FileName_Bak = objFileResource_Cond.dicFldComparisonOp[conFileResource.FileName_Bak];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.FileName_Bak, objFileResource_Cond.FileName_Bak, strComparisonOp_FileName_Bak);
}
if (objFileResource_Cond.IsUpdated(conFileResource.Extension) == true)
{
string strComparisonOp_Extension = objFileResource_Cond.dicFldComparisonOp[conFileResource.Extension];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.Extension, objFileResource_Cond.Extension, strComparisonOp_Extension);
}
if (objFileResource_Cond.IsUpdated(conFileResource.FileLength) == true)
{
string strComparisonOp_FileLength = objFileResource_Cond.dicFldComparisonOp[conFileResource.FileLength];
strWhereCond += string.Format(" And {0} {2} {1}", conFileResource.FileLength, objFileResource_Cond.FileLength, strComparisonOp_FileLength);
}
if (objFileResource_Cond.IsUpdated(conFileResource.FileType) == true)
{
string strComparisonOp_FileType = objFileResource_Cond.dicFldComparisonOp[conFileResource.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.FileType, objFileResource_Cond.FileType, strComparisonOp_FileType);
}
if (objFileResource_Cond.IsUpdated(conFileResource.CreationTime) == true)
{
string strComparisonOp_CreationTime = objFileResource_Cond.dicFldComparisonOp[conFileResource.CreationTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.CreationTime, objFileResource_Cond.CreationTime, strComparisonOp_CreationTime);
}
if (objFileResource_Cond.IsUpdated(conFileResource.LastWriteTime) == true)
{
string strComparisonOp_LastWriteTime = objFileResource_Cond.dicFldComparisonOp[conFileResource.LastWriteTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.LastWriteTime, objFileResource_Cond.LastWriteTime, strComparisonOp_LastWriteTime);
}
if (objFileResource_Cond.IsUpdated(conFileResource.CheckDateTime) == true)
{
string strComparisonOp_CheckDateTime = objFileResource_Cond.dicFldComparisonOp[conFileResource.CheckDateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.CheckDateTime, objFileResource_Cond.CheckDateTime, strComparisonOp_CheckDateTime);
}
if (objFileResource_Cond.IsUpdated(conFileResource.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objFileResource_Cond.dicFldComparisonOp[conFileResource.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.id_FtpResource, objFileResource_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objFileResource_Cond.IsUpdated(conFileResource.InUse) == true)
{
if (objFileResource_Cond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFileResource.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFileResource.InUse);
}
}
if (objFileResource_Cond.IsUpdated(conFileResource.IsExistFile) == true)
{
if (objFileResource_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFileResource.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFileResource.IsExistFile);
}
}
if (objFileResource_Cond.IsUpdated(conFileResource.UpdDate) == true)
{
string strComparisonOp_UpdDate = objFileResource_Cond.dicFldComparisonOp[conFileResource.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.UpdDate, objFileResource_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objFileResource_Cond.IsUpdated(conFileResource.UpdUser) == true)
{
string strComparisonOp_UpdUser = objFileResource_Cond.dicFldComparisonOp[conFileResource.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.UpdUser, objFileResource_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objFileResource_Cond.IsUpdated(conFileResource.Memo) == true)
{
string strComparisonOp_Memo = objFileResource_Cond.dicFldComparisonOp[conFileResource.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.Memo, objFileResource_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFileResourceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFileResourceEN objFileResourceEN)
{
 if (objFileResourceEN.FileResourceID == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFileResourceEN.sf_UpdFldSetStr = objFileResourceEN.getsf_UpdFldSetStr();
clsFileResourceWApi.CheckPropertyNew(objFileResourceEN); 
bool bolResult = clsFileResourceWApi.UpdateRecord(objFileResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileResourceWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FileResource(文件资源), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFileResourceEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_IpAddress_FileName(this clsFileResourceEN objFileResourceEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFileResourceEN == null) return "";
if (objFileResourceEN.FileResourceID == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objFileResourceEN.IpAddress);
 sbCondition.AppendFormat(" and FileName = '{0}'", objFileResourceEN.FileName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FileResourceID !=  {0}", objFileResourceEN.FileResourceID);
 sbCondition.AppendFormat(" and IpAddress = '{0}'", objFileResourceEN.IpAddress);
 sbCondition.AppendFormat(" and FileName = '{0}'", objFileResourceEN.FileName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFileResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFileResourceEN objFileResourceEN)
{
try
{
clsFileResourceWApi.CheckPropertyNew(objFileResourceEN); 
bool bolResult = clsFileResourceWApi.AddNewRecord(objFileResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileResourceWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objFileResourceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFileResourceEN objFileResourceEN, string strWhereCond)
{
try
{
clsFileResourceWApi.CheckPropertyNew(objFileResourceEN); 
bool bolResult = clsFileResourceWApi.UpdateWithCondition(objFileResourceEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileResourceWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 文件资源(FileResource)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFileResourceWApi
{
private static readonly string mstrApiControllerName = "FileResourceApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsFileResourceWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFileResourceEN objFileResourceEN)
{
if (!Object.Equals(null, objFileResourceEN.IpAddress) && GetStrLen(objFileResourceEN.IpAddress) > 50)
{
 throw new Exception("字段[Ip地址]的长度不能超过50!");
}
if (!Object.Equals(null, objFileResourceEN.FileDirName) && GetStrLen(objFileResourceEN.FileDirName) > 200)
{
 throw new Exception("字段[文件目录名]的长度不能超过200!");
}
if (!Object.Equals(null, objFileResourceEN.FileName) && GetStrLen(objFileResourceEN.FileName) > 500)
{
 throw new Exception("字段[文件名称]的长度不能超过500!");
}
if (!Object.Equals(null, objFileResourceEN.FileName_Bak) && GetStrLen(objFileResourceEN.FileName_Bak) > 500)
{
 throw new Exception("字段[FileName_Bak]的长度不能超过500!");
}
if (!Object.Equals(null, objFileResourceEN.Extension) && GetStrLen(objFileResourceEN.Extension) > 10)
{
 throw new Exception("字段[扩展名]的长度不能超过10!");
}
if (!Object.Equals(null, objFileResourceEN.FileType) && GetStrLen(objFileResourceEN.FileType) > 30)
{
 throw new Exception("字段[文件类型]的长度不能超过30!");
}
if (!Object.Equals(null, objFileResourceEN.CreationTime) && GetStrLen(objFileResourceEN.CreationTime) > 20)
{
 throw new Exception("字段[建立时间]的长度不能超过20!");
}
if (!Object.Equals(null, objFileResourceEN.LastWriteTime) && GetStrLen(objFileResourceEN.LastWriteTime) > 20)
{
 throw new Exception("字段[最后修改时间]的长度不能超过20!");
}
if (!Object.Equals(null, objFileResourceEN.CheckDateTime) && GetStrLen(objFileResourceEN.CheckDateTime) > 30)
{
 throw new Exception("字段[CheckDateTime]的长度不能超过30!");
}
if (!Object.Equals(null, objFileResourceEN.id_FtpResource) && GetStrLen(objFileResourceEN.id_FtpResource) > 8)
{
 throw new Exception("字段[FTP资源流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objFileResourceEN.UpdDate) && GetStrLen(objFileResourceEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objFileResourceEN.UpdUser) && GetStrLen(objFileResourceEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objFileResourceEN.Memo) && GetStrLen(objFileResourceEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objFileResourceEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngFileResourceID">表关键字</param>
 /// <returns>表对象</returns>
public static clsFileResourceEN GetObjByFileResourceID(long lngFileResourceID)
{
string strAction = "GetObjByFileResourceID";
string strErrMsg = string.Empty;
string strResult = "";
clsFileResourceEN objFileResourceEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["FileResourceID"] = lngFileResourceID.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objFileResourceEN = JsonConvert.DeserializeObject<clsFileResourceEN>((string)jobjReturn["ReturnObj"]);
return objFileResourceEN;
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
 /// <param name = "lngFileResourceID">表关键字</param>
 /// <returns>表对象</returns>
public static clsFileResourceEN GetObjByFileResourceID_WA_Cache(long lngFileResourceID)
{
string strAction = "GetObjByFileResourceID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsFileResourceEN objFileResourceEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["FileResourceID"] = lngFileResourceID.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objFileResourceEN = JsonConvert.DeserializeObject<clsFileResourceEN>((string)jobjReturn["ReturnObj"]);
return objFileResourceEN;
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
public static clsFileResourceEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsFileResourceEN objFileResourceEN = null;
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
objFileResourceEN = JsonConvert.DeserializeObject<clsFileResourceEN>((string)jobjReturn["ReturnObj"]);
return objFileResourceEN;
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
 /// <param name = "lngFileResourceID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFileResourceEN GetObjByFileResourceID_Cache(long lngFileResourceID)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsFileResourceEN._CurrTabName_S);
List<clsFileResourceEN> arrFileResourceObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsFileResourceEN> arrFileResourceObjLst_Sel =
from objFileResourceEN in arrFileResourceObjLst_Cache
where objFileResourceEN.FileResourceID == lngFileResourceID
select objFileResourceEN;
if (arrFileResourceObjLst_Sel.Count() == 0)
{
   clsFileResourceEN obj = clsFileResourceWApi.GetObjByFileResourceID(lngFileResourceID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrFileResourceObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFileResourceEN> GetObjLst(string strWhereCond)
{
 List<clsFileResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFileResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFileResourceEN> GetObjLstByFileResourceIDLst(List<long> arrFileResourceID)
{
 List<clsFileResourceEN> arrObjLst = null; 
string strAction = "GetObjLstByFileResourceIDLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFileResourceID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFileResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngFileResourceID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsFileResourceEN> GetObjLstByFileResourceIDLst_Cache(List<long> arrFileResourceID)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsFileResourceEN._CurrTabName_S);
List<clsFileResourceEN> arrFileResourceObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsFileResourceEN> arrFileResourceObjLst_Sel =
from objFileResourceEN in arrFileResourceObjLst_Cache
where arrFileResourceID.Contains(objFileResourceEN.FileResourceID)
select objFileResourceEN;
return arrFileResourceObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFileResourceEN> GetObjLstByFileResourceIDLst_WA_Cache(List<long> arrFileResourceID)
{
 List<clsFileResourceEN> arrObjLst = null; 
string strAction = "GetObjLstByFileResourceIDLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFileResourceID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFileResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFileResourceEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFileResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFileResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFileResourceEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFileResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFileResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFileResourceEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFileResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFileResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFileResourceEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsFileResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFileResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(long lngFileResourceID)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsFileResourceEN objFileResourceEN = clsFileResourceWApi.GetObjByFileResourceID(lngFileResourceID);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngFileResourceID.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsFileResourceWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelFileResources(List<string> arrFileResourceID)
{
string strAction = "DelFileResources";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFileResourceID);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsFileResourceWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelFileResourcesByCond(string strWhereCond)
{
string strAction = "DelFileResourcesByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsFileResourceEN objFileResourceEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFileResourceEN>(objFileResourceEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileResourceWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objFileResourceEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsFileResourceEN objFileResourceEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFileResourceEN>(objFileResourceEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileResourceWApi.ReFreshCache();
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsFileResourceEN objFileResourceEN)
{
if (string.IsNullOrEmpty(objFileResourceEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFileResourceEN.FileResourceID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFileResourceEN>(objFileResourceEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objFileResourceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFileResourceEN objFileResourceEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFileResourceEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFileResourceEN.FileResourceID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFileResourceEN.FileResourceID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFileResourceEN>(objFileResourceEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
public static bool IsExist(long lngFileResourceID)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["FileResourceID"] = lngFileResourceID.ToString()
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objFileResourceENS">源对象</param>
 /// <param name = "objFileResourceENT">目标对象</param>
 public static void CopyTo(clsFileResourceEN objFileResourceENS, clsFileResourceEN objFileResourceENT)
{
try
{
objFileResourceENT.FileResourceID = objFileResourceENS.FileResourceID; //FileResourceID
objFileResourceENT.IpAddress = objFileResourceENS.IpAddress; //Ip地址
objFileResourceENT.FileDirName = objFileResourceENS.FileDirName; //文件目录名
objFileResourceENT.FileName = objFileResourceENS.FileName; //文件名称
objFileResourceENT.FileName_Bak = objFileResourceENS.FileName_Bak; //FileName_Bak
objFileResourceENT.Extension = objFileResourceENS.Extension; //扩展名
objFileResourceENT.FileLength = objFileResourceENS.FileLength; //文件长度
objFileResourceENT.FileType = objFileResourceENS.FileType; //文件类型
objFileResourceENT.CreationTime = objFileResourceENS.CreationTime; //建立时间
objFileResourceENT.LastWriteTime = objFileResourceENS.LastWriteTime; //最后修改时间
objFileResourceENT.CheckDateTime = objFileResourceENS.CheckDateTime; //CheckDateTime
objFileResourceENT.id_FtpResource = objFileResourceENS.id_FtpResource; //FTP资源流水号
objFileResourceENT.InUse = objFileResourceENS.InUse; //是否在用
objFileResourceENT.IsExistFile = objFileResourceENS.IsExistFile; //是否存在文件
objFileResourceENT.UpdDate = objFileResourceENS.UpdDate; //修改日期
objFileResourceENT.UpdUser = objFileResourceENS.UpdUser; //修改人
objFileResourceENT.Memo = objFileResourceENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsFileResourceEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFileResourceEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFileResourceEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFileResourceEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFileResourceEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFileResourceEN.AttributeName)
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
if (clsFileResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileResourceWApi没有刷新缓存机制(clsFileResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FileResourceID");
//if (arrFileResourceObjLst_Cache == null)
//{
//arrFileResourceObjLst_Cache = await clsFileResourceWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsFileResourceEN._CurrTabName_S);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsFileResourceWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFileResourceEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsFileResourceWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFileResourceEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsFileResourceEN._CurrTabName_S);
List<clsFileResourceEN> arrFileResourceObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFileResourceObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFileResourceEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFileResource.FileResourceID, Type.GetType("System.Int64"));
objDT.Columns.Add(conFileResource.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(conFileResource.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(conFileResource.FileName, Type.GetType("System.String"));
objDT.Columns.Add(conFileResource.FileName_Bak, Type.GetType("System.String"));
objDT.Columns.Add(conFileResource.Extension, Type.GetType("System.String"));
objDT.Columns.Add(conFileResource.FileLength, Type.GetType("System.Int64"));
objDT.Columns.Add(conFileResource.FileType, Type.GetType("System.String"));
objDT.Columns.Add(conFileResource.CreationTime, Type.GetType("System.String"));
objDT.Columns.Add(conFileResource.LastWriteTime, Type.GetType("System.String"));
objDT.Columns.Add(conFileResource.CheckDateTime, Type.GetType("System.String"));
objDT.Columns.Add(conFileResource.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(conFileResource.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFileResource.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFileResource.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conFileResource.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conFileResource.Memo, Type.GetType("System.String"));
foreach (clsFileResourceEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFileResource.FileResourceID] = objInFor[conFileResource.FileResourceID];
objDR[conFileResource.IpAddress] = objInFor[conFileResource.IpAddress];
objDR[conFileResource.FileDirName] = objInFor[conFileResource.FileDirName];
objDR[conFileResource.FileName] = objInFor[conFileResource.FileName];
objDR[conFileResource.FileName_Bak] = objInFor[conFileResource.FileName_Bak];
objDR[conFileResource.Extension] = objInFor[conFileResource.Extension];
objDR[conFileResource.FileLength] = objInFor[conFileResource.FileLength];
objDR[conFileResource.FileType] = objInFor[conFileResource.FileType];
objDR[conFileResource.CreationTime] = objInFor[conFileResource.CreationTime];
objDR[conFileResource.LastWriteTime] = objInFor[conFileResource.LastWriteTime];
objDR[conFileResource.CheckDateTime] = objInFor[conFileResource.CheckDateTime];
objDR[conFileResource.id_FtpResource] = objInFor[conFileResource.id_FtpResource];
objDR[conFileResource.InUse] = objInFor[conFileResource.InUse];
objDR[conFileResource.IsExistFile] = objInFor[conFileResource.IsExistFile];
objDR[conFileResource.UpdDate] = objInFor[conFileResource.UpdDate];
objDR[conFileResource.UpdUser] = objInFor[conFileResource.UpdUser];
objDR[conFileResource.Memo] = objInFor[conFileResource.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 文件资源(FileResource)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4FileResource : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileResourceWApi.ReFreshThisCache();
}
}

}