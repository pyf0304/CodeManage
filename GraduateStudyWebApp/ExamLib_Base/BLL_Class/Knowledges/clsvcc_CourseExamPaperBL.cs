
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseExamPaperBL
 表名:vcc_CourseExamPaper(01120098)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:04:16
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
public static class  clsvcc_CourseExamPaperBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseExamPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseExamPaperEN GetObj(this K_CourseExamPaperId_vcc_CourseExamPaper myKey)
{
clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = clsvcc_CourseExamPaperBL.vcc_CourseExamPaperDA.GetObjByCourseExamPaperId(myKey.Value);
return objvcc_CourseExamPaperEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetCourseExamPaperId(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strCourseExamPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_CourseExamPaper.CourseExamPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_CourseExamPaper.CourseExamPaperId);
}
objvcc_CourseExamPaperEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.CourseExamPaperId) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.CourseExamPaperId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.CourseExamPaperId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetCourseId(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseExamPaper.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseExamPaper.CourseId);
}
objvcc_CourseExamPaperEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.CourseId) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.CourseId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.CourseId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetCourseName(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseExamPaper.CourseName);
}
objvcc_CourseExamPaperEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.CourseName) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.CourseName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.CourseName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetExamPaperName(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strExamPaperName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_CourseExamPaper.ExamPaperName);
}
objvcc_CourseExamPaperEN.ExamPaperName = strExamPaperName; //考卷名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.ExamPaperName) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.ExamPaperName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.ExamPaperName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetPaperIndex(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, int? intPaperIndex, string strComparisonOp="")
	{
objvcc_CourseExamPaperEN.PaperIndex = intPaperIndex; //试卷序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.PaperIndex) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.PaperIndex, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.PaperIndex] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetExamPaperTypeId(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strExamPaperTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeId, convcc_CourseExamPaper.ExamPaperTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, convcc_CourseExamPaper.ExamPaperTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, convcc_CourseExamPaper.ExamPaperTypeId);
}
objvcc_CourseExamPaperEN.ExamPaperTypeId = strExamPaperTypeId; //试卷类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.ExamPaperTypeId) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.ExamPaperTypeId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.ExamPaperTypeId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetExamPaperTypeName(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strExamPaperTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPaperTypeName, 30, convcc_CourseExamPaper.ExamPaperTypeName);
}
objvcc_CourseExamPaperEN.ExamPaperTypeName = strExamPaperTypeName; //试卷类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.ExamPaperTypeName) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.ExamPaperTypeName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.ExamPaperTypeName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetIsShow(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, bool bolIsShow, string strComparisonOp="")
	{
objvcc_CourseExamPaperEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.IsShow) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.IsShow, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.IsShow] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetTotalScore(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, double? dblTotalScore, string strComparisonOp="")
	{
objvcc_CourseExamPaperEN.TotalScore = dblTotalScore; //总得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.TotalScore) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.TotalScore, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.TotalScore] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetViewCount(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, int? intViewCount, string strComparisonOp="")
	{
objvcc_CourseExamPaperEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.ViewCount) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.ViewCount, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.ViewCount] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetDoneNumber(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, int? intDoneNumber, string strComparisonOp="")
	{
objvcc_CourseExamPaperEN.DoneNumber = intDoneNumber; //已做人数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.DoneNumber) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.DoneNumber, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.DoneNumber] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetPaperTime(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, int? intPaperTime, string strComparisonOp="")
	{
objvcc_CourseExamPaperEN.PaperTime = intPaperTime; //考试时间（分钟）
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.PaperTime) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.PaperTime, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.PaperTime] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetDownloadNumber(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, int? intDownloadNumber, string strComparisonOp="")
	{
objvcc_CourseExamPaperEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.DownloadNumber) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.DownloadNumber, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.DownloadNumber] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetCollectionCount(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvcc_CourseExamPaperEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.CollectionCount) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.CollectionCount, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.CollectionCount] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetLikeCount(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, long? lngLikeCount, string strComparisonOp="")
	{
objvcc_CourseExamPaperEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.LikeCount) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.LikeCount, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.LikeCount] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetIdXzMajor(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convcc_CourseExamPaper.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convcc_CourseExamPaper.IdXzMajor);
}
objvcc_CourseExamPaperEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.IdXzMajor) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.IdXzMajor, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.IdXzMajor] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetMajorName(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_CourseExamPaper.MajorName);
}
objvcc_CourseExamPaperEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.MajorName) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.MajorName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.MajorName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetPaperDispModeId(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strPaperDispModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperDispModeId, 4, convcc_CourseExamPaper.PaperDispModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperDispModeId, 4, convcc_CourseExamPaper.PaperDispModeId);
}
objvcc_CourseExamPaperEN.PaperDispModeId = strPaperDispModeId; //试卷显示模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.PaperDispModeId) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.PaperDispModeId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.PaperDispModeId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetPaperDispModeName(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strPaperDispModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperDispModeName, 30, convcc_CourseExamPaper.PaperDispModeName);
}
objvcc_CourseExamPaperEN.PaperDispModeName = strPaperDispModeName; //试卷显示模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.PaperDispModeName) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.PaperDispModeName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.PaperDispModeName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetExamCreateTime(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strExamCreateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamCreateTime, 14, convcc_CourseExamPaper.ExamCreateTime);
}
objvcc_CourseExamPaperEN.ExamCreateTime = strExamCreateTime; //考卷建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.ExamCreateTime) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.ExamCreateTime, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.ExamCreateTime] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetCreateUserID(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strCreateUserID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUserID, 20, convcc_CourseExamPaper.CreateUserID);
}
objvcc_CourseExamPaperEN.CreateUserID = strCreateUserID; //建立用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.CreateUserID) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.CreateUserID, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.CreateUserID] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetUserName(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convcc_CourseExamPaper.UserName);
}
objvcc_CourseExamPaperEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.UserName) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.UserName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.UserName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetIsOpenToAllStu(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, bool bolIsOpenToAllStu, string strComparisonOp="")
	{
objvcc_CourseExamPaperEN.IsOpenToAllStu = bolIsOpenToAllStu; //全校师生
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.IsOpenToAllStu) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.IsOpenToAllStu, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.IsOpenToAllStu] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetIsOpenToSchool(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, bool bolIsOpenToSchool, string strComparisonOp="")
	{
objvcc_CourseExamPaperEN.IsOpenToSchool = bolIsOpenToSchool; //全校师生公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.IsOpenToSchool) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.IsOpenToSchool, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.IsOpenToSchool] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetIsOpenToSocial(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, bool bolIsOpenToSocial, string strComparisonOp="")
	{
objvcc_CourseExamPaperEN.IsOpenToSocial = bolIsOpenToSocial; //社会公众
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.IsOpenToSocial) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.IsOpenToSocial, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.IsOpenToSocial] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetCourseChapterId(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_CourseExamPaper.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_CourseExamPaper.CourseChapterId);
}
objvcc_CourseExamPaperEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.CourseChapterId) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.CourseChapterId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.CourseChapterId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetCourseChapterName(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strCourseChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_CourseExamPaper.CourseChapterName);
}
objvcc_CourseExamPaperEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.CourseChapterName) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.CourseChapterName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.CourseChapterName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetChapterId(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_CourseExamPaper.ChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_CourseExamPaper.ChapterId);
}
objvcc_CourseExamPaperEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.ChapterId) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.ChapterId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.ChapterId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetSectionId(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_CourseExamPaper.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_CourseExamPaper.SectionId);
}
objvcc_CourseExamPaperEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.SectionId) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.SectionId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.SectionId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetChapterName(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_CourseExamPaper.ChapterName);
}
objvcc_CourseExamPaperEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.ChapterName) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.ChapterName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.ChapterName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetSectionName(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_CourseExamPaper.SectionName);
}
objvcc_CourseExamPaperEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.SectionName) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.SectionName, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.SectionName] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetChapterNameSim(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convcc_CourseExamPaper.ChapterNameSim);
}
objvcc_CourseExamPaperEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.ChapterNameSim) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.ChapterNameSim, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.ChapterNameSim] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetSectionNameSim(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convcc_CourseExamPaper.SectionNameSim);
}
objvcc_CourseExamPaperEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.SectionNameSim) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.SectionNameSim, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.SectionNameSim] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetIsAutoGeneQuestion(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, bool bolIsAutoGeneQuestion, string strComparisonOp="")
	{
objvcc_CourseExamPaperEN.IsAutoGeneQuestion = bolIsAutoGeneQuestion; //是否自动生成题目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.IsAutoGeneQuestion) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.IsAutoGeneQuestion, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.IsAutoGeneQuestion] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetIsCanMultiDo(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, bool bolIsCanMultiDo, string strComparisonOp="")
	{
objvcc_CourseExamPaperEN.IsCanMultiDo = bolIsCanMultiDo; //是否可以做多次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.IsCanMultiDo) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.IsCanMultiDo, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.IsCanMultiDo] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetUpdDate(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_CourseExamPaper.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseExamPaper.UpdDate);
}
objvcc_CourseExamPaperEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.UpdDate) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.UpdDate, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.UpdDate] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetUpdUserId(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_CourseExamPaper.UpdUserId);
}
objvcc_CourseExamPaperEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.UpdUserId) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.UpdUserId, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.UpdUserId] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetMemo(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseExamPaper.Memo);
}
objvcc_CourseExamPaperEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.Memo) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.Memo, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.Memo] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetQuestionNum(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, int? intQuestionNum, string strComparisonOp="")
	{
objvcc_CourseExamPaperEN.QuestionNum = intQuestionNum; //题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.QuestionNum) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.QuestionNum, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.QuestionNum] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetBigTopicNum(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, int? intBigTopicNum, string strComparisonOp="")
	{
objvcc_CourseExamPaperEN.BigTopicNum = intBigTopicNum; //大标题数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.BigTopicNum) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.BigTopicNum, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.BigTopicNum] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperENS">源对象</param>
 /// <param name = "objvcc_CourseExamPaperENT">目标对象</param>
 public static void CopyTo(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperENS, clsvcc_CourseExamPaperEN objvcc_CourseExamPaperENT)
{
try
{
objvcc_CourseExamPaperENT.CourseExamPaperId = objvcc_CourseExamPaperENS.CourseExamPaperId; //考卷流水号
objvcc_CourseExamPaperENT.CourseId = objvcc_CourseExamPaperENS.CourseId; //课程Id
objvcc_CourseExamPaperENT.CourseName = objvcc_CourseExamPaperENS.CourseName; //课程名称
objvcc_CourseExamPaperENT.ExamPaperName = objvcc_CourseExamPaperENS.ExamPaperName; //考卷名称
objvcc_CourseExamPaperENT.PaperIndex = objvcc_CourseExamPaperENS.PaperIndex; //试卷序号
objvcc_CourseExamPaperENT.ExamPaperTypeId = objvcc_CourseExamPaperENS.ExamPaperTypeId; //试卷类型Id
objvcc_CourseExamPaperENT.ExamPaperTypeName = objvcc_CourseExamPaperENS.ExamPaperTypeName; //试卷类型名称
objvcc_CourseExamPaperENT.IsShow = objvcc_CourseExamPaperENS.IsShow; //是否启用
objvcc_CourseExamPaperENT.TotalScore = objvcc_CourseExamPaperENS.TotalScore; //总得分
objvcc_CourseExamPaperENT.ViewCount = objvcc_CourseExamPaperENS.ViewCount; //浏览量
objvcc_CourseExamPaperENT.DoneNumber = objvcc_CourseExamPaperENS.DoneNumber; //已做人数
objvcc_CourseExamPaperENT.PaperTime = objvcc_CourseExamPaperENS.PaperTime; //考试时间（分钟）
objvcc_CourseExamPaperENT.DownloadNumber = objvcc_CourseExamPaperENS.DownloadNumber; //下载数目
objvcc_CourseExamPaperENT.CollectionCount = objvcc_CourseExamPaperENS.CollectionCount; //收藏数量
objvcc_CourseExamPaperENT.LikeCount = objvcc_CourseExamPaperENS.LikeCount; //资源喜欢数量
objvcc_CourseExamPaperENT.IdXzMajor = objvcc_CourseExamPaperENS.IdXzMajor; //专业流水号
objvcc_CourseExamPaperENT.MajorName = objvcc_CourseExamPaperENS.MajorName; //专业名称
objvcc_CourseExamPaperENT.PaperDispModeId = objvcc_CourseExamPaperENS.PaperDispModeId; //试卷显示模式Id
objvcc_CourseExamPaperENT.PaperDispModeName = objvcc_CourseExamPaperENS.PaperDispModeName; //试卷显示模式名称
objvcc_CourseExamPaperENT.ExamCreateTime = objvcc_CourseExamPaperENS.ExamCreateTime; //考卷建立时间
objvcc_CourseExamPaperENT.CreateUserID = objvcc_CourseExamPaperENS.CreateUserID; //建立用户ID
objvcc_CourseExamPaperENT.UserName = objvcc_CourseExamPaperENS.UserName; //用户名
objvcc_CourseExamPaperENT.IsOpenToAllStu = objvcc_CourseExamPaperENS.IsOpenToAllStu; //全校师生
objvcc_CourseExamPaperENT.IsOpenToSchool = objvcc_CourseExamPaperENS.IsOpenToSchool; //全校师生公开
objvcc_CourseExamPaperENT.IsOpenToSocial = objvcc_CourseExamPaperENS.IsOpenToSocial; //社会公众
objvcc_CourseExamPaperENT.CourseChapterId = objvcc_CourseExamPaperENS.CourseChapterId; //课程章节ID
objvcc_CourseExamPaperENT.CourseChapterName = objvcc_CourseExamPaperENS.CourseChapterName; //课程章节名称
objvcc_CourseExamPaperENT.ChapterId = objvcc_CourseExamPaperENS.ChapterId; //章Id
objvcc_CourseExamPaperENT.SectionId = objvcc_CourseExamPaperENS.SectionId; //节Id
objvcc_CourseExamPaperENT.ChapterName = objvcc_CourseExamPaperENS.ChapterName; //章名
objvcc_CourseExamPaperENT.SectionName = objvcc_CourseExamPaperENS.SectionName; //节名
objvcc_CourseExamPaperENT.ChapterNameSim = objvcc_CourseExamPaperENS.ChapterNameSim; //章名简称
objvcc_CourseExamPaperENT.SectionNameSim = objvcc_CourseExamPaperENS.SectionNameSim; //节名简称
objvcc_CourseExamPaperENT.IsAutoGeneQuestion = objvcc_CourseExamPaperENS.IsAutoGeneQuestion; //是否自动生成题目
objvcc_CourseExamPaperENT.IsCanMultiDo = objvcc_CourseExamPaperENS.IsCanMultiDo; //是否可以做多次
objvcc_CourseExamPaperENT.UpdDate = objvcc_CourseExamPaperENS.UpdDate; //修改日期
objvcc_CourseExamPaperENT.UpdUserId = objvcc_CourseExamPaperENS.UpdUserId; //修改用户Id
objvcc_CourseExamPaperENT.Memo = objvcc_CourseExamPaperENS.Memo; //备注
objvcc_CourseExamPaperENT.QuestionNum = objvcc_CourseExamPaperENS.QuestionNum; //题目数
objvcc_CourseExamPaperENT.BigTopicNum = objvcc_CourseExamPaperENS.BigTopicNum; //大标题数
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
 /// <param name = "objvcc_CourseExamPaperENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseExamPaperEN:objvcc_CourseExamPaperENT</returns>
 public static clsvcc_CourseExamPaperEN CopyTo(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperENS)
{
try
{
 clsvcc_CourseExamPaperEN objvcc_CourseExamPaperENT = new clsvcc_CourseExamPaperEN()
{
CourseExamPaperId = objvcc_CourseExamPaperENS.CourseExamPaperId, //考卷流水号
CourseId = objvcc_CourseExamPaperENS.CourseId, //课程Id
CourseName = objvcc_CourseExamPaperENS.CourseName, //课程名称
ExamPaperName = objvcc_CourseExamPaperENS.ExamPaperName, //考卷名称
PaperIndex = objvcc_CourseExamPaperENS.PaperIndex, //试卷序号
ExamPaperTypeId = objvcc_CourseExamPaperENS.ExamPaperTypeId, //试卷类型Id
ExamPaperTypeName = objvcc_CourseExamPaperENS.ExamPaperTypeName, //试卷类型名称
IsShow = objvcc_CourseExamPaperENS.IsShow, //是否启用
TotalScore = objvcc_CourseExamPaperENS.TotalScore, //总得分
ViewCount = objvcc_CourseExamPaperENS.ViewCount, //浏览量
DoneNumber = objvcc_CourseExamPaperENS.DoneNumber, //已做人数
PaperTime = objvcc_CourseExamPaperENS.PaperTime, //考试时间（分钟）
DownloadNumber = objvcc_CourseExamPaperENS.DownloadNumber, //下载数目
CollectionCount = objvcc_CourseExamPaperENS.CollectionCount, //收藏数量
LikeCount = objvcc_CourseExamPaperENS.LikeCount, //资源喜欢数量
IdXzMajor = objvcc_CourseExamPaperENS.IdXzMajor, //专业流水号
MajorName = objvcc_CourseExamPaperENS.MajorName, //专业名称
PaperDispModeId = objvcc_CourseExamPaperENS.PaperDispModeId, //试卷显示模式Id
PaperDispModeName = objvcc_CourseExamPaperENS.PaperDispModeName, //试卷显示模式名称
ExamCreateTime = objvcc_CourseExamPaperENS.ExamCreateTime, //考卷建立时间
CreateUserID = objvcc_CourseExamPaperENS.CreateUserID, //建立用户ID
UserName = objvcc_CourseExamPaperENS.UserName, //用户名
IsOpenToAllStu = objvcc_CourseExamPaperENS.IsOpenToAllStu, //全校师生
IsOpenToSchool = objvcc_CourseExamPaperENS.IsOpenToSchool, //全校师生公开
IsOpenToSocial = objvcc_CourseExamPaperENS.IsOpenToSocial, //社会公众
CourseChapterId = objvcc_CourseExamPaperENS.CourseChapterId, //课程章节ID
CourseChapterName = objvcc_CourseExamPaperENS.CourseChapterName, //课程章节名称
ChapterId = objvcc_CourseExamPaperENS.ChapterId, //章Id
SectionId = objvcc_CourseExamPaperENS.SectionId, //节Id
ChapterName = objvcc_CourseExamPaperENS.ChapterName, //章名
SectionName = objvcc_CourseExamPaperENS.SectionName, //节名
ChapterNameSim = objvcc_CourseExamPaperENS.ChapterNameSim, //章名简称
SectionNameSim = objvcc_CourseExamPaperENS.SectionNameSim, //节名简称
IsAutoGeneQuestion = objvcc_CourseExamPaperENS.IsAutoGeneQuestion, //是否自动生成题目
IsCanMultiDo = objvcc_CourseExamPaperENS.IsCanMultiDo, //是否可以做多次
UpdDate = objvcc_CourseExamPaperENS.UpdDate, //修改日期
UpdUserId = objvcc_CourseExamPaperENS.UpdUserId, //修改用户Id
Memo = objvcc_CourseExamPaperENS.Memo, //备注
QuestionNum = objvcc_CourseExamPaperENS.QuestionNum, //题目数
BigTopicNum = objvcc_CourseExamPaperENS.BigTopicNum, //大标题数
};
 return objvcc_CourseExamPaperENT;
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
public static void CheckProperty4Condition(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN)
{
 clsvcc_CourseExamPaperBL.vcc_CourseExamPaperDA.CheckProperty4Condition(objvcc_CourseExamPaperEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.CourseExamPaperId) == true)
{
string strComparisonOpCourseExamPaperId = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.CourseExamPaperId, objvcc_CourseExamPaperCond.CourseExamPaperId, strComparisonOpCourseExamPaperId);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.CourseId, objvcc_CourseExamPaperCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.CourseName, objvcc_CourseExamPaperCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.ExamPaperName) == true)
{
string strComparisonOpExamPaperName = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.ExamPaperName, objvcc_CourseExamPaperCond.ExamPaperName, strComparisonOpExamPaperName);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.PaperIndex) == true)
{
string strComparisonOpPaperIndex = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.PaperIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.PaperIndex, objvcc_CourseExamPaperCond.PaperIndex, strComparisonOpPaperIndex);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.ExamPaperTypeId) == true)
{
string strComparisonOpExamPaperTypeId = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.ExamPaperTypeId, objvcc_CourseExamPaperCond.ExamPaperTypeId, strComparisonOpExamPaperTypeId);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.ExamPaperTypeName) == true)
{
string strComparisonOpExamPaperTypeName = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.ExamPaperTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.ExamPaperTypeName, objvcc_CourseExamPaperCond.ExamPaperTypeName, strComparisonOpExamPaperTypeName);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.IsShow) == true)
{
if (objvcc_CourseExamPaperCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaper.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaper.IsShow);
}
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.TotalScore) == true)
{
string strComparisonOpTotalScore = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.TotalScore, objvcc_CourseExamPaperCond.TotalScore, strComparisonOpTotalScore);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.ViewCount) == true)
{
string strComparisonOpViewCount = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.ViewCount, objvcc_CourseExamPaperCond.ViewCount, strComparisonOpViewCount);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.DoneNumber) == true)
{
string strComparisonOpDoneNumber = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.DoneNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.DoneNumber, objvcc_CourseExamPaperCond.DoneNumber, strComparisonOpDoneNumber);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.PaperTime) == true)
{
string strComparisonOpPaperTime = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.PaperTime];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.PaperTime, objvcc_CourseExamPaperCond.PaperTime, strComparisonOpPaperTime);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.DownloadNumber, objvcc_CourseExamPaperCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.CollectionCount, objvcc_CourseExamPaperCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.LikeCount) == true)
{
string strComparisonOpLikeCount = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.LikeCount, objvcc_CourseExamPaperCond.LikeCount, strComparisonOpLikeCount);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.IdXzMajor, objvcc_CourseExamPaperCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.MajorName) == true)
{
string strComparisonOpMajorName = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.MajorName, objvcc_CourseExamPaperCond.MajorName, strComparisonOpMajorName);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.PaperDispModeId) == true)
{
string strComparisonOpPaperDispModeId = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.PaperDispModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.PaperDispModeId, objvcc_CourseExamPaperCond.PaperDispModeId, strComparisonOpPaperDispModeId);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.PaperDispModeName) == true)
{
string strComparisonOpPaperDispModeName = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.PaperDispModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.PaperDispModeName, objvcc_CourseExamPaperCond.PaperDispModeName, strComparisonOpPaperDispModeName);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.ExamCreateTime) == true)
{
string strComparisonOpExamCreateTime = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.ExamCreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.ExamCreateTime, objvcc_CourseExamPaperCond.ExamCreateTime, strComparisonOpExamCreateTime);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.CreateUserID) == true)
{
string strComparisonOpCreateUserID = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.CreateUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.CreateUserID, objvcc_CourseExamPaperCond.CreateUserID, strComparisonOpCreateUserID);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.UserName) == true)
{
string strComparisonOpUserName = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.UserName, objvcc_CourseExamPaperCond.UserName, strComparisonOpUserName);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.IsOpenToAllStu) == true)
{
if (objvcc_CourseExamPaperCond.IsOpenToAllStu == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaper.IsOpenToAllStu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaper.IsOpenToAllStu);
}
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.IsOpenToSchool) == true)
{
if (objvcc_CourseExamPaperCond.IsOpenToSchool == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaper.IsOpenToSchool);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaper.IsOpenToSchool);
}
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.IsOpenToSocial) == true)
{
if (objvcc_CourseExamPaperCond.IsOpenToSocial == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaper.IsOpenToSocial);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaper.IsOpenToSocial);
}
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.CourseChapterId, objvcc_CourseExamPaperCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.CourseChapterName, objvcc_CourseExamPaperCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.ChapterId) == true)
{
string strComparisonOpChapterId = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.ChapterId, objvcc_CourseExamPaperCond.ChapterId, strComparisonOpChapterId);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.SectionId) == true)
{
string strComparisonOpSectionId = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.SectionId, objvcc_CourseExamPaperCond.SectionId, strComparisonOpSectionId);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.ChapterName) == true)
{
string strComparisonOpChapterName = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.ChapterName, objvcc_CourseExamPaperCond.ChapterName, strComparisonOpChapterName);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.SectionName) == true)
{
string strComparisonOpSectionName = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.SectionName, objvcc_CourseExamPaperCond.SectionName, strComparisonOpSectionName);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.ChapterNameSim, objvcc_CourseExamPaperCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.SectionNameSim, objvcc_CourseExamPaperCond.SectionNameSim, strComparisonOpSectionNameSim);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.IsAutoGeneQuestion) == true)
{
if (objvcc_CourseExamPaperCond.IsAutoGeneQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaper.IsAutoGeneQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaper.IsAutoGeneQuestion);
}
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.IsCanMultiDo) == true)
{
if (objvcc_CourseExamPaperCond.IsCanMultiDo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaper.IsCanMultiDo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaper.IsCanMultiDo);
}
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.UpdDate, objvcc_CourseExamPaperCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.UpdUserId, objvcc_CourseExamPaperCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.Memo) == true)
{
string strComparisonOpMemo = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.Memo, objvcc_CourseExamPaperCond.Memo, strComparisonOpMemo);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.QuestionNum) == true)
{
string strComparisonOpQuestionNum = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.QuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.QuestionNum, objvcc_CourseExamPaperCond.QuestionNum, strComparisonOpQuestionNum);
}
if (objvcc_CourseExamPaperCond.IsUpdated(convcc_CourseExamPaper.BigTopicNum) == true)
{
string strComparisonOpBigTopicNum = objvcc_CourseExamPaperCond.dicFldComparisonOp[convcc_CourseExamPaper.BigTopicNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.BigTopicNum, objvcc_CourseExamPaperCond.BigTopicNum, strComparisonOpBigTopicNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_CourseExamPaper
{
public virtual bool UpdRelaTabDate(string strCourseExamPaperId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v考卷(vcc_CourseExamPaper)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseExamPaperBL
{
public static RelatedActions_vcc_CourseExamPaper relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_CourseExamPaperDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_CourseExamPaperDA vcc_CourseExamPaperDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_CourseExamPaperDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_CourseExamPaperBL()
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
if (string.IsNullOrEmpty(clsvcc_CourseExamPaperEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseExamPaperEN._ConnectString);
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
public static DataTable GetDataTable_vcc_CourseExamPaper(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_CourseExamPaperDA.GetDataTable_vcc_CourseExamPaper(strWhereCond);
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
objDT = vcc_CourseExamPaperDA.GetDataTable(strWhereCond);
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
objDT = vcc_CourseExamPaperDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_CourseExamPaperDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_CourseExamPaperDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_CourseExamPaperDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_CourseExamPaperDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_CourseExamPaperDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_CourseExamPaperDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCourseExamPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_CourseExamPaperEN> GetObjLstByCourseExamPaperIdLst(List<string> arrCourseExamPaperIdLst)
{
List<clsvcc_CourseExamPaperEN> arrObjLst = new List<clsvcc_CourseExamPaperEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCourseExamPaperIdLst, true);
 string strWhereCond = string.Format("CourseExamPaperId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN();
try
{
objvcc_CourseExamPaperEN.CourseExamPaperId = objRow[convcc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperEN.CourseId = objRow[convcc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperEN.CourseName = objRow[convcc_CourseExamPaper.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperEN.ExamPaperName = objRow[convcc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperEN.PaperIndex = objRow[convcc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objvcc_CourseExamPaperEN.ExamPaperTypeId = objRow[convcc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_CourseExamPaperEN.ExamPaperTypeName = objRow[convcc_CourseExamPaper.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objvcc_CourseExamPaperEN.TotalScore = objRow[convcc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objvcc_CourseExamPaperEN.ViewCount = objRow[convcc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseExamPaperEN.DoneNumber = objRow[convcc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objvcc_CourseExamPaperEN.PaperTime = objRow[convcc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_CourseExamPaperEN.DownloadNumber = objRow[convcc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objvcc_CourseExamPaperEN.CollectionCount = objRow[convcc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objvcc_CourseExamPaperEN.LikeCount = objRow[convcc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseExamPaperEN.IdXzMajor = objRow[convcc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseExamPaperEN.MajorName = objRow[convcc_CourseExamPaper.MajorName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.MajorName].ToString().Trim(); //专业名称
objvcc_CourseExamPaperEN.PaperDispModeId = objRow[convcc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objvcc_CourseExamPaperEN.PaperDispModeName = objRow[convcc_CourseExamPaper.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_CourseExamPaperEN.ExamCreateTime = objRow[convcc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_CourseExamPaperEN.CreateUserID = objRow[convcc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objvcc_CourseExamPaperEN.UserName = objRow[convcc_CourseExamPaper.UserName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UserName].ToString().Trim(); //用户名
objvcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseExamPaperEN.CourseChapterId = objRow[convcc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperEN.CourseChapterName = objRow[convcc_CourseExamPaper.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperEN.ChapterId = objRow[convcc_CourseExamPaper.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterId].ToString().Trim(); //章Id
objvcc_CourseExamPaperEN.SectionId = objRow[convcc_CourseExamPaper.SectionId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionId].ToString().Trim(); //节Id
objvcc_CourseExamPaperEN.ChapterName = objRow[convcc_CourseExamPaper.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterName].ToString().Trim(); //章名
objvcc_CourseExamPaperEN.SectionName = objRow[convcc_CourseExamPaper.SectionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionName].ToString().Trim(); //节名
objvcc_CourseExamPaperEN.ChapterNameSim = objRow[convcc_CourseExamPaper.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseExamPaperEN.SectionNameSim = objRow[convcc_CourseExamPaper.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_CourseExamPaperEN.UpdDate = objRow[convcc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperEN.UpdUserId = objRow[convcc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseExamPaperEN.Memo = objRow[convcc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.Memo].ToString().Trim(); //备注
objvcc_CourseExamPaperEN.QuestionNum = objRow[convcc_CourseExamPaper.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseExamPaperEN.BigTopicNum = objRow[convcc_CourseExamPaper.BigTopicNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.BigTopicNum].ToString().Trim()); //大标题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseExamPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_CourseExamPaperEN> GetObjLstByCourseExamPaperIdLstCache(List<string> arrCourseExamPaperIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperEN._CurrTabName, strCourseId);
List<clsvcc_CourseExamPaperEN> arrvcc_CourseExamPaperObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseExamPaperEN> arrvcc_CourseExamPaperObjLst_Sel =
arrvcc_CourseExamPaperObjLstCache
.Where(x => arrCourseExamPaperIdLst.Contains(x.CourseExamPaperId));
return arrvcc_CourseExamPaperObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseExamPaperEN> GetObjLst(string strWhereCond)
{
List<clsvcc_CourseExamPaperEN> arrObjLst = new List<clsvcc_CourseExamPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN();
try
{
objvcc_CourseExamPaperEN.CourseExamPaperId = objRow[convcc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperEN.CourseId = objRow[convcc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperEN.CourseName = objRow[convcc_CourseExamPaper.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperEN.ExamPaperName = objRow[convcc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperEN.PaperIndex = objRow[convcc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objvcc_CourseExamPaperEN.ExamPaperTypeId = objRow[convcc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_CourseExamPaperEN.ExamPaperTypeName = objRow[convcc_CourseExamPaper.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objvcc_CourseExamPaperEN.TotalScore = objRow[convcc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objvcc_CourseExamPaperEN.ViewCount = objRow[convcc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseExamPaperEN.DoneNumber = objRow[convcc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objvcc_CourseExamPaperEN.PaperTime = objRow[convcc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_CourseExamPaperEN.DownloadNumber = objRow[convcc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objvcc_CourseExamPaperEN.CollectionCount = objRow[convcc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objvcc_CourseExamPaperEN.LikeCount = objRow[convcc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseExamPaperEN.IdXzMajor = objRow[convcc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseExamPaperEN.MajorName = objRow[convcc_CourseExamPaper.MajorName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.MajorName].ToString().Trim(); //专业名称
objvcc_CourseExamPaperEN.PaperDispModeId = objRow[convcc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objvcc_CourseExamPaperEN.PaperDispModeName = objRow[convcc_CourseExamPaper.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_CourseExamPaperEN.ExamCreateTime = objRow[convcc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_CourseExamPaperEN.CreateUserID = objRow[convcc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objvcc_CourseExamPaperEN.UserName = objRow[convcc_CourseExamPaper.UserName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UserName].ToString().Trim(); //用户名
objvcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseExamPaperEN.CourseChapterId = objRow[convcc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperEN.CourseChapterName = objRow[convcc_CourseExamPaper.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperEN.ChapterId = objRow[convcc_CourseExamPaper.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterId].ToString().Trim(); //章Id
objvcc_CourseExamPaperEN.SectionId = objRow[convcc_CourseExamPaper.SectionId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionId].ToString().Trim(); //节Id
objvcc_CourseExamPaperEN.ChapterName = objRow[convcc_CourseExamPaper.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterName].ToString().Trim(); //章名
objvcc_CourseExamPaperEN.SectionName = objRow[convcc_CourseExamPaper.SectionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionName].ToString().Trim(); //节名
objvcc_CourseExamPaperEN.ChapterNameSim = objRow[convcc_CourseExamPaper.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseExamPaperEN.SectionNameSim = objRow[convcc_CourseExamPaper.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_CourseExamPaperEN.UpdDate = objRow[convcc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperEN.UpdUserId = objRow[convcc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseExamPaperEN.Memo = objRow[convcc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.Memo].ToString().Trim(); //备注
objvcc_CourseExamPaperEN.QuestionNum = objRow[convcc_CourseExamPaper.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseExamPaperEN.BigTopicNum = objRow[convcc_CourseExamPaper.BigTopicNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.BigTopicNum].ToString().Trim()); //大标题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperEN);
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
public static List<clsvcc_CourseExamPaperEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseExamPaperEN> arrObjLst = new List<clsvcc_CourseExamPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN();
try
{
objvcc_CourseExamPaperEN.CourseExamPaperId = objRow[convcc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperEN.CourseId = objRow[convcc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperEN.CourseName = objRow[convcc_CourseExamPaper.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperEN.ExamPaperName = objRow[convcc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperEN.PaperIndex = objRow[convcc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objvcc_CourseExamPaperEN.ExamPaperTypeId = objRow[convcc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_CourseExamPaperEN.ExamPaperTypeName = objRow[convcc_CourseExamPaper.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objvcc_CourseExamPaperEN.TotalScore = objRow[convcc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objvcc_CourseExamPaperEN.ViewCount = objRow[convcc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseExamPaperEN.DoneNumber = objRow[convcc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objvcc_CourseExamPaperEN.PaperTime = objRow[convcc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_CourseExamPaperEN.DownloadNumber = objRow[convcc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objvcc_CourseExamPaperEN.CollectionCount = objRow[convcc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objvcc_CourseExamPaperEN.LikeCount = objRow[convcc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseExamPaperEN.IdXzMajor = objRow[convcc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseExamPaperEN.MajorName = objRow[convcc_CourseExamPaper.MajorName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.MajorName].ToString().Trim(); //专业名称
objvcc_CourseExamPaperEN.PaperDispModeId = objRow[convcc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objvcc_CourseExamPaperEN.PaperDispModeName = objRow[convcc_CourseExamPaper.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_CourseExamPaperEN.ExamCreateTime = objRow[convcc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_CourseExamPaperEN.CreateUserID = objRow[convcc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objvcc_CourseExamPaperEN.UserName = objRow[convcc_CourseExamPaper.UserName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UserName].ToString().Trim(); //用户名
objvcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseExamPaperEN.CourseChapterId = objRow[convcc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperEN.CourseChapterName = objRow[convcc_CourseExamPaper.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperEN.ChapterId = objRow[convcc_CourseExamPaper.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterId].ToString().Trim(); //章Id
objvcc_CourseExamPaperEN.SectionId = objRow[convcc_CourseExamPaper.SectionId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionId].ToString().Trim(); //节Id
objvcc_CourseExamPaperEN.ChapterName = objRow[convcc_CourseExamPaper.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterName].ToString().Trim(); //章名
objvcc_CourseExamPaperEN.SectionName = objRow[convcc_CourseExamPaper.SectionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionName].ToString().Trim(); //节名
objvcc_CourseExamPaperEN.ChapterNameSim = objRow[convcc_CourseExamPaper.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseExamPaperEN.SectionNameSim = objRow[convcc_CourseExamPaper.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_CourseExamPaperEN.UpdDate = objRow[convcc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperEN.UpdUserId = objRow[convcc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseExamPaperEN.Memo = objRow[convcc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.Memo].ToString().Trim(); //备注
objvcc_CourseExamPaperEN.QuestionNum = objRow[convcc_CourseExamPaper.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseExamPaperEN.BigTopicNum = objRow[convcc_CourseExamPaper.BigTopicNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.BigTopicNum].ToString().Trim()); //大标题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_CourseExamPaperEN> GetSubObjLstCache(clsvcc_CourseExamPaperEN objvcc_CourseExamPaperCond)
{
 string strCourseId = objvcc_CourseExamPaperCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvcc_CourseExamPaperBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvcc_CourseExamPaperEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseExamPaperEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseExamPaper.AttributeName)
{
if (objvcc_CourseExamPaperCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseExamPaperCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseExamPaperCond[strFldName].ToString());
}
else
{
if (objvcc_CourseExamPaperCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseExamPaperCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseExamPaperCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseExamPaperCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseExamPaperCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseExamPaperCond[strFldName]));
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
public static List<clsvcc_CourseExamPaperEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_CourseExamPaperEN> arrObjLst = new List<clsvcc_CourseExamPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN();
try
{
objvcc_CourseExamPaperEN.CourseExamPaperId = objRow[convcc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperEN.CourseId = objRow[convcc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperEN.CourseName = objRow[convcc_CourseExamPaper.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperEN.ExamPaperName = objRow[convcc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperEN.PaperIndex = objRow[convcc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objvcc_CourseExamPaperEN.ExamPaperTypeId = objRow[convcc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_CourseExamPaperEN.ExamPaperTypeName = objRow[convcc_CourseExamPaper.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objvcc_CourseExamPaperEN.TotalScore = objRow[convcc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objvcc_CourseExamPaperEN.ViewCount = objRow[convcc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseExamPaperEN.DoneNumber = objRow[convcc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objvcc_CourseExamPaperEN.PaperTime = objRow[convcc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_CourseExamPaperEN.DownloadNumber = objRow[convcc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objvcc_CourseExamPaperEN.CollectionCount = objRow[convcc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objvcc_CourseExamPaperEN.LikeCount = objRow[convcc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseExamPaperEN.IdXzMajor = objRow[convcc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseExamPaperEN.MajorName = objRow[convcc_CourseExamPaper.MajorName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.MajorName].ToString().Trim(); //专业名称
objvcc_CourseExamPaperEN.PaperDispModeId = objRow[convcc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objvcc_CourseExamPaperEN.PaperDispModeName = objRow[convcc_CourseExamPaper.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_CourseExamPaperEN.ExamCreateTime = objRow[convcc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_CourseExamPaperEN.CreateUserID = objRow[convcc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objvcc_CourseExamPaperEN.UserName = objRow[convcc_CourseExamPaper.UserName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UserName].ToString().Trim(); //用户名
objvcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseExamPaperEN.CourseChapterId = objRow[convcc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperEN.CourseChapterName = objRow[convcc_CourseExamPaper.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperEN.ChapterId = objRow[convcc_CourseExamPaper.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterId].ToString().Trim(); //章Id
objvcc_CourseExamPaperEN.SectionId = objRow[convcc_CourseExamPaper.SectionId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionId].ToString().Trim(); //节Id
objvcc_CourseExamPaperEN.ChapterName = objRow[convcc_CourseExamPaper.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterName].ToString().Trim(); //章名
objvcc_CourseExamPaperEN.SectionName = objRow[convcc_CourseExamPaper.SectionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionName].ToString().Trim(); //节名
objvcc_CourseExamPaperEN.ChapterNameSim = objRow[convcc_CourseExamPaper.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseExamPaperEN.SectionNameSim = objRow[convcc_CourseExamPaper.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_CourseExamPaperEN.UpdDate = objRow[convcc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperEN.UpdUserId = objRow[convcc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseExamPaperEN.Memo = objRow[convcc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.Memo].ToString().Trim(); //备注
objvcc_CourseExamPaperEN.QuestionNum = objRow[convcc_CourseExamPaper.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseExamPaperEN.BigTopicNum = objRow[convcc_CourseExamPaper.BigTopicNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.BigTopicNum].ToString().Trim()); //大标题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperEN);
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
public static List<clsvcc_CourseExamPaperEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_CourseExamPaperEN> arrObjLst = new List<clsvcc_CourseExamPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN();
try
{
objvcc_CourseExamPaperEN.CourseExamPaperId = objRow[convcc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperEN.CourseId = objRow[convcc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperEN.CourseName = objRow[convcc_CourseExamPaper.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperEN.ExamPaperName = objRow[convcc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperEN.PaperIndex = objRow[convcc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objvcc_CourseExamPaperEN.ExamPaperTypeId = objRow[convcc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_CourseExamPaperEN.ExamPaperTypeName = objRow[convcc_CourseExamPaper.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objvcc_CourseExamPaperEN.TotalScore = objRow[convcc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objvcc_CourseExamPaperEN.ViewCount = objRow[convcc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseExamPaperEN.DoneNumber = objRow[convcc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objvcc_CourseExamPaperEN.PaperTime = objRow[convcc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_CourseExamPaperEN.DownloadNumber = objRow[convcc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objvcc_CourseExamPaperEN.CollectionCount = objRow[convcc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objvcc_CourseExamPaperEN.LikeCount = objRow[convcc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseExamPaperEN.IdXzMajor = objRow[convcc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseExamPaperEN.MajorName = objRow[convcc_CourseExamPaper.MajorName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.MajorName].ToString().Trim(); //专业名称
objvcc_CourseExamPaperEN.PaperDispModeId = objRow[convcc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objvcc_CourseExamPaperEN.PaperDispModeName = objRow[convcc_CourseExamPaper.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_CourseExamPaperEN.ExamCreateTime = objRow[convcc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_CourseExamPaperEN.CreateUserID = objRow[convcc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objvcc_CourseExamPaperEN.UserName = objRow[convcc_CourseExamPaper.UserName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UserName].ToString().Trim(); //用户名
objvcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseExamPaperEN.CourseChapterId = objRow[convcc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperEN.CourseChapterName = objRow[convcc_CourseExamPaper.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperEN.ChapterId = objRow[convcc_CourseExamPaper.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterId].ToString().Trim(); //章Id
objvcc_CourseExamPaperEN.SectionId = objRow[convcc_CourseExamPaper.SectionId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionId].ToString().Trim(); //节Id
objvcc_CourseExamPaperEN.ChapterName = objRow[convcc_CourseExamPaper.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterName].ToString().Trim(); //章名
objvcc_CourseExamPaperEN.SectionName = objRow[convcc_CourseExamPaper.SectionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionName].ToString().Trim(); //节名
objvcc_CourseExamPaperEN.ChapterNameSim = objRow[convcc_CourseExamPaper.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseExamPaperEN.SectionNameSim = objRow[convcc_CourseExamPaper.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_CourseExamPaperEN.UpdDate = objRow[convcc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperEN.UpdUserId = objRow[convcc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseExamPaperEN.Memo = objRow[convcc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.Memo].ToString().Trim(); //备注
objvcc_CourseExamPaperEN.QuestionNum = objRow[convcc_CourseExamPaper.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseExamPaperEN.BigTopicNum = objRow[convcc_CourseExamPaper.BigTopicNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.BigTopicNum].ToString().Trim()); //大标题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperEN);
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
List<clsvcc_CourseExamPaperEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_CourseExamPaperEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseExamPaperEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_CourseExamPaperEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseExamPaperEN> arrObjLst = new List<clsvcc_CourseExamPaperEN>(); 
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
	clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN();
try
{
objvcc_CourseExamPaperEN.CourseExamPaperId = objRow[convcc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperEN.CourseId = objRow[convcc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperEN.CourseName = objRow[convcc_CourseExamPaper.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperEN.ExamPaperName = objRow[convcc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperEN.PaperIndex = objRow[convcc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objvcc_CourseExamPaperEN.ExamPaperTypeId = objRow[convcc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_CourseExamPaperEN.ExamPaperTypeName = objRow[convcc_CourseExamPaper.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objvcc_CourseExamPaperEN.TotalScore = objRow[convcc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objvcc_CourseExamPaperEN.ViewCount = objRow[convcc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseExamPaperEN.DoneNumber = objRow[convcc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objvcc_CourseExamPaperEN.PaperTime = objRow[convcc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_CourseExamPaperEN.DownloadNumber = objRow[convcc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objvcc_CourseExamPaperEN.CollectionCount = objRow[convcc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objvcc_CourseExamPaperEN.LikeCount = objRow[convcc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseExamPaperEN.IdXzMajor = objRow[convcc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseExamPaperEN.MajorName = objRow[convcc_CourseExamPaper.MajorName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.MajorName].ToString().Trim(); //专业名称
objvcc_CourseExamPaperEN.PaperDispModeId = objRow[convcc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objvcc_CourseExamPaperEN.PaperDispModeName = objRow[convcc_CourseExamPaper.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_CourseExamPaperEN.ExamCreateTime = objRow[convcc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_CourseExamPaperEN.CreateUserID = objRow[convcc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objvcc_CourseExamPaperEN.UserName = objRow[convcc_CourseExamPaper.UserName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UserName].ToString().Trim(); //用户名
objvcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseExamPaperEN.CourseChapterId = objRow[convcc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperEN.CourseChapterName = objRow[convcc_CourseExamPaper.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperEN.ChapterId = objRow[convcc_CourseExamPaper.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterId].ToString().Trim(); //章Id
objvcc_CourseExamPaperEN.SectionId = objRow[convcc_CourseExamPaper.SectionId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionId].ToString().Trim(); //节Id
objvcc_CourseExamPaperEN.ChapterName = objRow[convcc_CourseExamPaper.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterName].ToString().Trim(); //章名
objvcc_CourseExamPaperEN.SectionName = objRow[convcc_CourseExamPaper.SectionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionName].ToString().Trim(); //节名
objvcc_CourseExamPaperEN.ChapterNameSim = objRow[convcc_CourseExamPaper.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseExamPaperEN.SectionNameSim = objRow[convcc_CourseExamPaper.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_CourseExamPaperEN.UpdDate = objRow[convcc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperEN.UpdUserId = objRow[convcc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseExamPaperEN.Memo = objRow[convcc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.Memo].ToString().Trim(); //备注
objvcc_CourseExamPaperEN.QuestionNum = objRow[convcc_CourseExamPaper.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseExamPaperEN.BigTopicNum = objRow[convcc_CourseExamPaper.BigTopicNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.BigTopicNum].ToString().Trim()); //大标题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperEN);
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
public static List<clsvcc_CourseExamPaperEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseExamPaperEN> arrObjLst = new List<clsvcc_CourseExamPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN();
try
{
objvcc_CourseExamPaperEN.CourseExamPaperId = objRow[convcc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperEN.CourseId = objRow[convcc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperEN.CourseName = objRow[convcc_CourseExamPaper.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperEN.ExamPaperName = objRow[convcc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperEN.PaperIndex = objRow[convcc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objvcc_CourseExamPaperEN.ExamPaperTypeId = objRow[convcc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_CourseExamPaperEN.ExamPaperTypeName = objRow[convcc_CourseExamPaper.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objvcc_CourseExamPaperEN.TotalScore = objRow[convcc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objvcc_CourseExamPaperEN.ViewCount = objRow[convcc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseExamPaperEN.DoneNumber = objRow[convcc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objvcc_CourseExamPaperEN.PaperTime = objRow[convcc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_CourseExamPaperEN.DownloadNumber = objRow[convcc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objvcc_CourseExamPaperEN.CollectionCount = objRow[convcc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objvcc_CourseExamPaperEN.LikeCount = objRow[convcc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseExamPaperEN.IdXzMajor = objRow[convcc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseExamPaperEN.MajorName = objRow[convcc_CourseExamPaper.MajorName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.MajorName].ToString().Trim(); //专业名称
objvcc_CourseExamPaperEN.PaperDispModeId = objRow[convcc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objvcc_CourseExamPaperEN.PaperDispModeName = objRow[convcc_CourseExamPaper.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_CourseExamPaperEN.ExamCreateTime = objRow[convcc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_CourseExamPaperEN.CreateUserID = objRow[convcc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objvcc_CourseExamPaperEN.UserName = objRow[convcc_CourseExamPaper.UserName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UserName].ToString().Trim(); //用户名
objvcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseExamPaperEN.CourseChapterId = objRow[convcc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperEN.CourseChapterName = objRow[convcc_CourseExamPaper.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperEN.ChapterId = objRow[convcc_CourseExamPaper.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterId].ToString().Trim(); //章Id
objvcc_CourseExamPaperEN.SectionId = objRow[convcc_CourseExamPaper.SectionId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionId].ToString().Trim(); //节Id
objvcc_CourseExamPaperEN.ChapterName = objRow[convcc_CourseExamPaper.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterName].ToString().Trim(); //章名
objvcc_CourseExamPaperEN.SectionName = objRow[convcc_CourseExamPaper.SectionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionName].ToString().Trim(); //节名
objvcc_CourseExamPaperEN.ChapterNameSim = objRow[convcc_CourseExamPaper.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseExamPaperEN.SectionNameSim = objRow[convcc_CourseExamPaper.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_CourseExamPaperEN.UpdDate = objRow[convcc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperEN.UpdUserId = objRow[convcc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseExamPaperEN.Memo = objRow[convcc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.Memo].ToString().Trim(); //备注
objvcc_CourseExamPaperEN.QuestionNum = objRow[convcc_CourseExamPaper.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseExamPaperEN.BigTopicNum = objRow[convcc_CourseExamPaper.BigTopicNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.BigTopicNum].ToString().Trim()); //大标题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_CourseExamPaperEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_CourseExamPaperEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseExamPaperEN> arrObjLst = new List<clsvcc_CourseExamPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN();
try
{
objvcc_CourseExamPaperEN.CourseExamPaperId = objRow[convcc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperEN.CourseId = objRow[convcc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperEN.CourseName = objRow[convcc_CourseExamPaper.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperEN.ExamPaperName = objRow[convcc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperEN.PaperIndex = objRow[convcc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objvcc_CourseExamPaperEN.ExamPaperTypeId = objRow[convcc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_CourseExamPaperEN.ExamPaperTypeName = objRow[convcc_CourseExamPaper.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objvcc_CourseExamPaperEN.TotalScore = objRow[convcc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objvcc_CourseExamPaperEN.ViewCount = objRow[convcc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseExamPaperEN.DoneNumber = objRow[convcc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objvcc_CourseExamPaperEN.PaperTime = objRow[convcc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_CourseExamPaperEN.DownloadNumber = objRow[convcc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objvcc_CourseExamPaperEN.CollectionCount = objRow[convcc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objvcc_CourseExamPaperEN.LikeCount = objRow[convcc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseExamPaperEN.IdXzMajor = objRow[convcc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseExamPaperEN.MajorName = objRow[convcc_CourseExamPaper.MajorName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.MajorName].ToString().Trim(); //专业名称
objvcc_CourseExamPaperEN.PaperDispModeId = objRow[convcc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objvcc_CourseExamPaperEN.PaperDispModeName = objRow[convcc_CourseExamPaper.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_CourseExamPaperEN.ExamCreateTime = objRow[convcc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_CourseExamPaperEN.CreateUserID = objRow[convcc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objvcc_CourseExamPaperEN.UserName = objRow[convcc_CourseExamPaper.UserName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UserName].ToString().Trim(); //用户名
objvcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseExamPaperEN.CourseChapterId = objRow[convcc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperEN.CourseChapterName = objRow[convcc_CourseExamPaper.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperEN.ChapterId = objRow[convcc_CourseExamPaper.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterId].ToString().Trim(); //章Id
objvcc_CourseExamPaperEN.SectionId = objRow[convcc_CourseExamPaper.SectionId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionId].ToString().Trim(); //节Id
objvcc_CourseExamPaperEN.ChapterName = objRow[convcc_CourseExamPaper.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterName].ToString().Trim(); //章名
objvcc_CourseExamPaperEN.SectionName = objRow[convcc_CourseExamPaper.SectionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionName].ToString().Trim(); //节名
objvcc_CourseExamPaperEN.ChapterNameSim = objRow[convcc_CourseExamPaper.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseExamPaperEN.SectionNameSim = objRow[convcc_CourseExamPaper.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_CourseExamPaperEN.UpdDate = objRow[convcc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperEN.UpdUserId = objRow[convcc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseExamPaperEN.Memo = objRow[convcc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.Memo].ToString().Trim(); //备注
objvcc_CourseExamPaperEN.QuestionNum = objRow[convcc_CourseExamPaper.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseExamPaperEN.BigTopicNum = objRow[convcc_CourseExamPaper.BigTopicNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.BigTopicNum].ToString().Trim()); //大标题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperEN);
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
public static List<clsvcc_CourseExamPaperEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_CourseExamPaperEN> arrObjLst = new List<clsvcc_CourseExamPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN();
try
{
objvcc_CourseExamPaperEN.CourseExamPaperId = objRow[convcc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperEN.CourseId = objRow[convcc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperEN.CourseName = objRow[convcc_CourseExamPaper.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperEN.ExamPaperName = objRow[convcc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperEN.PaperIndex = objRow[convcc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objvcc_CourseExamPaperEN.ExamPaperTypeId = objRow[convcc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_CourseExamPaperEN.ExamPaperTypeName = objRow[convcc_CourseExamPaper.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objvcc_CourseExamPaperEN.TotalScore = objRow[convcc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objvcc_CourseExamPaperEN.ViewCount = objRow[convcc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseExamPaperEN.DoneNumber = objRow[convcc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objvcc_CourseExamPaperEN.PaperTime = objRow[convcc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_CourseExamPaperEN.DownloadNumber = objRow[convcc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objvcc_CourseExamPaperEN.CollectionCount = objRow[convcc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objvcc_CourseExamPaperEN.LikeCount = objRow[convcc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseExamPaperEN.IdXzMajor = objRow[convcc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseExamPaperEN.MajorName = objRow[convcc_CourseExamPaper.MajorName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.MajorName].ToString().Trim(); //专业名称
objvcc_CourseExamPaperEN.PaperDispModeId = objRow[convcc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objvcc_CourseExamPaperEN.PaperDispModeName = objRow[convcc_CourseExamPaper.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_CourseExamPaperEN.ExamCreateTime = objRow[convcc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_CourseExamPaperEN.CreateUserID = objRow[convcc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objvcc_CourseExamPaperEN.UserName = objRow[convcc_CourseExamPaper.UserName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UserName].ToString().Trim(); //用户名
objvcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseExamPaperEN.CourseChapterId = objRow[convcc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperEN.CourseChapterName = objRow[convcc_CourseExamPaper.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperEN.ChapterId = objRow[convcc_CourseExamPaper.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterId].ToString().Trim(); //章Id
objvcc_CourseExamPaperEN.SectionId = objRow[convcc_CourseExamPaper.SectionId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionId].ToString().Trim(); //节Id
objvcc_CourseExamPaperEN.ChapterName = objRow[convcc_CourseExamPaper.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterName].ToString().Trim(); //章名
objvcc_CourseExamPaperEN.SectionName = objRow[convcc_CourseExamPaper.SectionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionName].ToString().Trim(); //节名
objvcc_CourseExamPaperEN.ChapterNameSim = objRow[convcc_CourseExamPaper.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseExamPaperEN.SectionNameSim = objRow[convcc_CourseExamPaper.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_CourseExamPaperEN.UpdDate = objRow[convcc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperEN.UpdUserId = objRow[convcc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseExamPaperEN.Memo = objRow[convcc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.Memo].ToString().Trim(); //备注
objvcc_CourseExamPaperEN.QuestionNum = objRow[convcc_CourseExamPaper.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseExamPaperEN.BigTopicNum = objRow[convcc_CourseExamPaper.BigTopicNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.BigTopicNum].ToString().Trim()); //大标题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseExamPaperEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_CourseExamPaperEN> arrObjLst = new List<clsvcc_CourseExamPaperEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN();
try
{
objvcc_CourseExamPaperEN.CourseExamPaperId = objRow[convcc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperEN.CourseId = objRow[convcc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperEN.CourseName = objRow[convcc_CourseExamPaper.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperEN.ExamPaperName = objRow[convcc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperEN.PaperIndex = objRow[convcc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objvcc_CourseExamPaperEN.ExamPaperTypeId = objRow[convcc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_CourseExamPaperEN.ExamPaperTypeName = objRow[convcc_CourseExamPaper.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objvcc_CourseExamPaperEN.TotalScore = objRow[convcc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objvcc_CourseExamPaperEN.ViewCount = objRow[convcc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseExamPaperEN.DoneNumber = objRow[convcc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objvcc_CourseExamPaperEN.PaperTime = objRow[convcc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_CourseExamPaperEN.DownloadNumber = objRow[convcc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objvcc_CourseExamPaperEN.CollectionCount = objRow[convcc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objvcc_CourseExamPaperEN.LikeCount = objRow[convcc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseExamPaperEN.IdXzMajor = objRow[convcc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseExamPaperEN.MajorName = objRow[convcc_CourseExamPaper.MajorName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.MajorName].ToString().Trim(); //专业名称
objvcc_CourseExamPaperEN.PaperDispModeId = objRow[convcc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objvcc_CourseExamPaperEN.PaperDispModeName = objRow[convcc_CourseExamPaper.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_CourseExamPaperEN.ExamCreateTime = objRow[convcc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_CourseExamPaperEN.CreateUserID = objRow[convcc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objvcc_CourseExamPaperEN.UserName = objRow[convcc_CourseExamPaper.UserName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UserName].ToString().Trim(); //用户名
objvcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objvcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objvcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objvcc_CourseExamPaperEN.CourseChapterId = objRow[convcc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperEN.CourseChapterName = objRow[convcc_CourseExamPaper.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperEN.ChapterId = objRow[convcc_CourseExamPaper.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterId].ToString().Trim(); //章Id
objvcc_CourseExamPaperEN.SectionId = objRow[convcc_CourseExamPaper.SectionId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionId].ToString().Trim(); //节Id
objvcc_CourseExamPaperEN.ChapterName = objRow[convcc_CourseExamPaper.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterName].ToString().Trim(); //章名
objvcc_CourseExamPaperEN.SectionName = objRow[convcc_CourseExamPaper.SectionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionName].ToString().Trim(); //节名
objvcc_CourseExamPaperEN.ChapterNameSim = objRow[convcc_CourseExamPaper.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseExamPaperEN.SectionNameSim = objRow[convcc_CourseExamPaper.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_CourseExamPaperEN.UpdDate = objRow[convcc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperEN.UpdUserId = objRow[convcc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_CourseExamPaperEN.Memo = objRow[convcc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[convcc_CourseExamPaper.Memo].ToString().Trim(); //备注
objvcc_CourseExamPaperEN.QuestionNum = objRow[convcc_CourseExamPaper.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseExamPaperEN.BigTopicNum = objRow[convcc_CourseExamPaper.BigTopicNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaper.BigTopicNum].ToString().Trim()); //大标题数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseExamPaperEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_CourseExamPaper(ref clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN)
{
bool bolResult = vcc_CourseExamPaperDA.Getvcc_CourseExamPaper(ref objvcc_CourseExamPaperEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseExamPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseExamPaperEN GetObjByCourseExamPaperId(string strCourseExamPaperId)
{
if (strCourseExamPaperId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCourseExamPaperId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCourseExamPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCourseExamPaperId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = vcc_CourseExamPaperDA.GetObjByCourseExamPaperId(strCourseExamPaperId);
return objvcc_CourseExamPaperEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_CourseExamPaperEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = vcc_CourseExamPaperDA.GetFirstObj(strWhereCond);
 return objvcc_CourseExamPaperEN;
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
public static clsvcc_CourseExamPaperEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = vcc_CourseExamPaperDA.GetObjByDataRow(objRow);
 return objvcc_CourseExamPaperEN;
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
public static clsvcc_CourseExamPaperEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = vcc_CourseExamPaperDA.GetObjByDataRow(objRow);
 return objvcc_CourseExamPaperEN;
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
 /// <param name = "strCourseExamPaperId">所给的关键字</param>
 /// <param name = "lstvcc_CourseExamPaperObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseExamPaperEN GetObjByCourseExamPaperIdFromList(string strCourseExamPaperId, List<clsvcc_CourseExamPaperEN> lstvcc_CourseExamPaperObjLst)
{
foreach (clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN in lstvcc_CourseExamPaperObjLst)
{
if (objvcc_CourseExamPaperEN.CourseExamPaperId == strCourseExamPaperId)
{
return objvcc_CourseExamPaperEN;
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
 string strCourseExamPaperId;
 try
 {
 strCourseExamPaperId = new clsvcc_CourseExamPaperDA().GetFirstID(strWhereCond);
 return strCourseExamPaperId;
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
 arrList = vcc_CourseExamPaperDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_CourseExamPaperDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCourseExamPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCourseExamPaperId)
{
if (string.IsNullOrEmpty(strCourseExamPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCourseExamPaperId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vcc_CourseExamPaperDA.IsExist(strCourseExamPaperId);
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
 bolIsExist = clsvcc_CourseExamPaperDA.IsExistTable();
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
 bolIsExist = vcc_CourseExamPaperDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_CourseExamPaperENS">源对象</param>
 /// <param name = "objvcc_CourseExamPaperENT">目标对象</param>
 public static void CopyTo(clsvcc_CourseExamPaperEN objvcc_CourseExamPaperENS, clsvcc_CourseExamPaperEN objvcc_CourseExamPaperENT)
{
try
{
objvcc_CourseExamPaperENT.CourseExamPaperId = objvcc_CourseExamPaperENS.CourseExamPaperId; //考卷流水号
objvcc_CourseExamPaperENT.CourseId = objvcc_CourseExamPaperENS.CourseId; //课程Id
objvcc_CourseExamPaperENT.CourseName = objvcc_CourseExamPaperENS.CourseName; //课程名称
objvcc_CourseExamPaperENT.ExamPaperName = objvcc_CourseExamPaperENS.ExamPaperName; //考卷名称
objvcc_CourseExamPaperENT.PaperIndex = objvcc_CourseExamPaperENS.PaperIndex; //试卷序号
objvcc_CourseExamPaperENT.ExamPaperTypeId = objvcc_CourseExamPaperENS.ExamPaperTypeId; //试卷类型Id
objvcc_CourseExamPaperENT.ExamPaperTypeName = objvcc_CourseExamPaperENS.ExamPaperTypeName; //试卷类型名称
objvcc_CourseExamPaperENT.IsShow = objvcc_CourseExamPaperENS.IsShow; //是否启用
objvcc_CourseExamPaperENT.TotalScore = objvcc_CourseExamPaperENS.TotalScore; //总得分
objvcc_CourseExamPaperENT.ViewCount = objvcc_CourseExamPaperENS.ViewCount; //浏览量
objvcc_CourseExamPaperENT.DoneNumber = objvcc_CourseExamPaperENS.DoneNumber; //已做人数
objvcc_CourseExamPaperENT.PaperTime = objvcc_CourseExamPaperENS.PaperTime; //考试时间（分钟）
objvcc_CourseExamPaperENT.DownloadNumber = objvcc_CourseExamPaperENS.DownloadNumber; //下载数目
objvcc_CourseExamPaperENT.CollectionCount = objvcc_CourseExamPaperENS.CollectionCount; //收藏数量
objvcc_CourseExamPaperENT.LikeCount = objvcc_CourseExamPaperENS.LikeCount; //资源喜欢数量
objvcc_CourseExamPaperENT.IdXzMajor = objvcc_CourseExamPaperENS.IdXzMajor; //专业流水号
objvcc_CourseExamPaperENT.MajorName = objvcc_CourseExamPaperENS.MajorName; //专业名称
objvcc_CourseExamPaperENT.PaperDispModeId = objvcc_CourseExamPaperENS.PaperDispModeId; //试卷显示模式Id
objvcc_CourseExamPaperENT.PaperDispModeName = objvcc_CourseExamPaperENS.PaperDispModeName; //试卷显示模式名称
objvcc_CourseExamPaperENT.ExamCreateTime = objvcc_CourseExamPaperENS.ExamCreateTime; //考卷建立时间
objvcc_CourseExamPaperENT.CreateUserID = objvcc_CourseExamPaperENS.CreateUserID; //建立用户ID
objvcc_CourseExamPaperENT.UserName = objvcc_CourseExamPaperENS.UserName; //用户名
objvcc_CourseExamPaperENT.IsOpenToAllStu = objvcc_CourseExamPaperENS.IsOpenToAllStu; //全校师生
objvcc_CourseExamPaperENT.IsOpenToSchool = objvcc_CourseExamPaperENS.IsOpenToSchool; //全校师生公开
objvcc_CourseExamPaperENT.IsOpenToSocial = objvcc_CourseExamPaperENS.IsOpenToSocial; //社会公众
objvcc_CourseExamPaperENT.CourseChapterId = objvcc_CourseExamPaperENS.CourseChapterId; //课程章节ID
objvcc_CourseExamPaperENT.CourseChapterName = objvcc_CourseExamPaperENS.CourseChapterName; //课程章节名称
objvcc_CourseExamPaperENT.ChapterId = objvcc_CourseExamPaperENS.ChapterId; //章Id
objvcc_CourseExamPaperENT.SectionId = objvcc_CourseExamPaperENS.SectionId; //节Id
objvcc_CourseExamPaperENT.ChapterName = objvcc_CourseExamPaperENS.ChapterName; //章名
objvcc_CourseExamPaperENT.SectionName = objvcc_CourseExamPaperENS.SectionName; //节名
objvcc_CourseExamPaperENT.ChapterNameSim = objvcc_CourseExamPaperENS.ChapterNameSim; //章名简称
objvcc_CourseExamPaperENT.SectionNameSim = objvcc_CourseExamPaperENS.SectionNameSim; //节名简称
objvcc_CourseExamPaperENT.IsAutoGeneQuestion = objvcc_CourseExamPaperENS.IsAutoGeneQuestion; //是否自动生成题目
objvcc_CourseExamPaperENT.IsCanMultiDo = objvcc_CourseExamPaperENS.IsCanMultiDo; //是否可以做多次
objvcc_CourseExamPaperENT.UpdDate = objvcc_CourseExamPaperENS.UpdDate; //修改日期
objvcc_CourseExamPaperENT.UpdUserId = objvcc_CourseExamPaperENS.UpdUserId; //修改用户Id
objvcc_CourseExamPaperENT.Memo = objvcc_CourseExamPaperENS.Memo; //备注
objvcc_CourseExamPaperENT.QuestionNum = objvcc_CourseExamPaperENS.QuestionNum; //题目数
objvcc_CourseExamPaperENT.BigTopicNum = objvcc_CourseExamPaperENS.BigTopicNum; //大标题数
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
 /// <param name = "objvcc_CourseExamPaperEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN)
{
try
{
objvcc_CourseExamPaperEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_CourseExamPaperEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_CourseExamPaper.CourseExamPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.CourseExamPaperId = objvcc_CourseExamPaperEN.CourseExamPaperId; //考卷流水号
}
if (arrFldSet.Contains(convcc_CourseExamPaper.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.CourseId = objvcc_CourseExamPaperEN.CourseId == "[null]" ? null :  objvcc_CourseExamPaperEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_CourseExamPaper.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.CourseName = objvcc_CourseExamPaperEN.CourseName == "[null]" ? null :  objvcc_CourseExamPaperEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_CourseExamPaper.ExamPaperName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.ExamPaperName = objvcc_CourseExamPaperEN.ExamPaperName == "[null]" ? null :  objvcc_CourseExamPaperEN.ExamPaperName; //考卷名称
}
if (arrFldSet.Contains(convcc_CourseExamPaper.PaperIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.PaperIndex = objvcc_CourseExamPaperEN.PaperIndex; //试卷序号
}
if (arrFldSet.Contains(convcc_CourseExamPaper.ExamPaperTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.ExamPaperTypeId = objvcc_CourseExamPaperEN.ExamPaperTypeId; //试卷类型Id
}
if (arrFldSet.Contains(convcc_CourseExamPaper.ExamPaperTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.ExamPaperTypeName = objvcc_CourseExamPaperEN.ExamPaperTypeName == "[null]" ? null :  objvcc_CourseExamPaperEN.ExamPaperTypeName; //试卷类型名称
}
if (arrFldSet.Contains(convcc_CourseExamPaper.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.IsShow = objvcc_CourseExamPaperEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convcc_CourseExamPaper.TotalScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.TotalScore = objvcc_CourseExamPaperEN.TotalScore; //总得分
}
if (arrFldSet.Contains(convcc_CourseExamPaper.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.ViewCount = objvcc_CourseExamPaperEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convcc_CourseExamPaper.DoneNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.DoneNumber = objvcc_CourseExamPaperEN.DoneNumber; //已做人数
}
if (arrFldSet.Contains(convcc_CourseExamPaper.PaperTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.PaperTime = objvcc_CourseExamPaperEN.PaperTime; //考试时间（分钟）
}
if (arrFldSet.Contains(convcc_CourseExamPaper.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.DownloadNumber = objvcc_CourseExamPaperEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(convcc_CourseExamPaper.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.CollectionCount = objvcc_CourseExamPaperEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convcc_CourseExamPaper.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.LikeCount = objvcc_CourseExamPaperEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(convcc_CourseExamPaper.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.IdXzMajor = objvcc_CourseExamPaperEN.IdXzMajor == "[null]" ? null :  objvcc_CourseExamPaperEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convcc_CourseExamPaper.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.MajorName = objvcc_CourseExamPaperEN.MajorName == "[null]" ? null :  objvcc_CourseExamPaperEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convcc_CourseExamPaper.PaperDispModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.PaperDispModeId = objvcc_CourseExamPaperEN.PaperDispModeId == "[null]" ? null :  objvcc_CourseExamPaperEN.PaperDispModeId; //试卷显示模式Id
}
if (arrFldSet.Contains(convcc_CourseExamPaper.PaperDispModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.PaperDispModeName = objvcc_CourseExamPaperEN.PaperDispModeName == "[null]" ? null :  objvcc_CourseExamPaperEN.PaperDispModeName; //试卷显示模式名称
}
if (arrFldSet.Contains(convcc_CourseExamPaper.ExamCreateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.ExamCreateTime = objvcc_CourseExamPaperEN.ExamCreateTime == "[null]" ? null :  objvcc_CourseExamPaperEN.ExamCreateTime; //考卷建立时间
}
if (arrFldSet.Contains(convcc_CourseExamPaper.CreateUserID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.CreateUserID = objvcc_CourseExamPaperEN.CreateUserID == "[null]" ? null :  objvcc_CourseExamPaperEN.CreateUserID; //建立用户ID
}
if (arrFldSet.Contains(convcc_CourseExamPaper.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.UserName = objvcc_CourseExamPaperEN.UserName == "[null]" ? null :  objvcc_CourseExamPaperEN.UserName; //用户名
}
if (arrFldSet.Contains(convcc_CourseExamPaper.IsOpenToAllStu, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.IsOpenToAllStu = objvcc_CourseExamPaperEN.IsOpenToAllStu; //全校师生
}
if (arrFldSet.Contains(convcc_CourseExamPaper.IsOpenToSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.IsOpenToSchool = objvcc_CourseExamPaperEN.IsOpenToSchool; //全校师生公开
}
if (arrFldSet.Contains(convcc_CourseExamPaper.IsOpenToSocial, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.IsOpenToSocial = objvcc_CourseExamPaperEN.IsOpenToSocial; //社会公众
}
if (arrFldSet.Contains(convcc_CourseExamPaper.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.CourseChapterId = objvcc_CourseExamPaperEN.CourseChapterId == "[null]" ? null :  objvcc_CourseExamPaperEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convcc_CourseExamPaper.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.CourseChapterName = objvcc_CourseExamPaperEN.CourseChapterName == "[null]" ? null :  objvcc_CourseExamPaperEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convcc_CourseExamPaper.ChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.ChapterId = objvcc_CourseExamPaperEN.ChapterId == "[null]" ? null :  objvcc_CourseExamPaperEN.ChapterId; //章Id
}
if (arrFldSet.Contains(convcc_CourseExamPaper.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.SectionId = objvcc_CourseExamPaperEN.SectionId == "[null]" ? null :  objvcc_CourseExamPaperEN.SectionId; //节Id
}
if (arrFldSet.Contains(convcc_CourseExamPaper.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.ChapterName = objvcc_CourseExamPaperEN.ChapterName == "[null]" ? null :  objvcc_CourseExamPaperEN.ChapterName; //章名
}
if (arrFldSet.Contains(convcc_CourseExamPaper.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.SectionName = objvcc_CourseExamPaperEN.SectionName == "[null]" ? null :  objvcc_CourseExamPaperEN.SectionName; //节名
}
if (arrFldSet.Contains(convcc_CourseExamPaper.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.ChapterNameSim = objvcc_CourseExamPaperEN.ChapterNameSim == "[null]" ? null :  objvcc_CourseExamPaperEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convcc_CourseExamPaper.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.SectionNameSim = objvcc_CourseExamPaperEN.SectionNameSim == "[null]" ? null :  objvcc_CourseExamPaperEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convcc_CourseExamPaper.IsAutoGeneQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.IsAutoGeneQuestion = objvcc_CourseExamPaperEN.IsAutoGeneQuestion; //是否自动生成题目
}
if (arrFldSet.Contains(convcc_CourseExamPaper.IsCanMultiDo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.IsCanMultiDo = objvcc_CourseExamPaperEN.IsCanMultiDo; //是否可以做多次
}
if (arrFldSet.Contains(convcc_CourseExamPaper.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.UpdDate = objvcc_CourseExamPaperEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_CourseExamPaper.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.UpdUserId = objvcc_CourseExamPaperEN.UpdUserId == "[null]" ? null :  objvcc_CourseExamPaperEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convcc_CourseExamPaper.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.Memo = objvcc_CourseExamPaperEN.Memo == "[null]" ? null :  objvcc_CourseExamPaperEN.Memo; //备注
}
if (arrFldSet.Contains(convcc_CourseExamPaper.QuestionNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.QuestionNum = objvcc_CourseExamPaperEN.QuestionNum; //题目数
}
if (arrFldSet.Contains(convcc_CourseExamPaper.BigTopicNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseExamPaperEN.BigTopicNum = objvcc_CourseExamPaperEN.BigTopicNum; //大标题数
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
 /// <param name = "objvcc_CourseExamPaperEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN)
{
try
{
if (objvcc_CourseExamPaperEN.CourseId == "[null]") objvcc_CourseExamPaperEN.CourseId = null; //课程Id
if (objvcc_CourseExamPaperEN.CourseName == "[null]") objvcc_CourseExamPaperEN.CourseName = null; //课程名称
if (objvcc_CourseExamPaperEN.ExamPaperName == "[null]") objvcc_CourseExamPaperEN.ExamPaperName = null; //考卷名称
if (objvcc_CourseExamPaperEN.ExamPaperTypeName == "[null]") objvcc_CourseExamPaperEN.ExamPaperTypeName = null; //试卷类型名称
if (objvcc_CourseExamPaperEN.IdXzMajor == "[null]") objvcc_CourseExamPaperEN.IdXzMajor = null; //专业流水号
if (objvcc_CourseExamPaperEN.MajorName == "[null]") objvcc_CourseExamPaperEN.MajorName = null; //专业名称
if (objvcc_CourseExamPaperEN.PaperDispModeId == "[null]") objvcc_CourseExamPaperEN.PaperDispModeId = null; //试卷显示模式Id
if (objvcc_CourseExamPaperEN.PaperDispModeName == "[null]") objvcc_CourseExamPaperEN.PaperDispModeName = null; //试卷显示模式名称
if (objvcc_CourseExamPaperEN.ExamCreateTime == "[null]") objvcc_CourseExamPaperEN.ExamCreateTime = null; //考卷建立时间
if (objvcc_CourseExamPaperEN.CreateUserID == "[null]") objvcc_CourseExamPaperEN.CreateUserID = null; //建立用户ID
if (objvcc_CourseExamPaperEN.UserName == "[null]") objvcc_CourseExamPaperEN.UserName = null; //用户名
if (objvcc_CourseExamPaperEN.CourseChapterId == "[null]") objvcc_CourseExamPaperEN.CourseChapterId = null; //课程章节ID
if (objvcc_CourseExamPaperEN.CourseChapterName == "[null]") objvcc_CourseExamPaperEN.CourseChapterName = null; //课程章节名称
if (objvcc_CourseExamPaperEN.ChapterId == "[null]") objvcc_CourseExamPaperEN.ChapterId = null; //章Id
if (objvcc_CourseExamPaperEN.SectionId == "[null]") objvcc_CourseExamPaperEN.SectionId = null; //节Id
if (objvcc_CourseExamPaperEN.ChapterName == "[null]") objvcc_CourseExamPaperEN.ChapterName = null; //章名
if (objvcc_CourseExamPaperEN.SectionName == "[null]") objvcc_CourseExamPaperEN.SectionName = null; //节名
if (objvcc_CourseExamPaperEN.ChapterNameSim == "[null]") objvcc_CourseExamPaperEN.ChapterNameSim = null; //章名简称
if (objvcc_CourseExamPaperEN.SectionNameSim == "[null]") objvcc_CourseExamPaperEN.SectionNameSim = null; //节名简称
if (objvcc_CourseExamPaperEN.UpdUserId == "[null]") objvcc_CourseExamPaperEN.UpdUserId = null; //修改用户Id
if (objvcc_CourseExamPaperEN.Memo == "[null]") objvcc_CourseExamPaperEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN)
{
 vcc_CourseExamPaperDA.CheckProperty4Condition(objvcc_CourseExamPaperEN);
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
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseExamPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperBL没有刷新缓存机制(clscc_CourseExamPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_PaperDispModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PaperDispModeBL没有刷新缓存机制(clscc_PaperDispModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamPaperTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperTypeBL没有刷新缓存机制(clscc_ExamPaperTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeBL没有刷新缓存机制(clscc_CourseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeBL没有刷新缓存机制(clscc_ExcellentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesBL没有刷新缓存机制(clscc_ThemesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseExamPaperId");
//if (arrvcc_CourseExamPaperObjLstCache == null)
//{
//arrvcc_CourseExamPaperObjLstCache = vcc_CourseExamPaperDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCourseExamPaperId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseExamPaperEN GetObjByCourseExamPaperIdCache(string strCourseExamPaperId, string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperEN._CurrTabName, strCourseId);
List<clsvcc_CourseExamPaperEN> arrvcc_CourseExamPaperObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseExamPaperEN> arrvcc_CourseExamPaperObjLst_Sel =
arrvcc_CourseExamPaperObjLstCache
.Where(x=> x.CourseExamPaperId == strCourseExamPaperId 
);
if (arrvcc_CourseExamPaperObjLst_Sel.Count() == 0)
{
   clsvcc_CourseExamPaperEN obj = clsvcc_CourseExamPaperBL.GetObjByCourseExamPaperId(strCourseExamPaperId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strCourseExamPaperId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvcc_CourseExamPaperObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseExamPaperEN> GetAllvcc_CourseExamPaperObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvcc_CourseExamPaperEN> arrvcc_CourseExamPaperObjLstCache = GetObjLstCache(strCourseId); 
return arrvcc_CourseExamPaperObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseExamPaperEN> GetObjLstCache(string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvcc_CourseExamPaperEN> arrvcc_CourseExamPaperObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvcc_CourseExamPaperObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperEN._CurrTabName, strCourseId);
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
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strCourseExamPaperId, string strCourseId)
{
if (strInFldName != convcc_CourseExamPaper.CourseExamPaperId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_CourseExamPaper.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_CourseExamPaper.AttributeName));
throw new Exception(strMsg);
}
var objvcc_CourseExamPaper = clsvcc_CourseExamPaperBL.GetObjByCourseExamPaperIdCache(strCourseExamPaperId, strCourseId);
if (objvcc_CourseExamPaper == null) return "";
return objvcc_CourseExamPaper[strOutFldName].ToString();
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
int intRecCount = clsvcc_CourseExamPaperDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_CourseExamPaperDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_CourseExamPaperDA.GetRecCount();
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
int intRecCount = clsvcc_CourseExamPaperDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_CourseExamPaperEN objvcc_CourseExamPaperCond)
{
 string strCourseId = objvcc_CourseExamPaperCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvcc_CourseExamPaperBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvcc_CourseExamPaperEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseExamPaperEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseExamPaper.AttributeName)
{
if (objvcc_CourseExamPaperCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseExamPaperCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseExamPaperCond[strFldName].ToString());
}
else
{
if (objvcc_CourseExamPaperCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseExamPaperCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseExamPaperCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseExamPaperCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseExamPaperCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseExamPaperCond[strFldName]));
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
 List<string> arrList = clsvcc_CourseExamPaperDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseExamPaperDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseExamPaperDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}