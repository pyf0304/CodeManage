
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_AttachmentWApi
 表名:vcc_Attachment(01120160)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:49
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:其他
 模块英文名:Other
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
public static class clsvcc_AttachmentWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_AttachmentEN SetTableName(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strTableName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTableName, 100, convcc_Attachment.TableName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_AttachmentEN SetFileName(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convcc_Attachment.FileName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_AttachmentEN SetExtension(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strExtension, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExtension, 10, convcc_Attachment.Extension);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_AttachmentEN SetFilePath(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convcc_Attachment.FilePath);
clsCheckSql.CheckFieldLen(strFilePath, 500, convcc_Attachment.FilePath);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_AttachmentEN SetFileSize(this clsvcc_AttachmentEN objvcc_AttachmentEN, double dblFileSize, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_AttachmentEN SetFileSizeUnit(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strFileSizeUnit, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSizeUnit, 10, convcc_Attachment.FileSizeUnit);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_AttachmentEN SetUploadDate(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strUploadDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUploadDate, convcc_Attachment.UploadDate);
clsCheckSql.CheckFieldLen(strUploadDate, 20, convcc_Attachment.UploadDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_AttachmentEN SetUploadPerson(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strUploadPerson, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUploadPerson, convcc_Attachment.UploadPerson);
clsCheckSql.CheckFieldLen(strUploadPerson, 20, convcc_Attachment.UploadPerson);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_AttachmentEN SetTableNameKey(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strTableNameKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTableNameKey, convcc_Attachment.TableNameKey);
clsCheckSql.CheckFieldLen(strTableNameKey, 20, convcc_Attachment.TableNameKey);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_AttachmentEN Setid_ResourceType(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, convcc_Attachment.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convcc_Attachment.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convcc_Attachment.id_ResourceType);
objvcc_AttachmentEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_AttachmentEN.dicFldComparisonOp.ContainsKey(convcc_Attachment.id_ResourceType) == false)
{
objvcc_AttachmentEN.dicFldComparisonOp.Add(convcc_Attachment.id_ResourceType, strComparisonOp);
}
else
{
objvcc_AttachmentEN.dicFldComparisonOp[convcc_Attachment.id_ResourceType] = strComparisonOp;
}
}
return objvcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_AttachmentEN SetResourceTypeID(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convcc_Attachment.ResourceTypeID);
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convcc_Attachment.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convcc_Attachment.ResourceTypeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_AttachmentEN SetResourceTypeName(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convcc_Attachment.ResourceTypeName);
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convcc_Attachment.ResourceTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_AttachmentEN SetUpdDate(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_Attachment.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_Attachment.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_AttachmentEN SetUpdUserId(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_Attachment.UpdUserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_AttachmentEN SetMemo(this clsvcc_AttachmentEN objvcc_AttachmentEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_Attachment.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_AttachmentEN SetImageHeight(this clsvcc_AttachmentEN objvcc_AttachmentEN, int intImageHeight, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_AttachmentEN SetImageWidth(this clsvcc_AttachmentEN objvcc_AttachmentEN, int intImageWidth, string strComparisonOp="")
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_AttachmentEN objvcc_Attachment_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_Attachment_Cond.IsUpdated(convcc_Attachment.AttachmentID) == true)
{
string strComparisonOp_AttachmentID = objvcc_Attachment_Cond.dicFldComparisonOp[convcc_Attachment.AttachmentID];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Attachment.AttachmentID, objvcc_Attachment_Cond.AttachmentID, strComparisonOp_AttachmentID);
}
if (objvcc_Attachment_Cond.IsUpdated(convcc_Attachment.TableName) == true)
{
string strComparisonOp_TableName = objvcc_Attachment_Cond.dicFldComparisonOp[convcc_Attachment.TableName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.TableName, objvcc_Attachment_Cond.TableName, strComparisonOp_TableName);
}
if (objvcc_Attachment_Cond.IsUpdated(convcc_Attachment.FileName) == true)
{
string strComparisonOp_FileName = objvcc_Attachment_Cond.dicFldComparisonOp[convcc_Attachment.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.FileName, objvcc_Attachment_Cond.FileName, strComparisonOp_FileName);
}
if (objvcc_Attachment_Cond.IsUpdated(convcc_Attachment.Extension) == true)
{
string strComparisonOp_Extension = objvcc_Attachment_Cond.dicFldComparisonOp[convcc_Attachment.Extension];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.Extension, objvcc_Attachment_Cond.Extension, strComparisonOp_Extension);
}
if (objvcc_Attachment_Cond.IsUpdated(convcc_Attachment.FilePath) == true)
{
string strComparisonOp_FilePath = objvcc_Attachment_Cond.dicFldComparisonOp[convcc_Attachment.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.FilePath, objvcc_Attachment_Cond.FilePath, strComparisonOp_FilePath);
}
if (objvcc_Attachment_Cond.IsUpdated(convcc_Attachment.FileSize) == true)
{
string strComparisonOp_FileSize = objvcc_Attachment_Cond.dicFldComparisonOp[convcc_Attachment.FileSize];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Attachment.FileSize, objvcc_Attachment_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvcc_Attachment_Cond.IsUpdated(convcc_Attachment.FileSizeUnit) == true)
{
string strComparisonOp_FileSizeUnit = objvcc_Attachment_Cond.dicFldComparisonOp[convcc_Attachment.FileSizeUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.FileSizeUnit, objvcc_Attachment_Cond.FileSizeUnit, strComparisonOp_FileSizeUnit);
}
if (objvcc_Attachment_Cond.IsUpdated(convcc_Attachment.UploadDate) == true)
{
string strComparisonOp_UploadDate = objvcc_Attachment_Cond.dicFldComparisonOp[convcc_Attachment.UploadDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.UploadDate, objvcc_Attachment_Cond.UploadDate, strComparisonOp_UploadDate);
}
if (objvcc_Attachment_Cond.IsUpdated(convcc_Attachment.UploadPerson) == true)
{
string strComparisonOp_UploadPerson = objvcc_Attachment_Cond.dicFldComparisonOp[convcc_Attachment.UploadPerson];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.UploadPerson, objvcc_Attachment_Cond.UploadPerson, strComparisonOp_UploadPerson);
}
if (objvcc_Attachment_Cond.IsUpdated(convcc_Attachment.TableNameKey) == true)
{
string strComparisonOp_TableNameKey = objvcc_Attachment_Cond.dicFldComparisonOp[convcc_Attachment.TableNameKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.TableNameKey, objvcc_Attachment_Cond.TableNameKey, strComparisonOp_TableNameKey);
}
if (objvcc_Attachment_Cond.IsUpdated(convcc_Attachment.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvcc_Attachment_Cond.dicFldComparisonOp[convcc_Attachment.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.id_ResourceType, objvcc_Attachment_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvcc_Attachment_Cond.IsUpdated(convcc_Attachment.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvcc_Attachment_Cond.dicFldComparisonOp[convcc_Attachment.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.ResourceTypeID, objvcc_Attachment_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvcc_Attachment_Cond.IsUpdated(convcc_Attachment.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvcc_Attachment_Cond.dicFldComparisonOp[convcc_Attachment.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.ResourceTypeName, objvcc_Attachment_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvcc_Attachment_Cond.IsUpdated(convcc_Attachment.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_Attachment_Cond.dicFldComparisonOp[convcc_Attachment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.UpdDate, objvcc_Attachment_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_Attachment_Cond.IsUpdated(convcc_Attachment.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_Attachment_Cond.dicFldComparisonOp[convcc_Attachment.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.UpdUserId, objvcc_Attachment_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_Attachment_Cond.IsUpdated(convcc_Attachment.Memo) == true)
{
string strComparisonOp_Memo = objvcc_Attachment_Cond.dicFldComparisonOp[convcc_Attachment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Attachment.Memo, objvcc_Attachment_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_Attachment_Cond.IsUpdated(convcc_Attachment.ImageHeight) == true)
{
string strComparisonOp_ImageHeight = objvcc_Attachment_Cond.dicFldComparisonOp[convcc_Attachment.ImageHeight];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Attachment.ImageHeight, objvcc_Attachment_Cond.ImageHeight, strComparisonOp_ImageHeight);
}
if (objvcc_Attachment_Cond.IsUpdated(convcc_Attachment.ImageWidth) == true)
{
string strComparisonOp_ImageWidth = objvcc_Attachment_Cond.dicFldComparisonOp[convcc_Attachment.ImageWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Attachment.ImageWidth, objvcc_Attachment_Cond.ImageWidth, strComparisonOp_ImageWidth);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v附件(vcc_Attachment)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_AttachmentWApi
{
private static readonly string mstrApiControllerName = "vcc_AttachmentApi";

 public clsvcc_AttachmentWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngAttachmentID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_AttachmentEN GetObjByAttachmentID(long lngAttachmentID)
{
string strAction = "GetObjByAttachmentID";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_AttachmentEN objvcc_AttachmentEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["AttachmentID"] = lngAttachmentID.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_AttachmentEN = JsonConvert.DeserializeObject<clsvcc_AttachmentEN>((string)jobjReturn["ReturnObj"]);
return objvcc_AttachmentEN;
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
 /// <param name = "lngAttachmentID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_AttachmentEN GetObjByAttachmentID_WA_Cache(long lngAttachmentID, string strTableName)
{
string strAction = "GetObjByAttachmentID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_AttachmentEN objvcc_AttachmentEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["AttachmentID"] = lngAttachmentID.ToString(),
["TableName"] = strTableName
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_AttachmentEN = JsonConvert.DeserializeObject<clsvcc_AttachmentEN>((string)jobjReturn["ReturnObj"]);
return objvcc_AttachmentEN;
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
public static clsvcc_AttachmentEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_AttachmentEN objvcc_AttachmentEN = null;
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
objvcc_AttachmentEN = JsonConvert.DeserializeObject<clsvcc_AttachmentEN>((string)jobjReturn["ReturnObj"]);
return objvcc_AttachmentEN;
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
 /// <param name = "lngAttachmentID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_AttachmentEN GetObjByAttachmentID_Cache(long lngAttachmentID, string strTableName)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_AttachmentEN._CurrTabName_S, strTableName);
List<clsvcc_AttachmentEN> arrvcc_AttachmentObjLst_Cache = GetObjLst_Cache(strTableName);
IEnumerable <clsvcc_AttachmentEN> arrvcc_AttachmentObjLst_Sel =
from objvcc_AttachmentEN in arrvcc_AttachmentObjLst_Cache
where objvcc_AttachmentEN.AttachmentID == lngAttachmentID
select objvcc_AttachmentEN;
if (arrvcc_AttachmentObjLst_Sel.Count() == 0)
{
   clsvcc_AttachmentEN obj = clsvcc_AttachmentWApi.GetObjByAttachmentID(lngAttachmentID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_AttachmentObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_AttachmentEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_AttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_AttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_AttachmentEN> GetObjLstByAttachmentIDLst(List<long> arrAttachmentID)
{
 List<clsvcc_AttachmentEN> arrObjLst = null; 
string strAction = "GetObjLstByAttachmentIDLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrAttachmentID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_AttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngAttachmentID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_AttachmentEN> GetObjLstByAttachmentIDLst_Cache(List<long> arrAttachmentID, string strTableName)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_AttachmentEN._CurrTabName_S, strTableName);
List<clsvcc_AttachmentEN> arrvcc_AttachmentObjLst_Cache = GetObjLst_Cache(strTableName);
IEnumerable <clsvcc_AttachmentEN> arrvcc_AttachmentObjLst_Sel =
from objvcc_AttachmentEN in arrvcc_AttachmentObjLst_Cache
where arrAttachmentID.Contains(objvcc_AttachmentEN.AttachmentID)
select objvcc_AttachmentEN;
return arrvcc_AttachmentObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_AttachmentEN> GetObjLstByAttachmentIDLst_WA_Cache(List<long> arrAttachmentID, string strTableName)
{
 List<clsvcc_AttachmentEN> arrObjLst = null; 
string strAction = "GetObjLstByAttachmentIDLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["TableName"] = strTableName
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrAttachmentID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_AttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_AttachmentEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_AttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_AttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_AttachmentEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_AttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_AttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_AttachmentEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_AttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_AttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_AttachmentEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_AttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_AttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngAttachmentID)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["AttachmentID"] = lngAttachmentID.ToString()
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
objvcc_AttachmentENT.id_ResourceType = objvcc_AttachmentENS.id_ResourceType; //资源类型流水号
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
public static DataTable ToDataTable(List<clsvcc_AttachmentEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_AttachmentEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_AttachmentEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_AttachmentEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_AttachmentEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_AttachmentEN.AttributeName)
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
if (clsResourceTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeWApi没有刷新缓存机制(clsResourceTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_AttachmentWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_AttachmentWApi没有刷新缓存机制(clscc_AttachmentWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by AttachmentID");
//if (arrvcc_AttachmentObjLst_Cache == null)
//{
//arrvcc_AttachmentObjLst_Cache = await clsvcc_AttachmentWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strTableName = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvcc_AttachmentEN._CurrTabName_S, strTableName);
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
public static List<clsvcc_AttachmentEN> GetObjLst_Cache(string strTableName)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_AttachmentEN._CurrTabName_S, strTableName);
List<clsvcc_AttachmentEN> arrvcc_AttachmentObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("TableName='{0}'", strTableName)); });
return arrvcc_AttachmentObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_AttachmentEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_Attachment.AttachmentID, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_Attachment.TableName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Attachment.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Attachment.Extension, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Attachment.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Attachment.FileSize, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_Attachment.FileSizeUnit, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Attachment.UploadDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Attachment.UploadPerson, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Attachment.TableNameKey, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Attachment.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Attachment.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Attachment.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Attachment.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Attachment.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Attachment.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Attachment.ImageHeight, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_Attachment.ImageWidth, Type.GetType("System.Int32"));
foreach (clsvcc_AttachmentEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_Attachment.AttachmentID] = objInFor[convcc_Attachment.AttachmentID];
objDR[convcc_Attachment.TableName] = objInFor[convcc_Attachment.TableName];
objDR[convcc_Attachment.FileName] = objInFor[convcc_Attachment.FileName];
objDR[convcc_Attachment.Extension] = objInFor[convcc_Attachment.Extension];
objDR[convcc_Attachment.FilePath] = objInFor[convcc_Attachment.FilePath];
objDR[convcc_Attachment.FileSize] = objInFor[convcc_Attachment.FileSize];
objDR[convcc_Attachment.FileSizeUnit] = objInFor[convcc_Attachment.FileSizeUnit];
objDR[convcc_Attachment.UploadDate] = objInFor[convcc_Attachment.UploadDate];
objDR[convcc_Attachment.UploadPerson] = objInFor[convcc_Attachment.UploadPerson];
objDR[convcc_Attachment.TableNameKey] = objInFor[convcc_Attachment.TableNameKey];
objDR[convcc_Attachment.id_ResourceType] = objInFor[convcc_Attachment.id_ResourceType];
objDR[convcc_Attachment.ResourceTypeID] = objInFor[convcc_Attachment.ResourceTypeID];
objDR[convcc_Attachment.ResourceTypeName] = objInFor[convcc_Attachment.ResourceTypeName];
objDR[convcc_Attachment.UpdDate] = objInFor[convcc_Attachment.UpdDate];
objDR[convcc_Attachment.UpdUserId] = objInFor[convcc_Attachment.UpdUserId];
objDR[convcc_Attachment.Memo] = objInFor[convcc_Attachment.Memo];
objDR[convcc_Attachment.ImageHeight] = objInFor[convcc_Attachment.ImageHeight];
objDR[convcc_Attachment.ImageWidth] = objInFor[convcc_Attachment.ImageWidth];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}