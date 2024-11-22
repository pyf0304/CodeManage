
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TextCountBL
 表名:vzx_TextCount(01120839)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
public static class  clsvzx_TextCountBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTextId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_TextCountEN GetObj(this K_TextId_vzx_TextCount myKey)
{
clsvzx_TextCountEN objvzx_TextCountEN = clsvzx_TextCountBL.vzx_TextCountDA.GetObjByTextId(myKey.Value);
return objvzx_TextCountEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetTextId(this clsvzx_TextCountEN objvzx_TextCountEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_TextCount.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_TextCount.TextId);
}
objvzx_TextCountEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.TextId) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.TextId, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.TextId] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetPaperQCount(this clsvzx_TextCountEN objvzx_TextCountEN, int? intPaperQCount, string strComparisonOp="")
	{
objvzx_TextCountEN.PaperQCount = intPaperQCount; //论文答疑数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.PaperQCount) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.PaperQCount, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.PaperQCount] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetTagsCount(this clsvzx_TextCountEN objvzx_TextCountEN, int? intTagsCount, string strComparisonOp="")
	{
objvzx_TextCountEN.TagsCount = intTagsCount; //论文标注数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.TagsCount) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.TagsCount, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.TagsCount] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetSubVCount(this clsvzx_TextCountEN objvzx_TextCountEN, int? intSubVCount, string strComparisonOp="")
	{
objvzx_TextCountEN.SubVCount = intSubVCount; //论文子观点数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.SubVCount) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.SubVCount, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.SubVCount] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetTeaQCount(this clsvzx_TextCountEN objvzx_TextCountEN, int? intTeaQCount, string strComparisonOp="")
	{
objvzx_TextCountEN.TeaQCount = intTeaQCount; //教师提问数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.TeaQCount) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.TeaQCount, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.TeaQCount] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetTeaScore(this clsvzx_TextCountEN objvzx_TextCountEN, float? fltTeaScore, string strComparisonOp="")
	{
objvzx_TextCountEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.TeaScore) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.TeaScore, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.TeaScore] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetStuScore(this clsvzx_TextCountEN objvzx_TextCountEN, float? fltStuScore, string strComparisonOp="")
	{
objvzx_TextCountEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.StuScore) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.StuScore, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.StuScore] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetScore(this clsvzx_TextCountEN objvzx_TextCountEN, float? fltScore, string strComparisonOp="")
	{
objvzx_TextCountEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.Score) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.Score, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.Score] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetAppraiseCount(this clsvzx_TextCountEN objvzx_TextCountEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvzx_TextCountEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.AppraiseCount) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.AppraiseCount, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.AppraiseCount] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetAttachmentCount(this clsvzx_TextCountEN objvzx_TextCountEN, int? intAttachmentCount, string strComparisonOp="")
	{
objvzx_TextCountEN.AttachmentCount = intAttachmentCount; //附件计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.AttachmentCount) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.AttachmentCount, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.AttachmentCount] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetDownloadCount(this clsvzx_TextCountEN objvzx_TextCountEN, int? intDownloadCount, string strComparisonOp="")
	{
objvzx_TextCountEN.DownloadCount = intDownloadCount; //下载数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.DownloadCount) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.DownloadCount, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.DownloadCount] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetCollectionCount(this clsvzx_TextCountEN objvzx_TextCountEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvzx_TextCountEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.CollectionCount) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.CollectionCount, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.CollectionCount] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetVoteCount(this clsvzx_TextCountEN objvzx_TextCountEN, int? intVoteCount, string strComparisonOp="")
	{
objvzx_TextCountEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.VoteCount) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.VoteCount, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.VoteCount] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetVCount(this clsvzx_TextCountEN objvzx_TextCountEN, int? intVCount, string strComparisonOp="")
	{
objvzx_TextCountEN.VCount = intVCount; //VCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.VCount) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.VCount, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.VCount] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetBrowseNumber(this clsvzx_TextCountEN objvzx_TextCountEN, int? intBrowseNumber, string strComparisonOp="")
	{
objvzx_TextCountEN.BrowseNumber = intBrowseNumber; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.BrowseNumber) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.BrowseNumber, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.BrowseNumber] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetTextTitle(this clsvzx_TextCountEN objvzx_TextCountEN, string strTextTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextTitle, convzx_TextCount.TextTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextTitle, 500, convzx_TextCount.TextTitle);
}
objvzx_TextCountEN.TextTitle = strTextTitle; //TextTitle
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.TextTitle) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.TextTitle, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.TextTitle] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetTextContent(this clsvzx_TextCountEN objvzx_TextCountEN, string strTextContent, string strComparisonOp="")
	{
objvzx_TextCountEN.TextContent = strTextContent; //TextContent
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.TextContent) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.TextContent, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.TextContent] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetUpdDate(this clsvzx_TextCountEN objvzx_TextCountEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_TextCount.UpdDate);
}
objvzx_TextCountEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.UpdDate) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.UpdDate, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.UpdDate] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetUpdUser(this clsvzx_TextCountEN objvzx_TextCountEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_TextCount.UpdUser);
}
objvzx_TextCountEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.UpdUser) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.UpdUser, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.UpdUser] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetCreateDate(this clsvzx_TextCountEN objvzx_TextCountEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convzx_TextCount.CreateDate);
}
objvzx_TextCountEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.CreateDate) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.CreateDate, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.CreateDate] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextCountEN SetIdCurrEduCls(this clsvzx_TextCountEN objvzx_TextCountEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_TextCount.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_TextCount.IdCurrEduCls);
}
objvzx_TextCountEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextCountEN.dicFldComparisonOp.ContainsKey(convzx_TextCount.IdCurrEduCls) == false)
{
objvzx_TextCountEN.dicFldComparisonOp.Add(convzx_TextCount.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_TextCountEN.dicFldComparisonOp[convzx_TextCount.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_TextCountEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_TextCountENS">源对象</param>
 /// <param name = "objvzx_TextCountENT">目标对象</param>
 public static void CopyTo(this clsvzx_TextCountEN objvzx_TextCountENS, clsvzx_TextCountEN objvzx_TextCountENT)
{
try
{
objvzx_TextCountENT.TextId = objvzx_TextCountENS.TextId; //课件Id
objvzx_TextCountENT.PaperQCount = objvzx_TextCountENS.PaperQCount; //论文答疑数
objvzx_TextCountENT.TagsCount = objvzx_TextCountENS.TagsCount; //论文标注数
objvzx_TextCountENT.SubVCount = objvzx_TextCountENS.SubVCount; //论文子观点数
objvzx_TextCountENT.TeaQCount = objvzx_TextCountENS.TeaQCount; //教师提问数
objvzx_TextCountENT.TeaScore = objvzx_TextCountENS.TeaScore; //教师评分
objvzx_TextCountENT.StuScore = objvzx_TextCountENS.StuScore; //学生平均分
objvzx_TextCountENT.Score = objvzx_TextCountENS.Score; //评分
objvzx_TextCountENT.AppraiseCount = objvzx_TextCountENS.AppraiseCount; //评论数
objvzx_TextCountENT.AttachmentCount = objvzx_TextCountENS.AttachmentCount; //附件计数
objvzx_TextCountENT.DownloadCount = objvzx_TextCountENS.DownloadCount; //下载数
objvzx_TextCountENT.CollectionCount = objvzx_TextCountENS.CollectionCount; //收藏数量
objvzx_TextCountENT.VoteCount = objvzx_TextCountENS.VoteCount; //点赞计数
objvzx_TextCountENT.VCount = objvzx_TextCountENS.VCount; //VCount
objvzx_TextCountENT.BrowseNumber = objvzx_TextCountENS.BrowseNumber; //浏览量
objvzx_TextCountENT.TextTitle = objvzx_TextCountENS.TextTitle; //TextTitle
objvzx_TextCountENT.TextContent = objvzx_TextCountENS.TextContent; //TextContent
objvzx_TextCountENT.UpdDate = objvzx_TextCountENS.UpdDate; //修改日期
objvzx_TextCountENT.UpdUser = objvzx_TextCountENS.UpdUser; //修改人
objvzx_TextCountENT.CreateDate = objvzx_TextCountENS.CreateDate; //建立日期
objvzx_TextCountENT.IdCurrEduCls = objvzx_TextCountENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvzx_TextCountENS">源对象</param>
 /// <returns>目标对象=>clsvzx_TextCountEN:objvzx_TextCountENT</returns>
 public static clsvzx_TextCountEN CopyTo(this clsvzx_TextCountEN objvzx_TextCountENS)
{
try
{
 clsvzx_TextCountEN objvzx_TextCountENT = new clsvzx_TextCountEN()
{
TextId = objvzx_TextCountENS.TextId, //课件Id
PaperQCount = objvzx_TextCountENS.PaperQCount, //论文答疑数
TagsCount = objvzx_TextCountENS.TagsCount, //论文标注数
SubVCount = objvzx_TextCountENS.SubVCount, //论文子观点数
TeaQCount = objvzx_TextCountENS.TeaQCount, //教师提问数
TeaScore = objvzx_TextCountENS.TeaScore, //教师评分
StuScore = objvzx_TextCountENS.StuScore, //学生平均分
Score = objvzx_TextCountENS.Score, //评分
AppraiseCount = objvzx_TextCountENS.AppraiseCount, //评论数
AttachmentCount = objvzx_TextCountENS.AttachmentCount, //附件计数
DownloadCount = objvzx_TextCountENS.DownloadCount, //下载数
CollectionCount = objvzx_TextCountENS.CollectionCount, //收藏数量
VoteCount = objvzx_TextCountENS.VoteCount, //点赞计数
VCount = objvzx_TextCountENS.VCount, //VCount
BrowseNumber = objvzx_TextCountENS.BrowseNumber, //浏览量
TextTitle = objvzx_TextCountENS.TextTitle, //TextTitle
TextContent = objvzx_TextCountENS.TextContent, //TextContent
UpdDate = objvzx_TextCountENS.UpdDate, //修改日期
UpdUser = objvzx_TextCountENS.UpdUser, //修改人
CreateDate = objvzx_TextCountENS.CreateDate, //建立日期
IdCurrEduCls = objvzx_TextCountENS.IdCurrEduCls, //教学班流水号
};
 return objvzx_TextCountENT;
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
public static void CheckProperty4Condition(this clsvzx_TextCountEN objvzx_TextCountEN)
{
 clsvzx_TextCountBL.vzx_TextCountDA.CheckProperty4Condition(objvzx_TextCountEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_TextCountEN objvzx_TextCountCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.TextId) == true)
{
string strComparisonOpTextId = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TextCount.TextId, objvzx_TextCountCond.TextId, strComparisonOpTextId);
}
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.PaperQCount) == true)
{
string strComparisonOpPaperQCount = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.PaperQCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TextCount.PaperQCount, objvzx_TextCountCond.PaperQCount, strComparisonOpPaperQCount);
}
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.TagsCount) == true)
{
string strComparisonOpTagsCount = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TextCount.TagsCount, objvzx_TextCountCond.TagsCount, strComparisonOpTagsCount);
}
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.SubVCount) == true)
{
string strComparisonOpSubVCount = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.SubVCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TextCount.SubVCount, objvzx_TextCountCond.SubVCount, strComparisonOpSubVCount);
}
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.TeaQCount) == true)
{
string strComparisonOpTeaQCount = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.TeaQCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TextCount.TeaQCount, objvzx_TextCountCond.TeaQCount, strComparisonOpTeaQCount);
}
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.TeaScore) == true)
{
string strComparisonOpTeaScore = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TextCount.TeaScore, objvzx_TextCountCond.TeaScore, strComparisonOpTeaScore);
}
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.StuScore) == true)
{
string strComparisonOpStuScore = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TextCount.StuScore, objvzx_TextCountCond.StuScore, strComparisonOpStuScore);
}
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.Score) == true)
{
string strComparisonOpScore = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TextCount.Score, objvzx_TextCountCond.Score, strComparisonOpScore);
}
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TextCount.AppraiseCount, objvzx_TextCountCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.AttachmentCount) == true)
{
string strComparisonOpAttachmentCount = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TextCount.AttachmentCount, objvzx_TextCountCond.AttachmentCount, strComparisonOpAttachmentCount);
}
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.DownloadCount) == true)
{
string strComparisonOpDownloadCount = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.DownloadCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TextCount.DownloadCount, objvzx_TextCountCond.DownloadCount, strComparisonOpDownloadCount);
}
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TextCount.CollectionCount, objvzx_TextCountCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.VoteCount) == true)
{
string strComparisonOpVoteCount = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TextCount.VoteCount, objvzx_TextCountCond.VoteCount, strComparisonOpVoteCount);
}
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.VCount) == true)
{
string strComparisonOpVCount = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.VCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TextCount.VCount, objvzx_TextCountCond.VCount, strComparisonOpVCount);
}
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.BrowseNumber) == true)
{
string strComparisonOpBrowseNumber = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TextCount.BrowseNumber, objvzx_TextCountCond.BrowseNumber, strComparisonOpBrowseNumber);
}
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.TextTitle) == true)
{
string strComparisonOpTextTitle = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.TextTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TextCount.TextTitle, objvzx_TextCountCond.TextTitle, strComparisonOpTextTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TextCount.UpdDate, objvzx_TextCountCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TextCount.UpdUser, objvzx_TextCountCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.CreateDate) == true)
{
string strComparisonOpCreateDate = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TextCount.CreateDate, objvzx_TextCountCond.CreateDate, strComparisonOpCreateDate);
}
if (objvzx_TextCountCond.IsUpdated(convzx_TextCount.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_TextCountCond.dicFldComparisonOp[convzx_TextCount.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TextCount.IdCurrEduCls, objvzx_TextCountCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_TextCount
{
public virtual bool UpdRelaTabDate(string strTextId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_TextCount(vzx_TextCount)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_TextCountBL
{
public static RelatedActions_vzx_TextCount relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_TextCountDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_TextCountDA vzx_TextCountDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_TextCountDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_TextCountBL()
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
if (string.IsNullOrEmpty(clsvzx_TextCountEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_TextCountEN._ConnectString);
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
public static DataTable GetDataTable_vzx_TextCount(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_TextCountDA.GetDataTable_vzx_TextCount(strWhereCond);
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
objDT = vzx_TextCountDA.GetDataTable(strWhereCond);
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
objDT = vzx_TextCountDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_TextCountDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_TextCountDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_TextCountDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_TextCountDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_TextCountDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_TextCountDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTextIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_TextCountEN> GetObjLstByTextIdLst(List<string> arrTextIdLst)
{
List<clsvzx_TextCountEN> arrObjLst = new List<clsvzx_TextCountEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTextIdLst, true);
 string strWhereCond = string.Format("TextId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextCountEN objvzx_TextCountEN = new clsvzx_TextCountEN();
try
{
objvzx_TextCountEN.TextId = objRow[convzx_TextCount.TextId].ToString().Trim(); //课件Id
objvzx_TextCountEN.PaperQCount = objRow[convzx_TextCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_TextCountEN.TagsCount = objRow[convzx_TextCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TagsCount].ToString().Trim()); //论文标注数
objvzx_TextCountEN.SubVCount = objRow[convzx_TextCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.SubVCount].ToString().Trim()); //论文子观点数
objvzx_TextCountEN.TeaQCount = objRow[convzx_TextCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TeaQCount].ToString().Trim()); //教师提问数
objvzx_TextCountEN.TeaScore = objRow[convzx_TextCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.TeaScore].ToString().Trim()); //教师评分
objvzx_TextCountEN.StuScore = objRow[convzx_TextCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.StuScore].ToString().Trim()); //学生平均分
objvzx_TextCountEN.Score = objRow[convzx_TextCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.Score].ToString().Trim()); //评分
objvzx_TextCountEN.AppraiseCount = objRow[convzx_TextCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AppraiseCount].ToString().Trim()); //评论数
objvzx_TextCountEN.AttachmentCount = objRow[convzx_TextCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_TextCountEN.DownloadCount = objRow[convzx_TextCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.DownloadCount].ToString().Trim()); //下载数
objvzx_TextCountEN.CollectionCount = objRow[convzx_TextCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_TextCountEN.VoteCount = objRow[convzx_TextCount.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VoteCount].ToString().Trim()); //点赞计数
objvzx_TextCountEN.VCount = objRow[convzx_TextCount.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VCount].ToString().Trim()); //VCount
objvzx_TextCountEN.BrowseNumber = objRow[convzx_TextCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.BrowseNumber].ToString().Trim()); //浏览量
objvzx_TextCountEN.TextTitle = objRow[convzx_TextCount.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextCountEN.TextContent = objRow[convzx_TextCount.TextContent] == DBNull.Value ? null : objRow[convzx_TextCount.TextContent].ToString().Trim(); //TextContent
objvzx_TextCountEN.UpdDate = objRow[convzx_TextCount.UpdDate] == DBNull.Value ? null : objRow[convzx_TextCount.UpdDate].ToString().Trim(); //修改日期
objvzx_TextCountEN.UpdUser = objRow[convzx_TextCount.UpdUser] == DBNull.Value ? null : objRow[convzx_TextCount.UpdUser].ToString().Trim(); //修改人
objvzx_TextCountEN.CreateDate = objRow[convzx_TextCount.CreateDate] == DBNull.Value ? null : objRow[convzx_TextCount.CreateDate].ToString().Trim(); //建立日期
objvzx_TextCountEN.IdCurrEduCls = objRow[convzx_TextCount.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextCountEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTextIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_TextCountEN> GetObjLstByTextIdLstCache(List<string> arrTextIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvzx_TextCountEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_TextCountEN> arrvzx_TextCountObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TextCountEN> arrvzx_TextCountObjLst_Sel =
arrvzx_TextCountObjLstCache
.Where(x => arrTextIdLst.Contains(x.TextId));
return arrvzx_TextCountObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TextCountEN> GetObjLst(string strWhereCond)
{
List<clsvzx_TextCountEN> arrObjLst = new List<clsvzx_TextCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextCountEN objvzx_TextCountEN = new clsvzx_TextCountEN();
try
{
objvzx_TextCountEN.TextId = objRow[convzx_TextCount.TextId].ToString().Trim(); //课件Id
objvzx_TextCountEN.PaperQCount = objRow[convzx_TextCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_TextCountEN.TagsCount = objRow[convzx_TextCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TagsCount].ToString().Trim()); //论文标注数
objvzx_TextCountEN.SubVCount = objRow[convzx_TextCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.SubVCount].ToString().Trim()); //论文子观点数
objvzx_TextCountEN.TeaQCount = objRow[convzx_TextCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TeaQCount].ToString().Trim()); //教师提问数
objvzx_TextCountEN.TeaScore = objRow[convzx_TextCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.TeaScore].ToString().Trim()); //教师评分
objvzx_TextCountEN.StuScore = objRow[convzx_TextCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.StuScore].ToString().Trim()); //学生平均分
objvzx_TextCountEN.Score = objRow[convzx_TextCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.Score].ToString().Trim()); //评分
objvzx_TextCountEN.AppraiseCount = objRow[convzx_TextCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AppraiseCount].ToString().Trim()); //评论数
objvzx_TextCountEN.AttachmentCount = objRow[convzx_TextCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_TextCountEN.DownloadCount = objRow[convzx_TextCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.DownloadCount].ToString().Trim()); //下载数
objvzx_TextCountEN.CollectionCount = objRow[convzx_TextCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_TextCountEN.VoteCount = objRow[convzx_TextCount.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VoteCount].ToString().Trim()); //点赞计数
objvzx_TextCountEN.VCount = objRow[convzx_TextCount.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VCount].ToString().Trim()); //VCount
objvzx_TextCountEN.BrowseNumber = objRow[convzx_TextCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.BrowseNumber].ToString().Trim()); //浏览量
objvzx_TextCountEN.TextTitle = objRow[convzx_TextCount.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextCountEN.TextContent = objRow[convzx_TextCount.TextContent] == DBNull.Value ? null : objRow[convzx_TextCount.TextContent].ToString().Trim(); //TextContent
objvzx_TextCountEN.UpdDate = objRow[convzx_TextCount.UpdDate] == DBNull.Value ? null : objRow[convzx_TextCount.UpdDate].ToString().Trim(); //修改日期
objvzx_TextCountEN.UpdUser = objRow[convzx_TextCount.UpdUser] == DBNull.Value ? null : objRow[convzx_TextCount.UpdUser].ToString().Trim(); //修改人
objvzx_TextCountEN.CreateDate = objRow[convzx_TextCount.CreateDate] == DBNull.Value ? null : objRow[convzx_TextCount.CreateDate].ToString().Trim(); //建立日期
objvzx_TextCountEN.IdCurrEduCls = objRow[convzx_TextCount.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextCountEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextCountEN);
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
public static List<clsvzx_TextCountEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_TextCountEN> arrObjLst = new List<clsvzx_TextCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextCountEN objvzx_TextCountEN = new clsvzx_TextCountEN();
try
{
objvzx_TextCountEN.TextId = objRow[convzx_TextCount.TextId].ToString().Trim(); //课件Id
objvzx_TextCountEN.PaperQCount = objRow[convzx_TextCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_TextCountEN.TagsCount = objRow[convzx_TextCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TagsCount].ToString().Trim()); //论文标注数
objvzx_TextCountEN.SubVCount = objRow[convzx_TextCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.SubVCount].ToString().Trim()); //论文子观点数
objvzx_TextCountEN.TeaQCount = objRow[convzx_TextCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TeaQCount].ToString().Trim()); //教师提问数
objvzx_TextCountEN.TeaScore = objRow[convzx_TextCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.TeaScore].ToString().Trim()); //教师评分
objvzx_TextCountEN.StuScore = objRow[convzx_TextCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.StuScore].ToString().Trim()); //学生平均分
objvzx_TextCountEN.Score = objRow[convzx_TextCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.Score].ToString().Trim()); //评分
objvzx_TextCountEN.AppraiseCount = objRow[convzx_TextCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AppraiseCount].ToString().Trim()); //评论数
objvzx_TextCountEN.AttachmentCount = objRow[convzx_TextCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_TextCountEN.DownloadCount = objRow[convzx_TextCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.DownloadCount].ToString().Trim()); //下载数
objvzx_TextCountEN.CollectionCount = objRow[convzx_TextCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_TextCountEN.VoteCount = objRow[convzx_TextCount.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VoteCount].ToString().Trim()); //点赞计数
objvzx_TextCountEN.VCount = objRow[convzx_TextCount.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VCount].ToString().Trim()); //VCount
objvzx_TextCountEN.BrowseNumber = objRow[convzx_TextCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.BrowseNumber].ToString().Trim()); //浏览量
objvzx_TextCountEN.TextTitle = objRow[convzx_TextCount.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextCountEN.TextContent = objRow[convzx_TextCount.TextContent] == DBNull.Value ? null : objRow[convzx_TextCount.TextContent].ToString().Trim(); //TextContent
objvzx_TextCountEN.UpdDate = objRow[convzx_TextCount.UpdDate] == DBNull.Value ? null : objRow[convzx_TextCount.UpdDate].ToString().Trim(); //修改日期
objvzx_TextCountEN.UpdUser = objRow[convzx_TextCount.UpdUser] == DBNull.Value ? null : objRow[convzx_TextCount.UpdUser].ToString().Trim(); //修改人
objvzx_TextCountEN.CreateDate = objRow[convzx_TextCount.CreateDate] == DBNull.Value ? null : objRow[convzx_TextCount.CreateDate].ToString().Trim(); //建立日期
objvzx_TextCountEN.IdCurrEduCls = objRow[convzx_TextCount.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextCountEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_TextCountCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_TextCountEN> GetSubObjLstCache(clsvzx_TextCountEN objvzx_TextCountCond)
{
 string strIdCurrEduCls = objvzx_TextCountCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvzx_TextCountBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvzx_TextCountEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TextCountEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_TextCount.AttributeName)
{
if (objvzx_TextCountCond.IsUpdated(strFldName) == false) continue;
if (objvzx_TextCountCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TextCountCond[strFldName].ToString());
}
else
{
if (objvzx_TextCountCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_TextCountCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TextCountCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_TextCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_TextCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_TextCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_TextCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_TextCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_TextCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_TextCountCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_TextCountCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_TextCountCond[strFldName]));
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
public static List<clsvzx_TextCountEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_TextCountEN> arrObjLst = new List<clsvzx_TextCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextCountEN objvzx_TextCountEN = new clsvzx_TextCountEN();
try
{
objvzx_TextCountEN.TextId = objRow[convzx_TextCount.TextId].ToString().Trim(); //课件Id
objvzx_TextCountEN.PaperQCount = objRow[convzx_TextCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_TextCountEN.TagsCount = objRow[convzx_TextCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TagsCount].ToString().Trim()); //论文标注数
objvzx_TextCountEN.SubVCount = objRow[convzx_TextCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.SubVCount].ToString().Trim()); //论文子观点数
objvzx_TextCountEN.TeaQCount = objRow[convzx_TextCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TeaQCount].ToString().Trim()); //教师提问数
objvzx_TextCountEN.TeaScore = objRow[convzx_TextCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.TeaScore].ToString().Trim()); //教师评分
objvzx_TextCountEN.StuScore = objRow[convzx_TextCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.StuScore].ToString().Trim()); //学生平均分
objvzx_TextCountEN.Score = objRow[convzx_TextCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.Score].ToString().Trim()); //评分
objvzx_TextCountEN.AppraiseCount = objRow[convzx_TextCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AppraiseCount].ToString().Trim()); //评论数
objvzx_TextCountEN.AttachmentCount = objRow[convzx_TextCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_TextCountEN.DownloadCount = objRow[convzx_TextCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.DownloadCount].ToString().Trim()); //下载数
objvzx_TextCountEN.CollectionCount = objRow[convzx_TextCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_TextCountEN.VoteCount = objRow[convzx_TextCount.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VoteCount].ToString().Trim()); //点赞计数
objvzx_TextCountEN.VCount = objRow[convzx_TextCount.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VCount].ToString().Trim()); //VCount
objvzx_TextCountEN.BrowseNumber = objRow[convzx_TextCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.BrowseNumber].ToString().Trim()); //浏览量
objvzx_TextCountEN.TextTitle = objRow[convzx_TextCount.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextCountEN.TextContent = objRow[convzx_TextCount.TextContent] == DBNull.Value ? null : objRow[convzx_TextCount.TextContent].ToString().Trim(); //TextContent
objvzx_TextCountEN.UpdDate = objRow[convzx_TextCount.UpdDate] == DBNull.Value ? null : objRow[convzx_TextCount.UpdDate].ToString().Trim(); //修改日期
objvzx_TextCountEN.UpdUser = objRow[convzx_TextCount.UpdUser] == DBNull.Value ? null : objRow[convzx_TextCount.UpdUser].ToString().Trim(); //修改人
objvzx_TextCountEN.CreateDate = objRow[convzx_TextCount.CreateDate] == DBNull.Value ? null : objRow[convzx_TextCount.CreateDate].ToString().Trim(); //建立日期
objvzx_TextCountEN.IdCurrEduCls = objRow[convzx_TextCount.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextCountEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextCountEN);
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
public static List<clsvzx_TextCountEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_TextCountEN> arrObjLst = new List<clsvzx_TextCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextCountEN objvzx_TextCountEN = new clsvzx_TextCountEN();
try
{
objvzx_TextCountEN.TextId = objRow[convzx_TextCount.TextId].ToString().Trim(); //课件Id
objvzx_TextCountEN.PaperQCount = objRow[convzx_TextCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_TextCountEN.TagsCount = objRow[convzx_TextCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TagsCount].ToString().Trim()); //论文标注数
objvzx_TextCountEN.SubVCount = objRow[convzx_TextCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.SubVCount].ToString().Trim()); //论文子观点数
objvzx_TextCountEN.TeaQCount = objRow[convzx_TextCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TeaQCount].ToString().Trim()); //教师提问数
objvzx_TextCountEN.TeaScore = objRow[convzx_TextCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.TeaScore].ToString().Trim()); //教师评分
objvzx_TextCountEN.StuScore = objRow[convzx_TextCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.StuScore].ToString().Trim()); //学生平均分
objvzx_TextCountEN.Score = objRow[convzx_TextCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.Score].ToString().Trim()); //评分
objvzx_TextCountEN.AppraiseCount = objRow[convzx_TextCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AppraiseCount].ToString().Trim()); //评论数
objvzx_TextCountEN.AttachmentCount = objRow[convzx_TextCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_TextCountEN.DownloadCount = objRow[convzx_TextCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.DownloadCount].ToString().Trim()); //下载数
objvzx_TextCountEN.CollectionCount = objRow[convzx_TextCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_TextCountEN.VoteCount = objRow[convzx_TextCount.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VoteCount].ToString().Trim()); //点赞计数
objvzx_TextCountEN.VCount = objRow[convzx_TextCount.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VCount].ToString().Trim()); //VCount
objvzx_TextCountEN.BrowseNumber = objRow[convzx_TextCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.BrowseNumber].ToString().Trim()); //浏览量
objvzx_TextCountEN.TextTitle = objRow[convzx_TextCount.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextCountEN.TextContent = objRow[convzx_TextCount.TextContent] == DBNull.Value ? null : objRow[convzx_TextCount.TextContent].ToString().Trim(); //TextContent
objvzx_TextCountEN.UpdDate = objRow[convzx_TextCount.UpdDate] == DBNull.Value ? null : objRow[convzx_TextCount.UpdDate].ToString().Trim(); //修改日期
objvzx_TextCountEN.UpdUser = objRow[convzx_TextCount.UpdUser] == DBNull.Value ? null : objRow[convzx_TextCount.UpdUser].ToString().Trim(); //修改人
objvzx_TextCountEN.CreateDate = objRow[convzx_TextCount.CreateDate] == DBNull.Value ? null : objRow[convzx_TextCount.CreateDate].ToString().Trim(); //建立日期
objvzx_TextCountEN.IdCurrEduCls = objRow[convzx_TextCount.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextCountEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextCountEN);
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
List<clsvzx_TextCountEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_TextCountEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TextCountEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_TextCountEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_TextCountEN> arrObjLst = new List<clsvzx_TextCountEN>(); 
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
	clsvzx_TextCountEN objvzx_TextCountEN = new clsvzx_TextCountEN();
try
{
objvzx_TextCountEN.TextId = objRow[convzx_TextCount.TextId].ToString().Trim(); //课件Id
objvzx_TextCountEN.PaperQCount = objRow[convzx_TextCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_TextCountEN.TagsCount = objRow[convzx_TextCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TagsCount].ToString().Trim()); //论文标注数
objvzx_TextCountEN.SubVCount = objRow[convzx_TextCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.SubVCount].ToString().Trim()); //论文子观点数
objvzx_TextCountEN.TeaQCount = objRow[convzx_TextCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TeaQCount].ToString().Trim()); //教师提问数
objvzx_TextCountEN.TeaScore = objRow[convzx_TextCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.TeaScore].ToString().Trim()); //教师评分
objvzx_TextCountEN.StuScore = objRow[convzx_TextCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.StuScore].ToString().Trim()); //学生平均分
objvzx_TextCountEN.Score = objRow[convzx_TextCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.Score].ToString().Trim()); //评分
objvzx_TextCountEN.AppraiseCount = objRow[convzx_TextCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AppraiseCount].ToString().Trim()); //评论数
objvzx_TextCountEN.AttachmentCount = objRow[convzx_TextCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_TextCountEN.DownloadCount = objRow[convzx_TextCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.DownloadCount].ToString().Trim()); //下载数
objvzx_TextCountEN.CollectionCount = objRow[convzx_TextCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_TextCountEN.VoteCount = objRow[convzx_TextCount.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VoteCount].ToString().Trim()); //点赞计数
objvzx_TextCountEN.VCount = objRow[convzx_TextCount.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VCount].ToString().Trim()); //VCount
objvzx_TextCountEN.BrowseNumber = objRow[convzx_TextCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.BrowseNumber].ToString().Trim()); //浏览量
objvzx_TextCountEN.TextTitle = objRow[convzx_TextCount.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextCountEN.TextContent = objRow[convzx_TextCount.TextContent] == DBNull.Value ? null : objRow[convzx_TextCount.TextContent].ToString().Trim(); //TextContent
objvzx_TextCountEN.UpdDate = objRow[convzx_TextCount.UpdDate] == DBNull.Value ? null : objRow[convzx_TextCount.UpdDate].ToString().Trim(); //修改日期
objvzx_TextCountEN.UpdUser = objRow[convzx_TextCount.UpdUser] == DBNull.Value ? null : objRow[convzx_TextCount.UpdUser].ToString().Trim(); //修改人
objvzx_TextCountEN.CreateDate = objRow[convzx_TextCount.CreateDate] == DBNull.Value ? null : objRow[convzx_TextCount.CreateDate].ToString().Trim(); //建立日期
objvzx_TextCountEN.IdCurrEduCls = objRow[convzx_TextCount.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextCountEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextCountEN);
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
public static List<clsvzx_TextCountEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_TextCountEN> arrObjLst = new List<clsvzx_TextCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextCountEN objvzx_TextCountEN = new clsvzx_TextCountEN();
try
{
objvzx_TextCountEN.TextId = objRow[convzx_TextCount.TextId].ToString().Trim(); //课件Id
objvzx_TextCountEN.PaperQCount = objRow[convzx_TextCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_TextCountEN.TagsCount = objRow[convzx_TextCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TagsCount].ToString().Trim()); //论文标注数
objvzx_TextCountEN.SubVCount = objRow[convzx_TextCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.SubVCount].ToString().Trim()); //论文子观点数
objvzx_TextCountEN.TeaQCount = objRow[convzx_TextCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TeaQCount].ToString().Trim()); //教师提问数
objvzx_TextCountEN.TeaScore = objRow[convzx_TextCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.TeaScore].ToString().Trim()); //教师评分
objvzx_TextCountEN.StuScore = objRow[convzx_TextCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.StuScore].ToString().Trim()); //学生平均分
objvzx_TextCountEN.Score = objRow[convzx_TextCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.Score].ToString().Trim()); //评分
objvzx_TextCountEN.AppraiseCount = objRow[convzx_TextCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AppraiseCount].ToString().Trim()); //评论数
objvzx_TextCountEN.AttachmentCount = objRow[convzx_TextCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_TextCountEN.DownloadCount = objRow[convzx_TextCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.DownloadCount].ToString().Trim()); //下载数
objvzx_TextCountEN.CollectionCount = objRow[convzx_TextCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_TextCountEN.VoteCount = objRow[convzx_TextCount.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VoteCount].ToString().Trim()); //点赞计数
objvzx_TextCountEN.VCount = objRow[convzx_TextCount.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VCount].ToString().Trim()); //VCount
objvzx_TextCountEN.BrowseNumber = objRow[convzx_TextCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.BrowseNumber].ToString().Trim()); //浏览量
objvzx_TextCountEN.TextTitle = objRow[convzx_TextCount.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextCountEN.TextContent = objRow[convzx_TextCount.TextContent] == DBNull.Value ? null : objRow[convzx_TextCount.TextContent].ToString().Trim(); //TextContent
objvzx_TextCountEN.UpdDate = objRow[convzx_TextCount.UpdDate] == DBNull.Value ? null : objRow[convzx_TextCount.UpdDate].ToString().Trim(); //修改日期
objvzx_TextCountEN.UpdUser = objRow[convzx_TextCount.UpdUser] == DBNull.Value ? null : objRow[convzx_TextCount.UpdUser].ToString().Trim(); //修改人
objvzx_TextCountEN.CreateDate = objRow[convzx_TextCount.CreateDate] == DBNull.Value ? null : objRow[convzx_TextCount.CreateDate].ToString().Trim(); //建立日期
objvzx_TextCountEN.IdCurrEduCls = objRow[convzx_TextCount.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextCountEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_TextCountEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_TextCountEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_TextCountEN> arrObjLst = new List<clsvzx_TextCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextCountEN objvzx_TextCountEN = new clsvzx_TextCountEN();
try
{
objvzx_TextCountEN.TextId = objRow[convzx_TextCount.TextId].ToString().Trim(); //课件Id
objvzx_TextCountEN.PaperQCount = objRow[convzx_TextCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_TextCountEN.TagsCount = objRow[convzx_TextCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TagsCount].ToString().Trim()); //论文标注数
objvzx_TextCountEN.SubVCount = objRow[convzx_TextCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.SubVCount].ToString().Trim()); //论文子观点数
objvzx_TextCountEN.TeaQCount = objRow[convzx_TextCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TeaQCount].ToString().Trim()); //教师提问数
objvzx_TextCountEN.TeaScore = objRow[convzx_TextCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.TeaScore].ToString().Trim()); //教师评分
objvzx_TextCountEN.StuScore = objRow[convzx_TextCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.StuScore].ToString().Trim()); //学生平均分
objvzx_TextCountEN.Score = objRow[convzx_TextCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.Score].ToString().Trim()); //评分
objvzx_TextCountEN.AppraiseCount = objRow[convzx_TextCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AppraiseCount].ToString().Trim()); //评论数
objvzx_TextCountEN.AttachmentCount = objRow[convzx_TextCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_TextCountEN.DownloadCount = objRow[convzx_TextCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.DownloadCount].ToString().Trim()); //下载数
objvzx_TextCountEN.CollectionCount = objRow[convzx_TextCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_TextCountEN.VoteCount = objRow[convzx_TextCount.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VoteCount].ToString().Trim()); //点赞计数
objvzx_TextCountEN.VCount = objRow[convzx_TextCount.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VCount].ToString().Trim()); //VCount
objvzx_TextCountEN.BrowseNumber = objRow[convzx_TextCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.BrowseNumber].ToString().Trim()); //浏览量
objvzx_TextCountEN.TextTitle = objRow[convzx_TextCount.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextCountEN.TextContent = objRow[convzx_TextCount.TextContent] == DBNull.Value ? null : objRow[convzx_TextCount.TextContent].ToString().Trim(); //TextContent
objvzx_TextCountEN.UpdDate = objRow[convzx_TextCount.UpdDate] == DBNull.Value ? null : objRow[convzx_TextCount.UpdDate].ToString().Trim(); //修改日期
objvzx_TextCountEN.UpdUser = objRow[convzx_TextCount.UpdUser] == DBNull.Value ? null : objRow[convzx_TextCount.UpdUser].ToString().Trim(); //修改人
objvzx_TextCountEN.CreateDate = objRow[convzx_TextCount.CreateDate] == DBNull.Value ? null : objRow[convzx_TextCount.CreateDate].ToString().Trim(); //建立日期
objvzx_TextCountEN.IdCurrEduCls = objRow[convzx_TextCount.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextCountEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextCountEN);
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
public static List<clsvzx_TextCountEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_TextCountEN> arrObjLst = new List<clsvzx_TextCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextCountEN objvzx_TextCountEN = new clsvzx_TextCountEN();
try
{
objvzx_TextCountEN.TextId = objRow[convzx_TextCount.TextId].ToString().Trim(); //课件Id
objvzx_TextCountEN.PaperQCount = objRow[convzx_TextCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_TextCountEN.TagsCount = objRow[convzx_TextCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TagsCount].ToString().Trim()); //论文标注数
objvzx_TextCountEN.SubVCount = objRow[convzx_TextCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.SubVCount].ToString().Trim()); //论文子观点数
objvzx_TextCountEN.TeaQCount = objRow[convzx_TextCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TeaQCount].ToString().Trim()); //教师提问数
objvzx_TextCountEN.TeaScore = objRow[convzx_TextCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.TeaScore].ToString().Trim()); //教师评分
objvzx_TextCountEN.StuScore = objRow[convzx_TextCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.StuScore].ToString().Trim()); //学生平均分
objvzx_TextCountEN.Score = objRow[convzx_TextCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.Score].ToString().Trim()); //评分
objvzx_TextCountEN.AppraiseCount = objRow[convzx_TextCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AppraiseCount].ToString().Trim()); //评论数
objvzx_TextCountEN.AttachmentCount = objRow[convzx_TextCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_TextCountEN.DownloadCount = objRow[convzx_TextCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.DownloadCount].ToString().Trim()); //下载数
objvzx_TextCountEN.CollectionCount = objRow[convzx_TextCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_TextCountEN.VoteCount = objRow[convzx_TextCount.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VoteCount].ToString().Trim()); //点赞计数
objvzx_TextCountEN.VCount = objRow[convzx_TextCount.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VCount].ToString().Trim()); //VCount
objvzx_TextCountEN.BrowseNumber = objRow[convzx_TextCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.BrowseNumber].ToString().Trim()); //浏览量
objvzx_TextCountEN.TextTitle = objRow[convzx_TextCount.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextCountEN.TextContent = objRow[convzx_TextCount.TextContent] == DBNull.Value ? null : objRow[convzx_TextCount.TextContent].ToString().Trim(); //TextContent
objvzx_TextCountEN.UpdDate = objRow[convzx_TextCount.UpdDate] == DBNull.Value ? null : objRow[convzx_TextCount.UpdDate].ToString().Trim(); //修改日期
objvzx_TextCountEN.UpdUser = objRow[convzx_TextCount.UpdUser] == DBNull.Value ? null : objRow[convzx_TextCount.UpdUser].ToString().Trim(); //修改人
objvzx_TextCountEN.CreateDate = objRow[convzx_TextCount.CreateDate] == DBNull.Value ? null : objRow[convzx_TextCount.CreateDate].ToString().Trim(); //建立日期
objvzx_TextCountEN.IdCurrEduCls = objRow[convzx_TextCount.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextCountEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TextCountEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_TextCountEN> arrObjLst = new List<clsvzx_TextCountEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextCountEN objvzx_TextCountEN = new clsvzx_TextCountEN();
try
{
objvzx_TextCountEN.TextId = objRow[convzx_TextCount.TextId].ToString().Trim(); //课件Id
objvzx_TextCountEN.PaperQCount = objRow[convzx_TextCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_TextCountEN.TagsCount = objRow[convzx_TextCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TagsCount].ToString().Trim()); //论文标注数
objvzx_TextCountEN.SubVCount = objRow[convzx_TextCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.SubVCount].ToString().Trim()); //论文子观点数
objvzx_TextCountEN.TeaQCount = objRow[convzx_TextCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TeaQCount].ToString().Trim()); //教师提问数
objvzx_TextCountEN.TeaScore = objRow[convzx_TextCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.TeaScore].ToString().Trim()); //教师评分
objvzx_TextCountEN.StuScore = objRow[convzx_TextCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.StuScore].ToString().Trim()); //学生平均分
objvzx_TextCountEN.Score = objRow[convzx_TextCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.Score].ToString().Trim()); //评分
objvzx_TextCountEN.AppraiseCount = objRow[convzx_TextCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AppraiseCount].ToString().Trim()); //评论数
objvzx_TextCountEN.AttachmentCount = objRow[convzx_TextCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_TextCountEN.DownloadCount = objRow[convzx_TextCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.DownloadCount].ToString().Trim()); //下载数
objvzx_TextCountEN.CollectionCount = objRow[convzx_TextCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_TextCountEN.VoteCount = objRow[convzx_TextCount.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VoteCount].ToString().Trim()); //点赞计数
objvzx_TextCountEN.VCount = objRow[convzx_TextCount.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VCount].ToString().Trim()); //VCount
objvzx_TextCountEN.BrowseNumber = objRow[convzx_TextCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.BrowseNumber].ToString().Trim()); //浏览量
objvzx_TextCountEN.TextTitle = objRow[convzx_TextCount.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextCountEN.TextContent = objRow[convzx_TextCount.TextContent] == DBNull.Value ? null : objRow[convzx_TextCount.TextContent].ToString().Trim(); //TextContent
objvzx_TextCountEN.UpdDate = objRow[convzx_TextCount.UpdDate] == DBNull.Value ? null : objRow[convzx_TextCount.UpdDate].ToString().Trim(); //修改日期
objvzx_TextCountEN.UpdUser = objRow[convzx_TextCount.UpdUser] == DBNull.Value ? null : objRow[convzx_TextCount.UpdUser].ToString().Trim(); //修改人
objvzx_TextCountEN.CreateDate = objRow[convzx_TextCount.CreateDate] == DBNull.Value ? null : objRow[convzx_TextCount.CreateDate].ToString().Trim(); //建立日期
objvzx_TextCountEN.IdCurrEduCls = objRow[convzx_TextCount.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextCountEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextCountEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_TextCount(ref clsvzx_TextCountEN objvzx_TextCountEN)
{
bool bolResult = vzx_TextCountDA.Getvzx_TextCount(ref objvzx_TextCountEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTextId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_TextCountEN GetObjByTextId(string strTextId)
{
if (strTextId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTextId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTextId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTextId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_TextCountEN objvzx_TextCountEN = vzx_TextCountDA.GetObjByTextId(strTextId);
return objvzx_TextCountEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_TextCountEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_TextCountEN objvzx_TextCountEN = vzx_TextCountDA.GetFirstObj(strWhereCond);
 return objvzx_TextCountEN;
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
public static clsvzx_TextCountEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_TextCountEN objvzx_TextCountEN = vzx_TextCountDA.GetObjByDataRow(objRow);
 return objvzx_TextCountEN;
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
public static clsvzx_TextCountEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_TextCountEN objvzx_TextCountEN = vzx_TextCountDA.GetObjByDataRow(objRow);
 return objvzx_TextCountEN;
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
 /// <param name = "strTextId">所给的关键字</param>
 /// <param name = "lstvzx_TextCountObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_TextCountEN GetObjByTextIdFromList(string strTextId, List<clsvzx_TextCountEN> lstvzx_TextCountObjLst)
{
foreach (clsvzx_TextCountEN objvzx_TextCountEN in lstvzx_TextCountObjLst)
{
if (objvzx_TextCountEN.TextId == strTextId)
{
return objvzx_TextCountEN;
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
 string strMaxTextId;
 try
 {
 strMaxTextId = clsvzx_TextCountDA.GetMaxStrId();
 return strMaxTextId;
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
 string strTextId;
 try
 {
 strTextId = new clsvzx_TextCountDA().GetFirstID(strWhereCond);
 return strTextId;
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
 arrList = vzx_TextCountDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_TextCountDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTextId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTextId)
{
if (string.IsNullOrEmpty(strTextId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTextId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_TextCountDA.IsExist(strTextId);
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
 bolIsExist = clsvzx_TextCountDA.IsExistTable();
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
 bolIsExist = vzx_TextCountDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_TextCountENS">源对象</param>
 /// <param name = "objvzx_TextCountENT">目标对象</param>
 public static void CopyTo(clsvzx_TextCountEN objvzx_TextCountENS, clsvzx_TextCountEN objvzx_TextCountENT)
{
try
{
objvzx_TextCountENT.TextId = objvzx_TextCountENS.TextId; //课件Id
objvzx_TextCountENT.PaperQCount = objvzx_TextCountENS.PaperQCount; //论文答疑数
objvzx_TextCountENT.TagsCount = objvzx_TextCountENS.TagsCount; //论文标注数
objvzx_TextCountENT.SubVCount = objvzx_TextCountENS.SubVCount; //论文子观点数
objvzx_TextCountENT.TeaQCount = objvzx_TextCountENS.TeaQCount; //教师提问数
objvzx_TextCountENT.TeaScore = objvzx_TextCountENS.TeaScore; //教师评分
objvzx_TextCountENT.StuScore = objvzx_TextCountENS.StuScore; //学生平均分
objvzx_TextCountENT.Score = objvzx_TextCountENS.Score; //评分
objvzx_TextCountENT.AppraiseCount = objvzx_TextCountENS.AppraiseCount; //评论数
objvzx_TextCountENT.AttachmentCount = objvzx_TextCountENS.AttachmentCount; //附件计数
objvzx_TextCountENT.DownloadCount = objvzx_TextCountENS.DownloadCount; //下载数
objvzx_TextCountENT.CollectionCount = objvzx_TextCountENS.CollectionCount; //收藏数量
objvzx_TextCountENT.VoteCount = objvzx_TextCountENS.VoteCount; //点赞计数
objvzx_TextCountENT.VCount = objvzx_TextCountENS.VCount; //VCount
objvzx_TextCountENT.BrowseNumber = objvzx_TextCountENS.BrowseNumber; //浏览量
objvzx_TextCountENT.TextTitle = objvzx_TextCountENS.TextTitle; //TextTitle
objvzx_TextCountENT.TextContent = objvzx_TextCountENS.TextContent; //TextContent
objvzx_TextCountENT.UpdDate = objvzx_TextCountENS.UpdDate; //修改日期
objvzx_TextCountENT.UpdUser = objvzx_TextCountENS.UpdUser; //修改人
objvzx_TextCountENT.CreateDate = objvzx_TextCountENS.CreateDate; //建立日期
objvzx_TextCountENT.IdCurrEduCls = objvzx_TextCountENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvzx_TextCountEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_TextCountEN objvzx_TextCountEN)
{
try
{
objvzx_TextCountEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_TextCountEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_TextCount.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.TextId = objvzx_TextCountEN.TextId; //课件Id
}
if (arrFldSet.Contains(convzx_TextCount.PaperQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.PaperQCount = objvzx_TextCountEN.PaperQCount; //论文答疑数
}
if (arrFldSet.Contains(convzx_TextCount.TagsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.TagsCount = objvzx_TextCountEN.TagsCount; //论文标注数
}
if (arrFldSet.Contains(convzx_TextCount.SubVCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.SubVCount = objvzx_TextCountEN.SubVCount; //论文子观点数
}
if (arrFldSet.Contains(convzx_TextCount.TeaQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.TeaQCount = objvzx_TextCountEN.TeaQCount; //教师提问数
}
if (arrFldSet.Contains(convzx_TextCount.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.TeaScore = objvzx_TextCountEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convzx_TextCount.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.StuScore = objvzx_TextCountEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convzx_TextCount.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.Score = objvzx_TextCountEN.Score; //评分
}
if (arrFldSet.Contains(convzx_TextCount.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.AppraiseCount = objvzx_TextCountEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convzx_TextCount.AttachmentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.AttachmentCount = objvzx_TextCountEN.AttachmentCount; //附件计数
}
if (arrFldSet.Contains(convzx_TextCount.DownloadCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.DownloadCount = objvzx_TextCountEN.DownloadCount; //下载数
}
if (arrFldSet.Contains(convzx_TextCount.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.CollectionCount = objvzx_TextCountEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convzx_TextCount.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.VoteCount = objvzx_TextCountEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(convzx_TextCount.VCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.VCount = objvzx_TextCountEN.VCount; //VCount
}
if (arrFldSet.Contains(convzx_TextCount.BrowseNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.BrowseNumber = objvzx_TextCountEN.BrowseNumber; //浏览量
}
if (arrFldSet.Contains(convzx_TextCount.TextTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.TextTitle = objvzx_TextCountEN.TextTitle; //TextTitle
}
if (arrFldSet.Contains(convzx_TextCount.TextContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.TextContent = objvzx_TextCountEN.TextContent == "[null]" ? null :  objvzx_TextCountEN.TextContent; //TextContent
}
if (arrFldSet.Contains(convzx_TextCount.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.UpdDate = objvzx_TextCountEN.UpdDate == "[null]" ? null :  objvzx_TextCountEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_TextCount.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.UpdUser = objvzx_TextCountEN.UpdUser == "[null]" ? null :  objvzx_TextCountEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_TextCount.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.CreateDate = objvzx_TextCountEN.CreateDate == "[null]" ? null :  objvzx_TextCountEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convzx_TextCount.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextCountEN.IdCurrEduCls = objvzx_TextCountEN.IdCurrEduCls == "[null]" ? null :  objvzx_TextCountEN.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvzx_TextCountEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_TextCountEN objvzx_TextCountEN)
{
try
{
if (objvzx_TextCountEN.TextContent == "[null]") objvzx_TextCountEN.TextContent = null; //TextContent
if (objvzx_TextCountEN.UpdDate == "[null]") objvzx_TextCountEN.UpdDate = null; //修改日期
if (objvzx_TextCountEN.UpdUser == "[null]") objvzx_TextCountEN.UpdUser = null; //修改人
if (objvzx_TextCountEN.CreateDate == "[null]") objvzx_TextCountEN.CreateDate = null; //建立日期
if (objvzx_TextCountEN.IdCurrEduCls == "[null]") objvzx_TextCountEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckProperty4Condition(clsvzx_TextCountEN objvzx_TextCountEN)
{
 vzx_TextCountDA.CheckProperty4Condition(objvzx_TextCountEN);
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TextId");
//if (arrvzx_TextCountObjLstCache == null)
//{
//arrvzx_TextCountObjLstCache = vzx_TextCountDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTextId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_TextCountEN GetObjByTextIdCache(string strTextId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_TextCountEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_TextCountEN> arrvzx_TextCountObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TextCountEN> arrvzx_TextCountObjLst_Sel =
arrvzx_TextCountObjLstCache
.Where(x=> x.TextId == strTextId 
);
if (arrvzx_TextCountObjLst_Sel.Count() == 0)
{
   clsvzx_TextCountEN obj = clsvzx_TextCountBL.GetObjByTextId(strTextId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTextId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvzx_TextCountObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_TextCountEN> GetAllvzx_TextCountObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvzx_TextCountEN> arrvzx_TextCountObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvzx_TextCountObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_TextCountEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_TextCountEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvzx_TextCountEN> arrvzx_TextCountObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvzx_TextCountObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvzx_TextCountEN._CurrTabName, strIdCurrEduCls);
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
public static string Func(string strInFldName, string strOutFldName, string strTextId, string strIdCurrEduCls)
{
if (strInFldName != convzx_TextCount.TextId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_TextCount.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_TextCount.AttributeName));
throw new Exception(strMsg);
}
var objvzx_TextCount = clsvzx_TextCountBL.GetObjByTextIdCache(strTextId, strIdCurrEduCls);
if (objvzx_TextCount == null) return "";
return objvzx_TextCount[strOutFldName].ToString();
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
int intRecCount = clsvzx_TextCountDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_TextCountDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_TextCountDA.GetRecCount();
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
int intRecCount = clsvzx_TextCountDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_TextCountCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_TextCountEN objvzx_TextCountCond)
{
 string strIdCurrEduCls = objvzx_TextCountCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvzx_TextCountBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvzx_TextCountEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TextCountEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_TextCount.AttributeName)
{
if (objvzx_TextCountCond.IsUpdated(strFldName) == false) continue;
if (objvzx_TextCountCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TextCountCond[strFldName].ToString());
}
else
{
if (objvzx_TextCountCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_TextCountCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TextCountCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_TextCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_TextCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_TextCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_TextCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_TextCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_TextCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_TextCountCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_TextCountCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_TextCountCond[strFldName]));
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
 List<string> arrList = clsvzx_TextCountDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_TextCountDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_TextCountDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}