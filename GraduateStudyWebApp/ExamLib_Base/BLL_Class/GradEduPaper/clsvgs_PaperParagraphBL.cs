
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PaperParagraphBL
 表名:vgs_PaperParagraph(01120747)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:52:45
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
public static class  clsvgs_PaperParagraphBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strParagraphId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PaperParagraphEN GetObj(this K_ParagraphId_vgs_PaperParagraph myKey)
{
clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = clsvgs_PaperParagraphBL.vgs_PaperParagraphDA.GetObjByParagraphId(myKey.Value);
return objvgs_PaperParagraphEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperParagraphEN SetParagraphId(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN, string strParagraphId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParagraphId, 10, convgs_PaperParagraph.ParagraphId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParagraphId, 10, convgs_PaperParagraph.ParagraphId);
}
objvgs_PaperParagraphEN.ParagraphId = strParagraphId; //段落Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convgs_PaperParagraph.ParagraphId) == false)
{
objvgs_PaperParagraphEN.dicFldComparisonOp.Add(convgs_PaperParagraph.ParagraphId, strComparisonOp);
}
else
{
objvgs_PaperParagraphEN.dicFldComparisonOp[convgs_PaperParagraph.ParagraphId] = strComparisonOp;
}
}
return objvgs_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperParagraphEN SetParagraphStateName(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN, string strParagraphStateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParagraphStateName, 100, convgs_PaperParagraph.ParagraphStateName);
}
objvgs_PaperParagraphEN.ParagraphStateName = strParagraphStateName; //段落状态
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convgs_PaperParagraph.ParagraphStateName) == false)
{
objvgs_PaperParagraphEN.dicFldComparisonOp.Add(convgs_PaperParagraph.ParagraphStateName, strComparisonOp);
}
else
{
objvgs_PaperParagraphEN.dicFldComparisonOp[convgs_PaperParagraph.ParagraphStateName] = strComparisonOp;
}
}
return objvgs_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperParagraphEN SetParagraphTypeName(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN, string strParagraphTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParagraphTypeName, 100, convgs_PaperParagraph.ParagraphTypeName);
}
objvgs_PaperParagraphEN.ParagraphTypeName = strParagraphTypeName; //段落类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convgs_PaperParagraph.ParagraphTypeName) == false)
{
objvgs_PaperParagraphEN.dicFldComparisonOp.Add(convgs_PaperParagraph.ParagraphTypeName, strComparisonOp);
}
else
{
objvgs_PaperParagraphEN.dicFldComparisonOp[convgs_PaperParagraph.ParagraphTypeName] = strComparisonOp;
}
}
return objvgs_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperParagraphEN SetPaperId(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperId, convgs_PaperParagraph.PaperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convgs_PaperParagraph.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convgs_PaperParagraph.PaperId);
}
objvgs_PaperParagraphEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convgs_PaperParagraph.PaperId) == false)
{
objvgs_PaperParagraphEN.dicFldComparisonOp.Add(convgs_PaperParagraph.PaperId, strComparisonOp);
}
else
{
objvgs_PaperParagraphEN.dicFldComparisonOp[convgs_PaperParagraph.PaperId] = strComparisonOp;
}
}
return objvgs_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperParagraphEN SetSectionId(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSectionId, convgs_PaperParagraph.SectionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convgs_PaperParagraph.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convgs_PaperParagraph.SectionId);
}
objvgs_PaperParagraphEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convgs_PaperParagraph.SectionId) == false)
{
objvgs_PaperParagraphEN.dicFldComparisonOp.Add(convgs_PaperParagraph.SectionId, strComparisonOp);
}
else
{
objvgs_PaperParagraphEN.dicFldComparisonOp[convgs_PaperParagraph.SectionId] = strComparisonOp;
}
}
return objvgs_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperParagraphEN SetParagraphStateId(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN, string strParagraphStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParagraphStateId, convgs_PaperParagraph.ParagraphStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParagraphStateId, 2, convgs_PaperParagraph.ParagraphStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParagraphStateId, 2, convgs_PaperParagraph.ParagraphStateId);
}
objvgs_PaperParagraphEN.ParagraphStateId = strParagraphStateId; //段落状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convgs_PaperParagraph.ParagraphStateId) == false)
{
objvgs_PaperParagraphEN.dicFldComparisonOp.Add(convgs_PaperParagraph.ParagraphStateId, strComparisonOp);
}
else
{
objvgs_PaperParagraphEN.dicFldComparisonOp[convgs_PaperParagraph.ParagraphStateId] = strComparisonOp;
}
}
return objvgs_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperParagraphEN SetParagraphTypeId(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN, string strParagraphTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParagraphTypeId, convgs_PaperParagraph.ParagraphTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParagraphTypeId, 2, convgs_PaperParagraph.ParagraphTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParagraphTypeId, 2, convgs_PaperParagraph.ParagraphTypeId);
}
objvgs_PaperParagraphEN.ParagraphTypeId = strParagraphTypeId; //段落类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convgs_PaperParagraph.ParagraphTypeId) == false)
{
objvgs_PaperParagraphEN.dicFldComparisonOp.Add(convgs_PaperParagraph.ParagraphTypeId, strComparisonOp);
}
else
{
objvgs_PaperParagraphEN.dicFldComparisonOp[convgs_PaperParagraph.ParagraphTypeId] = strComparisonOp;
}
}
return objvgs_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperParagraphEN SetParagraphContent(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN, string strParagraphContent, string strComparisonOp="")
	{
objvgs_PaperParagraphEN.ParagraphContent = strParagraphContent; //段落内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convgs_PaperParagraph.ParagraphContent) == false)
{
objvgs_PaperParagraphEN.dicFldComparisonOp.Add(convgs_PaperParagraph.ParagraphContent, strComparisonOp);
}
else
{
objvgs_PaperParagraphEN.dicFldComparisonOp[convgs_PaperParagraph.ParagraphContent] = strComparisonOp;
}
}
return objvgs_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperParagraphEN SetVoteCount(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN, int? intVoteCount, string strComparisonOp="")
	{
objvgs_PaperParagraphEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convgs_PaperParagraph.VoteCount) == false)
{
objvgs_PaperParagraphEN.dicFldComparisonOp.Add(convgs_PaperParagraph.VoteCount, strComparisonOp);
}
else
{
objvgs_PaperParagraphEN.dicFldComparisonOp[convgs_PaperParagraph.VoteCount] = strComparisonOp;
}
}
return objvgs_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperParagraphEN SetCommentCount(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN, int? intCommentCount, string strComparisonOp="")
	{
objvgs_PaperParagraphEN.CommentCount = intCommentCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convgs_PaperParagraph.CommentCount) == false)
{
objvgs_PaperParagraphEN.dicFldComparisonOp.Add(convgs_PaperParagraph.CommentCount, strComparisonOp);
}
else
{
objvgs_PaperParagraphEN.dicFldComparisonOp[convgs_PaperParagraph.CommentCount] = strComparisonOp;
}
}
return objvgs_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperParagraphEN SetVersionCount(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN, int? intVersionCount, string strComparisonOp="")
	{
objvgs_PaperParagraphEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convgs_PaperParagraph.VersionCount) == false)
{
objvgs_PaperParagraphEN.dicFldComparisonOp.Add(convgs_PaperParagraph.VersionCount, strComparisonOp);
}
else
{
objvgs_PaperParagraphEN.dicFldComparisonOp[convgs_PaperParagraph.VersionCount] = strComparisonOp;
}
}
return objvgs_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperParagraphEN SetCreateDate(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convgs_PaperParagraph.CreateDate);
}
objvgs_PaperParagraphEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convgs_PaperParagraph.CreateDate) == false)
{
objvgs_PaperParagraphEN.dicFldComparisonOp.Add(convgs_PaperParagraph.CreateDate, strComparisonOp);
}
else
{
objvgs_PaperParagraphEN.dicFldComparisonOp[convgs_PaperParagraph.CreateDate] = strComparisonOp;
}
}
return objvgs_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperParagraphEN SetCreateUser(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN, string strCreateUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUser, 50, convgs_PaperParagraph.CreateUser);
}
objvgs_PaperParagraphEN.CreateUser = strCreateUser; //建立用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convgs_PaperParagraph.CreateUser) == false)
{
objvgs_PaperParagraphEN.dicFldComparisonOp.Add(convgs_PaperParagraph.CreateUser, strComparisonOp);
}
else
{
objvgs_PaperParagraphEN.dicFldComparisonOp[convgs_PaperParagraph.CreateUser] = strComparisonOp;
}
}
return objvgs_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperParagraphEN SetUpdDate(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convgs_PaperParagraph.UpdDate);
}
objvgs_PaperParagraphEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convgs_PaperParagraph.UpdDate) == false)
{
objvgs_PaperParagraphEN.dicFldComparisonOp.Add(convgs_PaperParagraph.UpdDate, strComparisonOp);
}
else
{
objvgs_PaperParagraphEN.dicFldComparisonOp[convgs_PaperParagraph.UpdDate] = strComparisonOp;
}
}
return objvgs_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperParagraphEN SetUpdUser(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convgs_PaperParagraph.UpdUser);
}
objvgs_PaperParagraphEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convgs_PaperParagraph.UpdUser) == false)
{
objvgs_PaperParagraphEN.dicFldComparisonOp.Add(convgs_PaperParagraph.UpdUser, strComparisonOp);
}
else
{
objvgs_PaperParagraphEN.dicFldComparisonOp[convgs_PaperParagraph.UpdUser] = strComparisonOp;
}
}
return objvgs_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperParagraphEN SetMemo(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convgs_PaperParagraph.Memo);
}
objvgs_PaperParagraphEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convgs_PaperParagraph.Memo) == false)
{
objvgs_PaperParagraphEN.dicFldComparisonOp.Add(convgs_PaperParagraph.Memo, strComparisonOp);
}
else
{
objvgs_PaperParagraphEN.dicFldComparisonOp[convgs_PaperParagraph.Memo] = strComparisonOp;
}
}
return objvgs_PaperParagraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperParagraphEN SetOrderNum(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN, int? intOrderNum, string strComparisonOp="")
	{
objvgs_PaperParagraphEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperParagraphEN.dicFldComparisonOp.ContainsKey(convgs_PaperParagraph.OrderNum) == false)
{
objvgs_PaperParagraphEN.dicFldComparisonOp.Add(convgs_PaperParagraph.OrderNum, strComparisonOp);
}
else
{
objvgs_PaperParagraphEN.dicFldComparisonOp[convgs_PaperParagraph.OrderNum] = strComparisonOp;
}
}
return objvgs_PaperParagraphEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphENS">源对象</param>
 /// <param name = "objvgs_PaperParagraphENT">目标对象</param>
 public static void CopyTo(this clsvgs_PaperParagraphEN objvgs_PaperParagraphENS, clsvgs_PaperParagraphEN objvgs_PaperParagraphENT)
{
try
{
objvgs_PaperParagraphENT.ParagraphId = objvgs_PaperParagraphENS.ParagraphId; //段落Id
objvgs_PaperParagraphENT.ParagraphStateName = objvgs_PaperParagraphENS.ParagraphStateName; //段落状态
objvgs_PaperParagraphENT.ParagraphTypeName = objvgs_PaperParagraphENS.ParagraphTypeName; //段落类型
objvgs_PaperParagraphENT.PaperId = objvgs_PaperParagraphENS.PaperId; //论文Id
objvgs_PaperParagraphENT.SectionId = objvgs_PaperParagraphENS.SectionId; //节Id
objvgs_PaperParagraphENT.ParagraphStateId = objvgs_PaperParagraphENS.ParagraphStateId; //段落状态Id
objvgs_PaperParagraphENT.ParagraphTypeId = objvgs_PaperParagraphENS.ParagraphTypeId; //段落类型Id
objvgs_PaperParagraphENT.ParagraphContent = objvgs_PaperParagraphENS.ParagraphContent; //段落内容
objvgs_PaperParagraphENT.VoteCount = objvgs_PaperParagraphENS.VoteCount; //点赞计数
objvgs_PaperParagraphENT.CommentCount = objvgs_PaperParagraphENS.CommentCount; //评论数
objvgs_PaperParagraphENT.VersionCount = objvgs_PaperParagraphENS.VersionCount; //版本统计
objvgs_PaperParagraphENT.CreateDate = objvgs_PaperParagraphENS.CreateDate; //建立日期
objvgs_PaperParagraphENT.CreateUser = objvgs_PaperParagraphENS.CreateUser; //建立用户
objvgs_PaperParagraphENT.UpdDate = objvgs_PaperParagraphENS.UpdDate; //修改日期
objvgs_PaperParagraphENT.UpdUser = objvgs_PaperParagraphENS.UpdUser; //修改人
objvgs_PaperParagraphENT.Memo = objvgs_PaperParagraphENS.Memo; //备注
objvgs_PaperParagraphENT.OrderNum = objvgs_PaperParagraphENS.OrderNum; //序号
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
 /// <param name = "objvgs_PaperParagraphENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PaperParagraphEN:objvgs_PaperParagraphENT</returns>
 public static clsvgs_PaperParagraphEN CopyTo(this clsvgs_PaperParagraphEN objvgs_PaperParagraphENS)
{
try
{
 clsvgs_PaperParagraphEN objvgs_PaperParagraphENT = new clsvgs_PaperParagraphEN()
{
ParagraphId = objvgs_PaperParagraphENS.ParagraphId, //段落Id
ParagraphStateName = objvgs_PaperParagraphENS.ParagraphStateName, //段落状态
ParagraphTypeName = objvgs_PaperParagraphENS.ParagraphTypeName, //段落类型
PaperId = objvgs_PaperParagraphENS.PaperId, //论文Id
SectionId = objvgs_PaperParagraphENS.SectionId, //节Id
ParagraphStateId = objvgs_PaperParagraphENS.ParagraphStateId, //段落状态Id
ParagraphTypeId = objvgs_PaperParagraphENS.ParagraphTypeId, //段落类型Id
ParagraphContent = objvgs_PaperParagraphENS.ParagraphContent, //段落内容
VoteCount = objvgs_PaperParagraphENS.VoteCount, //点赞计数
CommentCount = objvgs_PaperParagraphENS.CommentCount, //评论数
VersionCount = objvgs_PaperParagraphENS.VersionCount, //版本统计
CreateDate = objvgs_PaperParagraphENS.CreateDate, //建立日期
CreateUser = objvgs_PaperParagraphENS.CreateUser, //建立用户
UpdDate = objvgs_PaperParagraphENS.UpdDate, //修改日期
UpdUser = objvgs_PaperParagraphENS.UpdUser, //修改人
Memo = objvgs_PaperParagraphENS.Memo, //备注
OrderNum = objvgs_PaperParagraphENS.OrderNum, //序号
};
 return objvgs_PaperParagraphENT;
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
public static void CheckProperty4Condition(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN)
{
 clsvgs_PaperParagraphBL.vgs_PaperParagraphDA.CheckProperty4Condition(objvgs_PaperParagraphEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_PaperParagraphEN objvgs_PaperParagraphCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_PaperParagraphCond.IsUpdated(convgs_PaperParagraph.ParagraphId) == true)
{
string strComparisonOpParagraphId = objvgs_PaperParagraphCond.dicFldComparisonOp[convgs_PaperParagraph.ParagraphId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperParagraph.ParagraphId, objvgs_PaperParagraphCond.ParagraphId, strComparisonOpParagraphId);
}
if (objvgs_PaperParagraphCond.IsUpdated(convgs_PaperParagraph.ParagraphStateName) == true)
{
string strComparisonOpParagraphStateName = objvgs_PaperParagraphCond.dicFldComparisonOp[convgs_PaperParagraph.ParagraphStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperParagraph.ParagraphStateName, objvgs_PaperParagraphCond.ParagraphStateName, strComparisonOpParagraphStateName);
}
if (objvgs_PaperParagraphCond.IsUpdated(convgs_PaperParagraph.ParagraphTypeName) == true)
{
string strComparisonOpParagraphTypeName = objvgs_PaperParagraphCond.dicFldComparisonOp[convgs_PaperParagraph.ParagraphTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperParagraph.ParagraphTypeName, objvgs_PaperParagraphCond.ParagraphTypeName, strComparisonOpParagraphTypeName);
}
if (objvgs_PaperParagraphCond.IsUpdated(convgs_PaperParagraph.PaperId) == true)
{
string strComparisonOpPaperId = objvgs_PaperParagraphCond.dicFldComparisonOp[convgs_PaperParagraph.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperParagraph.PaperId, objvgs_PaperParagraphCond.PaperId, strComparisonOpPaperId);
}
if (objvgs_PaperParagraphCond.IsUpdated(convgs_PaperParagraph.SectionId) == true)
{
string strComparisonOpSectionId = objvgs_PaperParagraphCond.dicFldComparisonOp[convgs_PaperParagraph.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperParagraph.SectionId, objvgs_PaperParagraphCond.SectionId, strComparisonOpSectionId);
}
if (objvgs_PaperParagraphCond.IsUpdated(convgs_PaperParagraph.ParagraphStateId) == true)
{
string strComparisonOpParagraphStateId = objvgs_PaperParagraphCond.dicFldComparisonOp[convgs_PaperParagraph.ParagraphStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperParagraph.ParagraphStateId, objvgs_PaperParagraphCond.ParagraphStateId, strComparisonOpParagraphStateId);
}
if (objvgs_PaperParagraphCond.IsUpdated(convgs_PaperParagraph.ParagraphTypeId) == true)
{
string strComparisonOpParagraphTypeId = objvgs_PaperParagraphCond.dicFldComparisonOp[convgs_PaperParagraph.ParagraphTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperParagraph.ParagraphTypeId, objvgs_PaperParagraphCond.ParagraphTypeId, strComparisonOpParagraphTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvgs_PaperParagraphCond.IsUpdated(convgs_PaperParagraph.VoteCount) == true)
{
string strComparisonOpVoteCount = objvgs_PaperParagraphCond.dicFldComparisonOp[convgs_PaperParagraph.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperParagraph.VoteCount, objvgs_PaperParagraphCond.VoteCount, strComparisonOpVoteCount);
}
if (objvgs_PaperParagraphCond.IsUpdated(convgs_PaperParagraph.CommentCount) == true)
{
string strComparisonOpCommentCount = objvgs_PaperParagraphCond.dicFldComparisonOp[convgs_PaperParagraph.CommentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperParagraph.CommentCount, objvgs_PaperParagraphCond.CommentCount, strComparisonOpCommentCount);
}
if (objvgs_PaperParagraphCond.IsUpdated(convgs_PaperParagraph.VersionCount) == true)
{
string strComparisonOpVersionCount = objvgs_PaperParagraphCond.dicFldComparisonOp[convgs_PaperParagraph.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperParagraph.VersionCount, objvgs_PaperParagraphCond.VersionCount, strComparisonOpVersionCount);
}
if (objvgs_PaperParagraphCond.IsUpdated(convgs_PaperParagraph.CreateDate) == true)
{
string strComparisonOpCreateDate = objvgs_PaperParagraphCond.dicFldComparisonOp[convgs_PaperParagraph.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperParagraph.CreateDate, objvgs_PaperParagraphCond.CreateDate, strComparisonOpCreateDate);
}
if (objvgs_PaperParagraphCond.IsUpdated(convgs_PaperParagraph.CreateUser) == true)
{
string strComparisonOpCreateUser = objvgs_PaperParagraphCond.dicFldComparisonOp[convgs_PaperParagraph.CreateUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperParagraph.CreateUser, objvgs_PaperParagraphCond.CreateUser, strComparisonOpCreateUser);
}
if (objvgs_PaperParagraphCond.IsUpdated(convgs_PaperParagraph.UpdDate) == true)
{
string strComparisonOpUpdDate = objvgs_PaperParagraphCond.dicFldComparisonOp[convgs_PaperParagraph.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperParagraph.UpdDate, objvgs_PaperParagraphCond.UpdDate, strComparisonOpUpdDate);
}
if (objvgs_PaperParagraphCond.IsUpdated(convgs_PaperParagraph.UpdUser) == true)
{
string strComparisonOpUpdUser = objvgs_PaperParagraphCond.dicFldComparisonOp[convgs_PaperParagraph.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperParagraph.UpdUser, objvgs_PaperParagraphCond.UpdUser, strComparisonOpUpdUser);
}
if (objvgs_PaperParagraphCond.IsUpdated(convgs_PaperParagraph.Memo) == true)
{
string strComparisonOpMemo = objvgs_PaperParagraphCond.dicFldComparisonOp[convgs_PaperParagraph.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperParagraph.Memo, objvgs_PaperParagraphCond.Memo, strComparisonOpMemo);
}
if (objvgs_PaperParagraphCond.IsUpdated(convgs_PaperParagraph.OrderNum) == true)
{
string strComparisonOpOrderNum = objvgs_PaperParagraphCond.dicFldComparisonOp[convgs_PaperParagraph.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperParagraph.OrderNum, objvgs_PaperParagraphCond.OrderNum, strComparisonOpOrderNum);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vgs_PaperParagraph(论文段落视图), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ParagraphId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvgs_PaperParagraphEN == null) return true;
if (objvgs_PaperParagraphEN.ParagraphId == null || objvgs_PaperParagraphEN.ParagraphId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ParagraphId = '{0}'", objvgs_PaperParagraphEN.ParagraphId);
if (clsvgs_PaperParagraphBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ParagraphId !=  '{0}'", objvgs_PaperParagraphEN.ParagraphId);
 sbCondition.AppendFormat(" and ParagraphId = '{0}'", objvgs_PaperParagraphEN.ParagraphId);
if (clsvgs_PaperParagraphBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--vgs_PaperParagraph(论文段落视图), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ParagraphId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvgs_PaperParagraphEN objvgs_PaperParagraphEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvgs_PaperParagraphEN == null) return "";
if (objvgs_PaperParagraphEN.ParagraphId == null || objvgs_PaperParagraphEN.ParagraphId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ParagraphId = '{0}'", objvgs_PaperParagraphEN.ParagraphId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ParagraphId !=  '{0}'", objvgs_PaperParagraphEN.ParagraphId);
 sbCondition.AppendFormat(" and ParagraphId = '{0}'", objvgs_PaperParagraphEN.ParagraphId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_PaperParagraph
{
public virtual bool UpdRelaTabDate(string strParagraphId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文段落视图(vgs_PaperParagraph)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_PaperParagraphBL
{
public static RelatedActions_vgs_PaperParagraph relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_PaperParagraphDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_PaperParagraphDA vgs_PaperParagraphDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_PaperParagraphDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_PaperParagraphBL()
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
if (string.IsNullOrEmpty(clsvgs_PaperParagraphEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_PaperParagraphEN._ConnectString);
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
public static DataTable GetDataTable_vgs_PaperParagraph(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_PaperParagraphDA.GetDataTable_vgs_PaperParagraph(strWhereCond);
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
objDT = vgs_PaperParagraphDA.GetDataTable(strWhereCond);
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
objDT = vgs_PaperParagraphDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vgs_PaperParagraphDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vgs_PaperParagraphDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vgs_PaperParagraphDA.GetDataTable_Top(objTopPara);
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
objDT = vgs_PaperParagraphDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vgs_PaperParagraphDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vgs_PaperParagraphDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrParagraphIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvgs_PaperParagraphEN> GetObjLstByParagraphIdLst(List<string> arrParagraphIdLst)
{
List<clsvgs_PaperParagraphEN> arrObjLst = new List<clsvgs_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrParagraphIdLst, true);
 string strWhereCond = string.Format("ParagraphId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN();
try
{
objvgs_PaperParagraphEN.ParagraphId = objRow[convgs_PaperParagraph.ParagraphId].ToString().Trim(); //段落Id
objvgs_PaperParagraphEN.ParagraphStateName = objRow[convgs_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvgs_PaperParagraphEN.ParagraphTypeName = objRow[convgs_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvgs_PaperParagraphEN.PaperId = objRow[convgs_PaperParagraph.PaperId].ToString().Trim(); //论文Id
objvgs_PaperParagraphEN.SectionId = objRow[convgs_PaperParagraph.SectionId].ToString().Trim(); //节Id
objvgs_PaperParagraphEN.ParagraphStateId = objRow[convgs_PaperParagraph.ParagraphStateId].ToString().Trim(); //段落状态Id
objvgs_PaperParagraphEN.ParagraphTypeId = objRow[convgs_PaperParagraph.ParagraphTypeId].ToString().Trim(); //段落类型Id
objvgs_PaperParagraphEN.ParagraphContent = objRow[convgs_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvgs_PaperParagraphEN.VoteCount = objRow[convgs_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvgs_PaperParagraphEN.CommentCount = objRow[convgs_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvgs_PaperParagraphEN.VersionCount = objRow[convgs_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperParagraphEN.CreateDate = objRow[convgs_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvgs_PaperParagraphEN.CreateUser = objRow[convgs_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvgs_PaperParagraphEN.UpdDate = objRow[convgs_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperParagraphEN.UpdUser = objRow[convgs_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvgs_PaperParagraphEN.Memo = objRow[convgs_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convgs_PaperParagraph.Memo].ToString().Trim(); //备注
objvgs_PaperParagraphEN.OrderNum = objRow[convgs_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperParagraphEN.ParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperParagraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrParagraphIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_PaperParagraphEN> GetObjLstByParagraphIdLstCache(List<string> arrParagraphIdLst)
{
string strKey = string.Format("{0}", clsvgs_PaperParagraphEN._CurrTabName);
List<clsvgs_PaperParagraphEN> arrvgs_PaperParagraphObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PaperParagraphEN> arrvgs_PaperParagraphObjLst_Sel =
arrvgs_PaperParagraphObjLstCache
.Where(x => arrParagraphIdLst.Contains(x.ParagraphId));
return arrvgs_PaperParagraphObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PaperParagraphEN> GetObjLst(string strWhereCond)
{
List<clsvgs_PaperParagraphEN> arrObjLst = new List<clsvgs_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN();
try
{
objvgs_PaperParagraphEN.ParagraphId = objRow[convgs_PaperParagraph.ParagraphId].ToString().Trim(); //段落Id
objvgs_PaperParagraphEN.ParagraphStateName = objRow[convgs_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvgs_PaperParagraphEN.ParagraphTypeName = objRow[convgs_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvgs_PaperParagraphEN.PaperId = objRow[convgs_PaperParagraph.PaperId].ToString().Trim(); //论文Id
objvgs_PaperParagraphEN.SectionId = objRow[convgs_PaperParagraph.SectionId].ToString().Trim(); //节Id
objvgs_PaperParagraphEN.ParagraphStateId = objRow[convgs_PaperParagraph.ParagraphStateId].ToString().Trim(); //段落状态Id
objvgs_PaperParagraphEN.ParagraphTypeId = objRow[convgs_PaperParagraph.ParagraphTypeId].ToString().Trim(); //段落类型Id
objvgs_PaperParagraphEN.ParagraphContent = objRow[convgs_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvgs_PaperParagraphEN.VoteCount = objRow[convgs_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvgs_PaperParagraphEN.CommentCount = objRow[convgs_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvgs_PaperParagraphEN.VersionCount = objRow[convgs_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperParagraphEN.CreateDate = objRow[convgs_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvgs_PaperParagraphEN.CreateUser = objRow[convgs_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvgs_PaperParagraphEN.UpdDate = objRow[convgs_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperParagraphEN.UpdUser = objRow[convgs_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvgs_PaperParagraphEN.Memo = objRow[convgs_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convgs_PaperParagraph.Memo].ToString().Trim(); //备注
objvgs_PaperParagraphEN.OrderNum = objRow[convgs_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperParagraphEN.ParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperParagraphEN);
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
public static List<clsvgs_PaperParagraphEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_PaperParagraphEN> arrObjLst = new List<clsvgs_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN();
try
{
objvgs_PaperParagraphEN.ParagraphId = objRow[convgs_PaperParagraph.ParagraphId].ToString().Trim(); //段落Id
objvgs_PaperParagraphEN.ParagraphStateName = objRow[convgs_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvgs_PaperParagraphEN.ParagraphTypeName = objRow[convgs_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvgs_PaperParagraphEN.PaperId = objRow[convgs_PaperParagraph.PaperId].ToString().Trim(); //论文Id
objvgs_PaperParagraphEN.SectionId = objRow[convgs_PaperParagraph.SectionId].ToString().Trim(); //节Id
objvgs_PaperParagraphEN.ParagraphStateId = objRow[convgs_PaperParagraph.ParagraphStateId].ToString().Trim(); //段落状态Id
objvgs_PaperParagraphEN.ParagraphTypeId = objRow[convgs_PaperParagraph.ParagraphTypeId].ToString().Trim(); //段落类型Id
objvgs_PaperParagraphEN.ParagraphContent = objRow[convgs_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvgs_PaperParagraphEN.VoteCount = objRow[convgs_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvgs_PaperParagraphEN.CommentCount = objRow[convgs_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvgs_PaperParagraphEN.VersionCount = objRow[convgs_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperParagraphEN.CreateDate = objRow[convgs_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvgs_PaperParagraphEN.CreateUser = objRow[convgs_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvgs_PaperParagraphEN.UpdDate = objRow[convgs_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperParagraphEN.UpdUser = objRow[convgs_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvgs_PaperParagraphEN.Memo = objRow[convgs_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convgs_PaperParagraph.Memo].ToString().Trim(); //备注
objvgs_PaperParagraphEN.OrderNum = objRow[convgs_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperParagraphEN.ParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperParagraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_PaperParagraphEN> GetSubObjLstCache(clsvgs_PaperParagraphEN objvgs_PaperParagraphCond)
{
List<clsvgs_PaperParagraphEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PaperParagraphEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_PaperParagraph.AttributeName)
{
if (objvgs_PaperParagraphCond.IsUpdated(strFldName) == false) continue;
if (objvgs_PaperParagraphCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PaperParagraphCond[strFldName].ToString());
}
else
{
if (objvgs_PaperParagraphCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_PaperParagraphCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PaperParagraphCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_PaperParagraphCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_PaperParagraphCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_PaperParagraphCond[strFldName]));
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
public static List<clsvgs_PaperParagraphEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_PaperParagraphEN> arrObjLst = new List<clsvgs_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN();
try
{
objvgs_PaperParagraphEN.ParagraphId = objRow[convgs_PaperParagraph.ParagraphId].ToString().Trim(); //段落Id
objvgs_PaperParagraphEN.ParagraphStateName = objRow[convgs_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvgs_PaperParagraphEN.ParagraphTypeName = objRow[convgs_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvgs_PaperParagraphEN.PaperId = objRow[convgs_PaperParagraph.PaperId].ToString().Trim(); //论文Id
objvgs_PaperParagraphEN.SectionId = objRow[convgs_PaperParagraph.SectionId].ToString().Trim(); //节Id
objvgs_PaperParagraphEN.ParagraphStateId = objRow[convgs_PaperParagraph.ParagraphStateId].ToString().Trim(); //段落状态Id
objvgs_PaperParagraphEN.ParagraphTypeId = objRow[convgs_PaperParagraph.ParagraphTypeId].ToString().Trim(); //段落类型Id
objvgs_PaperParagraphEN.ParagraphContent = objRow[convgs_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvgs_PaperParagraphEN.VoteCount = objRow[convgs_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvgs_PaperParagraphEN.CommentCount = objRow[convgs_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvgs_PaperParagraphEN.VersionCount = objRow[convgs_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperParagraphEN.CreateDate = objRow[convgs_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvgs_PaperParagraphEN.CreateUser = objRow[convgs_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvgs_PaperParagraphEN.UpdDate = objRow[convgs_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperParagraphEN.UpdUser = objRow[convgs_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvgs_PaperParagraphEN.Memo = objRow[convgs_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convgs_PaperParagraph.Memo].ToString().Trim(); //备注
objvgs_PaperParagraphEN.OrderNum = objRow[convgs_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperParagraphEN.ParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperParagraphEN);
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
public static List<clsvgs_PaperParagraphEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_PaperParagraphEN> arrObjLst = new List<clsvgs_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN();
try
{
objvgs_PaperParagraphEN.ParagraphId = objRow[convgs_PaperParagraph.ParagraphId].ToString().Trim(); //段落Id
objvgs_PaperParagraphEN.ParagraphStateName = objRow[convgs_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvgs_PaperParagraphEN.ParagraphTypeName = objRow[convgs_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvgs_PaperParagraphEN.PaperId = objRow[convgs_PaperParagraph.PaperId].ToString().Trim(); //论文Id
objvgs_PaperParagraphEN.SectionId = objRow[convgs_PaperParagraph.SectionId].ToString().Trim(); //节Id
objvgs_PaperParagraphEN.ParagraphStateId = objRow[convgs_PaperParagraph.ParagraphStateId].ToString().Trim(); //段落状态Id
objvgs_PaperParagraphEN.ParagraphTypeId = objRow[convgs_PaperParagraph.ParagraphTypeId].ToString().Trim(); //段落类型Id
objvgs_PaperParagraphEN.ParagraphContent = objRow[convgs_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvgs_PaperParagraphEN.VoteCount = objRow[convgs_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvgs_PaperParagraphEN.CommentCount = objRow[convgs_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvgs_PaperParagraphEN.VersionCount = objRow[convgs_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperParagraphEN.CreateDate = objRow[convgs_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvgs_PaperParagraphEN.CreateUser = objRow[convgs_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvgs_PaperParagraphEN.UpdDate = objRow[convgs_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperParagraphEN.UpdUser = objRow[convgs_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvgs_PaperParagraphEN.Memo = objRow[convgs_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convgs_PaperParagraph.Memo].ToString().Trim(); //备注
objvgs_PaperParagraphEN.OrderNum = objRow[convgs_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperParagraphEN.ParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperParagraphEN);
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
List<clsvgs_PaperParagraphEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvgs_PaperParagraphEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PaperParagraphEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvgs_PaperParagraphEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_PaperParagraphEN> arrObjLst = new List<clsvgs_PaperParagraphEN>(); 
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
	clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN();
try
{
objvgs_PaperParagraphEN.ParagraphId = objRow[convgs_PaperParagraph.ParagraphId].ToString().Trim(); //段落Id
objvgs_PaperParagraphEN.ParagraphStateName = objRow[convgs_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvgs_PaperParagraphEN.ParagraphTypeName = objRow[convgs_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvgs_PaperParagraphEN.PaperId = objRow[convgs_PaperParagraph.PaperId].ToString().Trim(); //论文Id
objvgs_PaperParagraphEN.SectionId = objRow[convgs_PaperParagraph.SectionId].ToString().Trim(); //节Id
objvgs_PaperParagraphEN.ParagraphStateId = objRow[convgs_PaperParagraph.ParagraphStateId].ToString().Trim(); //段落状态Id
objvgs_PaperParagraphEN.ParagraphTypeId = objRow[convgs_PaperParagraph.ParagraphTypeId].ToString().Trim(); //段落类型Id
objvgs_PaperParagraphEN.ParagraphContent = objRow[convgs_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvgs_PaperParagraphEN.VoteCount = objRow[convgs_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvgs_PaperParagraphEN.CommentCount = objRow[convgs_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvgs_PaperParagraphEN.VersionCount = objRow[convgs_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperParagraphEN.CreateDate = objRow[convgs_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvgs_PaperParagraphEN.CreateUser = objRow[convgs_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvgs_PaperParagraphEN.UpdDate = objRow[convgs_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperParagraphEN.UpdUser = objRow[convgs_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvgs_PaperParagraphEN.Memo = objRow[convgs_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convgs_PaperParagraph.Memo].ToString().Trim(); //备注
objvgs_PaperParagraphEN.OrderNum = objRow[convgs_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperParagraphEN.ParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperParagraphEN);
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
public static List<clsvgs_PaperParagraphEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_PaperParagraphEN> arrObjLst = new List<clsvgs_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN();
try
{
objvgs_PaperParagraphEN.ParagraphId = objRow[convgs_PaperParagraph.ParagraphId].ToString().Trim(); //段落Id
objvgs_PaperParagraphEN.ParagraphStateName = objRow[convgs_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvgs_PaperParagraphEN.ParagraphTypeName = objRow[convgs_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvgs_PaperParagraphEN.PaperId = objRow[convgs_PaperParagraph.PaperId].ToString().Trim(); //论文Id
objvgs_PaperParagraphEN.SectionId = objRow[convgs_PaperParagraph.SectionId].ToString().Trim(); //节Id
objvgs_PaperParagraphEN.ParagraphStateId = objRow[convgs_PaperParagraph.ParagraphStateId].ToString().Trim(); //段落状态Id
objvgs_PaperParagraphEN.ParagraphTypeId = objRow[convgs_PaperParagraph.ParagraphTypeId].ToString().Trim(); //段落类型Id
objvgs_PaperParagraphEN.ParagraphContent = objRow[convgs_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvgs_PaperParagraphEN.VoteCount = objRow[convgs_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvgs_PaperParagraphEN.CommentCount = objRow[convgs_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvgs_PaperParagraphEN.VersionCount = objRow[convgs_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperParagraphEN.CreateDate = objRow[convgs_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvgs_PaperParagraphEN.CreateUser = objRow[convgs_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvgs_PaperParagraphEN.UpdDate = objRow[convgs_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperParagraphEN.UpdUser = objRow[convgs_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvgs_PaperParagraphEN.Memo = objRow[convgs_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convgs_PaperParagraph.Memo].ToString().Trim(); //备注
objvgs_PaperParagraphEN.OrderNum = objRow[convgs_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperParagraphEN.ParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperParagraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_PaperParagraphEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvgs_PaperParagraphEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_PaperParagraphEN> arrObjLst = new List<clsvgs_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN();
try
{
objvgs_PaperParagraphEN.ParagraphId = objRow[convgs_PaperParagraph.ParagraphId].ToString().Trim(); //段落Id
objvgs_PaperParagraphEN.ParagraphStateName = objRow[convgs_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvgs_PaperParagraphEN.ParagraphTypeName = objRow[convgs_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvgs_PaperParagraphEN.PaperId = objRow[convgs_PaperParagraph.PaperId].ToString().Trim(); //论文Id
objvgs_PaperParagraphEN.SectionId = objRow[convgs_PaperParagraph.SectionId].ToString().Trim(); //节Id
objvgs_PaperParagraphEN.ParagraphStateId = objRow[convgs_PaperParagraph.ParagraphStateId].ToString().Trim(); //段落状态Id
objvgs_PaperParagraphEN.ParagraphTypeId = objRow[convgs_PaperParagraph.ParagraphTypeId].ToString().Trim(); //段落类型Id
objvgs_PaperParagraphEN.ParagraphContent = objRow[convgs_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvgs_PaperParagraphEN.VoteCount = objRow[convgs_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvgs_PaperParagraphEN.CommentCount = objRow[convgs_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvgs_PaperParagraphEN.VersionCount = objRow[convgs_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperParagraphEN.CreateDate = objRow[convgs_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvgs_PaperParagraphEN.CreateUser = objRow[convgs_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvgs_PaperParagraphEN.UpdDate = objRow[convgs_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperParagraphEN.UpdUser = objRow[convgs_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvgs_PaperParagraphEN.Memo = objRow[convgs_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convgs_PaperParagraph.Memo].ToString().Trim(); //备注
objvgs_PaperParagraphEN.OrderNum = objRow[convgs_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperParagraphEN.ParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperParagraphEN);
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
public static List<clsvgs_PaperParagraphEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_PaperParagraphEN> arrObjLst = new List<clsvgs_PaperParagraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN();
try
{
objvgs_PaperParagraphEN.ParagraphId = objRow[convgs_PaperParagraph.ParagraphId].ToString().Trim(); //段落Id
objvgs_PaperParagraphEN.ParagraphStateName = objRow[convgs_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvgs_PaperParagraphEN.ParagraphTypeName = objRow[convgs_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvgs_PaperParagraphEN.PaperId = objRow[convgs_PaperParagraph.PaperId].ToString().Trim(); //论文Id
objvgs_PaperParagraphEN.SectionId = objRow[convgs_PaperParagraph.SectionId].ToString().Trim(); //节Id
objvgs_PaperParagraphEN.ParagraphStateId = objRow[convgs_PaperParagraph.ParagraphStateId].ToString().Trim(); //段落状态Id
objvgs_PaperParagraphEN.ParagraphTypeId = objRow[convgs_PaperParagraph.ParagraphTypeId].ToString().Trim(); //段落类型Id
objvgs_PaperParagraphEN.ParagraphContent = objRow[convgs_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvgs_PaperParagraphEN.VoteCount = objRow[convgs_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvgs_PaperParagraphEN.CommentCount = objRow[convgs_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvgs_PaperParagraphEN.VersionCount = objRow[convgs_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperParagraphEN.CreateDate = objRow[convgs_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvgs_PaperParagraphEN.CreateUser = objRow[convgs_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvgs_PaperParagraphEN.UpdDate = objRow[convgs_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperParagraphEN.UpdUser = objRow[convgs_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvgs_PaperParagraphEN.Memo = objRow[convgs_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convgs_PaperParagraph.Memo].ToString().Trim(); //备注
objvgs_PaperParagraphEN.OrderNum = objRow[convgs_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperParagraphEN.ParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperParagraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PaperParagraphEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_PaperParagraphEN> arrObjLst = new List<clsvgs_PaperParagraphEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN();
try
{
objvgs_PaperParagraphEN.ParagraphId = objRow[convgs_PaperParagraph.ParagraphId].ToString().Trim(); //段落Id
objvgs_PaperParagraphEN.ParagraphStateName = objRow[convgs_PaperParagraph.ParagraphStateName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphStateName].ToString().Trim(); //段落状态
objvgs_PaperParagraphEN.ParagraphTypeName = objRow[convgs_PaperParagraph.ParagraphTypeName] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphTypeName].ToString().Trim(); //段落类型
objvgs_PaperParagraphEN.PaperId = objRow[convgs_PaperParagraph.PaperId].ToString().Trim(); //论文Id
objvgs_PaperParagraphEN.SectionId = objRow[convgs_PaperParagraph.SectionId].ToString().Trim(); //节Id
objvgs_PaperParagraphEN.ParagraphStateId = objRow[convgs_PaperParagraph.ParagraphStateId].ToString().Trim(); //段落状态Id
objvgs_PaperParagraphEN.ParagraphTypeId = objRow[convgs_PaperParagraph.ParagraphTypeId].ToString().Trim(); //段落类型Id
objvgs_PaperParagraphEN.ParagraphContent = objRow[convgs_PaperParagraph.ParagraphContent] == DBNull.Value ? null : objRow[convgs_PaperParagraph.ParagraphContent].ToString().Trim(); //段落内容
objvgs_PaperParagraphEN.VoteCount = objRow[convgs_PaperParagraph.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VoteCount].ToString().Trim()); //点赞计数
objvgs_PaperParagraphEN.CommentCount = objRow[convgs_PaperParagraph.CommentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.CommentCount].ToString().Trim()); //评论数
objvgs_PaperParagraphEN.VersionCount = objRow[convgs_PaperParagraph.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperParagraphEN.CreateDate = objRow[convgs_PaperParagraph.CreateDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateDate].ToString().Trim(); //建立日期
objvgs_PaperParagraphEN.CreateUser = objRow[convgs_PaperParagraph.CreateUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.CreateUser].ToString().Trim(); //建立用户
objvgs_PaperParagraphEN.UpdDate = objRow[convgs_PaperParagraph.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperParagraphEN.UpdUser = objRow[convgs_PaperParagraph.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperParagraph.UpdUser].ToString().Trim(); //修改人
objvgs_PaperParagraphEN.Memo = objRow[convgs_PaperParagraph.Memo] == DBNull.Value ? null : objRow[convgs_PaperParagraph.Memo].ToString().Trim(); //备注
objvgs_PaperParagraphEN.OrderNum = objRow[convgs_PaperParagraph.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperParagraph.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperParagraphEN.ParagraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperParagraphEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_PaperParagraph(ref clsvgs_PaperParagraphEN objvgs_PaperParagraphEN)
{
bool bolResult = vgs_PaperParagraphDA.Getvgs_PaperParagraph(ref objvgs_PaperParagraphEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strParagraphId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PaperParagraphEN GetObjByParagraphId(string strParagraphId)
{
if (strParagraphId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strParagraphId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strParagraphId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strParagraphId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = vgs_PaperParagraphDA.GetObjByParagraphId(strParagraphId);
return objvgs_PaperParagraphEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_PaperParagraphEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = vgs_PaperParagraphDA.GetFirstObj(strWhereCond);
 return objvgs_PaperParagraphEN;
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
public static clsvgs_PaperParagraphEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = vgs_PaperParagraphDA.GetObjByDataRow(objRow);
 return objvgs_PaperParagraphEN;
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
public static clsvgs_PaperParagraphEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = vgs_PaperParagraphDA.GetObjByDataRow(objRow);
 return objvgs_PaperParagraphEN;
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
 /// <param name = "strParagraphId">所给的关键字</param>
 /// <param name = "lstvgs_PaperParagraphObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PaperParagraphEN GetObjByParagraphIdFromList(string strParagraphId, List<clsvgs_PaperParagraphEN> lstvgs_PaperParagraphObjLst)
{
foreach (clsvgs_PaperParagraphEN objvgs_PaperParagraphEN in lstvgs_PaperParagraphObjLst)
{
if (objvgs_PaperParagraphEN.ParagraphId == strParagraphId)
{
return objvgs_PaperParagraphEN;
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
 string strMaxParagraphId;
 try
 {
 strMaxParagraphId = clsvgs_PaperParagraphDA.GetMaxStrId();
 return strMaxParagraphId;
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
 string strParagraphId;
 try
 {
 strParagraphId = new clsvgs_PaperParagraphDA().GetFirstID(strWhereCond);
 return strParagraphId;
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
 arrList = vgs_PaperParagraphDA.GetID(strWhereCond);
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
bool bolIsExist = vgs_PaperParagraphDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strParagraphId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strParagraphId)
{
if (string.IsNullOrEmpty(strParagraphId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strParagraphId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vgs_PaperParagraphDA.IsExist(strParagraphId);
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
 bolIsExist = clsvgs_PaperParagraphDA.IsExistTable();
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
 bolIsExist = vgs_PaperParagraphDA.IsExistTable(strTabName);
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
 /// <param name = "objvgs_PaperParagraphENS">源对象</param>
 /// <param name = "objvgs_PaperParagraphENT">目标对象</param>
 public static void CopyTo(clsvgs_PaperParagraphEN objvgs_PaperParagraphENS, clsvgs_PaperParagraphEN objvgs_PaperParagraphENT)
{
try
{
objvgs_PaperParagraphENT.ParagraphId = objvgs_PaperParagraphENS.ParagraphId; //段落Id
objvgs_PaperParagraphENT.ParagraphStateName = objvgs_PaperParagraphENS.ParagraphStateName; //段落状态
objvgs_PaperParagraphENT.ParagraphTypeName = objvgs_PaperParagraphENS.ParagraphTypeName; //段落类型
objvgs_PaperParagraphENT.PaperId = objvgs_PaperParagraphENS.PaperId; //论文Id
objvgs_PaperParagraphENT.SectionId = objvgs_PaperParagraphENS.SectionId; //节Id
objvgs_PaperParagraphENT.ParagraphStateId = objvgs_PaperParagraphENS.ParagraphStateId; //段落状态Id
objvgs_PaperParagraphENT.ParagraphTypeId = objvgs_PaperParagraphENS.ParagraphTypeId; //段落类型Id
objvgs_PaperParagraphENT.ParagraphContent = objvgs_PaperParagraphENS.ParagraphContent; //段落内容
objvgs_PaperParagraphENT.VoteCount = objvgs_PaperParagraphENS.VoteCount; //点赞计数
objvgs_PaperParagraphENT.CommentCount = objvgs_PaperParagraphENS.CommentCount; //评论数
objvgs_PaperParagraphENT.VersionCount = objvgs_PaperParagraphENS.VersionCount; //版本统计
objvgs_PaperParagraphENT.CreateDate = objvgs_PaperParagraphENS.CreateDate; //建立日期
objvgs_PaperParagraphENT.CreateUser = objvgs_PaperParagraphENS.CreateUser; //建立用户
objvgs_PaperParagraphENT.UpdDate = objvgs_PaperParagraphENS.UpdDate; //修改日期
objvgs_PaperParagraphENT.UpdUser = objvgs_PaperParagraphENS.UpdUser; //修改人
objvgs_PaperParagraphENT.Memo = objvgs_PaperParagraphENS.Memo; //备注
objvgs_PaperParagraphENT.OrderNum = objvgs_PaperParagraphENS.OrderNum; //序号
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
 /// <param name = "objvgs_PaperParagraphEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_PaperParagraphEN objvgs_PaperParagraphEN)
{
try
{
objvgs_PaperParagraphEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_PaperParagraphEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_PaperParagraph.ParagraphId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperParagraphEN.ParagraphId = objvgs_PaperParagraphEN.ParagraphId; //段落Id
}
if (arrFldSet.Contains(convgs_PaperParagraph.ParagraphStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperParagraphEN.ParagraphStateName = objvgs_PaperParagraphEN.ParagraphStateName == "[null]" ? null :  objvgs_PaperParagraphEN.ParagraphStateName; //段落状态
}
if (arrFldSet.Contains(convgs_PaperParagraph.ParagraphTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperParagraphEN.ParagraphTypeName = objvgs_PaperParagraphEN.ParagraphTypeName == "[null]" ? null :  objvgs_PaperParagraphEN.ParagraphTypeName; //段落类型
}
if (arrFldSet.Contains(convgs_PaperParagraph.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperParagraphEN.PaperId = objvgs_PaperParagraphEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convgs_PaperParagraph.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperParagraphEN.SectionId = objvgs_PaperParagraphEN.SectionId; //节Id
}
if (arrFldSet.Contains(convgs_PaperParagraph.ParagraphStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperParagraphEN.ParagraphStateId = objvgs_PaperParagraphEN.ParagraphStateId; //段落状态Id
}
if (arrFldSet.Contains(convgs_PaperParagraph.ParagraphTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperParagraphEN.ParagraphTypeId = objvgs_PaperParagraphEN.ParagraphTypeId; //段落类型Id
}
if (arrFldSet.Contains(convgs_PaperParagraph.ParagraphContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperParagraphEN.ParagraphContent = objvgs_PaperParagraphEN.ParagraphContent == "[null]" ? null :  objvgs_PaperParagraphEN.ParagraphContent; //段落内容
}
if (arrFldSet.Contains(convgs_PaperParagraph.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperParagraphEN.VoteCount = objvgs_PaperParagraphEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(convgs_PaperParagraph.CommentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperParagraphEN.CommentCount = objvgs_PaperParagraphEN.CommentCount; //评论数
}
if (arrFldSet.Contains(convgs_PaperParagraph.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperParagraphEN.VersionCount = objvgs_PaperParagraphEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convgs_PaperParagraph.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperParagraphEN.CreateDate = objvgs_PaperParagraphEN.CreateDate == "[null]" ? null :  objvgs_PaperParagraphEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convgs_PaperParagraph.CreateUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperParagraphEN.CreateUser = objvgs_PaperParagraphEN.CreateUser == "[null]" ? null :  objvgs_PaperParagraphEN.CreateUser; //建立用户
}
if (arrFldSet.Contains(convgs_PaperParagraph.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperParagraphEN.UpdDate = objvgs_PaperParagraphEN.UpdDate == "[null]" ? null :  objvgs_PaperParagraphEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convgs_PaperParagraph.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperParagraphEN.UpdUser = objvgs_PaperParagraphEN.UpdUser == "[null]" ? null :  objvgs_PaperParagraphEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convgs_PaperParagraph.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperParagraphEN.Memo = objvgs_PaperParagraphEN.Memo == "[null]" ? null :  objvgs_PaperParagraphEN.Memo; //备注
}
if (arrFldSet.Contains(convgs_PaperParagraph.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperParagraphEN.OrderNum = objvgs_PaperParagraphEN.OrderNum; //序号
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
 /// <param name = "objvgs_PaperParagraphEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_PaperParagraphEN objvgs_PaperParagraphEN)
{
try
{
if (objvgs_PaperParagraphEN.ParagraphStateName == "[null]") objvgs_PaperParagraphEN.ParagraphStateName = null; //段落状态
if (objvgs_PaperParagraphEN.ParagraphTypeName == "[null]") objvgs_PaperParagraphEN.ParagraphTypeName = null; //段落类型
if (objvgs_PaperParagraphEN.ParagraphContent == "[null]") objvgs_PaperParagraphEN.ParagraphContent = null; //段落内容
if (objvgs_PaperParagraphEN.CreateDate == "[null]") objvgs_PaperParagraphEN.CreateDate = null; //建立日期
if (objvgs_PaperParagraphEN.CreateUser == "[null]") objvgs_PaperParagraphEN.CreateUser = null; //建立用户
if (objvgs_PaperParagraphEN.UpdDate == "[null]") objvgs_PaperParagraphEN.UpdDate = null; //修改日期
if (objvgs_PaperParagraphEN.UpdUser == "[null]") objvgs_PaperParagraphEN.UpdUser = null; //修改人
if (objvgs_PaperParagraphEN.Memo == "[null]") objvgs_PaperParagraphEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvgs_PaperParagraphEN objvgs_PaperParagraphEN)
{
 vgs_PaperParagraphDA.CheckProperty4Condition(objvgs_PaperParagraphEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_ParagraphId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convgs_PaperParagraph.ParagraphId); 
List<clsvgs_PaperParagraphEN> arrObjLst = clsvgs_PaperParagraphBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvgs_PaperParagraphEN objvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN()
{
ParagraphId = "0",
ParagraphStateName = "选[论文段落视图]..."
};
arrObjLst.Insert(0, objvgs_PaperParagraphEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convgs_PaperParagraph.ParagraphId;
objComboBox.DisplayMember = convgs_PaperParagraph.ParagraphStateName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_ParagraphId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[论文段落视图]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convgs_PaperParagraph.ParagraphId); 
IEnumerable<clsvgs_PaperParagraphEN> arrObjLst = clsvgs_PaperParagraphBL.GetObjLst(strCondition);
objDDL.DataValueField = convgs_PaperParagraph.ParagraphId;
objDDL.DataTextField = convgs_PaperParagraph.ParagraphStateName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ParagraphIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[论文段落视图]...","0");
List<clsvgs_PaperParagraphEN> arrvgs_PaperParagraphObjLst = GetAllvgs_PaperParagraphObjLstCache(); 
arrvgs_PaperParagraphObjLst = arrvgs_PaperParagraphObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = convgs_PaperParagraph.ParagraphId;
objDDL.DataTextField = convgs_PaperParagraph.ParagraphStateName;
objDDL.DataSource = arrvgs_PaperParagraphObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsgs_PaperParagraphBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperParagraphBL没有刷新缓存机制(clsgs_PaperParagraphBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_ParagraphStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_ParagraphStateBL没有刷新缓存机制(clsgs_ParagraphStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_ParagraphTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_ParagraphTypeBL没有刷新缓存机制(clsgs_ParagraphTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ParagraphId");
//if (arrvgs_PaperParagraphObjLstCache == null)
//{
//arrvgs_PaperParagraphObjLstCache = vgs_PaperParagraphDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strParagraphId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PaperParagraphEN GetObjByParagraphIdCache(string strParagraphId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvgs_PaperParagraphEN._CurrTabName);
List<clsvgs_PaperParagraphEN> arrvgs_PaperParagraphObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PaperParagraphEN> arrvgs_PaperParagraphObjLst_Sel =
arrvgs_PaperParagraphObjLstCache
.Where(x=> x.ParagraphId == strParagraphId 
);
if (arrvgs_PaperParagraphObjLst_Sel.Count() == 0)
{
   clsvgs_PaperParagraphEN obj = clsvgs_PaperParagraphBL.GetObjByParagraphId(strParagraphId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvgs_PaperParagraphObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strParagraphId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetParagraphTypeNameByParagraphIdCache(string strParagraphId)
{
if (string.IsNullOrEmpty(strParagraphId) == true) return "";
//获取缓存中的对象列表
clsvgs_PaperParagraphEN objvgs_PaperParagraph = GetObjByParagraphIdCache(strParagraphId);
if (objvgs_PaperParagraph == null) return "";
return objvgs_PaperParagraph.ParagraphTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strParagraphId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByParagraphIdCache(string strParagraphId)
{
if (string.IsNullOrEmpty(strParagraphId) == true) return "";
//获取缓存中的对象列表
clsvgs_PaperParagraphEN objvgs_PaperParagraph = GetObjByParagraphIdCache(strParagraphId);
if (objvgs_PaperParagraph == null) return "";
return objvgs_PaperParagraph.ParagraphTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PaperParagraphEN> GetAllvgs_PaperParagraphObjLstCache()
{
//获取缓存中的对象列表
List<clsvgs_PaperParagraphEN> arrvgs_PaperParagraphObjLstCache = GetObjLstCache(); 
return arrvgs_PaperParagraphObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PaperParagraphEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvgs_PaperParagraphEN._CurrTabName);
List<clsvgs_PaperParagraphEN> arrvgs_PaperParagraphObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvgs_PaperParagraphObjLstCache;
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
string strKey = string.Format("{0}", clsvgs_PaperParagraphEN._CurrTabName);
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

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--vgs_PaperParagraph(论文段落视图)
 /// 唯一性条件:ParagraphId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvgs_PaperParagraphEN objvgs_PaperParagraphEN)
{
//检测记录是否存在
string strResult = vgs_PaperParagraphDA.GetUniCondStr(objvgs_PaperParagraphEN);
return strResult;
}


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
public static string Func(string strInFldName, string strOutFldName, string strParagraphId)
{
if (strInFldName != convgs_PaperParagraph.ParagraphId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_PaperParagraph.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_PaperParagraph.AttributeName));
throw new Exception(strMsg);
}
var objvgs_PaperParagraph = clsvgs_PaperParagraphBL.GetObjByParagraphIdCache(strParagraphId);
if (objvgs_PaperParagraph == null) return "";
return objvgs_PaperParagraph[strOutFldName].ToString();
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
int intRecCount = clsvgs_PaperParagraphDA.GetRecCount(strTabName);
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
int intRecCount = clsvgs_PaperParagraphDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_PaperParagraphDA.GetRecCount();
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
int intRecCount = clsvgs_PaperParagraphDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_PaperParagraphCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_PaperParagraphEN objvgs_PaperParagraphCond)
{
List<clsvgs_PaperParagraphEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PaperParagraphEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_PaperParagraph.AttributeName)
{
if (objvgs_PaperParagraphCond.IsUpdated(strFldName) == false) continue;
if (objvgs_PaperParagraphCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PaperParagraphCond[strFldName].ToString());
}
else
{
if (objvgs_PaperParagraphCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_PaperParagraphCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PaperParagraphCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_PaperParagraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_PaperParagraphCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_PaperParagraphCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_PaperParagraphCond[strFldName]));
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
 List<string> arrList = clsvgs_PaperParagraphDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vgs_PaperParagraphDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vgs_PaperParagraphDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}