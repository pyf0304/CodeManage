
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubTeachCaseRelaInfoWApi
 表名:vPubTeachCaseRelaInfo(01120400)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:45
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩
 模块英文名:PubicClassSenate
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
public static class clsvPubTeachCaseRelaInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN Setid_PubTeachCaseRelaInfo(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, long lngid_PubTeachCaseRelaInfo, string strComparisonOp="")
	{
objvPubTeachCaseRelaInfoEN.id_PubTeachCaseRelaInfo = lngid_PubTeachCaseRelaInfo; //公开课案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfo) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetIsVisible(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, bool bolIsVisible, string strComparisonOp="")
	{
objvPubTeachCaseRelaInfoEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.IsVisible) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.IsVisible, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.IsVisible] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetSubjectName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strSubjectName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSubjectName, convPubTeachCaseRelaInfo.SubjectName);
clsCheckSql.CheckFieldLen(strSubjectName, 200, convPubTeachCaseRelaInfo.SubjectName);
objvPubTeachCaseRelaInfoEN.SubjectName = strSubjectName; //课题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.SubjectName) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.SubjectName, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.SubjectName] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetTeachingPlanAuthor(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strTeachingPlanAuthor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingPlanAuthor, 50, convPubTeachCaseRelaInfo.TeachingPlanAuthor);
objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = strTeachingPlanAuthor; //教案撰写人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.TeachingPlanAuthor) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.TeachingPlanAuthor, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingPlanAuthor] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetTeachingObject(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strTeachingObject, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingObject, 5000, convPubTeachCaseRelaInfo.TeachingObject);
objvPubTeachCaseRelaInfoEN.TeachingObject = strTeachingObject; //教学目标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.TeachingObject) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.TeachingObject, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingObject] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetTeachingEmphases(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strTeachingEmphases, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingEmphases, 5000, convPubTeachCaseRelaInfo.TeachingEmphases);
objvPubTeachCaseRelaInfoEN.TeachingEmphases = strTeachingEmphases; //教学重点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.TeachingEmphases) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.TeachingEmphases, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingEmphases] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetTeachingDifficulty(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strTeachingDifficulty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingDifficulty, 5000, convPubTeachCaseRelaInfo.TeachingDifficulty);
objvPubTeachCaseRelaInfoEN.TeachingDifficulty = strTeachingDifficulty; //教学难点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.TeachingDifficulty) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.TeachingDifficulty, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingDifficulty] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetTeachingTool(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strTeachingTool, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingTool, 5000, convPubTeachCaseRelaInfo.TeachingTool);
objvPubTeachCaseRelaInfoEN.TeachingTool = strTeachingTool; //教学用具
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.TeachingTool) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.TeachingTool, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingTool] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetTeachingProcess(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strTeachingProcess, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingProcess, 8000, convPubTeachCaseRelaInfo.TeachingProcess);
objvPubTeachCaseRelaInfoEN.TeachingProcess = strTeachingProcess; //教学过程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.TeachingProcess) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.TeachingProcess, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingProcess] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN Setid_FtpResource(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convPubTeachCaseRelaInfo.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convPubTeachCaseRelaInfo.id_FtpResource);
objvPubTeachCaseRelaInfoEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.id_FtpResource) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.id_FtpResource, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_FtpResource] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFtpResourceID(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convPubTeachCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convPubTeachCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convPubTeachCaseRelaInfo.FtpResourceID);
objvPubTeachCaseRelaInfoEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.FtpResourceID) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.FtpResourceID, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.FtpResourceID] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileOriginalName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convPubTeachCaseRelaInfo.FileOriginalName);
objvPubTeachCaseRelaInfoEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.FileOriginalName) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.FileOriginalName, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileOriginalName] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileDirName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convPubTeachCaseRelaInfo.FileDirName);
objvPubTeachCaseRelaInfoEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.FileDirName) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.FileDirName, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileDirName] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileRename(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convPubTeachCaseRelaInfo.FileRename);
objvPubTeachCaseRelaInfoEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.FileRename) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.FileRename, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileRename] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileUpDate(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convPubTeachCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convPubTeachCaseRelaInfo.FileUpDate);
objvPubTeachCaseRelaInfoEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.FileUpDate) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.FileUpDate, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileUpDate] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileUpTime(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convPubTeachCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convPubTeachCaseRelaInfo.FileUpTime);
objvPubTeachCaseRelaInfoEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.FileUpTime) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.FileUpTime, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileUpTime] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN Setid_Resource(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convPubTeachCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convPubTeachCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convPubTeachCaseRelaInfo.id_Resource);
objvPubTeachCaseRelaInfoEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.id_Resource) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.id_Resource, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_Resource] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetSaveMode(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, bool bolSaveMode, string strComparisonOp="")
	{
objvPubTeachCaseRelaInfoEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.SaveMode) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.SaveMode, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.SaveMode] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN Setid_ResourceType(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, convPubTeachCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convPubTeachCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convPubTeachCaseRelaInfo.id_ResourceType);
objvPubTeachCaseRelaInfoEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.id_ResourceType) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.id_ResourceType, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_ResourceType] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetResourceTypeID(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convPubTeachCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convPubTeachCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convPubTeachCaseRelaInfo.ResourceTypeID);
objvPubTeachCaseRelaInfoEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.ResourceTypeID) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.ResourceTypeID, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.ResourceTypeID] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetResourceTypeName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convPubTeachCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convPubTeachCaseRelaInfo.ResourceTypeName);
objvPubTeachCaseRelaInfoEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.ResourceTypeName) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.ResourceTypeName, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.ResourceTypeName] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN Setid_PubCaseType(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strid_PubCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubCaseType, convPubTeachCaseRelaInfo.id_PubCaseType);
clsCheckSql.CheckFieldLen(strid_PubCaseType, 4, convPubTeachCaseRelaInfo.id_PubCaseType);
clsCheckSql.CheckFieldForeignKey(strid_PubCaseType, 4, convPubTeachCaseRelaInfo.id_PubCaseType);
objvPubTeachCaseRelaInfoEN.id_PubCaseType = strid_PubCaseType; //公开课案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.id_PubCaseType) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.id_PubCaseType, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_PubCaseType] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubCaseTypeID(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubCaseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubCaseTypeID, convPubTeachCaseRelaInfo.PubCaseTypeID);
clsCheckSql.CheckFieldLen(strPubCaseTypeID, 4, convPubTeachCaseRelaInfo.PubCaseTypeID);
clsCheckSql.CheckFieldForeignKey(strPubCaseTypeID, 4, convPubTeachCaseRelaInfo.PubCaseTypeID);
objvPubTeachCaseRelaInfoEN.PubCaseTypeID = strPubCaseTypeID; //公开课案例类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.PubCaseTypeID) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.PubCaseTypeID, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubCaseTypeID] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubCaseTypeName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubCaseTypeName, convPubTeachCaseRelaInfo.PubCaseTypeName);
clsCheckSql.CheckFieldLen(strPubCaseTypeName, 50, convPubTeachCaseRelaInfo.PubCaseTypeName);
objvPubTeachCaseRelaInfoEN.PubCaseTypeName = strPubCaseTypeName; //公开课案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.PubCaseTypeName) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.PubCaseTypeName, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubCaseTypeName] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN Setid_PubTeachCaseRelaInfoType(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strid_PubTeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubTeachCaseRelaInfoType, convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(strid_PubTeachCaseRelaInfoType, 4, convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType);
clsCheckSql.CheckFieldForeignKey(strid_PubTeachCaseRelaInfoType, 4, convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType);
objvPubTeachCaseRelaInfoEN.id_PubTeachCaseRelaInfoType = strid_PubTeachCaseRelaInfoType; //公开课案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubTeachCaseRelaInfoTypeID(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubTeachCaseRelaInfoTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubTeachCaseRelaInfoTypeID, convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldLen(strPubTeachCaseRelaInfoTypeID, 4, convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldForeignKey(strPubTeachCaseRelaInfoTypeID, 4, convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID);
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID = strPubTeachCaseRelaInfoTypeID; //公开课案例相关信息类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubTeachCaseRelaInfoTypeName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubTeachCaseRelaInfoTypeName, convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(strPubTeachCaseRelaInfoTypeName, 50, convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName);
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName = strPubTeachCaseRelaInfoTypeName; //公开课案例相关信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetTeachingPlanType(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strTeachingPlanType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingPlanType, 1, convPubTeachCaseRelaInfo.TeachingPlanType);
clsCheckSql.CheckFieldForeignKey(strTeachingPlanType, 1, convPubTeachCaseRelaInfo.TeachingPlanType);
objvPubTeachCaseRelaInfoEN.TeachingPlanType = strTeachingPlanType; //教案类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.TeachingPlanType) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.TeachingPlanType, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingPlanType] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetBrowseCount(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, int intBrowseCount, string strComparisonOp="")
	{
objvPubTeachCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.BrowseCount) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetSimplePlanContent(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strSimplePlanContent, string strComparisonOp="")
	{
objvPubTeachCaseRelaInfoEN.SimplePlanContent = strSimplePlanContent; //简案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.SimplePlanContent) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.SimplePlanContent, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.SimplePlanContent] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetResourceOwner(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convPubTeachCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convPubTeachCaseRelaInfo.ResourceOwner);
objvPubTeachCaseRelaInfoEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.ResourceOwner) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.ResourceOwner, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.ResourceOwner] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetftpFileType(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convPubTeachCaseRelaInfo.ftpFileType);
objvPubTeachCaseRelaInfoEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.ftpFileType) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.ftpFileType, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.ftpFileType] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetftpFileSize(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convPubTeachCaseRelaInfo.ftpFileSize);
objvPubTeachCaseRelaInfoEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.ftpFileSize) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.ftpFileSize, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.ftpFileSize] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetftpResourceOwner(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convPubTeachCaseRelaInfo.ftpResourceOwner);
objvPubTeachCaseRelaInfoEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.ftpResourceOwner) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.ftpResourceOwner, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.ftpResourceOwner] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN Setid_Discipline(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convPubTeachCaseRelaInfo.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convPubTeachCaseRelaInfo.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convPubTeachCaseRelaInfo.id_Discipline);
objvPubTeachCaseRelaInfoEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.id_Discipline) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.id_Discipline, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_Discipline] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetDisciplineID(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineID, convPubTeachCaseRelaInfo.DisciplineID);
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convPubTeachCaseRelaInfo.DisciplineID);
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convPubTeachCaseRelaInfo.DisciplineID);
objvPubTeachCaseRelaInfoEN.DisciplineID = strDisciplineID; //学科ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.DisciplineID) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.DisciplineID, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.DisciplineID] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetDisciplineName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, convPubTeachCaseRelaInfo.DisciplineName);
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convPubTeachCaseRelaInfo.DisciplineName);
objvPubTeachCaseRelaInfoEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.DisciplineName) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.DisciplineName, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.DisciplineName] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN Setid_StudyLevel(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convPubTeachCaseRelaInfo.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convPubTeachCaseRelaInfo.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convPubTeachCaseRelaInfo.id_StudyLevel);
objvPubTeachCaseRelaInfoEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.id_StudyLevel) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.id_StudyLevel, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_StudyLevel] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetStudyLevelName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convPubTeachCaseRelaInfo.StudyLevelName);
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convPubTeachCaseRelaInfo.StudyLevelName);
objvPubTeachCaseRelaInfoEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.StudyLevelName) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.StudyLevelName, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.StudyLevelName] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN Setid_File(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convPubTeachCaseRelaInfo.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convPubTeachCaseRelaInfo.id_File);
objvPubTeachCaseRelaInfoEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.id_File) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.id_File, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_File] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convPubTeachCaseRelaInfo.FileName);
objvPubTeachCaseRelaInfoEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.FileName) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.FileName, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileName] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileType(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convPubTeachCaseRelaInfo.FileType);
objvPubTeachCaseRelaInfoEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.FileType) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.FileType, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileType] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetSaveDate(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convPubTeachCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convPubTeachCaseRelaInfo.SaveDate);
objvPubTeachCaseRelaInfoEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.SaveDate) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.SaveDate, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.SaveDate] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileSize(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convPubTeachCaseRelaInfo.FileSize);
objvPubTeachCaseRelaInfoEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.FileSize) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.FileSize, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileSize] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetSaveTime(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convPubTeachCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convPubTeachCaseRelaInfo.SaveTime);
objvPubTeachCaseRelaInfoEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.SaveTime) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.SaveTime, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.SaveTime] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN Setid_PubClassCase(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strid_PubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubClassCase, convPubTeachCaseRelaInfo.id_PubClassCase);
clsCheckSql.CheckFieldLen(strid_PubClassCase, 8, convPubTeachCaseRelaInfo.id_PubClassCase);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCase, 8, convPubTeachCaseRelaInfo.id_PubClassCase);
objvPubTeachCaseRelaInfoEN.id_PubClassCase = strid_PubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.id_PubClassCase) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.id_PubClassCase, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_PubClassCase] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubClassCaseID(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubClassCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseID, convPubTeachCaseRelaInfo.PubClassCaseID);
clsCheckSql.CheckFieldLen(strPubClassCaseID, 8, convPubTeachCaseRelaInfo.PubClassCaseID);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseID, 8, convPubTeachCaseRelaInfo.PubClassCaseID);
objvPubTeachCaseRelaInfoEN.PubClassCaseID = strPubClassCaseID; //案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.PubClassCaseID) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.PubClassCaseID, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseID] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubClassCaseName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubClassCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseName, convPubTeachCaseRelaInfo.PubClassCaseName);
clsCheckSql.CheckFieldLen(strPubClassCaseName, 200, convPubTeachCaseRelaInfo.PubClassCaseName);
objvPubTeachCaseRelaInfoEN.PubClassCaseName = strPubClassCaseName; //案例课题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.PubClassCaseName) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.PubClassCaseName, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseName] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubClassCaseExecutor(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubClassCaseExecutor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseExecutor, 50, convPubTeachCaseRelaInfo.PubClassCaseExecutor);
objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = strPubClassCaseExecutor; //案例执教者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.PubClassCaseExecutor) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.PubClassCaseExecutor, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseExecutor] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubClassCaseTheme(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubClassCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseTheme, 500, convPubTeachCaseRelaInfo.PubClassCaseTheme);
objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = strPubClassCaseTheme; //案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.PubClassCaseTheme) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.PubClassCaseTheme, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseTheme] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubClassCaseBG(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubClassCaseBG, string strComparisonOp="")
	{
objvPubTeachCaseRelaInfoEN.PubClassCaseBG = strPubClassCaseBG; //案例背景资料
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.PubClassCaseBG) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.PubClassCaseBG, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseBG] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubClassCaseTeachDate(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubClassCaseTeachDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseTeachDate, 8, convPubTeachCaseRelaInfo.PubClassCaseTeachDate);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTeachDate, 8, convPubTeachCaseRelaInfo.PubClassCaseTeachDate);
objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = strPubClassCaseTeachDate; //案例授课日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.PubClassCaseTeachDate) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.PubClassCaseTeachDate, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseTeachDate] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubClassCaseDateIn(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubClassCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseDateIn, 8, convPubTeachCaseRelaInfo.PubClassCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseDateIn, 8, convPubTeachCaseRelaInfo.PubClassCaseDateIn);
objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = strPubClassCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.PubClassCaseDateIn) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.PubClassCaseDateIn, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseDateIn] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN Setid_TeachingPlan(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachingPlan, convPubTeachCaseRelaInfo.id_TeachingPlan);
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convPubTeachCaseRelaInfo.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convPubTeachCaseRelaInfo.id_TeachingPlan);
objvPubTeachCaseRelaInfoEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.id_TeachingPlan) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.id_TeachingPlan, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_TeachingPlan] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetMemo(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPubTeachCaseRelaInfo.Memo);
objvPubTeachCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.Memo) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileOriginName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convPubTeachCaseRelaInfo.FileOriginName);
objvPubTeachCaseRelaInfoEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.FileOriginName) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.FileOriginName, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileOriginName] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetIsExistFile(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvPubTeachCaseRelaInfoEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.IsExistFile) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.IsExistFile, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.IsExistFile] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetResourceID(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convPubTeachCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convPubTeachCaseRelaInfo.ResourceID);
objvPubTeachCaseRelaInfoEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.ResourceID) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.ResourceID, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.ResourceID] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileNewName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convPubTeachCaseRelaInfo.FileNewName);
objvPubTeachCaseRelaInfoEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.FileNewName) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.FileNewName, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileNewName] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileOldName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convPubTeachCaseRelaInfo.FileOldName);
objvPubTeachCaseRelaInfoEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.FileOldName) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.FileOldName, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileOldName] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfo) == true)
{
string strComparisonOp_id_PubTeachCaseRelaInfo = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfo, objvPubTeachCaseRelaInfo_Cond.id_PubTeachCaseRelaInfo, strComparisonOp_id_PubTeachCaseRelaInfo);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.IsVisible) == true)
{
if (objvPubTeachCaseRelaInfo_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubTeachCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubTeachCaseRelaInfo.IsVisible);
}
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.SubjectName) == true)
{
string strComparisonOp_SubjectName = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.SubjectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.SubjectName, objvPubTeachCaseRelaInfo_Cond.SubjectName, strComparisonOp_SubjectName);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.TeachingPlanAuthor) == true)
{
string strComparisonOp_TeachingPlanAuthor = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingPlanAuthor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.TeachingPlanAuthor, objvPubTeachCaseRelaInfo_Cond.TeachingPlanAuthor, strComparisonOp_TeachingPlanAuthor);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.TeachingObject) == true)
{
string strComparisonOp_TeachingObject = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingObject];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.TeachingObject, objvPubTeachCaseRelaInfo_Cond.TeachingObject, strComparisonOp_TeachingObject);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.TeachingEmphases) == true)
{
string strComparisonOp_TeachingEmphases = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingEmphases];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.TeachingEmphases, objvPubTeachCaseRelaInfo_Cond.TeachingEmphases, strComparisonOp_TeachingEmphases);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.TeachingDifficulty) == true)
{
string strComparisonOp_TeachingDifficulty = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingDifficulty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.TeachingDifficulty, objvPubTeachCaseRelaInfo_Cond.TeachingDifficulty, strComparisonOp_TeachingDifficulty);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.TeachingTool) == true)
{
string strComparisonOp_TeachingTool = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingTool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.TeachingTool, objvPubTeachCaseRelaInfo_Cond.TeachingTool, strComparisonOp_TeachingTool);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.TeachingProcess) == true)
{
string strComparisonOp_TeachingProcess = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingProcess];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.TeachingProcess, objvPubTeachCaseRelaInfo_Cond.TeachingProcess, strComparisonOp_TeachingProcess);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.id_FtpResource, objvPubTeachCaseRelaInfo_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FtpResourceID, objvPubTeachCaseRelaInfo_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileOriginalName, objvPubTeachCaseRelaInfo_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileDirName, objvPubTeachCaseRelaInfo_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.FileRename) == true)
{
string strComparisonOp_FileRename = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileRename, objvPubTeachCaseRelaInfo_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileUpDate, objvPubTeachCaseRelaInfo_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileUpTime, objvPubTeachCaseRelaInfo_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.id_Resource, objvPubTeachCaseRelaInfo_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.SaveMode) == true)
{
if (objvPubTeachCaseRelaInfo_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubTeachCaseRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubTeachCaseRelaInfo.SaveMode);
}
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.id_ResourceType, objvPubTeachCaseRelaInfo_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.ResourceTypeID, objvPubTeachCaseRelaInfo_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.ResourceTypeName, objvPubTeachCaseRelaInfo_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.id_PubCaseType) == true)
{
string strComparisonOp_id_PubCaseType = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_PubCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.id_PubCaseType, objvPubTeachCaseRelaInfo_Cond.id_PubCaseType, strComparisonOp_id_PubCaseType);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.PubCaseTypeID) == true)
{
string strComparisonOp_PubCaseTypeID = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubCaseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubCaseTypeID, objvPubTeachCaseRelaInfo_Cond.PubCaseTypeID, strComparisonOp_PubCaseTypeID);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.PubCaseTypeName) == true)
{
string strComparisonOp_PubCaseTypeName = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubCaseTypeName, objvPubTeachCaseRelaInfo_Cond.PubCaseTypeName, strComparisonOp_PubCaseTypeName);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType) == true)
{
string strComparisonOp_id_PubTeachCaseRelaInfoType = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType, objvPubTeachCaseRelaInfo_Cond.id_PubTeachCaseRelaInfoType, strComparisonOp_id_PubTeachCaseRelaInfoType);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID) == true)
{
string strComparisonOp_PubTeachCaseRelaInfoTypeID = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID, objvPubTeachCaseRelaInfo_Cond.PubTeachCaseRelaInfoTypeID, strComparisonOp_PubTeachCaseRelaInfoTypeID);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOp_PubTeachCaseRelaInfoTypeName = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName, objvPubTeachCaseRelaInfo_Cond.PubTeachCaseRelaInfoTypeName, strComparisonOp_PubTeachCaseRelaInfoTypeName);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.TeachingPlanType) == true)
{
string strComparisonOp_TeachingPlanType = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingPlanType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.TeachingPlanType, objvPubTeachCaseRelaInfo_Cond.TeachingPlanType, strComparisonOp_TeachingPlanType);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPubTeachCaseRelaInfo.BrowseCount, objvPubTeachCaseRelaInfo_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.ResourceOwner, objvPubTeachCaseRelaInfo_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.ftpFileType, objvPubTeachCaseRelaInfo_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.ftpFileSize, objvPubTeachCaseRelaInfo_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.ftpResourceOwner, objvPubTeachCaseRelaInfo_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.id_Discipline, objvPubTeachCaseRelaInfo_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.DisciplineID) == true)
{
string strComparisonOp_DisciplineID = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.DisciplineID, objvPubTeachCaseRelaInfo_Cond.DisciplineID, strComparisonOp_DisciplineID);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.DisciplineName, objvPubTeachCaseRelaInfo_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.id_StudyLevel, objvPubTeachCaseRelaInfo_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.StudyLevelName, objvPubTeachCaseRelaInfo_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.id_File) == true)
{
string strComparisonOp_id_File = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.id_File, objvPubTeachCaseRelaInfo_Cond.id_File, strComparisonOp_id_File);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.FileName) == true)
{
string strComparisonOp_FileName = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileName, objvPubTeachCaseRelaInfo_Cond.FileName, strComparisonOp_FileName);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.FileType) == true)
{
string strComparisonOp_FileType = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileType, objvPubTeachCaseRelaInfo_Cond.FileType, strComparisonOp_FileType);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.SaveDate, objvPubTeachCaseRelaInfo_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.FileSize) == true)
{
string strComparisonOp_FileSize = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileSize, objvPubTeachCaseRelaInfo_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.SaveTime, objvPubTeachCaseRelaInfo_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.id_PubClassCase) == true)
{
string strComparisonOp_id_PubClassCase = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_PubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.id_PubClassCase, objvPubTeachCaseRelaInfo_Cond.id_PubClassCase, strComparisonOp_id_PubClassCase);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.PubClassCaseID) == true)
{
string strComparisonOp_PubClassCaseID = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubClassCaseID, objvPubTeachCaseRelaInfo_Cond.PubClassCaseID, strComparisonOp_PubClassCaseID);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.PubClassCaseName) == true)
{
string strComparisonOp_PubClassCaseName = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubClassCaseName, objvPubTeachCaseRelaInfo_Cond.PubClassCaseName, strComparisonOp_PubClassCaseName);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.PubClassCaseExecutor) == true)
{
string strComparisonOp_PubClassCaseExecutor = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubClassCaseExecutor, objvPubTeachCaseRelaInfo_Cond.PubClassCaseExecutor, strComparisonOp_PubClassCaseExecutor);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.PubClassCaseTheme) == true)
{
string strComparisonOp_PubClassCaseTheme = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubClassCaseTheme, objvPubTeachCaseRelaInfo_Cond.PubClassCaseTheme, strComparisonOp_PubClassCaseTheme);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.PubClassCaseTeachDate) == true)
{
string strComparisonOp_PubClassCaseTeachDate = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseTeachDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubClassCaseTeachDate, objvPubTeachCaseRelaInfo_Cond.PubClassCaseTeachDate, strComparisonOp_PubClassCaseTeachDate);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.PubClassCaseDateIn) == true)
{
string strComparisonOp_PubClassCaseDateIn = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubClassCaseDateIn, objvPubTeachCaseRelaInfo_Cond.PubClassCaseDateIn, strComparisonOp_PubClassCaseDateIn);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.id_TeachingPlan, objvPubTeachCaseRelaInfo_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.Memo) == true)
{
string strComparisonOp_Memo = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.Memo, objvPubTeachCaseRelaInfo_Cond.Memo, strComparisonOp_Memo);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileOriginName, objvPubTeachCaseRelaInfo_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.IsExistFile) == true)
{
if (objvPubTeachCaseRelaInfo_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubTeachCaseRelaInfo.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubTeachCaseRelaInfo.IsExistFile);
}
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.ResourceID, objvPubTeachCaseRelaInfo_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileNewName, objvPubTeachCaseRelaInfo_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvPubTeachCaseRelaInfo_Cond.IsUpdated(convPubTeachCaseRelaInfo.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileOldName, objvPubTeachCaseRelaInfo_Cond.FileOldName, strComparisonOp_FileOldName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v公开课案例相关信息(vPubTeachCaseRelaInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPubTeachCaseRelaInfoWApi
{
private static readonly string mstrApiControllerName = "vPubTeachCaseRelaInfoApi";

 public clsvPubTeachCaseRelaInfoWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_PubTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubTeachCaseRelaInfoEN GetObjByid_PubTeachCaseRelaInfo(long lngid_PubTeachCaseRelaInfo)
{
string strAction = "GetObjByid_PubTeachCaseRelaInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubTeachCaseRelaInfo"] = lngid_PubTeachCaseRelaInfo.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPubTeachCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvPubTeachCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvPubTeachCaseRelaInfoEN;
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
 /// <param name = "lngid_PubTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubTeachCaseRelaInfoEN GetObjByid_PubTeachCaseRelaInfo_WA_Cache(long lngid_PubTeachCaseRelaInfo)
{
string strAction = "GetObjByid_PubTeachCaseRelaInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubTeachCaseRelaInfo"] = lngid_PubTeachCaseRelaInfo.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPubTeachCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvPubTeachCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvPubTeachCaseRelaInfoEN;
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
public static clsvPubTeachCaseRelaInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = null;
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
objvPubTeachCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvPubTeachCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvPubTeachCaseRelaInfoEN;
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
 /// <param name = "lngid_PubTeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubTeachCaseRelaInfoEN GetObjByid_PubTeachCaseRelaInfo_Cache(long lngid_PubTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPubTeachCaseRelaInfoEN._CurrTabName_S);
List<clsvPubTeachCaseRelaInfoEN> arrvPubTeachCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPubTeachCaseRelaInfoEN> arrvPubTeachCaseRelaInfoObjLst_Sel =
from objvPubTeachCaseRelaInfoEN in arrvPubTeachCaseRelaInfoObjLst_Cache
where objvPubTeachCaseRelaInfoEN.id_PubTeachCaseRelaInfo == lngid_PubTeachCaseRelaInfo
select objvPubTeachCaseRelaInfoEN;
if (arrvPubTeachCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvPubTeachCaseRelaInfoEN obj = clsvPubTeachCaseRelaInfoWApi.GetObjByid_PubTeachCaseRelaInfo(lngid_PubTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPubTeachCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubTeachCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvPubTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubTeachCaseRelaInfoEN> GetObjLstById_PubTeachCaseRelaInfoLst(List<long> arrId_PubTeachCaseRelaInfo)
{
 List<clsvPubTeachCaseRelaInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubTeachCaseRelaInfoLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubTeachCaseRelaInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_PubTeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvPubTeachCaseRelaInfoEN> GetObjLstById_PubTeachCaseRelaInfoLst_Cache(List<long> arrId_PubTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPubTeachCaseRelaInfoEN._CurrTabName_S);
List<clsvPubTeachCaseRelaInfoEN> arrvPubTeachCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPubTeachCaseRelaInfoEN> arrvPubTeachCaseRelaInfoObjLst_Sel =
from objvPubTeachCaseRelaInfoEN in arrvPubTeachCaseRelaInfoObjLst_Cache
where arrId_PubTeachCaseRelaInfo.Contains(objvPubTeachCaseRelaInfoEN.id_PubTeachCaseRelaInfo)
select objvPubTeachCaseRelaInfoEN;
return arrvPubTeachCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubTeachCaseRelaInfoEN> GetObjLstById_PubTeachCaseRelaInfoLst_WA_Cache(List<long> arrId_PubTeachCaseRelaInfo)
{
 List<clsvPubTeachCaseRelaInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubTeachCaseRelaInfoLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubTeachCaseRelaInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubTeachCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPubTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubTeachCaseRelaInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPubTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubTeachCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPubTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubTeachCaseRelaInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvPubTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_PubTeachCaseRelaInfo)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubTeachCaseRelaInfo"] = lngid_PubTeachCaseRelaInfo.ToString()
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
 /// <param name = "objvPubTeachCaseRelaInfoENS">源对象</param>
 /// <param name = "objvPubTeachCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoENS, clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoENT)
{
try
{
objvPubTeachCaseRelaInfoENT.id_PubTeachCaseRelaInfo = objvPubTeachCaseRelaInfoENS.id_PubTeachCaseRelaInfo; //公开课案例相关信息流水号
objvPubTeachCaseRelaInfoENT.IsVisible = objvPubTeachCaseRelaInfoENS.IsVisible; //是否显示
objvPubTeachCaseRelaInfoENT.SubjectName = objvPubTeachCaseRelaInfoENS.SubjectName; //课题名称
objvPubTeachCaseRelaInfoENT.TeachingPlanAuthor = objvPubTeachCaseRelaInfoENS.TeachingPlanAuthor; //教案撰写人
objvPubTeachCaseRelaInfoENT.TeachingObject = objvPubTeachCaseRelaInfoENS.TeachingObject; //教学目标
objvPubTeachCaseRelaInfoENT.TeachingEmphases = objvPubTeachCaseRelaInfoENS.TeachingEmphases; //教学重点
objvPubTeachCaseRelaInfoENT.TeachingDifficulty = objvPubTeachCaseRelaInfoENS.TeachingDifficulty; //教学难点
objvPubTeachCaseRelaInfoENT.TeachingTool = objvPubTeachCaseRelaInfoENS.TeachingTool; //教学用具
objvPubTeachCaseRelaInfoENT.TeachingProcess = objvPubTeachCaseRelaInfoENS.TeachingProcess; //教学过程
objvPubTeachCaseRelaInfoENT.id_FtpResource = objvPubTeachCaseRelaInfoENS.id_FtpResource; //FTP资源流水号
objvPubTeachCaseRelaInfoENT.FtpResourceID = objvPubTeachCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvPubTeachCaseRelaInfoENT.FileOriginalName = objvPubTeachCaseRelaInfoENS.FileOriginalName; //文件原名
objvPubTeachCaseRelaInfoENT.FileDirName = objvPubTeachCaseRelaInfoENS.FileDirName; //文件目录名
objvPubTeachCaseRelaInfoENT.FileRename = objvPubTeachCaseRelaInfoENS.FileRename; //文件新名
objvPubTeachCaseRelaInfoENT.FileUpDate = objvPubTeachCaseRelaInfoENS.FileUpDate; //创建日期
objvPubTeachCaseRelaInfoENT.FileUpTime = objvPubTeachCaseRelaInfoENS.FileUpTime; //创建时间
objvPubTeachCaseRelaInfoENT.id_Resource = objvPubTeachCaseRelaInfoENS.id_Resource; //资源流水号
objvPubTeachCaseRelaInfoENT.SaveMode = objvPubTeachCaseRelaInfoENS.SaveMode; //文件存放方式
objvPubTeachCaseRelaInfoENT.id_ResourceType = objvPubTeachCaseRelaInfoENS.id_ResourceType; //资源类型流水号
objvPubTeachCaseRelaInfoENT.ResourceTypeID = objvPubTeachCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvPubTeachCaseRelaInfoENT.ResourceTypeName = objvPubTeachCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvPubTeachCaseRelaInfoENT.id_PubCaseType = objvPubTeachCaseRelaInfoENS.id_PubCaseType; //公开课案例类型流水号
objvPubTeachCaseRelaInfoENT.PubCaseTypeID = objvPubTeachCaseRelaInfoENS.PubCaseTypeID; //公开课案例类型ID
objvPubTeachCaseRelaInfoENT.PubCaseTypeName = objvPubTeachCaseRelaInfoENS.PubCaseTypeName; //公开课案例类型名称
objvPubTeachCaseRelaInfoENT.id_PubTeachCaseRelaInfoType = objvPubTeachCaseRelaInfoENS.id_PubTeachCaseRelaInfoType; //公开课案例相关信息类型流水号
objvPubTeachCaseRelaInfoENT.PubTeachCaseRelaInfoTypeID = objvPubTeachCaseRelaInfoENS.PubTeachCaseRelaInfoTypeID; //公开课案例相关信息类型ID
objvPubTeachCaseRelaInfoENT.PubTeachCaseRelaInfoTypeName = objvPubTeachCaseRelaInfoENS.PubTeachCaseRelaInfoTypeName; //公开课案例相关信息类型名称
objvPubTeachCaseRelaInfoENT.TeachingPlanType = objvPubTeachCaseRelaInfoENS.TeachingPlanType; //教案类型
objvPubTeachCaseRelaInfoENT.BrowseCount = objvPubTeachCaseRelaInfoENS.BrowseCount; //浏览次数
objvPubTeachCaseRelaInfoENT.SimplePlanContent = objvPubTeachCaseRelaInfoENS.SimplePlanContent; //简案内容
objvPubTeachCaseRelaInfoENT.ResourceOwner = objvPubTeachCaseRelaInfoENS.ResourceOwner; //上传者
objvPubTeachCaseRelaInfoENT.ftpFileType = objvPubTeachCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvPubTeachCaseRelaInfoENT.ftpFileSize = objvPubTeachCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvPubTeachCaseRelaInfoENT.ftpResourceOwner = objvPubTeachCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvPubTeachCaseRelaInfoENT.id_Discipline = objvPubTeachCaseRelaInfoENS.id_Discipline; //学科流水号
objvPubTeachCaseRelaInfoENT.DisciplineID = objvPubTeachCaseRelaInfoENS.DisciplineID; //学科ID
objvPubTeachCaseRelaInfoENT.DisciplineName = objvPubTeachCaseRelaInfoENS.DisciplineName; //学科名称
objvPubTeachCaseRelaInfoENT.id_StudyLevel = objvPubTeachCaseRelaInfoENS.id_StudyLevel; //id_StudyLevel
objvPubTeachCaseRelaInfoENT.StudyLevelName = objvPubTeachCaseRelaInfoENS.StudyLevelName; //学段名称
objvPubTeachCaseRelaInfoENT.id_File = objvPubTeachCaseRelaInfoENS.id_File; //文件流水号
objvPubTeachCaseRelaInfoENT.FileName = objvPubTeachCaseRelaInfoENS.FileName; //文件名称
objvPubTeachCaseRelaInfoENT.FileType = objvPubTeachCaseRelaInfoENS.FileType; //文件类型
objvPubTeachCaseRelaInfoENT.SaveDate = objvPubTeachCaseRelaInfoENS.SaveDate; //创建日期
objvPubTeachCaseRelaInfoENT.FileSize = objvPubTeachCaseRelaInfoENS.FileSize; //文件大小
objvPubTeachCaseRelaInfoENT.SaveTime = objvPubTeachCaseRelaInfoENS.SaveTime; //创建时间
objvPubTeachCaseRelaInfoENT.id_PubClassCase = objvPubTeachCaseRelaInfoENS.id_PubClassCase; //案例流水号
objvPubTeachCaseRelaInfoENT.PubClassCaseID = objvPubTeachCaseRelaInfoENS.PubClassCaseID; //案例ID
objvPubTeachCaseRelaInfoENT.PubClassCaseName = objvPubTeachCaseRelaInfoENS.PubClassCaseName; //案例课题名称
objvPubTeachCaseRelaInfoENT.PubClassCaseExecutor = objvPubTeachCaseRelaInfoENS.PubClassCaseExecutor; //案例执教者
objvPubTeachCaseRelaInfoENT.PubClassCaseTheme = objvPubTeachCaseRelaInfoENS.PubClassCaseTheme; //案例主题词
objvPubTeachCaseRelaInfoENT.PubClassCaseBG = objvPubTeachCaseRelaInfoENS.PubClassCaseBG; //案例背景资料
objvPubTeachCaseRelaInfoENT.PubClassCaseTeachDate = objvPubTeachCaseRelaInfoENS.PubClassCaseTeachDate; //案例授课日期
objvPubTeachCaseRelaInfoENT.PubClassCaseDateIn = objvPubTeachCaseRelaInfoENS.PubClassCaseDateIn; //案例入库日期
objvPubTeachCaseRelaInfoENT.id_TeachingPlan = objvPubTeachCaseRelaInfoENS.id_TeachingPlan; //教案流水号
objvPubTeachCaseRelaInfoENT.Memo = objvPubTeachCaseRelaInfoENS.Memo; //备注
objvPubTeachCaseRelaInfoENT.FileOriginName = objvPubTeachCaseRelaInfoENS.FileOriginName; //原文件名
objvPubTeachCaseRelaInfoENT.IsExistFile = objvPubTeachCaseRelaInfoENS.IsExistFile; //是否存在文件
objvPubTeachCaseRelaInfoENT.ResourceID = objvPubTeachCaseRelaInfoENS.ResourceID; //资源ID
objvPubTeachCaseRelaInfoENT.FileNewName = objvPubTeachCaseRelaInfoENS.FileNewName; //新文件名
objvPubTeachCaseRelaInfoENT.FileOldName = objvPubTeachCaseRelaInfoENS.FileOldName; //旧文件名
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
public static DataTable ToDataTable(List<clsvPubTeachCaseRelaInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPubTeachCaseRelaInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPubTeachCaseRelaInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPubTeachCaseRelaInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPubTeachCaseRelaInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPubTeachCaseRelaInfoEN.AttributeName)
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
if (clsPubTeachCaseRelaInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubTeachCaseRelaInfoWApi没有刷新缓存机制(clsPubTeachCaseRelaInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubTeachCaseRelaInfoTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubTeachCaseRelaInfoTypeWApi没有刷新缓存机制(clsPubTeachCaseRelaInfoTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeWApi没有刷新缓存机制(clsResourceTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceWApi没有刷新缓存机制(clsResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFileServerWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerWApi没有刷新缓存机制(clsFileServerWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceWApi没有刷新缓存机制(clsFtpResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeWApi没有刷新缓存机制(clsRecommendedDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseWApi没有刷新缓存机制(clsPubClassCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingPlanWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingPlanWApi没有刷新缓存机制(clsTeachingPlanWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateGaugeVersionWApi没有刷新缓存机制(clsPubClassCaseSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubCaseTypeWApi没有刷新缓存机制(clsPubCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_PubTeachCaseRelaInfo");
//if (arrvPubTeachCaseRelaInfoObjLst_Cache == null)
//{
//arrvPubTeachCaseRelaInfoObjLst_Cache = await clsvPubTeachCaseRelaInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvPubTeachCaseRelaInfoEN._CurrTabName_S);
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
public static List<clsvPubTeachCaseRelaInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvPubTeachCaseRelaInfoEN._CurrTabName_S);
List<clsvPubTeachCaseRelaInfoEN> arrvPubTeachCaseRelaInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPubTeachCaseRelaInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPubTeachCaseRelaInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfo, Type.GetType("System.Int64"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.SubjectName, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.TeachingPlanAuthor, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.TeachingObject, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.TeachingEmphases, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.TeachingDifficulty, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.TeachingTool, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.TeachingProcess, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.id_PubCaseType, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.PubCaseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.PubCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.TeachingPlanType, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.SimplePlanContent, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.DisciplineID, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.id_PubClassCase, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.PubClassCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.PubClassCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.PubClassCaseExecutor, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.PubClassCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.PubClassCaseBG, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.PubClassCaseTeachDate, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.PubClassCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convPubTeachCaseRelaInfo.FileOldName, Type.GetType("System.String"));
foreach (clsvPubTeachCaseRelaInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfo] = objInFor[convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfo];
objDR[convPubTeachCaseRelaInfo.IsVisible] = objInFor[convPubTeachCaseRelaInfo.IsVisible];
objDR[convPubTeachCaseRelaInfo.SubjectName] = objInFor[convPubTeachCaseRelaInfo.SubjectName];
objDR[convPubTeachCaseRelaInfo.TeachingPlanAuthor] = objInFor[convPubTeachCaseRelaInfo.TeachingPlanAuthor];
objDR[convPubTeachCaseRelaInfo.TeachingObject] = objInFor[convPubTeachCaseRelaInfo.TeachingObject];
objDR[convPubTeachCaseRelaInfo.TeachingEmphases] = objInFor[convPubTeachCaseRelaInfo.TeachingEmphases];
objDR[convPubTeachCaseRelaInfo.TeachingDifficulty] = objInFor[convPubTeachCaseRelaInfo.TeachingDifficulty];
objDR[convPubTeachCaseRelaInfo.TeachingTool] = objInFor[convPubTeachCaseRelaInfo.TeachingTool];
objDR[convPubTeachCaseRelaInfo.TeachingProcess] = objInFor[convPubTeachCaseRelaInfo.TeachingProcess];
objDR[convPubTeachCaseRelaInfo.id_FtpResource] = objInFor[convPubTeachCaseRelaInfo.id_FtpResource];
objDR[convPubTeachCaseRelaInfo.FtpResourceID] = objInFor[convPubTeachCaseRelaInfo.FtpResourceID];
objDR[convPubTeachCaseRelaInfo.FileOriginalName] = objInFor[convPubTeachCaseRelaInfo.FileOriginalName];
objDR[convPubTeachCaseRelaInfo.FileDirName] = objInFor[convPubTeachCaseRelaInfo.FileDirName];
objDR[convPubTeachCaseRelaInfo.FileRename] = objInFor[convPubTeachCaseRelaInfo.FileRename];
objDR[convPubTeachCaseRelaInfo.FileUpDate] = objInFor[convPubTeachCaseRelaInfo.FileUpDate];
objDR[convPubTeachCaseRelaInfo.FileUpTime] = objInFor[convPubTeachCaseRelaInfo.FileUpTime];
objDR[convPubTeachCaseRelaInfo.id_Resource] = objInFor[convPubTeachCaseRelaInfo.id_Resource];
objDR[convPubTeachCaseRelaInfo.SaveMode] = objInFor[convPubTeachCaseRelaInfo.SaveMode];
objDR[convPubTeachCaseRelaInfo.id_ResourceType] = objInFor[convPubTeachCaseRelaInfo.id_ResourceType];
objDR[convPubTeachCaseRelaInfo.ResourceTypeID] = objInFor[convPubTeachCaseRelaInfo.ResourceTypeID];
objDR[convPubTeachCaseRelaInfo.ResourceTypeName] = objInFor[convPubTeachCaseRelaInfo.ResourceTypeName];
objDR[convPubTeachCaseRelaInfo.id_PubCaseType] = objInFor[convPubTeachCaseRelaInfo.id_PubCaseType];
objDR[convPubTeachCaseRelaInfo.PubCaseTypeID] = objInFor[convPubTeachCaseRelaInfo.PubCaseTypeID];
objDR[convPubTeachCaseRelaInfo.PubCaseTypeName] = objInFor[convPubTeachCaseRelaInfo.PubCaseTypeName];
objDR[convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType] = objInFor[convPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType];
objDR[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID] = objInFor[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID];
objDR[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName] = objInFor[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName];
objDR[convPubTeachCaseRelaInfo.TeachingPlanType] = objInFor[convPubTeachCaseRelaInfo.TeachingPlanType];
objDR[convPubTeachCaseRelaInfo.BrowseCount] = objInFor[convPubTeachCaseRelaInfo.BrowseCount];
objDR[convPubTeachCaseRelaInfo.SimplePlanContent] = objInFor[convPubTeachCaseRelaInfo.SimplePlanContent];
objDR[convPubTeachCaseRelaInfo.ResourceOwner] = objInFor[convPubTeachCaseRelaInfo.ResourceOwner];
objDR[convPubTeachCaseRelaInfo.ftpFileType] = objInFor[convPubTeachCaseRelaInfo.ftpFileType];
objDR[convPubTeachCaseRelaInfo.ftpFileSize] = objInFor[convPubTeachCaseRelaInfo.ftpFileSize];
objDR[convPubTeachCaseRelaInfo.ftpResourceOwner] = objInFor[convPubTeachCaseRelaInfo.ftpResourceOwner];
objDR[convPubTeachCaseRelaInfo.id_Discipline] = objInFor[convPubTeachCaseRelaInfo.id_Discipline];
objDR[convPubTeachCaseRelaInfo.DisciplineID] = objInFor[convPubTeachCaseRelaInfo.DisciplineID];
objDR[convPubTeachCaseRelaInfo.DisciplineName] = objInFor[convPubTeachCaseRelaInfo.DisciplineName];
objDR[convPubTeachCaseRelaInfo.id_StudyLevel] = objInFor[convPubTeachCaseRelaInfo.id_StudyLevel];
objDR[convPubTeachCaseRelaInfo.StudyLevelName] = objInFor[convPubTeachCaseRelaInfo.StudyLevelName];
objDR[convPubTeachCaseRelaInfo.id_File] = objInFor[convPubTeachCaseRelaInfo.id_File];
objDR[convPubTeachCaseRelaInfo.FileName] = objInFor[convPubTeachCaseRelaInfo.FileName];
objDR[convPubTeachCaseRelaInfo.FileType] = objInFor[convPubTeachCaseRelaInfo.FileType];
objDR[convPubTeachCaseRelaInfo.SaveDate] = objInFor[convPubTeachCaseRelaInfo.SaveDate];
objDR[convPubTeachCaseRelaInfo.FileSize] = objInFor[convPubTeachCaseRelaInfo.FileSize];
objDR[convPubTeachCaseRelaInfo.SaveTime] = objInFor[convPubTeachCaseRelaInfo.SaveTime];
objDR[convPubTeachCaseRelaInfo.id_PubClassCase] = objInFor[convPubTeachCaseRelaInfo.id_PubClassCase];
objDR[convPubTeachCaseRelaInfo.PubClassCaseID] = objInFor[convPubTeachCaseRelaInfo.PubClassCaseID];
objDR[convPubTeachCaseRelaInfo.PubClassCaseName] = objInFor[convPubTeachCaseRelaInfo.PubClassCaseName];
objDR[convPubTeachCaseRelaInfo.PubClassCaseExecutor] = objInFor[convPubTeachCaseRelaInfo.PubClassCaseExecutor];
objDR[convPubTeachCaseRelaInfo.PubClassCaseTheme] = objInFor[convPubTeachCaseRelaInfo.PubClassCaseTheme];
objDR[convPubTeachCaseRelaInfo.PubClassCaseBG] = objInFor[convPubTeachCaseRelaInfo.PubClassCaseBG];
objDR[convPubTeachCaseRelaInfo.PubClassCaseTeachDate] = objInFor[convPubTeachCaseRelaInfo.PubClassCaseTeachDate];
objDR[convPubTeachCaseRelaInfo.PubClassCaseDateIn] = objInFor[convPubTeachCaseRelaInfo.PubClassCaseDateIn];
objDR[convPubTeachCaseRelaInfo.id_TeachingPlan] = objInFor[convPubTeachCaseRelaInfo.id_TeachingPlan];
objDR[convPubTeachCaseRelaInfo.Memo] = objInFor[convPubTeachCaseRelaInfo.Memo];
objDR[convPubTeachCaseRelaInfo.FileOriginName] = objInFor[convPubTeachCaseRelaInfo.FileOriginName];
objDR[convPubTeachCaseRelaInfo.IsExistFile] = objInFor[convPubTeachCaseRelaInfo.IsExistFile];
objDR[convPubTeachCaseRelaInfo.ResourceID] = objInFor[convPubTeachCaseRelaInfo.ResourceID];
objDR[convPubTeachCaseRelaInfo.FileNewName] = objInFor[convPubTeachCaseRelaInfo.FileNewName];
objDR[convPubTeachCaseRelaInfo.FileOldName] = objInFor[convPubTeachCaseRelaInfo.FileOldName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}