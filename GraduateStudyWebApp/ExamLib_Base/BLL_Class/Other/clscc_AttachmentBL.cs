
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_AttachmentBL
 表名:cc_Attachment(01120149)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:01
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
public static class  clscc_AttachmentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngAttachmentID">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_AttachmentEN GetObj(this K_AttachmentID_cc_Attachment myKey)
{
clscc_AttachmentEN objcc_AttachmentEN = clscc_AttachmentBL.cc_AttachmentDA.GetObjByAttachmentID(myKey.Value);
return objcc_AttachmentEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_AttachmentEN objcc_AttachmentEN)
{
if (CheckUniqueness(objcc_AttachmentEN) == false)
{
var strMsg = string.Format("记录已经存在!主表表名 = [{0}],主表主键值 = [{1}],文件名称 = [{2}]的数据已经存在!(in clscc_AttachmentBL.AddNewRecord)", objcc_AttachmentEN.TableName,objcc_AttachmentEN.TableNameKey,objcc_AttachmentEN.FileName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clscc_AttachmentBL.cc_AttachmentDA.AddNewRecordBySQL2(objcc_AttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_AttachmentBL.ReFreshCache(objcc_AttachmentEN.TableName);

if (clscc_AttachmentBL.relatedActions != null)
{
clscc_AttachmentBL.relatedActions.UpdRelaTabDate(objcc_AttachmentEN.AttachmentID, objcc_AttachmentEN.UpdUserId);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000082)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddRecordEx)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
public static bool AddRecordEx(this clscc_AttachmentEN objcc_AttachmentEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
try
{
 //2、检查传进去的对象属性是否合法
objcc_AttachmentEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objcc_AttachmentEN.CheckUniqueness() == false)
{
strMsg = string.Format("(主表表名(TableName)=[{0}],主表主键值(TableNameKey)=[{1}],文件名称(FileName)=[{2}])已经存在,不能重复!", objcc_AttachmentEN.TableName, objcc_AttachmentEN.TableNameKey, objcc_AttachmentEN.FileName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objcc_AttachmentEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_AttachmentEN objcc_AttachmentEN)
{
if (CheckUniqueness(objcc_AttachmentEN) == false)
{
var strMsg = string.Format("记录已经存在!主表表名 = [{0}],主表主键值 = [{1}],文件名称 = [{2}]的数据已经存在!(in clscc_AttachmentBL.AddNewRecordWithReturnKey)", objcc_AttachmentEN.TableName,objcc_AttachmentEN.TableNameKey,objcc_AttachmentEN.FileName);
throw new Exception(strMsg);
}
try
{
string strKey = clscc_AttachmentBL.cc_AttachmentDA.AddNewRecordBySQL2WithReturnKey(objcc_AttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_AttachmentBL.ReFreshCache(objcc_AttachmentEN.TableName);

if (clscc_AttachmentBL.relatedActions != null)
{
clscc_AttachmentBL.relatedActions.UpdRelaTabDate(objcc_AttachmentEN.AttachmentID, objcc_AttachmentEN.UpdUserId);
}
return strKey;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000091)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_AttachmentEN SetAttachmentID(this clscc_AttachmentEN objcc_AttachmentEN, long lngAttachmentID, string strComparisonOp="")
	{
objcc_AttachmentEN.AttachmentID = lngAttachmentID; //附件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_AttachmentEN.dicFldComparisonOp.ContainsKey(concc_Attachment.AttachmentID) == false)
{
objcc_AttachmentEN.dicFldComparisonOp.Add(concc_Attachment.AttachmentID, strComparisonOp);
}
else
{
objcc_AttachmentEN.dicFldComparisonOp[concc_Attachment.AttachmentID] = strComparisonOp;
}
}
return objcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_AttachmentEN SetTableName(this clscc_AttachmentEN objcc_AttachmentEN, string strTableName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableName, 100, concc_Attachment.TableName);
}
objcc_AttachmentEN.TableName = strTableName; //主表表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_AttachmentEN.dicFldComparisonOp.ContainsKey(concc_Attachment.TableName) == false)
{
objcc_AttachmentEN.dicFldComparisonOp.Add(concc_Attachment.TableName, strComparisonOp);
}
else
{
objcc_AttachmentEN.dicFldComparisonOp[concc_Attachment.TableName] = strComparisonOp;
}
}
return objcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_AttachmentEN SetFileName(this clscc_AttachmentEN objcc_AttachmentEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, concc_Attachment.FileName);
}
objcc_AttachmentEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_AttachmentEN.dicFldComparisonOp.ContainsKey(concc_Attachment.FileName) == false)
{
objcc_AttachmentEN.dicFldComparisonOp.Add(concc_Attachment.FileName, strComparisonOp);
}
else
{
objcc_AttachmentEN.dicFldComparisonOp[concc_Attachment.FileName] = strComparisonOp;
}
}
return objcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_AttachmentEN SetExtension(this clscc_AttachmentEN objcc_AttachmentEN, string strExtension, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExtension, 10, concc_Attachment.Extension);
}
objcc_AttachmentEN.Extension = strExtension; //扩展名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_AttachmentEN.dicFldComparisonOp.ContainsKey(concc_Attachment.Extension) == false)
{
objcc_AttachmentEN.dicFldComparisonOp.Add(concc_Attachment.Extension, strComparisonOp);
}
else
{
objcc_AttachmentEN.dicFldComparisonOp[concc_Attachment.Extension] = strComparisonOp;
}
}
return objcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_AttachmentEN SetFilePath(this clscc_AttachmentEN objcc_AttachmentEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, concc_Attachment.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, concc_Attachment.FilePath);
}
objcc_AttachmentEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_AttachmentEN.dicFldComparisonOp.ContainsKey(concc_Attachment.FilePath) == false)
{
objcc_AttachmentEN.dicFldComparisonOp.Add(concc_Attachment.FilePath, strComparisonOp);
}
else
{
objcc_AttachmentEN.dicFldComparisonOp[concc_Attachment.FilePath] = strComparisonOp;
}
}
return objcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_AttachmentEN SetFileSize(this clscc_AttachmentEN objcc_AttachmentEN, double? dblFileSize, string strComparisonOp="")
	{
objcc_AttachmentEN.FileSize = dblFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_AttachmentEN.dicFldComparisonOp.ContainsKey(concc_Attachment.FileSize) == false)
{
objcc_AttachmentEN.dicFldComparisonOp.Add(concc_Attachment.FileSize, strComparisonOp);
}
else
{
objcc_AttachmentEN.dicFldComparisonOp[concc_Attachment.FileSize] = strComparisonOp;
}
}
return objcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_AttachmentEN SetFileSizeUnit(this clscc_AttachmentEN objcc_AttachmentEN, string strFileSizeUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSizeUnit, 10, concc_Attachment.FileSizeUnit);
}
objcc_AttachmentEN.FileSizeUnit = strFileSizeUnit; //文件大小单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_AttachmentEN.dicFldComparisonOp.ContainsKey(concc_Attachment.FileSizeUnit) == false)
{
objcc_AttachmentEN.dicFldComparisonOp.Add(concc_Attachment.FileSizeUnit, strComparisonOp);
}
else
{
objcc_AttachmentEN.dicFldComparisonOp[concc_Attachment.FileSizeUnit] = strComparisonOp;
}
}
return objcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_AttachmentEN SetImageHeight(this clscc_AttachmentEN objcc_AttachmentEN, int? intImageHeight, string strComparisonOp="")
	{
objcc_AttachmentEN.ImageHeight = intImageHeight; //图像高
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_AttachmentEN.dicFldComparisonOp.ContainsKey(concc_Attachment.ImageHeight) == false)
{
objcc_AttachmentEN.dicFldComparisonOp.Add(concc_Attachment.ImageHeight, strComparisonOp);
}
else
{
objcc_AttachmentEN.dicFldComparisonOp[concc_Attachment.ImageHeight] = strComparisonOp;
}
}
return objcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_AttachmentEN SetImageWidth(this clscc_AttachmentEN objcc_AttachmentEN, int? intImageWidth, string strComparisonOp="")
	{
objcc_AttachmentEN.ImageWidth = intImageWidth; //图像宽
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_AttachmentEN.dicFldComparisonOp.ContainsKey(concc_Attachment.ImageWidth) == false)
{
objcc_AttachmentEN.dicFldComparisonOp.Add(concc_Attachment.ImageWidth, strComparisonOp);
}
else
{
objcc_AttachmentEN.dicFldComparisonOp[concc_Attachment.ImageWidth] = strComparisonOp;
}
}
return objcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_AttachmentEN SetUploadDate(this clscc_AttachmentEN objcc_AttachmentEN, string strUploadDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUploadDate, concc_Attachment.UploadDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadDate, 20, concc_Attachment.UploadDate);
}
objcc_AttachmentEN.UploadDate = strUploadDate; //上传时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_AttachmentEN.dicFldComparisonOp.ContainsKey(concc_Attachment.UploadDate) == false)
{
objcc_AttachmentEN.dicFldComparisonOp.Add(concc_Attachment.UploadDate, strComparisonOp);
}
else
{
objcc_AttachmentEN.dicFldComparisonOp[concc_Attachment.UploadDate] = strComparisonOp;
}
}
return objcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_AttachmentEN SetUploadPerson(this clscc_AttachmentEN objcc_AttachmentEN, string strUploadPerson, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadPerson, 20, concc_Attachment.UploadPerson);
}
objcc_AttachmentEN.UploadPerson = strUploadPerson; //上传人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_AttachmentEN.dicFldComparisonOp.ContainsKey(concc_Attachment.UploadPerson) == false)
{
objcc_AttachmentEN.dicFldComparisonOp.Add(concc_Attachment.UploadPerson, strComparisonOp);
}
else
{
objcc_AttachmentEN.dicFldComparisonOp[concc_Attachment.UploadPerson] = strComparisonOp;
}
}
return objcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_AttachmentEN SetTableNameKey(this clscc_AttachmentEN objcc_AttachmentEN, string strTableNameKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTableNameKey, concc_Attachment.TableNameKey);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableNameKey, 20, concc_Attachment.TableNameKey);
}
objcc_AttachmentEN.TableNameKey = strTableNameKey; //主表主键值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_AttachmentEN.dicFldComparisonOp.ContainsKey(concc_Attachment.TableNameKey) == false)
{
objcc_AttachmentEN.dicFldComparisonOp.Add(concc_Attachment.TableNameKey, strComparisonOp);
}
else
{
objcc_AttachmentEN.dicFldComparisonOp[concc_Attachment.TableNameKey] = strComparisonOp;
}
}
return objcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_AttachmentEN SetIdResourceType(this clscc_AttachmentEN objcc_AttachmentEN, string strIdResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResourceType, concc_Attachment.IdResourceType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, concc_Attachment.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, concc_Attachment.IdResourceType);
}
objcc_AttachmentEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_AttachmentEN.dicFldComparisonOp.ContainsKey(concc_Attachment.IdResourceType) == false)
{
objcc_AttachmentEN.dicFldComparisonOp.Add(concc_Attachment.IdResourceType, strComparisonOp);
}
else
{
objcc_AttachmentEN.dicFldComparisonOp[concc_Attachment.IdResourceType] = strComparisonOp;
}
}
return objcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_AttachmentEN SetUpdDate(this clscc_AttachmentEN objcc_AttachmentEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_Attachment.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_Attachment.UpdDate);
}
objcc_AttachmentEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_AttachmentEN.dicFldComparisonOp.ContainsKey(concc_Attachment.UpdDate) == false)
{
objcc_AttachmentEN.dicFldComparisonOp.Add(concc_Attachment.UpdDate, strComparisonOp);
}
else
{
objcc_AttachmentEN.dicFldComparisonOp[concc_Attachment.UpdDate] = strComparisonOp;
}
}
return objcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_AttachmentEN SetUpdUserId(this clscc_AttachmentEN objcc_AttachmentEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_Attachment.UpdUserId);
}
objcc_AttachmentEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_AttachmentEN.dicFldComparisonOp.ContainsKey(concc_Attachment.UpdUserId) == false)
{
objcc_AttachmentEN.dicFldComparisonOp.Add(concc_Attachment.UpdUserId, strComparisonOp);
}
else
{
objcc_AttachmentEN.dicFldComparisonOp[concc_Attachment.UpdUserId] = strComparisonOp;
}
}
return objcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_AttachmentEN SetMemo(this clscc_AttachmentEN objcc_AttachmentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_Attachment.Memo);
}
objcc_AttachmentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_AttachmentEN.dicFldComparisonOp.ContainsKey(concc_Attachment.Memo) == false)
{
objcc_AttachmentEN.dicFldComparisonOp.Add(concc_Attachment.Memo, strComparisonOp);
}
else
{
objcc_AttachmentEN.dicFldComparisonOp[concc_Attachment.Memo] = strComparisonOp;
}
}
return objcc_AttachmentEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_AttachmentEN objcc_AttachmentEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_AttachmentEN.CheckPropertyNew();
clscc_AttachmentEN objcc_AttachmentCond = new clscc_AttachmentEN();
string strCondition = objcc_AttachmentCond
.SetAttachmentID(objcc_AttachmentEN.AttachmentID, "<>")
.SetTableName(objcc_AttachmentEN.TableName, "=")
.SetTableNameKey(objcc_AttachmentEN.TableNameKey, "=")
.SetFileName(objcc_AttachmentEN.FileName, "=")
.GetCombineCondition();
objcc_AttachmentEN._IsCheckProperty = true;
bool bolIsExist = clscc_AttachmentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TableName_TableNameKey_FileName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_AttachmentEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改,不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objcc_Attachment">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_AttachmentEN objcc_Attachment)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_AttachmentEN objcc_AttachmentCond = new clscc_AttachmentEN();
string strCondition = objcc_AttachmentCond
.SetTableName(objcc_Attachment.TableName, "=")
.SetTableNameKey(objcc_Attachment.TableNameKey, "=")
.SetFileName(objcc_Attachment.FileName, "=")
.GetCombineCondition();
objcc_Attachment._IsCheckProperty = true;
bool bolIsExist = clscc_AttachmentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_Attachment.AttachmentID = clscc_AttachmentBL.GetFirstID_S(strCondition);
objcc_Attachment.UpdateWithCondition(strCondition);
}
else
{
objcc_Attachment.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_AttachmentEN objcc_AttachmentEN)
{
 if (objcc_AttachmentEN.AttachmentID == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_AttachmentBL.cc_AttachmentDA.UpdateBySql2(objcc_AttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_AttachmentBL.ReFreshCache(objcc_AttachmentEN.TableName);

if (clscc_AttachmentBL.relatedActions != null)
{
clscc_AttachmentBL.relatedActions.UpdRelaTabDate(objcc_AttachmentEN.AttachmentID, objcc_AttachmentEN.UpdUserId);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000083)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithTransaction)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_AttachmentEN objcc_AttachmentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_AttachmentEN.AttachmentID == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_AttachmentBL.cc_AttachmentDA.UpdateBySql2(objcc_AttachmentEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_AttachmentBL.ReFreshCache(objcc_AttachmentEN.TableName);

if (clscc_AttachmentBL.relatedActions != null)
{
clscc_AttachmentBL.relatedActions.UpdRelaTabDate(objcc_AttachmentEN.AttachmentID, objcc_AttachmentEN.UpdUserId);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000088)修改记录出错,{1}.(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_AttachmentEN objcc_AttachmentEN, string strWhereCond)
{
try
{
bool bolResult = clscc_AttachmentBL.cc_AttachmentDA.UpdateBySqlWithCondition(objcc_AttachmentEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_AttachmentBL.ReFreshCache(objcc_AttachmentEN.TableName);

if (clscc_AttachmentBL.relatedActions != null)
{
clscc_AttachmentBL.relatedActions.UpdRelaTabDate(objcc_AttachmentEN.AttachmentID, objcc_AttachmentEN.UpdUserId);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000089)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithConditionTransaction)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_AttachmentEN objcc_AttachmentEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_AttachmentBL.cc_AttachmentDA.UpdateBySqlWithConditionTransaction(objcc_AttachmentEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_AttachmentBL.ReFreshCache(objcc_AttachmentEN.TableName);

if (clscc_AttachmentBL.relatedActions != null)
{
clscc_AttachmentBL.relatedActions.UpdRelaTabDate(objcc_AttachmentEN.AttachmentID, objcc_AttachmentEN.UpdUserId);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000090)根据条件修改记录出错!(带事务处理),{1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Delete)
 /// </summary>
 /// <param name = "lngAttachmentID">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_AttachmentEN objcc_AttachmentEN)
{
try
{
int intRecNum = clscc_AttachmentBL.cc_AttachmentDA.DelRecord(objcc_AttachmentEN.AttachmentID);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_AttachmentBL.ReFreshCache(objcc_AttachmentEN.TableName);

if (clscc_AttachmentBL.relatedActions != null)
{
clscc_AttachmentBL.relatedActions.UpdRelaTabDate(objcc_AttachmentEN.AttachmentID, objcc_AttachmentEN.UpdUserId);
}
return intRecNum;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000084)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objcc_AttachmentENS">源对象</param>
 /// <param name = "objcc_AttachmentENT">目标对象</param>
 public static void CopyTo(this clscc_AttachmentEN objcc_AttachmentENS, clscc_AttachmentEN objcc_AttachmentENT)
{
try
{
objcc_AttachmentENT.AttachmentID = objcc_AttachmentENS.AttachmentID; //附件流水号
objcc_AttachmentENT.TableName = objcc_AttachmentENS.TableName; //主表表名
objcc_AttachmentENT.FileName = objcc_AttachmentENS.FileName; //文件名称
objcc_AttachmentENT.Extension = objcc_AttachmentENS.Extension; //扩展名
objcc_AttachmentENT.FilePath = objcc_AttachmentENS.FilePath; //文件路径
objcc_AttachmentENT.FileSize = objcc_AttachmentENS.FileSize; //文件大小
objcc_AttachmentENT.FileSizeUnit = objcc_AttachmentENS.FileSizeUnit; //文件大小单位
objcc_AttachmentENT.ImageHeight = objcc_AttachmentENS.ImageHeight; //图像高
objcc_AttachmentENT.ImageWidth = objcc_AttachmentENS.ImageWidth; //图像宽
objcc_AttachmentENT.UploadDate = objcc_AttachmentENS.UploadDate; //上传时间
objcc_AttachmentENT.UploadPerson = objcc_AttachmentENS.UploadPerson; //上传人
objcc_AttachmentENT.TableNameKey = objcc_AttachmentENS.TableNameKey; //主表主键值
objcc_AttachmentENT.IdResourceType = objcc_AttachmentENS.IdResourceType; //资源类型流水号
objcc_AttachmentENT.UpdDate = objcc_AttachmentENS.UpdDate; //修改日期
objcc_AttachmentENT.UpdUserId = objcc_AttachmentENS.UpdUserId; //修改用户Id
objcc_AttachmentENT.Memo = objcc_AttachmentENS.Memo; //备注
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
 /// <param name = "objcc_AttachmentENS">源对象</param>
 /// <returns>目标对象=>clscc_AttachmentEN:objcc_AttachmentENT</returns>
 public static clscc_AttachmentEN CopyTo(this clscc_AttachmentEN objcc_AttachmentENS)
{
try
{
 clscc_AttachmentEN objcc_AttachmentENT = new clscc_AttachmentEN()
{
AttachmentID = objcc_AttachmentENS.AttachmentID, //附件流水号
TableName = objcc_AttachmentENS.TableName, //主表表名
FileName = objcc_AttachmentENS.FileName, //文件名称
Extension = objcc_AttachmentENS.Extension, //扩展名
FilePath = objcc_AttachmentENS.FilePath, //文件路径
FileSize = objcc_AttachmentENS.FileSize, //文件大小
FileSizeUnit = objcc_AttachmentENS.FileSizeUnit, //文件大小单位
ImageHeight = objcc_AttachmentENS.ImageHeight, //图像高
ImageWidth = objcc_AttachmentENS.ImageWidth, //图像宽
UploadDate = objcc_AttachmentENS.UploadDate, //上传时间
UploadPerson = objcc_AttachmentENS.UploadPerson, //上传人
TableNameKey = objcc_AttachmentENS.TableNameKey, //主表主键值
IdResourceType = objcc_AttachmentENS.IdResourceType, //资源类型流水号
UpdDate = objcc_AttachmentENS.UpdDate, //修改日期
UpdUserId = objcc_AttachmentENS.UpdUserId, //修改用户Id
Memo = objcc_AttachmentENS.Memo, //备注
};
 return objcc_AttachmentENT;
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(this clscc_AttachmentEN objcc_AttachmentEN)
{
 clscc_AttachmentBL.cc_AttachmentDA.CheckPropertyNew(objcc_AttachmentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_AttachmentEN objcc_AttachmentEN)
{
 clscc_AttachmentBL.cc_AttachmentDA.CheckProperty4Condition(objcc_AttachmentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_AttachmentEN objcc_AttachmentCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_AttachmentCond.IsUpdated(concc_Attachment.AttachmentID) == true)
{
string strComparisonOpAttachmentID = objcc_AttachmentCond.dicFldComparisonOp[concc_Attachment.AttachmentID];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Attachment.AttachmentID, objcc_AttachmentCond.AttachmentID, strComparisonOpAttachmentID);
}
if (objcc_AttachmentCond.IsUpdated(concc_Attachment.TableName) == true)
{
string strComparisonOpTableName = objcc_AttachmentCond.dicFldComparisonOp[concc_Attachment.TableName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.TableName, objcc_AttachmentCond.TableName, strComparisonOpTableName);
}
if (objcc_AttachmentCond.IsUpdated(concc_Attachment.FileName) == true)
{
string strComparisonOpFileName = objcc_AttachmentCond.dicFldComparisonOp[concc_Attachment.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.FileName, objcc_AttachmentCond.FileName, strComparisonOpFileName);
}
if (objcc_AttachmentCond.IsUpdated(concc_Attachment.Extension) == true)
{
string strComparisonOpExtension = objcc_AttachmentCond.dicFldComparisonOp[concc_Attachment.Extension];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.Extension, objcc_AttachmentCond.Extension, strComparisonOpExtension);
}
if (objcc_AttachmentCond.IsUpdated(concc_Attachment.FilePath) == true)
{
string strComparisonOpFilePath = objcc_AttachmentCond.dicFldComparisonOp[concc_Attachment.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.FilePath, objcc_AttachmentCond.FilePath, strComparisonOpFilePath);
}
if (objcc_AttachmentCond.IsUpdated(concc_Attachment.FileSize) == true)
{
string strComparisonOpFileSize = objcc_AttachmentCond.dicFldComparisonOp[concc_Attachment.FileSize];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Attachment.FileSize, objcc_AttachmentCond.FileSize, strComparisonOpFileSize);
}
if (objcc_AttachmentCond.IsUpdated(concc_Attachment.FileSizeUnit) == true)
{
string strComparisonOpFileSizeUnit = objcc_AttachmentCond.dicFldComparisonOp[concc_Attachment.FileSizeUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.FileSizeUnit, objcc_AttachmentCond.FileSizeUnit, strComparisonOpFileSizeUnit);
}
if (objcc_AttachmentCond.IsUpdated(concc_Attachment.ImageHeight) == true)
{
string strComparisonOpImageHeight = objcc_AttachmentCond.dicFldComparisonOp[concc_Attachment.ImageHeight];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Attachment.ImageHeight, objcc_AttachmentCond.ImageHeight, strComparisonOpImageHeight);
}
if (objcc_AttachmentCond.IsUpdated(concc_Attachment.ImageWidth) == true)
{
string strComparisonOpImageWidth = objcc_AttachmentCond.dicFldComparisonOp[concc_Attachment.ImageWidth];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Attachment.ImageWidth, objcc_AttachmentCond.ImageWidth, strComparisonOpImageWidth);
}
if (objcc_AttachmentCond.IsUpdated(concc_Attachment.UploadDate) == true)
{
string strComparisonOpUploadDate = objcc_AttachmentCond.dicFldComparisonOp[concc_Attachment.UploadDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.UploadDate, objcc_AttachmentCond.UploadDate, strComparisonOpUploadDate);
}
if (objcc_AttachmentCond.IsUpdated(concc_Attachment.UploadPerson) == true)
{
string strComparisonOpUploadPerson = objcc_AttachmentCond.dicFldComparisonOp[concc_Attachment.UploadPerson];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.UploadPerson, objcc_AttachmentCond.UploadPerson, strComparisonOpUploadPerson);
}
if (objcc_AttachmentCond.IsUpdated(concc_Attachment.TableNameKey) == true)
{
string strComparisonOpTableNameKey = objcc_AttachmentCond.dicFldComparisonOp[concc_Attachment.TableNameKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.TableNameKey, objcc_AttachmentCond.TableNameKey, strComparisonOpTableNameKey);
}
if (objcc_AttachmentCond.IsUpdated(concc_Attachment.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objcc_AttachmentCond.dicFldComparisonOp[concc_Attachment.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.IdResourceType, objcc_AttachmentCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objcc_AttachmentCond.IsUpdated(concc_Attachment.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_AttachmentCond.dicFldComparisonOp[concc_Attachment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.UpdDate, objcc_AttachmentCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_AttachmentCond.IsUpdated(concc_Attachment.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objcc_AttachmentCond.dicFldComparisonOp[concc_Attachment.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.UpdUserId, objcc_AttachmentCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objcc_AttachmentCond.IsUpdated(concc_Attachment.Memo) == true)
{
string strComparisonOpMemo = objcc_AttachmentCond.dicFldComparisonOp[concc_Attachment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.Memo, objcc_AttachmentCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_Attachment(附件), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TableName_TableNameKey_FileName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_AttachmentEN objcc_AttachmentEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_AttachmentEN == null) return true;
if (objcc_AttachmentEN.AttachmentID == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objcc_AttachmentEN.TableName == null)
{
 sbCondition.AppendFormat(" and TableName is null", objcc_AttachmentEN.TableName);
}
else
{
 sbCondition.AppendFormat(" and TableName = '{0}'", objcc_AttachmentEN.TableName);
}
 sbCondition.AppendFormat(" and TableNameKey = '{0}'", objcc_AttachmentEN.TableNameKey);
 if (objcc_AttachmentEN.FileName == null)
{
 sbCondition.AppendFormat(" and FileName is null", objcc_AttachmentEN.FileName);
}
else
{
 sbCondition.AppendFormat(" and FileName = '{0}'", objcc_AttachmentEN.FileName);
}
if (clscc_AttachmentBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("AttachmentID !=  {0}", objcc_AttachmentEN.AttachmentID);
 sbCondition.AppendFormat(" and TableName = '{0}'", objcc_AttachmentEN.TableName);
 sbCondition.AppendFormat(" and TableNameKey = '{0}'", objcc_AttachmentEN.TableNameKey);
 sbCondition.AppendFormat(" and FileName = '{0}'", objcc_AttachmentEN.FileName);
if (clscc_AttachmentBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--cc_Attachment(附件), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TableName_TableNameKey_FileName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_AttachmentEN objcc_AttachmentEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_AttachmentEN == null) return "";
if (objcc_AttachmentEN.AttachmentID == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objcc_AttachmentEN.TableName == null)
{
 sbCondition.AppendFormat(" and TableName is null", objcc_AttachmentEN.TableName);
}
else
{
 sbCondition.AppendFormat(" and TableName = '{0}'", objcc_AttachmentEN.TableName);
}
 sbCondition.AppendFormat(" and TableNameKey = '{0}'", objcc_AttachmentEN.TableNameKey);
 if (objcc_AttachmentEN.FileName == null)
{
 sbCondition.AppendFormat(" and FileName is null", objcc_AttachmentEN.FileName);
}
else
{
 sbCondition.AppendFormat(" and FileName = '{0}'", objcc_AttachmentEN.FileName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("AttachmentID !=  {0}", objcc_AttachmentEN.AttachmentID);
 sbCondition.AppendFormat(" and TableName = '{0}'", objcc_AttachmentEN.TableName);
 sbCondition.AppendFormat(" and TableNameKey = '{0}'", objcc_AttachmentEN.TableNameKey);
 sbCondition.AppendFormat(" and FileName = '{0}'", objcc_AttachmentEN.FileName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_Attachment
{
public virtual bool UpdRelaTabDate(long lngAttachmentID, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 附件(cc_Attachment)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_AttachmentBL
{
public static RelatedActions_cc_Attachment relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_AttachmentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_AttachmentDA cc_AttachmentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_AttachmentDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clscc_AttachmentBL()
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
if (string.IsNullOrEmpty(clscc_AttachmentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_AttachmentEN._ConnectString);
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
public static DataTable GetDataTable_cc_Attachment(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_AttachmentDA.GetDataTable_cc_Attachment(strWhereCond);
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
objDT = cc_AttachmentDA.GetDataTable(strWhereCond);
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
objDT = cc_AttachmentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_AttachmentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_AttachmentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_AttachmentDA.GetDataTable_Top(objTopPara);
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
objDT = cc_AttachmentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_AttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_AttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clscc_AttachmentEN> GetObjLstByAttachmentIDLst(List<long> arrAttachmentIDLst)
{
List<clscc_AttachmentEN> arrObjLst = new List<clscc_AttachmentEN>(); 
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
	clscc_AttachmentEN objcc_AttachmentEN = new clscc_AttachmentEN();
try
{
objcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[concc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objcc_AttachmentEN.TableName = objRow[concc_Attachment.TableName] == DBNull.Value ? null : objRow[concc_Attachment.TableName].ToString().Trim(); //主表表名
objcc_AttachmentEN.FileName = objRow[concc_Attachment.FileName] == DBNull.Value ? null : objRow[concc_Attachment.FileName].ToString().Trim(); //文件名称
objcc_AttachmentEN.Extension = objRow[concc_Attachment.Extension] == DBNull.Value ? null : objRow[concc_Attachment.Extension].ToString().Trim(); //扩展名
objcc_AttachmentEN.FilePath = objRow[concc_Attachment.FilePath].ToString().Trim(); //文件路径
objcc_AttachmentEN.FileSize = objRow[concc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_Attachment.FileSize].ToString().Trim()); //文件大小
objcc_AttachmentEN.FileSizeUnit = objRow[concc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[concc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_AttachmentEN.ImageHeight = objRow[concc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageHeight].ToString().Trim()); //图像高
objcc_AttachmentEN.ImageWidth = objRow[concc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageWidth].ToString().Trim()); //图像宽
objcc_AttachmentEN.UploadDate = objRow[concc_Attachment.UploadDate].ToString().Trim(); //上传时间
objcc_AttachmentEN.UploadPerson = objRow[concc_Attachment.UploadPerson] == DBNull.Value ? null : objRow[concc_Attachment.UploadPerson].ToString().Trim(); //上传人
objcc_AttachmentEN.TableNameKey = objRow[concc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objcc_AttachmentEN.IdResourceType = objRow[concc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objcc_AttachmentEN.UpdDate = objRow[concc_Attachment.UpdDate].ToString().Trim(); //修改日期
objcc_AttachmentEN.UpdUserId = objRow[concc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[concc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objcc_AttachmentEN.Memo = objRow[concc_Attachment.Memo] == DBNull.Value ? null : objRow[concc_Attachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_AttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrAttachmentIDLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_AttachmentEN> GetObjLstByAttachmentIDLstCache(List<long> arrAttachmentIDLst, string strTableName)
{
string strKey = string.Format("{0}_{1}", clscc_AttachmentEN._CurrTabName, strTableName);
List<clscc_AttachmentEN> arrcc_AttachmentObjLstCache = GetObjLstCache(strTableName);
IEnumerable <clscc_AttachmentEN> arrcc_AttachmentObjLst_Sel =
arrcc_AttachmentObjLstCache
.Where(x => arrAttachmentIDLst.Contains(x.AttachmentID));
return arrcc_AttachmentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_AttachmentEN> GetObjLst(string strWhereCond)
{
List<clscc_AttachmentEN> arrObjLst = new List<clscc_AttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_AttachmentEN objcc_AttachmentEN = new clscc_AttachmentEN();
try
{
objcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[concc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objcc_AttachmentEN.TableName = objRow[concc_Attachment.TableName] == DBNull.Value ? null : objRow[concc_Attachment.TableName].ToString().Trim(); //主表表名
objcc_AttachmentEN.FileName = objRow[concc_Attachment.FileName] == DBNull.Value ? null : objRow[concc_Attachment.FileName].ToString().Trim(); //文件名称
objcc_AttachmentEN.Extension = objRow[concc_Attachment.Extension] == DBNull.Value ? null : objRow[concc_Attachment.Extension].ToString().Trim(); //扩展名
objcc_AttachmentEN.FilePath = objRow[concc_Attachment.FilePath].ToString().Trim(); //文件路径
objcc_AttachmentEN.FileSize = objRow[concc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_Attachment.FileSize].ToString().Trim()); //文件大小
objcc_AttachmentEN.FileSizeUnit = objRow[concc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[concc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_AttachmentEN.ImageHeight = objRow[concc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageHeight].ToString().Trim()); //图像高
objcc_AttachmentEN.ImageWidth = objRow[concc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageWidth].ToString().Trim()); //图像宽
objcc_AttachmentEN.UploadDate = objRow[concc_Attachment.UploadDate].ToString().Trim(); //上传时间
objcc_AttachmentEN.UploadPerson = objRow[concc_Attachment.UploadPerson] == DBNull.Value ? null : objRow[concc_Attachment.UploadPerson].ToString().Trim(); //上传人
objcc_AttachmentEN.TableNameKey = objRow[concc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objcc_AttachmentEN.IdResourceType = objRow[concc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objcc_AttachmentEN.UpdDate = objRow[concc_Attachment.UpdDate].ToString().Trim(); //修改日期
objcc_AttachmentEN.UpdUserId = objRow[concc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[concc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objcc_AttachmentEN.Memo = objRow[concc_Attachment.Memo] == DBNull.Value ? null : objRow[concc_Attachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_AttachmentEN);
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
public static List<clscc_AttachmentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_AttachmentEN> arrObjLst = new List<clscc_AttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_AttachmentEN objcc_AttachmentEN = new clscc_AttachmentEN();
try
{
objcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[concc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objcc_AttachmentEN.TableName = objRow[concc_Attachment.TableName] == DBNull.Value ? null : objRow[concc_Attachment.TableName].ToString().Trim(); //主表表名
objcc_AttachmentEN.FileName = objRow[concc_Attachment.FileName] == DBNull.Value ? null : objRow[concc_Attachment.FileName].ToString().Trim(); //文件名称
objcc_AttachmentEN.Extension = objRow[concc_Attachment.Extension] == DBNull.Value ? null : objRow[concc_Attachment.Extension].ToString().Trim(); //扩展名
objcc_AttachmentEN.FilePath = objRow[concc_Attachment.FilePath].ToString().Trim(); //文件路径
objcc_AttachmentEN.FileSize = objRow[concc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_Attachment.FileSize].ToString().Trim()); //文件大小
objcc_AttachmentEN.FileSizeUnit = objRow[concc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[concc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_AttachmentEN.ImageHeight = objRow[concc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageHeight].ToString().Trim()); //图像高
objcc_AttachmentEN.ImageWidth = objRow[concc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageWidth].ToString().Trim()); //图像宽
objcc_AttachmentEN.UploadDate = objRow[concc_Attachment.UploadDate].ToString().Trim(); //上传时间
objcc_AttachmentEN.UploadPerson = objRow[concc_Attachment.UploadPerson] == DBNull.Value ? null : objRow[concc_Attachment.UploadPerson].ToString().Trim(); //上传人
objcc_AttachmentEN.TableNameKey = objRow[concc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objcc_AttachmentEN.IdResourceType = objRow[concc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objcc_AttachmentEN.UpdDate = objRow[concc_Attachment.UpdDate].ToString().Trim(); //修改日期
objcc_AttachmentEN.UpdUserId = objRow[concc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[concc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objcc_AttachmentEN.Memo = objRow[concc_Attachment.Memo] == DBNull.Value ? null : objRow[concc_Attachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_AttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_AttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_AttachmentEN> GetSubObjLstCache(clscc_AttachmentEN objcc_AttachmentCond)
{
 string strTableName = objcc_AttachmentCond.TableName;
 if (string.IsNullOrEmpty(strTableName) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clscc_AttachmentBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clscc_AttachmentEN> arrObjLstCache = GetObjLstCache(strTableName);
IEnumerable <clscc_AttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_Attachment.AttributeName)
{
if (objcc_AttachmentCond.IsUpdated(strFldName) == false) continue;
if (objcc_AttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_AttachmentCond[strFldName].ToString());
}
else
{
if (objcc_AttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_AttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_AttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_AttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_AttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_AttachmentCond[strFldName]));
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
public static List<clscc_AttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_AttachmentEN> arrObjLst = new List<clscc_AttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_AttachmentEN objcc_AttachmentEN = new clscc_AttachmentEN();
try
{
objcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[concc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objcc_AttachmentEN.TableName = objRow[concc_Attachment.TableName] == DBNull.Value ? null : objRow[concc_Attachment.TableName].ToString().Trim(); //主表表名
objcc_AttachmentEN.FileName = objRow[concc_Attachment.FileName] == DBNull.Value ? null : objRow[concc_Attachment.FileName].ToString().Trim(); //文件名称
objcc_AttachmentEN.Extension = objRow[concc_Attachment.Extension] == DBNull.Value ? null : objRow[concc_Attachment.Extension].ToString().Trim(); //扩展名
objcc_AttachmentEN.FilePath = objRow[concc_Attachment.FilePath].ToString().Trim(); //文件路径
objcc_AttachmentEN.FileSize = objRow[concc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_Attachment.FileSize].ToString().Trim()); //文件大小
objcc_AttachmentEN.FileSizeUnit = objRow[concc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[concc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_AttachmentEN.ImageHeight = objRow[concc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageHeight].ToString().Trim()); //图像高
objcc_AttachmentEN.ImageWidth = objRow[concc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageWidth].ToString().Trim()); //图像宽
objcc_AttachmentEN.UploadDate = objRow[concc_Attachment.UploadDate].ToString().Trim(); //上传时间
objcc_AttachmentEN.UploadPerson = objRow[concc_Attachment.UploadPerson] == DBNull.Value ? null : objRow[concc_Attachment.UploadPerson].ToString().Trim(); //上传人
objcc_AttachmentEN.TableNameKey = objRow[concc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objcc_AttachmentEN.IdResourceType = objRow[concc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objcc_AttachmentEN.UpdDate = objRow[concc_Attachment.UpdDate].ToString().Trim(); //修改日期
objcc_AttachmentEN.UpdUserId = objRow[concc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[concc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objcc_AttachmentEN.Memo = objRow[concc_Attachment.Memo] == DBNull.Value ? null : objRow[concc_Attachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_AttachmentEN);
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
public static List<clscc_AttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_AttachmentEN> arrObjLst = new List<clscc_AttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_AttachmentEN objcc_AttachmentEN = new clscc_AttachmentEN();
try
{
objcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[concc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objcc_AttachmentEN.TableName = objRow[concc_Attachment.TableName] == DBNull.Value ? null : objRow[concc_Attachment.TableName].ToString().Trim(); //主表表名
objcc_AttachmentEN.FileName = objRow[concc_Attachment.FileName] == DBNull.Value ? null : objRow[concc_Attachment.FileName].ToString().Trim(); //文件名称
objcc_AttachmentEN.Extension = objRow[concc_Attachment.Extension] == DBNull.Value ? null : objRow[concc_Attachment.Extension].ToString().Trim(); //扩展名
objcc_AttachmentEN.FilePath = objRow[concc_Attachment.FilePath].ToString().Trim(); //文件路径
objcc_AttachmentEN.FileSize = objRow[concc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_Attachment.FileSize].ToString().Trim()); //文件大小
objcc_AttachmentEN.FileSizeUnit = objRow[concc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[concc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_AttachmentEN.ImageHeight = objRow[concc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageHeight].ToString().Trim()); //图像高
objcc_AttachmentEN.ImageWidth = objRow[concc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageWidth].ToString().Trim()); //图像宽
objcc_AttachmentEN.UploadDate = objRow[concc_Attachment.UploadDate].ToString().Trim(); //上传时间
objcc_AttachmentEN.UploadPerson = objRow[concc_Attachment.UploadPerson] == DBNull.Value ? null : objRow[concc_Attachment.UploadPerson].ToString().Trim(); //上传人
objcc_AttachmentEN.TableNameKey = objRow[concc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objcc_AttachmentEN.IdResourceType = objRow[concc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objcc_AttachmentEN.UpdDate = objRow[concc_Attachment.UpdDate].ToString().Trim(); //修改日期
objcc_AttachmentEN.UpdUserId = objRow[concc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[concc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objcc_AttachmentEN.Memo = objRow[concc_Attachment.Memo] == DBNull.Value ? null : objRow[concc_Attachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_AttachmentEN);
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
List<clscc_AttachmentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_AttachmentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_AttachmentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_AttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_AttachmentEN> arrObjLst = new List<clscc_AttachmentEN>(); 
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
	clscc_AttachmentEN objcc_AttachmentEN = new clscc_AttachmentEN();
try
{
objcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[concc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objcc_AttachmentEN.TableName = objRow[concc_Attachment.TableName] == DBNull.Value ? null : objRow[concc_Attachment.TableName].ToString().Trim(); //主表表名
objcc_AttachmentEN.FileName = objRow[concc_Attachment.FileName] == DBNull.Value ? null : objRow[concc_Attachment.FileName].ToString().Trim(); //文件名称
objcc_AttachmentEN.Extension = objRow[concc_Attachment.Extension] == DBNull.Value ? null : objRow[concc_Attachment.Extension].ToString().Trim(); //扩展名
objcc_AttachmentEN.FilePath = objRow[concc_Attachment.FilePath].ToString().Trim(); //文件路径
objcc_AttachmentEN.FileSize = objRow[concc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_Attachment.FileSize].ToString().Trim()); //文件大小
objcc_AttachmentEN.FileSizeUnit = objRow[concc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[concc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_AttachmentEN.ImageHeight = objRow[concc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageHeight].ToString().Trim()); //图像高
objcc_AttachmentEN.ImageWidth = objRow[concc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageWidth].ToString().Trim()); //图像宽
objcc_AttachmentEN.UploadDate = objRow[concc_Attachment.UploadDate].ToString().Trim(); //上传时间
objcc_AttachmentEN.UploadPerson = objRow[concc_Attachment.UploadPerson] == DBNull.Value ? null : objRow[concc_Attachment.UploadPerson].ToString().Trim(); //上传人
objcc_AttachmentEN.TableNameKey = objRow[concc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objcc_AttachmentEN.IdResourceType = objRow[concc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objcc_AttachmentEN.UpdDate = objRow[concc_Attachment.UpdDate].ToString().Trim(); //修改日期
objcc_AttachmentEN.UpdUserId = objRow[concc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[concc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objcc_AttachmentEN.Memo = objRow[concc_Attachment.Memo] == DBNull.Value ? null : objRow[concc_Attachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_AttachmentEN);
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
public static List<clscc_AttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_AttachmentEN> arrObjLst = new List<clscc_AttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_AttachmentEN objcc_AttachmentEN = new clscc_AttachmentEN();
try
{
objcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[concc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objcc_AttachmentEN.TableName = objRow[concc_Attachment.TableName] == DBNull.Value ? null : objRow[concc_Attachment.TableName].ToString().Trim(); //主表表名
objcc_AttachmentEN.FileName = objRow[concc_Attachment.FileName] == DBNull.Value ? null : objRow[concc_Attachment.FileName].ToString().Trim(); //文件名称
objcc_AttachmentEN.Extension = objRow[concc_Attachment.Extension] == DBNull.Value ? null : objRow[concc_Attachment.Extension].ToString().Trim(); //扩展名
objcc_AttachmentEN.FilePath = objRow[concc_Attachment.FilePath].ToString().Trim(); //文件路径
objcc_AttachmentEN.FileSize = objRow[concc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_Attachment.FileSize].ToString().Trim()); //文件大小
objcc_AttachmentEN.FileSizeUnit = objRow[concc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[concc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_AttachmentEN.ImageHeight = objRow[concc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageHeight].ToString().Trim()); //图像高
objcc_AttachmentEN.ImageWidth = objRow[concc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageWidth].ToString().Trim()); //图像宽
objcc_AttachmentEN.UploadDate = objRow[concc_Attachment.UploadDate].ToString().Trim(); //上传时间
objcc_AttachmentEN.UploadPerson = objRow[concc_Attachment.UploadPerson] == DBNull.Value ? null : objRow[concc_Attachment.UploadPerson].ToString().Trim(); //上传人
objcc_AttachmentEN.TableNameKey = objRow[concc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objcc_AttachmentEN.IdResourceType = objRow[concc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objcc_AttachmentEN.UpdDate = objRow[concc_Attachment.UpdDate].ToString().Trim(); //修改日期
objcc_AttachmentEN.UpdUserId = objRow[concc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[concc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objcc_AttachmentEN.Memo = objRow[concc_Attachment.Memo] == DBNull.Value ? null : objRow[concc_Attachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_AttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_AttachmentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_AttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_AttachmentEN> arrObjLst = new List<clscc_AttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_AttachmentEN objcc_AttachmentEN = new clscc_AttachmentEN();
try
{
objcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[concc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objcc_AttachmentEN.TableName = objRow[concc_Attachment.TableName] == DBNull.Value ? null : objRow[concc_Attachment.TableName].ToString().Trim(); //主表表名
objcc_AttachmentEN.FileName = objRow[concc_Attachment.FileName] == DBNull.Value ? null : objRow[concc_Attachment.FileName].ToString().Trim(); //文件名称
objcc_AttachmentEN.Extension = objRow[concc_Attachment.Extension] == DBNull.Value ? null : objRow[concc_Attachment.Extension].ToString().Trim(); //扩展名
objcc_AttachmentEN.FilePath = objRow[concc_Attachment.FilePath].ToString().Trim(); //文件路径
objcc_AttachmentEN.FileSize = objRow[concc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_Attachment.FileSize].ToString().Trim()); //文件大小
objcc_AttachmentEN.FileSizeUnit = objRow[concc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[concc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_AttachmentEN.ImageHeight = objRow[concc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageHeight].ToString().Trim()); //图像高
objcc_AttachmentEN.ImageWidth = objRow[concc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageWidth].ToString().Trim()); //图像宽
objcc_AttachmentEN.UploadDate = objRow[concc_Attachment.UploadDate].ToString().Trim(); //上传时间
objcc_AttachmentEN.UploadPerson = objRow[concc_Attachment.UploadPerson] == DBNull.Value ? null : objRow[concc_Attachment.UploadPerson].ToString().Trim(); //上传人
objcc_AttachmentEN.TableNameKey = objRow[concc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objcc_AttachmentEN.IdResourceType = objRow[concc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objcc_AttachmentEN.UpdDate = objRow[concc_Attachment.UpdDate].ToString().Trim(); //修改日期
objcc_AttachmentEN.UpdUserId = objRow[concc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[concc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objcc_AttachmentEN.Memo = objRow[concc_Attachment.Memo] == DBNull.Value ? null : objRow[concc_Attachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_AttachmentEN);
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
public static List<clscc_AttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_AttachmentEN> arrObjLst = new List<clscc_AttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_AttachmentEN objcc_AttachmentEN = new clscc_AttachmentEN();
try
{
objcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[concc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objcc_AttachmentEN.TableName = objRow[concc_Attachment.TableName] == DBNull.Value ? null : objRow[concc_Attachment.TableName].ToString().Trim(); //主表表名
objcc_AttachmentEN.FileName = objRow[concc_Attachment.FileName] == DBNull.Value ? null : objRow[concc_Attachment.FileName].ToString().Trim(); //文件名称
objcc_AttachmentEN.Extension = objRow[concc_Attachment.Extension] == DBNull.Value ? null : objRow[concc_Attachment.Extension].ToString().Trim(); //扩展名
objcc_AttachmentEN.FilePath = objRow[concc_Attachment.FilePath].ToString().Trim(); //文件路径
objcc_AttachmentEN.FileSize = objRow[concc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_Attachment.FileSize].ToString().Trim()); //文件大小
objcc_AttachmentEN.FileSizeUnit = objRow[concc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[concc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_AttachmentEN.ImageHeight = objRow[concc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageHeight].ToString().Trim()); //图像高
objcc_AttachmentEN.ImageWidth = objRow[concc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageWidth].ToString().Trim()); //图像宽
objcc_AttachmentEN.UploadDate = objRow[concc_Attachment.UploadDate].ToString().Trim(); //上传时间
objcc_AttachmentEN.UploadPerson = objRow[concc_Attachment.UploadPerson] == DBNull.Value ? null : objRow[concc_Attachment.UploadPerson].ToString().Trim(); //上传人
objcc_AttachmentEN.TableNameKey = objRow[concc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objcc_AttachmentEN.IdResourceType = objRow[concc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objcc_AttachmentEN.UpdDate = objRow[concc_Attachment.UpdDate].ToString().Trim(); //修改日期
objcc_AttachmentEN.UpdUserId = objRow[concc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[concc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objcc_AttachmentEN.Memo = objRow[concc_Attachment.Memo] == DBNull.Value ? null : objRow[concc_Attachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_AttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_AttachmentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_AttachmentEN> arrObjLst = new List<clscc_AttachmentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_AttachmentEN objcc_AttachmentEN = new clscc_AttachmentEN();
try
{
objcc_AttachmentEN.AttachmentID = Int32.Parse(objRow[concc_Attachment.AttachmentID].ToString().Trim()); //附件流水号
objcc_AttachmentEN.TableName = objRow[concc_Attachment.TableName] == DBNull.Value ? null : objRow[concc_Attachment.TableName].ToString().Trim(); //主表表名
objcc_AttachmentEN.FileName = objRow[concc_Attachment.FileName] == DBNull.Value ? null : objRow[concc_Attachment.FileName].ToString().Trim(); //文件名称
objcc_AttachmentEN.Extension = objRow[concc_Attachment.Extension] == DBNull.Value ? null : objRow[concc_Attachment.Extension].ToString().Trim(); //扩展名
objcc_AttachmentEN.FilePath = objRow[concc_Attachment.FilePath].ToString().Trim(); //文件路径
objcc_AttachmentEN.FileSize = objRow[concc_Attachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_Attachment.FileSize].ToString().Trim()); //文件大小
objcc_AttachmentEN.FileSizeUnit = objRow[concc_Attachment.FileSizeUnit] == DBNull.Value ? null : objRow[concc_Attachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_AttachmentEN.ImageHeight = objRow[concc_Attachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageHeight].ToString().Trim()); //图像高
objcc_AttachmentEN.ImageWidth = objRow[concc_Attachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Attachment.ImageWidth].ToString().Trim()); //图像宽
objcc_AttachmentEN.UploadDate = objRow[concc_Attachment.UploadDate].ToString().Trim(); //上传时间
objcc_AttachmentEN.UploadPerson = objRow[concc_Attachment.UploadPerson] == DBNull.Value ? null : objRow[concc_Attachment.UploadPerson].ToString().Trim(); //上传人
objcc_AttachmentEN.TableNameKey = objRow[concc_Attachment.TableNameKey].ToString().Trim(); //主表主键值
objcc_AttachmentEN.IdResourceType = objRow[concc_Attachment.IdResourceType].ToString().Trim(); //资源类型流水号
objcc_AttachmentEN.UpdDate = objRow[concc_Attachment.UpdDate].ToString().Trim(); //修改日期
objcc_AttachmentEN.UpdUserId = objRow[concc_Attachment.UpdUserId] == DBNull.Value ? null : objRow[concc_Attachment.UpdUserId].ToString().Trim(); //修改用户Id
objcc_AttachmentEN.Memo = objRow[concc_Attachment.Memo] == DBNull.Value ? null : objRow[concc_Attachment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_AttachmentEN.AttachmentID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_AttachmentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_Attachment(ref clscc_AttachmentEN objcc_AttachmentEN)
{
bool bolResult = cc_AttachmentDA.Getcc_Attachment(ref objcc_AttachmentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngAttachmentID">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_AttachmentEN GetObjByAttachmentID(long lngAttachmentID)
{
clscc_AttachmentEN objcc_AttachmentEN = cc_AttachmentDA.GetObjByAttachmentID(lngAttachmentID);
return objcc_AttachmentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_AttachmentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_AttachmentEN objcc_AttachmentEN = cc_AttachmentDA.GetFirstObj(strWhereCond);
 return objcc_AttachmentEN;
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
public static clscc_AttachmentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_AttachmentEN objcc_AttachmentEN = cc_AttachmentDA.GetObjByDataRow(objRow);
 return objcc_AttachmentEN;
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
public static clscc_AttachmentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_AttachmentEN objcc_AttachmentEN = cc_AttachmentDA.GetObjByDataRow(objRow);
 return objcc_AttachmentEN;
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
 /// <param name = "lstcc_AttachmentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_AttachmentEN GetObjByAttachmentIDFromList(long lngAttachmentID, List<clscc_AttachmentEN> lstcc_AttachmentObjLst)
{
foreach (clscc_AttachmentEN objcc_AttachmentEN in lstcc_AttachmentObjLst)
{
if (objcc_AttachmentEN.AttachmentID == lngAttachmentID)
{
return objcc_AttachmentEN;
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
 lngAttachmentID = new clscc_AttachmentDA().GetFirstID(strWhereCond);
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
 arrList = cc_AttachmentDA.GetID(strWhereCond);
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
bool bolIsExist = cc_AttachmentDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = cc_AttachmentDA.IsExist(lngAttachmentID);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngAttachmentID">附件流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngAttachmentID, string strOpUser)
{
clscc_AttachmentEN objcc_AttachmentEN = clscc_AttachmentBL.GetObjByAttachmentID(lngAttachmentID);
objcc_AttachmentEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_AttachmentEN.UpdUserId = strOpUser;
return clscc_AttachmentBL.UpdateBySql2(objcc_AttachmentEN);
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
 bolIsExist = clscc_AttachmentDA.IsExistTable();
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
 bolIsExist = cc_AttachmentDA.IsExistTable(strTabName);
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


 #region 添加记录

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_AttachmentEN objcc_AttachmentEN)
{
if (objcc_AttachmentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主表表名 = [{0}],主表主键值 = [{1}],文件名称 = [{2}]的数据已经存在!(in clscc_AttachmentBL.AddNewRecordBySql2)", objcc_AttachmentEN.TableName,objcc_AttachmentEN.TableNameKey,objcc_AttachmentEN.FileName);
throw new Exception(strMsg);
}
try
{
bool bolResult = cc_AttachmentDA.AddNewRecordBySQL2(objcc_AttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_AttachmentBL.ReFreshCache(objcc_AttachmentEN.TableName);

if (clscc_AttachmentBL.relatedActions != null)
{
clscc_AttachmentBL.relatedActions.UpdRelaTabDate(objcc_AttachmentEN.AttachmentID, objcc_AttachmentEN.UpdUserId);
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000030)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_AttachmentEN objcc_AttachmentEN)
{
if (objcc_AttachmentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主表表名 = [{0}],主表主键值 = [{1}],文件名称 = [{2}]的数据已经存在!(in clscc_AttachmentBL.AddNewRecordBySql2WithReturnKey)", objcc_AttachmentEN.TableName,objcc_AttachmentEN.TableNameKey,objcc_AttachmentEN.FileName);
throw new Exception(strMsg);
}
try
{
string strKey = cc_AttachmentDA.AddNewRecordBySQL2WithReturnKey(objcc_AttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_AttachmentBL.ReFreshCache(objcc_AttachmentEN.TableName);

if (clscc_AttachmentBL.relatedActions != null)
{
clscc_AttachmentBL.relatedActions.UpdRelaTabDate(objcc_AttachmentEN.AttachmentID, objcc_AttachmentEN.UpdUserId);
}
return strKey;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000049)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 添加记录


 #region 修改记录

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Update)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_AttachmentEN objcc_AttachmentEN)
{
try
{
bool bolResult = cc_AttachmentDA.Update(objcc_AttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_AttachmentBL.ReFreshCache(objcc_AttachmentEN.TableName);

if (clscc_AttachmentBL.relatedActions != null)
{
clscc_AttachmentBL.relatedActions.UpdRelaTabDate(objcc_AttachmentEN.AttachmentID, objcc_AttachmentEN.UpdUserId);
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000033)修改记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql2)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_AttachmentEN objcc_AttachmentEN)
{
 if (objcc_AttachmentEN.AttachmentID == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_AttachmentDA.UpdateBySql2(objcc_AttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_AttachmentBL.ReFreshCache(objcc_AttachmentEN.TableName);

if (clscc_AttachmentBL.relatedActions != null)
{
clscc_AttachmentBL.relatedActions.UpdRelaTabDate(objcc_AttachmentEN.AttachmentID, objcc_AttachmentEN.UpdUserId);
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000034)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 修改记录


 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord)
 /// </summary>
 /// <param name = "lngAttachmentID">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngAttachmentID)
{
try
{
 clscc_AttachmentEN objcc_AttachmentEN = clscc_AttachmentBL.GetObjByAttachmentID(lngAttachmentID);

if (clscc_AttachmentBL.relatedActions != null)
{
clscc_AttachmentBL.relatedActions.UpdRelaTabDate(objcc_AttachmentEN.AttachmentID, objcc_AttachmentEN.UpdUserId);
}
if (objcc_AttachmentEN != null)
{
int intRecNum = cc_AttachmentDA.DelRecord(lngAttachmentID);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objcc_AttachmentEN.TableName);
return intRecNum;
}
            else
{
return 0;
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000039)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="lngAttachmentID">表关键字</param>
 /// <param name = "strTableName">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngAttachmentID , string strTableName)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_AttachmentDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[cc_Attachment]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_Attachment.AttachmentID,
//lngAttachmentID);
//        clscc_AttachmentBL.Delcc_AttachmentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_AttachmentBL.DelRecord(lngAttachmentID, strTableName, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_AttachmentBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngAttachmentID, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
 /// </summary>
 /// <param name = "lngAttachmentID">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngAttachmentID, string strTableName, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_AttachmentBL.relatedActions != null)
{
clscc_AttachmentBL.relatedActions.UpdRelaTabDate(lngAttachmentID, "UpdRelaTabDate");
}
bool bolResult = cc_AttachmentDA.DelRecord(lngAttachmentID,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strTableName);
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000040)根据关键字删除记录出错!(使用事务),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrAttachmentIDLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_Attachments(List<string> arrAttachmentIDLst)
{
if (arrAttachmentIDLst.Count == 0) return 0;
try
{
if (clscc_AttachmentBL.relatedActions != null)
{
foreach (var strAttachmentID in arrAttachmentIDLst)
{
long lngAttachmentID = long.Parse(strAttachmentID);
clscc_AttachmentBL.relatedActions.UpdRelaTabDate(lngAttachmentID, "UpdRelaTabDate");
}
}
 clscc_AttachmentEN objcc_AttachmentEN = clscc_AttachmentBL.GetObjByAttachmentID(long.Parse(arrAttachmentIDLst[0]));
int intDelRecNum = cc_AttachmentDA.Delcc_Attachment(arrAttachmentIDLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objcc_AttachmentEN.TableName);
return intDelRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000042)删除多关键字记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public static int Delcc_AttachmentsByCond(string strWhereCond)
{
try
{
if (clscc_AttachmentBL.relatedActions != null)
{
List<string> arrAttachmentID = GetPrimaryKeyID_S(strWhereCond);
foreach (var strAttachmentID in arrAttachmentID)
{
long lngAttachmentID = long.Parse(strAttachmentID);
clscc_AttachmentBL.relatedActions.UpdRelaTabDate(lngAttachmentID, "UpdRelaTabDate");
}
}
List<string> arrTableName = GetFldValue(concc_Attachment.TableName, strWhereCond);
int intRecNum = cc_AttachmentDA.Delcc_Attachment(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrTableName.ForEach(x => ReFreshCache(x));
return intRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000043)删除带条件表记录出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_Attachment]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngAttachmentID">表关键字</param>
 /// <param name = "strTableName">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngAttachmentID, string strTableName)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_AttachmentDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[cc_Attachment]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_AttachmentBL.DelRecord(lngAttachmentID, strTableName, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_AttachmentBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngAttachmentID, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}


 #endregion 删除记录


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objcc_AttachmentENS">源对象</param>
 /// <param name = "objcc_AttachmentENT">目标对象</param>
 public static void CopyTo(clscc_AttachmentEN objcc_AttachmentENS, clscc_AttachmentEN objcc_AttachmentENT)
{
try
{
objcc_AttachmentENT.AttachmentID = objcc_AttachmentENS.AttachmentID; //附件流水号
objcc_AttachmentENT.TableName = objcc_AttachmentENS.TableName; //主表表名
objcc_AttachmentENT.FileName = objcc_AttachmentENS.FileName; //文件名称
objcc_AttachmentENT.Extension = objcc_AttachmentENS.Extension; //扩展名
objcc_AttachmentENT.FilePath = objcc_AttachmentENS.FilePath; //文件路径
objcc_AttachmentENT.FileSize = objcc_AttachmentENS.FileSize; //文件大小
objcc_AttachmentENT.FileSizeUnit = objcc_AttachmentENS.FileSizeUnit; //文件大小单位
objcc_AttachmentENT.ImageHeight = objcc_AttachmentENS.ImageHeight; //图像高
objcc_AttachmentENT.ImageWidth = objcc_AttachmentENS.ImageWidth; //图像宽
objcc_AttachmentENT.UploadDate = objcc_AttachmentENS.UploadDate; //上传时间
objcc_AttachmentENT.UploadPerson = objcc_AttachmentENS.UploadPerson; //上传人
objcc_AttachmentENT.TableNameKey = objcc_AttachmentENS.TableNameKey; //主表主键值
objcc_AttachmentENT.IdResourceType = objcc_AttachmentENS.IdResourceType; //资源类型流水号
objcc_AttachmentENT.UpdDate = objcc_AttachmentENS.UpdDate; //修改日期
objcc_AttachmentENT.UpdUserId = objcc_AttachmentENS.UpdUserId; //修改用户Id
objcc_AttachmentENT.Memo = objcc_AttachmentENS.Memo; //备注
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
 /// <param name = "objcc_AttachmentEN">源简化对象</param>
 public static void SetUpdFlag(clscc_AttachmentEN objcc_AttachmentEN)
{
try
{
objcc_AttachmentEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_AttachmentEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_Attachment.AttachmentID, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_AttachmentEN.AttachmentID = objcc_AttachmentEN.AttachmentID; //附件流水号
}
if (arrFldSet.Contains(concc_Attachment.TableName, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_AttachmentEN.TableName = objcc_AttachmentEN.TableName == "[null]" ? null :  objcc_AttachmentEN.TableName; //主表表名
}
if (arrFldSet.Contains(concc_Attachment.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_AttachmentEN.FileName = objcc_AttachmentEN.FileName == "[null]" ? null :  objcc_AttachmentEN.FileName; //文件名称
}
if (arrFldSet.Contains(concc_Attachment.Extension, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_AttachmentEN.Extension = objcc_AttachmentEN.Extension == "[null]" ? null :  objcc_AttachmentEN.Extension; //扩展名
}
if (arrFldSet.Contains(concc_Attachment.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_AttachmentEN.FilePath = objcc_AttachmentEN.FilePath; //文件路径
}
if (arrFldSet.Contains(concc_Attachment.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_AttachmentEN.FileSize = objcc_AttachmentEN.FileSize; //文件大小
}
if (arrFldSet.Contains(concc_Attachment.FileSizeUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_AttachmentEN.FileSizeUnit = objcc_AttachmentEN.FileSizeUnit == "[null]" ? null :  objcc_AttachmentEN.FileSizeUnit; //文件大小单位
}
if (arrFldSet.Contains(concc_Attachment.ImageHeight, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_AttachmentEN.ImageHeight = objcc_AttachmentEN.ImageHeight; //图像高
}
if (arrFldSet.Contains(concc_Attachment.ImageWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_AttachmentEN.ImageWidth = objcc_AttachmentEN.ImageWidth; //图像宽
}
if (arrFldSet.Contains(concc_Attachment.UploadDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_AttachmentEN.UploadDate = objcc_AttachmentEN.UploadDate; //上传时间
}
if (arrFldSet.Contains(concc_Attachment.UploadPerson, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_AttachmentEN.UploadPerson = objcc_AttachmentEN.UploadPerson == "[null]" ? null :  objcc_AttachmentEN.UploadPerson; //上传人
}
if (arrFldSet.Contains(concc_Attachment.TableNameKey, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_AttachmentEN.TableNameKey = objcc_AttachmentEN.TableNameKey; //主表主键值
}
if (arrFldSet.Contains(concc_Attachment.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_AttachmentEN.IdResourceType = objcc_AttachmentEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(concc_Attachment.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_AttachmentEN.UpdDate = objcc_AttachmentEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_Attachment.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_AttachmentEN.UpdUserId = objcc_AttachmentEN.UpdUserId == "[null]" ? null :  objcc_AttachmentEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(concc_Attachment.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_AttachmentEN.Memo = objcc_AttachmentEN.Memo == "[null]" ? null :  objcc_AttachmentEN.Memo; //备注
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
 /// <param name = "objcc_AttachmentEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_AttachmentEN objcc_AttachmentEN)
{
try
{
if (objcc_AttachmentEN.TableName == "[null]") objcc_AttachmentEN.TableName = null; //主表表名
if (objcc_AttachmentEN.FileName == "[null]") objcc_AttachmentEN.FileName = null; //文件名称
if (objcc_AttachmentEN.Extension == "[null]") objcc_AttachmentEN.Extension = null; //扩展名
if (objcc_AttachmentEN.FileSizeUnit == "[null]") objcc_AttachmentEN.FileSizeUnit = null; //文件大小单位
if (objcc_AttachmentEN.UploadPerson == "[null]") objcc_AttachmentEN.UploadPerson = null; //上传人
if (objcc_AttachmentEN.UpdUserId == "[null]") objcc_AttachmentEN.UpdUserId = null; //修改用户Id
if (objcc_AttachmentEN.Memo == "[null]") objcc_AttachmentEN.Memo = null; //备注
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_AttachmentEN objcc_AttachmentEN)
{
 cc_AttachmentDA.CheckPropertyNew(objcc_AttachmentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_AttachmentEN objcc_AttachmentEN)
{
 cc_AttachmentDA.CheckProperty4Condition(objcc_AttachmentEN);
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
if (clscc_AttachmentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_AttachmentBL没有刷新缓存机制(clscc_AttachmentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by AttachmentID");
//if (arrcc_AttachmentObjLstCache == null)
//{
//arrcc_AttachmentObjLstCache = cc_AttachmentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngAttachmentID">所给的关键字</param>
 /// <param name = "strTableName">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_AttachmentEN GetObjByAttachmentIDCache(long lngAttachmentID, string strTableName)
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
string strKey = string.Format("{0}_{1}", clscc_AttachmentEN._CurrTabName, strTableName);
List<clscc_AttachmentEN> arrcc_AttachmentObjLstCache = GetObjLstCache(strTableName);
IEnumerable <clscc_AttachmentEN> arrcc_AttachmentObjLst_Sel =
arrcc_AttachmentObjLstCache
.Where(x=> x.AttachmentID == lngAttachmentID 
);
if (arrcc_AttachmentObjLst_Sel.Count() == 0)
{
   clscc_AttachmentEN obj = clscc_AttachmentBL.GetObjByAttachmentID(lngAttachmentID);
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
return arrcc_AttachmentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_AttachmentEN> GetAllcc_AttachmentObjLstCache(string strTableName)
{
//获取缓存中的对象列表
List<clscc_AttachmentEN> arrcc_AttachmentObjLstCache = GetObjLstCache(strTableName); 
return arrcc_AttachmentObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_AttachmentEN> GetObjLstCache(string strTableName)
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
string strKey = string.Format("{0}_{1}", clscc_AttachmentEN._CurrTabName, strTableName);
string strCondition = string.Format("TableName='{0}'", strTableName);
List<clscc_AttachmentEN> arrcc_AttachmentObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrcc_AttachmentObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:TableName字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrcc_AttachmentObjLst">需要排序的对象列表</param>
public static List <clscc_AttachmentEN> GetSubSet4cc_AttachmentObjLstByTableNameCache(string strTableName)
{
   if (string.IsNullOrEmpty(strTableName) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_AttachmentEN._CurrTabName, strTableName);
List<clscc_AttachmentEN> arrcc_AttachmentObjLstCache = GetObjLstCache(strTableName);
IEnumerable <clscc_AttachmentEN> arrcc_AttachmentObjLst_Sel1 =
from objcc_AttachmentEN in arrcc_AttachmentObjLstCache
where objcc_AttachmentEN.TableName == strTableName
select objcc_AttachmentEN;
List <clscc_AttachmentEN> arrcc_AttachmentObjLst_Sel = new List<clscc_AttachmentEN>();
foreach (clscc_AttachmentEN obj in arrcc_AttachmentObjLst_Sel1)
{
arrcc_AttachmentObjLst_Sel.Add(obj);
}
return arrcc_AttachmentObjLst_Sel;
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
string strKey = string.Format("{0}_{1}", clscc_AttachmentEN._CurrTabName, strTableName);
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strTableName)
{
if (string.IsNullOrEmpty(strTableName) == true)
{
string strMsg = string.Format("缓存分类字段:[TableName]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_AttachmentBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_AttachmentEN._CurrTabName, strTableName);
CacheHelper.Remove(strKey);
clscc_AttachmentBL.objCommFun4BL.ReFreshCache(strTableName);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_Attachment(附件)
 /// 唯一性条件:TableName_TableNameKey_FileName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_AttachmentEN objcc_AttachmentEN)
{
//检测记录是否存在
string strResult = cc_AttachmentDA.GetUniCondStr(objcc_AttachmentEN);
return strResult;
}


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
if (strInFldName != concc_Attachment.AttachmentID)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_Attachment.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_Attachment.AttributeName));
throw new Exception(strMsg);
}
var objcc_Attachment = clscc_AttachmentBL.GetObjByAttachmentIDCache(lngAttachmentID, strTableName);
if (objcc_Attachment == null) return "";
return objcc_Attachment[strOutFldName].ToString();
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
int intRecCount = clscc_AttachmentDA.GetRecCount(strTabName);
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
int intRecCount = clscc_AttachmentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_AttachmentDA.GetRecCount();
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
int intRecCount = clscc_AttachmentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_AttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_AttachmentEN objcc_AttachmentCond)
{
 string strTableName = objcc_AttachmentCond.TableName;
 if (string.IsNullOrEmpty(strTableName) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clscc_AttachmentBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clscc_AttachmentEN> arrObjLstCache = GetObjLstCache(strTableName);
IEnumerable <clscc_AttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_Attachment.AttributeName)
{
if (objcc_AttachmentCond.IsUpdated(strFldName) == false) continue;
if (objcc_AttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_AttachmentCond[strFldName].ToString());
}
else
{
if (objcc_AttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_AttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_AttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_AttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_AttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_AttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_AttachmentCond[strFldName]));
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
 List<string> arrList = clscc_AttachmentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_AttachmentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_AttachmentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = cc_AttachmentDA.SetFldValue(strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}


 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "fltValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clscc_AttachmentDA.SetFldValue(clscc_AttachmentEN._CurrTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "intValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = cc_AttachmentDA.SetFldValue( strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = clscc_AttachmentDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = clscc_AttachmentDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clscc_AttachmentDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}



 #endregion 表操作常用函数


 #region 表操作

 /// <summary>
 /// 功能:获取建立表的代码
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GenSQLCode4CreateTab)
 /// </summary>
 /// <returns>建立表的代码</returns>
public static string GetCode4CreateTable() 
{
 StringBuilder strCreateTabCode = new StringBuilder();
  strCreateTabCode.Append("CREATE table [dbo].[cc_Attachment] "); 
 strCreateTabCode.Append(" ( "); 
 // /**附件流水号*/ 
 strCreateTabCode.Append(" AttachmentID bigint primary key identity, "); 
 // /**主表表名*/ 
 strCreateTabCode.Append(" TableName varchar(100) Null, "); 
 // /**文件名称*/ 
 strCreateTabCode.Append(" FileName varchar(500) Null, "); 
 // /**扩展名*/ 
 strCreateTabCode.Append(" Extension varchar(10) Null, "); 
 // /**文件路径*/ 
 strCreateTabCode.Append(" FilePath varchar(500) not Null, "); 
 // /**文件大小*/ 
 strCreateTabCode.Append(" FileSize decimal(22,0) Null, "); 
 // /**文件大小单位*/ 
 strCreateTabCode.Append(" FileSizeUnit varchar(10) Null, "); 
 // /**图像高*/ 
 strCreateTabCode.Append(" ImageHeight int Null, "); 
 // /**图像宽*/ 
 strCreateTabCode.Append(" ImageWidth int Null, "); 
 // /**上传时间*/ 
 strCreateTabCode.Append(" UploadDate varchar(20) not Null, "); 
 // /**上传人*/ 
 strCreateTabCode.Append(" UploadPerson varchar(20) Null, "); 
 // /**主表主键值*/ 
 strCreateTabCode.Append(" TableNameKey varchar(20) not Null, "); 
 // /**资源类型流水号*/ 
 strCreateTabCode.Append(" IdResourceType char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 附件(cc_Attachment)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_Attachment : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strTableName)
{
string strMsg;
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
clscc_AttachmentBL.ReFreshThisCache(strTableName);
}
}

}