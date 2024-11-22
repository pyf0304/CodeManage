
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_AttachmentBL
 表名:vcc_Attachment(01120160)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:45
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:其他(Other)
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
public static class  clsvcc_AttachmentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngAttachmentID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_AttachmentEN GetObj(this K_AttachmentID_vcc_Attachment myKey)
{
clsvcc_AttachmentEN objvcc_AttachmentEN = clsvcc_AttachmentBL.vcc_AttachmentDA.GetObjByAttachmentID(myKey.Value);
return objvcc_AttachmentEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_AttachmentEN SetAttachmentID(this clsvcc_AttachmentEN objvcc_AttachmentEN, long lngAttachmentID, string strComparisonOp="")
	{
objvcc_AttachmentEN.AttachmentID = lngAttachmentID; //附件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.AttachmentID) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.AttachmentID, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.AttachmentID] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_AttachmentEN SetTableName(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strTableName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableName, 100, convcc_Attachment.TableName);
}
objvcc_AttachmentEN.TableName = strTableName; //主表表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.TableName) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.TableName, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.TableName] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_AttachmentEN SetFileName(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convcc_Attachment.FileName);
}
objvcc_AttachmentEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.FileName) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.FileName, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.FileName] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_AttachmentEN SetExtension(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strExtension, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExtension, 10, convcc_Attachment.Extension);
}
objvcc_AttachmentEN.Extension = strExtension; //扩展名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.Extension) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.Extension, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.Extension] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_AttachmentEN SetFilePath(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convcc_Attachment.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, convcc_Attachment.FilePath);
}
objvcc_AttachmentEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.FilePath) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.FilePath, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.FilePath] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_AttachmentEN SetFileSize(this clsvcc_AttachmentEN objvcc_AttachmentEN, double? dblFileSize, string strComparisonOp="")
	{
objvcc_AttachmentEN.FileSize = dblFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.FileSize) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.FileSize, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.FileSize] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_AttachmentEN SetFileSizeUnit(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strFileSizeUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSizeUnit, 10, convcc_Attachment.FileSizeUnit);
}
objvcc_AttachmentEN.FileSizeUnit = strFileSizeUnit; //文件大小单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.FileSizeUnit) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.FileSizeUnit, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.FileSizeUnit] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_AttachmentEN SetUploadDate(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strUploadDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUploadDate, convcc_Attachment.UploadDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadDate, 20, convcc_Attachment.UploadDate);
}
objvcc_AttachmentEN.UploadDate = strUploadDate; //上传时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.UploadDate) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.UploadDate, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.UploadDate] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_AttachmentEN SetUploadPerson(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strUploadPerson, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUploadPerson, convcc_Attachment.UploadPerson);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadPerson, 20, convcc_Attachment.UploadPerson);
}
objvcc_AttachmentEN.UploadPerson = strUploadPerson; //上传人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.UploadPerson) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.UploadPerson, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.UploadPerson] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_AttachmentEN SetTableNameKey(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strTableNameKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTableNameKey, convcc_Attachment.TableNameKey);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableNameKey, 20, convcc_Attachment.TableNameKey);
}
objvcc_AttachmentEN.TableNameKey = strTableNameKey; //主表主键值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.TableNameKey) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.TableNameKey, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.TableNameKey] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_AttachmentEN SetIdResourceType(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strIdResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResourceType, convcc_Attachment.IdResourceType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convcc_Attachment.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convcc_Attachment.IdResourceType);
}
objvcc_AttachmentEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.IdResourceType) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.IdResourceType, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.IdResourceType] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_AttachmentEN SetResourceTypeID(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convcc_Attachment.ResourceTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convcc_Attachment.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convcc_Attachment.ResourceTypeID);
}
objvcc_AttachmentEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.ResourceTypeID) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.ResourceTypeID, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.ResourceTypeID] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_AttachmentEN SetResourceTypeName(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convcc_Attachment.ResourceTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convcc_Attachment.ResourceTypeName);
}
objvcc_AttachmentEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.ResourceTypeName) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.ResourceTypeName, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.ResourceTypeName] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_AttachmentEN SetUpdDate(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_Attachment.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_Attachment.UpdDate);
}
objvcc_AttachmentEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.UpdDate) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.UpdDate, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.UpdDate] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_AttachmentEN SetUpdUserId(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_Attachment.UpdUserId);
}
objvcc_AttachmentEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.UpdUserId) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.UpdUserId, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.UpdUserId] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_AttachmentEN SetMemo(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_Attachment.Memo);
}
objvcc_AttachmentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.Memo) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.Memo, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.Memo] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_AttachmentEN SetImageHeight(this clsvcc_AttachmentEN objvcc_AttachmentEN, int? intImageHeight, string strComparisonOp="")
	{
objvcc_AttachmentEN.ImageHeight = intImageHeight; //图像高
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.ImageHeight) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.ImageHeight, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.ImageHeight] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_AttachmentEN SetImageWidth(this clsvcc_AttachmentEN objvcc_AttachmentEN, int? intImageWidth, string strComparisonOp="")
	{
objvcc_AttachmentEN.ImageWidth = intImageWidth; //图像宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.ImageWidth) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.ImageWidth, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.ImageWidth] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_AttachmentENS">源对象</param>
 /// <param name = "objvcc_AttachmentENT">目标对象</param>
 public static void CopyTo(this clsvcc_AttachmentEN objvcc_AttachmentENS, clsvcc_AttachmentEN objvcc_AttachmentENT)
{
try
{
objvcc_AttachmentENT.AttachmentID = objvcc_AttachmentENS.AttachmentID; //附件流水号
objvcc_AttachmentENT.TableName = objvcc_AttachmentENS.TableName; //主表表名
objvcc_AttachmentENT.FileName = objvcc_AttachmentENS.FileName; //文件名称
objvcc_AttachmentENT.Extension = objvcc_AttachmentENS.Extension; //扩展名
objvcc_AttachmentENT.FilePath = objvcc_AttachmentENS.FilePath; //文件路径
objvcc_AttachmentENT.FileSize = objvcc_AttachmentENS.FileSize; //文件大小
objvcc_AttachmentENT.FileSizeUnit = objvcc_AttachmentENS.FileSizeUnit; //文件大小单位
objvcc_AttachmentENT.UploadDate = objvcc_AttachmentENS.UploadDate; //上传时间
objvcc_AttachmentENT.UploadPerson = objvcc_AttachmentENS.UploadPerson; //上传人
objvcc_AttachmentENT.TableNameKey = objvcc_AttachmentENS.TableNameKey; //主表主键值
objvcc_AttachmentENT.IdResourceType = objvcc_AttachmentENS.IdResourceType; //资源类型流水号
objvcc_AttachmentENT.ResourceTypeID = objvcc_AttachmentENS.ResourceTypeID; //资源类型ID
objvcc_AttachmentENT.ResourceTypeName = objvcc_AttachmentENS.ResourceTypeName; //资源类型名称
objvcc_AttachmentENT.UpdDate = objvcc_AttachmentENS.UpdDate; //修改日期
objvcc_AttachmentENT.UpdUserId = objvcc_AttachmentENS.UpdUserId; //修改用户Id
objvcc_AttachmentENT.Memo = objvcc_AttachmentENS.Memo; //备注
objvcc_AttachmentENT.ImageHeight = objvcc_AttachmentENS.ImageHeight; //图像高
objvcc_AttachmentENT.ImageWidth = objvcc_AttachmentENS.ImageWidth; //图像宽
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
 /// <param name = "objvcc_AttachmentENS">源对象</param>
 /// <returns>目标对象=>clsvcc_AttachmentEN:objvcc_AttachmentENT</returns>
 public static clsvcc_AttachmentEN CopyTo(this clsvcc_AttachmentEN objvcc_AttachmentENS)
{
try
{
 clsvcc_AttachmentEN objvcc_AttachmentENT = new clsvcc_AttachmentEN()
{
AttachmentID = objvcc_AttachmentENS.AttachmentID, //附件流水号
TableName = objvcc_AttachmentENS.TableName, //主表表名
FileName = objvcc_AttachmentENS.FileName, //文件名称
Extension = objvcc_AttachmentENS.Extension, //扩展名
FilePath = objvcc_AttachmentENS.FilePath, //文件路径
FileSize = objvcc_AttachmentENS.FileSize, //文件大小
FileSizeUnit = objvcc_AttachmentENS.FileSizeUnit, //文件大小单位
UploadDate = objvcc_AttachmentENS.UploadDate, //上传时间
UploadPerson = objvcc_AttachmentENS.UploadPerson, //上传人
TableNameKey = objvcc_AttachmentENS.TableNameKey, //主表主键值
IdResourceType = objvcc_AttachmentENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvcc_AttachmentENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvcc_AttachmentENS.ResourceTypeName, //资源类型名称
UpdDate = objvcc_AttachmentENS.UpdDate, //修改日期
UpdUserId = objvcc_AttachmentENS.UpdUserId, //修改用户Id
Memo = objvcc_AttachmentENS.Memo, //备注
ImageHeight = objvcc_AttachmentENS.ImageHeight, //图像高
ImageWidth = objvcc_AttachmentENS.ImageWidth, //图像宽
};
 return objvcc_AttachmentENT;
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
public static void CheckProperty4Condition(this clsvcc_AttachmentEN objvcc_AttachmentEN)
{
 clsvcc_AttachmentBL.vcc_AttachmentDA.CheckProperty4Condition(objvcc_AttachmentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_AttachmentEN objvcc_AttachmentCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_AttachmentCond.IsUpdated(convcc_Attachment.AttachmentID) == true)
{
string strComparisonOpAttachmentID = objvcc_AttachmentCond.dicFldComparisonOp[convcc_Attachment.AttachmentID];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Attachment.AttachmentID, objvcc_AttachmentCond.AttachmentID, strComparisonOpAttachmentID);
}
if (objvcc_AttachmentCond.IsUpdated(convcc_Attachment.TableName) == true)
{
string strComparisonOpTableName = objvcc_AttachmentCond.dicFldComparisonOp[convcc_Attachment.TableName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.TableName, objvcc_AttachmentCond.TableName, strComparisonOpTableName);
}
if (objvcc_AttachmentCond.IsUpdated(convcc_Attachment.FileName) == true)
{
string strComparisonOpFileName = objvcc_AttachmentCond.dicFldComparisonOp[convcc_Attachment.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.FileName, objvcc_AttachmentCond.FileName, strComparisonOpFileName);
}
if (objvcc_AttachmentCond.IsUpdated(convcc_Attachment.Extension) == true)
{
string strComparisonOpExtension = objvcc_AttachmentCond.dicFldComparisonOp[convcc_Attachment.Extension];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.Extension, objvcc_AttachmentCond.Extension, strComparisonOpExtension);
}
if (objvcc_AttachmentCond.IsUpdated(convcc_Attachment.FilePath) == true)
{
string strComparisonOpFilePath = objvcc_AttachmentCond.dicFldComparisonOp[convcc_Attachment.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.FilePath, objvcc_AttachmentCond.FilePath, strComparisonOpFilePath);
}
if (objvcc_AttachmentCond.IsUpdated(convcc_Attachment.FileSize) == true)
{
string strComparisonOpFileSize = objvcc_AttachmentCond.dicFldComparisonOp[convcc_Attachment.FileSize];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Attachment.FileSize, objvcc_AttachmentCond.FileSize, strComparisonOpFileSize);
}
if (objvcc_AttachmentCond.IsUpdated(convcc_Attachment.FileSizeUnit) == true)
{
string strComparisonOpFileSizeUnit = objvcc_AttachmentCond.dicFldComparisonOp[convcc_Attachment.FileSizeUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.FileSizeUnit, objvcc_AttachmentCond.FileSizeUnit, strComparisonOpFileSizeUnit);
}
if (objvcc_AttachmentCond.IsUpdated(convcc_Attachment.UploadDate) == true)
{
string strComparisonOpUploadDate = objvcc_AttachmentCond.dicFldComparisonOp[convcc_Attachment.UploadDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.UploadDate, objvcc_AttachmentCond.UploadDate, strComparisonOpUploadDate);
}
if (objvcc_AttachmentCond.IsUpdated(convcc_Attachment.UploadPerson) == true)
{
string strComparisonOpUploadPerson = objvcc_AttachmentCond.dicFldComparisonOp[convcc_Attachment.UploadPerson];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.UploadPerson, objvcc_AttachmentCond.UploadPerson, strComparisonOpUploadPerson);
}
if (objvcc_AttachmentCond.IsUpdated(convcc_Attachment.TableNameKey) == true)
{
string strComparisonOpTableNameKey = objvcc_AttachmentCond.dicFldComparisonOp[convcc_Attachment.TableNameKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.TableNameKey, objvcc_AttachmentCond.TableNameKey, strComparisonOpTableNameKey);
}
if (objvcc_AttachmentCond.IsUpdated(convcc_Attachment.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvcc_AttachmentCond.dicFldComparisonOp[convcc_Attachment.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.IdResourceType, objvcc_AttachmentCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvcc_AttachmentCond.IsUpdated(convcc_Attachment.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvcc_AttachmentCond.dicFldComparisonOp[convcc_Attachment.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.ResourceTypeID, objvcc_AttachmentCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvcc_AttachmentCond.IsUpdated(convcc_Attachment.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvcc_AttachmentCond.dicFldComparisonOp[convcc_Attachment.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.ResourceTypeName, objvcc_AttachmentCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvcc_AttachmentCond.IsUpdated(convcc_Attachment.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_AttachmentCond.dicFldComparisonOp[convcc_Attachment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.UpdDate, objvcc_AttachmentCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_AttachmentCond.IsUpdated(convcc_Attachment.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvcc_AttachmentCond.dicFldComparisonOp[convcc_Attachment.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.UpdUserId, objvcc_AttachmentCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvcc_AttachmentCond.IsUpdated(convcc_Attachment.Memo) == true)
{
string strComparisonOpMemo = objvcc_AttachmentCond.dicFldComparisonOp[convcc_Attachment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.Memo, objvcc_AttachmentCond.Memo, strComparisonOpMemo);
}
if (objvcc_AttachmentCond.IsUpdated(convcc_Attachment.ImageHeight) == true)
{
string strComparisonOpImageHeight = objvcc_AttachmentCond.dicFldComparisonOp[convcc_Attachment.ImageHeight];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Attachment.ImageHeight, objvcc_AttachmentCond.ImageHeight, strComparisonOpImageHeight);
}
if (objvcc_AttachmentCond.IsUpdated(convcc_Attachment.ImageWidth) == true)
{
string strComparisonOpImageWidth = objvcc_AttachmentCond.dicFldComparisonOp[convcc_Attachment.ImageWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Attachment.ImageWidth, objvcc_AttachmentCond.ImageWidth, strComparisonOpImageWidth);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_Attachment
{
public virtual bool UpdRelaTabDate(long lngAttachmentID, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v附件(vcc_Attachment)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_AttachmentBL
{
public static RelatedActions_vcc_Attachment relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_AttachmentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_AttachmentDA vcc_AttachmentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_AttachmentDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_AttachmentBL()
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
if (string.IsNullOrEmpty(clsvcc_AttachmentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_AttachmentEN._ConnectString);
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
public static DataTable GetDataTable_vcc_Attachment(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_AttachmentDA.GetDataTable_vcc_Attachment(strWhereCond);
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
objDT = vcc_AttachmentDA.GetDataTable(strWhereCond);
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
objDT = vcc_AttachmentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_AttachmentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_AttachmentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_AttachmentDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_AttachmentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_AttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_AttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrAttachmentIDLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_AttachmentEN> GetObjLstByAttachmentIDLst(List<long> arrAttachmentIDLst)
{
List<clsvcc_AttachmentEN> arrObjLst = new List<clsvcc_AttachmentEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrAttachmentIDLst);
 string strWhereCond = string.Format("AttachmentID in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_AttachmentEN objvcc_AttachmentEN = new clsvcc_AttachmentEN();
try
{
objvcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[convcc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objvcc_AttachmentEN.TableName = objRow[convcc_Attachment.TableName] == DBNull.Value ? null : objRow[convcc_Attachment.TableName].ToString().Trim(); //主表表名
objvcc_AttachmentEN.FileName = objRow[convcc_Attachment.FileName] == DBNull.Value ? null : objRow[convcc_Attachment.FileName].ToString().Trim(); //文件名称
objvcc_AttachmentEN.Extension = objRow[convcc_Attachment.Extension] == DBNull.Value ? null : objRow[convcc_Attachment.Extension].ToString().Trim(); //扩展名
objvcc_AttachmentEN.FilePath = objRow[convcc_Attachment.FilePath].ToString().Trim(); //文件路径
objvcc_AttachmentEN.FileSize = objRow[convcc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_Attachment.FileSize].ToString().Trim()); //文件大小
objvcc_AttachmentEN.FileSizeUnit = objRow[convcc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[convcc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvcc_AttachmentEN.UploadDate = objRow[convcc_Attachment.UploadDate].ToString().Trim(); //上传时间
objvcc_AttachmentEN.UploadPerson = objRow[convcc_Attachment.UploadPerson].ToString().Trim(); //上传人
objvcc_AttachmentEN.TableNameKey = objRow[convcc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objvcc_AttachmentEN.IdResourceType = objRow[convcc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvcc_AttachmentEN.ResourceTypeID = objRow[convcc_Attachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvcc_AttachmentEN.ResourceTypeName = objRow[convcc_Attachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvcc_AttachmentEN.UpdDate = objRow[convcc_Attachment.UpdDate].ToString().Trim(); //修改日期
objvcc_AttachmentEN.UpdUserId = objRow[convcc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[convcc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_AttachmentEN.Memo = objRow[convcc_Attachment.Memo] == DBNull.Value ? null : objRow[convcc_Attachment.Memo].ToString().Trim(); //备注
objvcc_AttachmentEN.ImageHeight = objRow[convcc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageHeight].ToString().Trim()); //图像高
objvcc_AttachmentEN.ImageWidth = objRow[convcc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageWidth].ToString().Trim()); //图像宽
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_AttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrAttachmentIDLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_AttachmentEN> GetObjLstByAttachmentIDLstCache(List<long> arrAttachmentIDLst, string strTableName)
{
string strKey = string.Format("{0}_{1}", clsvcc_AttachmentEN._CurrTabName, strTableName);
List<clsvcc_AttachmentEN> arrvcc_AttachmentObjLstCache = GetObjLstCache(strTableName);
IEnumerable <clsvcc_AttachmentEN> arrvcc_AttachmentObjLst_Sel =
arrvcc_AttachmentObjLstCache
.Where(x => arrAttachmentIDLst.Contains(x.AttachmentID));
return arrvcc_AttachmentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_AttachmentEN> GetObjLst(string strWhereCond)
{
List<clsvcc_AttachmentEN> arrObjLst = new List<clsvcc_AttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_AttachmentEN objvcc_AttachmentEN = new clsvcc_AttachmentEN();
try
{
objvcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[convcc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objvcc_AttachmentEN.TableName = objRow[convcc_Attachment.TableName] == DBNull.Value ? null : objRow[convcc_Attachment.TableName].ToString().Trim(); //主表表名
objvcc_AttachmentEN.FileName = objRow[convcc_Attachment.FileName] == DBNull.Value ? null : objRow[convcc_Attachment.FileName].ToString().Trim(); //文件名称
objvcc_AttachmentEN.Extension = objRow[convcc_Attachment.Extension] == DBNull.Value ? null : objRow[convcc_Attachment.Extension].ToString().Trim(); //扩展名
objvcc_AttachmentEN.FilePath = objRow[convcc_Attachment.FilePath].ToString().Trim(); //文件路径
objvcc_AttachmentEN.FileSize = objRow[convcc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_Attachment.FileSize].ToString().Trim()); //文件大小
objvcc_AttachmentEN.FileSizeUnit = objRow[convcc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[convcc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvcc_AttachmentEN.UploadDate = objRow[convcc_Attachment.UploadDate].ToString().Trim(); //上传时间
objvcc_AttachmentEN.UploadPerson = objRow[convcc_Attachment.UploadPerson].ToString().Trim(); //上传人
objvcc_AttachmentEN.TableNameKey = objRow[convcc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objvcc_AttachmentEN.IdResourceType = objRow[convcc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvcc_AttachmentEN.ResourceTypeID = objRow[convcc_Attachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvcc_AttachmentEN.ResourceTypeName = objRow[convcc_Attachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvcc_AttachmentEN.UpdDate = objRow[convcc_Attachment.UpdDate].ToString().Trim(); //修改日期
objvcc_AttachmentEN.UpdUserId = objRow[convcc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[convcc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_AttachmentEN.Memo = objRow[convcc_Attachment.Memo] == DBNull.Value ? null : objRow[convcc_Attachment.Memo].ToString().Trim(); //备注
objvcc_AttachmentEN.ImageHeight = objRow[convcc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageHeight].ToString().Trim()); //图像高
objvcc_AttachmentEN.ImageWidth = objRow[convcc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageWidth].ToString().Trim()); //图像宽
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_AttachmentEN);
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
public static List<clsvcc_AttachmentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_AttachmentEN> arrObjLst = new List<clsvcc_AttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_AttachmentEN objvcc_AttachmentEN = new clsvcc_AttachmentEN();
try
{
objvcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[convcc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objvcc_AttachmentEN.TableName = objRow[convcc_Attachment.TableName] == DBNull.Value ? null : objRow[convcc_Attachment.TableName].ToString().Trim(); //主表表名
objvcc_AttachmentEN.FileName = objRow[convcc_Attachment.FileName] == DBNull.Value ? null : objRow[convcc_Attachment.FileName].ToString().Trim(); //文件名称
objvcc_AttachmentEN.Extension = objRow[convcc_Attachment.Extension] == DBNull.Value ? null : objRow[convcc_Attachment.Extension].ToString().Trim(); //扩展名
objvcc_AttachmentEN.FilePath = objRow[convcc_Attachment.FilePath].ToString().Trim(); //文件路径
objvcc_AttachmentEN.FileSize = objRow[convcc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_Attachment.FileSize].ToString().Trim()); //文件大小
objvcc_AttachmentEN.FileSizeUnit = objRow[convcc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[convcc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvcc_AttachmentEN.UploadDate = objRow[convcc_Attachment.UploadDate].ToString().Trim(); //上传时间
objvcc_AttachmentEN.UploadPerson = objRow[convcc_Attachment.UploadPerson].ToString().Trim(); //上传人
objvcc_AttachmentEN.TableNameKey = objRow[convcc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objvcc_AttachmentEN.IdResourceType = objRow[convcc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvcc_AttachmentEN.ResourceTypeID = objRow[convcc_Attachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvcc_AttachmentEN.ResourceTypeName = objRow[convcc_Attachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvcc_AttachmentEN.UpdDate = objRow[convcc_Attachment.UpdDate].ToString().Trim(); //修改日期
objvcc_AttachmentEN.UpdUserId = objRow[convcc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[convcc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_AttachmentEN.Memo = objRow[convcc_Attachment.Memo] == DBNull.Value ? null : objRow[convcc_Attachment.Memo].ToString().Trim(); //备注
objvcc_AttachmentEN.ImageHeight = objRow[convcc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageHeight].ToString().Trim()); //图像高
objvcc_AttachmentEN.ImageWidth = objRow[convcc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageWidth].ToString().Trim()); //图像宽
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_AttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_AttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_AttachmentEN> GetSubObjLstCache(clsvcc_AttachmentEN objvcc_AttachmentCond)
{
 string strTableName = objvcc_AttachmentCond.TableName;
 if (string.IsNullOrEmpty(strTableName) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvcc_AttachmentBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvcc_AttachmentEN> arrObjLstCache = GetObjLstCache(strTableName);
IEnumerable <clsvcc_AttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_Attachment.AttributeName)
{
if (objvcc_AttachmentCond.IsUpdated(strFldName) == false) continue;
if (objvcc_AttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_AttachmentCond[strFldName].ToString());
}
else
{
if (objvcc_AttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_AttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_AttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_AttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_AttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_AttachmentCond[strFldName]));
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
public static List<clsvcc_AttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_AttachmentEN> arrObjLst = new List<clsvcc_AttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_AttachmentEN objvcc_AttachmentEN = new clsvcc_AttachmentEN();
try
{
objvcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[convcc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objvcc_AttachmentEN.TableName = objRow[convcc_Attachment.TableName] == DBNull.Value ? null : objRow[convcc_Attachment.TableName].ToString().Trim(); //主表表名
objvcc_AttachmentEN.FileName = objRow[convcc_Attachment.FileName] == DBNull.Value ? null : objRow[convcc_Attachment.FileName].ToString().Trim(); //文件名称
objvcc_AttachmentEN.Extension = objRow[convcc_Attachment.Extension] == DBNull.Value ? null : objRow[convcc_Attachment.Extension].ToString().Trim(); //扩展名
objvcc_AttachmentEN.FilePath = objRow[convcc_Attachment.FilePath].ToString().Trim(); //文件路径
objvcc_AttachmentEN.FileSize = objRow[convcc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_Attachment.FileSize].ToString().Trim()); //文件大小
objvcc_AttachmentEN.FileSizeUnit = objRow[convcc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[convcc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvcc_AttachmentEN.UploadDate = objRow[convcc_Attachment.UploadDate].ToString().Trim(); //上传时间
objvcc_AttachmentEN.UploadPerson = objRow[convcc_Attachment.UploadPerson].ToString().Trim(); //上传人
objvcc_AttachmentEN.TableNameKey = objRow[convcc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objvcc_AttachmentEN.IdResourceType = objRow[convcc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvcc_AttachmentEN.ResourceTypeID = objRow[convcc_Attachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvcc_AttachmentEN.ResourceTypeName = objRow[convcc_Attachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvcc_AttachmentEN.UpdDate = objRow[convcc_Attachment.UpdDate].ToString().Trim(); //修改日期
objvcc_AttachmentEN.UpdUserId = objRow[convcc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[convcc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_AttachmentEN.Memo = objRow[convcc_Attachment.Memo] == DBNull.Value ? null : objRow[convcc_Attachment.Memo].ToString().Trim(); //备注
objvcc_AttachmentEN.ImageHeight = objRow[convcc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageHeight].ToString().Trim()); //图像高
objvcc_AttachmentEN.ImageWidth = objRow[convcc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageWidth].ToString().Trim()); //图像宽
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_AttachmentEN);
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
public static List<clsvcc_AttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_AttachmentEN> arrObjLst = new List<clsvcc_AttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_AttachmentEN objvcc_AttachmentEN = new clsvcc_AttachmentEN();
try
{
objvcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[convcc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objvcc_AttachmentEN.TableName = objRow[convcc_Attachment.TableName] == DBNull.Value ? null : objRow[convcc_Attachment.TableName].ToString().Trim(); //主表表名
objvcc_AttachmentEN.FileName = objRow[convcc_Attachment.FileName] == DBNull.Value ? null : objRow[convcc_Attachment.FileName].ToString().Trim(); //文件名称
objvcc_AttachmentEN.Extension = objRow[convcc_Attachment.Extension] == DBNull.Value ? null : objRow[convcc_Attachment.Extension].ToString().Trim(); //扩展名
objvcc_AttachmentEN.FilePath = objRow[convcc_Attachment.FilePath].ToString().Trim(); //文件路径
objvcc_AttachmentEN.FileSize = objRow[convcc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_Attachment.FileSize].ToString().Trim()); //文件大小
objvcc_AttachmentEN.FileSizeUnit = objRow[convcc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[convcc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvcc_AttachmentEN.UploadDate = objRow[convcc_Attachment.UploadDate].ToString().Trim(); //上传时间
objvcc_AttachmentEN.UploadPerson = objRow[convcc_Attachment.UploadPerson].ToString().Trim(); //上传人
objvcc_AttachmentEN.TableNameKey = objRow[convcc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objvcc_AttachmentEN.IdResourceType = objRow[convcc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvcc_AttachmentEN.ResourceTypeID = objRow[convcc_Attachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvcc_AttachmentEN.ResourceTypeName = objRow[convcc_Attachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvcc_AttachmentEN.UpdDate = objRow[convcc_Attachment.UpdDate].ToString().Trim(); //修改日期
objvcc_AttachmentEN.UpdUserId = objRow[convcc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[convcc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_AttachmentEN.Memo = objRow[convcc_Attachment.Memo] == DBNull.Value ? null : objRow[convcc_Attachment.Memo].ToString().Trim(); //备注
objvcc_AttachmentEN.ImageHeight = objRow[convcc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageHeight].ToString().Trim()); //图像高
objvcc_AttachmentEN.ImageWidth = objRow[convcc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageWidth].ToString().Trim()); //图像宽
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_AttachmentEN);
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
List<clsvcc_AttachmentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_AttachmentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_AttachmentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_AttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_AttachmentEN> arrObjLst = new List<clsvcc_AttachmentEN>(); 
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
	clsvcc_AttachmentEN objvcc_AttachmentEN = new clsvcc_AttachmentEN();
try
{
objvcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[convcc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objvcc_AttachmentEN.TableName = objRow[convcc_Attachment.TableName] == DBNull.Value ? null : objRow[convcc_Attachment.TableName].ToString().Trim(); //主表表名
objvcc_AttachmentEN.FileName = objRow[convcc_Attachment.FileName] == DBNull.Value ? null : objRow[convcc_Attachment.FileName].ToString().Trim(); //文件名称
objvcc_AttachmentEN.Extension = objRow[convcc_Attachment.Extension] == DBNull.Value ? null : objRow[convcc_Attachment.Extension].ToString().Trim(); //扩展名
objvcc_AttachmentEN.FilePath = objRow[convcc_Attachment.FilePath].ToString().Trim(); //文件路径
objvcc_AttachmentEN.FileSize = objRow[convcc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_Attachment.FileSize].ToString().Trim()); //文件大小
objvcc_AttachmentEN.FileSizeUnit = objRow[convcc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[convcc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvcc_AttachmentEN.UploadDate = objRow[convcc_Attachment.UploadDate].ToString().Trim(); //上传时间
objvcc_AttachmentEN.UploadPerson = objRow[convcc_Attachment.UploadPerson].ToString().Trim(); //上传人
objvcc_AttachmentEN.TableNameKey = objRow[convcc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objvcc_AttachmentEN.IdResourceType = objRow[convcc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvcc_AttachmentEN.ResourceTypeID = objRow[convcc_Attachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvcc_AttachmentEN.ResourceTypeName = objRow[convcc_Attachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvcc_AttachmentEN.UpdDate = objRow[convcc_Attachment.UpdDate].ToString().Trim(); //修改日期
objvcc_AttachmentEN.UpdUserId = objRow[convcc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[convcc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_AttachmentEN.Memo = objRow[convcc_Attachment.Memo] == DBNull.Value ? null : objRow[convcc_Attachment.Memo].ToString().Trim(); //备注
objvcc_AttachmentEN.ImageHeight = objRow[convcc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageHeight].ToString().Trim()); //图像高
objvcc_AttachmentEN.ImageWidth = objRow[convcc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageWidth].ToString().Trim()); //图像宽
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_AttachmentEN);
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
public static List<clsvcc_AttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_AttachmentEN> arrObjLst = new List<clsvcc_AttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_AttachmentEN objvcc_AttachmentEN = new clsvcc_AttachmentEN();
try
{
objvcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[convcc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objvcc_AttachmentEN.TableName = objRow[convcc_Attachment.TableName] == DBNull.Value ? null : objRow[convcc_Attachment.TableName].ToString().Trim(); //主表表名
objvcc_AttachmentEN.FileName = objRow[convcc_Attachment.FileName] == DBNull.Value ? null : objRow[convcc_Attachment.FileName].ToString().Trim(); //文件名称
objvcc_AttachmentEN.Extension = objRow[convcc_Attachment.Extension] == DBNull.Value ? null : objRow[convcc_Attachment.Extension].ToString().Trim(); //扩展名
objvcc_AttachmentEN.FilePath = objRow[convcc_Attachment.FilePath].ToString().Trim(); //文件路径
objvcc_AttachmentEN.FileSize = objRow[convcc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_Attachment.FileSize].ToString().Trim()); //文件大小
objvcc_AttachmentEN.FileSizeUnit = objRow[convcc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[convcc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvcc_AttachmentEN.UploadDate = objRow[convcc_Attachment.UploadDate].ToString().Trim(); //上传时间
objvcc_AttachmentEN.UploadPerson = objRow[convcc_Attachment.UploadPerson].ToString().Trim(); //上传人
objvcc_AttachmentEN.TableNameKey = objRow[convcc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objvcc_AttachmentEN.IdResourceType = objRow[convcc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvcc_AttachmentEN.ResourceTypeID = objRow[convcc_Attachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvcc_AttachmentEN.ResourceTypeName = objRow[convcc_Attachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvcc_AttachmentEN.UpdDate = objRow[convcc_Attachment.UpdDate].ToString().Trim(); //修改日期
objvcc_AttachmentEN.UpdUserId = objRow[convcc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[convcc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_AttachmentEN.Memo = objRow[convcc_Attachment.Memo] == DBNull.Value ? null : objRow[convcc_Attachment.Memo].ToString().Trim(); //备注
objvcc_AttachmentEN.ImageHeight = objRow[convcc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageHeight].ToString().Trim()); //图像高
objvcc_AttachmentEN.ImageWidth = objRow[convcc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageWidth].ToString().Trim()); //图像宽
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_AttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_AttachmentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_AttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_AttachmentEN> arrObjLst = new List<clsvcc_AttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_AttachmentEN objvcc_AttachmentEN = new clsvcc_AttachmentEN();
try
{
objvcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[convcc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objvcc_AttachmentEN.TableName = objRow[convcc_Attachment.TableName] == DBNull.Value ? null : objRow[convcc_Attachment.TableName].ToString().Trim(); //主表表名
objvcc_AttachmentEN.FileName = objRow[convcc_Attachment.FileName] == DBNull.Value ? null : objRow[convcc_Attachment.FileName].ToString().Trim(); //文件名称
objvcc_AttachmentEN.Extension = objRow[convcc_Attachment.Extension] == DBNull.Value ? null : objRow[convcc_Attachment.Extension].ToString().Trim(); //扩展名
objvcc_AttachmentEN.FilePath = objRow[convcc_Attachment.FilePath].ToString().Trim(); //文件路径
objvcc_AttachmentEN.FileSize = objRow[convcc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_Attachment.FileSize].ToString().Trim()); //文件大小
objvcc_AttachmentEN.FileSizeUnit = objRow[convcc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[convcc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvcc_AttachmentEN.UploadDate = objRow[convcc_Attachment.UploadDate].ToString().Trim(); //上传时间
objvcc_AttachmentEN.UploadPerson = objRow[convcc_Attachment.UploadPerson].ToString().Trim(); //上传人
objvcc_AttachmentEN.TableNameKey = objRow[convcc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objvcc_AttachmentEN.IdResourceType = objRow[convcc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvcc_AttachmentEN.ResourceTypeID = objRow[convcc_Attachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvcc_AttachmentEN.ResourceTypeName = objRow[convcc_Attachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvcc_AttachmentEN.UpdDate = objRow[convcc_Attachment.UpdDate].ToString().Trim(); //修改日期
objvcc_AttachmentEN.UpdUserId = objRow[convcc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[convcc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_AttachmentEN.Memo = objRow[convcc_Attachment.Memo] == DBNull.Value ? null : objRow[convcc_Attachment.Memo].ToString().Trim(); //备注
objvcc_AttachmentEN.ImageHeight = objRow[convcc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageHeight].ToString().Trim()); //图像高
objvcc_AttachmentEN.ImageWidth = objRow[convcc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageWidth].ToString().Trim()); //图像宽
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_AttachmentEN);
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
public static List<clsvcc_AttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_AttachmentEN> arrObjLst = new List<clsvcc_AttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_AttachmentEN objvcc_AttachmentEN = new clsvcc_AttachmentEN();
try
{
objvcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[convcc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objvcc_AttachmentEN.TableName = objRow[convcc_Attachment.TableName] == DBNull.Value ? null : objRow[convcc_Attachment.TableName].ToString().Trim(); //主表表名
objvcc_AttachmentEN.FileName = objRow[convcc_Attachment.FileName] == DBNull.Value ? null : objRow[convcc_Attachment.FileName].ToString().Trim(); //文件名称
objvcc_AttachmentEN.Extension = objRow[convcc_Attachment.Extension] == DBNull.Value ? null : objRow[convcc_Attachment.Extension].ToString().Trim(); //扩展名
objvcc_AttachmentEN.FilePath = objRow[convcc_Attachment.FilePath].ToString().Trim(); //文件路径
objvcc_AttachmentEN.FileSize = objRow[convcc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_Attachment.FileSize].ToString().Trim()); //文件大小
objvcc_AttachmentEN.FileSizeUnit = objRow[convcc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[convcc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvcc_AttachmentEN.UploadDate = objRow[convcc_Attachment.UploadDate].ToString().Trim(); //上传时间
objvcc_AttachmentEN.UploadPerson = objRow[convcc_Attachment.UploadPerson].ToString().Trim(); //上传人
objvcc_AttachmentEN.TableNameKey = objRow[convcc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objvcc_AttachmentEN.IdResourceType = objRow[convcc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvcc_AttachmentEN.ResourceTypeID = objRow[convcc_Attachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvcc_AttachmentEN.ResourceTypeName = objRow[convcc_Attachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvcc_AttachmentEN.UpdDate = objRow[convcc_Attachment.UpdDate].ToString().Trim(); //修改日期
objvcc_AttachmentEN.UpdUserId = objRow[convcc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[convcc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_AttachmentEN.Memo = objRow[convcc_Attachment.Memo] == DBNull.Value ? null : objRow[convcc_Attachment.Memo].ToString().Trim(); //备注
objvcc_AttachmentEN.ImageHeight = objRow[convcc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageHeight].ToString().Trim()); //图像高
objvcc_AttachmentEN.ImageWidth = objRow[convcc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageWidth].ToString().Trim()); //图像宽
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_AttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_AttachmentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_AttachmentEN> arrObjLst = new List<clsvcc_AttachmentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_AttachmentEN objvcc_AttachmentEN = new clsvcc_AttachmentEN();
try
{
objvcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[convcc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objvcc_AttachmentEN.TableName = objRow[convcc_Attachment.TableName] == DBNull.Value ? null : objRow[convcc_Attachment.TableName].ToString().Trim(); //主表表名
objvcc_AttachmentEN.FileName = objRow[convcc_Attachment.FileName] == DBNull.Value ? null : objRow[convcc_Attachment.FileName].ToString().Trim(); //文件名称
objvcc_AttachmentEN.Extension = objRow[convcc_Attachment.Extension] == DBNull.Value ? null : objRow[convcc_Attachment.Extension].ToString().Trim(); //扩展名
objvcc_AttachmentEN.FilePath = objRow[convcc_Attachment.FilePath].ToString().Trim(); //文件路径
objvcc_AttachmentEN.FileSize = objRow[convcc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_Attachment.FileSize].ToString().Trim()); //文件大小
objvcc_AttachmentEN.FileSizeUnit = objRow[convcc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[convcc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvcc_AttachmentEN.UploadDate = objRow[convcc_Attachment.UploadDate].ToString().Trim(); //上传时间
objvcc_AttachmentEN.UploadPerson = objRow[convcc_Attachment.UploadPerson].ToString().Trim(); //上传人
objvcc_AttachmentEN.TableNameKey = objRow[convcc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objvcc_AttachmentEN.IdResourceType = objRow[convcc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvcc_AttachmentEN.ResourceTypeID = objRow[convcc_Attachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvcc_AttachmentEN.ResourceTypeName = objRow[convcc_Attachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvcc_AttachmentEN.UpdDate = objRow[convcc_Attachment.UpdDate].ToString().Trim(); //修改日期
objvcc_AttachmentEN.UpdUserId = objRow[convcc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[convcc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_AttachmentEN.Memo = objRow[convcc_Attachment.Memo] == DBNull.Value ? null : objRow[convcc_Attachment.Memo].ToString().Trim(); //备注
objvcc_AttachmentEN.ImageHeight = objRow[convcc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageHeight].ToString().Trim()); //图像高
objvcc_AttachmentEN.ImageWidth = objRow[convcc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Attachment.ImageWidth].ToString().Trim()); //图像宽
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_AttachmentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_Attachment(ref clsvcc_AttachmentEN objvcc_AttachmentEN)
{
bool bolResult = vcc_AttachmentDA.Getvcc_Attachment(ref objvcc_AttachmentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngAttachmentID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_AttachmentEN GetObjByAttachmentID(long lngAttachmentID)
{
clsvcc_AttachmentEN objvcc_AttachmentEN = vcc_AttachmentDA.GetObjByAttachmentID(lngAttachmentID);
return objvcc_AttachmentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_AttachmentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_AttachmentEN objvcc_AttachmentEN = vcc_AttachmentDA.GetFirstObj(strWhereCond);
 return objvcc_AttachmentEN;
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
public static clsvcc_AttachmentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_AttachmentEN objvcc_AttachmentEN = vcc_AttachmentDA.GetObjByDataRow(objRow);
 return objvcc_AttachmentEN;
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
public static clsvcc_AttachmentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_AttachmentEN objvcc_AttachmentEN = vcc_AttachmentDA.GetObjByDataRow(objRow);
 return objvcc_AttachmentEN;
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
 /// <param name = "lngAttachmentID">所给的关键字</param>
 /// <param name = "lstvcc_AttachmentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_AttachmentEN GetObjByAttachmentIDFromList(long lngAttachmentID, List<clsvcc_AttachmentEN> lstvcc_AttachmentObjLst)
{
foreach (clsvcc_AttachmentEN objvcc_AttachmentEN in lstvcc_AttachmentObjLst)
{
if (objvcc_AttachmentEN.AttachmentID == lngAttachmentID)
{
return objvcc_AttachmentEN;
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
 long lngAttachmentID;
 try
 {
 lngAttachmentID = new clsvcc_AttachmentDA().GetFirstID(strWhereCond);
 return lngAttachmentID;
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
 arrList = vcc_AttachmentDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_AttachmentDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngAttachmentID">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngAttachmentID)
{
//检测记录是否存在
bool bolIsExist = vcc_AttachmentDA.IsExist(lngAttachmentID);
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
 bolIsExist = clsvcc_AttachmentDA.IsExistTable();
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
 bolIsExist = vcc_AttachmentDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_AttachmentENS">源对象</param>
 /// <param name = "objvcc_AttachmentENT">目标对象</param>
 public static void CopyTo(clsvcc_AttachmentEN objvcc_AttachmentENS, clsvcc_AttachmentEN objvcc_AttachmentENT)
{
try
{
objvcc_AttachmentENT.AttachmentID = objvcc_AttachmentENS.AttachmentID; //附件流水号
objvcc_AttachmentENT.TableName = objvcc_AttachmentENS.TableName; //主表表名
objvcc_AttachmentENT.FileName = objvcc_AttachmentENS.FileName; //文件名称
objvcc_AttachmentENT.Extension = objvcc_AttachmentENS.Extension; //扩展名
objvcc_AttachmentENT.FilePath = objvcc_AttachmentENS.FilePath; //文件路径
objvcc_AttachmentENT.FileSize = objvcc_AttachmentENS.FileSize; //文件大小
objvcc_AttachmentENT.FileSizeUnit = objvcc_AttachmentENS.FileSizeUnit; //文件大小单位
objvcc_AttachmentENT.UploadDate = objvcc_AttachmentENS.UploadDate; //上传时间
objvcc_AttachmentENT.UploadPerson = objvcc_AttachmentENS.UploadPerson; //上传人
objvcc_AttachmentENT.TableNameKey = objvcc_AttachmentENS.TableNameKey; //主表主键值
objvcc_AttachmentENT.IdResourceType = objvcc_AttachmentENS.IdResourceType; //资源类型流水号
objvcc_AttachmentENT.ResourceTypeID = objvcc_AttachmentENS.ResourceTypeID; //资源类型ID
objvcc_AttachmentENT.ResourceTypeName = objvcc_AttachmentENS.ResourceTypeName; //资源类型名称
objvcc_AttachmentENT.UpdDate = objvcc_AttachmentENS.UpdDate; //修改日期
objvcc_AttachmentENT.UpdUserId = objvcc_AttachmentENS.UpdUserId; //修改用户Id
objvcc_AttachmentENT.Memo = objvcc_AttachmentENS.Memo; //备注
objvcc_AttachmentENT.ImageHeight = objvcc_AttachmentENS.ImageHeight; //图像高
objvcc_AttachmentENT.ImageWidth = objvcc_AttachmentENS.ImageWidth; //图像宽
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
 /// <param name = "objvcc_AttachmentEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_AttachmentEN objvcc_AttachmentEN)
{
try
{
objvcc_AttachmentEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_AttachmentEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_Attachment.AttachmentID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_AttachmentEN.AttachmentID = objvcc_AttachmentEN.AttachmentID; //附件流水号
}
if (arrFldSet.Contains(convcc_Attachment.TableName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_AttachmentEN.TableName = objvcc_AttachmentEN.TableName == "[null]" ? null :  objvcc_AttachmentEN.TableName; //主表表名
}
if (arrFldSet.Contains(convcc_Attachment.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_AttachmentEN.FileName = objvcc_AttachmentEN.FileName == "[null]" ? null :  objvcc_AttachmentEN.FileName; //文件名称
}
if (arrFldSet.Contains(convcc_Attachment.Extension, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_AttachmentEN.Extension = objvcc_AttachmentEN.Extension == "[null]" ? null :  objvcc_AttachmentEN.Extension; //扩展名
}
if (arrFldSet.Contains(convcc_Attachment.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_AttachmentEN.FilePath = objvcc_AttachmentEN.FilePath; //文件路径
}
if (arrFldSet.Contains(convcc_Attachment.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_AttachmentEN.FileSize = objvcc_AttachmentEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convcc_Attachment.FileSizeUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_AttachmentEN.FileSizeUnit = objvcc_AttachmentEN.FileSizeUnit == "[null]" ? null :  objvcc_AttachmentEN.FileSizeUnit; //文件大小单位
}
if (arrFldSet.Contains(convcc_Attachment.UploadDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_AttachmentEN.UploadDate = objvcc_AttachmentEN.UploadDate; //上传时间
}
if (arrFldSet.Contains(convcc_Attachment.UploadPerson, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_AttachmentEN.UploadPerson = objvcc_AttachmentEN.UploadPerson; //上传人
}
if (arrFldSet.Contains(convcc_Attachment.TableNameKey, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_AttachmentEN.TableNameKey = objvcc_AttachmentEN.TableNameKey; //主表主键值
}
if (arrFldSet.Contains(convcc_Attachment.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_AttachmentEN.IdResourceType = objvcc_AttachmentEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convcc_Attachment.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_AttachmentEN.ResourceTypeID = objvcc_AttachmentEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convcc_Attachment.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_AttachmentEN.ResourceTypeName = objvcc_AttachmentEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convcc_Attachment.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_AttachmentEN.UpdDate = objvcc_AttachmentEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_Attachment.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_AttachmentEN.UpdUserId = objvcc_AttachmentEN.UpdUserId == "[null]" ? null :  objvcc_AttachmentEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convcc_Attachment.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_AttachmentEN.Memo = objvcc_AttachmentEN.Memo == "[null]" ? null :  objvcc_AttachmentEN.Memo; //备注
}
if (arrFldSet.Contains(convcc_Attachment.ImageHeight, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_AttachmentEN.ImageHeight = objvcc_AttachmentEN.ImageHeight; //图像高
}
if (arrFldSet.Contains(convcc_Attachment.ImageWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_AttachmentEN.ImageWidth = objvcc_AttachmentEN.ImageWidth; //图像宽
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
 /// <param name = "objvcc_AttachmentEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_AttachmentEN objvcc_AttachmentEN)
{
try
{
if (objvcc_AttachmentEN.TableName == "[null]") objvcc_AttachmentEN.TableName = null; //主表表名
if (objvcc_AttachmentEN.FileName == "[null]") objvcc_AttachmentEN.FileName = null; //文件名称
if (objvcc_AttachmentEN.Extension == "[null]") objvcc_AttachmentEN.Extension = null; //扩展名
if (objvcc_AttachmentEN.FileSizeUnit == "[null]") objvcc_AttachmentEN.FileSizeUnit = null; //文件大小单位
if (objvcc_AttachmentEN.UpdUserId == "[null]") objvcc_AttachmentEN.UpdUserId = null; //修改用户Id
if (objvcc_AttachmentEN.Memo == "[null]") objvcc_AttachmentEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvcc_AttachmentEN objvcc_AttachmentEN)
{
 vcc_AttachmentDA.CheckProperty4Condition(objvcc_AttachmentEN);
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
if (clsResourceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeBL没有刷新缓存机制(clsResourceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_AttachmentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_AttachmentBL没有刷新缓存机制(clscc_AttachmentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by AttachmentID");
//if (arrvcc_AttachmentObjLstCache == null)
//{
//arrvcc_AttachmentObjLstCache = vcc_AttachmentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngAttachmentID">所给的关键字</param>
 /// <param name = "strTableName">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_AttachmentEN GetObjByAttachmentIDCache(long lngAttachmentID, string strTableName)
{

if (string.IsNullOrEmpty(strTableName) == true)
{
  var strMsg = string.Format("参数:[strTableName]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strTableName.Length != 100)
{
var strMsg = string.Format("缓存分类变量:[strTableName]的长度:[{0}]不正确!(In {1})", strTableName.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvcc_AttachmentEN._CurrTabName, strTableName);
List<clsvcc_AttachmentEN> arrvcc_AttachmentObjLstCache = GetObjLstCache(strTableName);
IEnumerable <clsvcc_AttachmentEN> arrvcc_AttachmentObjLst_Sel =
arrvcc_AttachmentObjLstCache
.Where(x=> x.AttachmentID == lngAttachmentID 
);
if (arrvcc_AttachmentObjLst_Sel.Count() == 0)
{
   clsvcc_AttachmentEN obj = clsvcc_AttachmentBL.GetObjByAttachmentID(lngAttachmentID);
   if (obj != null)
 {
if (obj.TableName == strTableName)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngAttachmentID, strTableName, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvcc_AttachmentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_AttachmentEN> GetAllvcc_AttachmentObjLstCache(string strTableName)
{
//获取缓存中的对象列表
List<clsvcc_AttachmentEN> arrvcc_AttachmentObjLstCache = GetObjLstCache(strTableName); 
return arrvcc_AttachmentObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_AttachmentEN> GetObjLstCache(string strTableName)
{

if (string.IsNullOrEmpty(strTableName) == true)
{
  var strMsg = string.Format("参数:[strTableName]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strTableName.Length != 100)
{
var strMsg = string.Format("缓存分类变量:[strTableName]的长度:[{0}]不正确!(In {1})", strTableName.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_AttachmentEN._CurrTabName, strTableName);
string strCondition = string.Format("TableName='{0}'", strTableName);
List<clsvcc_AttachmentEN> arrvcc_AttachmentObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvcc_AttachmentObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strTableName = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvcc_AttachmentEN._CurrTabName, strTableName);
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
 /// <param name = "strTableName">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngAttachmentID, string strTableName)
{
if (strInFldName != convcc_Attachment.AttachmentID)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_Attachment.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_Attachment.AttributeName));
throw new Exception(strMsg);
}
var objvcc_Attachment = clsvcc_AttachmentBL.GetObjByAttachmentIDCache(lngAttachmentID, strTableName);
if (objvcc_Attachment == null) return "";
return objvcc_Attachment[strOutFldName].ToString();
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
int intRecCount = clsvcc_AttachmentDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_AttachmentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_AttachmentDA.GetRecCount();
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
int intRecCount = clsvcc_AttachmentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_AttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_AttachmentEN objvcc_AttachmentCond)
{
 string strTableName = objvcc_AttachmentCond.TableName;
 if (string.IsNullOrEmpty(strTableName) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvcc_AttachmentBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvcc_AttachmentEN> arrObjLstCache = GetObjLstCache(strTableName);
IEnumerable <clsvcc_AttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_Attachment.AttributeName)
{
if (objvcc_AttachmentCond.IsUpdated(strFldName) == false) continue;
if (objvcc_AttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_AttachmentCond[strFldName].ToString());
}
else
{
if (objvcc_AttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_AttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_AttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_AttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_AttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_AttachmentCond[strFldName]));
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
 List<string> arrList = clsvcc_AttachmentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_AttachmentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_AttachmentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}