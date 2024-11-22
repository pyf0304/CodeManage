
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PaperAttentionBL
 表名:vgs_PaperAttention(01120750)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:15
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
public static class  clsvgs_PaperAttentionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperAttentionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PaperAttentionEN GetObj(this K_PaperAttentionId_vgs_PaperAttention myKey)
{
clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = clsvgs_PaperAttentionBL.vgs_PaperAttentionDA.GetObjByPaperAttentionId(myKey.Value);
return objvgs_PaperAttentionEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetPaperAttentionId(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, long lngPaperAttentionId, string strComparisonOp="")
	{
objvgs_PaperAttentionEN.PaperAttentionId = lngPaperAttentionId; //论文收藏Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.PaperAttentionId) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.PaperAttentionId, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.PaperAttentionId] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetPaperId(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convgs_PaperAttention.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convgs_PaperAttention.PaperId);
}
objvgs_PaperAttentionEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.PaperId) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.PaperId, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.PaperId] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetPaperTitle(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperTitle, convgs_PaperAttention.PaperTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convgs_PaperAttention.PaperTitle);
}
objvgs_PaperAttentionEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.PaperTitle) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.PaperTitle, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.PaperTitle] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetAuthor(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convgs_PaperAttention.Author);
}
objvgs_PaperAttentionEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.Author) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.Author, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.Author] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetKeyword(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convgs_PaperAttention.Keyword);
}
objvgs_PaperAttentionEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.Keyword) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.Keyword, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.Keyword] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetBrowseNumber(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, int? intBrowseNumber, string strComparisonOp="")
	{
objvgs_PaperAttentionEN.BrowseNumber = intBrowseNumber; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.BrowseNumber) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.BrowseNumber, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.BrowseNumber] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetUserId(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convgs_PaperAttention.UserId);
}
objvgs_PaperAttentionEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.UserId) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.UserId, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.UserId] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetPaperGroupId(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strPaperGroupId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperGroupId, 8, convgs_PaperAttention.PaperGroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperGroupId, 8, convgs_PaperAttention.PaperGroupId);
}
objvgs_PaperAttentionEN.PaperGroupId = strPaperGroupId; //组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.PaperGroupId) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.PaperGroupId, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.PaperGroupId] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetUpdUser(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convgs_PaperAttention.UpdUser);
}
objvgs_PaperAttentionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.UpdUser) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.UpdUser, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.UpdUser] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetUpdDate(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convgs_PaperAttention.UpdDate);
}
objvgs_PaperAttentionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.UpdDate) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.UpdDate, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.UpdDate] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetMeno(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strMeno, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMeno, 2000, convgs_PaperAttention.Meno);
}
objvgs_PaperAttentionEN.Meno = strMeno; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.Meno) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.Meno, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.Meno] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetPaperGroupName(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, string strPaperGroupName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperGroupName, 50, convgs_PaperAttention.PaperGroupName);
}
objvgs_PaperAttentionEN.PaperGroupName = strPaperGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.PaperGroupName) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.PaperGroupName, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.PaperGroupName] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetPaperQCount(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, int? intPaperQCount, string strComparisonOp="")
	{
objvgs_PaperAttentionEN.PaperQCount = intPaperQCount; //论文答疑数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.PaperQCount) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.PaperQCount, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.PaperQCount] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetSubVCount(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, int? intSubVCount, string strComparisonOp="")
	{
objvgs_PaperAttentionEN.SubVCount = intSubVCount; //论文子观点数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.SubVCount) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.SubVCount, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.SubVCount] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetTagsCount(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, int? intTagsCount, string strComparisonOp="")
	{
objvgs_PaperAttentionEN.TagsCount = intTagsCount; //论文标注数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.TagsCount) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.TagsCount, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.TagsCount] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperAttentionEN SetTeaQCount(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN, int? intTeaQCount, string strComparisonOp="")
	{
objvgs_PaperAttentionEN.TeaQCount = intTeaQCount; //教师提问数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(convgs_PaperAttention.TeaQCount) == false)
{
objvgs_PaperAttentionEN.dicFldComparisonOp.Add(convgs_PaperAttention.TeaQCount, strComparisonOp);
}
else
{
objvgs_PaperAttentionEN.dicFldComparisonOp[convgs_PaperAttention.TeaQCount] = strComparisonOp;
}
}
return objvgs_PaperAttentionEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionENS">源对象</param>
 /// <param name = "objvgs_PaperAttentionENT">目标对象</param>
 public static void CopyTo(this clsvgs_PaperAttentionEN objvgs_PaperAttentionENS, clsvgs_PaperAttentionEN objvgs_PaperAttentionENT)
{
try
{
objvgs_PaperAttentionENT.PaperAttentionId = objvgs_PaperAttentionENS.PaperAttentionId; //论文收藏Id
objvgs_PaperAttentionENT.PaperId = objvgs_PaperAttentionENS.PaperId; //论文Id
objvgs_PaperAttentionENT.PaperTitle = objvgs_PaperAttentionENS.PaperTitle; //论文标题
objvgs_PaperAttentionENT.Author = objvgs_PaperAttentionENS.Author; //作者
objvgs_PaperAttentionENT.Keyword = objvgs_PaperAttentionENS.Keyword; //关键字
objvgs_PaperAttentionENT.BrowseNumber = objvgs_PaperAttentionENS.BrowseNumber; //浏览量
objvgs_PaperAttentionENT.UserId = objvgs_PaperAttentionENS.UserId; //用户ID
objvgs_PaperAttentionENT.PaperGroupId = objvgs_PaperAttentionENS.PaperGroupId; //组Id
objvgs_PaperAttentionENT.UpdUser = objvgs_PaperAttentionENS.UpdUser; //修改人
objvgs_PaperAttentionENT.UpdDate = objvgs_PaperAttentionENS.UpdDate; //修改日期
objvgs_PaperAttentionENT.Meno = objvgs_PaperAttentionENS.Meno; //备注
objvgs_PaperAttentionENT.PaperGroupName = objvgs_PaperAttentionENS.PaperGroupName; //组名
objvgs_PaperAttentionENT.PaperQCount = objvgs_PaperAttentionENS.PaperQCount; //论文答疑数
objvgs_PaperAttentionENT.SubVCount = objvgs_PaperAttentionENS.SubVCount; //论文子观点数
objvgs_PaperAttentionENT.TagsCount = objvgs_PaperAttentionENS.TagsCount; //论文标注数
objvgs_PaperAttentionENT.TeaQCount = objvgs_PaperAttentionENS.TeaQCount; //教师提问数
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
 /// <param name = "objvgs_PaperAttentionENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PaperAttentionEN:objvgs_PaperAttentionENT</returns>
 public static clsvgs_PaperAttentionEN CopyTo(this clsvgs_PaperAttentionEN objvgs_PaperAttentionENS)
{
try
{
 clsvgs_PaperAttentionEN objvgs_PaperAttentionENT = new clsvgs_PaperAttentionEN()
{
PaperAttentionId = objvgs_PaperAttentionENS.PaperAttentionId, //论文收藏Id
PaperId = objvgs_PaperAttentionENS.PaperId, //论文Id
PaperTitle = objvgs_PaperAttentionENS.PaperTitle, //论文标题
Author = objvgs_PaperAttentionENS.Author, //作者
Keyword = objvgs_PaperAttentionENS.Keyword, //关键字
BrowseNumber = objvgs_PaperAttentionENS.BrowseNumber, //浏览量
UserId = objvgs_PaperAttentionENS.UserId, //用户ID
PaperGroupId = objvgs_PaperAttentionENS.PaperGroupId, //组Id
UpdUser = objvgs_PaperAttentionENS.UpdUser, //修改人
UpdDate = objvgs_PaperAttentionENS.UpdDate, //修改日期
Meno = objvgs_PaperAttentionENS.Meno, //备注
PaperGroupName = objvgs_PaperAttentionENS.PaperGroupName, //组名
PaperQCount = objvgs_PaperAttentionENS.PaperQCount, //论文答疑数
SubVCount = objvgs_PaperAttentionENS.SubVCount, //论文子观点数
TagsCount = objvgs_PaperAttentionENS.TagsCount, //论文标注数
TeaQCount = objvgs_PaperAttentionENS.TeaQCount, //教师提问数
};
 return objvgs_PaperAttentionENT;
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
public static void CheckProperty4Condition(this clsvgs_PaperAttentionEN objvgs_PaperAttentionEN)
{
 clsvgs_PaperAttentionBL.vgs_PaperAttentionDA.CheckProperty4Condition(objvgs_PaperAttentionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_PaperAttentionEN objvgs_PaperAttentionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_PaperAttentionCond.IsUpdated(convgs_PaperAttention.PaperAttentionId) == true)
{
string strComparisonOpPaperAttentionId = objvgs_PaperAttentionCond.dicFldComparisonOp[convgs_PaperAttention.PaperAttentionId];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperAttention.PaperAttentionId, objvgs_PaperAttentionCond.PaperAttentionId, strComparisonOpPaperAttentionId);
}
if (objvgs_PaperAttentionCond.IsUpdated(convgs_PaperAttention.PaperId) == true)
{
string strComparisonOpPaperId = objvgs_PaperAttentionCond.dicFldComparisonOp[convgs_PaperAttention.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.PaperId, objvgs_PaperAttentionCond.PaperId, strComparisonOpPaperId);
}
if (objvgs_PaperAttentionCond.IsUpdated(convgs_PaperAttention.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvgs_PaperAttentionCond.dicFldComparisonOp[convgs_PaperAttention.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.PaperTitle, objvgs_PaperAttentionCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvgs_PaperAttentionCond.IsUpdated(convgs_PaperAttention.Author) == true)
{
string strComparisonOpAuthor = objvgs_PaperAttentionCond.dicFldComparisonOp[convgs_PaperAttention.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.Author, objvgs_PaperAttentionCond.Author, strComparisonOpAuthor);
}
if (objvgs_PaperAttentionCond.IsUpdated(convgs_PaperAttention.Keyword) == true)
{
string strComparisonOpKeyword = objvgs_PaperAttentionCond.dicFldComparisonOp[convgs_PaperAttention.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.Keyword, objvgs_PaperAttentionCond.Keyword, strComparisonOpKeyword);
}
if (objvgs_PaperAttentionCond.IsUpdated(convgs_PaperAttention.BrowseNumber) == true)
{
string strComparisonOpBrowseNumber = objvgs_PaperAttentionCond.dicFldComparisonOp[convgs_PaperAttention.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperAttention.BrowseNumber, objvgs_PaperAttentionCond.BrowseNumber, strComparisonOpBrowseNumber);
}
if (objvgs_PaperAttentionCond.IsUpdated(convgs_PaperAttention.UserId) == true)
{
string strComparisonOpUserId = objvgs_PaperAttentionCond.dicFldComparisonOp[convgs_PaperAttention.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.UserId, objvgs_PaperAttentionCond.UserId, strComparisonOpUserId);
}
if (objvgs_PaperAttentionCond.IsUpdated(convgs_PaperAttention.PaperGroupId) == true)
{
string strComparisonOpPaperGroupId = objvgs_PaperAttentionCond.dicFldComparisonOp[convgs_PaperAttention.PaperGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.PaperGroupId, objvgs_PaperAttentionCond.PaperGroupId, strComparisonOpPaperGroupId);
}
if (objvgs_PaperAttentionCond.IsUpdated(convgs_PaperAttention.UpdUser) == true)
{
string strComparisonOpUpdUser = objvgs_PaperAttentionCond.dicFldComparisonOp[convgs_PaperAttention.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.UpdUser, objvgs_PaperAttentionCond.UpdUser, strComparisonOpUpdUser);
}
if (objvgs_PaperAttentionCond.IsUpdated(convgs_PaperAttention.UpdDate) == true)
{
string strComparisonOpUpdDate = objvgs_PaperAttentionCond.dicFldComparisonOp[convgs_PaperAttention.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.UpdDate, objvgs_PaperAttentionCond.UpdDate, strComparisonOpUpdDate);
}
if (objvgs_PaperAttentionCond.IsUpdated(convgs_PaperAttention.Meno) == true)
{
string strComparisonOpMeno = objvgs_PaperAttentionCond.dicFldComparisonOp[convgs_PaperAttention.Meno];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.Meno, objvgs_PaperAttentionCond.Meno, strComparisonOpMeno);
}
if (objvgs_PaperAttentionCond.IsUpdated(convgs_PaperAttention.PaperGroupName) == true)
{
string strComparisonOpPaperGroupName = objvgs_PaperAttentionCond.dicFldComparisonOp[convgs_PaperAttention.PaperGroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperAttention.PaperGroupName, objvgs_PaperAttentionCond.PaperGroupName, strComparisonOpPaperGroupName);
}
if (objvgs_PaperAttentionCond.IsUpdated(convgs_PaperAttention.PaperQCount) == true)
{
string strComparisonOpPaperQCount = objvgs_PaperAttentionCond.dicFldComparisonOp[convgs_PaperAttention.PaperQCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperAttention.PaperQCount, objvgs_PaperAttentionCond.PaperQCount, strComparisonOpPaperQCount);
}
if (objvgs_PaperAttentionCond.IsUpdated(convgs_PaperAttention.SubVCount) == true)
{
string strComparisonOpSubVCount = objvgs_PaperAttentionCond.dicFldComparisonOp[convgs_PaperAttention.SubVCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperAttention.SubVCount, objvgs_PaperAttentionCond.SubVCount, strComparisonOpSubVCount);
}
if (objvgs_PaperAttentionCond.IsUpdated(convgs_PaperAttention.TagsCount) == true)
{
string strComparisonOpTagsCount = objvgs_PaperAttentionCond.dicFldComparisonOp[convgs_PaperAttention.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperAttention.TagsCount, objvgs_PaperAttentionCond.TagsCount, strComparisonOpTagsCount);
}
if (objvgs_PaperAttentionCond.IsUpdated(convgs_PaperAttention.TeaQCount) == true)
{
string strComparisonOpTeaQCount = objvgs_PaperAttentionCond.dicFldComparisonOp[convgs_PaperAttention.TeaQCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperAttention.TeaQCount, objvgs_PaperAttentionCond.TeaQCount, strComparisonOpTeaQCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_PaperAttention
{
public virtual bool UpdRelaTabDate(long lngPaperAttentionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文关注视图(vgs_PaperAttention)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_PaperAttentionBL
{
public static RelatedActions_vgs_PaperAttention relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_PaperAttentionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_PaperAttentionDA vgs_PaperAttentionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_PaperAttentionDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_PaperAttentionBL()
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
if (string.IsNullOrEmpty(clsvgs_PaperAttentionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_PaperAttentionEN._ConnectString);
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
public static DataTable GetDataTable_vgs_PaperAttention(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_PaperAttentionDA.GetDataTable_vgs_PaperAttention(strWhereCond);
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
objDT = vgs_PaperAttentionDA.GetDataTable(strWhereCond);
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
objDT = vgs_PaperAttentionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vgs_PaperAttentionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vgs_PaperAttentionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vgs_PaperAttentionDA.GetDataTable_Top(objTopPara);
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
objDT = vgs_PaperAttentionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vgs_PaperAttentionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vgs_PaperAttentionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperAttentionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvgs_PaperAttentionEN> GetObjLstByPaperAttentionIdLst(List<long> arrPaperAttentionIdLst)
{
List<clsvgs_PaperAttentionEN> arrObjLst = new List<clsvgs_PaperAttentionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperAttentionIdLst);
 string strWhereCond = string.Format("PaperAttentionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = new clsvgs_PaperAttentionEN();
try
{
objvgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[convgs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objvgs_PaperAttentionEN.PaperId = objRow[convgs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objvgs_PaperAttentionEN.PaperTitle = objRow[convgs_PaperAttention.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperAttentionEN.Author = objRow[convgs_PaperAttention.Author] == DBNull.Value ? null : objRow[convgs_PaperAttention.Author].ToString().Trim(); //作者
objvgs_PaperAttentionEN.Keyword = objRow[convgs_PaperAttention.Keyword] == DBNull.Value ? null : objRow[convgs_PaperAttention.Keyword].ToString().Trim(); //关键字
objvgs_PaperAttentionEN.BrowseNumber = objRow[convgs_PaperAttention.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.BrowseNumber].ToString().Trim()); //浏览量
objvgs_PaperAttentionEN.UserId = objRow[convgs_PaperAttention.UserId] == DBNull.Value ? null : objRow[convgs_PaperAttention.UserId].ToString().Trim(); //用户ID
objvgs_PaperAttentionEN.PaperGroupId = objRow[convgs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objvgs_PaperAttentionEN.UpdUser = objRow[convgs_PaperAttention.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objvgs_PaperAttentionEN.UpdDate = objRow[convgs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperAttentionEN.Meno = objRow[convgs_PaperAttention.Meno] == DBNull.Value ? null : objRow[convgs_PaperAttention.Meno].ToString().Trim(); //备注
objvgs_PaperAttentionEN.PaperGroupName = objRow[convgs_PaperAttention.PaperGroupName] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupName].ToString().Trim(); //组名
objvgs_PaperAttentionEN.PaperQCount = objRow[convgs_PaperAttention.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.PaperQCount].ToString().Trim()); //论文答疑数
objvgs_PaperAttentionEN.SubVCount = objRow[convgs_PaperAttention.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.SubVCount].ToString().Trim()); //论文子观点数
objvgs_PaperAttentionEN.TagsCount = objRow[convgs_PaperAttention.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TagsCount].ToString().Trim()); //论文标注数
objvgs_PaperAttentionEN.TeaQCount = objRow[convgs_PaperAttention.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperAttentionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperAttentionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_PaperAttentionEN> GetObjLstByPaperAttentionIdLstCache(List<long> arrPaperAttentionIdLst, string strUserId)
{
string strKey = string.Format("{0}_{1}", clsvgs_PaperAttentionEN._CurrTabName, strUserId);
List<clsvgs_PaperAttentionEN> arrvgs_PaperAttentionObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsvgs_PaperAttentionEN> arrvgs_PaperAttentionObjLst_Sel =
arrvgs_PaperAttentionObjLstCache
.Where(x => arrPaperAttentionIdLst.Contains(x.PaperAttentionId));
return arrvgs_PaperAttentionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PaperAttentionEN> GetObjLst(string strWhereCond)
{
List<clsvgs_PaperAttentionEN> arrObjLst = new List<clsvgs_PaperAttentionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = new clsvgs_PaperAttentionEN();
try
{
objvgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[convgs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objvgs_PaperAttentionEN.PaperId = objRow[convgs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objvgs_PaperAttentionEN.PaperTitle = objRow[convgs_PaperAttention.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperAttentionEN.Author = objRow[convgs_PaperAttention.Author] == DBNull.Value ? null : objRow[convgs_PaperAttention.Author].ToString().Trim(); //作者
objvgs_PaperAttentionEN.Keyword = objRow[convgs_PaperAttention.Keyword] == DBNull.Value ? null : objRow[convgs_PaperAttention.Keyword].ToString().Trim(); //关键字
objvgs_PaperAttentionEN.BrowseNumber = objRow[convgs_PaperAttention.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.BrowseNumber].ToString().Trim()); //浏览量
objvgs_PaperAttentionEN.UserId = objRow[convgs_PaperAttention.UserId] == DBNull.Value ? null : objRow[convgs_PaperAttention.UserId].ToString().Trim(); //用户ID
objvgs_PaperAttentionEN.PaperGroupId = objRow[convgs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objvgs_PaperAttentionEN.UpdUser = objRow[convgs_PaperAttention.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objvgs_PaperAttentionEN.UpdDate = objRow[convgs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperAttentionEN.Meno = objRow[convgs_PaperAttention.Meno] == DBNull.Value ? null : objRow[convgs_PaperAttention.Meno].ToString().Trim(); //备注
objvgs_PaperAttentionEN.PaperGroupName = objRow[convgs_PaperAttention.PaperGroupName] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupName].ToString().Trim(); //组名
objvgs_PaperAttentionEN.PaperQCount = objRow[convgs_PaperAttention.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.PaperQCount].ToString().Trim()); //论文答疑数
objvgs_PaperAttentionEN.SubVCount = objRow[convgs_PaperAttention.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.SubVCount].ToString().Trim()); //论文子观点数
objvgs_PaperAttentionEN.TagsCount = objRow[convgs_PaperAttention.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TagsCount].ToString().Trim()); //论文标注数
objvgs_PaperAttentionEN.TeaQCount = objRow[convgs_PaperAttention.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperAttentionEN);
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
public static List<clsvgs_PaperAttentionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_PaperAttentionEN> arrObjLst = new List<clsvgs_PaperAttentionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = new clsvgs_PaperAttentionEN();
try
{
objvgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[convgs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objvgs_PaperAttentionEN.PaperId = objRow[convgs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objvgs_PaperAttentionEN.PaperTitle = objRow[convgs_PaperAttention.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperAttentionEN.Author = objRow[convgs_PaperAttention.Author] == DBNull.Value ? null : objRow[convgs_PaperAttention.Author].ToString().Trim(); //作者
objvgs_PaperAttentionEN.Keyword = objRow[convgs_PaperAttention.Keyword] == DBNull.Value ? null : objRow[convgs_PaperAttention.Keyword].ToString().Trim(); //关键字
objvgs_PaperAttentionEN.BrowseNumber = objRow[convgs_PaperAttention.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.BrowseNumber].ToString().Trim()); //浏览量
objvgs_PaperAttentionEN.UserId = objRow[convgs_PaperAttention.UserId] == DBNull.Value ? null : objRow[convgs_PaperAttention.UserId].ToString().Trim(); //用户ID
objvgs_PaperAttentionEN.PaperGroupId = objRow[convgs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objvgs_PaperAttentionEN.UpdUser = objRow[convgs_PaperAttention.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objvgs_PaperAttentionEN.UpdDate = objRow[convgs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperAttentionEN.Meno = objRow[convgs_PaperAttention.Meno] == DBNull.Value ? null : objRow[convgs_PaperAttention.Meno].ToString().Trim(); //备注
objvgs_PaperAttentionEN.PaperGroupName = objRow[convgs_PaperAttention.PaperGroupName] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupName].ToString().Trim(); //组名
objvgs_PaperAttentionEN.PaperQCount = objRow[convgs_PaperAttention.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.PaperQCount].ToString().Trim()); //论文答疑数
objvgs_PaperAttentionEN.SubVCount = objRow[convgs_PaperAttention.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.SubVCount].ToString().Trim()); //论文子观点数
objvgs_PaperAttentionEN.TagsCount = objRow[convgs_PaperAttention.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TagsCount].ToString().Trim()); //论文标注数
objvgs_PaperAttentionEN.TeaQCount = objRow[convgs_PaperAttention.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperAttentionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_PaperAttentionEN> GetSubObjLstCache(clsvgs_PaperAttentionEN objvgs_PaperAttentionCond)
{
 string strUserId = objvgs_PaperAttentionCond.UserId;
 if (string.IsNullOrEmpty(strUserId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvgs_PaperAttentionBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvgs_PaperAttentionEN> arrObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsvgs_PaperAttentionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_PaperAttention.AttributeName)
{
if (objvgs_PaperAttentionCond.IsUpdated(strFldName) == false) continue;
if (objvgs_PaperAttentionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PaperAttentionCond[strFldName].ToString());
}
else
{
if (objvgs_PaperAttentionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_PaperAttentionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PaperAttentionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_PaperAttentionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_PaperAttentionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_PaperAttentionCond[strFldName]));
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
public static List<clsvgs_PaperAttentionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_PaperAttentionEN> arrObjLst = new List<clsvgs_PaperAttentionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = new clsvgs_PaperAttentionEN();
try
{
objvgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[convgs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objvgs_PaperAttentionEN.PaperId = objRow[convgs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objvgs_PaperAttentionEN.PaperTitle = objRow[convgs_PaperAttention.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperAttentionEN.Author = objRow[convgs_PaperAttention.Author] == DBNull.Value ? null : objRow[convgs_PaperAttention.Author].ToString().Trim(); //作者
objvgs_PaperAttentionEN.Keyword = objRow[convgs_PaperAttention.Keyword] == DBNull.Value ? null : objRow[convgs_PaperAttention.Keyword].ToString().Trim(); //关键字
objvgs_PaperAttentionEN.BrowseNumber = objRow[convgs_PaperAttention.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.BrowseNumber].ToString().Trim()); //浏览量
objvgs_PaperAttentionEN.UserId = objRow[convgs_PaperAttention.UserId] == DBNull.Value ? null : objRow[convgs_PaperAttention.UserId].ToString().Trim(); //用户ID
objvgs_PaperAttentionEN.PaperGroupId = objRow[convgs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objvgs_PaperAttentionEN.UpdUser = objRow[convgs_PaperAttention.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objvgs_PaperAttentionEN.UpdDate = objRow[convgs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperAttentionEN.Meno = objRow[convgs_PaperAttention.Meno] == DBNull.Value ? null : objRow[convgs_PaperAttention.Meno].ToString().Trim(); //备注
objvgs_PaperAttentionEN.PaperGroupName = objRow[convgs_PaperAttention.PaperGroupName] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupName].ToString().Trim(); //组名
objvgs_PaperAttentionEN.PaperQCount = objRow[convgs_PaperAttention.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.PaperQCount].ToString().Trim()); //论文答疑数
objvgs_PaperAttentionEN.SubVCount = objRow[convgs_PaperAttention.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.SubVCount].ToString().Trim()); //论文子观点数
objvgs_PaperAttentionEN.TagsCount = objRow[convgs_PaperAttention.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TagsCount].ToString().Trim()); //论文标注数
objvgs_PaperAttentionEN.TeaQCount = objRow[convgs_PaperAttention.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperAttentionEN);
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
public static List<clsvgs_PaperAttentionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_PaperAttentionEN> arrObjLst = new List<clsvgs_PaperAttentionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = new clsvgs_PaperAttentionEN();
try
{
objvgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[convgs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objvgs_PaperAttentionEN.PaperId = objRow[convgs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objvgs_PaperAttentionEN.PaperTitle = objRow[convgs_PaperAttention.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperAttentionEN.Author = objRow[convgs_PaperAttention.Author] == DBNull.Value ? null : objRow[convgs_PaperAttention.Author].ToString().Trim(); //作者
objvgs_PaperAttentionEN.Keyword = objRow[convgs_PaperAttention.Keyword] == DBNull.Value ? null : objRow[convgs_PaperAttention.Keyword].ToString().Trim(); //关键字
objvgs_PaperAttentionEN.BrowseNumber = objRow[convgs_PaperAttention.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.BrowseNumber].ToString().Trim()); //浏览量
objvgs_PaperAttentionEN.UserId = objRow[convgs_PaperAttention.UserId] == DBNull.Value ? null : objRow[convgs_PaperAttention.UserId].ToString().Trim(); //用户ID
objvgs_PaperAttentionEN.PaperGroupId = objRow[convgs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objvgs_PaperAttentionEN.UpdUser = objRow[convgs_PaperAttention.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objvgs_PaperAttentionEN.UpdDate = objRow[convgs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperAttentionEN.Meno = objRow[convgs_PaperAttention.Meno] == DBNull.Value ? null : objRow[convgs_PaperAttention.Meno].ToString().Trim(); //备注
objvgs_PaperAttentionEN.PaperGroupName = objRow[convgs_PaperAttention.PaperGroupName] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupName].ToString().Trim(); //组名
objvgs_PaperAttentionEN.PaperQCount = objRow[convgs_PaperAttention.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.PaperQCount].ToString().Trim()); //论文答疑数
objvgs_PaperAttentionEN.SubVCount = objRow[convgs_PaperAttention.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.SubVCount].ToString().Trim()); //论文子观点数
objvgs_PaperAttentionEN.TagsCount = objRow[convgs_PaperAttention.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TagsCount].ToString().Trim()); //论文标注数
objvgs_PaperAttentionEN.TeaQCount = objRow[convgs_PaperAttention.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperAttentionEN);
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
List<clsvgs_PaperAttentionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvgs_PaperAttentionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PaperAttentionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvgs_PaperAttentionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_PaperAttentionEN> arrObjLst = new List<clsvgs_PaperAttentionEN>(); 
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
	clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = new clsvgs_PaperAttentionEN();
try
{
objvgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[convgs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objvgs_PaperAttentionEN.PaperId = objRow[convgs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objvgs_PaperAttentionEN.PaperTitle = objRow[convgs_PaperAttention.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperAttentionEN.Author = objRow[convgs_PaperAttention.Author] == DBNull.Value ? null : objRow[convgs_PaperAttention.Author].ToString().Trim(); //作者
objvgs_PaperAttentionEN.Keyword = objRow[convgs_PaperAttention.Keyword] == DBNull.Value ? null : objRow[convgs_PaperAttention.Keyword].ToString().Trim(); //关键字
objvgs_PaperAttentionEN.BrowseNumber = objRow[convgs_PaperAttention.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.BrowseNumber].ToString().Trim()); //浏览量
objvgs_PaperAttentionEN.UserId = objRow[convgs_PaperAttention.UserId] == DBNull.Value ? null : objRow[convgs_PaperAttention.UserId].ToString().Trim(); //用户ID
objvgs_PaperAttentionEN.PaperGroupId = objRow[convgs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objvgs_PaperAttentionEN.UpdUser = objRow[convgs_PaperAttention.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objvgs_PaperAttentionEN.UpdDate = objRow[convgs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperAttentionEN.Meno = objRow[convgs_PaperAttention.Meno] == DBNull.Value ? null : objRow[convgs_PaperAttention.Meno].ToString().Trim(); //备注
objvgs_PaperAttentionEN.PaperGroupName = objRow[convgs_PaperAttention.PaperGroupName] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupName].ToString().Trim(); //组名
objvgs_PaperAttentionEN.PaperQCount = objRow[convgs_PaperAttention.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.PaperQCount].ToString().Trim()); //论文答疑数
objvgs_PaperAttentionEN.SubVCount = objRow[convgs_PaperAttention.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.SubVCount].ToString().Trim()); //论文子观点数
objvgs_PaperAttentionEN.TagsCount = objRow[convgs_PaperAttention.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TagsCount].ToString().Trim()); //论文标注数
objvgs_PaperAttentionEN.TeaQCount = objRow[convgs_PaperAttention.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperAttentionEN);
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
public static List<clsvgs_PaperAttentionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_PaperAttentionEN> arrObjLst = new List<clsvgs_PaperAttentionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = new clsvgs_PaperAttentionEN();
try
{
objvgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[convgs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objvgs_PaperAttentionEN.PaperId = objRow[convgs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objvgs_PaperAttentionEN.PaperTitle = objRow[convgs_PaperAttention.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperAttentionEN.Author = objRow[convgs_PaperAttention.Author] == DBNull.Value ? null : objRow[convgs_PaperAttention.Author].ToString().Trim(); //作者
objvgs_PaperAttentionEN.Keyword = objRow[convgs_PaperAttention.Keyword] == DBNull.Value ? null : objRow[convgs_PaperAttention.Keyword].ToString().Trim(); //关键字
objvgs_PaperAttentionEN.BrowseNumber = objRow[convgs_PaperAttention.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.BrowseNumber].ToString().Trim()); //浏览量
objvgs_PaperAttentionEN.UserId = objRow[convgs_PaperAttention.UserId] == DBNull.Value ? null : objRow[convgs_PaperAttention.UserId].ToString().Trim(); //用户ID
objvgs_PaperAttentionEN.PaperGroupId = objRow[convgs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objvgs_PaperAttentionEN.UpdUser = objRow[convgs_PaperAttention.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objvgs_PaperAttentionEN.UpdDate = objRow[convgs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperAttentionEN.Meno = objRow[convgs_PaperAttention.Meno] == DBNull.Value ? null : objRow[convgs_PaperAttention.Meno].ToString().Trim(); //备注
objvgs_PaperAttentionEN.PaperGroupName = objRow[convgs_PaperAttention.PaperGroupName] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupName].ToString().Trim(); //组名
objvgs_PaperAttentionEN.PaperQCount = objRow[convgs_PaperAttention.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.PaperQCount].ToString().Trim()); //论文答疑数
objvgs_PaperAttentionEN.SubVCount = objRow[convgs_PaperAttention.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.SubVCount].ToString().Trim()); //论文子观点数
objvgs_PaperAttentionEN.TagsCount = objRow[convgs_PaperAttention.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TagsCount].ToString().Trim()); //论文标注数
objvgs_PaperAttentionEN.TeaQCount = objRow[convgs_PaperAttention.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperAttentionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_PaperAttentionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvgs_PaperAttentionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_PaperAttentionEN> arrObjLst = new List<clsvgs_PaperAttentionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = new clsvgs_PaperAttentionEN();
try
{
objvgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[convgs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objvgs_PaperAttentionEN.PaperId = objRow[convgs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objvgs_PaperAttentionEN.PaperTitle = objRow[convgs_PaperAttention.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperAttentionEN.Author = objRow[convgs_PaperAttention.Author] == DBNull.Value ? null : objRow[convgs_PaperAttention.Author].ToString().Trim(); //作者
objvgs_PaperAttentionEN.Keyword = objRow[convgs_PaperAttention.Keyword] == DBNull.Value ? null : objRow[convgs_PaperAttention.Keyword].ToString().Trim(); //关键字
objvgs_PaperAttentionEN.BrowseNumber = objRow[convgs_PaperAttention.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.BrowseNumber].ToString().Trim()); //浏览量
objvgs_PaperAttentionEN.UserId = objRow[convgs_PaperAttention.UserId] == DBNull.Value ? null : objRow[convgs_PaperAttention.UserId].ToString().Trim(); //用户ID
objvgs_PaperAttentionEN.PaperGroupId = objRow[convgs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objvgs_PaperAttentionEN.UpdUser = objRow[convgs_PaperAttention.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objvgs_PaperAttentionEN.UpdDate = objRow[convgs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperAttentionEN.Meno = objRow[convgs_PaperAttention.Meno] == DBNull.Value ? null : objRow[convgs_PaperAttention.Meno].ToString().Trim(); //备注
objvgs_PaperAttentionEN.PaperGroupName = objRow[convgs_PaperAttention.PaperGroupName] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupName].ToString().Trim(); //组名
objvgs_PaperAttentionEN.PaperQCount = objRow[convgs_PaperAttention.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.PaperQCount].ToString().Trim()); //论文答疑数
objvgs_PaperAttentionEN.SubVCount = objRow[convgs_PaperAttention.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.SubVCount].ToString().Trim()); //论文子观点数
objvgs_PaperAttentionEN.TagsCount = objRow[convgs_PaperAttention.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TagsCount].ToString().Trim()); //论文标注数
objvgs_PaperAttentionEN.TeaQCount = objRow[convgs_PaperAttention.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperAttentionEN);
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
public static List<clsvgs_PaperAttentionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_PaperAttentionEN> arrObjLst = new List<clsvgs_PaperAttentionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = new clsvgs_PaperAttentionEN();
try
{
objvgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[convgs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objvgs_PaperAttentionEN.PaperId = objRow[convgs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objvgs_PaperAttentionEN.PaperTitle = objRow[convgs_PaperAttention.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperAttentionEN.Author = objRow[convgs_PaperAttention.Author] == DBNull.Value ? null : objRow[convgs_PaperAttention.Author].ToString().Trim(); //作者
objvgs_PaperAttentionEN.Keyword = objRow[convgs_PaperAttention.Keyword] == DBNull.Value ? null : objRow[convgs_PaperAttention.Keyword].ToString().Trim(); //关键字
objvgs_PaperAttentionEN.BrowseNumber = objRow[convgs_PaperAttention.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.BrowseNumber].ToString().Trim()); //浏览量
objvgs_PaperAttentionEN.UserId = objRow[convgs_PaperAttention.UserId] == DBNull.Value ? null : objRow[convgs_PaperAttention.UserId].ToString().Trim(); //用户ID
objvgs_PaperAttentionEN.PaperGroupId = objRow[convgs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objvgs_PaperAttentionEN.UpdUser = objRow[convgs_PaperAttention.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objvgs_PaperAttentionEN.UpdDate = objRow[convgs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperAttentionEN.Meno = objRow[convgs_PaperAttention.Meno] == DBNull.Value ? null : objRow[convgs_PaperAttention.Meno].ToString().Trim(); //备注
objvgs_PaperAttentionEN.PaperGroupName = objRow[convgs_PaperAttention.PaperGroupName] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupName].ToString().Trim(); //组名
objvgs_PaperAttentionEN.PaperQCount = objRow[convgs_PaperAttention.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.PaperQCount].ToString().Trim()); //论文答疑数
objvgs_PaperAttentionEN.SubVCount = objRow[convgs_PaperAttention.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.SubVCount].ToString().Trim()); //论文子观点数
objvgs_PaperAttentionEN.TagsCount = objRow[convgs_PaperAttention.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TagsCount].ToString().Trim()); //论文标注数
objvgs_PaperAttentionEN.TeaQCount = objRow[convgs_PaperAttention.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperAttentionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PaperAttentionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_PaperAttentionEN> arrObjLst = new List<clsvgs_PaperAttentionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = new clsvgs_PaperAttentionEN();
try
{
objvgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[convgs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objvgs_PaperAttentionEN.PaperId = objRow[convgs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objvgs_PaperAttentionEN.PaperTitle = objRow[convgs_PaperAttention.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperAttentionEN.Author = objRow[convgs_PaperAttention.Author] == DBNull.Value ? null : objRow[convgs_PaperAttention.Author].ToString().Trim(); //作者
objvgs_PaperAttentionEN.Keyword = objRow[convgs_PaperAttention.Keyword] == DBNull.Value ? null : objRow[convgs_PaperAttention.Keyword].ToString().Trim(); //关键字
objvgs_PaperAttentionEN.BrowseNumber = objRow[convgs_PaperAttention.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.BrowseNumber].ToString().Trim()); //浏览量
objvgs_PaperAttentionEN.UserId = objRow[convgs_PaperAttention.UserId] == DBNull.Value ? null : objRow[convgs_PaperAttention.UserId].ToString().Trim(); //用户ID
objvgs_PaperAttentionEN.PaperGroupId = objRow[convgs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objvgs_PaperAttentionEN.UpdUser = objRow[convgs_PaperAttention.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objvgs_PaperAttentionEN.UpdDate = objRow[convgs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperAttentionEN.Meno = objRow[convgs_PaperAttention.Meno] == DBNull.Value ? null : objRow[convgs_PaperAttention.Meno].ToString().Trim(); //备注
objvgs_PaperAttentionEN.PaperGroupName = objRow[convgs_PaperAttention.PaperGroupName] == DBNull.Value ? null : objRow[convgs_PaperAttention.PaperGroupName].ToString().Trim(); //组名
objvgs_PaperAttentionEN.PaperQCount = objRow[convgs_PaperAttention.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.PaperQCount].ToString().Trim()); //论文答疑数
objvgs_PaperAttentionEN.SubVCount = objRow[convgs_PaperAttention.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.SubVCount].ToString().Trim()); //论文子观点数
objvgs_PaperAttentionEN.TagsCount = objRow[convgs_PaperAttention.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TagsCount].ToString().Trim()); //论文标注数
objvgs_PaperAttentionEN.TeaQCount = objRow[convgs_PaperAttention.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperAttention.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperAttentionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_PaperAttention(ref clsvgs_PaperAttentionEN objvgs_PaperAttentionEN)
{
bool bolResult = vgs_PaperAttentionDA.Getvgs_PaperAttention(ref objvgs_PaperAttentionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperAttentionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PaperAttentionEN GetObjByPaperAttentionId(long lngPaperAttentionId)
{
clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = vgs_PaperAttentionDA.GetObjByPaperAttentionId(lngPaperAttentionId);
return objvgs_PaperAttentionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_PaperAttentionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = vgs_PaperAttentionDA.GetFirstObj(strWhereCond);
 return objvgs_PaperAttentionEN;
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
public static clsvgs_PaperAttentionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = vgs_PaperAttentionDA.GetObjByDataRow(objRow);
 return objvgs_PaperAttentionEN;
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
public static clsvgs_PaperAttentionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_PaperAttentionEN objvgs_PaperAttentionEN = vgs_PaperAttentionDA.GetObjByDataRow(objRow);
 return objvgs_PaperAttentionEN;
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
 /// <param name = "lngPaperAttentionId">所给的关键字</param>
 /// <param name = "lstvgs_PaperAttentionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PaperAttentionEN GetObjByPaperAttentionIdFromList(long lngPaperAttentionId, List<clsvgs_PaperAttentionEN> lstvgs_PaperAttentionObjLst)
{
foreach (clsvgs_PaperAttentionEN objvgs_PaperAttentionEN in lstvgs_PaperAttentionObjLst)
{
if (objvgs_PaperAttentionEN.PaperAttentionId == lngPaperAttentionId)
{
return objvgs_PaperAttentionEN;
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
 long lngPaperAttentionId;
 try
 {
 lngPaperAttentionId = new clsvgs_PaperAttentionDA().GetFirstID(strWhereCond);
 return lngPaperAttentionId;
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
 arrList = vgs_PaperAttentionDA.GetID(strWhereCond);
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
bool bolIsExist = vgs_PaperAttentionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngPaperAttentionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngPaperAttentionId)
{
//检测记录是否存在
bool bolIsExist = vgs_PaperAttentionDA.IsExist(lngPaperAttentionId);
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
 bolIsExist = clsvgs_PaperAttentionDA.IsExistTable();
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
 bolIsExist = vgs_PaperAttentionDA.IsExistTable(strTabName);
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
 /// <param name = "objvgs_PaperAttentionENS">源对象</param>
 /// <param name = "objvgs_PaperAttentionENT">目标对象</param>
 public static void CopyTo(clsvgs_PaperAttentionEN objvgs_PaperAttentionENS, clsvgs_PaperAttentionEN objvgs_PaperAttentionENT)
{
try
{
objvgs_PaperAttentionENT.PaperAttentionId = objvgs_PaperAttentionENS.PaperAttentionId; //论文收藏Id
objvgs_PaperAttentionENT.PaperId = objvgs_PaperAttentionENS.PaperId; //论文Id
objvgs_PaperAttentionENT.PaperTitle = objvgs_PaperAttentionENS.PaperTitle; //论文标题
objvgs_PaperAttentionENT.Author = objvgs_PaperAttentionENS.Author; //作者
objvgs_PaperAttentionENT.Keyword = objvgs_PaperAttentionENS.Keyword; //关键字
objvgs_PaperAttentionENT.BrowseNumber = objvgs_PaperAttentionENS.BrowseNumber; //浏览量
objvgs_PaperAttentionENT.UserId = objvgs_PaperAttentionENS.UserId; //用户ID
objvgs_PaperAttentionENT.PaperGroupId = objvgs_PaperAttentionENS.PaperGroupId; //组Id
objvgs_PaperAttentionENT.UpdUser = objvgs_PaperAttentionENS.UpdUser; //修改人
objvgs_PaperAttentionENT.UpdDate = objvgs_PaperAttentionENS.UpdDate; //修改日期
objvgs_PaperAttentionENT.Meno = objvgs_PaperAttentionENS.Meno; //备注
objvgs_PaperAttentionENT.PaperGroupName = objvgs_PaperAttentionENS.PaperGroupName; //组名
objvgs_PaperAttentionENT.PaperQCount = objvgs_PaperAttentionENS.PaperQCount; //论文答疑数
objvgs_PaperAttentionENT.SubVCount = objvgs_PaperAttentionENS.SubVCount; //论文子观点数
objvgs_PaperAttentionENT.TagsCount = objvgs_PaperAttentionENS.TagsCount; //论文标注数
objvgs_PaperAttentionENT.TeaQCount = objvgs_PaperAttentionENS.TeaQCount; //教师提问数
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
 /// <param name = "objvgs_PaperAttentionEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_PaperAttentionEN objvgs_PaperAttentionEN)
{
try
{
objvgs_PaperAttentionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_PaperAttentionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_PaperAttention.PaperAttentionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperAttentionEN.PaperAttentionId = objvgs_PaperAttentionEN.PaperAttentionId; //论文收藏Id
}
if (arrFldSet.Contains(convgs_PaperAttention.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperAttentionEN.PaperId = objvgs_PaperAttentionEN.PaperId == "[null]" ? null :  objvgs_PaperAttentionEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convgs_PaperAttention.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperAttentionEN.PaperTitle = objvgs_PaperAttentionEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convgs_PaperAttention.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperAttentionEN.Author = objvgs_PaperAttentionEN.Author == "[null]" ? null :  objvgs_PaperAttentionEN.Author; //作者
}
if (arrFldSet.Contains(convgs_PaperAttention.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperAttentionEN.Keyword = objvgs_PaperAttentionEN.Keyword == "[null]" ? null :  objvgs_PaperAttentionEN.Keyword; //关键字
}
if (arrFldSet.Contains(convgs_PaperAttention.BrowseNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperAttentionEN.BrowseNumber = objvgs_PaperAttentionEN.BrowseNumber; //浏览量
}
if (arrFldSet.Contains(convgs_PaperAttention.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperAttentionEN.UserId = objvgs_PaperAttentionEN.UserId == "[null]" ? null :  objvgs_PaperAttentionEN.UserId; //用户ID
}
if (arrFldSet.Contains(convgs_PaperAttention.PaperGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperAttentionEN.PaperGroupId = objvgs_PaperAttentionEN.PaperGroupId == "[null]" ? null :  objvgs_PaperAttentionEN.PaperGroupId; //组Id
}
if (arrFldSet.Contains(convgs_PaperAttention.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperAttentionEN.UpdUser = objvgs_PaperAttentionEN.UpdUser == "[null]" ? null :  objvgs_PaperAttentionEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convgs_PaperAttention.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperAttentionEN.UpdDate = objvgs_PaperAttentionEN.UpdDate == "[null]" ? null :  objvgs_PaperAttentionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convgs_PaperAttention.Meno, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperAttentionEN.Meno = objvgs_PaperAttentionEN.Meno == "[null]" ? null :  objvgs_PaperAttentionEN.Meno; //备注
}
if (arrFldSet.Contains(convgs_PaperAttention.PaperGroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperAttentionEN.PaperGroupName = objvgs_PaperAttentionEN.PaperGroupName == "[null]" ? null :  objvgs_PaperAttentionEN.PaperGroupName; //组名
}
if (arrFldSet.Contains(convgs_PaperAttention.PaperQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperAttentionEN.PaperQCount = objvgs_PaperAttentionEN.PaperQCount; //论文答疑数
}
if (arrFldSet.Contains(convgs_PaperAttention.SubVCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperAttentionEN.SubVCount = objvgs_PaperAttentionEN.SubVCount; //论文子观点数
}
if (arrFldSet.Contains(convgs_PaperAttention.TagsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperAttentionEN.TagsCount = objvgs_PaperAttentionEN.TagsCount; //论文标注数
}
if (arrFldSet.Contains(convgs_PaperAttention.TeaQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperAttentionEN.TeaQCount = objvgs_PaperAttentionEN.TeaQCount; //教师提问数
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
 /// <param name = "objvgs_PaperAttentionEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_PaperAttentionEN objvgs_PaperAttentionEN)
{
try
{
if (objvgs_PaperAttentionEN.PaperId == "[null]") objvgs_PaperAttentionEN.PaperId = null; //论文Id
if (objvgs_PaperAttentionEN.Author == "[null]") objvgs_PaperAttentionEN.Author = null; //作者
if (objvgs_PaperAttentionEN.Keyword == "[null]") objvgs_PaperAttentionEN.Keyword = null; //关键字
if (objvgs_PaperAttentionEN.UserId == "[null]") objvgs_PaperAttentionEN.UserId = null; //用户ID
if (objvgs_PaperAttentionEN.PaperGroupId == "[null]") objvgs_PaperAttentionEN.PaperGroupId = null; //组Id
if (objvgs_PaperAttentionEN.UpdUser == "[null]") objvgs_PaperAttentionEN.UpdUser = null; //修改人
if (objvgs_PaperAttentionEN.UpdDate == "[null]") objvgs_PaperAttentionEN.UpdDate = null; //修改日期
if (objvgs_PaperAttentionEN.Meno == "[null]") objvgs_PaperAttentionEN.Meno = null; //备注
if (objvgs_PaperAttentionEN.PaperGroupName == "[null]") objvgs_PaperAttentionEN.PaperGroupName = null; //组名
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
public static void CheckProperty4Condition(clsvgs_PaperAttentionEN objvgs_PaperAttentionEN)
{
 vgs_PaperAttentionDA.CheckProperty4Condition(objvgs_PaperAttentionEN);
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
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_PaperAttentionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperAttentionBL没有刷新缓存机制(clsgs_PaperAttentionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_PaperGroupBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperGroupBL没有刷新缓存机制(clsgs_PaperGroupBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperAttentionId");
//if (arrvgs_PaperAttentionObjLstCache == null)
//{
//arrvgs_PaperAttentionObjLstCache = vgs_PaperAttentionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPaperAttentionId">所给的关键字</param>
 /// <param name = "strUserId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PaperAttentionEN GetObjByPaperAttentionIdCache(long lngPaperAttentionId, string strUserId)
{

if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strUserId.Length != 18)
{
var strMsg = string.Format("缓存分类变量:[strUserId]的长度:[{0}]不正确!(In {1})", strUserId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvgs_PaperAttentionEN._CurrTabName, strUserId);
List<clsvgs_PaperAttentionEN> arrvgs_PaperAttentionObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsvgs_PaperAttentionEN> arrvgs_PaperAttentionObjLst_Sel =
arrvgs_PaperAttentionObjLstCache
.Where(x=> x.PaperAttentionId == lngPaperAttentionId 
);
if (arrvgs_PaperAttentionObjLst_Sel.Count() == 0)
{
   clsvgs_PaperAttentionEN obj = clsvgs_PaperAttentionBL.GetObjByPaperAttentionId(lngPaperAttentionId);
   if (obj != null)
 {
if (obj.UserId == strUserId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngPaperAttentionId, strUserId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvgs_PaperAttentionObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PaperAttentionEN> GetAllvgs_PaperAttentionObjLstCache(string strUserId)
{
//获取缓存中的对象列表
List<clsvgs_PaperAttentionEN> arrvgs_PaperAttentionObjLstCache = GetObjLstCache(strUserId); 
return arrvgs_PaperAttentionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PaperAttentionEN> GetObjLstCache(string strUserId)
{

if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strUserId.Length != 18)
{
var strMsg = string.Format("缓存分类变量:[strUserId]的长度:[{0}]不正确!(In {1})", strUserId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvgs_PaperAttentionEN._CurrTabName, strUserId);
string strCondition = string.Format("UserId='{0}'", strUserId);
List<clsvgs_PaperAttentionEN> arrvgs_PaperAttentionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvgs_PaperAttentionObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strUserId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvgs_PaperAttentionEN._CurrTabName, strUserId);
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
 /// <param name = "strUserId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngPaperAttentionId, string strUserId)
{
if (strInFldName != convgs_PaperAttention.PaperAttentionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_PaperAttention.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_PaperAttention.AttributeName));
throw new Exception(strMsg);
}
var objvgs_PaperAttention = clsvgs_PaperAttentionBL.GetObjByPaperAttentionIdCache(lngPaperAttentionId, strUserId);
if (objvgs_PaperAttention == null) return "";
return objvgs_PaperAttention[strOutFldName].ToString();
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
int intRecCount = clsvgs_PaperAttentionDA.GetRecCount(strTabName);
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
int intRecCount = clsvgs_PaperAttentionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_PaperAttentionDA.GetRecCount();
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
int intRecCount = clsvgs_PaperAttentionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_PaperAttentionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_PaperAttentionEN objvgs_PaperAttentionCond)
{
 string strUserId = objvgs_PaperAttentionCond.UserId;
 if (string.IsNullOrEmpty(strUserId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvgs_PaperAttentionBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvgs_PaperAttentionEN> arrObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsvgs_PaperAttentionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_PaperAttention.AttributeName)
{
if (objvgs_PaperAttentionCond.IsUpdated(strFldName) == false) continue;
if (objvgs_PaperAttentionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PaperAttentionCond[strFldName].ToString());
}
else
{
if (objvgs_PaperAttentionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_PaperAttentionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PaperAttentionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_PaperAttentionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_PaperAttentionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_PaperAttentionCond[strFldName]));
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
 List<string> arrList = clsvgs_PaperAttentionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vgs_PaperAttentionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vgs_PaperAttentionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}