
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvtz_ContentAttachmentWApi
 表名:vtz_ContentAttachment(01120208)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:11
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
public static class clsvtz_ContentAttachmentWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetmId(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, long lngmId, string strComparisonOp="")
	{
objvtz_ContentAttachmentEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.mId) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.mId, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.mId] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetContentTypeId(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strContentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strContentTypeId, convtz_ContentAttachment.ContentTypeId);
clsCheckSql.CheckFieldLen(strContentTypeId, 4, convtz_ContentAttachment.ContentTypeId);
clsCheckSql.CheckFieldForeignKey(strContentTypeId, 4, convtz_ContentAttachment.ContentTypeId);
objvtz_ContentAttachmentEN.ContentTypeId = strContentTypeId; //内容类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.ContentTypeId) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.ContentTypeId, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.ContentTypeId] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetContentTypeName(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strContentTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strContentTypeName, 50, convtz_ContentAttachment.ContentTypeName);
objvtz_ContentAttachmentEN.ContentTypeName = strContentTypeName; //内容类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.ContentTypeName) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.ContentTypeName, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.ContentTypeName] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetTableName(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strTableName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTableName, 100, convtz_ContentAttachment.TableName);
objvtz_ContentAttachmentEN.TableName = strTableName; //主表表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.TableName) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.TableName, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.TableName] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetFldName(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convtz_ContentAttachment.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, convtz_ContentAttachment.FldName);
objvtz_ContentAttachmentEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.FldName) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.FldName, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.FldName] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetTableNameKey(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strTableNameKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTableNameKey, convtz_ContentAttachment.TableNameKey);
clsCheckSql.CheckFieldLen(strTableNameKey, 20, convtz_ContentAttachment.TableNameKey);
objvtz_ContentAttachmentEN.TableNameKey = strTableNameKey; //主表主键值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.TableNameKey) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.TableNameKey, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.TableNameKey] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetOrderNum(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, int intOrderNum, string strComparisonOp="")
	{
objvtz_ContentAttachmentEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.OrderNum) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.OrderNum, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.OrderNum] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetAttachmentTitle(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strAttachmentTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAttachmentTitle, 100, convtz_ContentAttachment.AttachmentTitle);
objvtz_ContentAttachmentEN.AttachmentTitle = strAttachmentTitle; //附件标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.AttachmentTitle) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.AttachmentTitle, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.AttachmentTitle] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN Setid_ResourceType(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, convtz_ContentAttachment.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convtz_ContentAttachment.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convtz_ContentAttachment.id_ResourceType);
objvtz_ContentAttachmentEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.id_ResourceType) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.id_ResourceType, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.id_ResourceType] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetResourceTypeID(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convtz_ContentAttachment.ResourceTypeID);
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convtz_ContentAttachment.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convtz_ContentAttachment.ResourceTypeID);
objvtz_ContentAttachmentEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.ResourceTypeID) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.ResourceTypeID, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.ResourceTypeID] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetResourceTypeName(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convtz_ContentAttachment.ResourceTypeName);
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convtz_ContentAttachment.ResourceTypeName);
objvtz_ContentAttachmentEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.ResourceTypeName) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.ResourceTypeName, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.ResourceTypeName] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetTextContent(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strTextContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextContent, convtz_ContentAttachment.TextContent);
clsCheckSql.CheckFieldLen(strTextContent, 8000, convtz_ContentAttachment.TextContent);
objvtz_ContentAttachmentEN.TextContent = strTextContent; //文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.TextContent) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.TextContent, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.TextContent] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetFileName(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convtz_ContentAttachment.FileName);
objvtz_ContentAttachmentEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.FileName) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.FileName, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.FileName] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetExtension(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strExtension, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExtension, 10, convtz_ContentAttachment.Extension);
objvtz_ContentAttachmentEN.Extension = strExtension; //扩展名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.Extension) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.Extension, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.Extension] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetFilePath(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convtz_ContentAttachment.FilePath);
clsCheckSql.CheckFieldLen(strFilePath, 500, convtz_ContentAttachment.FilePath);
objvtz_ContentAttachmentEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.FilePath) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.FilePath, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.FilePath] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetPdfFilePath(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strPdfFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPdfFilePath, 500, convtz_ContentAttachment.PdfFilePath);
objvtz_ContentAttachmentEN.PdfFilePath = strPdfFilePath; //Pdf文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.PdfFilePath) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.PdfFilePath, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.PdfFilePath] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetSwfFilePath(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strSwfFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSwfFilePath, 500, convtz_ContentAttachment.SwfFilePath);
objvtz_ContentAttachmentEN.SwfFilePath = strSwfFilePath; //Swf文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.SwfFilePath) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.SwfFilePath, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.SwfFilePath] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetFileSize(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, double dblFileSize, string strComparisonOp="")
	{
objvtz_ContentAttachmentEN.FileSize = dblFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.FileSize) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.FileSize, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.FileSize] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetFileSizeUnit(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strFileSizeUnit, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSizeUnit, 10, convtz_ContentAttachment.FileSizeUnit);
objvtz_ContentAttachmentEN.FileSizeUnit = strFileSizeUnit; //文件大小单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.FileSizeUnit) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.FileSizeUnit, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.FileSizeUnit] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetImageHeight(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, int intImageHeight, string strComparisonOp="")
	{
objvtz_ContentAttachmentEN.ImageHeight = intImageHeight; //图像高
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.ImageHeight) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.ImageHeight, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.ImageHeight] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetImageWidth(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, int intImageWidth, string strComparisonOp="")
	{
objvtz_ContentAttachmentEN.ImageWidth = intImageWidth; //图像宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.ImageWidth) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.ImageWidth, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.ImageWidth] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetUploadDate(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strUploadDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUploadDate, convtz_ContentAttachment.UploadDate);
clsCheckSql.CheckFieldLen(strUploadDate, 20, convtz_ContentAttachment.UploadDate);
objvtz_ContentAttachmentEN.UploadDate = strUploadDate; //上传时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.UploadDate) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.UploadDate, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.UploadDate] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetUploadPerson(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strUploadPerson, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUploadPerson, convtz_ContentAttachment.UploadPerson);
clsCheckSql.CheckFieldLen(strUploadPerson, 20, convtz_ContentAttachment.UploadPerson);
objvtz_ContentAttachmentEN.UploadPerson = strUploadPerson; //上传人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.UploadPerson) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.UploadPerson, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.UploadPerson] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetUpdDate(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convtz_ContentAttachment.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convtz_ContentAttachment.UpdDate);
objvtz_ContentAttachmentEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.UpdDate) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.UpdDate, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.UpdDate] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetUpdUserId(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convtz_ContentAttachment.UpdUserId);
objvtz_ContentAttachmentEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.UpdUserId) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.UpdUserId, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.UpdUserId] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetMemo(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convtz_ContentAttachment.Memo);
objvtz_ContentAttachmentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.Memo) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.Memo, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.Memo] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetCourseId(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convtz_ContentAttachment.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convtz_ContentAttachment.CourseId);
objvtz_ContentAttachmentEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.CourseId) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.CourseId, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.CourseId] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvtz_ContentAttachmentEN objvtz_ContentAttachment_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.mId) == true)
{
string strComparisonOp_mId = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convtz_ContentAttachment.mId, objvtz_ContentAttachment_Cond.mId, strComparisonOp_mId);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.ContentTypeId) == true)
{
string strComparisonOp_ContentTypeId = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.ContentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.ContentTypeId, objvtz_ContentAttachment_Cond.ContentTypeId, strComparisonOp_ContentTypeId);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.ContentTypeName) == true)
{
string strComparisonOp_ContentTypeName = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.ContentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.ContentTypeName, objvtz_ContentAttachment_Cond.ContentTypeName, strComparisonOp_ContentTypeName);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.TableName) == true)
{
string strComparisonOp_TableName = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.TableName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.TableName, objvtz_ContentAttachment_Cond.TableName, strComparisonOp_TableName);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.FldName) == true)
{
string strComparisonOp_FldName = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.FldName, objvtz_ContentAttachment_Cond.FldName, strComparisonOp_FldName);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.TableNameKey) == true)
{
string strComparisonOp_TableNameKey = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.TableNameKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.TableNameKey, objvtz_ContentAttachment_Cond.TableNameKey, strComparisonOp_TableNameKey);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convtz_ContentAttachment.OrderNum, objvtz_ContentAttachment_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.AttachmentTitle) == true)
{
string strComparisonOp_AttachmentTitle = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.AttachmentTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.AttachmentTitle, objvtz_ContentAttachment_Cond.AttachmentTitle, strComparisonOp_AttachmentTitle);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.id_ResourceType, objvtz_ContentAttachment_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.ResourceTypeID, objvtz_ContentAttachment_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.ResourceTypeName, objvtz_ContentAttachment_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.TextContent) == true)
{
string strComparisonOp_TextContent = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.TextContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.TextContent, objvtz_ContentAttachment_Cond.TextContent, strComparisonOp_TextContent);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.FileName) == true)
{
string strComparisonOp_FileName = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.FileName, objvtz_ContentAttachment_Cond.FileName, strComparisonOp_FileName);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.Extension) == true)
{
string strComparisonOp_Extension = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.Extension];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.Extension, objvtz_ContentAttachment_Cond.Extension, strComparisonOp_Extension);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.FilePath) == true)
{
string strComparisonOp_FilePath = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.FilePath, objvtz_ContentAttachment_Cond.FilePath, strComparisonOp_FilePath);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.PdfFilePath) == true)
{
string strComparisonOp_PdfFilePath = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.PdfFilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.PdfFilePath, objvtz_ContentAttachment_Cond.PdfFilePath, strComparisonOp_PdfFilePath);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.SwfFilePath) == true)
{
string strComparisonOp_SwfFilePath = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.SwfFilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.SwfFilePath, objvtz_ContentAttachment_Cond.SwfFilePath, strComparisonOp_SwfFilePath);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.FileSize) == true)
{
string strComparisonOp_FileSize = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.FileSize];
strWhereCond += string.Format(" And {0} {2} {1}", convtz_ContentAttachment.FileSize, objvtz_ContentAttachment_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.FileSizeUnit) == true)
{
string strComparisonOp_FileSizeUnit = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.FileSizeUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.FileSizeUnit, objvtz_ContentAttachment_Cond.FileSizeUnit, strComparisonOp_FileSizeUnit);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.ImageHeight) == true)
{
string strComparisonOp_ImageHeight = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.ImageHeight];
strWhereCond += string.Format(" And {0} {2} {1}", convtz_ContentAttachment.ImageHeight, objvtz_ContentAttachment_Cond.ImageHeight, strComparisonOp_ImageHeight);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.ImageWidth) == true)
{
string strComparisonOp_ImageWidth = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.ImageWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convtz_ContentAttachment.ImageWidth, objvtz_ContentAttachment_Cond.ImageWidth, strComparisonOp_ImageWidth);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.UploadDate) == true)
{
string strComparisonOp_UploadDate = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.UploadDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.UploadDate, objvtz_ContentAttachment_Cond.UploadDate, strComparisonOp_UploadDate);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.UploadPerson) == true)
{
string strComparisonOp_UploadPerson = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.UploadPerson];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.UploadPerson, objvtz_ContentAttachment_Cond.UploadPerson, strComparisonOp_UploadPerson);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.UpdDate, objvtz_ContentAttachment_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.UpdUserId, objvtz_ContentAttachment_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.Memo) == true)
{
string strComparisonOp_Memo = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.Memo, objvtz_ContentAttachment_Cond.Memo, strComparisonOp_Memo);
}
if (objvtz_ContentAttachment_Cond.IsUpdated(convtz_ContentAttachment.CourseId) == true)
{
string strComparisonOp_CourseId = objvtz_ContentAttachment_Cond.dicFldComparisonOp[convtz_ContentAttachment.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.CourseId, objvtz_ContentAttachment_Cond.CourseId, strComparisonOp_CourseId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v内容附件(vtz_ContentAttachment)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvtz_ContentAttachmentWApi
{
private static readonly string mstrApiControllerName = "vtz_ContentAttachmentApi";

 public clsvtz_ContentAttachmentWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvtz_ContentAttachmentEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvtz_ContentAttachmentEN = JsonConvert.DeserializeObject<clsvtz_ContentAttachmentEN>((string)jobjReturn["ReturnObj"]);
return objvtz_ContentAttachmentEN;
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
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvtz_ContentAttachmentEN GetObjBymId_WA_Cache(long lngmId, string strCourseId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString(),
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvtz_ContentAttachmentEN = JsonConvert.DeserializeObject<clsvtz_ContentAttachmentEN>((string)jobjReturn["ReturnObj"]);
return objvtz_ContentAttachmentEN;
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
public static clsvtz_ContentAttachmentEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = null;
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
objvtz_ContentAttachmentEN = JsonConvert.DeserializeObject<clsvtz_ContentAttachmentEN>((string)jobjReturn["ReturnObj"]);
return objvtz_ContentAttachmentEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvtz_ContentAttachmentEN GetObjBymId_Cache(long lngmId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvtz_ContentAttachmentEN._CurrTabName_S, strCourseId);
List<clsvtz_ContentAttachmentEN> arrvtz_ContentAttachmentObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvtz_ContentAttachmentEN> arrvtz_ContentAttachmentObjLst_Sel =
from objvtz_ContentAttachmentEN in arrvtz_ContentAttachmentObjLst_Cache
where objvtz_ContentAttachmentEN.mId == lngmId
select objvtz_ContentAttachmentEN;
if (arrvtz_ContentAttachmentObjLst_Sel.Count() == 0)
{
   clsvtz_ContentAttachmentEN obj = clsvtz_ContentAttachmentWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvtz_ContentAttachmentObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvtz_ContentAttachmentEN> GetObjLst(string strWhereCond)
{
 List<clsvtz_ContentAttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvtz_ContentAttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvtz_ContentAttachmentEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvtz_ContentAttachmentEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvtz_ContentAttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvtz_ContentAttachmentEN> GetObjLstByMIdLst_Cache(List<long> arrMId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvtz_ContentAttachmentEN._CurrTabName_S, strCourseId);
List<clsvtz_ContentAttachmentEN> arrvtz_ContentAttachmentObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvtz_ContentAttachmentEN> arrvtz_ContentAttachmentObjLst_Sel =
from objvtz_ContentAttachmentEN in arrvtz_ContentAttachmentObjLst_Cache
where arrMId.Contains(objvtz_ContentAttachmentEN.mId)
select objvtz_ContentAttachmentEN;
return arrvtz_ContentAttachmentObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvtz_ContentAttachmentEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId, string strCourseId)
{
 List<clsvtz_ContentAttachmentEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvtz_ContentAttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvtz_ContentAttachmentEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvtz_ContentAttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvtz_ContentAttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvtz_ContentAttachmentEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvtz_ContentAttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvtz_ContentAttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvtz_ContentAttachmentEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvtz_ContentAttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvtz_ContentAttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvtz_ContentAttachmentEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvtz_ContentAttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvtz_ContentAttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
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
 /// <param name = "objvtz_ContentAttachmentENS">源对象</param>
 /// <param name = "objvtz_ContentAttachmentENT">目标对象</param>
 public static void CopyTo(clsvtz_ContentAttachmentEN objvtz_ContentAttachmentENS, clsvtz_ContentAttachmentEN objvtz_ContentAttachmentENT)
{
try
{
objvtz_ContentAttachmentENT.mId = objvtz_ContentAttachmentENS.mId; //mId
objvtz_ContentAttachmentENT.ContentTypeId = objvtz_ContentAttachmentENS.ContentTypeId; //内容类型Id
objvtz_ContentAttachmentENT.ContentTypeName = objvtz_ContentAttachmentENS.ContentTypeName; //内容类型名
objvtz_ContentAttachmentENT.TableName = objvtz_ContentAttachmentENS.TableName; //主表表名
objvtz_ContentAttachmentENT.FldName = objvtz_ContentAttachmentENS.FldName; //字段名
objvtz_ContentAttachmentENT.TableNameKey = objvtz_ContentAttachmentENS.TableNameKey; //主表主键值
objvtz_ContentAttachmentENT.OrderNum = objvtz_ContentAttachmentENS.OrderNum; //序号
objvtz_ContentAttachmentENT.AttachmentTitle = objvtz_ContentAttachmentENS.AttachmentTitle; //附件标题
objvtz_ContentAttachmentENT.id_ResourceType = objvtz_ContentAttachmentENS.id_ResourceType; //资源类型流水号
objvtz_ContentAttachmentENT.ResourceTypeID = objvtz_ContentAttachmentENS.ResourceTypeID; //资源类型ID
objvtz_ContentAttachmentENT.ResourceTypeName = objvtz_ContentAttachmentENS.ResourceTypeName; //资源类型名称
objvtz_ContentAttachmentENT.TextContent = objvtz_ContentAttachmentENS.TextContent; //文本内容
objvtz_ContentAttachmentENT.FileName = objvtz_ContentAttachmentENS.FileName; //文件名称
objvtz_ContentAttachmentENT.Extension = objvtz_ContentAttachmentENS.Extension; //扩展名
objvtz_ContentAttachmentENT.FilePath = objvtz_ContentAttachmentENS.FilePath; //文件路径
objvtz_ContentAttachmentENT.PdfFilePath = objvtz_ContentAttachmentENS.PdfFilePath; //Pdf文件路径
objvtz_ContentAttachmentENT.SwfFilePath = objvtz_ContentAttachmentENS.SwfFilePath; //Swf文件路径
objvtz_ContentAttachmentENT.FileSize = objvtz_ContentAttachmentENS.FileSize; //文件大小
objvtz_ContentAttachmentENT.FileSizeUnit = objvtz_ContentAttachmentENS.FileSizeUnit; //文件大小单位
objvtz_ContentAttachmentENT.ImageHeight = objvtz_ContentAttachmentENS.ImageHeight; //图像高
objvtz_ContentAttachmentENT.ImageWidth = objvtz_ContentAttachmentENS.ImageWidth; //图像宽
objvtz_ContentAttachmentENT.UploadDate = objvtz_ContentAttachmentENS.UploadDate; //上传时间
objvtz_ContentAttachmentENT.UploadPerson = objvtz_ContentAttachmentENS.UploadPerson; //上传人
objvtz_ContentAttachmentENT.UpdDate = objvtz_ContentAttachmentENS.UpdDate; //修改日期
objvtz_ContentAttachmentENT.UpdUserId = objvtz_ContentAttachmentENS.UpdUserId; //修改用户Id
objvtz_ContentAttachmentENT.Memo = objvtz_ContentAttachmentENS.Memo; //备注
objvtz_ContentAttachmentENT.CourseId = objvtz_ContentAttachmentENS.CourseId; //课程Id
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
public static DataTable ToDataTable(List<clsvtz_ContentAttachmentEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvtz_ContentAttachmentEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvtz_ContentAttachmentEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvtz_ContentAttachmentEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvtz_ContentAttachmentEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvtz_ContentAttachmentEN.AttributeName)
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
if (clstz_ContentAttachmentWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clstz_ContentAttachmentWApi没有刷新缓存机制(clstz_ContentAttachmentWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsContentTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsContentTypeWApi没有刷新缓存机制(clsContentTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvtz_ContentAttachmentObjLst_Cache == null)
//{
//arrvtz_ContentAttachmentObjLst_Cache = await clsvtz_ContentAttachmentWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvtz_ContentAttachmentEN._CurrTabName_S, strCourseId);
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
public static List<clsvtz_ContentAttachmentEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvtz_ContentAttachmentEN._CurrTabName_S, strCourseId);
List<clsvtz_ContentAttachmentEN> arrvtz_ContentAttachmentObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvtz_ContentAttachmentObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvtz_ContentAttachmentEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convtz_ContentAttachment.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convtz_ContentAttachment.ContentTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.ContentTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.TableName, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.TableNameKey, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convtz_ContentAttachment.AttachmentTitle, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.TextContent, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.Extension, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.PdfFilePath, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.SwfFilePath, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.FileSize, Type.GetType("System.Decimal"));
objDT.Columns.Add(convtz_ContentAttachment.FileSizeUnit, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.ImageHeight, Type.GetType("System.Int32"));
objDT.Columns.Add(convtz_ContentAttachment.ImageWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(convtz_ContentAttachment.UploadDate, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.UploadPerson, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convtz_ContentAttachment.CourseId, Type.GetType("System.String"));
foreach (clsvtz_ContentAttachmentEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convtz_ContentAttachment.mId] = objInFor[convtz_ContentAttachment.mId];
objDR[convtz_ContentAttachment.ContentTypeId] = objInFor[convtz_ContentAttachment.ContentTypeId];
objDR[convtz_ContentAttachment.ContentTypeName] = objInFor[convtz_ContentAttachment.ContentTypeName];
objDR[convtz_ContentAttachment.TableName] = objInFor[convtz_ContentAttachment.TableName];
objDR[convtz_ContentAttachment.FldName] = objInFor[convtz_ContentAttachment.FldName];
objDR[convtz_ContentAttachment.TableNameKey] = objInFor[convtz_ContentAttachment.TableNameKey];
objDR[convtz_ContentAttachment.OrderNum] = objInFor[convtz_ContentAttachment.OrderNum];
objDR[convtz_ContentAttachment.AttachmentTitle] = objInFor[convtz_ContentAttachment.AttachmentTitle];
objDR[convtz_ContentAttachment.id_ResourceType] = objInFor[convtz_ContentAttachment.id_ResourceType];
objDR[convtz_ContentAttachment.ResourceTypeID] = objInFor[convtz_ContentAttachment.ResourceTypeID];
objDR[convtz_ContentAttachment.ResourceTypeName] = objInFor[convtz_ContentAttachment.ResourceTypeName];
objDR[convtz_ContentAttachment.TextContent] = objInFor[convtz_ContentAttachment.TextContent];
objDR[convtz_ContentAttachment.FileName] = objInFor[convtz_ContentAttachment.FileName];
objDR[convtz_ContentAttachment.Extension] = objInFor[convtz_ContentAttachment.Extension];
objDR[convtz_ContentAttachment.FilePath] = objInFor[convtz_ContentAttachment.FilePath];
objDR[convtz_ContentAttachment.PdfFilePath] = objInFor[convtz_ContentAttachment.PdfFilePath];
objDR[convtz_ContentAttachment.SwfFilePath] = objInFor[convtz_ContentAttachment.SwfFilePath];
objDR[convtz_ContentAttachment.FileSize] = objInFor[convtz_ContentAttachment.FileSize];
objDR[convtz_ContentAttachment.FileSizeUnit] = objInFor[convtz_ContentAttachment.FileSizeUnit];
objDR[convtz_ContentAttachment.ImageHeight] = objInFor[convtz_ContentAttachment.ImageHeight];
objDR[convtz_ContentAttachment.ImageWidth] = objInFor[convtz_ContentAttachment.ImageWidth];
objDR[convtz_ContentAttachment.UploadDate] = objInFor[convtz_ContentAttachment.UploadDate];
objDR[convtz_ContentAttachment.UploadPerson] = objInFor[convtz_ContentAttachment.UploadPerson];
objDR[convtz_ContentAttachment.UpdDate] = objInFor[convtz_ContentAttachment.UpdDate];
objDR[convtz_ContentAttachment.UpdUserId] = objInFor[convtz_ContentAttachment.UpdUserId];
objDR[convtz_ContentAttachment.Memo] = objInFor[convtz_ContentAttachment.Memo];
objDR[convtz_ContentAttachment.CourseId] = objInFor[convtz_ContentAttachment.CourseId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}