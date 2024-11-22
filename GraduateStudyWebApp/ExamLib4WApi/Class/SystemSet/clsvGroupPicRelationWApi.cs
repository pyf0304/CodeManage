
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvGroupPicRelationWApi
 表名:vGroupPicRelation(01120018)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:50
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置
 模块英文名:SystemSet
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
public static class clsvGroupPicRelationWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetMemo(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convGroupPicRelation.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetGroupId(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGroupId, 8, convGroupPicRelation.GroupId);
clsCheckSql.CheckFieldForeignKey(strGroupId, 8, convGroupPicRelation.GroupId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetGroupName(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGroupName, 40, convGroupPicRelation.GroupName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetPictureId(this clsvGroupPicRelationEN objvGroupPicRelationEN, int intPictureId, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetPictureName(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strPictureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPictureName, 100, convGroupPicRelation.PictureName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetPictureConfigName(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strPictureConfigName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPictureConfigName, 50, convGroupPicRelation.PictureConfigName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetCreateTime(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strCreateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateTime, 16, convGroupPicRelation.CreateTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetCreateUserID(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strCreateUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateUserID, 20, convGroupPicRelation.CreateUserID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetLastModifyUserID(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strLastModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLastModifyUserID, 20, convGroupPicRelation.LastModifyUserID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetLastModifyTime(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strLastModifyTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLastModifyTime, 16, convGroupPicRelation.LastModifyTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetLastModifyUserName(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strLastModifyUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLastModifyUserName, 30, convGroupPicRelation.LastModifyUserName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetPictureConfigerId(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strPictureConfigerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPictureConfigerId, 4, convGroupPicRelation.PictureConfigerId);
clsCheckSql.CheckFieldForeignKey(strPictureConfigerId, 4, convGroupPicRelation.PictureConfigerId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetOrginialFileName(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strOrginialFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOrginialFileName, 100, convGroupPicRelation.OrginialFileName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetOrginialFileSize(this clsvGroupPicRelationEN objvGroupPicRelationEN, int intOrginialFileSize, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetResizePictureSize(this clsvGroupPicRelationEN objvGroupPicRelationEN, int intResizePictureSize, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetThumbSize(this clsvGroupPicRelationEN objvGroupPicRelationEN, int intThumbSize, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetOrginialFileWidth(this clsvGroupPicRelationEN objvGroupPicRelationEN, int intOrginialFileWidth, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetCreateUserName(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strCreateUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateUserName, 30, convGroupPicRelation.CreateUserName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvGroupPicRelationEN SetPicturePath(this clsvGroupPicRelationEN objvGroupPicRelationEN, string strPicturePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPicturePath, 50, convGroupPicRelation.PicturePath);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvGroupPicRelationEN objvGroupPicRelation_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.Memo) == true)
{
string strComparisonOp_Memo = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.Memo, objvGroupPicRelation_Cond.Memo, strComparisonOp_Memo);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.GroupId) == true)
{
string strComparisonOp_GroupId = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.GroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.GroupId, objvGroupPicRelation_Cond.GroupId, strComparisonOp_GroupId);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.RelationshipId) == true)
{
string strComparisonOp_RelationshipId = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.RelationshipId];
strWhereCond += string.Format(" And {0} {2} {1}", convGroupPicRelation.RelationshipId, objvGroupPicRelation_Cond.RelationshipId, strComparisonOp_RelationshipId);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.GroupName) == true)
{
string strComparisonOp_GroupName = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.GroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.GroupName, objvGroupPicRelation_Cond.GroupName, strComparisonOp_GroupName);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.PictureId) == true)
{
string strComparisonOp_PictureId = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.PictureId];
strWhereCond += string.Format(" And {0} {2} {1}", convGroupPicRelation.PictureId, objvGroupPicRelation_Cond.PictureId, strComparisonOp_PictureId);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.PictureName) == true)
{
string strComparisonOp_PictureName = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.PictureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.PictureName, objvGroupPicRelation_Cond.PictureName, strComparisonOp_PictureName);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.PictureConfigName) == true)
{
string strComparisonOp_PictureConfigName = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.PictureConfigName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.PictureConfigName, objvGroupPicRelation_Cond.PictureConfigName, strComparisonOp_PictureConfigName);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.CreateTime) == true)
{
string strComparisonOp_CreateTime = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.CreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.CreateTime, objvGroupPicRelation_Cond.CreateTime, strComparisonOp_CreateTime);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.CreateUserID) == true)
{
string strComparisonOp_CreateUserID = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.CreateUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.CreateUserID, objvGroupPicRelation_Cond.CreateUserID, strComparisonOp_CreateUserID);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.LastModifyUserID) == true)
{
string strComparisonOp_LastModifyUserID = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.LastModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.LastModifyUserID, objvGroupPicRelation_Cond.LastModifyUserID, strComparisonOp_LastModifyUserID);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.LastModifyTime) == true)
{
string strComparisonOp_LastModifyTime = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.LastModifyTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.LastModifyTime, objvGroupPicRelation_Cond.LastModifyTime, strComparisonOp_LastModifyTime);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.LastModifyUserName) == true)
{
string strComparisonOp_LastModifyUserName = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.LastModifyUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.LastModifyUserName, objvGroupPicRelation_Cond.LastModifyUserName, strComparisonOp_LastModifyUserName);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.PictureConfigerId) == true)
{
string strComparisonOp_PictureConfigerId = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.PictureConfigerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.PictureConfigerId, objvGroupPicRelation_Cond.PictureConfigerId, strComparisonOp_PictureConfigerId);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.OrginialFileName) == true)
{
string strComparisonOp_OrginialFileName = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.OrginialFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.OrginialFileName, objvGroupPicRelation_Cond.OrginialFileName, strComparisonOp_OrginialFileName);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.OrginialFileSize) == true)
{
string strComparisonOp_OrginialFileSize = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.OrginialFileSize];
strWhereCond += string.Format(" And {0} {2} {1}", convGroupPicRelation.OrginialFileSize, objvGroupPicRelation_Cond.OrginialFileSize, strComparisonOp_OrginialFileSize);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.ResizePictureSize) == true)
{
string strComparisonOp_ResizePictureSize = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.ResizePictureSize];
strWhereCond += string.Format(" And {0} {2} {1}", convGroupPicRelation.ResizePictureSize, objvGroupPicRelation_Cond.ResizePictureSize, strComparisonOp_ResizePictureSize);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.ThumbSize) == true)
{
string strComparisonOp_ThumbSize = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.ThumbSize];
strWhereCond += string.Format(" And {0} {2} {1}", convGroupPicRelation.ThumbSize, objvGroupPicRelation_Cond.ThumbSize, strComparisonOp_ThumbSize);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.OrginialFileWidth) == true)
{
string strComparisonOp_OrginialFileWidth = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.OrginialFileWidth];
strWhereCond += string.Format(" And {0} {2} {1}", convGroupPicRelation.OrginialFileWidth, objvGroupPicRelation_Cond.OrginialFileWidth, strComparisonOp_OrginialFileWidth);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.CreateUserName) == true)
{
string strComparisonOp_CreateUserName = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.CreateUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.CreateUserName, objvGroupPicRelation_Cond.CreateUserName, strComparisonOp_CreateUserName);
}
if (objvGroupPicRelation_Cond.IsUpdated(convGroupPicRelation.PicturePath) == true)
{
string strComparisonOp_PicturePath = objvGroupPicRelation_Cond.dicFldComparisonOp[convGroupPicRelation.PicturePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGroupPicRelation.PicturePath, objvGroupPicRelation_Cond.PicturePath, strComparisonOp_PicturePath);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v用户组图片关系(vGroupPicRelation)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvGroupPicRelationWApi
{
private static readonly string mstrApiControllerName = "vGroupPicRelationApi";

 public clsvGroupPicRelationWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "intRelationshipId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvGroupPicRelationEN GetObjByRelationshipId(int intRelationshipId)
{
string strAction = "GetObjByRelationshipId";
string strErrMsg = string.Empty;
string strResult = "";
clsvGroupPicRelationEN objvGroupPicRelationEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RelationshipId"] = intRelationshipId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvGroupPicRelationEN = JsonConvert.DeserializeObject<clsvGroupPicRelationEN>((string)jobjReturn["ReturnObj"]);
return objvGroupPicRelationEN;
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
 /// <param name = "intRelationshipId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvGroupPicRelationEN GetObjByRelationshipId_WA_Cache(int intRelationshipId)
{
string strAction = "GetObjByRelationshipId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvGroupPicRelationEN objvGroupPicRelationEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RelationshipId"] = intRelationshipId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvGroupPicRelationEN = JsonConvert.DeserializeObject<clsvGroupPicRelationEN>((string)jobjReturn["ReturnObj"]);
return objvGroupPicRelationEN;
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
public static int GetFirstID(string strWhereCond)
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
return int.Parse(strReturnStr);
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
public static clsvGroupPicRelationEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvGroupPicRelationEN objvGroupPicRelationEN = null;
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
objvGroupPicRelationEN = JsonConvert.DeserializeObject<clsvGroupPicRelationEN>((string)jobjReturn["ReturnObj"]);
return objvGroupPicRelationEN;
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
 /// <param name = "intRelationshipId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvGroupPicRelationEN GetObjByRelationshipId_Cache(int intRelationshipId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvGroupPicRelationEN._CurrTabName_S);
List<clsvGroupPicRelationEN> arrvGroupPicRelationObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvGroupPicRelationEN> arrvGroupPicRelationObjLst_Sel =
from objvGroupPicRelationEN in arrvGroupPicRelationObjLst_Cache
where objvGroupPicRelationEN.RelationshipId == intRelationshipId
select objvGroupPicRelationEN;
if (arrvGroupPicRelationObjLst_Sel.Count() == 0)
{
   clsvGroupPicRelationEN obj = clsvGroupPicRelationWApi.GetObjByRelationshipId(intRelationshipId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvGroupPicRelationObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvGroupPicRelationEN> GetObjLst(string strWhereCond)
{
 List<clsvGroupPicRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvGroupPicRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvGroupPicRelationEN> GetObjLstByRelationshipIdLst(List<int> arrRelationshipId)
{
 List<clsvGroupPicRelationEN> arrObjLst = null; 
string strAction = "GetObjLstByRelationshipIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRelationshipId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvGroupPicRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "intRelationshipId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvGroupPicRelationEN> GetObjLstByRelationshipIdLst_Cache(List<int> arrRelationshipId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvGroupPicRelationEN._CurrTabName_S);
List<clsvGroupPicRelationEN> arrvGroupPicRelationObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvGroupPicRelationEN> arrvGroupPicRelationObjLst_Sel =
from objvGroupPicRelationEN in arrvGroupPicRelationObjLst_Cache
where arrRelationshipId.Contains(objvGroupPicRelationEN.RelationshipId)
select objvGroupPicRelationEN;
return arrvGroupPicRelationObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvGroupPicRelationEN> GetObjLstByRelationshipIdLst_WA_Cache(List<int> arrRelationshipId)
{
 List<clsvGroupPicRelationEN> arrObjLst = null; 
string strAction = "GetObjLstByRelationshipIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRelationshipId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvGroupPicRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvGroupPicRelationEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvGroupPicRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvGroupPicRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvGroupPicRelationEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvGroupPicRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvGroupPicRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvGroupPicRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvGroupPicRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvGroupPicRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvGroupPicRelationEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvGroupPicRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvGroupPicRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(int intRelationshipId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RelationshipId"] = intRelationshipId.ToString()
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
public static DataTable ToDataTable(List<clsvGroupPicRelationEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvGroupPicRelationEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvGroupPicRelationEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvGroupPicRelationEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvGroupPicRelationEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvGroupPicRelationEN.AttributeName)
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
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsGroupPicRelationWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsGroupPicRelationWApi没有刷新缓存机制(clsGroupPicRelationWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPictureConfigerWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPictureConfigerWApi没有刷新缓存机制(clsPictureConfigerWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPictureResourcesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPictureResourcesWApi没有刷新缓存机制(clsPictureResourcesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserGroupWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserGroupWApi没有刷新缓存机制(clsUserGroupWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RelationshipId");
//if (arrvGroupPicRelationObjLst_Cache == null)
//{
//arrvGroupPicRelationObjLst_Cache = await clsvGroupPicRelationWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvGroupPicRelationEN._CurrTabName_S);
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
public static List<clsvGroupPicRelationEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvGroupPicRelationEN._CurrTabName_S);
List<clsvGroupPicRelationEN> arrvGroupPicRelationObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvGroupPicRelationObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvGroupPicRelationEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convGroupPicRelation.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convGroupPicRelation.GroupId, Type.GetType("System.String"));
objDT.Columns.Add(convGroupPicRelation.RelationshipId, Type.GetType("System.Int32"));
objDT.Columns.Add(convGroupPicRelation.GroupName, Type.GetType("System.String"));
objDT.Columns.Add(convGroupPicRelation.PictureId, Type.GetType("System.Int32"));
objDT.Columns.Add(convGroupPicRelation.PictureName, Type.GetType("System.String"));
objDT.Columns.Add(convGroupPicRelation.PictureConfigName, Type.GetType("System.String"));
objDT.Columns.Add(convGroupPicRelation.CreateTime, Type.GetType("System.String"));
objDT.Columns.Add(convGroupPicRelation.CreateUserID, Type.GetType("System.String"));
objDT.Columns.Add(convGroupPicRelation.LastModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(convGroupPicRelation.LastModifyTime, Type.GetType("System.String"));
objDT.Columns.Add(convGroupPicRelation.LastModifyUserName, Type.GetType("System.String"));
objDT.Columns.Add(convGroupPicRelation.PictureConfigerId, Type.GetType("System.String"));
objDT.Columns.Add(convGroupPicRelation.OrginialFileName, Type.GetType("System.String"));
objDT.Columns.Add(convGroupPicRelation.OrginialFileSize, Type.GetType("System.Int32"));
objDT.Columns.Add(convGroupPicRelation.ResizePictureSize, Type.GetType("System.Int32"));
objDT.Columns.Add(convGroupPicRelation.ThumbSize, Type.GetType("System.Int32"));
objDT.Columns.Add(convGroupPicRelation.OrginialFileWidth, Type.GetType("System.Int32"));
objDT.Columns.Add(convGroupPicRelation.CreateUserName, Type.GetType("System.String"));
objDT.Columns.Add(convGroupPicRelation.PicturePath, Type.GetType("System.String"));
foreach (clsvGroupPicRelationEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convGroupPicRelation.Memo] = objInFor[convGroupPicRelation.Memo];
objDR[convGroupPicRelation.GroupId] = objInFor[convGroupPicRelation.GroupId];
objDR[convGroupPicRelation.RelationshipId] = objInFor[convGroupPicRelation.RelationshipId];
objDR[convGroupPicRelation.GroupName] = objInFor[convGroupPicRelation.GroupName];
objDR[convGroupPicRelation.PictureId] = objInFor[convGroupPicRelation.PictureId];
objDR[convGroupPicRelation.PictureName] = objInFor[convGroupPicRelation.PictureName];
objDR[convGroupPicRelation.PictureConfigName] = objInFor[convGroupPicRelation.PictureConfigName];
objDR[convGroupPicRelation.CreateTime] = objInFor[convGroupPicRelation.CreateTime];
objDR[convGroupPicRelation.CreateUserID] = objInFor[convGroupPicRelation.CreateUserID];
objDR[convGroupPicRelation.LastModifyUserID] = objInFor[convGroupPicRelation.LastModifyUserID];
objDR[convGroupPicRelation.LastModifyTime] = objInFor[convGroupPicRelation.LastModifyTime];
objDR[convGroupPicRelation.LastModifyUserName] = objInFor[convGroupPicRelation.LastModifyUserName];
objDR[convGroupPicRelation.PictureConfigerId] = objInFor[convGroupPicRelation.PictureConfigerId];
objDR[convGroupPicRelation.OrginialFileName] = objInFor[convGroupPicRelation.OrginialFileName];
objDR[convGroupPicRelation.OrginialFileSize] = objInFor[convGroupPicRelation.OrginialFileSize];
objDR[convGroupPicRelation.ResizePictureSize] = objInFor[convGroupPicRelation.ResizePictureSize];
objDR[convGroupPicRelation.ThumbSize] = objInFor[convGroupPicRelation.ThumbSize];
objDR[convGroupPicRelation.OrginialFileWidth] = objInFor[convGroupPicRelation.OrginialFileWidth];
objDR[convGroupPicRelation.CreateUserName] = objInFor[convGroupPicRelation.CreateUserName];
objDR[convGroupPicRelation.PicturePath] = objInFor[convGroupPicRelation.PicturePath];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}