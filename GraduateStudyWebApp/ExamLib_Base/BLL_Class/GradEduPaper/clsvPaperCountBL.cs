
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperCountBL
 表名:vPaperCount(01120595)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:14
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
public static class  clsvPaperCountBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperCountEN GetObj(this K_PaperId_vPaperCount myKey)
{
clsvPaperCountEN objvPaperCountEN = clsvPaperCountBL.vPaperCountDA.GetObjByPaperId(myKey.Value);
return objvPaperCountEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCountEN SetPaperId(this clsvPaperCountEN objvPaperCountEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convPaperCount.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convPaperCount.PaperId);
}
objvPaperCountEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCountEN.dicFldComparisonOp.ContainsKey(convPaperCount.PaperId) == false)
{
objvPaperCountEN.dicFldComparisonOp.Add(convPaperCount.PaperId, strComparisonOp);
}
else
{
objvPaperCountEN.dicFldComparisonOp[convPaperCount.PaperId] = strComparisonOp;
}
}
return objvPaperCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCountEN SetAppraiseCount(this clsvPaperCountEN objvPaperCountEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvPaperCountEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCountEN.dicFldComparisonOp.ContainsKey(convPaperCount.AppraiseCount) == false)
{
objvPaperCountEN.dicFldComparisonOp.Add(convPaperCount.AppraiseCount, strComparisonOp);
}
else
{
objvPaperCountEN.dicFldComparisonOp[convPaperCount.AppraiseCount] = strComparisonOp;
}
}
return objvPaperCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCountEN SetAttachmentCount(this clsvPaperCountEN objvPaperCountEN, int? intAttachmentCount, string strComparisonOp="")
	{
objvPaperCountEN.AttachmentCount = intAttachmentCount; //附件计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCountEN.dicFldComparisonOp.ContainsKey(convPaperCount.AttachmentCount) == false)
{
objvPaperCountEN.dicFldComparisonOp.Add(convPaperCount.AttachmentCount, strComparisonOp);
}
else
{
objvPaperCountEN.dicFldComparisonOp[convPaperCount.AttachmentCount] = strComparisonOp;
}
}
return objvPaperCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCountEN SetCollectionCount(this clsvPaperCountEN objvPaperCountEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvPaperCountEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCountEN.dicFldComparisonOp.ContainsKey(convPaperCount.CollectionCount) == false)
{
objvPaperCountEN.dicFldComparisonOp.Add(convPaperCount.CollectionCount, strComparisonOp);
}
else
{
objvPaperCountEN.dicFldComparisonOp[convPaperCount.CollectionCount] = strComparisonOp;
}
}
return objvPaperCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCountEN SetDownloadCount(this clsvPaperCountEN objvPaperCountEN, int? intDownloadCount, string strComparisonOp="")
	{
objvPaperCountEN.DownloadCount = intDownloadCount; //下载数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCountEN.dicFldComparisonOp.ContainsKey(convPaperCount.DownloadCount) == false)
{
objvPaperCountEN.dicFldComparisonOp.Add(convPaperCount.DownloadCount, strComparisonOp);
}
else
{
objvPaperCountEN.dicFldComparisonOp[convPaperCount.DownloadCount] = strComparisonOp;
}
}
return objvPaperCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCountEN SetOkCount(this clsvPaperCountEN objvPaperCountEN, int? intOkCount, string strComparisonOp="")
	{
objvPaperCountEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCountEN.dicFldComparisonOp.ContainsKey(convPaperCount.OkCount) == false)
{
objvPaperCountEN.dicFldComparisonOp.Add(convPaperCount.OkCount, strComparisonOp);
}
else
{
objvPaperCountEN.dicFldComparisonOp[convPaperCount.OkCount] = strComparisonOp;
}
}
return objvPaperCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCountEN SetPcount(this clsvPaperCountEN objvPaperCountEN, int? intPcount, string strComparisonOp="")
	{
objvPaperCountEN.Pcount = intPcount; //读写数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCountEN.dicFldComparisonOp.ContainsKey(convPaperCount.Pcount) == false)
{
objvPaperCountEN.dicFldComparisonOp.Add(convPaperCount.Pcount, strComparisonOp);
}
else
{
objvPaperCountEN.dicFldComparisonOp[convPaperCount.Pcount] = strComparisonOp;
}
}
return objvPaperCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCountEN SetScore(this clsvPaperCountEN objvPaperCountEN, float? fltScore, string strComparisonOp="")
	{
objvPaperCountEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCountEN.dicFldComparisonOp.ContainsKey(convPaperCount.Score) == false)
{
objvPaperCountEN.dicFldComparisonOp.Add(convPaperCount.Score, strComparisonOp);
}
else
{
objvPaperCountEN.dicFldComparisonOp[convPaperCount.Score] = strComparisonOp;
}
}
return objvPaperCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCountEN SetStuScore(this clsvPaperCountEN objvPaperCountEN, float? fltStuScore, string strComparisonOp="")
	{
objvPaperCountEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCountEN.dicFldComparisonOp.ContainsKey(convPaperCount.StuScore) == false)
{
objvPaperCountEN.dicFldComparisonOp.Add(convPaperCount.StuScore, strComparisonOp);
}
else
{
objvPaperCountEN.dicFldComparisonOp[convPaperCount.StuScore] = strComparisonOp;
}
}
return objvPaperCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCountEN SetTeaScore(this clsvPaperCountEN objvPaperCountEN, float? fltTeaScore, string strComparisonOp="")
	{
objvPaperCountEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCountEN.dicFldComparisonOp.ContainsKey(convPaperCount.TeaScore) == false)
{
objvPaperCountEN.dicFldComparisonOp.Add(convPaperCount.TeaScore, strComparisonOp);
}
else
{
objvPaperCountEN.dicFldComparisonOp[convPaperCount.TeaScore] = strComparisonOp;
}
}
return objvPaperCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCountEN SetBrowseNumber(this clsvPaperCountEN objvPaperCountEN, int? intBrowseNumber, string strComparisonOp="")
	{
objvPaperCountEN.BrowseNumber = intBrowseNumber; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCountEN.dicFldComparisonOp.ContainsKey(convPaperCount.BrowseNumber) == false)
{
objvPaperCountEN.dicFldComparisonOp.Add(convPaperCount.BrowseNumber, strComparisonOp);
}
else
{
objvPaperCountEN.dicFldComparisonOp[convPaperCount.BrowseNumber] = strComparisonOp;
}
}
return objvPaperCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCountEN SetUpdDate(this clsvPaperCountEN objvPaperCountEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPaperCount.UpdDate);
}
objvPaperCountEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCountEN.dicFldComparisonOp.ContainsKey(convPaperCount.UpdDate) == false)
{
objvPaperCountEN.dicFldComparisonOp.Add(convPaperCount.UpdDate, strComparisonOp);
}
else
{
objvPaperCountEN.dicFldComparisonOp[convPaperCount.UpdDate] = strComparisonOp;
}
}
return objvPaperCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCountEN SetPaperTitle(this clsvPaperCountEN objvPaperCountEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperTitle, convPaperCount.PaperTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convPaperCount.PaperTitle);
}
objvPaperCountEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCountEN.dicFldComparisonOp.ContainsKey(convPaperCount.PaperTitle) == false)
{
objvPaperCountEN.dicFldComparisonOp.Add(convPaperCount.PaperTitle, strComparisonOp);
}
else
{
objvPaperCountEN.dicFldComparisonOp[convPaperCount.PaperTitle] = strComparisonOp;
}
}
return objvPaperCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCountEN SetUpdUser(this clsvPaperCountEN objvPaperCountEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaperCount.UpdUser);
}
objvPaperCountEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCountEN.dicFldComparisonOp.ContainsKey(convPaperCount.UpdUser) == false)
{
objvPaperCountEN.dicFldComparisonOp.Add(convPaperCount.UpdUser, strComparisonOp);
}
else
{
objvPaperCountEN.dicFldComparisonOp[convPaperCount.UpdUser] = strComparisonOp;
}
}
return objvPaperCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCountEN SetPaperQCount(this clsvPaperCountEN objvPaperCountEN, int? intPaperQCount, string strComparisonOp="")
	{
objvPaperCountEN.PaperQCount = intPaperQCount; //论文答疑数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCountEN.dicFldComparisonOp.ContainsKey(convPaperCount.PaperQCount) == false)
{
objvPaperCountEN.dicFldComparisonOp.Add(convPaperCount.PaperQCount, strComparisonOp);
}
else
{
objvPaperCountEN.dicFldComparisonOp[convPaperCount.PaperQCount] = strComparisonOp;
}
}
return objvPaperCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCountEN SetSubVCount(this clsvPaperCountEN objvPaperCountEN, int? intSubVCount, string strComparisonOp="")
	{
objvPaperCountEN.SubVCount = intSubVCount; //论文子观点数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCountEN.dicFldComparisonOp.ContainsKey(convPaperCount.SubVCount) == false)
{
objvPaperCountEN.dicFldComparisonOp.Add(convPaperCount.SubVCount, strComparisonOp);
}
else
{
objvPaperCountEN.dicFldComparisonOp[convPaperCount.SubVCount] = strComparisonOp;
}
}
return objvPaperCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCountEN SetTagsCount(this clsvPaperCountEN objvPaperCountEN, int? intTagsCount, string strComparisonOp="")
	{
objvPaperCountEN.TagsCount = intTagsCount; //论文标注数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCountEN.dicFldComparisonOp.ContainsKey(convPaperCount.TagsCount) == false)
{
objvPaperCountEN.dicFldComparisonOp.Add(convPaperCount.TagsCount, strComparisonOp);
}
else
{
objvPaperCountEN.dicFldComparisonOp[convPaperCount.TagsCount] = strComparisonOp;
}
}
return objvPaperCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCountEN SetTeaQCount(this clsvPaperCountEN objvPaperCountEN, int? intTeaQCount, string strComparisonOp="")
	{
objvPaperCountEN.TeaQCount = intTeaQCount; //教师提问数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCountEN.dicFldComparisonOp.ContainsKey(convPaperCount.TeaQCount) == false)
{
objvPaperCountEN.dicFldComparisonOp.Add(convPaperCount.TeaQCount, strComparisonOp);
}
else
{
objvPaperCountEN.dicFldComparisonOp[convPaperCount.TeaQCount] = strComparisonOp;
}
}
return objvPaperCountEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPaperCountENS">源对象</param>
 /// <param name = "objvPaperCountENT">目标对象</param>
 public static void CopyTo(this clsvPaperCountEN objvPaperCountENS, clsvPaperCountEN objvPaperCountENT)
{
try
{
objvPaperCountENT.PaperId = objvPaperCountENS.PaperId; //论文Id
objvPaperCountENT.AppraiseCount = objvPaperCountENS.AppraiseCount; //评论数
objvPaperCountENT.AttachmentCount = objvPaperCountENS.AttachmentCount; //附件计数
objvPaperCountENT.CollectionCount = objvPaperCountENS.CollectionCount; //收藏数量
objvPaperCountENT.DownloadCount = objvPaperCountENS.DownloadCount; //下载数
objvPaperCountENT.OkCount = objvPaperCountENS.OkCount; //点赞统计
objvPaperCountENT.Pcount = objvPaperCountENS.Pcount; //读写数
objvPaperCountENT.Score = objvPaperCountENS.Score; //评分
objvPaperCountENT.StuScore = objvPaperCountENS.StuScore; //学生平均分
objvPaperCountENT.TeaScore = objvPaperCountENS.TeaScore; //教师评分
objvPaperCountENT.BrowseNumber = objvPaperCountENS.BrowseNumber; //浏览量
objvPaperCountENT.UpdDate = objvPaperCountENS.UpdDate; //修改日期
objvPaperCountENT.PaperTitle = objvPaperCountENS.PaperTitle; //论文标题
objvPaperCountENT.UpdUser = objvPaperCountENS.UpdUser; //修改人
objvPaperCountENT.PaperQCount = objvPaperCountENS.PaperQCount; //论文答疑数
objvPaperCountENT.SubVCount = objvPaperCountENS.SubVCount; //论文子观点数
objvPaperCountENT.TagsCount = objvPaperCountENS.TagsCount; //论文标注数
objvPaperCountENT.TeaQCount = objvPaperCountENS.TeaQCount; //教师提问数
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
 /// <param name = "objvPaperCountENS">源对象</param>
 /// <returns>目标对象=>clsvPaperCountEN:objvPaperCountENT</returns>
 public static clsvPaperCountEN CopyTo(this clsvPaperCountEN objvPaperCountENS)
{
try
{
 clsvPaperCountEN objvPaperCountENT = new clsvPaperCountEN()
{
PaperId = objvPaperCountENS.PaperId, //论文Id
AppraiseCount = objvPaperCountENS.AppraiseCount, //评论数
AttachmentCount = objvPaperCountENS.AttachmentCount, //附件计数
CollectionCount = objvPaperCountENS.CollectionCount, //收藏数量
DownloadCount = objvPaperCountENS.DownloadCount, //下载数
OkCount = objvPaperCountENS.OkCount, //点赞统计
Pcount = objvPaperCountENS.Pcount, //读写数
Score = objvPaperCountENS.Score, //评分
StuScore = objvPaperCountENS.StuScore, //学生平均分
TeaScore = objvPaperCountENS.TeaScore, //教师评分
BrowseNumber = objvPaperCountENS.BrowseNumber, //浏览量
UpdDate = objvPaperCountENS.UpdDate, //修改日期
PaperTitle = objvPaperCountENS.PaperTitle, //论文标题
UpdUser = objvPaperCountENS.UpdUser, //修改人
PaperQCount = objvPaperCountENS.PaperQCount, //论文答疑数
SubVCount = objvPaperCountENS.SubVCount, //论文子观点数
TagsCount = objvPaperCountENS.TagsCount, //论文标注数
TeaQCount = objvPaperCountENS.TeaQCount, //教师提问数
};
 return objvPaperCountENT;
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
public static void CheckProperty4Condition(this clsvPaperCountEN objvPaperCountEN)
{
 clsvPaperCountBL.vPaperCountDA.CheckProperty4Condition(objvPaperCountEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperCountEN objvPaperCountCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperCountCond.IsUpdated(convPaperCount.PaperId) == true)
{
string strComparisonOpPaperId = objvPaperCountCond.dicFldComparisonOp[convPaperCount.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperCount.PaperId, objvPaperCountCond.PaperId, strComparisonOpPaperId);
}
if (objvPaperCountCond.IsUpdated(convPaperCount.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvPaperCountCond.dicFldComparisonOp[convPaperCount.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount.AppraiseCount, objvPaperCountCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvPaperCountCond.IsUpdated(convPaperCount.AttachmentCount) == true)
{
string strComparisonOpAttachmentCount = objvPaperCountCond.dicFldComparisonOp[convPaperCount.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount.AttachmentCount, objvPaperCountCond.AttachmentCount, strComparisonOpAttachmentCount);
}
if (objvPaperCountCond.IsUpdated(convPaperCount.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvPaperCountCond.dicFldComparisonOp[convPaperCount.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount.CollectionCount, objvPaperCountCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvPaperCountCond.IsUpdated(convPaperCount.DownloadCount) == true)
{
string strComparisonOpDownloadCount = objvPaperCountCond.dicFldComparisonOp[convPaperCount.DownloadCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount.DownloadCount, objvPaperCountCond.DownloadCount, strComparisonOpDownloadCount);
}
if (objvPaperCountCond.IsUpdated(convPaperCount.OkCount) == true)
{
string strComparisonOpOkCount = objvPaperCountCond.dicFldComparisonOp[convPaperCount.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount.OkCount, objvPaperCountCond.OkCount, strComparisonOpOkCount);
}
if (objvPaperCountCond.IsUpdated(convPaperCount.Pcount) == true)
{
string strComparisonOpPcount = objvPaperCountCond.dicFldComparisonOp[convPaperCount.Pcount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount.Pcount, objvPaperCountCond.Pcount, strComparisonOpPcount);
}
if (objvPaperCountCond.IsUpdated(convPaperCount.Score) == true)
{
string strComparisonOpScore = objvPaperCountCond.dicFldComparisonOp[convPaperCount.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount.Score, objvPaperCountCond.Score, strComparisonOpScore);
}
if (objvPaperCountCond.IsUpdated(convPaperCount.StuScore) == true)
{
string strComparisonOpStuScore = objvPaperCountCond.dicFldComparisonOp[convPaperCount.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount.StuScore, objvPaperCountCond.StuScore, strComparisonOpStuScore);
}
if (objvPaperCountCond.IsUpdated(convPaperCount.TeaScore) == true)
{
string strComparisonOpTeaScore = objvPaperCountCond.dicFldComparisonOp[convPaperCount.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount.TeaScore, objvPaperCountCond.TeaScore, strComparisonOpTeaScore);
}
if (objvPaperCountCond.IsUpdated(convPaperCount.BrowseNumber) == true)
{
string strComparisonOpBrowseNumber = objvPaperCountCond.dicFldComparisonOp[convPaperCount.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount.BrowseNumber, objvPaperCountCond.BrowseNumber, strComparisonOpBrowseNumber);
}
if (objvPaperCountCond.IsUpdated(convPaperCount.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPaperCountCond.dicFldComparisonOp[convPaperCount.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperCount.UpdDate, objvPaperCountCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPaperCountCond.IsUpdated(convPaperCount.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvPaperCountCond.dicFldComparisonOp[convPaperCount.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperCount.PaperTitle, objvPaperCountCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvPaperCountCond.IsUpdated(convPaperCount.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPaperCountCond.dicFldComparisonOp[convPaperCount.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperCount.UpdUser, objvPaperCountCond.UpdUser, strComparisonOpUpdUser);
}
if (objvPaperCountCond.IsUpdated(convPaperCount.PaperQCount) == true)
{
string strComparisonOpPaperQCount = objvPaperCountCond.dicFldComparisonOp[convPaperCount.PaperQCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount.PaperQCount, objvPaperCountCond.PaperQCount, strComparisonOpPaperQCount);
}
if (objvPaperCountCond.IsUpdated(convPaperCount.SubVCount) == true)
{
string strComparisonOpSubVCount = objvPaperCountCond.dicFldComparisonOp[convPaperCount.SubVCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount.SubVCount, objvPaperCountCond.SubVCount, strComparisonOpSubVCount);
}
if (objvPaperCountCond.IsUpdated(convPaperCount.TagsCount) == true)
{
string strComparisonOpTagsCount = objvPaperCountCond.dicFldComparisonOp[convPaperCount.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount.TagsCount, objvPaperCountCond.TagsCount, strComparisonOpTagsCount);
}
if (objvPaperCountCond.IsUpdated(convPaperCount.TeaQCount) == true)
{
string strComparisonOpTeaQCount = objvPaperCountCond.dicFldComparisonOp[convPaperCount.TeaQCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount.TeaQCount, objvPaperCountCond.TeaQCount, strComparisonOpTeaQCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPaperCount
{
public virtual bool UpdRelaTabDate(string strPaperId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vPaperCount(vPaperCount)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPaperCountBL
{
public static RelatedActions_vPaperCount relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPaperCountDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPaperCountDA vPaperCountDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPaperCountDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPaperCountBL()
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
if (string.IsNullOrEmpty(clsvPaperCountEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperCountEN._ConnectString);
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
public static DataTable GetDataTable_vPaperCount(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPaperCountDA.GetDataTable_vPaperCount(strWhereCond);
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
objDT = vPaperCountDA.GetDataTable(strWhereCond);
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
objDT = vPaperCountDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPaperCountDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPaperCountDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPaperCountDA.GetDataTable_Top(objTopPara);
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
objDT = vPaperCountDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPaperCountDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPaperCountDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPaperCountEN> GetObjLstByPaperIdLst(List<string> arrPaperIdLst)
{
List<clsvPaperCountEN> arrObjLst = new List<clsvPaperCountEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperIdLst, true);
 string strWhereCond = string.Format("PaperId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCountEN objvPaperCountEN = new clsvPaperCountEN();
try
{
objvPaperCountEN.PaperId = objRow[convPaperCount.PaperId].ToString().Trim(); //论文Id
objvPaperCountEN.AppraiseCount = objRow[convPaperCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AppraiseCount].ToString().Trim()); //评论数
objvPaperCountEN.AttachmentCount = objRow[convPaperCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCountEN.CollectionCount = objRow[convPaperCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCountEN.DownloadCount = objRow[convPaperCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.DownloadCount].ToString().Trim()); //下载数
objvPaperCountEN.OkCount = objRow[convPaperCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.OkCount].ToString().Trim()); //点赞统计
objvPaperCountEN.Pcount = objRow[convPaperCount.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.Pcount].ToString().Trim()); //读写数
objvPaperCountEN.Score = objRow[convPaperCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.Score].ToString().Trim()); //评分
objvPaperCountEN.StuScore = objRow[convPaperCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.StuScore].ToString().Trim()); //学生平均分
objvPaperCountEN.TeaScore = objRow[convPaperCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.TeaScore].ToString().Trim()); //教师评分
objvPaperCountEN.BrowseNumber = objRow[convPaperCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.BrowseNumber].ToString().Trim()); //浏览量
objvPaperCountEN.UpdDate = objRow[convPaperCount.UpdDate] == DBNull.Value ? null : objRow[convPaperCount.UpdDate].ToString().Trim(); //修改日期
objvPaperCountEN.PaperTitle = objRow[convPaperCount.PaperTitle].ToString().Trim(); //论文标题
objvPaperCountEN.UpdUser = objRow[convPaperCount.UpdUser] == DBNull.Value ? null : objRow[convPaperCount.UpdUser].ToString().Trim(); //修改人
objvPaperCountEN.PaperQCount = objRow[convPaperCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperCountEN.SubVCount = objRow[convPaperCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.SubVCount].ToString().Trim()); //论文子观点数
objvPaperCountEN.TagsCount = objRow[convPaperCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TagsCount].ToString().Trim()); //论文标注数
objvPaperCountEN.TeaQCount = objRow[convPaperCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCountEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPaperCountEN> GetObjLstByPaperIdLstCache(List<string> arrPaperIdLst)
{
string strKey = string.Format("{0}", clsvPaperCountEN._CurrTabName);
List<clsvPaperCountEN> arrvPaperCountObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperCountEN> arrvPaperCountObjLst_Sel =
arrvPaperCountObjLstCache
.Where(x => arrPaperIdLst.Contains(x.PaperId));
return arrvPaperCountObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperCountEN> GetObjLst(string strWhereCond)
{
List<clsvPaperCountEN> arrObjLst = new List<clsvPaperCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCountEN objvPaperCountEN = new clsvPaperCountEN();
try
{
objvPaperCountEN.PaperId = objRow[convPaperCount.PaperId].ToString().Trim(); //论文Id
objvPaperCountEN.AppraiseCount = objRow[convPaperCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AppraiseCount].ToString().Trim()); //评论数
objvPaperCountEN.AttachmentCount = objRow[convPaperCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCountEN.CollectionCount = objRow[convPaperCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCountEN.DownloadCount = objRow[convPaperCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.DownloadCount].ToString().Trim()); //下载数
objvPaperCountEN.OkCount = objRow[convPaperCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.OkCount].ToString().Trim()); //点赞统计
objvPaperCountEN.Pcount = objRow[convPaperCount.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.Pcount].ToString().Trim()); //读写数
objvPaperCountEN.Score = objRow[convPaperCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.Score].ToString().Trim()); //评分
objvPaperCountEN.StuScore = objRow[convPaperCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.StuScore].ToString().Trim()); //学生平均分
objvPaperCountEN.TeaScore = objRow[convPaperCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.TeaScore].ToString().Trim()); //教师评分
objvPaperCountEN.BrowseNumber = objRow[convPaperCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.BrowseNumber].ToString().Trim()); //浏览量
objvPaperCountEN.UpdDate = objRow[convPaperCount.UpdDate] == DBNull.Value ? null : objRow[convPaperCount.UpdDate].ToString().Trim(); //修改日期
objvPaperCountEN.PaperTitle = objRow[convPaperCount.PaperTitle].ToString().Trim(); //论文标题
objvPaperCountEN.UpdUser = objRow[convPaperCount.UpdUser] == DBNull.Value ? null : objRow[convPaperCount.UpdUser].ToString().Trim(); //修改人
objvPaperCountEN.PaperQCount = objRow[convPaperCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperCountEN.SubVCount = objRow[convPaperCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.SubVCount].ToString().Trim()); //论文子观点数
objvPaperCountEN.TagsCount = objRow[convPaperCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TagsCount].ToString().Trim()); //论文标注数
objvPaperCountEN.TeaQCount = objRow[convPaperCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCountEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCountEN);
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
public static List<clsvPaperCountEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPaperCountEN> arrObjLst = new List<clsvPaperCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCountEN objvPaperCountEN = new clsvPaperCountEN();
try
{
objvPaperCountEN.PaperId = objRow[convPaperCount.PaperId].ToString().Trim(); //论文Id
objvPaperCountEN.AppraiseCount = objRow[convPaperCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AppraiseCount].ToString().Trim()); //评论数
objvPaperCountEN.AttachmentCount = objRow[convPaperCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCountEN.CollectionCount = objRow[convPaperCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCountEN.DownloadCount = objRow[convPaperCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.DownloadCount].ToString().Trim()); //下载数
objvPaperCountEN.OkCount = objRow[convPaperCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.OkCount].ToString().Trim()); //点赞统计
objvPaperCountEN.Pcount = objRow[convPaperCount.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.Pcount].ToString().Trim()); //读写数
objvPaperCountEN.Score = objRow[convPaperCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.Score].ToString().Trim()); //评分
objvPaperCountEN.StuScore = objRow[convPaperCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.StuScore].ToString().Trim()); //学生平均分
objvPaperCountEN.TeaScore = objRow[convPaperCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.TeaScore].ToString().Trim()); //教师评分
objvPaperCountEN.BrowseNumber = objRow[convPaperCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.BrowseNumber].ToString().Trim()); //浏览量
objvPaperCountEN.UpdDate = objRow[convPaperCount.UpdDate] == DBNull.Value ? null : objRow[convPaperCount.UpdDate].ToString().Trim(); //修改日期
objvPaperCountEN.PaperTitle = objRow[convPaperCount.PaperTitle].ToString().Trim(); //论文标题
objvPaperCountEN.UpdUser = objRow[convPaperCount.UpdUser] == DBNull.Value ? null : objRow[convPaperCount.UpdUser].ToString().Trim(); //修改人
objvPaperCountEN.PaperQCount = objRow[convPaperCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperCountEN.SubVCount = objRow[convPaperCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.SubVCount].ToString().Trim()); //论文子观点数
objvPaperCountEN.TagsCount = objRow[convPaperCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TagsCount].ToString().Trim()); //论文标注数
objvPaperCountEN.TeaQCount = objRow[convPaperCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCountEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPaperCountCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPaperCountEN> GetSubObjLstCache(clsvPaperCountEN objvPaperCountCond)
{
List<clsvPaperCountEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperCountEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperCount.AttributeName)
{
if (objvPaperCountCond.IsUpdated(strFldName) == false) continue;
if (objvPaperCountCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperCountCond[strFldName].ToString());
}
else
{
if (objvPaperCountCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperCountCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperCountCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperCountCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperCountCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperCountCond[strFldName]));
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
public static List<clsvPaperCountEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPaperCountEN> arrObjLst = new List<clsvPaperCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCountEN objvPaperCountEN = new clsvPaperCountEN();
try
{
objvPaperCountEN.PaperId = objRow[convPaperCount.PaperId].ToString().Trim(); //论文Id
objvPaperCountEN.AppraiseCount = objRow[convPaperCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AppraiseCount].ToString().Trim()); //评论数
objvPaperCountEN.AttachmentCount = objRow[convPaperCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCountEN.CollectionCount = objRow[convPaperCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCountEN.DownloadCount = objRow[convPaperCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.DownloadCount].ToString().Trim()); //下载数
objvPaperCountEN.OkCount = objRow[convPaperCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.OkCount].ToString().Trim()); //点赞统计
objvPaperCountEN.Pcount = objRow[convPaperCount.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.Pcount].ToString().Trim()); //读写数
objvPaperCountEN.Score = objRow[convPaperCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.Score].ToString().Trim()); //评分
objvPaperCountEN.StuScore = objRow[convPaperCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.StuScore].ToString().Trim()); //学生平均分
objvPaperCountEN.TeaScore = objRow[convPaperCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.TeaScore].ToString().Trim()); //教师评分
objvPaperCountEN.BrowseNumber = objRow[convPaperCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.BrowseNumber].ToString().Trim()); //浏览量
objvPaperCountEN.UpdDate = objRow[convPaperCount.UpdDate] == DBNull.Value ? null : objRow[convPaperCount.UpdDate].ToString().Trim(); //修改日期
objvPaperCountEN.PaperTitle = objRow[convPaperCount.PaperTitle].ToString().Trim(); //论文标题
objvPaperCountEN.UpdUser = objRow[convPaperCount.UpdUser] == DBNull.Value ? null : objRow[convPaperCount.UpdUser].ToString().Trim(); //修改人
objvPaperCountEN.PaperQCount = objRow[convPaperCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperCountEN.SubVCount = objRow[convPaperCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.SubVCount].ToString().Trim()); //论文子观点数
objvPaperCountEN.TagsCount = objRow[convPaperCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TagsCount].ToString().Trim()); //论文标注数
objvPaperCountEN.TeaQCount = objRow[convPaperCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCountEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCountEN);
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
public static List<clsvPaperCountEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPaperCountEN> arrObjLst = new List<clsvPaperCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCountEN objvPaperCountEN = new clsvPaperCountEN();
try
{
objvPaperCountEN.PaperId = objRow[convPaperCount.PaperId].ToString().Trim(); //论文Id
objvPaperCountEN.AppraiseCount = objRow[convPaperCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AppraiseCount].ToString().Trim()); //评论数
objvPaperCountEN.AttachmentCount = objRow[convPaperCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCountEN.CollectionCount = objRow[convPaperCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCountEN.DownloadCount = objRow[convPaperCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.DownloadCount].ToString().Trim()); //下载数
objvPaperCountEN.OkCount = objRow[convPaperCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.OkCount].ToString().Trim()); //点赞统计
objvPaperCountEN.Pcount = objRow[convPaperCount.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.Pcount].ToString().Trim()); //读写数
objvPaperCountEN.Score = objRow[convPaperCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.Score].ToString().Trim()); //评分
objvPaperCountEN.StuScore = objRow[convPaperCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.StuScore].ToString().Trim()); //学生平均分
objvPaperCountEN.TeaScore = objRow[convPaperCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.TeaScore].ToString().Trim()); //教师评分
objvPaperCountEN.BrowseNumber = objRow[convPaperCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.BrowseNumber].ToString().Trim()); //浏览量
objvPaperCountEN.UpdDate = objRow[convPaperCount.UpdDate] == DBNull.Value ? null : objRow[convPaperCount.UpdDate].ToString().Trim(); //修改日期
objvPaperCountEN.PaperTitle = objRow[convPaperCount.PaperTitle].ToString().Trim(); //论文标题
objvPaperCountEN.UpdUser = objRow[convPaperCount.UpdUser] == DBNull.Value ? null : objRow[convPaperCount.UpdUser].ToString().Trim(); //修改人
objvPaperCountEN.PaperQCount = objRow[convPaperCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperCountEN.SubVCount = objRow[convPaperCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.SubVCount].ToString().Trim()); //论文子观点数
objvPaperCountEN.TagsCount = objRow[convPaperCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TagsCount].ToString().Trim()); //论文标注数
objvPaperCountEN.TeaQCount = objRow[convPaperCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCountEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCountEN);
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
List<clsvPaperCountEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPaperCountEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperCountEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPaperCountEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperCountEN> arrObjLst = new List<clsvPaperCountEN>(); 
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
	clsvPaperCountEN objvPaperCountEN = new clsvPaperCountEN();
