
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubTeachCaseRelaInfoBL
 表名:vPubTeachCaseRelaInfo(01120400)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
public static class  clsvPubTeachCaseRelaInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPubTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubTeachCaseRelaInfoEN GetObj(this K_IdPubTeachCaseRelaInfo_vPubTeachCaseRelaInfo myKey)
{
clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = clsvPubTeachCaseRelaInfoBL.vPubTeachCaseRelaInfoDA.GetObjByIdPubTeachCaseRelaInfo(myKey.Value);
return objvPubTeachCaseRelaInfoEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetIdPubTeachCaseRelaInfo(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, long lngIdPubTeachCaseRelaInfo, string strComparisonOp="")
	{
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo = lngIdPubTeachCaseRelaInfo; //公开课案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetSubjectName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strSubjectName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSubjectName, convPubTeachCaseRelaInfo.SubjectName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubjectName, 200, convPubTeachCaseRelaInfo.SubjectName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetTeachingPlanAuthor(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strTeachingPlanAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingPlanAuthor, 50, convPubTeachCaseRelaInfo.TeachingPlanAuthor);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetTeachingObject(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strTeachingObject, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingObject, 5000, convPubTeachCaseRelaInfo.TeachingObject);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetTeachingEmphases(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strTeachingEmphases, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingEmphases, 5000, convPubTeachCaseRelaInfo.TeachingEmphases);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetTeachingDifficulty(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strTeachingDifficulty, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingDifficulty, 5000, convPubTeachCaseRelaInfo.TeachingDifficulty);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetTeachingTool(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strTeachingTool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingTool, 5000, convPubTeachCaseRelaInfo.TeachingTool);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetTeachingProcess(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strTeachingProcess, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingProcess, 8000, convPubTeachCaseRelaInfo.TeachingProcess);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetIdFtpResource(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convPubTeachCaseRelaInfo.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convPubTeachCaseRelaInfo.IdFtpResource);
}
objvPubTeachCaseRelaInfoEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.IdFtpResource) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.IdFtpResource, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdFtpResource] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFtpResourceID(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convPubTeachCaseRelaInfo.FtpResourceID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convPubTeachCaseRelaInfo.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convPubTeachCaseRelaInfo.FtpResourceID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileOriginalName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convPubTeachCaseRelaInfo.FileOriginalName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileDirName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convPubTeachCaseRelaInfo.FileDirName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileRename(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convPubTeachCaseRelaInfo.FileRename);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileUpDate(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convPubTeachCaseRelaInfo.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convPubTeachCaseRelaInfo.FileUpDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileUpTime(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convPubTeachCaseRelaInfo.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convPubTeachCaseRelaInfo.FileUpTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetIdResource(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, convPubTeachCaseRelaInfo.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convPubTeachCaseRelaInfo.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convPubTeachCaseRelaInfo.IdResource);
}
objvPubTeachCaseRelaInfoEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.IdResource) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.IdResource, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdResource] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetIdResourceType(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strIdResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResourceType, convPubTeachCaseRelaInfo.IdResourceType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convPubTeachCaseRelaInfo.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convPubTeachCaseRelaInfo.IdResourceType);
}
objvPubTeachCaseRelaInfoEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.IdResourceType) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.IdResourceType, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdResourceType] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetResourceTypeID(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convPubTeachCaseRelaInfo.ResourceTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convPubTeachCaseRelaInfo.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convPubTeachCaseRelaInfo.ResourceTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetResourceTypeName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convPubTeachCaseRelaInfo.ResourceTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convPubTeachCaseRelaInfo.ResourceTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetIdPubCaseType(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strIdPubCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubCaseType, convPubTeachCaseRelaInfo.IdPubCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubCaseType, 4, convPubTeachCaseRelaInfo.IdPubCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubCaseType, 4, convPubTeachCaseRelaInfo.IdPubCaseType);
}
objvPubTeachCaseRelaInfoEN.IdPubCaseType = strIdPubCaseType; //公开课案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.IdPubCaseType) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.IdPubCaseType, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdPubCaseType] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubCaseTypeID(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubCaseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubCaseTypeID, convPubTeachCaseRelaInfo.PubCaseTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubCaseTypeID, 4, convPubTeachCaseRelaInfo.PubCaseTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubCaseTypeID, 4, convPubTeachCaseRelaInfo.PubCaseTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubCaseTypeName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubCaseTypeName, convPubTeachCaseRelaInfo.PubCaseTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubCaseTypeName, 50, convPubTeachCaseRelaInfo.PubCaseTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetIdPubTeachCaseRelaInfoType(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strIdPubTeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubTeachCaseRelaInfoType, convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubTeachCaseRelaInfoType, 4, convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubTeachCaseRelaInfoType, 4, convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType);
}
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType = strIdPubTeachCaseRelaInfoType; //公开课案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubTeachCaseRelaInfoTypeID(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubTeachCaseRelaInfoTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubTeachCaseRelaInfoTypeID, convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubTeachCaseRelaInfoTypeID, 4, convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubTeachCaseRelaInfoTypeID, 4, convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubTeachCaseRelaInfoTypeName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubTeachCaseRelaInfoTypeName, convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubTeachCaseRelaInfoTypeName, 50, convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetTeachingPlanType(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strTeachingPlanType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingPlanType, 1, convPubTeachCaseRelaInfo.TeachingPlanType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingPlanType, 1, convPubTeachCaseRelaInfo.TeachingPlanType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetBrowseCount(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, int? intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetResourceOwner(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convPubTeachCaseRelaInfo.ResourceOwner);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convPubTeachCaseRelaInfo.ResourceOwner);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetftpFileType(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convPubTeachCaseRelaInfo.ftpFileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetftpFileSize(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convPubTeachCaseRelaInfo.ftpFileSize);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetftpResourceOwner(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convPubTeachCaseRelaInfo.ftpResourceOwner);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetIdDiscipline(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convPubTeachCaseRelaInfo.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convPubTeachCaseRelaInfo.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convPubTeachCaseRelaInfo.IdDiscipline);
}
objvPubTeachCaseRelaInfoEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.IdDiscipline) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.IdDiscipline, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdDiscipline] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetDisciplineID(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strDisciplineID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineID, convPubTeachCaseRelaInfo.DisciplineID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineID, 4, convPubTeachCaseRelaInfo.DisciplineID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDisciplineID, 4, convPubTeachCaseRelaInfo.DisciplineID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetDisciplineName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, convPubTeachCaseRelaInfo.DisciplineName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convPubTeachCaseRelaInfo.DisciplineName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetIdStudyLevel(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strIdStudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudyLevel, convPubTeachCaseRelaInfo.IdStudyLevel);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convPubTeachCaseRelaInfo.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convPubTeachCaseRelaInfo.IdStudyLevel);
}
objvPubTeachCaseRelaInfoEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.IdStudyLevel) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.IdStudyLevel, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdStudyLevel] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetStudyLevelName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convPubTeachCaseRelaInfo.StudyLevelName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convPubTeachCaseRelaInfo.StudyLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetIdFile(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convPubTeachCaseRelaInfo.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convPubTeachCaseRelaInfo.IdFile);
}
objvPubTeachCaseRelaInfoEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.IdFile) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.IdFile, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdFile] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convPubTeachCaseRelaInfo.FileName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileType(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convPubTeachCaseRelaInfo.FileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetSaveDate(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convPubTeachCaseRelaInfo.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convPubTeachCaseRelaInfo.SaveDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileSize(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convPubTeachCaseRelaInfo.FileSize);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetSaveTime(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convPubTeachCaseRelaInfo.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convPubTeachCaseRelaInfo.SaveTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetIdPubClassCase(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strIdPubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubClassCase, convPubTeachCaseRelaInfo.IdPubClassCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCase, 8, convPubTeachCaseRelaInfo.IdPubClassCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCase, 8, convPubTeachCaseRelaInfo.IdPubClassCase);
}
objvPubTeachCaseRelaInfoEN.IdPubClassCase = strIdPubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.IdPubClassCase) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.IdPubClassCase, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdPubClassCase] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubClassCaseID(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubClassCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseID, convPubTeachCaseRelaInfo.PubClassCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseID, 8, convPubTeachCaseRelaInfo.PubClassCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseID, 8, convPubTeachCaseRelaInfo.PubClassCaseID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubClassCaseName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubClassCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseName, convPubTeachCaseRelaInfo.PubClassCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseName, 200, convPubTeachCaseRelaInfo.PubClassCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubClassCaseExecutor(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubClassCaseExecutor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseExecutor, 50, convPubTeachCaseRelaInfo.PubClassCaseExecutor);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubClassCaseTheme(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubClassCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseTheme, 500, convPubTeachCaseRelaInfo.PubClassCaseTheme);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubClassCaseTeachDate(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubClassCaseTeachDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseTeachDate, 8, convPubTeachCaseRelaInfo.PubClassCaseTeachDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTeachDate, 8, convPubTeachCaseRelaInfo.PubClassCaseTeachDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetPubClassCaseDateIn(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strPubClassCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseDateIn, 8, convPubTeachCaseRelaInfo.PubClassCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseDateIn, 8, convPubTeachCaseRelaInfo.PubClassCaseDateIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetIdTeachingPlan(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strIdTeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachingPlan, convPubTeachCaseRelaInfo.IdTeachingPlan);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convPubTeachCaseRelaInfo.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convPubTeachCaseRelaInfo.IdTeachingPlan);
}
objvPubTeachCaseRelaInfoEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convPubTeachCaseRelaInfo.IdTeachingPlan) == false)
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(convPubTeachCaseRelaInfo.IdTeachingPlan, strComparisonOp);
}
else
{
objvPubTeachCaseRelaInfoEN.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdTeachingPlan] = strComparisonOp;
}
}
return objvPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetMemo(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPubTeachCaseRelaInfo.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileOriginName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convPubTeachCaseRelaInfo.FileOriginName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetResourceID(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convPubTeachCaseRelaInfo.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convPubTeachCaseRelaInfo.ResourceID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileNewName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convPubTeachCaseRelaInfo.FileNewName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubTeachCaseRelaInfoEN SetFileOldName(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convPubTeachCaseRelaInfo.FileOldName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoENS">源对象</param>
 /// <param name = "objvPubTeachCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoENS, clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoENT)
{
try
{
objvPubTeachCaseRelaInfoENT.IdPubTeachCaseRelaInfo = objvPubTeachCaseRelaInfoENS.IdPubTeachCaseRelaInfo; //公开课案例相关信息流水号
objvPubTeachCaseRelaInfoENT.IsVisible = objvPubTeachCaseRelaInfoENS.IsVisible; //是否显示
objvPubTeachCaseRelaInfoENT.SubjectName = objvPubTeachCaseRelaInfoENS.SubjectName; //课题名称
objvPubTeachCaseRelaInfoENT.TeachingPlanAuthor = objvPubTeachCaseRelaInfoENS.TeachingPlanAuthor; //教案撰写人
objvPubTeachCaseRelaInfoENT.TeachingObject = objvPubTeachCaseRelaInfoENS.TeachingObject; //教学目标
objvPubTeachCaseRelaInfoENT.TeachingEmphases = objvPubTeachCaseRelaInfoENS.TeachingEmphases; //教学重点
objvPubTeachCaseRelaInfoENT.TeachingDifficulty = objvPubTeachCaseRelaInfoENS.TeachingDifficulty; //教学难点
objvPubTeachCaseRelaInfoENT.TeachingTool = objvPubTeachCaseRelaInfoENS.TeachingTool; //教学用具
objvPubTeachCaseRelaInfoENT.TeachingProcess = objvPubTeachCaseRelaInfoENS.TeachingProcess; //教学过程
objvPubTeachCaseRelaInfoENT.IdFtpResource = objvPubTeachCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvPubTeachCaseRelaInfoENT.FtpResourceID = objvPubTeachCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvPubTeachCaseRelaInfoENT.FileOriginalName = objvPubTeachCaseRelaInfoENS.FileOriginalName; //文件原名
objvPubTeachCaseRelaInfoENT.FileDirName = objvPubTeachCaseRelaInfoENS.FileDirName; //文件目录名
objvPubTeachCaseRelaInfoENT.FileRename = objvPubTeachCaseRelaInfoENS.FileRename; //文件新名
objvPubTeachCaseRelaInfoENT.FileUpDate = objvPubTeachCaseRelaInfoENS.FileUpDate; //创建日期
objvPubTeachCaseRelaInfoENT.FileUpTime = objvPubTeachCaseRelaInfoENS.FileUpTime; //创建时间
objvPubTeachCaseRelaInfoENT.IdResource = objvPubTeachCaseRelaInfoENS.IdResource; //资源流水号
objvPubTeachCaseRelaInfoENT.SaveMode = objvPubTeachCaseRelaInfoENS.SaveMode; //文件存放方式
objvPubTeachCaseRelaInfoENT.IdResourceType = objvPubTeachCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvPubTeachCaseRelaInfoENT.ResourceTypeID = objvPubTeachCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvPubTeachCaseRelaInfoENT.ResourceTypeName = objvPubTeachCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvPubTeachCaseRelaInfoENT.IdPubCaseType = objvPubTeachCaseRelaInfoENS.IdPubCaseType; //公开课案例类型流水号
objvPubTeachCaseRelaInfoENT.PubCaseTypeID = objvPubTeachCaseRelaInfoENS.PubCaseTypeID; //公开课案例类型ID
objvPubTeachCaseRelaInfoENT.PubCaseTypeName = objvPubTeachCaseRelaInfoENS.PubCaseTypeName; //公开课案例类型名称
objvPubTeachCaseRelaInfoENT.IdPubTeachCaseRelaInfoType = objvPubTeachCaseRelaInfoENS.IdPubTeachCaseRelaInfoType; //公开课案例相关信息类型流水号
objvPubTeachCaseRelaInfoENT.PubTeachCaseRelaInfoTypeID = objvPubTeachCaseRelaInfoENS.PubTeachCaseRelaInfoTypeID; //公开课案例相关信息类型ID
objvPubTeachCaseRelaInfoENT.PubTeachCaseRelaInfoTypeName = objvPubTeachCaseRelaInfoENS.PubTeachCaseRelaInfoTypeName; //公开课案例相关信息类型名称
objvPubTeachCaseRelaInfoENT.TeachingPlanType = objvPubTeachCaseRelaInfoENS.TeachingPlanType; //教案类型
objvPubTeachCaseRelaInfoENT.BrowseCount = objvPubTeachCaseRelaInfoENS.BrowseCount; //浏览次数
objvPubTeachCaseRelaInfoENT.SimplePlanContent = objvPubTeachCaseRelaInfoENS.SimplePlanContent; //简案内容
objvPubTeachCaseRelaInfoENT.ResourceOwner = objvPubTeachCaseRelaInfoENS.ResourceOwner; //上传者
objvPubTeachCaseRelaInfoENT.ftpFileType = objvPubTeachCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvPubTeachCaseRelaInfoENT.ftpFileSize = objvPubTeachCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvPubTeachCaseRelaInfoENT.ftpResourceOwner = objvPubTeachCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvPubTeachCaseRelaInfoENT.IdDiscipline = objvPubTeachCaseRelaInfoENS.IdDiscipline; //学科流水号
objvPubTeachCaseRelaInfoENT.DisciplineID = objvPubTeachCaseRelaInfoENS.DisciplineID; //学科ID
objvPubTeachCaseRelaInfoENT.DisciplineName = objvPubTeachCaseRelaInfoENS.DisciplineName; //学科名称
objvPubTeachCaseRelaInfoENT.IdStudyLevel = objvPubTeachCaseRelaInfoENS.IdStudyLevel; //id_StudyLevel
objvPubTeachCaseRelaInfoENT.StudyLevelName = objvPubTeachCaseRelaInfoENS.StudyLevelName; //学段名称
objvPubTeachCaseRelaInfoENT.IdFile = objvPubTeachCaseRelaInfoENS.IdFile; //文件流水号
objvPubTeachCaseRelaInfoENT.FileName = objvPubTeachCaseRelaInfoENS.FileName; //文件名称
objvPubTeachCaseRelaInfoENT.FileType = objvPubTeachCaseRelaInfoENS.FileType; //文件类型
objvPubTeachCaseRelaInfoENT.SaveDate = objvPubTeachCaseRelaInfoENS.SaveDate; //创建日期
objvPubTeachCaseRelaInfoENT.FileSize = objvPubTeachCaseRelaInfoENS.FileSize; //文件大小
objvPubTeachCaseRelaInfoENT.SaveTime = objvPubTeachCaseRelaInfoENS.SaveTime; //创建时间
objvPubTeachCaseRelaInfoENT.IdPubClassCase = objvPubTeachCaseRelaInfoENS.IdPubClassCase; //案例流水号
objvPubTeachCaseRelaInfoENT.PubClassCaseID = objvPubTeachCaseRelaInfoENS.PubClassCaseID; //案例ID
objvPubTeachCaseRelaInfoENT.PubClassCaseName = objvPubTeachCaseRelaInfoENS.PubClassCaseName; //案例课题名称
objvPubTeachCaseRelaInfoENT.PubClassCaseExecutor = objvPubTeachCaseRelaInfoENS.PubClassCaseExecutor; //案例执教者
objvPubTeachCaseRelaInfoENT.PubClassCaseTheme = objvPubTeachCaseRelaInfoENS.PubClassCaseTheme; //案例主题词
objvPubTeachCaseRelaInfoENT.PubClassCaseBG = objvPubTeachCaseRelaInfoENS.PubClassCaseBG; //案例背景资料
objvPubTeachCaseRelaInfoENT.PubClassCaseTeachDate = objvPubTeachCaseRelaInfoENS.PubClassCaseTeachDate; //案例授课日期
objvPubTeachCaseRelaInfoENT.PubClassCaseDateIn = objvPubTeachCaseRelaInfoENS.PubClassCaseDateIn; //案例入库日期
objvPubTeachCaseRelaInfoENT.IdTeachingPlan = objvPubTeachCaseRelaInfoENS.IdTeachingPlan; //教案流水号
objvPubTeachCaseRelaInfoENT.Memo = objvPubTeachCaseRelaInfoENS.Memo; //备注
objvPubTeachCaseRelaInfoENT.FileOriginName = objvPubTeachCaseRelaInfoENS.FileOriginName; //原文件名
objvPubTeachCaseRelaInfoENT.IsExistFile = objvPubTeachCaseRelaInfoENS.IsExistFile; //是否存在文件
objvPubTeachCaseRelaInfoENT.ResourceID = objvPubTeachCaseRelaInfoENS.ResourceID; //资源ID
objvPubTeachCaseRelaInfoENT.FileNewName = objvPubTeachCaseRelaInfoENS.FileNewName; //新文件名
objvPubTeachCaseRelaInfoENT.FileOldName = objvPubTeachCaseRelaInfoENS.FileOldName; //旧文件名
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
 /// <param name = "objvPubTeachCaseRelaInfoENS">源对象</param>
 /// <returns>目标对象=>clsvPubTeachCaseRelaInfoEN:objvPubTeachCaseRelaInfoENT</returns>
 public static clsvPubTeachCaseRelaInfoEN CopyTo(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoENS)
{
try
{
 clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoENT = new clsvPubTeachCaseRelaInfoEN()
{
IdPubTeachCaseRelaInfo = objvPubTeachCaseRelaInfoENS.IdPubTeachCaseRelaInfo, //公开课案例相关信息流水号
IsVisible = objvPubTeachCaseRelaInfoENS.IsVisible, //是否显示
SubjectName = objvPubTeachCaseRelaInfoENS.SubjectName, //课题名称
TeachingPlanAuthor = objvPubTeachCaseRelaInfoENS.TeachingPlanAuthor, //教案撰写人
TeachingObject = objvPubTeachCaseRelaInfoENS.TeachingObject, //教学目标
TeachingEmphases = objvPubTeachCaseRelaInfoENS.TeachingEmphases, //教学重点
TeachingDifficulty = objvPubTeachCaseRelaInfoENS.TeachingDifficulty, //教学难点
TeachingTool = objvPubTeachCaseRelaInfoENS.TeachingTool, //教学用具
TeachingProcess = objvPubTeachCaseRelaInfoENS.TeachingProcess, //教学过程
IdFtpResource = objvPubTeachCaseRelaInfoENS.IdFtpResource, //FTP资源流水号
FtpResourceID = objvPubTeachCaseRelaInfoENS.FtpResourceID, //FTP资源ID
FileOriginalName = objvPubTeachCaseRelaInfoENS.FileOriginalName, //文件原名
FileDirName = objvPubTeachCaseRelaInfoENS.FileDirName, //文件目录名
FileRename = objvPubTeachCaseRelaInfoENS.FileRename, //文件新名
FileUpDate = objvPubTeachCaseRelaInfoENS.FileUpDate, //创建日期
FileUpTime = objvPubTeachCaseRelaInfoENS.FileUpTime, //创建时间
IdResource = objvPubTeachCaseRelaInfoENS.IdResource, //资源流水号
SaveMode = objvPubTeachCaseRelaInfoENS.SaveMode, //文件存放方式
IdResourceType = objvPubTeachCaseRelaInfoENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvPubTeachCaseRelaInfoENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvPubTeachCaseRelaInfoENS.ResourceTypeName, //资源类型名称
IdPubCaseType = objvPubTeachCaseRelaInfoENS.IdPubCaseType, //公开课案例类型流水号
PubCaseTypeID = objvPubTeachCaseRelaInfoENS.PubCaseTypeID, //公开课案例类型ID
PubCaseTypeName = objvPubTeachCaseRelaInfoENS.PubCaseTypeName, //公开课案例类型名称
IdPubTeachCaseRelaInfoType = objvPubTeachCaseRelaInfoENS.IdPubTeachCaseRelaInfoType, //公开课案例相关信息类型流水号
PubTeachCaseRelaInfoTypeID = objvPubTeachCaseRelaInfoENS.PubTeachCaseRelaInfoTypeID, //公开课案例相关信息类型ID
PubTeachCaseRelaInfoTypeName = objvPubTeachCaseRelaInfoENS.PubTeachCaseRelaInfoTypeName, //公开课案例相关信息类型名称
TeachingPlanType = objvPubTeachCaseRelaInfoENS.TeachingPlanType, //教案类型
BrowseCount = objvPubTeachCaseRelaInfoENS.BrowseCount, //浏览次数
SimplePlanContent = objvPubTeachCaseRelaInfoENS.SimplePlanContent, //简案内容
ResourceOwner = objvPubTeachCaseRelaInfoENS.ResourceOwner, //上传者
ftpFileType = objvPubTeachCaseRelaInfoENS.ftpFileType, //ftp文件类型
ftpFileSize = objvPubTeachCaseRelaInfoENS.ftpFileSize, //ftp文件大小
ftpResourceOwner = objvPubTeachCaseRelaInfoENS.ftpResourceOwner, //Ftp资源拥有者
IdDiscipline = objvPubTeachCaseRelaInfoENS.IdDiscipline, //学科流水号
DisciplineID = objvPubTeachCaseRelaInfoENS.DisciplineID, //学科ID
DisciplineName = objvPubTeachCaseRelaInfoENS.DisciplineName, //学科名称
IdStudyLevel = objvPubTeachCaseRelaInfoENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvPubTeachCaseRelaInfoENS.StudyLevelName, //学段名称
IdFile = objvPubTeachCaseRelaInfoENS.IdFile, //文件流水号
FileName = objvPubTeachCaseRelaInfoENS.FileName, //文件名称
FileType = objvPubTeachCaseRelaInfoENS.FileType, //文件类型
SaveDate = objvPubTeachCaseRelaInfoENS.SaveDate, //创建日期
FileSize = objvPubTeachCaseRelaInfoENS.FileSize, //文件大小
SaveTime = objvPubTeachCaseRelaInfoENS.SaveTime, //创建时间
IdPubClassCase = objvPubTeachCaseRelaInfoENS.IdPubClassCase, //案例流水号
PubClassCaseID = objvPubTeachCaseRelaInfoENS.PubClassCaseID, //案例ID
PubClassCaseName = objvPubTeachCaseRelaInfoENS.PubClassCaseName, //案例课题名称
PubClassCaseExecutor = objvPubTeachCaseRelaInfoENS.PubClassCaseExecutor, //案例执教者
PubClassCaseTheme = objvPubTeachCaseRelaInfoENS.PubClassCaseTheme, //案例主题词
PubClassCaseBG = objvPubTeachCaseRelaInfoENS.PubClassCaseBG, //案例背景资料
PubClassCaseTeachDate = objvPubTeachCaseRelaInfoENS.PubClassCaseTeachDate, //案例授课日期
PubClassCaseDateIn = objvPubTeachCaseRelaInfoENS.PubClassCaseDateIn, //案例入库日期
IdTeachingPlan = objvPubTeachCaseRelaInfoENS.IdTeachingPlan, //教案流水号
Memo = objvPubTeachCaseRelaInfoENS.Memo, //备注
FileOriginName = objvPubTeachCaseRelaInfoENS.FileOriginName, //原文件名
IsExistFile = objvPubTeachCaseRelaInfoENS.IsExistFile, //是否存在文件
ResourceID = objvPubTeachCaseRelaInfoENS.ResourceID, //资源ID
FileNewName = objvPubTeachCaseRelaInfoENS.FileNewName, //新文件名
FileOldName = objvPubTeachCaseRelaInfoENS.FileOldName, //旧文件名
};
 return objvPubTeachCaseRelaInfoENT;
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
public static void CheckProperty4Condition(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN)
{
 clsvPubTeachCaseRelaInfoBL.vPubTeachCaseRelaInfoDA.CheckProperty4Condition(objvPubTeachCaseRelaInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo) == true)
{
string strComparisonOpIdPubTeachCaseRelaInfo = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo, objvPubTeachCaseRelaInfoCond.IdPubTeachCaseRelaInfo, strComparisonOpIdPubTeachCaseRelaInfo);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.IsVisible) == true)
{
if (objvPubTeachCaseRelaInfoCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubTeachCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubTeachCaseRelaInfo.IsVisible);
}
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.SubjectName) == true)
{
string strComparisonOpSubjectName = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.SubjectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.SubjectName, objvPubTeachCaseRelaInfoCond.SubjectName, strComparisonOpSubjectName);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.TeachingPlanAuthor) == true)
{
string strComparisonOpTeachingPlanAuthor = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingPlanAuthor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.TeachingPlanAuthor, objvPubTeachCaseRelaInfoCond.TeachingPlanAuthor, strComparisonOpTeachingPlanAuthor);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.TeachingObject) == true)
{
string strComparisonOpTeachingObject = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingObject];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.TeachingObject, objvPubTeachCaseRelaInfoCond.TeachingObject, strComparisonOpTeachingObject);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.TeachingEmphases) == true)
{
string strComparisonOpTeachingEmphases = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingEmphases];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.TeachingEmphases, objvPubTeachCaseRelaInfoCond.TeachingEmphases, strComparisonOpTeachingEmphases);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.TeachingDifficulty) == true)
{
string strComparisonOpTeachingDifficulty = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingDifficulty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.TeachingDifficulty, objvPubTeachCaseRelaInfoCond.TeachingDifficulty, strComparisonOpTeachingDifficulty);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.TeachingTool) == true)
{
string strComparisonOpTeachingTool = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingTool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.TeachingTool, objvPubTeachCaseRelaInfoCond.TeachingTool, strComparisonOpTeachingTool);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.TeachingProcess) == true)
{
string strComparisonOpTeachingProcess = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingProcess];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.TeachingProcess, objvPubTeachCaseRelaInfoCond.TeachingProcess, strComparisonOpTeachingProcess);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.IdFtpResource, objvPubTeachCaseRelaInfoCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FtpResourceID, objvPubTeachCaseRelaInfoCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileOriginalName, objvPubTeachCaseRelaInfoCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.FileDirName) == true)
{
string strComparisonOpFileDirName = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileDirName, objvPubTeachCaseRelaInfoCond.FileDirName, strComparisonOpFileDirName);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.FileRename) == true)
{
string strComparisonOpFileRename = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileRename, objvPubTeachCaseRelaInfoCond.FileRename, strComparisonOpFileRename);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileUpDate, objvPubTeachCaseRelaInfoCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileUpTime, objvPubTeachCaseRelaInfoCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.IdResource) == true)
{
string strComparisonOpIdResource = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.IdResource, objvPubTeachCaseRelaInfoCond.IdResource, strComparisonOpIdResource);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.SaveMode) == true)
{
if (objvPubTeachCaseRelaInfoCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubTeachCaseRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubTeachCaseRelaInfo.SaveMode);
}
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.IdResourceType, objvPubTeachCaseRelaInfoCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.ResourceTypeID, objvPubTeachCaseRelaInfoCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.ResourceTypeName, objvPubTeachCaseRelaInfoCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.IdPubCaseType) == true)
{
string strComparisonOpIdPubCaseType = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdPubCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.IdPubCaseType, objvPubTeachCaseRelaInfoCond.IdPubCaseType, strComparisonOpIdPubCaseType);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.PubCaseTypeID) == true)
{
string strComparisonOpPubCaseTypeID = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubCaseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubCaseTypeID, objvPubTeachCaseRelaInfoCond.PubCaseTypeID, strComparisonOpPubCaseTypeID);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.PubCaseTypeName) == true)
{
string strComparisonOpPubCaseTypeName = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubCaseTypeName, objvPubTeachCaseRelaInfoCond.PubCaseTypeName, strComparisonOpPubCaseTypeName);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType) == true)
{
string strComparisonOpIdPubTeachCaseRelaInfoType = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType, objvPubTeachCaseRelaInfoCond.IdPubTeachCaseRelaInfoType, strComparisonOpIdPubTeachCaseRelaInfoType);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID) == true)
{
string strComparisonOpPubTeachCaseRelaInfoTypeID = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID, objvPubTeachCaseRelaInfoCond.PubTeachCaseRelaInfoTypeID, strComparisonOpPubTeachCaseRelaInfoTypeID);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOpPubTeachCaseRelaInfoTypeName = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName, objvPubTeachCaseRelaInfoCond.PubTeachCaseRelaInfoTypeName, strComparisonOpPubTeachCaseRelaInfoTypeName);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.TeachingPlanType) == true)
{
string strComparisonOpTeachingPlanType = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.TeachingPlanType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.TeachingPlanType, objvPubTeachCaseRelaInfoCond.TeachingPlanType, strComparisonOpTeachingPlanType);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPubTeachCaseRelaInfo.BrowseCount, objvPubTeachCaseRelaInfoCond.BrowseCount, strComparisonOpBrowseCount);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.ResourceOwner, objvPubTeachCaseRelaInfoCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.ftpFileType, objvPubTeachCaseRelaInfoCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.ftpFileSize) == true)
{
string strComparisonOpftpFileSize = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.ftpFileSize, objvPubTeachCaseRelaInfoCond.ftpFileSize, strComparisonOpftpFileSize);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOpftpResourceOwner = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.ftpResourceOwner, objvPubTeachCaseRelaInfoCond.ftpResourceOwner, strComparisonOpftpResourceOwner);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.IdDiscipline, objvPubTeachCaseRelaInfoCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.DisciplineID) == true)
{
string strComparisonOpDisciplineID = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.DisciplineID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.DisciplineID, objvPubTeachCaseRelaInfoCond.DisciplineID, strComparisonOpDisciplineID);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.DisciplineName, objvPubTeachCaseRelaInfoCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.IdStudyLevel, objvPubTeachCaseRelaInfoCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.StudyLevelName, objvPubTeachCaseRelaInfoCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.IdFile) == true)
{
string strComparisonOpIdFile = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.IdFile, objvPubTeachCaseRelaInfoCond.IdFile, strComparisonOpIdFile);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.FileName) == true)
{
string strComparisonOpFileName = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileName, objvPubTeachCaseRelaInfoCond.FileName, strComparisonOpFileName);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.FileType) == true)
{
string strComparisonOpFileType = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileType, objvPubTeachCaseRelaInfoCond.FileType, strComparisonOpFileType);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.SaveDate) == true)
{
string strComparisonOpSaveDate = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.SaveDate, objvPubTeachCaseRelaInfoCond.SaveDate, strComparisonOpSaveDate);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.FileSize) == true)
{
string strComparisonOpFileSize = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileSize, objvPubTeachCaseRelaInfoCond.FileSize, strComparisonOpFileSize);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.SaveTime) == true)
{
string strComparisonOpSaveTime = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.SaveTime, objvPubTeachCaseRelaInfoCond.SaveTime, strComparisonOpSaveTime);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.IdPubClassCase) == true)
{
string strComparisonOpIdPubClassCase = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdPubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.IdPubClassCase, objvPubTeachCaseRelaInfoCond.IdPubClassCase, strComparisonOpIdPubClassCase);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.PubClassCaseID) == true)
{
string strComparisonOpPubClassCaseID = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubClassCaseID, objvPubTeachCaseRelaInfoCond.PubClassCaseID, strComparisonOpPubClassCaseID);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.PubClassCaseName) == true)
{
string strComparisonOpPubClassCaseName = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubClassCaseName, objvPubTeachCaseRelaInfoCond.PubClassCaseName, strComparisonOpPubClassCaseName);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.PubClassCaseExecutor) == true)
{
string strComparisonOpPubClassCaseExecutor = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubClassCaseExecutor, objvPubTeachCaseRelaInfoCond.PubClassCaseExecutor, strComparisonOpPubClassCaseExecutor);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.PubClassCaseTheme) == true)
{
string strComparisonOpPubClassCaseTheme = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubClassCaseTheme, objvPubTeachCaseRelaInfoCond.PubClassCaseTheme, strComparisonOpPubClassCaseTheme);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.PubClassCaseTeachDate) == true)
{
string strComparisonOpPubClassCaseTeachDate = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseTeachDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubClassCaseTeachDate, objvPubTeachCaseRelaInfoCond.PubClassCaseTeachDate, strComparisonOpPubClassCaseTeachDate);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.PubClassCaseDateIn) == true)
{
string strComparisonOpPubClassCaseDateIn = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.PubClassCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.PubClassCaseDateIn, objvPubTeachCaseRelaInfoCond.PubClassCaseDateIn, strComparisonOpPubClassCaseDateIn);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.IdTeachingPlan, objvPubTeachCaseRelaInfoCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.Memo) == true)
{
string strComparisonOpMemo = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.Memo, objvPubTeachCaseRelaInfoCond.Memo, strComparisonOpMemo);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileOriginName, objvPubTeachCaseRelaInfoCond.FileOriginName, strComparisonOpFileOriginName);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.IsExistFile) == true)
{
if (objvPubTeachCaseRelaInfoCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubTeachCaseRelaInfo.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubTeachCaseRelaInfo.IsExistFile);
}
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.ResourceID) == true)
{
string strComparisonOpResourceID = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.ResourceID, objvPubTeachCaseRelaInfoCond.ResourceID, strComparisonOpResourceID);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.FileNewName) == true)
{
string strComparisonOpFileNewName = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileNewName, objvPubTeachCaseRelaInfoCond.FileNewName, strComparisonOpFileNewName);
}
if (objvPubTeachCaseRelaInfoCond.IsUpdated(convPubTeachCaseRelaInfo.FileOldName) == true)
{
string strComparisonOpFileOldName = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[convPubTeachCaseRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubTeachCaseRelaInfo.FileOldName, objvPubTeachCaseRelaInfoCond.FileOldName, strComparisonOpFileOldName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPubTeachCaseRelaInfo
{
public virtual bool UpdRelaTabDate(long lngIdPubTeachCaseRelaInfo, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v公开课案例相关信息(vPubTeachCaseRelaInfo)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPubTeachCaseRelaInfoBL
{
public static RelatedActions_vPubTeachCaseRelaInfo relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPubTeachCaseRelaInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPubTeachCaseRelaInfoDA vPubTeachCaseRelaInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPubTeachCaseRelaInfoDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPubTeachCaseRelaInfoBL()
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
if (string.IsNullOrEmpty(clsvPubTeachCaseRelaInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPubTeachCaseRelaInfoEN._ConnectString);
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
public static DataTable GetDataTable_vPubTeachCaseRelaInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPubTeachCaseRelaInfoDA.GetDataTable_vPubTeachCaseRelaInfo(strWhereCond);
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
objDT = vPubTeachCaseRelaInfoDA.GetDataTable(strWhereCond);
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
objDT = vPubTeachCaseRelaInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPubTeachCaseRelaInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPubTeachCaseRelaInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPubTeachCaseRelaInfoDA.GetDataTable_Top(objTopPara);
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
objDT = vPubTeachCaseRelaInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPubTeachCaseRelaInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPubTeachCaseRelaInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdPubTeachCaseRelaInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPubTeachCaseRelaInfoEN> GetObjLstByIdPubTeachCaseRelaInfoLst(List<long> arrIdPubTeachCaseRelaInfoLst)
{
List<clsvPubTeachCaseRelaInfoEN> arrObjLst = new List<clsvPubTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdPubTeachCaseRelaInfoLst);
 string strWhereCond = string.Format("IdPubTeachCaseRelaInfo in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = new clsvPubTeachCaseRelaInfoEN();
try
{
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo = Int32.Parse(objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo].ToString().Trim()); //公开课案例相关信息流水号
objvPubTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvPubTeachCaseRelaInfoEN.SubjectName = objRow[convPubTeachCaseRelaInfo.SubjectName].ToString().Trim(); //课题名称
objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubTeachCaseRelaInfoEN.TeachingObject = objRow[convPubTeachCaseRelaInfo.TeachingObject] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingObject].ToString().Trim(); //教学目标
objvPubTeachCaseRelaInfoEN.TeachingEmphases = objRow[convPubTeachCaseRelaInfo.TeachingEmphases] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingEmphases].ToString().Trim(); //教学重点
objvPubTeachCaseRelaInfoEN.TeachingDifficulty = objRow[convPubTeachCaseRelaInfo.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubTeachCaseRelaInfoEN.TeachingTool = objRow[convPubTeachCaseRelaInfo.TeachingTool] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingTool].ToString().Trim(); //教学用具
objvPubTeachCaseRelaInfoEN.TeachingProcess = objRow[convPubTeachCaseRelaInfo.TeachingProcess] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingProcess].ToString().Trim(); //教学过程
objvPubTeachCaseRelaInfoEN.IdFtpResource = objRow[convPubTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubTeachCaseRelaInfoEN.FtpResourceID = objRow[convPubTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubTeachCaseRelaInfoEN.FileOriginalName = objRow[convPubTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvPubTeachCaseRelaInfoEN.FileDirName = objRow[convPubTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvPubTeachCaseRelaInfoEN.FileRename = objRow[convPubTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvPubTeachCaseRelaInfoEN.FileUpDate = objRow[convPubTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileUpTime = objRow[convPubTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdResource = objRow[convPubTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvPubTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvPubTeachCaseRelaInfoEN.IdResourceType = objRow[convPubTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubTeachCaseRelaInfoEN.ResourceTypeID = objRow[convPubTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubTeachCaseRelaInfoEN.ResourceTypeName = objRow[convPubTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubTeachCaseRelaInfoEN.IdPubCaseType = objRow[convPubTeachCaseRelaInfo.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubTeachCaseRelaInfoEN.PubCaseTypeID = objRow[convPubTeachCaseRelaInfo.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubTeachCaseRelaInfoEN.PubCaseTypeName = objRow[convPubTeachCaseRelaInfo.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType = objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType].ToString().Trim(); //公开课案例相关信息类型流水号
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID].ToString().Trim(); //公开课案例相关信息类型ID
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName].ToString().Trim(); //公开课案例相关信息类型名称
objvPubTeachCaseRelaInfoEN.TeachingPlanType = objRow[convPubTeachCaseRelaInfo.TeachingPlanType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanType].ToString().Trim(); //教案类型
objvPubTeachCaseRelaInfoEN.BrowseCount = objRow[convPubTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvPubTeachCaseRelaInfoEN.SimplePlanContent = objRow[convPubTeachCaseRelaInfo.SimplePlanContent] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SimplePlanContent].ToString().Trim(); //简案内容
objvPubTeachCaseRelaInfoEN.ResourceOwner = objRow[convPubTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvPubTeachCaseRelaInfoEN.ftpFileType = objRow[convPubTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubTeachCaseRelaInfoEN.ftpFileSize = objRow[convPubTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convPubTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubTeachCaseRelaInfoEN.IdDiscipline = objRow[convPubTeachCaseRelaInfo.IdDiscipline].ToString().Trim(); //学科流水号
objvPubTeachCaseRelaInfoEN.DisciplineID = objRow[convPubTeachCaseRelaInfo.DisciplineID].ToString().Trim(); //学科ID
objvPubTeachCaseRelaInfoEN.DisciplineName = objRow[convPubTeachCaseRelaInfo.DisciplineName].ToString().Trim(); //学科名称
objvPubTeachCaseRelaInfoEN.IdStudyLevel = objRow[convPubTeachCaseRelaInfo.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubTeachCaseRelaInfoEN.StudyLevelName = objRow[convPubTeachCaseRelaInfo.StudyLevelName].ToString().Trim(); //学段名称
objvPubTeachCaseRelaInfoEN.IdFile = objRow[convPubTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvPubTeachCaseRelaInfoEN.FileName = objRow[convPubTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvPubTeachCaseRelaInfoEN.FileType = objRow[convPubTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvPubTeachCaseRelaInfoEN.SaveDate = objRow[convPubTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileSize = objRow[convPubTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvPubTeachCaseRelaInfoEN.SaveTime = objRow[convPubTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdPubClassCase = objRow[convPubTeachCaseRelaInfo.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubTeachCaseRelaInfoEN.PubClassCaseID = objRow[convPubTeachCaseRelaInfo.PubClassCaseID].ToString().Trim(); //案例ID
objvPubTeachCaseRelaInfoEN.PubClassCaseName = objRow[convPubTeachCaseRelaInfo.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubTeachCaseRelaInfoEN.PubClassCaseBG = objRow[convPubTeachCaseRelaInfo.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubTeachCaseRelaInfoEN.IdTeachingPlan = objRow[convPubTeachCaseRelaInfo.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubTeachCaseRelaInfoEN.Memo = objRow[convPubTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
objvPubTeachCaseRelaInfoEN.FileOriginName = objRow[convPubTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvPubTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvPubTeachCaseRelaInfoEN.ResourceID = objRow[convPubTeachCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvPubTeachCaseRelaInfoEN.FileNewName = objRow[convPubTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvPubTeachCaseRelaInfoEN.FileOldName = objRow[convPubTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdPubTeachCaseRelaInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPubTeachCaseRelaInfoEN> GetObjLstByIdPubTeachCaseRelaInfoLstCache(List<long> arrIdPubTeachCaseRelaInfoLst)
{
string strKey = string.Format("{0}", clsvPubTeachCaseRelaInfoEN._CurrTabName);
List<clsvPubTeachCaseRelaInfoEN> arrvPubTeachCaseRelaInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvPubTeachCaseRelaInfoEN> arrvPubTeachCaseRelaInfoObjLst_Sel =
arrvPubTeachCaseRelaInfoObjLstCache
.Where(x => arrIdPubTeachCaseRelaInfoLst.Contains(x.IdPubTeachCaseRelaInfo));
return arrvPubTeachCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubTeachCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
List<clsvPubTeachCaseRelaInfoEN> arrObjLst = new List<clsvPubTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = new clsvPubTeachCaseRelaInfoEN();
try
{
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo = Int32.Parse(objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo].ToString().Trim()); //公开课案例相关信息流水号
objvPubTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvPubTeachCaseRelaInfoEN.SubjectName = objRow[convPubTeachCaseRelaInfo.SubjectName].ToString().Trim(); //课题名称
objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubTeachCaseRelaInfoEN.TeachingObject = objRow[convPubTeachCaseRelaInfo.TeachingObject] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingObject].ToString().Trim(); //教学目标
objvPubTeachCaseRelaInfoEN.TeachingEmphases = objRow[convPubTeachCaseRelaInfo.TeachingEmphases] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingEmphases].ToString().Trim(); //教学重点
objvPubTeachCaseRelaInfoEN.TeachingDifficulty = objRow[convPubTeachCaseRelaInfo.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubTeachCaseRelaInfoEN.TeachingTool = objRow[convPubTeachCaseRelaInfo.TeachingTool] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingTool].ToString().Trim(); //教学用具
objvPubTeachCaseRelaInfoEN.TeachingProcess = objRow[convPubTeachCaseRelaInfo.TeachingProcess] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingProcess].ToString().Trim(); //教学过程
objvPubTeachCaseRelaInfoEN.IdFtpResource = objRow[convPubTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubTeachCaseRelaInfoEN.FtpResourceID = objRow[convPubTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubTeachCaseRelaInfoEN.FileOriginalName = objRow[convPubTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvPubTeachCaseRelaInfoEN.FileDirName = objRow[convPubTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvPubTeachCaseRelaInfoEN.FileRename = objRow[convPubTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvPubTeachCaseRelaInfoEN.FileUpDate = objRow[convPubTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileUpTime = objRow[convPubTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdResource = objRow[convPubTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvPubTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvPubTeachCaseRelaInfoEN.IdResourceType = objRow[convPubTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubTeachCaseRelaInfoEN.ResourceTypeID = objRow[convPubTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubTeachCaseRelaInfoEN.ResourceTypeName = objRow[convPubTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubTeachCaseRelaInfoEN.IdPubCaseType = objRow[convPubTeachCaseRelaInfo.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubTeachCaseRelaInfoEN.PubCaseTypeID = objRow[convPubTeachCaseRelaInfo.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubTeachCaseRelaInfoEN.PubCaseTypeName = objRow[convPubTeachCaseRelaInfo.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType = objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType].ToString().Trim(); //公开课案例相关信息类型流水号
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID].ToString().Trim(); //公开课案例相关信息类型ID
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName].ToString().Trim(); //公开课案例相关信息类型名称
objvPubTeachCaseRelaInfoEN.TeachingPlanType = objRow[convPubTeachCaseRelaInfo.TeachingPlanType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanType].ToString().Trim(); //教案类型
objvPubTeachCaseRelaInfoEN.BrowseCount = objRow[convPubTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvPubTeachCaseRelaInfoEN.SimplePlanContent = objRow[convPubTeachCaseRelaInfo.SimplePlanContent] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SimplePlanContent].ToString().Trim(); //简案内容
objvPubTeachCaseRelaInfoEN.ResourceOwner = objRow[convPubTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvPubTeachCaseRelaInfoEN.ftpFileType = objRow[convPubTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubTeachCaseRelaInfoEN.ftpFileSize = objRow[convPubTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convPubTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubTeachCaseRelaInfoEN.IdDiscipline = objRow[convPubTeachCaseRelaInfo.IdDiscipline].ToString().Trim(); //学科流水号
objvPubTeachCaseRelaInfoEN.DisciplineID = objRow[convPubTeachCaseRelaInfo.DisciplineID].ToString().Trim(); //学科ID
objvPubTeachCaseRelaInfoEN.DisciplineName = objRow[convPubTeachCaseRelaInfo.DisciplineName].ToString().Trim(); //学科名称
objvPubTeachCaseRelaInfoEN.IdStudyLevel = objRow[convPubTeachCaseRelaInfo.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubTeachCaseRelaInfoEN.StudyLevelName = objRow[convPubTeachCaseRelaInfo.StudyLevelName].ToString().Trim(); //学段名称
objvPubTeachCaseRelaInfoEN.IdFile = objRow[convPubTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvPubTeachCaseRelaInfoEN.FileName = objRow[convPubTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvPubTeachCaseRelaInfoEN.FileType = objRow[convPubTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvPubTeachCaseRelaInfoEN.SaveDate = objRow[convPubTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileSize = objRow[convPubTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvPubTeachCaseRelaInfoEN.SaveTime = objRow[convPubTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdPubClassCase = objRow[convPubTeachCaseRelaInfo.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubTeachCaseRelaInfoEN.PubClassCaseID = objRow[convPubTeachCaseRelaInfo.PubClassCaseID].ToString().Trim(); //案例ID
objvPubTeachCaseRelaInfoEN.PubClassCaseName = objRow[convPubTeachCaseRelaInfo.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubTeachCaseRelaInfoEN.PubClassCaseBG = objRow[convPubTeachCaseRelaInfo.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubTeachCaseRelaInfoEN.IdTeachingPlan = objRow[convPubTeachCaseRelaInfo.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubTeachCaseRelaInfoEN.Memo = objRow[convPubTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
objvPubTeachCaseRelaInfoEN.FileOriginName = objRow[convPubTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvPubTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvPubTeachCaseRelaInfoEN.ResourceID = objRow[convPubTeachCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvPubTeachCaseRelaInfoEN.FileNewName = objRow[convPubTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvPubTeachCaseRelaInfoEN.FileOldName = objRow[convPubTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubTeachCaseRelaInfoEN);
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
public static List<clsvPubTeachCaseRelaInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPubTeachCaseRelaInfoEN> arrObjLst = new List<clsvPubTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = new clsvPubTeachCaseRelaInfoEN();
try
{
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo = Int32.Parse(objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo].ToString().Trim()); //公开课案例相关信息流水号
objvPubTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvPubTeachCaseRelaInfoEN.SubjectName = objRow[convPubTeachCaseRelaInfo.SubjectName].ToString().Trim(); //课题名称
objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubTeachCaseRelaInfoEN.TeachingObject = objRow[convPubTeachCaseRelaInfo.TeachingObject] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingObject].ToString().Trim(); //教学目标
objvPubTeachCaseRelaInfoEN.TeachingEmphases = objRow[convPubTeachCaseRelaInfo.TeachingEmphases] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingEmphases].ToString().Trim(); //教学重点
objvPubTeachCaseRelaInfoEN.TeachingDifficulty = objRow[convPubTeachCaseRelaInfo.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubTeachCaseRelaInfoEN.TeachingTool = objRow[convPubTeachCaseRelaInfo.TeachingTool] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingTool].ToString().Trim(); //教学用具
objvPubTeachCaseRelaInfoEN.TeachingProcess = objRow[convPubTeachCaseRelaInfo.TeachingProcess] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingProcess].ToString().Trim(); //教学过程
objvPubTeachCaseRelaInfoEN.IdFtpResource = objRow[convPubTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubTeachCaseRelaInfoEN.FtpResourceID = objRow[convPubTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubTeachCaseRelaInfoEN.FileOriginalName = objRow[convPubTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvPubTeachCaseRelaInfoEN.FileDirName = objRow[convPubTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvPubTeachCaseRelaInfoEN.FileRename = objRow[convPubTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvPubTeachCaseRelaInfoEN.FileUpDate = objRow[convPubTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileUpTime = objRow[convPubTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdResource = objRow[convPubTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvPubTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvPubTeachCaseRelaInfoEN.IdResourceType = objRow[convPubTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubTeachCaseRelaInfoEN.ResourceTypeID = objRow[convPubTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubTeachCaseRelaInfoEN.ResourceTypeName = objRow[convPubTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubTeachCaseRelaInfoEN.IdPubCaseType = objRow[convPubTeachCaseRelaInfo.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubTeachCaseRelaInfoEN.PubCaseTypeID = objRow[convPubTeachCaseRelaInfo.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubTeachCaseRelaInfoEN.PubCaseTypeName = objRow[convPubTeachCaseRelaInfo.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType = objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType].ToString().Trim(); //公开课案例相关信息类型流水号
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID].ToString().Trim(); //公开课案例相关信息类型ID
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName].ToString().Trim(); //公开课案例相关信息类型名称
objvPubTeachCaseRelaInfoEN.TeachingPlanType = objRow[convPubTeachCaseRelaInfo.TeachingPlanType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanType].ToString().Trim(); //教案类型
objvPubTeachCaseRelaInfoEN.BrowseCount = objRow[convPubTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvPubTeachCaseRelaInfoEN.SimplePlanContent = objRow[convPubTeachCaseRelaInfo.SimplePlanContent] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SimplePlanContent].ToString().Trim(); //简案内容
objvPubTeachCaseRelaInfoEN.ResourceOwner = objRow[convPubTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvPubTeachCaseRelaInfoEN.ftpFileType = objRow[convPubTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubTeachCaseRelaInfoEN.ftpFileSize = objRow[convPubTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convPubTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubTeachCaseRelaInfoEN.IdDiscipline = objRow[convPubTeachCaseRelaInfo.IdDiscipline].ToString().Trim(); //学科流水号
objvPubTeachCaseRelaInfoEN.DisciplineID = objRow[convPubTeachCaseRelaInfo.DisciplineID].ToString().Trim(); //学科ID
objvPubTeachCaseRelaInfoEN.DisciplineName = objRow[convPubTeachCaseRelaInfo.DisciplineName].ToString().Trim(); //学科名称
objvPubTeachCaseRelaInfoEN.IdStudyLevel = objRow[convPubTeachCaseRelaInfo.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubTeachCaseRelaInfoEN.StudyLevelName = objRow[convPubTeachCaseRelaInfo.StudyLevelName].ToString().Trim(); //学段名称
objvPubTeachCaseRelaInfoEN.IdFile = objRow[convPubTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvPubTeachCaseRelaInfoEN.FileName = objRow[convPubTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvPubTeachCaseRelaInfoEN.FileType = objRow[convPubTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvPubTeachCaseRelaInfoEN.SaveDate = objRow[convPubTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileSize = objRow[convPubTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvPubTeachCaseRelaInfoEN.SaveTime = objRow[convPubTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdPubClassCase = objRow[convPubTeachCaseRelaInfo.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubTeachCaseRelaInfoEN.PubClassCaseID = objRow[convPubTeachCaseRelaInfo.PubClassCaseID].ToString().Trim(); //案例ID
objvPubTeachCaseRelaInfoEN.PubClassCaseName = objRow[convPubTeachCaseRelaInfo.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubTeachCaseRelaInfoEN.PubClassCaseBG = objRow[convPubTeachCaseRelaInfo.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubTeachCaseRelaInfoEN.IdTeachingPlan = objRow[convPubTeachCaseRelaInfo.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubTeachCaseRelaInfoEN.Memo = objRow[convPubTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
objvPubTeachCaseRelaInfoEN.FileOriginName = objRow[convPubTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvPubTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvPubTeachCaseRelaInfoEN.ResourceID = objRow[convPubTeachCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvPubTeachCaseRelaInfoEN.FileNewName = objRow[convPubTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvPubTeachCaseRelaInfoEN.FileOldName = objRow[convPubTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPubTeachCaseRelaInfoEN> GetSubObjLstCache(clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoCond)
{
List<clsvPubTeachCaseRelaInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPubTeachCaseRelaInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPubTeachCaseRelaInfo.AttributeName)
{
if (objvPubTeachCaseRelaInfoCond.IsUpdated(strFldName) == false) continue;
if (objvPubTeachCaseRelaInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubTeachCaseRelaInfoCond[strFldName].ToString());
}
else
{
if (objvPubTeachCaseRelaInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubTeachCaseRelaInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPubTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPubTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPubTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPubTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPubTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPubTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPubTeachCaseRelaInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPubTeachCaseRelaInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPubTeachCaseRelaInfoCond[strFldName]));
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
public static List<clsvPubTeachCaseRelaInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPubTeachCaseRelaInfoEN> arrObjLst = new List<clsvPubTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = new clsvPubTeachCaseRelaInfoEN();
try
{
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo = Int32.Parse(objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo].ToString().Trim()); //公开课案例相关信息流水号
objvPubTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvPubTeachCaseRelaInfoEN.SubjectName = objRow[convPubTeachCaseRelaInfo.SubjectName].ToString().Trim(); //课题名称
objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubTeachCaseRelaInfoEN.TeachingObject = objRow[convPubTeachCaseRelaInfo.TeachingObject] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingObject].ToString().Trim(); //教学目标
objvPubTeachCaseRelaInfoEN.TeachingEmphases = objRow[convPubTeachCaseRelaInfo.TeachingEmphases] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingEmphases].ToString().Trim(); //教学重点
objvPubTeachCaseRelaInfoEN.TeachingDifficulty = objRow[convPubTeachCaseRelaInfo.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubTeachCaseRelaInfoEN.TeachingTool = objRow[convPubTeachCaseRelaInfo.TeachingTool] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingTool].ToString().Trim(); //教学用具
objvPubTeachCaseRelaInfoEN.TeachingProcess = objRow[convPubTeachCaseRelaInfo.TeachingProcess] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingProcess].ToString().Trim(); //教学过程
objvPubTeachCaseRelaInfoEN.IdFtpResource = objRow[convPubTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubTeachCaseRelaInfoEN.FtpResourceID = objRow[convPubTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubTeachCaseRelaInfoEN.FileOriginalName = objRow[convPubTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvPubTeachCaseRelaInfoEN.FileDirName = objRow[convPubTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvPubTeachCaseRelaInfoEN.FileRename = objRow[convPubTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvPubTeachCaseRelaInfoEN.FileUpDate = objRow[convPubTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileUpTime = objRow[convPubTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdResource = objRow[convPubTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvPubTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvPubTeachCaseRelaInfoEN.IdResourceType = objRow[convPubTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubTeachCaseRelaInfoEN.ResourceTypeID = objRow[convPubTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubTeachCaseRelaInfoEN.ResourceTypeName = objRow[convPubTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubTeachCaseRelaInfoEN.IdPubCaseType = objRow[convPubTeachCaseRelaInfo.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubTeachCaseRelaInfoEN.PubCaseTypeID = objRow[convPubTeachCaseRelaInfo.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubTeachCaseRelaInfoEN.PubCaseTypeName = objRow[convPubTeachCaseRelaInfo.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType = objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType].ToString().Trim(); //公开课案例相关信息类型流水号
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID].ToString().Trim(); //公开课案例相关信息类型ID
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName].ToString().Trim(); //公开课案例相关信息类型名称
objvPubTeachCaseRelaInfoEN.TeachingPlanType = objRow[convPubTeachCaseRelaInfo.TeachingPlanType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanType].ToString().Trim(); //教案类型
objvPubTeachCaseRelaInfoEN.BrowseCount = objRow[convPubTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvPubTeachCaseRelaInfoEN.SimplePlanContent = objRow[convPubTeachCaseRelaInfo.SimplePlanContent] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SimplePlanContent].ToString().Trim(); //简案内容
objvPubTeachCaseRelaInfoEN.ResourceOwner = objRow[convPubTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvPubTeachCaseRelaInfoEN.ftpFileType = objRow[convPubTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubTeachCaseRelaInfoEN.ftpFileSize = objRow[convPubTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convPubTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubTeachCaseRelaInfoEN.IdDiscipline = objRow[convPubTeachCaseRelaInfo.IdDiscipline].ToString().Trim(); //学科流水号
objvPubTeachCaseRelaInfoEN.DisciplineID = objRow[convPubTeachCaseRelaInfo.DisciplineID].ToString().Trim(); //学科ID
objvPubTeachCaseRelaInfoEN.DisciplineName = objRow[convPubTeachCaseRelaInfo.DisciplineName].ToString().Trim(); //学科名称
objvPubTeachCaseRelaInfoEN.IdStudyLevel = objRow[convPubTeachCaseRelaInfo.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubTeachCaseRelaInfoEN.StudyLevelName = objRow[convPubTeachCaseRelaInfo.StudyLevelName].ToString().Trim(); //学段名称
objvPubTeachCaseRelaInfoEN.IdFile = objRow[convPubTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvPubTeachCaseRelaInfoEN.FileName = objRow[convPubTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvPubTeachCaseRelaInfoEN.FileType = objRow[convPubTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvPubTeachCaseRelaInfoEN.SaveDate = objRow[convPubTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileSize = objRow[convPubTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvPubTeachCaseRelaInfoEN.SaveTime = objRow[convPubTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdPubClassCase = objRow[convPubTeachCaseRelaInfo.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubTeachCaseRelaInfoEN.PubClassCaseID = objRow[convPubTeachCaseRelaInfo.PubClassCaseID].ToString().Trim(); //案例ID
objvPubTeachCaseRelaInfoEN.PubClassCaseName = objRow[convPubTeachCaseRelaInfo.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubTeachCaseRelaInfoEN.PubClassCaseBG = objRow[convPubTeachCaseRelaInfo.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubTeachCaseRelaInfoEN.IdTeachingPlan = objRow[convPubTeachCaseRelaInfo.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubTeachCaseRelaInfoEN.Memo = objRow[convPubTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
objvPubTeachCaseRelaInfoEN.FileOriginName = objRow[convPubTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvPubTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvPubTeachCaseRelaInfoEN.ResourceID = objRow[convPubTeachCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvPubTeachCaseRelaInfoEN.FileNewName = objRow[convPubTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvPubTeachCaseRelaInfoEN.FileOldName = objRow[convPubTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubTeachCaseRelaInfoEN);
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
public static List<clsvPubTeachCaseRelaInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPubTeachCaseRelaInfoEN> arrObjLst = new List<clsvPubTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = new clsvPubTeachCaseRelaInfoEN();
try
{
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo = Int32.Parse(objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo].ToString().Trim()); //公开课案例相关信息流水号
objvPubTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvPubTeachCaseRelaInfoEN.SubjectName = objRow[convPubTeachCaseRelaInfo.SubjectName].ToString().Trim(); //课题名称
objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubTeachCaseRelaInfoEN.TeachingObject = objRow[convPubTeachCaseRelaInfo.TeachingObject] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingObject].ToString().Trim(); //教学目标
objvPubTeachCaseRelaInfoEN.TeachingEmphases = objRow[convPubTeachCaseRelaInfo.TeachingEmphases] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingEmphases].ToString().Trim(); //教学重点
objvPubTeachCaseRelaInfoEN.TeachingDifficulty = objRow[convPubTeachCaseRelaInfo.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubTeachCaseRelaInfoEN.TeachingTool = objRow[convPubTeachCaseRelaInfo.TeachingTool] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingTool].ToString().Trim(); //教学用具
objvPubTeachCaseRelaInfoEN.TeachingProcess = objRow[convPubTeachCaseRelaInfo.TeachingProcess] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingProcess].ToString().Trim(); //教学过程
objvPubTeachCaseRelaInfoEN.IdFtpResource = objRow[convPubTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubTeachCaseRelaInfoEN.FtpResourceID = objRow[convPubTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubTeachCaseRelaInfoEN.FileOriginalName = objRow[convPubTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvPubTeachCaseRelaInfoEN.FileDirName = objRow[convPubTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvPubTeachCaseRelaInfoEN.FileRename = objRow[convPubTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvPubTeachCaseRelaInfoEN.FileUpDate = objRow[convPubTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileUpTime = objRow[convPubTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdResource = objRow[convPubTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvPubTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvPubTeachCaseRelaInfoEN.IdResourceType = objRow[convPubTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubTeachCaseRelaInfoEN.ResourceTypeID = objRow[convPubTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubTeachCaseRelaInfoEN.ResourceTypeName = objRow[convPubTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubTeachCaseRelaInfoEN.IdPubCaseType = objRow[convPubTeachCaseRelaInfo.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubTeachCaseRelaInfoEN.PubCaseTypeID = objRow[convPubTeachCaseRelaInfo.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubTeachCaseRelaInfoEN.PubCaseTypeName = objRow[convPubTeachCaseRelaInfo.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType = objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType].ToString().Trim(); //公开课案例相关信息类型流水号
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID].ToString().Trim(); //公开课案例相关信息类型ID
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName].ToString().Trim(); //公开课案例相关信息类型名称
objvPubTeachCaseRelaInfoEN.TeachingPlanType = objRow[convPubTeachCaseRelaInfo.TeachingPlanType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanType].ToString().Trim(); //教案类型
objvPubTeachCaseRelaInfoEN.BrowseCount = objRow[convPubTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvPubTeachCaseRelaInfoEN.SimplePlanContent = objRow[convPubTeachCaseRelaInfo.SimplePlanContent] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SimplePlanContent].ToString().Trim(); //简案内容
objvPubTeachCaseRelaInfoEN.ResourceOwner = objRow[convPubTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvPubTeachCaseRelaInfoEN.ftpFileType = objRow[convPubTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubTeachCaseRelaInfoEN.ftpFileSize = objRow[convPubTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convPubTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubTeachCaseRelaInfoEN.IdDiscipline = objRow[convPubTeachCaseRelaInfo.IdDiscipline].ToString().Trim(); //学科流水号
objvPubTeachCaseRelaInfoEN.DisciplineID = objRow[convPubTeachCaseRelaInfo.DisciplineID].ToString().Trim(); //学科ID
objvPubTeachCaseRelaInfoEN.DisciplineName = objRow[convPubTeachCaseRelaInfo.DisciplineName].ToString().Trim(); //学科名称
objvPubTeachCaseRelaInfoEN.IdStudyLevel = objRow[convPubTeachCaseRelaInfo.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubTeachCaseRelaInfoEN.StudyLevelName = objRow[convPubTeachCaseRelaInfo.StudyLevelName].ToString().Trim(); //学段名称
objvPubTeachCaseRelaInfoEN.IdFile = objRow[convPubTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvPubTeachCaseRelaInfoEN.FileName = objRow[convPubTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvPubTeachCaseRelaInfoEN.FileType = objRow[convPubTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvPubTeachCaseRelaInfoEN.SaveDate = objRow[convPubTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileSize = objRow[convPubTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvPubTeachCaseRelaInfoEN.SaveTime = objRow[convPubTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdPubClassCase = objRow[convPubTeachCaseRelaInfo.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubTeachCaseRelaInfoEN.PubClassCaseID = objRow[convPubTeachCaseRelaInfo.PubClassCaseID].ToString().Trim(); //案例ID
objvPubTeachCaseRelaInfoEN.PubClassCaseName = objRow[convPubTeachCaseRelaInfo.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubTeachCaseRelaInfoEN.PubClassCaseBG = objRow[convPubTeachCaseRelaInfo.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubTeachCaseRelaInfoEN.IdTeachingPlan = objRow[convPubTeachCaseRelaInfo.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubTeachCaseRelaInfoEN.Memo = objRow[convPubTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
objvPubTeachCaseRelaInfoEN.FileOriginName = objRow[convPubTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvPubTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvPubTeachCaseRelaInfoEN.ResourceID = objRow[convPubTeachCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvPubTeachCaseRelaInfoEN.FileNewName = objRow[convPubTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvPubTeachCaseRelaInfoEN.FileOldName = objRow[convPubTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubTeachCaseRelaInfoEN);
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
List<clsvPubTeachCaseRelaInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPubTeachCaseRelaInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubTeachCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPubTeachCaseRelaInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPubTeachCaseRelaInfoEN> arrObjLst = new List<clsvPubTeachCaseRelaInfoEN>(); 
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
	clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = new clsvPubTeachCaseRelaInfoEN();
try
{
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo = Int32.Parse(objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo].ToString().Trim()); //公开课案例相关信息流水号
objvPubTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvPubTeachCaseRelaInfoEN.SubjectName = objRow[convPubTeachCaseRelaInfo.SubjectName].ToString().Trim(); //课题名称
objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubTeachCaseRelaInfoEN.TeachingObject = objRow[convPubTeachCaseRelaInfo.TeachingObject] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingObject].ToString().Trim(); //教学目标
objvPubTeachCaseRelaInfoEN.TeachingEmphases = objRow[convPubTeachCaseRelaInfo.TeachingEmphases] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingEmphases].ToString().Trim(); //教学重点
objvPubTeachCaseRelaInfoEN.TeachingDifficulty = objRow[convPubTeachCaseRelaInfo.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubTeachCaseRelaInfoEN.TeachingTool = objRow[convPubTeachCaseRelaInfo.TeachingTool] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingTool].ToString().Trim(); //教学用具
objvPubTeachCaseRelaInfoEN.TeachingProcess = objRow[convPubTeachCaseRelaInfo.TeachingProcess] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingProcess].ToString().Trim(); //教学过程
objvPubTeachCaseRelaInfoEN.IdFtpResource = objRow[convPubTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubTeachCaseRelaInfoEN.FtpResourceID = objRow[convPubTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubTeachCaseRelaInfoEN.FileOriginalName = objRow[convPubTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvPubTeachCaseRelaInfoEN.FileDirName = objRow[convPubTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvPubTeachCaseRelaInfoEN.FileRename = objRow[convPubTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvPubTeachCaseRelaInfoEN.FileUpDate = objRow[convPubTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileUpTime = objRow[convPubTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdResource = objRow[convPubTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvPubTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvPubTeachCaseRelaInfoEN.IdResourceType = objRow[convPubTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubTeachCaseRelaInfoEN.ResourceTypeID = objRow[convPubTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubTeachCaseRelaInfoEN.ResourceTypeName = objRow[convPubTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubTeachCaseRelaInfoEN.IdPubCaseType = objRow[convPubTeachCaseRelaInfo.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubTeachCaseRelaInfoEN.PubCaseTypeID = objRow[convPubTeachCaseRelaInfo.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubTeachCaseRelaInfoEN.PubCaseTypeName = objRow[convPubTeachCaseRelaInfo.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType = objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType].ToString().Trim(); //公开课案例相关信息类型流水号
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID].ToString().Trim(); //公开课案例相关信息类型ID
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName].ToString().Trim(); //公开课案例相关信息类型名称
objvPubTeachCaseRelaInfoEN.TeachingPlanType = objRow[convPubTeachCaseRelaInfo.TeachingPlanType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanType].ToString().Trim(); //教案类型
objvPubTeachCaseRelaInfoEN.BrowseCount = objRow[convPubTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvPubTeachCaseRelaInfoEN.SimplePlanContent = objRow[convPubTeachCaseRelaInfo.SimplePlanContent] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SimplePlanContent].ToString().Trim(); //简案内容
objvPubTeachCaseRelaInfoEN.ResourceOwner = objRow[convPubTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvPubTeachCaseRelaInfoEN.ftpFileType = objRow[convPubTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubTeachCaseRelaInfoEN.ftpFileSize = objRow[convPubTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convPubTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubTeachCaseRelaInfoEN.IdDiscipline = objRow[convPubTeachCaseRelaInfo.IdDiscipline].ToString().Trim(); //学科流水号
objvPubTeachCaseRelaInfoEN.DisciplineID = objRow[convPubTeachCaseRelaInfo.DisciplineID].ToString().Trim(); //学科ID
objvPubTeachCaseRelaInfoEN.DisciplineName = objRow[convPubTeachCaseRelaInfo.DisciplineName].ToString().Trim(); //学科名称
objvPubTeachCaseRelaInfoEN.IdStudyLevel = objRow[convPubTeachCaseRelaInfo.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubTeachCaseRelaInfoEN.StudyLevelName = objRow[convPubTeachCaseRelaInfo.StudyLevelName].ToString().Trim(); //学段名称
objvPubTeachCaseRelaInfoEN.IdFile = objRow[convPubTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvPubTeachCaseRelaInfoEN.FileName = objRow[convPubTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvPubTeachCaseRelaInfoEN.FileType = objRow[convPubTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvPubTeachCaseRelaInfoEN.SaveDate = objRow[convPubTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileSize = objRow[convPubTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvPubTeachCaseRelaInfoEN.SaveTime = objRow[convPubTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdPubClassCase = objRow[convPubTeachCaseRelaInfo.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubTeachCaseRelaInfoEN.PubClassCaseID = objRow[convPubTeachCaseRelaInfo.PubClassCaseID].ToString().Trim(); //案例ID
objvPubTeachCaseRelaInfoEN.PubClassCaseName = objRow[convPubTeachCaseRelaInfo.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubTeachCaseRelaInfoEN.PubClassCaseBG = objRow[convPubTeachCaseRelaInfo.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubTeachCaseRelaInfoEN.IdTeachingPlan = objRow[convPubTeachCaseRelaInfo.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubTeachCaseRelaInfoEN.Memo = objRow[convPubTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
objvPubTeachCaseRelaInfoEN.FileOriginName = objRow[convPubTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvPubTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvPubTeachCaseRelaInfoEN.ResourceID = objRow[convPubTeachCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvPubTeachCaseRelaInfoEN.FileNewName = objRow[convPubTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvPubTeachCaseRelaInfoEN.FileOldName = objRow[convPubTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubTeachCaseRelaInfoEN);
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
public static List<clsvPubTeachCaseRelaInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPubTeachCaseRelaInfoEN> arrObjLst = new List<clsvPubTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = new clsvPubTeachCaseRelaInfoEN();
try
{
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo = Int32.Parse(objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo].ToString().Trim()); //公开课案例相关信息流水号
objvPubTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvPubTeachCaseRelaInfoEN.SubjectName = objRow[convPubTeachCaseRelaInfo.SubjectName].ToString().Trim(); //课题名称
objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubTeachCaseRelaInfoEN.TeachingObject = objRow[convPubTeachCaseRelaInfo.TeachingObject] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingObject].ToString().Trim(); //教学目标
objvPubTeachCaseRelaInfoEN.TeachingEmphases = objRow[convPubTeachCaseRelaInfo.TeachingEmphases] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingEmphases].ToString().Trim(); //教学重点
objvPubTeachCaseRelaInfoEN.TeachingDifficulty = objRow[convPubTeachCaseRelaInfo.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubTeachCaseRelaInfoEN.TeachingTool = objRow[convPubTeachCaseRelaInfo.TeachingTool] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingTool].ToString().Trim(); //教学用具
objvPubTeachCaseRelaInfoEN.TeachingProcess = objRow[convPubTeachCaseRelaInfo.TeachingProcess] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingProcess].ToString().Trim(); //教学过程
objvPubTeachCaseRelaInfoEN.IdFtpResource = objRow[convPubTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubTeachCaseRelaInfoEN.FtpResourceID = objRow[convPubTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubTeachCaseRelaInfoEN.FileOriginalName = objRow[convPubTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvPubTeachCaseRelaInfoEN.FileDirName = objRow[convPubTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvPubTeachCaseRelaInfoEN.FileRename = objRow[convPubTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvPubTeachCaseRelaInfoEN.FileUpDate = objRow[convPubTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileUpTime = objRow[convPubTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdResource = objRow[convPubTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvPubTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvPubTeachCaseRelaInfoEN.IdResourceType = objRow[convPubTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubTeachCaseRelaInfoEN.ResourceTypeID = objRow[convPubTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubTeachCaseRelaInfoEN.ResourceTypeName = objRow[convPubTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubTeachCaseRelaInfoEN.IdPubCaseType = objRow[convPubTeachCaseRelaInfo.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubTeachCaseRelaInfoEN.PubCaseTypeID = objRow[convPubTeachCaseRelaInfo.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubTeachCaseRelaInfoEN.PubCaseTypeName = objRow[convPubTeachCaseRelaInfo.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType = objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType].ToString().Trim(); //公开课案例相关信息类型流水号
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID].ToString().Trim(); //公开课案例相关信息类型ID
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName].ToString().Trim(); //公开课案例相关信息类型名称
objvPubTeachCaseRelaInfoEN.TeachingPlanType = objRow[convPubTeachCaseRelaInfo.TeachingPlanType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanType].ToString().Trim(); //教案类型
objvPubTeachCaseRelaInfoEN.BrowseCount = objRow[convPubTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvPubTeachCaseRelaInfoEN.SimplePlanContent = objRow[convPubTeachCaseRelaInfo.SimplePlanContent] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SimplePlanContent].ToString().Trim(); //简案内容
objvPubTeachCaseRelaInfoEN.ResourceOwner = objRow[convPubTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvPubTeachCaseRelaInfoEN.ftpFileType = objRow[convPubTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubTeachCaseRelaInfoEN.ftpFileSize = objRow[convPubTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convPubTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubTeachCaseRelaInfoEN.IdDiscipline = objRow[convPubTeachCaseRelaInfo.IdDiscipline].ToString().Trim(); //学科流水号
objvPubTeachCaseRelaInfoEN.DisciplineID = objRow[convPubTeachCaseRelaInfo.DisciplineID].ToString().Trim(); //学科ID
objvPubTeachCaseRelaInfoEN.DisciplineName = objRow[convPubTeachCaseRelaInfo.DisciplineName].ToString().Trim(); //学科名称
objvPubTeachCaseRelaInfoEN.IdStudyLevel = objRow[convPubTeachCaseRelaInfo.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubTeachCaseRelaInfoEN.StudyLevelName = objRow[convPubTeachCaseRelaInfo.StudyLevelName].ToString().Trim(); //学段名称
objvPubTeachCaseRelaInfoEN.IdFile = objRow[convPubTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvPubTeachCaseRelaInfoEN.FileName = objRow[convPubTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvPubTeachCaseRelaInfoEN.FileType = objRow[convPubTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvPubTeachCaseRelaInfoEN.SaveDate = objRow[convPubTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileSize = objRow[convPubTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvPubTeachCaseRelaInfoEN.SaveTime = objRow[convPubTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdPubClassCase = objRow[convPubTeachCaseRelaInfo.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubTeachCaseRelaInfoEN.PubClassCaseID = objRow[convPubTeachCaseRelaInfo.PubClassCaseID].ToString().Trim(); //案例ID
objvPubTeachCaseRelaInfoEN.PubClassCaseName = objRow[convPubTeachCaseRelaInfo.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubTeachCaseRelaInfoEN.PubClassCaseBG = objRow[convPubTeachCaseRelaInfo.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubTeachCaseRelaInfoEN.IdTeachingPlan = objRow[convPubTeachCaseRelaInfo.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubTeachCaseRelaInfoEN.Memo = objRow[convPubTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
objvPubTeachCaseRelaInfoEN.FileOriginName = objRow[convPubTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvPubTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvPubTeachCaseRelaInfoEN.ResourceID = objRow[convPubTeachCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvPubTeachCaseRelaInfoEN.FileNewName = objRow[convPubTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvPubTeachCaseRelaInfoEN.FileOldName = objRow[convPubTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPubTeachCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPubTeachCaseRelaInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPubTeachCaseRelaInfoEN> arrObjLst = new List<clsvPubTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = new clsvPubTeachCaseRelaInfoEN();
try
{
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo = Int32.Parse(objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo].ToString().Trim()); //公开课案例相关信息流水号
objvPubTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvPubTeachCaseRelaInfoEN.SubjectName = objRow[convPubTeachCaseRelaInfo.SubjectName].ToString().Trim(); //课题名称
objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubTeachCaseRelaInfoEN.TeachingObject = objRow[convPubTeachCaseRelaInfo.TeachingObject] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingObject].ToString().Trim(); //教学目标
objvPubTeachCaseRelaInfoEN.TeachingEmphases = objRow[convPubTeachCaseRelaInfo.TeachingEmphases] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingEmphases].ToString().Trim(); //教学重点
objvPubTeachCaseRelaInfoEN.TeachingDifficulty = objRow[convPubTeachCaseRelaInfo.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubTeachCaseRelaInfoEN.TeachingTool = objRow[convPubTeachCaseRelaInfo.TeachingTool] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingTool].ToString().Trim(); //教学用具
objvPubTeachCaseRelaInfoEN.TeachingProcess = objRow[convPubTeachCaseRelaInfo.TeachingProcess] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingProcess].ToString().Trim(); //教学过程
objvPubTeachCaseRelaInfoEN.IdFtpResource = objRow[convPubTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubTeachCaseRelaInfoEN.FtpResourceID = objRow[convPubTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubTeachCaseRelaInfoEN.FileOriginalName = objRow[convPubTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvPubTeachCaseRelaInfoEN.FileDirName = objRow[convPubTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvPubTeachCaseRelaInfoEN.FileRename = objRow[convPubTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvPubTeachCaseRelaInfoEN.FileUpDate = objRow[convPubTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileUpTime = objRow[convPubTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdResource = objRow[convPubTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvPubTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvPubTeachCaseRelaInfoEN.IdResourceType = objRow[convPubTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubTeachCaseRelaInfoEN.ResourceTypeID = objRow[convPubTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubTeachCaseRelaInfoEN.ResourceTypeName = objRow[convPubTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubTeachCaseRelaInfoEN.IdPubCaseType = objRow[convPubTeachCaseRelaInfo.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubTeachCaseRelaInfoEN.PubCaseTypeID = objRow[convPubTeachCaseRelaInfo.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubTeachCaseRelaInfoEN.PubCaseTypeName = objRow[convPubTeachCaseRelaInfo.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType = objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType].ToString().Trim(); //公开课案例相关信息类型流水号
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID].ToString().Trim(); //公开课案例相关信息类型ID
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName].ToString().Trim(); //公开课案例相关信息类型名称
objvPubTeachCaseRelaInfoEN.TeachingPlanType = objRow[convPubTeachCaseRelaInfo.TeachingPlanType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanType].ToString().Trim(); //教案类型
objvPubTeachCaseRelaInfoEN.BrowseCount = objRow[convPubTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvPubTeachCaseRelaInfoEN.SimplePlanContent = objRow[convPubTeachCaseRelaInfo.SimplePlanContent] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SimplePlanContent].ToString().Trim(); //简案内容
objvPubTeachCaseRelaInfoEN.ResourceOwner = objRow[convPubTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvPubTeachCaseRelaInfoEN.ftpFileType = objRow[convPubTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubTeachCaseRelaInfoEN.ftpFileSize = objRow[convPubTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convPubTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubTeachCaseRelaInfoEN.IdDiscipline = objRow[convPubTeachCaseRelaInfo.IdDiscipline].ToString().Trim(); //学科流水号
objvPubTeachCaseRelaInfoEN.DisciplineID = objRow[convPubTeachCaseRelaInfo.DisciplineID].ToString().Trim(); //学科ID
objvPubTeachCaseRelaInfoEN.DisciplineName = objRow[convPubTeachCaseRelaInfo.DisciplineName].ToString().Trim(); //学科名称
objvPubTeachCaseRelaInfoEN.IdStudyLevel = objRow[convPubTeachCaseRelaInfo.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubTeachCaseRelaInfoEN.StudyLevelName = objRow[convPubTeachCaseRelaInfo.StudyLevelName].ToString().Trim(); //学段名称
objvPubTeachCaseRelaInfoEN.IdFile = objRow[convPubTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvPubTeachCaseRelaInfoEN.FileName = objRow[convPubTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvPubTeachCaseRelaInfoEN.FileType = objRow[convPubTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvPubTeachCaseRelaInfoEN.SaveDate = objRow[convPubTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileSize = objRow[convPubTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvPubTeachCaseRelaInfoEN.SaveTime = objRow[convPubTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdPubClassCase = objRow[convPubTeachCaseRelaInfo.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubTeachCaseRelaInfoEN.PubClassCaseID = objRow[convPubTeachCaseRelaInfo.PubClassCaseID].ToString().Trim(); //案例ID
objvPubTeachCaseRelaInfoEN.PubClassCaseName = objRow[convPubTeachCaseRelaInfo.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubTeachCaseRelaInfoEN.PubClassCaseBG = objRow[convPubTeachCaseRelaInfo.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubTeachCaseRelaInfoEN.IdTeachingPlan = objRow[convPubTeachCaseRelaInfo.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubTeachCaseRelaInfoEN.Memo = objRow[convPubTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
objvPubTeachCaseRelaInfoEN.FileOriginName = objRow[convPubTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvPubTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvPubTeachCaseRelaInfoEN.ResourceID = objRow[convPubTeachCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvPubTeachCaseRelaInfoEN.FileNewName = objRow[convPubTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvPubTeachCaseRelaInfoEN.FileOldName = objRow[convPubTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubTeachCaseRelaInfoEN);
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
public static List<clsvPubTeachCaseRelaInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPubTeachCaseRelaInfoEN> arrObjLst = new List<clsvPubTeachCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = new clsvPubTeachCaseRelaInfoEN();
try
{
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo = Int32.Parse(objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo].ToString().Trim()); //公开课案例相关信息流水号
objvPubTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvPubTeachCaseRelaInfoEN.SubjectName = objRow[convPubTeachCaseRelaInfo.SubjectName].ToString().Trim(); //课题名称
objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubTeachCaseRelaInfoEN.TeachingObject = objRow[convPubTeachCaseRelaInfo.TeachingObject] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingObject].ToString().Trim(); //教学目标
objvPubTeachCaseRelaInfoEN.TeachingEmphases = objRow[convPubTeachCaseRelaInfo.TeachingEmphases] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingEmphases].ToString().Trim(); //教学重点
objvPubTeachCaseRelaInfoEN.TeachingDifficulty = objRow[convPubTeachCaseRelaInfo.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubTeachCaseRelaInfoEN.TeachingTool = objRow[convPubTeachCaseRelaInfo.TeachingTool] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingTool].ToString().Trim(); //教学用具
objvPubTeachCaseRelaInfoEN.TeachingProcess = objRow[convPubTeachCaseRelaInfo.TeachingProcess] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingProcess].ToString().Trim(); //教学过程
objvPubTeachCaseRelaInfoEN.IdFtpResource = objRow[convPubTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubTeachCaseRelaInfoEN.FtpResourceID = objRow[convPubTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubTeachCaseRelaInfoEN.FileOriginalName = objRow[convPubTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvPubTeachCaseRelaInfoEN.FileDirName = objRow[convPubTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvPubTeachCaseRelaInfoEN.FileRename = objRow[convPubTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvPubTeachCaseRelaInfoEN.FileUpDate = objRow[convPubTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileUpTime = objRow[convPubTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdResource = objRow[convPubTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvPubTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvPubTeachCaseRelaInfoEN.IdResourceType = objRow[convPubTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubTeachCaseRelaInfoEN.ResourceTypeID = objRow[convPubTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubTeachCaseRelaInfoEN.ResourceTypeName = objRow[convPubTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubTeachCaseRelaInfoEN.IdPubCaseType = objRow[convPubTeachCaseRelaInfo.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubTeachCaseRelaInfoEN.PubCaseTypeID = objRow[convPubTeachCaseRelaInfo.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubTeachCaseRelaInfoEN.PubCaseTypeName = objRow[convPubTeachCaseRelaInfo.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType = objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType].ToString().Trim(); //公开课案例相关信息类型流水号
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID].ToString().Trim(); //公开课案例相关信息类型ID
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName].ToString().Trim(); //公开课案例相关信息类型名称
objvPubTeachCaseRelaInfoEN.TeachingPlanType = objRow[convPubTeachCaseRelaInfo.TeachingPlanType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanType].ToString().Trim(); //教案类型
objvPubTeachCaseRelaInfoEN.BrowseCount = objRow[convPubTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvPubTeachCaseRelaInfoEN.SimplePlanContent = objRow[convPubTeachCaseRelaInfo.SimplePlanContent] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SimplePlanContent].ToString().Trim(); //简案内容
objvPubTeachCaseRelaInfoEN.ResourceOwner = objRow[convPubTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvPubTeachCaseRelaInfoEN.ftpFileType = objRow[convPubTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubTeachCaseRelaInfoEN.ftpFileSize = objRow[convPubTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convPubTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubTeachCaseRelaInfoEN.IdDiscipline = objRow[convPubTeachCaseRelaInfo.IdDiscipline].ToString().Trim(); //学科流水号
objvPubTeachCaseRelaInfoEN.DisciplineID = objRow[convPubTeachCaseRelaInfo.DisciplineID].ToString().Trim(); //学科ID
objvPubTeachCaseRelaInfoEN.DisciplineName = objRow[convPubTeachCaseRelaInfo.DisciplineName].ToString().Trim(); //学科名称
objvPubTeachCaseRelaInfoEN.IdStudyLevel = objRow[convPubTeachCaseRelaInfo.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubTeachCaseRelaInfoEN.StudyLevelName = objRow[convPubTeachCaseRelaInfo.StudyLevelName].ToString().Trim(); //学段名称
objvPubTeachCaseRelaInfoEN.IdFile = objRow[convPubTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvPubTeachCaseRelaInfoEN.FileName = objRow[convPubTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvPubTeachCaseRelaInfoEN.FileType = objRow[convPubTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvPubTeachCaseRelaInfoEN.SaveDate = objRow[convPubTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileSize = objRow[convPubTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvPubTeachCaseRelaInfoEN.SaveTime = objRow[convPubTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdPubClassCase = objRow[convPubTeachCaseRelaInfo.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubTeachCaseRelaInfoEN.PubClassCaseID = objRow[convPubTeachCaseRelaInfo.PubClassCaseID].ToString().Trim(); //案例ID
objvPubTeachCaseRelaInfoEN.PubClassCaseName = objRow[convPubTeachCaseRelaInfo.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubTeachCaseRelaInfoEN.PubClassCaseBG = objRow[convPubTeachCaseRelaInfo.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubTeachCaseRelaInfoEN.IdTeachingPlan = objRow[convPubTeachCaseRelaInfo.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubTeachCaseRelaInfoEN.Memo = objRow[convPubTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
objvPubTeachCaseRelaInfoEN.FileOriginName = objRow[convPubTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvPubTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvPubTeachCaseRelaInfoEN.ResourceID = objRow[convPubTeachCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvPubTeachCaseRelaInfoEN.FileNewName = objRow[convPubTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvPubTeachCaseRelaInfoEN.FileOldName = objRow[convPubTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubTeachCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubTeachCaseRelaInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPubTeachCaseRelaInfoEN> arrObjLst = new List<clsvPubTeachCaseRelaInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = new clsvPubTeachCaseRelaInfoEN();
try
{
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo = Int32.Parse(objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo].ToString().Trim()); //公开课案例相关信息流水号
objvPubTeachCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvPubTeachCaseRelaInfoEN.SubjectName = objRow[convPubTeachCaseRelaInfo.SubjectName].ToString().Trim(); //课题名称
objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPubTeachCaseRelaInfoEN.TeachingObject = objRow[convPubTeachCaseRelaInfo.TeachingObject] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingObject].ToString().Trim(); //教学目标
objvPubTeachCaseRelaInfoEN.TeachingEmphases = objRow[convPubTeachCaseRelaInfo.TeachingEmphases] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingEmphases].ToString().Trim(); //教学重点
objvPubTeachCaseRelaInfoEN.TeachingDifficulty = objRow[convPubTeachCaseRelaInfo.TeachingDifficulty] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingDifficulty].ToString().Trim(); //教学难点
objvPubTeachCaseRelaInfoEN.TeachingTool = objRow[convPubTeachCaseRelaInfo.TeachingTool] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingTool].ToString().Trim(); //教学用具
objvPubTeachCaseRelaInfoEN.TeachingProcess = objRow[convPubTeachCaseRelaInfo.TeachingProcess] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingProcess].ToString().Trim(); //教学过程
objvPubTeachCaseRelaInfoEN.IdFtpResource = objRow[convPubTeachCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPubTeachCaseRelaInfoEN.FtpResourceID = objRow[convPubTeachCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPubTeachCaseRelaInfoEN.FileOriginalName = objRow[convPubTeachCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvPubTeachCaseRelaInfoEN.FileDirName = objRow[convPubTeachCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvPubTeachCaseRelaInfoEN.FileRename = objRow[convPubTeachCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvPubTeachCaseRelaInfoEN.FileUpDate = objRow[convPubTeachCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileUpTime = objRow[convPubTeachCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdResource = objRow[convPubTeachCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvPubTeachCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvPubTeachCaseRelaInfoEN.IdResourceType = objRow[convPubTeachCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvPubTeachCaseRelaInfoEN.ResourceTypeID = objRow[convPubTeachCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPubTeachCaseRelaInfoEN.ResourceTypeName = objRow[convPubTeachCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPubTeachCaseRelaInfoEN.IdPubCaseType = objRow[convPubTeachCaseRelaInfo.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objvPubTeachCaseRelaInfoEN.PubCaseTypeID = objRow[convPubTeachCaseRelaInfo.PubCaseTypeID].ToString().Trim(); //公开课案例类型ID
objvPubTeachCaseRelaInfoEN.PubCaseTypeName = objRow[convPubTeachCaseRelaInfo.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType = objRow[convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType].ToString().Trim(); //公开课案例相关信息类型流水号
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID].ToString().Trim(); //公开课案例相关信息类型ID
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName = objRow[convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName].ToString().Trim(); //公开课案例相关信息类型名称
objvPubTeachCaseRelaInfoEN.TeachingPlanType = objRow[convPubTeachCaseRelaInfo.TeachingPlanType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.TeachingPlanType].ToString().Trim(); //教案类型
objvPubTeachCaseRelaInfoEN.BrowseCount = objRow[convPubTeachCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubTeachCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvPubTeachCaseRelaInfoEN.SimplePlanContent = objRow[convPubTeachCaseRelaInfo.SimplePlanContent] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SimplePlanContent].ToString().Trim(); //简案内容
objvPubTeachCaseRelaInfoEN.ResourceOwner = objRow[convPubTeachCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvPubTeachCaseRelaInfoEN.ftpFileType = objRow[convPubTeachCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvPubTeachCaseRelaInfoEN.ftpFileSize = objRow[convPubTeachCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPubTeachCaseRelaInfoEN.ftpResourceOwner = objRow[convPubTeachCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPubTeachCaseRelaInfoEN.IdDiscipline = objRow[convPubTeachCaseRelaInfo.IdDiscipline].ToString().Trim(); //学科流水号
objvPubTeachCaseRelaInfoEN.DisciplineID = objRow[convPubTeachCaseRelaInfo.DisciplineID].ToString().Trim(); //学科ID
objvPubTeachCaseRelaInfoEN.DisciplineName = objRow[convPubTeachCaseRelaInfo.DisciplineName].ToString().Trim(); //学科名称
objvPubTeachCaseRelaInfoEN.IdStudyLevel = objRow[convPubTeachCaseRelaInfo.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPubTeachCaseRelaInfoEN.StudyLevelName = objRow[convPubTeachCaseRelaInfo.StudyLevelName].ToString().Trim(); //学段名称
objvPubTeachCaseRelaInfoEN.IdFile = objRow[convPubTeachCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvPubTeachCaseRelaInfoEN.FileName = objRow[convPubTeachCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvPubTeachCaseRelaInfoEN.FileType = objRow[convPubTeachCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvPubTeachCaseRelaInfoEN.SaveDate = objRow[convPubTeachCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvPubTeachCaseRelaInfoEN.FileSize = objRow[convPubTeachCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvPubTeachCaseRelaInfoEN.SaveTime = objRow[convPubTeachCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvPubTeachCaseRelaInfoEN.IdPubClassCase = objRow[convPubTeachCaseRelaInfo.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubTeachCaseRelaInfoEN.PubClassCaseID = objRow[convPubTeachCaseRelaInfo.PubClassCaseID].ToString().Trim(); //案例ID
objvPubTeachCaseRelaInfoEN.PubClassCaseName = objRow[convPubTeachCaseRelaInfo.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPubTeachCaseRelaInfoEN.PubClassCaseBG = objRow[convPubTeachCaseRelaInfo.PubClassCaseBG] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPubTeachCaseRelaInfoEN.IdTeachingPlan = objRow[convPubTeachCaseRelaInfo.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPubTeachCaseRelaInfoEN.Memo = objRow[convPubTeachCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.Memo].ToString().Trim(); //备注
objvPubTeachCaseRelaInfoEN.FileOriginName = objRow[convPubTeachCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvPubTeachCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubTeachCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvPubTeachCaseRelaInfoEN.ResourceID = objRow[convPubTeachCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvPubTeachCaseRelaInfoEN.FileNewName = objRow[convPubTeachCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvPubTeachCaseRelaInfoEN.FileOldName = objRow[convPubTeachCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convPubTeachCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubTeachCaseRelaInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPubTeachCaseRelaInfo(ref clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN)
{
bool bolResult = vPubTeachCaseRelaInfoDA.GetvPubTeachCaseRelaInfo(ref objvPubTeachCaseRelaInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPubTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubTeachCaseRelaInfoEN GetObjByIdPubTeachCaseRelaInfo(long lngIdPubTeachCaseRelaInfo)
{
clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = vPubTeachCaseRelaInfoDA.GetObjByIdPubTeachCaseRelaInfo(lngIdPubTeachCaseRelaInfo);
return objvPubTeachCaseRelaInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPubTeachCaseRelaInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = vPubTeachCaseRelaInfoDA.GetFirstObj(strWhereCond);
 return objvPubTeachCaseRelaInfoEN;
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
public static clsvPubTeachCaseRelaInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = vPubTeachCaseRelaInfoDA.GetObjByDataRow(objRow);
 return objvPubTeachCaseRelaInfoEN;
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
public static clsvPubTeachCaseRelaInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN = vPubTeachCaseRelaInfoDA.GetObjByDataRow(objRow);
 return objvPubTeachCaseRelaInfoEN;
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
 /// <param name = "lngIdPubTeachCaseRelaInfo">所给的关键字</param>
 /// <param name = "lstvPubTeachCaseRelaInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubTeachCaseRelaInfoEN GetObjByIdPubTeachCaseRelaInfoFromList(long lngIdPubTeachCaseRelaInfo, List<clsvPubTeachCaseRelaInfoEN> lstvPubTeachCaseRelaInfoObjLst)
{
foreach (clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN in lstvPubTeachCaseRelaInfoObjLst)
{
if (objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo == lngIdPubTeachCaseRelaInfo)
{
return objvPubTeachCaseRelaInfoEN;
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
 long lngIdPubTeachCaseRelaInfo;
 try
 {
 lngIdPubTeachCaseRelaInfo = new clsvPubTeachCaseRelaInfoDA().GetFirstID(strWhereCond);
 return lngIdPubTeachCaseRelaInfo;
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
 arrList = vPubTeachCaseRelaInfoDA.GetID(strWhereCond);
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
bool bolIsExist = vPubTeachCaseRelaInfoDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdPubTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdPubTeachCaseRelaInfo)
{
//检测记录是否存在
bool bolIsExist = vPubTeachCaseRelaInfoDA.IsExist(lngIdPubTeachCaseRelaInfo);
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
 bolIsExist = clsvPubTeachCaseRelaInfoDA.IsExistTable();
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
 bolIsExist = vPubTeachCaseRelaInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objvPubTeachCaseRelaInfoENS">源对象</param>
 /// <param name = "objvPubTeachCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoENS, clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoENT)
{
try
{
objvPubTeachCaseRelaInfoENT.IdPubTeachCaseRelaInfo = objvPubTeachCaseRelaInfoENS.IdPubTeachCaseRelaInfo; //公开课案例相关信息流水号
objvPubTeachCaseRelaInfoENT.IsVisible = objvPubTeachCaseRelaInfoENS.IsVisible; //是否显示
objvPubTeachCaseRelaInfoENT.SubjectName = objvPubTeachCaseRelaInfoENS.SubjectName; //课题名称
objvPubTeachCaseRelaInfoENT.TeachingPlanAuthor = objvPubTeachCaseRelaInfoENS.TeachingPlanAuthor; //教案撰写人
objvPubTeachCaseRelaInfoENT.TeachingObject = objvPubTeachCaseRelaInfoENS.TeachingObject; //教学目标
objvPubTeachCaseRelaInfoENT.TeachingEmphases = objvPubTeachCaseRelaInfoENS.TeachingEmphases; //教学重点
objvPubTeachCaseRelaInfoENT.TeachingDifficulty = objvPubTeachCaseRelaInfoENS.TeachingDifficulty; //教学难点
objvPubTeachCaseRelaInfoENT.TeachingTool = objvPubTeachCaseRelaInfoENS.TeachingTool; //教学用具
objvPubTeachCaseRelaInfoENT.TeachingProcess = objvPubTeachCaseRelaInfoENS.TeachingProcess; //教学过程
objvPubTeachCaseRelaInfoENT.IdFtpResource = objvPubTeachCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvPubTeachCaseRelaInfoENT.FtpResourceID = objvPubTeachCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvPubTeachCaseRelaInfoENT.FileOriginalName = objvPubTeachCaseRelaInfoENS.FileOriginalName; //文件原名
objvPubTeachCaseRelaInfoENT.FileDirName = objvPubTeachCaseRelaInfoENS.FileDirName; //文件目录名
objvPubTeachCaseRelaInfoENT.FileRename = objvPubTeachCaseRelaInfoENS.FileRename; //文件新名
objvPubTeachCaseRelaInfoENT.FileUpDate = objvPubTeachCaseRelaInfoENS.FileUpDate; //创建日期
objvPubTeachCaseRelaInfoENT.FileUpTime = objvPubTeachCaseRelaInfoENS.FileUpTime; //创建时间
objvPubTeachCaseRelaInfoENT.IdResource = objvPubTeachCaseRelaInfoENS.IdResource; //资源流水号
objvPubTeachCaseRelaInfoENT.SaveMode = objvPubTeachCaseRelaInfoENS.SaveMode; //文件存放方式
objvPubTeachCaseRelaInfoENT.IdResourceType = objvPubTeachCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvPubTeachCaseRelaInfoENT.ResourceTypeID = objvPubTeachCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvPubTeachCaseRelaInfoENT.ResourceTypeName = objvPubTeachCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvPubTeachCaseRelaInfoENT.IdPubCaseType = objvPubTeachCaseRelaInfoENS.IdPubCaseType; //公开课案例类型流水号
objvPubTeachCaseRelaInfoENT.PubCaseTypeID = objvPubTeachCaseRelaInfoENS.PubCaseTypeID; //公开课案例类型ID
objvPubTeachCaseRelaInfoENT.PubCaseTypeName = objvPubTeachCaseRelaInfoENS.PubCaseTypeName; //公开课案例类型名称
objvPubTeachCaseRelaInfoENT.IdPubTeachCaseRelaInfoType = objvPubTeachCaseRelaInfoENS.IdPubTeachCaseRelaInfoType; //公开课案例相关信息类型流水号
objvPubTeachCaseRelaInfoENT.PubTeachCaseRelaInfoTypeID = objvPubTeachCaseRelaInfoENS.PubTeachCaseRelaInfoTypeID; //公开课案例相关信息类型ID
objvPubTeachCaseRelaInfoENT.PubTeachCaseRelaInfoTypeName = objvPubTeachCaseRelaInfoENS.PubTeachCaseRelaInfoTypeName; //公开课案例相关信息类型名称
objvPubTeachCaseRelaInfoENT.TeachingPlanType = objvPubTeachCaseRelaInfoENS.TeachingPlanType; //教案类型
objvPubTeachCaseRelaInfoENT.BrowseCount = objvPubTeachCaseRelaInfoENS.BrowseCount; //浏览次数
objvPubTeachCaseRelaInfoENT.SimplePlanContent = objvPubTeachCaseRelaInfoENS.SimplePlanContent; //简案内容
objvPubTeachCaseRelaInfoENT.ResourceOwner = objvPubTeachCaseRelaInfoENS.ResourceOwner; //上传者
objvPubTeachCaseRelaInfoENT.ftpFileType = objvPubTeachCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvPubTeachCaseRelaInfoENT.ftpFileSize = objvPubTeachCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvPubTeachCaseRelaInfoENT.ftpResourceOwner = objvPubTeachCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvPubTeachCaseRelaInfoENT.IdDiscipline = objvPubTeachCaseRelaInfoENS.IdDiscipline; //学科流水号
objvPubTeachCaseRelaInfoENT.DisciplineID = objvPubTeachCaseRelaInfoENS.DisciplineID; //学科ID
objvPubTeachCaseRelaInfoENT.DisciplineName = objvPubTeachCaseRelaInfoENS.DisciplineName; //学科名称
objvPubTeachCaseRelaInfoENT.IdStudyLevel = objvPubTeachCaseRelaInfoENS.IdStudyLevel; //id_StudyLevel
objvPubTeachCaseRelaInfoENT.StudyLevelName = objvPubTeachCaseRelaInfoENS.StudyLevelName; //学段名称
objvPubTeachCaseRelaInfoENT.IdFile = objvPubTeachCaseRelaInfoENS.IdFile; //文件流水号
objvPubTeachCaseRelaInfoENT.FileName = objvPubTeachCaseRelaInfoENS.FileName; //文件名称
objvPubTeachCaseRelaInfoENT.FileType = objvPubTeachCaseRelaInfoENS.FileType; //文件类型
objvPubTeachCaseRelaInfoENT.SaveDate = objvPubTeachCaseRelaInfoENS.SaveDate; //创建日期
objvPubTeachCaseRelaInfoENT.FileSize = objvPubTeachCaseRelaInfoENS.FileSize; //文件大小
objvPubTeachCaseRelaInfoENT.SaveTime = objvPubTeachCaseRelaInfoENS.SaveTime; //创建时间
objvPubTeachCaseRelaInfoENT.IdPubClassCase = objvPubTeachCaseRelaInfoENS.IdPubClassCase; //案例流水号
objvPubTeachCaseRelaInfoENT.PubClassCaseID = objvPubTeachCaseRelaInfoENS.PubClassCaseID; //案例ID
objvPubTeachCaseRelaInfoENT.PubClassCaseName = objvPubTeachCaseRelaInfoENS.PubClassCaseName; //案例课题名称
objvPubTeachCaseRelaInfoENT.PubClassCaseExecutor = objvPubTeachCaseRelaInfoENS.PubClassCaseExecutor; //案例执教者
objvPubTeachCaseRelaInfoENT.PubClassCaseTheme = objvPubTeachCaseRelaInfoENS.PubClassCaseTheme; //案例主题词
objvPubTeachCaseRelaInfoENT.PubClassCaseBG = objvPubTeachCaseRelaInfoENS.PubClassCaseBG; //案例背景资料
objvPubTeachCaseRelaInfoENT.PubClassCaseTeachDate = objvPubTeachCaseRelaInfoENS.PubClassCaseTeachDate; //案例授课日期
objvPubTeachCaseRelaInfoENT.PubClassCaseDateIn = objvPubTeachCaseRelaInfoENS.PubClassCaseDateIn; //案例入库日期
objvPubTeachCaseRelaInfoENT.IdTeachingPlan = objvPubTeachCaseRelaInfoENS.IdTeachingPlan; //教案流水号
objvPubTeachCaseRelaInfoENT.Memo = objvPubTeachCaseRelaInfoENS.Memo; //备注
objvPubTeachCaseRelaInfoENT.FileOriginName = objvPubTeachCaseRelaInfoENS.FileOriginName; //原文件名
objvPubTeachCaseRelaInfoENT.IsExistFile = objvPubTeachCaseRelaInfoENS.IsExistFile; //是否存在文件
objvPubTeachCaseRelaInfoENT.ResourceID = objvPubTeachCaseRelaInfoENS.ResourceID; //资源ID
objvPubTeachCaseRelaInfoENT.FileNewName = objvPubTeachCaseRelaInfoENS.FileNewName; //新文件名
objvPubTeachCaseRelaInfoENT.FileOldName = objvPubTeachCaseRelaInfoENS.FileOldName; //旧文件名
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
 /// <param name = "objvPubTeachCaseRelaInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN)
{
try
{
objvPubTeachCaseRelaInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPubTeachCaseRelaInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo = objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfo; //公开课案例相关信息流水号
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.IsVisible = objvPubTeachCaseRelaInfoEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.SubjectName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.SubjectName = objvPubTeachCaseRelaInfoEN.SubjectName; //课题名称
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.TeachingPlanAuthor, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor; //教案撰写人
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.TeachingObject, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.TeachingObject = objvPubTeachCaseRelaInfoEN.TeachingObject == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.TeachingObject; //教学目标
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.TeachingEmphases, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.TeachingEmphases = objvPubTeachCaseRelaInfoEN.TeachingEmphases == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.TeachingEmphases; //教学重点
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.TeachingDifficulty, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.TeachingDifficulty = objvPubTeachCaseRelaInfoEN.TeachingDifficulty == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.TeachingDifficulty; //教学难点
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.TeachingTool, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.TeachingTool = objvPubTeachCaseRelaInfoEN.TeachingTool == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.TeachingTool; //教学用具
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.TeachingProcess, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.TeachingProcess = objvPubTeachCaseRelaInfoEN.TeachingProcess == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.TeachingProcess; //教学过程
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.IdFtpResource = objvPubTeachCaseRelaInfoEN.IdFtpResource == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.FtpResourceID = objvPubTeachCaseRelaInfoEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.FileOriginalName = objvPubTeachCaseRelaInfoEN.FileOriginalName == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.FileDirName = objvPubTeachCaseRelaInfoEN.FileDirName == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.FileRename = objvPubTeachCaseRelaInfoEN.FileRename == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.FileUpDate = objvPubTeachCaseRelaInfoEN.FileUpDate == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.FileUpTime = objvPubTeachCaseRelaInfoEN.FileUpTime == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.IdResource = objvPubTeachCaseRelaInfoEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.SaveMode = objvPubTeachCaseRelaInfoEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.IdResourceType = objvPubTeachCaseRelaInfoEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.ResourceTypeID = objvPubTeachCaseRelaInfoEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.ResourceTypeName = objvPubTeachCaseRelaInfoEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.IdPubCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.IdPubCaseType = objvPubTeachCaseRelaInfoEN.IdPubCaseType; //公开课案例类型流水号
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.PubCaseTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.PubCaseTypeID = objvPubTeachCaseRelaInfoEN.PubCaseTypeID; //公开课案例类型ID
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.PubCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.PubCaseTypeName = objvPubTeachCaseRelaInfoEN.PubCaseTypeName; //公开课案例类型名称
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType = objvPubTeachCaseRelaInfoEN.IdPubTeachCaseRelaInfoType; //公开课案例相关信息类型流水号
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID = objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeID; //公开课案例相关信息类型ID
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.PubTeachCaseRelaInfoTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName = objvPubTeachCaseRelaInfoEN.PubTeachCaseRelaInfoTypeName; //公开课案例相关信息类型名称
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.TeachingPlanType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.TeachingPlanType = objvPubTeachCaseRelaInfoEN.TeachingPlanType == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.TeachingPlanType; //教案类型
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.BrowseCount = objvPubTeachCaseRelaInfoEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.SimplePlanContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.SimplePlanContent = objvPubTeachCaseRelaInfoEN.SimplePlanContent == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.SimplePlanContent; //简案内容
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.ResourceOwner = objvPubTeachCaseRelaInfoEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.ftpFileType = objvPubTeachCaseRelaInfoEN.ftpFileType == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.ftpFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.ftpFileSize = objvPubTeachCaseRelaInfoEN.ftpFileSize == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.ftpFileSize; //ftp文件大小
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.ftpResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.ftpResourceOwner = objvPubTeachCaseRelaInfoEN.ftpResourceOwner == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.ftpResourceOwner; //Ftp资源拥有者
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.IdDiscipline = objvPubTeachCaseRelaInfoEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.DisciplineID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.DisciplineID = objvPubTeachCaseRelaInfoEN.DisciplineID; //学科ID
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.DisciplineName = objvPubTeachCaseRelaInfoEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.IdStudyLevel = objvPubTeachCaseRelaInfoEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.StudyLevelName = objvPubTeachCaseRelaInfoEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.IdFile = objvPubTeachCaseRelaInfoEN.IdFile == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.FileName = objvPubTeachCaseRelaInfoEN.FileName == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.FileName; //文件名称
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.FileType = objvPubTeachCaseRelaInfoEN.FileType == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.FileType; //文件类型
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.SaveDate = objvPubTeachCaseRelaInfoEN.SaveDate == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.FileSize = objvPubTeachCaseRelaInfoEN.FileSize == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.SaveTime = objvPubTeachCaseRelaInfoEN.SaveTime == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.IdPubClassCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.IdPubClassCase = objvPubTeachCaseRelaInfoEN.IdPubClassCase; //案例流水号
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.PubClassCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.PubClassCaseID = objvPubTeachCaseRelaInfoEN.PubClassCaseID; //案例ID
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.PubClassCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.PubClassCaseName = objvPubTeachCaseRelaInfoEN.PubClassCaseName; //案例课题名称
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.PubClassCaseExecutor, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor; //案例执教者
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.PubClassCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = objvPubTeachCaseRelaInfoEN.PubClassCaseTheme == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.PubClassCaseTheme; //案例主题词
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.PubClassCaseBG, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.PubClassCaseBG = objvPubTeachCaseRelaInfoEN.PubClassCaseBG == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.PubClassCaseBG; //案例背景资料
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.PubClassCaseTeachDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate; //案例授课日期
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.PubClassCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.IdTeachingPlan = objvPubTeachCaseRelaInfoEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.Memo = objvPubTeachCaseRelaInfoEN.Memo == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.Memo; //备注
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.FileOriginName = objvPubTeachCaseRelaInfoEN.FileOriginName == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.FileOriginName; //原文件名
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.IsExistFile = objvPubTeachCaseRelaInfoEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.ResourceID = objvPubTeachCaseRelaInfoEN.ResourceID == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.FileNewName = objvPubTeachCaseRelaInfoEN.FileNewName == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convPubTeachCaseRelaInfo.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubTeachCaseRelaInfoEN.FileOldName = objvPubTeachCaseRelaInfoEN.FileOldName == "[null]" ? null :  objvPubTeachCaseRelaInfoEN.FileOldName; //旧文件名
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
 /// <param name = "objvPubTeachCaseRelaInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN)
{
try
{
if (objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor == "[null]") objvPubTeachCaseRelaInfoEN.TeachingPlanAuthor = null; //教案撰写人
if (objvPubTeachCaseRelaInfoEN.TeachingObject == "[null]") objvPubTeachCaseRelaInfoEN.TeachingObject = null; //教学目标
if (objvPubTeachCaseRelaInfoEN.TeachingEmphases == "[null]") objvPubTeachCaseRelaInfoEN.TeachingEmphases = null; //教学重点
if (objvPubTeachCaseRelaInfoEN.TeachingDifficulty == "[null]") objvPubTeachCaseRelaInfoEN.TeachingDifficulty = null; //教学难点
if (objvPubTeachCaseRelaInfoEN.TeachingTool == "[null]") objvPubTeachCaseRelaInfoEN.TeachingTool = null; //教学用具
if (objvPubTeachCaseRelaInfoEN.TeachingProcess == "[null]") objvPubTeachCaseRelaInfoEN.TeachingProcess = null; //教学过程
if (objvPubTeachCaseRelaInfoEN.IdFtpResource == "[null]") objvPubTeachCaseRelaInfoEN.IdFtpResource = null; //FTP资源流水号
if (objvPubTeachCaseRelaInfoEN.FileOriginalName == "[null]") objvPubTeachCaseRelaInfoEN.FileOriginalName = null; //文件原名
if (objvPubTeachCaseRelaInfoEN.FileDirName == "[null]") objvPubTeachCaseRelaInfoEN.FileDirName = null; //文件目录名
if (objvPubTeachCaseRelaInfoEN.FileRename == "[null]") objvPubTeachCaseRelaInfoEN.FileRename = null; //文件新名
if (objvPubTeachCaseRelaInfoEN.FileUpDate == "[null]") objvPubTeachCaseRelaInfoEN.FileUpDate = null; //创建日期
if (objvPubTeachCaseRelaInfoEN.FileUpTime == "[null]") objvPubTeachCaseRelaInfoEN.FileUpTime = null; //创建时间
if (objvPubTeachCaseRelaInfoEN.TeachingPlanType == "[null]") objvPubTeachCaseRelaInfoEN.TeachingPlanType = null; //教案类型
if (objvPubTeachCaseRelaInfoEN.SimplePlanContent == "[null]") objvPubTeachCaseRelaInfoEN.SimplePlanContent = null; //简案内容
if (objvPubTeachCaseRelaInfoEN.ftpFileType == "[null]") objvPubTeachCaseRelaInfoEN.ftpFileType = null; //ftp文件类型
if (objvPubTeachCaseRelaInfoEN.ftpFileSize == "[null]") objvPubTeachCaseRelaInfoEN.ftpFileSize = null; //ftp文件大小
if (objvPubTeachCaseRelaInfoEN.ftpResourceOwner == "[null]") objvPubTeachCaseRelaInfoEN.ftpResourceOwner = null; //Ftp资源拥有者
if (objvPubTeachCaseRelaInfoEN.IdFile == "[null]") objvPubTeachCaseRelaInfoEN.IdFile = null; //文件流水号
if (objvPubTeachCaseRelaInfoEN.FileName == "[null]") objvPubTeachCaseRelaInfoEN.FileName = null; //文件名称
if (objvPubTeachCaseRelaInfoEN.FileType == "[null]") objvPubTeachCaseRelaInfoEN.FileType = null; //文件类型
if (objvPubTeachCaseRelaInfoEN.SaveDate == "[null]") objvPubTeachCaseRelaInfoEN.SaveDate = null; //创建日期
if (objvPubTeachCaseRelaInfoEN.FileSize == "[null]") objvPubTeachCaseRelaInfoEN.FileSize = null; //文件大小
if (objvPubTeachCaseRelaInfoEN.SaveTime == "[null]") objvPubTeachCaseRelaInfoEN.SaveTime = null; //创建时间
if (objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor == "[null]") objvPubTeachCaseRelaInfoEN.PubClassCaseExecutor = null; //案例执教者
if (objvPubTeachCaseRelaInfoEN.PubClassCaseTheme == "[null]") objvPubTeachCaseRelaInfoEN.PubClassCaseTheme = null; //案例主题词
if (objvPubTeachCaseRelaInfoEN.PubClassCaseBG == "[null]") objvPubTeachCaseRelaInfoEN.PubClassCaseBG = null; //案例背景资料
if (objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate == "[null]") objvPubTeachCaseRelaInfoEN.PubClassCaseTeachDate = null; //案例授课日期
if (objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn == "[null]") objvPubTeachCaseRelaInfoEN.PubClassCaseDateIn = null; //案例入库日期
if (objvPubTeachCaseRelaInfoEN.Memo == "[null]") objvPubTeachCaseRelaInfoEN.Memo = null; //备注
if (objvPubTeachCaseRelaInfoEN.FileOriginName == "[null]") objvPubTeachCaseRelaInfoEN.FileOriginName = null; //原文件名
if (objvPubTeachCaseRelaInfoEN.ResourceID == "[null]") objvPubTeachCaseRelaInfoEN.ResourceID = null; //资源ID
if (objvPubTeachCaseRelaInfoEN.FileNewName == "[null]") objvPubTeachCaseRelaInfoEN.FileNewName = null; //新文件名
if (objvPubTeachCaseRelaInfoEN.FileOldName == "[null]") objvPubTeachCaseRelaInfoEN.FileOldName = null; //旧文件名
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
public static void CheckProperty4Condition(clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoEN)
{
 vPubTeachCaseRelaInfoDA.CheckProperty4Condition(objvPubTeachCaseRelaInfoEN);
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
if (clsPubTeachCaseRelaInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubTeachCaseRelaInfoBL没有刷新缓存机制(clsPubTeachCaseRelaInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubTeachCaseRelaInfoTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubTeachCaseRelaInfoTypeBL没有刷新缓存机制(clsPubTeachCaseRelaInfoTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeBL没有刷新缓存机制(clsResourceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceBL没有刷新缓存机制(clsResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFileServerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerBL没有刷新缓存机制(clsFileServerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceBL没有刷新缓存机制(clsFtpResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeBL没有刷新缓存机制(clsRecommendedDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseBL没有刷新缓存机制(clsPubClassCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingPlanBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingPlanBL没有刷新缓存机制(clsTeachingPlanBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateGaugeVersionBL没有刷新缓存机制(clsPubClassCaseSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubCaseTypeBL没有刷新缓存机制(clsPubCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdPubTeachCaseRelaInfo");
//if (arrvPubTeachCaseRelaInfoObjLstCache == null)
//{
//arrvPubTeachCaseRelaInfoObjLstCache = vPubTeachCaseRelaInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdPubTeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubTeachCaseRelaInfoEN GetObjByIdPubTeachCaseRelaInfoCache(long lngIdPubTeachCaseRelaInfo)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPubTeachCaseRelaInfoEN._CurrTabName);
List<clsvPubTeachCaseRelaInfoEN> arrvPubTeachCaseRelaInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvPubTeachCaseRelaInfoEN> arrvPubTeachCaseRelaInfoObjLst_Sel =
arrvPubTeachCaseRelaInfoObjLstCache
.Where(x=> x.IdPubTeachCaseRelaInfo == lngIdPubTeachCaseRelaInfo 
);
if (arrvPubTeachCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvPubTeachCaseRelaInfoEN obj = clsvPubTeachCaseRelaInfoBL.GetObjByIdPubTeachCaseRelaInfo(lngIdPubTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPubTeachCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPubTeachCaseRelaInfoEN> GetAllvPubTeachCaseRelaInfoObjLstCache()
{
//获取缓存中的对象列表
List<clsvPubTeachCaseRelaInfoEN> arrvPubTeachCaseRelaInfoObjLstCache = GetObjLstCache(); 
return arrvPubTeachCaseRelaInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPubTeachCaseRelaInfoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPubTeachCaseRelaInfoEN._CurrTabName);
List<clsvPubTeachCaseRelaInfoEN> arrvPubTeachCaseRelaInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPubTeachCaseRelaInfoObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvPubTeachCaseRelaInfoEN._CurrTabName);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngIdPubTeachCaseRelaInfo)
{
if (strInFldName != convPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPubTeachCaseRelaInfo.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPubTeachCaseRelaInfo.AttributeName));
throw new Exception(strMsg);
}
var objvPubTeachCaseRelaInfo = clsvPubTeachCaseRelaInfoBL.GetObjByIdPubTeachCaseRelaInfoCache(lngIdPubTeachCaseRelaInfo);
if (objvPubTeachCaseRelaInfo == null) return "";
return objvPubTeachCaseRelaInfo[strOutFldName].ToString();
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
int intRecCount = clsvPubTeachCaseRelaInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsvPubTeachCaseRelaInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPubTeachCaseRelaInfoDA.GetRecCount();
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
int intRecCount = clsvPubTeachCaseRelaInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPubTeachCaseRelaInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPubTeachCaseRelaInfoEN objvPubTeachCaseRelaInfoCond)
{
List<clsvPubTeachCaseRelaInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPubTeachCaseRelaInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPubTeachCaseRelaInfo.AttributeName)
{
if (objvPubTeachCaseRelaInfoCond.IsUpdated(strFldName) == false) continue;
if (objvPubTeachCaseRelaInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubTeachCaseRelaInfoCond[strFldName].ToString());
}
else
{
if (objvPubTeachCaseRelaInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPubTeachCaseRelaInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubTeachCaseRelaInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPubTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPubTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPubTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPubTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPubTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPubTeachCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPubTeachCaseRelaInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPubTeachCaseRelaInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPubTeachCaseRelaInfoCond[strFldName]));
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
 List<string> arrList = clsvPubTeachCaseRelaInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPubTeachCaseRelaInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPubTeachCaseRelaInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}