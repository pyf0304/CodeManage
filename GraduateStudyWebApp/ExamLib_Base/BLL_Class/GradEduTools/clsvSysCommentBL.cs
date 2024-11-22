
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysCommentBL
 表名:vSysComment(01120624)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:03:33
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
public static class  clsvSysCommentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCommentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysCommentEN GetObj(this K_CommentId_vSysComment myKey)
{
clsvSysCommentEN objvSysCommentEN = clsvSysCommentBL.vSysCommentDA.GetObjByCommentId(myKey.Value);
return objvSysCommentEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCommentEN SetCommentId(this clsvSysCommentEN objvSysCommentEN, string strCommentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentId, 10, convSysComment.CommentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCommentId, 10, convSysComment.CommentId);
}
objvSysCommentEN.CommentId = strCommentId; //评论Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCommentEN.dicFldComparisonOp.ContainsKey(convSysComment.CommentId) == false)
{
objvSysCommentEN.dicFldComparisonOp.Add(convSysComment.CommentId, strComparisonOp);
}
else
{
objvSysCommentEN.dicFldComparisonOp[convSysComment.CommentId] = strComparisonOp;
}
}
return objvSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCommentEN SetComment(this clsvSysCommentEN objvSysCommentEN, string strComment, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strComment, 2000, convSysComment.Comment);
}
objvSysCommentEN.Comment = strComment; //评论
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCommentEN.dicFldComparisonOp.ContainsKey(convSysComment.Comment) == false)
{
objvSysCommentEN.dicFldComparisonOp.Add(convSysComment.Comment, strComparisonOp);
}
else
{
objvSysCommentEN.dicFldComparisonOp[convSysComment.Comment] = strComparisonOp;
}
}
return objvSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCommentEN SetScore(this clsvSysCommentEN objvSysCommentEN, float? fltScore, string strComparisonOp="")
	{
objvSysCommentEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCommentEN.dicFldComparisonOp.ContainsKey(convSysComment.Score) == false)
{
objvSysCommentEN.dicFldComparisonOp.Add(convSysComment.Score, strComparisonOp);
}
else
{
objvSysCommentEN.dicFldComparisonOp[convSysComment.Score] = strComparisonOp;
}
}
return objvSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCommentEN SetCommentTypeId(this clsvSysCommentEN objvSysCommentEN, string strCommentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCommentTypeId, convSysComment.CommentTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentTypeId, 2, convSysComment.CommentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCommentTypeId, 2, convSysComment.CommentTypeId);
}
objvSysCommentEN.CommentTypeId = strCommentTypeId; //评论类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCommentEN.dicFldComparisonOp.ContainsKey(convSysComment.CommentTypeId) == false)
{
objvSysCommentEN.dicFldComparisonOp.Add(convSysComment.CommentTypeId, strComparisonOp);
}
else
{
objvSysCommentEN.dicFldComparisonOp[convSysComment.CommentTypeId] = strComparisonOp;
}
}
return objvSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCommentEN SetScoreType(this clsvSysCommentEN objvSysCommentEN, string strScoreType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreType, 1, convSysComment.ScoreType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strScoreType, 1, convSysComment.ScoreType);
}
objvSysCommentEN.ScoreType = strScoreType; //评分类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCommentEN.dicFldComparisonOp.ContainsKey(convSysComment.ScoreType) == false)
{
objvSysCommentEN.dicFldComparisonOp.Add(convSysComment.ScoreType, strComparisonOp);
}
else
{
objvSysCommentEN.dicFldComparisonOp[convSysComment.ScoreType] = strComparisonOp;
}
}
return objvSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCommentEN SetParentId(this clsvSysCommentEN objvSysCommentEN, string strParentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParentId, convSysComment.ParentId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 20, convSysComment.ParentId);
}
objvSysCommentEN.ParentId = strParentId; //父Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCommentEN.dicFldComparisonOp.ContainsKey(convSysComment.ParentId) == false)
{
objvSysCommentEN.dicFldComparisonOp.Add(convSysComment.ParentId, strComparisonOp);
}
else
{
objvSysCommentEN.dicFldComparisonOp[convSysComment.ParentId] = strComparisonOp;
}
}
return objvSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCommentEN SetTableKey(this clsvSysCommentEN objvSysCommentEN, string strTableKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableKey, 20, convSysComment.TableKey);
}
objvSysCommentEN.TableKey = strTableKey; //表主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCommentEN.dicFldComparisonOp.ContainsKey(convSysComment.TableKey) == false)
{
objvSysCommentEN.dicFldComparisonOp.Add(convSysComment.TableKey, strComparisonOp);
}
else
{
objvSysCommentEN.dicFldComparisonOp[convSysComment.TableKey] = strComparisonOp;
}
}
return objvSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCommentEN SetUpdUser(this clsvSysCommentEN objvSysCommentEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convSysComment.UpdUser);
}
objvSysCommentEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCommentEN.dicFldComparisonOp.ContainsKey(convSysComment.UpdUser) == false)
{
objvSysCommentEN.dicFldComparisonOp.Add(convSysComment.UpdUser, strComparisonOp);
}
else
{
objvSysCommentEN.dicFldComparisonOp[convSysComment.UpdUser] = strComparisonOp;
}
}
return objvSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCommentEN SetUpdDate(this clsvSysCommentEN objvSysCommentEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSysComment.UpdDate);
}
objvSysCommentEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCommentEN.dicFldComparisonOp.ContainsKey(convSysComment.UpdDate) == false)
{
objvSysCommentEN.dicFldComparisonOp.Add(convSysComment.UpdDate, strComparisonOp);
}
else
{
objvSysCommentEN.dicFldComparisonOp[convSysComment.UpdDate] = strComparisonOp;
}
}
return objvSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCommentEN SetMemo(this clsvSysCommentEN objvSysCommentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSysComment.Memo);
}
objvSysCommentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCommentEN.dicFldComparisonOp.ContainsKey(convSysComment.Memo) == false)
{
objvSysCommentEN.dicFldComparisonOp.Add(convSysComment.Memo, strComparisonOp);
}
else
{
objvSysCommentEN.dicFldComparisonOp[convSysComment.Memo] = strComparisonOp;
}
}
return objvSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCommentEN SetCommentTypeName(this clsvSysCommentEN objvSysCommentEN, string strCommentTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentTypeName, 50, convSysComment.CommentTypeName);
}
objvSysCommentEN.CommentTypeName = strCommentTypeName; //评论类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCommentEN.dicFldComparisonOp.ContainsKey(convSysComment.CommentTypeName) == false)
{
objvSysCommentEN.dicFldComparisonOp.Add(convSysComment.CommentTypeName, strComparisonOp);
}
else
{
objvSysCommentEN.dicFldComparisonOp[convSysComment.CommentTypeName] = strComparisonOp;
}
}
return objvSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCommentEN SetCommentTable(this clsvSysCommentEN objvSysCommentEN, string strCommentTable, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentTable, 50, convSysComment.CommentTable);
}
objvSysCommentEN.CommentTable = strCommentTable; //评论表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCommentEN.dicFldComparisonOp.ContainsKey(convSysComment.CommentTable) == false)
{
objvSysCommentEN.dicFldComparisonOp.Add(convSysComment.CommentTable, strComparisonOp);
}
else
{
objvSysCommentEN.dicFldComparisonOp[convSysComment.CommentTable] = strComparisonOp;
}
}
return objvSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCommentEN SetCommentTableId(this clsvSysCommentEN objvSysCommentEN, string strCommentTableId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentTableId, 50, convSysComment.CommentTableId);
}
objvSysCommentEN.CommentTableId = strCommentTableId; //评论表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCommentEN.dicFldComparisonOp.ContainsKey(convSysComment.CommentTableId) == false)
{
objvSysCommentEN.dicFldComparisonOp.Add(convSysComment.CommentTableId, strComparisonOp);
}
else
{
objvSysCommentEN.dicFldComparisonOp[convSysComment.CommentTableId] = strComparisonOp;
}
}
return objvSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCommentEN SetOkCount(this clsvSysCommentEN objvSysCommentEN, int? intOkCount, string strComparisonOp="")
	{
objvSysCommentEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCommentEN.dicFldComparisonOp.ContainsKey(convSysComment.OkCount) == false)
{
objvSysCommentEN.dicFldComparisonOp.Add(convSysComment.OkCount, strComparisonOp);
}
else
{
objvSysCommentEN.dicFldComparisonOp[convSysComment.OkCount] = strComparisonOp;
}
}
return objvSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCommentEN SetPubParentId(this clsvSysCommentEN objvSysCommentEN, string strPubParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubParentId, 20, convSysComment.PubParentId);
}
objvSysCommentEN.PubParentId = strPubParentId; //公共父Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCommentEN.dicFldComparisonOp.ContainsKey(convSysComment.PubParentId) == false)
{
objvSysCommentEN.dicFldComparisonOp.Add(convSysComment.PubParentId, strComparisonOp);
}
else
{
objvSysCommentEN.dicFldComparisonOp[convSysComment.PubParentId] = strComparisonOp;
}
}
return objvSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCommentEN SetIdCurrEduCls(this clsvSysCommentEN objvSysCommentEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, convSysComment.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convSysComment.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convSysComment.IdCurrEduCls);
}
objvSysCommentEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCommentEN.dicFldComparisonOp.ContainsKey(convSysComment.IdCurrEduCls) == false)
{
objvSysCommentEN.dicFldComparisonOp.Add(convSysComment.IdCurrEduCls, strComparisonOp);
}
else
{
objvSysCommentEN.dicFldComparisonOp[convSysComment.IdCurrEduCls] = strComparisonOp;
}
}
return objvSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysCommentEN SetUserId(this clsvSysCommentEN objvSysCommentEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convSysComment.UserId);
}
objvSysCommentEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysCommentEN.dicFldComparisonOp.ContainsKey(convSysComment.UserId) == false)
{
objvSysCommentEN.dicFldComparisonOp.Add(convSysComment.UserId, strComparisonOp);
}
else
{
objvSysCommentEN.dicFldComparisonOp[convSysComment.UserId] = strComparisonOp;
}
}
return objvSysCommentEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSysCommentENS">源对象</param>
 /// <param name = "objvSysCommentENT">目标对象</param>
 public static void CopyTo(this clsvSysCommentEN objvSysCommentENS, clsvSysCommentEN objvSysCommentENT)
{
try
{
objvSysCommentENT.CommentId = objvSysCommentENS.CommentId; //评论Id
objvSysCommentENT.Comment = objvSysCommentENS.Comment; //评论
objvSysCommentENT.Score = objvSysCommentENS.Score; //评分
objvSysCommentENT.CommentTypeId = objvSysCommentENS.CommentTypeId; //评论类型Id
objvSysCommentENT.ScoreType = objvSysCommentENS.ScoreType; //评分类型
objvSysCommentENT.ParentId = objvSysCommentENS.ParentId; //父Id
objvSysCommentENT.TableKey = objvSysCommentENS.TableKey; //表主键
objvSysCommentENT.UpdUser = objvSysCommentENS.UpdUser; //修改人
objvSysCommentENT.UpdDate = objvSysCommentENS.UpdDate; //修改日期
objvSysCommentENT.Memo = objvSysCommentENS.Memo; //备注
objvSysCommentENT.CommentTypeName = objvSysCommentENS.CommentTypeName; //评论类型名
objvSysCommentENT.CommentTable = objvSysCommentENS.CommentTable; //评论表
objvSysCommentENT.CommentTableId = objvSysCommentENS.CommentTableId; //评论表Id
objvSysCommentENT.OkCount = objvSysCommentENS.OkCount; //点赞统计
objvSysCommentENT.PubParentId = objvSysCommentENS.PubParentId; //公共父Id
objvSysCommentENT.IdCurrEduCls = objvSysCommentENS.IdCurrEduCls; //教学班流水号
objvSysCommentENT.UserId = objvSysCommentENS.UserId; //用户ID
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
 /// <param name = "objvSysCommentENS">源对象</param>
 /// <returns>目标对象=>clsvSysCommentEN:objvSysCommentENT</returns>
 public static clsvSysCommentEN CopyTo(this clsvSysCommentEN objvSysCommentENS)
{
try
{
 clsvSysCommentEN objvSysCommentENT = new clsvSysCommentEN()
{
CommentId = objvSysCommentENS.CommentId, //评论Id
Comment = objvSysCommentENS.Comment, //评论
Score = objvSysCommentENS.Score, //评分
CommentTypeId = objvSysCommentENS.CommentTypeId, //评论类型Id
ScoreType = objvSysCommentENS.ScoreType, //评分类型
ParentId = objvSysCommentENS.ParentId, //父Id
TableKey = objvSysCommentENS.TableKey, //表主键
UpdUser = objvSysCommentENS.UpdUser, //修改人
UpdDate = objvSysCommentENS.UpdDate, //修改日期
Memo = objvSysCommentENS.Memo, //备注
CommentTypeName = objvSysCommentENS.CommentTypeName, //评论类型名
CommentTable = objvSysCommentENS.CommentTable, //评论表
CommentTableId = objvSysCommentENS.CommentTableId, //评论表Id
OkCount = objvSysCommentENS.OkCount, //点赞统计
PubParentId = objvSysCommentENS.PubParentId, //公共父Id
IdCurrEduCls = objvSysCommentENS.IdCurrEduCls, //教学班流水号
UserId = objvSysCommentENS.UserId, //用户ID
};
 return objvSysCommentENT;
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
public static void CheckProperty4Condition(this clsvSysCommentEN objvSysCommentEN)
{
 clsvSysCommentBL.vSysCommentDA.CheckProperty4Condition(objvSysCommentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSysCommentEN objvSysCommentCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSysCommentCond.IsUpdated(convSysComment.CommentId) == true)
{
string strComparisonOpCommentId = objvSysCommentCond.dicFldComparisonOp[convSysComment.CommentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysComment.CommentId, objvSysCommentCond.CommentId, strComparisonOpCommentId);
}
if (objvSysCommentCond.IsUpdated(convSysComment.Comment) == true)
{
string strComparisonOpComment = objvSysCommentCond.dicFldComparisonOp[convSysComment.Comment];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysComment.Comment, objvSysCommentCond.Comment, strComparisonOpComment);
}
if (objvSysCommentCond.IsUpdated(convSysComment.Score) == true)
{
string strComparisonOpScore = objvSysCommentCond.dicFldComparisonOp[convSysComment.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convSysComment.Score, objvSysCommentCond.Score, strComparisonOpScore);
}
if (objvSysCommentCond.IsUpdated(convSysComment.CommentTypeId) == true)
{
string strComparisonOpCommentTypeId = objvSysCommentCond.dicFldComparisonOp[convSysComment.CommentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysComment.CommentTypeId, objvSysCommentCond.CommentTypeId, strComparisonOpCommentTypeId);
}
if (objvSysCommentCond.IsUpdated(convSysComment.ScoreType) == true)
{
string strComparisonOpScoreType = objvSysCommentCond.dicFldComparisonOp[convSysComment.ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysComment.ScoreType, objvSysCommentCond.ScoreType, strComparisonOpScoreType);
}
if (objvSysCommentCond.IsUpdated(convSysComment.ParentId) == true)
{
string strComparisonOpParentId = objvSysCommentCond.dicFldComparisonOp[convSysComment.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysComment.ParentId, objvSysCommentCond.ParentId, strComparisonOpParentId);
}
if (objvSysCommentCond.IsUpdated(convSysComment.TableKey) == true)
{
string strComparisonOpTableKey = objvSysCommentCond.dicFldComparisonOp[convSysComment.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysComment.TableKey, objvSysCommentCond.TableKey, strComparisonOpTableKey);
}
if (objvSysCommentCond.IsUpdated(convSysComment.UpdUser) == true)
{
string strComparisonOpUpdUser = objvSysCommentCond.dicFldComparisonOp[convSysComment.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysComment.UpdUser, objvSysCommentCond.UpdUser, strComparisonOpUpdUser);
}
if (objvSysCommentCond.IsUpdated(convSysComment.UpdDate) == true)
{
string strComparisonOpUpdDate = objvSysCommentCond.dicFldComparisonOp[convSysComment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysComment.UpdDate, objvSysCommentCond.UpdDate, strComparisonOpUpdDate);
}
if (objvSysCommentCond.IsUpdated(convSysComment.Memo) == true)
{
string strComparisonOpMemo = objvSysCommentCond.dicFldComparisonOp[convSysComment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysComment.Memo, objvSysCommentCond.Memo, strComparisonOpMemo);
}
if (objvSysCommentCond.IsUpdated(convSysComment.CommentTypeName) == true)
{
string strComparisonOpCommentTypeName = objvSysCommentCond.dicFldComparisonOp[convSysComment.CommentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysComment.CommentTypeName, objvSysCommentCond.CommentTypeName, strComparisonOpCommentTypeName);
}
if (objvSysCommentCond.IsUpdated(convSysComment.CommentTable) == true)
{
string strComparisonOpCommentTable = objvSysCommentCond.dicFldComparisonOp[convSysComment.CommentTable];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysComment.CommentTable, objvSysCommentCond.CommentTable, strComparisonOpCommentTable);
}
if (objvSysCommentCond.IsUpdated(convSysComment.CommentTableId) == true)
{
string strComparisonOpCommentTableId = objvSysCommentCond.dicFldComparisonOp[convSysComment.CommentTableId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysComment.CommentTableId, objvSysCommentCond.CommentTableId, strComparisonOpCommentTableId);
}
if (objvSysCommentCond.IsUpdated(convSysComment.OkCount) == true)
{
string strComparisonOpOkCount = objvSysCommentCond.dicFldComparisonOp[convSysComment.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convSysComment.OkCount, objvSysCommentCond.OkCount, strComparisonOpOkCount);
}
if (objvSysCommentCond.IsUpdated(convSysComment.PubParentId) == true)
{
string strComparisonOpPubParentId = objvSysCommentCond.dicFldComparisonOp[convSysComment.PubParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysComment.PubParentId, objvSysCommentCond.PubParentId, strComparisonOpPubParentId);
}
if (objvSysCommentCond.IsUpdated(convSysComment.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvSysCommentCond.dicFldComparisonOp[convSysComment.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysComment.IdCurrEduCls, objvSysCommentCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvSysCommentCond.IsUpdated(convSysComment.UserId) == true)
{
string strComparisonOpUserId = objvSysCommentCond.dicFldComparisonOp[convSysComment.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysComment.UserId, objvSysCommentCond.UserId, strComparisonOpUserId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSysComment
{
public virtual bool UpdRelaTabDate(string strCommentId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v系统评论表(vSysComment)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSysCommentBL
{
public static RelatedActions_vSysComment relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSysCommentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSysCommentDA vSysCommentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSysCommentDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSysCommentBL()
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
if (string.IsNullOrEmpty(clsvSysCommentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSysCommentEN._ConnectString);
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
public static DataTable GetDataTable_vSysComment(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSysCommentDA.GetDataTable_vSysComment(strWhereCond);
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
objDT = vSysCommentDA.GetDataTable(strWhereCond);
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
objDT = vSysCommentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSysCommentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSysCommentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSysCommentDA.GetDataTable_Top(objTopPara);
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
objDT = vSysCommentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vSysCommentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSysCommentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCommentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvSysCommentEN> GetObjLstByCommentIdLst(List<string> arrCommentIdLst)
{
List<clsvSysCommentEN> arrObjLst = new List<clsvSysCommentEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCommentIdLst, true);
 string strWhereCond = string.Format("CommentId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCommentEN objvSysCommentEN = new clsvSysCommentEN();
try
{
objvSysCommentEN.CommentId = objRow[convSysComment.CommentId].ToString().Trim(); //评论Id
objvSysCommentEN.Comment = objRow[convSysComment.Comment] == DBNull.Value ? null : objRow[convSysComment.Comment].ToString().Trim(); //评论
objvSysCommentEN.Score = objRow[convSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysComment.Score].ToString().Trim()); //评分
objvSysCommentEN.CommentTypeId = objRow[convSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objvSysCommentEN.ScoreType = objRow[convSysComment.ScoreType] == DBNull.Value ? null : objRow[convSysComment.ScoreType].ToString().Trim(); //评分类型
objvSysCommentEN.ParentId = objRow[convSysComment.ParentId].ToString().Trim(); //父Id
objvSysCommentEN.TableKey = objRow[convSysComment.TableKey] == DBNull.Value ? null : objRow[convSysComment.TableKey].ToString().Trim(); //表主键
objvSysCommentEN.UpdUser = objRow[convSysComment.UpdUser] == DBNull.Value ? null : objRow[convSysComment.UpdUser].ToString().Trim(); //修改人
objvSysCommentEN.UpdDate = objRow[convSysComment.UpdDate] == DBNull.Value ? null : objRow[convSysComment.UpdDate].ToString().Trim(); //修改日期
objvSysCommentEN.Memo = objRow[convSysComment.Memo] == DBNull.Value ? null : objRow[convSysComment.Memo].ToString().Trim(); //备注
objvSysCommentEN.CommentTypeName = objRow[convSysComment.CommentTypeName] == DBNull.Value ? null : objRow[convSysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCommentEN.CommentTable = objRow[convSysComment.CommentTable] == DBNull.Value ? null : objRow[convSysComment.CommentTable].ToString().Trim(); //评论表
objvSysCommentEN.CommentTableId = objRow[convSysComment.CommentTableId] == DBNull.Value ? null : objRow[convSysComment.CommentTableId].ToString().Trim(); //评论表Id
objvSysCommentEN.OkCount = objRow[convSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysComment.OkCount].ToString().Trim()); //点赞统计
objvSysCommentEN.PubParentId = objRow[convSysComment.PubParentId] == DBNull.Value ? null : objRow[convSysComment.PubParentId].ToString().Trim(); //公共父Id
objvSysCommentEN.IdCurrEduCls = objRow[convSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysCommentEN.UserId = objRow[convSysComment.UserId] == DBNull.Value ? null : objRow[convSysComment.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCommentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCommentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSysCommentEN> GetObjLstByCommentIdLstCache(List<string> arrCommentIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvSysCommentEN._CurrTabName, strIdCurrEduCls);
List<clsvSysCommentEN> arrvSysCommentObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvSysCommentEN> arrvSysCommentObjLst_Sel =
arrvSysCommentObjLstCache
.Where(x => arrCommentIdLst.Contains(x.CommentId));
return arrvSysCommentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysCommentEN> GetObjLst(string strWhereCond)
{
List<clsvSysCommentEN> arrObjLst = new List<clsvSysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCommentEN objvSysCommentEN = new clsvSysCommentEN();
try
{
objvSysCommentEN.CommentId = objRow[convSysComment.CommentId].ToString().Trim(); //评论Id
objvSysCommentEN.Comment = objRow[convSysComment.Comment] == DBNull.Value ? null : objRow[convSysComment.Comment].ToString().Trim(); //评论
objvSysCommentEN.Score = objRow[convSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysComment.Score].ToString().Trim()); //评分
objvSysCommentEN.CommentTypeId = objRow[convSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objvSysCommentEN.ScoreType = objRow[convSysComment.ScoreType] == DBNull.Value ? null : objRow[convSysComment.ScoreType].ToString().Trim(); //评分类型
objvSysCommentEN.ParentId = objRow[convSysComment.ParentId].ToString().Trim(); //父Id
objvSysCommentEN.TableKey = objRow[convSysComment.TableKey] == DBNull.Value ? null : objRow[convSysComment.TableKey].ToString().Trim(); //表主键
objvSysCommentEN.UpdUser = objRow[convSysComment.UpdUser] == DBNull.Value ? null : objRow[convSysComment.UpdUser].ToString().Trim(); //修改人
objvSysCommentEN.UpdDate = objRow[convSysComment.UpdDate] == DBNull.Value ? null : objRow[convSysComment.UpdDate].ToString().Trim(); //修改日期
objvSysCommentEN.Memo = objRow[convSysComment.Memo] == DBNull.Value ? null : objRow[convSysComment.Memo].ToString().Trim(); //备注
objvSysCommentEN.CommentTypeName = objRow[convSysComment.CommentTypeName] == DBNull.Value ? null : objRow[convSysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCommentEN.CommentTable = objRow[convSysComment.CommentTable] == DBNull.Value ? null : objRow[convSysComment.CommentTable].ToString().Trim(); //评论表
objvSysCommentEN.CommentTableId = objRow[convSysComment.CommentTableId] == DBNull.Value ? null : objRow[convSysComment.CommentTableId].ToString().Trim(); //评论表Id
objvSysCommentEN.OkCount = objRow[convSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysComment.OkCount].ToString().Trim()); //点赞统计
objvSysCommentEN.PubParentId = objRow[convSysComment.PubParentId] == DBNull.Value ? null : objRow[convSysComment.PubParentId].ToString().Trim(); //公共父Id
objvSysCommentEN.IdCurrEduCls = objRow[convSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysCommentEN.UserId = objRow[convSysComment.UserId] == DBNull.Value ? null : objRow[convSysComment.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCommentEN);
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
public static List<clsvSysCommentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSysCommentEN> arrObjLst = new List<clsvSysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCommentEN objvSysCommentEN = new clsvSysCommentEN();
try
{
objvSysCommentEN.CommentId = objRow[convSysComment.CommentId].ToString().Trim(); //评论Id
objvSysCommentEN.Comment = objRow[convSysComment.Comment] == DBNull.Value ? null : objRow[convSysComment.Comment].ToString().Trim(); //评论
objvSysCommentEN.Score = objRow[convSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysComment.Score].ToString().Trim()); //评分
objvSysCommentEN.CommentTypeId = objRow[convSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objvSysCommentEN.ScoreType = objRow[convSysComment.ScoreType] == DBNull.Value ? null : objRow[convSysComment.ScoreType].ToString().Trim(); //评分类型
objvSysCommentEN.ParentId = objRow[convSysComment.ParentId].ToString().Trim(); //父Id
objvSysCommentEN.TableKey = objRow[convSysComment.TableKey] == DBNull.Value ? null : objRow[convSysComment.TableKey].ToString().Trim(); //表主键
objvSysCommentEN.UpdUser = objRow[convSysComment.UpdUser] == DBNull.Value ? null : objRow[convSysComment.UpdUser].ToString().Trim(); //修改人
objvSysCommentEN.UpdDate = objRow[convSysComment.UpdDate] == DBNull.Value ? null : objRow[convSysComment.UpdDate].ToString().Trim(); //修改日期
objvSysCommentEN.Memo = objRow[convSysComment.Memo] == DBNull.Value ? null : objRow[convSysComment.Memo].ToString().Trim(); //备注
objvSysCommentEN.CommentTypeName = objRow[convSysComment.CommentTypeName] == DBNull.Value ? null : objRow[convSysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCommentEN.CommentTable = objRow[convSysComment.CommentTable] == DBNull.Value ? null : objRow[convSysComment.CommentTable].ToString().Trim(); //评论表
objvSysCommentEN.CommentTableId = objRow[convSysComment.CommentTableId] == DBNull.Value ? null : objRow[convSysComment.CommentTableId].ToString().Trim(); //评论表Id
objvSysCommentEN.OkCount = objRow[convSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysComment.OkCount].ToString().Trim()); //点赞统计
objvSysCommentEN.PubParentId = objRow[convSysComment.PubParentId] == DBNull.Value ? null : objRow[convSysComment.PubParentId].ToString().Trim(); //公共父Id
objvSysCommentEN.IdCurrEduCls = objRow[convSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysCommentEN.UserId = objRow[convSysComment.UserId] == DBNull.Value ? null : objRow[convSysComment.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCommentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSysCommentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSysCommentEN> GetSubObjLstCache(clsvSysCommentEN objvSysCommentCond)
{
 string strIdCurrEduCls = objvSysCommentCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvSysCommentBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvSysCommentEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvSysCommentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSysComment.AttributeName)
{
if (objvSysCommentCond.IsUpdated(strFldName) == false) continue;
if (objvSysCommentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysCommentCond[strFldName].ToString());
}
else
{
if (objvSysCommentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSysCommentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysCommentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSysCommentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSysCommentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSysCommentCond[strFldName]));
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
public static List<clsvSysCommentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSysCommentEN> arrObjLst = new List<clsvSysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCommentEN objvSysCommentEN = new clsvSysCommentEN();
try
{
objvSysCommentEN.CommentId = objRow[convSysComment.CommentId].ToString().Trim(); //评论Id
objvSysCommentEN.Comment = objRow[convSysComment.Comment] == DBNull.Value ? null : objRow[convSysComment.Comment].ToString().Trim(); //评论
objvSysCommentEN.Score = objRow[convSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysComment.Score].ToString().Trim()); //评分
objvSysCommentEN.CommentTypeId = objRow[convSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objvSysCommentEN.ScoreType = objRow[convSysComment.ScoreType] == DBNull.Value ? null : objRow[convSysComment.ScoreType].ToString().Trim(); //评分类型
objvSysCommentEN.ParentId = objRow[convSysComment.ParentId].ToString().Trim(); //父Id
objvSysCommentEN.TableKey = objRow[convSysComment.TableKey] == DBNull.Value ? null : objRow[convSysComment.TableKey].ToString().Trim(); //表主键
objvSysCommentEN.UpdUser = objRow[convSysComment.UpdUser] == DBNull.Value ? null : objRow[convSysComment.UpdUser].ToString().Trim(); //修改人
objvSysCommentEN.UpdDate = objRow[convSysComment.UpdDate] == DBNull.Value ? null : objRow[convSysComment.UpdDate].ToString().Trim(); //修改日期
objvSysCommentEN.Memo = objRow[convSysComment.Memo] == DBNull.Value ? null : objRow[convSysComment.Memo].ToString().Trim(); //备注
objvSysCommentEN.CommentTypeName = objRow[convSysComment.CommentTypeName] == DBNull.Value ? null : objRow[convSysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCommentEN.CommentTable = objRow[convSysComment.CommentTable] == DBNull.Value ? null : objRow[convSysComment.CommentTable].ToString().Trim(); //评论表
objvSysCommentEN.CommentTableId = objRow[convSysComment.CommentTableId] == DBNull.Value ? null : objRow[convSysComment.CommentTableId].ToString().Trim(); //评论表Id
objvSysCommentEN.OkCount = objRow[convSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysComment.OkCount].ToString().Trim()); //点赞统计
objvSysCommentEN.PubParentId = objRow[convSysComment.PubParentId] == DBNull.Value ? null : objRow[convSysComment.PubParentId].ToString().Trim(); //公共父Id
objvSysCommentEN.IdCurrEduCls = objRow[convSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysCommentEN.UserId = objRow[convSysComment.UserId] == DBNull.Value ? null : objRow[convSysComment.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCommentEN);
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
public static List<clsvSysCommentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSysCommentEN> arrObjLst = new List<clsvSysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCommentEN objvSysCommentEN = new clsvSysCommentEN();
try
{
objvSysCommentEN.CommentId = objRow[convSysComment.CommentId].ToString().Trim(); //评论Id
objvSysCommentEN.Comment = objRow[convSysComment.Comment] == DBNull.Value ? null : objRow[convSysComment.Comment].ToString().Trim(); //评论
objvSysCommentEN.Score = objRow[convSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysComment.Score].ToString().Trim()); //评分
objvSysCommentEN.CommentTypeId = objRow[convSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objvSysCommentEN.ScoreType = objRow[convSysComment.ScoreType] == DBNull.Value ? null : objRow[convSysComment.ScoreType].ToString().Trim(); //评分类型
objvSysCommentEN.ParentId = objRow[convSysComment.ParentId].ToString().Trim(); //父Id
objvSysCommentEN.TableKey = objRow[convSysComment.TableKey] == DBNull.Value ? null : objRow[convSysComment.TableKey].ToString().Trim(); //表主键
objvSysCommentEN.UpdUser = objRow[convSysComment.UpdUser] == DBNull.Value ? null : objRow[convSysComment.UpdUser].ToString().Trim(); //修改人
objvSysCommentEN.UpdDate = objRow[convSysComment.UpdDate] == DBNull.Value ? null : objRow[convSysComment.UpdDate].ToString().Trim(); //修改日期
objvSysCommentEN.Memo = objRow[convSysComment.Memo] == DBNull.Value ? null : objRow[convSysComment.Memo].ToString().Trim(); //备注
objvSysCommentEN.CommentTypeName = objRow[convSysComment.CommentTypeName] == DBNull.Value ? null : objRow[convSysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCommentEN.CommentTable = objRow[convSysComment.CommentTable] == DBNull.Value ? null : objRow[convSysComment.CommentTable].ToString().Trim(); //评论表
objvSysCommentEN.CommentTableId = objRow[convSysComment.CommentTableId] == DBNull.Value ? null : objRow[convSysComment.CommentTableId].ToString().Trim(); //评论表Id
objvSysCommentEN.OkCount = objRow[convSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysComment.OkCount].ToString().Trim()); //点赞统计
objvSysCommentEN.PubParentId = objRow[convSysComment.PubParentId] == DBNull.Value ? null : objRow[convSysComment.PubParentId].ToString().Trim(); //公共父Id
objvSysCommentEN.IdCurrEduCls = objRow[convSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysCommentEN.UserId = objRow[convSysComment.UserId] == DBNull.Value ? null : objRow[convSysComment.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCommentEN);
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
List<clsvSysCommentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSysCommentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysCommentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSysCommentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSysCommentEN> arrObjLst = new List<clsvSysCommentEN>(); 
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
	clsvSysCommentEN objvSysCommentEN = new clsvSysCommentEN();
try
{
objvSysCommentEN.CommentId = objRow[convSysComment.CommentId].ToString().Trim(); //评论Id
objvSysCommentEN.Comment = objRow[convSysComment.Comment] == DBNull.Value ? null : objRow[convSysComment.Comment].ToString().Trim(); //评论
objvSysCommentEN.Score = objRow[convSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysComment.Score].ToString().Trim()); //评分
objvSysCommentEN.CommentTypeId = objRow[convSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objvSysCommentEN.ScoreType = objRow[convSysComment.ScoreType] == DBNull.Value ? null : objRow[convSysComment.ScoreType].ToString().Trim(); //评分类型
objvSysCommentEN.ParentId = objRow[convSysComment.ParentId].ToString().Trim(); //父Id
objvSysCommentEN.TableKey = objRow[convSysComment.TableKey] == DBNull.Value ? null : objRow[convSysComment.TableKey].ToString().Trim(); //表主键
objvSysCommentEN.UpdUser = objRow[convSysComment.UpdUser] == DBNull.Value ? null : objRow[convSysComment.UpdUser].ToString().Trim(); //修改人
objvSysCommentEN.UpdDate = objRow[convSysComment.UpdDate] == DBNull.Value ? null : objRow[convSysComment.UpdDate].ToString().Trim(); //修改日期
objvSysCommentEN.Memo = objRow[convSysComment.Memo] == DBNull.Value ? null : objRow[convSysComment.Memo].ToString().Trim(); //备注
objvSysCommentEN.CommentTypeName = objRow[convSysComment.CommentTypeName] == DBNull.Value ? null : objRow[convSysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCommentEN.CommentTable = objRow[convSysComment.CommentTable] == DBNull.Value ? null : objRow[convSysComment.CommentTable].ToString().Trim(); //评论表
objvSysCommentEN.CommentTableId = objRow[convSysComment.CommentTableId] == DBNull.Value ? null : objRow[convSysComment.CommentTableId].ToString().Trim(); //评论表Id
objvSysCommentEN.OkCount = objRow[convSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysComment.OkCount].ToString().Trim()); //点赞统计
objvSysCommentEN.PubParentId = objRow[convSysComment.PubParentId] == DBNull.Value ? null : objRow[convSysComment.PubParentId].ToString().Trim(); //公共父Id
objvSysCommentEN.IdCurrEduCls = objRow[convSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysCommentEN.UserId = objRow[convSysComment.UserId] == DBNull.Value ? null : objRow[convSysComment.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCommentEN);
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
public static List<clsvSysCommentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSysCommentEN> arrObjLst = new List<clsvSysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCommentEN objvSysCommentEN = new clsvSysCommentEN();
try
{
objvSysCommentEN.CommentId = objRow[convSysComment.CommentId].ToString().Trim(); //评论Id
objvSysCommentEN.Comment = objRow[convSysComment.Comment] == DBNull.Value ? null : objRow[convSysComment.Comment].ToString().Trim(); //评论
objvSysCommentEN.Score = objRow[convSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysComment.Score].ToString().Trim()); //评分
objvSysCommentEN.CommentTypeId = objRow[convSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objvSysCommentEN.ScoreType = objRow[convSysComment.ScoreType] == DBNull.Value ? null : objRow[convSysComment.ScoreType].ToString().Trim(); //评分类型
objvSysCommentEN.ParentId = objRow[convSysComment.ParentId].ToString().Trim(); //父Id
objvSysCommentEN.TableKey = objRow[convSysComment.TableKey] == DBNull.Value ? null : objRow[convSysComment.TableKey].ToString().Trim(); //表主键
objvSysCommentEN.UpdUser = objRow[convSysComment.UpdUser] == DBNull.Value ? null : objRow[convSysComment.UpdUser].ToString().Trim(); //修改人
objvSysCommentEN.UpdDate = objRow[convSysComment.UpdDate] == DBNull.Value ? null : objRow[convSysComment.UpdDate].ToString().Trim(); //修改日期
objvSysCommentEN.Memo = objRow[convSysComment.Memo] == DBNull.Value ? null : objRow[convSysComment.Memo].ToString().Trim(); //备注
objvSysCommentEN.CommentTypeName = objRow[convSysComment.CommentTypeName] == DBNull.Value ? null : objRow[convSysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCommentEN.CommentTable = objRow[convSysComment.CommentTable] == DBNull.Value ? null : objRow[convSysComment.CommentTable].ToString().Trim(); //评论表
objvSysCommentEN.CommentTableId = objRow[convSysComment.CommentTableId] == DBNull.Value ? null : objRow[convSysComment.CommentTableId].ToString().Trim(); //评论表Id
objvSysCommentEN.OkCount = objRow[convSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysComment.OkCount].ToString().Trim()); //点赞统计
objvSysCommentEN.PubParentId = objRow[convSysComment.PubParentId] == DBNull.Value ? null : objRow[convSysComment.PubParentId].ToString().Trim(); //公共父Id
objvSysCommentEN.IdCurrEduCls = objRow[convSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysCommentEN.UserId = objRow[convSysComment.UserId] == DBNull.Value ? null : objRow[convSysComment.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCommentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSysCommentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSysCommentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSysCommentEN> arrObjLst = new List<clsvSysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCommentEN objvSysCommentEN = new clsvSysCommentEN();
try
{
objvSysCommentEN.CommentId = objRow[convSysComment.CommentId].ToString().Trim(); //评论Id
objvSysCommentEN.Comment = objRow[convSysComment.Comment] == DBNull.Value ? null : objRow[convSysComment.Comment].ToString().Trim(); //评论
objvSysCommentEN.Score = objRow[convSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysComment.Score].ToString().Trim()); //评分
objvSysCommentEN.CommentTypeId = objRow[convSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objvSysCommentEN.ScoreType = objRow[convSysComment.ScoreType] == DBNull.Value ? null : objRow[convSysComment.ScoreType].ToString().Trim(); //评分类型
objvSysCommentEN.ParentId = objRow[convSysComment.ParentId].ToString().Trim(); //父Id
objvSysCommentEN.TableKey = objRow[convSysComment.TableKey] == DBNull.Value ? null : objRow[convSysComment.TableKey].ToString().Trim(); //表主键
objvSysCommentEN.UpdUser = objRow[convSysComment.UpdUser] == DBNull.Value ? null : objRow[convSysComment.UpdUser].ToString().Trim(); //修改人
objvSysCommentEN.UpdDate = objRow[convSysComment.UpdDate] == DBNull.Value ? null : objRow[convSysComment.UpdDate].ToString().Trim(); //修改日期
objvSysCommentEN.Memo = objRow[convSysComment.Memo] == DBNull.Value ? null : objRow[convSysComment.Memo].ToString().Trim(); //备注
objvSysCommentEN.CommentTypeName = objRow[convSysComment.CommentTypeName] == DBNull.Value ? null : objRow[convSysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCommentEN.CommentTable = objRow[convSysComment.CommentTable] == DBNull.Value ? null : objRow[convSysComment.CommentTable].ToString().Trim(); //评论表
objvSysCommentEN.CommentTableId = objRow[convSysComment.CommentTableId] == DBNull.Value ? null : objRow[convSysComment.CommentTableId].ToString().Trim(); //评论表Id
objvSysCommentEN.OkCount = objRow[convSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysComment.OkCount].ToString().Trim()); //点赞统计
objvSysCommentEN.PubParentId = objRow[convSysComment.PubParentId] == DBNull.Value ? null : objRow[convSysComment.PubParentId].ToString().Trim(); //公共父Id
objvSysCommentEN.IdCurrEduCls = objRow[convSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysCommentEN.UserId = objRow[convSysComment.UserId] == DBNull.Value ? null : objRow[convSysComment.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCommentEN);
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
public static List<clsvSysCommentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSysCommentEN> arrObjLst = new List<clsvSysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCommentEN objvSysCommentEN = new clsvSysCommentEN();
try
{
objvSysCommentEN.CommentId = objRow[convSysComment.CommentId].ToString().Trim(); //评论Id
objvSysCommentEN.Comment = objRow[convSysComment.Comment] == DBNull.Value ? null : objRow[convSysComment.Comment].ToString().Trim(); //评论
objvSysCommentEN.Score = objRow[convSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysComment.Score].ToString().Trim()); //评分
objvSysCommentEN.CommentTypeId = objRow[convSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objvSysCommentEN.ScoreType = objRow[convSysComment.ScoreType] == DBNull.Value ? null : objRow[convSysComment.ScoreType].ToString().Trim(); //评分类型
objvSysCommentEN.ParentId = objRow[convSysComment.ParentId].ToString().Trim(); //父Id
objvSysCommentEN.TableKey = objRow[convSysComment.TableKey] == DBNull.Value ? null : objRow[convSysComment.TableKey].ToString().Trim(); //表主键
objvSysCommentEN.UpdUser = objRow[convSysComment.UpdUser] == DBNull.Value ? null : objRow[convSysComment.UpdUser].ToString().Trim(); //修改人
objvSysCommentEN.UpdDate = objRow[convSysComment.UpdDate] == DBNull.Value ? null : objRow[convSysComment.UpdDate].ToString().Trim(); //修改日期
objvSysCommentEN.Memo = objRow[convSysComment.Memo] == DBNull.Value ? null : objRow[convSysComment.Memo].ToString().Trim(); //备注
objvSysCommentEN.CommentTypeName = objRow[convSysComment.CommentTypeName] == DBNull.Value ? null : objRow[convSysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCommentEN.CommentTable = objRow[convSysComment.CommentTable] == DBNull.Value ? null : objRow[convSysComment.CommentTable].ToString().Trim(); //评论表
objvSysCommentEN.CommentTableId = objRow[convSysComment.CommentTableId] == DBNull.Value ? null : objRow[convSysComment.CommentTableId].ToString().Trim(); //评论表Id
objvSysCommentEN.OkCount = objRow[convSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysComment.OkCount].ToString().Trim()); //点赞统计
objvSysCommentEN.PubParentId = objRow[convSysComment.PubParentId] == DBNull.Value ? null : objRow[convSysComment.PubParentId].ToString().Trim(); //公共父Id
objvSysCommentEN.IdCurrEduCls = objRow[convSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysCommentEN.UserId = objRow[convSysComment.UserId] == DBNull.Value ? null : objRow[convSysComment.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCommentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysCommentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSysCommentEN> arrObjLst = new List<clsvSysCommentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysCommentEN objvSysCommentEN = new clsvSysCommentEN();
try
{
objvSysCommentEN.CommentId = objRow[convSysComment.CommentId].ToString().Trim(); //评论Id
objvSysCommentEN.Comment = objRow[convSysComment.Comment] == DBNull.Value ? null : objRow[convSysComment.Comment].ToString().Trim(); //评论
objvSysCommentEN.Score = objRow[convSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysComment.Score].ToString().Trim()); //评分
objvSysCommentEN.CommentTypeId = objRow[convSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objvSysCommentEN.ScoreType = objRow[convSysComment.ScoreType] == DBNull.Value ? null : objRow[convSysComment.ScoreType].ToString().Trim(); //评分类型
objvSysCommentEN.ParentId = objRow[convSysComment.ParentId].ToString().Trim(); //父Id
objvSysCommentEN.TableKey = objRow[convSysComment.TableKey] == DBNull.Value ? null : objRow[convSysComment.TableKey].ToString().Trim(); //表主键
objvSysCommentEN.UpdUser = objRow[convSysComment.UpdUser] == DBNull.Value ? null : objRow[convSysComment.UpdUser].ToString().Trim(); //修改人
objvSysCommentEN.UpdDate = objRow[convSysComment.UpdDate] == DBNull.Value ? null : objRow[convSysComment.UpdDate].ToString().Trim(); //修改日期
objvSysCommentEN.Memo = objRow[convSysComment.Memo] == DBNull.Value ? null : objRow[convSysComment.Memo].ToString().Trim(); //备注
objvSysCommentEN.CommentTypeName = objRow[convSysComment.CommentTypeName] == DBNull.Value ? null : objRow[convSysComment.CommentTypeName].ToString().Trim(); //评论类型名
objvSysCommentEN.CommentTable = objRow[convSysComment.CommentTable] == DBNull.Value ? null : objRow[convSysComment.CommentTable].ToString().Trim(); //评论表
objvSysCommentEN.CommentTableId = objRow[convSysComment.CommentTableId] == DBNull.Value ? null : objRow[convSysComment.CommentTableId].ToString().Trim(); //评论表Id
objvSysCommentEN.OkCount = objRow[convSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysComment.OkCount].ToString().Trim()); //点赞统计
objvSysCommentEN.PubParentId = objRow[convSysComment.PubParentId] == DBNull.Value ? null : objRow[convSysComment.PubParentId].ToString().Trim(); //公共父Id
objvSysCommentEN.IdCurrEduCls = objRow[convSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysCommentEN.UserId = objRow[convSysComment.UserId] == DBNull.Value ? null : objRow[convSysComment.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysCommentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSysCommentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSysComment(ref clsvSysCommentEN objvSysCommentEN)
{
bool bolResult = vSysCommentDA.GetvSysComment(ref objvSysCommentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCommentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysCommentEN GetObjByCommentId(string strCommentId)
{
if (strCommentId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCommentId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCommentId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCommentId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvSysCommentEN objvSysCommentEN = vSysCommentDA.GetObjByCommentId(strCommentId);
return objvSysCommentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSysCommentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSysCommentEN objvSysCommentEN = vSysCommentDA.GetFirstObj(strWhereCond);
 return objvSysCommentEN;
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
public static clsvSysCommentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSysCommentEN objvSysCommentEN = vSysCommentDA.GetObjByDataRow(objRow);
 return objvSysCommentEN;
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
public static clsvSysCommentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSysCommentEN objvSysCommentEN = vSysCommentDA.GetObjByDataRow(objRow);
 return objvSysCommentEN;
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
 /// <param name = "strCommentId">所给的关键字</param>
 /// <param name = "lstvSysCommentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSysCommentEN GetObjByCommentIdFromList(string strCommentId, List<clsvSysCommentEN> lstvSysCommentObjLst)
{
foreach (clsvSysCommentEN objvSysCommentEN in lstvSysCommentObjLst)
{
if (objvSysCommentEN.CommentId == strCommentId)
{
return objvSysCommentEN;
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
 string strCommentId;
 try
 {
 strCommentId = new clsvSysCommentDA().GetFirstID(strWhereCond);
 return strCommentId;
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
 arrList = vSysCommentDA.GetID(strWhereCond);
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
bool bolIsExist = vSysCommentDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCommentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCommentId)
{
if (string.IsNullOrEmpty(strCommentId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCommentId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vSysCommentDA.IsExist(strCommentId);
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
 bolIsExist = clsvSysCommentDA.IsExistTable();
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
 bolIsExist = vSysCommentDA.IsExistTable(strTabName);
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
 /// <param name = "objvSysCommentENS">源对象</param>
 /// <param name = "objvSysCommentENT">目标对象</param>
 public static void CopyTo(clsvSysCommentEN objvSysCommentENS, clsvSysCommentEN objvSysCommentENT)
{
try
{
objvSysCommentENT.CommentId = objvSysCommentENS.CommentId; //评论Id
objvSysCommentENT.Comment = objvSysCommentENS.Comment; //评论
objvSysCommentENT.Score = objvSysCommentENS.Score; //评分
objvSysCommentENT.CommentTypeId = objvSysCommentENS.CommentTypeId; //评论类型Id
objvSysCommentENT.ScoreType = objvSysCommentENS.ScoreType; //评分类型
objvSysCommentENT.ParentId = objvSysCommentENS.ParentId; //父Id
objvSysCommentENT.TableKey = objvSysCommentENS.TableKey; //表主键
objvSysCommentENT.UpdUser = objvSysCommentENS.UpdUser; //修改人
objvSysCommentENT.UpdDate = objvSysCommentENS.UpdDate; //修改日期
objvSysCommentENT.Memo = objvSysCommentENS.Memo; //备注
objvSysCommentENT.CommentTypeName = objvSysCommentENS.CommentTypeName; //评论类型名
objvSysCommentENT.CommentTable = objvSysCommentENS.CommentTable; //评论表
objvSysCommentENT.CommentTableId = objvSysCommentENS.CommentTableId; //评论表Id
objvSysCommentENT.OkCount = objvSysCommentENS.OkCount; //点赞统计
objvSysCommentENT.PubParentId = objvSysCommentENS.PubParentId; //公共父Id
objvSysCommentENT.IdCurrEduCls = objvSysCommentENS.IdCurrEduCls; //教学班流水号
objvSysCommentENT.UserId = objvSysCommentENS.UserId; //用户ID
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
 /// <param name = "objvSysCommentEN">源简化对象</param>
 public static void SetUpdFlag(clsvSysCommentEN objvSysCommentEN)
{
try
{
objvSysCommentEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSysCommentEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSysComment.CommentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCommentEN.CommentId = objvSysCommentEN.CommentId; //评论Id
}
if (arrFldSet.Contains(convSysComment.Comment, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCommentEN.Comment = objvSysCommentEN.Comment == "[null]" ? null :  objvSysCommentEN.Comment; //评论
}
if (arrFldSet.Contains(convSysComment.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCommentEN.Score = objvSysCommentEN.Score; //评分
}
if (arrFldSet.Contains(convSysComment.CommentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCommentEN.CommentTypeId = objvSysCommentEN.CommentTypeId; //评论类型Id
}
if (arrFldSet.Contains(convSysComment.ScoreType, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCommentEN.ScoreType = objvSysCommentEN.ScoreType == "[null]" ? null :  objvSysCommentEN.ScoreType; //评分类型
}
if (arrFldSet.Contains(convSysComment.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCommentEN.ParentId = objvSysCommentEN.ParentId; //父Id
}
if (arrFldSet.Contains(convSysComment.TableKey, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCommentEN.TableKey = objvSysCommentEN.TableKey == "[null]" ? null :  objvSysCommentEN.TableKey; //表主键
}
if (arrFldSet.Contains(convSysComment.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCommentEN.UpdUser = objvSysCommentEN.UpdUser == "[null]" ? null :  objvSysCommentEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convSysComment.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCommentEN.UpdDate = objvSysCommentEN.UpdDate == "[null]" ? null :  objvSysCommentEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convSysComment.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCommentEN.Memo = objvSysCommentEN.Memo == "[null]" ? null :  objvSysCommentEN.Memo; //备注
}
if (arrFldSet.Contains(convSysComment.CommentTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCommentEN.CommentTypeName = objvSysCommentEN.CommentTypeName == "[null]" ? null :  objvSysCommentEN.CommentTypeName; //评论类型名
}
if (arrFldSet.Contains(convSysComment.CommentTable, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCommentEN.CommentTable = objvSysCommentEN.CommentTable == "[null]" ? null :  objvSysCommentEN.CommentTable; //评论表
}
if (arrFldSet.Contains(convSysComment.CommentTableId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCommentEN.CommentTableId = objvSysCommentEN.CommentTableId == "[null]" ? null :  objvSysCommentEN.CommentTableId; //评论表Id
}
if (arrFldSet.Contains(convSysComment.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCommentEN.OkCount = objvSysCommentEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convSysComment.PubParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCommentEN.PubParentId = objvSysCommentEN.PubParentId == "[null]" ? null :  objvSysCommentEN.PubParentId; //公共父Id
}
if (arrFldSet.Contains(convSysComment.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCommentEN.IdCurrEduCls = objvSysCommentEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convSysComment.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysCommentEN.UserId = objvSysCommentEN.UserId == "[null]" ? null :  objvSysCommentEN.UserId; //用户ID
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
 /// <param name = "objvSysCommentEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSysCommentEN objvSysCommentEN)
{
try
{
if (objvSysCommentEN.Comment == "[null]") objvSysCommentEN.Comment = null; //评论
if (objvSysCommentEN.ScoreType == "[null]") objvSysCommentEN.ScoreType = null; //评分类型
if (objvSysCommentEN.TableKey == "[null]") objvSysCommentEN.TableKey = null; //表主键
if (objvSysCommentEN.UpdUser == "[null]") objvSysCommentEN.UpdUser = null; //修改人
if (objvSysCommentEN.UpdDate == "[null]") objvSysCommentEN.UpdDate = null; //修改日期
if (objvSysCommentEN.Memo == "[null]") objvSysCommentEN.Memo = null; //备注
if (objvSysCommentEN.CommentTypeName == "[null]") objvSysCommentEN.CommentTypeName = null; //评论类型名
if (objvSysCommentEN.CommentTable == "[null]") objvSysCommentEN.CommentTable = null; //评论表
if (objvSysCommentEN.CommentTableId == "[null]") objvSysCommentEN.CommentTableId = null; //评论表Id
if (objvSysCommentEN.PubParentId == "[null]") objvSysCommentEN.PubParentId = null; //公共父Id
if (objvSysCommentEN.UserId == "[null]") objvSysCommentEN.UserId = null; //用户ID
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
public static void CheckProperty4Condition(clsvSysCommentEN objvSysCommentEN)
{
 vSysCommentDA.CheckProperty4Condition(objvSysCommentEN);
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
if (clsSysCommentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysCommentBL没有刷新缓存机制(clsSysCommentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSysCommentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysCommentTypeBL没有刷新缓存机制(clsSysCommentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CommentId");
//if (arrvSysCommentObjLstCache == null)
//{
//arrvSysCommentObjLstCache = vSysCommentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCommentId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSysCommentEN GetObjByCommentIdCache(string strCommentId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvSysCommentEN._CurrTabName, strIdCurrEduCls);
List<clsvSysCommentEN> arrvSysCommentObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvSysCommentEN> arrvSysCommentObjLst_Sel =
arrvSysCommentObjLstCache
.Where(x=> x.CommentId == strCommentId 
);
if (arrvSysCommentObjLst_Sel.Count() == 0)
{
   clsvSysCommentEN obj = clsvSysCommentBL.GetObjByCommentId(strCommentId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strCommentId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvSysCommentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSysCommentEN> GetAllvSysCommentObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvSysCommentEN> arrvSysCommentObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvSysCommentObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSysCommentEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvSysCommentEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvSysCommentEN> arrvSysCommentObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvSysCommentObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvSysCommentEN._CurrTabName, strIdCurrEduCls);
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
public static string Func(string strInFldName, string strOutFldName, string strCommentId, string strIdCurrEduCls)
{
if (strInFldName != convSysComment.CommentId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSysComment.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSysComment.AttributeName));
throw new Exception(strMsg);
}
var objvSysComment = clsvSysCommentBL.GetObjByCommentIdCache(strCommentId, strIdCurrEduCls);
if (objvSysComment == null) return "";
return objvSysComment[strOutFldName].ToString();
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
int intRecCount = clsvSysCommentDA.GetRecCount(strTabName);
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
int intRecCount = clsvSysCommentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSysCommentDA.GetRecCount();
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
int intRecCount = clsvSysCommentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSysCommentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSysCommentEN objvSysCommentCond)
{
 string strIdCurrEduCls = objvSysCommentCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvSysCommentBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvSysCommentEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvSysCommentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSysComment.AttributeName)
{
if (objvSysCommentCond.IsUpdated(strFldName) == false) continue;
if (objvSysCommentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysCommentCond[strFldName].ToString());
}
else
{
if (objvSysCommentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSysCommentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysCommentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSysCommentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSysCommentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSysCommentCond[strFldName]));
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
 List<string> arrList = clsvSysCommentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSysCommentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSysCommentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}