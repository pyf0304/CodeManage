﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFileServerWApi
 表名:FileServer(00050209)
 生成代码版本:2021.07.30.2
 生成日期:2021/07/30 16:30:26
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:文件服务
 模块英文名:FileService
 框架-层名:WA_访问层(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
using AGC.Entity;

namespace AGC4WApi
{
public static class clsFileServerWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN Setid_FileId(this clsFileServerEN objFileServerEN, long lngid_FileId, string strComparisonOp="")
	{
objFileServerEN.id_FileId = lngid_FileId; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.id_FileId) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.id_FileId, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.id_FileId] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetFileContent(this clsFileServerEN objFileServerEN, byte[] bytFileContent, string strComparisonOp="")
	{
objFileServerEN.FileContent = bytFileContent; //文件内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.FileContent) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.FileContent, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.FileContent] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetFileName(this clsFileServerEN objFileServerEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, conFileServer.FileName);
clsCheckSql.CheckFieldLen(strFileName, 150, conFileServer.FileName);
objFileServerEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.FileName) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.FileName, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.FileName] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetIsFree(this clsFileServerEN objFileServerEN, bool bolIsFree, string strComparisonOp="")
	{
objFileServerEN.IsFree = bolIsFree; //是否释放
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.IsFree) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.IsFree, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.IsFree] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetFileSize(this clsFileServerEN objFileServerEN, long lngFileSize, string strComparisonOp="")
	{
objFileServerEN.FileSize = lngFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.FileSize) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.FileSize, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.FileSize] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetFileType(this clsFileServerEN objFileServerEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, conFileServer.FileType);
objFileServerEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.FileType) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.FileType, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.FileType] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetSaveDate(this clsFileServerEN objFileServerEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 25, conFileServer.SaveDate);
objFileServerEN.SaveDate = strSaveDate; //保存日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.SaveDate) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.SaveDate, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.SaveDate] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetLastWriteTime(this clsFileServerEN objFileServerEN, string strLastWriteTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLastWriteTime, 30, conFileServer.LastWriteTime);
objFileServerEN.LastWriteTime = strLastWriteTime; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.LastWriteTime) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.LastWriteTime, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.LastWriteTime] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetIdFtpResource(this clsFileServerEN objFileServerEN, string strIdFtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, conFileServer.IdFtpResource);
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, conFileServer.IdFtpResource);
objFileServerEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.IdFtpResource) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.IdFtpResource, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.IdFtpResource] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN Setid_ResourceType(this clsFileServerEN objFileServerEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, conFileServer.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, conFileServer.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, conFileServer.id_ResourceType);
objFileServerEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.id_ResourceType) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.id_ResourceType, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.id_ResourceType] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetSaveMode(this clsFileServerEN objFileServerEN, string strSaveMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveMode, 10, conFileServer.SaveMode);
objFileServerEN.SaveMode = strSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.SaveMode) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.SaveMode, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.SaveMode] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetProjectName(this clsFileServerEN objFileServerEN, string strProjectName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProjectName, 100, conFileServer.ProjectName);
objFileServerEN.ProjectName = strProjectName; //项目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.ProjectName) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.ProjectName, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.ProjectName] = strComparisonOp;
}
}
return objFileServerEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFileServerEN objFileServer_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFileServer_Cond.IsUpdated(conFileServer.id_FileId) == true)
{
string strComparisonOp_id_FileId = objFileServer_Cond.dicFldComparisonOp[conFileServer.id_FileId];
strWhereCond += string.Format(" And {0} {2} {1}", conFileServer.id_FileId, objFileServer_Cond.id_FileId, strComparisonOp_id_FileId);
}
//数据类型byte[](image)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objFileServer_Cond.IsUpdated(conFileServer.FileName) == true)
{
string strComparisonOp_FileName = objFileServer_Cond.dicFldComparisonOp[conFileServer.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.FileName, objFileServer_Cond.FileName, strComparisonOp_FileName);
}
if (objFileServer_Cond.IsUpdated(conFileServer.IsFree) == true)
{
if (objFileServer_Cond.IsFree == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFileServer.IsFree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFileServer.IsFree);
}
}
if (objFileServer_Cond.IsUpdated(conFileServer.FileSize) == true)
{
string strComparisonOp_FileSize = objFileServer_Cond.dicFldComparisonOp[conFileServer.FileSize];
strWhereCond += string.Format(" And {0} {2} {1}", conFileServer.FileSize, objFileServer_Cond.FileSize, strComparisonOp_FileSize);
}
if (objFileServer_Cond.IsUpdated(conFileServer.FileType) == true)
{
string strComparisonOp_FileType = objFileServer_Cond.dicFldComparisonOp[conFileServer.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.FileType, objFileServer_Cond.FileType, strComparisonOp_FileType);
}
if (objFileServer_Cond.IsUpdated(conFileServer.SaveDate) == true)
{
string strComparisonOp_SaveDate = objFileServer_Cond.dicFldComparisonOp[conFileServer.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.SaveDate, objFileServer_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objFileServer_Cond.IsUpdated(conFileServer.LastWriteTime) == true)
{
string strComparisonOp_LastWriteTime = objFileServer_Cond.dicFldComparisonOp[conFileServer.LastWriteTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.LastWriteTime, objFileServer_Cond.LastWriteTime, strComparisonOp_LastWriteTime);
}
if (objFileServer_Cond.IsUpdated(conFileServer.IdFtpResource) == true)
{
string strComparisonOp_IdFtpResource = objFileServer_Cond.dicFldComparisonOp[conFileServer.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.IdFtpResource, objFileServer_Cond.IdFtpResource, strComparisonOp_IdFtpResource);
}
if (objFileServer_Cond.IsUpdated(conFileServer.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objFileServer_Cond.dicFldComparisonOp[conFileServer.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.id_ResourceType, objFileServer_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objFileServer_Cond.IsUpdated(conFileServer.SaveMode) == true)
{
string strComparisonOp_SaveMode = objFileServer_Cond.dicFldComparisonOp[conFileServer.SaveMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.SaveMode, objFileServer_Cond.SaveMode, strComparisonOp_SaveMode);
}
if (objFileServer_Cond.IsUpdated(conFileServer.ProjectName) == true)
{
string strComparisonOp_ProjectName = objFileServer_Cond.dicFldComparisonOp[conFileServer.ProjectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.ProjectName, objFileServer_Cond.ProjectName, strComparisonOp_ProjectName);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFileServerEN objFileServerEN)
{
 if (objFileServerEN.id_FileId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFileServerEN.sfUpdFldSetStr = objFileServerEN.getsfUpdFldSetStr();
clsFileServerWApi.CheckPropertyNew(objFileServerEN); 
bool bolResult = clsFileServerWApi.UpdateRecord(objFileServerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--FileServer(文件服务), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFileServerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_ProjectName_id_ResourceType_FileName(this clsFileServerEN objFileServerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFileServerEN == null) return "";
if (objFileServerEN.id_FileId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ProjectName = '{0}'", objFileServerEN.ProjectName);
 sbCondition.AppendFormat(" and id_ResourceType = '{0}'", objFileServerEN.id_ResourceType);
 sbCondition.AppendFormat(" and FileName = '{0}'", objFileServerEN.FileName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_FileId !=  {0}", objFileServerEN.id_FileId);
 sbCondition.AppendFormat(" and ProjectName = '{0}'", objFileServerEN.ProjectName);
 sbCondition.AppendFormat(" and id_ResourceType = '{0}'", objFileServerEN.id_ResourceType);
 sbCondition.AppendFormat(" and FileName = '{0}'", objFileServerEN.FileName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFileServerEN objFileServerEN)
{
try
{
clsFileServerWApi.CheckPropertyNew(objFileServerEN); 
bool bolResult = clsFileServerWApi.AddNewRecord(objFileServerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerWApi.ReFreshCache();
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
 /// <param name = "objFileServerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFileServerEN objFileServerEN, string strWhereCond)
{
try
{
clsFileServerWApi.CheckPropertyNew(objFileServerEN); 
bool bolResult = clsFileServerWApi.UpdateWithCondition(objFileServerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerWApi.ReFreshCache();
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
 /// 文件服务(FileServer)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFileServerWApi
{
private static readonly string mstrApiControllerName = "FileServerApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsFileServerWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFileServerEN objFileServerEN)
{
if (!Object.Equals(null, objFileServerEN.FileName) && GetStrLen(objFileServerEN.FileName) > 150)
{
 throw new Exception("字段[文件名]的长度不能超过150!");
}
if (!Object.Equals(null, objFileServerEN.FileType) && GetStrLen(objFileServerEN.FileType) > 30)
{
 throw new Exception("字段[文件类型]的长度不能超过30!");
}
if (!Object.Equals(null, objFileServerEN.SaveDate) && GetStrLen(objFileServerEN.SaveDate) > 25)
{
 throw new Exception("字段[保存日期]的长度不能超过25!");
}
if (!Object.Equals(null, objFileServerEN.LastWriteTime) && GetStrLen(objFileServerEN.LastWriteTime) > 30)
{
 throw new Exception("字段[修改日期]的长度不能超过30!");
}
if (!Object.Equals(null, objFileServerEN.IdFtpResource) && GetStrLen(objFileServerEN.IdFtpResource) > 8)
{
 throw new Exception("字段[FTP资源流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objFileServerEN.id_ResourceType) && GetStrLen(objFileServerEN.id_ResourceType) > 4)
{
 throw new Exception("字段[资源类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objFileServerEN.SaveMode) && GetStrLen(objFileServerEN.SaveMode) > 10)
{
 throw new Exception("字段[文件存放方式]的长度不能超过10!");
}
if (!Object.Equals(null, objFileServerEN.ProjectName) && GetStrLen(objFileServerEN.ProjectName) > 100)
{
 throw new Exception("字段[项目名称]的长度不能超过100!");
}
 objFileServerEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_FileId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFileServerEN GetObjByid_FileId(long lngid_FileId)
{
string strAction = "GetObjByid_FileId";
string strErrMsg = string.Empty;
string strResult = "";
clsFileServerEN objFileServerEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_FileId"] = lngid_FileId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objFileServerEN = JsonConvert.DeserializeObject<clsFileServerEN>((string)jobjReturn["returnObj"]);
return objFileServerEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <param name = "lngid_FileId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFileServerEN GetObjByid_FileId_WA_Cache(long lngid_FileId)
{
string strAction = "GetObjByid_FileId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsFileServerEN objFileServerEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_FileId"] = lngid_FileId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objFileServerEN = JsonConvert.DeserializeObject<clsFileServerEN>((string)jobjReturn["returnObj"]);
return objFileServerEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
if ((int)jobjReturn["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn["returnStr"];
return long.Parse(strReturnStr);
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static clsFileServerEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsFileServerEN objFileServerEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objFileServerEN = JsonConvert.DeserializeObject<clsFileServerEN>((string)jobjReturn["returnObj"]);
return objFileServerEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <param name = "lngid_FileId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFileServerEN GetObjByid_FileId_Cache(long lngid_FileId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsFileServerEN._CurrTabName);
List<clsFileServerEN> arrFileServerObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsFileServerEN> arrFileServerObjLst_Sel =
from objFileServerEN in arrFileServerObjLst_Cache
where objFileServerEN.id_FileId == lngid_FileId
select objFileServerEN;
if (arrFileServerObjLst_Sel.Count() == 0)
{
   clsFileServerEN obj = clsFileServerWApi.GetObjByid_FileId(lngid_FileId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrFileServerObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFileServerEN> GetObjLst(string strWhereCond)
{
 List<clsFileServerEN> arrObjLst = null; 
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
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFileServerEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsFileServerEN> GetObjLstById_FileIdLst(List<long> arrId_FileId)
{
 List<clsFileServerEN> arrObjLst = null; 
string strAction = "GetObjLstById_FileIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_FileId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFileServerEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <param name = "lngid_FileId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsFileServerEN> GetObjLstById_FileIdLst_Cache(List<long> arrId_FileId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsFileServerEN._CurrTabName);
List<clsFileServerEN> arrFileServerObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsFileServerEN> arrFileServerObjLst_Sel =
from objFileServerEN in arrFileServerObjLst_Cache
where arrId_FileId.Contains(objFileServerEN.id_FileId)
select objFileServerEN;
return arrFileServerObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFileServerEN> GetObjLstById_FileIdLst_WA_Cache(List<long> arrId_FileId)
{
 List<clsFileServerEN> arrObjLst = null; 
string strAction = "GetObjLstById_FileIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_FileId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFileServerEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsFileServerEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFileServerEN> arrObjLst = null; 
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
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFileServerEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsFileServerEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFileServerEN> arrObjLst = null; 
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
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFileServerEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsFileServerEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFileServerEN> arrObjLst = null; 
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
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFileServerEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsFileServerEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsFileServerEN> arrObjLst = null; 
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
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFileServerEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static int DelRecord(long lngid_FileId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsFileServerEN objFileServerEN = clsFileServerWApi.GetObjByid_FileId(lngid_FileId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngid_FileId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
clsFileServerWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static int DelFileServers(List<string> arrid_FileId)
{
string strAction = "DelFileServers";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_FileId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
clsFileServerWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static int DelFileServersByCond(string strWhereCond)
{
string strAction = "DelFileServersByCond";
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
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static bool AddNewRecord(clsFileServerEN objFileServerEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFileServerEN>(objFileServerEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerWApi.ReFreshCache();
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <param name = "objFileServerEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsFileServerEN objFileServerEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFileServerEN>(objFileServerEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerWApi.ReFreshCache();
var strReturnStr = (string)jobjReturn["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static bool UpdateRecord(clsFileServerEN objFileServerEN)
{
if (string.IsNullOrEmpty(objFileServerEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFileServerEN.id_FileId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFileServerEN>(objFileServerEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <param name = "objFileServerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFileServerEN objFileServerEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFileServerEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFileServerEN.id_FileId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFileServerEN.id_FileId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFileServerEN>(objFileServerEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static bool IsExist(long lngid_FileId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_FileId"] = lngid_FileId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
if ((int)jobjReturn["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <param name = "objFileServerENS">源对象</param>
 /// <param name = "objFileServerENT">目标对象</param>
 public static void CopyTo(clsFileServerEN objFileServerENS, clsFileServerEN objFileServerENT)
{
try
{
objFileServerENT.id_FileId = objFileServerENS.id_FileId; //文件流水号
objFileServerENT.FileContent = objFileServerENS.FileContent; //文件内容
objFileServerENT.FileName = objFileServerENS.FileName; //文件名
objFileServerENT.IsFree = objFileServerENS.IsFree; //是否释放
objFileServerENT.FileSize = objFileServerENS.FileSize; //文件大小
objFileServerENT.FileType = objFileServerENS.FileType; //文件类型
objFileServerENT.SaveDate = objFileServerENS.SaveDate; //保存日期
objFileServerENT.LastWriteTime = objFileServerENS.LastWriteTime; //修改日期
objFileServerENT.IdFtpResource = objFileServerENS.IdFtpResource; //FTP资源流水号
objFileServerENT.id_ResourceType = objFileServerENS.id_ResourceType; //资源类型流水号
objFileServerENT.SaveMode = objFileServerENS.SaveMode; //文件存放方式
objFileServerENT.ProjectName = objFileServerENS.ProjectName; //项目名称
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
public static DataTable ToDataTable(List<clsFileServerEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFileServerEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFileServerEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFileServerEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFileServerEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFileServerEN.AttributeName)
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
if (clsFileServerWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsFileServerWApi没有刷新缓存机制(clsFileServerWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_FileId");
//if (arrFileServerObjLst_Cache == null)
//{
//arrFileServerObjLst_Cache = await clsFileServerWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsFileServerEN._CurrTabName);
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
if (clsFileServerWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFileServerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFileServerWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFileServerEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsFileServerEN._CurrTabName);
List<clsFileServerEN> arrFileServerObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFileServerObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFileServerEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFileServer.id_FileId, Type.GetType("System.Int64"));
objDT.Columns.Add(conFileServer.FileContent, Type.GetType("System.Byte[]"));
objDT.Columns.Add(conFileServer.FileName, Type.GetType("System.String"));
objDT.Columns.Add(conFileServer.IsFree, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFileServer.FileSize, Type.GetType("System.Int64"));
objDT.Columns.Add(conFileServer.FileType, Type.GetType("System.String"));
objDT.Columns.Add(conFileServer.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(conFileServer.LastWriteTime, Type.GetType("System.String"));
objDT.Columns.Add(conFileServer.IdFtpResource, Type.GetType("System.String"));
objDT.Columns.Add(conFileServer.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(conFileServer.SaveMode, Type.GetType("System.String"));
objDT.Columns.Add(conFileServer.ProjectName, Type.GetType("System.String"));
foreach (clsFileServerEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFileServer.id_FileId] = objInFor[conFileServer.id_FileId];
objDR[conFileServer.FileContent] = objInFor[conFileServer.FileContent];
objDR[conFileServer.FileName] = objInFor[conFileServer.FileName];
objDR[conFileServer.IsFree] = objInFor[conFileServer.IsFree];
objDR[conFileServer.FileSize] = objInFor[conFileServer.FileSize];
objDR[conFileServer.FileType] = objInFor[conFileServer.FileType];
objDR[conFileServer.SaveDate] = objInFor[conFileServer.SaveDate];
objDR[conFileServer.LastWriteTime] = objInFor[conFileServer.LastWriteTime];
objDR[conFileServer.IdFtpResource] = objInFor[conFileServer.IdFtpResource];
objDR[conFileServer.id_ResourceType] = objInFor[conFileServer.id_ResourceType];
objDR[conFileServer.SaveMode] = objInFor[conFileServer.SaveMode];
objDR[conFileServer.ProjectName] = objInFor[conFileServer.ProjectName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 文件服务(FileServer)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4FileServer : clsCommFun4BL
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
clsFileServerWApi.ReFreshThisCache();
}
}

}