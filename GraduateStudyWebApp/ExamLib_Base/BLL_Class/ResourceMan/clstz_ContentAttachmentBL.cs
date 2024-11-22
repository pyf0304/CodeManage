
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clstz_ContentAttachmentBL
 表名:tz_ContentAttachment(01120207)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:44
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理(ResourceMan)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
public static class  clstz_ContentAttachmentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clstz_ContentAttachmentEN GetObj(this K_mId_tz_ContentAttachment myKey)
{
clstz_ContentAttachmentEN objtz_ContentAttachmentEN = clstz_ContentAttachmentBL.tz_ContentAttachmentDA.GetObjBymId(myKey.Value);
return objtz_ContentAttachmentEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objtz_ContentAttachmentEN) == false)
{
var strMsg = string.Format("记录已经存在!内容类型Id = [{0}],主表主键值 = [{1}],附件标题 = [{2}]的数据已经存在!(in clstz_ContentAttachmentBL.AddNewRecord)", objtz_ContentAttachmentEN.ContentTypeId,objtz_ContentAttachmentEN.TableNameKey,objtz_ContentAttachmentEN.AttachmentTitle);
throw new Exception(strMsg);
}
try
{
bool bolResult = clstz_ContentAttachmentBL.tz_ContentAttachmentDA.AddNewRecordBySQL2(objtz_ContentAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_ContentAttachmentBL.ReFreshCache(objtz_ContentAttachmentEN.CourseId);

if (clstz_ContentAttachmentBL.relatedActions != null)
{
clstz_ContentAttachmentBL.relatedActions.UpdRelaTabDate(objtz_ContentAttachmentEN.mId, objtz_ContentAttachmentEN.UpdUserId);
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
public static bool AddRecordEx(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, bool bolIsNeedCheckUniqueness = true)
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
objtz_ContentAttachmentEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objtz_ContentAttachmentEN.CheckUniqueness() == false)
{
strMsg = string.Format("(内容类型Id(ContentTypeId)=[{0}],主表主键值(TableNameKey)=[{1}],附件标题(AttachmentTitle)=[{2}])已经存在,不能重复!", objtz_ContentAttachmentEN.ContentTypeId, objtz_ContentAttachmentEN.TableNameKey, objtz_ContentAttachmentEN.AttachmentTitle);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objtz_ContentAttachmentEN.AddNewRecord();
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
 /// <param name = "objtz_ContentAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objtz_ContentAttachmentEN) == false)
{
var strMsg = string.Format("记录已经存在!内容类型Id = [{0}],主表主键值 = [{1}],附件标题 = [{2}]的数据已经存在!(in clstz_ContentAttachmentBL.AddNewRecordWithReturnKey)", objtz_ContentAttachmentEN.ContentTypeId,objtz_ContentAttachmentEN.TableNameKey,objtz_ContentAttachmentEN.AttachmentTitle);
throw new Exception(strMsg);
}
try
{
string strKey = clstz_ContentAttachmentBL.tz_ContentAttachmentDA.AddNewRecordBySQL2WithReturnKey(objtz_ContentAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_ContentAttachmentBL.ReFreshCache(objtz_ContentAttachmentEN.CourseId);

if (clstz_ContentAttachmentBL.relatedActions != null)
{
clstz_ContentAttachmentBL.relatedActions.UpdRelaTabDate(objtz_ContentAttachmentEN.mId, objtz_ContentAttachmentEN.UpdUserId);
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
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetContentTypeId(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strContentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strContentTypeId, contz_ContentAttachment.ContentTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strContentTypeId, 4, contz_ContentAttachment.ContentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strContentTypeId, 4, contz_ContentAttachment.ContentTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetTableNameKey(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strTableNameKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTableNameKey, contz_ContentAttachment.TableNameKey);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableNameKey, 20, contz_ContentAttachment.TableNameKey);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetOrderNum(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, int? intOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetAttachmentTitle(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strAttachmentTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAttachmentTitle, 100, contz_ContentAttachment.AttachmentTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetIdResourceType(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strIdResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResourceType, contz_ContentAttachment.IdResourceType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, contz_ContentAttachment.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, contz_ContentAttachment.IdResourceType);
}
objtz_ContentAttachmentEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_ContentAttachmentEN.dicFldComparisonOp.ContainsKey(contz_ContentAttachment.IdResourceType) == false)
{
objtz_ContentAttachmentEN.dicFldComparisonOp.Add(contz_ContentAttachment.IdResourceType, strComparisonOp);
}
else
{
objtz_ContentAttachmentEN.dicFldComparisonOp[contz_ContentAttachment.IdResourceType] = strComparisonOp;
}
}
return objtz_ContentAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetTextContent(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strTextContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextContent, 8000, contz_ContentAttachment.TextContent);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetFileName(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, contz_ContentAttachment.FileName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetExtension(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strExtension, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExtension, 10, contz_ContentAttachment.Extension);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetFilePath(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strFilePath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, contz_ContentAttachment.FilePath);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetPdfFilePath(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strPdfFilePath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfFilePath, 500, contz_ContentAttachment.PdfFilePath);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetSwfFilePath(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strSwfFilePath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSwfFilePath, 500, contz_ContentAttachment.SwfFilePath);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetFileSize(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, double? dblFileSize, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetFileSizeUnit(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strFileSizeUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSizeUnit, 10, contz_ContentAttachment.FileSizeUnit);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetImageHeight(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, int? intImageHeight, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetImageWidth(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, int? intImageWidth, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetUploadDate(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strUploadDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUploadDate, contz_ContentAttachment.UploadDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadDate, 20, contz_ContentAttachment.UploadDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetUploadPerson(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strUploadPerson, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadPerson, 20, contz_ContentAttachment.UploadPerson);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetUpdDate(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, contz_ContentAttachment.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, contz_ContentAttachment.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetUpdUserId(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, contz_ContentAttachment.UpdUserId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetMemo(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, contz_ContentAttachment.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_ContentAttachmentEN SetCourseId(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, contz_ContentAttachment.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, contz_ContentAttachment.CourseId);
}
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
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objtz_ContentAttachmentEN.CheckPropertyNew();
clstz_ContentAttachmentEN objtz_ContentAttachmentCond = new clstz_ContentAttachmentEN();
string strCondition = objtz_ContentAttachmentCond
.SetmId(objtz_ContentAttachmentEN.mId, "<>")
.SetContentTypeId(objtz_ContentAttachmentEN.ContentTypeId, "=")
.SetTableNameKey(objtz_ContentAttachmentEN.TableNameKey, "=")
.SetAttachmentTitle(objtz_ContentAttachmentEN.AttachmentTitle, "=")
.GetCombineCondition();
objtz_ContentAttachmentEN._IsCheckProperty = true;
bool bolIsExist = clstz_ContentAttachmentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ContentTypeId_TableNameKey_mId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objtz_ContentAttachmentEN.Update();
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
 /// <param name = "objtz_ContentAttachment">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clstz_ContentAttachmentEN objtz_ContentAttachment)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clstz_ContentAttachmentEN objtz_ContentAttachmentCond = new clstz_ContentAttachmentEN();
string strCondition = objtz_ContentAttachmentCond
.SetContentTypeId(objtz_ContentAttachment.ContentTypeId, "=")
.SetTableNameKey(objtz_ContentAttachment.TableNameKey, "=")
.SetAttachmentTitle(objtz_ContentAttachment.AttachmentTitle, "=")
.GetCombineCondition();
objtz_ContentAttachment._IsCheckProperty = true;
bool bolIsExist = clstz_ContentAttachmentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objtz_ContentAttachment.mId = clstz_ContentAttachmentBL.GetFirstID_S(strCondition);
objtz_ContentAttachment.UpdateWithCondition(strCondition);
}
else
{
objtz_ContentAttachment.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
 if (objtz_ContentAttachmentEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clstz_ContentAttachmentBL.tz_ContentAttachmentDA.UpdateBySql2(objtz_ContentAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_ContentAttachmentBL.ReFreshCache(objtz_ContentAttachmentEN.CourseId);

if (clstz_ContentAttachmentBL.relatedActions != null)
{
clstz_ContentAttachmentBL.relatedActions.UpdRelaTabDate(objtz_ContentAttachmentEN.mId, objtz_ContentAttachmentEN.UpdUserId);
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
 /// <param name = "objtz_ContentAttachmentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objtz_ContentAttachmentEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clstz_ContentAttachmentBL.tz_ContentAttachmentDA.UpdateBySql2(objtz_ContentAttachmentEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_ContentAttachmentBL.ReFreshCache(objtz_ContentAttachmentEN.CourseId);

if (clstz_ContentAttachmentBL.relatedActions != null)
{
clstz_ContentAttachmentBL.relatedActions.UpdRelaTabDate(objtz_ContentAttachmentEN.mId, objtz_ContentAttachmentEN.UpdUserId);
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
 /// <param name = "objtz_ContentAttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strWhereCond)
{
try
{
bool bolResult = clstz_ContentAttachmentBL.tz_ContentAttachmentDA.UpdateBySqlWithCondition(objtz_ContentAttachmentEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_ContentAttachmentBL.ReFreshCache(objtz_ContentAttachmentEN.CourseId);

if (clstz_ContentAttachmentBL.relatedActions != null)
{
clstz_ContentAttachmentBL.relatedActions.UpdRelaTabDate(objtz_ContentAttachmentEN.mId, objtz_ContentAttachmentEN.UpdUserId);
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
 /// <param name = "objtz_ContentAttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clstz_ContentAttachmentBL.tz_ContentAttachmentDA.UpdateBySqlWithConditionTransaction(objtz_ContentAttachmentEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_ContentAttachmentBL.ReFreshCache(objtz_ContentAttachmentEN.CourseId);

if (clstz_ContentAttachmentBL.relatedActions != null)
{
clstz_ContentAttachmentBL.relatedActions.UpdRelaTabDate(objtz_ContentAttachmentEN.mId, objtz_ContentAttachmentEN.UpdUserId);
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
try
{
int intRecNum = clstz_ContentAttachmentBL.tz_ContentAttachmentDA.DelRecord(objtz_ContentAttachmentEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_ContentAttachmentBL.ReFreshCache(objtz_ContentAttachmentEN.CourseId);

if (clstz_ContentAttachmentBL.relatedActions != null)
{
clstz_ContentAttachmentBL.relatedActions.UpdRelaTabDate(objtz_ContentAttachmentEN.mId, objtz_ContentAttachmentEN.UpdUserId);
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
 /// <param name = "objtz_ContentAttachmentENS">源对象</param>
 /// <param name = "objtz_ContentAttachmentENT">目标对象</param>
 public static void CopyTo(this clstz_ContentAttachmentEN objtz_ContentAttachmentENS, clstz_ContentAttachmentEN objtz_ContentAttachmentENT)
{
try
{
objtz_ContentAttachmentENT.mId = objtz_ContentAttachmentENS.mId; //mId
objtz_ContentAttachmentENT.ContentTypeId = objtz_ContentAttachmentENS.ContentTypeId; //内容类型Id
objtz_ContentAttachmentENT.TableNameKey = objtz_ContentAttachmentENS.TableNameKey; //主表主键值
objtz_ContentAttachmentENT.OrderNum = objtz_ContentAttachmentENS.OrderNum; //序号
objtz_ContentAttachmentENT.AttachmentTitle = objtz_ContentAttachmentENS.AttachmentTitle; //附件标题
objtz_ContentAttachmentENT.IdResourceType = objtz_ContentAttachmentENS.IdResourceType; //资源类型流水号
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
 /// <param name = "objtz_ContentAttachmentENS">源对象</param>
 /// <returns>目标对象=>clstz_ContentAttachmentEN:objtz_ContentAttachmentENT</returns>
 public static clstz_ContentAttachmentEN CopyTo(this clstz_ContentAttachmentEN objtz_ContentAttachmentENS)
{
try
{
 clstz_ContentAttachmentEN objtz_ContentAttachmentENT = new clstz_ContentAttachmentEN()
{
mId = objtz_ContentAttachmentENS.mId, //mId
ContentTypeId = objtz_ContentAttachmentENS.ContentTypeId, //内容类型Id
TableNameKey = objtz_ContentAttachmentENS.TableNameKey, //主表主键值
OrderNum = objtz_ContentAttachmentENS.OrderNum, //序号
AttachmentTitle = objtz_ContentAttachmentENS.AttachmentTitle, //附件标题
IdResourceType = objtz_ContentAttachmentENS.IdResourceType, //资源类型流水号
TextContent = objtz_ContentAttachmentENS.TextContent, //文本内容
FileName = objtz_ContentAttachmentENS.FileName, //文件名称
Extension = objtz_ContentAttachmentENS.Extension, //扩展名
FilePath = objtz_ContentAttachmentENS.FilePath, //文件路径
PdfFilePath = objtz_ContentAttachmentENS.PdfFilePath, //Pdf文件路径
SwfFilePath = objtz_ContentAttachmentENS.SwfFilePath, //Swf文件路径
FileSize = objtz_ContentAttachmentENS.FileSize, //文件大小
FileSizeUnit = objtz_ContentAttachmentENS.FileSizeUnit, //文件大小单位
ImageHeight = objtz_ContentAttachmentENS.ImageHeight, //图像高
ImageWidth = objtz_ContentAttachmentENS.ImageWidth, //图像宽
UploadDate = objtz_ContentAttachmentENS.UploadDate, //上传时间
UploadPerson = objtz_ContentAttachmentENS.UploadPerson, //上传人
UpdDate = objtz_ContentAttachmentENS.UpdDate, //修改日期
UpdUserId = objtz_ContentAttachmentENS.UpdUserId, //修改用户Id
Memo = objtz_ContentAttachmentENS.Memo, //备注
CourseId = objtz_ContentAttachmentENS.CourseId, //课程Id
};
 return objtz_ContentAttachmentENT;
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
public static void CheckPropertyNew(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
 clstz_ContentAttachmentBL.tz_ContentAttachmentDA.CheckPropertyNew(objtz_ContentAttachmentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
 clstz_ContentAttachmentBL.tz_ContentAttachmentDA.CheckProperty4Condition(objtz_ContentAttachmentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clstz_ContentAttachmentEN objtz_ContentAttachmentCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.mId) == true)
{
string strComparisonOpmId = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.mId];
strWhereCond += string.Format(" And {0} {2} {1}", contz_ContentAttachment.mId, objtz_ContentAttachmentCond.mId, strComparisonOpmId);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.ContentTypeId) == true)
{
string strComparisonOpContentTypeId = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.ContentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.ContentTypeId, objtz_ContentAttachmentCond.ContentTypeId, strComparisonOpContentTypeId);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.TableNameKey) == true)
{
string strComparisonOpTableNameKey = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.TableNameKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.TableNameKey, objtz_ContentAttachmentCond.TableNameKey, strComparisonOpTableNameKey);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.OrderNum) == true)
{
string strComparisonOpOrderNum = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", contz_ContentAttachment.OrderNum, objtz_ContentAttachmentCond.OrderNum, strComparisonOpOrderNum);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.AttachmentTitle) == true)
{
string strComparisonOpAttachmentTitle = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.AttachmentTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.AttachmentTitle, objtz_ContentAttachmentCond.AttachmentTitle, strComparisonOpAttachmentTitle);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.IdResourceType, objtz_ContentAttachmentCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.TextContent) == true)
{
string strComparisonOpTextContent = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.TextContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.TextContent, objtz_ContentAttachmentCond.TextContent, strComparisonOpTextContent);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.FileName) == true)
{
string strComparisonOpFileName = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.FileName, objtz_ContentAttachmentCond.FileName, strComparisonOpFileName);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.Extension) == true)
{
string strComparisonOpExtension = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.Extension];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.Extension, objtz_ContentAttachmentCond.Extension, strComparisonOpExtension);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.FilePath) == true)
{
string strComparisonOpFilePath = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.FilePath, objtz_ContentAttachmentCond.FilePath, strComparisonOpFilePath);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.PdfFilePath) == true)
{
string strComparisonOpPdfFilePath = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.PdfFilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.PdfFilePath, objtz_ContentAttachmentCond.PdfFilePath, strComparisonOpPdfFilePath);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.SwfFilePath) == true)
{
string strComparisonOpSwfFilePath = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.SwfFilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.SwfFilePath, objtz_ContentAttachmentCond.SwfFilePath, strComparisonOpSwfFilePath);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.FileSize) == true)
{
string strComparisonOpFileSize = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.FileSize];
strWhereCond += string.Format(" And {0} {2} {1}", contz_ContentAttachment.FileSize, objtz_ContentAttachmentCond.FileSize, strComparisonOpFileSize);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.FileSizeUnit) == true)
{
string strComparisonOpFileSizeUnit = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.FileSizeUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.FileSizeUnit, objtz_ContentAttachmentCond.FileSizeUnit, strComparisonOpFileSizeUnit);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.ImageHeight) == true)
{
string strComparisonOpImageHeight = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.ImageHeight];
strWhereCond += string.Format(" And {0} {2} {1}", contz_ContentAttachment.ImageHeight, objtz_ContentAttachmentCond.ImageHeight, strComparisonOpImageHeight);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.ImageWidth) == true)
{
string strComparisonOpImageWidth = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.ImageWidth];
strWhereCond += string.Format(" And {0} {2} {1}", contz_ContentAttachment.ImageWidth, objtz_ContentAttachmentCond.ImageWidth, strComparisonOpImageWidth);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.UploadDate) == true)
{
string strComparisonOpUploadDate = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.UploadDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.UploadDate, objtz_ContentAttachmentCond.UploadDate, strComparisonOpUploadDate);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.UploadPerson) == true)
{
string strComparisonOpUploadPerson = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.UploadPerson];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.UploadPerson, objtz_ContentAttachmentCond.UploadPerson, strComparisonOpUploadPerson);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.UpdDate) == true)
{
string strComparisonOpUpdDate = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.UpdDate, objtz_ContentAttachmentCond.UpdDate, strComparisonOpUpdDate);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.UpdUserId, objtz_ContentAttachmentCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.Memo) == true)
{
string strComparisonOpMemo = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.Memo, objtz_ContentAttachmentCond.Memo, strComparisonOpMemo);
}
if (objtz_ContentAttachmentCond.IsUpdated(contz_ContentAttachment.CourseId) == true)
{
string strComparisonOpCourseId = objtz_ContentAttachmentCond.dicFldComparisonOp[contz_ContentAttachment.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_ContentAttachment.CourseId, objtz_ContentAttachmentCond.CourseId, strComparisonOpCourseId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--tz_ContentAttachment(内容附件), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:AttachmentTitle_ContentTypeId_TableNameKey
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objtz_ContentAttachmentEN == null) return true;
if (objtz_ContentAttachmentEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ContentTypeId = '{0}'", objtz_ContentAttachmentEN.ContentTypeId);
 sbCondition.AppendFormat(" and TableNameKey = '{0}'", objtz_ContentAttachmentEN.TableNameKey);
 if (objtz_ContentAttachmentEN.AttachmentTitle == null)
{
 sbCondition.AppendFormat(" and AttachmentTitle is null", objtz_ContentAttachmentEN.AttachmentTitle);
}
else
{
 sbCondition.AppendFormat(" and AttachmentTitle = '{0}'", objtz_ContentAttachmentEN.AttachmentTitle);
}
if (clstz_ContentAttachmentBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objtz_ContentAttachmentEN.mId);
 sbCondition.AppendFormat(" and ContentTypeId = '{0}'", objtz_ContentAttachmentEN.ContentTypeId);
 sbCondition.AppendFormat(" and TableNameKey = '{0}'", objtz_ContentAttachmentEN.TableNameKey);
 sbCondition.AppendFormat(" and AttachmentTitle = '{0}'", objtz_ContentAttachmentEN.AttachmentTitle);
if (clstz_ContentAttachmentBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--tz_ContentAttachment(内容附件), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:AttachmentTitle_ContentTypeId_TableNameKey
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objtz_ContentAttachmentEN == null) return "";
if (objtz_ContentAttachmentEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ContentTypeId = '{0}'", objtz_ContentAttachmentEN.ContentTypeId);
 sbCondition.AppendFormat(" and TableNameKey = '{0}'", objtz_ContentAttachmentEN.TableNameKey);
 if (objtz_ContentAttachmentEN.AttachmentTitle == null)
{
 sbCondition.AppendFormat(" and AttachmentTitle is null", objtz_ContentAttachmentEN.AttachmentTitle);
}
else
{
 sbCondition.AppendFormat(" and AttachmentTitle = '{0}'", objtz_ContentAttachmentEN.AttachmentTitle);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objtz_ContentAttachmentEN.mId);
 sbCondition.AppendFormat(" and ContentTypeId = '{0}'", objtz_ContentAttachmentEN.ContentTypeId);
 sbCondition.AppendFormat(" and TableNameKey = '{0}'", objtz_ContentAttachmentEN.TableNameKey);
 sbCondition.AppendFormat(" and AttachmentTitle = '{0}'", objtz_ContentAttachmentEN.AttachmentTitle);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_tz_ContentAttachment
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 内容附件(tz_ContentAttachment)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clstz_ContentAttachmentBL
{
public static RelatedActions_tz_ContentAttachment relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clstz_ContentAttachmentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clstz_ContentAttachmentDA tz_ContentAttachmentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clstz_ContentAttachmentDA();
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
 public clstz_ContentAttachmentBL()
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
if (string.IsNullOrEmpty(clstz_ContentAttachmentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clstz_ContentAttachmentEN._ConnectString);
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
public static DataTable GetDataTable_tz_ContentAttachment(string strWhereCond)
{
DataTable objDT;
try
{
objDT = tz_ContentAttachmentDA.GetDataTable_tz_ContentAttachment(strWhereCond);
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
objDT = tz_ContentAttachmentDA.GetDataTable(strWhereCond);
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
objDT = tz_ContentAttachmentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = tz_ContentAttachmentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = tz_ContentAttachmentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = tz_ContentAttachmentDA.GetDataTable_Top(objTopPara);
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
objDT = tz_ContentAttachmentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = tz_ContentAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = tz_ContentAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clstz_ContentAttachmentEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clstz_ContentAttachmentEN> arrObjLst = new List<clstz_ContentAttachmentEN>(); 
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
	clstz_ContentAttachmentEN objtz_ContentAttachmentEN = new clstz_ContentAttachmentEN();
try
{
objtz_ContentAttachmentEN.mId = Int32.Parse(objRow[contz_ContentAttachment.mId].ToString().Trim()); //mId
objtz_ContentAttachmentEN.ContentTypeId = objRow[contz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objtz_ContentAttachmentEN.TableNameKey = objRow[contz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objtz_ContentAttachmentEN.OrderNum = objRow[contz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objtz_ContentAttachmentEN.AttachmentTitle = objRow[contz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[contz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objtz_ContentAttachmentEN.IdResourceType = objRow[contz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objtz_ContentAttachmentEN.TextContent = objRow[contz_ContentAttachment.TextContent] == DBNull.Value ? null : objRow[contz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objtz_ContentAttachmentEN.FileName = objRow[contz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objtz_ContentAttachmentEN.Extension = objRow[contz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[contz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objtz_ContentAttachmentEN.FilePath = objRow[contz_ContentAttachment.FilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objtz_ContentAttachmentEN.PdfFilePath = objRow[contz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objtz_ContentAttachmentEN.SwfFilePath = objRow[contz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objtz_ContentAttachmentEN.FileSize = objRow[contz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[contz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objtz_ContentAttachmentEN.FileSizeUnit = objRow[contz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objtz_ContentAttachmentEN.ImageHeight = objRow[contz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objtz_ContentAttachmentEN.ImageWidth = objRow[contz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objtz_ContentAttachmentEN.UploadDate = objRow[contz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objtz_ContentAttachmentEN.UploadPerson = objRow[contz_ContentAttachment.UploadPerson] == DBNull.Value ? null : objRow[contz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objtz_ContentAttachmentEN.UpdDate = objRow[contz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objtz_ContentAttachmentEN.UpdUserId = objRow[contz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[contz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objtz_ContentAttachmentEN.Memo = objRow[contz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[contz_ContentAttachment.Memo].ToString().Trim(); //备注
objtz_ContentAttachmentEN.CourseId = objRow[contz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[contz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_ContentAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clstz_ContentAttachmentEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clstz_ContentAttachmentEN._CurrTabName, strCourseId);
List<clstz_ContentAttachmentEN> arrtz_ContentAttachmentObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clstz_ContentAttachmentEN> arrtz_ContentAttachmentObjLst_Sel =
arrtz_ContentAttachmentObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrtz_ContentAttachmentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clstz_ContentAttachmentEN> GetObjLst(string strWhereCond)
{
List<clstz_ContentAttachmentEN> arrObjLst = new List<clstz_ContentAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_ContentAttachmentEN objtz_ContentAttachmentEN = new clstz_ContentAttachmentEN();
try
{
objtz_ContentAttachmentEN.mId = Int32.Parse(objRow[contz_ContentAttachment.mId].ToString().Trim()); //mId
objtz_ContentAttachmentEN.ContentTypeId = objRow[contz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objtz_ContentAttachmentEN.TableNameKey = objRow[contz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objtz_ContentAttachmentEN.OrderNum = objRow[contz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objtz_ContentAttachmentEN.AttachmentTitle = objRow[contz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[contz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objtz_ContentAttachmentEN.IdResourceType = objRow[contz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objtz_ContentAttachmentEN.TextContent = objRow[contz_ContentAttachment.TextContent] == DBNull.Value ? null : objRow[contz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objtz_ContentAttachmentEN.FileName = objRow[contz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objtz_ContentAttachmentEN.Extension = objRow[contz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[contz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objtz_ContentAttachmentEN.FilePath = objRow[contz_ContentAttachment.FilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objtz_ContentAttachmentEN.PdfFilePath = objRow[contz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objtz_ContentAttachmentEN.SwfFilePath = objRow[contz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objtz_ContentAttachmentEN.FileSize = objRow[contz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[contz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objtz_ContentAttachmentEN.FileSizeUnit = objRow[contz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objtz_ContentAttachmentEN.ImageHeight = objRow[contz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objtz_ContentAttachmentEN.ImageWidth = objRow[contz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objtz_ContentAttachmentEN.UploadDate = objRow[contz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objtz_ContentAttachmentEN.UploadPerson = objRow[contz_ContentAttachment.UploadPerson] == DBNull.Value ? null : objRow[contz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objtz_ContentAttachmentEN.UpdDate = objRow[contz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objtz_ContentAttachmentEN.UpdUserId = objRow[contz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[contz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objtz_ContentAttachmentEN.Memo = objRow[contz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[contz_ContentAttachment.Memo].ToString().Trim(); //备注
objtz_ContentAttachmentEN.CourseId = objRow[contz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[contz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_ContentAttachmentEN);
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
public static List<clstz_ContentAttachmentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clstz_ContentAttachmentEN> arrObjLst = new List<clstz_ContentAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_ContentAttachmentEN objtz_ContentAttachmentEN = new clstz_ContentAttachmentEN();
try
{
objtz_ContentAttachmentEN.mId = Int32.Parse(objRow[contz_ContentAttachment.mId].ToString().Trim()); //mId
objtz_ContentAttachmentEN.ContentTypeId = objRow[contz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objtz_ContentAttachmentEN.TableNameKey = objRow[contz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objtz_ContentAttachmentEN.OrderNum = objRow[contz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objtz_ContentAttachmentEN.AttachmentTitle = objRow[contz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[contz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objtz_ContentAttachmentEN.IdResourceType = objRow[contz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objtz_ContentAttachmentEN.TextContent = objRow[contz_ContentAttachment.TextContent] == DBNull.Value ? null : objRow[contz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objtz_ContentAttachmentEN.FileName = objRow[contz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objtz_ContentAttachmentEN.Extension = objRow[contz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[contz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objtz_ContentAttachmentEN.FilePath = objRow[contz_ContentAttachment.FilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objtz_ContentAttachmentEN.PdfFilePath = objRow[contz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objtz_ContentAttachmentEN.SwfFilePath = objRow[contz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objtz_ContentAttachmentEN.FileSize = objRow[contz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[contz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objtz_ContentAttachmentEN.FileSizeUnit = objRow[contz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objtz_ContentAttachmentEN.ImageHeight = objRow[contz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objtz_ContentAttachmentEN.ImageWidth = objRow[contz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objtz_ContentAttachmentEN.UploadDate = objRow[contz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objtz_ContentAttachmentEN.UploadPerson = objRow[contz_ContentAttachment.UploadPerson] == DBNull.Value ? null : objRow[contz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objtz_ContentAttachmentEN.UpdDate = objRow[contz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objtz_ContentAttachmentEN.UpdUserId = objRow[contz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[contz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objtz_ContentAttachmentEN.Memo = objRow[contz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[contz_ContentAttachment.Memo].ToString().Trim(); //备注
objtz_ContentAttachmentEN.CourseId = objRow[contz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[contz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_ContentAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clstz_ContentAttachmentEN> GetSubObjLstCache(clstz_ContentAttachmentEN objtz_ContentAttachmentCond)
{
 string strCourseId = objtz_ContentAttachmentCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clstz_ContentAttachmentBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clstz_ContentAttachmentEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clstz_ContentAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in contz_ContentAttachment.AttributeName)
{
if (objtz_ContentAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objtz_ContentAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objtz_ContentAttachmentCond[strFldName].ToString());
}
else
{
if (objtz_ContentAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objtz_ContentAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objtz_ContentAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objtz_ContentAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objtz_ContentAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objtz_ContentAttachmentCond[strFldName]));
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
public static List<clstz_ContentAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clstz_ContentAttachmentEN> arrObjLst = new List<clstz_ContentAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_ContentAttachmentEN objtz_ContentAttachmentEN = new clstz_ContentAttachmentEN();
try
{
objtz_ContentAttachmentEN.mId = Int32.Parse(objRow[contz_ContentAttachment.mId].ToString().Trim()); //mId
objtz_ContentAttachmentEN.ContentTypeId = objRow[contz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objtz_ContentAttachmentEN.TableNameKey = objRow[contz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objtz_ContentAttachmentEN.OrderNum = objRow[contz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objtz_ContentAttachmentEN.AttachmentTitle = objRow[contz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[contz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objtz_ContentAttachmentEN.IdResourceType = objRow[contz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objtz_ContentAttachmentEN.TextContent = objRow[contz_ContentAttachment.TextContent] == DBNull.Value ? null : objRow[contz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objtz_ContentAttachmentEN.FileName = objRow[contz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objtz_ContentAttachmentEN.Extension = objRow[contz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[contz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objtz_ContentAttachmentEN.FilePath = objRow[contz_ContentAttachment.FilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objtz_ContentAttachmentEN.PdfFilePath = objRow[contz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objtz_ContentAttachmentEN.SwfFilePath = objRow[contz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objtz_ContentAttachmentEN.FileSize = objRow[contz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[contz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objtz_ContentAttachmentEN.FileSizeUnit = objRow[contz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objtz_ContentAttachmentEN.ImageHeight = objRow[contz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objtz_ContentAttachmentEN.ImageWidth = objRow[contz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objtz_ContentAttachmentEN.UploadDate = objRow[contz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objtz_ContentAttachmentEN.UploadPerson = objRow[contz_ContentAttachment.UploadPerson] == DBNull.Value ? null : objRow[contz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objtz_ContentAttachmentEN.UpdDate = objRow[contz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objtz_ContentAttachmentEN.UpdUserId = objRow[contz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[contz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objtz_ContentAttachmentEN.Memo = objRow[contz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[contz_ContentAttachment.Memo].ToString().Trim(); //备注
objtz_ContentAttachmentEN.CourseId = objRow[contz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[contz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_ContentAttachmentEN);
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
public static List<clstz_ContentAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clstz_ContentAttachmentEN> arrObjLst = new List<clstz_ContentAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_ContentAttachmentEN objtz_ContentAttachmentEN = new clstz_ContentAttachmentEN();
try
{
objtz_ContentAttachmentEN.mId = Int32.Parse(objRow[contz_ContentAttachment.mId].ToString().Trim()); //mId
objtz_ContentAttachmentEN.ContentTypeId = objRow[contz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objtz_ContentAttachmentEN.TableNameKey = objRow[contz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objtz_ContentAttachmentEN.OrderNum = objRow[contz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objtz_ContentAttachmentEN.AttachmentTitle = objRow[contz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[contz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objtz_ContentAttachmentEN.IdResourceType = objRow[contz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objtz_ContentAttachmentEN.TextContent = objRow[contz_ContentAttachment.TextContent] == DBNull.Value ? null : objRow[contz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objtz_ContentAttachmentEN.FileName = objRow[contz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objtz_ContentAttachmentEN.Extension = objRow[contz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[contz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objtz_ContentAttachmentEN.FilePath = objRow[contz_ContentAttachment.FilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objtz_ContentAttachmentEN.PdfFilePath = objRow[contz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objtz_ContentAttachmentEN.SwfFilePath = objRow[contz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objtz_ContentAttachmentEN.FileSize = objRow[contz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[contz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objtz_ContentAttachmentEN.FileSizeUnit = objRow[contz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objtz_ContentAttachmentEN.ImageHeight = objRow[contz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objtz_ContentAttachmentEN.ImageWidth = objRow[contz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objtz_ContentAttachmentEN.UploadDate = objRow[contz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objtz_ContentAttachmentEN.UploadPerson = objRow[contz_ContentAttachment.UploadPerson] == DBNull.Value ? null : objRow[contz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objtz_ContentAttachmentEN.UpdDate = objRow[contz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objtz_ContentAttachmentEN.UpdUserId = objRow[contz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[contz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objtz_ContentAttachmentEN.Memo = objRow[contz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[contz_ContentAttachment.Memo].ToString().Trim(); //备注
objtz_ContentAttachmentEN.CourseId = objRow[contz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[contz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_ContentAttachmentEN);
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
List<clstz_ContentAttachmentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clstz_ContentAttachmentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clstz_ContentAttachmentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clstz_ContentAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clstz_ContentAttachmentEN> arrObjLst = new List<clstz_ContentAttachmentEN>(); 
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
	clstz_ContentAttachmentEN objtz_ContentAttachmentEN = new clstz_ContentAttachmentEN();
try
{
objtz_ContentAttachmentEN.mId = Int32.Parse(objRow[contz_ContentAttachment.mId].ToString().Trim()); //mId
objtz_ContentAttachmentEN.ContentTypeId = objRow[contz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objtz_ContentAttachmentEN.TableNameKey = objRow[contz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objtz_ContentAttachmentEN.OrderNum = objRow[contz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objtz_ContentAttachmentEN.AttachmentTitle = objRow[contz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[contz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objtz_ContentAttachmentEN.IdResourceType = objRow[contz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objtz_ContentAttachmentEN.TextContent = objRow[contz_ContentAttachment.TextContent] == DBNull.Value ? null : objRow[contz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objtz_ContentAttachmentEN.FileName = objRow[contz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objtz_ContentAttachmentEN.Extension = objRow[contz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[contz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objtz_ContentAttachmentEN.FilePath = objRow[contz_ContentAttachment.FilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objtz_ContentAttachmentEN.PdfFilePath = objRow[contz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objtz_ContentAttachmentEN.SwfFilePath = objRow[contz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objtz_ContentAttachmentEN.FileSize = objRow[contz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[contz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objtz_ContentAttachmentEN.FileSizeUnit = objRow[contz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objtz_ContentAttachmentEN.ImageHeight = objRow[contz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objtz_ContentAttachmentEN.ImageWidth = objRow[contz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objtz_ContentAttachmentEN.UploadDate = objRow[contz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objtz_ContentAttachmentEN.UploadPerson = objRow[contz_ContentAttachment.UploadPerson] == DBNull.Value ? null : objRow[contz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objtz_ContentAttachmentEN.UpdDate = objRow[contz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objtz_ContentAttachmentEN.UpdUserId = objRow[contz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[contz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objtz_ContentAttachmentEN.Memo = objRow[contz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[contz_ContentAttachment.Memo].ToString().Trim(); //备注
objtz_ContentAttachmentEN.CourseId = objRow[contz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[contz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_ContentAttachmentEN);
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
public static List<clstz_ContentAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clstz_ContentAttachmentEN> arrObjLst = new List<clstz_ContentAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_ContentAttachmentEN objtz_ContentAttachmentEN = new clstz_ContentAttachmentEN();
try
{
objtz_ContentAttachmentEN.mId = Int32.Parse(objRow[contz_ContentAttachment.mId].ToString().Trim()); //mId
objtz_ContentAttachmentEN.ContentTypeId = objRow[contz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objtz_ContentAttachmentEN.TableNameKey = objRow[contz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objtz_ContentAttachmentEN.OrderNum = objRow[contz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objtz_ContentAttachmentEN.AttachmentTitle = objRow[contz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[contz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objtz_ContentAttachmentEN.IdResourceType = objRow[contz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objtz_ContentAttachmentEN.TextContent = objRow[contz_ContentAttachment.TextContent] == DBNull.Value ? null : objRow[contz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objtz_ContentAttachmentEN.FileName = objRow[contz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objtz_ContentAttachmentEN.Extension = objRow[contz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[contz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objtz_ContentAttachmentEN.FilePath = objRow[contz_ContentAttachment.FilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objtz_ContentAttachmentEN.PdfFilePath = objRow[contz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objtz_ContentAttachmentEN.SwfFilePath = objRow[contz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objtz_ContentAttachmentEN.FileSize = objRow[contz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[contz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objtz_ContentAttachmentEN.FileSizeUnit = objRow[contz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objtz_ContentAttachmentEN.ImageHeight = objRow[contz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objtz_ContentAttachmentEN.ImageWidth = objRow[contz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objtz_ContentAttachmentEN.UploadDate = objRow[contz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objtz_ContentAttachmentEN.UploadPerson = objRow[contz_ContentAttachment.UploadPerson] == DBNull.Value ? null : objRow[contz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objtz_ContentAttachmentEN.UpdDate = objRow[contz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objtz_ContentAttachmentEN.UpdUserId = objRow[contz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[contz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objtz_ContentAttachmentEN.Memo = objRow[contz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[contz_ContentAttachment.Memo].ToString().Trim(); //备注
objtz_ContentAttachmentEN.CourseId = objRow[contz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[contz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_ContentAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clstz_ContentAttachmentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clstz_ContentAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clstz_ContentAttachmentEN> arrObjLst = new List<clstz_ContentAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_ContentAttachmentEN objtz_ContentAttachmentEN = new clstz_ContentAttachmentEN();
try
{
objtz_ContentAttachmentEN.mId = Int32.Parse(objRow[contz_ContentAttachment.mId].ToString().Trim()); //mId
objtz_ContentAttachmentEN.ContentTypeId = objRow[contz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objtz_ContentAttachmentEN.TableNameKey = objRow[contz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objtz_ContentAttachmentEN.OrderNum = objRow[contz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objtz_ContentAttachmentEN.AttachmentTitle = objRow[contz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[contz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objtz_ContentAttachmentEN.IdResourceType = objRow[contz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objtz_ContentAttachmentEN.TextContent = objRow[contz_ContentAttachment.TextContent] == DBNull.Value ? null : objRow[contz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objtz_ContentAttachmentEN.FileName = objRow[contz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objtz_ContentAttachmentEN.Extension = objRow[contz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[contz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objtz_ContentAttachmentEN.FilePath = objRow[contz_ContentAttachment.FilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objtz_ContentAttachmentEN.PdfFilePath = objRow[contz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objtz_ContentAttachmentEN.SwfFilePath = objRow[contz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objtz_ContentAttachmentEN.FileSize = objRow[contz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[contz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objtz_ContentAttachmentEN.FileSizeUnit = objRow[contz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objtz_ContentAttachmentEN.ImageHeight = objRow[contz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objtz_ContentAttachmentEN.ImageWidth = objRow[contz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objtz_ContentAttachmentEN.UploadDate = objRow[contz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objtz_ContentAttachmentEN.UploadPerson = objRow[contz_ContentAttachment.UploadPerson] == DBNull.Value ? null : objRow[contz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objtz_ContentAttachmentEN.UpdDate = objRow[contz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objtz_ContentAttachmentEN.UpdUserId = objRow[contz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[contz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objtz_ContentAttachmentEN.Memo = objRow[contz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[contz_ContentAttachment.Memo].ToString().Trim(); //备注
objtz_ContentAttachmentEN.CourseId = objRow[contz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[contz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_ContentAttachmentEN);
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
public static List<clstz_ContentAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clstz_ContentAttachmentEN> arrObjLst = new List<clstz_ContentAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_ContentAttachmentEN objtz_ContentAttachmentEN = new clstz_ContentAttachmentEN();
try
{
objtz_ContentAttachmentEN.mId = Int32.Parse(objRow[contz_ContentAttachment.mId].ToString().Trim()); //mId
objtz_ContentAttachmentEN.ContentTypeId = objRow[contz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objtz_ContentAttachmentEN.TableNameKey = objRow[contz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objtz_ContentAttachmentEN.OrderNum = objRow[contz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objtz_ContentAttachmentEN.AttachmentTitle = objRow[contz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[contz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objtz_ContentAttachmentEN.IdResourceType = objRow[contz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objtz_ContentAttachmentEN.TextContent = objRow[contz_ContentAttachment.TextContent] == DBNull.Value ? null : objRow[contz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objtz_ContentAttachmentEN.FileName = objRow[contz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objtz_ContentAttachmentEN.Extension = objRow[contz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[contz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objtz_ContentAttachmentEN.FilePath = objRow[contz_ContentAttachment.FilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objtz_ContentAttachmentEN.PdfFilePath = objRow[contz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objtz_ContentAttachmentEN.SwfFilePath = objRow[contz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objtz_ContentAttachmentEN.FileSize = objRow[contz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[contz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objtz_ContentAttachmentEN.FileSizeUnit = objRow[contz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objtz_ContentAttachmentEN.ImageHeight = objRow[contz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objtz_ContentAttachmentEN.ImageWidth = objRow[contz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objtz_ContentAttachmentEN.UploadDate = objRow[contz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objtz_ContentAttachmentEN.UploadPerson = objRow[contz_ContentAttachment.UploadPerson] == DBNull.Value ? null : objRow[contz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objtz_ContentAttachmentEN.UpdDate = objRow[contz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objtz_ContentAttachmentEN.UpdUserId = objRow[contz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[contz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objtz_ContentAttachmentEN.Memo = objRow[contz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[contz_ContentAttachment.Memo].ToString().Trim(); //备注
objtz_ContentAttachmentEN.CourseId = objRow[contz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[contz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_ContentAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clstz_ContentAttachmentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clstz_ContentAttachmentEN> arrObjLst = new List<clstz_ContentAttachmentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clstz_ContentAttachmentEN objtz_ContentAttachmentEN = new clstz_ContentAttachmentEN();
try
{
objtz_ContentAttachmentEN.mId = Int32.Parse(objRow[contz_ContentAttachment.mId].ToString().Trim()); //mId
objtz_ContentAttachmentEN.ContentTypeId = objRow[contz_ContentAttachment.ContentTypeId].ToString().Trim(); //内容类型Id
objtz_ContentAttachmentEN.TableNameKey = objRow[contz_ContentAttachment.TableNameKey].ToString().Trim(); //主表主键值
objtz_ContentAttachmentEN.OrderNum = objRow[contz_ContentAttachment.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.OrderNum].ToString().Trim()); //序号
objtz_ContentAttachmentEN.AttachmentTitle = objRow[contz_ContentAttachment.AttachmentTitle] == DBNull.Value ? null : objRow[contz_ContentAttachment.AttachmentTitle].ToString().Trim(); //附件标题
objtz_ContentAttachmentEN.IdResourceType = objRow[contz_ContentAttachment.IdResourceType].ToString().Trim(); //资源类型流水号
objtz_ContentAttachmentEN.TextContent = objRow[contz_ContentAttachment.TextContent] == DBNull.Value ? null : objRow[contz_ContentAttachment.TextContent].ToString().Trim(); //文本内容
objtz_ContentAttachmentEN.FileName = objRow[contz_ContentAttachment.FileName] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileName].ToString().Trim(); //文件名称
objtz_ContentAttachmentEN.Extension = objRow[contz_ContentAttachment.Extension] == DBNull.Value ? null : objRow[contz_ContentAttachment.Extension].ToString().Trim(); //扩展名
objtz_ContentAttachmentEN.FilePath = objRow[contz_ContentAttachment.FilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.FilePath].ToString().Trim(); //文件路径
objtz_ContentAttachmentEN.PdfFilePath = objRow[contz_ContentAttachment.PdfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.PdfFilePath].ToString().Trim(); //Pdf文件路径
objtz_ContentAttachmentEN.SwfFilePath = objRow[contz_ContentAttachment.SwfFilePath] == DBNull.Value ? null : objRow[contz_ContentAttachment.SwfFilePath].ToString().Trim(); //Swf文件路径
objtz_ContentAttachmentEN.FileSize = objRow[contz_ContentAttachment.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[contz_ContentAttachment.FileSize].ToString().Trim()); //文件大小
objtz_ContentAttachmentEN.FileSizeUnit = objRow[contz_ContentAttachment.FileSizeUnit] == DBNull.Value ? null : objRow[contz_ContentAttachment.FileSizeUnit].ToString().Trim(); //文件大小单位
objtz_ContentAttachmentEN.ImageHeight = objRow[contz_ContentAttachment.ImageHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageHeight].ToString().Trim()); //图像高
objtz_ContentAttachmentEN.ImageWidth = objRow[contz_ContentAttachment.ImageWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[contz_ContentAttachment.ImageWidth].ToString().Trim()); //图像宽
objtz_ContentAttachmentEN.UploadDate = objRow[contz_ContentAttachment.UploadDate].ToString().Trim(); //上传时间
objtz_ContentAttachmentEN.UploadPerson = objRow[contz_ContentAttachment.UploadPerson] == DBNull.Value ? null : objRow[contz_ContentAttachment.UploadPerson].ToString().Trim(); //上传人
objtz_ContentAttachmentEN.UpdDate = objRow[contz_ContentAttachment.UpdDate].ToString().Trim(); //修改日期
objtz_ContentAttachmentEN.UpdUserId = objRow[contz_ContentAttachment.UpdUserId] == DBNull.Value ? null : objRow[contz_ContentAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objtz_ContentAttachmentEN.Memo = objRow[contz_ContentAttachment.Memo] == DBNull.Value ? null : objRow[contz_ContentAttachment.Memo].ToString().Trim(); //备注
objtz_ContentAttachmentEN.CourseId = objRow[contz_ContentAttachment.CourseId] == DBNull.Value ? null : objRow[contz_ContentAttachment.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objtz_ContentAttachmentEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objtz_ContentAttachmentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Gettz_ContentAttachment(ref clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
bool bolResult = tz_ContentAttachmentDA.Gettz_ContentAttachment(ref objtz_ContentAttachmentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clstz_ContentAttachmentEN GetObjBymId(long lngmId)
{
clstz_ContentAttachmentEN objtz_ContentAttachmentEN = tz_ContentAttachmentDA.GetObjBymId(lngmId);
return objtz_ContentAttachmentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clstz_ContentAttachmentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clstz_ContentAttachmentEN objtz_ContentAttachmentEN = tz_ContentAttachmentDA.GetFirstObj(strWhereCond);
 return objtz_ContentAttachmentEN;
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
public static clstz_ContentAttachmentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clstz_ContentAttachmentEN objtz_ContentAttachmentEN = tz_ContentAttachmentDA.GetObjByDataRow(objRow);
 return objtz_ContentAttachmentEN;
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
public static clstz_ContentAttachmentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clstz_ContentAttachmentEN objtz_ContentAttachmentEN = tz_ContentAttachmentDA.GetObjByDataRow(objRow);
 return objtz_ContentAttachmentEN;
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
 /// <param name = "lsttz_ContentAttachmentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clstz_ContentAttachmentEN GetObjBymIdFromList(long lngmId, List<clstz_ContentAttachmentEN> lsttz_ContentAttachmentObjLst)
{
foreach (clstz_ContentAttachmentEN objtz_ContentAttachmentEN in lsttz_ContentAttachmentObjLst)
{
if (objtz_ContentAttachmentEN.mId == lngmId)
{
return objtz_ContentAttachmentEN;
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
 lngmId = new clstz_ContentAttachmentDA().GetFirstID(strWhereCond);
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
 arrList = tz_ContentAttachmentDA.GetID(strWhereCond);
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
bool bolIsExist = tz_ContentAttachmentDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = tz_ContentAttachmentDA.IsExist(lngmId);
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
 bolIsExist = clstz_ContentAttachmentDA.IsExistTable();
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
 bolIsExist = tz_ContentAttachmentDA.IsExistTable(strTabName);
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
 /// <param name = "objtz_ContentAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clstz_ContentAttachmentEN objtz_ContentAttachmentEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objtz_ContentAttachmentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!内容类型Id = [{0}],主表主键值 = [{1}],附件标题 = [{2}]的数据已经存在!(in clstz_ContentAttachmentBL.AddNewRecordBySql2)", objtz_ContentAttachmentEN.ContentTypeId,objtz_ContentAttachmentEN.TableNameKey,objtz_ContentAttachmentEN.AttachmentTitle);
throw new Exception(strMsg);
}
try
{
bool bolResult = tz_ContentAttachmentDA.AddNewRecordBySQL2(objtz_ContentAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_ContentAttachmentBL.ReFreshCache(objtz_ContentAttachmentEN.CourseId);

if (clstz_ContentAttachmentBL.relatedActions != null)
{
clstz_ContentAttachmentBL.relatedActions.UpdRelaTabDate(objtz_ContentAttachmentEN.mId, objtz_ContentAttachmentEN.UpdUserId);
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
 /// <param name = "objtz_ContentAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clstz_ContentAttachmentEN objtz_ContentAttachmentEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objtz_ContentAttachmentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!内容类型Id = [{0}],主表主键值 = [{1}],附件标题 = [{2}]的数据已经存在!(in clstz_ContentAttachmentBL.AddNewRecordBySql2WithReturnKey)", objtz_ContentAttachmentEN.ContentTypeId,objtz_ContentAttachmentEN.TableNameKey,objtz_ContentAttachmentEN.AttachmentTitle);
throw new Exception(strMsg);
}
try
{
string strKey = tz_ContentAttachmentDA.AddNewRecordBySQL2WithReturnKey(objtz_ContentAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_ContentAttachmentBL.ReFreshCache(objtz_ContentAttachmentEN.CourseId);

if (clstz_ContentAttachmentBL.relatedActions != null)
{
clstz_ContentAttachmentBL.relatedActions.UpdRelaTabDate(objtz_ContentAttachmentEN.mId, objtz_ContentAttachmentEN.UpdUserId);
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
 /// <param name = "objtz_ContentAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
try
{
bool bolResult = tz_ContentAttachmentDA.Update(objtz_ContentAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_ContentAttachmentBL.ReFreshCache(objtz_ContentAttachmentEN.CourseId);

if (clstz_ContentAttachmentBL.relatedActions != null)
{
clstz_ContentAttachmentBL.relatedActions.UpdRelaTabDate(objtz_ContentAttachmentEN.mId, objtz_ContentAttachmentEN.UpdUserId);
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
 /// <param name = "objtz_ContentAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
 if (objtz_ContentAttachmentEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = tz_ContentAttachmentDA.UpdateBySql2(objtz_ContentAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_ContentAttachmentBL.ReFreshCache(objtz_ContentAttachmentEN.CourseId);

if (clstz_ContentAttachmentBL.relatedActions != null)
{
clstz_ContentAttachmentBL.relatedActions.UpdRelaTabDate(objtz_ContentAttachmentEN.mId, objtz_ContentAttachmentEN.UpdUserId);
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngmId)
{
try
{
 clstz_ContentAttachmentEN objtz_ContentAttachmentEN = clstz_ContentAttachmentBL.GetObjBymId(lngmId);

if (clstz_ContentAttachmentBL.relatedActions != null)
{
clstz_ContentAttachmentBL.relatedActions.UpdRelaTabDate(objtz_ContentAttachmentEN.mId, objtz_ContentAttachmentEN.UpdUserId);
}
if (objtz_ContentAttachmentEN != null)
{
int intRecNum = tz_ContentAttachmentDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objtz_ContentAttachmentEN.CourseId);
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
/// <param name="lngmId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
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
//删除与表:[tz_ContentAttachment]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//contz_ContentAttachment.mId,
//lngmId);
//        clstz_ContentAttachmentBL.Deltz_ContentAttachmentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clstz_ContentAttachmentBL.DelRecord(lngmId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clstz_ContentAttachmentBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngmId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clstz_ContentAttachmentBL.relatedActions != null)
{
clstz_ContentAttachmentBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = tz_ContentAttachmentDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strCourseId);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Deltz_ContentAttachments(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clstz_ContentAttachmentBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clstz_ContentAttachmentBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clstz_ContentAttachmentEN objtz_ContentAttachmentEN = clstz_ContentAttachmentBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = tz_ContentAttachmentDA.Deltz_ContentAttachment(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objtz_ContentAttachmentEN.CourseId);
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
public static int Deltz_ContentAttachmentsByCond(string strWhereCond)
{
try
{
if (clstz_ContentAttachmentBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clstz_ContentAttachmentBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(contz_ContentAttachment.CourseId, strWhereCond);
int intRecNum = tz_ContentAttachmentDA.Deltz_ContentAttachment(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrCourseId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[tz_ContentAttachment]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clstz_ContentAttachmentDA.GetSpecSQLObj();
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
//删除与表:[tz_ContentAttachment]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clstz_ContentAttachmentBL.DelRecord(lngmId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clstz_ContentAttachmentBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
objtz_ContentAttachmentENT.IdResourceType = objtz_ContentAttachmentENS.IdResourceType; //资源类型流水号
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
 /// <param name = "objtz_ContentAttachmentEN">源简化对象</param>
 public static void SetUpdFlag(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
try
{
objtz_ContentAttachmentEN.ClearUpdateState();
   string strsfUpdFldSetStr = objtz_ContentAttachmentEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(contz_ContentAttachment.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.mId = objtz_ContentAttachmentEN.mId; //mId
}
if (arrFldSet.Contains(contz_ContentAttachment.ContentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.ContentTypeId = objtz_ContentAttachmentEN.ContentTypeId; //内容类型Id
}
if (arrFldSet.Contains(contz_ContentAttachment.TableNameKey, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.TableNameKey = objtz_ContentAttachmentEN.TableNameKey; //主表主键值
}
if (arrFldSet.Contains(contz_ContentAttachment.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.OrderNum = objtz_ContentAttachmentEN.OrderNum; //序号
}
if (arrFldSet.Contains(contz_ContentAttachment.AttachmentTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.AttachmentTitle = objtz_ContentAttachmentEN.AttachmentTitle == "[null]" ? null :  objtz_ContentAttachmentEN.AttachmentTitle; //附件标题
}
if (arrFldSet.Contains(contz_ContentAttachment.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.IdResourceType = objtz_ContentAttachmentEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(contz_ContentAttachment.TextContent, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.TextContent = objtz_ContentAttachmentEN.TextContent == "[null]" ? null :  objtz_ContentAttachmentEN.TextContent; //文本内容
}
if (arrFldSet.Contains(contz_ContentAttachment.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.FileName = objtz_ContentAttachmentEN.FileName == "[null]" ? null :  objtz_ContentAttachmentEN.FileName; //文件名称
}
if (arrFldSet.Contains(contz_ContentAttachment.Extension, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.Extension = objtz_ContentAttachmentEN.Extension == "[null]" ? null :  objtz_ContentAttachmentEN.Extension; //扩展名
}
if (arrFldSet.Contains(contz_ContentAttachment.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.FilePath = objtz_ContentAttachmentEN.FilePath == "[null]" ? null :  objtz_ContentAttachmentEN.FilePath; //文件路径
}
if (arrFldSet.Contains(contz_ContentAttachment.PdfFilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.PdfFilePath = objtz_ContentAttachmentEN.PdfFilePath == "[null]" ? null :  objtz_ContentAttachmentEN.PdfFilePath; //Pdf文件路径
}
if (arrFldSet.Contains(contz_ContentAttachment.SwfFilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.SwfFilePath = objtz_ContentAttachmentEN.SwfFilePath == "[null]" ? null :  objtz_ContentAttachmentEN.SwfFilePath; //Swf文件路径
}
if (arrFldSet.Contains(contz_ContentAttachment.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.FileSize = objtz_ContentAttachmentEN.FileSize; //文件大小
}
if (arrFldSet.Contains(contz_ContentAttachment.FileSizeUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.FileSizeUnit = objtz_ContentAttachmentEN.FileSizeUnit == "[null]" ? null :  objtz_ContentAttachmentEN.FileSizeUnit; //文件大小单位
}
if (arrFldSet.Contains(contz_ContentAttachment.ImageHeight, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.ImageHeight = objtz_ContentAttachmentEN.ImageHeight; //图像高
}
if (arrFldSet.Contains(contz_ContentAttachment.ImageWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.ImageWidth = objtz_ContentAttachmentEN.ImageWidth; //图像宽
}
if (arrFldSet.Contains(contz_ContentAttachment.UploadDate, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.UploadDate = objtz_ContentAttachmentEN.UploadDate; //上传时间
}
if (arrFldSet.Contains(contz_ContentAttachment.UploadPerson, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.UploadPerson = objtz_ContentAttachmentEN.UploadPerson == "[null]" ? null :  objtz_ContentAttachmentEN.UploadPerson; //上传人
}
if (arrFldSet.Contains(contz_ContentAttachment.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.UpdDate = objtz_ContentAttachmentEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(contz_ContentAttachment.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.UpdUserId = objtz_ContentAttachmentEN.UpdUserId == "[null]" ? null :  objtz_ContentAttachmentEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(contz_ContentAttachment.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.Memo = objtz_ContentAttachmentEN.Memo == "[null]" ? null :  objtz_ContentAttachmentEN.Memo; //备注
}
if (arrFldSet.Contains(contz_ContentAttachment.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objtz_ContentAttachmentEN.CourseId = objtz_ContentAttachmentEN.CourseId == "[null]" ? null :  objtz_ContentAttachmentEN.CourseId; //课程Id
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
 /// <param name = "objtz_ContentAttachmentEN">源简化对象</param>
 public static void AccessFldValueNull(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
try
{
if (objtz_ContentAttachmentEN.AttachmentTitle == "[null]") objtz_ContentAttachmentEN.AttachmentTitle = null; //附件标题
if (objtz_ContentAttachmentEN.TextContent == "[null]") objtz_ContentAttachmentEN.TextContent = null; //文本内容
if (objtz_ContentAttachmentEN.FileName == "[null]") objtz_ContentAttachmentEN.FileName = null; //文件名称
if (objtz_ContentAttachmentEN.Extension == "[null]") objtz_ContentAttachmentEN.Extension = null; //扩展名
if (objtz_ContentAttachmentEN.FilePath == "[null]") objtz_ContentAttachmentEN.FilePath = null; //文件路径
if (objtz_ContentAttachmentEN.PdfFilePath == "[null]") objtz_ContentAttachmentEN.PdfFilePath = null; //Pdf文件路径
if (objtz_ContentAttachmentEN.SwfFilePath == "[null]") objtz_ContentAttachmentEN.SwfFilePath = null; //Swf文件路径
if (objtz_ContentAttachmentEN.FileSizeUnit == "[null]") objtz_ContentAttachmentEN.FileSizeUnit = null; //文件大小单位
if (objtz_ContentAttachmentEN.UploadPerson == "[null]") objtz_ContentAttachmentEN.UploadPerson = null; //上传人
if (objtz_ContentAttachmentEN.UpdUserId == "[null]") objtz_ContentAttachmentEN.UpdUserId = null; //修改用户Id
if (objtz_ContentAttachmentEN.Memo == "[null]") objtz_ContentAttachmentEN.Memo = null; //备注
if (objtz_ContentAttachmentEN.CourseId == "[null]") objtz_ContentAttachmentEN.CourseId = null; //课程Id
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
public static void CheckPropertyNew(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
 tz_ContentAttachmentDA.CheckPropertyNew(objtz_ContentAttachmentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
 tz_ContentAttachmentDA.CheckProperty4Condition(objtz_ContentAttachmentEN);
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
if (clstz_ContentAttachmentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clstz_ContentAttachmentBL没有刷新缓存机制(clstz_ContentAttachmentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrtz_ContentAttachmentObjLstCache == null)
//{
//arrtz_ContentAttachmentObjLstCache = tz_ContentAttachmentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clstz_ContentAttachmentEN GetObjBymIdCache(long lngmId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clstz_ContentAttachmentEN._CurrTabName, strCourseId);
List<clstz_ContentAttachmentEN> arrtz_ContentAttachmentObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clstz_ContentAttachmentEN> arrtz_ContentAttachmentObjLst_Sel =
arrtz_ContentAttachmentObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrtz_ContentAttachmentObjLst_Sel.Count() == 0)
{
   clstz_ContentAttachmentEN obj = clstz_ContentAttachmentBL.GetObjBymId(lngmId);
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
return arrtz_ContentAttachmentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clstz_ContentAttachmentEN> GetAlltz_ContentAttachmentObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clstz_ContentAttachmentEN> arrtz_ContentAttachmentObjLstCache = GetObjLstCache(strCourseId); 
return arrtz_ContentAttachmentObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clstz_ContentAttachmentEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clstz_ContentAttachmentEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clstz_ContentAttachmentEN> arrtz_ContentAttachmentObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrtz_ContentAttachmentObjLstCache;
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
string strKey = string.Format("{0}_{1}", clstz_ContentAttachmentEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clstz_ContentAttachmentEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clstz_ContentAttachmentEN._RefreshTimeLst.Count == 0) return "";
return clstz_ContentAttachmentEN._RefreshTimeLst[clstz_ContentAttachmentEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("缓存分类字段:[CourseId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clstz_ContentAttachmentBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clstz_ContentAttachmentEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clstz_ContentAttachmentEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clstz_ContentAttachmentBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--tz_ContentAttachment(内容附件)
 /// 唯一性条件:AttachmentTitle_ContentTypeId_TableNameKey
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clstz_ContentAttachmentEN objtz_ContentAttachmentEN)
{
//检测记录是否存在
string strResult = tz_ContentAttachmentDA.GetUniCondStr(objtz_ContentAttachmentEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-11-13
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strCourseId)
{
if (strInFldName != contz_ContentAttachment.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (contz_ContentAttachment.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", contz_ContentAttachment.AttributeName));
throw new Exception(strMsg);
}
var objtz_ContentAttachment = clstz_ContentAttachmentBL.GetObjBymIdCache(lngmId, strCourseId);
if (objtz_ContentAttachment == null) return "";
return objtz_ContentAttachment[strOutFldName].ToString();
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
int intRecCount = clstz_ContentAttachmentDA.GetRecCount(strTabName);
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
int intRecCount = clstz_ContentAttachmentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clstz_ContentAttachmentDA.GetRecCount();
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
int intRecCount = clstz_ContentAttachmentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objtz_ContentAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clstz_ContentAttachmentEN objtz_ContentAttachmentCond)
{
 string strCourseId = objtz_ContentAttachmentCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clstz_ContentAttachmentBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clstz_ContentAttachmentEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clstz_ContentAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in contz_ContentAttachment.AttributeName)
{
if (objtz_ContentAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objtz_ContentAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objtz_ContentAttachmentCond[strFldName].ToString());
}
else
{
if (objtz_ContentAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objtz_ContentAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objtz_ContentAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objtz_ContentAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objtz_ContentAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objtz_ContentAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objtz_ContentAttachmentCond[strFldName]));
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
 List<string> arrList = clstz_ContentAttachmentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = tz_ContentAttachmentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = tz_ContentAttachmentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = tz_ContentAttachmentDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clstz_ContentAttachmentDA.SetFldValue(clstz_ContentAttachmentEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = tz_ContentAttachmentDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clstz_ContentAttachmentDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clstz_ContentAttachmentDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clstz_ContentAttachmentDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[tz_ContentAttachment] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**内容类型Id*/ 
 strCreateTabCode.Append(" ContentTypeId char(4) not Null, "); 
 // /**主表主键值*/ 
 strCreateTabCode.Append(" TableNameKey varchar(20) not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**附件标题*/ 
 strCreateTabCode.Append(" AttachmentTitle varchar(100) Null, "); 
 // /**资源类型流水号*/ 
 strCreateTabCode.Append(" IdResourceType char(4) not Null, "); 
 // /**文本内容*/ 
 strCreateTabCode.Append(" TextContent varchar(8000) Null, "); 
 // /**文件名称*/ 
 strCreateTabCode.Append(" FileName varchar(500) Null, "); 
 // /**扩展名*/ 
 strCreateTabCode.Append(" Extension varchar(10) Null, "); 
 // /**文件路径*/ 
 strCreateTabCode.Append(" FilePath varchar(500) Null, "); 
 // /**Pdf文件路径*/ 
 strCreateTabCode.Append(" PdfFilePath varchar(500) Null, "); 
 // /**Swf文件路径*/ 
 strCreateTabCode.Append(" SwfFilePath varchar(500) Null, "); 
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
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null, "); 
 // /**资源类型名称*/ 
 strCreateTabCode.Append(" ResourceTypeName varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：TableNameKey单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strTableNameKey">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strTableNameKey)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", contz_ContentAttachment.TableNameKey, strTableNameKey);
 strCondition += string.Format(" order by OrderNum ");
List<clstz_ContentAttachmentEN> arrtz_ContentAttachmentObjList = new clstz_ContentAttachmentDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clstz_ContentAttachmentEN objtz_ContentAttachment in arrtz_ContentAttachmentObjList)
{
objtz_ContentAttachment.OrderNum = intIndex;
UpdateBySql2(objtz_ContentAttachment);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。根据分类字段：TableNameKey单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="lngmId">所给的关键字</param>
/// <param name="strTableNameKey">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, long lngmId ,string strTableNameKey)
{
try
{
//操作步骤：
//1、根据所给定的关键字[mId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字mId
//5、把当前关键字mId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字mId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
long lngPrevmId = 0;    //上一条序号的关键字mId
long lngNextmId = 0;    //下一条序号的关键字mId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[mId],获取相应的序号[OrderNum]。

clstz_ContentAttachmentEN objtz_ContentAttachment = clstz_ContentAttachmentBL.GetObjBymId(lngmId);

intOrderNum = objtz_ContentAttachment.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", contz_ContentAttachment.TableNameKey, strTableNameKey);
intTabRecNum = clstz_ContentAttachmentBL.GetRecCountByCond(clstz_ContentAttachmentEN._CurrTabName, strCondition);    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
sbCondition.AppendFormat(" {0} = {1} ", contz_ContentAttachment.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", contz_ContentAttachment.TableNameKey, strTableNameKey);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clstz_ContentAttachmentBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clstz_ContentAttachmentBL.SetFldValue(clstz_ContentAttachmentEN._CurrTabName, contz_ContentAttachment.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", contz_ContentAttachment.mId, lngmId));
clstz_ContentAttachmentBL.SetFldValue(clstz_ContentAttachmentEN._CurrTabName, contz_ContentAttachment.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", contz_ContentAttachment.mId, lngPrevmId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字mId
sbCondition.AppendFormat(" {0} = {1} ", contz_ContentAttachment.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", contz_ContentAttachment.TableNameKey, strTableNameKey);

lngNextmId = clstz_ContentAttachmentBL.GetFirstID_S(sbCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clstz_ContentAttachmentBL.SetFldValue(clstz_ContentAttachmentEN._CurrTabName, contz_ContentAttachment.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", contz_ContentAttachment.mId, lngmId));
clstz_ContentAttachmentBL.SetFldValue(clstz_ContentAttachmentEN._CurrTabName, contz_ContentAttachment.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", contz_ContentAttachment.mId, lngNextmId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
 	 	objException.Message,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：TableNameKey单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<long> arrKeyId ,string strTableNameKey)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", contz_ContentAttachment.mId, strKeyList);
List<clstz_ContentAttachmentEN> arrtz_ContentAttachmentLst = GetObjLst(strCondition);
foreach (clstz_ContentAttachmentEN objtz_ContentAttachment in arrtz_ContentAttachmentLst)
{
objtz_ContentAttachment.OrderNum = objtz_ContentAttachment.OrderNum + 10000;
UpdateBySql2(objtz_ContentAttachment);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", contz_ContentAttachment.TableNameKey, strTableNameKey);
 strCondition += string.Format(" order by OrderNum ");
List<clstz_ContentAttachmentEN> arrtz_ContentAttachmentObjList = new clstz_ContentAttachmentDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clstz_ContentAttachmentEN objtz_ContentAttachment in arrtz_ContentAttachmentObjList)
{
objtz_ContentAttachment.OrderNum = intIndex;
UpdateBySql2(objtz_ContentAttachment);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：TableNameKey单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strTableNameKey">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId ,string strTableNameKey)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", contz_ContentAttachment.mId, strKeyList);
List<clstz_ContentAttachmentEN> arrtz_ContentAttachmentLst = GetObjLst(strCondition);
foreach (clstz_ContentAttachmentEN objtz_ContentAttachment in arrtz_ContentAttachmentLst)
{
objtz_ContentAttachment.OrderNum = objtz_ContentAttachment.OrderNum - 10000;
UpdateBySql2(objtz_ContentAttachment);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", contz_ContentAttachment.TableNameKey, strTableNameKey);
 strCondition += string.Format(" order by OrderNum ");
List<clstz_ContentAttachmentEN> arrtz_ContentAttachmentObjList = new clstz_ContentAttachmentDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clstz_ContentAttachmentEN objtz_ContentAttachment in arrtz_ContentAttachmentObjList)
{
objtz_ContentAttachment.OrderNum = intIndex;
UpdateBySql2(objtz_ContentAttachment);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 内容附件(tz_ContentAttachment)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4tz_ContentAttachment : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clstz_ContentAttachmentBL.ReFreshThisCache(strCourseId);
}
}

}