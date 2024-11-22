
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDecompressionFileWApi
 表名:DecompressionFile(01120522)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:26
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:附加网站
 模块英文名:AdditionalSite
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
public static class clsDecompressionFileWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDecompressionFileEN SetId_DecompressionFile(this clsDecompressionFileEN objDecompressionFileEN, long lngId_DecompressionFile, string strComparisonOp="")
	{
objDecompressionFileEN.Id_DecompressionFile = lngId_DecompressionFile; //解压缩文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDecompressionFileEN.dicFldComparisonOp.ContainsKey(conDecompressionFile.Id_DecompressionFile) == false)
{
objDecompressionFileEN.dicFldComparisonOp.Add(conDecompressionFile.Id_DecompressionFile, strComparisonOp);
}
else
{
objDecompressionFileEN.dicFldComparisonOp[conDecompressionFile.Id_DecompressionFile] = strComparisonOp;
}
}
return objDecompressionFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDecompressionFileEN SetUploadFileDir(this clsDecompressionFileEN objDecompressionFileEN, string strUploadFileDir, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUploadFileDir, 1000, conDecompressionFile.UploadFileDir);
objDecompressionFileEN.UploadFileDir = strUploadFileDir; //上传文件的路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDecompressionFileEN.dicFldComparisonOp.ContainsKey(conDecompressionFile.UploadFileDir) == false)
{
objDecompressionFileEN.dicFldComparisonOp.Add(conDecompressionFile.UploadFileDir, strComparisonOp);
}
else
{
objDecompressionFileEN.dicFldComparisonOp[conDecompressionFile.UploadFileDir] = strComparisonOp;
}
}
return objDecompressionFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDecompressionFileEN SetUploadPerson(this clsDecompressionFileEN objDecompressionFileEN, string strUploadPerson, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUploadPerson, 20, conDecompressionFile.UploadPerson);
objDecompressionFileEN.UploadPerson = strUploadPerson; //上传人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDecompressionFileEN.dicFldComparisonOp.ContainsKey(conDecompressionFile.UploadPerson) == false)
{
objDecompressionFileEN.dicFldComparisonOp.Add(conDecompressionFile.UploadPerson, strComparisonOp);
}
else
{
objDecompressionFileEN.dicFldComparisonOp[conDecompressionFile.UploadPerson] = strComparisonOp;
}
}
return objDecompressionFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDecompressionFileEN SetNewName(this clsDecompressionFileEN objDecompressionFileEN, string strNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNewName, 1000, conDecompressionFile.NewName);
objDecompressionFileEN.NewName = strNewName; //新名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDecompressionFileEN.dicFldComparisonOp.ContainsKey(conDecompressionFile.NewName) == false)
{
objDecompressionFileEN.dicFldComparisonOp.Add(conDecompressionFile.NewName, strComparisonOp);
}
else
{
objDecompressionFileEN.dicFldComparisonOp[conDecompressionFile.NewName] = strComparisonOp;
}
}
return objDecompressionFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDecompressionFileEN SetNewPath(this clsDecompressionFileEN objDecompressionFileEN, string strNewPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNewPath, 1000, conDecompressionFile.NewPath);
objDecompressionFileEN.NewPath = strNewPath; //新路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDecompressionFileEN.dicFldComparisonOp.ContainsKey(conDecompressionFile.NewPath) == false)
{
objDecompressionFileEN.dicFldComparisonOp.Add(conDecompressionFile.NewPath, strComparisonOp);
}
else
{
objDecompressionFileEN.dicFldComparisonOp[conDecompressionFile.NewPath] = strComparisonOp;
}
}
return objDecompressionFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDecompressionFileEN SetUploadDate(this clsDecompressionFileEN objDecompressionFileEN, DateTime dteUploadDate, string strComparisonOp="")
	{
objDecompressionFileEN.UploadDate = dteUploadDate; //上传时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDecompressionFileEN.dicFldComparisonOp.ContainsKey(conDecompressionFile.UploadDate) == false)
{
objDecompressionFileEN.dicFldComparisonOp.Add(conDecompressionFile.UploadDate, strComparisonOp);
}
else
{
objDecompressionFileEN.dicFldComparisonOp[conDecompressionFile.UploadDate] = strComparisonOp;
}
}
return objDecompressionFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDecompressionFileEN SetDecompressionFilePath(this clsDecompressionFileEN objDecompressionFileEN, string strDecompressionFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDecompressionFilePath, 500, conDecompressionFile.DecompressionFilePath);
objDecompressionFileEN.DecompressionFilePath = strDecompressionFilePath; //解压缩文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDecompressionFileEN.dicFldComparisonOp.ContainsKey(conDecompressionFile.DecompressionFilePath) == false)
{
objDecompressionFileEN.dicFldComparisonOp.Add(conDecompressionFile.DecompressionFilePath, strComparisonOp);
}
else
{
objDecompressionFileEN.dicFldComparisonOp[conDecompressionFile.DecompressionFilePath] = strComparisonOp;
}
}
return objDecompressionFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDecompressionFileEN SetFileName(this clsDecompressionFileEN objDecompressionFileEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, conDecompressionFile.FileName);
objDecompressionFileEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDecompressionFileEN.dicFldComparisonOp.ContainsKey(conDecompressionFile.FileName) == false)
{
objDecompressionFileEN.dicFldComparisonOp.Add(conDecompressionFile.FileName, strComparisonOp);
}
else
{
objDecompressionFileEN.dicFldComparisonOp[conDecompressionFile.FileName] = strComparisonOp;
}
}
return objDecompressionFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDecompressionFileEN SetFilePath(this clsDecompressionFileEN objDecompressionFileEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFilePath, 500, conDecompressionFile.FilePath);
objDecompressionFileEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDecompressionFileEN.dicFldComparisonOp.ContainsKey(conDecompressionFile.FilePath) == false)
{
objDecompressionFileEN.dicFldComparisonOp.Add(conDecompressionFile.FilePath, strComparisonOp);
}
else
{
objDecompressionFileEN.dicFldComparisonOp[conDecompressionFile.FilePath] = strComparisonOp;
}
}
return objDecompressionFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDecompressionFileEN SetFileSize(this clsDecompressionFileEN objDecompressionFileEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, conDecompressionFile.FileSize);
objDecompressionFileEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDecompressionFileEN.dicFldComparisonOp.ContainsKey(conDecompressionFile.FileSize) == false)
{
objDecompressionFileEN.dicFldComparisonOp.Add(conDecompressionFile.FileSize, strComparisonOp);
}
else
{
objDecompressionFileEN.dicFldComparisonOp[conDecompressionFile.FileSize] = strComparisonOp;
}
}
return objDecompressionFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDecompressionFileEN SetFileSizeUnit(this clsDecompressionFileEN objDecompressionFileEN, string strFileSizeUnit, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSizeUnit, 10, conDecompressionFile.FileSizeUnit);
objDecompressionFileEN.FileSizeUnit = strFileSizeUnit; //文件大小单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDecompressionFileEN.dicFldComparisonOp.ContainsKey(conDecompressionFile.FileSizeUnit) == false)
{
objDecompressionFileEN.dicFldComparisonOp.Add(conDecompressionFile.FileSizeUnit, strComparisonOp);
}
else
{
objDecompressionFileEN.dicFldComparisonOp[conDecompressionFile.FileSizeUnit] = strComparisonOp;
}
}
return objDecompressionFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDecompressionFileEN SetIsRar(this clsDecompressionFileEN objDecompressionFileEN, bool bolIsRar, string strComparisonOp="")
	{
objDecompressionFileEN.IsRar = bolIsRar; //是否解压缩
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDecompressionFileEN.dicFldComparisonOp.ContainsKey(conDecompressionFile.IsRar) == false)
{
objDecompressionFileEN.dicFldComparisonOp.Add(conDecompressionFile.IsRar, strComparisonOp);
}
else
{
objDecompressionFileEN.dicFldComparisonOp[conDecompressionFile.IsRar] = strComparisonOp;
}
}
return objDecompressionFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDecompressionFileEN SetUserId(this clsDecompressionFileEN objDecompressionFileEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conDecompressionFile.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, conDecompressionFile.UserId);
objDecompressionFileEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDecompressionFileEN.dicFldComparisonOp.ContainsKey(conDecompressionFile.UserId) == false)
{
objDecompressionFileEN.dicFldComparisonOp.Add(conDecompressionFile.UserId, strComparisonOp);
}
else
{
objDecompressionFileEN.dicFldComparisonOp[conDecompressionFile.UserId] = strComparisonOp;
}
}
return objDecompressionFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDecompressionFileEN SetHomePage(this clsDecompressionFileEN objDecompressionFileEN, string strHomePage, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHomePage, 100, conDecompressionFile.HomePage);
objDecompressionFileEN.HomePage = strHomePage; //HomePage
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDecompressionFileEN.dicFldComparisonOp.ContainsKey(conDecompressionFile.HomePage) == false)
{
objDecompressionFileEN.dicFldComparisonOp.Add(conDecompressionFile.HomePage, strComparisonOp);
}
else
{
objDecompressionFileEN.dicFldComparisonOp[conDecompressionFile.HomePage] = strComparisonOp;
}
}
return objDecompressionFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDecompressionFileEN SetHomePageDir(this clsDecompressionFileEN objDecompressionFileEN, string strHomePageDir, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHomePageDir, 200, conDecompressionFile.HomePageDir);
objDecompressionFileEN.HomePageDir = strHomePageDir; //首页文件目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDecompressionFileEN.dicFldComparisonOp.ContainsKey(conDecompressionFile.HomePageDir) == false)
{
objDecompressionFileEN.dicFldComparisonOp.Add(conDecompressionFile.HomePageDir, strComparisonOp);
}
else
{
objDecompressionFileEN.dicFldComparisonOp[conDecompressionFile.HomePageDir] = strComparisonOp;
}
}
return objDecompressionFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDecompressionFileEN SetMemo(this clsDecompressionFileEN objDecompressionFileEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDecompressionFile.Memo);
objDecompressionFileEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDecompressionFileEN.dicFldComparisonOp.ContainsKey(conDecompressionFile.Memo) == false)
{
objDecompressionFileEN.dicFldComparisonOp.Add(conDecompressionFile.Memo, strComparisonOp);
}
else
{
objDecompressionFileEN.dicFldComparisonOp[conDecompressionFile.Memo] = strComparisonOp;
}
}
return objDecompressionFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDecompressionFileEN SetMemo1(this clsDecompressionFileEN objDecompressionFileEN, string strMemo1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo1, 1000, conDecompressionFile.Memo1);
objDecompressionFileEN.Memo1 = strMemo1; //Memo1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDecompressionFileEN.dicFldComparisonOp.ContainsKey(conDecompressionFile.Memo1) == false)
{
objDecompressionFileEN.dicFldComparisonOp.Add(conDecompressionFile.Memo1, strComparisonOp);
}
else
{
objDecompressionFileEN.dicFldComparisonOp[conDecompressionFile.Memo1] = strComparisonOp;
}
}
return objDecompressionFileEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDecompressionFileEN objDecompressionFile_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDecompressionFile_Cond.IsUpdated(conDecompressionFile.Id_DecompressionFile) == true)
{
string strComparisonOp_Id_DecompressionFile = objDecompressionFile_Cond.dicFldComparisonOp[conDecompressionFile.Id_DecompressionFile];
strWhereCond += string.Format(" And {0} {2} {1}", conDecompressionFile.Id_DecompressionFile, objDecompressionFile_Cond.Id_DecompressionFile, strComparisonOp_Id_DecompressionFile);
}
if (objDecompressionFile_Cond.IsUpdated(conDecompressionFile.UploadFileDir) == true)
{
string strComparisonOp_UploadFileDir = objDecompressionFile_Cond.dicFldComparisonOp[conDecompressionFile.UploadFileDir];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDecompressionFile.UploadFileDir, objDecompressionFile_Cond.UploadFileDir, strComparisonOp_UploadFileDir);
}
if (objDecompressionFile_Cond.IsUpdated(conDecompressionFile.UploadPerson) == true)
{
string strComparisonOp_UploadPerson = objDecompressionFile_Cond.dicFldComparisonOp[conDecompressionFile.UploadPerson];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDecompressionFile.UploadPerson, objDecompressionFile_Cond.UploadPerson, strComparisonOp_UploadPerson);
}
if (objDecompressionFile_Cond.IsUpdated(conDecompressionFile.NewName) == true)
{
string strComparisonOp_NewName = objDecompressionFile_Cond.dicFldComparisonOp[conDecompressionFile.NewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDecompressionFile.NewName, objDecompressionFile_Cond.NewName, strComparisonOp_NewName);
}
if (objDecompressionFile_Cond.IsUpdated(conDecompressionFile.NewPath) == true)
{
string strComparisonOp_NewPath = objDecompressionFile_Cond.dicFldComparisonOp[conDecompressionFile.NewPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDecompressionFile.NewPath, objDecompressionFile_Cond.NewPath, strComparisonOp_NewPath);
}
if (objDecompressionFile_Cond.IsUpdated(conDecompressionFile.UploadDate) == true)
{
string strComparisonOp_UploadDate = objDecompressionFile_Cond.dicFldComparisonOp[conDecompressionFile.UploadDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDecompressionFile.UploadDate, objDecompressionFile_Cond.UploadDate, strComparisonOp_UploadDate);
}
if (objDecompressionFile_Cond.IsUpdated(conDecompressionFile.DecompressionFilePath) == true)
{
string strComparisonOp_DecompressionFilePath = objDecompressionFile_Cond.dicFldComparisonOp[conDecompressionFile.DecompressionFilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDecompressionFile.DecompressionFilePath, objDecompressionFile_Cond.DecompressionFilePath, strComparisonOp_DecompressionFilePath);
}
if (objDecompressionFile_Cond.IsUpdated(conDecompressionFile.FileName) == true)
{
string strComparisonOp_FileName = objDecompressionFile_Cond.dicFldComparisonOp[conDecompressionFile.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDecompressionFile.FileName, objDecompressionFile_Cond.FileName, strComparisonOp_FileName);
}
if (objDecompressionFile_Cond.IsUpdated(conDecompressionFile.FilePath) == true)
{
string strComparisonOp_FilePath = objDecompressionFile_Cond.dicFldComparisonOp[conDecompressionFile.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDecompressionFile.FilePath, objDecompressionFile_Cond.FilePath, strComparisonOp_FilePath);
}
if (objDecompressionFile_Cond.IsUpdated(conDecompressionFile.FileSize) == true)
{
string strComparisonOp_FileSize = objDecompressionFile_Cond.dicFldComparisonOp[conDecompressionFile.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDecompressionFile.FileSize, objDecompressionFile_Cond.FileSize, strComparisonOp_FileSize);
}
if (objDecompressionFile_Cond.IsUpdated(conDecompressionFile.FileSizeUnit) == true)
{
string strComparisonOp_FileSizeUnit = objDecompressionFile_Cond.dicFldComparisonOp[conDecompressionFile.FileSizeUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDecompressionFile.FileSizeUnit, objDecompressionFile_Cond.FileSizeUnit, strComparisonOp_FileSizeUnit);
}
if (objDecompressionFile_Cond.IsUpdated(conDecompressionFile.IsRar) == true)
{
if (objDecompressionFile_Cond.IsRar == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDecompressionFile.IsRar);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDecompressionFile.IsRar);
}
}
if (objDecompressionFile_Cond.IsUpdated(conDecompressionFile.UserId) == true)
{
string strComparisonOp_UserId = objDecompressionFile_Cond.dicFldComparisonOp[conDecompressionFile.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDecompressionFile.UserId, objDecompressionFile_Cond.UserId, strComparisonOp_UserId);
}
if (objDecompressionFile_Cond.IsUpdated(conDecompressionFile.HomePage) == true)
{
string strComparisonOp_HomePage = objDecompressionFile_Cond.dicFldComparisonOp[conDecompressionFile.HomePage];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDecompressionFile.HomePage, objDecompressionFile_Cond.HomePage, strComparisonOp_HomePage);
}
if (objDecompressionFile_Cond.IsUpdated(conDecompressionFile.HomePageDir) == true)
{
string strComparisonOp_HomePageDir = objDecompressionFile_Cond.dicFldComparisonOp[conDecompressionFile.HomePageDir];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDecompressionFile.HomePageDir, objDecompressionFile_Cond.HomePageDir, strComparisonOp_HomePageDir);
}
if (objDecompressionFile_Cond.IsUpdated(conDecompressionFile.Memo) == true)
{
string strComparisonOp_Memo = objDecompressionFile_Cond.dicFldComparisonOp[conDecompressionFile.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDecompressionFile.Memo, objDecompressionFile_Cond.Memo, strComparisonOp_Memo);
}
if (objDecompressionFile_Cond.IsUpdated(conDecompressionFile.Memo1) == true)
{
string strComparisonOp_Memo1 = objDecompressionFile_Cond.dicFldComparisonOp[conDecompressionFile.Memo1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDecompressionFile.Memo1, objDecompressionFile_Cond.Memo1, strComparisonOp_Memo1);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDecompressionFileEN objDecompressionFileEN)
{
 if (objDecompressionFileEN.Id_DecompressionFile == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objDecompressionFileEN.sf_UpdFldSetStr = objDecompressionFileEN.getsf_UpdFldSetStr();
clsDecompressionFileWApi.CheckPropertyNew(objDecompressionFileEN); 
bool bolResult = clsDecompressionFileWApi.UpdateRecord(objDecompressionFileEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDecompressionFileWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--DecompressionFile(解压缩文件), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDecompressionFileEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_FileName_UploadPerson_UploadFileDir(this clsDecompressionFileEN objDecompressionFileEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDecompressionFileEN == null) return "";
if (objDecompressionFileEN.Id_DecompressionFile == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FileName = '{0}'", objDecompressionFileEN.FileName);
 sbCondition.AppendFormat(" and UploadPerson = '{0}'", objDecompressionFileEN.UploadPerson);
 sbCondition.AppendFormat(" and UploadFileDir = '{0}'", objDecompressionFileEN.UploadFileDir);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("Id_DecompressionFile !=  {0}", objDecompressionFileEN.Id_DecompressionFile);
 sbCondition.AppendFormat(" and FileName = '{0}'", objDecompressionFileEN.FileName);
 sbCondition.AppendFormat(" and UploadPerson = '{0}'", objDecompressionFileEN.UploadPerson);
 sbCondition.AppendFormat(" and UploadFileDir = '{0}'", objDecompressionFileEN.UploadFileDir);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDecompressionFileEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDecompressionFileEN objDecompressionFileEN)
{
try
{
clsDecompressionFileWApi.CheckPropertyNew(objDecompressionFileEN); 
bool bolResult = clsDecompressionFileWApi.AddNewRecord(objDecompressionFileEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDecompressionFileWApi.ReFreshCache();
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
 /// <param name = "objDecompressionFileEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDecompressionFileEN objDecompressionFileEN, string strWhereCond)
{
try
{
clsDecompressionFileWApi.CheckPropertyNew(objDecompressionFileEN); 
bool bolResult = clsDecompressionFileWApi.UpdateWithCondition(objDecompressionFileEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDecompressionFileWApi.ReFreshCache();
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
 /// 解压缩文件(DecompressionFile)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsDecompressionFileWApi
{
private static readonly string mstrApiControllerName = "DecompressionFileApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsDecompressionFileWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsDecompressionFileEN objDecompressionFileEN)
{
if (!Object.Equals(null, objDecompressionFileEN.UploadFileDir) && GetStrLen(objDecompressionFileEN.UploadFileDir) > 1000)
{
 throw new Exception("字段[上传文件的路径]的长度不能超过1000!");
}
if (!Object.Equals(null, objDecompressionFileEN.UploadPerson) && GetStrLen(objDecompressionFileEN.UploadPerson) > 20)
{
 throw new Exception("字段[上传人]的长度不能超过20!");
}
if (!Object.Equals(null, objDecompressionFileEN.NewName) && GetStrLen(objDecompressionFileEN.NewName) > 1000)
{
 throw new Exception("字段[新名称]的长度不能超过1000!");
}
if (!Object.Equals(null, objDecompressionFileEN.NewPath) && GetStrLen(objDecompressionFileEN.NewPath) > 1000)
{
 throw new Exception("字段[新路径]的长度不能超过1000!");
}
if (!Object.Equals(null, objDecompressionFileEN.DecompressionFilePath) && GetStrLen(objDecompressionFileEN.DecompressionFilePath) > 500)
{
 throw new Exception("字段[解压缩文件路径]的长度不能超过500!");
}
if (!Object.Equals(null, objDecompressionFileEN.FileName) && GetStrLen(objDecompressionFileEN.FileName) > 500)
{
 throw new Exception("字段[文件名称]的长度不能超过500!");
}
if (!Object.Equals(null, objDecompressionFileEN.FilePath) && GetStrLen(objDecompressionFileEN.FilePath) > 500)
{
 throw new Exception("字段[文件路径]的长度不能超过500!");
}
if (!Object.Equals(null, objDecompressionFileEN.FileSize) && GetStrLen(objDecompressionFileEN.FileSize) > 50)
{
 throw new Exception("字段[文件大小]的长度不能超过50!");
}
if (!Object.Equals(null, objDecompressionFileEN.FileSizeUnit) && GetStrLen(objDecompressionFileEN.FileSizeUnit) > 10)
{
 throw new Exception("字段[文件大小单位]的长度不能超过10!");
}
if (!Object.Equals(null, objDecompressionFileEN.UserId) && GetStrLen(objDecompressionFileEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objDecompressionFileEN.HomePage) && GetStrLen(objDecompressionFileEN.HomePage) > 100)
{
 throw new Exception("字段[HomePage]的长度不能超过100!");
}
if (!Object.Equals(null, objDecompressionFileEN.HomePageDir) && GetStrLen(objDecompressionFileEN.HomePageDir) > 200)
{
 throw new Exception("字段[首页文件目录]的长度不能超过200!");
}
if (!Object.Equals(null, objDecompressionFileEN.Memo) && GetStrLen(objDecompressionFileEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objDecompressionFileEN.Memo1) && GetStrLen(objDecompressionFileEN.Memo1) > 1000)
{
 throw new Exception("字段[Memo1]的长度不能超过1000!");
}
 objDecompressionFileEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_DecompressionFile">表关键字</param>
 /// <returns>表对象</returns>
public static clsDecompressionFileEN GetObjById_DecompressionFile(long lngId_DecompressionFile)
{
string strAction = "GetObjById_DecompressionFile";
string strErrMsg = string.Empty;
string strResult = "";
clsDecompressionFileEN objDecompressionFileEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_DecompressionFile"] = lngId_DecompressionFile.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objDecompressionFileEN = JsonConvert.DeserializeObject<clsDecompressionFileEN>((string)jobjReturn["ReturnObj"]);
return objDecompressionFileEN;
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
 /// <param name = "lngId_DecompressionFile">表关键字</param>
 /// <returns>表对象</returns>
public static clsDecompressionFileEN GetObjById_DecompressionFile_WA_Cache(long lngId_DecompressionFile)
{
string strAction = "GetObjById_DecompressionFile_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsDecompressionFileEN objDecompressionFileEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_DecompressionFile"] = lngId_DecompressionFile.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objDecompressionFileEN = JsonConvert.DeserializeObject<clsDecompressionFileEN>((string)jobjReturn["ReturnObj"]);
return objDecompressionFileEN;
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
public static clsDecompressionFileEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsDecompressionFileEN objDecompressionFileEN = null;
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
objDecompressionFileEN = JsonConvert.DeserializeObject<clsDecompressionFileEN>((string)jobjReturn["ReturnObj"]);
return objDecompressionFileEN;
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
 /// <param name = "lngId_DecompressionFile">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDecompressionFileEN GetObjById_DecompressionFile_Cache(long lngId_DecompressionFile)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsDecompressionFileEN._CurrTabName_S);
List<clsDecompressionFileEN> arrDecompressionFileObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsDecompressionFileEN> arrDecompressionFileObjLst_Sel =
from objDecompressionFileEN in arrDecompressionFileObjLst_Cache
where objDecompressionFileEN.Id_DecompressionFile == lngId_DecompressionFile
select objDecompressionFileEN;
if (arrDecompressionFileObjLst_Sel.Count() == 0)
{
   clsDecompressionFileEN obj = clsDecompressionFileWApi.GetObjById_DecompressionFile(lngId_DecompressionFile);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrDecompressionFileObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDecompressionFileEN> GetObjLst(string strWhereCond)
{
 List<clsDecompressionFileEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDecompressionFileEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsDecompressionFileEN> GetObjLstById_DecompressionFileLst(List<long> arrId_DecompressionFile)
{
 List<clsDecompressionFileEN> arrObjLst = null; 
string strAction = "GetObjLstById_DecompressionFileLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_DecompressionFile);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsDecompressionFileEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_DecompressionFile">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsDecompressionFileEN> GetObjLstById_DecompressionFileLst_Cache(List<long> arrId_DecompressionFile)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsDecompressionFileEN._CurrTabName_S);
List<clsDecompressionFileEN> arrDecompressionFileObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsDecompressionFileEN> arrDecompressionFileObjLst_Sel =
from objDecompressionFileEN in arrDecompressionFileObjLst_Cache
where arrId_DecompressionFile.Contains(objDecompressionFileEN.Id_DecompressionFile)
select objDecompressionFileEN;
return arrDecompressionFileObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDecompressionFileEN> GetObjLstById_DecompressionFileLst_WA_Cache(List<long> arrId_DecompressionFile)
{
 List<clsDecompressionFileEN> arrObjLst = null; 
string strAction = "GetObjLstById_DecompressionFileLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_DecompressionFile);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsDecompressionFileEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsDecompressionFileEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsDecompressionFileEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDecompressionFileEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsDecompressionFileEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsDecompressionFileEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDecompressionFileEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsDecompressionFileEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsDecompressionFileEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDecompressionFileEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsDecompressionFileEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsDecompressionFileEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDecompressionFileEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngId_DecompressionFile)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsDecompressionFileEN objDecompressionFileEN = clsDecompressionFileWApi.GetObjById_DecompressionFile(lngId_DecompressionFile);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngId_DecompressionFile.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsDecompressionFileWApi.ReFreshCache();
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
public static int DelDecompressionFiles(List<string> arrId_DecompressionFile)
{
string strAction = "DelDecompressionFiles";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_DecompressionFile);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsDecompressionFileWApi.ReFreshCache();
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
public static int DelDecompressionFilesByCond(string strWhereCond)
{
string strAction = "DelDecompressionFilesByCond";
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
public static bool AddNewRecord(clsDecompressionFileEN objDecompressionFileEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDecompressionFileEN>(objDecompressionFileEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDecompressionFileWApi.ReFreshCache();
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
 /// <param name = "objDecompressionFileEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsDecompressionFileEN objDecompressionFileEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDecompressionFileEN>(objDecompressionFileEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDecompressionFileWApi.ReFreshCache();
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
public static bool UpdateRecord(clsDecompressionFileEN objDecompressionFileEN)
{
if (string.IsNullOrEmpty(objDecompressionFileEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objDecompressionFileEN.Id_DecompressionFile, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDecompressionFileEN>(objDecompressionFileEN);
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
 /// <param name = "objDecompressionFileEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsDecompressionFileEN objDecompressionFileEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objDecompressionFileEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objDecompressionFileEN.Id_DecompressionFile, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objDecompressionFileEN.Id_DecompressionFile, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDecompressionFileEN>(objDecompressionFileEN);
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
public static bool IsExist(long lngId_DecompressionFile)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_DecompressionFile"] = lngId_DecompressionFile.ToString()
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
 /// <param name = "objDecompressionFileENS">源对象</param>
 /// <param name = "objDecompressionFileENT">目标对象</param>
 public static void CopyTo(clsDecompressionFileEN objDecompressionFileENS, clsDecompressionFileEN objDecompressionFileENT)
{
try
{
objDecompressionFileENT.Id_DecompressionFile = objDecompressionFileENS.Id_DecompressionFile; //解压缩文件流水号
objDecompressionFileENT.UploadFileDir = objDecompressionFileENS.UploadFileDir; //上传文件的路径
objDecompressionFileENT.UploadPerson = objDecompressionFileENS.UploadPerson; //上传人
objDecompressionFileENT.NewName = objDecompressionFileENS.NewName; //新名称
objDecompressionFileENT.NewPath = objDecompressionFileENS.NewPath; //新路径
objDecompressionFileENT.UploadDate = objDecompressionFileENS.UploadDate; //上传时间
objDecompressionFileENT.DecompressionFilePath = objDecompressionFileENS.DecompressionFilePath; //解压缩文件路径
objDecompressionFileENT.FileName = objDecompressionFileENS.FileName; //文件名称
objDecompressionFileENT.FilePath = objDecompressionFileENS.FilePath; //文件路径
objDecompressionFileENT.FileSize = objDecompressionFileENS.FileSize; //文件大小
objDecompressionFileENT.FileSizeUnit = objDecompressionFileENS.FileSizeUnit; //文件大小单位
objDecompressionFileENT.IsRar = objDecompressionFileENS.IsRar; //是否解压缩
objDecompressionFileENT.UserId = objDecompressionFileENS.UserId; //用户ID
objDecompressionFileENT.HomePage = objDecompressionFileENS.HomePage; //HomePage
objDecompressionFileENT.HomePageDir = objDecompressionFileENS.HomePageDir; //首页文件目录
objDecompressionFileENT.Memo = objDecompressionFileENS.Memo; //备注
objDecompressionFileENT.Memo1 = objDecompressionFileENS.Memo1; //Memo1
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
public static DataTable ToDataTable(List<clsDecompressionFileEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsDecompressionFileEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsDecompressionFileEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsDecompressionFileEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsDecompressionFileEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsDecompressionFileEN.AttributeName)
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
if (clsDecompressionFileWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDecompressionFileWApi没有刷新缓存机制(clsDecompressionFileWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_DecompressionFile");
//if (arrDecompressionFileObjLst_Cache == null)
//{
//arrDecompressionFileObjLst_Cache = await clsDecompressionFileWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsDecompressionFileEN._CurrTabName_S);
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
if (clsDecompressionFileWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDecompressionFileEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsDecompressionFileWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDecompressionFileEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsDecompressionFileEN._CurrTabName_S);
List<clsDecompressionFileEN> arrDecompressionFileObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrDecompressionFileObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsDecompressionFileEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conDecompressionFile.Id_DecompressionFile, Type.GetType("System.Int64"));
objDT.Columns.Add(conDecompressionFile.UploadFileDir, Type.GetType("System.String"));
objDT.Columns.Add(conDecompressionFile.UploadPerson, Type.GetType("System.String"));
objDT.Columns.Add(conDecompressionFile.NewName, Type.GetType("System.String"));
objDT.Columns.Add(conDecompressionFile.NewPath, Type.GetType("System.String"));
objDT.Columns.Add(conDecompressionFile.UploadDate, Type.GetType("System.DateTime"));
objDT.Columns.Add(conDecompressionFile.DecompressionFilePath, Type.GetType("System.String"));
objDT.Columns.Add(conDecompressionFile.FileName, Type.GetType("System.String"));
objDT.Columns.Add(conDecompressionFile.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(conDecompressionFile.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(conDecompressionFile.FileSizeUnit, Type.GetType("System.String"));
objDT.Columns.Add(conDecompressionFile.IsRar, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDecompressionFile.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conDecompressionFile.HomePage, Type.GetType("System.String"));
objDT.Columns.Add(conDecompressionFile.HomePageDir, Type.GetType("System.String"));
objDT.Columns.Add(conDecompressionFile.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conDecompressionFile.Memo1, Type.GetType("System.String"));
foreach (clsDecompressionFileEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conDecompressionFile.Id_DecompressionFile] = objInFor[conDecompressionFile.Id_DecompressionFile];
objDR[conDecompressionFile.UploadFileDir] = objInFor[conDecompressionFile.UploadFileDir];
objDR[conDecompressionFile.UploadPerson] = objInFor[conDecompressionFile.UploadPerson];
objDR[conDecompressionFile.NewName] = objInFor[conDecompressionFile.NewName];
objDR[conDecompressionFile.NewPath] = objInFor[conDecompressionFile.NewPath];
objDR[conDecompressionFile.UploadDate] = objInFor[conDecompressionFile.UploadDate];
objDR[conDecompressionFile.DecompressionFilePath] = objInFor[conDecompressionFile.DecompressionFilePath];
objDR[conDecompressionFile.FileName] = objInFor[conDecompressionFile.FileName];
objDR[conDecompressionFile.FilePath] = objInFor[conDecompressionFile.FilePath];
objDR[conDecompressionFile.FileSize] = objInFor[conDecompressionFile.FileSize];
objDR[conDecompressionFile.FileSizeUnit] = objInFor[conDecompressionFile.FileSizeUnit];
objDR[conDecompressionFile.IsRar] = objInFor[conDecompressionFile.IsRar];
objDR[conDecompressionFile.UserId] = objInFor[conDecompressionFile.UserId];
objDR[conDecompressionFile.HomePage] = objInFor[conDecompressionFile.HomePage];
objDR[conDecompressionFile.HomePageDir] = objInFor[conDecompressionFile.HomePageDir];
objDR[conDecompressionFile.Memo] = objInFor[conDecompressionFile.Memo];
objDR[conDecompressionFile.Memo1] = objInFor[conDecompressionFile.Memo1];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 解压缩文件(DecompressionFile)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4DecompressionFile : clsCommFun4BL
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
clsDecompressionFileWApi.ReFreshThisCache();
}
}

}