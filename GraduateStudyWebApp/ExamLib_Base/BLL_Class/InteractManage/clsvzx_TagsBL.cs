
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TagsBL
 表名:vzx_Tags(01120854)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clsvzx_TagsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxTagsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_TagsEN GetObj(this K_zxTagsId_vzx_Tags myKey)
{
clsvzx_TagsEN objvzx_TagsEN = clsvzx_TagsBL.vzx_TagsDA.GetObjByzxTagsId(myKey.Value);
return objvzx_TagsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetTextTitle(this clsvzx_TagsEN objvzx_TagsEN, string strTextTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextTitle, 500, convzx_Tags.TextTitle);
}
objvzx_TagsEN.TextTitle = strTextTitle; //TextTitle
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.TextTitle) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.TextTitle, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.TextTitle] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetTextContent(this clsvzx_TagsEN objvzx_TagsEN, string strTextContent, string strComparisonOp="")
	{
objvzx_TagsEN.TextContent = strTextContent; //TextContent
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.TextContent) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.TextContent, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.TextContent] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetAuthor(this clsvzx_TagsEN objvzx_TagsEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convzx_Tags.Author);
}
objvzx_TagsEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.Author) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.Author, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.Author] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetKeyword(this clsvzx_TagsEN objvzx_TagsEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convzx_Tags.Keyword);
}
objvzx_TagsEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.Keyword) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.Keyword, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.Keyword] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetzxTagsId(this clsvzx_TagsEN objvzx_TagsEN, string strzxTagsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxTagsId, 10, convzx_Tags.zxTagsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxTagsId, 10, convzx_Tags.zxTagsId);
}
objvzx_TagsEN.zxTagsId = strzxTagsId; //标注Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.zxTagsId) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.zxTagsId, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.zxTagsId] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetTagsContent(this clsvzx_TagsEN objvzx_TagsEN, string strTagsContent, string strComparisonOp="")
	{
objvzx_TagsEN.TagsContent = strTagsContent; //标注内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.TagsContent) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.TagsContent, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.TagsContent] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetPdfContent(this clsvzx_TagsEN objvzx_TagsEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convzx_Tags.PdfContent);
}
objvzx_TagsEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.PdfContent) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.PdfContent, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.PdfContent] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetPdfPageNum(this clsvzx_TagsEN objvzx_TagsEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvzx_TagsEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.PdfPageNum) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.PdfPageNum, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.PdfPageNum] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetVoteCount(this clsvzx_TagsEN objvzx_TagsEN, int? intVoteCount, string strComparisonOp="")
	{
objvzx_TagsEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.VoteCount) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.VoteCount, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.VoteCount] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetOrderNum(this clsvzx_TagsEN objvzx_TagsEN, int? intOrderNum, string strComparisonOp="")
	{
objvzx_TagsEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.OrderNum) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.OrderNum, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.OrderNum] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetUpdUser(this clsvzx_TagsEN objvzx_TagsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_Tags.UpdUser);
}
objvzx_TagsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.UpdUser) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.UpdUser, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.UpdUser] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetUpdDate(this clsvzx_TagsEN objvzx_TagsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_Tags.UpdDate);
}
objvzx_TagsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.UpdDate) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.UpdDate, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.UpdDate] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetPdfLineNum(this clsvzx_TagsEN objvzx_TagsEN, int? intPdfLineNum, string strComparisonOp="")
	{
objvzx_TagsEN.PdfLineNum = intPdfLineNum; //pdf行号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.PdfLineNum) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.PdfLineNum, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.PdfLineNum] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetPdfX(this clsvzx_TagsEN objvzx_TagsEN, string strPdfX, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfX, 50, convzx_Tags.PdfX);
}
objvzx_TagsEN.PdfX = strPdfX; //PdfX
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.PdfX) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.PdfX, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.PdfX] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetPdfY(this clsvzx_TagsEN objvzx_TagsEN, string strPdfY, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfY, 50, convzx_Tags.PdfY);
}
objvzx_TagsEN.PdfY = strPdfY; //PdfY
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.PdfY) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.PdfY, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.PdfY] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetMemo(this clsvzx_TagsEN objvzx_TagsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_Tags.Memo);
}
objvzx_TagsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.Memo) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.Memo, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.Memo] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetIdCurrEduCls(this clsvzx_TagsEN objvzx_TagsEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_Tags.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_Tags.IdCurrEduCls);
}
objvzx_TagsEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.IdCurrEduCls) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetTextId(this clsvzx_TagsEN objvzx_TagsEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_Tags.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_Tags.TextId);
}
objvzx_TagsEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.TextId) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.TextId, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.TextId] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetzxShareId(this clsvzx_TagsEN objvzx_TagsEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, convzx_Tags.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, convzx_Tags.zxShareId);
}
objvzx_TagsEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.zxShareId) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.zxShareId, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.zxShareId] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetPdfPageNumIn(this clsvzx_TagsEN objvzx_TagsEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, convzx_Tags.PdfPageNumIn);
}
objvzx_TagsEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.PdfPageNumIn) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.PdfPageNumIn, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.PdfPageNumIn] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetPdfPageTop(this clsvzx_TagsEN objvzx_TagsEN, int? intPdfPageTop, string strComparisonOp="")
	{
objvzx_TagsEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.PdfPageTop) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.PdfPageTop, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.PdfPageTop] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetPdfDivLet(this clsvzx_TagsEN objvzx_TagsEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, convzx_Tags.PdfDivLet);
}
objvzx_TagsEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.PdfDivLet) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.PdfDivLet, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.PdfDivLet] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetPdfDivTop(this clsvzx_TagsEN objvzx_TagsEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, convzx_Tags.PdfDivTop);
}
objvzx_TagsEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.PdfDivTop) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.PdfDivTop, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.PdfDivTop] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetPdfZoom(this clsvzx_TagsEN objvzx_TagsEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, convzx_Tags.PdfZoom);
}
objvzx_TagsEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.PdfZoom) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.PdfZoom, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.PdfZoom] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TagsEN SetzxTagsTypeId(this clsvzx_TagsEN objvzx_TagsEN, string strzxTagsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxTagsTypeId, 2, convzx_Tags.zxTagsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxTagsTypeId, 2, convzx_Tags.zxTagsTypeId);
}
objvzx_TagsEN.zxTagsTypeId = strzxTagsTypeId; //标注类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TagsEN.dicFldComparisonOp.ContainsKey(convzx_Tags.zxTagsTypeId) == false)
{
objvzx_TagsEN.dicFldComparisonOp.Add(convzx_Tags.zxTagsTypeId, strComparisonOp);
}
else
{
objvzx_TagsEN.dicFldComparisonOp[convzx_Tags.zxTagsTypeId] = strComparisonOp;
}
}
return objvzx_TagsEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_TagsENS">源对象</param>
 /// <param name = "objvzx_TagsENT">目标对象</param>
 public static void CopyTo(this clsvzx_TagsEN objvzx_TagsENS, clsvzx_TagsEN objvzx_TagsENT)
{
try
{
objvzx_TagsENT.TextTitle = objvzx_TagsENS.TextTitle; //TextTitle
objvzx_TagsENT.TextContent = objvzx_TagsENS.TextContent; //TextContent
objvzx_TagsENT.Author = objvzx_TagsENS.Author; //作者
objvzx_TagsENT.Keyword = objvzx_TagsENS.Keyword; //关键字
objvzx_TagsENT.zxTagsId = objvzx_TagsENS.zxTagsId; //标注Id
objvzx_TagsENT.TagsContent = objvzx_TagsENS.TagsContent; //标注内容
objvzx_TagsENT.PdfContent = objvzx_TagsENS.PdfContent; //Pdf内容
objvzx_TagsENT.PdfPageNum = objvzx_TagsENS.PdfPageNum; //Pdf页码
objvzx_TagsENT.VoteCount = objvzx_TagsENS.VoteCount; //点赞计数
objvzx_TagsENT.OrderNum = objvzx_TagsENS.OrderNum; //序号
objvzx_TagsENT.UpdUser = objvzx_TagsENS.UpdUser; //修改人
objvzx_TagsENT.UpdDate = objvzx_TagsENS.UpdDate; //修改日期
objvzx_TagsENT.PdfLineNum = objvzx_TagsENS.PdfLineNum; //pdf行号
objvzx_TagsENT.PdfX = objvzx_TagsENS.PdfX; //PdfX
objvzx_TagsENT.PdfY = objvzx_TagsENS.PdfY; //PdfY
objvzx_TagsENT.Memo = objvzx_TagsENS.Memo; //备注
objvzx_TagsENT.IdCurrEduCls = objvzx_TagsENS.IdCurrEduCls; //教学班流水号
objvzx_TagsENT.TextId = objvzx_TagsENS.TextId; //课件Id
objvzx_TagsENT.zxShareId = objvzx_TagsENS.zxShareId; //分享Id
objvzx_TagsENT.PdfPageNumIn = objvzx_TagsENS.PdfPageNumIn; //PdfPageNumIn
objvzx_TagsENT.PdfPageTop = objvzx_TagsENS.PdfPageTop; //pdf页面顶部位置
objvzx_TagsENT.PdfDivLet = objvzx_TagsENS.PdfDivLet; //PdfDivLet
objvzx_TagsENT.PdfDivTop = objvzx_TagsENS.PdfDivTop; //PdfDivTop
objvzx_TagsENT.PdfZoom = objvzx_TagsENS.PdfZoom; //PdfZoom
objvzx_TagsENT.zxTagsTypeId = objvzx_TagsENS.zxTagsTypeId; //标注类型ID
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
 /// <param name = "objvzx_TagsENS">源对象</param>
 /// <returns>目标对象=>clsvzx_TagsEN:objvzx_TagsENT</returns>
 public static clsvzx_TagsEN CopyTo(this clsvzx_TagsEN objvzx_TagsENS)
{
try
{
 clsvzx_TagsEN objvzx_TagsENT = new clsvzx_TagsEN()
{
TextTitle = objvzx_TagsENS.TextTitle, //TextTitle
TextContent = objvzx_TagsENS.TextContent, //TextContent
Author = objvzx_TagsENS.Author, //作者
Keyword = objvzx_TagsENS.Keyword, //关键字
zxTagsId = objvzx_TagsENS.zxTagsId, //标注Id
TagsContent = objvzx_TagsENS.TagsContent, //标注内容
PdfContent = objvzx_TagsENS.PdfContent, //Pdf内容
PdfPageNum = objvzx_TagsENS.PdfPageNum, //Pdf页码
VoteCount = objvzx_TagsENS.VoteCount, //点赞计数
OrderNum = objvzx_TagsENS.OrderNum, //序号
UpdUser = objvzx_TagsENS.UpdUser, //修改人
UpdDate = objvzx_TagsENS.UpdDate, //修改日期
PdfLineNum = objvzx_TagsENS.PdfLineNum, //pdf行号
PdfX = objvzx_TagsENS.PdfX, //PdfX
PdfY = objvzx_TagsENS.PdfY, //PdfY
Memo = objvzx_TagsENS.Memo, //备注
IdCurrEduCls = objvzx_TagsENS.IdCurrEduCls, //教学班流水号
TextId = objvzx_TagsENS.TextId, //课件Id
zxShareId = objvzx_TagsENS.zxShareId, //分享Id
PdfPageNumIn = objvzx_TagsENS.PdfPageNumIn, //PdfPageNumIn
PdfPageTop = objvzx_TagsENS.PdfPageTop, //pdf页面顶部位置
PdfDivLet = objvzx_TagsENS.PdfDivLet, //PdfDivLet
PdfDivTop = objvzx_TagsENS.PdfDivTop, //PdfDivTop
PdfZoom = objvzx_TagsENS.PdfZoom, //PdfZoom
zxTagsTypeId = objvzx_TagsENS.zxTagsTypeId, //标注类型ID
};
 return objvzx_TagsENT;
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
public static void CheckProperty4Condition(this clsvzx_TagsEN objvzx_TagsEN)
{
 clsvzx_TagsBL.vzx_TagsDA.CheckProperty4Condition(objvzx_TagsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_TagsEN objvzx_TagsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_TagsCond.IsUpdated(convzx_Tags.TextTitle) == true)
{
string strComparisonOpTextTitle = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.TextTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Tags.TextTitle, objvzx_TagsCond.TextTitle, strComparisonOpTextTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_TagsCond.IsUpdated(convzx_Tags.Author) == true)
{
string strComparisonOpAuthor = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Tags.Author, objvzx_TagsCond.Author, strComparisonOpAuthor);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.Keyword) == true)
{
string strComparisonOpKeyword = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Tags.Keyword, objvzx_TagsCond.Keyword, strComparisonOpKeyword);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.zxTagsId) == true)
{
string strComparisonOpzxTagsId = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.zxTagsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Tags.zxTagsId, objvzx_TagsCond.zxTagsId, strComparisonOpzxTagsId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_TagsCond.IsUpdated(convzx_Tags.PdfContent) == true)
{
string strComparisonOpPdfContent = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Tags.PdfContent, objvzx_TagsCond.PdfContent, strComparisonOpPdfContent);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Tags.PdfPageNum, objvzx_TagsCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.VoteCount) == true)
{
string strComparisonOpVoteCount = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Tags.VoteCount, objvzx_TagsCond.VoteCount, strComparisonOpVoteCount);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.OrderNum) == true)
{
string strComparisonOpOrderNum = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Tags.OrderNum, objvzx_TagsCond.OrderNum, strComparisonOpOrderNum);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Tags.UpdUser, objvzx_TagsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Tags.UpdDate, objvzx_TagsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.PdfLineNum) == true)
{
string strComparisonOpPdfLineNum = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.PdfLineNum];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Tags.PdfLineNum, objvzx_TagsCond.PdfLineNum, strComparisonOpPdfLineNum);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.PdfX) == true)
{
string strComparisonOpPdfX = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.PdfX];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Tags.PdfX, objvzx_TagsCond.PdfX, strComparisonOpPdfX);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.PdfY) == true)
{
string strComparisonOpPdfY = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.PdfY];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Tags.PdfY, objvzx_TagsCond.PdfY, strComparisonOpPdfY);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.Memo) == true)
{
string strComparisonOpMemo = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Tags.Memo, objvzx_TagsCond.Memo, strComparisonOpMemo);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Tags.IdCurrEduCls, objvzx_TagsCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.TextId) == true)
{
string strComparisonOpTextId = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Tags.TextId, objvzx_TagsCond.TextId, strComparisonOpTextId);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.zxShareId) == true)
{
string strComparisonOpzxShareId = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Tags.zxShareId, objvzx_TagsCond.zxShareId, strComparisonOpzxShareId);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Tags.PdfPageNumIn, objvzx_TagsCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Tags.PdfPageTop, objvzx_TagsCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Tags.PdfDivLet, objvzx_TagsCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Tags.PdfDivTop, objvzx_TagsCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Tags.PdfZoom, objvzx_TagsCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objvzx_TagsCond.IsUpdated(convzx_Tags.zxTagsTypeId) == true)
{
string strComparisonOpzxTagsTypeId = objvzx_TagsCond.dicFldComparisonOp[convzx_Tags.zxTagsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Tags.zxTagsTypeId, objvzx_TagsCond.zxTagsTypeId, strComparisonOpzxTagsTypeId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_Tags
{
public virtual bool UpdRelaTabDate(string strzxTagsId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_Tags(vzx_Tags)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_TagsBL
{
public static RelatedActions_vzx_Tags relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_TagsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_TagsDA vzx_TagsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_TagsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_TagsBL()
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
if (string.IsNullOrEmpty(clsvzx_TagsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_TagsEN._ConnectString);
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
public static DataTable GetDataTable_vzx_Tags(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_TagsDA.GetDataTable_vzx_Tags(strWhereCond);
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
objDT = vzx_TagsDA.GetDataTable(strWhereCond);
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
objDT = vzx_TagsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_TagsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_TagsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_TagsDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_TagsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_TagsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_TagsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxTagsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_TagsEN> GetObjLstByZxTagsIdLst(List<string> arrZxTagsIdLst)
{
List<clsvzx_TagsEN> arrObjLst = new List<clsvzx_TagsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxTagsIdLst, true);
 string strWhereCond = string.Format("zxTagsId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TagsEN objvzx_TagsEN = new clsvzx_TagsEN();
try
{
objvzx_TagsEN.TextTitle = objRow[convzx_Tags.TextTitle] == DBNull.Value ? null : objRow[convzx_Tags.TextTitle].ToString().Trim(); //TextTitle
objvzx_TagsEN.TextContent = objRow[convzx_Tags.TextContent] == DBNull.Value ? null : objRow[convzx_Tags.TextContent].ToString().Trim(); //TextContent
objvzx_TagsEN.Author = objRow[convzx_Tags.Author] == DBNull.Value ? null : objRow[convzx_Tags.Author].ToString().Trim(); //作者
objvzx_TagsEN.Keyword = objRow[convzx_Tags.Keyword] == DBNull.Value ? null : objRow[convzx_Tags.Keyword].ToString().Trim(); //关键字
objvzx_TagsEN.zxTagsId = objRow[convzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objvzx_TagsEN.TagsContent = objRow[convzx_Tags.TagsContent] == DBNull.Value ? null : objRow[convzx_Tags.TagsContent].ToString().Trim(); //标注内容
objvzx_TagsEN.PdfContent = objRow[convzx_Tags.PdfContent] == DBNull.Value ? null : objRow[convzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TagsEN.PdfPageNum = objRow[convzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TagsEN.VoteCount = objRow[convzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objvzx_TagsEN.OrderNum = objRow[convzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.OrderNum].ToString().Trim()); //序号
objvzx_TagsEN.UpdUser = objRow[convzx_Tags.UpdUser] == DBNull.Value ? null : objRow[convzx_Tags.UpdUser].ToString().Trim(); //修改人
objvzx_TagsEN.UpdDate = objRow[convzx_Tags.UpdDate] == DBNull.Value ? null : objRow[convzx_Tags.UpdDate].ToString().Trim(); //修改日期
objvzx_TagsEN.PdfLineNum = objRow[convzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvzx_TagsEN.PdfX = objRow[convzx_Tags.PdfX] == DBNull.Value ? null : objRow[convzx_Tags.PdfX].ToString().Trim(); //PdfX
objvzx_TagsEN.PdfY = objRow[convzx_Tags.PdfY] == DBNull.Value ? null : objRow[convzx_Tags.PdfY].ToString().Trim(); //PdfY
objvzx_TagsEN.Memo = objRow[convzx_Tags.Memo] == DBNull.Value ? null : objRow[convzx_Tags.Memo].ToString().Trim(); //备注
objvzx_TagsEN.IdCurrEduCls = objRow[convzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TagsEN.TextId = objRow[convzx_Tags.TextId] == DBNull.Value ? null : objRow[convzx_Tags.TextId].ToString().Trim(); //课件Id
objvzx_TagsEN.zxShareId = objRow[convzx_Tags.zxShareId] == DBNull.Value ? null : objRow[convzx_Tags.zxShareId].ToString().Trim(); //分享Id
objvzx_TagsEN.PdfPageNumIn = objRow[convzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TagsEN.PdfPageTop = objRow[convzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TagsEN.PdfDivLet = objRow[convzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TagsEN.PdfDivTop = objRow[convzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TagsEN.PdfZoom = objRow[convzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[convzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TagsEN.zxTagsTypeId = objRow[convzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[convzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TagsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxTagsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_TagsEN> GetObjLstByZxTagsIdLstCache(List<string> arrZxTagsIdLst)
{
string strKey = string.Format("{0}", clsvzx_TagsEN._CurrTabName);
List<clsvzx_TagsEN> arrvzx_TagsObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_TagsEN> arrvzx_TagsObjLst_Sel =
arrvzx_TagsObjLstCache
.Where(x => arrZxTagsIdLst.Contains(x.zxTagsId));
return arrvzx_TagsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TagsEN> GetObjLst(string strWhereCond)
{
List<clsvzx_TagsEN> arrObjLst = new List<clsvzx_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TagsEN objvzx_TagsEN = new clsvzx_TagsEN();
try
{
objvzx_TagsEN.TextTitle = objRow[convzx_Tags.TextTitle] == DBNull.Value ? null : objRow[convzx_Tags.TextTitle].ToString().Trim(); //TextTitle
objvzx_TagsEN.TextContent = objRow[convzx_Tags.TextContent] == DBNull.Value ? null : objRow[convzx_Tags.TextContent].ToString().Trim(); //TextContent
objvzx_TagsEN.Author = objRow[convzx_Tags.Author] == DBNull.Value ? null : objRow[convzx_Tags.Author].ToString().Trim(); //作者
objvzx_TagsEN.Keyword = objRow[convzx_Tags.Keyword] == DBNull.Value ? null : objRow[convzx_Tags.Keyword].ToString().Trim(); //关键字
objvzx_TagsEN.zxTagsId = objRow[convzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objvzx_TagsEN.TagsContent = objRow[convzx_Tags.TagsContent] == DBNull.Value ? null : objRow[convzx_Tags.TagsContent].ToString().Trim(); //标注内容
objvzx_TagsEN.PdfContent = objRow[convzx_Tags.PdfContent] == DBNull.Value ? null : objRow[convzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TagsEN.PdfPageNum = objRow[convzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TagsEN.VoteCount = objRow[convzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objvzx_TagsEN.OrderNum = objRow[convzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.OrderNum].ToString().Trim()); //序号
objvzx_TagsEN.UpdUser = objRow[convzx_Tags.UpdUser] == DBNull.Value ? null : objRow[convzx_Tags.UpdUser].ToString().Trim(); //修改人
objvzx_TagsEN.UpdDate = objRow[convzx_Tags.UpdDate] == DBNull.Value ? null : objRow[convzx_Tags.UpdDate].ToString().Trim(); //修改日期
objvzx_TagsEN.PdfLineNum = objRow[convzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvzx_TagsEN.PdfX = objRow[convzx_Tags.PdfX] == DBNull.Value ? null : objRow[convzx_Tags.PdfX].ToString().Trim(); //PdfX
objvzx_TagsEN.PdfY = objRow[convzx_Tags.PdfY] == DBNull.Value ? null : objRow[convzx_Tags.PdfY].ToString().Trim(); //PdfY
objvzx_TagsEN.Memo = objRow[convzx_Tags.Memo] == DBNull.Value ? null : objRow[convzx_Tags.Memo].ToString().Trim(); //备注
objvzx_TagsEN.IdCurrEduCls = objRow[convzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TagsEN.TextId = objRow[convzx_Tags.TextId] == DBNull.Value ? null : objRow[convzx_Tags.TextId].ToString().Trim(); //课件Id
objvzx_TagsEN.zxShareId = objRow[convzx_Tags.zxShareId] == DBNull.Value ? null : objRow[convzx_Tags.zxShareId].ToString().Trim(); //分享Id
objvzx_TagsEN.PdfPageNumIn = objRow[convzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TagsEN.PdfPageTop = objRow[convzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TagsEN.PdfDivLet = objRow[convzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TagsEN.PdfDivTop = objRow[convzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TagsEN.PdfZoom = objRow[convzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[convzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TagsEN.zxTagsTypeId = objRow[convzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[convzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TagsEN);
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
public static List<clsvzx_TagsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_TagsEN> arrObjLst = new List<clsvzx_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TagsEN objvzx_TagsEN = new clsvzx_TagsEN();
try
{
objvzx_TagsEN.TextTitle = objRow[convzx_Tags.TextTitle] == DBNull.Value ? null : objRow[convzx_Tags.TextTitle].ToString().Trim(); //TextTitle
objvzx_TagsEN.TextContent = objRow[convzx_Tags.TextContent] == DBNull.Value ? null : objRow[convzx_Tags.TextContent].ToString().Trim(); //TextContent
objvzx_TagsEN.Author = objRow[convzx_Tags.Author] == DBNull.Value ? null : objRow[convzx_Tags.Author].ToString().Trim(); //作者
objvzx_TagsEN.Keyword = objRow[convzx_Tags.Keyword] == DBNull.Value ? null : objRow[convzx_Tags.Keyword].ToString().Trim(); //关键字
objvzx_TagsEN.zxTagsId = objRow[convzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objvzx_TagsEN.TagsContent = objRow[convzx_Tags.TagsContent] == DBNull.Value ? null : objRow[convzx_Tags.TagsContent].ToString().Trim(); //标注内容
objvzx_TagsEN.PdfContent = objRow[convzx_Tags.PdfContent] == DBNull.Value ? null : objRow[convzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TagsEN.PdfPageNum = objRow[convzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TagsEN.VoteCount = objRow[convzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objvzx_TagsEN.OrderNum = objRow[convzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.OrderNum].ToString().Trim()); //序号
objvzx_TagsEN.UpdUser = objRow[convzx_Tags.UpdUser] == DBNull.Value ? null : objRow[convzx_Tags.UpdUser].ToString().Trim(); //修改人
objvzx_TagsEN.UpdDate = objRow[convzx_Tags.UpdDate] == DBNull.Value ? null : objRow[convzx_Tags.UpdDate].ToString().Trim(); //修改日期
objvzx_TagsEN.PdfLineNum = objRow[convzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvzx_TagsEN.PdfX = objRow[convzx_Tags.PdfX] == DBNull.Value ? null : objRow[convzx_Tags.PdfX].ToString().Trim(); //PdfX
objvzx_TagsEN.PdfY = objRow[convzx_Tags.PdfY] == DBNull.Value ? null : objRow[convzx_Tags.PdfY].ToString().Trim(); //PdfY
objvzx_TagsEN.Memo = objRow[convzx_Tags.Memo] == DBNull.Value ? null : objRow[convzx_Tags.Memo].ToString().Trim(); //备注
objvzx_TagsEN.IdCurrEduCls = objRow[convzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TagsEN.TextId = objRow[convzx_Tags.TextId] == DBNull.Value ? null : objRow[convzx_Tags.TextId].ToString().Trim(); //课件Id
objvzx_TagsEN.zxShareId = objRow[convzx_Tags.zxShareId] == DBNull.Value ? null : objRow[convzx_Tags.zxShareId].ToString().Trim(); //分享Id
objvzx_TagsEN.PdfPageNumIn = objRow[convzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TagsEN.PdfPageTop = objRow[convzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TagsEN.PdfDivLet = objRow[convzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TagsEN.PdfDivTop = objRow[convzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TagsEN.PdfZoom = objRow[convzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[convzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TagsEN.zxTagsTypeId = objRow[convzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[convzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TagsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_TagsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_TagsEN> GetSubObjLstCache(clsvzx_TagsEN objvzx_TagsCond)
{
List<clsvzx_TagsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_TagsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_Tags.AttributeName)
{
if (objvzx_TagsCond.IsUpdated(strFldName) == false) continue;
if (objvzx_TagsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TagsCond[strFldName].ToString());
}
else
{
if (objvzx_TagsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_TagsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TagsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_TagsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_TagsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_TagsCond[strFldName]));
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
public static List<clsvzx_TagsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_TagsEN> arrObjLst = new List<clsvzx_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TagsEN objvzx_TagsEN = new clsvzx_TagsEN();
try
{
objvzx_TagsEN.TextTitle = objRow[convzx_Tags.TextTitle] == DBNull.Value ? null : objRow[convzx_Tags.TextTitle].ToString().Trim(); //TextTitle
objvzx_TagsEN.TextContent = objRow[convzx_Tags.TextContent] == DBNull.Value ? null : objRow[convzx_Tags.TextContent].ToString().Trim(); //TextContent
objvzx_TagsEN.Author = objRow[convzx_Tags.Author] == DBNull.Value ? null : objRow[convzx_Tags.Author].ToString().Trim(); //作者
objvzx_TagsEN.Keyword = objRow[convzx_Tags.Keyword] == DBNull.Value ? null : objRow[convzx_Tags.Keyword].ToString().Trim(); //关键字
objvzx_TagsEN.zxTagsId = objRow[convzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objvzx_TagsEN.TagsContent = objRow[convzx_Tags.TagsContent] == DBNull.Value ? null : objRow[convzx_Tags.TagsContent].ToString().Trim(); //标注内容
objvzx_TagsEN.PdfContent = objRow[convzx_Tags.PdfContent] == DBNull.Value ? null : objRow[convzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TagsEN.PdfPageNum = objRow[convzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TagsEN.VoteCount = objRow[convzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objvzx_TagsEN.OrderNum = objRow[convzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.OrderNum].ToString().Trim()); //序号
objvzx_TagsEN.UpdUser = objRow[convzx_Tags.UpdUser] == DBNull.Value ? null : objRow[convzx_Tags.UpdUser].ToString().Trim(); //修改人
objvzx_TagsEN.UpdDate = objRow[convzx_Tags.UpdDate] == DBNull.Value ? null : objRow[convzx_Tags.UpdDate].ToString().Trim(); //修改日期
objvzx_TagsEN.PdfLineNum = objRow[convzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvzx_TagsEN.PdfX = objRow[convzx_Tags.PdfX] == DBNull.Value ? null : objRow[convzx_Tags.PdfX].ToString().Trim(); //PdfX
objvzx_TagsEN.PdfY = objRow[convzx_Tags.PdfY] == DBNull.Value ? null : objRow[convzx_Tags.PdfY].ToString().Trim(); //PdfY
objvzx_TagsEN.Memo = objRow[convzx_Tags.Memo] == DBNull.Value ? null : objRow[convzx_Tags.Memo].ToString().Trim(); //备注
objvzx_TagsEN.IdCurrEduCls = objRow[convzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TagsEN.TextId = objRow[convzx_Tags.TextId] == DBNull.Value ? null : objRow[convzx_Tags.TextId].ToString().Trim(); //课件Id
objvzx_TagsEN.zxShareId = objRow[convzx_Tags.zxShareId] == DBNull.Value ? null : objRow[convzx_Tags.zxShareId].ToString().Trim(); //分享Id
objvzx_TagsEN.PdfPageNumIn = objRow[convzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TagsEN.PdfPageTop = objRow[convzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TagsEN.PdfDivLet = objRow[convzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TagsEN.PdfDivTop = objRow[convzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TagsEN.PdfZoom = objRow[convzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[convzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TagsEN.zxTagsTypeId = objRow[convzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[convzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TagsEN);
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
public static List<clsvzx_TagsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_TagsEN> arrObjLst = new List<clsvzx_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TagsEN objvzx_TagsEN = new clsvzx_TagsEN();
try
{
objvzx_TagsEN.TextTitle = objRow[convzx_Tags.TextTitle] == DBNull.Value ? null : objRow[convzx_Tags.TextTitle].ToString().Trim(); //TextTitle
objvzx_TagsEN.TextContent = objRow[convzx_Tags.TextContent] == DBNull.Value ? null : objRow[convzx_Tags.TextContent].ToString().Trim(); //TextContent
objvzx_TagsEN.Author = objRow[convzx_Tags.Author] == DBNull.Value ? null : objRow[convzx_Tags.Author].ToString().Trim(); //作者
objvzx_TagsEN.Keyword = objRow[convzx_Tags.Keyword] == DBNull.Value ? null : objRow[convzx_Tags.Keyword].ToString().Trim(); //关键字
objvzx_TagsEN.zxTagsId = objRow[convzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objvzx_TagsEN.TagsContent = objRow[convzx_Tags.TagsContent] == DBNull.Value ? null : objRow[convzx_Tags.TagsContent].ToString().Trim(); //标注内容
objvzx_TagsEN.PdfContent = objRow[convzx_Tags.PdfContent] == DBNull.Value ? null : objRow[convzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TagsEN.PdfPageNum = objRow[convzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TagsEN.VoteCount = objRow[convzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objvzx_TagsEN.OrderNum = objRow[convzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.OrderNum].ToString().Trim()); //序号
objvzx_TagsEN.UpdUser = objRow[convzx_Tags.UpdUser] == DBNull.Value ? null : objRow[convzx_Tags.UpdUser].ToString().Trim(); //修改人
objvzx_TagsEN.UpdDate = objRow[convzx_Tags.UpdDate] == DBNull.Value ? null : objRow[convzx_Tags.UpdDate].ToString().Trim(); //修改日期
objvzx_TagsEN.PdfLineNum = objRow[convzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvzx_TagsEN.PdfX = objRow[convzx_Tags.PdfX] == DBNull.Value ? null : objRow[convzx_Tags.PdfX].ToString().Trim(); //PdfX
objvzx_TagsEN.PdfY = objRow[convzx_Tags.PdfY] == DBNull.Value ? null : objRow[convzx_Tags.PdfY].ToString().Trim(); //PdfY
objvzx_TagsEN.Memo = objRow[convzx_Tags.Memo] == DBNull.Value ? null : objRow[convzx_Tags.Memo].ToString().Trim(); //备注
objvzx_TagsEN.IdCurrEduCls = objRow[convzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TagsEN.TextId = objRow[convzx_Tags.TextId] == DBNull.Value ? null : objRow[convzx_Tags.TextId].ToString().Trim(); //课件Id
objvzx_TagsEN.zxShareId = objRow[convzx_Tags.zxShareId] == DBNull.Value ? null : objRow[convzx_Tags.zxShareId].ToString().Trim(); //分享Id
objvzx_TagsEN.PdfPageNumIn = objRow[convzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TagsEN.PdfPageTop = objRow[convzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TagsEN.PdfDivLet = objRow[convzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TagsEN.PdfDivTop = objRow[convzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TagsEN.PdfZoom = objRow[convzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[convzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TagsEN.zxTagsTypeId = objRow[convzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[convzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TagsEN);
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
List<clsvzx_TagsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_TagsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TagsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_TagsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_TagsEN> arrObjLst = new List<clsvzx_TagsEN>(); 
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
	clsvzx_TagsEN objvzx_TagsEN = new clsvzx_TagsEN();
try
{
objvzx_TagsEN.TextTitle = objRow[convzx_Tags.TextTitle] == DBNull.Value ? null : objRow[convzx_Tags.TextTitle].ToString().Trim(); //TextTitle
objvzx_TagsEN.TextContent = objRow[convzx_Tags.TextContent] == DBNull.Value ? null : objRow[convzx_Tags.TextContent].ToString().Trim(); //TextContent
objvzx_TagsEN.Author = objRow[convzx_Tags.Author] == DBNull.Value ? null : objRow[convzx_Tags.Author].ToString().Trim(); //作者
objvzx_TagsEN.Keyword = objRow[convzx_Tags.Keyword] == DBNull.Value ? null : objRow[convzx_Tags.Keyword].ToString().Trim(); //关键字
objvzx_TagsEN.zxTagsId = objRow[convzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objvzx_TagsEN.TagsContent = objRow[convzx_Tags.TagsContent] == DBNull.Value ? null : objRow[convzx_Tags.TagsContent].ToString().Trim(); //标注内容
objvzx_TagsEN.PdfContent = objRow[convzx_Tags.PdfContent] == DBNull.Value ? null : objRow[convzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TagsEN.PdfPageNum = objRow[convzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TagsEN.VoteCount = objRow[convzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objvzx_TagsEN.OrderNum = objRow[convzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.OrderNum].ToString().Trim()); //序号
objvzx_TagsEN.UpdUser = objRow[convzx_Tags.UpdUser] == DBNull.Value ? null : objRow[convzx_Tags.UpdUser].ToString().Trim(); //修改人
objvzx_TagsEN.UpdDate = objRow[convzx_Tags.UpdDate] == DBNull.Value ? null : objRow[convzx_Tags.UpdDate].ToString().Trim(); //修改日期
objvzx_TagsEN.PdfLineNum = objRow[convzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvzx_TagsEN.PdfX = objRow[convzx_Tags.PdfX] == DBNull.Value ? null : objRow[convzx_Tags.PdfX].ToString().Trim(); //PdfX
objvzx_TagsEN.PdfY = objRow[convzx_Tags.PdfY] == DBNull.Value ? null : objRow[convzx_Tags.PdfY].ToString().Trim(); //PdfY
objvzx_TagsEN.Memo = objRow[convzx_Tags.Memo] == DBNull.Value ? null : objRow[convzx_Tags.Memo].ToString().Trim(); //备注
objvzx_TagsEN.IdCurrEduCls = objRow[convzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TagsEN.TextId = objRow[convzx_Tags.TextId] == DBNull.Value ? null : objRow[convzx_Tags.TextId].ToString().Trim(); //课件Id
objvzx_TagsEN.zxShareId = objRow[convzx_Tags.zxShareId] == DBNull.Value ? null : objRow[convzx_Tags.zxShareId].ToString().Trim(); //分享Id
objvzx_TagsEN.PdfPageNumIn = objRow[convzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TagsEN.PdfPageTop = objRow[convzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TagsEN.PdfDivLet = objRow[convzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TagsEN.PdfDivTop = objRow[convzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TagsEN.PdfZoom = objRow[convzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[convzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TagsEN.zxTagsTypeId = objRow[convzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[convzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TagsEN);
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
public static List<clsvzx_TagsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_TagsEN> arrObjLst = new List<clsvzx_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TagsEN objvzx_TagsEN = new clsvzx_TagsEN();
try
{
objvzx_TagsEN.TextTitle = objRow[convzx_Tags.TextTitle] == DBNull.Value ? null : objRow[convzx_Tags.TextTitle].ToString().Trim(); //TextTitle
objvzx_TagsEN.TextContent = objRow[convzx_Tags.TextContent] == DBNull.Value ? null : objRow[convzx_Tags.TextContent].ToString().Trim(); //TextContent
objvzx_TagsEN.Author = objRow[convzx_Tags.Author] == DBNull.Value ? null : objRow[convzx_Tags.Author].ToString().Trim(); //作者
objvzx_TagsEN.Keyword = objRow[convzx_Tags.Keyword] == DBNull.Value ? null : objRow[convzx_Tags.Keyword].ToString().Trim(); //关键字
objvzx_TagsEN.zxTagsId = objRow[convzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objvzx_TagsEN.TagsContent = objRow[convzx_Tags.TagsContent] == DBNull.Value ? null : objRow[convzx_Tags.TagsContent].ToString().Trim(); //标注内容
objvzx_TagsEN.PdfContent = objRow[convzx_Tags.PdfContent] == DBNull.Value ? null : objRow[convzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TagsEN.PdfPageNum = objRow[convzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TagsEN.VoteCount = objRow[convzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objvzx_TagsEN.OrderNum = objRow[convzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.OrderNum].ToString().Trim()); //序号
objvzx_TagsEN.UpdUser = objRow[convzx_Tags.UpdUser] == DBNull.Value ? null : objRow[convzx_Tags.UpdUser].ToString().Trim(); //修改人
objvzx_TagsEN.UpdDate = objRow[convzx_Tags.UpdDate] == DBNull.Value ? null : objRow[convzx_Tags.UpdDate].ToString().Trim(); //修改日期
objvzx_TagsEN.PdfLineNum = objRow[convzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvzx_TagsEN.PdfX = objRow[convzx_Tags.PdfX] == DBNull.Value ? null : objRow[convzx_Tags.PdfX].ToString().Trim(); //PdfX
objvzx_TagsEN.PdfY = objRow[convzx_Tags.PdfY] == DBNull.Value ? null : objRow[convzx_Tags.PdfY].ToString().Trim(); //PdfY
objvzx_TagsEN.Memo = objRow[convzx_Tags.Memo] == DBNull.Value ? null : objRow[convzx_Tags.Memo].ToString().Trim(); //备注
objvzx_TagsEN.IdCurrEduCls = objRow[convzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TagsEN.TextId = objRow[convzx_Tags.TextId] == DBNull.Value ? null : objRow[convzx_Tags.TextId].ToString().Trim(); //课件Id
objvzx_TagsEN.zxShareId = objRow[convzx_Tags.zxShareId] == DBNull.Value ? null : objRow[convzx_Tags.zxShareId].ToString().Trim(); //分享Id
objvzx_TagsEN.PdfPageNumIn = objRow[convzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TagsEN.PdfPageTop = objRow[convzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TagsEN.PdfDivLet = objRow[convzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TagsEN.PdfDivTop = objRow[convzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TagsEN.PdfZoom = objRow[convzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[convzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TagsEN.zxTagsTypeId = objRow[convzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[convzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TagsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_TagsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_TagsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_TagsEN> arrObjLst = new List<clsvzx_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TagsEN objvzx_TagsEN = new clsvzx_TagsEN();
try
{
objvzx_TagsEN.TextTitle = objRow[convzx_Tags.TextTitle] == DBNull.Value ? null : objRow[convzx_Tags.TextTitle].ToString().Trim(); //TextTitle
objvzx_TagsEN.TextContent = objRow[convzx_Tags.TextContent] == DBNull.Value ? null : objRow[convzx_Tags.TextContent].ToString().Trim(); //TextContent
objvzx_TagsEN.Author = objRow[convzx_Tags.Author] == DBNull.Value ? null : objRow[convzx_Tags.Author].ToString().Trim(); //作者
objvzx_TagsEN.Keyword = objRow[convzx_Tags.Keyword] == DBNull.Value ? null : objRow[convzx_Tags.Keyword].ToString().Trim(); //关键字
objvzx_TagsEN.zxTagsId = objRow[convzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objvzx_TagsEN.TagsContent = objRow[convzx_Tags.TagsContent] == DBNull.Value ? null : objRow[convzx_Tags.TagsContent].ToString().Trim(); //标注内容
objvzx_TagsEN.PdfContent = objRow[convzx_Tags.PdfContent] == DBNull.Value ? null : objRow[convzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TagsEN.PdfPageNum = objRow[convzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TagsEN.VoteCount = objRow[convzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objvzx_TagsEN.OrderNum = objRow[convzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.OrderNum].ToString().Trim()); //序号
objvzx_TagsEN.UpdUser = objRow[convzx_Tags.UpdUser] == DBNull.Value ? null : objRow[convzx_Tags.UpdUser].ToString().Trim(); //修改人
objvzx_TagsEN.UpdDate = objRow[convzx_Tags.UpdDate] == DBNull.Value ? null : objRow[convzx_Tags.UpdDate].ToString().Trim(); //修改日期
objvzx_TagsEN.PdfLineNum = objRow[convzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvzx_TagsEN.PdfX = objRow[convzx_Tags.PdfX] == DBNull.Value ? null : objRow[convzx_Tags.PdfX].ToString().Trim(); //PdfX
objvzx_TagsEN.PdfY = objRow[convzx_Tags.PdfY] == DBNull.Value ? null : objRow[convzx_Tags.PdfY].ToString().Trim(); //PdfY
objvzx_TagsEN.Memo = objRow[convzx_Tags.Memo] == DBNull.Value ? null : objRow[convzx_Tags.Memo].ToString().Trim(); //备注
objvzx_TagsEN.IdCurrEduCls = objRow[convzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TagsEN.TextId = objRow[convzx_Tags.TextId] == DBNull.Value ? null : objRow[convzx_Tags.TextId].ToString().Trim(); //课件Id
objvzx_TagsEN.zxShareId = objRow[convzx_Tags.zxShareId] == DBNull.Value ? null : objRow[convzx_Tags.zxShareId].ToString().Trim(); //分享Id
objvzx_TagsEN.PdfPageNumIn = objRow[convzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TagsEN.PdfPageTop = objRow[convzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TagsEN.PdfDivLet = objRow[convzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TagsEN.PdfDivTop = objRow[convzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TagsEN.PdfZoom = objRow[convzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[convzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TagsEN.zxTagsTypeId = objRow[convzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[convzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TagsEN);
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
public static List<clsvzx_TagsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_TagsEN> arrObjLst = new List<clsvzx_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TagsEN objvzx_TagsEN = new clsvzx_TagsEN();
try
{
objvzx_TagsEN.TextTitle = objRow[convzx_Tags.TextTitle] == DBNull.Value ? null : objRow[convzx_Tags.TextTitle].ToString().Trim(); //TextTitle
objvzx_TagsEN.TextContent = objRow[convzx_Tags.TextContent] == DBNull.Value ? null : objRow[convzx_Tags.TextContent].ToString().Trim(); //TextContent
objvzx_TagsEN.Author = objRow[convzx_Tags.Author] == DBNull.Value ? null : objRow[convzx_Tags.Author].ToString().Trim(); //作者
objvzx_TagsEN.Keyword = objRow[convzx_Tags.Keyword] == DBNull.Value ? null : objRow[convzx_Tags.Keyword].ToString().Trim(); //关键字
objvzx_TagsEN.zxTagsId = objRow[convzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objvzx_TagsEN.TagsContent = objRow[convzx_Tags.TagsContent] == DBNull.Value ? null : objRow[convzx_Tags.TagsContent].ToString().Trim(); //标注内容
objvzx_TagsEN.PdfContent = objRow[convzx_Tags.PdfContent] == DBNull.Value ? null : objRow[convzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TagsEN.PdfPageNum = objRow[convzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TagsEN.VoteCount = objRow[convzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objvzx_TagsEN.OrderNum = objRow[convzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.OrderNum].ToString().Trim()); //序号
objvzx_TagsEN.UpdUser = objRow[convzx_Tags.UpdUser] == DBNull.Value ? null : objRow[convzx_Tags.UpdUser].ToString().Trim(); //修改人
objvzx_TagsEN.UpdDate = objRow[convzx_Tags.UpdDate] == DBNull.Value ? null : objRow[convzx_Tags.UpdDate].ToString().Trim(); //修改日期
objvzx_TagsEN.PdfLineNum = objRow[convzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvzx_TagsEN.PdfX = objRow[convzx_Tags.PdfX] == DBNull.Value ? null : objRow[convzx_Tags.PdfX].ToString().Trim(); //PdfX
objvzx_TagsEN.PdfY = objRow[convzx_Tags.PdfY] == DBNull.Value ? null : objRow[convzx_Tags.PdfY].ToString().Trim(); //PdfY
objvzx_TagsEN.Memo = objRow[convzx_Tags.Memo] == DBNull.Value ? null : objRow[convzx_Tags.Memo].ToString().Trim(); //备注
objvzx_TagsEN.IdCurrEduCls = objRow[convzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TagsEN.TextId = objRow[convzx_Tags.TextId] == DBNull.Value ? null : objRow[convzx_Tags.TextId].ToString().Trim(); //课件Id
objvzx_TagsEN.zxShareId = objRow[convzx_Tags.zxShareId] == DBNull.Value ? null : objRow[convzx_Tags.zxShareId].ToString().Trim(); //分享Id
objvzx_TagsEN.PdfPageNumIn = objRow[convzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TagsEN.PdfPageTop = objRow[convzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TagsEN.PdfDivLet = objRow[convzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TagsEN.PdfDivTop = objRow[convzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TagsEN.PdfZoom = objRow[convzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[convzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TagsEN.zxTagsTypeId = objRow[convzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[convzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TagsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TagsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_TagsEN> arrObjLst = new List<clsvzx_TagsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TagsEN objvzx_TagsEN = new clsvzx_TagsEN();
try
{
objvzx_TagsEN.TextTitle = objRow[convzx_Tags.TextTitle] == DBNull.Value ? null : objRow[convzx_Tags.TextTitle].ToString().Trim(); //TextTitle
objvzx_TagsEN.TextContent = objRow[convzx_Tags.TextContent] == DBNull.Value ? null : objRow[convzx_Tags.TextContent].ToString().Trim(); //TextContent
objvzx_TagsEN.Author = objRow[convzx_Tags.Author] == DBNull.Value ? null : objRow[convzx_Tags.Author].ToString().Trim(); //作者
objvzx_TagsEN.Keyword = objRow[convzx_Tags.Keyword] == DBNull.Value ? null : objRow[convzx_Tags.Keyword].ToString().Trim(); //关键字
objvzx_TagsEN.zxTagsId = objRow[convzx_Tags.zxTagsId].ToString().Trim(); //标注Id
objvzx_TagsEN.TagsContent = objRow[convzx_Tags.TagsContent] == DBNull.Value ? null : objRow[convzx_Tags.TagsContent].ToString().Trim(); //标注内容
objvzx_TagsEN.PdfContent = objRow[convzx_Tags.PdfContent] == DBNull.Value ? null : objRow[convzx_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TagsEN.PdfPageNum = objRow[convzx_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TagsEN.VoteCount = objRow[convzx_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.VoteCount].ToString().Trim()); //点赞计数
objvzx_TagsEN.OrderNum = objRow[convzx_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.OrderNum].ToString().Trim()); //序号
objvzx_TagsEN.UpdUser = objRow[convzx_Tags.UpdUser] == DBNull.Value ? null : objRow[convzx_Tags.UpdUser].ToString().Trim(); //修改人
objvzx_TagsEN.UpdDate = objRow[convzx_Tags.UpdDate] == DBNull.Value ? null : objRow[convzx_Tags.UpdDate].ToString().Trim(); //修改日期
objvzx_TagsEN.PdfLineNum = objRow[convzx_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvzx_TagsEN.PdfX = objRow[convzx_Tags.PdfX] == DBNull.Value ? null : objRow[convzx_Tags.PdfX].ToString().Trim(); //PdfX
objvzx_TagsEN.PdfY = objRow[convzx_Tags.PdfY] == DBNull.Value ? null : objRow[convzx_Tags.PdfY].ToString().Trim(); //PdfY
objvzx_TagsEN.Memo = objRow[convzx_Tags.Memo] == DBNull.Value ? null : objRow[convzx_Tags.Memo].ToString().Trim(); //备注
objvzx_TagsEN.IdCurrEduCls = objRow[convzx_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TagsEN.TextId = objRow[convzx_Tags.TextId] == DBNull.Value ? null : objRow[convzx_Tags.TextId].ToString().Trim(); //课件Id
objvzx_TagsEN.zxShareId = objRow[convzx_Tags.zxShareId] == DBNull.Value ? null : objRow[convzx_Tags.zxShareId].ToString().Trim(); //分享Id
objvzx_TagsEN.PdfPageNumIn = objRow[convzx_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TagsEN.PdfPageTop = objRow[convzx_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TagsEN.PdfDivLet = objRow[convzx_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TagsEN.PdfDivTop = objRow[convzx_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TagsEN.PdfZoom = objRow[convzx_Tags.PdfZoom] == DBNull.Value ? null : objRow[convzx_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TagsEN.zxTagsTypeId = objRow[convzx_Tags.zxTagsTypeId] == DBNull.Value ? null : objRow[convzx_Tags.zxTagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TagsEN.zxTagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TagsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_TagsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_Tags(ref clsvzx_TagsEN objvzx_TagsEN)
{
bool bolResult = vzx_TagsDA.Getvzx_Tags(ref objvzx_TagsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxTagsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_TagsEN GetObjByzxTagsId(string strzxTagsId)
{
if (strzxTagsId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxTagsId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxTagsId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxTagsId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_TagsEN objvzx_TagsEN = vzx_TagsDA.GetObjByzxTagsId(strzxTagsId);
return objvzx_TagsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_TagsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_TagsEN objvzx_TagsEN = vzx_TagsDA.GetFirstObj(strWhereCond);
 return objvzx_TagsEN;
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
public static clsvzx_TagsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_TagsEN objvzx_TagsEN = vzx_TagsDA.GetObjByDataRow(objRow);
 return objvzx_TagsEN;
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
public static clsvzx_TagsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_TagsEN objvzx_TagsEN = vzx_TagsDA.GetObjByDataRow(objRow);
 return objvzx_TagsEN;
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
 /// <param name = "strzxTagsId">所给的关键字</param>
 /// <param name = "lstvzx_TagsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_TagsEN GetObjByzxTagsIdFromList(string strzxTagsId, List<clsvzx_TagsEN> lstvzx_TagsObjLst)
{
foreach (clsvzx_TagsEN objvzx_TagsEN in lstvzx_TagsObjLst)
{
if (objvzx_TagsEN.zxTagsId == strzxTagsId)
{
return objvzx_TagsEN;
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
 string strMaxZxTagsId;
 try
 {
 strMaxZxTagsId = clsvzx_TagsDA.GetMaxStrId();
 return strMaxZxTagsId;
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
 string strzxTagsId;
 try
 {
 strzxTagsId = new clsvzx_TagsDA().GetFirstID(strWhereCond);
 return strzxTagsId;
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
 arrList = vzx_TagsDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_TagsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxTagsId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxTagsId)
{
if (string.IsNullOrEmpty(strzxTagsId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxTagsId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_TagsDA.IsExist(strzxTagsId);
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
 bolIsExist = clsvzx_TagsDA.IsExistTable();
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
 bolIsExist = vzx_TagsDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_TagsENS">源对象</param>
 /// <param name = "objvzx_TagsENT">目标对象</param>
 public static void CopyTo(clsvzx_TagsEN objvzx_TagsENS, clsvzx_TagsEN objvzx_TagsENT)
{
try
{
objvzx_TagsENT.TextTitle = objvzx_TagsENS.TextTitle; //TextTitle
objvzx_TagsENT.TextContent = objvzx_TagsENS.TextContent; //TextContent
objvzx_TagsENT.Author = objvzx_TagsENS.Author; //作者
objvzx_TagsENT.Keyword = objvzx_TagsENS.Keyword; //关键字
objvzx_TagsENT.zxTagsId = objvzx_TagsENS.zxTagsId; //标注Id
objvzx_TagsENT.TagsContent = objvzx_TagsENS.TagsContent; //标注内容
objvzx_TagsENT.PdfContent = objvzx_TagsENS.PdfContent; //Pdf内容
objvzx_TagsENT.PdfPageNum = objvzx_TagsENS.PdfPageNum; //Pdf页码
objvzx_TagsENT.VoteCount = objvzx_TagsENS.VoteCount; //点赞计数
objvzx_TagsENT.OrderNum = objvzx_TagsENS.OrderNum; //序号
objvzx_TagsENT.UpdUser = objvzx_TagsENS.UpdUser; //修改人
objvzx_TagsENT.UpdDate = objvzx_TagsENS.UpdDate; //修改日期
objvzx_TagsENT.PdfLineNum = objvzx_TagsENS.PdfLineNum; //pdf行号
objvzx_TagsENT.PdfX = objvzx_TagsENS.PdfX; //PdfX
objvzx_TagsENT.PdfY = objvzx_TagsENS.PdfY; //PdfY
objvzx_TagsENT.Memo = objvzx_TagsENS.Memo; //备注
objvzx_TagsENT.IdCurrEduCls = objvzx_TagsENS.IdCurrEduCls; //教学班流水号
objvzx_TagsENT.TextId = objvzx_TagsENS.TextId; //课件Id
objvzx_TagsENT.zxShareId = objvzx_TagsENS.zxShareId; //分享Id
objvzx_TagsENT.PdfPageNumIn = objvzx_TagsENS.PdfPageNumIn; //PdfPageNumIn
objvzx_TagsENT.PdfPageTop = objvzx_TagsENS.PdfPageTop; //pdf页面顶部位置
objvzx_TagsENT.PdfDivLet = objvzx_TagsENS.PdfDivLet; //PdfDivLet
objvzx_TagsENT.PdfDivTop = objvzx_TagsENS.PdfDivTop; //PdfDivTop
objvzx_TagsENT.PdfZoom = objvzx_TagsENS.PdfZoom; //PdfZoom
objvzx_TagsENT.zxTagsTypeId = objvzx_TagsENS.zxTagsTypeId; //标注类型ID
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
 /// <param name = "objvzx_TagsEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_TagsEN objvzx_TagsEN)
{
try
{
objvzx_TagsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_TagsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_Tags.TextTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.TextTitle = objvzx_TagsEN.TextTitle == "[null]" ? null :  objvzx_TagsEN.TextTitle; //TextTitle
}
if (arrFldSet.Contains(convzx_Tags.TextContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.TextContent = objvzx_TagsEN.TextContent == "[null]" ? null :  objvzx_TagsEN.TextContent; //TextContent
}
if (arrFldSet.Contains(convzx_Tags.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.Author = objvzx_TagsEN.Author == "[null]" ? null :  objvzx_TagsEN.Author; //作者
}
if (arrFldSet.Contains(convzx_Tags.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.Keyword = objvzx_TagsEN.Keyword == "[null]" ? null :  objvzx_TagsEN.Keyword; //关键字
}
if (arrFldSet.Contains(convzx_Tags.zxTagsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.zxTagsId = objvzx_TagsEN.zxTagsId; //标注Id
}
if (arrFldSet.Contains(convzx_Tags.TagsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.TagsContent = objvzx_TagsEN.TagsContent == "[null]" ? null :  objvzx_TagsEN.TagsContent; //标注内容
}
if (arrFldSet.Contains(convzx_Tags.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.PdfContent = objvzx_TagsEN.PdfContent == "[null]" ? null :  objvzx_TagsEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convzx_Tags.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.PdfPageNum = objvzx_TagsEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convzx_Tags.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.VoteCount = objvzx_TagsEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(convzx_Tags.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.OrderNum = objvzx_TagsEN.OrderNum; //序号
}
if (arrFldSet.Contains(convzx_Tags.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.UpdUser = objvzx_TagsEN.UpdUser == "[null]" ? null :  objvzx_TagsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_Tags.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.UpdDate = objvzx_TagsEN.UpdDate == "[null]" ? null :  objvzx_TagsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_Tags.PdfLineNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.PdfLineNum = objvzx_TagsEN.PdfLineNum; //pdf行号
}
if (arrFldSet.Contains(convzx_Tags.PdfX, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.PdfX = objvzx_TagsEN.PdfX == "[null]" ? null :  objvzx_TagsEN.PdfX; //PdfX
}
if (arrFldSet.Contains(convzx_Tags.PdfY, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.PdfY = objvzx_TagsEN.PdfY == "[null]" ? null :  objvzx_TagsEN.PdfY; //PdfY
}
if (arrFldSet.Contains(convzx_Tags.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.Memo = objvzx_TagsEN.Memo == "[null]" ? null :  objvzx_TagsEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_Tags.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.IdCurrEduCls = objvzx_TagsEN.IdCurrEduCls == "[null]" ? null :  objvzx_TagsEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_Tags.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.TextId = objvzx_TagsEN.TextId == "[null]" ? null :  objvzx_TagsEN.TextId; //课件Id
}
if (arrFldSet.Contains(convzx_Tags.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.zxShareId = objvzx_TagsEN.zxShareId == "[null]" ? null :  objvzx_TagsEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(convzx_Tags.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.PdfPageNumIn = objvzx_TagsEN.PdfPageNumIn == "[null]" ? null :  objvzx_TagsEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(convzx_Tags.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.PdfPageTop = objvzx_TagsEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(convzx_Tags.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.PdfDivLet = objvzx_TagsEN.PdfDivLet == "[null]" ? null :  objvzx_TagsEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(convzx_Tags.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.PdfDivTop = objvzx_TagsEN.PdfDivTop == "[null]" ? null :  objvzx_TagsEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(convzx_Tags.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.PdfZoom = objvzx_TagsEN.PdfZoom == "[null]" ? null :  objvzx_TagsEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(convzx_Tags.zxTagsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TagsEN.zxTagsTypeId = objvzx_TagsEN.zxTagsTypeId == "[null]" ? null :  objvzx_TagsEN.zxTagsTypeId; //标注类型ID
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
 /// <param name = "objvzx_TagsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_TagsEN objvzx_TagsEN)
{
try
{
if (objvzx_TagsEN.TextTitle == "[null]") objvzx_TagsEN.TextTitle = null; //TextTitle
if (objvzx_TagsEN.TextContent == "[null]") objvzx_TagsEN.TextContent = null; //TextContent
if (objvzx_TagsEN.Author == "[null]") objvzx_TagsEN.Author = null; //作者
if (objvzx_TagsEN.Keyword == "[null]") objvzx_TagsEN.Keyword = null; //关键字
if (objvzx_TagsEN.TagsContent == "[null]") objvzx_TagsEN.TagsContent = null; //标注内容
if (objvzx_TagsEN.PdfContent == "[null]") objvzx_TagsEN.PdfContent = null; //Pdf内容
if (objvzx_TagsEN.UpdUser == "[null]") objvzx_TagsEN.UpdUser = null; //修改人
if (objvzx_TagsEN.UpdDate == "[null]") objvzx_TagsEN.UpdDate = null; //修改日期
if (objvzx_TagsEN.PdfX == "[null]") objvzx_TagsEN.PdfX = null; //PdfX
if (objvzx_TagsEN.PdfY == "[null]") objvzx_TagsEN.PdfY = null; //PdfY
if (objvzx_TagsEN.Memo == "[null]") objvzx_TagsEN.Memo = null; //备注
if (objvzx_TagsEN.IdCurrEduCls == "[null]") objvzx_TagsEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_TagsEN.TextId == "[null]") objvzx_TagsEN.TextId = null; //课件Id
if (objvzx_TagsEN.zxShareId == "[null]") objvzx_TagsEN.zxShareId = null; //分享Id
if (objvzx_TagsEN.PdfPageNumIn == "[null]") objvzx_TagsEN.PdfPageNumIn = null; //PdfPageNumIn
if (objvzx_TagsEN.PdfDivLet == "[null]") objvzx_TagsEN.PdfDivLet = null; //PdfDivLet
if (objvzx_TagsEN.PdfDivTop == "[null]") objvzx_TagsEN.PdfDivTop = null; //PdfDivTop
if (objvzx_TagsEN.PdfZoom == "[null]") objvzx_TagsEN.PdfZoom = null; //PdfZoom
if (objvzx_TagsEN.zxTagsTypeId == "[null]") objvzx_TagsEN.zxTagsTypeId = null; //标注类型ID
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
public static void CheckProperty4Condition(clsvzx_TagsEN objvzx_TagsEN)
{
 vzx_TagsDA.CheckProperty4Condition(objvzx_TagsEN);
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
if (clszx_TextBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TextBL没有刷新缓存机制(clszx_TextBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_TagsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TagsBL没有刷新缓存机制(clszx_TagsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxTagsId");
//if (arrvzx_TagsObjLstCache == null)
//{
//arrvzx_TagsObjLstCache = vzx_TagsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxTagsId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_TagsEN GetObjByzxTagsIdCache(string strzxTagsId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvzx_TagsEN._CurrTabName);
List<clsvzx_TagsEN> arrvzx_TagsObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_TagsEN> arrvzx_TagsObjLst_Sel =
arrvzx_TagsObjLstCache
.Where(x=> x.zxTagsId == strzxTagsId 
);
if (arrvzx_TagsObjLst_Sel.Count() == 0)
{
   clsvzx_TagsEN obj = clsvzx_TagsBL.GetObjByzxTagsId(strzxTagsId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvzx_TagsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_TagsEN> GetAllvzx_TagsObjLstCache()
{
//获取缓存中的对象列表
List<clsvzx_TagsEN> arrvzx_TagsObjLstCache = GetObjLstCache(); 
return arrvzx_TagsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_TagsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvzx_TagsEN._CurrTabName);
List<clsvzx_TagsEN> arrvzx_TagsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvzx_TagsObjLstCache;
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
string strKey = string.Format("{0}", clsvzx_TagsEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strzxTagsId)
{
if (strInFldName != convzx_Tags.zxTagsId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_Tags.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_Tags.AttributeName));
throw new Exception(strMsg);
}
var objvzx_Tags = clsvzx_TagsBL.GetObjByzxTagsIdCache(strzxTagsId);
if (objvzx_Tags == null) return "";
return objvzx_Tags[strOutFldName].ToString();
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
int intRecCount = clsvzx_TagsDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_TagsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_TagsDA.GetRecCount();
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
int intRecCount = clsvzx_TagsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_TagsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_TagsEN objvzx_TagsCond)
{
List<clsvzx_TagsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_TagsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_Tags.AttributeName)
{
if (objvzx_TagsCond.IsUpdated(strFldName) == false) continue;
if (objvzx_TagsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TagsCond[strFldName].ToString());
}
else
{
if (objvzx_TagsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_TagsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TagsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_TagsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_TagsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_TagsCond[strFldName]));
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
 List<string> arrList = clsvzx_TagsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_TagsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_TagsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}