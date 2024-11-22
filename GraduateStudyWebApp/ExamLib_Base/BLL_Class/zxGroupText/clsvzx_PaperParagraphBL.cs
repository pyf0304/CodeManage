
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_PaperParagraphBL
 表名:vzx_PaperParagraph(01120766)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:50:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
public static class  clsvzx_PaperParagraphBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxParagraphId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_PaperParagraphEN GetObj(this K_zxParagraphId_vzx_PaperParagraph myKey)
{
clsvzx_PaperParagraphEN objvzx_PaperParagraphEN = clsvzx_PaperParagraphBL.vzx_PaperParagraphDA.GetObjByzxParagraphId(myKey.Value);
return objvzx_PaperParagraphEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperParagraphEN SetParagraphTypeName(this clsvzx_PaperParagraphEN objvzx_PaperParagraphEN, string strParagraphTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParagraphTypeName, 100, convzx_PaperParagraph.ParagraphTypeName);
}
objvzx_PaperParagraphEN.ParagraphTypeName = strParagraphTypeName; //段落类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convzx_PaperParagraph.ParagraphTypeName) == false)
{
objvzx_PaperParagraphEN.dicFldComparisonOp.Add(convzx_PaperParagraph.ParagraphTypeName, strComparisonOp);
}
else
{
objvzx_PaperParagraphEN.dicFldComparisonOp[convzx_PaperParagraph.ParagraphTypeName] = strComparisonOp;
}
}
return objvzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperParagraphEN SetParagraphStateName(this clsvzx_PaperParagraphEN objvzx_PaperParagraphEN, string strParagraphStateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParagraphStateName, 100, convzx_PaperParagraph.ParagraphStateName);
}
objvzx_PaperParagraphEN.ParagraphStateName = strParagraphStateName; //段落状态
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convzx_PaperParagraph.ParagraphStateName) == false)
{
objvzx_PaperParagraphEN.dicFldComparisonOp.Add(convzx_PaperParagraph.ParagraphStateName, strComparisonOp);
}
else
{
objvzx_PaperParagraphEN.dicFldComparisonOp[convzx_PaperParagraph.ParagraphStateName] = strComparisonOp;
}
}
return objvzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperParagraphEN SetzxParagraphId(this clsvzx_PaperParagraphEN objvzx_PaperParagraphEN, string strzxParagraphId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxParagraphId, 10, convzx_PaperParagraph.zxParagraphId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxParagraphId, 10, convzx_PaperParagraph.zxParagraphId);
}
objvzx_PaperParagraphEN.zxParagraphId = strzxParagraphId; //段落Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convzx_PaperParagraph.zxParagraphId) == false)
{
objvzx_PaperParagraphEN.dicFldComparisonOp.Add(convzx_PaperParagraph.zxParagraphId, strComparisonOp);
}
else
{
objvzx_PaperParagraphEN.dicFldComparisonOp[convzx_PaperParagraph.zxParagraphId] = strComparisonOp;
}
}
return objvzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperParagraphEN SetTextId(this clsvzx_PaperParagraphEN objvzx_PaperParagraphEN, string strTextId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextId, convzx_PaperParagraph.TextId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_PaperParagraph.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_PaperParagraph.TextId);
}
objvzx_PaperParagraphEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convzx_PaperParagraph.TextId) == false)
{
objvzx_PaperParagraphEN.dicFldComparisonOp.Add(convzx_PaperParagraph.TextId, strComparisonOp);
}
else
{
objvzx_PaperParagraphEN.dicFldComparisonOp[convzx_PaperParagraph.TextId] = strComparisonOp;
}
}
return objvzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperParagraphEN SetzxSectionId(this clsvzx_PaperParagraphEN objvzx_PaperParagraphEN, string strzxSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxSectionId, convzx_PaperParagraph.zxSectionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxSectionId, 8, convzx_PaperParagraph.zxSectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxSectionId, 8, convzx_PaperParagraph.zxSectionId);
}
objvzx_PaperParagraphEN.zxSectionId = strzxSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convzx_PaperParagraph.zxSectionId) == false)
{
objvzx_PaperParagraphEN.dicFldComparisonOp.Add(convzx_PaperParagraph.zxSectionId, strComparisonOp);
}
else
{
objvzx_PaperParagraphEN.dicFldComparisonOp[convzx_PaperParagraph.zxSectionId] = strComparisonOp;
}
}
return objvzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperParagraphEN SetzxParagraphStateId(this clsvzx_PaperParagraphEN objvzx_PaperParagraphEN, string strzxParagraphStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxParagraphStateId, convzx_PaperParagraph.zxParagraphStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxParagraphStateId, 2, convzx_PaperParagraph.zxParagraphStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxParagraphStateId, 2, convzx_PaperParagraph.zxParagraphStateId);
}
objvzx_PaperParagraphEN.zxParagraphStateId = strzxParagraphStateId; //段落状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convzx_PaperParagraph.zxParagraphStateId) == false)
{
objvzx_PaperParagraphEN.dicFldComparisonOp.Add(convzx_PaperParagraph.zxParagraphStateId, strComparisonOp);
}
else
{
objvzx_PaperParagraphEN.dicFldComparisonOp[convzx_PaperParagraph.zxParagraphStateId] = strComparisonOp;
}
}
return objvzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperParagraphEN SetzxParagraphTypeId(this clsvzx_PaperParagraphEN objvzx_PaperParagraphEN, string strzxParagraphTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxParagraphTypeId, convzx_PaperParagraph.zxParagraphTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxParagraphTypeId, 2, convzx_PaperParagraph.zxParagraphTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxParagraphTypeId, 2, convzx_PaperParagraph.zxParagraphTypeId);
}
objvzx_PaperParagraphEN.zxParagraphTypeId = strzxParagraphTypeId; //段落类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convzx_PaperParagraph.zxParagraphTypeId) == false)
{
objvzx_PaperParagraphEN.dicFldComparisonOp.Add(convzx_PaperParagraph.zxParagraphTypeId, strComparisonOp);
}
else
{
objvzx_PaperParagraphEN.dicFldComparisonOp[convzx_PaperParagraph.zxParagraphTypeId] = strComparisonOp;
}
}
return objvzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperParagraphEN SetParagraphContent(this clsvzx_PaperParagraphEN objvzx_PaperParagraphEN, string strParagraphContent, string strComparisonOp="")
	{
objvzx_PaperParagraphEN.ParagraphContent = strParagraphContent; //段落内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convzx_PaperParagraph.ParagraphContent) == false)
{
objvzx_PaperParagraphEN.dicFldComparisonOp.Add(convzx_PaperParagraph.ParagraphContent, strComparisonOp);
}
else
{
objvzx_PaperParagraphEN.dicFldComparisonOp[convzx_PaperParagraph.ParagraphContent] = strComparisonOp;
}
}
return objvzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperParagraphEN SetVoteCount(this clsvzx_PaperParagraphEN objvzx_PaperParagraphEN, int? intVoteCount, string strComparisonOp="")
	{
objvzx_PaperParagraphEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convzx_PaperParagraph.VoteCount) == false)
{
objvzx_PaperParagraphEN.dicFldComparisonOp.Add(convzx_PaperParagraph.VoteCount, strComparisonOp);
}
else
{
objvzx_PaperParagraphEN.dicFldComparisonOp[convzx_PaperParagraph.VoteCount] = strComparisonOp;
}
}
return objvzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperParagraphEN SetCommentCount(this clsvzx_PaperParagraphEN objvzx_PaperParagraphEN, int? intCommentCount, string strComparisonOp="")
	{
objvzx_PaperParagraphEN.CommentCount = intCommentCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convzx_PaperParagraph.CommentCount) == false)
{
objvzx_PaperParagraphEN.dicFldComparisonOp.Add(convzx_PaperParagraph.CommentCount, strComparisonOp);
}
else
{
objvzx_PaperParagraphEN.dicFldComparisonOp[convzx_PaperParagraph.CommentCount] = strComparisonOp;
}
}
return objvzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperParagraphEN SetVersionCount(this clsvzx_PaperParagraphEN objvzx_PaperParagraphEN, int? intVersionCount, string strComparisonOp="")
	{
objvzx_PaperParagraphEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convzx_PaperParagraph.VersionCount) == false)
{
objvzx_PaperParagraphEN.dicFldComparisonOp.Add(convzx_PaperParagraph.VersionCount, strComparisonOp);
}
else
{
objvzx_PaperParagraphEN.dicFldComparisonOp[convzx_PaperParagraph.VersionCount] = strComparisonOp;
}
}
return objvzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperParagraphEN SetCreateDate(this clsvzx_PaperParagraphEN objvzx_PaperParagraphEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convzx_PaperParagraph.CreateDate);
}
objvzx_PaperParagraphEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convzx_PaperParagraph.CreateDate) == false)
{
objvzx_PaperParagraphEN.dicFldComparisonOp.Add(convzx_PaperParagraph.CreateDate, strComparisonOp);
}
else
{
objvzx_PaperParagraphEN.dicFldComparisonOp[convzx_PaperParagraph.CreateDate] = strComparisonOp;
}
}
return objvzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperParagraphEN SetCreateUser(this clsvzx_PaperParagraphEN objvzx_PaperParagraphEN, string strCreateUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUser, 50, convzx_PaperParagraph.CreateUser);
}
objvzx_PaperParagraphEN.CreateUser = strCreateUser; //建立用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convzx_PaperParagraph.CreateUser) == false)
{
objvzx_PaperParagraphEN.dicFldComparisonOp.Add(convzx_PaperParagraph.CreateUser, strComparisonOp);
}
else
{
objvzx_PaperParagraphEN.dicFldComparisonOp[convzx_PaperParagraph.CreateUser] = strComparisonOp;
}
}
return objvzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperParagraphEN SetUpdDate(this clsvzx_PaperParagraphEN objvzx_PaperParagraphEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_PaperParagraph.UpdDate);
}
objvzx_PaperParagraphEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convzx_PaperParagraph.UpdDate) == false)
{
objvzx_PaperParagraphEN.dicFldComparisonOp.Add(convzx_PaperParagraph.UpdDate, strComparisonOp);
}
else
{
objvzx_PaperParagraphEN.dicFldComparisonOp[convzx_PaperParagraph.UpdDate] = strComparisonOp;
}
}
return objvzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperParagraphEN SetUpdUser(this clsvzx_PaperParagraphEN objvzx_PaperParagraphEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_PaperParagraph.UpdUser);
}
objvzx_PaperParagraphEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convzx_PaperParagraph.UpdUser) == false)
{
objvzx_PaperParagraphEN.dicFldComparisonOp.Add(convzx_PaperParagraph.UpdUser, strComparisonOp);
}
else
{
objvzx_PaperParagraphEN.dicFldComparisonOp[convzx_PaperParagraph.UpdUser] = strComparisonOp;
}
}
return objvzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperParagraphEN SetMemo(this clsvzx_PaperParagraphEN objvzx_PaperParagraphEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_PaperParagraph.Memo);
}
objvzx_PaperParagraphEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convzx_PaperParagraph.Memo) == false)
{
objvzx_PaperParagraphEN.dicFldComparisonOp.Add(convzx_PaperParagraph.Memo, strComparisonOp);
}
else
{
objvzx_PaperParagraphEN.dicFldComparisonOp[convzx_PaperParagraph.Memo] = strComparisonOp;
}
}
return objvzx_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperParagraphEN SetOrderNum(this clsvzx_PaperParagraphEN objvzx_PaperParagraphEN, int? intOrderNum, string strComparisonOp="")
	{
objvzx_PaperParagraphEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convzx_PaperParagraph.OrderNum) == false)
{
objvzx_PaperParagraphEN.dicFldComparisonOp.Add(convzx_PaperParagraph.OrderNum, strComparisonOp);
}
else
{
objvzx_PaperParagraphEN.dicFldComparisonOp[convzx_PaperParagraph.OrderNum] = strComparisonOp;
}
}
return objvzx_PaperParagraphEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphENS">源对象</param>
 /// <param name = "objvzx_PaperParagraphENT">目标对象</param>
 public static void CopyTo(this clsvzx_PaperParagraphEN objvzx_PaperParagraphENS, clsvzx_PaperParagraphEN objvzx_PaperParagraphENT)
{
try
{
objvzx_PaperParagraphENT.ParagraphTypeName = objvzx_PaperParagraphENS.ParagraphTypeName; //段落类型
objvzx_PaperParagraphENT.ParagraphStateName = objvzx_PaperParagraphENS.ParagraphStateName; //段落状态
objvzx_PaperParagraphENT.zxParagraphId = objvzx_PaperParagraphENS.zxParagraphId; //段落Id
objvzx_PaperParagraphENT.TextId = objvzx_PaperParagraphENS.TextId; //课件Id
objvzx_PaperParagraphENT.zxSectionId = objvzx_PaperParagraphENS.zxSectionId; //节Id
objvzx_PaperParagraphENT.zxParagraphStateId = objvzx_PaperParagraphENS.zxParagraphStateId; //段落状态Id
objvzx_PaperParagraphENT.zxParagraphTypeId = objvzx_PaperParagraphENS.zxParagraphTypeId; //段落类型Id
objvzx_PaperParagraphENT.ParagraphContent = objvzx_PaperParagraphENS.ParagraphContent; //段落内容
objvzx_PaperParagraphENT.VoteCount = objvzx_PaperParagraphENS.VoteCount; //点赞计数
objvzx_PaperParagraphENT.CommentCount = objvzx_PaperParagraphENS.CommentCount; //评论数
objvzx_PaperParagraphENT.VersionCount = objvzx_PaperParagraphENS.VersionCount; //版本统计
objvzx_PaperParagraphENT.CreateDate = objvzx_PaperParagraphENS.CreateDate; //建立日期
objvzx_PaperParagraphENT.CreateUser = objvzx_PaperParagraphENS.CreateUser; //建立用户
objvzx_PaperParagraphENT.UpdDate = objvzx_PaperParagraphENS.UpdDate; //修改日期
objvzx_PaperParagraphENT.UpdUser = objvzx_PaperParagraphENS.UpdUser; //修改人
objvzx_PaperParagraphENT.Memo = objvzx_PaperParagraphENS.Memo; //备注
objvzx_PaperParagraphENT.OrderNum = objvzx_PaperParagraphENS.OrderNum; //序号
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
 /// <param name = "objvzx_PaperParagraphENS">源对象</param>
 /// <returns>目标对象=>clsvzx_PaperParagraphEN:objvzx_PaperParagraphENT</returns>
 public static clsvzx_PaperParagraphEN CopyTo(this clsvzx_PaperParagraphEN objvzx_PaperParagraphENS)
{
try
{
 clsvzx_PaperParagraphEN objvzx_PaperParagraphENT = new clsvzx_PaperParagraphEN()
{
ParagraphTypeName = objvzx_PaperParagraphENS.ParagraphTypeName, //段落类型
ParagraphStateName = objvzx_PaperParagraphENS.ParagraphStateName, //段落状态
zxParagraphId = objvzx_PaperParagraphENS.zxParagraphId, //段落Id
TextId = objvzx_PaperParagraphENS.TextId, //课件Id
zxSectionId = objvzx_PaperParagraphENS.zxSectionId, //节Id
zxParagraphStateId = objvzx_PaperParagraphENS.zxParagraphStateId, //段落状态Id
zxParagraphTypeId = objvzx_PaperParagraphENS.zxParagraphTypeId, //段落类型Id
ParagraphContent = objvzx_PaperParagraphENS.ParagraphContent, //段落内容
VoteCount = objvzx_PaperParagraphENS.VoteCount, //点赞计数
CommentCount = objvzx_PaperParagraphENS.CommentCount, //评论数
VersionCount = objvzx_PaperParagraphENS.VersionCount, //版本统计
CreateDate = objvzx_PaperParagraphENS.CreateDate, //建立日期
CreateUser = objvzx_PaperParagraphENS.CreateUser, //建立用户
UpdDate = objvzx_PaperParagraphENS.UpdDate, //修改日期
UpdUser = objvzx_PaperParagraphENS.UpdUser, //修改人
Memo = objvzx_PaperParagraphENS.Memo, //备注
OrderNum = objvzx_PaperParagraphENS.OrderNum, //序号
};
 return objvzx_PaperParagraphENT;
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
public static void CheckProperty4Condition(this clsvzx_PaperParagraphEN objvzx_PaperParagraphEN)
{
 clsvzx_PaperParagraphBL.vzx_PaperParagraphDA.CheckProperty4Condition(objvzx_PaperParagraphEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_PaperParagraphEN objvzx_PaperParagraphCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_PaperParagraphCond.IsUpdated(convzx_PaperParagraph.ParagraphTypeName) == true)
{
string strComparisonOpParagraphTypeName = objvzx_PaperParagraphCond.dicFldComparisonOp[convzx_PaperParagraph.ParagraphTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperParagraph.ParagraphTypeName, objvzx_PaperParagraphCond.ParagraphTypeName, strComparisonOpParagraphTypeName);
}
if (objvzx_PaperParagraphCond.IsUpdated(convzx_PaperParagraph.ParagraphStateName) == true)
{
string strComparisonOpParagraphStateName = objvzx_PaperParagraphCond.dicFldComparisonOp[convzx_PaperParagraph.ParagraphStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperParagraph.ParagraphStateName, objvzx_PaperParagraphCond.ParagraphStateName, strComparisonOpParagraphStateName);
}
if (objvzx_PaperParagraphCond.IsUpdated(convzx_PaperParagraph.zxParagraphId) == true)
{
string strComparisonOpzxParagraphId = objvzx_PaperParagraphCond.dicFldComparisonOp[convzx_PaperParagraph.zxParagraphId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperParagraph.zxParagraphId, objvzx_PaperParagraphCond.zxParagraphId, strComparisonOpzxParagraphId);
}
if (objvzx_PaperParagraphCond.IsUpdated(convzx_PaperParagraph.TextId) == true)
{
string strComparisonOpTextId = objvzx_PaperParagraphCond.dicFldComparisonOp[convzx_PaperParagraph.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperParagraph.TextId, objvzx_PaperParagraphCond.TextId, strComparisonOpTextId);
}
if (objvzx_PaperParagraphCond.IsUpdated(convzx_PaperParagraph.zxSectionId) == true)
{
string strComparisonOpzxSectionId = objvzx_PaperParagraphCond.dicFldComparisonOp[convzx_PaperParagraph.zxSectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperParagraph.zxSectionId, objvzx_PaperParagraphCond.zxSectionId, strComparisonOpzxSectionId);
}
if (objvzx_PaperParagraphCond.IsUpdated(convzx_PaperParagraph.zxParagraphStateId) == true)
{
string strComparisonOpzxParagraphStateId = objvzx_PaperParagraphCond.dicFldComparisonOp[convzx_PaperParagraph.zxParagraphStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperParagraph.zxParagraphStateId, objvzx_PaperParagraphCond.zxParagraphStateId, strComparisonOpzxParagraphStateId);
}
if (objvzx_PaperParagraphCond.IsUpdated(convzx_PaperParagraph.zxParagraphTypeId) == true)
{
string strComparisonOpzxParagraphTypeId = objvzx_PaperParagraphCond.dicFldComparisonOp[convzx_PaperParagraph.zxParagraphTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperParagraph.zxParagraphTypeId, objvzx_PaperParagraphCond.zxParagraphTypeId, strComparisonOpzxParagraphTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_PaperParagraphCond.IsUpdated(convzx_PaperParagraph.VoteCount) == true)
{
string strComparisonOpVoteCount = objvzx_PaperParagraphCond.dicFldComparisonOp[convzx_PaperParagraph.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperParagraph.VoteCount, objvzx_PaperParagraphCond.VoteCount, strComparisonOpVoteCount);
}
if (objvzx_PaperParagraphCond.IsUpdated(convzx_PaperParagraph.CommentCount) == true)
{
string strComparisonOpCommentCount = objvzx_PaperParagraphCond.dicFldComparisonOp[convzx_PaperParagraph.CommentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperParagraph.CommentCount, objvzx_PaperParagraphCond.CommentCount, strComparisonOpCommentCount);
}
if (objvzx_PaperParagraphCond.IsUpdated(convzx_PaperParagraph.VersionCount) == true)
{
string strComparisonOpVersionCount = objvzx_PaperParagraphCond.dicFldComparisonOp[convzx_PaperParagraph.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperParagraph.VersionCount, objvzx_PaperParagraphCond.VersionCount, strComparisonOpVersionCount);
}
if (objvzx_PaperParagraphCond.IsUpdated(convzx_PaperParagraph.CreateDate) == true)
{
string strComparisonOpCreateDate = objvzx_PaperParagraphCond.dicFldComparisonOp[convzx_PaperParagraph.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperParagraph.CreateDate, objvzx_PaperParagraphCond.CreateDate, strComparisonOpCreateDate);
}
if (objvzx_PaperParagraphCond.IsUpdated(convzx_PaperParagraph.CreateUser) == true)
{
string strComparisonOpCreateUser = objvzx_PaperParagraphCond.dicFldComparisonOp[convzx_PaperParagraph.CreateUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperParagraph.CreateUser, objvzx_PaperParagraphCond.CreateUser, strComparisonOpCreateUser);
}
if (objvzx_PaperParagraphCond.IsUpdated(convzx_PaperParagraph.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_PaperParagraphCond.dicFldComparisonOp[convzx_PaperParagraph.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperParagraph.UpdDate, objvzx_PaperParagraphCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_PaperParagraphCond.IsUpdated(convzx_PaperParagraph.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_PaperParagraphCond.dicFldComparisonOp[convzx_PaperParagraph.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperParagraph.UpdUser, objvzx_PaperParagraphCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_PaperParagraphCond.IsUpdated(convzx_PaperParagraph.Memo) == true)
{
string strComparisonOpMemo = objvzx_PaperParagraphCond.dicFldComparisonOp[convzx_PaperParagraph.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperParagraph.Memo, objvzx_PaperParagraphCond.Memo, strComparisonOpMemo);
}
if (objvzx_PaperParagraphCond.IsUpdated(convzx_PaperParagraph.OrderNum) == true)
{
string strComparisonOpOrderNum = objvzx_PaperParagraphCond.dicFldComparisonOp[convzx_PaperParagraph.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperParagraph.OrderNum, objvzx_PaperParagraphCond.OrderNum, strComparisonOpOrderNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_PaperParagraph
{
public virtual bool UpdRelaTabDate(string strzxParagraphId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_PaperParagraph(vzx_PaperParagraph)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_PaperParagraphBL
{
public static RelatedActions_vzx_PaperParagraph relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_PaperParagraphDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_PaperParagraphDA vzx_PaperParagraphDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_PaperParagraphDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_PaperParagraphBL()
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
if (string.IsNullOrEmpty(clsvzx_PaperParagraphEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_PaperParagraphEN._ConnectString);
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
public static DataTable GetDataTable_vzx_PaperParagraph(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_PaperParagraphDA.GetDataTable_vzx_PaperParagraph(strWhereCond);
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
objDT = vzx_PaperParagraphDA.GetDataTable(strWhereCond);
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
objDT = vzx_PaperParagraphDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_PaperParagraphDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_PaperParagraphDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_PaperParagraphDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_PaperParagraphDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_PaperParagraphDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_PaperParagraphDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxParagraphIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_PaperParagraphEN> GetObjLstByZxParagraphIdLst(List<string> arrZxParagraphIdLst)
{
List<clsvzx_PaperParagraphEN> arrObjLst = new List<clsvzx_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxParagraphIdLst, true);
 string strWhereCond = string.Format("zxParagraphId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperParagraphEN objvzx_PaperParagraphEN = new clsvzx_PaperParagraphEN();
try
{
objvzx_PaperParagraphEN.ParagraphTypeName = objRow[convzx_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvzx_PaperParagraphEN.ParagraphStateName = objRow[convzx_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvzx_PaperParagraphEN.zxParagraphId = objRow[convzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objvzx_PaperParagraphEN.TextId = objRow[convzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objvzx_PaperParagraphEN.zxSectionId = objRow[convzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objvzx_PaperParagraphEN.zxParagraphStateId = objRow[convzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objvzx_PaperParagraphEN.zxParagraphTypeId = objRow[convzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objvzx_PaperParagraphEN.ParagraphContent = objRow[convzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvzx_PaperParagraphEN.VoteCount = objRow[convzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperParagraphEN.CommentCount = objRow[convzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvzx_PaperParagraphEN.VersionCount = objRow[convzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperParagraphEN.CreateDate = objRow[convzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperParagraphEN.CreateUser = objRow[convzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvzx_PaperParagraphEN.UpdDate = objRow[convzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperParagraphEN.UpdUser = objRow[convzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvzx_PaperParagraphEN.Memo = objRow[convzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convzx_PaperParagraph.Memo].ToString().Trim(); //备注
objvzx_PaperParagraphEN.OrderNum = objRow[convzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperParagraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxParagraphIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_PaperParagraphEN> GetObjLstByZxParagraphIdLstCache(List<string> arrZxParagraphIdLst)
{
string strKey = string.Format("{0}", clsvzx_PaperParagraphEN._CurrTabName);
List<clsvzx_PaperParagraphEN> arrvzx_PaperParagraphObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_PaperParagraphEN> arrvzx_PaperParagraphObjLst_Sel =
arrvzx_PaperParagraphObjLstCache
.Where(x => arrZxParagraphIdLst.Contains(x.zxParagraphId));
return arrvzx_PaperParagraphObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_PaperParagraphEN> GetObjLst(string strWhereCond)
{
List<clsvzx_PaperParagraphEN> arrObjLst = new List<clsvzx_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperParagraphEN objvzx_PaperParagraphEN = new clsvzx_PaperParagraphEN();
try
{
objvzx_PaperParagraphEN.ParagraphTypeName = objRow[convzx_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvzx_PaperParagraphEN.ParagraphStateName = objRow[convzx_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvzx_PaperParagraphEN.zxParagraphId = objRow[convzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objvzx_PaperParagraphEN.TextId = objRow[convzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objvzx_PaperParagraphEN.zxSectionId = objRow[convzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objvzx_PaperParagraphEN.zxParagraphStateId = objRow[convzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objvzx_PaperParagraphEN.zxParagraphTypeId = objRow[convzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objvzx_PaperParagraphEN.ParagraphContent = objRow[convzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvzx_PaperParagraphEN.VoteCount = objRow[convzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperParagraphEN.CommentCount = objRow[convzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvzx_PaperParagraphEN.VersionCount = objRow[convzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperParagraphEN.CreateDate = objRow[convzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperParagraphEN.CreateUser = objRow[convzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvzx_PaperParagraphEN.UpdDate = objRow[convzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperParagraphEN.UpdUser = objRow[convzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvzx_PaperParagraphEN.Memo = objRow[convzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convzx_PaperParagraph.Memo].ToString().Trim(); //备注
objvzx_PaperParagraphEN.OrderNum = objRow[convzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperParagraphEN);
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
public static List<clsvzx_PaperParagraphEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_PaperParagraphEN> arrObjLst = new List<clsvzx_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperParagraphEN objvzx_PaperParagraphEN = new clsvzx_PaperParagraphEN();
try
{
objvzx_PaperParagraphEN.ParagraphTypeName = objRow[convzx_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvzx_PaperParagraphEN.ParagraphStateName = objRow[convzx_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvzx_PaperParagraphEN.zxParagraphId = objRow[convzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objvzx_PaperParagraphEN.TextId = objRow[convzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objvzx_PaperParagraphEN.zxSectionId = objRow[convzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objvzx_PaperParagraphEN.zxParagraphStateId = objRow[convzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objvzx_PaperParagraphEN.zxParagraphTypeId = objRow[convzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objvzx_PaperParagraphEN.ParagraphContent = objRow[convzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvzx_PaperParagraphEN.VoteCount = objRow[convzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperParagraphEN.CommentCount = objRow[convzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvzx_PaperParagraphEN.VersionCount = objRow[convzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperParagraphEN.CreateDate = objRow[convzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperParagraphEN.CreateUser = objRow[convzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvzx_PaperParagraphEN.UpdDate = objRow[convzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperParagraphEN.UpdUser = objRow[convzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvzx_PaperParagraphEN.Memo = objRow[convzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convzx_PaperParagraph.Memo].ToString().Trim(); //备注
objvzx_PaperParagraphEN.OrderNum = objRow[convzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperParagraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_PaperParagraphEN> GetSubObjLstCache(clsvzx_PaperParagraphEN objvzx_PaperParagraphCond)
{
List<clsvzx_PaperParagraphEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_PaperParagraphEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_PaperParagraph.AttributeName)
{
if (objvzx_PaperParagraphCond.IsUpdated(strFldName) == false) continue;
if (objvzx_PaperParagraphCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_PaperParagraphCond[strFldName].ToString());
}
else
{
if (objvzx_PaperParagraphCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_PaperParagraphCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_PaperParagraphCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_PaperParagraphCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_PaperParagraphCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_PaperParagraphCond[strFldName]));
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
public static List<clsvzx_PaperParagraphEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_PaperParagraphEN> arrObjLst = new List<clsvzx_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperParagraphEN objvzx_PaperParagraphEN = new clsvzx_PaperParagraphEN();
try
{
objvzx_PaperParagraphEN.ParagraphTypeName = objRow[convzx_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvzx_PaperParagraphEN.ParagraphStateName = objRow[convzx_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvzx_PaperParagraphEN.zxParagraphId = objRow[convzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objvzx_PaperParagraphEN.TextId = objRow[convzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objvzx_PaperParagraphEN.zxSectionId = objRow[convzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objvzx_PaperParagraphEN.zxParagraphStateId = objRow[convzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objvzx_PaperParagraphEN.zxParagraphTypeId = objRow[convzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objvzx_PaperParagraphEN.ParagraphContent = objRow[convzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvzx_PaperParagraphEN.VoteCount = objRow[convzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperParagraphEN.CommentCount = objRow[convzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvzx_PaperParagraphEN.VersionCount = objRow[convzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperParagraphEN.CreateDate = objRow[convzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperParagraphEN.CreateUser = objRow[convzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvzx_PaperParagraphEN.UpdDate = objRow[convzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperParagraphEN.UpdUser = objRow[convzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvzx_PaperParagraphEN.Memo = objRow[convzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convzx_PaperParagraph.Memo].ToString().Trim(); //备注
objvzx_PaperParagraphEN.OrderNum = objRow[convzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperParagraphEN);
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
public static List<clsvzx_PaperParagraphEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_PaperParagraphEN> arrObjLst = new List<clsvzx_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperParagraphEN objvzx_PaperParagraphEN = new clsvzx_PaperParagraphEN();
try
{
objvzx_PaperParagraphEN.ParagraphTypeName = objRow[convzx_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvzx_PaperParagraphEN.ParagraphStateName = objRow[convzx_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvzx_PaperParagraphEN.zxParagraphId = objRow[convzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objvzx_PaperParagraphEN.TextId = objRow[convzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objvzx_PaperParagraphEN.zxSectionId = objRow[convzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objvzx_PaperParagraphEN.zxParagraphStateId = objRow[convzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objvzx_PaperParagraphEN.zxParagraphTypeId = objRow[convzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objvzx_PaperParagraphEN.ParagraphContent = objRow[convzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvzx_PaperParagraphEN.VoteCount = objRow[convzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperParagraphEN.CommentCount = objRow[convzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvzx_PaperParagraphEN.VersionCount = objRow[convzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperParagraphEN.CreateDate = objRow[convzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperParagraphEN.CreateUser = objRow[convzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvzx_PaperParagraphEN.UpdDate = objRow[convzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperParagraphEN.UpdUser = objRow[convzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvzx_PaperParagraphEN.Memo = objRow[convzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convzx_PaperParagraph.Memo].ToString().Trim(); //备注
objvzx_PaperParagraphEN.OrderNum = objRow[convzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperParagraphEN);
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
List<clsvzx_PaperParagraphEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_PaperParagraphEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_PaperParagraphEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_PaperParagraphEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_PaperParagraphEN> arrObjLst = new List<clsvzx_PaperParagraphEN>(); 
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
	clsvzx_PaperParagraphEN objvzx_PaperParagraphEN = new clsvzx_PaperParagraphEN();
try
{
objvzx_PaperParagraphEN.ParagraphTypeName = objRow[convzx_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvzx_PaperParagraphEN.ParagraphStateName = objRow[convzx_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvzx_PaperParagraphEN.zxParagraphId = objRow[convzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objvzx_PaperParagraphEN.TextId = objRow[convzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objvzx_PaperParagraphEN.zxSectionId = objRow[convzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objvzx_PaperParagraphEN.zxParagraphStateId = objRow[convzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objvzx_PaperParagraphEN.zxParagraphTypeId = objRow[convzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objvzx_PaperParagraphEN.ParagraphContent = objRow[convzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvzx_PaperParagraphEN.VoteCount = objRow[convzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperParagraphEN.CommentCount = objRow[convzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvzx_PaperParagraphEN.VersionCount = objRow[convzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperParagraphEN.CreateDate = objRow[convzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperParagraphEN.CreateUser = objRow[convzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvzx_PaperParagraphEN.UpdDate = objRow[convzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperParagraphEN.UpdUser = objRow[convzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvzx_PaperParagraphEN.Memo = objRow[convzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convzx_PaperParagraph.Memo].ToString().Trim(); //备注
objvzx_PaperParagraphEN.OrderNum = objRow[convzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperParagraphEN);
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
public static List<clsvzx_PaperParagraphEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_PaperParagraphEN> arrObjLst = new List<clsvzx_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperParagraphEN objvzx_PaperParagraphEN = new clsvzx_PaperParagraphEN();
try
{
objvzx_PaperParagraphEN.ParagraphTypeName = objRow[convzx_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvzx_PaperParagraphEN.ParagraphStateName = objRow[convzx_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvzx_PaperParagraphEN.zxParagraphId = objRow[convzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objvzx_PaperParagraphEN.TextId = objRow[convzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objvzx_PaperParagraphEN.zxSectionId = objRow[convzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objvzx_PaperParagraphEN.zxParagraphStateId = objRow[convzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objvzx_PaperParagraphEN.zxParagraphTypeId = objRow[convzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objvzx_PaperParagraphEN.ParagraphContent = objRow[convzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvzx_PaperParagraphEN.VoteCount = objRow[convzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperParagraphEN.CommentCount = objRow[convzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvzx_PaperParagraphEN.VersionCount = objRow[convzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperParagraphEN.CreateDate = objRow[convzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperParagraphEN.CreateUser = objRow[convzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvzx_PaperParagraphEN.UpdDate = objRow[convzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperParagraphEN.UpdUser = objRow[convzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvzx_PaperParagraphEN.Memo = objRow[convzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convzx_PaperParagraph.Memo].ToString().Trim(); //备注
objvzx_PaperParagraphEN.OrderNum = objRow[convzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperParagraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_PaperParagraphEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_PaperParagraphEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_PaperParagraphEN> arrObjLst = new List<clsvzx_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperParagraphEN objvzx_PaperParagraphEN = new clsvzx_PaperParagraphEN();
try
{
objvzx_PaperParagraphEN.ParagraphTypeName = objRow[convzx_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvzx_PaperParagraphEN.ParagraphStateName = objRow[convzx_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvzx_PaperParagraphEN.zxParagraphId = objRow[convzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objvzx_PaperParagraphEN.TextId = objRow[convzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objvzx_PaperParagraphEN.zxSectionId = objRow[convzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objvzx_PaperParagraphEN.zxParagraphStateId = objRow[convzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objvzx_PaperParagraphEN.zxParagraphTypeId = objRow[convzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objvzx_PaperParagraphEN.ParagraphContent = objRow[convzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvzx_PaperParagraphEN.VoteCount = objRow[convzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperParagraphEN.CommentCount = objRow[convzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvzx_PaperParagraphEN.VersionCount = objRow[convzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperParagraphEN.CreateDate = objRow[convzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperParagraphEN.CreateUser = objRow[convzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvzx_PaperParagraphEN.UpdDate = objRow[convzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperParagraphEN.UpdUser = objRow[convzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvzx_PaperParagraphEN.Memo = objRow[convzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convzx_PaperParagraph.Memo].ToString().Trim(); //备注
objvzx_PaperParagraphEN.OrderNum = objRow[convzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperParagraphEN);
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
public static List<clsvzx_PaperParagraphEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_PaperParagraphEN> arrObjLst = new List<clsvzx_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperParagraphEN objvzx_PaperParagraphEN = new clsvzx_PaperParagraphEN();
try
{
objvzx_PaperParagraphEN.ParagraphTypeName = objRow[convzx_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvzx_PaperParagraphEN.ParagraphStateName = objRow[convzx_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvzx_PaperParagraphEN.zxParagraphId = objRow[convzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objvzx_PaperParagraphEN.TextId = objRow[convzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objvzx_PaperParagraphEN.zxSectionId = objRow[convzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objvzx_PaperParagraphEN.zxParagraphStateId = objRow[convzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objvzx_PaperParagraphEN.zxParagraphTypeId = objRow[convzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objvzx_PaperParagraphEN.ParagraphContent = objRow[convzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvzx_PaperParagraphEN.VoteCount = objRow[convzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperParagraphEN.CommentCount = objRow[convzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvzx_PaperParagraphEN.VersionCount = objRow[convzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperParagraphEN.CreateDate = objRow[convzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperParagraphEN.CreateUser = objRow[convzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvzx_PaperParagraphEN.UpdDate = objRow[convzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperParagraphEN.UpdUser = objRow[convzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvzx_PaperParagraphEN.Memo = objRow[convzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convzx_PaperParagraph.Memo].ToString().Trim(); //备注
objvzx_PaperParagraphEN.OrderNum = objRow[convzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperParagraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_PaperParagraphEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_PaperParagraphEN> arrObjLst = new List<clsvzx_PaperParagraphEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperParagraphEN objvzx_PaperParagraphEN = new clsvzx_PaperParagraphEN();
try
{
objvzx_PaperParagraphEN.ParagraphTypeName = objRow[convzx_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvzx_PaperParagraphEN.ParagraphStateName = objRow[convzx_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvzx_PaperParagraphEN.zxParagraphId = objRow[convzx_PaperParagraph.zxParagraphId].ToString().Trim(); //段落Id
objvzx_PaperParagraphEN.TextId = objRow[convzx_PaperParagraph.TextId].ToString().Trim(); //课件Id
objvzx_PaperParagraphEN.zxSectionId = objRow[convzx_PaperParagraph.zxSectionId].ToString().Trim(); //节Id
objvzx_PaperParagraphEN.zxParagraphStateId = objRow[convzx_PaperParagraph.zxParagraphStateId].ToString().Trim(); //段落状态Id
objvzx_PaperParagraphEN.zxParagraphTypeId = objRow[convzx_PaperParagraph.zxParagraphTypeId].ToString().Trim(); //段落类型Id
objvzx_PaperParagraphEN.ParagraphContent = objRow[convzx_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convzx_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvzx_PaperParagraphEN.VoteCount = objRow[convzx_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvzx_PaperParagraphEN.CommentCount = objRow[convzx_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvzx_PaperParagraphEN.VersionCount = objRow[convzx_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperParagraphEN.CreateDate = objRow[convzx_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvzx_PaperParagraphEN.CreateUser = objRow[convzx_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvzx_PaperParagraphEN.UpdDate = objRow[convzx_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperParagraphEN.UpdUser = objRow[convzx_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvzx_PaperParagraphEN.Memo = objRow[convzx_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convzx_PaperParagraph.Memo].ToString().Trim(); //备注
objvzx_PaperParagraphEN.OrderNum = objRow[convzx_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperParagraphEN.zxParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperParagraphEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_PaperParagraph(ref clsvzx_PaperParagraphEN objvzx_PaperParagraphEN)
{
bool bolResult = vzx_PaperParagraphDA.Getvzx_PaperParagraph(ref objvzx_PaperParagraphEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxParagraphId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_PaperParagraphEN GetObjByzxParagraphId(string strzxParagraphId)
{
if (strzxParagraphId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxParagraphId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxParagraphId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxParagraphId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_PaperParagraphEN objvzx_PaperParagraphEN = vzx_PaperParagraphDA.GetObjByzxParagraphId(strzxParagraphId);
return objvzx_PaperParagraphEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_PaperParagraphEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_PaperParagraphEN objvzx_PaperParagraphEN = vzx_PaperParagraphDA.GetFirstObj(strWhereCond);
 return objvzx_PaperParagraphEN;
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
public static clsvzx_PaperParagraphEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_PaperParagraphEN objvzx_PaperParagraphEN = vzx_PaperParagraphDA.GetObjByDataRow(objRow);
 return objvzx_PaperParagraphEN;
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
public static clsvzx_PaperParagraphEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_PaperParagraphEN objvzx_PaperParagraphEN = vzx_PaperParagraphDA.GetObjByDataRow(objRow);
 return objvzx_PaperParagraphEN;
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
 /// <param name = "strzxParagraphId">所给的关键字</param>
 /// <param name = "lstvzx_PaperParagraphObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_PaperParagraphEN GetObjByzxParagraphIdFromList(string strzxParagraphId, List<clsvzx_PaperParagraphEN> lstvzx_PaperParagraphObjLst)
{
foreach (clsvzx_PaperParagraphEN objvzx_PaperParagraphEN in lstvzx_PaperParagraphObjLst)
{
if (objvzx_PaperParagraphEN.zxParagraphId == strzxParagraphId)
{
return objvzx_PaperParagraphEN;
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
 string strMaxZxParagraphId;
 try
 {
 strMaxZxParagraphId = clsvzx_PaperParagraphDA.GetMaxStrId();
 return strMaxZxParagraphId;
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
 string strzxParagraphId;
 try
 {
 strzxParagraphId = new clsvzx_PaperParagraphDA().GetFirstID(strWhereCond);
 return strzxParagraphId;
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
 arrList = vzx_PaperParagraphDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_PaperParagraphDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxParagraphId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxParagraphId)
{
if (string.IsNullOrEmpty(strzxParagraphId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxParagraphId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_PaperParagraphDA.IsExist(strzxParagraphId);
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
 bolIsExist = clsvzx_PaperParagraphDA.IsExistTable();
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
 bolIsExist = vzx_PaperParagraphDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_PaperParagraphENS">源对象</param>
 /// <param name = "objvzx_PaperParagraphENT">目标对象</param>
 public static void CopyTo(clsvzx_PaperParagraphEN objvzx_PaperParagraphENS, clsvzx_PaperParagraphEN objvzx_PaperParagraphENT)
{
try
{
objvzx_PaperParagraphENT.ParagraphTypeName = objvzx_PaperParagraphENS.ParagraphTypeName; //段落类型
objvzx_PaperParagraphENT.ParagraphStateName = objvzx_PaperParagraphENS.ParagraphStateName; //段落状态
objvzx_PaperParagraphENT.zxParagraphId = objvzx_PaperParagraphENS.zxParagraphId; //段落Id
objvzx_PaperParagraphENT.TextId = objvzx_PaperParagraphENS.TextId; //课件Id
objvzx_PaperParagraphENT.zxSectionId = objvzx_PaperParagraphENS.zxSectionId; //节Id
objvzx_PaperParagraphENT.zxParagraphStateId = objvzx_PaperParagraphENS.zxParagraphStateId; //段落状态Id
objvzx_PaperParagraphENT.zxParagraphTypeId = objvzx_PaperParagraphENS.zxParagraphTypeId; //段落类型Id
objvzx_PaperParagraphENT.ParagraphContent = objvzx_PaperParagraphENS.ParagraphContent; //段落内容
objvzx_PaperParagraphENT.VoteCount = objvzx_PaperParagraphENS.VoteCount; //点赞计数
objvzx_PaperParagraphENT.CommentCount = objvzx_PaperParagraphENS.CommentCount; //评论数
objvzx_PaperParagraphENT.VersionCount = objvzx_PaperParagraphENS.VersionCount; //版本统计
objvzx_PaperParagraphENT.CreateDate = objvzx_PaperParagraphENS.CreateDate; //建立日期
objvzx_PaperParagraphENT.CreateUser = objvzx_PaperParagraphENS.CreateUser; //建立用户
objvzx_PaperParagraphENT.UpdDate = objvzx_PaperParagraphENS.UpdDate; //修改日期
objvzx_PaperParagraphENT.UpdUser = objvzx_PaperParagraphENS.UpdUser; //修改人
objvzx_PaperParagraphENT.Memo = objvzx_PaperParagraphENS.Memo; //备注
objvzx_PaperParagraphENT.OrderNum = objvzx_PaperParagraphENS.OrderNum; //序号
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
 /// <param name = "objvzx_PaperParagraphEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_PaperParagraphEN objvzx_PaperParagraphEN)
{
try
{
objvzx_PaperParagraphEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_PaperParagraphEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_PaperParagraph.ParagraphTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperParagraphEN.ParagraphTypeName = objvzx_PaperParagraphEN.ParagraphTypeName == "[null]" ? null :  objvzx_PaperParagraphEN.ParagraphTypeName; //段落类型
}
if (arrFldSet.Contains(convzx_PaperParagraph.ParagraphStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperParagraphEN.ParagraphStateName = objvzx_PaperParagraphEN.ParagraphStateName == "[null]" ? null :  objvzx_PaperParagraphEN.ParagraphStateName; //段落状态
}
if (arrFldSet.Contains(convzx_PaperParagraph.zxParagraphId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperParagraphEN.zxParagraphId = objvzx_PaperParagraphEN.zxParagraphId; //段落Id
}
if (arrFldSet.Contains(convzx_PaperParagraph.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperParagraphEN.TextId = objvzx_PaperParagraphEN.TextId; //课件Id
}
if (arrFldSet.Contains(convzx_PaperParagraph.zxSectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperParagraphEN.zxSectionId = objvzx_PaperParagraphEN.zxSectionId; //节Id
}
if (arrFldSet.Contains(convzx_PaperParagraph.zxParagraphStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperParagraphEN.zxParagraphStateId = objvzx_PaperParagraphEN.zxParagraphStateId; //段落状态Id
}
if (arrFldSet.Contains(convzx_PaperParagraph.zxParagraphTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperParagraphEN.zxParagraphTypeId = objvzx_PaperParagraphEN.zxParagraphTypeId; //段落类型Id
}
if (arrFldSet.Contains(convzx_PaperParagraph.ParagraphContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperParagraphEN.ParagraphContent = objvzx_PaperParagraphEN.ParagraphContent == "[null]" ? null :  objvzx_PaperParagraphEN.ParagraphContent; //段落内容
}
if (arrFldSet.Contains(convzx_PaperParagraph.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperParagraphEN.VoteCount = objvzx_PaperParagraphEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(convzx_PaperParagraph.CommentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperParagraphEN.CommentCount = objvzx_PaperParagraphEN.CommentCount; //评论数
}
if (arrFldSet.Contains(convzx_PaperParagraph.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperParagraphEN.VersionCount = objvzx_PaperParagraphEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convzx_PaperParagraph.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperParagraphEN.CreateDate = objvzx_PaperParagraphEN.CreateDate == "[null]" ? null :  objvzx_PaperParagraphEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convzx_PaperParagraph.CreateUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperParagraphEN.CreateUser = objvzx_PaperParagraphEN.CreateUser == "[null]" ? null :  objvzx_PaperParagraphEN.CreateUser; //建立用户
}
if (arrFldSet.Contains(convzx_PaperParagraph.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperParagraphEN.UpdDate = objvzx_PaperParagraphEN.UpdDate == "[null]" ? null :  objvzx_PaperParagraphEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_PaperParagraph.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperParagraphEN.UpdUser = objvzx_PaperParagraphEN.UpdUser == "[null]" ? null :  objvzx_PaperParagraphEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_PaperParagraph.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperParagraphEN.Memo = objvzx_PaperParagraphEN.Memo == "[null]" ? null :  objvzx_PaperParagraphEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_PaperParagraph.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperParagraphEN.OrderNum = objvzx_PaperParagraphEN.OrderNum; //序号
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
 /// <param name = "objvzx_PaperParagraphEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_PaperParagraphEN objvzx_PaperParagraphEN)
{
try
{
if (objvzx_PaperParagraphEN.ParagraphTypeName == "[null]") objvzx_PaperParagraphEN.ParagraphTypeName = null; //段落类型
if (objvzx_PaperParagraphEN.ParagraphStateName == "[null]") objvzx_PaperParagraphEN.ParagraphStateName = null; //段落状态
if (objvzx_PaperParagraphEN.ParagraphContent == "[null]") objvzx_PaperParagraphEN.ParagraphContent = null; //段落内容
if (objvzx_PaperParagraphEN.CreateDate == "[null]") objvzx_PaperParagraphEN.CreateDate = null; //建立日期
if (objvzx_PaperParagraphEN.CreateUser == "[null]") objvzx_PaperParagraphEN.CreateUser = null; //建立用户
if (objvzx_PaperParagraphEN.UpdDate == "[null]") objvzx_PaperParagraphEN.UpdDate = null; //修改日期
if (objvzx_PaperParagraphEN.UpdUser == "[null]") objvzx_PaperParagraphEN.UpdUser = null; //修改人
if (objvzx_PaperParagraphEN.Memo == "[null]") objvzx_PaperParagraphEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvzx_PaperParagraphEN objvzx_PaperParagraphEN)
{
 vzx_PaperParagraphDA.CheckProperty4Condition(objvzx_PaperParagraphEN);
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
if (clszx_PaperParagraphBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_PaperParagraphBL没有刷新缓存机制(clszx_PaperParagraphBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_ParagraphStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_ParagraphStateBL没有刷新缓存机制(clszx_ParagraphStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_ParagraphTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_ParagraphTypeBL没有刷新缓存机制(clszx_ParagraphTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxParagraphId");
//if (arrvzx_PaperParagraphObjLstCache == null)
//{
//arrvzx_PaperParagraphObjLstCache = vzx_PaperParagraphDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxParagraphId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_PaperParagraphEN GetObjByzxParagraphIdCache(string strzxParagraphId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvzx_PaperParagraphEN._CurrTabName);
List<clsvzx_PaperParagraphEN> arrvzx_PaperParagraphObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_PaperParagraphEN> arrvzx_PaperParagraphObjLst_Sel =
arrvzx_PaperParagraphObjLstCache
.Where(x=> x.zxParagraphId == strzxParagraphId 
);
if (arrvzx_PaperParagraphObjLst_Sel.Count() == 0)
{
   clsvzx_PaperParagraphEN obj = clsvzx_PaperParagraphBL.GetObjByzxParagraphId(strzxParagraphId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvzx_PaperParagraphObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_PaperParagraphEN> GetAllvzx_PaperParagraphObjLstCache()
{
//获取缓存中的对象列表
List<clsvzx_PaperParagraphEN> arrvzx_PaperParagraphObjLstCache = GetObjLstCache(); 
return arrvzx_PaperParagraphObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_PaperParagraphEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvzx_PaperParagraphEN._CurrTabName);
List<clsvzx_PaperParagraphEN> arrvzx_PaperParagraphObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvzx_PaperParagraphObjLstCache;
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
string strKey = string.Format("{0}", clsvzx_PaperParagraphEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strzxParagraphId)
{
if (strInFldName != convzx_PaperParagraph.zxParagraphId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_PaperParagraph.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_PaperParagraph.AttributeName));
throw new Exception(strMsg);
}
var objvzx_PaperParagraph = clsvzx_PaperParagraphBL.GetObjByzxParagraphIdCache(strzxParagraphId);
if (objvzx_PaperParagraph == null) return "";
return objvzx_PaperParagraph[strOutFldName].ToString();
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
int intRecCount = clsvzx_PaperParagraphDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_PaperParagraphDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_PaperParagraphDA.GetRecCount();
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
int intRecCount = clsvzx_PaperParagraphDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_PaperParagraphCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_PaperParagraphEN objvzx_PaperParagraphCond)
{
List<clsvzx_PaperParagraphEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_PaperParagraphEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_PaperParagraph.AttributeName)
{
if (objvzx_PaperParagraphCond.IsUpdated(strFldName) == false) continue;
if (objvzx_PaperParagraphCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_PaperParagraphCond[strFldName].ToString());
}
else
{
if (objvzx_PaperParagraphCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_PaperParagraphCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_PaperParagraphCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_PaperParagraphCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_PaperParagraphCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_PaperParagraphCond[strFldName]));
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
 List<string> arrList = clsvzx_PaperParagraphDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_PaperParagraphDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_PaperParagraphDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数


 #region 排序相关函数


 #endregion 排序相关函数
}
}