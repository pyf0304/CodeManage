
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCase4AppBL
 表名:vCourseLearningCase4App(01120271)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
public static class  clsvCourseLearningCase4AppBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCase4AppEN GetObj(this K_IdCourseLearningCase_vCourseLearningCase4App myKey)
{
clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = clsvCourseLearningCase4AppBL.vCourseLearningCase4AppDA.GetObjByIdCourseLearningCase(myKey.Value);
return objvCourseLearningCase4AppEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetIdCourseLearningCase(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strIdCourseLearningCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseLearningCase, 8, convCourseLearningCase4App.IdCourseLearningCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseLearningCase, 8, convCourseLearningCase4App.IdCourseLearningCase);
}
objvCourseLearningCase4AppEN.IdCourseLearningCase = strIdCourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.IdCourseLearningCase) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.IdCourseLearningCase, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.IdCourseLearningCase] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetCourseLearningCaseID(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseID, convCourseLearningCase4App.CourseLearningCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, convCourseLearningCase4App.CourseLearningCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, convCourseLearningCase4App.CourseLearningCaseID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetCourseLearningCaseName(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseName, convCourseLearningCase4App.CourseLearningCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningCase4App.CourseLearningCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetCourseId(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convCourseLearningCase4App.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCourseLearningCase4App.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCourseLearningCase4App.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetCourseCode(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCourseLearningCase4App.CourseCode);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetCourseName(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCourseLearningCase4App.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetCourseChapterId(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convCourseLearningCase4App.CourseChapterId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCourseLearningCase4App.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCourseLearningCase4App.CourseChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetChapterId(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterId, 8, convCourseLearningCase4App.ChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convCourseLearningCase4App.ChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetChapterName(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convCourseLearningCase4App.ChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetChapterNameSim(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convCourseLearningCase4App.ChapterNameSim);
}
objvCourseLearningCase4AppEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.ChapterNameSim) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.ChapterNameSim, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.ChapterNameSim] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetSectionName(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convCourseLearningCase4App.SectionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetSectionNameSim(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convCourseLearningCase4App.SectionNameSim);
}
objvCourseLearningCase4AppEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App.SectionNameSim) == false)
{
objvCourseLearningCase4AppEN.dicFldComparisonOp.Add(convCourseLearningCase4App.SectionNameSim, strComparisonOp);
}
else
{
objvCourseLearningCase4AppEN.dicFldComparisonOp[convCourseLearningCase4App.SectionNameSim] = strComparisonOp;
}
}
return objvCourseLearningCase4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetSectionId(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convCourseLearningCase4App.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convCourseLearningCase4App.SectionId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetVideoUrl(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convCourseLearningCase4App.VideoUrl);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetVideoPath(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convCourseLearningCase4App.VideoPath);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetUpdDate(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCourseLearningCase4App.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetMemo(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCourseLearningCase4App.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetBrowseCount4Case(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, int? intBrowseCount4Case, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetImageUrl(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, string strImageUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImageUrl, 100, convCourseLearningCase4App.ImageUrl);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4AppEN SetOrderNum(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN, int? intOrderNum, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppENS">源对象</param>
 /// <param name = "objvCourseLearningCase4AppENT">目标对象</param>
 public static void CopyTo(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppENS, clsvCourseLearningCase4AppEN objvCourseLearningCase4AppENT)
{
try
{
objvCourseLearningCase4AppENT.IdCourseLearningCase = objvCourseLearningCase4AppENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCase4AppENT.CourseLearningCaseID = objvCourseLearningCase4AppENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCase4AppENT.CourseLearningCaseName = objvCourseLearningCase4AppENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCase4AppENT.IsDualVideo = objvCourseLearningCase4AppENS.IsDualVideo; //是否双视频
objvCourseLearningCase4AppENT.CourseId = objvCourseLearningCase4AppENS.CourseId; //课程Id
objvCourseLearningCase4AppENT.CourseCode = objvCourseLearningCase4AppENS.CourseCode; //课程代码
objvCourseLearningCase4AppENT.CourseName = objvCourseLearningCase4AppENS.CourseName; //课程名称
objvCourseLearningCase4AppENT.CourseChapterId = objvCourseLearningCase4AppENS.CourseChapterId; //课程章节ID
objvCourseLearningCase4AppENT.ChapterId = objvCourseLearningCase4AppENS.ChapterId; //章Id
objvCourseLearningCase4AppENT.ChapterName = objvCourseLearningCase4AppENS.ChapterName; //章名
objvCourseLearningCase4AppENT.ChapterNameSim = objvCourseLearningCase4AppENS.ChapterNameSim; //章名简称
objvCourseLearningCase4AppENT.SectionName = objvCourseLearningCase4AppENS.SectionName; //节名
objvCourseLearningCase4AppENT.SectionNameSim = objvCourseLearningCase4AppENS.SectionNameSim; //节名简称
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
 /// <param name = "objvCourseLearningCase4AppENS">源对象</param>
 /// <returns>目标对象=>clsvCourseLearningCase4AppEN:objvCourseLearningCase4AppENT</returns>
 public static clsvCourseLearningCase4AppEN CopyTo(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppENS)
{
try
{
 clsvCourseLearningCase4AppEN objvCourseLearningCase4AppENT = new clsvCourseLearningCase4AppEN()
{
IdCourseLearningCase = objvCourseLearningCase4AppENS.IdCourseLearningCase, //课程学习案例流水号
CourseLearningCaseID = objvCourseLearningCase4AppENS.CourseLearningCaseID, //课程学习案例ID
CourseLearningCaseName = objvCourseLearningCase4AppENS.CourseLearningCaseName, //课程学习案例名称
IsDualVideo = objvCourseLearningCase4AppENS.IsDualVideo, //是否双视频
CourseId = objvCourseLearningCase4AppENS.CourseId, //课程Id
CourseCode = objvCourseLearningCase4AppENS.CourseCode, //课程代码
CourseName = objvCourseLearningCase4AppENS.CourseName, //课程名称
CourseChapterId = objvCourseLearningCase4AppENS.CourseChapterId, //课程章节ID
ChapterId = objvCourseLearningCase4AppENS.ChapterId, //章Id
ChapterName = objvCourseLearningCase4AppENS.ChapterName, //章名
ChapterNameSim = objvCourseLearningCase4AppENS.ChapterNameSim, //章名简称
SectionName = objvCourseLearningCase4AppENS.SectionName, //节名
SectionNameSim = objvCourseLearningCase4AppENS.SectionNameSim, //节名简称
SectionId = objvCourseLearningCase4AppENS.SectionId, //节Id
VideoUrl = objvCourseLearningCase4AppENS.VideoUrl, //视频Url
VideoPath = objvCourseLearningCase4AppENS.VideoPath, //视频目录
UpdDate = objvCourseLearningCase4AppENS.UpdDate, //修改日期
Memo = objvCourseLearningCase4AppENS.Memo, //备注
BrowseCount4Case = objvCourseLearningCase4AppENS.BrowseCount4Case, //课例浏览次数
ImageUrl = objvCourseLearningCase4AppENS.ImageUrl, //ImageUrl
OrderNum = objvCourseLearningCase4AppENS.OrderNum, //序号
};
 return objvCourseLearningCase4AppENT;
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
public static void CheckProperty4Condition(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN)
{
 clsvCourseLearningCase4AppBL.vCourseLearningCase4AppDA.CheckProperty4Condition(objvCourseLearningCase4AppEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningCase4AppEN objvCourseLearningCase4AppCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.IdCourseLearningCase) == true)
{
string strComparisonOpIdCourseLearningCase = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.IdCourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.IdCourseLearningCase, objvCourseLearningCase4AppCond.IdCourseLearningCase, strComparisonOpIdCourseLearningCase);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.CourseLearningCaseID) == true)
{
string strComparisonOpCourseLearningCaseID = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.CourseLearningCaseID, objvCourseLearningCase4AppCond.CourseLearningCaseID, strComparisonOpCourseLearningCaseID);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.CourseLearningCaseName) == true)
{
string strComparisonOpCourseLearningCaseName = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.CourseLearningCaseName, objvCourseLearningCase4AppCond.CourseLearningCaseName, strComparisonOpCourseLearningCaseName);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.IsDualVideo) == true)
{
if (objvCourseLearningCase4AppCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningCase4App.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningCase4App.IsDualVideo);
}
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.CourseId) == true)
{
string strComparisonOpCourseId = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.CourseId, objvCourseLearningCase4AppCond.CourseId, strComparisonOpCourseId);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.CourseCode) == true)
{
string strComparisonOpCourseCode = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.CourseCode, objvCourseLearningCase4AppCond.CourseCode, strComparisonOpCourseCode);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.CourseName) == true)
{
string strComparisonOpCourseName = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.CourseName, objvCourseLearningCase4AppCond.CourseName, strComparisonOpCourseName);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.CourseChapterId, objvCourseLearningCase4AppCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.ChapterId) == true)
{
string strComparisonOpChapterId = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.ChapterId, objvCourseLearningCase4AppCond.ChapterId, strComparisonOpChapterId);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.ChapterName) == true)
{
string strComparisonOpChapterName = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.ChapterName, objvCourseLearningCase4AppCond.ChapterName, strComparisonOpChapterName);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.ChapterNameSim, objvCourseLearningCase4AppCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.SectionName) == true)
{
string strComparisonOpSectionName = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.SectionName, objvCourseLearningCase4AppCond.SectionName, strComparisonOpSectionName);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.SectionNameSim, objvCourseLearningCase4AppCond.SectionNameSim, strComparisonOpSectionNameSim);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.SectionId) == true)
{
string strComparisonOpSectionId = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.SectionId, objvCourseLearningCase4AppCond.SectionId, strComparisonOpSectionId);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.VideoUrl, objvCourseLearningCase4AppCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.VideoPath) == true)
{
string strComparisonOpVideoPath = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.VideoPath, objvCourseLearningCase4AppCond.VideoPath, strComparisonOpVideoPath);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.UpdDate, objvCourseLearningCase4AppCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.Memo) == true)
{
string strComparisonOpMemo = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.Memo, objvCourseLearningCase4AppCond.Memo, strComparisonOpMemo);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase4App.BrowseCount4Case, objvCourseLearningCase4AppCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.ImageUrl) == true)
{
string strComparisonOpImageUrl = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App.ImageUrl, objvCourseLearningCase4AppCond.ImageUrl, strComparisonOpImageUrl);
}
if (objvCourseLearningCase4AppCond.IsUpdated(convCourseLearningCase4App.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCourseLearningCase4AppCond.dicFldComparisonOp[convCourseLearningCase4App.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase4App.OrderNum, objvCourseLearningCase4AppCond.OrderNum, strComparisonOpOrderNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCourseLearningCase4App
{
public virtual bool UpdRelaTabDate(string strIdCourseLearningCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程学习案例4App(vCourseLearningCase4App)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningCase4AppBL
{
public static RelatedActions_vCourseLearningCase4App relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCourseLearningCase4AppDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCourseLearningCase4AppDA vCourseLearningCase4AppDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCourseLearningCase4AppDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCourseLearningCase4AppBL()
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
if (string.IsNullOrEmpty(clsvCourseLearningCase4AppEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCourseLearningCase4AppEN._ConnectString);
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
public static DataTable GetDataTable_vCourseLearningCase4App(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCourseLearningCase4AppDA.GetDataTable_vCourseLearningCase4App(strWhereCond);
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
objDT = vCourseLearningCase4AppDA.GetDataTable(strWhereCond);
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
objDT = vCourseLearningCase4AppDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCourseLearningCase4AppDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCourseLearningCase4AppDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCourseLearningCase4AppDA.GetDataTable_Top(objTopPara);
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
objDT = vCourseLearningCase4AppDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCourseLearningCase4AppDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCourseLearningCase4AppDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCourseLearningCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCourseLearningCase4AppEN> GetObjLstByIdCourseLearningCaseLst(List<string> arrIdCourseLearningCaseLst)
{
List<clsvCourseLearningCase4AppEN> arrObjLst = new List<clsvCourseLearningCase4AppEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCourseLearningCaseLst, true);
 string strWhereCond = string.Format("IdCourseLearningCase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = new clsvCourseLearningCase4AppEN();
try
{
objvCourseLearningCase4AppEN.IdCourseLearningCase = objRow[convCourseLearningCase4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4AppEN.CourseLearningCaseID = objRow[convCourseLearningCase4App.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4AppEN.CourseLearningCaseName = objRow[convCourseLearningCase4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4AppEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase4App.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase4AppEN.CourseId = objRow[convCourseLearningCase4App.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4AppEN.CourseCode = objRow[convCourseLearningCase4App.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase4AppEN.CourseName = objRow[convCourseLearningCase4App.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase4AppEN.CourseChapterId = objRow[convCourseLearningCase4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4AppEN.ChapterId = objRow[convCourseLearningCase4App.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4AppEN.ChapterName = objRow[convCourseLearningCase4App.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4AppEN.ChapterNameSim = objRow[convCourseLearningCase4App.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4AppEN.SectionName = objRow[convCourseLearningCase4App.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionName].ToString().Trim(); //节名
objvCourseLearningCase4AppEN.SectionNameSim = objRow[convCourseLearningCase4App.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase4AppEN.SectionId = objRow[convCourseLearningCase4App.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase4AppEN.VideoUrl = objRow[convCourseLearningCase4App.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase4AppEN.VideoPath = objRow[convCourseLearningCase4App.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase4AppEN.UpdDate = objRow[convCourseLearningCase4App.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase4App.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase4AppEN.Memo = objRow[convCourseLearningCase4App.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase4App.Memo].ToString().Trim(); //备注
objvCourseLearningCase4AppEN.BrowseCount4Case = objRow[convCourseLearningCase4App.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase4AppEN.ImageUrl = objRow[convCourseLearningCase4App.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCase4AppEN.OrderNum = objRow[convCourseLearningCase4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4AppEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCourseLearningCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCourseLearningCase4AppEN> GetObjLstByIdCourseLearningCaseLstCache(List<string> arrIdCourseLearningCaseLst)
{
string strKey = string.Format("{0}", clsvCourseLearningCase4AppEN._CurrTabName);
List<clsvCourseLearningCase4AppEN> arrvCourseLearningCase4AppObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCase4AppEN> arrvCourseLearningCase4AppObjLst_Sel =
arrvCourseLearningCase4AppObjLstCache
.Where(x => arrIdCourseLearningCaseLst.Contains(x.IdCourseLearningCase));
return arrvCourseLearningCase4AppObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase4AppEN> GetObjLst(string strWhereCond)
{
List<clsvCourseLearningCase4AppEN> arrObjLst = new List<clsvCourseLearningCase4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = new clsvCourseLearningCase4AppEN();
try
{
objvCourseLearningCase4AppEN.IdCourseLearningCase = objRow[convCourseLearningCase4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4AppEN.CourseLearningCaseID = objRow[convCourseLearningCase4App.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4AppEN.CourseLearningCaseName = objRow[convCourseLearningCase4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4AppEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase4App.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase4AppEN.CourseId = objRow[convCourseLearningCase4App.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4AppEN.CourseCode = objRow[convCourseLearningCase4App.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase4AppEN.CourseName = objRow[convCourseLearningCase4App.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase4AppEN.CourseChapterId = objRow[convCourseLearningCase4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4AppEN.ChapterId = objRow[convCourseLearningCase4App.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4AppEN.ChapterName = objRow[convCourseLearningCase4App.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4AppEN.ChapterNameSim = objRow[convCourseLearningCase4App.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4AppEN.SectionName = objRow[convCourseLearningCase4App.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionName].ToString().Trim(); //节名
objvCourseLearningCase4AppEN.SectionNameSim = objRow[convCourseLearningCase4App.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase4AppEN.SectionId = objRow[convCourseLearningCase4App.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase4AppEN.VideoUrl = objRow[convCourseLearningCase4App.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase4AppEN.VideoPath = objRow[convCourseLearningCase4App.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase4AppEN.UpdDate = objRow[convCourseLearningCase4App.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase4App.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase4AppEN.Memo = objRow[convCourseLearningCase4App.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase4App.Memo].ToString().Trim(); //备注
objvCourseLearningCase4AppEN.BrowseCount4Case = objRow[convCourseLearningCase4App.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase4AppEN.ImageUrl = objRow[convCourseLearningCase4App.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCase4AppEN.OrderNum = objRow[convCourseLearningCase4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4AppEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4AppEN);
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
public static List<clsvCourseLearningCase4AppEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningCase4AppEN> arrObjLst = new List<clsvCourseLearningCase4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = new clsvCourseLearningCase4AppEN();
try
{
objvCourseLearningCase4AppEN.IdCourseLearningCase = objRow[convCourseLearningCase4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4AppEN.CourseLearningCaseID = objRow[convCourseLearningCase4App.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4AppEN.CourseLearningCaseName = objRow[convCourseLearningCase4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4AppEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase4App.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase4AppEN.CourseId = objRow[convCourseLearningCase4App.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4AppEN.CourseCode = objRow[convCourseLearningCase4App.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase4AppEN.CourseName = objRow[convCourseLearningCase4App.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase4AppEN.CourseChapterId = objRow[convCourseLearningCase4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4AppEN.ChapterId = objRow[convCourseLearningCase4App.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4AppEN.ChapterName = objRow[convCourseLearningCase4App.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4AppEN.ChapterNameSim = objRow[convCourseLearningCase4App.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4AppEN.SectionName = objRow[convCourseLearningCase4App.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionName].ToString().Trim(); //节名
objvCourseLearningCase4AppEN.SectionNameSim = objRow[convCourseLearningCase4App.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase4AppEN.SectionId = objRow[convCourseLearningCase4App.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase4AppEN.VideoUrl = objRow[convCourseLearningCase4App.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase4AppEN.VideoPath = objRow[convCourseLearningCase4App.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase4AppEN.UpdDate = objRow[convCourseLearningCase4App.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase4App.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase4AppEN.Memo = objRow[convCourseLearningCase4App.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase4App.Memo].ToString().Trim(); //备注
objvCourseLearningCase4AppEN.BrowseCount4Case = objRow[convCourseLearningCase4App.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase4AppEN.ImageUrl = objRow[convCourseLearningCase4App.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCase4AppEN.OrderNum = objRow[convCourseLearningCase4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4AppEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCourseLearningCase4AppEN> GetSubObjLstCache(clsvCourseLearningCase4AppEN objvCourseLearningCase4AppCond)
{
List<clsvCourseLearningCase4AppEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCase4AppEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningCase4App.AttributeName)
{
if (objvCourseLearningCase4AppCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningCase4AppCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCase4AppCond[strFldName].ToString());
}
else
{
if (objvCourseLearningCase4AppCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningCase4AppCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCase4AppCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningCase4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningCase4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningCase4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningCase4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningCase4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningCase4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningCase4AppCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCase4AppCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCase4AppCond[strFldName]));
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
public static List<clsvCourseLearningCase4AppEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCourseLearningCase4AppEN> arrObjLst = new List<clsvCourseLearningCase4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = new clsvCourseLearningCase4AppEN();
try
{
objvCourseLearningCase4AppEN.IdCourseLearningCase = objRow[convCourseLearningCase4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4AppEN.CourseLearningCaseID = objRow[convCourseLearningCase4App.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4AppEN.CourseLearningCaseName = objRow[convCourseLearningCase4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4AppEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase4App.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase4AppEN.CourseId = objRow[convCourseLearningCase4App.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4AppEN.CourseCode = objRow[convCourseLearningCase4App.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase4AppEN.CourseName = objRow[convCourseLearningCase4App.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase4AppEN.CourseChapterId = objRow[convCourseLearningCase4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4AppEN.ChapterId = objRow[convCourseLearningCase4App.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4AppEN.ChapterName = objRow[convCourseLearningCase4App.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4AppEN.ChapterNameSim = objRow[convCourseLearningCase4App.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4AppEN.SectionName = objRow[convCourseLearningCase4App.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionName].ToString().Trim(); //节名
objvCourseLearningCase4AppEN.SectionNameSim = objRow[convCourseLearningCase4App.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase4AppEN.SectionId = objRow[convCourseLearningCase4App.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase4AppEN.VideoUrl = objRow[convCourseLearningCase4App.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase4AppEN.VideoPath = objRow[convCourseLearningCase4App.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase4AppEN.UpdDate = objRow[convCourseLearningCase4App.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase4App.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase4AppEN.Memo = objRow[convCourseLearningCase4App.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase4App.Memo].ToString().Trim(); //备注
objvCourseLearningCase4AppEN.BrowseCount4Case = objRow[convCourseLearningCase4App.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase4AppEN.ImageUrl = objRow[convCourseLearningCase4App.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCase4AppEN.OrderNum = objRow[convCourseLearningCase4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4AppEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4AppEN);
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
public static List<clsvCourseLearningCase4AppEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCourseLearningCase4AppEN> arrObjLst = new List<clsvCourseLearningCase4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = new clsvCourseLearningCase4AppEN();
try
{
objvCourseLearningCase4AppEN.IdCourseLearningCase = objRow[convCourseLearningCase4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4AppEN.CourseLearningCaseID = objRow[convCourseLearningCase4App.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4AppEN.CourseLearningCaseName = objRow[convCourseLearningCase4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4AppEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase4App.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase4AppEN.CourseId = objRow[convCourseLearningCase4App.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4AppEN.CourseCode = objRow[convCourseLearningCase4App.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase4AppEN.CourseName = objRow[convCourseLearningCase4App.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase4AppEN.CourseChapterId = objRow[convCourseLearningCase4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4AppEN.ChapterId = objRow[convCourseLearningCase4App.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4AppEN.ChapterName = objRow[convCourseLearningCase4App.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4AppEN.ChapterNameSim = objRow[convCourseLearningCase4App.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4AppEN.SectionName = objRow[convCourseLearningCase4App.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionName].ToString().Trim(); //节名
objvCourseLearningCase4AppEN.SectionNameSim = objRow[convCourseLearningCase4App.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase4AppEN.SectionId = objRow[convCourseLearningCase4App.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase4AppEN.VideoUrl = objRow[convCourseLearningCase4App.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase4AppEN.VideoPath = objRow[convCourseLearningCase4App.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase4AppEN.UpdDate = objRow[convCourseLearningCase4App.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase4App.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase4AppEN.Memo = objRow[convCourseLearningCase4App.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase4App.Memo].ToString().Trim(); //备注
objvCourseLearningCase4AppEN.BrowseCount4Case = objRow[convCourseLearningCase4App.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase4AppEN.ImageUrl = objRow[convCourseLearningCase4App.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCase4AppEN.OrderNum = objRow[convCourseLearningCase4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4AppEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4AppEN);
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
List<clsvCourseLearningCase4AppEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCourseLearningCase4AppEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase4AppEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCourseLearningCase4AppEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningCase4AppEN> arrObjLst = new List<clsvCourseLearningCase4AppEN>(); 
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
	clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = new clsvCourseLearningCase4AppEN();
try
{
objvCourseLearningCase4AppEN.IdCourseLearningCase = objRow[convCourseLearningCase4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4AppEN.CourseLearningCaseID = objRow[convCourseLearningCase4App.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4AppEN.CourseLearningCaseName = objRow[convCourseLearningCase4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4AppEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase4App.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase4AppEN.CourseId = objRow[convCourseLearningCase4App.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4AppEN.CourseCode = objRow[convCourseLearningCase4App.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase4AppEN.CourseName = objRow[convCourseLearningCase4App.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase4AppEN.CourseChapterId = objRow[convCourseLearningCase4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4AppEN.ChapterId = objRow[convCourseLearningCase4App.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4AppEN.ChapterName = objRow[convCourseLearningCase4App.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4AppEN.ChapterNameSim = objRow[convCourseLearningCase4App.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4AppEN.SectionName = objRow[convCourseLearningCase4App.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionName].ToString().Trim(); //节名
objvCourseLearningCase4AppEN.SectionNameSim = objRow[convCourseLearningCase4App.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase4AppEN.SectionId = objRow[convCourseLearningCase4App.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase4AppEN.VideoUrl = objRow[convCourseLearningCase4App.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase4AppEN.VideoPath = objRow[convCourseLearningCase4App.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase4AppEN.UpdDate = objRow[convCourseLearningCase4App.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase4App.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase4AppEN.Memo = objRow[convCourseLearningCase4App.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase4App.Memo].ToString().Trim(); //备注
objvCourseLearningCase4AppEN.BrowseCount4Case = objRow[convCourseLearningCase4App.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase4AppEN.ImageUrl = objRow[convCourseLearningCase4App.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCase4AppEN.OrderNum = objRow[convCourseLearningCase4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4AppEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4AppEN);
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
public static List<clsvCourseLearningCase4AppEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningCase4AppEN> arrObjLst = new List<clsvCourseLearningCase4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = new clsvCourseLearningCase4AppEN();
try
{
objvCourseLearningCase4AppEN.IdCourseLearningCase = objRow[convCourseLearningCase4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4AppEN.CourseLearningCaseID = objRow[convCourseLearningCase4App.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4AppEN.CourseLearningCaseName = objRow[convCourseLearningCase4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4AppEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase4App.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase4AppEN.CourseId = objRow[convCourseLearningCase4App.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4AppEN.CourseCode = objRow[convCourseLearningCase4App.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase4AppEN.CourseName = objRow[convCourseLearningCase4App.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase4AppEN.CourseChapterId = objRow[convCourseLearningCase4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4AppEN.ChapterId = objRow[convCourseLearningCase4App.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4AppEN.ChapterName = objRow[convCourseLearningCase4App.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4AppEN.ChapterNameSim = objRow[convCourseLearningCase4App.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4AppEN.SectionName = objRow[convCourseLearningCase4App.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionName].ToString().Trim(); //节名
objvCourseLearningCase4AppEN.SectionNameSim = objRow[convCourseLearningCase4App.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase4AppEN.SectionId = objRow[convCourseLearningCase4App.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase4AppEN.VideoUrl = objRow[convCourseLearningCase4App.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase4AppEN.VideoPath = objRow[convCourseLearningCase4App.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase4AppEN.UpdDate = objRow[convCourseLearningCase4App.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase4App.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase4AppEN.Memo = objRow[convCourseLearningCase4App.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase4App.Memo].ToString().Trim(); //备注
objvCourseLearningCase4AppEN.BrowseCount4Case = objRow[convCourseLearningCase4App.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase4AppEN.ImageUrl = objRow[convCourseLearningCase4App.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCase4AppEN.OrderNum = objRow[convCourseLearningCase4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4AppEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCourseLearningCase4AppEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCourseLearningCase4AppEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningCase4AppEN> arrObjLst = new List<clsvCourseLearningCase4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = new clsvCourseLearningCase4AppEN();
try
{
objvCourseLearningCase4AppEN.IdCourseLearningCase = objRow[convCourseLearningCase4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4AppEN.CourseLearningCaseID = objRow[convCourseLearningCase4App.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4AppEN.CourseLearningCaseName = objRow[convCourseLearningCase4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4AppEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase4App.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase4AppEN.CourseId = objRow[convCourseLearningCase4App.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4AppEN.CourseCode = objRow[convCourseLearningCase4App.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase4AppEN.CourseName = objRow[convCourseLearningCase4App.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase4AppEN.CourseChapterId = objRow[convCourseLearningCase4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4AppEN.ChapterId = objRow[convCourseLearningCase4App.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4AppEN.ChapterName = objRow[convCourseLearningCase4App.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4AppEN.ChapterNameSim = objRow[convCourseLearningCase4App.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4AppEN.SectionName = objRow[convCourseLearningCase4App.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionName].ToString().Trim(); //节名
objvCourseLearningCase4AppEN.SectionNameSim = objRow[convCourseLearningCase4App.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase4AppEN.SectionId = objRow[convCourseLearningCase4App.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase4AppEN.VideoUrl = objRow[convCourseLearningCase4App.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase4AppEN.VideoPath = objRow[convCourseLearningCase4App.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase4AppEN.UpdDate = objRow[convCourseLearningCase4App.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase4App.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase4AppEN.Memo = objRow[convCourseLearningCase4App.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase4App.Memo].ToString().Trim(); //备注
objvCourseLearningCase4AppEN.BrowseCount4Case = objRow[convCourseLearningCase4App.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase4AppEN.ImageUrl = objRow[convCourseLearningCase4App.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCase4AppEN.OrderNum = objRow[convCourseLearningCase4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4AppEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4AppEN);
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
public static List<clsvCourseLearningCase4AppEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCourseLearningCase4AppEN> arrObjLst = new List<clsvCourseLearningCase4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = new clsvCourseLearningCase4AppEN();
try
{
objvCourseLearningCase4AppEN.IdCourseLearningCase = objRow[convCourseLearningCase4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4AppEN.CourseLearningCaseID = objRow[convCourseLearningCase4App.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4AppEN.CourseLearningCaseName = objRow[convCourseLearningCase4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4AppEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase4App.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase4AppEN.CourseId = objRow[convCourseLearningCase4App.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4AppEN.CourseCode = objRow[convCourseLearningCase4App.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase4AppEN.CourseName = objRow[convCourseLearningCase4App.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase4AppEN.CourseChapterId = objRow[convCourseLearningCase4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4AppEN.ChapterId = objRow[convCourseLearningCase4App.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4AppEN.ChapterName = objRow[convCourseLearningCase4App.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4AppEN.ChapterNameSim = objRow[convCourseLearningCase4App.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4AppEN.SectionName = objRow[convCourseLearningCase4App.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionName].ToString().Trim(); //节名
objvCourseLearningCase4AppEN.SectionNameSim = objRow[convCourseLearningCase4App.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase4AppEN.SectionId = objRow[convCourseLearningCase4App.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase4AppEN.VideoUrl = objRow[convCourseLearningCase4App.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase4AppEN.VideoPath = objRow[convCourseLearningCase4App.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase4AppEN.UpdDate = objRow[convCourseLearningCase4App.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase4App.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase4AppEN.Memo = objRow[convCourseLearningCase4App.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase4App.Memo].ToString().Trim(); //备注
objvCourseLearningCase4AppEN.BrowseCount4Case = objRow[convCourseLearningCase4App.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase4AppEN.ImageUrl = objRow[convCourseLearningCase4App.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCase4AppEN.OrderNum = objRow[convCourseLearningCase4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4AppEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase4AppEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCourseLearningCase4AppEN> arrObjLst = new List<clsvCourseLearningCase4AppEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = new clsvCourseLearningCase4AppEN();
try
{
objvCourseLearningCase4AppEN.IdCourseLearningCase = objRow[convCourseLearningCase4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4AppEN.CourseLearningCaseID = objRow[convCourseLearningCase4App.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4AppEN.CourseLearningCaseName = objRow[convCourseLearningCase4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4AppEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCase4App.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCase4AppEN.CourseId = objRow[convCourseLearningCase4App.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4AppEN.CourseCode = objRow[convCourseLearningCase4App.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCase4AppEN.CourseName = objRow[convCourseLearningCase4App.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCase4AppEN.CourseChapterId = objRow[convCourseLearningCase4App.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4AppEN.ChapterId = objRow[convCourseLearningCase4App.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4AppEN.ChapterName = objRow[convCourseLearningCase4App.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4AppEN.ChapterNameSim = objRow[convCourseLearningCase4App.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4AppEN.SectionName = objRow[convCourseLearningCase4App.SectionName] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionName].ToString().Trim(); //节名
objvCourseLearningCase4AppEN.SectionNameSim = objRow[convCourseLearningCase4App.SectionNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionNameSim].ToString().Trim(); //节名简称
objvCourseLearningCase4AppEN.SectionId = objRow[convCourseLearningCase4App.SectionId] == DBNull.Value ? null : objRow[convCourseLearningCase4App.SectionId].ToString().Trim(); //节Id
objvCourseLearningCase4AppEN.VideoUrl = objRow[convCourseLearningCase4App.VideoUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoUrl].ToString().Trim(); //视频Url
objvCourseLearningCase4AppEN.VideoPath = objRow[convCourseLearningCase4App.VideoPath] == DBNull.Value ? null : objRow[convCourseLearningCase4App.VideoPath].ToString().Trim(); //视频目录
objvCourseLearningCase4AppEN.UpdDate = objRow[convCourseLearningCase4App.UpdDate] == DBNull.Value ? null : objRow[convCourseLearningCase4App.UpdDate].ToString().Trim(); //修改日期
objvCourseLearningCase4AppEN.Memo = objRow[convCourseLearningCase4App.Memo] == DBNull.Value ? null : objRow[convCourseLearningCase4App.Memo].ToString().Trim(); //备注
objvCourseLearningCase4AppEN.BrowseCount4Case = objRow[convCourseLearningCase4App.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCase4AppEN.ImageUrl = objRow[convCourseLearningCase4App.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App.ImageUrl].ToString().Trim(); //ImageUrl
objvCourseLearningCase4AppEN.OrderNum = objRow[convCourseLearningCase4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4AppEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4AppEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCourseLearningCase4App(ref clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN)
{
bool bolResult = vCourseLearningCase4AppDA.GetvCourseLearningCase4App(ref objvCourseLearningCase4AppEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCase4AppEN GetObjByIdCourseLearningCase(string strIdCourseLearningCase)
{
if (strIdCourseLearningCase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdCourseLearningCase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdCourseLearningCase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdCourseLearningCase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = vCourseLearningCase4AppDA.GetObjByIdCourseLearningCase(strIdCourseLearningCase);
return objvCourseLearningCase4AppEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCourseLearningCase4AppEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = vCourseLearningCase4AppDA.GetFirstObj(strWhereCond);
 return objvCourseLearningCase4AppEN;
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
public static clsvCourseLearningCase4AppEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = vCourseLearningCase4AppDA.GetObjByDataRow(objRow);
 return objvCourseLearningCase4AppEN;
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
public static clsvCourseLearningCase4AppEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN = vCourseLearningCase4AppDA.GetObjByDataRow(objRow);
 return objvCourseLearningCase4AppEN;
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
 /// <param name = "strIdCourseLearningCase">所给的关键字</param>
 /// <param name = "lstvCourseLearningCase4AppObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCase4AppEN GetObjByIdCourseLearningCaseFromList(string strIdCourseLearningCase, List<clsvCourseLearningCase4AppEN> lstvCourseLearningCase4AppObjLst)
{
foreach (clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN in lstvCourseLearningCase4AppObjLst)
{
if (objvCourseLearningCase4AppEN.IdCourseLearningCase == strIdCourseLearningCase)
{
return objvCourseLearningCase4AppEN;
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
 string strIdCourseLearningCase;
 try
 {
 strIdCourseLearningCase = new clsvCourseLearningCase4AppDA().GetFirstID(strWhereCond);
 return strIdCourseLearningCase;
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
 arrList = vCourseLearningCase4AppDA.GetID(strWhereCond);
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
bool bolIsExist = vCourseLearningCase4AppDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdCourseLearningCase)
{
if (string.IsNullOrEmpty(strIdCourseLearningCase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdCourseLearningCase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vCourseLearningCase4AppDA.IsExist(strIdCourseLearningCase);
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
 bolIsExist = clsvCourseLearningCase4AppDA.IsExistTable();
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
 bolIsExist = vCourseLearningCase4AppDA.IsExistTable(strTabName);
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
 /// <param name = "objvCourseLearningCase4AppENS">源对象</param>
 /// <param name = "objvCourseLearningCase4AppENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningCase4AppEN objvCourseLearningCase4AppENS, clsvCourseLearningCase4AppEN objvCourseLearningCase4AppENT)
{
try
{
objvCourseLearningCase4AppENT.IdCourseLearningCase = objvCourseLearningCase4AppENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCase4AppENT.CourseLearningCaseID = objvCourseLearningCase4AppENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCase4AppENT.CourseLearningCaseName = objvCourseLearningCase4AppENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCase4AppENT.IsDualVideo = objvCourseLearningCase4AppENS.IsDualVideo; //是否双视频
objvCourseLearningCase4AppENT.CourseId = objvCourseLearningCase4AppENS.CourseId; //课程Id
objvCourseLearningCase4AppENT.CourseCode = objvCourseLearningCase4AppENS.CourseCode; //课程代码
objvCourseLearningCase4AppENT.CourseName = objvCourseLearningCase4AppENS.CourseName; //课程名称
objvCourseLearningCase4AppENT.CourseChapterId = objvCourseLearningCase4AppENS.CourseChapterId; //课程章节ID
objvCourseLearningCase4AppENT.ChapterId = objvCourseLearningCase4AppENS.ChapterId; //章Id
objvCourseLearningCase4AppENT.ChapterName = objvCourseLearningCase4AppENS.ChapterName; //章名
objvCourseLearningCase4AppENT.ChapterNameSim = objvCourseLearningCase4AppENS.ChapterNameSim; //章名简称
objvCourseLearningCase4AppENT.SectionName = objvCourseLearningCase4AppENS.SectionName; //节名
objvCourseLearningCase4AppENT.SectionNameSim = objvCourseLearningCase4AppENS.SectionNameSim; //节名简称
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
 /// <param name = "objvCourseLearningCase4AppEN">源简化对象</param>
 public static void SetUpdFlag(clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN)
{
try
{
objvCourseLearningCase4AppEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCourseLearningCase4AppEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCourseLearningCase4App.IdCourseLearningCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.IdCourseLearningCase = objvCourseLearningCase4AppEN.IdCourseLearningCase; //课程学习案例流水号
}
if (arrFldSet.Contains(convCourseLearningCase4App.CourseLearningCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.CourseLearningCaseID = objvCourseLearningCase4AppEN.CourseLearningCaseID; //课程学习案例ID
}
if (arrFldSet.Contains(convCourseLearningCase4App.CourseLearningCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.CourseLearningCaseName = objvCourseLearningCase4AppEN.CourseLearningCaseName; //课程学习案例名称
}
if (arrFldSet.Contains(convCourseLearningCase4App.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.IsDualVideo = objvCourseLearningCase4AppEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convCourseLearningCase4App.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.CourseId = objvCourseLearningCase4AppEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convCourseLearningCase4App.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.CourseCode = objvCourseLearningCase4AppEN.CourseCode == "[null]" ? null :  objvCourseLearningCase4AppEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convCourseLearningCase4App.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.CourseName = objvCourseLearningCase4AppEN.CourseName == "[null]" ? null :  objvCourseLearningCase4AppEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convCourseLearningCase4App.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.CourseChapterId = objvCourseLearningCase4AppEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convCourseLearningCase4App.ChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.ChapterId = objvCourseLearningCase4AppEN.ChapterId == "[null]" ? null :  objvCourseLearningCase4AppEN.ChapterId; //章Id
}
if (arrFldSet.Contains(convCourseLearningCase4App.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.ChapterName = objvCourseLearningCase4AppEN.ChapterName == "[null]" ? null :  objvCourseLearningCase4AppEN.ChapterName; //章名
}
if (arrFldSet.Contains(convCourseLearningCase4App.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.ChapterNameSim = objvCourseLearningCase4AppEN.ChapterNameSim == "[null]" ? null :  objvCourseLearningCase4AppEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convCourseLearningCase4App.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.SectionName = objvCourseLearningCase4AppEN.SectionName == "[null]" ? null :  objvCourseLearningCase4AppEN.SectionName; //节名
}
if (arrFldSet.Contains(convCourseLearningCase4App.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.SectionNameSim = objvCourseLearningCase4AppEN.SectionNameSim == "[null]" ? null :  objvCourseLearningCase4AppEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convCourseLearningCase4App.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.SectionId = objvCourseLearningCase4AppEN.SectionId == "[null]" ? null :  objvCourseLearningCase4AppEN.SectionId; //节Id
}
if (arrFldSet.Contains(convCourseLearningCase4App.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.VideoUrl = objvCourseLearningCase4AppEN.VideoUrl == "[null]" ? null :  objvCourseLearningCase4AppEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(convCourseLearningCase4App.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.VideoPath = objvCourseLearningCase4AppEN.VideoPath == "[null]" ? null :  objvCourseLearningCase4AppEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(convCourseLearningCase4App.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.UpdDate = objvCourseLearningCase4AppEN.UpdDate == "[null]" ? null :  objvCourseLearningCase4AppEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCourseLearningCase4App.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.Memo = objvCourseLearningCase4AppEN.Memo == "[null]" ? null :  objvCourseLearningCase4AppEN.Memo; //备注
}
if (arrFldSet.Contains(convCourseLearningCase4App.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.BrowseCount4Case = objvCourseLearningCase4AppEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convCourseLearningCase4App.ImageUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.ImageUrl = objvCourseLearningCase4AppEN.ImageUrl == "[null]" ? null :  objvCourseLearningCase4AppEN.ImageUrl; //ImageUrl
}
if (arrFldSet.Contains(convCourseLearningCase4App.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4AppEN.OrderNum = objvCourseLearningCase4AppEN.OrderNum; //序号
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
 /// <param name = "objvCourseLearningCase4AppEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN)
{
try
{
if (objvCourseLearningCase4AppEN.CourseCode == "[null]") objvCourseLearningCase4AppEN.CourseCode = null; //课程代码
if (objvCourseLearningCase4AppEN.CourseName == "[null]") objvCourseLearningCase4AppEN.CourseName = null; //课程名称
if (objvCourseLearningCase4AppEN.ChapterId == "[null]") objvCourseLearningCase4AppEN.ChapterId = null; //章Id
if (objvCourseLearningCase4AppEN.ChapterName == "[null]") objvCourseLearningCase4AppEN.ChapterName = null; //章名
if (objvCourseLearningCase4AppEN.ChapterNameSim == "[null]") objvCourseLearningCase4AppEN.ChapterNameSim = null; //章名简称
if (objvCourseLearningCase4AppEN.SectionName == "[null]") objvCourseLearningCase4AppEN.SectionName = null; //节名
if (objvCourseLearningCase4AppEN.SectionNameSim == "[null]") objvCourseLearningCase4AppEN.SectionNameSim = null; //节名简称
if (objvCourseLearningCase4AppEN.SectionId == "[null]") objvCourseLearningCase4AppEN.SectionId = null; //节Id
if (objvCourseLearningCase4AppEN.VideoUrl == "[null]") objvCourseLearningCase4AppEN.VideoUrl = null; //视频Url
if (objvCourseLearningCase4AppEN.VideoPath == "[null]") objvCourseLearningCase4AppEN.VideoPath = null; //视频目录
if (objvCourseLearningCase4AppEN.UpdDate == "[null]") objvCourseLearningCase4AppEN.UpdDate = null; //修改日期
if (objvCourseLearningCase4AppEN.Memo == "[null]") objvCourseLearningCase4AppEN.Memo = null; //备注
if (objvCourseLearningCase4AppEN.ImageUrl == "[null]") objvCourseLearningCase4AppEN.ImageUrl = null; //ImageUrl
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
public static void CheckProperty4Condition(clsvCourseLearningCase4AppEN objvCourseLearningCase4AppEN)
{
 vCourseLearningCase4AppDA.CheckProperty4Condition(objvCourseLearningCase4AppEN);
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
if (clsCourseLearningCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseBL没有刷新缓存机制(clsCourseLearningCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesBL没有刷新缓存机制(clscc_ThemesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCourseLearningCase");
//if (arrvCourseLearningCase4AppObjLstCache == null)
//{
//arrvCourseLearningCase4AppObjLstCache = vCourseLearningCase4AppDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCase4AppEN GetObjByIdCourseLearningCaseCache(string strIdCourseLearningCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCourseLearningCase4AppEN._CurrTabName);
List<clsvCourseLearningCase4AppEN> arrvCourseLearningCase4AppObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCase4AppEN> arrvCourseLearningCase4AppObjLst_Sel =
arrvCourseLearningCase4AppObjLstCache
.Where(x=> x.IdCourseLearningCase == strIdCourseLearningCase 
);
if (arrvCourseLearningCase4AppObjLst_Sel.Count() == 0)
{
   clsvCourseLearningCase4AppEN obj = clsvCourseLearningCase4AppBL.GetObjByIdCourseLearningCase(strIdCourseLearningCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCourseLearningCase4AppObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningCase4AppEN> GetAllvCourseLearningCase4AppObjLstCache()
{
//获取缓存中的对象列表
List<clsvCourseLearningCase4AppEN> arrvCourseLearningCase4AppObjLstCache = GetObjLstCache(); 
return arrvCourseLearningCase4AppObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningCase4AppEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningCase4AppEN._CurrTabName);
List<clsvCourseLearningCase4AppEN> arrvCourseLearningCase4AppObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningCase4AppObjLstCache;
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
string strKey = string.Format("{0}", clsvCourseLearningCase4AppEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdCourseLearningCase)
{
if (strInFldName != convCourseLearningCase4App.IdCourseLearningCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCourseLearningCase4App.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCourseLearningCase4App.AttributeName));
throw new Exception(strMsg);
}
var objvCourseLearningCase4App = clsvCourseLearningCase4AppBL.GetObjByIdCourseLearningCaseCache(strIdCourseLearningCase);
if (objvCourseLearningCase4App == null) return "";
return objvCourseLearningCase4App[strOutFldName].ToString();
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
int intRecCount = clsvCourseLearningCase4AppDA.GetRecCount(strTabName);
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
int intRecCount = clsvCourseLearningCase4AppDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCourseLearningCase4AppDA.GetRecCount();
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
int intRecCount = clsvCourseLearningCase4AppDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCourseLearningCase4AppCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCourseLearningCase4AppEN objvCourseLearningCase4AppCond)
{
List<clsvCourseLearningCase4AppEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCase4AppEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningCase4App.AttributeName)
{
if (objvCourseLearningCase4AppCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningCase4AppCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCase4AppCond[strFldName].ToString());
}
else
{
if (objvCourseLearningCase4AppCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningCase4AppCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCase4AppCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningCase4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningCase4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningCase4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningCase4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningCase4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningCase4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningCase4AppCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCase4AppCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCase4AppCond[strFldName]));
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
 List<string> arrList = clsvCourseLearningCase4AppDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningCase4AppDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningCase4AppDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}