
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCase4AppWApi
 表名:vCourseLearningCase4App(01120271)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:15
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
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
public static class clsvCourseLearningCase4AppWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetId_CourseLearningCase(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strId_CourseLearningCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CourseLearningCase, 8, convCourseLearningCase4App.Id_CourseLearningCase);
clsCheckSql.CheckFieldForeignKey(strId_CourseLearningCase, 8, convCourseLearningCase4App.Id_CourseLearningCase);
objvCourseLearningCase4AppEN.Id_CourseLearningCase = strId_CourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.Id_CourseLearningCase) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.Id_CourseLearningCase, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.Id_CourseLearningCase] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetCourseLearningCaseID(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseID, convCourseLearningCase4App.CourseLearningCaseID);
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, convCourseLearningCase4App.CourseLearningCaseID);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, convCourseLearningCase4App.CourseLearningCaseID);
objvCourseLearningCase4AppEN.CourseLearningCaseID = strCourseLearningCaseID; //课程学习案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.CourseLearningCaseID) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.CourseLearningCaseID, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.CourseLearningCaseID] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetCourseLearningCaseName(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseName, convCourseLearningCase4App.CourseLearningCaseName);
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningCase4App.CourseLearningCaseName);
objvCourseLearningCase4AppEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.CourseLearningCaseName) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.CourseLearningCaseName, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.CourseLearningCaseName] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetIsDualVideo(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvCourseLearningCase4AppEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.IsDualVideo) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.IsDualVideo, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.IsDualVideo] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetCourseId(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convCourseLearningCase4App.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convCourseLearningCase4App.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCourseLearningCase4App.CourseId);
objvCourseLearningCase4AppEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.CourseId) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.CourseId, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.CourseId] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetCourseCode(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCourseLearningCase4App.CourseCode);
objvCourseLearningCase4AppEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.CourseCode) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.CourseCode, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.CourseCode] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetCourseName(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCourseLearningCase4App.CourseName);
objvCourseLearningCase4AppEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.CourseName) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.CourseName, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.CourseName] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetCourseChapterId(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convCourseLearningCase4App.CourseChapterId);
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCourseLearningCase4App.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCourseLearningCase4App.CourseChapterId);
objvCourseLearningCase4AppEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.CourseChapterId) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.CourseChapterId, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.CourseChapterId] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetChapterId(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convCourseLearningCase4App.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convCourseLearningCase4App.ChapterId);
objvCourseLearningCase4AppEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.ChapterId) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.ChapterId, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.ChapterId] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetChapterName(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convCourseLearningCase4App.ChapterName);
objvCourseLearningCase4AppEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.ChapterName) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.ChapterName, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.ChapterName] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetChapterName_Sim(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convCourseLearningCase4App.ChapterName_Sim);
objvCourseLearningCase4AppEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.ChapterName_Sim) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.ChapterName_Sim, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.ChapterName_Sim] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetSectionName(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convCourseLearningCase4App.SectionName);
objvCourseLearningCase4AppEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.SectionName) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.SectionName, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.SectionName] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetSectionName_Sim(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convCourseLearningCase4App.SectionName_Sim);
objvCourseLearningCase4AppEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.SectionName_Sim) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.SectionName_Sim, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.SectionName_Sim] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetSectionId(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convCourseLearningCase4App.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convCourseLearningCase4App.SectionId);
objvCourseLearningCase4AppEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.SectionId) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.SectionId, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.SectionId] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetVideoUrl(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convCourseLearningCase4App.VideoUrl);
objvCourseLearningCase4AppEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.VideoUrl) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.VideoUrl, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.VideoUrl] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetVideoPath(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convCourseLearningCase4App.VideoPath);
objvCourseLearningCase4AppEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.VideoPath) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.VideoPath, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.VideoPath] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetUpdDate(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCourseLearningCase4App.UpdDate);
objvCourseLearningCase4AppEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.UpdDate) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.UpdDate, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.UpdDate] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetMemo(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCourseLearningCase4App.Memo);
objvCourseLearningCase4AppEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.Memo) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.Memo, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.Memo] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetBrowseCount4Case(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvCourseLearningCase4AppEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.BrowseCount4Case) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.BrowseCount4Case, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.BrowseCount4Case] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetImageUrl(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strImageUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImageUrl, 50, convCourseLearningCase4App.ImageUrl);
objvCourseLearningCase4AppEN.ImageUrl = strImageUrl; //ImageUrl
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.ImageUrl) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.ImageUrl, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.ImageUrl] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetOrderNum(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, int intOrderNum, string strComparisonOp="")
	{
objvCourseLearningCase4AppEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.OrderNum) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.OrderNum, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.OrderNum] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningCase4AppEN objvCourseLearningCase4App_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.Id_CourseLearningCase) == true)
{
string strComparisonOp_Id_CourseLearningCase = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.Id_CourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.Id_CourseLearningCase, objvCourseLearningCase4App_Cond.Id_CourseLearningCase, strComparisonOp_Id_CourseLearningCase);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.CourseLearningCaseID) == true)
{
string strComparisonOp_CourseLearningCaseID = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.CourseLearningCaseID, objvCourseLearningCase4App_Cond.CourseLearningCaseID, strComparisonOp_CourseLearningCaseID);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.CourseLearningCaseName) == true)
{
string strComparisonOp_CourseLearningCaseName = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.CourseLearningCaseName, objvCourseLearningCase4App_Cond.CourseLearningCaseName, strComparisonOp_CourseLearningCaseName);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.IsDualVideo) == true)
{
if (objvCourseLearningCase4App_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase4App.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase4App.IsDualVideo);
}
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.CourseId) == true)
{
string strComparisonOp_CourseId = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.CourseId, objvCourseLearningCase4App_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.CourseCode, objvCourseLearningCase4App_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.CourseName) == true)
{
string strComparisonOp_CourseName = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.CourseName, objvCourseLearningCase4App_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.CourseChapterId, objvCourseLearningCase4App_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.ChapterId, objvCourseLearningCase4App_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.ChapterName, objvCourseLearningCase4App_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.ChapterName_Sim, objvCourseLearningCase4App_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.SectionName) == true)
{
string strComparisonOp_SectionName = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.SectionName, objvCourseLearningCase4App_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.SectionName_Sim, objvCourseLearningCase4App_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.SectionId) == true)
{
string strComparisonOp_SectionId = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.SectionId, objvCourseLearningCase4App_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.VideoUrl, objvCourseLearningCase4App_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.VideoPath, objvCourseLearningCase4App_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.UpdDate, objvCourseLearningCase4App_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.Memo) == true)
{
string strComparisonOp_Memo = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.Memo, objvCourseLearningCase4App_Cond.Memo, strComparisonOp_Memo);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase4App.BrowseCount4Case, objvCourseLearningCase4App_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.ImageUrl) == true)
{
string strComparisonOp_ImageUrl = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.ImageUrl, objvCourseLearningCase4App_Cond.ImageUrl, strComparisonOp_ImageUrl);
}
if (objvCourseLearningCase4App_Cond.IsUpdated(convCourseLearningCase4App.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvCourseLearningCase4App_Cond.dicFldComparisonOp[convCourseLearningCase4App.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase4App.OrderNum, objvCourseLearningCase4App_Cond.OrderNum, strComparisonOp_OrderNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程学习案例4App(vCourseLearningCase4App)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningCase4AppWApi
{
private static readonly string mstrApiControllerName = "vCourseLearningCase4AppApi";

 public clsvCourseLearningCase4AppWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_CourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCase4AppEN GetObjById_CourseLearningCase(string strId_CourseLearningCase)
{
string strAction = "GetObjById_CourseLearningCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CourseLearningCase"] = strId_CourseLearningCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCourseLearningCase4AppEN = JsonConvert.DeserializeObject<clsvCourseLearningCase4AppEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCase4AppEN;
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
 /// <param name = "strId_CourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCase4AppEN GetObjById_CourseLearningCase_WA_Cache(string strId_CourseLearningCase)
{
string strAction = "GetObjById_CourseLearningCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CourseLearningCase"] = strId_CourseLearningCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCourseLearningCase4AppEN = JsonConvert.DeserializeObject<clsvCourseLearningCase4AppEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCase4AppEN;
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
public static clsvCourseLearningCase4AppEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = null;
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
objvCourseLearningCase4AppEN = JsonConvert.DeserializeObject<clsvCourseLearningCase4AppEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCase4AppEN;
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
 /// <param name = "strId_CourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCase4AppEN GetObjById_CourseLearningCase_Cache(string strId_CourseLearningCase)
{
if (string.IsNullOrEmpty(strId_CourseLearningCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCase4AppEN._CurrTabName_S);
List<clsvCourseLearningCase4AppEN> arrvCourseLearningCase4AppObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCase4AppEN> arrvCourseLearningCase4AppObjLst_Sel =
from objvCourseLearningCase4AppEN in arrvCourseLearningCase4AppObjLst_Cache
where objvCourseLearningCase4AppEN.Id_CourseLearningCase == strId_CourseLearningCase
select objvCourseLearningCase4AppEN;
if (arrvCourseLearningCase4AppObjLst_Sel.Count() == 0)
{
   clsvCourseLearningCase4AppEN obj = clsvCourseLearningCase4AppWApi.GetObjById_CourseLearningCase(strId_CourseLearningCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCourseLearningCase4AppObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase4AppEN> GetObjLst(string strWhereCond)
{
 List<clsvCourseLearningCase4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase4AppEN> GetObjLstById_CourseLearningCaseLst(List<string> arrId_CourseLearningCase)
{
 List<clsvCourseLearningCase4AppEN> arrObjLst = null; 
string strAction = "GetObjLstById_CourseLearningCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CourseLearningCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strId_CourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCourseLearningCase4AppEN> GetObjLstById_CourseLearningCaseLst_Cache(List<string> arrId_CourseLearningCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCase4AppEN._CurrTabName_S);
List<clsvCourseLearningCase4AppEN> arrvCourseLearningCase4AppObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCase4AppEN> arrvCourseLearningCase4AppObjLst_Sel =
from objvCourseLearningCase4AppEN in arrvCourseLearningCase4AppObjLst_Cache
where arrId_CourseLearningCase.Contains(objvCourseLearningCase4AppEN.Id_CourseLearningCase)
select objvCourseLearningCase4AppEN;
return arrvCourseLearningCase4AppObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase4AppEN> GetObjLstById_CourseLearningCaseLst_WA_Cache(List<string> arrId_CourseLearningCase)
{
 List<clsvCourseLearningCase4AppEN> arrObjLst = null; 
string strAction = "GetObjLstById_CourseLearningCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CourseLearningCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase4AppEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCourseLearningCase4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase4AppEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCourseLearningCase4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase4AppEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningCase4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase4AppEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningCase4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strId_CourseLearningCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_CourseLearningCase"] = strId_CourseLearningCase
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
 /// <param name = "objvCourseLearningCase4AppENS">源对象</param>
 /// <param name = "objvCourseLearningCase4AppENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningCase4AppEN objvCourseLearningCase4AppENS, clsvCourseLearningCase4AppEN objvCourseLearningCase4AppENT)
{
try
{
objvCourseLearningCase4AppENT.Id_CourseLearningCase = objvCourseLearningCase4AppENS.Id_CourseLearningCase; //课程学习案例流水号
objvCourseLearningCase4AppENT.CourseLearningCaseID = objvCourseLearningCase4AppENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCase4AppENT.CourseLearningCaseName = objvCourseLearningCase4AppENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCase4AppENT.IsDualVideo = objvCourseLearningCase4AppENS.IsDualVideo; //是否双视频
objvCourseLearningCase4AppENT.CourseId = objvCourseLearningCase4AppENS.CourseId; //课程Id
objvCourseLearningCase4AppENT.CourseCode = objvCourseLearningCase4AppENS.CourseCode; //课程代码
objvCourseLearningCase4AppENT.CourseName = objvCourseLearningCase4AppENS.CourseName; //课程名称
objvCourseLearningCase4AppENT.CourseChapterId = objvCourseLearningCase4AppENS.CourseChapterId; //课程章节ID
objvCourseLearningCase4AppENT.ChapterId = objvCourseLearningCase4AppENS.ChapterId; //章Id
objvCourseLearningCase4AppENT.ChapterName = objvCourseLearningCase4AppENS.ChapterName; //章名
objvCourseLearningCase4AppENT.ChapterName_Sim = objvCourseLearningCase4AppENS.ChapterName_Sim; //章名简称
objvCourseLearningCase4AppENT.SectionName = objvCourseLearningCase4AppENS.SectionName; //节名
objvCourseLearningCase4AppENT.SectionName_Sim = objvCourseLearningCase4AppENS.SectionName_Sim; //节名简称
objvCourseLearningCase4AppENT.SectionId = objvCourseLearningCase4AppENS.SectionId; //节Id
objvCourseLearningCase4AppENT.VideoUrl = objvCourseLearningCase4AppENS.VideoUrl; //视频Url
objvCourseLearningCase4AppENT.VideoPath = objvCourseLearningCase4AppENS.VideoPath; //视频目录
objvCourseLearningCase4AppENT.UpdDate = objvCourseLearningCase4AppENS.UpdDate; //修改日期
objvCourseLearningCase4AppENT.Memo = objvCourseLearningCase4AppENS.Memo; //备注
objvCourseLearningCase4AppENT.BrowseCount4Case = objvCourseLearningCase4AppENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningCase4AppENT.ImageUrl = objvCourseLearningCase4AppENS.ImageUrl; //ImageUrl
objvCourseLearningCase4AppENT.OrderNum = objvCourseLearningCase4AppENS.OrderNum; //序号
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
public static DataTable ToDataTable(List<clsvCourseLearningCase4AppEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCourseLearningCase4AppEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCourseLearningCase4AppEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCourseLearningCase4AppEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCourseLearningCase4AppEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCourseLearningCase4AppEN.AttributeName)
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
if (clsCourseLearningCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseWApi没有刷新缓存机制(clsCourseLearningCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesWApi没有刷新缓存机制(clscc_ThemesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_CourseLearningCase");
//if (arrvCourseLearningCase4AppObjLst_Cache == null)
//{
//arrvCourseLearningCase4AppObjLst_Cache = await clsvCourseLearningCase4AppWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvCourseLearningCase4AppEN._CurrTabName_S);
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
public static List<clsvCourseLearningCase4AppEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningCase4AppEN._CurrTabName_S);
List<clsvCourseLearningCase4AppEN> arrvCourseLearningCase4AppObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningCase4AppObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCourseLearningCase4AppEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCourseLearningCase4App.Id_CourseLearningCase, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App.CourseLearningCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App.CourseLearningCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCourseLearningCase4App.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase4App.ImageUrl, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App.OrderNum, Type.GetType("System.Int32"));
foreach (clsvCourseLearningCase4AppEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCourseLearningCase4App.Id_CourseLearningCase] = objInFor[convCourseLearningCase4App.Id_CourseLearningCase];
objDR[convCourseLearningCase4App.CourseLearningCaseID] = objInFor[convCourseLearningCase4App.CourseLearningCaseID];
objDR[convCourseLearningCase4App.CourseLearningCaseName] = objInFor[convCourseLearningCase4App.CourseLearningCaseName];
objDR[convCourseLearningCase4App.IsDualVideo] = objInFor[convCourseLearningCase4App.IsDualVideo];
objDR[convCourseLearningCase4App.CourseId] = objInFor[convCourseLearningCase4App.CourseId];
objDR[convCourseLearningCase4App.CourseCode] = objInFor[convCourseLearningCase4App.CourseCode];
objDR[convCourseLearningCase4App.CourseName] = objInFor[convCourseLearningCase4App.CourseName];
objDR[convCourseLearningCase4App.CourseChapterId] = objInFor[convCourseLearningCase4App.CourseChapterId];
objDR[convCourseLearningCase4App.ChapterId] = objInFor[convCourseLearningCase4App.ChapterId];
objDR[convCourseLearningCase4App.ChapterName] = objInFor[convCourseLearningCase4App.ChapterName];
objDR[convCourseLearningCase4App.ChapterName_Sim] = objInFor[convCourseLearningCase4App.ChapterName_Sim];
objDR[convCourseLearningCase4App.SectionName] = objInFor[convCourseLearningCase4App.SectionName];
objDR[convCourseLearningCase4App.SectionName_Sim] = objInFor[convCourseLearningCase4App.SectionName_Sim];
objDR[convCourseLearningCase4App.SectionId] = objInFor[convCourseLearningCase4App.SectionId];
objDR[convCourseLearningCase4App.VideoUrl] = objInFor[convCourseLearningCase4App.VideoUrl];
objDR[convCourseLearningCase4App.VideoPath] = objInFor[convCourseLearningCase4App.VideoPath];
objDR[convCourseLearningCase4App.UpdDate] = objInFor[convCourseLearningCase4App.UpdDate];
objDR[convCourseLearningCase4App.Memo] = objInFor[convCourseLearningCase4App.Memo];
objDR[convCourseLearningCase4App.BrowseCount4Case] = objInFor[convCourseLearningCase4App.BrowseCount4Case];
objDR[convCourseLearningCase4App.ImageUrl] = objInFor[convCourseLearningCase4App.ImageUrl];
objDR[convCourseLearningCase4App.OrderNum] = objInFor[convCourseLearningCase4App.OrderNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}