
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvGroupPicRelationBL
 表名:vGroupPicRelation(01120018)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:44
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
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
public static class  clsvGroupPicRelationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "intRelationshipId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvGroupPicRelationEN GetObj(this K_RelationshipId_vGroupPicRelation myKey)
{
clsvGroupPicRelationEN objvGroupPicRelationEN = clsvGroupPicRelationBL.vGroupPicRelationDA.GetObjByRelationshipId(myKey.Value);
return objvGroupPicRelationEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetMemo(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convGroupPicRelation.Memo);
}
objvGroupPicRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.Memo) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.Memo, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.Memo] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetGroupId(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strGroupId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupId, 8, convGroupPicRelation.GroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupId, 8, convGroupPicRelation.GroupId);
}
objvGroupPicRelationEN.GroupId = strGroupId; //组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.GroupId) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.GroupId, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.GroupId] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetRelationshipId(this clsvGroupPicRelationEN objvGroupPicRelationEN, int intRelationshipId, string strComparisonOp="")
	{
objvGroupPicRelationEN.RelationshipId = intRelationshipId; //RelationshipId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.RelationshipId) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.RelationshipId, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.RelationshipId] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetGroupName(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strGroupName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupName, 40, convGroupPicRelation.GroupName);
}
objvGroupPicRelationEN.GroupName = strGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.GroupName) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.GroupName, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.GroupName] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetPictureId(this clsvGroupPicRelationEN objvGroupPicRelationEN, int? intPictureId, string strComparisonOp="")
	{
objvGroupPicRelationEN.PictureId = intPictureId; //PictureId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.PictureId) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.PictureId, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.PictureId] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetPictureName(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strPictureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPictureName, 100, convGroupPicRelation.PictureName);
}
objvGroupPicRelationEN.PictureName = strPictureName; //PictureName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.PictureName) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.PictureName, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.PictureName] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetPictureConfigName(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strPictureConfigName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPictureConfigName, 50, convGroupPicRelation.PictureConfigName);
}
objvGroupPicRelationEN.PictureConfigName = strPictureConfigName; //PictureConfigName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.PictureConfigName) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.PictureConfigName, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.PictureConfigName] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetCreateTime(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strCreateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateTime, 16, convGroupPicRelation.CreateTime);
}
objvGroupPicRelationEN.CreateTime = strCreateTime; //建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.CreateTime) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.CreateTime, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.CreateTime] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetCreateUserID(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strCreateUserID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUserID, 20, convGroupPicRelation.CreateUserID);
}
objvGroupPicRelationEN.CreateUserID = strCreateUserID; //建立用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.CreateUserID) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.CreateUserID, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.CreateUserID] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetLastModifyUserID(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strLastModifyUserID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastModifyUserID, 20, convGroupPicRelation.LastModifyUserID);
}
objvGroupPicRelationEN.LastModifyUserID = strLastModifyUserID; //最后修改用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.LastModifyUserID) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.LastModifyUserID, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.LastModifyUserID] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetLastModifyTime(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strLastModifyTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastModifyTime, 16, convGroupPicRelation.LastModifyTime);
}
objvGroupPicRelationEN.LastModifyTime = strLastModifyTime; //最后修改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.LastModifyTime) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.LastModifyTime, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.LastModifyTime] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetLastModifyUserName(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strLastModifyUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastModifyUserName, 30, convGroupPicRelation.LastModifyUserName);
}
objvGroupPicRelationEN.LastModifyUserName = strLastModifyUserName; //最后修改用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.LastModifyUserName) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.LastModifyUserName, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.LastModifyUserName] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetPictureConfigerId(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strPictureConfigerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPictureConfigerId, 4, convGroupPicRelation.PictureConfigerId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPictureConfigerId, 4, convGroupPicRelation.PictureConfigerId);
}
objvGroupPicRelationEN.PictureConfigerId = strPictureConfigerId; //PictureConfigerId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.PictureConfigerId) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.PictureConfigerId, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.PictureConfigerId] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetOrginialFileName(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strOrginialFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOrginialFileName, 100, convGroupPicRelation.OrginialFileName);
}
objvGroupPicRelationEN.OrginialFileName = strOrginialFileName; //OrginialFileName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.OrginialFileName) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.OrginialFileName, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.OrginialFileName] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetOrginialFileSize(this clsvGroupPicRelationEN objvGroupPicRelationEN, int? intOrginialFileSize, string strComparisonOp="")
	{
objvGroupPicRelationEN.OrginialFileSize = intOrginialFileSize; //OrginialFileSize
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.OrginialFileSize) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.OrginialFileSize, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.OrginialFileSize] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetResizePictureSize(this clsvGroupPicRelationEN objvGroupPicRelationEN, int? intResizePictureSize, string strComparisonOp="")
	{
objvGroupPicRelationEN.ResizePictureSize = intResizePictureSize; //ResizePictureSize
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.ResizePictureSize) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.ResizePictureSize, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.ResizePictureSize] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetThumbSize(this clsvGroupPicRelationEN objvGroupPicRelationEN, int? intThumbSize, string strComparisonOp="")
	{
objvGroupPicRelationEN.ThumbSize = intThumbSize; //ThumbSize
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.ThumbSize) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.ThumbSize, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.ThumbSize] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetOrginialFileWidth(this clsvGroupPicRelationEN objvGroupPicRelationEN, int? intOrginialFileWidth, string strComparisonOp="")
	{
objvGroupPicRelationEN.OrginialFileWidth = intOrginialFileWidth; //OrginialFileWidth
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.OrginialFileWidth) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.OrginialFileWidth, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.OrginialFileWidth] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetCreateUserName(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strCreateUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUserName, 30, convGroupPicRelation.CreateUserName);
}
objvGroupPicRelationEN.CreateUserName = strCreateUserName; //建立用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.CreateUserName) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.CreateUserName, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.CreateUserName] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGroupPicRelationEN SetPicturePath(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strPicturePath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPicturePath, 50, convGroupPicRelation.PicturePath);
}
objvGroupPicRelationEN.PicturePath = strPicturePath; //PicturePath
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGroupPicRelationEN.dicFldComparisonOp.ContainsKey(convGroupPicRelation.PicturePath) == false)
{
objvGroupPicRelationEN.dicFldComparisonOp.Add(convGroupPicRelation.PicturePath, strComparisonOp);
}
else
{
objvGroupPicRelationEN.dicFldComparisonOp[convGroupPicRelation.PicturePath] = strComparisonOp;
}
}
return objvGroupPicRelationEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvGroupPicRelationENS">源对象</param>
 /// <param name = "objvGroupPicRelationENT">目标对象</param>
 public static void CopyTo(this clsvGroupPicRelationEN objvGroupPicRelationENS, clsvGroupPicRelationEN objvGroupPicRelationENT)
{
try
{
objvGroupPicRelationENT.Memo = objvGroupPicRelationENS.Memo; //备注
objvGroupPicRelationENT.GroupId = objvGroupPicRelationENS.GroupId; //组Id
objvGroupPicRelationENT.RelationshipId = objvGroupPicRelationENS.RelationshipId; //RelationshipId
objvGroupPicRelationENT.GroupName = objvGroupPicRelationENS.GroupName; //组名
objvGroupPicRelationENT.PictureId = objvGroupPicRelationENS.PictureId; //PictureId
objvGroupPicRelationENT.PictureName = objvGroupPicRelationENS.PictureName; //PictureName
objvGroupPicRelationENT.PictureConfigName = objvGroupPicRelationENS.PictureConfigName; //PictureConfigName
objvGroupPicRelationENT.CreateTime = objvGroupPicRelationENS.CreateTime; //建立时间
objvGroupPicRelationENT.CreateUserID = objvGroupPicRelationENS.CreateUserID; //建立用户ID
objvGroupPicRelationENT.LastModifyUserID = objvGroupPicRelationENS.LastModifyUserID; //最后修改用户ID
objvGroupPicRelationENT.LastModifyTime = objvGroupPicRelationENS.LastModifyTime; //最后修改时间
objvGroupPicRelationENT.LastModifyUserName = objvGroupPicRelationENS.LastModifyUserName; //最后修改用户名
objvGroupPicRelationENT.PictureConfigerId = objvGroupPicRelationENS.PictureConfigerId; //PictureConfigerId
objvGroupPicRelationENT.OrginialFileName = objvGroupPicRelationENS.OrginialFileName; //OrginialFileName
objvGroupPicRelationENT.OrginialFileSize = objvGroupPicRelationENS.OrginialFileSize; //OrginialFileSize
objvGroupPicRelationENT.ResizePictureSize = objvGroupPicRelationENS.ResizePictureSize; //ResizePictureSize
objvGroupPicRelationENT.ThumbSize = objvGroupPicRelationENS.ThumbSize; //ThumbSize
objvGroupPicRelationENT.OrginialFileWidth = objvGroupPicRelationENS.OrginialFileWidth; //OrginialFileWidth
objvGroupPicRelationENT.CreateUserName = objvGroupPicRelationENS.CreateUserName; //建立用户名
objvGroupPicRelationENT.PicturePath = objvGroupPicRelationENS.PicturePath; //PicturePath
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
 /// <param name = "objvGroupPicRelationENS">源对象</param>
 /// <returns>目标对象=>clsvGroupPicRelationEN:objvGroupPicRelationENT</returns>
 public static clsvGroupPicRelationEN CopyTo(this clsvGroupPicRelationEN objvGroupPicRelationENS)
{
try
{
 clsvGroupPicRelationEN objvGroupPicRelationENT = new clsvGroupPicRelationEN()
{
Memo = objvGroupPicRelationENS.Memo, //备注
GroupId = objvGroupPicRelationENS.GroupId, //组Id
RelationshipId = objvGroupPicRelationENS.RelationshipId, //RelationshipId
GroupName = objvGroupPicRelationENS.GroupName, //组名
PictureId = objvGroupPicRelationENS.PictureId, //PictureId
PictureName = objvGroupPicRelationENS.PictureName, //PictureName
PictureConfigName = objvGroupPicRelationENS.PictureConfigName, //PictureConfigName
CreateTime = objvGroupPicRelationENS.CreateTime, //建立时间
CreateUserID = objvGroupPicRelationENS.CreateUserID, //建立用户ID
LastModifyUserID = objvGroupPicRelationENS.LastModifyUserID, //最后修改用户ID
LastModifyTime = objvGroupPicRelationENS.LastModifyTime, //最后修改时间
LastModifyUserName = objvGroupPicRelationENS.LastModifyUserName, //最后修改用户名
PictureConfigerId = objvGroupPicRelationENS.PictureConfigerId, //PictureConfigerId
OrginialFileName = objvGroupPicRelationENS.OrginialFileName, //OrginialFileName
OrginialFileSize = objvGroupPicRelationENS.OrginialFileSize, //OrginialFileSize
ResizePictureSize = objvGroupPicRelationENS.ResizePictureSize, //ResizePictureSize
ThumbSize = objvGroupPicRelationENS.ThumbSize, //ThumbSize
OrginialFileWidth = objvGroupPicRelationENS.OrginialFileWidth, //OrginialFileWidth
CreateUserName = objvGroupPicRelationENS.CreateUserName, //建立用户名
PicturePath = objvGroupPicRelationENS.PicturePath, //PicturePath
};
 return objvGroupPicRelationENT;
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
public static void CheckProperty4Condition(this clsvGroupPicRelationEN objvGroupPicRelationEN)
{
 clsvGroupPicRelationBL.vGroupPicRelationDA.CheckProperty4Condition(objvGroupPicRelationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvGroupPicRelationEN objvGroupPicRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.Memo) == true)
{
string strComparisonOpMemo = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.Memo, objvGroupPicRelationCond.Memo, strComparisonOpMemo);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.GroupId) == true)
{
string strComparisonOpGroupId = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.GroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.GroupId, objvGroupPicRelationCond.GroupId, strComparisonOpGroupId);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.RelationshipId) == true)
{
string strComparisonOpRelationshipId = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.RelationshipId];
strWhereCond += string.Format(" And {0} {2} {1}", convGroupPicRelation.RelationshipId, objvGroupPicRelationCond.RelationshipId, strComparisonOpRelationshipId);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.GroupName) == true)
{
string strComparisonOpGroupName = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.GroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.GroupName, objvGroupPicRelationCond.GroupName, strComparisonOpGroupName);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.PictureId) == true)
{
string strComparisonOpPictureId = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.PictureId];
strWhereCond += string.Format(" And {0} {2} {1}", convGroupPicRelation.PictureId, objvGroupPicRelationCond.PictureId, strComparisonOpPictureId);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.PictureName) == true)
{
string strComparisonOpPictureName = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.PictureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.PictureName, objvGroupPicRelationCond.PictureName, strComparisonOpPictureName);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.PictureConfigName) == true)
{
string strComparisonOpPictureConfigName = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.PictureConfigName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.PictureConfigName, objvGroupPicRelationCond.PictureConfigName, strComparisonOpPictureConfigName);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.CreateTime) == true)
{
string strComparisonOpCreateTime = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.CreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.CreateTime, objvGroupPicRelationCond.CreateTime, strComparisonOpCreateTime);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.CreateUserID) == true)
{
string strComparisonOpCreateUserID = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.CreateUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.CreateUserID, objvGroupPicRelationCond.CreateUserID, strComparisonOpCreateUserID);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.LastModifyUserID) == true)
{
string strComparisonOpLastModifyUserID = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.LastModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.LastModifyUserID, objvGroupPicRelationCond.LastModifyUserID, strComparisonOpLastModifyUserID);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.LastModifyTime) == true)
{
string strComparisonOpLastModifyTime = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.LastModifyTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.LastModifyTime, objvGroupPicRelationCond.LastModifyTime, strComparisonOpLastModifyTime);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.LastModifyUserName) == true)
{
string strComparisonOpLastModifyUserName = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.LastModifyUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.LastModifyUserName, objvGroupPicRelationCond.LastModifyUserName, strComparisonOpLastModifyUserName);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.PictureConfigerId) == true)
{
string strComparisonOpPictureConfigerId = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.PictureConfigerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.PictureConfigerId, objvGroupPicRelationCond.PictureConfigerId, strComparisonOpPictureConfigerId);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.OrginialFileName) == true)
{
string strComparisonOpOrginialFileName = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.OrginialFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.OrginialFileName, objvGroupPicRelationCond.OrginialFileName, strComparisonOpOrginialFileName);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.OrginialFileSize) == true)
{
string strComparisonOpOrginialFileSize = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.OrginialFileSize];
strWhereCond += string.Format(" And {0} {2} {1}", convGroupPicRelation.OrginialFileSize, objvGroupPicRelationCond.OrginialFileSize, strComparisonOpOrginialFileSize);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.ResizePictureSize) == true)
{
string strComparisonOpResizePictureSize = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.ResizePictureSize];
strWhereCond += string.Format(" And {0} {2} {1}", convGroupPicRelation.ResizePictureSize, objvGroupPicRelationCond.ResizePictureSize, strComparisonOpResizePictureSize);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.ThumbSize) == true)
{
string strComparisonOpThumbSize = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.ThumbSize];
strWhereCond += string.Format(" And {0} {2} {1}", convGroupPicRelation.ThumbSize, objvGroupPicRelationCond.ThumbSize, strComparisonOpThumbSize);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.OrginialFileWidth) == true)
{
string strComparisonOpOrginialFileWidth = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.OrginialFileWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convGroupPicRelation.OrginialFileWidth, objvGroupPicRelationCond.OrginialFileWidth, strComparisonOpOrginialFileWidth);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.CreateUserName) == true)
{
string strComparisonOpCreateUserName = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.CreateUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.CreateUserName, objvGroupPicRelationCond.CreateUserName, strComparisonOpCreateUserName);
}
if (objvGroupPicRelationCond.IsUpdated(convGroupPicRelation.PicturePath) == true)
{
string strComparisonOpPicturePath = objvGroupPicRelationCond.dicFldComparisonOp[convGroupPicRelation.PicturePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.PicturePath, objvGroupPicRelationCond.PicturePath, strComparisonOpPicturePath);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vGroupPicRelation
{
public virtual bool UpdRelaTabDate(int intRelationshipId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v用户组图片关系(vGroupPicRelation)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvGroupPicRelationBL
{
public static RelatedActions_vGroupPicRelation relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvGroupPicRelationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvGroupPicRelationDA vGroupPicRelationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvGroupPicRelationDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvGroupPicRelationBL()
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
if (string.IsNullOrEmpty(clsvGroupPicRelationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvGroupPicRelationEN._ConnectString);
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
public static DataTable GetDataTable_vGroupPicRelation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vGroupPicRelationDA.GetDataTable_vGroupPicRelation(strWhereCond);
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
objDT = vGroupPicRelationDA.GetDataTable(strWhereCond);
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
objDT = vGroupPicRelationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vGroupPicRelationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vGroupPicRelationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vGroupPicRelationDA.GetDataTable_Top(objTopPara);
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
objDT = vGroupPicRelationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vGroupPicRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vGroupPicRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrRelationshipIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvGroupPicRelationEN> GetObjLstByRelationshipIdLst(List<int> arrRelationshipIdLst)
{
List<clsvGroupPicRelationEN> arrObjLst = new List<clsvGroupPicRelationEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRelationshipIdLst);
 string strWhereCond = string.Format("RelationshipId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGroupPicRelationEN objvGroupPicRelationEN = new clsvGroupPicRelationEN();
try
{
objvGroupPicRelationEN.Memo = objRow[convGroupPicRelation.Memo] == DBNull.Value ? null : objRow[convGroupPicRelation.Memo].ToString().Trim(); //备注
objvGroupPicRelationEN.GroupId = objRow[convGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupId].ToString().Trim(); //组Id
objvGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[convGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objvGroupPicRelationEN.GroupName = objRow[convGroupPicRelation.GroupName] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupName].ToString().Trim(); //组名
objvGroupPicRelationEN.PictureId = objRow[convGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objvGroupPicRelationEN.PictureName = objRow[convGroupPicRelation.PictureName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureName].ToString().Trim(); //PictureName
objvGroupPicRelationEN.PictureConfigName = objRow[convGroupPicRelation.PictureConfigName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigName].ToString().Trim(); //PictureConfigName
objvGroupPicRelationEN.CreateTime = objRow[convGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objvGroupPicRelationEN.CreateUserID = objRow[convGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objvGroupPicRelationEN.LastModifyUserID = objRow[convGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objvGroupPicRelationEN.LastModifyTime = objRow[convGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objvGroupPicRelationEN.LastModifyUserName = objRow[convGroupPicRelation.LastModifyUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserName].ToString().Trim(); //最后修改用户名
objvGroupPicRelationEN.PictureConfigerId = objRow[convGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objvGroupPicRelationEN.OrginialFileName = objRow[convGroupPicRelation.OrginialFileName] == DBNull.Value ? null : objRow[convGroupPicRelation.OrginialFileName].ToString().Trim(); //OrginialFileName
objvGroupPicRelationEN.OrginialFileSize = objRow[convGroupPicRelation.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objvGroupPicRelationEN.ResizePictureSize = objRow[convGroupPicRelation.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objvGroupPicRelationEN.ThumbSize = objRow[convGroupPicRelation.ThumbSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ThumbSize].ToString().Trim()); //ThumbSize
objvGroupPicRelationEN.OrginialFileWidth = objRow[convGroupPicRelation.OrginialFileWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objvGroupPicRelationEN.CreateUserName = objRow[convGroupPicRelation.CreateUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserName].ToString().Trim(); //建立用户名
objvGroupPicRelationEN.PicturePath = objRow[convGroupPicRelation.PicturePath] == DBNull.Value ? null : objRow[convGroupPicRelation.PicturePath].ToString().Trim(); //PicturePath
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGroupPicRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRelationshipIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvGroupPicRelationEN> GetObjLstByRelationshipIdLstCache(List<int> arrRelationshipIdLst)
{
string strKey = string.Format("{0}", clsvGroupPicRelationEN._CurrTabName);
List<clsvGroupPicRelationEN> arrvGroupPicRelationObjLstCache = GetObjLstCache();
IEnumerable <clsvGroupPicRelationEN> arrvGroupPicRelationObjLst_Sel =
arrvGroupPicRelationObjLstCache
.Where(x => arrRelationshipIdLst.Contains(x.RelationshipId));
return arrvGroupPicRelationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvGroupPicRelationEN> GetObjLst(string strWhereCond)
{
List<clsvGroupPicRelationEN> arrObjLst = new List<clsvGroupPicRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGroupPicRelationEN objvGroupPicRelationEN = new clsvGroupPicRelationEN();
try
{
objvGroupPicRelationEN.Memo = objRow[convGroupPicRelation.Memo] == DBNull.Value ? null : objRow[convGroupPicRelation.Memo].ToString().Trim(); //备注
objvGroupPicRelationEN.GroupId = objRow[convGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupId].ToString().Trim(); //组Id
objvGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[convGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objvGroupPicRelationEN.GroupName = objRow[convGroupPicRelation.GroupName] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupName].ToString().Trim(); //组名
objvGroupPicRelationEN.PictureId = objRow[convGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objvGroupPicRelationEN.PictureName = objRow[convGroupPicRelation.PictureName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureName].ToString().Trim(); //PictureName
objvGroupPicRelationEN.PictureConfigName = objRow[convGroupPicRelation.PictureConfigName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigName].ToString().Trim(); //PictureConfigName
objvGroupPicRelationEN.CreateTime = objRow[convGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objvGroupPicRelationEN.CreateUserID = objRow[convGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objvGroupPicRelationEN.LastModifyUserID = objRow[convGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objvGroupPicRelationEN.LastModifyTime = objRow[convGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objvGroupPicRelationEN.LastModifyUserName = objRow[convGroupPicRelation.LastModifyUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserName].ToString().Trim(); //最后修改用户名
objvGroupPicRelationEN.PictureConfigerId = objRow[convGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objvGroupPicRelationEN.OrginialFileName = objRow[convGroupPicRelation.OrginialFileName] == DBNull.Value ? null : objRow[convGroupPicRelation.OrginialFileName].ToString().Trim(); //OrginialFileName
objvGroupPicRelationEN.OrginialFileSize = objRow[convGroupPicRelation.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objvGroupPicRelationEN.ResizePictureSize = objRow[convGroupPicRelation.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objvGroupPicRelationEN.ThumbSize = objRow[convGroupPicRelation.ThumbSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ThumbSize].ToString().Trim()); //ThumbSize
objvGroupPicRelationEN.OrginialFileWidth = objRow[convGroupPicRelation.OrginialFileWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objvGroupPicRelationEN.CreateUserName = objRow[convGroupPicRelation.CreateUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserName].ToString().Trim(); //建立用户名
objvGroupPicRelationEN.PicturePath = objRow[convGroupPicRelation.PicturePath] == DBNull.Value ? null : objRow[convGroupPicRelation.PicturePath].ToString().Trim(); //PicturePath
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGroupPicRelationEN);
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
public static List<clsvGroupPicRelationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvGroupPicRelationEN> arrObjLst = new List<clsvGroupPicRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGroupPicRelationEN objvGroupPicRelationEN = new clsvGroupPicRelationEN();
try
{
objvGroupPicRelationEN.Memo = objRow[convGroupPicRelation.Memo] == DBNull.Value ? null : objRow[convGroupPicRelation.Memo].ToString().Trim(); //备注
objvGroupPicRelationEN.GroupId = objRow[convGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupId].ToString().Trim(); //组Id
objvGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[convGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objvGroupPicRelationEN.GroupName = objRow[convGroupPicRelation.GroupName] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupName].ToString().Trim(); //组名
objvGroupPicRelationEN.PictureId = objRow[convGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objvGroupPicRelationEN.PictureName = objRow[convGroupPicRelation.PictureName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureName].ToString().Trim(); //PictureName
objvGroupPicRelationEN.PictureConfigName = objRow[convGroupPicRelation.PictureConfigName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigName].ToString().Trim(); //PictureConfigName
objvGroupPicRelationEN.CreateTime = objRow[convGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objvGroupPicRelationEN.CreateUserID = objRow[convGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objvGroupPicRelationEN.LastModifyUserID = objRow[convGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objvGroupPicRelationEN.LastModifyTime = objRow[convGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objvGroupPicRelationEN.LastModifyUserName = objRow[convGroupPicRelation.LastModifyUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserName].ToString().Trim(); //最后修改用户名
objvGroupPicRelationEN.PictureConfigerId = objRow[convGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objvGroupPicRelationEN.OrginialFileName = objRow[convGroupPicRelation.OrginialFileName] == DBNull.Value ? null : objRow[convGroupPicRelation.OrginialFileName].ToString().Trim(); //OrginialFileName
objvGroupPicRelationEN.OrginialFileSize = objRow[convGroupPicRelation.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objvGroupPicRelationEN.ResizePictureSize = objRow[convGroupPicRelation.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objvGroupPicRelationEN.ThumbSize = objRow[convGroupPicRelation.ThumbSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ThumbSize].ToString().Trim()); //ThumbSize
objvGroupPicRelationEN.OrginialFileWidth = objRow[convGroupPicRelation.OrginialFileWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objvGroupPicRelationEN.CreateUserName = objRow[convGroupPicRelation.CreateUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserName].ToString().Trim(); //建立用户名
objvGroupPicRelationEN.PicturePath = objRow[convGroupPicRelation.PicturePath] == DBNull.Value ? null : objRow[convGroupPicRelation.PicturePath].ToString().Trim(); //PicturePath
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGroupPicRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvGroupPicRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvGroupPicRelationEN> GetSubObjLstCache(clsvGroupPicRelationEN objvGroupPicRelationCond)
{
List<clsvGroupPicRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvGroupPicRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convGroupPicRelation.AttributeName)
{
if (objvGroupPicRelationCond.IsUpdated(strFldName) == false) continue;
if (objvGroupPicRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvGroupPicRelationCond[strFldName].ToString());
}
else
{
if (objvGroupPicRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvGroupPicRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvGroupPicRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvGroupPicRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvGroupPicRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvGroupPicRelationCond[strFldName]));
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
public static List<clsvGroupPicRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvGroupPicRelationEN> arrObjLst = new List<clsvGroupPicRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGroupPicRelationEN objvGroupPicRelationEN = new clsvGroupPicRelationEN();
try
{
objvGroupPicRelationEN.Memo = objRow[convGroupPicRelation.Memo] == DBNull.Value ? null : objRow[convGroupPicRelation.Memo].ToString().Trim(); //备注
objvGroupPicRelationEN.GroupId = objRow[convGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupId].ToString().Trim(); //组Id
objvGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[convGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objvGroupPicRelationEN.GroupName = objRow[convGroupPicRelation.GroupName] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupName].ToString().Trim(); //组名
objvGroupPicRelationEN.PictureId = objRow[convGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objvGroupPicRelationEN.PictureName = objRow[convGroupPicRelation.PictureName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureName].ToString().Trim(); //PictureName
objvGroupPicRelationEN.PictureConfigName = objRow[convGroupPicRelation.PictureConfigName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigName].ToString().Trim(); //PictureConfigName
objvGroupPicRelationEN.CreateTime = objRow[convGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objvGroupPicRelationEN.CreateUserID = objRow[convGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objvGroupPicRelationEN.LastModifyUserID = objRow[convGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objvGroupPicRelationEN.LastModifyTime = objRow[convGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objvGroupPicRelationEN.LastModifyUserName = objRow[convGroupPicRelation.LastModifyUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserName].ToString().Trim(); //最后修改用户名
objvGroupPicRelationEN.PictureConfigerId = objRow[convGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objvGroupPicRelationEN.OrginialFileName = objRow[convGroupPicRelation.OrginialFileName] == DBNull.Value ? null : objRow[convGroupPicRelation.OrginialFileName].ToString().Trim(); //OrginialFileName
objvGroupPicRelationEN.OrginialFileSize = objRow[convGroupPicRelation.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objvGroupPicRelationEN.ResizePictureSize = objRow[convGroupPicRelation.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objvGroupPicRelationEN.ThumbSize = objRow[convGroupPicRelation.ThumbSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ThumbSize].ToString().Trim()); //ThumbSize
objvGroupPicRelationEN.OrginialFileWidth = objRow[convGroupPicRelation.OrginialFileWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objvGroupPicRelationEN.CreateUserName = objRow[convGroupPicRelation.CreateUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserName].ToString().Trim(); //建立用户名
objvGroupPicRelationEN.PicturePath = objRow[convGroupPicRelation.PicturePath] == DBNull.Value ? null : objRow[convGroupPicRelation.PicturePath].ToString().Trim(); //PicturePath
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGroupPicRelationEN);
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
public static List<clsvGroupPicRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvGroupPicRelationEN> arrObjLst = new List<clsvGroupPicRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGroupPicRelationEN objvGroupPicRelationEN = new clsvGroupPicRelationEN();
try
{
objvGroupPicRelationEN.Memo = objRow[convGroupPicRelation.Memo] == DBNull.Value ? null : objRow[convGroupPicRelation.Memo].ToString().Trim(); //备注
objvGroupPicRelationEN.GroupId = objRow[convGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupId].ToString().Trim(); //组Id
objvGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[convGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objvGroupPicRelationEN.GroupName = objRow[convGroupPicRelation.GroupName] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupName].ToString().Trim(); //组名
objvGroupPicRelationEN.PictureId = objRow[convGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objvGroupPicRelationEN.PictureName = objRow[convGroupPicRelation.PictureName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureName].ToString().Trim(); //PictureName
objvGroupPicRelationEN.PictureConfigName = objRow[convGroupPicRelation.PictureConfigName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigName].ToString().Trim(); //PictureConfigName
objvGroupPicRelationEN.CreateTime = objRow[convGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objvGroupPicRelationEN.CreateUserID = objRow[convGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objvGroupPicRelationEN.LastModifyUserID = objRow[convGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objvGroupPicRelationEN.LastModifyTime = objRow[convGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objvGroupPicRelationEN.LastModifyUserName = objRow[convGroupPicRelation.LastModifyUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserName].ToString().Trim(); //最后修改用户名
objvGroupPicRelationEN.PictureConfigerId = objRow[convGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objvGroupPicRelationEN.OrginialFileName = objRow[convGroupPicRelation.OrginialFileName] == DBNull.Value ? null : objRow[convGroupPicRelation.OrginialFileName].ToString().Trim(); //OrginialFileName
objvGroupPicRelationEN.OrginialFileSize = objRow[convGroupPicRelation.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objvGroupPicRelationEN.ResizePictureSize = objRow[convGroupPicRelation.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objvGroupPicRelationEN.ThumbSize = objRow[convGroupPicRelation.ThumbSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ThumbSize].ToString().Trim()); //ThumbSize
objvGroupPicRelationEN.OrginialFileWidth = objRow[convGroupPicRelation.OrginialFileWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objvGroupPicRelationEN.CreateUserName = objRow[convGroupPicRelation.CreateUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserName].ToString().Trim(); //建立用户名
objvGroupPicRelationEN.PicturePath = objRow[convGroupPicRelation.PicturePath] == DBNull.Value ? null : objRow[convGroupPicRelation.PicturePath].ToString().Trim(); //PicturePath
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGroupPicRelationEN);
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
List<clsvGroupPicRelationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvGroupPicRelationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvGroupPicRelationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvGroupPicRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvGroupPicRelationEN> arrObjLst = new List<clsvGroupPicRelationEN>(); 
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
	clsvGroupPicRelationEN objvGroupPicRelationEN = new clsvGroupPicRelationEN();
try
{
objvGroupPicRelationEN.Memo = objRow[convGroupPicRelation.Memo] == DBNull.Value ? null : objRow[convGroupPicRelation.Memo].ToString().Trim(); //备注
objvGroupPicRelationEN.GroupId = objRow[convGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupId].ToString().Trim(); //组Id
objvGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[convGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objvGroupPicRelationEN.GroupName = objRow[convGroupPicRelation.GroupName] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupName].ToString().Trim(); //组名
objvGroupPicRelationEN.PictureId = objRow[convGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objvGroupPicRelationEN.PictureName = objRow[convGroupPicRelation.PictureName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureName].ToString().Trim(); //PictureName
objvGroupPicRelationEN.PictureConfigName = objRow[convGroupPicRelation.PictureConfigName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigName].ToString().Trim(); //PictureConfigName
objvGroupPicRelationEN.CreateTime = objRow[convGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objvGroupPicRelationEN.CreateUserID = objRow[convGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objvGroupPicRelationEN.LastModifyUserID = objRow[convGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objvGroupPicRelationEN.LastModifyTime = objRow[convGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objvGroupPicRelationEN.LastModifyUserName = objRow[convGroupPicRelation.LastModifyUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserName].ToString().Trim(); //最后修改用户名
objvGroupPicRelationEN.PictureConfigerId = objRow[convGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objvGroupPicRelationEN.OrginialFileName = objRow[convGroupPicRelation.OrginialFileName] == DBNull.Value ? null : objRow[convGroupPicRelation.OrginialFileName].ToString().Trim(); //OrginialFileName
objvGroupPicRelationEN.OrginialFileSize = objRow[convGroupPicRelation.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objvGroupPicRelationEN.ResizePictureSize = objRow[convGroupPicRelation.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objvGroupPicRelationEN.ThumbSize = objRow[convGroupPicRelation.ThumbSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ThumbSize].ToString().Trim()); //ThumbSize
objvGroupPicRelationEN.OrginialFileWidth = objRow[convGroupPicRelation.OrginialFileWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objvGroupPicRelationEN.CreateUserName = objRow[convGroupPicRelation.CreateUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserName].ToString().Trim(); //建立用户名
objvGroupPicRelationEN.PicturePath = objRow[convGroupPicRelation.PicturePath] == DBNull.Value ? null : objRow[convGroupPicRelation.PicturePath].ToString().Trim(); //PicturePath
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGroupPicRelationEN);
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
public static List<clsvGroupPicRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvGroupPicRelationEN> arrObjLst = new List<clsvGroupPicRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGroupPicRelationEN objvGroupPicRelationEN = new clsvGroupPicRelationEN();
try
{
objvGroupPicRelationEN.Memo = objRow[convGroupPicRelation.Memo] == DBNull.Value ? null : objRow[convGroupPicRelation.Memo].ToString().Trim(); //备注
objvGroupPicRelationEN.GroupId = objRow[convGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupId].ToString().Trim(); //组Id
objvGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[convGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objvGroupPicRelationEN.GroupName = objRow[convGroupPicRelation.GroupName] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupName].ToString().Trim(); //组名
objvGroupPicRelationEN.PictureId = objRow[convGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objvGroupPicRelationEN.PictureName = objRow[convGroupPicRelation.PictureName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureName].ToString().Trim(); //PictureName
objvGroupPicRelationEN.PictureConfigName = objRow[convGroupPicRelation.PictureConfigName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigName].ToString().Trim(); //PictureConfigName
objvGroupPicRelationEN.CreateTime = objRow[convGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objvGroupPicRelationEN.CreateUserID = objRow[convGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objvGroupPicRelationEN.LastModifyUserID = objRow[convGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objvGroupPicRelationEN.LastModifyTime = objRow[convGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objvGroupPicRelationEN.LastModifyUserName = objRow[convGroupPicRelation.LastModifyUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserName].ToString().Trim(); //最后修改用户名
objvGroupPicRelationEN.PictureConfigerId = objRow[convGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objvGroupPicRelationEN.OrginialFileName = objRow[convGroupPicRelation.OrginialFileName] == DBNull.Value ? null : objRow[convGroupPicRelation.OrginialFileName].ToString().Trim(); //OrginialFileName
objvGroupPicRelationEN.OrginialFileSize = objRow[convGroupPicRelation.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objvGroupPicRelationEN.ResizePictureSize = objRow[convGroupPicRelation.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objvGroupPicRelationEN.ThumbSize = objRow[convGroupPicRelation.ThumbSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ThumbSize].ToString().Trim()); //ThumbSize
objvGroupPicRelationEN.OrginialFileWidth = objRow[convGroupPicRelation.OrginialFileWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objvGroupPicRelationEN.CreateUserName = objRow[convGroupPicRelation.CreateUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserName].ToString().Trim(); //建立用户名
objvGroupPicRelationEN.PicturePath = objRow[convGroupPicRelation.PicturePath] == DBNull.Value ? null : objRow[convGroupPicRelation.PicturePath].ToString().Trim(); //PicturePath
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGroupPicRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvGroupPicRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvGroupPicRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvGroupPicRelationEN> arrObjLst = new List<clsvGroupPicRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGroupPicRelationEN objvGroupPicRelationEN = new clsvGroupPicRelationEN();
try
{
objvGroupPicRelationEN.Memo = objRow[convGroupPicRelation.Memo] == DBNull.Value ? null : objRow[convGroupPicRelation.Memo].ToString().Trim(); //备注
objvGroupPicRelationEN.GroupId = objRow[convGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupId].ToString().Trim(); //组Id
objvGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[convGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objvGroupPicRelationEN.GroupName = objRow[convGroupPicRelation.GroupName] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupName].ToString().Trim(); //组名
objvGroupPicRelationEN.PictureId = objRow[convGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objvGroupPicRelationEN.PictureName = objRow[convGroupPicRelation.PictureName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureName].ToString().Trim(); //PictureName
objvGroupPicRelationEN.PictureConfigName = objRow[convGroupPicRelation.PictureConfigName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigName].ToString().Trim(); //PictureConfigName
objvGroupPicRelationEN.CreateTime = objRow[convGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objvGroupPicRelationEN.CreateUserID = objRow[convGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objvGroupPicRelationEN.LastModifyUserID = objRow[convGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objvGroupPicRelationEN.LastModifyTime = objRow[convGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objvGroupPicRelationEN.LastModifyUserName = objRow[convGroupPicRelation.LastModifyUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserName].ToString().Trim(); //最后修改用户名
objvGroupPicRelationEN.PictureConfigerId = objRow[convGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objvGroupPicRelationEN.OrginialFileName = objRow[convGroupPicRelation.OrginialFileName] == DBNull.Value ? null : objRow[convGroupPicRelation.OrginialFileName].ToString().Trim(); //OrginialFileName
objvGroupPicRelationEN.OrginialFileSize = objRow[convGroupPicRelation.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objvGroupPicRelationEN.ResizePictureSize = objRow[convGroupPicRelation.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objvGroupPicRelationEN.ThumbSize = objRow[convGroupPicRelation.ThumbSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ThumbSize].ToString().Trim()); //ThumbSize
objvGroupPicRelationEN.OrginialFileWidth = objRow[convGroupPicRelation.OrginialFileWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objvGroupPicRelationEN.CreateUserName = objRow[convGroupPicRelation.CreateUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserName].ToString().Trim(); //建立用户名
objvGroupPicRelationEN.PicturePath = objRow[convGroupPicRelation.PicturePath] == DBNull.Value ? null : objRow[convGroupPicRelation.PicturePath].ToString().Trim(); //PicturePath
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGroupPicRelationEN);
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
public static List<clsvGroupPicRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvGroupPicRelationEN> arrObjLst = new List<clsvGroupPicRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGroupPicRelationEN objvGroupPicRelationEN = new clsvGroupPicRelationEN();
try
{
objvGroupPicRelationEN.Memo = objRow[convGroupPicRelation.Memo] == DBNull.Value ? null : objRow[convGroupPicRelation.Memo].ToString().Trim(); //备注
objvGroupPicRelationEN.GroupId = objRow[convGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupId].ToString().Trim(); //组Id
objvGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[convGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objvGroupPicRelationEN.GroupName = objRow[convGroupPicRelation.GroupName] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupName].ToString().Trim(); //组名
objvGroupPicRelationEN.PictureId = objRow[convGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objvGroupPicRelationEN.PictureName = objRow[convGroupPicRelation.PictureName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureName].ToString().Trim(); //PictureName
objvGroupPicRelationEN.PictureConfigName = objRow[convGroupPicRelation.PictureConfigName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigName].ToString().Trim(); //PictureConfigName
objvGroupPicRelationEN.CreateTime = objRow[convGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objvGroupPicRelationEN.CreateUserID = objRow[convGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objvGroupPicRelationEN.LastModifyUserID = objRow[convGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objvGroupPicRelationEN.LastModifyTime = objRow[convGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objvGroupPicRelationEN.LastModifyUserName = objRow[convGroupPicRelation.LastModifyUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserName].ToString().Trim(); //最后修改用户名
objvGroupPicRelationEN.PictureConfigerId = objRow[convGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objvGroupPicRelationEN.OrginialFileName = objRow[convGroupPicRelation.OrginialFileName] == DBNull.Value ? null : objRow[convGroupPicRelation.OrginialFileName].ToString().Trim(); //OrginialFileName
objvGroupPicRelationEN.OrginialFileSize = objRow[convGroupPicRelation.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objvGroupPicRelationEN.ResizePictureSize = objRow[convGroupPicRelation.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objvGroupPicRelationEN.ThumbSize = objRow[convGroupPicRelation.ThumbSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ThumbSize].ToString().Trim()); //ThumbSize
objvGroupPicRelationEN.OrginialFileWidth = objRow[convGroupPicRelation.OrginialFileWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objvGroupPicRelationEN.CreateUserName = objRow[convGroupPicRelation.CreateUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserName].ToString().Trim(); //建立用户名
objvGroupPicRelationEN.PicturePath = objRow[convGroupPicRelation.PicturePath] == DBNull.Value ? null : objRow[convGroupPicRelation.PicturePath].ToString().Trim(); //PicturePath
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGroupPicRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvGroupPicRelationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvGroupPicRelationEN> arrObjLst = new List<clsvGroupPicRelationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGroupPicRelationEN objvGroupPicRelationEN = new clsvGroupPicRelationEN();
try
{
objvGroupPicRelationEN.Memo = objRow[convGroupPicRelation.Memo] == DBNull.Value ? null : objRow[convGroupPicRelation.Memo].ToString().Trim(); //备注
objvGroupPicRelationEN.GroupId = objRow[convGroupPicRelation.GroupId] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupId].ToString().Trim(); //组Id
objvGroupPicRelationEN.RelationshipId = Int32.Parse(objRow[convGroupPicRelation.RelationshipId].ToString().Trim()); //RelationshipId
objvGroupPicRelationEN.GroupName = objRow[convGroupPicRelation.GroupName] == DBNull.Value ? null : objRow[convGroupPicRelation.GroupName].ToString().Trim(); //组名
objvGroupPicRelationEN.PictureId = objRow[convGroupPicRelation.PictureId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.PictureId].ToString().Trim()); //PictureId
objvGroupPicRelationEN.PictureName = objRow[convGroupPicRelation.PictureName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureName].ToString().Trim(); //PictureName
objvGroupPicRelationEN.PictureConfigName = objRow[convGroupPicRelation.PictureConfigName] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigName].ToString().Trim(); //PictureConfigName
objvGroupPicRelationEN.CreateTime = objRow[convGroupPicRelation.CreateTime] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateTime].ToString().Trim(); //建立时间
objvGroupPicRelationEN.CreateUserID = objRow[convGroupPicRelation.CreateUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserID].ToString().Trim(); //建立用户ID
objvGroupPicRelationEN.LastModifyUserID = objRow[convGroupPicRelation.LastModifyUserID] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserID].ToString().Trim(); //最后修改用户ID
objvGroupPicRelationEN.LastModifyTime = objRow[convGroupPicRelation.LastModifyTime] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyTime].ToString().Trim(); //最后修改时间
objvGroupPicRelationEN.LastModifyUserName = objRow[convGroupPicRelation.LastModifyUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.LastModifyUserName].ToString().Trim(); //最后修改用户名
objvGroupPicRelationEN.PictureConfigerId = objRow[convGroupPicRelation.PictureConfigerId] == DBNull.Value ? null : objRow[convGroupPicRelation.PictureConfigerId].ToString().Trim(); //PictureConfigerId
objvGroupPicRelationEN.OrginialFileName = objRow[convGroupPicRelation.OrginialFileName] == DBNull.Value ? null : objRow[convGroupPicRelation.OrginialFileName].ToString().Trim(); //OrginialFileName
objvGroupPicRelationEN.OrginialFileSize = objRow[convGroupPicRelation.OrginialFileSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileSize].ToString().Trim()); //OrginialFileSize
objvGroupPicRelationEN.ResizePictureSize = objRow[convGroupPicRelation.ResizePictureSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ResizePictureSize].ToString().Trim()); //ResizePictureSize
objvGroupPicRelationEN.ThumbSize = objRow[convGroupPicRelation.ThumbSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.ThumbSize].ToString().Trim()); //ThumbSize
objvGroupPicRelationEN.OrginialFileWidth = objRow[convGroupPicRelation.OrginialFileWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convGroupPicRelation.OrginialFileWidth].ToString().Trim()); //OrginialFileWidth
objvGroupPicRelationEN.CreateUserName = objRow[convGroupPicRelation.CreateUserName] == DBNull.Value ? null : objRow[convGroupPicRelation.CreateUserName].ToString().Trim(); //建立用户名
objvGroupPicRelationEN.PicturePath = objRow[convGroupPicRelation.PicturePath] == DBNull.Value ? null : objRow[convGroupPicRelation.PicturePath].ToString().Trim(); //PicturePath
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGroupPicRelationEN.RelationshipId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGroupPicRelationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvGroupPicRelation(ref clsvGroupPicRelationEN objvGroupPicRelationEN)
{
bool bolResult = vGroupPicRelationDA.GetvGroupPicRelation(ref objvGroupPicRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "intRelationshipId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvGroupPicRelationEN GetObjByRelationshipId(int intRelationshipId)
{
clsvGroupPicRelationEN objvGroupPicRelationEN = vGroupPicRelationDA.GetObjByRelationshipId(intRelationshipId);
return objvGroupPicRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvGroupPicRelationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvGroupPicRelationEN objvGroupPicRelationEN = vGroupPicRelationDA.GetFirstObj(strWhereCond);
 return objvGroupPicRelationEN;
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
public static clsvGroupPicRelationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvGroupPicRelationEN objvGroupPicRelationEN = vGroupPicRelationDA.GetObjByDataRow(objRow);
 return objvGroupPicRelationEN;
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
public static clsvGroupPicRelationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvGroupPicRelationEN objvGroupPicRelationEN = vGroupPicRelationDA.GetObjByDataRow(objRow);
 return objvGroupPicRelationEN;
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
 /// <param name = "intRelationshipId">所给的关键字</param>
 /// <param name = "lstvGroupPicRelationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvGroupPicRelationEN GetObjByRelationshipIdFromList(int intRelationshipId, List<clsvGroupPicRelationEN> lstvGroupPicRelationObjLst)
{
foreach (clsvGroupPicRelationEN objvGroupPicRelationEN in lstvGroupPicRelationObjLst)
{
if (objvGroupPicRelationEN.RelationshipId == intRelationshipId)
{
return objvGroupPicRelationEN;
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
public static int GetFirstID_S(string strWhereCond) 
{
 int intRelationshipId;
 try
 {
 intRelationshipId = new clsvGroupPicRelationDA().GetFirstID(strWhereCond);
 return intRelationshipId;
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
 arrList = vGroupPicRelationDA.GetID(strWhereCond);
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
bool bolIsExist = vGroupPicRelationDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "intRelationshipId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(int intRelationshipId)
{
//检测记录是否存在
bool bolIsExist = vGroupPicRelationDA.IsExist(intRelationshipId);
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
 bolIsExist = clsvGroupPicRelationDA.IsExistTable();
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
 bolIsExist = vGroupPicRelationDA.IsExistTable(strTabName);
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
 /// <param name = "objvGroupPicRelationENS">源对象</param>
 /// <param name = "objvGroupPicRelationENT">目标对象</param>
 public static void CopyTo(clsvGroupPicRelationEN objvGroupPicRelationENS, clsvGroupPicRelationEN objvGroupPicRelationENT)
{
try
{
objvGroupPicRelationENT.Memo = objvGroupPicRelationENS.Memo; //备注
objvGroupPicRelationENT.GroupId = objvGroupPicRelationENS.GroupId; //组Id
objvGroupPicRelationENT.RelationshipId = objvGroupPicRelationENS.RelationshipId; //RelationshipId
objvGroupPicRelationENT.GroupName = objvGroupPicRelationENS.GroupName; //组名
objvGroupPicRelationENT.PictureId = objvGroupPicRelationENS.PictureId; //PictureId
objvGroupPicRelationENT.PictureName = objvGroupPicRelationENS.PictureName; //PictureName
objvGroupPicRelationENT.PictureConfigName = objvGroupPicRelationENS.PictureConfigName; //PictureConfigName
objvGroupPicRelationENT.CreateTime = objvGroupPicRelationENS.CreateTime; //建立时间
objvGroupPicRelationENT.CreateUserID = objvGroupPicRelationENS.CreateUserID; //建立用户ID
objvGroupPicRelationENT.LastModifyUserID = objvGroupPicRelationENS.LastModifyUserID; //最后修改用户ID
objvGroupPicRelationENT.LastModifyTime = objvGroupPicRelationENS.LastModifyTime; //最后修改时间
objvGroupPicRelationENT.LastModifyUserName = objvGroupPicRelationENS.LastModifyUserName; //最后修改用户名
objvGroupPicRelationENT.PictureConfigerId = objvGroupPicRelationENS.PictureConfigerId; //PictureConfigerId
objvGroupPicRelationENT.OrginialFileName = objvGroupPicRelationENS.OrginialFileName; //OrginialFileName
objvGroupPicRelationENT.OrginialFileSize = objvGroupPicRelationENS.OrginialFileSize; //OrginialFileSize
objvGroupPicRelationENT.ResizePictureSize = objvGroupPicRelationENS.ResizePictureSize; //ResizePictureSize
objvGroupPicRelationENT.ThumbSize = objvGroupPicRelationENS.ThumbSize; //ThumbSize
objvGroupPicRelationENT.OrginialFileWidth = objvGroupPicRelationENS.OrginialFileWidth; //OrginialFileWidth
objvGroupPicRelationENT.CreateUserName = objvGroupPicRelationENS.CreateUserName; //建立用户名
objvGroupPicRelationENT.PicturePath = objvGroupPicRelationENS.PicturePath; //PicturePath
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
 /// <param name = "objvGroupPicRelationEN">源简化对象</param>
 public static void SetUpdFlag(clsvGroupPicRelationEN objvGroupPicRelationEN)
{
try
{
objvGroupPicRelationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvGroupPicRelationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convGroupPicRelation.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.Memo = objvGroupPicRelationEN.Memo == "[null]" ? null :  objvGroupPicRelationEN.Memo; //备注
}
if (arrFldSet.Contains(convGroupPicRelation.GroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.GroupId = objvGroupPicRelationEN.GroupId == "[null]" ? null :  objvGroupPicRelationEN.GroupId; //组Id
}
if (arrFldSet.Contains(convGroupPicRelation.RelationshipId, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.RelationshipId = objvGroupPicRelationEN.RelationshipId; //RelationshipId
}
if (arrFldSet.Contains(convGroupPicRelation.GroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.GroupName = objvGroupPicRelationEN.GroupName == "[null]" ? null :  objvGroupPicRelationEN.GroupName; //组名
}
if (arrFldSet.Contains(convGroupPicRelation.PictureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.PictureId = objvGroupPicRelationEN.PictureId; //PictureId
}
if (arrFldSet.Contains(convGroupPicRelation.PictureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.PictureName = objvGroupPicRelationEN.PictureName == "[null]" ? null :  objvGroupPicRelationEN.PictureName; //PictureName
}
if (arrFldSet.Contains(convGroupPicRelation.PictureConfigName, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.PictureConfigName = objvGroupPicRelationEN.PictureConfigName == "[null]" ? null :  objvGroupPicRelationEN.PictureConfigName; //PictureConfigName
}
if (arrFldSet.Contains(convGroupPicRelation.CreateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.CreateTime = objvGroupPicRelationEN.CreateTime == "[null]" ? null :  objvGroupPicRelationEN.CreateTime; //建立时间
}
if (arrFldSet.Contains(convGroupPicRelation.CreateUserID, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.CreateUserID = objvGroupPicRelationEN.CreateUserID == "[null]" ? null :  objvGroupPicRelationEN.CreateUserID; //建立用户ID
}
if (arrFldSet.Contains(convGroupPicRelation.LastModifyUserID, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.LastModifyUserID = objvGroupPicRelationEN.LastModifyUserID == "[null]" ? null :  objvGroupPicRelationEN.LastModifyUserID; //最后修改用户ID
}
if (arrFldSet.Contains(convGroupPicRelation.LastModifyTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.LastModifyTime = objvGroupPicRelationEN.LastModifyTime == "[null]" ? null :  objvGroupPicRelationEN.LastModifyTime; //最后修改时间
}
if (arrFldSet.Contains(convGroupPicRelation.LastModifyUserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.LastModifyUserName = objvGroupPicRelationEN.LastModifyUserName == "[null]" ? null :  objvGroupPicRelationEN.LastModifyUserName; //最后修改用户名
}
if (arrFldSet.Contains(convGroupPicRelation.PictureConfigerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.PictureConfigerId = objvGroupPicRelationEN.PictureConfigerId == "[null]" ? null :  objvGroupPicRelationEN.PictureConfigerId; //PictureConfigerId
}
if (arrFldSet.Contains(convGroupPicRelation.OrginialFileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.OrginialFileName = objvGroupPicRelationEN.OrginialFileName == "[null]" ? null :  objvGroupPicRelationEN.OrginialFileName; //OrginialFileName
}
if (arrFldSet.Contains(convGroupPicRelation.OrginialFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.OrginialFileSize = objvGroupPicRelationEN.OrginialFileSize; //OrginialFileSize
}
if (arrFldSet.Contains(convGroupPicRelation.ResizePictureSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.ResizePictureSize = objvGroupPicRelationEN.ResizePictureSize; //ResizePictureSize
}
if (arrFldSet.Contains(convGroupPicRelation.ThumbSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.ThumbSize = objvGroupPicRelationEN.ThumbSize; //ThumbSize
}
if (arrFldSet.Contains(convGroupPicRelation.OrginialFileWidth, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.OrginialFileWidth = objvGroupPicRelationEN.OrginialFileWidth; //OrginialFileWidth
}
if (arrFldSet.Contains(convGroupPicRelation.CreateUserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.CreateUserName = objvGroupPicRelationEN.CreateUserName == "[null]" ? null :  objvGroupPicRelationEN.CreateUserName; //建立用户名
}
if (arrFldSet.Contains(convGroupPicRelation.PicturePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvGroupPicRelationEN.PicturePath = objvGroupPicRelationEN.PicturePath == "[null]" ? null :  objvGroupPicRelationEN.PicturePath; //PicturePath
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
 /// <param name = "objvGroupPicRelationEN">源简化对象</param>
 public static void AccessFldValueNull(clsvGroupPicRelationEN objvGroupPicRelationEN)
{
try
{
if (objvGroupPicRelationEN.Memo == "[null]") objvGroupPicRelationEN.Memo = null; //备注
if (objvGroupPicRelationEN.GroupId == "[null]") objvGroupPicRelationEN.GroupId = null; //组Id
if (objvGroupPicRelationEN.GroupName == "[null]") objvGroupPicRelationEN.GroupName = null; //组名
if (objvGroupPicRelationEN.PictureName == "[null]") objvGroupPicRelationEN.PictureName = null; //PictureName
if (objvGroupPicRelationEN.PictureConfigName == "[null]") objvGroupPicRelationEN.PictureConfigName = null; //PictureConfigName
if (objvGroupPicRelationEN.CreateTime == "[null]") objvGroupPicRelationEN.CreateTime = null; //建立时间
if (objvGroupPicRelationEN.CreateUserID == "[null]") objvGroupPicRelationEN.CreateUserID = null; //建立用户ID
if (objvGroupPicRelationEN.LastModifyUserID == "[null]") objvGroupPicRelationEN.LastModifyUserID = null; //最后修改用户ID
if (objvGroupPicRelationEN.LastModifyTime == "[null]") objvGroupPicRelationEN.LastModifyTime = null; //最后修改时间
if (objvGroupPicRelationEN.LastModifyUserName == "[null]") objvGroupPicRelationEN.LastModifyUserName = null; //最后修改用户名
if (objvGroupPicRelationEN.PictureConfigerId == "[null]") objvGroupPicRelationEN.PictureConfigerId = null; //PictureConfigerId
if (objvGroupPicRelationEN.OrginialFileName == "[null]") objvGroupPicRelationEN.OrginialFileName = null; //OrginialFileName
if (objvGroupPicRelationEN.CreateUserName == "[null]") objvGroupPicRelationEN.CreateUserName = null; //建立用户名
if (objvGroupPicRelationEN.PicturePath == "[null]") objvGroupPicRelationEN.PicturePath = null; //PicturePath
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
public static void CheckProperty4Condition(clsvGroupPicRelationEN objvGroupPicRelationEN)
{
 vGroupPicRelationDA.CheckProperty4Condition(objvGroupPicRelationEN);
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsGroupPicRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGroupPicRelationBL没有刷新缓存机制(clsGroupPicRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPictureConfigerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPictureConfigerBL没有刷新缓存机制(clsPictureConfigerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPictureResourcesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPictureResourcesBL没有刷新缓存机制(clsPictureResourcesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserGroupBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserGroupBL没有刷新缓存机制(clsUserGroupBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RelationshipId");
//if (arrvGroupPicRelationObjLstCache == null)
//{
//arrvGroupPicRelationObjLstCache = vGroupPicRelationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "intRelationshipId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvGroupPicRelationEN GetObjByRelationshipIdCache(int intRelationshipId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvGroupPicRelationEN._CurrTabName);
List<clsvGroupPicRelationEN> arrvGroupPicRelationObjLstCache = GetObjLstCache();
IEnumerable <clsvGroupPicRelationEN> arrvGroupPicRelationObjLst_Sel =
arrvGroupPicRelationObjLstCache
.Where(x=> x.RelationshipId == intRelationshipId 
);
if (arrvGroupPicRelationObjLst_Sel.Count() == 0)
{
   clsvGroupPicRelationEN obj = clsvGroupPicRelationBL.GetObjByRelationshipId(intRelationshipId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvGroupPicRelationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvGroupPicRelationEN> GetAllvGroupPicRelationObjLstCache()
{
//获取缓存中的对象列表
List<clsvGroupPicRelationEN> arrvGroupPicRelationObjLstCache = GetObjLstCache(); 
return arrvGroupPicRelationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvGroupPicRelationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvGroupPicRelationEN._CurrTabName);
List<clsvGroupPicRelationEN> arrvGroupPicRelationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvGroupPicRelationObjLstCache;
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
string strKey = string.Format("{0}", clsvGroupPicRelationEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, int intRelationshipId)
{
if (strInFldName != convGroupPicRelation.RelationshipId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convGroupPicRelation.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convGroupPicRelation.AttributeName));
throw new Exception(strMsg);
}
var objvGroupPicRelation = clsvGroupPicRelationBL.GetObjByRelationshipIdCache(intRelationshipId);
if (objvGroupPicRelation == null) return "";
return objvGroupPicRelation[strOutFldName].ToString();
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
int intRecCount = clsvGroupPicRelationDA.GetRecCount(strTabName);
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
int intRecCount = clsvGroupPicRelationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvGroupPicRelationDA.GetRecCount();
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
int intRecCount = clsvGroupPicRelationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvGroupPicRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvGroupPicRelationEN objvGroupPicRelationCond)
{
List<clsvGroupPicRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvGroupPicRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convGroupPicRelation.AttributeName)
{
if (objvGroupPicRelationCond.IsUpdated(strFldName) == false) continue;
if (objvGroupPicRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvGroupPicRelationCond[strFldName].ToString());
}
else
{
if (objvGroupPicRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvGroupPicRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvGroupPicRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvGroupPicRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvGroupPicRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvGroupPicRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvGroupPicRelationCond[strFldName]));
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
 List<string> arrList = clsvGroupPicRelationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vGroupPicRelationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vGroupPicRelationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}