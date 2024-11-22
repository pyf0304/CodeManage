
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clstz_ContentAttachmentWApi
 表名:tz_ContentAttachment(01120207)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:40
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
public static class clstz_ContentAttachmentWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetmId(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, long lngmId, string strComparisonOp="")
	{
objtz_ContentAttachmentEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.mId) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.mId, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.mId] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetContentTypeId(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strContentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strContentTypeId, contz_ContentAttachment.ContentTypeId);
clsCheckSql.CheckFieldLen(strContentTypeId, 4, contz_ContentAttachment.ContentTypeId);
clsCheckSql.CheckFieldForeignKey(strContentTypeId, 4, contz_ContentAttachment.ContentTypeId);
objtz_ContentAttachmentEN.ContentTypeId = strContentTypeId; //内容类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.ContentTypeId) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.ContentTypeId, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.ContentTypeId] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetTableNameKey(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strTableNameKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTableNameKey, contz_ContentAttachment.TableNameKey);
clsCheckSql.CheckFieldLen(strTableNameKey, 20, contz_ContentAttachment.TableNameKey);
objtz_ContentAttachmentEN.TableNameKey = strTableNameKey; //主表主键值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.TableNameKey) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.TableNameKey, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.TableNameKey] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetOrderNum(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, int intOrderNum, string strComparisonOp="")
	{
objtz_ContentAttachmentEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.OrderNum) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.OrderNum, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.OrderNum] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetAttachmentTitle(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strAttachmentTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAttachmentTitle, 100, contz_ContentAttachment.AttachmentTitle);
objtz_ContentAttachmentEN.AttachmentTitle = strAttachmentTitle; //附件标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.AttachmentTitle) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.AttachmentTitle, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.AttachmentTitle] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN Setid_ResourceType(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, contz_ContentAttachment.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, contz_ContentAttachment.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, contz_ContentAttachment.id_ResourceType);
objtz_ContentAttachmentEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.id_ResourceType) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.id_ResourceType, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.id_ResourceType] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetTextContent(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strTextContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTextContent, 8000, contz_ContentAttachment.TextContent);
objtz_ContentAttachmentEN.TextContent = strTextContent; //文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.TextContent) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.TextContent, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.TextContent] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetFileName(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, contz_ContentAttachment.FileName);
objtz_ContentAttachmentEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.FileName) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.FileName, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.FileName] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetExtension(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strExtension, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExtension, 10, contz_ContentAttachment.Extension);
objtz_ContentAttachmentEN.Extension = strExtension; //扩展名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.Extension) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.Extension, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.Extension] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetFilePath(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFilePath, 500, contz_ContentAttachment.FilePath);
objtz_ContentAttachmentEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.FilePath) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.FilePath, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.FilePath] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetPdfFilePath(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strPdfFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPdfFilePath, 500, contz_ContentAttachment.PdfFilePath);
objtz_ContentAttachmentEN.PdfFilePath = strPdfFilePath; //Pdf文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.PdfFilePath) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.PdfFilePath, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.PdfFilePath] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetSwfFilePath(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strSwfFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSwfFilePath, 500, contz_ContentAttachment.SwfFilePath);
objtz_ContentAttachmentEN.SwfFilePath = strSwfFilePath; //Swf文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.SwfFilePath) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.SwfFilePath, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.SwfFilePath] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetFileSize(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, double dblFileSize, string strComparisonOp="")
	{
objtz_ContentAttachmentEN.FileSize = dblFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.FileSize) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.FileSize, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.FileSize] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetFileSizeUnit(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strFileSizeUnit, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSizeUnit, 10, contz_ContentAttachment.FileSizeUnit);
objtz_ContentAttachmentEN.FileSizeUnit = strFileSizeUnit; //文件大小单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.FileSizeUnit) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.FileSizeUnit, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.FileSizeUnit] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetImageHeight(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, int intImageHeight, string strComparisonOp="")
	{
objtz_ContentAttachmentEN.ImageHeight = intImageHeight; //图像高
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.ImageHeight) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.ImageHeight, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.ImageHeight] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetImageWidth(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, int intImageWidth, string strComparisonOp="")
	{
objtz_ContentAttachmentEN.ImageWidth = intImageWidth; //图像宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.ImageWidth) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.ImageWidth, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.ImageWidth] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetUploadDate(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strUploadDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUploadDate, contz_ContentAttachment.UploadDate);
clsCheckSql.CheckFieldLen(strUploadDate, 20, contz_ContentAttachment.UploadDate);
objtz_ContentAttachmentEN.UploadDate = strUploadDate; //上传时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.UploadDate) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.UploadDate, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.UploadDate] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetUploadPerson(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strUploadPerson, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUploadPerson, 20, contz_ContentAttachment.UploadPerson);
objtz_ContentAttachmentEN.UploadPerson = strUploadPerson; //上传人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.UploadPerson) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.UploadPerson, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.UploadPerson] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetUpdDate(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, contz_ContentAttachment.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, contz_ContentAttachment.UpdDate);
objtz_ContentAttachmentEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.UpdDate) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.UpdDate, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.UpdDate] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetUpdUserId(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, contz_ContentAttachment.UpdUserId);
objtz_ContentAttachmentEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.UpdUserId) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.UpdUserId, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.UpdUserId] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetMemo(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, contz_ContentAttachment.Memo);
objtz_ContentAttachmentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.Memo) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.Memo, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.Memo] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clstz_ContentAttachmentEN SetCourseId(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, contz_ContentAttachment.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, contz_ContentAttachment.CourseId);
objtz_ContentAttachmentEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.CourseId) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.CourseId, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.CourseId] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clstz_ContentAttachmentEN objtz_ContentAttachment_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.mId) == true)
{
string strComparisonOp_mId = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.mId];
strWhereCond += string.Format(" And {0} {2} {1}", contz_ContentAttachment.mId, objtz_ContentAttachment_Cond.mId, strComparisonOp_mId);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.ContentTypeId) == true)
{
string strComparisonOp_ContentTypeId = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.ContentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.ContentTypeId, objtz_ContentAttachment_Cond.ContentTypeId, strComparisonOp_ContentTypeId);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.TableNameKey) == true)
{
string strComparisonOp_TableNameKey = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.TableNameKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.TableNameKey, objtz_ContentAttachment_Cond.TableNameKey, strComparisonOp_TableNameKey);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.OrderNum) == true)
{
string strComparisonOp_OrderNum = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", contz_ContentAttachment.OrderNum, objtz_ContentAttachment_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.AttachmentTitle) == true)
{
string strComparisonOp_AttachmentTitle = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.AttachmentTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.AttachmentTitle, objtz_ContentAttachment_Cond.AttachmentTitle, strComparisonOp_AttachmentTitle);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.id_ResourceType, objtz_ContentAttachment_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.TextContent) == true)
{
string strComparisonOp_TextContent = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.TextContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.TextContent, objtz_ContentAttachment_Cond.TextContent, strComparisonOp_TextContent);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.FileName) == true)
{
string strComparisonOp_FileName = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.FileName, objtz_ContentAttachment_Cond.FileName, strComparisonOp_FileName);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.Extension) == true)
{
string strComparisonOp_Extension = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.Extension];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.Extension, objtz_ContentAttachment_Cond.Extension, strComparisonOp_Extension);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.FilePath) == true)
{
string strComparisonOp_FilePath = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.FilePath, objtz_ContentAttachment_Cond.FilePath, strComparisonOp_FilePath);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.PdfFilePath) == true)
{
string strComparisonOp_PdfFilePath = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.PdfFilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.PdfFilePath, objtz_ContentAttachment_Cond.PdfFilePath, strComparisonOp_PdfFilePath);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.SwfFilePath) == true)
{
string strComparisonOp_SwfFilePath = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.SwfFilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.SwfFilePath, objtz_ContentAttachment_Cond.SwfFilePath, strComparisonOp_SwfFilePath);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.FileSize) == true)
{
string strComparisonOp_FileSize = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.FileSize];
strWhereCond += string.Format(" And {0} {2} {1}", contz_ContentAttachment.FileSize, objtz_ContentAttachment_Cond.FileSize, strComparisonOp_FileSize);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.FileSizeUnit) == true)
{
string strComparisonOp_FileSizeUnit = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.FileSizeUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.FileSizeUnit, objtz_ContentAttachment_Cond.FileSizeUnit, strComparisonOp_FileSizeUnit);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.ImageHeight) == true)
{
string strComparisonOp_ImageHeight = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.ImageHeight];
strWhereCond += string.Format(" And {0} {2} {1}", contz_ContentAttachment.ImageHeight, objtz_ContentAttachment_Cond.ImageHeight, strComparisonOp_ImageHeight);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.ImageWidth) == true)
{
string strComparisonOp_ImageWidth = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.ImageWidth];
strWhereCond += string.Format(" And {0} {2} {1}", contz_ContentAttachment.ImageWidth, objtz_ContentAttachment_Cond.ImageWidth, strComparisonOp_ImageWidth);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.UploadDate) == true)
{
string strComparisonOp_UploadDate = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.UploadDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.UploadDate, objtz_ContentAttachment_Cond.UploadDate, strComparisonOp_UploadDate);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.UploadPerson) == true)
{
string strComparisonOp_UploadPerson = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.UploadPerson];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.UploadPerson, objtz_ContentAttachment_Cond.UploadPerson, strComparisonOp_UploadPerson);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.UpdDate) == true)
{
string strComparisonOp_UpdDate = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.UpdDate, objtz_ContentAttachment_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.UpdUserId, objtz_ContentAttachment_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.Memo) == true)
{
string strComparisonOp_Memo = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.Memo, objtz_ContentAttachment_Cond.Memo, strComparisonOp_Memo);
}
if (objtz_ContentAttachment_Cond.IsUpdated(contz_ContentAttachment.CourseId) == true)
{
string strComparisonOp_CourseId = objtz_ContentAttachment_Cond.dicFldComparisonOp[contz_ContentAttachment.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.CourseId, objtz_ContentAttachment_Cond.CourseId, strComparisonOp_CourseId);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
 if (objtz_ContentAttachmentEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objtz_ContentAttachmentEN.sf_UpdFldSetStr = objtz_ContentAttachmentEN.getsf_UpdFldSetStr();
clstz_ContentAttachmentWApi.CheckPropertyNew(objtz_ContentAttachmentEN); 
bool bolResult = clstz_ContentAttachmentWApi.UpdateRecord(objtz_ContentAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_ContentAttachmentWApi.ReFreshCache(objtz_ContentAttachmentEN.CourseId);
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
 /// 检查唯一性(Uniqueness)--tz_ContentAttachment(内容附件), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_ContentTypeId_TableNameKey_mId(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objtz_ContentAttachmentEN == null) return "";
if (objtz_ContentAttachmentEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ContentTypeId = '{0}'", objtz_ContentAttachmentEN.ContentTypeId);
 sbCondition.AppendFormat(" and TableNameKey = '{0}'", objtz_ContentAttachmentEN.TableNameKey);
 sbCondition.AppendFormat(" and mId = '{0}'", objtz_ContentAttachmentEN.mId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objtz_ContentAttachmentEN.mId);
 sbCondition.AppendFormat(" and ContentTypeId = '{0}'", objtz_ContentAttachmentEN.ContentTypeId);
 sbCondition.AppendFormat(" and TableNameKey = '{0}'", objtz_ContentAttachmentEN.TableNameKey);
 sbCondition.AppendFormat(" and mId = '{0}'", objtz_ContentAttachmentEN.mId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
try
{
clstz_ContentAttachmentWApi.CheckPropertyNew(objtz_ContentAttachmentEN); 
bool bolResult = clstz_ContentAttachmentWApi.AddNewRecord(objtz_ContentAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_ContentAttachmentWApi.ReFreshCache(objtz_ContentAttachmentEN.CourseId);
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
 /// <param name = "objtz_ContentAttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strWhereCond)
{
try
{
clstz_ContentAttachmentWApi.CheckPropertyNew(objtz_ContentAttachmentEN); 
bool bolResult = clstz_ContentAttachmentWApi.UpdateWithCondition(objtz_ContentAttachmentEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_ContentAttachmentWApi.ReFreshCache(objtz_ContentAttachmentEN.CourseId);
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
 /// 内容附件(tz_ContentAttachment)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clstz_ContentAttachmentWApi
{
private static readonly string mstrApiControllerName = "tz_ContentAttachmentApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clstz_ContentAttachmentWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
if (!Object.Equals(null, objtz_ContentAttachmentEN.ContentTypeId) && GetStrLen(objtz_ContentAttachmentEN.ContentTypeId) > 4)
{
 throw new Exception("字段[内容类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objtz_ContentAttachmentEN.TableNameKey) && GetStrLen(objtz_ContentAttachmentEN.TableNameKey) > 20)
{
 throw new Exception("字段[主表主键值]的长度不能超过20!");
}
if (!Object.Equals(null, objtz_ContentAttachmentEN.AttachmentTitle) && GetStrLen(objtz_ContentAttachmentEN.AttachmentTitle) > 100)
{
 throw new Exception("字段[附件标题]的长度不能超过100!");
}
if (!Object.Equals(null, objtz_ContentAttachmentEN.id_ResourceType) && GetStrLen(objtz_ContentAttachmentEN.id_ResourceType) > 4)
{
 throw new Exception("字段[资源类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objtz_ContentAttachmentEN.TextContent) && GetStrLen(objtz_ContentAttachmentEN.TextContent) > 8000)
{
 throw new Exception("字段[文本内容]的长度不能超过8000!");
}
if (!Object.Equals(null, objtz_ContentAttachmentEN.FileName) && GetStrLen(objtz_ContentAttachmentEN.FileName) > 500)
{
 throw new Exception("字段[文件名称]的长度不能超过500!");
}
if (!Object.Equals(null, objtz_ContentAttachmentEN.Extension) && GetStrLen(objtz_ContentAttachmentEN.Extension) > 10)
{
 throw new Exception("字段[扩展名]的长度不能超过10!");
}
if (!Object.Equals(null, objtz_ContentAttachmentEN.FilePath) && GetStrLen(objtz_ContentAttachmentEN.FilePath) > 500)
{
 throw new Exception("字段[文件路径]的长度不能超过500!");
}
if (!Object.Equals(null, objtz_ContentAttachmentEN.PdfFilePath) && GetStrLen(objtz_ContentAttachmentEN.PdfFilePath) > 500)
{
 throw new Exception("字段[Pdf文件路径]的长度不能超过500!");
}
if (!Object.Equals(null, objtz_ContentAttachmentEN.SwfFilePath) && GetStrLen(objtz_ContentAttachmentEN.SwfFilePath) > 500)
{
 throw new Exception("字段[Swf文件路径]的长度不能超过500!");
}
if (!Object.Equals(null, objtz_ContentAttachmentEN.FileSizeUnit) && GetStrLen(objtz_ContentAttachmentEN.FileSizeUnit) > 10)
{
 throw new Exception("字段[文件大小单位]的长度不能超过10!");
}
if (!Object.Equals(null, objtz_ContentAttachmentEN.UploadDate) && GetStrLen(objtz_ContentAttachmentEN.UploadDate) > 20)
{
 throw new Exception("字段[上传时间]的长度不能超过20!");
}
if (!Object.Equals(null, objtz_ContentAttachmentEN.UploadPerson) && GetStrLen(objtz_ContentAttachmentEN.UploadPerson) > 20)
{
 throw new Exception("字段[上传人]的长度不能超过20!");
}
if (!Object.Equals(null, objtz_ContentAttachmentEN.UpdDate) && GetStrLen(objtz_ContentAttachmentEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objtz_ContentAttachmentEN.UpdUserId) && GetStrLen(objtz_ContentAttachmentEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objtz_ContentAttachmentEN.Memo) && GetStrLen(objtz_ContentAttachmentEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objtz_ContentAttachmentEN.CourseId) && GetStrLen(objtz_ContentAttachmentEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
 objtz_ContentAttachmentEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clstz_ContentAttachmentEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clstz_ContentAttachmentEN objtz_ContentAttachmentEN = null;
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
objtz_ContentAttachmentEN = JsonConvert.DeserializeObject<clstz_ContentAttachmentEN>((string)jobjReturn["ReturnObj"]);
return objtz_ContentAttachmentEN;
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
public static clstz_ContentAttachmentEN GetObjBymId_WA_Cache(long lngmId, string strCourseId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clstz_ContentAttachmentEN objtz_ContentAttachmentEN = null;
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
objtz_ContentAttachmentEN = JsonConvert.DeserializeObject<clstz_ContentAttachmentEN>((string)jobjReturn["ReturnObj"]);
return objtz_ContentAttachmentEN;
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
public static clstz_ContentAttachmentEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clstz_ContentAttachmentEN objtz_ContentAttachmentEN = null;
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
objtz_ContentAttachmentEN = JsonConvert.DeserializeObject<clstz_ContentAttachmentEN>((string)jobjReturn["ReturnObj"]);
return objtz_ContentAttachmentEN;
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
public static clstz_ContentAttachmentEN GetObjBymId_Cache(long lngmId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clstz_ContentAttachmentEN._CurrTabName_S, strCourseId);
List<clstz_ContentAttachmentEN> arrtz_ContentAttachmentObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clstz_ContentAttachmentEN> arrtz_ContentAttachmentObjLst_Sel =
from objtz_ContentAttachmentEN in arrtz_ContentAttachmentObjLst_Cache
where objtz_ContentAttachmentEN.mId == lngmId
select objtz_ContentAttachmentEN;
if (arrtz_ContentAttachmentObjLst_Sel.Count() == 0)
{
   clstz_ContentAttachmentEN obj = clstz_ContentAttachmentWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrtz_ContentAttachmentObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clstz_ContentAttachmentEN> GetObjLst(string strWhereCond)
{
 List<clstz_ContentAttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clstz_ContentAttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clstz_ContentAttachmentEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clstz_ContentAttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clstz_ContentAttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clstz_ContentAttachmentEN> GetObjLstByMIdLst_Cache(List<long> arrMId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clstz_ContentAttachmentEN._CurrTabName_S, strCourseId);
List<clstz_ContentAttachmentEN> arrtz_ContentAttachmentObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clstz_ContentAttachmentEN> arrtz_ContentAttachmentObjLst_Sel =
from objtz_ContentAttachmentEN in arrtz_ContentAttachmentObjLst_Cache
where arrMId.Contains(objtz_ContentAttachmentEN.mId)
select objtz_ContentAttachmentEN;
return arrtz_ContentAttachmentObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clstz_ContentAttachmentEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId, string strCourseId)
{
 List<clstz_ContentAttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clstz_ContentAttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clstz_ContentAttachmentEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clstz_ContentAttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clstz_ContentAttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clstz_ContentAttachmentEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clstz_ContentAttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clstz_ContentAttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clstz_ContentAttachmentEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clstz_ContentAttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clstz_ContentAttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clstz_ContentAttachmentEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clstz_ContentAttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clstz_ContentAttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clstz_ContentAttachmentEN objtz_ContentAttachmentEN = clstz_ContentAttachmentWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clstz_ContentAttachmentWApi.ReFreshCache(objtz_ContentAttachmentEN.CourseId);
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
public static int Deltz_ContentAttachments(List<string> arrmId)
{
string strAction = "Deltz_ContentAttachments";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clstz_ContentAttachmentEN objtz_ContentAttachmentEN = clstz_ContentAttachmentWApi.GetObjBymId(long.Parse(arrmId[0]));
clstz_ContentAttachmentWApi.ReFreshCache(objtz_ContentAttachmentEN.CourseId);
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
public static int Deltz_ContentAttachmentsByCond(string strWhereCond)
{
string strAction = "Deltz_ContentAttachmentsByCond";
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
public static bool AddNewRecord(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clstz_ContentAttachmentEN>(objtz_ContentAttachmentEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_ContentAttachmentWApi.ReFreshCache(objtz_ContentAttachmentEN.CourseId);
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
 /// <param name = "objtz_ContentAttachmentEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clstz_ContentAttachmentEN>(objtz_ContentAttachmentEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_ContentAttachmentWApi.ReFreshCache(objtz_ContentAttachmentEN.CourseId);
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
public static bool UpdateRecord(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
if (string.IsNullOrEmpty(objtz_ContentAttachmentEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objtz_ContentAttachmentEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clstz_ContentAttachmentEN>(objtz_ContentAttachmentEN);
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
 /// <param name = "objtz_ContentAttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objtz_ContentAttachmentEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objtz_ContentAttachmentEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objtz_ContentAttachmentEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clstz_ContentAttachmentEN>(objtz_ContentAttachmentEN);
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
 /// <param name = "objtz_ContentAttachmentENS">源对象</param>
 /// <param name = "objtz_ContentAttachmentENT">目标对象</param>
 public static void CopyTo(clstz_ContentAttachmentEN objtz_ContentAttachmentENS, clstz_ContentAttachmentEN objtz_ContentAttachmentENT)
{
try
{
objtz_ContentAttachmentENT.mId = objtz_ContentAttachmentENS.mId; //mId
objtz_ContentAttachmentENT.ContentTypeId = objtz_ContentAttachmentENS.ContentTypeId; //内容类型Id
objtz_ContentAttachmentENT.TableNameKey = objtz_ContentAttachmentENS.TableNameKey; //主表主键值
objtz_ContentAttachmentENT.OrderNum = objtz_ContentAttachmentENS.OrderNum; //序号
objtz_ContentAttachmentENT.AttachmentTitle = objtz_ContentAttachmentENS.AttachmentTitle; //附件标题
objtz_ContentAttachmentENT.id_ResourceType = objtz_ContentAttachmentENS.id_ResourceType; //资源类型流水号
objtz_ContentAttachmentENT.TextContent = objtz_ContentAttachmentENS.TextContent; //文本内容
objtz_ContentAttachmentENT.FileName = objtz_ContentAttachmentENS.FileName; //文件名称
objtz_ContentAttachmentENT.Extension = objtz_ContentAttachmentENS.Extension; //扩展名
objtz_ContentAttachmentENT.FilePath = objtz_ContentAttachmentENS.FilePath; //文件路径
objtz_ContentAttachmentENT.PdfFilePath = objtz_ContentAttachmentENS.PdfFilePath; //Pdf文件路径
objtz_ContentAttachmentENT.SwfFilePath = objtz_ContentAttachmentENS.SwfFilePath; //Swf文件路径
objtz_ContentAttachmentENT.FileSize = objtz_ContentAttachmentENS.FileSize; //文件大小
objtz_ContentAttachmentENT.FileSizeUnit = objtz_ContentAttachmentENS.FileSizeUnit; //文件大小单位
objtz_ContentAttachmentENT.ImageHeight = objtz_ContentAttachmentENS.ImageHeight; //图像高
objtz_ContentAttachmentENT.ImageWidth = objtz_ContentAttachmentENS.ImageWidth; //图像宽
objtz_ContentAttachmentENT.UploadDate = objtz_ContentAttachmentENS.UploadDate; //上传时间
objtz_ContentAttachmentENT.UploadPerson = objtz_ContentAttachmentENS.UploadPerson; //上传人
objtz_ContentAttachmentENT.UpdDate = objtz_ContentAttachmentENS.UpdDate; //修改日期
objtz_ContentAttachmentENT.UpdUserId = objtz_ContentAttachmentENS.UpdUserId; //修改用户Id
objtz_ContentAttachmentENT.Memo = objtz_ContentAttachmentENS.Memo; //备注
objtz_ContentAttachmentENT.CourseId = objtz_ContentAttachmentENS.CourseId; //课程Id
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
public static DataTable ToDataTable(List<clstz_ContentAttachmentEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clstz_ContentAttachmentEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clstz_ContentAttachmentEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clstz_ContentAttachmentEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clstz_ContentAttachmentEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clstz_ContentAttachmentEN.AttributeName)
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
if (clstz_ContentAttachmentWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clstz_ContentAttachmentWApi没有刷新缓存机制(clstz_ContentAttachmentWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrtz_ContentAttachmentObjLst_Cache == null)
//{
//arrtz_ContentAttachmentObjLst_Cache = await clstz_ContentAttachmentWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clstz_ContentAttachmentEN._CurrTabName_S, strCourseId);
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
public static void ReFreshCache(string strCourseId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clstz_ContentAttachmentWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clstz_ContentAttachmentEN._CurrTabName_S, strCourseId);
CacheHelper.Remove(strKey);
clstz_ContentAttachmentWApi.objCommFun4BL.ReFreshCache(strCourseId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clstz_ContentAttachmentEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clstz_ContentAttachmentEN._CurrTabName_S, strCourseId);
List<clstz_ContentAttachmentEN> arrtz_ContentAttachmentObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrtz_ContentAttachmentObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clstz_ContentAttachmentEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(contz_ContentAttachment.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(contz_ContentAttachment.ContentTypeId, Type.GetType("System.String"));
objDT.Columns.Add(contz_ContentAttachment.TableNameKey, Type.GetType("System.String"));
objDT.Columns.Add(contz_ContentAttachment.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(contz_ContentAttachment.AttachmentTitle, Type.GetType("System.String"));
objDT.Columns.Add(contz_ContentAttachment.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(contz_ContentAttachment.TextContent, Type.GetType("System.String"));
objDT.Columns.Add(contz_ContentAttachment.FileName, Type.GetType("System.String"));
objDT.Columns.Add(contz_ContentAttachment.Extension, Type.GetType("System.String"));
objDT.Columns.Add(contz_ContentAttachment.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(contz_ContentAttachment.PdfFilePath, Type.GetType("System.String"));
objDT.Columns.Add(contz_ContentAttachment.SwfFilePath, Type.GetType("System.String"));
objDT.Columns.Add(contz_ContentAttachment.FileSize, Type.GetType("System.Decimal"));
objDT.Columns.Add(contz_ContentAttachment.FileSizeUnit, Type.GetType("System.String"));
objDT.Columns.Add(contz_ContentAttachment.ImageHeight, Type.GetType("System.Int32"));
objDT.Columns.Add(contz_ContentAttachment.ImageWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(contz_ContentAttachment.UploadDate, Type.GetType("System.String"));
objDT.Columns.Add(contz_ContentAttachment.UploadPerson, Type.GetType("System.String"));
objDT.Columns.Add(contz_ContentAttachment.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(contz_ContentAttachment.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(contz_ContentAttachment.Memo, Type.GetType("System.String"));
objDT.Columns.Add(contz_ContentAttachment.CourseId, Type.GetType("System.String"));
foreach (clstz_ContentAttachmentEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[contz_ContentAttachment.mId] = objInFor[contz_ContentAttachment.mId];
objDR[contz_ContentAttachment.ContentTypeId] = objInFor[contz_ContentAttachment.ContentTypeId];
objDR[contz_ContentAttachment.TableNameKey] = objInFor[contz_ContentAttachment.TableNameKey];
objDR[contz_ContentAttachment.OrderNum] = objInFor[contz_ContentAttachment.OrderNum];
objDR[contz_ContentAttachment.AttachmentTitle] = objInFor[contz_ContentAttachment.AttachmentTitle];
objDR[contz_ContentAttachment.id_ResourceType] = objInFor[contz_ContentAttachment.id_ResourceType];
objDR[contz_ContentAttachment.TextContent] = objInFor[contz_ContentAttachment.TextContent];
objDR[contz_ContentAttachment.FileName] = objInFor[contz_ContentAttachment.FileName];
objDR[contz_ContentAttachment.Extension] = objInFor[contz_ContentAttachment.Extension];
objDR[contz_ContentAttachment.FilePath] = objInFor[contz_ContentAttachment.FilePath];
objDR[contz_ContentAttachment.PdfFilePath] = objInFor[contz_ContentAttachment.PdfFilePath];
objDR[contz_ContentAttachment.SwfFilePath] = objInFor[contz_ContentAttachment.SwfFilePath];
objDR[contz_ContentAttachment.FileSize] = objInFor[contz_ContentAttachment.FileSize];
objDR[contz_ContentAttachment.FileSizeUnit] = objInFor[contz_ContentAttachment.FileSizeUnit];
objDR[contz_ContentAttachment.ImageHeight] = objInFor[contz_ContentAttachment.ImageHeight];
objDR[contz_ContentAttachment.ImageWidth] = objInFor[contz_ContentAttachment.ImageWidth];
objDR[contz_ContentAttachment.UploadDate] = objInFor[contz_ContentAttachment.UploadDate];
objDR[contz_ContentAttachment.UploadPerson] = objInFor[contz_ContentAttachment.UploadPerson];
objDR[contz_ContentAttachment.UpdDate] = objInFor[contz_ContentAttachment.UpdDate];
objDR[contz_ContentAttachment.UpdUserId] = objInFor[contz_ContentAttachment.UpdUserId];
objDR[contz_ContentAttachment.Memo] = objInFor[contz_ContentAttachment.Memo];
objDR[contz_ContentAttachment.CourseId] = objInFor[contz_ContentAttachment.CourseId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 内容附件(tz_ContentAttachment)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4tz_ContentAttachment : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clstz_ContentAttachmentWApi.ReFreshThisCache(strCourseId);
clsvtz_ContentAttachmentWApi.ReFreshThisCache(strCourseId);
}
}

}