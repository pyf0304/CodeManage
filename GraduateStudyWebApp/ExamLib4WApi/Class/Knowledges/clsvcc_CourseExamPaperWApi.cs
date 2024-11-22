
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseExamPaperWApi
 表名:vcc_CourseExamPaper(01120098)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:07
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
public static class clsvcc_CourseExamPaperWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetCourseExamPaperId(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_CourseExamPaper.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_CourseExamPaper.CourseExamPaperId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetCourseId(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseExamPaper.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseExamPaper.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetCourseName(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseExamPaper.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetExamPaperName(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strExamPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_CourseExamPaper.ExamPaperName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetPaperIndex(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, int intPaperIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetExamPaperTypeId(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strExamPaperTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeId, convcc_CourseExamPaper.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, convcc_CourseExamPaper.ExamPaperTypeId);
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, convcc_CourseExamPaper.ExamPaperTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetExamPaperTypeName(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strExamPaperTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperTypeName, 30, convcc_CourseExamPaper.ExamPaperTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetTotalScore(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, double dblTotalScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetViewCount(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, int intViewCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetDoneNumber(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, int intDoneNumber, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetPaperTime(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, int intPaperTime, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetDownloadNumber(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, int intDownloadNumber, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetCollectionCount(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, long lngCollectionCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetLikeCount(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, long lngLikeCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN Setid_XzMajor(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convcc_CourseExamPaper.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convcc_CourseExamPaper.id_XzMajor);
objvcc_CourseExamPaperEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.id_XzMajor) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.id_XzMajor, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.id_XzMajor] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetMajorName(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_CourseExamPaper.MajorName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetPaperDispModeId(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strPaperDispModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperDispModeId, 4, convcc_CourseExamPaper.PaperDispModeId);
clsCheckSql.CheckFieldForeignKey(strPaperDispModeId, 4, convcc_CourseExamPaper.PaperDispModeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetPaperDispModeName(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strPaperDispModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperDispModeName, 30, convcc_CourseExamPaper.PaperDispModeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetExamCreateTime(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strExamCreateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamCreateTime, 14, convcc_CourseExamPaper.ExamCreateTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetCreateUserID(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strCreateUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateUserID, 20, convcc_CourseExamPaper.CreateUserID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetUserName(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convcc_CourseExamPaper.UserName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetCourseChapterId(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_CourseExamPaper.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_CourseExamPaper.CourseChapterId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetCourseChapterName(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_CourseExamPaper.CourseChapterName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetChapterId(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_CourseExamPaper.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_CourseExamPaper.ChapterId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetSectionId(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_CourseExamPaper.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_CourseExamPaper.SectionId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetChapterName(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_CourseExamPaper.ChapterName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetSectionName(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_CourseExamPaper.SectionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetChapterName_Sim(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_CourseExamPaper.ChapterName_Sim);
objvcc_CourseExamPaperEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.ChapterName_Sim) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetSectionName_Sim(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_CourseExamPaper.SectionName_Sim);
objvcc_CourseExamPaperEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(convcc_CourseExamPaper.SectionName_Sim) == false)
{
objvcc_CourseExamPaperEN.dicFldComparisonOp.Add(convcc_CourseExamPaper.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_CourseExamPaperEN.dicFldComparisonOp[convcc_CourseExamPaper.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetUpdDate(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_CourseExamPaper.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseExamPaper.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetUpdUserId(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_CourseExamPaper.UpdUserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetMemo(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseExamPaper.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetQuestionNum(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, int intQuestionNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExamPaperEN SetBigTopicNum(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN, int intBigTopicNum, string strComparisonOp="")
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseExamPaperEN objvcc_CourseExamPaper_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.CourseExamPaperId, objvcc_CourseExamPaper_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.CourseId, objvcc_CourseExamPaper_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.CourseName, objvcc_CourseExamPaper_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.ExamPaperName) == true)
{
string strComparisonOp_ExamPaperName = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.ExamPaperName, objvcc_CourseExamPaper_Cond.ExamPaperName, strComparisonOp_ExamPaperName);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.PaperIndex) == true)
{
string strComparisonOp_PaperIndex = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.PaperIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.PaperIndex, objvcc_CourseExamPaper_Cond.PaperIndex, strComparisonOp_PaperIndex);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.ExamPaperTypeId) == true)
{
string strComparisonOp_ExamPaperTypeId = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.ExamPaperTypeId, objvcc_CourseExamPaper_Cond.ExamPaperTypeId, strComparisonOp_ExamPaperTypeId);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.ExamPaperTypeName) == true)
{
string strComparisonOp_ExamPaperTypeName = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.ExamPaperTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.ExamPaperTypeName, objvcc_CourseExamPaper_Cond.ExamPaperTypeName, strComparisonOp_ExamPaperTypeName);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.IsShow) == true)
{
if (objvcc_CourseExamPaper_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaper.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaper.IsShow);
}
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.TotalScore) == true)
{
string strComparisonOp_TotalScore = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.TotalScore, objvcc_CourseExamPaper_Cond.TotalScore, strComparisonOp_TotalScore);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.ViewCount, objvcc_CourseExamPaper_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.DoneNumber) == true)
{
string strComparisonOp_DoneNumber = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.DoneNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.DoneNumber, objvcc_CourseExamPaper_Cond.DoneNumber, strComparisonOp_DoneNumber);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.PaperTime) == true)
{
string strComparisonOp_PaperTime = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.PaperTime];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.PaperTime, objvcc_CourseExamPaper_Cond.PaperTime, strComparisonOp_PaperTime);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.DownloadNumber) == true)
{
string strComparisonOp_DownloadNumber = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.DownloadNumber, objvcc_CourseExamPaper_Cond.DownloadNumber, strComparisonOp_DownloadNumber);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.CollectionCount, objvcc_CourseExamPaper_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.LikeCount, objvcc_CourseExamPaper_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.id_XzMajor, objvcc_CourseExamPaper_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.MajorName) == true)
{
string strComparisonOp_MajorName = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.MajorName, objvcc_CourseExamPaper_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.PaperDispModeId) == true)
{
string strComparisonOp_PaperDispModeId = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.PaperDispModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.PaperDispModeId, objvcc_CourseExamPaper_Cond.PaperDispModeId, strComparisonOp_PaperDispModeId);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.PaperDispModeName) == true)
{
string strComparisonOp_PaperDispModeName = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.PaperDispModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.PaperDispModeName, objvcc_CourseExamPaper_Cond.PaperDispModeName, strComparisonOp_PaperDispModeName);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.ExamCreateTime) == true)
{
string strComparisonOp_ExamCreateTime = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.ExamCreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.ExamCreateTime, objvcc_CourseExamPaper_Cond.ExamCreateTime, strComparisonOp_ExamCreateTime);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.CreateUserID) == true)
{
string strComparisonOp_CreateUserID = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.CreateUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.CreateUserID, objvcc_CourseExamPaper_Cond.CreateUserID, strComparisonOp_CreateUserID);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.UserName) == true)
{
string strComparisonOp_UserName = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.UserName, objvcc_CourseExamPaper_Cond.UserName, strComparisonOp_UserName);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.IsOpenToAllStu) == true)
{
if (objvcc_CourseExamPaper_Cond.IsOpenToAllStu == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaper.IsOpenToAllStu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaper.IsOpenToAllStu);
}
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.IsOpenToSchool) == true)
{
if (objvcc_CourseExamPaper_Cond.IsOpenToSchool == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaper.IsOpenToSchool);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaper.IsOpenToSchool);
}
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.IsOpenToSocial) == true)
{
if (objvcc_CourseExamPaper_Cond.IsOpenToSocial == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaper.IsOpenToSocial);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaper.IsOpenToSocial);
}
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.CourseChapterId, objvcc_CourseExamPaper_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.CourseChapterName, objvcc_CourseExamPaper_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.ChapterId, objvcc_CourseExamPaper_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.SectionId) == true)
{
string strComparisonOp_SectionId = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.SectionId, objvcc_CourseExamPaper_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.ChapterName, objvcc_CourseExamPaper_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.SectionName, objvcc_CourseExamPaper_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.ChapterName_Sim, objvcc_CourseExamPaper_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.SectionName_Sim, objvcc_CourseExamPaper_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.IsAutoGeneQuestion) == true)
{
if (objvcc_CourseExamPaper_Cond.IsAutoGeneQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaper.IsAutoGeneQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaper.IsAutoGeneQuestion);
}
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.IsCanMultiDo) == true)
{
if (objvcc_CourseExamPaper_Cond.IsCanMultiDo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseExamPaper.IsCanMultiDo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseExamPaper.IsCanMultiDo);
}
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.UpdDate, objvcc_CourseExamPaper_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.UpdUserId, objvcc_CourseExamPaper_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.Memo) == true)
{
string strComparisonOp_Memo = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseExamPaper.Memo, objvcc_CourseExamPaper_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.QuestionNum) == true)
{
string strComparisonOp_QuestionNum = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.QuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.QuestionNum, objvcc_CourseExamPaper_Cond.QuestionNum, strComparisonOp_QuestionNum);
}
if (objvcc_CourseExamPaper_Cond.IsUpdated(convcc_CourseExamPaper.BigTopicNum) == true)
{
string strComparisonOp_BigTopicNum = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[convcc_CourseExamPaper.BigTopicNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseExamPaper.BigTopicNum, objvcc_CourseExamPaper_Cond.BigTopicNum, strComparisonOp_BigTopicNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v考卷(vcc_CourseExamPaper)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseExamPaperWApi
{
private static readonly string mstrApiControllerName = "vcc_CourseExamPaperApi";

 public clsvcc_CourseExamPaperWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseExamPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseExamPaperEN GetObjByCourseExamPaperId(string strCourseExamPaperId)
{
string strAction = "GetObjByCourseExamPaperId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = null;
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
objvcc_CourseExamPaperEN = JsonConvert.DeserializeObject<clsvcc_CourseExamPaperEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseExamPaperEN;
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
public static clsvcc_CourseExamPaperEN GetObjByCourseExamPaperId_WA_Cache(string strCourseExamPaperId, string strCourseId)
{
string strAction = "GetObjByCourseExamPaperId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = null;
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
objvcc_CourseExamPaperEN = JsonConvert.DeserializeObject<clsvcc_CourseExamPaperEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseExamPaperEN;
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
public static clsvcc_CourseExamPaperEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseExamPaperEN objvcc_CourseExamPaperEN = null;
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
objvcc_CourseExamPaperEN = JsonConvert.DeserializeObject<clsvcc_CourseExamPaperEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseExamPaperEN;
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
public static clsvcc_CourseExamPaperEN GetObjByCourseExamPaperId_Cache(string strCourseExamPaperId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseExamPaperId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseExamPaperEN> arrvcc_CourseExamPaperObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseExamPaperEN> arrvcc_CourseExamPaperObjLst_Sel =
from objvcc_CourseExamPaperEN in arrvcc_CourseExamPaperObjLst_Cache
where objvcc_CourseExamPaperEN.CourseExamPaperId == strCourseExamPaperId
select objvcc_CourseExamPaperEN;
if (arrvcc_CourseExamPaperObjLst_Sel.Count() == 0)
{
   clsvcc_CourseExamPaperEN obj = clsvcc_CourseExamPaperWApi.GetObjByCourseExamPaperId(strCourseExamPaperId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_CourseExamPaperObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseExamPaperEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_CourseExamPaperEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExamPaperEN> GetObjLstByCourseExamPaperIdLst(List<string> arrCourseExamPaperId)
{
 List<clsvcc_CourseExamPaperEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvcc_CourseExamPaperEN> GetObjLstByCourseExamPaperIdLst_Cache(List<string> arrCourseExamPaperId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseExamPaperEN> arrvcc_CourseExamPaperObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseExamPaperEN> arrvcc_CourseExamPaperObjLst_Sel =
from objvcc_CourseExamPaperEN in arrvcc_CourseExamPaperObjLst_Cache
where arrCourseExamPaperId.Contains(objvcc_CourseExamPaperEN.CourseExamPaperId)
select objvcc_CourseExamPaperEN;
return arrvcc_CourseExamPaperObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseExamPaperEN> GetObjLstByCourseExamPaperIdLst_WA_Cache(List<string> arrCourseExamPaperId, string strCourseId)
{
 List<clsvcc_CourseExamPaperEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExamPaperEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_CourseExamPaperEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExamPaperEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_CourseExamPaperEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExamPaperEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseExamPaperEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExamPaperEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseExamPaperEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExamPaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
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
objvcc_CourseExamPaperENT.id_XzMajor = objvcc_CourseExamPaperENS.id_XzMajor; //专业流水号
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
objvcc_CourseExamPaperENT.ChapterName_Sim = objvcc_CourseExamPaperENS.ChapterName_Sim; //章名简称
objvcc_CourseExamPaperENT.SectionName_Sim = objvcc_CourseExamPaperENS.SectionName_Sim; //节名简称
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
public static DataTable ToDataTable(List<clsvcc_CourseExamPaperEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_CourseExamPaperEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_CourseExamPaperEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_CourseExamPaperEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_CourseExamPaperEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_CourseExamPaperEN.AttributeName)
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
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseExamPaperWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperWApi没有刷新缓存机制(clscc_CourseExamPaperWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_PaperDispModeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PaperDispModeWApi没有刷新缓存机制(clscc_PaperDispModeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamPaperTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperTypeWApi没有刷新缓存机制(clscc_ExamPaperTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeWApi没有刷新缓存机制(clscc_ExcellentTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesWApi没有刷新缓存机制(clscc_ThemesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseExamPaperId");
//if (arrvcc_CourseExamPaperObjLst_Cache == null)
//{
//arrvcc_CourseExamPaperObjLst_Cache = await clsvcc_CourseExamPaperWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperEN._CurrTabName_S, strCourseId);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseExamPaperEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_CourseExamPaperEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseExamPaperEN> arrvcc_CourseExamPaperObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvcc_CourseExamPaperObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_CourseExamPaperEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_CourseExamPaper.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.ExamPaperName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.PaperIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseExamPaper.ExamPaperTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.ExamPaperTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseExamPaper.TotalScore, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_CourseExamPaper.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseExamPaper.DoneNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseExamPaper.PaperTime, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseExamPaper.DownloadNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseExamPaper.CollectionCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_CourseExamPaper.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_CourseExamPaper.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.PaperDispModeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.PaperDispModeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.ExamCreateTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.CreateUserID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.IsOpenToAllStu, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseExamPaper.IsOpenToSchool, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseExamPaper.IsOpenToSocial, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseExamPaper.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.IsAutoGeneQuestion, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseExamPaper.IsCanMultiDo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseExamPaper.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseExamPaper.QuestionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseExamPaper.BigTopicNum, Type.GetType("System.Int32"));
foreach (clsvcc_CourseExamPaperEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_CourseExamPaper.CourseExamPaperId] = objInFor[convcc_CourseExamPaper.CourseExamPaperId];
objDR[convcc_CourseExamPaper.CourseId] = objInFor[convcc_CourseExamPaper.CourseId];
objDR[convcc_CourseExamPaper.CourseName] = objInFor[convcc_CourseExamPaper.CourseName];
objDR[convcc_CourseExamPaper.ExamPaperName] = objInFor[convcc_CourseExamPaper.ExamPaperName];
objDR[convcc_CourseExamPaper.PaperIndex] = objInFor[convcc_CourseExamPaper.PaperIndex];
objDR[convcc_CourseExamPaper.ExamPaperTypeId] = objInFor[convcc_CourseExamPaper.ExamPaperTypeId];
objDR[convcc_CourseExamPaper.ExamPaperTypeName] = objInFor[convcc_CourseExamPaper.ExamPaperTypeName];
objDR[convcc_CourseExamPaper.IsShow] = objInFor[convcc_CourseExamPaper.IsShow];
objDR[convcc_CourseExamPaper.TotalScore] = objInFor[convcc_CourseExamPaper.TotalScore];
objDR[convcc_CourseExamPaper.ViewCount] = objInFor[convcc_CourseExamPaper.ViewCount];
objDR[convcc_CourseExamPaper.DoneNumber] = objInFor[convcc_CourseExamPaper.DoneNumber];
objDR[convcc_CourseExamPaper.PaperTime] = objInFor[convcc_CourseExamPaper.PaperTime];
objDR[convcc_CourseExamPaper.DownloadNumber] = objInFor[convcc_CourseExamPaper.DownloadNumber];
objDR[convcc_CourseExamPaper.CollectionCount] = objInFor[convcc_CourseExamPaper.CollectionCount];
objDR[convcc_CourseExamPaper.LikeCount] = objInFor[convcc_CourseExamPaper.LikeCount];
objDR[convcc_CourseExamPaper.id_XzMajor] = objInFor[convcc_CourseExamPaper.id_XzMajor];
objDR[convcc_CourseExamPaper.MajorName] = objInFor[convcc_CourseExamPaper.MajorName];
objDR[convcc_CourseExamPaper.PaperDispModeId] = objInFor[convcc_CourseExamPaper.PaperDispModeId];
objDR[convcc_CourseExamPaper.PaperDispModeName] = objInFor[convcc_CourseExamPaper.PaperDispModeName];
objDR[convcc_CourseExamPaper.ExamCreateTime] = objInFor[convcc_CourseExamPaper.ExamCreateTime];
objDR[convcc_CourseExamPaper.CreateUserID] = objInFor[convcc_CourseExamPaper.CreateUserID];
objDR[convcc_CourseExamPaper.UserName] = objInFor[convcc_CourseExamPaper.UserName];
objDR[convcc_CourseExamPaper.IsOpenToAllStu] = objInFor[convcc_CourseExamPaper.IsOpenToAllStu];
objDR[convcc_CourseExamPaper.IsOpenToSchool] = objInFor[convcc_CourseExamPaper.IsOpenToSchool];
objDR[convcc_CourseExamPaper.IsOpenToSocial] = objInFor[convcc_CourseExamPaper.IsOpenToSocial];
objDR[convcc_CourseExamPaper.CourseChapterId] = objInFor[convcc_CourseExamPaper.CourseChapterId];
objDR[convcc_CourseExamPaper.CourseChapterName] = objInFor[convcc_CourseExamPaper.CourseChapterName];
objDR[convcc_CourseExamPaper.ChapterId] = objInFor[convcc_CourseExamPaper.ChapterId];
objDR[convcc_CourseExamPaper.SectionId] = objInFor[convcc_CourseExamPaper.SectionId];
objDR[convcc_CourseExamPaper.ChapterName] = objInFor[convcc_CourseExamPaper.ChapterName];
objDR[convcc_CourseExamPaper.SectionName] = objInFor[convcc_CourseExamPaper.SectionName];
objDR[convcc_CourseExamPaper.ChapterName_Sim] = objInFor[convcc_CourseExamPaper.ChapterName_Sim];
objDR[convcc_CourseExamPaper.SectionName_Sim] = objInFor[convcc_CourseExamPaper.SectionName_Sim];
objDR[convcc_CourseExamPaper.IsAutoGeneQuestion] = objInFor[convcc_CourseExamPaper.IsAutoGeneQuestion];
objDR[convcc_CourseExamPaper.IsCanMultiDo] = objInFor[convcc_CourseExamPaper.IsCanMultiDo];
objDR[convcc_CourseExamPaper.UpdDate] = objInFor[convcc_CourseExamPaper.UpdDate];
objDR[convcc_CourseExamPaper.UpdUserId] = objInFor[convcc_CourseExamPaper.UpdUserId];
objDR[convcc_CourseExamPaper.Memo] = objInFor[convcc_CourseExamPaper.Memo];
objDR[convcc_CourseExamPaper.QuestionNum] = objInFor[convcc_CourseExamPaper.QuestionNum];
objDR[convcc_CourseExamPaper.BigTopicNum] = objInFor[convcc_CourseExamPaper.BigTopicNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}