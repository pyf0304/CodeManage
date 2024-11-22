
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFileResourceWApi
 表名:vFileResource(01120374)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:13
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
public static class clsvFileResourceWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetFileResourceID(this clsvFileResourceEN objvFileResourceEN, long lngFileResourceID, string strComparisonOp="")
	{
objvFileResourceEN.FileResourceID = lngFileResourceID; //FileResourceID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.FileResourceID) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.FileResourceID, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.FileResourceID] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetIpAddress(this clsvFileResourceEN objvFileResourceEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIpAddress, 50, convFileResource.IpAddress);
objvFileResourceEN.IpAddress = strIpAddress; //Ip地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.IpAddress) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.IpAddress, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.IpAddress] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetFileDirName(this clsvFileResourceEN objvFileResourceEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convFileResource.FileDirName);
objvFileResourceEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.FileDirName) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.FileDirName, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.FileDirName] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetFileName(this clsvFileResourceEN objvFileResourceEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convFileResource.FileName);
objvFileResourceEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.FileName) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.FileName, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.FileName] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetFileName_Bak(this clsvFileResourceEN objvFileResourceEN, string strFileName_Bak, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName_Bak, 500, convFileResource.FileName_Bak);
objvFileResourceEN.FileName_Bak = strFileName_Bak; //FileName_Bak
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.FileName_Bak) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.FileName_Bak, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.FileName_Bak] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetExtension(this clsvFileResourceEN objvFileResourceEN, string strExtension, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExtension, 10, convFileResource.Extension);
objvFileResourceEN.Extension = strExtension; //扩展名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.Extension) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.Extension, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.Extension] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetFileLength(this clsvFileResourceEN objvFileResourceEN, long lngFileLength, string strComparisonOp="")
	{
objvFileResourceEN.FileLength = lngFileLength; //文件长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.FileLength) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.FileLength, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.FileLength] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetFileType(this clsvFileResourceEN objvFileResourceEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convFileResource.FileType);
objvFileResourceEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.FileType) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.FileType, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.FileType] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetCreationTime(this clsvFileResourceEN objvFileResourceEN, string strCreationTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreationTime, 20, convFileResource.CreationTime);
objvFileResourceEN.CreationTime = strCreationTime; //建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.CreationTime) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.CreationTime, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.CreationTime] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetLastWriteTime(this clsvFileResourceEN objvFileResourceEN, string strLastWriteTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLastWriteTime, 20, convFileResource.LastWriteTime);
objvFileResourceEN.LastWriteTime = strLastWriteTime; //最后修改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.LastWriteTime) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.LastWriteTime, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.LastWriteTime] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetCheckDateTime(this clsvFileResourceEN objvFileResourceEN, string strCheckDateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckDateTime, 30, convFileResource.CheckDateTime);
objvFileResourceEN.CheckDateTime = strCheckDateTime; //CheckDateTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.CheckDateTime) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.CheckDateTime, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.CheckDateTime] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetInUse(this clsvFileResourceEN objvFileResourceEN, bool bolInUse, string strComparisonOp="")
	{
objvFileResourceEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.InUse) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.InUse, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.InUse] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetIsExistFile(this clsvFileResourceEN objvFileResourceEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvFileResourceEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.IsExistFile) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.IsExistFile, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.IsExistFile] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetUpdDate(this clsvFileResourceEN objvFileResourceEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFileResource.UpdDate);
objvFileResourceEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.UpdDate) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.UpdDate, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.UpdDate] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetUpdUser(this clsvFileResourceEN objvFileResourceEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFileResource.UpdUser);
objvFileResourceEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.UpdUser) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.UpdUser, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.UpdUser] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetMemo(this clsvFileResourceEN objvFileResourceEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFileResource.Memo);
objvFileResourceEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.Memo) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.Memo, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.Memo] = strComparisonOp;
}
}
return objvFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvFileResourceEN SetFtpResourceCount(this clsvFileResourceEN objvFileResourceEN, int intFtpResourceCount, string strComparisonOp="")
	{
objvFileResourceEN.FtpResourceCount = intFtpResourceCount; //Ftp资源数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFileResourceEN.dicFldComparisonOp.ContainsKey(convFileResource.FtpResourceCount) == false)
{
objvFileResourceEN.dicFldComparisonOp.Add(convFileResource.FtpResourceCount, strComparisonOp);
}
else
{
objvFileResourceEN.dicFldComparisonOp[convFileResource.FtpResourceCount] = strComparisonOp;
}
}
return objvFileResourceEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFileResourceEN objvFileResource_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFileResource_Cond.IsUpdated(convFileResource.FileResourceID) == true)
{
string strComparisonOp_FileResourceID = objvFileResource_Cond.dicFldComparisonOp[convFileResource.FileResourceID];
strWhereCond += string.Format(" And {0} {2} {1}", convFileResource.FileResourceID, objvFileResource_Cond.FileResourceID, strComparisonOp_FileResourceID);
}
if (objvFileResource_Cond.IsUpdated(convFileResource.IpAddress) == true)
{
string strComparisonOp_IpAddress = objvFileResource_Cond.dicFldComparisonOp[convFileResource.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.IpAddress, objvFileResource_Cond.IpAddress, strComparisonOp_IpAddress);
}
if (objvFileResource_Cond.IsUpdated(convFileResource.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvFileResource_Cond.dicFldComparisonOp[convFileResource.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.FileDirName, objvFileResource_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvFileResource_Cond.IsUpdated(convFileResource.FileName) == true)
{
string strComparisonOp_FileName = objvFileResource_Cond.dicFldComparisonOp[convFileResource.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.FileName, objvFileResource_Cond.FileName, strComparisonOp_FileName);
}
if (objvFileResource_Cond.IsUpdated(convFileResource.FileName_Bak) == true)
{
string strComparisonOp_FileName_Bak = objvFileResource_Cond.dicFldComparisonOp[convFileResource.FileName_Bak];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.FileName_Bak, objvFileResource_Cond.FileName_Bak, strComparisonOp_FileName_Bak);
}
if (objvFileResource_Cond.IsUpdated(convFileResource.Extension) == true)
{
string strComparisonOp_Extension = objvFileResource_Cond.dicFldComparisonOp[convFileResource.Extension];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.Extension, objvFileResource_Cond.Extension, strComparisonOp_Extension);
}
if (objvFileResource_Cond.IsUpdated(convFileResource.FileLength) == true)
{
string strComparisonOp_FileLength = objvFileResource_Cond.dicFldComparisonOp[convFileResource.FileLength];
strWhereCond += string.Format(" And {0} {2} {1}", convFileResource.FileLength, objvFileResource_Cond.FileLength, strComparisonOp_FileLength);
}
if (objvFileResource_Cond.IsUpdated(convFileResource.FileType) == true)
{
string strComparisonOp_FileType = objvFileResource_Cond.dicFldComparisonOp[convFileResource.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.FileType, objvFileResource_Cond.FileType, strComparisonOp_FileType);
}
if (objvFileResource_Cond.IsUpdated(convFileResource.CreationTime) == true)
{
string strComparisonOp_CreationTime = objvFileResource_Cond.dicFldComparisonOp[convFileResource.CreationTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.CreationTime, objvFileResource_Cond.CreationTime, strComparisonOp_CreationTime);
}
if (objvFileResource_Cond.IsUpdated(convFileResource.LastWriteTime) == true)
{
string strComparisonOp_LastWriteTime = objvFileResource_Cond.dicFldComparisonOp[convFileResource.LastWriteTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.LastWriteTime, objvFileResource_Cond.LastWriteTime, strComparisonOp_LastWriteTime);
}
if (objvFileResource_Cond.IsUpdated(convFileResource.CheckDateTime) == true)
{
string strComparisonOp_CheckDateTime = objvFileResource_Cond.dicFldComparisonOp[convFileResource.CheckDateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.CheckDateTime, objvFileResource_Cond.CheckDateTime, strComparisonOp_CheckDateTime);
}
if (objvFileResource_Cond.IsUpdated(convFileResource.InUse) == true)
{
if (objvFileResource_Cond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFileResource.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFileResource.InUse);
}
}
if (objvFileResource_Cond.IsUpdated(convFileResource.IsExistFile) == true)
{
if (objvFileResource_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFileResource.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFileResource.IsExistFile);
}
}
if (objvFileResource_Cond.IsUpdated(convFileResource.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvFileResource_Cond.dicFldComparisonOp[convFileResource.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.UpdDate, objvFileResource_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvFileResource_Cond.IsUpdated(convFileResource.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvFileResource_Cond.dicFldComparisonOp[convFileResource.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.UpdUser, objvFileResource_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvFileResource_Cond.IsUpdated(convFileResource.Memo) == true)
{
string strComparisonOp_Memo = objvFileResource_Cond.dicFldComparisonOp[convFileResource.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFileResource.Memo, objvFileResource_Cond.Memo, strComparisonOp_Memo);
}
if (objvFileResource_Cond.IsUpdated(convFileResource.FtpResourceCount) == true)
{
string strComparisonOp_FtpResourceCount = objvFileResource_Cond.dicFldComparisonOp[convFileResource.FtpResourceCount];
strWhereCond += string.Format(" And {0} {2} {1}", convFileResource.FtpResourceCount, objvFileResource_Cond.FtpResourceCount, strComparisonOp_FtpResourceCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v文件资源(vFileResource)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFileResourceWApi
{
private static readonly string mstrApiControllerName = "vFileResourceApi";

 public clsvFileResourceWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngFileResourceID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFileResourceEN GetObjByFileResourceID(long lngFileResourceID)
{
string strAction = "GetObjByFileResourceID";
string strErrMsg = string.Empty;
string strResult = "";
clsvFileResourceEN objvFileResourceEN = null;
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
objvFileResourceEN = JsonConvert.DeserializeObject<clsvFileResourceEN>((string)jobjReturn["ReturnObj"]);
return objvFileResourceEN;
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
public static clsvFileResourceEN GetObjByFileResourceID_WA_Cache(long lngFileResourceID)
{
string strAction = "GetObjByFileResourceID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvFileResourceEN objvFileResourceEN = null;
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
objvFileResourceEN = JsonConvert.DeserializeObject<clsvFileResourceEN>((string)jobjReturn["ReturnObj"]);
return objvFileResourceEN;
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
public static clsvFileResourceEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvFileResourceEN objvFileResourceEN = null;
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
objvFileResourceEN = JsonConvert.DeserializeObject<clsvFileResourceEN>((string)jobjReturn["ReturnObj"]);
return objvFileResourceEN;
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
public static clsvFileResourceEN GetObjByFileResourceID_Cache(long lngFileResourceID)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFileResourceEN._CurrTabName_S);
List<clsvFileResourceEN> arrvFileResourceObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvFileResourceEN> arrvFileResourceObjLst_Sel =
from objvFileResourceEN in arrvFileResourceObjLst_Cache
where objvFileResourceEN.FileResourceID == lngFileResourceID
select objvFileResourceEN;
if (arrvFileResourceObjLst_Sel.Count() == 0)
{
   clsvFileResourceEN obj = clsvFileResourceWApi.GetObjByFileResourceID(lngFileResourceID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFileResourceObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFileResourceEN> GetObjLst(string strWhereCond)
{
 List<clsvFileResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFileResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFileResourceEN> GetObjLstByFileResourceIDLst(List<long> arrFileResourceID)
{
 List<clsvFileResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFileResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvFileResourceEN> GetObjLstByFileResourceIDLst_Cache(List<long> arrFileResourceID)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFileResourceEN._CurrTabName_S);
List<clsvFileResourceEN> arrvFileResourceObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvFileResourceEN> arrvFileResourceObjLst_Sel =
from objvFileResourceEN in arrvFileResourceObjLst_Cache
where arrFileResourceID.Contains(objvFileResourceEN.FileResourceID)
select objvFileResourceEN;
return arrvFileResourceObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFileResourceEN> GetObjLstByFileResourceIDLst_WA_Cache(List<long> arrFileResourceID)
{
 List<clsvFileResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFileResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFileResourceEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFileResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFileResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFileResourceEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFileResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFileResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFileResourceEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFileResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFileResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvFileResourceEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvFileResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFileResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvFileResourceENS">源对象</param>
 /// <param name = "objvFileResourceENT">目标对象</param>
 public static void CopyTo(clsvFileResourceEN objvFileResourceENS, clsvFileResourceEN objvFileResourceENT)
{
try
{
objvFileResourceENT.FileResourceID = objvFileResourceENS.FileResourceID; //FileResourceID
objvFileResourceENT.IpAddress = objvFileResourceENS.IpAddress; //Ip地址
objvFileResourceENT.FileDirName = objvFileResourceENS.FileDirName; //文件目录名
objvFileResourceENT.FileName = objvFileResourceENS.FileName; //文件名称
objvFileResourceENT.FileName_Bak = objvFileResourceENS.FileName_Bak; //FileName_Bak
objvFileResourceENT.Extension = objvFileResourceENS.Extension; //扩展名
objvFileResourceENT.FileLength = objvFileResourceENS.FileLength; //文件长度
objvFileResourceENT.FileType = objvFileResourceENS.FileType; //文件类型
objvFileResourceENT.CreationTime = objvFileResourceENS.CreationTime; //建立时间
objvFileResourceENT.LastWriteTime = objvFileResourceENS.LastWriteTime; //最后修改时间
objvFileResourceENT.CheckDateTime = objvFileResourceENS.CheckDateTime; //CheckDateTime
objvFileResourceENT.InUse = objvFileResourceENS.InUse; //是否在用
objvFileResourceENT.IsExistFile = objvFileResourceENS.IsExistFile; //是否存在文件
objvFileResourceENT.UpdDate = objvFileResourceENS.UpdDate; //修改日期
objvFileResourceENT.UpdUser = objvFileResourceENS.UpdUser; //修改人
objvFileResourceENT.Memo = objvFileResourceENS.Memo; //备注
objvFileResourceENT.FtpResourceCount = objvFileResourceENS.FtpResourceCount; //Ftp资源数
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
public static DataTable ToDataTable(List<clsvFileResourceEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFileResourceEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFileResourceEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFileResourceEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFileResourceEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFileResourceEN.AttributeName)
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
//if (arrvFileResourceObjLst_Cache == null)
//{
//arrvFileResourceObjLst_Cache = await clsvFileResourceWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvFileResourceEN._CurrTabName_S);
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
public static List<clsvFileResourceEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvFileResourceEN._CurrTabName_S);
List<clsvFileResourceEN> arrvFileResourceObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFileResourceObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFileResourceEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFileResource.FileResourceID, Type.GetType("System.Int64"));
objDT.Columns.Add(convFileResource.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(convFileResource.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convFileResource.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convFileResource.FileName_Bak, Type.GetType("System.String"));
objDT.Columns.Add(convFileResource.Extension, Type.GetType("System.String"));
objDT.Columns.Add(convFileResource.FileLength, Type.GetType("System.Int64"));
objDT.Columns.Add(convFileResource.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convFileResource.CreationTime, Type.GetType("System.String"));
objDT.Columns.Add(convFileResource.LastWriteTime, Type.GetType("System.String"));
objDT.Columns.Add(convFileResource.CheckDateTime, Type.GetType("System.String"));
objDT.Columns.Add(convFileResource.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFileResource.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFileResource.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFileResource.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFileResource.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convFileResource.FtpResourceCount, Type.GetType("System.Int32"));
foreach (clsvFileResourceEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFileResource.FileResourceID] = objInFor[convFileResource.FileResourceID];
objDR[convFileResource.IpAddress] = objInFor[convFileResource.IpAddress];
objDR[convFileResource.FileDirName] = objInFor[convFileResource.FileDirName];
objDR[convFileResource.FileName] = objInFor[convFileResource.FileName];
objDR[convFileResource.FileName_Bak] = objInFor[convFileResource.FileName_Bak];
objDR[convFileResource.Extension] = objInFor[convFileResource.Extension];
objDR[convFileResource.FileLength] = objInFor[convFileResource.FileLength];
objDR[convFileResource.FileType] = objInFor[convFileResource.FileType];
objDR[convFileResource.CreationTime] = objInFor[convFileResource.CreationTime];
objDR[convFileResource.LastWriteTime] = objInFor[convFileResource.LastWriteTime];
objDR[convFileResource.CheckDateTime] = objInFor[convFileResource.CheckDateTime];
objDR[convFileResource.InUse] = objInFor[convFileResource.InUse];
objDR[convFileResource.IsExistFile] = objInFor[convFileResource.IsExistFile];
objDR[convFileResource.UpdDate] = objInFor[convFileResource.UpdDate];
objDR[convFileResource.UpdUser] = objInFor[convFileResource.UpdUser];
objDR[convFileResource.Memo] = objInFor[convFileResource.Memo];
objDR[convFileResource.FtpResourceCount] = objInFor[convFileResource.FtpResourceCount];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}