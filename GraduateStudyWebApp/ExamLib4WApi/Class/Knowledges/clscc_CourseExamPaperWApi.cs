
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseExamPaperWApi
 表名:cc_CourseExamPaper(01120071)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:26
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
 框架-层名:WA_访问层_CS(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using ExamLib.Entity;

namespace ExamLib4WApi
{
public static class clscc_CourseExamPaperWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetCourseExamPaperId(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, concc_CourseExamPaper.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, concc_CourseExamPaper.CourseExamPaperId);
objcc_CourseExamPaperEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.CourseExamPaperId) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.CourseExamPaperId, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.CourseExamPaperId] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetCourseId(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_CourseExamPaper.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_CourseExamPaper.CourseId);
objcc_CourseExamPaperEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.CourseId) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.CourseId, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.CourseId] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetExamPaperName(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strExamPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, concc_CourseExamPaper.ExamPaperName);
objcc_CourseExamPaperEN.ExamPaperName = strExamPaperName; //考卷名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.ExamPaperName) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.ExamPaperName, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.ExamPaperName] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetPaperIndex(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, int intPaperIndex, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.PaperIndex = intPaperIndex; //试卷序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.PaperIndex) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.PaperIndex, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.PaperIndex] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetExamPaperTypeId(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strExamPaperTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeId, concc_CourseExamPaper.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, concc_CourseExamPaper.ExamPaperTypeId);
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, concc_CourseExamPaper.ExamPaperTypeId);
objcc_CourseExamPaperEN.ExamPaperTypeId = strExamPaperTypeId; //试卷类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.ExamPaperTypeId) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.ExamPaperTypeId, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.ExamPaperTypeId] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetIsShow(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, bool bolIsShow, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.IsShow) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.IsShow, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.IsShow] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetTotalScore(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, double dblTotalScore, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.TotalScore = dblTotalScore; //总得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.TotalScore) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.TotalScore, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.TotalScore] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetViewCount(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, int intViewCount, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.ViewCount) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.ViewCount, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.ViewCount] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetDoneNumber(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, int intDoneNumber, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.DoneNumber = intDoneNumber; //已做人数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.DoneNumber) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.DoneNumber, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.DoneNumber] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetPaperTime(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, int intPaperTime, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.PaperTime = intPaperTime; //考试时间（分钟）
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.PaperTime) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.PaperTime, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.PaperTime] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetDownloadNumber(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, int intDownloadNumber, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.DownloadNumber) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.DownloadNumber, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.DownloadNumber] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetCollectionCount(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, long lngCollectionCount, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.CollectionCount) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.CollectionCount, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.CollectionCount] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetLikeCount(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, long lngLikeCount, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.LikeCount) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.LikeCount, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.LikeCount] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN Setid_XzMajor(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, concc_CourseExamPaper.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, concc_CourseExamPaper.id_XzMajor);
objcc_CourseExamPaperEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.id_XzMajor) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.id_XzMajor, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.id_XzMajor] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetPaperDispModeId(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strPaperDispModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperDispModeId, 4, concc_CourseExamPaper.PaperDispModeId);
clsCheckSql.CheckFieldForeignKey(strPaperDispModeId, 4, concc_CourseExamPaper.PaperDispModeId);
objcc_CourseExamPaperEN.PaperDispModeId = strPaperDispModeId; //试卷显示模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.PaperDispModeId) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.PaperDispModeId, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.PaperDispModeId] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetExamCreateTime(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strExamCreateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamCreateTime, 14, concc_CourseExamPaper.ExamCreateTime);
objcc_CourseExamPaperEN.ExamCreateTime = strExamCreateTime; //考卷建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.ExamCreateTime) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.ExamCreateTime, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.ExamCreateTime] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetCreateUserID(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strCreateUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateUserID, 20, concc_CourseExamPaper.CreateUserID);
objcc_CourseExamPaperEN.CreateUserID = strCreateUserID; //建立用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.CreateUserID) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.CreateUserID, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.CreateUserID] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetIsOpenToAllStu(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, bool bolIsOpenToAllStu, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.IsOpenToAllStu = bolIsOpenToAllStu; //全校师生
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.IsOpenToAllStu) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.IsOpenToAllStu, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.IsOpenToAllStu] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetIsOpenToSchool(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, bool bolIsOpenToSchool, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.IsOpenToSchool = bolIsOpenToSchool; //全校师生公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.IsOpenToSchool) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.IsOpenToSchool, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.IsOpenToSchool] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetIsOpenToSocial(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, bool bolIsOpenToSocial, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.IsOpenToSocial = bolIsOpenToSocial; //社会公众
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.IsOpenToSocial) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.IsOpenToSocial, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.IsOpenToSocial] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetCourseChapterId(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, concc_CourseExamPaper.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, concc_CourseExamPaper.CourseChapterId);
objcc_CourseExamPaperEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.CourseChapterId) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.CourseChapterId, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.CourseChapterId] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetIsAutoGeneQuestion(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, bool bolIsAutoGeneQuestion, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.IsAutoGeneQuestion = bolIsAutoGeneQuestion; //是否自动生成题目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.IsAutoGeneQuestion) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.IsAutoGeneQuestion, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.IsAutoGeneQuestion] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetIsCanMultiDo(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, bool bolIsCanMultiDo, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.IsCanMultiDo = bolIsCanMultiDo; //是否可以做多次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.IsCanMultiDo) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.IsCanMultiDo, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.IsCanMultiDo] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetUpdDate(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_CourseExamPaper.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_CourseExamPaper.UpdDate);
objcc_CourseExamPaperEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.UpdDate) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.UpdDate, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.UpdDate] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetUpdUserId(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_CourseExamPaper.UpdUserId);
objcc_CourseExamPaperEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.UpdUserId) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.UpdUserId, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.UpdUserId] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperEN SetMemo(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_CourseExamPaper.Memo);
objcc_CourseExamPaperEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.Memo) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.Memo, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.Memo] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_CourseExamPaperEN objcc_CourseExamPaper_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.CourseExamPaperId, objcc_CourseExamPaper_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.CourseId) == true)
{
string strComparisonOp_CourseId = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.CourseId, objcc_CourseExamPaper_Cond.CourseId, strComparisonOp_CourseId);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.ExamPaperName) == true)
{
string strComparisonOp_ExamPaperName = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.ExamPaperName, objcc_CourseExamPaper_Cond.ExamPaperName, strComparisonOp_ExamPaperName);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.PaperIndex) == true)
{
string strComparisonOp_PaperIndex = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.PaperIndex];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaper.PaperIndex, objcc_CourseExamPaper_Cond.PaperIndex, strComparisonOp_PaperIndex);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.ExamPaperTypeId) == true)
{
string strComparisonOp_ExamPaperTypeId = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.ExamPaperTypeId, objcc_CourseExamPaper_Cond.ExamPaperTypeId, strComparisonOp_ExamPaperTypeId);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.IsShow) == true)
{
if (objcc_CourseExamPaper_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseExamPaper.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseExamPaper.IsShow);
}
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.TotalScore) == true)
{
string strComparisonOp_TotalScore = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaper.TotalScore, objcc_CourseExamPaper_Cond.TotalScore, strComparisonOp_TotalScore);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.ViewCount) == true)
{
string strComparisonOp_ViewCount = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaper.ViewCount, objcc_CourseExamPaper_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.DoneNumber) == true)
{
string strComparisonOp_DoneNumber = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.DoneNumber];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaper.DoneNumber, objcc_CourseExamPaper_Cond.DoneNumber, strComparisonOp_DoneNumber);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.PaperTime) == true)
{
string strComparisonOp_PaperTime = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.PaperTime];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaper.PaperTime, objcc_CourseExamPaper_Cond.PaperTime, strComparisonOp_PaperTime);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaper.DownloadNumber, objcc_CourseExamPaper_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaper.CollectionCount, objcc_CourseExamPaper_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.LikeCount) == true)
{
string strComparisonOp_LikeCount = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaper.LikeCount, objcc_CourseExamPaper_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.id_XzMajor, objcc_CourseExamPaper_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.PaperDispModeId) == true)
{
string strComparisonOp_PaperDispModeId = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.PaperDispModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.PaperDispModeId, objcc_CourseExamPaper_Cond.PaperDispModeId, strComparisonOp_PaperDispModeId);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.ExamCreateTime) == true)
{
string strComparisonOp_ExamCreateTime = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.ExamCreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.ExamCreateTime, objcc_CourseExamPaper_Cond.ExamCreateTime, strComparisonOp_ExamCreateTime);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.CreateUserID) == true)
{
string strComparisonOp_CreateUserID = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.CreateUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.CreateUserID, objcc_CourseExamPaper_Cond.CreateUserID, strComparisonOp_CreateUserID);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.IsOpenToAllStu) == true)
{
if (objcc_CourseExamPaper_Cond.IsOpenToAllStu == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseExamPaper.IsOpenToAllStu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseExamPaper.IsOpenToAllStu);
}
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.IsOpenToSchool) == true)
{
if (objcc_CourseExamPaper_Cond.IsOpenToSchool == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseExamPaper.IsOpenToSchool);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseExamPaper.IsOpenToSchool);
}
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.IsOpenToSocial) == true)
{
if (objcc_CourseExamPaper_Cond.IsOpenToSocial == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseExamPaper.IsOpenToSocial);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseExamPaper.IsOpenToSocial);
}
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.CourseChapterId, objcc_CourseExamPaper_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.IsAutoGeneQuestion) == true)
{
if (objcc_CourseExamPaper_Cond.IsAutoGeneQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseExamPaper.IsAutoGeneQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseExamPaper.IsAutoGeneQuestion);
}
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.IsCanMultiDo) == true)
{
if (objcc_CourseExamPaper_Cond.IsCanMultiDo == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseExamPaper.IsCanMultiDo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseExamPaper.IsCanMultiDo);
}
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.UpdDate, objcc_CourseExamPaper_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.UpdUserId, objcc_CourseExamPaper_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objcc_CourseExamPaper_Cond.IsUpdated(concc_CourseExamPaper.Memo) == true)
{
string strComparisonOp_Memo = objcc_CourseExamPaper_Cond.dicFldComparisonOp[concc_CourseExamPaper.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.Memo, objcc_CourseExamPaper_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
 if (string.IsNullOrEmpty(objcc_CourseExamPaperEN.CourseExamPaperId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_CourseExamPaperEN.sf_UpdFldSetStr = objcc_CourseExamPaperEN.getsf_UpdFldSetStr();
clscc_CourseExamPaperWApi.CheckPropertyNew(objcc_CourseExamPaperEN); 
bool bolResult = clscc_CourseExamPaperWApi.UpdateRecord(objcc_CourseExamPaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperWApi.ReFreshCache(objcc_CourseExamPaperEN.CourseId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_CourseExamPaper(考卷), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_ExamPaperName(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseExamPaperEN == null) return "";
if (objcc_CourseExamPaperEN.CourseExamPaperId == null || objcc_CourseExamPaperEN.CourseExamPaperId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ExamPaperName = '{0}'", objcc_CourseExamPaperEN.ExamPaperName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CourseExamPaperId !=  '{0}'", objcc_CourseExamPaperEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and ExamPaperName = '{0}'", objcc_CourseExamPaperEN.ExamPaperName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
try
{
 if (string.IsNullOrEmpty(objcc_CourseExamPaperEN.CourseExamPaperId) == true || clscc_CourseExamPaperWApi.IsExist(objcc_CourseExamPaperEN.CourseExamPaperId) == true)
 {
     objcc_CourseExamPaperEN.CourseExamPaperId = clscc_CourseExamPaperWApi.GetMaxStrId();
 }
clscc_CourseExamPaperWApi.CheckPropertyNew(objcc_CourseExamPaperEN); 
bool bolResult = clscc_CourseExamPaperWApi.AddNewRecord(objcc_CourseExamPaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperWApi.ReFreshCache(objcc_CourseExamPaperEN.CourseId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
try
{
clscc_CourseExamPaperWApi.CheckPropertyNew(objcc_CourseExamPaperEN); 
string strCourseExamPaperId = clscc_CourseExamPaperWApi.AddNewRecordWithMaxId(objcc_CourseExamPaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperWApi.ReFreshCache(objcc_CourseExamPaperEN.CourseId);
return strCourseExamPaperId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strWhereCond)
{
try
{
clscc_CourseExamPaperWApi.CheckPropertyNew(objcc_CourseExamPaperEN); 
bool bolResult = clscc_CourseExamPaperWApi.UpdateWithCondition(objcc_CourseExamPaperEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperWApi.ReFreshCache(objcc_CourseExamPaperEN.CourseId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 考卷(cc_CourseExamPaper)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_CourseExamPaperWApi
{
private static readonly string mstrApiControllerName = "cc_CourseExamPaperApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clscc_CourseExamPaperWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CourseExamPaperId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[考卷]...","0");
List<clscc_CourseExamPaperEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="CourseExamPaperId";
objDDL.DataTextField="ExamPaperName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_CourseExamPaperId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", concc_CourseExamPaper.CourseExamPaperId); 
List<clscc_CourseExamPaperEN> arrObjLst = clscc_CourseExamPaperWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clscc_CourseExamPaperEN objcc_CourseExamPaperEN = new clscc_CourseExamPaperEN()
{
CourseExamPaperId = "0",
ExamPaperName = "选[考卷]..."
};
arrObjLst.Insert(0, objcc_CourseExamPaperEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = concc_CourseExamPaper.CourseExamPaperId;
objComboBox.DisplayMember = concc_CourseExamPaper.ExamPaperName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
if (!Object.Equals(null, objcc_CourseExamPaperEN.CourseExamPaperId) && GetStrLen(objcc_CourseExamPaperEN.CourseExamPaperId) > 8)
{
 throw new Exception("字段[考卷流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseExamPaperEN.CourseId) && GetStrLen(objcc_CourseExamPaperEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseExamPaperEN.ExamPaperName) && GetStrLen(objcc_CourseExamPaperEN.ExamPaperName) > 500)
{
 throw new Exception("字段[考卷名称]的长度不能超过500!");
}
if (!Object.Equals(null, objcc_CourseExamPaperEN.ExamPaperTypeId) && GetStrLen(objcc_CourseExamPaperEN.ExamPaperTypeId) > 2)
{
 throw new Exception("字段[试卷类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objcc_CourseExamPaperEN.id_XzMajor) && GetStrLen(objcc_CourseExamPaperEN.id_XzMajor) > 8)
{
 throw new Exception("字段[专业流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseExamPaperEN.PaperDispModeId) && GetStrLen(objcc_CourseExamPaperEN.PaperDispModeId) > 4)
{
 throw new Exception("字段[试卷显示模式Id]的长度不能超过4!");
}
if (!Object.Equals(null, objcc_CourseExamPaperEN.ExamCreateTime) && GetStrLen(objcc_CourseExamPaperEN.ExamCreateTime) > 14)
{
 throw new Exception("字段[考卷建立时间]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_CourseExamPaperEN.CreateUserID) && GetStrLen(objcc_CourseExamPaperEN.CreateUserID) > 20)
{
 throw new Exception("字段[建立用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseExamPaperEN.CourseChapterId) && GetStrLen(objcc_CourseExamPaperEN.CourseChapterId) > 8)
{
 throw new Exception("字段[课程章节ID]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseExamPaperEN.UpdDate) && GetStrLen(objcc_CourseExamPaperEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseExamPaperEN.UpdUserId) && GetStrLen(objcc_CourseExamPaperEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseExamPaperEN.Memo) && GetStrLen(objcc_CourseExamPaperEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_CourseExamPaperEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseExamPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseExamPaperEN GetObjByCourseExamPaperId(string strCourseExamPaperId)
{
string strAction = "GetObjByCourseExamPaperId";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseExamPaperEN objcc_CourseExamPaperEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseExamPaperId"] = strCourseExamPaperId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_CourseExamPaperEN = JsonConvert.DeserializeObject<clscc_CourseExamPaperEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseExamPaperEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strCourseExamPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseExamPaperEN GetObjByCourseExamPaperId_WA_Cache(string strCourseExamPaperId, string strCourseId)
{
string strAction = "GetObjByCourseExamPaperId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseExamPaperEN objcc_CourseExamPaperEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseExamPaperId"] = strCourseExamPaperId,
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_CourseExamPaperEN = JsonConvert.DeserializeObject<clscc_CourseExamPaperEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseExamPaperEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clscc_CourseExamPaperEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseExamPaperEN objcc_CourseExamPaperEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_CourseExamPaperEN = JsonConvert.DeserializeObject<clscc_CourseExamPaperEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseExamPaperEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strCourseExamPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseExamPaperEN GetObjByCourseExamPaperId_Cache(string strCourseExamPaperId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseExamPaperId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperEN._CurrTabName_S, strCourseId);
List<clscc_CourseExamPaperEN> arrcc_CourseExamPaperObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_CourseExamPaperEN> arrcc_CourseExamPaperObjLst_Sel =
from objcc_CourseExamPaperEN in arrcc_CourseExamPaperObjLst_Cache
where objcc_CourseExamPaperEN.CourseExamPaperId == strCourseExamPaperId
select objcc_CourseExamPaperEN;
if (arrcc_CourseExamPaperObjLst_Sel.Count() == 0)
{
   clscc_CourseExamPaperEN obj = clscc_CourseExamPaperWApi.GetObjByCourseExamPaperId(strCourseExamPaperId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_CourseExamPaperObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strCourseExamPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetExamPaperNameByCourseExamPaperId_Cache(string strCourseExamPaperId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseExamPaperId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperEN._CurrTabName_S, strCourseId);
List<clscc_CourseExamPaperEN> arrcc_CourseExamPaperObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_CourseExamPaperEN> arrcc_CourseExamPaperObjLst_Sel1 =
from objcc_CourseExamPaperEN in arrcc_CourseExamPaperObjLst_Cache
where objcc_CourseExamPaperEN.CourseExamPaperId == strCourseExamPaperId
select objcc_CourseExamPaperEN;
List <clscc_CourseExamPaperEN> arrcc_CourseExamPaperObjLst_Sel = new List<clscc_CourseExamPaperEN>();
foreach (clscc_CourseExamPaperEN obj in arrcc_CourseExamPaperObjLst_Sel1)
{
arrcc_CourseExamPaperObjLst_Sel.Add(obj);
}
if (arrcc_CourseExamPaperObjLst_Sel.Count > 0)
{
return arrcc_CourseExamPaperObjLst_Sel[0].ExamPaperName;
}
string strErrMsgForGetObjById = string.Format("在cc_CourseExamPaper对象缓存列表中,找不到记录[CourseExamPaperId = {0}](函数:{1})", strCourseExamPaperId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clscc_CourseExamPaperBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strCourseExamPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCourseExamPaperId_Cache(string strCourseExamPaperId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseExamPaperId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperEN._CurrTabName_S, strCourseId);
List<clscc_CourseExamPaperEN> arrcc_CourseExamPaperObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_CourseExamPaperEN> arrcc_CourseExamPaperObjLst_Sel1 =
from objcc_CourseExamPaperEN in arrcc_CourseExamPaperObjLst_Cache
where objcc_CourseExamPaperEN.CourseExamPaperId == strCourseExamPaperId
select objcc_CourseExamPaperEN;
List <clscc_CourseExamPaperEN> arrcc_CourseExamPaperObjLst_Sel = new List<clscc_CourseExamPaperEN>();
foreach (clscc_CourseExamPaperEN obj in arrcc_CourseExamPaperObjLst_Sel1)
{
arrcc_CourseExamPaperObjLst_Sel.Add(obj);
}
if (arrcc_CourseExamPaperObjLst_Sel.Count > 0)
{
return arrcc_CourseExamPaperObjLst_Sel[0].ExamPaperName;
}
string strErrMsgForGetObjById = string.Format("在cc_CourseExamPaper对象缓存列表中,找不到记录的相关名称[CourseExamPaperId = {0}](函数:{1})", strCourseExamPaperId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clscc_CourseExamPaperBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseExamPaperEN> GetObjLst(string strWhereCond)
{
 List<clscc_CourseExamPaperEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseExamPaperEN> GetObjLstByCourseExamPaperIdLst(List<string> arrCourseExamPaperId)
{
 List<clscc_CourseExamPaperEN> arrObjLst = null; 
string strAction = "GetObjLstByCourseExamPaperIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseExamPaperId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "strCourseExamPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clscc_CourseExamPaperEN> GetObjLstByCourseExamPaperIdLst_Cache(List<string> arrCourseExamPaperId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperEN._CurrTabName_S, strCourseId);
List<clscc_CourseExamPaperEN> arrcc_CourseExamPaperObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_CourseExamPaperEN> arrcc_CourseExamPaperObjLst_Sel =
from objcc_CourseExamPaperEN in arrcc_CourseExamPaperObjLst_Cache
where arrCourseExamPaperId.Contains(objcc_CourseExamPaperEN.CourseExamPaperId)
select objcc_CourseExamPaperEN;
return arrcc_CourseExamPaperObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseExamPaperEN> GetObjLstByCourseExamPaperIdLst_WA_Cache(List<string> arrCourseExamPaperId, string strCourseId)
{
 List<clscc_CourseExamPaperEN> arrObjLst = null; 
string strAction = "GetObjLstByCourseExamPaperIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseExamPaperId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseExamPaperEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_CourseExamPaperEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseExamPaperEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_CourseExamPaperEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clscc_CourseExamPaperEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_CourseExamPaperEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clscc_CourseExamPaperEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_CourseExamPaperEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strCourseExamPaperId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_CourseExamPaperEN objcc_CourseExamPaperEN = clscc_CourseExamPaperWApi.GetObjByCourseExamPaperId(strCourseExamPaperId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strCourseExamPaperId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_CourseExamPaperWApi.ReFreshCache(objcc_CourseExamPaperEN.CourseId);
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int Delcc_CourseExamPapers(List<string> arrCourseExamPaperId)
{
string strAction = "Delcc_CourseExamPapers";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseExamPaperId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clscc_CourseExamPaperEN objcc_CourseExamPaperEN = clscc_CourseExamPaperWApi.GetObjByCourseExamPaperId(arrCourseExamPaperId[0]);
clscc_CourseExamPaperWApi.ReFreshCache(objcc_CourseExamPaperEN.CourseId);
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int Delcc_CourseExamPapersByCond(string strWhereCond)
{
string strAction = "Delcc_CourseExamPapersByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseExamPaperEN>(objcc_CourseExamPaperEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperWApi.ReFreshCache(objcc_CourseExamPaperEN.CourseId);
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseExamPaperEN>(objcc_CourseExamPaperEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperWApi.ReFreshCache(objcc_CourseExamPaperEN.CourseId);
var strCourseExamPaperId = (string)jobjReturn["ReturnStr"];
return strCourseExamPaperId;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
if (string.IsNullOrEmpty(objcc_CourseExamPaperEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseExamPaperEN.CourseExamPaperId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseExamPaperEN>(objcc_CourseExamPaperEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_CourseExamPaperEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseExamPaperEN.CourseExamPaperId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseExamPaperEN.CourseExamPaperId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseExamPaperEN>(objcc_CourseExamPaperEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(string strCourseExamPaperId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseExamPaperId"] = strCourseExamPaperId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperENS">源对象</param>
 /// <param name = "objcc_CourseExamPaperENT">目标对象</param>
 public static void CopyTo(clscc_CourseExamPaperEN objcc_CourseExamPaperENS, clscc_CourseExamPaperEN objcc_CourseExamPaperENT)
{
try
{
objcc_CourseExamPaperENT.CourseExamPaperId = objcc_CourseExamPaperENS.CourseExamPaperId; //考卷流水号
objcc_CourseExamPaperENT.CourseId = objcc_CourseExamPaperENS.CourseId; //课程Id
objcc_CourseExamPaperENT.ExamPaperName = objcc_CourseExamPaperENS.ExamPaperName; //考卷名称
objcc_CourseExamPaperENT.PaperIndex = objcc_CourseExamPaperENS.PaperIndex; //试卷序号
objcc_CourseExamPaperENT.ExamPaperTypeId = objcc_CourseExamPaperENS.ExamPaperTypeId; //试卷类型Id
objcc_CourseExamPaperENT.IsShow = objcc_CourseExamPaperENS.IsShow; //是否启用
objcc_CourseExamPaperENT.TotalScore = objcc_CourseExamPaperENS.TotalScore; //总得分
objcc_CourseExamPaperENT.ViewCount = objcc_CourseExamPaperENS.ViewCount; //浏览量
objcc_CourseExamPaperENT.DoneNumber = objcc_CourseExamPaperENS.DoneNumber; //已做人数
objcc_CourseExamPaperENT.PaperTime = objcc_CourseExamPaperENS.PaperTime; //考试时间（分钟）
objcc_CourseExamPaperENT.DownloadNumber = objcc_CourseExamPaperENS.DownloadNumber; //下载数目
objcc_CourseExamPaperENT.CollectionCount = objcc_CourseExamPaperENS.CollectionCount; //收藏数量
objcc_CourseExamPaperENT.LikeCount = objcc_CourseExamPaperENS.LikeCount; //资源喜欢数量
objcc_CourseExamPaperENT.id_XzMajor = objcc_CourseExamPaperENS.id_XzMajor; //专业流水号
objcc_CourseExamPaperENT.PaperDispModeId = objcc_CourseExamPaperENS.PaperDispModeId; //试卷显示模式Id
objcc_CourseExamPaperENT.ExamCreateTime = objcc_CourseExamPaperENS.ExamCreateTime; //考卷建立时间
objcc_CourseExamPaperENT.CreateUserID = objcc_CourseExamPaperENS.CreateUserID; //建立用户ID
objcc_CourseExamPaperENT.IsOpenToAllStu = objcc_CourseExamPaperENS.IsOpenToAllStu; //全校师生
objcc_CourseExamPaperENT.IsOpenToSchool = objcc_CourseExamPaperENS.IsOpenToSchool; //全校师生公开
objcc_CourseExamPaperENT.IsOpenToSocial = objcc_CourseExamPaperENS.IsOpenToSocial; //社会公众
objcc_CourseExamPaperENT.CourseChapterId = objcc_CourseExamPaperENS.CourseChapterId; //课程章节ID
objcc_CourseExamPaperENT.IsAutoGeneQuestion = objcc_CourseExamPaperENS.IsAutoGeneQuestion; //是否自动生成题目
objcc_CourseExamPaperENT.IsCanMultiDo = objcc_CourseExamPaperENS.IsCanMultiDo; //是否可以做多次
objcc_CourseExamPaperENT.UpdDate = objcc_CourseExamPaperENS.UpdDate; //修改日期
objcc_CourseExamPaperENT.UpdUserId = objcc_CourseExamPaperENS.UpdUserId; //修改用户Id
objcc_CourseExamPaperENT.Memo = objcc_CourseExamPaperENS.Memo; //备注
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clscc_CourseExamPaperEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_CourseExamPaperEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_CourseExamPaperEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_CourseExamPaperEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_CourseExamPaperEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_CourseExamPaperEN.AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clscc_CourseExamPaperWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperWApi没有刷新缓存机制(clscc_CourseExamPaperWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseExamPaperId");
//if (arrcc_CourseExamPaperObjLst_Cache == null)
//{
//arrcc_CourseExamPaperObjLst_Cache = await clscc_CourseExamPaperWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperEN._CurrTabName_S, strCourseId);
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

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strCourseId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clscc_CourseExamPaperWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperEN._CurrTabName_S, strCourseId);
CacheHelper.Remove(strKey);
clscc_CourseExamPaperWApi.objCommFun4BL.ReFreshCache(strCourseId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseExamPaperEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperEN._CurrTabName_S, strCourseId);
List<clscc_CourseExamPaperEN> arrcc_CourseExamPaperObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrcc_CourseExamPaperObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_CourseExamPaperEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_CourseExamPaper.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaper.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaper.ExamPaperName, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaper.PaperIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_CourseExamPaper.ExamPaperTypeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaper.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseExamPaper.TotalScore, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_CourseExamPaper.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_CourseExamPaper.DoneNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_CourseExamPaper.PaperTime, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_CourseExamPaper.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_CourseExamPaper.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_CourseExamPaper.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_CourseExamPaper.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaper.PaperDispModeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaper.ExamCreateTime, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaper.CreateUserID, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaper.IsOpenToAllStu, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseExamPaper.IsOpenToSchool, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseExamPaper.IsOpenToSocial, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseExamPaper.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaper.IsAutoGeneQuestion, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseExamPaper.IsCanMultiDo, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseExamPaper.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaper.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaper.Memo, Type.GetType("System.String"));
foreach (clscc_CourseExamPaperEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_CourseExamPaper.CourseExamPaperId] = objInFor[concc_CourseExamPaper.CourseExamPaperId];
objDR[concc_CourseExamPaper.CourseId] = objInFor[concc_CourseExamPaper.CourseId];
objDR[concc_CourseExamPaper.ExamPaperName] = objInFor[concc_CourseExamPaper.ExamPaperName];
objDR[concc_CourseExamPaper.PaperIndex] = objInFor[concc_CourseExamPaper.PaperIndex];
objDR[concc_CourseExamPaper.ExamPaperTypeId] = objInFor[concc_CourseExamPaper.ExamPaperTypeId];
objDR[concc_CourseExamPaper.IsShow] = objInFor[concc_CourseExamPaper.IsShow];
objDR[concc_CourseExamPaper.TotalScore] = objInFor[concc_CourseExamPaper.TotalScore];
objDR[concc_CourseExamPaper.ViewCount] = objInFor[concc_CourseExamPaper.ViewCount];
objDR[concc_CourseExamPaper.DoneNumber] = objInFor[concc_CourseExamPaper.DoneNumber];
objDR[concc_CourseExamPaper.PaperTime] = objInFor[concc_CourseExamPaper.PaperTime];
objDR[concc_CourseExamPaper.DownloadNumber] = objInFor[concc_CourseExamPaper.DownloadNumber];
objDR[concc_CourseExamPaper.CollectionCount] = objInFor[concc_CourseExamPaper.CollectionCount];
objDR[concc_CourseExamPaper.LikeCount] = objInFor[concc_CourseExamPaper.LikeCount];
objDR[concc_CourseExamPaper.id_XzMajor] = objInFor[concc_CourseExamPaper.id_XzMajor];
objDR[concc_CourseExamPaper.PaperDispModeId] = objInFor[concc_CourseExamPaper.PaperDispModeId];
objDR[concc_CourseExamPaper.ExamCreateTime] = objInFor[concc_CourseExamPaper.ExamCreateTime];
objDR[concc_CourseExamPaper.CreateUserID] = objInFor[concc_CourseExamPaper.CreateUserID];
objDR[concc_CourseExamPaper.IsOpenToAllStu] = objInFor[concc_CourseExamPaper.IsOpenToAllStu];
objDR[concc_CourseExamPaper.IsOpenToSchool] = objInFor[concc_CourseExamPaper.IsOpenToSchool];
objDR[concc_CourseExamPaper.IsOpenToSocial] = objInFor[concc_CourseExamPaper.IsOpenToSocial];
objDR[concc_CourseExamPaper.CourseChapterId] = objInFor[concc_CourseExamPaper.CourseChapterId];
objDR[concc_CourseExamPaper.IsAutoGeneQuestion] = objInFor[concc_CourseExamPaper.IsAutoGeneQuestion];
objDR[concc_CourseExamPaper.IsCanMultiDo] = objInFor[concc_CourseExamPaper.IsCanMultiDo];
objDR[concc_CourseExamPaper.UpdDate] = objInFor[concc_CourseExamPaper.UpdDate];
objDR[concc_CourseExamPaper.UpdUserId] = objInFor[concc_CourseExamPaper.UpdUserId];
objDR[concc_CourseExamPaper.Memo] = objInFor[concc_CourseExamPaper.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 考卷(cc_CourseExamPaper)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_CourseExamPaper : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperWApi.ReFreshThisCache(strCourseId);
clsvcc_CourseExamPaperWApi.ReFreshThisCache(strCourseId);
}
}

}