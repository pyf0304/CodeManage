
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_TagsBL
 表名:vgs_Tags(01120757)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:27
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
public static class  clsvgs_TagsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTagsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_TagsEN GetObj(this K_TagsId_vgs_Tags myKey)
{
clsvgs_TagsEN objvgs_TagsEN = clsvgs_TagsBL.vgs_TagsDA.GetObjByTagsId(myKey.Value);
return objvgs_TagsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetTagsId(this clsvgs_TagsEN objvgs_TagsEN, string strTagsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTagsId, 10, convgs_Tags.TagsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTagsId, 10, convgs_Tags.TagsId);
}
objvgs_TagsEN.TagsId = strTagsId; //标注Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.TagsId) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.TagsId, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.TagsId] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetTagsContent(this clsvgs_TagsEN objvgs_TagsEN, string strTagsContent, string strComparisonOp="")
	{
objvgs_TagsEN.TagsContent = strTagsContent; //标注内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.TagsContent) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.TagsContent, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.TagsContent] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetPdfContent(this clsvgs_TagsEN objvgs_TagsEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convgs_Tags.PdfContent);
}
objvgs_TagsEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.PdfContent) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.PdfContent, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.PdfContent] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetPdfPageNum(this clsvgs_TagsEN objvgs_TagsEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvgs_TagsEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.PdfPageNum) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.PdfPageNum, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.PdfPageNum] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetVoteCount(this clsvgs_TagsEN objvgs_TagsEN, int? intVoteCount, string strComparisonOp="")
	{
objvgs_TagsEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.VoteCount) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.VoteCount, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.VoteCount] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetOrderNum(this clsvgs_TagsEN objvgs_TagsEN, int? intOrderNum, string strComparisonOp="")
	{
objvgs_TagsEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.OrderNum) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.OrderNum, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.OrderNum] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetUpdUser(this clsvgs_TagsEN objvgs_TagsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convgs_Tags.UpdUser);
}
objvgs_TagsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.UpdUser) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.UpdUser, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.UpdUser] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetUpdDate(this clsvgs_TagsEN objvgs_TagsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convgs_Tags.UpdDate);
}
objvgs_TagsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.UpdDate) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.UpdDate, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.UpdDate] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetPdfLineNum(this clsvgs_TagsEN objvgs_TagsEN, int? intPdfLineNum, string strComparisonOp="")
	{
objvgs_TagsEN.PdfLineNum = intPdfLineNum; //pdf行号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.PdfLineNum) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.PdfLineNum, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.PdfLineNum] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetPdfX(this clsvgs_TagsEN objvgs_TagsEN, string strPdfX, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfX, 50, convgs_Tags.PdfX);
}
objvgs_TagsEN.PdfX = strPdfX; //PdfX
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.PdfX) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.PdfX, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.PdfX] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetPdfY(this clsvgs_TagsEN objvgs_TagsEN, string strPdfY, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfY, 50, convgs_Tags.PdfY);
}
objvgs_TagsEN.PdfY = strPdfY; //PdfY
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.PdfY) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.PdfY, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.PdfY] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetMemo(this clsvgs_TagsEN objvgs_TagsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convgs_Tags.Memo);
}
objvgs_TagsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.Memo) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.Memo, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.Memo] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetIdCurrEduCls(this clsvgs_TagsEN objvgs_TagsEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convgs_Tags.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convgs_Tags.IdCurrEduCls);
}
objvgs_TagsEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.IdCurrEduCls) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.IdCurrEduCls, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.IdCurrEduCls] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetPaperTitle(this clsvgs_TagsEN objvgs_TagsEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convgs_Tags.PaperTitle);
}
objvgs_TagsEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.PaperTitle) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.PaperTitle, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.PaperTitle] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetPaperId(this clsvgs_TagsEN objvgs_TagsEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convgs_Tags.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convgs_Tags.PaperId);
}
objvgs_TagsEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.PaperId) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.PaperId, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.PaperId] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetShareId(this clsvgs_TagsEN objvgs_TagsEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convgs_Tags.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convgs_Tags.ShareId);
}
objvgs_TagsEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.ShareId) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.ShareId, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.ShareId] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetPdfPageNumIn(this clsvgs_TagsEN objvgs_TagsEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, convgs_Tags.PdfPageNumIn);
}
objvgs_TagsEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.PdfPageNumIn) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.PdfPageNumIn, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.PdfPageNumIn] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetPdfPageTop(this clsvgs_TagsEN objvgs_TagsEN, int? intPdfPageTop, string strComparisonOp="")
	{
objvgs_TagsEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.PdfPageTop) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.PdfPageTop, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.PdfPageTop] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetPdfDivLet(this clsvgs_TagsEN objvgs_TagsEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, convgs_Tags.PdfDivLet);
}
objvgs_TagsEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.PdfDivLet) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.PdfDivLet, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.PdfDivLet] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetPdfDivTop(this clsvgs_TagsEN objvgs_TagsEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, convgs_Tags.PdfDivTop);
}
objvgs_TagsEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.PdfDivTop) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.PdfDivTop, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.PdfDivTop] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetPdfZoom(this clsvgs_TagsEN objvgs_TagsEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, convgs_Tags.PdfZoom);
}
objvgs_TagsEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.PdfZoom) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.PdfZoom, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.PdfZoom] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TagsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TagsEN SetTagsTypeId(this clsvgs_TagsEN objvgs_TagsEN, string strTagsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTagsTypeId, 2, convgs_Tags.TagsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTagsTypeId, 2, convgs_Tags.TagsTypeId);
}
objvgs_TagsEN.TagsTypeId = strTagsTypeId; //标注类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TagsEN.dicFldComparisonOp.ContainsKey(convgs_Tags.TagsTypeId) == false)
{
objvgs_TagsEN.dicFldComparisonOp.Add(convgs_Tags.TagsTypeId, strComparisonOp);
}
else
{
objvgs_TagsEN.dicFldComparisonOp[convgs_Tags.TagsTypeId] = strComparisonOp;
}
}
return objvgs_TagsEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_TagsENS">源对象</param>
 /// <param name = "objvgs_TagsENT">目标对象</param>
 public static void CopyTo(this clsvgs_TagsEN objvgs_TagsENS, clsvgs_TagsEN objvgs_TagsENT)
{
try
{
objvgs_TagsENT.TagsId = objvgs_TagsENS.TagsId; //标注Id
objvgs_TagsENT.TagsContent = objvgs_TagsENS.TagsContent; //标注内容
objvgs_TagsENT.PdfContent = objvgs_TagsENS.PdfContent; //Pdf内容
objvgs_TagsENT.PdfPageNum = objvgs_TagsENS.PdfPageNum; //Pdf页码
objvgs_TagsENT.VoteCount = objvgs_TagsENS.VoteCount; //点赞计数
objvgs_TagsENT.OrderNum = objvgs_TagsENS.OrderNum; //序号
objvgs_TagsENT.UpdUser = objvgs_TagsENS.UpdUser; //修改人
objvgs_TagsENT.UpdDate = objvgs_TagsENS.UpdDate; //修改日期
objvgs_TagsENT.PdfLineNum = objvgs_TagsENS.PdfLineNum; //pdf行号
objvgs_TagsENT.PdfX = objvgs_TagsENS.PdfX; //PdfX
objvgs_TagsENT.PdfY = objvgs_TagsENS.PdfY; //PdfY
objvgs_TagsENT.Memo = objvgs_TagsENS.Memo; //备注
objvgs_TagsENT.IdCurrEduCls = objvgs_TagsENS.IdCurrEduCls; //教学班流水号
objvgs_TagsENT.PaperTitle = objvgs_TagsENS.PaperTitle; //论文标题
objvgs_TagsENT.PaperId = objvgs_TagsENS.PaperId; //论文Id
objvgs_TagsENT.ShareId = objvgs_TagsENS.ShareId; //分享Id
objvgs_TagsENT.PdfPageNumIn = objvgs_TagsENS.PdfPageNumIn; //PdfPageNumIn
objvgs_TagsENT.PdfPageTop = objvgs_TagsENS.PdfPageTop; //pdf页面顶部位置
objvgs_TagsENT.PdfDivLet = objvgs_TagsENS.PdfDivLet; //PdfDivLet
objvgs_TagsENT.PdfDivTop = objvgs_TagsENS.PdfDivTop; //PdfDivTop
objvgs_TagsENT.PdfZoom = objvgs_TagsENS.PdfZoom; //PdfZoom
objvgs_TagsENT.TagsTypeId = objvgs_TagsENS.TagsTypeId; //标注类型ID
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
 /// <param name = "objvgs_TagsENS">源对象</param>
 /// <returns>目标对象=>clsvgs_TagsEN:objvgs_TagsENT</returns>
 public static clsvgs_TagsEN CopyTo(this clsvgs_TagsEN objvgs_TagsENS)
{
try
{
 clsvgs_TagsEN objvgs_TagsENT = new clsvgs_TagsEN()
{
TagsId = objvgs_TagsENS.TagsId, //标注Id
TagsContent = objvgs_TagsENS.TagsContent, //标注内容
PdfContent = objvgs_TagsENS.PdfContent, //Pdf内容
PdfPageNum = objvgs_TagsENS.PdfPageNum, //Pdf页码
VoteCount = objvgs_TagsENS.VoteCount, //点赞计数
OrderNum = objvgs_TagsENS.OrderNum, //序号
UpdUser = objvgs_TagsENS.UpdUser, //修改人
UpdDate = objvgs_TagsENS.UpdDate, //修改日期
PdfLineNum = objvgs_TagsENS.PdfLineNum, //pdf行号
PdfX = objvgs_TagsENS.PdfX, //PdfX
PdfY = objvgs_TagsENS.PdfY, //PdfY
Memo = objvgs_TagsENS.Memo, //备注
IdCurrEduCls = objvgs_TagsENS.IdCurrEduCls, //教学班流水号
PaperTitle = objvgs_TagsENS.PaperTitle, //论文标题
PaperId = objvgs_TagsENS.PaperId, //论文Id
ShareId = objvgs_TagsENS.ShareId, //分享Id
PdfPageNumIn = objvgs_TagsENS.PdfPageNumIn, //PdfPageNumIn
PdfPageTop = objvgs_TagsENS.PdfPageTop, //pdf页面顶部位置
PdfDivLet = objvgs_TagsENS.PdfDivLet, //PdfDivLet
PdfDivTop = objvgs_TagsENS.PdfDivTop, //PdfDivTop
PdfZoom = objvgs_TagsENS.PdfZoom, //PdfZoom
TagsTypeId = objvgs_TagsENS.TagsTypeId, //标注类型ID
};
 return objvgs_TagsENT;
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
public static void CheckProperty4Condition(this clsvgs_TagsEN objvgs_TagsEN)
{
 clsvgs_TagsBL.vgs_TagsDA.CheckProperty4Condition(objvgs_TagsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_TagsEN objvgs_TagsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_TagsCond.IsUpdated(convgs_Tags.TagsId) == true)
{
string strComparisonOpTagsId = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.TagsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_Tags.TagsId, objvgs_TagsCond.TagsId, strComparisonOpTagsId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvgs_TagsCond.IsUpdated(convgs_Tags.PdfContent) == true)
{
string strComparisonOpPdfContent = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_Tags.PdfContent, objvgs_TagsCond.PdfContent, strComparisonOpPdfContent);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_Tags.PdfPageNum, objvgs_TagsCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.VoteCount) == true)
{
string strComparisonOpVoteCount = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_Tags.VoteCount, objvgs_TagsCond.VoteCount, strComparisonOpVoteCount);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.OrderNum) == true)
{
string strComparisonOpOrderNum = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_Tags.OrderNum, objvgs_TagsCond.OrderNum, strComparisonOpOrderNum);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.UpdUser) == true)
{
string strComparisonOpUpdUser = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_Tags.UpdUser, objvgs_TagsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.UpdDate) == true)
{
string strComparisonOpUpdDate = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_Tags.UpdDate, objvgs_TagsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.PdfLineNum) == true)
{
string strComparisonOpPdfLineNum = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.PdfLineNum];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_Tags.PdfLineNum, objvgs_TagsCond.PdfLineNum, strComparisonOpPdfLineNum);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.PdfX) == true)
{
string strComparisonOpPdfX = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.PdfX];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_Tags.PdfX, objvgs_TagsCond.PdfX, strComparisonOpPdfX);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.PdfY) == true)
{
string strComparisonOpPdfY = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.PdfY];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_Tags.PdfY, objvgs_TagsCond.PdfY, strComparisonOpPdfY);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.Memo) == true)
{
string strComparisonOpMemo = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_Tags.Memo, objvgs_TagsCond.Memo, strComparisonOpMemo);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_Tags.IdCurrEduCls, objvgs_TagsCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_Tags.PaperTitle, objvgs_TagsCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.PaperId) == true)
{
string strComparisonOpPaperId = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_Tags.PaperId, objvgs_TagsCond.PaperId, strComparisonOpPaperId);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.ShareId) == true)
{
string strComparisonOpShareId = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_Tags.ShareId, objvgs_TagsCond.ShareId, strComparisonOpShareId);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_Tags.PdfPageNumIn, objvgs_TagsCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_Tags.PdfPageTop, objvgs_TagsCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_Tags.PdfDivLet, objvgs_TagsCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_Tags.PdfDivTop, objvgs_TagsCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_Tags.PdfZoom, objvgs_TagsCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objvgs_TagsCond.IsUpdated(convgs_Tags.TagsTypeId) == true)
{
string strComparisonOpTagsTypeId = objvgs_TagsCond.dicFldComparisonOp[convgs_Tags.TagsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_Tags.TagsTypeId, objvgs_TagsCond.TagsTypeId, strComparisonOpTagsTypeId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_Tags
{
public virtual bool UpdRelaTabDate(string strTagsId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文标注视图(vgs_Tags)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_TagsBL
{
public static RelatedActions_vgs_Tags relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_TagsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_TagsDA vgs_TagsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_TagsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_TagsBL()
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
if (string.IsNullOrEmpty(clsvgs_TagsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_TagsEN._ConnectString);
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
public static DataTable GetDataTable_vgs_Tags(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_TagsDA.GetDataTable_vgs_Tags(strWhereCond);
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
objDT = vgs_TagsDA.GetDataTable(strWhereCond);
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
objDT = vgs_TagsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vgs_TagsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vgs_TagsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vgs_TagsDA.GetDataTable_Top(objTopPara);
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
objDT = vgs_TagsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vgs_TagsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vgs_TagsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTagsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvgs_TagsEN> GetObjLstByTagsIdLst(List<string> arrTagsIdLst)
{
List<clsvgs_TagsEN> arrObjLst = new List<clsvgs_TagsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTagsIdLst, true);
 string strWhereCond = string.Format("TagsId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TagsEN objvgs_TagsEN = new clsvgs_TagsEN();
try
{
objvgs_TagsEN.TagsId = objRow[convgs_Tags.TagsId].ToString().Trim(); //标注Id
objvgs_TagsEN.TagsContent = objRow[convgs_Tags.TagsContent] == DBNull.Value ? null : objRow[convgs_Tags.TagsContent].ToString().Trim(); //标注内容
objvgs_TagsEN.PdfContent = objRow[convgs_Tags.PdfContent] == DBNull.Value ? null : objRow[convgs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvgs_TagsEN.PdfPageNum = objRow[convgs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvgs_TagsEN.VoteCount = objRow[convgs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.VoteCount].ToString().Trim()); //点赞计数
objvgs_TagsEN.OrderNum = objRow[convgs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.OrderNum].ToString().Trim()); //序号
objvgs_TagsEN.UpdUser = objRow[convgs_Tags.UpdUser] == DBNull.Value ? null : objRow[convgs_Tags.UpdUser].ToString().Trim(); //修改人
objvgs_TagsEN.UpdDate = objRow[convgs_Tags.UpdDate] == DBNull.Value ? null : objRow[convgs_Tags.UpdDate].ToString().Trim(); //修改日期
objvgs_TagsEN.PdfLineNum = objRow[convgs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvgs_TagsEN.PdfX = objRow[convgs_Tags.PdfX] == DBNull.Value ? null : objRow[convgs_Tags.PdfX].ToString().Trim(); //PdfX
objvgs_TagsEN.PdfY = objRow[convgs_Tags.PdfY] == DBNull.Value ? null : objRow[convgs_Tags.PdfY].ToString().Trim(); //PdfY
objvgs_TagsEN.Memo = objRow[convgs_Tags.Memo] == DBNull.Value ? null : objRow[convgs_Tags.Memo].ToString().Trim(); //备注
objvgs_TagsEN.IdCurrEduCls = objRow[convgs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TagsEN.PaperTitle = objRow[convgs_Tags.PaperTitle] == DBNull.Value ? null : objRow[convgs_Tags.PaperTitle].ToString().Trim(); //论文标题
objvgs_TagsEN.PaperId = objRow[convgs_Tags.PaperId] == DBNull.Value ? null : objRow[convgs_Tags.PaperId].ToString().Trim(); //论文Id
objvgs_TagsEN.ShareId = objRow[convgs_Tags.ShareId] == DBNull.Value ? null : objRow[convgs_Tags.ShareId].ToString().Trim(); //分享Id
objvgs_TagsEN.PdfPageNumIn = objRow[convgs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convgs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvgs_TagsEN.PdfPageTop = objRow[convgs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvgs_TagsEN.PdfDivLet = objRow[convgs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvgs_TagsEN.PdfDivTop = objRow[convgs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvgs_TagsEN.PdfZoom = objRow[convgs_Tags.PdfZoom] == DBNull.Value ? null : objRow[convgs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvgs_TagsEN.TagsTypeId = objRow[convgs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[convgs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TagsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTagsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_TagsEN> GetObjLstByTagsIdLstCache(List<string> arrTagsIdLst)
{
string strKey = string.Format("{0}", clsvgs_TagsEN._CurrTabName);
List<clsvgs_TagsEN> arrvgs_TagsObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_TagsEN> arrvgs_TagsObjLst_Sel =
arrvgs_TagsObjLstCache
.Where(x => arrTagsIdLst.Contains(x.TagsId));
return arrvgs_TagsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_TagsEN> GetObjLst(string strWhereCond)
{
List<clsvgs_TagsEN> arrObjLst = new List<clsvgs_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TagsEN objvgs_TagsEN = new clsvgs_TagsEN();
try
{
objvgs_TagsEN.TagsId = objRow[convgs_Tags.TagsId].ToString().Trim(); //标注Id
objvgs_TagsEN.TagsContent = objRow[convgs_Tags.TagsContent] == DBNull.Value ? null : objRow[convgs_Tags.TagsContent].ToString().Trim(); //标注内容
objvgs_TagsEN.PdfContent = objRow[convgs_Tags.PdfContent] == DBNull.Value ? null : objRow[convgs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvgs_TagsEN.PdfPageNum = objRow[convgs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvgs_TagsEN.VoteCount = objRow[convgs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.VoteCount].ToString().Trim()); //点赞计数
objvgs_TagsEN.OrderNum = objRow[convgs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.OrderNum].ToString().Trim()); //序号
objvgs_TagsEN.UpdUser = objRow[convgs_Tags.UpdUser] == DBNull.Value ? null : objRow[convgs_Tags.UpdUser].ToString().Trim(); //修改人
objvgs_TagsEN.UpdDate = objRow[convgs_Tags.UpdDate] == DBNull.Value ? null : objRow[convgs_Tags.UpdDate].ToString().Trim(); //修改日期
objvgs_TagsEN.PdfLineNum = objRow[convgs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvgs_TagsEN.PdfX = objRow[convgs_Tags.PdfX] == DBNull.Value ? null : objRow[convgs_Tags.PdfX].ToString().Trim(); //PdfX
objvgs_TagsEN.PdfY = objRow[convgs_Tags.PdfY] == DBNull.Value ? null : objRow[convgs_Tags.PdfY].ToString().Trim(); //PdfY
objvgs_TagsEN.Memo = objRow[convgs_Tags.Memo] == DBNull.Value ? null : objRow[convgs_Tags.Memo].ToString().Trim(); //备注
objvgs_TagsEN.IdCurrEduCls = objRow[convgs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TagsEN.PaperTitle = objRow[convgs_Tags.PaperTitle] == DBNull.Value ? null : objRow[convgs_Tags.PaperTitle].ToString().Trim(); //论文标题
objvgs_TagsEN.PaperId = objRow[convgs_Tags.PaperId] == DBNull.Value ? null : objRow[convgs_Tags.PaperId].ToString().Trim(); //论文Id
objvgs_TagsEN.ShareId = objRow[convgs_Tags.ShareId] == DBNull.Value ? null : objRow[convgs_Tags.ShareId].ToString().Trim(); //分享Id
objvgs_TagsEN.PdfPageNumIn = objRow[convgs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convgs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvgs_TagsEN.PdfPageTop = objRow[convgs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvgs_TagsEN.PdfDivLet = objRow[convgs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvgs_TagsEN.PdfDivTop = objRow[convgs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvgs_TagsEN.PdfZoom = objRow[convgs_Tags.PdfZoom] == DBNull.Value ? null : objRow[convgs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvgs_TagsEN.TagsTypeId = objRow[convgs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[convgs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TagsEN);
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
public static List<clsvgs_TagsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_TagsEN> arrObjLst = new List<clsvgs_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TagsEN objvgs_TagsEN = new clsvgs_TagsEN();
try
{
objvgs_TagsEN.TagsId = objRow[convgs_Tags.TagsId].ToString().Trim(); //标注Id
objvgs_TagsEN.TagsContent = objRow[convgs_Tags.TagsContent] == DBNull.Value ? null : objRow[convgs_Tags.TagsContent].ToString().Trim(); //标注内容
objvgs_TagsEN.PdfContent = objRow[convgs_Tags.PdfContent] == DBNull.Value ? null : objRow[convgs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvgs_TagsEN.PdfPageNum = objRow[convgs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvgs_TagsEN.VoteCount = objRow[convgs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.VoteCount].ToString().Trim()); //点赞计数
objvgs_TagsEN.OrderNum = objRow[convgs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.OrderNum].ToString().Trim()); //序号
objvgs_TagsEN.UpdUser = objRow[convgs_Tags.UpdUser] == DBNull.Value ? null : objRow[convgs_Tags.UpdUser].ToString().Trim(); //修改人
objvgs_TagsEN.UpdDate = objRow[convgs_Tags.UpdDate] == DBNull.Value ? null : objRow[convgs_Tags.UpdDate].ToString().Trim(); //修改日期
objvgs_TagsEN.PdfLineNum = objRow[convgs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvgs_TagsEN.PdfX = objRow[convgs_Tags.PdfX] == DBNull.Value ? null : objRow[convgs_Tags.PdfX].ToString().Trim(); //PdfX
objvgs_TagsEN.PdfY = objRow[convgs_Tags.PdfY] == DBNull.Value ? null : objRow[convgs_Tags.PdfY].ToString().Trim(); //PdfY
objvgs_TagsEN.Memo = objRow[convgs_Tags.Memo] == DBNull.Value ? null : objRow[convgs_Tags.Memo].ToString().Trim(); //备注
objvgs_TagsEN.IdCurrEduCls = objRow[convgs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TagsEN.PaperTitle = objRow[convgs_Tags.PaperTitle] == DBNull.Value ? null : objRow[convgs_Tags.PaperTitle].ToString().Trim(); //论文标题
objvgs_TagsEN.PaperId = objRow[convgs_Tags.PaperId] == DBNull.Value ? null : objRow[convgs_Tags.PaperId].ToString().Trim(); //论文Id
objvgs_TagsEN.ShareId = objRow[convgs_Tags.ShareId] == DBNull.Value ? null : objRow[convgs_Tags.ShareId].ToString().Trim(); //分享Id
objvgs_TagsEN.PdfPageNumIn = objRow[convgs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convgs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvgs_TagsEN.PdfPageTop = objRow[convgs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvgs_TagsEN.PdfDivLet = objRow[convgs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvgs_TagsEN.PdfDivTop = objRow[convgs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvgs_TagsEN.PdfZoom = objRow[convgs_Tags.PdfZoom] == DBNull.Value ? null : objRow[convgs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvgs_TagsEN.TagsTypeId = objRow[convgs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[convgs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TagsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_TagsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_TagsEN> GetSubObjLstCache(clsvgs_TagsEN objvgs_TagsCond)
{
List<clsvgs_TagsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_TagsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_Tags.AttributeName)
{
if (objvgs_TagsCond.IsUpdated(strFldName) == false) continue;
if (objvgs_TagsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_TagsCond[strFldName].ToString());
}
else
{
if (objvgs_TagsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_TagsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_TagsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_TagsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_TagsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_TagsCond[strFldName]));
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
public static List<clsvgs_TagsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_TagsEN> arrObjLst = new List<clsvgs_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TagsEN objvgs_TagsEN = new clsvgs_TagsEN();
try
{
objvgs_TagsEN.TagsId = objRow[convgs_Tags.TagsId].ToString().Trim(); //标注Id
objvgs_TagsEN.TagsContent = objRow[convgs_Tags.TagsContent] == DBNull.Value ? null : objRow[convgs_Tags.TagsContent].ToString().Trim(); //标注内容
objvgs_TagsEN.PdfContent = objRow[convgs_Tags.PdfContent] == DBNull.Value ? null : objRow[convgs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvgs_TagsEN.PdfPageNum = objRow[convgs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvgs_TagsEN.VoteCount = objRow[convgs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.VoteCount].ToString().Trim()); //点赞计数
objvgs_TagsEN.OrderNum = objRow[convgs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.OrderNum].ToString().Trim()); //序号
objvgs_TagsEN.UpdUser = objRow[convgs_Tags.UpdUser] == DBNull.Value ? null : objRow[convgs_Tags.UpdUser].ToString().Trim(); //修改人
objvgs_TagsEN.UpdDate = objRow[convgs_Tags.UpdDate] == DBNull.Value ? null : objRow[convgs_Tags.UpdDate].ToString().Trim(); //修改日期
objvgs_TagsEN.PdfLineNum = objRow[convgs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvgs_TagsEN.PdfX = objRow[convgs_Tags.PdfX] == DBNull.Value ? null : objRow[convgs_Tags.PdfX].ToString().Trim(); //PdfX
objvgs_TagsEN.PdfY = objRow[convgs_Tags.PdfY] == DBNull.Value ? null : objRow[convgs_Tags.PdfY].ToString().Trim(); //PdfY
objvgs_TagsEN.Memo = objRow[convgs_Tags.Memo] == DBNull.Value ? null : objRow[convgs_Tags.Memo].ToString().Trim(); //备注
objvgs_TagsEN.IdCurrEduCls = objRow[convgs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TagsEN.PaperTitle = objRow[convgs_Tags.PaperTitle] == DBNull.Value ? null : objRow[convgs_Tags.PaperTitle].ToString().Trim(); //论文标题
objvgs_TagsEN.PaperId = objRow[convgs_Tags.PaperId] == DBNull.Value ? null : objRow[convgs_Tags.PaperId].ToString().Trim(); //论文Id
objvgs_TagsEN.ShareId = objRow[convgs_Tags.ShareId] == DBNull.Value ? null : objRow[convgs_Tags.ShareId].ToString().Trim(); //分享Id
objvgs_TagsEN.PdfPageNumIn = objRow[convgs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convgs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvgs_TagsEN.PdfPageTop = objRow[convgs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvgs_TagsEN.PdfDivLet = objRow[convgs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvgs_TagsEN.PdfDivTop = objRow[convgs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvgs_TagsEN.PdfZoom = objRow[convgs_Tags.PdfZoom] == DBNull.Value ? null : objRow[convgs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvgs_TagsEN.TagsTypeId = objRow[convgs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[convgs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TagsEN);
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
public static List<clsvgs_TagsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_TagsEN> arrObjLst = new List<clsvgs_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TagsEN objvgs_TagsEN = new clsvgs_TagsEN();
try
{
objvgs_TagsEN.TagsId = objRow[convgs_Tags.TagsId].ToString().Trim(); //标注Id
objvgs_TagsEN.TagsContent = objRow[convgs_Tags.TagsContent] == DBNull.Value ? null : objRow[convgs_Tags.TagsContent].ToString().Trim(); //标注内容
objvgs_TagsEN.PdfContent = objRow[convgs_Tags.PdfContent] == DBNull.Value ? null : objRow[convgs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvgs_TagsEN.PdfPageNum = objRow[convgs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvgs_TagsEN.VoteCount = objRow[convgs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.VoteCount].ToString().Trim()); //点赞计数
objvgs_TagsEN.OrderNum = objRow[convgs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.OrderNum].ToString().Trim()); //序号
objvgs_TagsEN.UpdUser = objRow[convgs_Tags.UpdUser] == DBNull.Value ? null : objRow[convgs_Tags.UpdUser].ToString().Trim(); //修改人
objvgs_TagsEN.UpdDate = objRow[convgs_Tags.UpdDate] == DBNull.Value ? null : objRow[convgs_Tags.UpdDate].ToString().Trim(); //修改日期
objvgs_TagsEN.PdfLineNum = objRow[convgs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvgs_TagsEN.PdfX = objRow[convgs_Tags.PdfX] == DBNull.Value ? null : objRow[convgs_Tags.PdfX].ToString().Trim(); //PdfX
objvgs_TagsEN.PdfY = objRow[convgs_Tags.PdfY] == DBNull.Value ? null : objRow[convgs_Tags.PdfY].ToString().Trim(); //PdfY
objvgs_TagsEN.Memo = objRow[convgs_Tags.Memo] == DBNull.Value ? null : objRow[convgs_Tags.Memo].ToString().Trim(); //备注
objvgs_TagsEN.IdCurrEduCls = objRow[convgs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TagsEN.PaperTitle = objRow[convgs_Tags.PaperTitle] == DBNull.Value ? null : objRow[convgs_Tags.PaperTitle].ToString().Trim(); //论文标题
objvgs_TagsEN.PaperId = objRow[convgs_Tags.PaperId] == DBNull.Value ? null : objRow[convgs_Tags.PaperId].ToString().Trim(); //论文Id
objvgs_TagsEN.ShareId = objRow[convgs_Tags.ShareId] == DBNull.Value ? null : objRow[convgs_Tags.ShareId].ToString().Trim(); //分享Id
objvgs_TagsEN.PdfPageNumIn = objRow[convgs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convgs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvgs_TagsEN.PdfPageTop = objRow[convgs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvgs_TagsEN.PdfDivLet = objRow[convgs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvgs_TagsEN.PdfDivTop = objRow[convgs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvgs_TagsEN.PdfZoom = objRow[convgs_Tags.PdfZoom] == DBNull.Value ? null : objRow[convgs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvgs_TagsEN.TagsTypeId = objRow[convgs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[convgs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TagsEN);
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
List<clsvgs_TagsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvgs_TagsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_TagsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvgs_TagsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_TagsEN> arrObjLst = new List<clsvgs_TagsEN>(); 
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
	clsvgs_TagsEN objvgs_TagsEN = new clsvgs_TagsEN();
try
{
objvgs_TagsEN.TagsId = objRow[convgs_Tags.TagsId].ToString().Trim(); //标注Id
objvgs_TagsEN.TagsContent = objRow[convgs_Tags.TagsContent] == DBNull.Value ? null : objRow[convgs_Tags.TagsContent].ToString().Trim(); //标注内容
objvgs_TagsEN.PdfContent = objRow[convgs_Tags.PdfContent] == DBNull.Value ? null : objRow[convgs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvgs_TagsEN.PdfPageNum = objRow[convgs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvgs_TagsEN.VoteCount = objRow[convgs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.VoteCount].ToString().Trim()); //点赞计数
objvgs_TagsEN.OrderNum = objRow[convgs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.OrderNum].ToString().Trim()); //序号
objvgs_TagsEN.UpdUser = objRow[convgs_Tags.UpdUser] == DBNull.Value ? null : objRow[convgs_Tags.UpdUser].ToString().Trim(); //修改人
objvgs_TagsEN.UpdDate = objRow[convgs_Tags.UpdDate] == DBNull.Value ? null : objRow[convgs_Tags.UpdDate].ToString().Trim(); //修改日期
objvgs_TagsEN.PdfLineNum = objRow[convgs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvgs_TagsEN.PdfX = objRow[convgs_Tags.PdfX] == DBNull.Value ? null : objRow[convgs_Tags.PdfX].ToString().Trim(); //PdfX
objvgs_TagsEN.PdfY = objRow[convgs_Tags.PdfY] == DBNull.Value ? null : objRow[convgs_Tags.PdfY].ToString().Trim(); //PdfY
objvgs_TagsEN.Memo = objRow[convgs_Tags.Memo] == DBNull.Value ? null : objRow[convgs_Tags.Memo].ToString().Trim(); //备注
objvgs_TagsEN.IdCurrEduCls = objRow[convgs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TagsEN.PaperTitle = objRow[convgs_Tags.PaperTitle] == DBNull.Value ? null : objRow[convgs_Tags.PaperTitle].ToString().Trim(); //论文标题
objvgs_TagsEN.PaperId = objRow[convgs_Tags.PaperId] == DBNull.Value ? null : objRow[convgs_Tags.PaperId].ToString().Trim(); //论文Id
objvgs_TagsEN.ShareId = objRow[convgs_Tags.ShareId] == DBNull.Value ? null : objRow[convgs_Tags.ShareId].ToString().Trim(); //分享Id
objvgs_TagsEN.PdfPageNumIn = objRow[convgs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convgs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvgs_TagsEN.PdfPageTop = objRow[convgs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvgs_TagsEN.PdfDivLet = objRow[convgs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvgs_TagsEN.PdfDivTop = objRow[convgs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvgs_TagsEN.PdfZoom = objRow[convgs_Tags.PdfZoom] == DBNull.Value ? null : objRow[convgs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvgs_TagsEN.TagsTypeId = objRow[convgs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[convgs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TagsEN);
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
public static List<clsvgs_TagsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_TagsEN> arrObjLst = new List<clsvgs_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TagsEN objvgs_TagsEN = new clsvgs_TagsEN();
try
{
objvgs_TagsEN.TagsId = objRow[convgs_Tags.TagsId].ToString().Trim(); //标注Id
objvgs_TagsEN.TagsContent = objRow[convgs_Tags.TagsContent] == DBNull.Value ? null : objRow[convgs_Tags.TagsContent].ToString().Trim(); //标注内容
objvgs_TagsEN.PdfContent = objRow[convgs_Tags.PdfContent] == DBNull.Value ? null : objRow[convgs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvgs_TagsEN.PdfPageNum = objRow[convgs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvgs_TagsEN.VoteCount = objRow[convgs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.VoteCount].ToString().Trim()); //点赞计数
objvgs_TagsEN.OrderNum = objRow[convgs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.OrderNum].ToString().Trim()); //序号
objvgs_TagsEN.UpdUser = objRow[convgs_Tags.UpdUser] == DBNull.Value ? null : objRow[convgs_Tags.UpdUser].ToString().Trim(); //修改人
objvgs_TagsEN.UpdDate = objRow[convgs_Tags.UpdDate] == DBNull.Value ? null : objRow[convgs_Tags.UpdDate].ToString().Trim(); //修改日期
objvgs_TagsEN.PdfLineNum = objRow[convgs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvgs_TagsEN.PdfX = objRow[convgs_Tags.PdfX] == DBNull.Value ? null : objRow[convgs_Tags.PdfX].ToString().Trim(); //PdfX
objvgs_TagsEN.PdfY = objRow[convgs_Tags.PdfY] == DBNull.Value ? null : objRow[convgs_Tags.PdfY].ToString().Trim(); //PdfY
objvgs_TagsEN.Memo = objRow[convgs_Tags.Memo] == DBNull.Value ? null : objRow[convgs_Tags.Memo].ToString().Trim(); //备注
objvgs_TagsEN.IdCurrEduCls = objRow[convgs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TagsEN.PaperTitle = objRow[convgs_Tags.PaperTitle] == DBNull.Value ? null : objRow[convgs_Tags.PaperTitle].ToString().Trim(); //论文标题
objvgs_TagsEN.PaperId = objRow[convgs_Tags.PaperId] == DBNull.Value ? null : objRow[convgs_Tags.PaperId].ToString().Trim(); //论文Id
objvgs_TagsEN.ShareId = objRow[convgs_Tags.ShareId] == DBNull.Value ? null : objRow[convgs_Tags.ShareId].ToString().Trim(); //分享Id
objvgs_TagsEN.PdfPageNumIn = objRow[convgs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convgs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvgs_TagsEN.PdfPageTop = objRow[convgs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvgs_TagsEN.PdfDivLet = objRow[convgs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvgs_TagsEN.PdfDivTop = objRow[convgs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvgs_TagsEN.PdfZoom = objRow[convgs_Tags.PdfZoom] == DBNull.Value ? null : objRow[convgs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvgs_TagsEN.TagsTypeId = objRow[convgs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[convgs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TagsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_TagsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvgs_TagsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_TagsEN> arrObjLst = new List<clsvgs_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TagsEN objvgs_TagsEN = new clsvgs_TagsEN();
try
{
objvgs_TagsEN.TagsId = objRow[convgs_Tags.TagsId].ToString().Trim(); //标注Id
objvgs_TagsEN.TagsContent = objRow[convgs_Tags.TagsContent] == DBNull.Value ? null : objRow[convgs_Tags.TagsContent].ToString().Trim(); //标注内容
objvgs_TagsEN.PdfContent = objRow[convgs_Tags.PdfContent] == DBNull.Value ? null : objRow[convgs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvgs_TagsEN.PdfPageNum = objRow[convgs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvgs_TagsEN.VoteCount = objRow[convgs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.VoteCount].ToString().Trim()); //点赞计数
objvgs_TagsEN.OrderNum = objRow[convgs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.OrderNum].ToString().Trim()); //序号
objvgs_TagsEN.UpdUser = objRow[convgs_Tags.UpdUser] == DBNull.Value ? null : objRow[convgs_Tags.UpdUser].ToString().Trim(); //修改人
objvgs_TagsEN.UpdDate = objRow[convgs_Tags.UpdDate] == DBNull.Value ? null : objRow[convgs_Tags.UpdDate].ToString().Trim(); //修改日期
objvgs_TagsEN.PdfLineNum = objRow[convgs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvgs_TagsEN.PdfX = objRow[convgs_Tags.PdfX] == DBNull.Value ? null : objRow[convgs_Tags.PdfX].ToString().Trim(); //PdfX
objvgs_TagsEN.PdfY = objRow[convgs_Tags.PdfY] == DBNull.Value ? null : objRow[convgs_Tags.PdfY].ToString().Trim(); //PdfY
objvgs_TagsEN.Memo = objRow[convgs_Tags.Memo] == DBNull.Value ? null : objRow[convgs_Tags.Memo].ToString().Trim(); //备注
objvgs_TagsEN.IdCurrEduCls = objRow[convgs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TagsEN.PaperTitle = objRow[convgs_Tags.PaperTitle] == DBNull.Value ? null : objRow[convgs_Tags.PaperTitle].ToString().Trim(); //论文标题
objvgs_TagsEN.PaperId = objRow[convgs_Tags.PaperId] == DBNull.Value ? null : objRow[convgs_Tags.PaperId].ToString().Trim(); //论文Id
objvgs_TagsEN.ShareId = objRow[convgs_Tags.ShareId] == DBNull.Value ? null : objRow[convgs_Tags.ShareId].ToString().Trim(); //分享Id
objvgs_TagsEN.PdfPageNumIn = objRow[convgs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convgs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvgs_TagsEN.PdfPageTop = objRow[convgs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvgs_TagsEN.PdfDivLet = objRow[convgs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvgs_TagsEN.PdfDivTop = objRow[convgs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvgs_TagsEN.PdfZoom = objRow[convgs_Tags.PdfZoom] == DBNull.Value ? null : objRow[convgs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvgs_TagsEN.TagsTypeId = objRow[convgs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[convgs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TagsEN);
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
public static List<clsvgs_TagsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_TagsEN> arrObjLst = new List<clsvgs_TagsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TagsEN objvgs_TagsEN = new clsvgs_TagsEN();
try
{
objvgs_TagsEN.TagsId = objRow[convgs_Tags.TagsId].ToString().Trim(); //标注Id
objvgs_TagsEN.TagsContent = objRow[convgs_Tags.TagsContent] == DBNull.Value ? null : objRow[convgs_Tags.TagsContent].ToString().Trim(); //标注内容
objvgs_TagsEN.PdfContent = objRow[convgs_Tags.PdfContent] == DBNull.Value ? null : objRow[convgs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvgs_TagsEN.PdfPageNum = objRow[convgs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvgs_TagsEN.VoteCount = objRow[convgs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.VoteCount].ToString().Trim()); //点赞计数
objvgs_TagsEN.OrderNum = objRow[convgs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.OrderNum].ToString().Trim()); //序号
objvgs_TagsEN.UpdUser = objRow[convgs_Tags.UpdUser] == DBNull.Value ? null : objRow[convgs_Tags.UpdUser].ToString().Trim(); //修改人
objvgs_TagsEN.UpdDate = objRow[convgs_Tags.UpdDate] == DBNull.Value ? null : objRow[convgs_Tags.UpdDate].ToString().Trim(); //修改日期
objvgs_TagsEN.PdfLineNum = objRow[convgs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvgs_TagsEN.PdfX = objRow[convgs_Tags.PdfX] == DBNull.Value ? null : objRow[convgs_Tags.PdfX].ToString().Trim(); //PdfX
objvgs_TagsEN.PdfY = objRow[convgs_Tags.PdfY] == DBNull.Value ? null : objRow[convgs_Tags.PdfY].ToString().Trim(); //PdfY
objvgs_TagsEN.Memo = objRow[convgs_Tags.Memo] == DBNull.Value ? null : objRow[convgs_Tags.Memo].ToString().Trim(); //备注
objvgs_TagsEN.IdCurrEduCls = objRow[convgs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TagsEN.PaperTitle = objRow[convgs_Tags.PaperTitle] == DBNull.Value ? null : objRow[convgs_Tags.PaperTitle].ToString().Trim(); //论文标题
objvgs_TagsEN.PaperId = objRow[convgs_Tags.PaperId] == DBNull.Value ? null : objRow[convgs_Tags.PaperId].ToString().Trim(); //论文Id
objvgs_TagsEN.ShareId = objRow[convgs_Tags.ShareId] == DBNull.Value ? null : objRow[convgs_Tags.ShareId].ToString().Trim(); //分享Id
objvgs_TagsEN.PdfPageNumIn = objRow[convgs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convgs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvgs_TagsEN.PdfPageTop = objRow[convgs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvgs_TagsEN.PdfDivLet = objRow[convgs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvgs_TagsEN.PdfDivTop = objRow[convgs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvgs_TagsEN.PdfZoom = objRow[convgs_Tags.PdfZoom] == DBNull.Value ? null : objRow[convgs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvgs_TagsEN.TagsTypeId = objRow[convgs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[convgs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TagsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_TagsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_TagsEN> arrObjLst = new List<clsvgs_TagsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TagsEN objvgs_TagsEN = new clsvgs_TagsEN();
try
{
objvgs_TagsEN.TagsId = objRow[convgs_Tags.TagsId].ToString().Trim(); //标注Id
objvgs_TagsEN.TagsContent = objRow[convgs_Tags.TagsContent] == DBNull.Value ? null : objRow[convgs_Tags.TagsContent].ToString().Trim(); //标注内容
objvgs_TagsEN.PdfContent = objRow[convgs_Tags.PdfContent] == DBNull.Value ? null : objRow[convgs_Tags.PdfContent].ToString().Trim(); //Pdf内容
objvgs_TagsEN.PdfPageNum = objRow[convgs_Tags.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageNum].ToString().Trim()); //Pdf页码
objvgs_TagsEN.VoteCount = objRow[convgs_Tags.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.VoteCount].ToString().Trim()); //点赞计数
objvgs_TagsEN.OrderNum = objRow[convgs_Tags.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.OrderNum].ToString().Trim()); //序号
objvgs_TagsEN.UpdUser = objRow[convgs_Tags.UpdUser] == DBNull.Value ? null : objRow[convgs_Tags.UpdUser].ToString().Trim(); //修改人
objvgs_TagsEN.UpdDate = objRow[convgs_Tags.UpdDate] == DBNull.Value ? null : objRow[convgs_Tags.UpdDate].ToString().Trim(); //修改日期
objvgs_TagsEN.PdfLineNum = objRow[convgs_Tags.PdfLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfLineNum].ToString().Trim()); //pdf行号
objvgs_TagsEN.PdfX = objRow[convgs_Tags.PdfX] == DBNull.Value ? null : objRow[convgs_Tags.PdfX].ToString().Trim(); //PdfX
objvgs_TagsEN.PdfY = objRow[convgs_Tags.PdfY] == DBNull.Value ? null : objRow[convgs_Tags.PdfY].ToString().Trim(); //PdfY
objvgs_TagsEN.Memo = objRow[convgs_Tags.Memo] == DBNull.Value ? null : objRow[convgs_Tags.Memo].ToString().Trim(); //备注
objvgs_TagsEN.IdCurrEduCls = objRow[convgs_Tags.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_Tags.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TagsEN.PaperTitle = objRow[convgs_Tags.PaperTitle] == DBNull.Value ? null : objRow[convgs_Tags.PaperTitle].ToString().Trim(); //论文标题
objvgs_TagsEN.PaperId = objRow[convgs_Tags.PaperId] == DBNull.Value ? null : objRow[convgs_Tags.PaperId].ToString().Trim(); //论文Id
objvgs_TagsEN.ShareId = objRow[convgs_Tags.ShareId] == DBNull.Value ? null : objRow[convgs_Tags.ShareId].ToString().Trim(); //分享Id
objvgs_TagsEN.PdfPageNumIn = objRow[convgs_Tags.PdfPageNumIn] == DBNull.Value ? null : objRow[convgs_Tags.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvgs_TagsEN.PdfPageTop = objRow[convgs_Tags.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_Tags.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvgs_TagsEN.PdfDivLet = objRow[convgs_Tags.PdfDivLet] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivLet].ToString().Trim(); //PdfDivLet
objvgs_TagsEN.PdfDivTop = objRow[convgs_Tags.PdfDivTop] == DBNull.Value ? null : objRow[convgs_Tags.PdfDivTop].ToString().Trim(); //PdfDivTop
objvgs_TagsEN.PdfZoom = objRow[convgs_Tags.PdfZoom] == DBNull.Value ? null : objRow[convgs_Tags.PdfZoom].ToString().Trim(); //PdfZoom
objvgs_TagsEN.TagsTypeId = objRow[convgs_Tags.TagsTypeId] == DBNull.Value ? null : objRow[convgs_Tags.TagsTypeId].ToString().Trim(); //标注类型ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TagsEN.TagsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TagsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_TagsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_Tags(ref clsvgs_TagsEN objvgs_TagsEN)
{
bool bolResult = vgs_TagsDA.Getvgs_Tags(ref objvgs_TagsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTagsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_TagsEN GetObjByTagsId(string strTagsId)
{
if (strTagsId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTagsId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTagsId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTagsId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvgs_TagsEN objvgs_TagsEN = vgs_TagsDA.GetObjByTagsId(strTagsId);
return objvgs_TagsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_TagsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_TagsEN objvgs_TagsEN = vgs_TagsDA.GetFirstObj(strWhereCond);
 return objvgs_TagsEN;
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
public static clsvgs_TagsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_TagsEN objvgs_TagsEN = vgs_TagsDA.GetObjByDataRow(objRow);
 return objvgs_TagsEN;
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
public static clsvgs_TagsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_TagsEN objvgs_TagsEN = vgs_TagsDA.GetObjByDataRow(objRow);
 return objvgs_TagsEN;
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
 /// <param name = "strTagsId">所给的关键字</param>
 /// <param name = "lstvgs_TagsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_TagsEN GetObjByTagsIdFromList(string strTagsId, List<clsvgs_TagsEN> lstvgs_TagsObjLst)
{
foreach (clsvgs_TagsEN objvgs_TagsEN in lstvgs_TagsObjLst)
{
if (objvgs_TagsEN.TagsId == strTagsId)
{
return objvgs_TagsEN;
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
 string strMaxTagsId;
 try
 {
 strMaxTagsId = clsvgs_TagsDA.GetMaxStrId();
 return strMaxTagsId;
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
 string strTagsId;
 try
 {
 strTagsId = new clsvgs_TagsDA().GetFirstID(strWhereCond);
 return strTagsId;
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
 arrList = vgs_TagsDA.GetID(strWhereCond);
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
bool bolIsExist = vgs_TagsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTagsId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTagsId)
{
if (string.IsNullOrEmpty(strTagsId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTagsId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vgs_TagsDA.IsExist(strTagsId);
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
 bolIsExist = clsvgs_TagsDA.IsExistTable();
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
 bolIsExist = vgs_TagsDA.IsExistTable(strTabName);
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
 /// <param name = "objvgs_TagsENS">源对象</param>
 /// <param name = "objvgs_TagsENT">目标对象</param>
 public static void CopyTo(clsvgs_TagsEN objvgs_TagsENS, clsvgs_TagsEN objvgs_TagsENT)
{
try
{
objvgs_TagsENT.TagsId = objvgs_TagsENS.TagsId; //标注Id
objvgs_TagsENT.TagsContent = objvgs_TagsENS.TagsContent; //标注内容
objvgs_TagsENT.PdfContent = objvgs_TagsENS.PdfContent; //Pdf内容
objvgs_TagsENT.PdfPageNum = objvgs_TagsENS.PdfPageNum; //Pdf页码
objvgs_TagsENT.VoteCount = objvgs_TagsENS.VoteCount; //点赞计数
objvgs_TagsENT.OrderNum = objvgs_TagsENS.OrderNum; //序号
objvgs_TagsENT.UpdUser = objvgs_TagsENS.UpdUser; //修改人
objvgs_TagsENT.UpdDate = objvgs_TagsENS.UpdDate; //修改日期
objvgs_TagsENT.PdfLineNum = objvgs_TagsENS.PdfLineNum; //pdf行号
objvgs_TagsENT.PdfX = objvgs_TagsENS.PdfX; //PdfX
objvgs_TagsENT.PdfY = objvgs_TagsENS.PdfY; //PdfY
objvgs_TagsENT.Memo = objvgs_TagsENS.Memo; //备注
objvgs_TagsENT.IdCurrEduCls = objvgs_TagsENS.IdCurrEduCls; //教学班流水号
objvgs_TagsENT.PaperTitle = objvgs_TagsENS.PaperTitle; //论文标题
objvgs_TagsENT.PaperId = objvgs_TagsENS.PaperId; //论文Id
objvgs_TagsENT.ShareId = objvgs_TagsENS.ShareId; //分享Id
objvgs_TagsENT.PdfPageNumIn = objvgs_TagsENS.PdfPageNumIn; //PdfPageNumIn
objvgs_TagsENT.PdfPageTop = objvgs_TagsENS.PdfPageTop; //pdf页面顶部位置
objvgs_TagsENT.PdfDivLet = objvgs_TagsENS.PdfDivLet; //PdfDivLet
objvgs_TagsENT.PdfDivTop = objvgs_TagsENS.PdfDivTop; //PdfDivTop
objvgs_TagsENT.PdfZoom = objvgs_TagsENS.PdfZoom; //PdfZoom
objvgs_TagsENT.TagsTypeId = objvgs_TagsENS.TagsTypeId; //标注类型ID
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
 /// <param name = "objvgs_TagsEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_TagsEN objvgs_TagsEN)
{
try
{
objvgs_TagsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_TagsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_Tags.TagsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.TagsId = objvgs_TagsEN.TagsId; //标注Id
}
if (arrFldSet.Contains(convgs_Tags.TagsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.TagsContent = objvgs_TagsEN.TagsContent == "[null]" ? null :  objvgs_TagsEN.TagsContent; //标注内容
}
if (arrFldSet.Contains(convgs_Tags.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.PdfContent = objvgs_TagsEN.PdfContent == "[null]" ? null :  objvgs_TagsEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convgs_Tags.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.PdfPageNum = objvgs_TagsEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convgs_Tags.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.VoteCount = objvgs_TagsEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(convgs_Tags.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.OrderNum = objvgs_TagsEN.OrderNum; //序号
}
if (arrFldSet.Contains(convgs_Tags.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.UpdUser = objvgs_TagsEN.UpdUser == "[null]" ? null :  objvgs_TagsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convgs_Tags.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.UpdDate = objvgs_TagsEN.UpdDate == "[null]" ? null :  objvgs_TagsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convgs_Tags.PdfLineNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.PdfLineNum = objvgs_TagsEN.PdfLineNum; //pdf行号
}
if (arrFldSet.Contains(convgs_Tags.PdfX, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.PdfX = objvgs_TagsEN.PdfX == "[null]" ? null :  objvgs_TagsEN.PdfX; //PdfX
}
if (arrFldSet.Contains(convgs_Tags.PdfY, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.PdfY = objvgs_TagsEN.PdfY == "[null]" ? null :  objvgs_TagsEN.PdfY; //PdfY
}
if (arrFldSet.Contains(convgs_Tags.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.Memo = objvgs_TagsEN.Memo == "[null]" ? null :  objvgs_TagsEN.Memo; //备注
}
if (arrFldSet.Contains(convgs_Tags.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.IdCurrEduCls = objvgs_TagsEN.IdCurrEduCls == "[null]" ? null :  objvgs_TagsEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convgs_Tags.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.PaperTitle = objvgs_TagsEN.PaperTitle == "[null]" ? null :  objvgs_TagsEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convgs_Tags.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.PaperId = objvgs_TagsEN.PaperId == "[null]" ? null :  objvgs_TagsEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convgs_Tags.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.ShareId = objvgs_TagsEN.ShareId == "[null]" ? null :  objvgs_TagsEN.ShareId; //分享Id
}
if (arrFldSet.Contains(convgs_Tags.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.PdfPageNumIn = objvgs_TagsEN.PdfPageNumIn == "[null]" ? null :  objvgs_TagsEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(convgs_Tags.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.PdfPageTop = objvgs_TagsEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(convgs_Tags.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.PdfDivLet = objvgs_TagsEN.PdfDivLet == "[null]" ? null :  objvgs_TagsEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(convgs_Tags.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.PdfDivTop = objvgs_TagsEN.PdfDivTop == "[null]" ? null :  objvgs_TagsEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(convgs_Tags.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.PdfZoom = objvgs_TagsEN.PdfZoom == "[null]" ? null :  objvgs_TagsEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(convgs_Tags.TagsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TagsEN.TagsTypeId = objvgs_TagsEN.TagsTypeId == "[null]" ? null :  objvgs_TagsEN.TagsTypeId; //标注类型ID
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
 /// <param name = "objvgs_TagsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_TagsEN objvgs_TagsEN)
{
try
{
if (objvgs_TagsEN.TagsContent == "[null]") objvgs_TagsEN.TagsContent = null; //标注内容
if (objvgs_TagsEN.PdfContent == "[null]") objvgs_TagsEN.PdfContent = null; //Pdf内容
if (objvgs_TagsEN.UpdUser == "[null]") objvgs_TagsEN.UpdUser = null; //修改人
if (objvgs_TagsEN.UpdDate == "[null]") objvgs_TagsEN.UpdDate = null; //修改日期
if (objvgs_TagsEN.PdfX == "[null]") objvgs_TagsEN.PdfX = null; //PdfX
if (objvgs_TagsEN.PdfY == "[null]") objvgs_TagsEN.PdfY = null; //PdfY
if (objvgs_TagsEN.Memo == "[null]") objvgs_TagsEN.Memo = null; //备注
if (objvgs_TagsEN.IdCurrEduCls == "[null]") objvgs_TagsEN.IdCurrEduCls = null; //教学班流水号
if (objvgs_TagsEN.PaperTitle == "[null]") objvgs_TagsEN.PaperTitle = null; //论文标题
if (objvgs_TagsEN.PaperId == "[null]") objvgs_TagsEN.PaperId = null; //论文Id
if (objvgs_TagsEN.ShareId == "[null]") objvgs_TagsEN.ShareId = null; //分享Id
if (objvgs_TagsEN.PdfPageNumIn == "[null]") objvgs_TagsEN.PdfPageNumIn = null; //PdfPageNumIn
if (objvgs_TagsEN.PdfDivLet == "[null]") objvgs_TagsEN.PdfDivLet = null; //PdfDivLet
if (objvgs_TagsEN.PdfDivTop == "[null]") objvgs_TagsEN.PdfDivTop = null; //PdfDivTop
if (objvgs_TagsEN.PdfZoom == "[null]") objvgs_TagsEN.PdfZoom = null; //PdfZoom
if (objvgs_TagsEN.TagsTypeId == "[null]") objvgs_TagsEN.TagsTypeId = null; //标注类型ID
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
public static void CheckProperty4Condition(clsvgs_TagsEN objvgs_TagsEN)
{
 vgs_TagsDA.CheckProperty4Condition(objvgs_TagsEN);
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
if (clsgs_TagsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_TagsBL没有刷新缓存机制(clsgs_TagsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TagsId");
//if (arrvgs_TagsObjLstCache == null)
//{
//arrvgs_TagsObjLstCache = vgs_TagsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTagsId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_TagsEN GetObjByTagsIdCache(string strTagsId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvgs_TagsEN._CurrTabName);
List<clsvgs_TagsEN> arrvgs_TagsObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_TagsEN> arrvgs_TagsObjLst_Sel =
arrvgs_TagsObjLstCache
.Where(x=> x.TagsId == strTagsId 
);
if (arrvgs_TagsObjLst_Sel.Count() == 0)
{
   clsvgs_TagsEN obj = clsvgs_TagsBL.GetObjByTagsId(strTagsId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvgs_TagsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_TagsEN> GetAllvgs_TagsObjLstCache()
{
//获取缓存中的对象列表
List<clsvgs_TagsEN> arrvgs_TagsObjLstCache = GetObjLstCache(); 
return arrvgs_TagsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_TagsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvgs_TagsEN._CurrTabName);
List<clsvgs_TagsEN> arrvgs_TagsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvgs_TagsObjLstCache;
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
string strKey = string.Format("{0}", clsvgs_TagsEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strTagsId)
{
if (strInFldName != convgs_Tags.TagsId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_Tags.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_Tags.AttributeName));
throw new Exception(strMsg);
}
var objvgs_Tags = clsvgs_TagsBL.GetObjByTagsIdCache(strTagsId);
if (objvgs_Tags == null) return "";
return objvgs_Tags[strOutFldName].ToString();
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
int intRecCount = clsvgs_TagsDA.GetRecCount(strTabName);
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
int intRecCount = clsvgs_TagsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_TagsDA.GetRecCount();
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
int intRecCount = clsvgs_TagsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_TagsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_TagsEN objvgs_TagsCond)
{
List<clsvgs_TagsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_TagsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_Tags.AttributeName)
{
if (objvgs_TagsCond.IsUpdated(strFldName) == false) continue;
if (objvgs_TagsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_TagsCond[strFldName].ToString());
}
else
{
if (objvgs_TagsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_TagsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_TagsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_TagsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_TagsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_TagsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_TagsCond[strFldName]));
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
 List<string> arrList = clsvgs_TagsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vgs_TagsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vgs_TagsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}