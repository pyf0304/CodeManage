
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysCountBL
 表名:vSysCount(01120626)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:45
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
public static class  clsvSysCountBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCountId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysCountEN GetObj(this K_CountId_vSysCount myKey)
{
clsvSysCountEN objvSysCountEN = clsvSysCountBL.vSysCountDA.GetObjByCountId(myKey.Value);
return objvSysCountEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetCountId(this clsvSysCountEN objvSysCountEN, string strCountId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCountId, 10, convSysCount.CountId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCountId, 10, convSysCount.CountId);
}
objvSysCountEN.CountId = strCountId; //CountId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.CountId) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.CountId, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.CountId] = strComparisonOp;
}
}
return objvSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetCountTypeId(this clsvSysCountEN objvSysCountEN, string strCountTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCountTypeId, 2, convSysCount.CountTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCountTypeId, 2, convSysCount.CountTypeId);
}
objvSysCountEN.CountTypeId = strCountTypeId; //CountTypeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.CountTypeId) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.CountTypeId, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.CountTypeId] = strComparisonOp;
}
}
return objvSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetCommentTypeName(this clsvSysCountEN objvSysCountEN, string strCommentTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentTypeName, 50, convSysCount.CommentTypeName);
}
objvSysCountEN.CommentTypeName = strCommentTypeName; //评论类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.CommentTypeName) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.CommentTypeName, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.CommentTypeName] = strComparisonOp;
}
}
return objvSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetCommentTable(this clsvSysCountEN objvSysCountEN, string strCommentTable, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentTable, 50, convSysCount.CommentTable);
}
objvSysCountEN.CommentTable = strCommentTable; //评论表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.CommentTable) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.CommentTable, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.CommentTable] = strComparisonOp;
}
}
return objvSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetOkCount(this clsvSysCountEN objvSysCountEN, int? intOkCount, string strComparisonOp="")
	{
objvSysCountEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.OkCount) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.OkCount, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.OkCount] = strComparisonOp;
}
}
return objvSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetCommentTableId(this clsvSysCountEN objvSysCountEN, string strCommentTableId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentTableId, 50, convSysCount.CommentTableId);
}
objvSysCountEN.CommentTableId = strCommentTableId; //评论表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.CommentTableId) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.CommentTableId, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.CommentTableId] = strComparisonOp;
}
}
return objvSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetCollectionCount(this clsvSysCountEN objvSysCountEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvSysCountEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.CollectionCount) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.CollectionCount, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.CollectionCount] = strComparisonOp;
}
}
return objvSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetDownloadCount(this clsvSysCountEN objvSysCountEN, int? intDownloadCount, string strComparisonOp="")
	{
objvSysCountEN.DownloadCount = intDownloadCount; //下载数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.DownloadCount) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.DownloadCount, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.DownloadCount] = strComparisonOp;
}
}
return objvSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetAttachmentCount(this clsvSysCountEN objvSysCountEN, int? intAttachmentCount, string strComparisonOp="")
	{
objvSysCountEN.AttachmentCount = intAttachmentCount; //附件计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.AttachmentCount) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.AttachmentCount, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.AttachmentCount] = strComparisonOp;
}
}
return objvSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetCommentCount(this clsvSysCountEN objvSysCountEN, int? intCommentCount, string strComparisonOp="")
	{
objvSysCountEN.CommentCount = intCommentCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.CommentCount) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.CommentCount, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.CommentCount] = strComparisonOp;
}
}
return objvSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetScore(this clsvSysCountEN objvSysCountEN, float? fltScore, string strComparisonOp="")
	{
objvSysCountEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.Score) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.Score, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.Score] = strComparisonOp;
}
}
return objvSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetStuScore(this clsvSysCountEN objvSysCountEN, float? fltStuScore, string strComparisonOp="")
	{
objvSysCountEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.StuScore) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.StuScore, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.StuScore] = strComparisonOp;
}
}
return objvSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetTeaScore(this clsvSysCountEN objvSysCountEN, float? fltTeaScore, string strComparisonOp="")
	{
objvSysCountEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.TeaScore) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.TeaScore, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.TeaScore] = strComparisonOp;
}
}
return objvSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetTableKey(this clsvSysCountEN objvSysCountEN, string strTableKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableKey, 20, convSysCount.TableKey);
}
objvSysCountEN.TableKey = strTableKey; //表主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.TableKey) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.TableKey, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.TableKey] = strComparisonOp;
}
}
return objvSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetParentId(this clsvSysCountEN objvSysCountEN, string strParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 20, convSysCount.ParentId);
}
objvSysCountEN.ParentId = strParentId; //父Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.ParentId) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.ParentId, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.ParentId] = strComparisonOp;
}
}
return objvSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetUpdUser(this clsvSysCountEN objvSysCountEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convSysCount.UpdUser);
}
objvSysCountEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.UpdUser) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.UpdUser, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.UpdUser] = strComparisonOp;
}
}
return objvSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetUpdDate(this clsvSysCountEN objvSysCountEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSysCount.UpdDate);
}
objvSysCountEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.UpdDate) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.UpdDate, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.UpdDate] = strComparisonOp;
}
}
return objvSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetMemo(this clsvSysCountEN objvSysCountEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSysCount.Memo);
}
objvSysCountEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.Memo) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.Memo, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.Memo] = strComparisonOp;
}
}
return objvSysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCountEN SetPaperRWCount(this clsvSysCountEN objvSysCountEN, int? intPaperRWCount, string strComparisonOp="")
	{
objvSysCountEN.PaperRWCount = intPaperRWCount; //PaperRWCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCountEN.dicFldComparisonOp.ContainsKey(convSysCount.PaperRWCount) == false)
{
objvSysCountEN.dicFldComparisonOp.Add(convSysCount.PaperRWCount, strComparisonOp);
}
else
{
objvSysCountEN.dicFldComparisonOp[convSysCount.PaperRWCount] = strComparisonOp;
}
}
return objvSysCountEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSysCountENS">源对象</param>
 /// <param name = "objvSysCountENT">目标对象</param>
 public static void CopyTo(this clsvSysCountEN objvSysCountENS, clsvSysCountEN objvSysCountENT)
{
try
{
objvSysCountENT.CountId = objvSysCountENS.CountId; //CountId
objvSysCountENT.CountTypeId = objvSysCountENS.CountTypeId; //CountTypeId
objvSysCountENT.CommentTypeName = objvSysCountENS.CommentTypeName; //评论类型名
objvSysCountENT.CommentTable = objvSysCountENS.CommentTable; //评论表
objvSysCountENT.OkCount = objvSysCountENS.OkCount; //点赞统计
objvSysCountENT.CommentTableId = objvSysCountENS.CommentTableId; //评论表Id
objvSysCountENT.CollectionCount = objvSysCountENS.CollectionCount; //收藏数量
objvSysCountENT.DownloadCount = objvSysCountENS.DownloadCount; //下载数
objvSysCountENT.AttachmentCount = objvSysCountENS.AttachmentCount; //附件计数
objvSysCountENT.CommentCount = objvSysCountENS.CommentCount; //评论数
objvSysCountENT.Score = objvSysCountENS.Score; //评分
objvSysCountENT.StuScore = objvSysCountENS.StuScore; //学生平均分
objvSysCountENT.TeaScore = objvSysCountENS.TeaScore; //教师评分
objvSysCountENT.TableKey = objvSysCountENS.TableKey; //表主键
objvSysCountENT.ParentId = objvSysCountENS.ParentId; //父Id
objvSysCountENT.UpdUser = objvSysCountENS.UpdUser; //修改人
objvSysCountENT.UpdDate = objvSysCountENS.UpdDate; //修改日期
objvSysCountENT.Memo = objvSysCountENS.Memo; //备注
objvSysCountENT.PaperRWCount = objvSysCountENS.PaperRWCount; //PaperRWCount
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
 /// <param name = "objvSysCountENS">源对象</param>
 /// <returns>目标对象=>clsvSysCountEN:objvSysCountENT</returns>
 public static clsvSysCountEN CopyTo(this clsvSysCountEN objvSysCountENS)
{
try
{
 clsvSysCountEN objvSysCountENT = new clsvSysCountEN()
{
CountId = objvSysCountENS.CountId, //CountId
CountTypeId = objvSysCountENS.CountTypeId, //CountTypeId
CommentTypeName = objvSysCountENS.CommentTypeName, //评论类型名
CommentTable = objvSysCountENS.CommentTable, //评论表
OkCount = objvSysCountENS.OkCount, //点赞统计
CommentTableId = objvSysCountENS.CommentTableId, //评论表Id
CollectionCount = objvSysCountENS.CollectionCount, //收藏数量
DownloadCount = objvSysCountENS.DownloadCount, //下载数
AttachmentCount = objvSysCountENS.AttachmentCount, //附件计数
CommentCount = objvSysCountENS.CommentCount, //评论数
Score = objvSysCountENS.Score, //评分
StuScore = objvSysCountENS.StuScore, //学生平均分
TeaScore = objvSysCountENS.TeaScore, //教师评分
TableKey = objvSysCountENS.TableKey, //表主键
ParentId = objvSysCountENS.ParentId, //父Id
UpdUser = objvSysCountENS.UpdUser, //修改人
UpdDate = objvSysCountENS.UpdDate, //修改日期
Memo = objvSysCountENS.Memo, //备注
PaperRWCount = objvSysCountENS.PaperRWCount, //PaperRWCount
};
 return objvSysCountENT;
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
public static void CheckProperty4Condition(this clsvSysCountEN objvSysCountEN)
{
 clsvSysCountBL.vSysCountDA.CheckProperty4Condition(objvSysCountEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSysCountEN objvSysCountCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSysCountCond.IsUpdated(convSysCount.CountId) == true)
{
string strComparisonOpCountId = objvSysCountCond.dicFldComparisonOp[convSysCount.CountId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysCount.CountId, objvSysCountCond.CountId, strComparisonOpCountId);
}
if (objvSysCountCond.IsUpdated(convSysCount.CountTypeId) == true)
{
string strComparisonOpCountTypeId = objvSysCountCond.dicFldComparisonOp[convSysCount.CountTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysCount.CountTypeId, objvSysCountCond.CountTypeId, strComparisonOpCountTypeId);
}
if (objvSysCountCond.IsUpdated(convSysCount.CommentTypeName) == true)
{
string strComparisonOpCommentTypeName = objvSysCountCond.dicFldComparisonOp[convSysCount.CommentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysCount.CommentTypeName, objvSysCountCond.CommentTypeName, strComparisonOpCommentTypeName);
}
if (objvSysCountCond.IsUpdated(convSysCount.CommentTable) == true)
{
string strComparisonOpCommentTable = objvSysCountCond.dicFldComparisonOp[convSysCount.CommentTable];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysCount.CommentTable, objvSysCountCond.CommentTable, strComparisonOpCommentTable);
}
if (objvSysCountCond.IsUpdated(convSysCount.OkCount) == true)
{
string strComparisonOpOkCount = objvSysCountCond.dicFldComparisonOp[convSysCount.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convSysCount.OkCount, objvSysCountCond.OkCount, strComparisonOpOkCount);
}
if (objvSysCountCond.IsUpdated(convSysCount.CommentTableId) == true)
{
string strComparisonOpCommentTableId = objvSysCountCond.dicFldComparisonOp[convSysCount.CommentTableId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysCount.CommentTableId, objvSysCountCond.CommentTableId, strComparisonOpCommentTableId);
}
if (objvSysCountCond.IsUpdated(convSysCount.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvSysCountCond.dicFldComparisonOp[convSysCount.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convSysCount.CollectionCount, objvSysCountCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvSysCountCond.IsUpdated(convSysCount.DownloadCount) == true)
{
string strComparisonOpDownloadCount = objvSysCountCond.dicFldComparisonOp[convSysCount.DownloadCount];
strWhereCond += string.Format(" And {0} {2} {1}", convSysCount.DownloadCount, objvSysCountCond.DownloadCount, strComparisonOpDownloadCount);
}
if (objvSysCountCond.IsUpdated(convSysCount.AttachmentCount) == true)
{
string strComparisonOpAttachmentCount = objvSysCountCond.dicFldComparisonOp[convSysCount.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convSysCount.AttachmentCount, objvSysCountCond.AttachmentCount, strComparisonOpAttachmentCount);
}
if (objvSysCountCond.IsUpdated(convSysCount.CommentCount) == true)
{
string strComparisonOpCommentCount = objvSysCountCond.dicFldComparisonOp[convSysCount.CommentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convSysCount.CommentCount, objvSysCountCond.CommentCount, strComparisonOpCommentCount);
}
if (objvSysCountCond.IsUpdated(convSysCount.Score) == true)
{
string strComparisonOpScore = objvSysCountCond.dicFldComparisonOp[convSysCount.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convSysCount.Score, objvSysCountCond.Score, strComparisonOpScore);
}
if (objvSysCountCond.IsUpdated(convSysCount.StuScore) == true)
{
string strComparisonOpStuScore = objvSysCountCond.dicFldComparisonOp[convSysCount.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSysCount.StuScore, objvSysCountCond.StuScore, strComparisonOpStuScore);
}
if (objvSysCountCond.IsUpdated(convSysCount.TeaScore) == true)
{
string strComparisonOpTeaScore = objvSysCountCond.dicFldComparisonOp[convSysCount.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSysCount.TeaScore, objvSysCountCond.TeaScore, strComparisonOpTeaScore);
}
if (objvSysCountCond.IsUpdated(convSysCount.TableKey) == true)
{
string strComparisonOpTableKey = objvSysCountCond.dicFldComparisonOp[convSysCount.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysCount.TableKey, objvSysCountCond.TableKey, strComparisonOpTableKey);
}
if (objvSysCountCond.IsUpdated(convSysCount.ParentId) == true)
{
string strComparisonOpParentId = objvSysCountCond.dicFldComparisonOp[convSysCount.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysCount.ParentId, objvSysCountCond.ParentId, strComparisonOpParentId);
}
if (objvSysCountCond.IsUpdated(convSysCount.UpdUser) == true)
{
string strComparisonOpUpdUser = objvSysCountCond.dicFldComparisonOp[convSysCount.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysCount.UpdUser, objvSysCountCond.UpdUser, strComparisonOpUpdUser);
}
if (objvSysCountCond.IsUpdated(convSysCount.UpdDate) == true)
{
string strComparisonOpUpdDate = objvSysCountCond.dicFldComparisonOp[convSysCount.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysCount.UpdDate, objvSysCountCond.UpdDate, strComparisonOpUpdDate);
}
if (objvSysCountCond.IsUpdated(convSysCount.Memo) == true)
{
string strComparisonOpMemo = objvSysCountCond.dicFldComparisonOp[convSysCount.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysCount.Memo, objvSysCountCond.Memo, strComparisonOpMemo);
}
if (objvSysCountCond.IsUpdated(convSysCount.PaperRWCount) == true)
{
string strComparisonOpPaperRWCount = objvSysCountCond.dicFldComparisonOp[convSysCount.PaperRWCount];
strWhereCond += string.Format(" And {0} {2} {1}", convSysCount.PaperRWCount, objvSysCountCond.PaperRWCount, strComparisonOpPaperRWCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSysCount
{
public virtual bool UpdRelaTabDate(string strCountId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 数据统计视图(vSysCount)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSysCountBL
{
public static RelatedActions_vSysCount relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSysCountDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSysCountDA vSysCountDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSysCountDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSysCountBL()
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
if (string.IsNullOrEmpty(clsvSysCountEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSysCountEN._ConnectString);
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
public static DataTable GetDataTable_vSysCount(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSysCountDA.GetDataTable_vSysCount(strWhereCond);
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
objDT = vSysCountDA.GetDataTable(strWhereCond);
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
objDT = vSysCountDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSysCountDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSysCountDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSysCountDA.GetDataTable_Top(objTopPara);
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
objDT = vSysCountDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vSysCountDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSysCountDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCountIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvSysCountEN> GetObjLstByCountIdLst(List<string> arrCountIdLst)
{
List<clsvSysCountEN> arrObjLst = new List<clsvSysCountEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCountIdLst, true);
 string strWhereCond = string.Format("CountId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCountEN objvSysCountEN = new clsvSysCountEN();
try
{
objvSysCountEN.CountId = objRow[convSysCount.CountId].ToString().Trim(); //CountId
objvSysCountEN.CountTypeId = objRow[convSysCount.CountTypeId] == DBNull.Value ? null : objRow[convSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvSysCountEN.CommentTypeName = objRow[convSysCount.CommentTypeName] == DBNull.Value ? null : objRow[convSysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCountEN.CommentTable = objRow[convSysCount.CommentTable] == DBNull.Value ? null : objRow[convSysCount.CommentTable].ToString().Trim(); //评论表
objvSysCountEN.OkCount = objRow[convSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.OkCount].ToString().Trim()); //点赞统计
objvSysCountEN.CommentTableId = objRow[convSysCount.CommentTableId] == DBNull.Value ? null : objRow[convSysCount.CommentTableId].ToString().Trim(); //评论表Id
objvSysCountEN.CollectionCount = objRow[convSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CollectionCount].ToString().Trim()); //收藏数量
objvSysCountEN.DownloadCount = objRow[convSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.DownloadCount].ToString().Trim()); //下载数
objvSysCountEN.AttachmentCount = objRow[convSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.AttachmentCount].ToString().Trim()); //附件计数
objvSysCountEN.CommentCount = objRow[convSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CommentCount].ToString().Trim()); //评论数
objvSysCountEN.Score = objRow[convSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.Score].ToString().Trim()); //评分
objvSysCountEN.StuScore = objRow[convSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.StuScore].ToString().Trim()); //学生平均分
objvSysCountEN.TeaScore = objRow[convSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.TeaScore].ToString().Trim()); //教师评分
objvSysCountEN.TableKey = objRow[convSysCount.TableKey] == DBNull.Value ? null : objRow[convSysCount.TableKey].ToString().Trim(); //表主键
objvSysCountEN.ParentId = objRow[convSysCount.ParentId] == DBNull.Value ? null : objRow[convSysCount.ParentId].ToString().Trim(); //父Id
objvSysCountEN.UpdUser = objRow[convSysCount.UpdUser] == DBNull.Value ? null : objRow[convSysCount.UpdUser].ToString().Trim(); //修改人
objvSysCountEN.UpdDate = objRow[convSysCount.UpdDate] == DBNull.Value ? null : objRow[convSysCount.UpdDate].ToString().Trim(); //修改日期
objvSysCountEN.Memo = objRow[convSysCount.Memo] == DBNull.Value ? null : objRow[convSysCount.Memo].ToString().Trim(); //备注
objvSysCountEN.PaperRWCount = objRow[convSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCountIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSysCountEN> GetObjLstByCountIdLstCache(List<string> arrCountIdLst)
{
string strKey = string.Format("{0}", clsvSysCountEN._CurrTabName);
List<clsvSysCountEN> arrvSysCountObjLstCache = GetObjLstCache();
IEnumerable <clsvSysCountEN> arrvSysCountObjLst_Sel =
arrvSysCountObjLstCache
.Where(x => arrCountIdLst.Contains(x.CountId));
return arrvSysCountObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysCountEN> GetObjLst(string strWhereCond)
{
List<clsvSysCountEN> arrObjLst = new List<clsvSysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCountEN objvSysCountEN = new clsvSysCountEN();
try
{
objvSysCountEN.CountId = objRow[convSysCount.CountId].ToString().Trim(); //CountId
objvSysCountEN.CountTypeId = objRow[convSysCount.CountTypeId] == DBNull.Value ? null : objRow[convSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvSysCountEN.CommentTypeName = objRow[convSysCount.CommentTypeName] == DBNull.Value ? null : objRow[convSysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCountEN.CommentTable = objRow[convSysCount.CommentTable] == DBNull.Value ? null : objRow[convSysCount.CommentTable].ToString().Trim(); //评论表
objvSysCountEN.OkCount = objRow[convSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.OkCount].ToString().Trim()); //点赞统计
objvSysCountEN.CommentTableId = objRow[convSysCount.CommentTableId] == DBNull.Value ? null : objRow[convSysCount.CommentTableId].ToString().Trim(); //评论表Id
objvSysCountEN.CollectionCount = objRow[convSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CollectionCount].ToString().Trim()); //收藏数量
objvSysCountEN.DownloadCount = objRow[convSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.DownloadCount].ToString().Trim()); //下载数
objvSysCountEN.AttachmentCount = objRow[convSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.AttachmentCount].ToString().Trim()); //附件计数
objvSysCountEN.CommentCount = objRow[convSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CommentCount].ToString().Trim()); //评论数
objvSysCountEN.Score = objRow[convSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.Score].ToString().Trim()); //评分
objvSysCountEN.StuScore = objRow[convSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.StuScore].ToString().Trim()); //学生平均分
objvSysCountEN.TeaScore = objRow[convSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.TeaScore].ToString().Trim()); //教师评分
objvSysCountEN.TableKey = objRow[convSysCount.TableKey] == DBNull.Value ? null : objRow[convSysCount.TableKey].ToString().Trim(); //表主键
objvSysCountEN.ParentId = objRow[convSysCount.ParentId] == DBNull.Value ? null : objRow[convSysCount.ParentId].ToString().Trim(); //父Id
objvSysCountEN.UpdUser = objRow[convSysCount.UpdUser] == DBNull.Value ? null : objRow[convSysCount.UpdUser].ToString().Trim(); //修改人
objvSysCountEN.UpdDate = objRow[convSysCount.UpdDate] == DBNull.Value ? null : objRow[convSysCount.UpdDate].ToString().Trim(); //修改日期
objvSysCountEN.Memo = objRow[convSysCount.Memo] == DBNull.Value ? null : objRow[convSysCount.Memo].ToString().Trim(); //备注
objvSysCountEN.PaperRWCount = objRow[convSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCountEN);
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
public static List<clsvSysCountEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSysCountEN> arrObjLst = new List<clsvSysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCountEN objvSysCountEN = new clsvSysCountEN();
try
{
objvSysCountEN.CountId = objRow[convSysCount.CountId].ToString().Trim(); //CountId
objvSysCountEN.CountTypeId = objRow[convSysCount.CountTypeId] == DBNull.Value ? null : objRow[convSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvSysCountEN.CommentTypeName = objRow[convSysCount.CommentTypeName] == DBNull.Value ? null : objRow[convSysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCountEN.CommentTable = objRow[convSysCount.CommentTable] == DBNull.Value ? null : objRow[convSysCount.CommentTable].ToString().Trim(); //评论表
objvSysCountEN.OkCount = objRow[convSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.OkCount].ToString().Trim()); //点赞统计
objvSysCountEN.CommentTableId = objRow[convSysCount.CommentTableId] == DBNull.Value ? null : objRow[convSysCount.CommentTableId].ToString().Trim(); //评论表Id
objvSysCountEN.CollectionCount = objRow[convSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CollectionCount].ToString().Trim()); //收藏数量
objvSysCountEN.DownloadCount = objRow[convSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.DownloadCount].ToString().Trim()); //下载数
objvSysCountEN.AttachmentCount = objRow[convSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.AttachmentCount].ToString().Trim()); //附件计数
objvSysCountEN.CommentCount = objRow[convSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CommentCount].ToString().Trim()); //评论数
objvSysCountEN.Score = objRow[convSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.Score].ToString().Trim()); //评分
objvSysCountEN.StuScore = objRow[convSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.StuScore].ToString().Trim()); //学生平均分
objvSysCountEN.TeaScore = objRow[convSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.TeaScore].ToString().Trim()); //教师评分
objvSysCountEN.TableKey = objRow[convSysCount.TableKey] == DBNull.Value ? null : objRow[convSysCount.TableKey].ToString().Trim(); //表主键
objvSysCountEN.ParentId = objRow[convSysCount.ParentId] == DBNull.Value ? null : objRow[convSysCount.ParentId].ToString().Trim(); //父Id
objvSysCountEN.UpdUser = objRow[convSysCount.UpdUser] == DBNull.Value ? null : objRow[convSysCount.UpdUser].ToString().Trim(); //修改人
objvSysCountEN.UpdDate = objRow[convSysCount.UpdDate] == DBNull.Value ? null : objRow[convSysCount.UpdDate].ToString().Trim(); //修改日期
objvSysCountEN.Memo = objRow[convSysCount.Memo] == DBNull.Value ? null : objRow[convSysCount.Memo].ToString().Trim(); //备注
objvSysCountEN.PaperRWCount = objRow[convSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSysCountCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSysCountEN> GetSubObjLstCache(clsvSysCountEN objvSysCountCond)
{
List<clsvSysCountEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSysCountEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSysCount.AttributeName)
{
if (objvSysCountCond.IsUpdated(strFldName) == false) continue;
if (objvSysCountCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysCountCond[strFldName].ToString());
}
else
{
if (objvSysCountCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSysCountCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysCountCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSysCountCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSysCountCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSysCountCond[strFldName]));
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
public static List<clsvSysCountEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSysCountEN> arrObjLst = new List<clsvSysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCountEN objvSysCountEN = new clsvSysCountEN();
try
{
objvSysCountEN.CountId = objRow[convSysCount.CountId].ToString().Trim(); //CountId
objvSysCountEN.CountTypeId = objRow[convSysCount.CountTypeId] == DBNull.Value ? null : objRow[convSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvSysCountEN.CommentTypeName = objRow[convSysCount.CommentTypeName] == DBNull.Value ? null : objRow[convSysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCountEN.CommentTable = objRow[convSysCount.CommentTable] == DBNull.Value ? null : objRow[convSysCount.CommentTable].ToString().Trim(); //评论表
objvSysCountEN.OkCount = objRow[convSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.OkCount].ToString().Trim()); //点赞统计
objvSysCountEN.CommentTableId = objRow[convSysCount.CommentTableId] == DBNull.Value ? null : objRow[convSysCount.CommentTableId].ToString().Trim(); //评论表Id
objvSysCountEN.CollectionCount = objRow[convSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CollectionCount].ToString().Trim()); //收藏数量
objvSysCountEN.DownloadCount = objRow[convSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.DownloadCount].ToString().Trim()); //下载数
objvSysCountEN.AttachmentCount = objRow[convSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.AttachmentCount].ToString().Trim()); //附件计数
objvSysCountEN.CommentCount = objRow[convSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CommentCount].ToString().Trim()); //评论数
objvSysCountEN.Score = objRow[convSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.Score].ToString().Trim()); //评分
objvSysCountEN.StuScore = objRow[convSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.StuScore].ToString().Trim()); //学生平均分
objvSysCountEN.TeaScore = objRow[convSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.TeaScore].ToString().Trim()); //教师评分
objvSysCountEN.TableKey = objRow[convSysCount.TableKey] == DBNull.Value ? null : objRow[convSysCount.TableKey].ToString().Trim(); //表主键
objvSysCountEN.ParentId = objRow[convSysCount.ParentId] == DBNull.Value ? null : objRow[convSysCount.ParentId].ToString().Trim(); //父Id
objvSysCountEN.UpdUser = objRow[convSysCount.UpdUser] == DBNull.Value ? null : objRow[convSysCount.UpdUser].ToString().Trim(); //修改人
objvSysCountEN.UpdDate = objRow[convSysCount.UpdDate] == DBNull.Value ? null : objRow[convSysCount.UpdDate].ToString().Trim(); //修改日期
objvSysCountEN.Memo = objRow[convSysCount.Memo] == DBNull.Value ? null : objRow[convSysCount.Memo].ToString().Trim(); //备注
objvSysCountEN.PaperRWCount = objRow[convSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCountEN);
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
public static List<clsvSysCountEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSysCountEN> arrObjLst = new List<clsvSysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCountEN objvSysCountEN = new clsvSysCountEN();
try
{
objvSysCountEN.CountId = objRow[convSysCount.CountId].ToString().Trim(); //CountId
objvSysCountEN.CountTypeId = objRow[convSysCount.CountTypeId] == DBNull.Value ? null : objRow[convSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvSysCountEN.CommentTypeName = objRow[convSysCount.CommentTypeName] == DBNull.Value ? null : objRow[convSysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCountEN.CommentTable = objRow[convSysCount.CommentTable] == DBNull.Value ? null : objRow[convSysCount.CommentTable].ToString().Trim(); //评论表
objvSysCountEN.OkCount = objRow[convSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.OkCount].ToString().Trim()); //点赞统计
objvSysCountEN.CommentTableId = objRow[convSysCount.CommentTableId] == DBNull.Value ? null : objRow[convSysCount.CommentTableId].ToString().Trim(); //评论表Id
objvSysCountEN.CollectionCount = objRow[convSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CollectionCount].ToString().Trim()); //收藏数量
objvSysCountEN.DownloadCount = objRow[convSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.DownloadCount].ToString().Trim()); //下载数
objvSysCountEN.AttachmentCount = objRow[convSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.AttachmentCount].ToString().Trim()); //附件计数
objvSysCountEN.CommentCount = objRow[convSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CommentCount].ToString().Trim()); //评论数
objvSysCountEN.Score = objRow[convSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.Score].ToString().Trim()); //评分
objvSysCountEN.StuScore = objRow[convSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.StuScore].ToString().Trim()); //学生平均分
objvSysCountEN.TeaScore = objRow[convSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.TeaScore].ToString().Trim()); //教师评分
objvSysCountEN.TableKey = objRow[convSysCount.TableKey] == DBNull.Value ? null : objRow[convSysCount.TableKey].ToString().Trim(); //表主键
objvSysCountEN.ParentId = objRow[convSysCount.ParentId] == DBNull.Value ? null : objRow[convSysCount.ParentId].ToString().Trim(); //父Id
objvSysCountEN.UpdUser = objRow[convSysCount.UpdUser] == DBNull.Value ? null : objRow[convSysCount.UpdUser].ToString().Trim(); //修改人
objvSysCountEN.UpdDate = objRow[convSysCount.UpdDate] == DBNull.Value ? null : objRow[convSysCount.UpdDate].ToString().Trim(); //修改日期
objvSysCountEN.Memo = objRow[convSysCount.Memo] == DBNull.Value ? null : objRow[convSysCount.Memo].ToString().Trim(); //备注
objvSysCountEN.PaperRWCount = objRow[convSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCountEN);
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
List<clsvSysCountEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSysCountEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysCountEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSysCountEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSysCountEN> arrObjLst = new List<clsvSysCountEN>(); 
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
	clsvSysCountEN objvSysCountEN = new clsvSysCountEN();