try
{
objvPaperCountEN.PaperId = objRow[convPaperCount.PaperId].ToString().Trim(); //论文Id
objvPaperCountEN.AppraiseCount = objRow[convPaperCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AppraiseCount].ToString().Trim()); //评论数
objvPaperCountEN.AttachmentCount = objRow[convPaperCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCountEN.CollectionCount = objRow[convPaperCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCountEN.DownloadCount = objRow[convPaperCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.DownloadCount].ToString().Trim()); //下载数
objvPaperCountEN.OkCount = objRow[convPaperCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.OkCount].ToString().Trim()); //点赞统计
objvPaperCountEN.Pcount = objRow[convPaperCount.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.Pcount].ToString().Trim()); //读写数
objvPaperCountEN.Score = objRow[convPaperCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.Score].ToString().Trim()); //评分
objvPaperCountEN.StuScore = objRow[convPaperCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.StuScore].ToString().Trim()); //学生平均分
objvPaperCountEN.TeaScore = objRow[convPaperCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.TeaScore].ToString().Trim()); //教师评分
objvPaperCountEN.BrowseNumber = objRow[convPaperCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.BrowseNumber].ToString().Trim()); //浏览量
objvPaperCountEN.UpdDate = objRow[convPaperCount.UpdDate] == DBNull.Value ? null : objRow[convPaperCount.UpdDate].ToString().Trim(); //修改日期
objvPaperCountEN.PaperTitle = objRow[convPaperCount.PaperTitle].ToString().Trim(); //论文标题
objvPaperCountEN.UpdUser = objRow[convPaperCount.UpdUser] == DBNull.Value ? null : objRow[convPaperCount.UpdUser].ToString().Trim(); //修改人
objvPaperCountEN.PaperQCount = objRow[convPaperCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperCountEN.SubVCount = objRow[convPaperCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.SubVCount].ToString().Trim()); //论文子观点数
objvPaperCountEN.TagsCount = objRow[convPaperCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TagsCount].ToString().Trim()); //论文标注数
objvPaperCountEN.TeaQCount = objRow[convPaperCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCountEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCountEN);
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
public static List<clsvPaperCountEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPaperCountEN> arrObjLst = new List<clsvPaperCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCountEN objvPaperCountEN = new clsvPaperCountEN();
try
{
objvPaperCountEN.PaperId = objRow[convPaperCount.PaperId].ToString().Trim(); //论文Id
objvPaperCountEN.AppraiseCount = objRow[convPaperCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AppraiseCount].ToString().Trim()); //评论数
objvPaperCountEN.AttachmentCount = objRow[convPaperCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCountEN.CollectionCount = objRow[convPaperCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCountEN.DownloadCount = objRow[convPaperCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.DownloadCount].ToString().Trim()); //下载数
objvPaperCountEN.OkCount = objRow[convPaperCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.OkCount].ToString().Trim()); //点赞统计
objvPaperCountEN.Pcount = objRow[convPaperCount.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.Pcount].ToString().Trim()); //读写数
objvPaperCountEN.Score = objRow[convPaperCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.Score].ToString().Trim()); //评分
objvPaperCountEN.StuScore = objRow[convPaperCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.StuScore].ToString().Trim()); //学生平均分
objvPaperCountEN.TeaScore = objRow[convPaperCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.TeaScore].ToString().Trim()); //教师评分
objvPaperCountEN.BrowseNumber = objRow[convPaperCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.BrowseNumber].ToString().Trim()); //浏览量
objvPaperCountEN.UpdDate = objRow[convPaperCount.UpdDate] == DBNull.Value ? null : objRow[convPaperCount.UpdDate].ToString().Trim(); //修改日期
objvPaperCountEN.PaperTitle = objRow[convPaperCount.PaperTitle].ToString().Trim(); //论文标题
objvPaperCountEN.UpdUser = objRow[convPaperCount.UpdUser] == DBNull.Value ? null : objRow[convPaperCount.UpdUser].ToString().Trim(); //修改人
objvPaperCountEN.PaperQCount = objRow[convPaperCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperCountEN.SubVCount = objRow[convPaperCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.SubVCount].ToString().Trim()); //论文子观点数
objvPaperCountEN.TagsCount = objRow[convPaperCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TagsCount].ToString().Trim()); //论文标注数
objvPaperCountEN.TeaQCount = objRow[convPaperCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCountEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPaperCountEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPaperCountEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperCountEN> arrObjLst = new List<clsvPaperCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCountEN objvPaperCountEN = new clsvPaperCountEN();
try
{
objvPaperCountEN.PaperId = objRow[convPaperCount.PaperId].ToString().Trim(); //论文Id
objvPaperCountEN.AppraiseCount = objRow[convPaperCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AppraiseCount].ToString().Trim()); //评论数
objvPaperCountEN.AttachmentCount = objRow[convPaperCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCountEN.CollectionCount = objRow[convPaperCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCountEN.DownloadCount = objRow[convPaperCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.DownloadCount].ToString().Trim()); //下载数
objvPaperCountEN.OkCount = objRow[convPaperCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.OkCount].ToString().Trim()); //点赞统计
objvPaperCountEN.Pcount = objRow[convPaperCount.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.Pcount].ToString().Trim()); //读写数
objvPaperCountEN.Score = objRow[convPaperCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.Score].ToString().Trim()); //评分
objvPaperCountEN.StuScore = objRow[convPaperCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.StuScore].ToString().Trim()); //学生平均分
objvPaperCountEN.TeaScore = objRow[convPaperCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.TeaScore].ToString().Trim()); //教师评分
objvPaperCountEN.BrowseNumber = objRow[convPaperCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.BrowseNumber].ToString().Trim()); //浏览量
objvPaperCountEN.UpdDate = objRow[convPaperCount.UpdDate] == DBNull.Value ? null : objRow[convPaperCount.UpdDate].ToString().Trim(); //修改日期
objvPaperCountEN.PaperTitle = objRow[convPaperCount.PaperTitle].ToString().Trim(); //论文标题
objvPaperCountEN.UpdUser = objRow[convPaperCount.UpdUser] == DBNull.Value ? null : objRow[convPaperCount.UpdUser].ToString().Trim(); //修改人
objvPaperCountEN.PaperQCount = objRow[convPaperCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperCountEN.SubVCount = objRow[convPaperCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.SubVCount].ToString().Trim()); //论文子观点数
objvPaperCountEN.TagsCount = objRow[convPaperCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TagsCount].ToString().Trim()); //论文标注数
objvPaperCountEN.TeaQCount = objRow[convPaperCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCountEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCountEN);
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
public static List<clsvPaperCountEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPaperCountEN> arrObjLst = new List<clsvPaperCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCountEN objvPaperCountEN = new clsvPaperCountEN();
try
{
objvPaperCountEN.PaperId = objRow[convPaperCount.PaperId].ToString().Trim(); //论文Id
objvPaperCountEN.AppraiseCount = objRow[convPaperCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AppraiseCount].ToString().Trim()); //评论数
objvPaperCountEN.AttachmentCount = objRow[convPaperCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCountEN.CollectionCount = objRow[convPaperCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCountEN.DownloadCount = objRow[convPaperCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.DownloadCount].ToString().Trim()); //下载数
objvPaperCountEN.OkCount = objRow[convPaperCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.OkCount].ToString().Trim()); //点赞统计
objvPaperCountEN.Pcount = objRow[convPaperCount.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.Pcount].ToString().Trim()); //读写数
objvPaperCountEN.Score = objRow[convPaperCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.Score].ToString().Trim()); //评分
objvPaperCountEN.StuScore = objRow[convPaperCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.StuScore].ToString().Trim()); //学生平均分
objvPaperCountEN.TeaScore = objRow[convPaperCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.TeaScore].ToString().Trim()); //教师评分
objvPaperCountEN.BrowseNumber = objRow[convPaperCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.BrowseNumber].ToString().Trim()); //浏览量
objvPaperCountEN.UpdDate = objRow[convPaperCount.UpdDate] == DBNull.Value ? null : objRow[convPaperCount.UpdDate].ToString().Trim(); //修改日期
objvPaperCountEN.PaperTitle = objRow[convPaperCount.PaperTitle].ToString().Trim(); //论文标题
objvPaperCountEN.UpdUser = objRow[convPaperCount.UpdUser] == DBNull.Value ? null : objRow[convPaperCount.UpdUser].ToString().Trim(); //修改人
objvPaperCountEN.PaperQCount = objRow[convPaperCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperCountEN.SubVCount = objRow[convPaperCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.SubVCount].ToString().Trim()); //论文子观点数
objvPaperCountEN.TagsCount = objRow[convPaperCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TagsCount].ToString().Trim()); //论文标注数
objvPaperCountEN.TeaQCount = objRow[convPaperCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCountEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperCountEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPaperCountEN> arrObjLst = new List<clsvPaperCountEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCountEN objvPaperCountEN = new clsvPaperCountEN();
try
{
objvPaperCountEN.PaperId = objRow[convPaperCount.PaperId].ToString().Trim(); //论文Id
objvPaperCountEN.AppraiseCount = objRow[convPaperCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AppraiseCount].ToString().Trim()); //评论数
objvPaperCountEN.AttachmentCount = objRow[convPaperCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCountEN.CollectionCount = objRow[convPaperCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCountEN.DownloadCount = objRow[convPaperCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.DownloadCount].ToString().Trim()); //下载数
objvPaperCountEN.OkCount = objRow[convPaperCount.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.OkCount].ToString().Trim()); //点赞统计
objvPaperCountEN.Pcount = objRow[convPaperCount.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.Pcount].ToString().Trim()); //读写数
objvPaperCountEN.Score = objRow[convPaperCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.Score].ToString().Trim()); //评分
objvPaperCountEN.StuScore = objRow[convPaperCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.StuScore].ToString().Trim()); //学生平均分
objvPaperCountEN.TeaScore = objRow[convPaperCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount.TeaScore].ToString().Trim()); //教师评分
objvPaperCountEN.BrowseNumber = objRow[convPaperCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.BrowseNumber].ToString().Trim()); //浏览量
objvPaperCountEN.UpdDate = objRow[convPaperCount.UpdDate] == DBNull.Value ? null : objRow[convPaperCount.UpdDate].ToString().Trim(); //修改日期
objvPaperCountEN.PaperTitle = objRow[convPaperCount.PaperTitle].ToString().Trim(); //论文标题
objvPaperCountEN.UpdUser = objRow[convPaperCount.UpdUser] == DBNull.Value ? null : objRow[convPaperCount.UpdUser].ToString().Trim(); //修改人
objvPaperCountEN.PaperQCount = objRow[convPaperCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperCountEN.SubVCount = objRow[convPaperCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.SubVCount].ToString().Trim()); //论文子观点数
objvPaperCountEN.TagsCount = objRow[convPaperCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TagsCount].ToString().Trim()); //论文标注数
objvPaperCountEN.TeaQCount = objRow[convPaperCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCountEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCountEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPaperCountEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPaperCount(ref clsvPaperCountEN objvPaperCountEN)
{
bool bolResult = vPaperCountDA.GetvPaperCount(ref objvPaperCountEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperCountEN GetObjByPaperId(string strPaperId)
{
if (strPaperId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPaperId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPaperId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvPaperCountEN objvPaperCountEN = vPaperCountDA.GetObjByPaperId(strPaperId);
return objvPaperCountEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPaperCountEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPaperCountEN objvPaperCountEN = vPaperCountDA.GetFirstObj(strWhereCond);
 return objvPaperCountEN;
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
public static clsvPaperCountEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPaperCountEN objvPaperCountEN = vPaperCountDA.GetObjByDataRow(objRow);
 return objvPaperCountEN;
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
public static clsvPaperCountEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPaperCountEN objvPaperCountEN = vPaperCountDA.GetObjByDataRow(objRow);
 return objvPaperCountEN;
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
 /// <param name = "strPaperId">所给的关键字</param>
 /// <param name = "lstvPaperCountObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperCountEN GetObjByPaperIdFromList(string strPaperId, List<clsvPaperCountEN> lstvPaperCountObjLst)
{
foreach (clsvPaperCountEN objvPaperCountEN in lstvPaperCountObjLst)
{
if (objvPaperCountEN.PaperId == strPaperId)
{
return objvPaperCountEN;
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
 string strPaperId;
 try
 {
 strPaperId = new clsvPaperCountDA().GetFirstID(strWhereCond);
 return strPaperId;
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
 arrList = vPaperCountDA.GetID(strWhereCond);
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
bool bolIsExist = vPaperCountDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPaperId)
{
if (string.IsNullOrEmpty(strPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPaperId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vPaperCountDA.IsExist(strPaperId);
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
 bolIsExist = clsvPaperCountDA.IsExistTable();
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
 bolIsExist = vPaperCountDA.IsExistTable(strTabName);
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
 /// <param name = "objvPaperCountENS">源对象</param>
 /// <param name = "objvPaperCountENT">目标对象</param>
 public static void CopyTo(clsvPaperCountEN objvPaperCountENS, clsvPaperCountEN objvPaperCountENT)
{
try
{
objvPaperCountENT.PaperId = objvPaperCountENS.PaperId; //论文Id
objvPaperCountENT.AppraiseCount = objvPaperCountENS.AppraiseCount; //评论数
objvPaperCountENT.AttachmentCount = objvPaperCountENS.AttachmentCount; //附件计数
objvPaperCountENT.CollectionCount = objvPaperCountENS.CollectionCount; //收藏数量
objvPaperCountENT.DownloadCount = objvPaperCountENS.DownloadCount; //下载数
objvPaperCountENT.OkCount = objvPaperCountENS.OkCount; //点赞统计
objvPaperCountENT.Pcount = objvPaperCountENS.Pcount; //读写数
objvPaperCountENT.Score = objvPaperCountENS.Score; //评分
objvPaperCountENT.StuScore = objvPaperCountENS.StuScore; //学生平均分
objvPaperCountENT.TeaScore = objvPaperCountENS.TeaScore; //教师评分
objvPaperCountENT.BrowseNumber = objvPaperCountENS.BrowseNumber; //浏览量
objvPaperCountENT.UpdDate = objvPaperCountENS.UpdDate; //修改日期
objvPaperCountENT.PaperTitle = objvPaperCountENS.PaperTitle; //论文标题
objvPaperCountENT.UpdUser = objvPaperCountENS.UpdUser; //修改人
objvPaperCountENT.PaperQCount = objvPaperCountENS.PaperQCount; //论文答疑数
objvPaperCountENT.SubVCount = objvPaperCountENS.SubVCount; //论文子观点数
objvPaperCountENT.TagsCount = objvPaperCountENS.TagsCount; //论文标注数
objvPaperCountENT.TeaQCount = objvPaperCountENS.TeaQCount; //教师提问数
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
 /// <param name = "objvPaperCountEN">源简化对象</param>
 public static void SetUpdFlag(clsvPaperCountEN objvPaperCountEN)
{
try
{
objvPaperCountEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPaperCountEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPaperCount.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCountEN.PaperId = objvPaperCountEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convPaperCount.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCountEN.AppraiseCount = objvPaperCountEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convPaperCount.AttachmentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCountEN.AttachmentCount = objvPaperCountEN.AttachmentCount; //附件计数
}
if (arrFldSet.Contains(convPaperCount.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCountEN.CollectionCount = objvPaperCountEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convPaperCount.DownloadCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCountEN.DownloadCount = objvPaperCountEN.DownloadCount; //下载数
}
if (arrFldSet.Contains(convPaperCount.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCountEN.OkCount = objvPaperCountEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convPaperCount.Pcount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCountEN.Pcount = objvPaperCountEN.Pcount; //读写数
}
if (arrFldSet.Contains(convPaperCount.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCountEN.Score = objvPaperCountEN.Score; //评分
}
if (arrFldSet.Contains(convPaperCount.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCountEN.StuScore = objvPaperCountEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convPaperCount.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCountEN.TeaScore = objvPaperCountEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convPaperCount.BrowseNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCountEN.BrowseNumber = objvPaperCountEN.BrowseNumber; //浏览量
}
if (arrFldSet.Contains(convPaperCount.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCountEN.UpdDate = objvPaperCountEN.UpdDate == "[null]" ? null :  objvPaperCountEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPaperCount.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCountEN.PaperTitle = objvPaperCountEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convPaperCount.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCountEN.UpdUser = objvPaperCountEN.UpdUser == "[null]" ? null :  objvPaperCountEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convPaperCount.PaperQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCountEN.PaperQCount = objvPaperCountEN.PaperQCount; //论文答疑数
}
if (arrFldSet.Contains(convPaperCount.SubVCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCountEN.SubVCount = objvPaperCountEN.SubVCount; //论文子观点数
}
if (arrFldSet.Contains(convPaperCount.TagsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCountEN.TagsCount = objvPaperCountEN.TagsCount; //论文标注数
}
if (arrFldSet.Contains(convPaperCount.TeaQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCountEN.TeaQCount = objvPaperCountEN.TeaQCount; //教师提问数
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
 /// <param name = "objvPaperCountEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPaperCountEN objvPaperCountEN)
{
try
{
if (objvPaperCountEN.UpdDate == "[null]") objvPaperCountEN.UpdDate = null; //修改日期
if (objvPaperCountEN.UpdUser == "[null]") objvPaperCountEN.UpdUser = null; //修改人
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
public static void CheckProperty4Condition(clsvPaperCountEN objvPaperCountEN)
{
 vPaperCountDA.CheckProperty4Condition(objvPaperCountEN);
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperId");
//if (arrvPaperCountObjLstCache == null)
//{
//arrvPaperCountObjLstCache = vPaperCountDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperCountEN GetObjByPaperIdCache(string strPaperId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPaperCountEN._CurrTabName);
List<clsvPaperCountEN> arrvPaperCountObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperCountEN> arrvPaperCountObjLst_Sel =
arrvPaperCountObjLstCache
.Where(x=> x.PaperId == strPaperId 
);
if (arrvPaperCountObjLst_Sel.Count() == 0)
{
   clsvPaperCountEN obj = clsvPaperCountBL.GetObjByPaperId(strPaperId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPaperCountObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperCountEN> GetAllvPaperCountObjLstCache()
{
//获取缓存中的对象列表
List<clsvPaperCountEN> arrvPaperCountObjLstCache = GetObjLstCache(); 
return arrvPaperCountObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperCountEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPaperCountEN._CurrTabName);
List<clsvPaperCountEN> arrvPaperCountObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPaperCountObjLstCache;
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
string strKey = string.Format("{0}", clsvPaperCountEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strPaperId)
{
if (strInFldName != convPaperCount.PaperId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPaperCount.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPaperCount.AttributeName));
throw new Exception(strMsg);
}
var objvPaperCount = clsvPaperCountBL.GetObjByPaperIdCache(strPaperId);
if (objvPaperCount == null) return "";
return objvPaperCount[strOutFldName].ToString();
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
int intRecCount = clsvPaperCountDA.GetRecCount(strTabName);
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
int intRecCount = clsvPaperCountDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPaperCountDA.GetRecCount();
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
int intRecCount = clsvPaperCountDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPaperCountCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPaperCountEN objvPaperCountCond)
{
List<clsvPaperCountEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperCountEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperCount.AttributeName)
{
if (objvPaperCountCond.IsUpdated(strFldName) == false) continue;
if (objvPaperCountCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperCountCond[strFldName].ToString());
}
else
{
if (objvPaperCountCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperCountCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperCountCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperCountCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperCountCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperCountCond[strFldName]));
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
 List<string> arrList = clsvPaperCountDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPaperCountDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPaperCountDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}