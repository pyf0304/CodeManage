
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SysCommentBL
 表名:vzx_SysComment(01120836)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:14
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
public static class  clsvzx_SysCommentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxCommentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_SysCommentEN GetObj(this K_zxCommentId_vzx_SysComment myKey)
{
clsvzx_SysCommentEN objvzx_SysCommentEN = clsvzx_SysCommentBL.vzx_SysCommentDA.GetObjByzxCommentId(myKey.Value);
return objvzx_SysCommentEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetCommentTypeName(this clsvzx_SysCommentEN objvzx_SysCommentEN, string strCommentTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentTypeName, 50, convzx_SysComment.CommentTypeName);
}
objvzx_SysCommentEN.CommentTypeName = strCommentTypeName; //评论类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.CommentTypeName) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.CommentTypeName, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.CommentTypeName] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetzxCommentId(this clsvzx_SysCommentEN objvzx_SysCommentEN, string strzxCommentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxCommentId, 10, convzx_SysComment.zxCommentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxCommentId, 10, convzx_SysComment.zxCommentId);
}
objvzx_SysCommentEN.zxCommentId = strzxCommentId; //评论Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.zxCommentId) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.zxCommentId, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.zxCommentId] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetCommentTable(this clsvzx_SysCommentEN objvzx_SysCommentEN, string strCommentTable, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentTable, 50, convzx_SysComment.CommentTable);
}
objvzx_SysCommentEN.CommentTable = strCommentTable; //评论表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.CommentTable) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.CommentTable, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.CommentTable] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetComment(this clsvzx_SysCommentEN objvzx_SysCommentEN, string strComment, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strComment, 2000, convzx_SysComment.Comment);
}
objvzx_SysCommentEN.Comment = strComment; //评论
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.Comment) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.Comment, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.Comment] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetCommentTableId(this clsvzx_SysCommentEN objvzx_SysCommentEN, string strCommentTableId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentTableId, 50, convzx_SysComment.CommentTableId);
}
objvzx_SysCommentEN.CommentTableId = strCommentTableId; //评论表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.CommentTableId) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.CommentTableId, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.CommentTableId] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetScore(this clsvzx_SysCommentEN objvzx_SysCommentEN, float? fltScore, string strComparisonOp="")
	{
objvzx_SysCommentEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.Score) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.Score, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.Score] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetzxCommentTypeId(this clsvzx_SysCommentEN objvzx_SysCommentEN, string strzxCommentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxCommentTypeId, convzx_SysComment.zxCommentTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxCommentTypeId, 2, convzx_SysComment.zxCommentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxCommentTypeId, 2, convzx_SysComment.zxCommentTypeId);
}
objvzx_SysCommentEN.zxCommentTypeId = strzxCommentTypeId; //评论类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.zxCommentTypeId) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.zxCommentTypeId, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.zxCommentTypeId] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetScoreType(this clsvzx_SysCommentEN objvzx_SysCommentEN, string strScoreType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreType, 1, convzx_SysComment.ScoreType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strScoreType, 1, convzx_SysComment.ScoreType);
}
objvzx_SysCommentEN.ScoreType = strScoreType; //评分类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.ScoreType) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.ScoreType, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.ScoreType] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetParentId(this clsvzx_SysCommentEN objvzx_SysCommentEN, string strParentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParentId, convzx_SysComment.ParentId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 20, convzx_SysComment.ParentId);
}
objvzx_SysCommentEN.ParentId = strParentId; //父Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.ParentId) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.ParentId, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.ParentId] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetTableKey(this clsvzx_SysCommentEN objvzx_SysCommentEN, string strTableKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableKey, 20, convzx_SysComment.TableKey);
}
objvzx_SysCommentEN.TableKey = strTableKey; //表主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.TableKey) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.TableKey, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.TableKey] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetUpdUser(this clsvzx_SysCommentEN objvzx_SysCommentEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_SysComment.UpdUser);
}
objvzx_SysCommentEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.UpdUser) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.UpdUser, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.UpdUser] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetUpdDate(this clsvzx_SysCommentEN objvzx_SysCommentEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_SysComment.UpdDate);
}
objvzx_SysCommentEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.UpdDate) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.UpdDate, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.UpdDate] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetMemo(this clsvzx_SysCommentEN objvzx_SysCommentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_SysComment.Memo);
}
objvzx_SysCommentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.Memo) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.Memo, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.Memo] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetOkCount(this clsvzx_SysCommentEN objvzx_SysCommentEN, int? intOkCount, string strComparisonOp="")
	{
objvzx_SysCommentEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.OkCount) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.OkCount, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.OkCount] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetPubParentId(this clsvzx_SysCommentEN objvzx_SysCommentEN, string strPubParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubParentId, 20, convzx_SysComment.PubParentId);
}
objvzx_SysCommentEN.PubParentId = strPubParentId; //公共父Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.PubParentId) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.PubParentId, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.PubParentId] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetIdCurrEduCls(this clsvzx_SysCommentEN objvzx_SysCommentEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_SysComment.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_SysComment.IdCurrEduCls);
}
objvzx_SysCommentEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.IdCurrEduCls) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetUserId(this clsvzx_SysCommentEN objvzx_SysCommentEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convzx_SysComment.UserId);
}
objvzx_SysCommentEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.UserId) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.UserId, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.UserId] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetMonth(this clsvzx_SysCommentEN objvzx_SysCommentEN, int? intMonth, string strComparisonOp="")
	{
objvzx_SysCommentEN.Month = intMonth; //月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.Month) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.Month, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.Month] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetWeek(this clsvzx_SysCommentEN objvzx_SysCommentEN, int? intWeek, string strComparisonOp="")
	{
objvzx_SysCommentEN.Week = intWeek; //周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.Week) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.Week, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.Week] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysCommentEN SetWeekTimeRange(this clsvzx_SysCommentEN objvzx_SysCommentEN, string strWeekTimeRange, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWeekTimeRange, 100, convzx_SysComment.WeekTimeRange);
}
objvzx_SysCommentEN.WeekTimeRange = strWeekTimeRange; //WeekTimeRange
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysCommentEN.dicFldComparisonOp.ContainsKey(convzx_SysComment.WeekTimeRange) == false)
{
objvzx_SysCommentEN.dicFldComparisonOp.Add(convzx_SysComment.WeekTimeRange, strComparisonOp);
}
else
{
objvzx_SysCommentEN.dicFldComparisonOp[convzx_SysComment.WeekTimeRange] = strComparisonOp;
}
}
return objvzx_SysCommentEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_SysCommentENS">源对象</param>
 /// <param name = "objvzx_SysCommentENT">目标对象</param>
 public static void CopyTo(this clsvzx_SysCommentEN objvzx_SysCommentENS, clsvzx_SysCommentEN objvzx_SysCommentENT)
{
try
{
objvzx_SysCommentENT.CommentTypeName = objvzx_SysCommentENS.CommentTypeName; //评论类型名
objvzx_SysCommentENT.zxCommentId = objvzx_SysCommentENS.zxCommentId; //评论Id
objvzx_SysCommentENT.CommentTable = objvzx_SysCommentENS.CommentTable; //评论表
objvzx_SysCommentENT.Comment = objvzx_SysCommentENS.Comment; //评论
objvzx_SysCommentENT.CommentTableId = objvzx_SysCommentENS.CommentTableId; //评论表Id
objvzx_SysCommentENT.Score = objvzx_SysCommentENS.Score; //评分
objvzx_SysCommentENT.zxCommentTypeId = objvzx_SysCommentENS.zxCommentTypeId; //评论类型Id
objvzx_SysCommentENT.ScoreType = objvzx_SysCommentENS.ScoreType; //评分类型
objvzx_SysCommentENT.ParentId = objvzx_SysCommentENS.ParentId; //父Id
objvzx_SysCommentENT.TableKey = objvzx_SysCommentENS.TableKey; //表主键
objvzx_SysCommentENT.UpdUser = objvzx_SysCommentENS.UpdUser; //修改人
objvzx_SysCommentENT.UpdDate = objvzx_SysCommentENS.UpdDate; //修改日期
objvzx_SysCommentENT.Memo = objvzx_SysCommentENS.Memo; //备注
objvzx_SysCommentENT.OkCount = objvzx_SysCommentENS.OkCount; //点赞统计
objvzx_SysCommentENT.PubParentId = objvzx_SysCommentENS.PubParentId; //公共父Id
objvzx_SysCommentENT.IdCurrEduCls = objvzx_SysCommentENS.IdCurrEduCls; //教学班流水号
objvzx_SysCommentENT.UserId = objvzx_SysCommentENS.UserId; //用户ID
objvzx_SysCommentENT.Month = objvzx_SysCommentENS.Month; //月
objvzx_SysCommentENT.Week = objvzx_SysCommentENS.Week; //周
objvzx_SysCommentENT.WeekTimeRange = objvzx_SysCommentENS.WeekTimeRange; //WeekTimeRange
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
 /// <param name = "objvzx_SysCommentENS">源对象</param>
 /// <returns>目标对象=>clsvzx_SysCommentEN:objvzx_SysCommentENT</returns>
 public static clsvzx_SysCommentEN CopyTo(this clsvzx_SysCommentEN objvzx_SysCommentENS)
{
try
{
 clsvzx_SysCommentEN objvzx_SysCommentENT = new clsvzx_SysCommentEN()
{
CommentTypeName = objvzx_SysCommentENS.CommentTypeName, //评论类型名
zxCommentId = objvzx_SysCommentENS.zxCommentId, //评论Id
CommentTable = objvzx_SysCommentENS.CommentTable, //评论表
Comment = objvzx_SysCommentENS.Comment, //评论
CommentTableId = objvzx_SysCommentENS.CommentTableId, //评论表Id
Score = objvzx_SysCommentENS.Score, //评分
zxCommentTypeId = objvzx_SysCommentENS.zxCommentTypeId, //评论类型Id
ScoreType = objvzx_SysCommentENS.ScoreType, //评分类型
ParentId = objvzx_SysCommentENS.ParentId, //父Id
TableKey = objvzx_SysCommentENS.TableKey, //表主键
UpdUser = objvzx_SysCommentENS.UpdUser, //修改人
UpdDate = objvzx_SysCommentENS.UpdDate, //修改日期
Memo = objvzx_SysCommentENS.Memo, //备注
OkCount = objvzx_SysCommentENS.OkCount, //点赞统计
PubParentId = objvzx_SysCommentENS.PubParentId, //公共父Id
IdCurrEduCls = objvzx_SysCommentENS.IdCurrEduCls, //教学班流水号
UserId = objvzx_SysCommentENS.UserId, //用户ID
Month = objvzx_SysCommentENS.Month, //月
Week = objvzx_SysCommentENS.Week, //周
WeekTimeRange = objvzx_SysCommentENS.WeekTimeRange, //WeekTimeRange
};
 return objvzx_SysCommentENT;
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
public static void CheckProperty4Condition(this clsvzx_SysCommentEN objvzx_SysCommentEN)
{
 clsvzx_SysCommentBL.vzx_SysCommentDA.CheckProperty4Condition(objvzx_SysCommentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_SysCommentEN objvzx_SysCommentCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.CommentTypeName) == true)
{
string strComparisonOpCommentTypeName = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.CommentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysComment.CommentTypeName, objvzx_SysCommentCond.CommentTypeName, strComparisonOpCommentTypeName);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.zxCommentId) == true)
{
string strComparisonOpzxCommentId = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.zxCommentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysComment.zxCommentId, objvzx_SysCommentCond.zxCommentId, strComparisonOpzxCommentId);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.CommentTable) == true)
{
string strComparisonOpCommentTable = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.CommentTable];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysComment.CommentTable, objvzx_SysCommentCond.CommentTable, strComparisonOpCommentTable);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.Comment) == true)
{
string strComparisonOpComment = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.Comment];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysComment.Comment, objvzx_SysCommentCond.Comment, strComparisonOpComment);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.CommentTableId) == true)
{
string strComparisonOpCommentTableId = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.CommentTableId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysComment.CommentTableId, objvzx_SysCommentCond.CommentTableId, strComparisonOpCommentTableId);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.Score) == true)
{
string strComparisonOpScore = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SysComment.Score, objvzx_SysCommentCond.Score, strComparisonOpScore);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.zxCommentTypeId) == true)
{
string strComparisonOpzxCommentTypeId = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.zxCommentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysComment.zxCommentTypeId, objvzx_SysCommentCond.zxCommentTypeId, strComparisonOpzxCommentTypeId);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.ScoreType) == true)
{
string strComparisonOpScoreType = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysComment.ScoreType, objvzx_SysCommentCond.ScoreType, strComparisonOpScoreType);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.ParentId) == true)
{
string strComparisonOpParentId = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysComment.ParentId, objvzx_SysCommentCond.ParentId, strComparisonOpParentId);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.TableKey) == true)
{
string strComparisonOpTableKey = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysComment.TableKey, objvzx_SysCommentCond.TableKey, strComparisonOpTableKey);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysComment.UpdUser, objvzx_SysCommentCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysComment.UpdDate, objvzx_SysCommentCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.Memo) == true)
{
string strComparisonOpMemo = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysComment.Memo, objvzx_SysCommentCond.Memo, strComparisonOpMemo);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.OkCount) == true)
{
string strComparisonOpOkCount = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SysComment.OkCount, objvzx_SysCommentCond.OkCount, strComparisonOpOkCount);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.PubParentId) == true)
{
string strComparisonOpPubParentId = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.PubParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysComment.PubParentId, objvzx_SysCommentCond.PubParentId, strComparisonOpPubParentId);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysComment.IdCurrEduCls, objvzx_SysCommentCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.UserId) == true)
{
string strComparisonOpUserId = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysComment.UserId, objvzx_SysCommentCond.UserId, strComparisonOpUserId);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.Month) == true)
{
string strComparisonOpMonth = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.Month];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SysComment.Month, objvzx_SysCommentCond.Month, strComparisonOpMonth);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.Week) == true)
{
string strComparisonOpWeek = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.Week];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SysComment.Week, objvzx_SysCommentCond.Week, strComparisonOpWeek);
}
if (objvzx_SysCommentCond.IsUpdated(convzx_SysComment.WeekTimeRange) == true)
{
string strComparisonOpWeekTimeRange = objvzx_SysCommentCond.dicFldComparisonOp[convzx_SysComment.WeekTimeRange];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysComment.WeekTimeRange, objvzx_SysCommentCond.WeekTimeRange, strComparisonOpWeekTimeRange);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_SysComment
{
public virtual bool UpdRelaTabDate(string strzxCommentId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_SysComment(vzx_SysComment)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_SysCommentBL
{
public static RelatedActions_vzx_SysComment relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_SysCommentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_SysCommentDA vzx_SysCommentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_SysCommentDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_SysCommentBL()
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
if (string.IsNullOrEmpty(clsvzx_SysCommentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_SysCommentEN._ConnectString);
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
public static DataTable GetDataTable_vzx_SysComment(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_SysCommentDA.GetDataTable_vzx_SysComment(strWhereCond);
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
objDT = vzx_SysCommentDA.GetDataTable(strWhereCond);
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
objDT = vzx_SysCommentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_SysCommentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_SysCommentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_SysCommentDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_SysCommentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_SysCommentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_SysCommentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxCommentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_SysCommentEN> GetObjLstByZxCommentIdLst(List<string> arrZxCommentIdLst)
{
List<clsvzx_SysCommentEN> arrObjLst = new List<clsvzx_SysCommentEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxCommentIdLst, true);
 string strWhereCond = string.Format("zxCommentId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCommentEN objvzx_SysCommentEN = new clsvzx_SysCommentEN();
try
{
objvzx_SysCommentEN.CommentTypeName = objRow[convzx_SysComment.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCommentEN.zxCommentId = objRow[convzx_SysComment.zxCommentId].ToString().Trim(); //评论Id
objvzx_SysCommentEN.CommentTable = objRow[convzx_SysComment.CommentTable] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTable].ToString().Trim(); //评论表
objvzx_SysCommentEN.Comment = objRow[convzx_SysComment.Comment] == DBNull.Value ? null : objRow[convzx_SysComment.Comment].ToString().Trim(); //评论
objvzx_SysCommentEN.CommentTableId = objRow[convzx_SysComment.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCommentEN.Score = objRow[convzx_SysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysComment.Score].ToString().Trim()); //评分
objvzx_SysCommentEN.zxCommentTypeId = objRow[convzx_SysComment.zxCommentTypeId].ToString().Trim(); //评论类型Id
objvzx_SysCommentEN.ScoreType = objRow[convzx_SysComment.ScoreType] == DBNull.Value ? null : objRow[convzx_SysComment.ScoreType].ToString().Trim(); //评分类型
objvzx_SysCommentEN.ParentId = objRow[convzx_SysComment.ParentId].ToString().Trim(); //父Id
objvzx_SysCommentEN.TableKey = objRow[convzx_SysComment.TableKey] == DBNull.Value ? null : objRow[convzx_SysComment.TableKey].ToString().Trim(); //表主键
objvzx_SysCommentEN.UpdUser = objRow[convzx_SysComment.UpdUser] == DBNull.Value ? null : objRow[convzx_SysComment.UpdUser].ToString().Trim(); //修改人
objvzx_SysCommentEN.UpdDate = objRow[convzx_SysComment.UpdDate] == DBNull.Value ? null : objRow[convzx_SysComment.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCommentEN.Memo = objRow[convzx_SysComment.Memo] == DBNull.Value ? null : objRow[convzx_SysComment.Memo].ToString().Trim(); //备注
objvzx_SysCommentEN.OkCount = objRow[convzx_SysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCommentEN.PubParentId = objRow[convzx_SysComment.PubParentId] == DBNull.Value ? null : objRow[convzx_SysComment.PubParentId].ToString().Trim(); //公共父Id
objvzx_SysCommentEN.IdCurrEduCls = objRow[convzx_SysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysCommentEN.UserId = objRow[convzx_SysComment.UserId] == DBNull.Value ? null : objRow[convzx_SysComment.UserId].ToString().Trim(); //用户ID
objvzx_SysCommentEN.Month = objRow[convzx_SysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Month].ToString().Trim()); //月
objvzx_SysCommentEN.Week = objRow[convzx_SysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Week].ToString().Trim()); //周
objvzx_SysCommentEN.WeekTimeRange = objRow[convzx_SysComment.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_SysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCommentEN.zxCommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCommentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxCommentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_SysCommentEN> GetObjLstByZxCommentIdLstCache(List<string> arrZxCommentIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvzx_SysCommentEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_SysCommentEN> arrvzx_SysCommentObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_SysCommentEN> arrvzx_SysCommentObjLst_Sel =
arrvzx_SysCommentObjLstCache
.Where(x => arrZxCommentIdLst.Contains(x.zxCommentId));
return arrvzx_SysCommentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_SysCommentEN> GetObjLst(string strWhereCond)
{
List<clsvzx_SysCommentEN> arrObjLst = new List<clsvzx_SysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCommentEN objvzx_SysCommentEN = new clsvzx_SysCommentEN();
try
{
objvzx_SysCommentEN.CommentTypeName = objRow[convzx_SysComment.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCommentEN.zxCommentId = objRow[convzx_SysComment.zxCommentId].ToString().Trim(); //评论Id
objvzx_SysCommentEN.CommentTable = objRow[convzx_SysComment.CommentTable] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTable].ToString().Trim(); //评论表
objvzx_SysCommentEN.Comment = objRow[convzx_SysComment.Comment] == DBNull.Value ? null : objRow[convzx_SysComment.Comment].ToString().Trim(); //评论
objvzx_SysCommentEN.CommentTableId = objRow[convzx_SysComment.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCommentEN.Score = objRow[convzx_SysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysComment.Score].ToString().Trim()); //评分
objvzx_SysCommentEN.zxCommentTypeId = objRow[convzx_SysComment.zxCommentTypeId].ToString().Trim(); //评论类型Id
objvzx_SysCommentEN.ScoreType = objRow[convzx_SysComment.ScoreType] == DBNull.Value ? null : objRow[convzx_SysComment.ScoreType].ToString().Trim(); //评分类型
objvzx_SysCommentEN.ParentId = objRow[convzx_SysComment.ParentId].ToString().Trim(); //父Id
objvzx_SysCommentEN.TableKey = objRow[convzx_SysComment.TableKey] == DBNull.Value ? null : objRow[convzx_SysComment.TableKey].ToString().Trim(); //表主键
objvzx_SysCommentEN.UpdUser = objRow[convzx_SysComment.UpdUser] == DBNull.Value ? null : objRow[convzx_SysComment.UpdUser].ToString().Trim(); //修改人
objvzx_SysCommentEN.UpdDate = objRow[convzx_SysComment.UpdDate] == DBNull.Value ? null : objRow[convzx_SysComment.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCommentEN.Memo = objRow[convzx_SysComment.Memo] == DBNull.Value ? null : objRow[convzx_SysComment.Memo].ToString().Trim(); //备注
objvzx_SysCommentEN.OkCount = objRow[convzx_SysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCommentEN.PubParentId = objRow[convzx_SysComment.PubParentId] == DBNull.Value ? null : objRow[convzx_SysComment.PubParentId].ToString().Trim(); //公共父Id
objvzx_SysCommentEN.IdCurrEduCls = objRow[convzx_SysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysCommentEN.UserId = objRow[convzx_SysComment.UserId] == DBNull.Value ? null : objRow[convzx_SysComment.UserId].ToString().Trim(); //用户ID
objvzx_SysCommentEN.Month = objRow[convzx_SysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Month].ToString().Trim()); //月
objvzx_SysCommentEN.Week = objRow[convzx_SysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Week].ToString().Trim()); //周
objvzx_SysCommentEN.WeekTimeRange = objRow[convzx_SysComment.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_SysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCommentEN.zxCommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCommentEN);
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
public static List<clsvzx_SysCommentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_SysCommentEN> arrObjLst = new List<clsvzx_SysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCommentEN objvzx_SysCommentEN = new clsvzx_SysCommentEN();
try
{
objvzx_SysCommentEN.CommentTypeName = objRow[convzx_SysComment.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCommentEN.zxCommentId = objRow[convzx_SysComment.zxCommentId].ToString().Trim(); //评论Id
objvzx_SysCommentEN.CommentTable = objRow[convzx_SysComment.CommentTable] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTable].ToString().Trim(); //评论表
objvzx_SysCommentEN.Comment = objRow[convzx_SysComment.Comment] == DBNull.Value ? null : objRow[convzx_SysComment.Comment].ToString().Trim(); //评论
objvzx_SysCommentEN.CommentTableId = objRow[convzx_SysComment.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCommentEN.Score = objRow[convzx_SysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysComment.Score].ToString().Trim()); //评分
objvzx_SysCommentEN.zxCommentTypeId = objRow[convzx_SysComment.zxCommentTypeId].ToString().Trim(); //评论类型Id
objvzx_SysCommentEN.ScoreType = objRow[convzx_SysComment.ScoreType] == DBNull.Value ? null : objRow[convzx_SysComment.ScoreType].ToString().Trim(); //评分类型
objvzx_SysCommentEN.ParentId = objRow[convzx_SysComment.ParentId].ToString().Trim(); //父Id
objvzx_SysCommentEN.TableKey = objRow[convzx_SysComment.TableKey] == DBNull.Value ? null : objRow[convzx_SysComment.TableKey].ToString().Trim(); //表主键
objvzx_SysCommentEN.UpdUser = objRow[convzx_SysComment.UpdUser] == DBNull.Value ? null : objRow[convzx_SysComment.UpdUser].ToString().Trim(); //修改人
objvzx_SysCommentEN.UpdDate = objRow[convzx_SysComment.UpdDate] == DBNull.Value ? null : objRow[convzx_SysComment.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCommentEN.Memo = objRow[convzx_SysComment.Memo] == DBNull.Value ? null : objRow[convzx_SysComment.Memo].ToString().Trim(); //备注
objvzx_SysCommentEN.OkCount = objRow[convzx_SysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCommentEN.PubParentId = objRow[convzx_SysComment.PubParentId] == DBNull.Value ? null : objRow[convzx_SysComment.PubParentId].ToString().Trim(); //公共父Id
objvzx_SysCommentEN.IdCurrEduCls = objRow[convzx_SysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysCommentEN.UserId = objRow[convzx_SysComment.UserId] == DBNull.Value ? null : objRow[convzx_SysComment.UserId].ToString().Trim(); //用户ID
objvzx_SysCommentEN.Month = objRow[convzx_SysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Month].ToString().Trim()); //月
objvzx_SysCommentEN.Week = objRow[convzx_SysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Week].ToString().Trim()); //周
objvzx_SysCommentEN.WeekTimeRange = objRow[convzx_SysComment.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_SysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCommentEN.zxCommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCommentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_SysCommentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_SysCommentEN> GetSubObjLstCache(clsvzx_SysCommentEN objvzx_SysCommentCond)
{
 string strIdCurrEduCls = objvzx_SysCommentCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvzx_SysCommentBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvzx_SysCommentEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_SysCommentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_SysComment.AttributeName)
{
if (objvzx_SysCommentCond.IsUpdated(strFldName) == false) continue;
if (objvzx_SysCommentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SysCommentCond[strFldName].ToString());
}
else
{
if (objvzx_SysCommentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_SysCommentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SysCommentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_SysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_SysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_SysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_SysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_SysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_SysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_SysCommentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_SysCommentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_SysCommentCond[strFldName]));
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
public static List<clsvzx_SysCommentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_SysCommentEN> arrObjLst = new List<clsvzx_SysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCommentEN objvzx_SysCommentEN = new clsvzx_SysCommentEN();
try
{
objvzx_SysCommentEN.CommentTypeName = objRow[convzx_SysComment.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCommentEN.zxCommentId = objRow[convzx_SysComment.zxCommentId].ToString().Trim(); //评论Id
objvzx_SysCommentEN.CommentTable = objRow[convzx_SysComment.CommentTable] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTable].ToString().Trim(); //评论表
objvzx_SysCommentEN.Comment = objRow[convzx_SysComment.Comment] == DBNull.Value ? null : objRow[convzx_SysComment.Comment].ToString().Trim(); //评论
objvzx_SysCommentEN.CommentTableId = objRow[convzx_SysComment.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCommentEN.Score = objRow[convzx_SysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysComment.Score].ToString().Trim()); //评分
objvzx_SysCommentEN.zxCommentTypeId = objRow[convzx_SysComment.zxCommentTypeId].ToString().Trim(); //评论类型Id
objvzx_SysCommentEN.ScoreType = objRow[convzx_SysComment.ScoreType] == DBNull.Value ? null : objRow[convzx_SysComment.ScoreType].ToString().Trim(); //评分类型
objvzx_SysCommentEN.ParentId = objRow[convzx_SysComment.ParentId].ToString().Trim(); //父Id
objvzx_SysCommentEN.TableKey = objRow[convzx_SysComment.TableKey] == DBNull.Value ? null : objRow[convzx_SysComment.TableKey].ToString().Trim(); //表主键
objvzx_SysCommentEN.UpdUser = objRow[convzx_SysComment.UpdUser] == DBNull.Value ? null : objRow[convzx_SysComment.UpdUser].ToString().Trim(); //修改人
objvzx_SysCommentEN.UpdDate = objRow[convzx_SysComment.UpdDate] == DBNull.Value ? null : objRow[convzx_SysComment.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCommentEN.Memo = objRow[convzx_SysComment.Memo] == DBNull.Value ? null : objRow[convzx_SysComment.Memo].ToString().Trim(); //备注
objvzx_SysCommentEN.OkCount = objRow[convzx_SysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCommentEN.PubParentId = objRow[convzx_SysComment.PubParentId] == DBNull.Value ? null : objRow[convzx_SysComment.PubParentId].ToString().Trim(); //公共父Id
objvzx_SysCommentEN.IdCurrEduCls = objRow[convzx_SysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysCommentEN.UserId = objRow[convzx_SysComment.UserId] == DBNull.Value ? null : objRow[convzx_SysComment.UserId].ToString().Trim(); //用户ID
objvzx_SysCommentEN.Month = objRow[convzx_SysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Month].ToString().Trim()); //月
objvzx_SysCommentEN.Week = objRow[convzx_SysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Week].ToString().Trim()); //周
objvzx_SysCommentEN.WeekTimeRange = objRow[convzx_SysComment.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_SysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCommentEN.zxCommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCommentEN);
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
public static List<clsvzx_SysCommentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_SysCommentEN> arrObjLst = new List<clsvzx_SysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCommentEN objvzx_SysCommentEN = new clsvzx_SysCommentEN();
try
{
objvzx_SysCommentEN.CommentTypeName = objRow[convzx_SysComment.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCommentEN.zxCommentId = objRow[convzx_SysComment.zxCommentId].ToString().Trim(); //评论Id
objvzx_SysCommentEN.CommentTable = objRow[convzx_SysComment.CommentTable] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTable].ToString().Trim(); //评论表
objvzx_SysCommentEN.Comment = objRow[convzx_SysComment.Comment] == DBNull.Value ? null : objRow[convzx_SysComment.Comment].ToString().Trim(); //评论
objvzx_SysCommentEN.CommentTableId = objRow[convzx_SysComment.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCommentEN.Score = objRow[convzx_SysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysComment.Score].ToString().Trim()); //评分
objvzx_SysCommentEN.zxCommentTypeId = objRow[convzx_SysComment.zxCommentTypeId].ToString().Trim(); //评论类型Id
objvzx_SysCommentEN.ScoreType = objRow[convzx_SysComment.ScoreType] == DBNull.Value ? null : objRow[convzx_SysComment.ScoreType].ToString().Trim(); //评分类型
objvzx_SysCommentEN.ParentId = objRow[convzx_SysComment.ParentId].ToString().Trim(); //父Id
objvzx_SysCommentEN.TableKey = objRow[convzx_SysComment.TableKey] == DBNull.Value ? null : objRow[convzx_SysComment.TableKey].ToString().Trim(); //表主键
objvzx_SysCommentEN.UpdUser = objRow[convzx_SysComment.UpdUser] == DBNull.Value ? null : objRow[convzx_SysComment.UpdUser].ToString().Trim(); //修改人
objvzx_SysCommentEN.UpdDate = objRow[convzx_SysComment.UpdDate] == DBNull.Value ? null : objRow[convzx_SysComment.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCommentEN.Memo = objRow[convzx_SysComment.Memo] == DBNull.Value ? null : objRow[convzx_SysComment.Memo].ToString().Trim(); //备注
objvzx_SysCommentEN.OkCount = objRow[convzx_SysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCommentEN.PubParentId = objRow[convzx_SysComment.PubParentId] == DBNull.Value ? null : objRow[convzx_SysComment.PubParentId].ToString().Trim(); //公共父Id
objvzx_SysCommentEN.IdCurrEduCls = objRow[convzx_SysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysCommentEN.UserId = objRow[convzx_SysComment.UserId] == DBNull.Value ? null : objRow[convzx_SysComment.UserId].ToString().Trim(); //用户ID
objvzx_SysCommentEN.Month = objRow[convzx_SysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Month].ToString().Trim()); //月
objvzx_SysCommentEN.Week = objRow[convzx_SysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Week].ToString().Trim()); //周
objvzx_SysCommentEN.WeekTimeRange = objRow[convzx_SysComment.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_SysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCommentEN.zxCommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCommentEN);
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
List<clsvzx_SysCommentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_SysCommentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_SysCommentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_SysCommentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_SysCommentEN> arrObjLst = new List<clsvzx_SysCommentEN>(); 
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
	clsvzx_SysCommentEN objvzx_SysCommentEN = new clsvzx_SysCommentEN();
try
{
objvzx_SysCommentEN.CommentTypeName = objRow[convzx_SysComment.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCommentEN.zxCommentId = objRow[convzx_SysComment.zxCommentId].ToString().Trim(); //评论Id
objvzx_SysCommentEN.CommentTable = objRow[convzx_SysComment.CommentTable] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTable].ToString().Trim(); //评论表
objvzx_SysCommentEN.Comment = objRow[convzx_SysComment.Comment] == DBNull.Value ? null : objRow[convzx_SysComment.Comment].ToString().Trim(); //评论
objvzx_SysCommentEN.CommentTableId = objRow[convzx_SysComment.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCommentEN.Score = objRow[convzx_SysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysComment.Score].ToString().Trim()); //评分
objvzx_SysCommentEN.zxCommentTypeId = objRow[convzx_SysComment.zxCommentTypeId].ToString().Trim(); //评论类型Id
objvzx_SysCommentEN.ScoreType = objRow[convzx_SysComment.ScoreType] == DBNull.Value ? null : objRow[convzx_SysComment.ScoreType].ToString().Trim(); //评分类型
objvzx_SysCommentEN.ParentId = objRow[convzx_SysComment.ParentId].ToString().Trim(); //父Id
objvzx_SysCommentEN.TableKey = objRow[convzx_SysComment.TableKey] == DBNull.Value ? null : objRow[convzx_SysComment.TableKey].ToString().Trim(); //表主键
objvzx_SysCommentEN.UpdUser = objRow[convzx_SysComment.UpdUser] == DBNull.Value ? null : objRow[convzx_SysComment.UpdUser].ToString().Trim(); //修改人
objvzx_SysCommentEN.UpdDate = objRow[convzx_SysComment.UpdDate] == DBNull.Value ? null : objRow[convzx_SysComment.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCommentEN.Memo = objRow[convzx_SysComment.Memo] == DBNull.Value ? null : objRow[convzx_SysComment.Memo].ToString().Trim(); //备注
objvzx_SysCommentEN.OkCount = objRow[convzx_SysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCommentEN.PubParentId = objRow[convzx_SysComment.PubParentId] == DBNull.Value ? null : objRow[convzx_SysComment.PubParentId].ToString().Trim(); //公共父Id
objvzx_SysCommentEN.IdCurrEduCls = objRow[convzx_SysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysCommentEN.UserId = objRow[convzx_SysComment.UserId] == DBNull.Value ? null : objRow[convzx_SysComment.UserId].ToString().Trim(); //用户ID
objvzx_SysCommentEN.Month = objRow[convzx_SysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Month].ToString().Trim()); //月
objvzx_SysCommentEN.Week = objRow[convzx_SysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Week].ToString().Trim()); //周
objvzx_SysCommentEN.WeekTimeRange = objRow[convzx_SysComment.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_SysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCommentEN.zxCommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCommentEN);
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
public static List<clsvzx_SysCommentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_SysCommentEN> arrObjLst = new List<clsvzx_SysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCommentEN objvzx_SysCommentEN = new clsvzx_SysCommentEN();
try
{
objvzx_SysCommentEN.CommentTypeName = objRow[convzx_SysComment.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCommentEN.zxCommentId = objRow[convzx_SysComment.zxCommentId].ToString().Trim(); //评论Id
objvzx_SysCommentEN.CommentTable = objRow[convzx_SysComment.CommentTable] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTable].ToString().Trim(); //评论表
objvzx_SysCommentEN.Comment = objRow[convzx_SysComment.Comment] == DBNull.Value ? null : objRow[convzx_SysComment.Comment].ToString().Trim(); //评论
objvzx_SysCommentEN.CommentTableId = objRow[convzx_SysComment.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCommentEN.Score = objRow[convzx_SysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysComment.Score].ToString().Trim()); //评分
objvzx_SysCommentEN.zxCommentTypeId = objRow[convzx_SysComment.zxCommentTypeId].ToString().Trim(); //评论类型Id
objvzx_SysCommentEN.ScoreType = objRow[convzx_SysComment.ScoreType] == DBNull.Value ? null : objRow[convzx_SysComment.ScoreType].ToString().Trim(); //评分类型
objvzx_SysCommentEN.ParentId = objRow[convzx_SysComment.ParentId].ToString().Trim(); //父Id
objvzx_SysCommentEN.TableKey = objRow[convzx_SysComment.TableKey] == DBNull.Value ? null : objRow[convzx_SysComment.TableKey].ToString().Trim(); //表主键
objvzx_SysCommentEN.UpdUser = objRow[convzx_SysComment.UpdUser] == DBNull.Value ? null : objRow[convzx_SysComment.UpdUser].ToString().Trim(); //修改人
objvzx_SysCommentEN.UpdDate = objRow[convzx_SysComment.UpdDate] == DBNull.Value ? null : objRow[convzx_SysComment.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCommentEN.Memo = objRow[convzx_SysComment.Memo] == DBNull.Value ? null : objRow[convzx_SysComment.Memo].ToString().Trim(); //备注
objvzx_SysCommentEN.OkCount = objRow[convzx_SysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCommentEN.PubParentId = objRow[convzx_SysComment.PubParentId] == DBNull.Value ? null : objRow[convzx_SysComment.PubParentId].ToString().Trim(); //公共父Id
objvzx_SysCommentEN.IdCurrEduCls = objRow[convzx_SysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysCommentEN.UserId = objRow[convzx_SysComment.UserId] == DBNull.Value ? null : objRow[convzx_SysComment.UserId].ToString().Trim(); //用户ID
objvzx_SysCommentEN.Month = objRow[convzx_SysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Month].ToString().Trim()); //月
objvzx_SysCommentEN.Week = objRow[convzx_SysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Week].ToString().Trim()); //周
objvzx_SysCommentEN.WeekTimeRange = objRow[convzx_SysComment.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_SysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCommentEN.zxCommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCommentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_SysCommentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_SysCommentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_SysCommentEN> arrObjLst = new List<clsvzx_SysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCommentEN objvzx_SysCommentEN = new clsvzx_SysCommentEN();
try
{
objvzx_SysCommentEN.CommentTypeName = objRow[convzx_SysComment.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCommentEN.zxCommentId = objRow[convzx_SysComment.zxCommentId].ToString().Trim(); //评论Id
objvzx_SysCommentEN.CommentTable = objRow[convzx_SysComment.CommentTable] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTable].ToString().Trim(); //评论表
objvzx_SysCommentEN.Comment = objRow[convzx_SysComment.Comment] == DBNull.Value ? null : objRow[convzx_SysComment.Comment].ToString().Trim(); //评论
objvzx_SysCommentEN.CommentTableId = objRow[convzx_SysComment.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCommentEN.Score = objRow[convzx_SysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysComment.Score].ToString().Trim()); //评分
objvzx_SysCommentEN.zxCommentTypeId = objRow[convzx_SysComment.zxCommentTypeId].ToString().Trim(); //评论类型Id
objvzx_SysCommentEN.ScoreType = objRow[convzx_SysComment.ScoreType] == DBNull.Value ? null : objRow[convzx_SysComment.ScoreType].ToString().Trim(); //评分类型
objvzx_SysCommentEN.ParentId = objRow[convzx_SysComment.ParentId].ToString().Trim(); //父Id
objvzx_SysCommentEN.TableKey = objRow[convzx_SysComment.TableKey] == DBNull.Value ? null : objRow[convzx_SysComment.TableKey].ToString().Trim(); //表主键
objvzx_SysCommentEN.UpdUser = objRow[convzx_SysComment.UpdUser] == DBNull.Value ? null : objRow[convzx_SysComment.UpdUser].ToString().Trim(); //修改人
objvzx_SysCommentEN.UpdDate = objRow[convzx_SysComment.UpdDate] == DBNull.Value ? null : objRow[convzx_SysComment.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCommentEN.Memo = objRow[convzx_SysComment.Memo] == DBNull.Value ? null : objRow[convzx_SysComment.Memo].ToString().Trim(); //备注
objvzx_SysCommentEN.OkCount = objRow[convzx_SysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCommentEN.PubParentId = objRow[convzx_SysComment.PubParentId] == DBNull.Value ? null : objRow[convzx_SysComment.PubParentId].ToString().Trim(); //公共父Id
objvzx_SysCommentEN.IdCurrEduCls = objRow[convzx_SysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysCommentEN.UserId = objRow[convzx_SysComment.UserId] == DBNull.Value ? null : objRow[convzx_SysComment.UserId].ToString().Trim(); //用户ID
objvzx_SysCommentEN.Month = objRow[convzx_SysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Month].ToString().Trim()); //月
objvzx_SysCommentEN.Week = objRow[convzx_SysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Week].ToString().Trim()); //周
objvzx_SysCommentEN.WeekTimeRange = objRow[convzx_SysComment.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_SysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCommentEN.zxCommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCommentEN);
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
public static List<clsvzx_SysCommentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_SysCommentEN> arrObjLst = new List<clsvzx_SysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCommentEN objvzx_SysCommentEN = new clsvzx_SysCommentEN();
try
{
objvzx_SysCommentEN.CommentTypeName = objRow[convzx_SysComment.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCommentEN.zxCommentId = objRow[convzx_SysComment.zxCommentId].ToString().Trim(); //评论Id
objvzx_SysCommentEN.CommentTable = objRow[convzx_SysComment.CommentTable] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTable].ToString().Trim(); //评论表
objvzx_SysCommentEN.Comment = objRow[convzx_SysComment.Comment] == DBNull.Value ? null : objRow[convzx_SysComment.Comment].ToString().Trim(); //评论
objvzx_SysCommentEN.CommentTableId = objRow[convzx_SysComment.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCommentEN.Score = objRow[convzx_SysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysComment.Score].ToString().Trim()); //评分
objvzx_SysCommentEN.zxCommentTypeId = objRow[convzx_SysComment.zxCommentTypeId].ToString().Trim(); //评论类型Id
objvzx_SysCommentEN.ScoreType = objRow[convzx_SysComment.ScoreType] == DBNull.Value ? null : objRow[convzx_SysComment.ScoreType].ToString().Trim(); //评分类型
objvzx_SysCommentEN.ParentId = objRow[convzx_SysComment.ParentId].ToString().Trim(); //父Id
objvzx_SysCommentEN.TableKey = objRow[convzx_SysComment.TableKey] == DBNull.Value ? null : objRow[convzx_SysComment.TableKey].ToString().Trim(); //表主键
objvzx_SysCommentEN.UpdUser = objRow[convzx_SysComment.UpdUser] == DBNull.Value ? null : objRow[convzx_SysComment.UpdUser].ToString().Trim(); //修改人
objvzx_SysCommentEN.UpdDate = objRow[convzx_SysComment.UpdDate] == DBNull.Value ? null : objRow[convzx_SysComment.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCommentEN.Memo = objRow[convzx_SysComment.Memo] == DBNull.Value ? null : objRow[convzx_SysComment.Memo].ToString().Trim(); //备注
objvzx_SysCommentEN.OkCount = objRow[convzx_SysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCommentEN.PubParentId = objRow[convzx_SysComment.PubParentId] == DBNull.Value ? null : objRow[convzx_SysComment.PubParentId].ToString().Trim(); //公共父Id
objvzx_SysCommentEN.IdCurrEduCls = objRow[convzx_SysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysCommentEN.UserId = objRow[convzx_SysComment.UserId] == DBNull.Value ? null : objRow[convzx_SysComment.UserId].ToString().Trim(); //用户ID
objvzx_SysCommentEN.Month = objRow[convzx_SysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Month].ToString().Trim()); //月
objvzx_SysCommentEN.Week = objRow[convzx_SysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Week].ToString().Trim()); //周
objvzx_SysCommentEN.WeekTimeRange = objRow[convzx_SysComment.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_SysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCommentEN.zxCommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCommentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_SysCommentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_SysCommentEN> arrObjLst = new List<clsvzx_SysCommentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysCommentEN objvzx_SysCommentEN = new clsvzx_SysCommentEN();
try
{
objvzx_SysCommentEN.CommentTypeName = objRow[convzx_SysComment.CommentTypeName] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvzx_SysCommentEN.zxCommentId = objRow[convzx_SysComment.zxCommentId].ToString().Trim(); //评论Id
objvzx_SysCommentEN.CommentTable = objRow[convzx_SysComment.CommentTable] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTable].ToString().Trim(); //评论表
objvzx_SysCommentEN.Comment = objRow[convzx_SysComment.Comment] == DBNull.Value ? null : objRow[convzx_SysComment.Comment].ToString().Trim(); //评论
objvzx_SysCommentEN.CommentTableId = objRow[convzx_SysComment.CommentTableId] == DBNull.Value ? null : objRow[convzx_SysComment.CommentTableId].ToString().Trim(); //评论表Id
objvzx_SysCommentEN.Score = objRow[convzx_SysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysComment.Score].ToString().Trim()); //评分
objvzx_SysCommentEN.zxCommentTypeId = objRow[convzx_SysComment.zxCommentTypeId].ToString().Trim(); //评论类型Id
objvzx_SysCommentEN.ScoreType = objRow[convzx_SysComment.ScoreType] == DBNull.Value ? null : objRow[convzx_SysComment.ScoreType].ToString().Trim(); //评分类型
objvzx_SysCommentEN.ParentId = objRow[convzx_SysComment.ParentId].ToString().Trim(); //父Id
objvzx_SysCommentEN.TableKey = objRow[convzx_SysComment.TableKey] == DBNull.Value ? null : objRow[convzx_SysComment.TableKey].ToString().Trim(); //表主键
objvzx_SysCommentEN.UpdUser = objRow[convzx_SysComment.UpdUser] == DBNull.Value ? null : objRow[convzx_SysComment.UpdUser].ToString().Trim(); //修改人
objvzx_SysCommentEN.UpdDate = objRow[convzx_SysComment.UpdDate] == DBNull.Value ? null : objRow[convzx_SysComment.UpdDate].ToString().Trim(); //修改日期
objvzx_SysCommentEN.Memo = objRow[convzx_SysComment.Memo] == DBNull.Value ? null : objRow[convzx_SysComment.Memo].ToString().Trim(); //备注
objvzx_SysCommentEN.OkCount = objRow[convzx_SysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.OkCount].ToString().Trim()); //点赞统计
objvzx_SysCommentEN.PubParentId = objRow[convzx_SysComment.PubParentId] == DBNull.Value ? null : objRow[convzx_SysComment.PubParentId].ToString().Trim(); //公共父Id
objvzx_SysCommentEN.IdCurrEduCls = objRow[convzx_SysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysCommentEN.UserId = objRow[convzx_SysComment.UserId] == DBNull.Value ? null : objRow[convzx_SysComment.UserId].ToString().Trim(); //用户ID
objvzx_SysCommentEN.Month = objRow[convzx_SysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Month].ToString().Trim()); //月
objvzx_SysCommentEN.Week = objRow[convzx_SysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SysComment.Week].ToString().Trim()); //周
objvzx_SysCommentEN.WeekTimeRange = objRow[convzx_SysComment.WeekTimeRange] == DBNull.Value ? null : objRow[convzx_SysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysCommentEN.zxCommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysCommentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_SysCommentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_SysComment(ref clsvzx_SysCommentEN objvzx_SysCommentEN)
{
bool bolResult = vzx_SysCommentDA.Getvzx_SysComment(ref objvzx_SysCommentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxCommentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_SysCommentEN GetObjByzxCommentId(string strzxCommentId)
{
if (strzxCommentId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxCommentId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxCommentId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxCommentId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_SysCommentEN objvzx_SysCommentEN = vzx_SysCommentDA.GetObjByzxCommentId(strzxCommentId);
return objvzx_SysCommentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_SysCommentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_SysCommentEN objvzx_SysCommentEN = vzx_SysCommentDA.GetFirstObj(strWhereCond);
 return objvzx_SysCommentEN;
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
public static clsvzx_SysCommentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_SysCommentEN objvzx_SysCommentEN = vzx_SysCommentDA.GetObjByDataRow(objRow);
 return objvzx_SysCommentEN;
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
public static clsvzx_SysCommentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_SysCommentEN objvzx_SysCommentEN = vzx_SysCommentDA.GetObjByDataRow(objRow);
 return objvzx_SysCommentEN;
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
 /// <param name = "strzxCommentId">所给的关键字</param>
 /// <param name = "lstvzx_SysCommentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_SysCommentEN GetObjByzxCommentIdFromList(string strzxCommentId, List<clsvzx_SysCommentEN> lstvzx_SysCommentObjLst)
{
foreach (clsvzx_SysCommentEN objvzx_SysCommentEN in lstvzx_SysCommentObjLst)
{
if (objvzx_SysCommentEN.zxCommentId == strzxCommentId)
{
return objvzx_SysCommentEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxZxCommentId;
 try
 {
 strMaxZxCommentId = clsvzx_SysCommentDA.GetMaxStrId();
 return strMaxZxCommentId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strzxCommentId;
 try
 {
 strzxCommentId = new clsvzx_SysCommentDA().GetFirstID(strWhereCond);
 return strzxCommentId;
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
 arrList = vzx_SysCommentDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_SysCommentDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxCommentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxCommentId)
{
if (string.IsNullOrEmpty(strzxCommentId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxCommentId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_SysCommentDA.IsExist(strzxCommentId);
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
 bolIsExist = clsvzx_SysCommentDA.IsExistTable();
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
 bolIsExist = vzx_SysCommentDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_SysCommentENS">源对象</param>
 /// <param name = "objvzx_SysCommentENT">目标对象</param>
 public static void CopyTo(clsvzx_SysCommentEN objvzx_SysCommentENS, clsvzx_SysCommentEN objvzx_SysCommentENT)
{
try
{
objvzx_SysCommentENT.CommentTypeName = objvzx_SysCommentENS.CommentTypeName; //评论类型名
objvzx_SysCommentENT.zxCommentId = objvzx_SysCommentENS.zxCommentId; //评论Id
objvzx_SysCommentENT.CommentTable = objvzx_SysCommentENS.CommentTable; //评论表
objvzx_SysCommentENT.Comment = objvzx_SysCommentENS.Comment; //评论
objvzx_SysCommentENT.CommentTableId = objvzx_SysCommentENS.CommentTableId; //评论表Id
objvzx_SysCommentENT.Score = objvzx_SysCommentENS.Score; //评分
objvzx_SysCommentENT.zxCommentTypeId = objvzx_SysCommentENS.zxCommentTypeId; //评论类型Id
objvzx_SysCommentENT.ScoreType = objvzx_SysCommentENS.ScoreType; //评分类型
objvzx_SysCommentENT.ParentId = objvzx_SysCommentENS.ParentId; //父Id
objvzx_SysCommentENT.TableKey = objvzx_SysCommentENS.TableKey; //表主键
objvzx_SysCommentENT.UpdUser = objvzx_SysCommentENS.UpdUser; //修改人
objvzx_SysCommentENT.UpdDate = objvzx_SysCommentENS.UpdDate; //修改日期
objvzx_SysCommentENT.Memo = objvzx_SysCommentENS.Memo; //备注
objvzx_SysCommentENT.OkCount = objvzx_SysCommentENS.OkCount; //点赞统计
objvzx_SysCommentENT.PubParentId = objvzx_SysCommentENS.PubParentId; //公共父Id
objvzx_SysCommentENT.IdCurrEduCls = objvzx_SysCommentENS.IdCurrEduCls; //教学班流水号
objvzx_SysCommentENT.UserId = objvzx_SysCommentENS.UserId; //用户ID
objvzx_SysCommentENT.Month = objvzx_SysCommentENS.Month; //月
objvzx_SysCommentENT.Week = objvzx_SysCommentENS.Week; //周
objvzx_SysCommentENT.WeekTimeRange = objvzx_SysCommentENS.WeekTimeRange; //WeekTimeRange
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
 /// <param name = "objvzx_SysCommentEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_SysCommentEN objvzx_SysCommentEN)
{
try
{
objvzx_SysCommentEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_SysCommentEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_SysComment.CommentTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.CommentTypeName = objvzx_SysCommentEN.CommentTypeName == "[null]" ? null :  objvzx_SysCommentEN.CommentTypeName; //评论类型名
}
if (arrFldSet.Contains(convzx_SysComment.zxCommentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.zxCommentId = objvzx_SysCommentEN.zxCommentId; //评论Id
}
if (arrFldSet.Contains(convzx_SysComment.CommentTable, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.CommentTable = objvzx_SysCommentEN.CommentTable == "[null]" ? null :  objvzx_SysCommentEN.CommentTable; //评论表
}
if (arrFldSet.Contains(convzx_SysComment.Comment, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.Comment = objvzx_SysCommentEN.Comment == "[null]" ? null :  objvzx_SysCommentEN.Comment; //评论
}
if (arrFldSet.Contains(convzx_SysComment.CommentTableId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.CommentTableId = objvzx_SysCommentEN.CommentTableId == "[null]" ? null :  objvzx_SysCommentEN.CommentTableId; //评论表Id
}
if (arrFldSet.Contains(convzx_SysComment.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.Score = objvzx_SysCommentEN.Score; //评分
}
if (arrFldSet.Contains(convzx_SysComment.zxCommentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.zxCommentTypeId = objvzx_SysCommentEN.zxCommentTypeId; //评论类型Id
}
if (arrFldSet.Contains(convzx_SysComment.ScoreType, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.ScoreType = objvzx_SysCommentEN.ScoreType == "[null]" ? null :  objvzx_SysCommentEN.ScoreType; //评分类型
}
if (arrFldSet.Contains(convzx_SysComment.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.ParentId = objvzx_SysCommentEN.ParentId; //父Id
}
if (arrFldSet.Contains(convzx_SysComment.TableKey, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.TableKey = objvzx_SysCommentEN.TableKey == "[null]" ? null :  objvzx_SysCommentEN.TableKey; //表主键
}
if (arrFldSet.Contains(convzx_SysComment.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.UpdUser = objvzx_SysCommentEN.UpdUser == "[null]" ? null :  objvzx_SysCommentEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_SysComment.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.UpdDate = objvzx_SysCommentEN.UpdDate == "[null]" ? null :  objvzx_SysCommentEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_SysComment.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.Memo = objvzx_SysCommentEN.Memo == "[null]" ? null :  objvzx_SysCommentEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_SysComment.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.OkCount = objvzx_SysCommentEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convzx_SysComment.PubParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.PubParentId = objvzx_SysCommentEN.PubParentId == "[null]" ? null :  objvzx_SysCommentEN.PubParentId; //公共父Id
}
if (arrFldSet.Contains(convzx_SysComment.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.IdCurrEduCls = objvzx_SysCommentEN.IdCurrEduCls == "[null]" ? null :  objvzx_SysCommentEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_SysComment.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.UserId = objvzx_SysCommentEN.UserId == "[null]" ? null :  objvzx_SysCommentEN.UserId; //用户ID
}
if (arrFldSet.Contains(convzx_SysComment.Month, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.Month = objvzx_SysCommentEN.Month; //月
}
if (arrFldSet.Contains(convzx_SysComment.Week, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.Week = objvzx_SysCommentEN.Week; //周
}
if (arrFldSet.Contains(convzx_SysComment.WeekTimeRange, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysCommentEN.WeekTimeRange = objvzx_SysCommentEN.WeekTimeRange == "[null]" ? null :  objvzx_SysCommentEN.WeekTimeRange; //WeekTimeRange
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
 /// <param name = "objvzx_SysCommentEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_SysCommentEN objvzx_SysCommentEN)
{
try
{
if (objvzx_SysCommentEN.CommentTypeName == "[null]") objvzx_SysCommentEN.CommentTypeName = null; //评论类型名
if (objvzx_SysCommentEN.CommentTable == "[null]") objvzx_SysCommentEN.CommentTable = null; //评论表
if (objvzx_SysCommentEN.Comment == "[null]") objvzx_SysCommentEN.Comment = null; //评论
if (objvzx_SysCommentEN.CommentTableId == "[null]") objvzx_SysCommentEN.CommentTableId = null; //评论表Id
if (objvzx_SysCommentEN.ScoreType == "[null]") objvzx_SysCommentEN.ScoreType = null; //评分类型
if (objvzx_SysCommentEN.TableKey == "[null]") objvzx_SysCommentEN.TableKey = null; //表主键
if (objvzx_SysCommentEN.UpdUser == "[null]") objvzx_SysCommentEN.UpdUser = null; //修改人
if (objvzx_SysCommentEN.UpdDate == "[null]") objvzx_SysCommentEN.UpdDate = null; //修改日期
if (objvzx_SysCommentEN.Memo == "[null]") objvzx_SysCommentEN.Memo = null; //备注
if (objvzx_SysCommentEN.PubParentId == "[null]") objvzx_SysCommentEN.PubParentId = null; //公共父Id
if (objvzx_SysCommentEN.IdCurrEduCls == "[null]") objvzx_SysCommentEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_SysCommentEN.UserId == "[null]") objvzx_SysCommentEN.UserId = null; //用户ID
if (objvzx_SysCommentEN.WeekTimeRange == "[null]") objvzx_SysCommentEN.WeekTimeRange = null; //WeekTimeRange
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
public static void CheckProperty4Condition(clsvzx_SysCommentEN objvzx_SysCommentEN)
{
 vzx_SysCommentDA.CheckProperty4Condition(objvzx_SysCommentEN);
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
if (clszx_SysCommentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SysCommentBL没有刷新缓存机制(clszx_SysCommentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_SysCommentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SysCommentTypeBL没有刷新缓存机制(clszx_SysCommentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxCommentId");
//if (arrvzx_SysCommentObjLstCache == null)
//{
//arrvzx_SysCommentObjLstCache = vzx_SysCommentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxCommentId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_SysCommentEN GetObjByzxCommentIdCache(string strzxCommentId, string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvzx_SysCommentEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_SysCommentEN> arrvzx_SysCommentObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_SysCommentEN> arrvzx_SysCommentObjLst_Sel =
arrvzx_SysCommentObjLstCache
.Where(x=> x.zxCommentId == strzxCommentId 
);
if (arrvzx_SysCommentObjLst_Sel.Count() == 0)
{
   clsvzx_SysCommentEN obj = clsvzx_SysCommentBL.GetObjByzxCommentId(strzxCommentId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strzxCommentId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvzx_SysCommentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_SysCommentEN> GetAllvzx_SysCommentObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvzx_SysCommentEN> arrvzx_SysCommentObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvzx_SysCommentObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_SysCommentEN> GetObjLstCache(string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvzx_SysCommentEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvzx_SysCommentEN> arrvzx_SysCommentObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvzx_SysCommentObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strIdCurrEduCls = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvzx_SysCommentEN._CurrTabName, strIdCurrEduCls);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strzxCommentId, string strIdCurrEduCls)
{
if (strInFldName != convzx_SysComment.zxCommentId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_SysComment.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_SysComment.AttributeName));
throw new Exception(strMsg);
}
var objvzx_SysComment = clsvzx_SysCommentBL.GetObjByzxCommentIdCache(strzxCommentId, strIdCurrEduCls);
if (objvzx_SysComment == null) return "";
return objvzx_SysComment[strOutFldName].ToString();
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
int intRecCount = clsvzx_SysCommentDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_SysCommentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_SysCommentDA.GetRecCount();
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
int intRecCount = clsvzx_SysCommentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_SysCommentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_SysCommentEN objvzx_SysCommentCond)
{
 string strIdCurrEduCls = objvzx_SysCommentCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvzx_SysCommentBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvzx_SysCommentEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_SysCommentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_SysComment.AttributeName)
{
if (objvzx_SysCommentCond.IsUpdated(strFldName) == false) continue;
if (objvzx_SysCommentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SysCommentCond[strFldName].ToString());
}
else
{
if (objvzx_SysCommentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_SysCommentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SysCommentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_SysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_SysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_SysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_SysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_SysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_SysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_SysCommentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_SysCommentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_SysCommentCond[strFldName]));
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
 List<string> arrList = clsvzx_SysCommentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_SysCommentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_SysCommentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}