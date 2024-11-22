
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SysCountBL
 表名:vzx_SysCount(01120837)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:37
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
public static class  clsvzx_SysCountBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxCountId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_SysCountEN GetObj(this K_zxCountId_vzx_SysCount myKey)
{
clsvzx_SysCountEN objvzx_SysCountEN = clsvzx_SysCountBL.vzx_SysCountDA.GetObjByzxCountId(myKey.Value);
return objvzx_SysCountEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetCommentTypeName(this clsvzx_SysCountEN objvzx_SysCountEN, string strCommentTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentTypeName, 50, convzx_SysCount.CommentTypeName);
}
objvzx_SysCountEN.CommentTypeName = strCommentTypeName; //评论类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.CommentTypeName) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.CommentTypeName, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.CommentTypeName] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetCommentTable(this clsvzx_SysCountEN objvzx_SysCountEN, string strCommentTable, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentTable, 50, convzx_SysCount.CommentTable);
}
objvzx_SysCountEN.CommentTable = strCommentTable; //评论表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.CommentTable) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.CommentTable, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.CommentTable] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetzxCountId(this clsvzx_SysCountEN objvzx_SysCountEN, string strzxCountId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxCountId, 10, convzx_SysCount.zxCountId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxCountId, 10, convzx_SysCount.zxCountId);
}
objvzx_SysCountEN.zxCountId = strzxCountId; //CountId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.zxCountId) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.zxCountId, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.zxCountId] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetCommentTableId(this clsvzx_SysCountEN objvzx_SysCountEN, string strCommentTableId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentTableId, 50, convzx_SysCount.CommentTableId);
}
objvzx_SysCountEN.CommentTableId = strCommentTableId; //评论表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.CommentTableId) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.CommentTableId, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.CommentTableId] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetCountTypeId(this clsvzx_SysCountEN objvzx_SysCountEN, string strCountTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCountTypeId, 2, convzx_SysCount.CountTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCountTypeId, 2, convzx_SysCount.CountTypeId);
}
objvzx_SysCountEN.CountTypeId = strCountTypeId; //CountTypeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.CountTypeId) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.CountTypeId, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.CountTypeId] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetPaperRWCount(this clsvzx_SysCountEN objvzx_SysCountEN, int? intPaperRWCount, string strComparisonOp="")
	{
objvzx_SysCountEN.PaperRWCount = intPaperRWCount; //PaperRWCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.PaperRWCount) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.PaperRWCount, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.PaperRWCount] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetOkCount(this clsvzx_SysCountEN objvzx_SysCountEN, int? intOkCount, string strComparisonOp="")
	{
objvzx_SysCountEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.OkCount) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.OkCount, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.OkCount] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetCollectionCount(this clsvzx_SysCountEN objvzx_SysCountEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvzx_SysCountEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.CollectionCount) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.CollectionCount, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.CollectionCount] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetDownloadCount(this clsvzx_SysCountEN objvzx_SysCountEN, int? intDownloadCount, string strComparisonOp="")
	{
objvzx_SysCountEN.DownloadCount = intDownloadCount; //下载数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.DownloadCount) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.DownloadCount, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.DownloadCount] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetAttachmentCount(this clsvzx_SysCountEN objvzx_SysCountEN, int? intAttachmentCount, string strComparisonOp="")
	{
objvzx_SysCountEN.AttachmentCount = intAttachmentCount; //附件计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.AttachmentCount) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.AttachmentCount, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.AttachmentCount] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetCommentCount(this clsvzx_SysCountEN objvzx_SysCountEN, int? intCommentCount, string strComparisonOp="")
	{
objvzx_SysCountEN.CommentCount = intCommentCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.CommentCount) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.CommentCount, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.CommentCount] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetScore(this clsvzx_SysCountEN objvzx_SysCountEN, float? fltScore, string strComparisonOp="")
	{
objvzx_SysCountEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.Score) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.Score, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.Score] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetStuScore(this clsvzx_SysCountEN objvzx_SysCountEN, float? fltStuScore, string strComparisonOp="")
	{
objvzx_SysCountEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.StuScore) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.StuScore, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.StuScore] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetTeaScore(this clsvzx_SysCountEN objvzx_SysCountEN, float? fltTeaScore, string strComparisonOp="")
	{
objvzx_SysCountEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.TeaScore) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.TeaScore, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.TeaScore] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetTableKey(this clsvzx_SysCountEN objvzx_SysCountEN, string strTableKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableKey, 20, convzx_SysCount.TableKey);
}
objvzx_SysCountEN.TableKey = strTableKey; //表主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.TableKey) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.TableKey, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.TableKey] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetParentId(this clsvzx_SysCountEN objvzx_SysCountEN, string strParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 20, convzx_SysCount.ParentId);
}
objvzx_SysCountEN.ParentId = strParentId; //父Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.ParentId) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.ParentId, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.ParentId] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetUpdUser(this clsvzx_SysCountEN objvzx_SysCountEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_SysCount.UpdUser);
}
objvzx_SysCountEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.UpdUser) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.UpdUser, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.UpdUser] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetUpdDate(this clsvzx_SysCountEN objvzx_SysCountEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_SysCount.UpdDate);
}
objvzx_SysCountEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.UpdDate) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.UpdDate, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.UpdDate] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCountEN SetMemo(this clsvzx_SysCountEN objvzx_SysCountEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_SysCount.Memo);
}
objvzx_SysCountEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCountEN.dicFldComparisonOp.ContainsKey(convzx_SysCount.Memo) == false)
{
objvzx_SysCountEN.dicFldComparisonOp.Add(convzx_SysCount.Memo, strComparisonOp);
}
else
{
objvzx_SysCountEN.dicFldComparisonOp[convzx_SysCount.Memo] = strComparisonOp;
}
}
return objvzx_SysCountEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_SysCountENS">源对象</param>
 /// <param name = "objvzx_SysCountENT">目标对象</param>
 public static void CopyTo(this clsvzx_SysCountEN objvzx_SysCountENS, clsvzx_SysCountEN objvzx_SysCountENT)
{
try
{
objvzx_SysCountENT.CommentTypeName = objvzx_SysCountENS.CommentTypeName; //评论类型名
objvzx_SysCountENT.CommentTable = objvzx_SysCountENS.CommentTable; //评论表
objvzx_SysCountENT.zxCountId = objvzx_SysCountENS.zxCountId; //CountId
objvzx_SysCountENT.CommentTableId = objvzx_SysCountENS.CommentTableId; //评论表Id
objvzx_SysCountENT.CountTypeId = objvzx_SysCountENS.CountTypeId; //CountTypeId
objvzx_SysCountENT.PaperRWCount = objvzx_SysCountENS.PaperRWCount; //PaperRWCount
objvzx_SysCountENT.OkCount = objvzx_SysCountENS.OkCount; //点赞统计
objvzx_SysCountENT.CollectionCount = objvzx_SysCountENS.CollectionCount; //收藏数量
objvzx_SysCountENT.DownloadCount = objvzx_SysCountENS.DownloadCount; //下载数
objvzx_SysCountENT.AttachmentCount = objvzx_SysCountENS.AttachmentCount; //附件计数
objvzx_SysCountENT.CommentCount = objvzx_SysCountENS.CommentCount; //评论数
objvzx_SysCountENT.Score = objvzx_SysCountENS.Score; //评分
objvzx_SysCountENT.StuScore = objvzx_SysCountENS.StuScore; //学生平均分
objvzx_SysCountENT.TeaScore = objvzx_SysCountENS.TeaScore; //教师评分
objvzx_SysCountENT.TableKey = objvzx_SysCountENS.TableKey; //表主键
objvzx_SysCountENT.ParentId = objvzx_SysCountENS.ParentId; //父Id
objvzx_SysCountENT.UpdUser = objvzx_SysCountENS.UpdUser; //修改人
objvzx_SysCountENT.UpdDate = objvzx_SysCountENS.UpdDate; //修改日期
objvzx_SysCountENT.Memo = objvzx_SysCountENS.Memo; //备注
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
 /// <param name = "objvzx_SysCountENS">源对象</param>
 /// <returns>目标对象=>clsvzx_SysCountEN:objvzx_SysCountENT</returns>
 public static clsvzx_SysCountEN CopyTo(this clsvzx_SysCountEN objvzx_SysCountENS)
{
try
{
 clsvzx_SysCountEN objvzx_SysCountENT = new clsvzx_SysCountEN()
{
CommentTypeName = objvzx_SysCountENS.CommentTypeName, //评论类型名
CommentTable = objvzx_SysCountENS.CommentTable, //评论表
zxCountId = objvzx_SysCountENS.zxCountId, //CountId
CommentTableId = objvzx_SysCountENS.CommentTableId, //评论表Id
CountTypeId = objvzx_SysCountENS.CountTypeId, //CountTypeId
PaperRWCount = objvzx_SysCountENS.PaperRWCount, //PaperRWCount
OkCount = objvzx_SysCountENS.OkCount, //点赞统计
CollectionCount = objvzx_SysCountENS.CollectionCount, //收藏数量
DownloadCount = objvzx_SysCountENS.DownloadCount, //下载数
AttachmentCount = objvzx_SysCountENS.AttachmentCount, //附件计数
CommentCount = objvzx_SysCountENS.CommentCount, //评论数
Score = objvzx_SysCountENS.Score, //评分
StuScore = objvzx_SysCountENS.StuScore, //学生平均分
TeaScore = objvzx_SysCountENS.TeaScore, //教师评分
TableKey = objvzx_SysCountENS.TableKey, //表主键
ParentId = objvzx_SysCountENS.ParentId, //父Id
UpdUser = objvzx_SysCountENS.UpdUser, //修改人
UpdDate = objvzx_SysCountENS.UpdDate, //修改日期
Memo = objvzx_SysCountENS.Memo, //备注
};
 return objvzx_SysCountENT;
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
public static void CheckProperty4Condition(this clsvzx_SysCountEN objvzx_SysCountEN)
{
 clsvzx_SysCountBL.vzx_SysCountDA.CheckProperty4Condition(objvzx_SysCountEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_SysCountEN objvzx_SysCountCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.CommentTypeName) == true)
{
string strComparisonOpCommentTypeName = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.CommentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysCount.CommentTypeName, objvzx_SysCountCond.CommentTypeName, strComparisonOpCommentTypeName);
}
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.CommentTable) == true)
{
string strComparisonOpCommentTable = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.CommentTable];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysCount.CommentTable, objvzx_SysCountCond.CommentTable, strComparisonOpCommentTable);
}
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.zxCountId) == true)
{
string strComparisonOpzxCountId = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.zxCountId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysCount.zxCountId, objvzx_SysCountCond.zxCountId, strComparisonOpzxCountId);
}
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.CommentTableId) == true)
{
string strComparisonOpCommentTableId = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.CommentTableId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysCount.CommentTableId, objvzx_SysCountCond.CommentTableId, strComparisonOpCommentTableId);
}
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.CountTypeId) == true)
{
string strComparisonOpCountTypeId = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.CountTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysCount.CountTypeId, objvzx_SysCountCond.CountTypeId, strComparisonOpCountTypeId);
}
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.PaperRWCount) == true)
{
string strComparisonOpPaperRWCount = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.PaperRWCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SysCount.PaperRWCount, objvzx_SysCountCond.PaperRWCount, strComparisonOpPaperRWCount);
}
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.OkCount) == true)
{
string strComparisonOpOkCount = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SysCount.OkCount, objvzx_SysCountCond.OkCount, strComparisonOpOkCount);
}
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SysCount.CollectionCount, objvzx_SysCountCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.DownloadCount) == true)
{
string strComparisonOpDownloadCount = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.DownloadCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SysCount.DownloadCount, objvzx_SysCountCond.DownloadCount, strComparisonOpDownloadCount);
}
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.AttachmentCount) == true)
{
string strComparisonOpAttachmentCount = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SysCount.AttachmentCount, objvzx_SysCountCond.AttachmentCount, strComparisonOpAttachmentCount);
}
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.CommentCount) == true)
{
string strComparisonOpCommentCount = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.CommentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SysCount.CommentCount, objvzx_SysCountCond.CommentCount, strComparisonOpCommentCount);
}
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.Score) == true)
{
string strComparisonOpScore = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SysCount.Score, objvzx_SysCountCond.Score, strComparisonOpScore);
}
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.StuScore) == true)
{
string strComparisonOpStuScore = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SysCount.StuScore, objvzx_SysCountCond.StuScore, strComparisonOpStuScore);
}
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.TeaScore) == true)
{
string strComparisonOpTeaScore = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SysCount.TeaScore, objvzx_SysCountCond.TeaScore, strComparisonOpTeaScore);
}
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.TableKey) == true)
{
string strComparisonOpTableKey = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysCount.TableKey, objvzx_SysCountCond.TableKey, strComparisonOpTableKey);
}
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.ParentId) == true)
{
string strComparisonOpParentId = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysCount.ParentId, objvzx_SysCountCond.ParentId, strComparisonOpParentId);
}
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysCount.UpdUser, objvzx_SysCountCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysCount.UpdDate, objvzx_SysCountCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_SysCountCond.IsUpdated(convzx_SysCount.Memo) == true)
{
string strComparisonOpMemo = objvzx_SysCountCond.dicFldComparisonOp[convzx_SysCount.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysCount.Memo, objvzx_SysCountCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_SysCount
{
public virtual bool UpdRelaTabDate(string strzxCountId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_SysCount(vzx_SysCount)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_SysCountBL
{
public static RelatedActions_vzx_SysCount relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_SysCountDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_SysCountDA vzx_SysCountDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_SysCountDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_SysCountBL()
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
if (string.IsNullOrEmpty(clsvzx_SysCountEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_SysCountEN._ConnectString);
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
public static DataTable GetDataTable_vzx_SysCount(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_SysCountDA.GetDataTable_vzx_SysCount(strWhereCond);
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
objDT = vzx_SysCountDA.GetDataTable(strWhereCond);
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
objDT = vzx_SysCountDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_SysCountDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_SysCountDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_SysCountDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_SysCountDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_SysCountDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_SysCountDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxCountIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_SysCountEN> GetObjLstByZxCountIdLst(List<string> arrZxCountIdLst)
{
List<clsvzx_SysCountEN> arrObjLst = new List<clsvzx_SysCountEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxCountIdLst, true);
 string strWhereCond = string.Format("zxCountId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCountEN objvzx_SysCountEN = new clsvzx_SysCountEN();
try
{
objvzx_SysCountEN.CommentTypeName = objRow[convzx_SysCount.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCountEN.CommentTable = objRow[convzx_SysCount.CommentTable] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTable].ToString().Trim(); //评论表
objvzx_SysCountEN.zxCountId = objRow[convzx_SysCount.zxCountId].ToString().Trim(); //CountId
objvzx_SysCountEN.CommentTableId = objRow[convzx_SysCount.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCountEN.CountTypeId = objRow[convzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[convzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvzx_SysCountEN.PaperRWCount = objRow[convzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objvzx_SysCountEN.OkCount = objRow[convzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCountEN.CollectionCount = objRow[convzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_SysCountEN.DownloadCount = objRow[convzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objvzx_SysCountEN.AttachmentCount = objRow[convzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_SysCountEN.CommentCount = objRow[convzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CommentCount].ToString().Trim()); //评论数
objvzx_SysCountEN.Score = objRow[convzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.Score].ToString().Trim()); //评分
objvzx_SysCountEN.StuScore = objRow[convzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objvzx_SysCountEN.TeaScore = objRow[convzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objvzx_SysCountEN.TableKey = objRow[convzx_SysCount.TableKey] == DBNull.Value ? null : objRow[convzx_SysCount.TableKey].ToString().Trim(); //表主键
objvzx_SysCountEN.ParentId = objRow[convzx_SysCount.ParentId] == DBNull.Value ? null : objRow[convzx_SysCount.ParentId].ToString().Trim(); //父Id
objvzx_SysCountEN.UpdUser = objRow[convzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[convzx_SysCount.UpdUser].ToString().Trim(); //修改人
objvzx_SysCountEN.UpdDate = objRow[convzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[convzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCountEN.Memo = objRow[convzx_SysCount.Memo] == DBNull.Value ? null : objRow[convzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxCountIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_SysCountEN> GetObjLstByZxCountIdLstCache(List<string> arrZxCountIdLst)
{
string strKey = string.Format("{0}", clsvzx_SysCountEN._CurrTabName);
List<clsvzx_SysCountEN> arrvzx_SysCountObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_SysCountEN> arrvzx_SysCountObjLst_Sel =
arrvzx_SysCountObjLstCache
.Where(x => arrZxCountIdLst.Contains(x.zxCountId));
return arrvzx_SysCountObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_SysCountEN> GetObjLst(string strWhereCond)
{
List<clsvzx_SysCountEN> arrObjLst = new List<clsvzx_SysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCountEN objvzx_SysCountEN = new clsvzx_SysCountEN();
try
{
objvzx_SysCountEN.CommentTypeName = objRow[convzx_SysCount.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCountEN.CommentTable = objRow[convzx_SysCount.CommentTable] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTable].ToString().Trim(); //评论表
objvzx_SysCountEN.zxCountId = objRow[convzx_SysCount.zxCountId].ToString().Trim(); //CountId
objvzx_SysCountEN.CommentTableId = objRow[convzx_SysCount.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCountEN.CountTypeId = objRow[convzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[convzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvzx_SysCountEN.PaperRWCount = objRow[convzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objvzx_SysCountEN.OkCount = objRow[convzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCountEN.CollectionCount = objRow[convzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_SysCountEN.DownloadCount = objRow[convzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objvzx_SysCountEN.AttachmentCount = objRow[convzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_SysCountEN.CommentCount = objRow[convzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CommentCount].ToString().Trim()); //评论数
objvzx_SysCountEN.Score = objRow[convzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.Score].ToString().Trim()); //评分
objvzx_SysCountEN.StuScore = objRow[convzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objvzx_SysCountEN.TeaScore = objRow[convzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objvzx_SysCountEN.TableKey = objRow[convzx_SysCount.TableKey] == DBNull.Value ? null : objRow[convzx_SysCount.TableKey].ToString().Trim(); //表主键
objvzx_SysCountEN.ParentId = objRow[convzx_SysCount.ParentId] == DBNull.Value ? null : objRow[convzx_SysCount.ParentId].ToString().Trim(); //父Id
objvzx_SysCountEN.UpdUser = objRow[convzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[convzx_SysCount.UpdUser].ToString().Trim(); //修改人
objvzx_SysCountEN.UpdDate = objRow[convzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[convzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCountEN.Memo = objRow[convzx_SysCount.Memo] == DBNull.Value ? null : objRow[convzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCountEN);
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
public static List<clsvzx_SysCountEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_SysCountEN> arrObjLst = new List<clsvzx_SysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCountEN objvzx_SysCountEN = new clsvzx_SysCountEN();
try
{
objvzx_SysCountEN.CommentTypeName = objRow[convzx_SysCount.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCountEN.CommentTable = objRow[convzx_SysCount.CommentTable] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTable].ToString().Trim(); //评论表
objvzx_SysCountEN.zxCountId = objRow[convzx_SysCount.zxCountId].ToString().Trim(); //CountId
objvzx_SysCountEN.CommentTableId = objRow[convzx_SysCount.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCountEN.CountTypeId = objRow[convzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[convzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvzx_SysCountEN.PaperRWCount = objRow[convzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objvzx_SysCountEN.OkCount = objRow[convzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCountEN.CollectionCount = objRow[convzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_SysCountEN.DownloadCount = objRow[convzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objvzx_SysCountEN.AttachmentCount = objRow[convzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_SysCountEN.CommentCount = objRow[convzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CommentCount].ToString().Trim()); //评论数
objvzx_SysCountEN.Score = objRow[convzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.Score].ToString().Trim()); //评分
objvzx_SysCountEN.StuScore = objRow[convzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objvzx_SysCountEN.TeaScore = objRow[convzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objvzx_SysCountEN.TableKey = objRow[convzx_SysCount.TableKey] == DBNull.Value ? null : objRow[convzx_SysCount.TableKey].ToString().Trim(); //表主键
objvzx_SysCountEN.ParentId = objRow[convzx_SysCount.ParentId] == DBNull.Value ? null : objRow[convzx_SysCount.ParentId].ToString().Trim(); //父Id
objvzx_SysCountEN.UpdUser = objRow[convzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[convzx_SysCount.UpdUser].ToString().Trim(); //修改人
objvzx_SysCountEN.UpdDate = objRow[convzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[convzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCountEN.Memo = objRow[convzx_SysCount.Memo] == DBNull.Value ? null : objRow[convzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_SysCountCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_SysCountEN> GetSubObjLstCache(clsvzx_SysCountEN objvzx_SysCountCond)
{
List<clsvzx_SysCountEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_SysCountEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_SysCount.AttributeName)
{
if (objvzx_SysCountCond.IsUpdated(strFldName) == false) continue;
if (objvzx_SysCountCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SysCountCond[strFldName].ToString());
}
else
{
if (objvzx_SysCountCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_SysCountCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SysCountCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_SysCountCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_SysCountCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_SysCountCond[strFldName]));
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
public static List<clsvzx_SysCountEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_SysCountEN> arrObjLst = new List<clsvzx_SysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCountEN objvzx_SysCountEN = new clsvzx_SysCountEN();
try
{
objvzx_SysCountEN.CommentTypeName = objRow[convzx_SysCount.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCountEN.CommentTable = objRow[convzx_SysCount.CommentTable] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTable].ToString().Trim(); //评论表
objvzx_SysCountEN.zxCountId = objRow[convzx_SysCount.zxCountId].ToString().Trim(); //CountId
objvzx_SysCountEN.CommentTableId = objRow[convzx_SysCount.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCountEN.CountTypeId = objRow[convzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[convzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvzx_SysCountEN.PaperRWCount = objRow[convzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objvzx_SysCountEN.OkCount = objRow[convzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCountEN.CollectionCount = objRow[convzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_SysCountEN.DownloadCount = objRow[convzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objvzx_SysCountEN.AttachmentCount = objRow[convzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_SysCountEN.CommentCount = objRow[convzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CommentCount].ToString().Trim()); //评论数
objvzx_SysCountEN.Score = objRow[convzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.Score].ToString().Trim()); //评分
objvzx_SysCountEN.StuScore = objRow[convzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objvzx_SysCountEN.TeaScore = objRow[convzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objvzx_SysCountEN.TableKey = objRow[convzx_SysCount.TableKey] == DBNull.Value ? null : objRow[convzx_SysCount.TableKey].ToString().Trim(); //表主键
objvzx_SysCountEN.ParentId = objRow[convzx_SysCount.ParentId] == DBNull.Value ? null : objRow[convzx_SysCount.ParentId].ToString().Trim(); //父Id
objvzx_SysCountEN.UpdUser = objRow[convzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[convzx_SysCount.UpdUser].ToString().Trim(); //修改人
objvzx_SysCountEN.UpdDate = objRow[convzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[convzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCountEN.Memo = objRow[convzx_SysCount.Memo] == DBNull.Value ? null : objRow[convzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCountEN);
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
public static List<clsvzx_SysCountEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_SysCountEN> arrObjLst = new List<clsvzx_SysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCountEN objvzx_SysCountEN = new clsvzx_SysCountEN();
try
{
objvzx_SysCountEN.CommentTypeName = objRow[convzx_SysCount.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCountEN.CommentTable = objRow[convzx_SysCount.CommentTable] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTable].ToString().Trim(); //评论表
objvzx_SysCountEN.zxCountId = objRow[convzx_SysCount.zxCountId].ToString().Trim(); //CountId
objvzx_SysCountEN.CommentTableId = objRow[convzx_SysCount.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCountEN.CountTypeId = objRow[convzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[convzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvzx_SysCountEN.PaperRWCount = objRow[convzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objvzx_SysCountEN.OkCount = objRow[convzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCountEN.CollectionCount = objRow[convzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_SysCountEN.DownloadCount = objRow[convzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objvzx_SysCountEN.AttachmentCount = objRow[convzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_SysCountEN.CommentCount = objRow[convzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CommentCount].ToString().Trim()); //评论数
objvzx_SysCountEN.Score = objRow[convzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.Score].ToString().Trim()); //评分
objvzx_SysCountEN.StuScore = objRow[convzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objvzx_SysCountEN.TeaScore = objRow[convzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objvzx_SysCountEN.TableKey = objRow[convzx_SysCount.TableKey] == DBNull.Value ? null : objRow[convzx_SysCount.TableKey].ToString().Trim(); //表主键
objvzx_SysCountEN.ParentId = objRow[convzx_SysCount.ParentId] == DBNull.Value ? null : objRow[convzx_SysCount.ParentId].ToString().Trim(); //父Id
objvzx_SysCountEN.UpdUser = objRow[convzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[convzx_SysCount.UpdUser].ToString().Trim(); //修改人
objvzx_SysCountEN.UpdDate = objRow[convzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[convzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCountEN.Memo = objRow[convzx_SysCount.Memo] == DBNull.Value ? null : objRow[convzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCountEN);
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
List<clsvzx_SysCountEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_SysCountEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_SysCountEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_SysCountEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_SysCountEN> arrObjLst = new List<clsvzx_SysCountEN>(); 
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
	clsvzx_SysCountEN objvzx_SysCountEN = new clsvzx_SysCountEN();
try
{
objvzx_SysCountEN.CommentTypeName = objRow[convzx_SysCount.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCountEN.CommentTable = objRow[convzx_SysCount.CommentTable] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTable].ToString().Trim(); //评论表
objvzx_SysCountEN.zxCountId = objRow[convzx_SysCount.zxCountId].ToString().Trim(); //CountId
objvzx_SysCountEN.CommentTableId = objRow[convzx_SysCount.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCountEN.CountTypeId = objRow[convzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[convzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvzx_SysCountEN.PaperRWCount = objRow[convzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objvzx_SysCountEN.OkCount = objRow[convzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCountEN.CollectionCount = objRow[convzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_SysCountEN.DownloadCount = objRow[convzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objvzx_SysCountEN.AttachmentCount = objRow[convzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_SysCountEN.CommentCount = objRow[convzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CommentCount].ToString().Trim()); //评论数
objvzx_SysCountEN.Score = objRow[convzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.Score].ToString().Trim()); //评分
objvzx_SysCountEN.StuScore = objRow[convzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objvzx_SysCountEN.TeaScore = objRow[convzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objvzx_SysCountEN.TableKey = objRow[convzx_SysCount.TableKey] == DBNull.Value ? null : objRow[convzx_SysCount.TableKey].ToString().Trim(); //表主键
objvzx_SysCountEN.ParentId = objRow[convzx_SysCount.ParentId] == DBNull.Value ? null : objRow[convzx_SysCount.ParentId].ToString().Trim(); //父Id
objvzx_SysCountEN.UpdUser = objRow[convzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[convzx_SysCount.UpdUser].ToString().Trim(); //修改人
objvzx_SysCountEN.UpdDate = objRow[convzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[convzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCountEN.Memo = objRow[convzx_SysCount.Memo] == DBNull.Value ? null : objRow[convzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCountEN);
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
public static List<clsvzx_SysCountEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_SysCountEN> arrObjLst = new List<clsvzx_SysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCountEN objvzx_SysCountEN = new clsvzx_SysCountEN();
try
{
objvzx_SysCountEN.CommentTypeName = objRow[convzx_SysCount.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCountEN.CommentTable = objRow[convzx_SysCount.CommentTable] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTable].ToString().Trim(); //评论表
objvzx_SysCountEN.zxCountId = objRow[convzx_SysCount.zxCountId].ToString().Trim(); //CountId
objvzx_SysCountEN.CommentTableId = objRow[convzx_SysCount.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCountEN.CountTypeId = objRow[convzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[convzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvzx_SysCountEN.PaperRWCount = objRow[convzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objvzx_SysCountEN.OkCount = objRow[convzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCountEN.CollectionCount = objRow[convzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_SysCountEN.DownloadCount = objRow[convzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objvzx_SysCountEN.AttachmentCount = objRow[convzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_SysCountEN.CommentCount = objRow[convzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CommentCount].ToString().Trim()); //评论数
objvzx_SysCountEN.Score = objRow[convzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.Score].ToString().Trim()); //评分
objvzx_SysCountEN.StuScore = objRow[convzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objvzx_SysCountEN.TeaScore = objRow[convzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objvzx_SysCountEN.TableKey = objRow[convzx_SysCount.TableKey] == DBNull.Value ? null : objRow[convzx_SysCount.TableKey].ToString().Trim(); //表主键
objvzx_SysCountEN.ParentId = objRow[convzx_SysCount.ParentId] == DBNull.Value ? null : objRow[convzx_SysCount.ParentId].ToString().Trim(); //父Id
objvzx_SysCountEN.UpdUser = objRow[convzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[convzx_SysCount.UpdUser].ToString().Trim(); //修改人
objvzx_SysCountEN.UpdDate = objRow[convzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[convzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCountEN.Memo = objRow[convzx_SysCount.Memo] == DBNull.Value ? null : objRow[convzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_SysCountEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_SysCountEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_SysCountEN> arrObjLst = new List<clsvzx_SysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCountEN objvzx_SysCountEN = new clsvzx_SysCountEN();
try
{
objvzx_SysCountEN.CommentTypeName = objRow[convzx_SysCount.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCountEN.CommentTable = objRow[convzx_SysCount.CommentTable] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTable].ToString().Trim(); //评论表
objvzx_SysCountEN.zxCountId = objRow[convzx_SysCount.zxCountId].ToString().Trim(); //CountId
objvzx_SysCountEN.CommentTableId = objRow[convzx_SysCount.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCountEN.CountTypeId = objRow[convzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[convzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvzx_SysCountEN.PaperRWCount = objRow[convzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objvzx_SysCountEN.OkCount = objRow[convzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCountEN.CollectionCount = objRow[convzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_SysCountEN.DownloadCount = objRow[convzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objvzx_SysCountEN.AttachmentCount = objRow[convzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_SysCountEN.CommentCount = objRow[convzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CommentCount].ToString().Trim()); //评论数
objvzx_SysCountEN.Score = objRow[convzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.Score].ToString().Trim()); //评分
objvzx_SysCountEN.StuScore = objRow[convzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objvzx_SysCountEN.TeaScore = objRow[convzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objvzx_SysCountEN.TableKey = objRow[convzx_SysCount.TableKey] == DBNull.Value ? null : objRow[convzx_SysCount.TableKey].ToString().Trim(); //表主键
objvzx_SysCountEN.ParentId = objRow[convzx_SysCount.ParentId] == DBNull.Value ? null : objRow[convzx_SysCount.ParentId].ToString().Trim(); //父Id
objvzx_SysCountEN.UpdUser = objRow[convzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[convzx_SysCount.UpdUser].ToString().Trim(); //修改人
objvzx_SysCountEN.UpdDate = objRow[convzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[convzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCountEN.Memo = objRow[convzx_SysCount.Memo] == DBNull.Value ? null : objRow[convzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCountEN);
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
public static List<clsvzx_SysCountEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_SysCountEN> arrObjLst = new List<clsvzx_SysCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCountEN objvzx_SysCountEN = new clsvzx_SysCountEN();
try
{
objvzx_SysCountEN.CommentTypeName = objRow[convzx_SysCount.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCountEN.CommentTable = objRow[convzx_SysCount.CommentTable] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTable].ToString().Trim(); //评论表
objvzx_SysCountEN.zxCountId = objRow[convzx_SysCount.zxCountId].ToString().Trim(); //CountId
objvzx_SysCountEN.CommentTableId = objRow[convzx_SysCount.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCountEN.CountTypeId = objRow[convzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[convzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvzx_SysCountEN.PaperRWCount = objRow[convzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objvzx_SysCountEN.OkCount = objRow[convzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCountEN.CollectionCount = objRow[convzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_SysCountEN.DownloadCount = objRow[convzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objvzx_SysCountEN.AttachmentCount = objRow[convzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_SysCountEN.CommentCount = objRow[convzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CommentCount].ToString().Trim()); //评论数
objvzx_SysCountEN.Score = objRow[convzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.Score].ToString().Trim()); //评分
objvzx_SysCountEN.StuScore = objRow[convzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objvzx_SysCountEN.TeaScore = objRow[convzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objvzx_SysCountEN.TableKey = objRow[convzx_SysCount.TableKey] == DBNull.Value ? null : objRow[convzx_SysCount.TableKey].ToString().Trim(); //表主键
objvzx_SysCountEN.ParentId = objRow[convzx_SysCount.ParentId] == DBNull.Value ? null : objRow[convzx_SysCount.ParentId].ToString().Trim(); //父Id
objvzx_SysCountEN.UpdUser = objRow[convzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[convzx_SysCount.UpdUser].ToString().Trim(); //修改人
objvzx_SysCountEN.UpdDate = objRow[convzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[convzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCountEN.Memo = objRow[convzx_SysCount.Memo] == DBNull.Value ? null : objRow[convzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_SysCountEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_SysCountEN> arrObjLst = new List<clsvzx_SysCountEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCountEN objvzx_SysCountEN = new clsvzx_SysCountEN();
try
{
objvzx_SysCountEN.CommentTypeName = objRow[convzx_SysCount.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCountEN.CommentTable = objRow[convzx_SysCount.CommentTable] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTable].ToString().Trim(); //评论表
objvzx_SysCountEN.zxCountId = objRow[convzx_SysCount.zxCountId].ToString().Trim(); //CountId
objvzx_SysCountEN.CommentTableId = objRow[convzx_SysCount.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysCount.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCountEN.CountTypeId = objRow[convzx_SysCount.CountTypeId] == DBNull.Value ? null : objRow[convzx_SysCount.CountTypeId].ToString().Trim(); //CountTypeId
objvzx_SysCountEN.PaperRWCount = objRow[convzx_SysCount.PaperRWCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.PaperRWCount].ToString().Trim()); //PaperRWCount
objvzx_SysCountEN.OkCount = objRow[convzx_SysCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCountEN.CollectionCount = objRow[convzx_SysCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_SysCountEN.DownloadCount = objRow[convzx_SysCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.DownloadCount].ToString().Trim()); //下载数
objvzx_SysCountEN.AttachmentCount = objRow[convzx_SysCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_SysCountEN.CommentCount = objRow[convzx_SysCount.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysCount.CommentCount].ToString().Trim()); //评论数
objvzx_SysCountEN.Score = objRow[convzx_SysCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.Score].ToString().Trim()); //评分
objvzx_SysCountEN.StuScore = objRow[convzx_SysCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.StuScore].ToString().Trim()); //学生平均分
objvzx_SysCountEN.TeaScore = objRow[convzx_SysCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysCount.TeaScore].ToString().Trim()); //教师评分
objvzx_SysCountEN.TableKey = objRow[convzx_SysCount.TableKey] == DBNull.Value ? null : objRow[convzx_SysCount.TableKey].ToString().Trim(); //表主键
objvzx_SysCountEN.ParentId = objRow[convzx_SysCount.ParentId] == DBNull.Value ? null : objRow[convzx_SysCount.ParentId].ToString().Trim(); //父Id
objvzx_SysCountEN.UpdUser = objRow[convzx_SysCount.UpdUser] == DBNull.Value ? null : objRow[convzx_SysCount.UpdUser].ToString().Trim(); //修改人
objvzx_SysCountEN.UpdDate = objRow[convzx_SysCount.UpdDate] == DBNull.Value ? null : objRow[convzx_SysCount.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCountEN.Memo = objRow[convzx_SysCount.Memo] == DBNull.Value ? null : objRow[convzx_SysCount.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCountEN.zxCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCountEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_SysCountEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_SysCount(ref clsvzx_SysCountEN objvzx_SysCountEN)
{
bool bolResult = vzx_SysCountDA.Getvzx_SysCount(ref objvzx_SysCountEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxCountId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_SysCountEN GetObjByzxCountId(string strzxCountId)
{
if (strzxCountId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxCountId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxCountId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxCountId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_SysCountEN objvzx_SysCountEN = vzx_SysCountDA.GetObjByzxCountId(strzxCountId);
return objvzx_SysCountEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_SysCountEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_SysCountEN objvzx_SysCountEN = vzx_SysCountDA.GetFirstObj(strWhereCond);
 return objvzx_SysCountEN;
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
public static clsvzx_SysCountEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_SysCountEN objvzx_SysCountEN = vzx_SysCountDA.GetObjByDataRow(objRow);
 return objvzx_SysCountEN;
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
public static clsvzx_SysCountEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_SysCountEN objvzx_SysCountEN = vzx_SysCountDA.GetObjByDataRow(objRow);
 return objvzx_SysCountEN;
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
 /// <param name = "strzxCountId">所给的关键字</param>
 /// <param name = "lstvzx_SysCountObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_SysCountEN GetObjByzxCountIdFromList(string strzxCountId, List<clsvzx_SysCountEN> lstvzx_SysCountObjLst)
{
foreach (clsvzx_SysCountEN objvzx_SysCountEN in lstvzx_SysCountObjLst)
{
if (objvzx_SysCountEN.zxCountId == strzxCountId)
{
return objvzx_SysCountEN;
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
 string strzxCountId;
 try
 {
 strzxCountId = new clsvzx_SysCountDA().GetFirstID(strWhereCond);
 return strzxCountId;
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
 arrList = vzx_SysCountDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_SysCountDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxCountId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxCountId)
{
if (string.IsNullOrEmpty(strzxCountId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxCountId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_SysCountDA.IsExist(strzxCountId);
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
 bolIsExist = clsvzx_SysCountDA.IsExistTable();
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
 bolIsExist = vzx_SysCountDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_SysCountENS">源对象</param>
 /// <param name = "objvzx_SysCountENT">目标对象</param>
 public static void CopyTo(clsvzx_SysCountEN objvzx_SysCountENS, clsvzx_SysCountEN objvzx_SysCountENT)
{
try
{
objvzx_SysCountENT.CommentTypeName = objvzx_SysCountENS.CommentTypeName; //评论类型名
objvzx_SysCountENT.CommentTable = objvzx_SysCountENS.CommentTable; //评论表
objvzx_SysCountENT.zxCountId = objvzx_SysCountENS.zxCountId; //CountId
objvzx_SysCountENT.CommentTableId = objvzx_SysCountENS.CommentTableId; //评论表Id
objvzx_SysCountENT.CountTypeId = objvzx_SysCountENS.CountTypeId; //CountTypeId
objvzx_SysCountENT.PaperRWCount = objvzx_SysCountENS.PaperRWCount; //PaperRWCount
objvzx_SysCountENT.OkCount = objvzx_SysCountENS.OkCount; //点赞统计
objvzx_SysCountENT.CollectionCount = objvzx_SysCountENS.CollectionCount; //收藏数量
objvzx_SysCountENT.DownloadCount = objvzx_SysCountENS.DownloadCount; //下载数
objvzx_SysCountENT.AttachmentCount = objvzx_SysCountENS.AttachmentCount; //附件计数
objvzx_SysCountENT.CommentCount = objvzx_SysCountENS.CommentCount; //评论数
objvzx_SysCountENT.Score = objvzx_SysCountENS.Score; //评分
objvzx_SysCountENT.StuScore = objvzx_SysCountENS.StuScore; //学生平均分
objvzx_SysCountENT.TeaScore = objvzx_SysCountENS.TeaScore; //教师评分
objvzx_SysCountENT.TableKey = objvzx_SysCountENS.TableKey; //表主键
objvzx_SysCountENT.ParentId = objvzx_SysCountENS.ParentId; //父Id
objvzx_SysCountENT.UpdUser = objvzx_SysCountENS.UpdUser; //修改人
objvzx_SysCountENT.UpdDate = objvzx_SysCountENS.UpdDate; //修改日期
objvzx_SysCountENT.Memo = objvzx_SysCountENS.Memo; //备注
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
 /// <param name = "objvzx_SysCountEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_SysCountEN objvzx_SysCountEN)
{
try
{
objvzx_SysCountEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_SysCountEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_SysCount.CommentTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.CommentTypeName = objvzx_SysCountEN.CommentTypeName == "[null]" ? null :  objvzx_SysCountEN.CommentTypeName; //评论类型名
}
if (arrFldSet.Contains(convzx_SysCount.CommentTable, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.CommentTable = objvzx_SysCountEN.CommentTable == "[null]" ? null :  objvzx_SysCountEN.CommentTable; //评论表
}
if (arrFldSet.Contains(convzx_SysCount.zxCountId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.zxCountId = objvzx_SysCountEN.zxCountId; //CountId
}
if (arrFldSet.Contains(convzx_SysCount.CommentTableId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.CommentTableId = objvzx_SysCountEN.CommentTableId == "[null]" ? null :  objvzx_SysCountEN.CommentTableId; //评论表Id
}
if (arrFldSet.Contains(convzx_SysCount.CountTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.CountTypeId = objvzx_SysCountEN.CountTypeId == "[null]" ? null :  objvzx_SysCountEN.CountTypeId; //CountTypeId
}
if (arrFldSet.Contains(convzx_SysCount.PaperRWCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.PaperRWCount = objvzx_SysCountEN.PaperRWCount; //PaperRWCount
}
if (arrFldSet.Contains(convzx_SysCount.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.OkCount = objvzx_SysCountEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convzx_SysCount.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.CollectionCount = objvzx_SysCountEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convzx_SysCount.DownloadCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.DownloadCount = objvzx_SysCountEN.DownloadCount; //下载数
}
if (arrFldSet.Contains(convzx_SysCount.AttachmentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.AttachmentCount = objvzx_SysCountEN.AttachmentCount; //附件计数
}
if (arrFldSet.Contains(convzx_SysCount.CommentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.CommentCount = objvzx_SysCountEN.CommentCount; //评论数
}
if (arrFldSet.Contains(convzx_SysCount.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.Score = objvzx_SysCountEN.Score; //评分
}
if (arrFldSet.Contains(convzx_SysCount.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.StuScore = objvzx_SysCountEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convzx_SysCount.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.TeaScore = objvzx_SysCountEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convzx_SysCount.TableKey, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.TableKey = objvzx_SysCountEN.TableKey == "[null]" ? null :  objvzx_SysCountEN.TableKey; //表主键
}
if (arrFldSet.Contains(convzx_SysCount.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.ParentId = objvzx_SysCountEN.ParentId == "[null]" ? null :  objvzx_SysCountEN.ParentId; //父Id
}
if (arrFldSet.Contains(convzx_SysCount.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.UpdUser = objvzx_SysCountEN.UpdUser == "[null]" ? null :  objvzx_SysCountEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_SysCount.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.UpdDate = objvzx_SysCountEN.UpdDate == "[null]" ? null :  objvzx_SysCountEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_SysCount.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCountEN.Memo = objvzx_SysCountEN.Memo == "[null]" ? null :  objvzx_SysCountEN.Memo; //备注
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
 /// <param name = "objvzx_SysCountEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_SysCountEN objvzx_SysCountEN)
{
try
{
if (objvzx_SysCountEN.CommentTypeName == "[null]") objvzx_SysCountEN.CommentTypeName = null; //评论类型名
if (objvzx_SysCountEN.CommentTable == "[null]") objvzx_SysCountEN.CommentTable = null; //评论表
if (objvzx_SysCountEN.CommentTableId == "[null]") objvzx_SysCountEN.CommentTableId = null; //评论表Id
if (objvzx_SysCountEN.CountTypeId == "[null]") objvzx_SysCountEN.CountTypeId = null; //CountTypeId
if (objvzx_SysCountEN.TableKey == "[null]") objvzx_SysCountEN.TableKey = null; //表主键
if (objvzx_SysCountEN.ParentId == "[null]") objvzx_SysCountEN.ParentId = null; //父Id
if (objvzx_SysCountEN.UpdUser == "[null]") objvzx_SysCountEN.UpdUser = null; //修改人
if (objvzx_SysCountEN.UpdDate == "[null]") objvzx_SysCountEN.UpdDate = null; //修改日期
if (objvzx_SysCountEN.Memo == "[null]") objvzx_SysCountEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvzx_SysCountEN objvzx_SysCountEN)
{
 vzx_SysCountDA.CheckProperty4Condition(objvzx_SysCountEN);
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
if (clszx_SysCommentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SysCommentTypeBL没有刷新缓存机制(clszx_SysCommentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_SysCountBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SysCountBL没有刷新缓存机制(clszx_SysCountBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxCountId");
//if (arrvzx_SysCountObjLstCache == null)
//{
//arrvzx_SysCountObjLstCache = vzx_SysCountDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxCountId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_SysCountEN GetObjByzxCountIdCache(string strzxCountId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvzx_SysCountEN._CurrTabName);
List<clsvzx_SysCountEN> arrvzx_SysCountObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_SysCountEN> arrvzx_SysCountObjLst_Sel =
arrvzx_SysCountObjLstCache
.Where(x=> x.zxCountId == strzxCountId 
);
if (arrvzx_SysCountObjLst_Sel.Count() == 0)
{
   clsvzx_SysCountEN obj = clsvzx_SysCountBL.GetObjByzxCountId(strzxCountId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvzx_SysCountObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_SysCountEN> GetAllvzx_SysCountObjLstCache()
{
//获取缓存中的对象列表
List<clsvzx_SysCountEN> arrvzx_SysCountObjLstCache = GetObjLstCache(); 
return arrvzx_SysCountObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_SysCountEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvzx_SysCountEN._CurrTabName);
List<clsvzx_SysCountEN> arrvzx_SysCountObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvzx_SysCountObjLstCache;
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
string strKey = string.Format("{0}", clsvzx_SysCountEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strzxCountId)
{
if (strInFldName != convzx_SysCount.zxCountId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_SysCount.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_SysCount.AttributeName));
throw new Exception(strMsg);
}
var objvzx_SysCount = clsvzx_SysCountBL.GetObjByzxCountIdCache(strzxCountId);
if (objvzx_SysCount == null) return "";
return objvzx_SysCount[strOutFldName].ToString();
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
int intRecCount = clsvzx_SysCountDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_SysCountDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_SysCountDA.GetRecCount();
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
int intRecCount = clsvzx_SysCountDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_SysCountCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_SysCountEN objvzx_SysCountCond)
{
List<clsvzx_SysCountEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_SysCountEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_SysCount.AttributeName)
{
if (objvzx_SysCountCond.IsUpdated(strFldName) == false) continue;
if (objvzx_SysCountCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SysCountCond[strFldName].ToString());
}
else
{
if (objvzx_SysCountCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_SysCountCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SysCountCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_SysCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_SysCountCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_SysCountCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_SysCountCond[strFldName]));
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
 List<string> arrList = clsvzx_SysCountDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_SysCountDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_SysCountDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}