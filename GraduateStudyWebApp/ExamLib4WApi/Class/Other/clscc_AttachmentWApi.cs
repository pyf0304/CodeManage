
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_AttachmentWApi
 表名:cc_Attachment(01120149)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:50
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
public static class clscc_AttachmentWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_AttachmentEN SetTableName(this clscc_AttachmentEN objcc_AttachmentEN, string strTableName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTableName, 100, concc_Attachment.TableName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_AttachmentEN SetFileName(this clscc_AttachmentEN objcc_AttachmentEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, concc_Attachment.FileName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_AttachmentEN SetExtension(this clscc_AttachmentEN objcc_AttachmentEN, string strExtension, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExtension, 10, concc_Attachment.Extension);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_AttachmentEN SetFilePath(this clscc_AttachmentEN objcc_AttachmentEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, concc_Attachment.FilePath);
clsCheckSql.CheckFieldLen(strFilePath, 500, concc_Attachment.FilePath);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_AttachmentEN SetFileSize(this clscc_AttachmentEN objcc_AttachmentEN, double dblFileSize, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_AttachmentEN SetFileSizeUnit(this clscc_AttachmentEN objcc_AttachmentEN, string strFileSizeUnit, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSizeUnit, 10, concc_Attachment.FileSizeUnit);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_AttachmentEN SetImageHeight(this clscc_AttachmentEN objcc_AttachmentEN, int intImageHeight, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_AttachmentEN SetImageWidth(this clscc_AttachmentEN objcc_AttachmentEN, int intImageWidth, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_AttachmentEN SetUploadDate(this clscc_AttachmentEN objcc_AttachmentEN, string strUploadDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUploadDate, concc_Attachment.UploadDate);
clsCheckSql.CheckFieldLen(strUploadDate, 20, concc_Attachment.UploadDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_AttachmentEN SetUploadPerson(this clscc_AttachmentEN objcc_AttachmentEN, string strUploadPerson, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUploadPerson, 20, concc_Attachment.UploadPerson);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_AttachmentEN SetTableNameKey(this clscc_AttachmentEN objcc_AttachmentEN, string strTableNameKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTableNameKey, concc_Attachment.TableNameKey);
clsCheckSql.CheckFieldLen(strTableNameKey, 20, concc_Attachment.TableNameKey);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_AttachmentEN Setid_ResourceType(this clscc_AttachmentEN objcc_AttachmentEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, concc_Attachment.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, concc_Attachment.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, concc_Attachment.id_ResourceType);
objcc_AttachmentEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_AttachmentEN.dicFldComparisonOp.ContainsKey(concc_Attachment.id_ResourceType) == false)
{
objcc_AttachmentEN.dicFldComparisonOp.Add(concc_Attachment.id_ResourceType, strComparisonOp);
}
else
{
objcc_AttachmentEN.dicFldComparisonOp[concc_Attachment.id_ResourceType] = strComparisonOp;
}
}
return objcc_AttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_AttachmentEN SetUpdDate(this clscc_AttachmentEN objcc_AttachmentEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_Attachment.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_Attachment.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_AttachmentEN SetUpdUserId(this clscc_AttachmentEN objcc_AttachmentEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_Attachment.UpdUserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_AttachmentEN SetMemo(this clscc_AttachmentEN objcc_AttachmentEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_Attachment.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_AttachmentEN objcc_Attachment_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_Attachment_Cond.IsUpdated(concc_Attachment.AttachmentID) == true)
{
string strComparisonOp_AttachmentID = objcc_Attachment_Cond.dicFldComparisonOp[concc_Attachment.AttachmentID];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Attachment.AttachmentID, objcc_Attachment_Cond.AttachmentID, strComparisonOp_AttachmentID);
}
if (objcc_Attachment_Cond.IsUpdated(concc_Attachment.TableName) == true)
{
string strComparisonOp_TableName = objcc_Attachment_Cond.dicFldComparisonOp[concc_Attachment.TableName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.TableName, objcc_Attachment_Cond.TableName, strComparisonOp_TableName);
}
if (objcc_Attachment_Cond.IsUpdated(concc_Attachment.FileName) == true)
{
string strComparisonOp_FileName = objcc_Attachment_Cond.dicFldComparisonOp[concc_Attachment.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.FileName, objcc_Attachment_Cond.FileName, strComparisonOp_FileName);
}
if (objcc_Attachment_Cond.IsUpdated(concc_Attachment.Extension) == true)
{
string strComparisonOp_Extension = objcc_Attachment_Cond.dicFldComparisonOp[concc_Attachment.Extension];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.Extension, objcc_Attachment_Cond.Extension, strComparisonOp_Extension);
}
if (objcc_Attachment_Cond.IsUpdated(concc_Attachment.FilePath) == true)
{
string strComparisonOp_FilePath = objcc_Attachment_Cond.dicFldComparisonOp[concc_Attachment.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.FilePath, objcc_Attachment_Cond.FilePath, strComparisonOp_FilePath);
}
if (objcc_Attachment_Cond.IsUpdated(concc_Attachment.FileSize) == true)
{
string strComparisonOp_FileSize = objcc_Attachment_Cond.dicFldComparisonOp[concc_Attachment.FileSize];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Attachment.FileSize, objcc_Attachment_Cond.FileSize, strComparisonOp_FileSize);
}
if (objcc_Attachment_Cond.IsUpdated(concc_Attachment.FileSizeUnit) == true)
{
string strComparisonOp_FileSizeUnit = objcc_Attachment_Cond.dicFldComparisonOp[concc_Attachment.FileSizeUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.FileSizeUnit, objcc_Attachment_Cond.FileSizeUnit, strComparisonOp_FileSizeUnit);
}
if (objcc_Attachment_Cond.IsUpdated(concc_Attachment.ImageHeight) == true)
{
string strComparisonOp_ImageHeight = objcc_Attachment_Cond.dicFldComparisonOp[concc_Attachment.ImageHeight];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Attachment.ImageHeight, objcc_Attachment_Cond.ImageHeight, strComparisonOp_ImageHeight);
}
if (objcc_Attachment_Cond.IsUpdated(concc_Attachment.ImageWidth) == true)
{
string strComparisonOp_ImageWidth = objcc_Attachment_Cond.dicFldComparisonOp[concc_Attachment.ImageWidth];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Attachment.ImageWidth, objcc_Attachment_Cond.ImageWidth, strComparisonOp_ImageWidth);
}
if (objcc_Attachment_Cond.IsUpdated(concc_Attachment.UploadDate) == true)
{
string strComparisonOp_UploadDate = objcc_Attachment_Cond.dicFldComparisonOp[concc_Attachment.UploadDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.UploadDate, objcc_Attachment_Cond.UploadDate, strComparisonOp_UploadDate);
}
if (objcc_Attachment_Cond.IsUpdated(concc_Attachment.UploadPerson) == true)
{
string strComparisonOp_UploadPerson = objcc_Attachment_Cond.dicFldComparisonOp[concc_Attachment.UploadPerson];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.UploadPerson, objcc_Attachment_Cond.UploadPerson, strComparisonOp_UploadPerson);
}
if (objcc_Attachment_Cond.IsUpdated(concc_Attachment.TableNameKey) == true)
{
string strComparisonOp_TableNameKey = objcc_Attachment_Cond.dicFldComparisonOp[concc_Attachment.TableNameKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.TableNameKey, objcc_Attachment_Cond.TableNameKey, strComparisonOp_TableNameKey);
}
if (objcc_Attachment_Cond.IsUpdated(concc_Attachment.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objcc_Attachment_Cond.dicFldComparisonOp[concc_Attachment.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.id_ResourceType, objcc_Attachment_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objcc_Attachment_Cond.IsUpdated(concc_Attachment.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_Attachment_Cond.dicFldComparisonOp[concc_Attachment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.UpdDate, objcc_Attachment_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_Attachment_Cond.IsUpdated(concc_Attachment.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objcc_Attachment_Cond.dicFldComparisonOp[concc_Attachment.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.UpdUserId, objcc_Attachment_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objcc_Attachment_Cond.IsUpdated(concc_Attachment.Memo) == true)
{
string strComparisonOp_Memo = objcc_Attachment_Cond.dicFldComparisonOp[concc_Attachment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Attachment.Memo, objcc_Attachment_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_AttachmentEN objcc_AttachmentEN)
{
 if (objcc_AttachmentEN.AttachmentID == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_AttachmentEN.sf_UpdFldSetStr = objcc_AttachmentEN.getsf_UpdFldSetStr();
clscc_AttachmentWApi.CheckPropertyNew(objcc_AttachmentEN); 
bool bolResult = clscc_AttachmentWApi.UpdateRecord(objcc_AttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_AttachmentWApi.ReFreshCache(objcc_AttachmentEN.TableName);
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
 /// 检查唯一性(Uniqueness)--cc_Attachment(附件), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_TableName_TableNameKey_FileName(this clscc_AttachmentEN objcc_AttachmentEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_AttachmentEN == null) return "";
if (objcc_AttachmentEN.AttachmentID == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TableName = '{0}'", objcc_AttachmentEN.TableName);
 sbCondition.AppendFormat(" and TableNameKey = '{0}'", objcc_AttachmentEN.TableNameKey);
 sbCondition.AppendFormat(" and FileName = '{0}'", objcc_AttachmentEN.FileName);
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

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_AttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_AttachmentEN objcc_AttachmentEN)
{
try
{
clscc_AttachmentWApi.CheckPropertyNew(objcc_AttachmentEN); 
bool bolResult = clscc_AttachmentWApi.AddNewRecord(objcc_AttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_AttachmentWApi.ReFreshCache(objcc_AttachmentEN.TableName);
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
 /// <param name = "objcc_AttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_AttachmentEN objcc_AttachmentEN, string strWhereCond)
{
try
{
clscc_AttachmentWApi.CheckPropertyNew(objcc_AttachmentEN); 
bool bolResult = clscc_AttachmentWApi.UpdateWithCondition(objcc_AttachmentEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_AttachmentWApi.ReFreshCache(objcc_AttachmentEN.TableName);
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
 /// 附件(cc_Attachment)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_AttachmentWApi
{
private static readonly string mstrApiControllerName = "cc_AttachmentApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clscc_AttachmentWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_AttachmentEN objcc_AttachmentEN)
{
if (!Object.Equals(null, objcc_AttachmentEN.TableName) && GetStrLen(objcc_AttachmentEN.TableName) > 100)
{
 throw new Exception("字段[主表表名]的长度不能超过100!");
}
if (!Object.Equals(null, objcc_AttachmentEN.FileName) && GetStrLen(objcc_AttachmentEN.FileName) > 500)
{
 throw new Exception("字段[文件名称]的长度不能超过500!");
}
if (!Object.Equals(null, objcc_AttachmentEN.Extension) && GetStrLen(objcc_AttachmentEN.Extension) > 10)
{
 throw new Exception("字段[扩展名]的长度不能超过10!");
}
if (!Object.Equals(null, objcc_AttachmentEN.FilePath) && GetStrLen(objcc_AttachmentEN.FilePath) > 500)
{
 throw new Exception("字段[文件路径]的长度不能超过500!");
}
if (!Object.Equals(null, objcc_AttachmentEN.FileSizeUnit) && GetStrLen(objcc_AttachmentEN.FileSizeUnit) > 10)
{
 throw new Exception("字段[文件大小单位]的长度不能超过10!");
}
if (!Object.Equals(null, objcc_AttachmentEN.UploadDate) && GetStrLen(objcc_AttachmentEN.UploadDate) > 20)
{
 throw new Exception("字段[上传时间]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_AttachmentEN.UploadPerson) && GetStrLen(objcc_AttachmentEN.UploadPerson) > 20)
{
 throw new Exception("字段[上传人]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_AttachmentEN.TableNameKey) && GetStrLen(objcc_AttachmentEN.TableNameKey) > 20)
{
 throw new Exception("字段[主表主键值]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_AttachmentEN.id_ResourceType) && GetStrLen(objcc_AttachmentEN.id_ResourceType) > 4)
{
 throw new Exception("字段[资源类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objcc_AttachmentEN.UpdDate) && GetStrLen(objcc_AttachmentEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_AttachmentEN.UpdUserId) && GetStrLen(objcc_AttachmentEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_AttachmentEN.Memo) && GetStrLen(objcc_AttachmentEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_AttachmentEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngAttachmentID">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_AttachmentEN GetObjByAttachmentID(long lngAttachmentID)
{
string strAction = "GetObjByAttachmentID";
string strErrMsg = string.Empty;
string strResult = "";
clscc_AttachmentEN objcc_AttachmentEN = null;
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
objcc_AttachmentEN = JsonConvert.DeserializeObject<clscc_AttachmentEN>((string)jobjReturn["ReturnObj"]);
return objcc_AttachmentEN;
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
public static clscc_AttachmentEN GetObjByAttachmentID_WA_Cache(long lngAttachmentID, string strTableName)
{
string strAction = "GetObjByAttachmentID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_AttachmentEN objcc_AttachmentEN = null;
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
objcc_AttachmentEN = JsonConvert.DeserializeObject<clscc_AttachmentEN>((string)jobjReturn["ReturnObj"]);
return objcc_AttachmentEN;
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
public static clscc_AttachmentEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_AttachmentEN objcc_AttachmentEN = null;
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
objcc_AttachmentEN = JsonConvert.DeserializeObject<clscc_AttachmentEN>((string)jobjReturn["ReturnObj"]);
return objcc_AttachmentEN;
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
public static clscc_AttachmentEN GetObjByAttachmentID_Cache(long lngAttachmentID, string strTableName)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_AttachmentEN._CurrTabName_S, strTableName);
List<clscc_AttachmentEN> arrcc_AttachmentObjLst_Cache = GetObjLst_Cache(strTableName);
IEnumerable <clscc_AttachmentEN> arrcc_AttachmentObjLst_Sel =
from objcc_AttachmentEN in arrcc_AttachmentObjLst_Cache
where objcc_AttachmentEN.AttachmentID == lngAttachmentID
select objcc_AttachmentEN;
if (arrcc_AttachmentObjLst_Sel.Count() == 0)
{
   clscc_AttachmentEN obj = clscc_AttachmentWApi.GetObjByAttachmentID(lngAttachmentID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_AttachmentObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_AttachmentEN> GetObjLst(string strWhereCond)
{
 List<clscc_AttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_AttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_AttachmentEN> GetObjLstByAttachmentIDLst(List<long> arrAttachmentID)
{
 List<clscc_AttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_AttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clscc_AttachmentEN> GetObjLstByAttachmentIDLst_Cache(List<long> arrAttachmentID, string strTableName)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_AttachmentEN._CurrTabName_S, strTableName);
List<clscc_AttachmentEN> arrcc_AttachmentObjLst_Cache = GetObjLst_Cache(strTableName);
IEnumerable <clscc_AttachmentEN> arrcc_AttachmentObjLst_Sel =
from objcc_AttachmentEN in arrcc_AttachmentObjLst_Cache
where arrAttachmentID.Contains(objcc_AttachmentEN.AttachmentID)
select objcc_AttachmentEN;
return arrcc_AttachmentObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_AttachmentEN> GetObjLstByAttachmentIDLst_WA_Cache(List<long> arrAttachmentID, string strTableName)
{
 List<clscc_AttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_AttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_AttachmentEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_AttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_AttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_AttachmentEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_AttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_AttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_AttachmentEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_AttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_AttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_AttachmentEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_AttachmentEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_AttachmentEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngAttachmentID)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_AttachmentEN objcc_AttachmentEN = clscc_AttachmentWApi.GetObjByAttachmentID(lngAttachmentID);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngAttachmentID.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_AttachmentWApi.ReFreshCache(objcc_AttachmentEN.TableName);
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
public static int Delcc_Attachments(List<string> arrAttachmentID)
{
string strAction = "Delcc_Attachments";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrAttachmentID);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clscc_AttachmentEN objcc_AttachmentEN = clscc_AttachmentWApi.GetObjByAttachmentID(long.Parse(arrAttachmentID[0]));
clscc_AttachmentWApi.ReFreshCache(objcc_AttachmentEN.TableName);
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
public static int Delcc_AttachmentsByCond(string strWhereCond)
{
string strAction = "Delcc_AttachmentsByCond";
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
public static bool AddNewRecord(clscc_AttachmentEN objcc_AttachmentEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_AttachmentEN>(objcc_AttachmentEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_AttachmentWApi.ReFreshCache(objcc_AttachmentEN.TableName);
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
 /// <param name = "objcc_AttachmentEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clscc_AttachmentEN objcc_AttachmentEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_AttachmentEN>(objcc_AttachmentEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_AttachmentWApi.ReFreshCache(objcc_AttachmentEN.TableName);
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
public static bool UpdateRecord(clscc_AttachmentEN objcc_AttachmentEN)
{
if (string.IsNullOrEmpty(objcc_AttachmentEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_AttachmentEN.AttachmentID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_AttachmentEN>(objcc_AttachmentEN);
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
 /// <param name = "objcc_AttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_AttachmentEN objcc_AttachmentEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_AttachmentEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_AttachmentEN.AttachmentID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_AttachmentEN.AttachmentID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_AttachmentEN>(objcc_AttachmentEN);
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
objcc_AttachmentENT.id_ResourceType = objcc_AttachmentENS.id_ResourceType; //资源类型流水号
objcc_AttachmentENT.UpdDate = objcc_AttachmentENS.UpdDate; //修改日期
objcc_AttachmentENT.UpdUserId = objcc_AttachmentENS.UpdUserId; //修改用户Id
objcc_AttachmentENT.Memo = objcc_AttachmentENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_AttachmentEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_AttachmentEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_AttachmentEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_AttachmentEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_AttachmentEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_AttachmentEN.AttributeName)
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
if (clscc_AttachmentWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_AttachmentWApi没有刷新缓存机制(clscc_AttachmentWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by AttachmentID");
//if (arrcc_AttachmentObjLst_Cache == null)
//{
//arrcc_AttachmentObjLst_Cache = await clscc_AttachmentWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clscc_AttachmentEN._CurrTabName_S, strTableName);
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
public static void ReFreshCache(string strTableName)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clscc_AttachmentWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_AttachmentEN._CurrTabName_S, strTableName);
CacheHelper.Remove(strKey);
clscc_AttachmentWApi.objCommFun4BL.ReFreshCache(strTableName);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_AttachmentEN> GetObjLst_Cache(string strTableName)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clscc_AttachmentEN._CurrTabName_S, strTableName);
List<clscc_AttachmentEN> arrcc_AttachmentObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("TableName='{0}'", strTableName)); });
return arrcc_AttachmentObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_AttachmentEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_Attachment.AttachmentID, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_Attachment.TableName, Type.GetType("System.String"));
objDT.Columns.Add(concc_Attachment.FileName, Type.GetType("System.String"));
objDT.Columns.Add(concc_Attachment.Extension, Type.GetType("System.String"));
objDT.Columns.Add(concc_Attachment.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(concc_Attachment.FileSize, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_Attachment.FileSizeUnit, Type.GetType("System.String"));
objDT.Columns.Add(concc_Attachment.ImageHeight, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_Attachment.ImageWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_Attachment.UploadDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_Attachment.UploadPerson, Type.GetType("System.String"));
objDT.Columns.Add(concc_Attachment.TableNameKey, Type.GetType("System.String"));
objDT.Columns.Add(concc_Attachment.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(concc_Attachment.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_Attachment.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(concc_Attachment.Memo, Type.GetType("System.String"));
foreach (clscc_AttachmentEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_Attachment.AttachmentID] = objInFor[concc_Attachment.AttachmentID];
objDR[concc_Attachment.TableName] = objInFor[concc_Attachment.TableName];
objDR[concc_Attachment.FileName] = objInFor[concc_Attachment.FileName];
objDR[concc_Attachment.Extension] = objInFor[concc_Attachment.Extension];
objDR[concc_Attachment.FilePath] = objInFor[concc_Attachment.FilePath];
objDR[concc_Attachment.FileSize] = objInFor[concc_Attachment.FileSize];
objDR[concc_Attachment.FileSizeUnit] = objInFor[concc_Attachment.FileSizeUnit];
objDR[concc_Attachment.ImageHeight] = objInFor[concc_Attachment.ImageHeight];
objDR[concc_Attachment.ImageWidth] = objInFor[concc_Attachment.ImageWidth];
objDR[concc_Attachment.UploadDate] = objInFor[concc_Attachment.UploadDate];
objDR[concc_Attachment.UploadPerson] = objInFor[concc_Attachment.UploadPerson];
objDR[concc_Attachment.TableNameKey] = objInFor[concc_Attachment.TableNameKey];
objDR[concc_Attachment.id_ResourceType] = objInFor[concc_Attachment.id_ResourceType];
objDR[concc_Attachment.UpdDate] = objInFor[concc_Attachment.UpdDate];
objDR[concc_Attachment.UpdUserId] = objInFor[concc_Attachment.UpdUserId];
objDR[concc_Attachment.Memo] = objInFor[concc_Attachment.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 附件(cc_Attachment)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_Attachment : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strTableName)
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
clscc_AttachmentWApi.ReFreshThisCache(strTableName);
clsvcc_AttachmentWApi.ReFreshThisCache(strTableName);
}
}

}