try
{
objvSysCountEN.CountId = objRow[convSysCount.CountId].ToString().Trim(); //CountId
objvSysCountEN.CountTypeId = objRow[convSysCount.CountTypeId] == DBNull.Value ? null : objRow[convSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvSysCountEN.CommentTypeName = objRow[convSysCount.CommentTypeName] == DBNull.Value ? null : objRow[convSysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCountEN.CommentTable = objRow[convSysCount.CommentTable] == DBNull.Value ? null : objRow[convSysCount.CommentTable].ToString().Trim(); //评论表
objvSysCountEN.OkCount = objRow[convSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.OkCount].ToString().Trim()); //点赞统计
objvSysCountEN.CommentTableId = objRow[convSysCount.CommentTableId] == DBNull.Value ? null : objRow[convSysCount.CommentTableId].ToString().Trim(); //评论表Id
objvSysCountEN.CollectionCount = objRow[convSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CollectionCount].ToString().Trim()); //收藏数量
objvSysCountEN.DownloadCount = objRow[convSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.DownloadCount].ToString().Trim()); //下载数
objvSysCountEN.AttachmentCount = objRow[convSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.AttachmentCount].ToString().Trim()); //附件计数
objvSysCountEN.CommentCount = objRow[convSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CommentCount].ToString().Trim()); //评论数
objvSysCountEN.Score = objRow[convSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.Score].ToString().Trim()); //评分
objvSysCountEN.StuScore = objRow[convSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.StuScore].ToString().Trim()); //学生平均分
objvSysCountEN.TeaScore = objRow[convSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.TeaScore].ToString().Trim()); //教师评分
objvSysCountEN.TableKey = objRow[convSysCount.TableKey] == DBNull.Value ? null : objRow[convSysCount.TableKey].ToString().Trim(); //表主键
objvSysCountEN.ParentId = objRow[convSysCount.ParentId] == DBNull.Value ? null : objRow[convSysCount.ParentId].ToString().Trim(); //父Id
objvSysCountEN.UpdUser = objRow[convSysCount.UpdUser] == DBNull.Value ? null : objRow[convSysCount.UpdUser].ToString().Trim(); //修改人
objvSysCountEN.UpdDate = objRow[convSysCount.UpdDate] == DBNull.Value ? null : objRow[convSysCount.UpdDate].ToString().Trim(); //修改日期
objvSysCountEN.Memo = objRow[convSysCount.Memo] == DBNull.Value ? null : objRow[convSysCount.Memo].ToString().Trim(); //备注
objvSysCountEN.PaperRWCount = objRow[convSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCountEN);
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
public static List<clsvSysCountEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSysCountEN> arrObjLst = new List<clsvSysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCountEN objvSysCountEN = new clsvSysCountEN();
try
{
objvSysCountEN.CountId = objRow[convSysCount.CountId].ToString().Trim(); //CountId
objvSysCountEN.CountTypeId = objRow[convSysCount.CountTypeId] == DBNull.Value ? null : objRow[convSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvSysCountEN.CommentTypeName = objRow[convSysCount.CommentTypeName] == DBNull.Value ? null : objRow[convSysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCountEN.CommentTable = objRow[convSysCount.CommentTable] == DBNull.Value ? null : objRow[convSysCount.CommentTable].ToString().Trim(); //评论表
objvSysCountEN.OkCount = objRow[convSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.OkCount].ToString().Trim()); //点赞统计
objvSysCountEN.CommentTableId = objRow[convSysCount.CommentTableId] == DBNull.Value ? null : objRow[convSysCount.CommentTableId].ToString().Trim(); //评论表Id
objvSysCountEN.CollectionCount = objRow[convSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CollectionCount].ToString().Trim()); //收藏数量
objvSysCountEN.DownloadCount = objRow[convSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.DownloadCount].ToString().Trim()); //下载数
objvSysCountEN.AttachmentCount = objRow[convSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.AttachmentCount].ToString().Trim()); //附件计数
objvSysCountEN.CommentCount = objRow[convSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CommentCount].ToString().Trim()); //评论数
objvSysCountEN.Score = objRow[convSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.Score].ToString().Trim()); //评分
objvSysCountEN.StuScore = objRow[convSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.StuScore].ToString().Trim()); //学生平均分
objvSysCountEN.TeaScore = objRow[convSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.TeaScore].ToString().Trim()); //教师评分
objvSysCountEN.TableKey = objRow[convSysCount.TableKey] == DBNull.Value ? null : objRow[convSysCount.TableKey].ToString().Trim(); //表主键
objvSysCountEN.ParentId = objRow[convSysCount.ParentId] == DBNull.Value ? null : objRow[convSysCount.ParentId].ToString().Trim(); //父Id
objvSysCountEN.UpdUser = objRow[convSysCount.UpdUser] == DBNull.Value ? null : objRow[convSysCount.UpdUser].ToString().Trim(); //修改人
objvSysCountEN.UpdDate = objRow[convSysCount.UpdDate] == DBNull.Value ? null : objRow[convSysCount.UpdDate].ToString().Trim(); //修改日期
objvSysCountEN.Memo = objRow[convSysCount.Memo] == DBNull.Value ? null : objRow[convSysCount.Memo].ToString().Trim(); //备注
objvSysCountEN.PaperRWCount = objRow[convSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSysCountEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSysCountEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSysCountEN> arrObjLst = new List<clsvSysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCountEN objvSysCountEN = new clsvSysCountEN();
try
{
objvSysCountEN.CountId = objRow[convSysCount.CountId].ToString().Trim(); //CountId
objvSysCountEN.CountTypeId = objRow[convSysCount.CountTypeId] == DBNull.Value ? null : objRow[convSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvSysCountEN.CommentTypeName = objRow[convSysCount.CommentTypeName] == DBNull.Value ? null : objRow[convSysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCountEN.CommentTable = objRow[convSysCount.CommentTable] == DBNull.Value ? null : objRow[convSysCount.CommentTable].ToString().Trim(); //评论表
objvSysCountEN.OkCount = objRow[convSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.OkCount].ToString().Trim()); //点赞统计
objvSysCountEN.CommentTableId = objRow[convSysCount.CommentTableId] == DBNull.Value ? null : objRow[convSysCount.CommentTableId].ToString().Trim(); //评论表Id
objvSysCountEN.CollectionCount = objRow[convSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CollectionCount].ToString().Trim()); //收藏数量
objvSysCountEN.DownloadCount = objRow[convSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.DownloadCount].ToString().Trim()); //下载数
objvSysCountEN.AttachmentCount = objRow[convSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.AttachmentCount].ToString().Trim()); //附件计数
objvSysCountEN.CommentCount = objRow[convSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CommentCount].ToString().Trim()); //评论数
objvSysCountEN.Score = objRow[convSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.Score].ToString().Trim()); //评分
objvSysCountEN.StuScore = objRow[convSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.StuScore].ToString().Trim()); //学生平均分
objvSysCountEN.TeaScore = objRow[convSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.TeaScore].ToString().Trim()); //教师评分
objvSysCountEN.TableKey = objRow[convSysCount.TableKey] == DBNull.Value ? null : objRow[convSysCount.TableKey].ToString().Trim(); //表主键
objvSysCountEN.ParentId = objRow[convSysCount.ParentId] == DBNull.Value ? null : objRow[convSysCount.ParentId].ToString().Trim(); //父Id
objvSysCountEN.UpdUser = objRow[convSysCount.UpdUser] == DBNull.Value ? null : objRow[convSysCount.UpdUser].ToString().Trim(); //修改人
objvSysCountEN.UpdDate = objRow[convSysCount.UpdDate] == DBNull.Value ? null : objRow[convSysCount.UpdDate].ToString().Trim(); //修改日期
objvSysCountEN.Memo = objRow[convSysCount.Memo] == DBNull.Value ? null : objRow[convSysCount.Memo].ToString().Trim(); //备注
objvSysCountEN.PaperRWCount = objRow[convSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCountEN);
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
public static List<clsvSysCountEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSysCountEN> arrObjLst = new List<clsvSysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCountEN objvSysCountEN = new clsvSysCountEN();
try
{
objvSysCountEN.CountId = objRow[convSysCount.CountId].ToString().Trim(); //CountId
objvSysCountEN.CountTypeId = objRow[convSysCount.CountTypeId] == DBNull.Value ? null : objRow[convSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvSysCountEN.CommentTypeName = objRow[convSysCount.CommentTypeName] == DBNull.Value ? null : objRow[convSysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCountEN.CommentTable = objRow[convSysCount.CommentTable] == DBNull.Value ? null : objRow[convSysCount.CommentTable].ToString().Trim(); //评论表
objvSysCountEN.OkCount = objRow[convSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.OkCount].ToString().Trim()); //点赞统计
objvSysCountEN.CommentTableId = objRow[convSysCount.CommentTableId] == DBNull.Value ? null : objRow[convSysCount.CommentTableId].ToString().Trim(); //评论表Id
objvSysCountEN.CollectionCount = objRow[convSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CollectionCount].ToString().Trim()); //收藏数量
objvSysCountEN.DownloadCount = objRow[convSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.DownloadCount].ToString().Trim()); //下载数
objvSysCountEN.AttachmentCount = objRow[convSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.AttachmentCount].ToString().Trim()); //附件计数
objvSysCountEN.CommentCount = objRow[convSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CommentCount].ToString().Trim()); //评论数
objvSysCountEN.Score = objRow[convSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.Score].ToString().Trim()); //评分
objvSysCountEN.StuScore = objRow[convSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.StuScore].ToString().Trim()); //学生平均分
objvSysCountEN.TeaScore = objRow[convSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.TeaScore].ToString().Trim()); //教师评分
objvSysCountEN.TableKey = objRow[convSysCount.TableKey] == DBNull.Value ? null : objRow[convSysCount.TableKey].ToString().Trim(); //表主键
objvSysCountEN.ParentId = objRow[convSysCount.ParentId] == DBNull.Value ? null : objRow[convSysCount.ParentId].ToString().Trim(); //父Id
objvSysCountEN.UpdUser = objRow[convSysCount.UpdUser] == DBNull.Value ? null : objRow[convSysCount.UpdUser].ToString().Trim(); //修改人
objvSysCountEN.UpdDate = objRow[convSysCount.UpdDate] == DBNull.Value ? null : objRow[convSysCount.UpdDate].ToString().Trim(); //修改日期
objvSysCountEN.Memo = objRow[convSysCount.Memo] == DBNull.Value ? null : objRow[convSysCount.Memo].ToString().Trim(); //备注
objvSysCountEN.PaperRWCount = objRow[convSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysCountEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSysCountEN> arrObjLst = new List<clsvSysCountEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCountEN objvSysCountEN = new clsvSysCountEN();
try
{
objvSysCountEN.CountId = objRow[convSysCount.CountId].ToString().Trim(); //CountId
objvSysCountEN.CountTypeId = objRow[convSysCount.CountTypeId] == DBNull.Value ? null : objRow[convSysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvSysCountEN.CommentTypeName = objRow[convSysCount.CommentTypeName] == DBNull.Value ? null : objRow[convSysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCountEN.CommentTable = objRow[convSysCount.CommentTable] == DBNull.Value ? null : objRow[convSysCount.CommentTable].ToString().Trim(); //评论表
objvSysCountEN.OkCount = objRow[convSysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.OkCount].ToString().Trim()); //点赞统计
objvSysCountEN.CommentTableId = objRow[convSysCount.CommentTableId] == DBNull.Value ? null : objRow[convSysCount.CommentTableId].ToString().Trim(); //评论表Id
objvSysCountEN.CollectionCount = objRow[convSysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CollectionCount].ToString().Trim()); //收藏数量
objvSysCountEN.DownloadCount = objRow[convSysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.DownloadCount].ToString().Trim()); //下载数
objvSysCountEN.AttachmentCount = objRow[convSysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.AttachmentCount].ToString().Trim()); //附件计数
objvSysCountEN.CommentCount = objRow[convSysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.CommentCount].ToString().Trim()); //评论数
objvSysCountEN.Score = objRow[convSysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.Score].ToString().Trim()); //评分
objvSysCountEN.StuScore = objRow[convSysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.StuScore].ToString().Trim()); //学生平均分
objvSysCountEN.TeaScore = objRow[convSysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysCount.TeaScore].ToString().Trim()); //教师评分
objvSysCountEN.TableKey = objRow[convSysCount.TableKey] == DBNull.Value ? null : objRow[convSysCount.TableKey].ToString().Trim(); //表主键
objvSysCountEN.ParentId = objRow[convSysCount.ParentId] == DBNull.Value ? null : objRow[convSysCount.ParentId].ToString().Trim(); //父Id
objvSysCountEN.UpdUser = objRow[convSysCount.UpdUser] == DBNull.Value ? null : objRow[convSysCount.UpdUser].ToString().Trim(); //修改人
objvSysCountEN.UpdDate = objRow[convSysCount.UpdDate] == DBNull.Value ? null : objRow[convSysCount.UpdDate].ToString().Trim(); //修改日期
objvSysCountEN.Memo = objRow[convSysCount.Memo] == DBNull.Value ? null : objRow[convSysCount.Memo].ToString().Trim(); //备注
objvSysCountEN.PaperRWCount = objRow[convSysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCountEN.CountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCountEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSysCountEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSysCount(ref clsvSysCountEN objvSysCountEN)
{
bool bolResult = vSysCountDA.GetvSysCount(ref objvSysCountEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCountId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysCountEN GetObjByCountId(string strCountId)
{
if (strCountId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCountId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCountId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCountId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvSysCountEN objvSysCountEN = vSysCountDA.GetObjByCountId(strCountId);
return objvSysCountEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSysCountEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSysCountEN objvSysCountEN = vSysCountDA.GetFirstObj(strWhereCond);
 return objvSysCountEN;
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
public static clsvSysCountEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSysCountEN objvSysCountEN = vSysCountDA.GetObjByDataRow(objRow);
 return objvSysCountEN;
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
public static clsvSysCountEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSysCountEN objvSysCountEN = vSysCountDA.GetObjByDataRow(objRow);
 return objvSysCountEN;
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
 /// <param name = "strCountId">所给的关键字</param>
 /// <param name = "lstvSysCountObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSysCountEN GetObjByCountIdFromList(string strCountId, List<clsvSysCountEN> lstvSysCountObjLst)
{
foreach (clsvSysCountEN objvSysCountEN in lstvSysCountObjLst)
{
if (objvSysCountEN.CountId == strCountId)
{
return objvSysCountEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strCountId;
 try
 {
 strCountId = new clsvSysCountDA().GetFirstID(strWhereCond);
 return strCountId;
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
 arrList = vSysCountDA.GetID(strWhereCond);
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
bool bolIsExist = vSysCountDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCountId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCountId)
{
if (string.IsNullOrEmpty(strCountId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCountId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vSysCountDA.IsExist(strCountId);
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
 bolIsExist = clsvSysCountDA.IsExistTable();
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
 bolIsExist = vSysCountDA.IsExistTable(strTabName);
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
 /// <param name = "objvSysCountENS">源对象</param>
 /// <param name = "objvSysCountENT">目标对象</param>
 public static void CopyTo(clsvSysCountEN objvSysCountENS, clsvSysCountEN objvSysCountENT)
{
try
{
objvSysCountENT.CountId = objvSysCountENS.CountId; //CountId
objvSysCountENT.CountTypeId = objvSysCountENS.CountTypeId; //CountTypeId
objvSysCountENT.CommentTypeName = objvSysCountENS.CommentTypeName; //评论类型名
objvSysCountENT.CommentTable = objvSysCountENS.CommentTable; //评论表
objvSysCountENT.OkCount = objvSysCountENS.OkCount; //点赞统计
objvSysCountENT.CommentTableId = objvSysCountENS.CommentTableId; //评论表Id
objvSysCountENT.CollectionCount = objvSysCountENS.CollectionCount; //收藏数量
objvSysCountENT.DownloadCount = objvSysCountENS.DownloadCount; //下载数
objvSysCountENT.AttachmentCount = objvSysCountENS.AttachmentCount; //附件计数
objvSysCountENT.CommentCount = objvSysCountENS.CommentCount; //评论数
objvSysCountENT.Score = objvSysCountENS.Score; //评分
objvSysCountENT.StuScore = objvSysCountENS.StuScore; //学生平均分
objvSysCountENT.TeaScore = objvSysCountENS.TeaScore; //教师评分
objvSysCountENT.TableKey = objvSysCountENS.TableKey; //表主键
objvSysCountENT.ParentId = objvSysCountENS.ParentId; //父Id
objvSysCountENT.UpdUser = objvSysCountENS.UpdUser; //修改人
objvSysCountENT.UpdDate = objvSysCountENS.UpdDate; //修改日期
objvSysCountENT.Memo = objvSysCountENS.Memo; //备注
objvSysCountENT.PaperRWCount = objvSysCountENS.PaperRWCount; //PaperRWCount
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
 /// <param name = "objvSysCountEN">源简化对象</param>
 public static void SetUpdFlag(clsvSysCountEN objvSysCountEN)
{
try
{
objvSysCountEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSysCountEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSysCount.CountId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.CountId = objvSysCountEN.CountId; //CountId
}
if (arrFldSet.Contains(convSysCount.CountTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.CountTypeId = objvSysCountEN.CountTypeId == "[null]" ? null :  objvSysCountEN.CountTypeId; //CountTypeId
}
if (arrFldSet.Contains(convSysCount.CommentTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.CommentTypeName = objvSysCountEN.CommentTypeName == "[null]" ? null :  objvSysCountEN.CommentTypeName; //评论类型名
}
if (arrFldSet.Contains(convSysCount.CommentTable, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.CommentTable = objvSysCountEN.CommentTable == "[null]" ? null :  objvSysCountEN.CommentTable; //评论表
}
if (arrFldSet.Contains(convSysCount.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.OkCount = objvSysCountEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convSysCount.CommentTableId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.CommentTableId = objvSysCountEN.CommentTableId == "[null]" ? null :  objvSysCountEN.CommentTableId; //评论表Id
}
if (arrFldSet.Contains(convSysCount.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.CollectionCount = objvSysCountEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convSysCount.DownloadCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.DownloadCount = objvSysCountEN.DownloadCount; //下载数
}
if (arrFldSet.Contains(convSysCount.AttachmentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.AttachmentCount = objvSysCountEN.AttachmentCount; //附件计数
}
if (arrFldSet.Contains(convSysCount.CommentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.CommentCount = objvSysCountEN.CommentCount; //评论数
}
if (arrFldSet.Contains(convSysCount.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.Score = objvSysCountEN.Score; //评分
}
if (arrFldSet.Contains(convSysCount.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.StuScore = objvSysCountEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convSysCount.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.TeaScore = objvSysCountEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convSysCount.TableKey, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.TableKey = objvSysCountEN.TableKey == "[null]" ? null :  objvSysCountEN.TableKey; //表主键
}
if (arrFldSet.Contains(convSysCount.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.ParentId = objvSysCountEN.ParentId == "[null]" ? null :  objvSysCountEN.ParentId; //父Id
}
if (arrFldSet.Contains(convSysCount.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.UpdUser = objvSysCountEN.UpdUser == "[null]" ? null :  objvSysCountEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convSysCount.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.UpdDate = objvSysCountEN.UpdDate == "[null]" ? null :  objvSysCountEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convSysCount.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.Memo = objvSysCountEN.Memo == "[null]" ? null :  objvSysCountEN.Memo; //备注
}
if (arrFldSet.Contains(convSysCount.PaperRWCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCountEN.PaperRWCount = objvSysCountEN.PaperRWCount; //PaperRWCount
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
 /// <param name = "objvSysCountEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSysCountEN objvSysCountEN)
{
try
{
if (objvSysCountEN.CountTypeId == "[null]") objvSysCountEN.CountTypeId = null; //CountTypeId
if (objvSysCountEN.CommentTypeName == "[null]") objvSysCountEN.CommentTypeName = null; //评论类型名
if (objvSysCountEN.CommentTable == "[null]") objvSysCountEN.CommentTable = null; //评论表
if (objvSysCountEN.CommentTableId == "[null]") objvSysCountEN.CommentTableId = null; //评论表Id
if (objvSysCountEN.TableKey == "[null]") objvSysCountEN.TableKey = null; //表主键
if (objvSysCountEN.ParentId == "[null]") objvSysCountEN.ParentId = null; //父Id
if (objvSysCountEN.UpdUser == "[null]") objvSysCountEN.UpdUser = null; //修改人
if (objvSysCountEN.UpdDate == "[null]") objvSysCountEN.UpdDate = null; //修改日期
if (objvSysCountEN.Memo == "[null]") objvSysCountEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvSysCountEN objvSysCountEN)
{
 vSysCountDA.CheckProperty4Condition(objvSysCountEN);
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
if (clsSysCommentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysCommentTypeBL没有刷新缓存机制(clsSysCommentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSysCountBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysCountBL没有刷新缓存机制(clsSysCountBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CountId");
//if (arrvSysCountObjLstCache == null)
//{
//arrvSysCountObjLstCache = vSysCountDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCountId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSysCountEN GetObjByCountIdCache(string strCountId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvSysCountEN._CurrTabName);
List<clsvSysCountEN> arrvSysCountObjLstCache = GetObjLstCache();
IEnumerable <clsvSysCountEN> arrvSysCountObjLst_Sel =
arrvSysCountObjLstCache
.Where(x=> x.CountId == strCountId 
);
if (arrvSysCountObjLst_Sel.Count() == 0)
{
   clsvSysCountEN obj = clsvSysCountBL.GetObjByCountId(strCountId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvSysCountObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSysCountEN> GetAllvSysCountObjLstCache()
{
//获取缓存中的对象列表
List<clsvSysCountEN> arrvSysCountObjLstCache = GetObjLstCache(); 
return arrvSysCountObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSysCountEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvSysCountEN._CurrTabName);
List<clsvSysCountEN> arrvSysCountObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSysCountObjLstCache;
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
string strKey = string.Format("{0}", clsvSysCountEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strCountId)
{
if (strInFldName != convSysCount.CountId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSysCount.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSysCount.AttributeName));
throw new Exception(strMsg);
}
var objvSysCount = clsvSysCountBL.GetObjByCountIdCache(strCountId);
if (objvSysCount == null) return "";
return objvSysCount[strOutFldName].ToString();
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
int intRecCount = clsvSysCountDA.GetRecCount(strTabName);
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
int intRecCount = clsvSysCountDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSysCountDA.GetRecCount();
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
int intRecCount = clsvSysCountDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSysCountCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSysCountEN objvSysCountCond)
{
List<clsvSysCountEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSysCountEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSysCount.AttributeName)
{
if (objvSysCountCond.IsUpdated(strFldName) == false) continue;
if (objvSysCountCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysCountCond[strFldName].ToString());
}
else
{
if (objvSysCountCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSysCountCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysCountCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSysCountCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSysCountCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSysCountCond[strFldName]));
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
 List<string> arrList = clsvSysCountDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSysCountDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSysCountDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}