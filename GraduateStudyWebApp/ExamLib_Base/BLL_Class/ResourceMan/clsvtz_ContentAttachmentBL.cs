
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvtz_ContentAttachmentBL
 表名:vtz_ContentAttachment(01120208)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:21
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
public static class  clsvtz_ContentAttachmentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvtz_ContentAttachmentEN GetObj(this K_mId_vtz_ContentAttachment myKey)
{
clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = clsvtz_ContentAttachmentBL.vtz_ContentAttachmentDA.GetObjBymId(myKey.Value);
return objvtz_ContentAttachmentEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetContentTypeId(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strContentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strContentTypeId, convtz_ContentAttachment.ContentTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strContentTypeId, 4, convtz_ContentAttachment.ContentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strContentTypeId, 4, convtz_ContentAttachment.ContentTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetContentTypeName(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strContentTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strContentTypeName, 50, convtz_ContentAttachment.ContentTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetTableName(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strTableName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableName, 100, convtz_ContentAttachment.TableName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetFldName(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convtz_ContentAttachment.FldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convtz_ContentAttachment.FldName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetTableNameKey(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strTableNameKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTableNameKey, convtz_ContentAttachment.TableNameKey);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableNameKey, 20, convtz_ContentAttachment.TableNameKey);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetOrderNum(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, int? intOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetAttachmentTitle(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strAttachmentTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAttachmentTitle, 100, convtz_ContentAttachment.AttachmentTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetIdResourceType(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strIdResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResourceType, convtz_ContentAttachment.IdResourceType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convtz_ContentAttachment.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convtz_ContentAttachment.IdResourceType);
}
objvtz_ContentAttachmentEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(convtz_ContentAttachment.IdResourceType) == false)
{
objvtz_ContentAttachmentEN.dicFldComparisonOp.Add(convtz_ContentAttachment.IdResourceType, strComparisonOp);
}
else
{
objvtz_ContentAttachmentEN.dicFldComparisonOp[convtz_ContentAttachment.IdResourceType] = strComparisonOp;
}
}
return objvtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetResourceTypeID(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convtz_ContentAttachment.ResourceTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convtz_ContentAttachment.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convtz_ContentAttachment.ResourceTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetResourceTypeName(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convtz_ContentAttachment.ResourceTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convtz_ContentAttachment.ResourceTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetTextContent(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strTextContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextContent, convtz_ContentAttachment.TextContent);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextContent, 8000, convtz_ContentAttachment.TextContent);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetFileName(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convtz_ContentAttachment.FileName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetExtension(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strExtension, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExtension, 10, convtz_ContentAttachment.Extension);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetFilePath(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convtz_ContentAttachment.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, convtz_ContentAttachment.FilePath);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetPdfFilePath(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strPdfFilePath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfFilePath, 500, convtz_ContentAttachment.PdfFilePath);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetSwfFilePath(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strSwfFilePath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSwfFilePath, 500, convtz_ContentAttachment.SwfFilePath);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetFileSize(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, double? dblFileSize, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetFileSizeUnit(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strFileSizeUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSizeUnit, 10, convtz_ContentAttachment.FileSizeUnit);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetImageHeight(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, int? intImageHeight, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetImageWidth(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, int? intImageWidth, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetUploadDate(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strUploadDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUploadDate, convtz_ContentAttachment.UploadDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadDate, 20, convtz_ContentAttachment.UploadDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetUploadPerson(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strUploadPerson, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUploadPerson, convtz_ContentAttachment.UploadPerson);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadPerson, 20, convtz_ContentAttachment.UploadPerson);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetUpdDate(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convtz_ContentAttachment.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convtz_ContentAttachment.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetUpdUserId(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convtz_ContentAttachment.UpdUserId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetMemo(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convtz_ContentAttachment.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvtz_ContentAttachmentEN SetCourseId(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convtz_ContentAttachment.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convtz_ContentAttachment.CourseId);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentENS">源对象</param>
 /// <param name = "objvtz_ContentAttachmentENT">目标对象</param>
 public static void CopyTo(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentENS, clsvtz_ContentAttachmentEN objvtz_ContentAttachmentENT)
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
objvtz_ContentAttachmentENT.IdResourceType = objvtz_ContentAttachmentENS.IdResourceType; //资源类型流水号
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
 /// <param name = "objvtz_ContentAttachmentENS">源对象</param>
 /// <returns>目标对象=>clsvtz_ContentAttachmentEN:objvtz_ContentAttachmentENT</returns>
 public static clsvtz_ContentAttachmentEN CopyTo(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentENS)
{
try
{
 clsvtz_ContentAttachmentEN objvtz_ContentAttachmentENT = new clsvtz_ContentAttachmentEN()
{
mId = objvtz_ContentAttachmentENS.mId, //mId
ContentTypeId = objvtz_ContentAttachmentENS.ContentTypeId, //内容类型Id
ContentTypeName = objvtz_ContentAttachmentENS.ContentTypeName, //内容类型名
TableName = objvtz_ContentAttachmentENS.TableName, //主表表名
FldName = objvtz_ContentAttachmentENS.FldName, //字段名
TableNameKey = objvtz_ContentAttachmentENS.TableNameKey, //主表主键值
OrderNum = objvtz_ContentAttachmentENS.OrderNum, //序号
AttachmentTitle = objvtz_ContentAttachmentENS.AttachmentTitle, //附件标题
IdResourceType = objvtz_ContentAttachmentENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvtz_ContentAttachmentENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvtz_ContentAttachmentENS.ResourceTypeName, //资源类型名称
TextContent = objvtz_ContentAttachmentENS.TextContent, //文本内容
FileName = objvtz_ContentAttachmentENS.FileName, //文件名称
Extension = objvtz_ContentAttachmentENS.Extension, //扩展名
FilePath = objvtz_ContentAttachmentENS.FilePath, //文件路径
PdfFilePath = objvtz_ContentAttachmentENS.PdfFilePath, //Pdf文件路径
SwfFilePath = objvtz_ContentAttachmentENS.SwfFilePath, //Swf文件路径
FileSize = objvtz_ContentAttachmentENS.FileSize, //文件大小
FileSizeUnit = objvtz_ContentAttachmentENS.FileSizeUnit, //文件大小单位
ImageHeight = objvtz_ContentAttachmentENS.ImageHeight, //图像高
ImageWidth = objvtz_ContentAttachmentENS.ImageWidth, //图像宽
UploadDate = objvtz_ContentAttachmentENS.UploadDate, //上传时间
UploadPerson = objvtz_ContentAttachmentENS.UploadPerson, //上传人
UpdDate = objvtz_ContentAttachmentENS.UpdDate, //修改日期
UpdUserId = objvtz_ContentAttachmentENS.UpdUserId, //修改用户Id
Memo = objvtz_ContentAttachmentENS.Memo, //备注
CourseId = objvtz_ContentAttachmentENS.CourseId, //课程Id
};
 return objvtz_ContentAttachmentENT;
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
public static void CheckProperty4Condition(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN)
{
 clsvtz_ContentAttachmentBL.vtz_ContentAttachmentDA.CheckProperty4Condition(objvtz_ContentAttachmentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvtz_ContentAttachmentEN objvtz_ContentAttachmentCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.mId) == true)
{
string strComparisonOpmId = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convtz_ContentAttachment.mId, objvtz_ContentAttachmentCond.mId, strComparisonOpmId);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.ContentTypeId) == true)
{
string strComparisonOpContentTypeId = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.ContentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.ContentTypeId, objvtz_ContentAttachmentCond.ContentTypeId, strComparisonOpContentTypeId);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.ContentTypeName) == true)
{
string strComparisonOpContentTypeName = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.ContentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.ContentTypeName, objvtz_ContentAttachmentCond.ContentTypeName, strComparisonOpContentTypeName);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.TableName) == true)
{
string strComparisonOpTableName = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.TableName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.TableName, objvtz_ContentAttachmentCond.TableName, strComparisonOpTableName);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.FldName) == true)
{
string strComparisonOpFldName = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.FldName, objvtz_ContentAttachmentCond.FldName, strComparisonOpFldName);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.TableNameKey) == true)
{
string strComparisonOpTableNameKey = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.TableNameKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.TableNameKey, objvtz_ContentAttachmentCond.TableNameKey, strComparisonOpTableNameKey);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.OrderNum) == true)
{
string strComparisonOpOrderNum = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convtz_ContentAttachment.OrderNum, objvtz_ContentAttachmentCond.OrderNum, strComparisonOpOrderNum);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.AttachmentTitle) == true)
{
string strComparisonOpAttachmentTitle = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.AttachmentTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.AttachmentTitle, objvtz_ContentAttachmentCond.AttachmentTitle, strComparisonOpAttachmentTitle);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.IdResourceType, objvtz_ContentAttachmentCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.ResourceTypeID, objvtz_ContentAttachmentCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.ResourceTypeName, objvtz_ContentAttachmentCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.TextContent) == true)
{
string strComparisonOpTextContent = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.TextContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.TextContent, objvtz_ContentAttachmentCond.TextContent, strComparisonOpTextContent);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.FileName) == true)
{
string strComparisonOpFileName = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.FileName, objvtz_ContentAttachmentCond.FileName, strComparisonOpFileName);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.Extension) == true)
{
string strComparisonOpExtension = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.Extension];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.Extension, objvtz_ContentAttachmentCond.Extension, strComparisonOpExtension);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.FilePath) == true)
{
string strComparisonOpFilePath = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.FilePath, objvtz_ContentAttachmentCond.FilePath, strComparisonOpFilePath);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.PdfFilePath) == true)
{
string strComparisonOpPdfFilePath = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.PdfFilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.PdfFilePath, objvtz_ContentAttachmentCond.PdfFilePath, strComparisonOpPdfFilePath);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.SwfFilePath) == true)
{
string strComparisonOpSwfFilePath = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.SwfFilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.SwfFilePath, objvtz_ContentAttachmentCond.SwfFilePath, strComparisonOpSwfFilePath);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.FileSize) == true)
{
string strComparisonOpFileSize = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.FileSize];
strWhereCond += string.Format(" And {0} {2} {1}", convtz_ContentAttachment.FileSize, objvtz_ContentAttachmentCond.FileSize, strComparisonOpFileSize);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.FileSizeUnit) == true)
{
string strComparisonOpFileSizeUnit = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.FileSizeUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.FileSizeUnit, objvtz_ContentAttachmentCond.FileSizeUnit, strComparisonOpFileSizeUnit);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.ImageHeight) == true)
{
string strComparisonOpImageHeight = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.ImageHeight];
strWhereCond += string.Format(" And {0} {2} {1}", convtz_ContentAttachment.ImageHeight, objvtz_ContentAttachmentCond.ImageHeight, strComparisonOpImageHeight);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.ImageWidth) == true)
{
string strComparisonOpImageWidth = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.ImageWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convtz_ContentAttachment.ImageWidth, objvtz_ContentAttachmentCond.ImageWidth, strComparisonOpImageWidth);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.UploadDate) == true)
{
string strComparisonOpUploadDate = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.UploadDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.UploadDate, objvtz_ContentAttachmentCond.UploadDate, strComparisonOpUploadDate);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.UploadPerson) == true)
{
string strComparisonOpUploadPerson = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.UploadPerson];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.UploadPerson, objvtz_ContentAttachmentCond.UploadPerson, strComparisonOpUploadPerson);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.UpdDate) == true)
{
string strComparisonOpUpdDate = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.UpdDate, objvtz_ContentAttachmentCond.UpdDate, strComparisonOpUpdDate);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.UpdUserId, objvtz_ContentAttachmentCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.Memo) == true)
{
string strComparisonOpMemo = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.Memo, objvtz_ContentAttachmentCond.Memo, strComparisonOpMemo);
}
if (objvtz_ContentAttachmentCond.IsUpdated(convtz_ContentAttachment.CourseId) == true)
{
string strComparisonOpCourseId = objvtz_ContentAttachmentCond.dicFldComparisonOp[convtz_ContentAttachment.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convtz_ContentAttachment.CourseId, objvtz_ContentAttachmentCond.CourseId, strComparisonOpCourseId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vtz_ContentAttachment
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v内容附件(vtz_ContentAttachment)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvtz_ContentAttachmentBL
{
public static RelatedActions_vtz_ContentAttachment relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvtz_ContentAttachmentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvtz_ContentAttachmentDA vtz_ContentAttachmentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvtz_ContentAttachmentDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvtz_ContentAttachmentBL()
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
if (string.IsNullOrEmpty(clsvtz_ContentAttachmentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvtz_ContentAttachmentEN._ConnectString);
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
public static DataTable GetDataTable_vtz_ContentAttachment(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vtz_ContentAttachmentDA.GetDataTable_vtz_ContentAttachment(strWhereCond);
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
objDT = vtz_ContentAttachmentDA.GetDataTable(strWhereCond);
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
objDT = vtz_ContentAttachmentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vtz_ContentAttachmentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vtz_ContentAttachmentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vtz_ContentAttachmentDA.GetDataTable_Top(objTopPara);
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
objDT = vtz_ContentAttachmentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vtz_ContentAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vtz_ContentAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvtz_ContentAttachmentEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvtz_ContentAttachmentEN> arrObjLst = new List<clsvtz_ContentAttachmentEN>(); 
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
	clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = new clsvtz_ContentAttachmentEN();
try
{
objvtz_ContentAttachmentEN.mId = Int32.Parse(objRow[convtz_ContentAttachment.mId].ToString().Trim()); //mId
objvtz_ContentAttachmentEN.ContentTypeId = objRow[convtz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objvtz_ContentAttachmentEN.ContentTypeName = objRow[convtz_ContentAttachment.ContentTypeName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.ContentTypeName].ToString().Trim(); //内容类型名
objvtz_ContentAttachmentEN.TableName = objRow[convtz_ContentAttachment.TableName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.TableName].ToString().Trim(); //主表表名
objvtz_ContentAttachmentEN.FldName = objRow[convtz_ContentAttachment.FldName].ToString().Trim(); //字段名
objvtz_ContentAttachmentEN.TableNameKey = objRow[convtz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objvtz_ContentAttachmentEN.OrderNum = objRow[convtz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objvtz_ContentAttachmentEN.AttachmentTitle = objRow[convtz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[convtz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objvtz_ContentAttachmentEN.IdResourceType = objRow[convtz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvtz_ContentAttachmentEN.ResourceTypeID = objRow[convtz_ContentAttachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvtz_ContentAttachmentEN.ResourceTypeName = objRow[convtz_ContentAttachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvtz_ContentAttachmentEN.TextContent = objRow[convtz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objvtz_ContentAttachmentEN.FileName = objRow[convtz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objvtz_ContentAttachmentEN.Extension = objRow[convtz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objvtz_ContentAttachmentEN.FilePath = objRow[convtz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objvtz_ContentAttachmentEN.PdfFilePath = objRow[convtz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objvtz_ContentAttachmentEN.SwfFilePath = objRow[convtz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objvtz_ContentAttachmentEN.FileSize = objRow[convtz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convtz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objvtz_ContentAttachmentEN.FileSizeUnit = objRow[convtz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvtz_ContentAttachmentEN.ImageHeight = objRow[convtz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objvtz_ContentAttachmentEN.ImageWidth = objRow[convtz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objvtz_ContentAttachmentEN.UploadDate = objRow[convtz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objvtz_ContentAttachmentEN.UploadPerson = objRow[convtz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objvtz_ContentAttachmentEN.UpdDate = objRow[convtz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objvtz_ContentAttachmentEN.UpdUserId = objRow[convtz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvtz_ContentAttachmentEN.Memo = objRow[convtz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Memo].ToString().Trim(); //备注
objvtz_ContentAttachmentEN.CourseId = objRow[convtz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvtz_ContentAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvtz_ContentAttachmentEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvtz_ContentAttachmentEN._CurrTabName, strCourseId);
List<clsvtz_ContentAttachmentEN> arrvtz_ContentAttachmentObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvtz_ContentAttachmentEN> arrvtz_ContentAttachmentObjLst_Sel =
arrvtz_ContentAttachmentObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvtz_ContentAttachmentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvtz_ContentAttachmentEN> GetObjLst(string strWhereCond)
{
List<clsvtz_ContentAttachmentEN> arrObjLst = new List<clsvtz_ContentAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = new clsvtz_ContentAttachmentEN();
try
{
objvtz_ContentAttachmentEN.mId = Int32.Parse(objRow[convtz_ContentAttachment.mId].ToString().Trim()); //mId
objvtz_ContentAttachmentEN.ContentTypeId = objRow[convtz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objvtz_ContentAttachmentEN.ContentTypeName = objRow[convtz_ContentAttachment.ContentTypeName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.ContentTypeName].ToString().Trim(); //内容类型名
objvtz_ContentAttachmentEN.TableName = objRow[convtz_ContentAttachment.TableName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.TableName].ToString().Trim(); //主表表名
objvtz_ContentAttachmentEN.FldName = objRow[convtz_ContentAttachment.FldName].ToString().Trim(); //字段名
objvtz_ContentAttachmentEN.TableNameKey = objRow[convtz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objvtz_ContentAttachmentEN.OrderNum = objRow[convtz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objvtz_ContentAttachmentEN.AttachmentTitle = objRow[convtz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[convtz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objvtz_ContentAttachmentEN.IdResourceType = objRow[convtz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvtz_ContentAttachmentEN.ResourceTypeID = objRow[convtz_ContentAttachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvtz_ContentAttachmentEN.ResourceTypeName = objRow[convtz_ContentAttachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvtz_ContentAttachmentEN.TextContent = objRow[convtz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objvtz_ContentAttachmentEN.FileName = objRow[convtz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objvtz_ContentAttachmentEN.Extension = objRow[convtz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objvtz_ContentAttachmentEN.FilePath = objRow[convtz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objvtz_ContentAttachmentEN.PdfFilePath = objRow[convtz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objvtz_ContentAttachmentEN.SwfFilePath = objRow[convtz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objvtz_ContentAttachmentEN.FileSize = objRow[convtz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convtz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objvtz_ContentAttachmentEN.FileSizeUnit = objRow[convtz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvtz_ContentAttachmentEN.ImageHeight = objRow[convtz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objvtz_ContentAttachmentEN.ImageWidth = objRow[convtz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objvtz_ContentAttachmentEN.UploadDate = objRow[convtz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objvtz_ContentAttachmentEN.UploadPerson = objRow[convtz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objvtz_ContentAttachmentEN.UpdDate = objRow[convtz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objvtz_ContentAttachmentEN.UpdUserId = objRow[convtz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvtz_ContentAttachmentEN.Memo = objRow[convtz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Memo].ToString().Trim(); //备注
objvtz_ContentAttachmentEN.CourseId = objRow[convtz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvtz_ContentAttachmentEN);
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
public static List<clsvtz_ContentAttachmentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvtz_ContentAttachmentEN> arrObjLst = new List<clsvtz_ContentAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = new clsvtz_ContentAttachmentEN();
try
{
objvtz_ContentAttachmentEN.mId = Int32.Parse(objRow[convtz_ContentAttachment.mId].ToString().Trim()); //mId
objvtz_ContentAttachmentEN.ContentTypeId = objRow[convtz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objvtz_ContentAttachmentEN.ContentTypeName = objRow[convtz_ContentAttachment.ContentTypeName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.ContentTypeName].ToString().Trim(); //内容类型名
objvtz_ContentAttachmentEN.TableName = objRow[convtz_ContentAttachment.TableName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.TableName].ToString().Trim(); //主表表名
objvtz_ContentAttachmentEN.FldName = objRow[convtz_ContentAttachment.FldName].ToString().Trim(); //字段名
objvtz_ContentAttachmentEN.TableNameKey = objRow[convtz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objvtz_ContentAttachmentEN.OrderNum = objRow[convtz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objvtz_ContentAttachmentEN.AttachmentTitle = objRow[convtz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[convtz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objvtz_ContentAttachmentEN.IdResourceType = objRow[convtz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvtz_ContentAttachmentEN.ResourceTypeID = objRow[convtz_ContentAttachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvtz_ContentAttachmentEN.ResourceTypeName = objRow[convtz_ContentAttachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvtz_ContentAttachmentEN.TextContent = objRow[convtz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objvtz_ContentAttachmentEN.FileName = objRow[convtz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objvtz_ContentAttachmentEN.Extension = objRow[convtz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objvtz_ContentAttachmentEN.FilePath = objRow[convtz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objvtz_ContentAttachmentEN.PdfFilePath = objRow[convtz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objvtz_ContentAttachmentEN.SwfFilePath = objRow[convtz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objvtz_ContentAttachmentEN.FileSize = objRow[convtz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convtz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objvtz_ContentAttachmentEN.FileSizeUnit = objRow[convtz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvtz_ContentAttachmentEN.ImageHeight = objRow[convtz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objvtz_ContentAttachmentEN.ImageWidth = objRow[convtz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objvtz_ContentAttachmentEN.UploadDate = objRow[convtz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objvtz_ContentAttachmentEN.UploadPerson = objRow[convtz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objvtz_ContentAttachmentEN.UpdDate = objRow[convtz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objvtz_ContentAttachmentEN.UpdUserId = objRow[convtz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvtz_ContentAttachmentEN.Memo = objRow[convtz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Memo].ToString().Trim(); //备注
objvtz_ContentAttachmentEN.CourseId = objRow[convtz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvtz_ContentAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvtz_ContentAttachmentEN> GetSubObjLstCache(clsvtz_ContentAttachmentEN objvtz_ContentAttachmentCond)
{
 string strCourseId = objvtz_ContentAttachmentCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvtz_ContentAttachmentBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvtz_ContentAttachmentEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvtz_ContentAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convtz_ContentAttachment.AttributeName)
{
if (objvtz_ContentAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objvtz_ContentAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvtz_ContentAttachmentCond[strFldName].ToString());
}
else
{
if (objvtz_ContentAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvtz_ContentAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvtz_ContentAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvtz_ContentAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvtz_ContentAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvtz_ContentAttachmentCond[strFldName]));
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
public static List<clsvtz_ContentAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvtz_ContentAttachmentEN> arrObjLst = new List<clsvtz_ContentAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = new clsvtz_ContentAttachmentEN();
try
{
objvtz_ContentAttachmentEN.mId = Int32.Parse(objRow[convtz_ContentAttachment.mId].ToString().Trim()); //mId
objvtz_ContentAttachmentEN.ContentTypeId = objRow[convtz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objvtz_ContentAttachmentEN.ContentTypeName = objRow[convtz_ContentAttachment.ContentTypeName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.ContentTypeName].ToString().Trim(); //内容类型名
objvtz_ContentAttachmentEN.TableName = objRow[convtz_ContentAttachment.TableName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.TableName].ToString().Trim(); //主表表名
objvtz_ContentAttachmentEN.FldName = objRow[convtz_ContentAttachment.FldName].ToString().Trim(); //字段名
objvtz_ContentAttachmentEN.TableNameKey = objRow[convtz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objvtz_ContentAttachmentEN.OrderNum = objRow[convtz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objvtz_ContentAttachmentEN.AttachmentTitle = objRow[convtz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[convtz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objvtz_ContentAttachmentEN.IdResourceType = objRow[convtz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvtz_ContentAttachmentEN.ResourceTypeID = objRow[convtz_ContentAttachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvtz_ContentAttachmentEN.ResourceTypeName = objRow[convtz_ContentAttachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvtz_ContentAttachmentEN.TextContent = objRow[convtz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objvtz_ContentAttachmentEN.FileName = objRow[convtz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objvtz_ContentAttachmentEN.Extension = objRow[convtz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objvtz_ContentAttachmentEN.FilePath = objRow[convtz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objvtz_ContentAttachmentEN.PdfFilePath = objRow[convtz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objvtz_ContentAttachmentEN.SwfFilePath = objRow[convtz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objvtz_ContentAttachmentEN.FileSize = objRow[convtz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convtz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objvtz_ContentAttachmentEN.FileSizeUnit = objRow[convtz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvtz_ContentAttachmentEN.ImageHeight = objRow[convtz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objvtz_ContentAttachmentEN.ImageWidth = objRow[convtz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objvtz_ContentAttachmentEN.UploadDate = objRow[convtz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objvtz_ContentAttachmentEN.UploadPerson = objRow[convtz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objvtz_ContentAttachmentEN.UpdDate = objRow[convtz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objvtz_ContentAttachmentEN.UpdUserId = objRow[convtz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvtz_ContentAttachmentEN.Memo = objRow[convtz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Memo].ToString().Trim(); //备注
objvtz_ContentAttachmentEN.CourseId = objRow[convtz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvtz_ContentAttachmentEN);
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
public static List<clsvtz_ContentAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvtz_ContentAttachmentEN> arrObjLst = new List<clsvtz_ContentAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = new clsvtz_ContentAttachmentEN();
try
{
objvtz_ContentAttachmentEN.mId = Int32.Parse(objRow[convtz_ContentAttachment.mId].ToString().Trim()); //mId
objvtz_ContentAttachmentEN.ContentTypeId = objRow[convtz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objvtz_ContentAttachmentEN.ContentTypeName = objRow[convtz_ContentAttachment.ContentTypeName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.ContentTypeName].ToString().Trim(); //内容类型名
objvtz_ContentAttachmentEN.TableName = objRow[convtz_ContentAttachment.TableName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.TableName].ToString().Trim(); //主表表名
objvtz_ContentAttachmentEN.FldName = objRow[convtz_ContentAttachment.FldName].ToString().Trim(); //字段名
objvtz_ContentAttachmentEN.TableNameKey = objRow[convtz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objvtz_ContentAttachmentEN.OrderNum = objRow[convtz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objvtz_ContentAttachmentEN.AttachmentTitle = objRow[convtz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[convtz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objvtz_ContentAttachmentEN.IdResourceType = objRow[convtz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvtz_ContentAttachmentEN.ResourceTypeID = objRow[convtz_ContentAttachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvtz_ContentAttachmentEN.ResourceTypeName = objRow[convtz_ContentAttachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvtz_ContentAttachmentEN.TextContent = objRow[convtz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objvtz_ContentAttachmentEN.FileName = objRow[convtz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objvtz_ContentAttachmentEN.Extension = objRow[convtz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objvtz_ContentAttachmentEN.FilePath = objRow[convtz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objvtz_ContentAttachmentEN.PdfFilePath = objRow[convtz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objvtz_ContentAttachmentEN.SwfFilePath = objRow[convtz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objvtz_ContentAttachmentEN.FileSize = objRow[convtz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convtz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objvtz_ContentAttachmentEN.FileSizeUnit = objRow[convtz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvtz_ContentAttachmentEN.ImageHeight = objRow[convtz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objvtz_ContentAttachmentEN.ImageWidth = objRow[convtz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objvtz_ContentAttachmentEN.UploadDate = objRow[convtz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objvtz_ContentAttachmentEN.UploadPerson = objRow[convtz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objvtz_ContentAttachmentEN.UpdDate = objRow[convtz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objvtz_ContentAttachmentEN.UpdUserId = objRow[convtz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvtz_ContentAttachmentEN.Memo = objRow[convtz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Memo].ToString().Trim(); //备注
objvtz_ContentAttachmentEN.CourseId = objRow[convtz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvtz_ContentAttachmentEN);
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
List<clsvtz_ContentAttachmentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvtz_ContentAttachmentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvtz_ContentAttachmentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvtz_ContentAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvtz_ContentAttachmentEN> arrObjLst = new List<clsvtz_ContentAttachmentEN>(); 
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
	clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = new clsvtz_ContentAttachmentEN();
try
{
objvtz_ContentAttachmentEN.mId = Int32.Parse(objRow[convtz_ContentAttachment.mId].ToString().Trim()); //mId
objvtz_ContentAttachmentEN.ContentTypeId = objRow[convtz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objvtz_ContentAttachmentEN.ContentTypeName = objRow[convtz_ContentAttachment.ContentTypeName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.ContentTypeName].ToString().Trim(); //内容类型名
objvtz_ContentAttachmentEN.TableName = objRow[convtz_ContentAttachment.TableName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.TableName].ToString().Trim(); //主表表名
objvtz_ContentAttachmentEN.FldName = objRow[convtz_ContentAttachment.FldName].ToString().Trim(); //字段名
objvtz_ContentAttachmentEN.TableNameKey = objRow[convtz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objvtz_ContentAttachmentEN.OrderNum = objRow[convtz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objvtz_ContentAttachmentEN.AttachmentTitle = objRow[convtz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[convtz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objvtz_ContentAttachmentEN.IdResourceType = objRow[convtz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvtz_ContentAttachmentEN.ResourceTypeID = objRow[convtz_ContentAttachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvtz_ContentAttachmentEN.ResourceTypeName = objRow[convtz_ContentAttachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvtz_ContentAttachmentEN.TextContent = objRow[convtz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objvtz_ContentAttachmentEN.FileName = objRow[convtz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objvtz_ContentAttachmentEN.Extension = objRow[convtz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objvtz_ContentAttachmentEN.FilePath = objRow[convtz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objvtz_ContentAttachmentEN.PdfFilePath = objRow[convtz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objvtz_ContentAttachmentEN.SwfFilePath = objRow[convtz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objvtz_ContentAttachmentEN.FileSize = objRow[convtz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convtz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objvtz_ContentAttachmentEN.FileSizeUnit = objRow[convtz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvtz_ContentAttachmentEN.ImageHeight = objRow[convtz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objvtz_ContentAttachmentEN.ImageWidth = objRow[convtz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objvtz_ContentAttachmentEN.UploadDate = objRow[convtz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objvtz_ContentAttachmentEN.UploadPerson = objRow[convtz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objvtz_ContentAttachmentEN.UpdDate = objRow[convtz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objvtz_ContentAttachmentEN.UpdUserId = objRow[convtz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvtz_ContentAttachmentEN.Memo = objRow[convtz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Memo].ToString().Trim(); //备注
objvtz_ContentAttachmentEN.CourseId = objRow[convtz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvtz_ContentAttachmentEN);
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
public static List<clsvtz_ContentAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvtz_ContentAttachmentEN> arrObjLst = new List<clsvtz_ContentAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = new clsvtz_ContentAttachmentEN();
try
{
objvtz_ContentAttachmentEN.mId = Int32.Parse(objRow[convtz_ContentAttachment.mId].ToString().Trim()); //mId
objvtz_ContentAttachmentEN.ContentTypeId = objRow[convtz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objvtz_ContentAttachmentEN.ContentTypeName = objRow[convtz_ContentAttachment.ContentTypeName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.ContentTypeName].ToString().Trim(); //内容类型名
objvtz_ContentAttachmentEN.TableName = objRow[convtz_ContentAttachment.TableName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.TableName].ToString().Trim(); //主表表名
objvtz_ContentAttachmentEN.FldName = objRow[convtz_ContentAttachment.FldName].ToString().Trim(); //字段名
objvtz_ContentAttachmentEN.TableNameKey = objRow[convtz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objvtz_ContentAttachmentEN.OrderNum = objRow[convtz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objvtz_ContentAttachmentEN.AttachmentTitle = objRow[convtz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[convtz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objvtz_ContentAttachmentEN.IdResourceType = objRow[convtz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvtz_ContentAttachmentEN.ResourceTypeID = objRow[convtz_ContentAttachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvtz_ContentAttachmentEN.ResourceTypeName = objRow[convtz_ContentAttachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvtz_ContentAttachmentEN.TextContent = objRow[convtz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objvtz_ContentAttachmentEN.FileName = objRow[convtz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objvtz_ContentAttachmentEN.Extension = objRow[convtz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objvtz_ContentAttachmentEN.FilePath = objRow[convtz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objvtz_ContentAttachmentEN.PdfFilePath = objRow[convtz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objvtz_ContentAttachmentEN.SwfFilePath = objRow[convtz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objvtz_ContentAttachmentEN.FileSize = objRow[convtz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convtz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objvtz_ContentAttachmentEN.FileSizeUnit = objRow[convtz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvtz_ContentAttachmentEN.ImageHeight = objRow[convtz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objvtz_ContentAttachmentEN.ImageWidth = objRow[convtz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objvtz_ContentAttachmentEN.UploadDate = objRow[convtz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objvtz_ContentAttachmentEN.UploadPerson = objRow[convtz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objvtz_ContentAttachmentEN.UpdDate = objRow[convtz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objvtz_ContentAttachmentEN.UpdUserId = objRow[convtz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvtz_ContentAttachmentEN.Memo = objRow[convtz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Memo].ToString().Trim(); //备注
objvtz_ContentAttachmentEN.CourseId = objRow[convtz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvtz_ContentAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvtz_ContentAttachmentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvtz_ContentAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvtz_ContentAttachmentEN> arrObjLst = new List<clsvtz_ContentAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = new clsvtz_ContentAttachmentEN();
try
{
objvtz_ContentAttachmentEN.mId = Int32.Parse(objRow[convtz_ContentAttachment.mId].ToString().Trim()); //mId
objvtz_ContentAttachmentEN.ContentTypeId = objRow[convtz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objvtz_ContentAttachmentEN.ContentTypeName = objRow[convtz_ContentAttachment.ContentTypeName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.ContentTypeName].ToString().Trim(); //内容类型名
objvtz_ContentAttachmentEN.TableName = objRow[convtz_ContentAttachment.TableName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.TableName].ToString().Trim(); //主表表名
objvtz_ContentAttachmentEN.FldName = objRow[convtz_ContentAttachment.FldName].ToString().Trim(); //字段名
objvtz_ContentAttachmentEN.TableNameKey = objRow[convtz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objvtz_ContentAttachmentEN.OrderNum = objRow[convtz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objvtz_ContentAttachmentEN.AttachmentTitle = objRow[convtz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[convtz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objvtz_ContentAttachmentEN.IdResourceType = objRow[convtz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvtz_ContentAttachmentEN.ResourceTypeID = objRow[convtz_ContentAttachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvtz_ContentAttachmentEN.ResourceTypeName = objRow[convtz_ContentAttachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvtz_ContentAttachmentEN.TextContent = objRow[convtz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objvtz_ContentAttachmentEN.FileName = objRow[convtz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objvtz_ContentAttachmentEN.Extension = objRow[convtz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objvtz_ContentAttachmentEN.FilePath = objRow[convtz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objvtz_ContentAttachmentEN.PdfFilePath = objRow[convtz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objvtz_ContentAttachmentEN.SwfFilePath = objRow[convtz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objvtz_ContentAttachmentEN.FileSize = objRow[convtz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convtz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objvtz_ContentAttachmentEN.FileSizeUnit = objRow[convtz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvtz_ContentAttachmentEN.ImageHeight = objRow[convtz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objvtz_ContentAttachmentEN.ImageWidth = objRow[convtz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objvtz_ContentAttachmentEN.UploadDate = objRow[convtz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objvtz_ContentAttachmentEN.UploadPerson = objRow[convtz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objvtz_ContentAttachmentEN.UpdDate = objRow[convtz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objvtz_ContentAttachmentEN.UpdUserId = objRow[convtz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvtz_ContentAttachmentEN.Memo = objRow[convtz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Memo].ToString().Trim(); //备注
objvtz_ContentAttachmentEN.CourseId = objRow[convtz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvtz_ContentAttachmentEN);
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
public static List<clsvtz_ContentAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvtz_ContentAttachmentEN> arrObjLst = new List<clsvtz_ContentAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = new clsvtz_ContentAttachmentEN();
try
{
objvtz_ContentAttachmentEN.mId = Int32.Parse(objRow[convtz_ContentAttachment.mId].ToString().Trim()); //mId
objvtz_ContentAttachmentEN.ContentTypeId = objRow[convtz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objvtz_ContentAttachmentEN.ContentTypeName = objRow[convtz_ContentAttachment.ContentTypeName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.ContentTypeName].ToString().Trim(); //内容类型名
objvtz_ContentAttachmentEN.TableName = objRow[convtz_ContentAttachment.TableName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.TableName].ToString().Trim(); //主表表名
objvtz_ContentAttachmentEN.FldName = objRow[convtz_ContentAttachment.FldName].ToString().Trim(); //字段名
objvtz_ContentAttachmentEN.TableNameKey = objRow[convtz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objvtz_ContentAttachmentEN.OrderNum = objRow[convtz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objvtz_ContentAttachmentEN.AttachmentTitle = objRow[convtz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[convtz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objvtz_ContentAttachmentEN.IdResourceType = objRow[convtz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvtz_ContentAttachmentEN.ResourceTypeID = objRow[convtz_ContentAttachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvtz_ContentAttachmentEN.ResourceTypeName = objRow[convtz_ContentAttachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvtz_ContentAttachmentEN.TextContent = objRow[convtz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objvtz_ContentAttachmentEN.FileName = objRow[convtz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objvtz_ContentAttachmentEN.Extension = objRow[convtz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objvtz_ContentAttachmentEN.FilePath = objRow[convtz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objvtz_ContentAttachmentEN.PdfFilePath = objRow[convtz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objvtz_ContentAttachmentEN.SwfFilePath = objRow[convtz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objvtz_ContentAttachmentEN.FileSize = objRow[convtz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convtz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objvtz_ContentAttachmentEN.FileSizeUnit = objRow[convtz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvtz_ContentAttachmentEN.ImageHeight = objRow[convtz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objvtz_ContentAttachmentEN.ImageWidth = objRow[convtz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objvtz_ContentAttachmentEN.UploadDate = objRow[convtz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objvtz_ContentAttachmentEN.UploadPerson = objRow[convtz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objvtz_ContentAttachmentEN.UpdDate = objRow[convtz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objvtz_ContentAttachmentEN.UpdUserId = objRow[convtz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvtz_ContentAttachmentEN.Memo = objRow[convtz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Memo].ToString().Trim(); //备注
objvtz_ContentAttachmentEN.CourseId = objRow[convtz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvtz_ContentAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvtz_ContentAttachmentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvtz_ContentAttachmentEN> arrObjLst = new List<clsvtz_ContentAttachmentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = new clsvtz_ContentAttachmentEN();
try
{
objvtz_ContentAttachmentEN.mId = Int32.Parse(objRow[convtz_ContentAttachment.mId].ToString().Trim()); //mId
objvtz_ContentAttachmentEN.ContentTypeId = objRow[convtz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objvtz_ContentAttachmentEN.ContentTypeName = objRow[convtz_ContentAttachment.ContentTypeName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.ContentTypeName].ToString().Trim(); //内容类型名
objvtz_ContentAttachmentEN.TableName = objRow[convtz_ContentAttachment.TableName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.TableName].ToString().Trim(); //主表表名
objvtz_ContentAttachmentEN.FldName = objRow[convtz_ContentAttachment.FldName].ToString().Trim(); //字段名
objvtz_ContentAttachmentEN.TableNameKey = objRow[convtz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objvtz_ContentAttachmentEN.OrderNum = objRow[convtz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objvtz_ContentAttachmentEN.AttachmentTitle = objRow[convtz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[convtz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objvtz_ContentAttachmentEN.IdResourceType = objRow[convtz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objvtz_ContentAttachmentEN.ResourceTypeID = objRow[convtz_ContentAttachment.ResourceTypeID].ToString().Trim(); //资源类型ID
objvtz_ContentAttachmentEN.ResourceTypeName = objRow[convtz_ContentAttachment.ResourceTypeName].ToString().Trim(); //资源类型名称
objvtz_ContentAttachmentEN.TextContent = objRow[convtz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objvtz_ContentAttachmentEN.FileName = objRow[convtz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objvtz_ContentAttachmentEN.Extension = objRow[convtz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objvtz_ContentAttachmentEN.FilePath = objRow[convtz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objvtz_ContentAttachmentEN.PdfFilePath = objRow[convtz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objvtz_ContentAttachmentEN.SwfFilePath = objRow[convtz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[convtz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objvtz_ContentAttachmentEN.FileSize = objRow[convtz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convtz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objvtz_ContentAttachmentEN.FileSizeUnit = objRow[convtz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[convtz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objvtz_ContentAttachmentEN.ImageHeight = objRow[convtz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objvtz_ContentAttachmentEN.ImageWidth = objRow[convtz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convtz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objvtz_ContentAttachmentEN.UploadDate = objRow[convtz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objvtz_ContentAttachmentEN.UploadPerson = objRow[convtz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objvtz_ContentAttachmentEN.UpdDate = objRow[convtz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objvtz_ContentAttachmentEN.UpdUserId = objRow[convtz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvtz_ContentAttachmentEN.Memo = objRow[convtz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[convtz_ContentAttachment.Memo].ToString().Trim(); //备注
objvtz_ContentAttachmentEN.CourseId = objRow[convtz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[convtz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvtz_ContentAttachmentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvtz_ContentAttachment(ref clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN)
{
bool bolResult = vtz_ContentAttachmentDA.Getvtz_ContentAttachment(ref objvtz_ContentAttachmentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvtz_ContentAttachmentEN GetObjBymId(long lngmId)
{
clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = vtz_ContentAttachmentDA.GetObjBymId(lngmId);
return objvtz_ContentAttachmentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvtz_ContentAttachmentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = vtz_ContentAttachmentDA.GetFirstObj(strWhereCond);
 return objvtz_ContentAttachmentEN;
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
public static clsvtz_ContentAttachmentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = vtz_ContentAttachmentDA.GetObjByDataRow(objRow);
 return objvtz_ContentAttachmentEN;
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
public static clsvtz_ContentAttachmentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN = vtz_ContentAttachmentDA.GetObjByDataRow(objRow);
 return objvtz_ContentAttachmentEN;
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
 /// <param name = "lstvtz_ContentAttachmentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvtz_ContentAttachmentEN GetObjBymIdFromList(long lngmId, List<clsvtz_ContentAttachmentEN> lstvtz_ContentAttachmentObjLst)
{
foreach (clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN in lstvtz_ContentAttachmentObjLst)
{
if (objvtz_ContentAttachmentEN.mId == lngmId)
{
return objvtz_ContentAttachmentEN;
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
 lngmId = new clsvtz_ContentAttachmentDA().GetFirstID(strWhereCond);
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
 arrList = vtz_ContentAttachmentDA.GetID(strWhereCond);
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
bool bolIsExist = vtz_ContentAttachmentDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vtz_ContentAttachmentDA.IsExist(lngmId);
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
 bolIsExist = clsvtz_ContentAttachmentDA.IsExistTable();
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
 bolIsExist = vtz_ContentAttachmentDA.IsExistTable(strTabName);
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
objvtz_ContentAttachmentENT.IdResourceType = objvtz_ContentAttachmentENS.IdResourceType; //资源类型流水号
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
 /// <param name = "objvtz_ContentAttachmentEN">源简化对象</param>
 public static void SetUpdFlag(clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN)
{
try
{
objvtz_ContentAttachmentEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvtz_ContentAttachmentEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convtz_ContentAttachment.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.mId = objvtz_ContentAttachmentEN.mId; //mId
}
if (arrFldSet.Contains(convtz_ContentAttachment.ContentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.ContentTypeId = objvtz_ContentAttachmentEN.ContentTypeId; //内容类型Id
}
if (arrFldSet.Contains(convtz_ContentAttachment.ContentTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.ContentTypeName = objvtz_ContentAttachmentEN.ContentTypeName == "[null]" ? null :  objvtz_ContentAttachmentEN.ContentTypeName; //内容类型名
}
if (arrFldSet.Contains(convtz_ContentAttachment.TableName, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.TableName = objvtz_ContentAttachmentEN.TableName == "[null]" ? null :  objvtz_ContentAttachmentEN.TableName; //主表表名
}
if (arrFldSet.Contains(convtz_ContentAttachment.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.FldName = objvtz_ContentAttachmentEN.FldName; //字段名
}
if (arrFldSet.Contains(convtz_ContentAttachment.TableNameKey, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.TableNameKey = objvtz_ContentAttachmentEN.TableNameKey; //主表主键值
}
if (arrFldSet.Contains(convtz_ContentAttachment.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.OrderNum = objvtz_ContentAttachmentEN.OrderNum; //序号
}
if (arrFldSet.Contains(convtz_ContentAttachment.AttachmentTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.AttachmentTitle = objvtz_ContentAttachmentEN.AttachmentTitle == "[null]" ? null :  objvtz_ContentAttachmentEN.AttachmentTitle; //附件标题
}
if (arrFldSet.Contains(convtz_ContentAttachment.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.IdResourceType = objvtz_ContentAttachmentEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convtz_ContentAttachment.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.ResourceTypeID = objvtz_ContentAttachmentEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convtz_ContentAttachment.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.ResourceTypeName = objvtz_ContentAttachmentEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convtz_ContentAttachment.TextContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.TextContent = objvtz_ContentAttachmentEN.TextContent; //文本内容
}
if (arrFldSet.Contains(convtz_ContentAttachment.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.FileName = objvtz_ContentAttachmentEN.FileName == "[null]" ? null :  objvtz_ContentAttachmentEN.FileName; //文件名称
}
if (arrFldSet.Contains(convtz_ContentAttachment.Extension, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.Extension = objvtz_ContentAttachmentEN.Extension == "[null]" ? null :  objvtz_ContentAttachmentEN.Extension; //扩展名
}
if (arrFldSet.Contains(convtz_ContentAttachment.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.FilePath = objvtz_ContentAttachmentEN.FilePath; //文件路径
}
if (arrFldSet.Contains(convtz_ContentAttachment.PdfFilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.PdfFilePath = objvtz_ContentAttachmentEN.PdfFilePath == "[null]" ? null :  objvtz_ContentAttachmentEN.PdfFilePath; //Pdf文件路径
}
if (arrFldSet.Contains(convtz_ContentAttachment.SwfFilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.SwfFilePath = objvtz_ContentAttachmentEN.SwfFilePath == "[null]" ? null :  objvtz_ContentAttachmentEN.SwfFilePath; //Swf文件路径
}
if (arrFldSet.Contains(convtz_ContentAttachment.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.FileSize = objvtz_ContentAttachmentEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convtz_ContentAttachment.FileSizeUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.FileSizeUnit = objvtz_ContentAttachmentEN.FileSizeUnit == "[null]" ? null :  objvtz_ContentAttachmentEN.FileSizeUnit; //文件大小单位
}
if (arrFldSet.Contains(convtz_ContentAttachment.ImageHeight, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.ImageHeight = objvtz_ContentAttachmentEN.ImageHeight; //图像高
}
if (arrFldSet.Contains(convtz_ContentAttachment.ImageWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.ImageWidth = objvtz_ContentAttachmentEN.ImageWidth; //图像宽
}
if (arrFldSet.Contains(convtz_ContentAttachment.UploadDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.UploadDate = objvtz_ContentAttachmentEN.UploadDate; //上传时间
}
if (arrFldSet.Contains(convtz_ContentAttachment.UploadPerson, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.UploadPerson = objvtz_ContentAttachmentEN.UploadPerson; //上传人
}
if (arrFldSet.Contains(convtz_ContentAttachment.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.UpdDate = objvtz_ContentAttachmentEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convtz_ContentAttachment.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.UpdUserId = objvtz_ContentAttachmentEN.UpdUserId == "[null]" ? null :  objvtz_ContentAttachmentEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convtz_ContentAttachment.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.Memo = objvtz_ContentAttachmentEN.Memo == "[null]" ? null :  objvtz_ContentAttachmentEN.Memo; //备注
}
if (arrFldSet.Contains(convtz_ContentAttachment.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvtz_ContentAttachmentEN.CourseId = objvtz_ContentAttachmentEN.CourseId == "[null]" ? null :  objvtz_ContentAttachmentEN.CourseId; //课程Id
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
 /// <param name = "objvtz_ContentAttachmentEN">源简化对象</param>
 public static void AccessFldValueNull(clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN)
{
try
{
if (objvtz_ContentAttachmentEN.ContentTypeName == "[null]") objvtz_ContentAttachmentEN.ContentTypeName = null; //内容类型名
if (objvtz_ContentAttachmentEN.TableName == "[null]") objvtz_ContentAttachmentEN.TableName = null; //主表表名
if (objvtz_ContentAttachmentEN.AttachmentTitle == "[null]") objvtz_ContentAttachmentEN.AttachmentTitle = null; //附件标题
if (objvtz_ContentAttachmentEN.FileName == "[null]") objvtz_ContentAttachmentEN.FileName = null; //文件名称
if (objvtz_ContentAttachmentEN.Extension == "[null]") objvtz_ContentAttachmentEN.Extension = null; //扩展名
if (objvtz_ContentAttachmentEN.PdfFilePath == "[null]") objvtz_ContentAttachmentEN.PdfFilePath = null; //Pdf文件路径
if (objvtz_ContentAttachmentEN.SwfFilePath == "[null]") objvtz_ContentAttachmentEN.SwfFilePath = null; //Swf文件路径
if (objvtz_ContentAttachmentEN.FileSizeUnit == "[null]") objvtz_ContentAttachmentEN.FileSizeUnit = null; //文件大小单位
if (objvtz_ContentAttachmentEN.UpdUserId == "[null]") objvtz_ContentAttachmentEN.UpdUserId = null; //修改用户Id
if (objvtz_ContentAttachmentEN.Memo == "[null]") objvtz_ContentAttachmentEN.Memo = null; //备注
if (objvtz_ContentAttachmentEN.CourseId == "[null]") objvtz_ContentAttachmentEN.CourseId = null; //课程Id
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
public static void CheckProperty4Condition(clsvtz_ContentAttachmentEN objvtz_ContentAttachmentEN)
{
 vtz_ContentAttachmentDA.CheckProperty4Condition(objvtz_ContentAttachmentEN);
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
if (clstz_ContentAttachmentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clstz_ContentAttachmentBL没有刷新缓存机制(clstz_ContentAttachmentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsContentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsContentTypeBL没有刷新缓存机制(clsContentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvtz_ContentAttachmentObjLstCache == null)
//{
//arrvtz_ContentAttachmentObjLstCache = vtz_ContentAttachmentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvtz_ContentAttachmentEN GetObjBymIdCache(long lngmId, string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvtz_ContentAttachmentEN._CurrTabName, strCourseId);
List<clsvtz_ContentAttachmentEN> arrvtz_ContentAttachmentObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvtz_ContentAttachmentEN> arrvtz_ContentAttachmentObjLst_Sel =
arrvtz_ContentAttachmentObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvtz_ContentAttachmentObjLst_Sel.Count() == 0)
{
   clsvtz_ContentAttachmentEN obj = clsvtz_ContentAttachmentBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvtz_ContentAttachmentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvtz_ContentAttachmentEN> GetAllvtz_ContentAttachmentObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvtz_ContentAttachmentEN> arrvtz_ContentAttachmentObjLstCache = GetObjLstCache(strCourseId); 
return arrvtz_ContentAttachmentObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvtz_ContentAttachmentEN> GetObjLstCache(string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvtz_ContentAttachmentEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvtz_ContentAttachmentEN> arrvtz_ContentAttachmentObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvtz_ContentAttachmentObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvtz_ContentAttachmentEN._CurrTabName, strCourseId);
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
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strCourseId)
{
if (strInFldName != convtz_ContentAttachment.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convtz_ContentAttachment.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convtz_ContentAttachment.AttributeName));
throw new Exception(strMsg);
}
var objvtz_ContentAttachment = clsvtz_ContentAttachmentBL.GetObjBymIdCache(lngmId, strCourseId);
if (objvtz_ContentAttachment == null) return "";
return objvtz_ContentAttachment[strOutFldName].ToString();
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
int intRecCount = clsvtz_ContentAttachmentDA.GetRecCount(strTabName);
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
int intRecCount = clsvtz_ContentAttachmentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvtz_ContentAttachmentDA.GetRecCount();
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
int intRecCount = clsvtz_ContentAttachmentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvtz_ContentAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvtz_ContentAttachmentEN objvtz_ContentAttachmentCond)
{
 string strCourseId = objvtz_ContentAttachmentCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvtz_ContentAttachmentBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvtz_ContentAttachmentEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvtz_ContentAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convtz_ContentAttachment.AttributeName)
{
if (objvtz_ContentAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objvtz_ContentAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvtz_ContentAttachmentCond[strFldName].ToString());
}
else
{
if (objvtz_ContentAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvtz_ContentAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvtz_ContentAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvtz_ContentAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvtz_ContentAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvtz_ContentAttachmentCond[strFldName]));
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
 List<string> arrList = clsvtz_ContentAttachmentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vtz_ContentAttachmentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vtz_ContentAttachmentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}