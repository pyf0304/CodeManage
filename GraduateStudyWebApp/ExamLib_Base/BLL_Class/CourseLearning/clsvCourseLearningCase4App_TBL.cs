
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCase4App_TBL
 表名:vCourseLearningCase4App_T(01120272)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:49
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
public static class  clsvCourseLearningCase4App_TBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCase4App_TEN GetObj(this K_IdCourseLearningCase_vCourseLearningCase4App_T myKey)
{
clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN = clsvCourseLearningCase4App_TBL.vCourseLearningCase4App_TDA.GetObjByIdCourseLearningCase(myKey.Value);
return objvCourseLearningCase4App_TEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetIdCourseLearningCase(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strIdCourseLearningCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseLearningCase, 8, convCourseLearningCase4App_T.IdCourseLearningCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseLearningCase, 8, convCourseLearningCase4App_T.IdCourseLearningCase);
}
objvCourseLearningCase4App_TEN.IdCourseLearningCase = strIdCourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4App_TEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App_T.IdCourseLearningCase) == false)
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp.Add(convCourseLearningCase4App_T.IdCourseLearningCase, strComparisonOp);
}
else
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp[convCourseLearningCase4App_T.IdCourseLearningCase] = strComparisonOp;
}
}
return objvCourseLearningCase4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetCourseLearningCaseID(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseID, convCourseLearningCase4App_T.CourseLearningCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, convCourseLearningCase4App_T.CourseLearningCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, convCourseLearningCase4App_T.CourseLearningCaseID);
}
objvCourseLearningCase4App_TEN.CourseLearningCaseID = strCourseLearningCaseID; //课程学习案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4App_TEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App_T.CourseLearningCaseID) == false)
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp.Add(convCourseLearningCase4App_T.CourseLearningCaseID, strComparisonOp);
}
else
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp[convCourseLearningCase4App_T.CourseLearningCaseID] = strComparisonOp;
}
}
return objvCourseLearningCase4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetCourseLearningCaseName(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseName, convCourseLearningCase4App_T.CourseLearningCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningCase4App_T.CourseLearningCaseName);
}
objvCourseLearningCase4App_TEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4App_TEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App_T.CourseLearningCaseName) == false)
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp.Add(convCourseLearningCase4App_T.CourseLearningCaseName, strComparisonOp);
}
else
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp[convCourseLearningCase4App_T.CourseLearningCaseName] = strComparisonOp;
}
}
return objvCourseLearningCase4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetCourseId(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convCourseLearningCase4App_T.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCourseLearningCase4App_T.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCourseLearningCase4App_T.CourseId);
}
objvCourseLearningCase4App_TEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4App_TEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App_T.CourseId) == false)
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp.Add(convCourseLearningCase4App_T.CourseId, strComparisonOp);
}
else
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp[convCourseLearningCase4App_T.CourseId] = strComparisonOp;
}
}
return objvCourseLearningCase4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetCourseChapterId(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convCourseLearningCase4App_T.CourseChapterId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCourseLearningCase4App_T.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCourseLearningCase4App_T.CourseChapterId);
}
objvCourseLearningCase4App_TEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4App_TEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App_T.CourseChapterId) == false)
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp.Add(convCourseLearningCase4App_T.CourseChapterId, strComparisonOp);
}
else
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp[convCourseLearningCase4App_T.CourseChapterId] = strComparisonOp;
}
}
return objvCourseLearningCase4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetChapterId(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterId, 8, convCourseLearningCase4App_T.ChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convCourseLearningCase4App_T.ChapterId);
}
objvCourseLearningCase4App_TEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4App_TEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App_T.ChapterId) == false)
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp.Add(convCourseLearningCase4App_T.ChapterId, strComparisonOp);
}
else
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp[convCourseLearningCase4App_T.ChapterId] = strComparisonOp;
}
}
return objvCourseLearningCase4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetChapterName(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convCourseLearningCase4App_T.ChapterName);
}
objvCourseLearningCase4App_TEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4App_TEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App_T.ChapterName) == false)
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp.Add(convCourseLearningCase4App_T.ChapterName, strComparisonOp);
}
else
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp[convCourseLearningCase4App_T.ChapterName] = strComparisonOp;
}
}
return objvCourseLearningCase4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetChapterNameSim(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convCourseLearningCase4App_T.ChapterNameSim);
}
objvCourseLearningCase4App_TEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4App_TEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App_T.ChapterNameSim) == false)
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp.Add(convCourseLearningCase4App_T.ChapterNameSim, strComparisonOp);
}
else
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp[convCourseLearningCase4App_T.ChapterNameSim] = strComparisonOp;
}
}
return objvCourseLearningCase4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetOrderNum4Chapter(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, int? intOrderNum4Chapter, string strComparisonOp="")
	{
objvCourseLearningCase4App_TEN.OrderNum4Chapter = intOrderNum4Chapter; //OrderNum4Chapter
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4App_TEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App_T.OrderNum4Chapter) == false)
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp.Add(convCourseLearningCase4App_T.OrderNum4Chapter, strComparisonOp);
}
else
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp[convCourseLearningCase4App_T.OrderNum4Chapter] = strComparisonOp;
}
}
return objvCourseLearningCase4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetRecommendedDegreeId(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convCourseLearningCase4App_T.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convCourseLearningCase4App_T.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convCourseLearningCase4App_T.RecommendedDegreeId);
}
objvCourseLearningCase4App_TEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4App_TEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App_T.RecommendedDegreeId) == false)
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp.Add(convCourseLearningCase4App_T.RecommendedDegreeId, strComparisonOp);
}
else
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp[convCourseLearningCase4App_T.RecommendedDegreeId] = strComparisonOp;
}
}
return objvCourseLearningCase4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetImageUrl(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strImageUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImageUrl, 100, convCourseLearningCase4App_T.ImageUrl);
}
objvCourseLearningCase4App_TEN.ImageUrl = strImageUrl; //ImageUrl
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4App_TEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App_T.ImageUrl) == false)
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp.Add(convCourseLearningCase4App_T.ImageUrl, strComparisonOp);
}
else
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp[convCourseLearningCase4App_T.ImageUrl] = strComparisonOp;
}
}
return objvCourseLearningCase4App_TEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TENS">源对象</param>
 /// <param name = "objvCourseLearningCase4App_TENT">目标对象</param>
 public static void CopyTo(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TENS, clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TENT)
{
try
{
objvCourseLearningCase4App_TENT.IdCourseLearningCase = objvCourseLearningCase4App_TENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCase4App_TENT.CourseLearningCaseID = objvCourseLearningCase4App_TENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCase4App_TENT.CourseLearningCaseName = objvCourseLearningCase4App_TENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCase4App_TENT.CourseId = objvCourseLearningCase4App_TENS.CourseId; //课程Id
objvCourseLearningCase4App_TENT.CourseChapterId = objvCourseLearningCase4App_TENS.CourseChapterId; //课程章节ID
objvCourseLearningCase4App_TENT.ChapterId = objvCourseLearningCase4App_TENS.ChapterId; //章Id
objvCourseLearningCase4App_TENT.ChapterName = objvCourseLearningCase4App_TENS.ChapterName; //章名
objvCourseLearningCase4App_TENT.ChapterNameSim = objvCourseLearningCase4App_TENS.ChapterNameSim; //章名简称
objvCourseLearningCase4App_TENT.OrderNum4Chapter = objvCourseLearningCase4App_TENS.OrderNum4Chapter; //OrderNum4Chapter
objvCourseLearningCase4App_TENT.RecommendedDegreeId = objvCourseLearningCase4App_TENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCase4App_TENT.ImageUrl = objvCourseLearningCase4App_TENS.ImageUrl; //ImageUrl
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
 /// <param name = "objvCourseLearningCase4App_TENS">源对象</param>
 /// <returns>目标对象=>clsvCourseLearningCase4App_TEN:objvCourseLearningCase4App_TENT</returns>
 public static clsvCourseLearningCase4App_TEN CopyTo(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TENS)
{
try
{
 clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TENT = new clsvCourseLearningCase4App_TEN()
{
IdCourseLearningCase = objvCourseLearningCase4App_TENS.IdCourseLearningCase, //课程学习案例流水号
CourseLearningCaseID = objvCourseLearningCase4App_TENS.CourseLearningCaseID, //课程学习案例ID
CourseLearningCaseName = objvCourseLearningCase4App_TENS.CourseLearningCaseName, //课程学习案例名称
CourseId = objvCourseLearningCase4App_TENS.CourseId, //课程Id
CourseChapterId = objvCourseLearningCase4App_TENS.CourseChapterId, //课程章节ID
ChapterId = objvCourseLearningCase4App_TENS.ChapterId, //章Id
ChapterName = objvCourseLearningCase4App_TENS.ChapterName, //章名
ChapterNameSim = objvCourseLearningCase4App_TENS.ChapterNameSim, //章名简称
OrderNum4Chapter = objvCourseLearningCase4App_TENS.OrderNum4Chapter, //OrderNum4Chapter
RecommendedDegreeId = objvCourseLearningCase4App_TENS.RecommendedDegreeId, //推荐度Id
ImageUrl = objvCourseLearningCase4App_TENS.ImageUrl, //ImageUrl
};
 return objvCourseLearningCase4App_TENT;
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
public static void CheckProperty4Condition(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN)
{
 clsvCourseLearningCase4App_TBL.vCourseLearningCase4App_TDA.CheckProperty4Condition(objvCourseLearningCase4App_TEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningCase4App_TCond.IsUpdated(convCourseLearningCase4App_T.IdCourseLearningCase) == true)
{
string strComparisonOpIdCourseLearningCase = objvCourseLearningCase4App_TCond.dicFldComparisonOp[convCourseLearningCase4App_T.IdCourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.IdCourseLearningCase, objvCourseLearningCase4App_TCond.IdCourseLearningCase, strComparisonOpIdCourseLearningCase);
}
if (objvCourseLearningCase4App_TCond.IsUpdated(convCourseLearningCase4App_T.CourseLearningCaseID) == true)
{
string strComparisonOpCourseLearningCaseID = objvCourseLearningCase4App_TCond.dicFldComparisonOp[convCourseLearningCase4App_T.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.CourseLearningCaseID, objvCourseLearningCase4App_TCond.CourseLearningCaseID, strComparisonOpCourseLearningCaseID);
}
if (objvCourseLearningCase4App_TCond.IsUpdated(convCourseLearningCase4App_T.CourseLearningCaseName) == true)
{
string strComparisonOpCourseLearningCaseName = objvCourseLearningCase4App_TCond.dicFldComparisonOp[convCourseLearningCase4App_T.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.CourseLearningCaseName, objvCourseLearningCase4App_TCond.CourseLearningCaseName, strComparisonOpCourseLearningCaseName);
}
if (objvCourseLearningCase4App_TCond.IsUpdated(convCourseLearningCase4App_T.CourseId) == true)
{
string strComparisonOpCourseId = objvCourseLearningCase4App_TCond.dicFldComparisonOp[convCourseLearningCase4App_T.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.CourseId, objvCourseLearningCase4App_TCond.CourseId, strComparisonOpCourseId);
}
if (objvCourseLearningCase4App_TCond.IsUpdated(convCourseLearningCase4App_T.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvCourseLearningCase4App_TCond.dicFldComparisonOp[convCourseLearningCase4App_T.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.CourseChapterId, objvCourseLearningCase4App_TCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvCourseLearningCase4App_TCond.IsUpdated(convCourseLearningCase4App_T.ChapterId) == true)
{
string strComparisonOpChapterId = objvCourseLearningCase4App_TCond.dicFldComparisonOp[convCourseLearningCase4App_T.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.ChapterId, objvCourseLearningCase4App_TCond.ChapterId, strComparisonOpChapterId);
}
if (objvCourseLearningCase4App_TCond.IsUpdated(convCourseLearningCase4App_T.ChapterName) == true)
{
string strComparisonOpChapterName = objvCourseLearningCase4App_TCond.dicFldComparisonOp[convCourseLearningCase4App_T.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.ChapterName, objvCourseLearningCase4App_TCond.ChapterName, strComparisonOpChapterName);
}
if (objvCourseLearningCase4App_TCond.IsUpdated(convCourseLearningCase4App_T.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvCourseLearningCase4App_TCond.dicFldComparisonOp[convCourseLearningCase4App_T.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.ChapterNameSim, objvCourseLearningCase4App_TCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvCourseLearningCase4App_TCond.IsUpdated(convCourseLearningCase4App_T.OrderNum4Chapter) == true)
{
string strComparisonOpOrderNum4Chapter = objvCourseLearningCase4App_TCond.dicFldComparisonOp[convCourseLearningCase4App_T.OrderNum4Chapter];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase4App_T.OrderNum4Chapter, objvCourseLearningCase4App_TCond.OrderNum4Chapter, strComparisonOpOrderNum4Chapter);
}
if (objvCourseLearningCase4App_TCond.IsUpdated(convCourseLearningCase4App_T.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvCourseLearningCase4App_TCond.dicFldComparisonOp[convCourseLearningCase4App_T.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.RecommendedDegreeId, objvCourseLearningCase4App_TCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvCourseLearningCase4App_TCond.IsUpdated(convCourseLearningCase4App_T.ImageUrl) == true)
{
string strComparisonOpImageUrl = objvCourseLearningCase4App_TCond.dicFldComparisonOp[convCourseLearningCase4App_T.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.ImageUrl, objvCourseLearningCase4App_TCond.ImageUrl, strComparisonOpImageUrl);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCourseLearningCase4App_T
{
public virtual bool UpdRelaTabDate(string strIdCourseLearningCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程学习案例4App_T(vCourseLearningCase4App_T)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningCase4App_TBL
{
public static RelatedActions_vCourseLearningCase4App_T relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCourseLearningCase4App_TDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCourseLearningCase4App_TDA vCourseLearningCase4App_TDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCourseLearningCase4App_TDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCourseLearningCase4App_TBL()
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
if (string.IsNullOrEmpty(clsvCourseLearningCase4App_TEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCourseLearningCase4App_TEN._ConnectString);
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
public static DataTable GetDataTable_vCourseLearningCase4App_T(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCourseLearningCase4App_TDA.GetDataTable_vCourseLearningCase4App_T(strWhereCond);
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
objDT = vCourseLearningCase4App_TDA.GetDataTable(strWhereCond);
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
objDT = vCourseLearningCase4App_TDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCourseLearningCase4App_TDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCourseLearningCase4App_TDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCourseLearningCase4App_TDA.GetDataTable_Top(objTopPara);
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
objDT = vCourseLearningCase4App_TDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCourseLearningCase4App_TDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCourseLearningCase4App_TDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvCourseLearningCase4App_TEN> GetObjLstByIdCourseLearningCaseLst(List<string> arrIdCourseLearningCaseLst)
{
List<clsvCourseLearningCase4App_TEN> arrObjLst = new List<clsvCourseLearningCase4App_TEN>(); 
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
	clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN = new clsvCourseLearningCase4App_TEN();
try
{
objvCourseLearningCase4App_TEN.IdCourseLearningCase = objRow[convCourseLearningCase4App_T.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4App_TEN.CourseLearningCaseID = objRow[convCourseLearningCase4App_T.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4App_TEN.CourseLearningCaseName = objRow[convCourseLearningCase4App_T.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4App_TEN.CourseId = objRow[convCourseLearningCase4App_T.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4App_TEN.CourseChapterId = objRow[convCourseLearningCase4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4App_TEN.ChapterId = objRow[convCourseLearningCase4App_T.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4App_TEN.ChapterName = objRow[convCourseLearningCase4App_T.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4App_TEN.ChapterNameSim = objRow[convCourseLearningCase4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4App_TEN.OrderNum4Chapter = objRow[convCourseLearningCase4App_T.OrderNum4Chapter] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App_T.OrderNum4Chapter].ToString().Trim()); //OrderNum4Chapter
objvCourseLearningCase4App_TEN.RecommendedDegreeId = objRow[convCourseLearningCase4App_T.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase4App_TEN.ImageUrl = objRow[convCourseLearningCase4App_T.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ImageUrl].ToString().Trim(); //ImageUrl
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4App_TEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4App_TEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCourseLearningCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCourseLearningCase4App_TEN> GetObjLstByIdCourseLearningCaseLstCache(List<string> arrIdCourseLearningCaseLst)
{
string strKey = string.Format("{0}", clsvCourseLearningCase4App_TEN._CurrTabName);
List<clsvCourseLearningCase4App_TEN> arrvCourseLearningCase4App_TObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCase4App_TEN> arrvCourseLearningCase4App_TObjLst_Sel =
arrvCourseLearningCase4App_TObjLstCache
.Where(x => arrIdCourseLearningCaseLst.Contains(x.IdCourseLearningCase));
return arrvCourseLearningCase4App_TObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase4App_TEN> GetObjLst(string strWhereCond)
{
List<clsvCourseLearningCase4App_TEN> arrObjLst = new List<clsvCourseLearningCase4App_TEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN = new clsvCourseLearningCase4App_TEN();
try
{
objvCourseLearningCase4App_TEN.IdCourseLearningCase = objRow[convCourseLearningCase4App_T.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4App_TEN.CourseLearningCaseID = objRow[convCourseLearningCase4App_T.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4App_TEN.CourseLearningCaseName = objRow[convCourseLearningCase4App_T.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4App_TEN.CourseId = objRow[convCourseLearningCase4App_T.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4App_TEN.CourseChapterId = objRow[convCourseLearningCase4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4App_TEN.ChapterId = objRow[convCourseLearningCase4App_T.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4App_TEN.ChapterName = objRow[convCourseLearningCase4App_T.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4App_TEN.ChapterNameSim = objRow[convCourseLearningCase4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4App_TEN.OrderNum4Chapter = objRow[convCourseLearningCase4App_T.OrderNum4Chapter] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App_T.OrderNum4Chapter].ToString().Trim()); //OrderNum4Chapter
objvCourseLearningCase4App_TEN.RecommendedDegreeId = objRow[convCourseLearningCase4App_T.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase4App_TEN.ImageUrl = objRow[convCourseLearningCase4App_T.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ImageUrl].ToString().Trim(); //ImageUrl
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4App_TEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4App_TEN);
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
public static List<clsvCourseLearningCase4App_TEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningCase4App_TEN> arrObjLst = new List<clsvCourseLearningCase4App_TEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN = new clsvCourseLearningCase4App_TEN();
try
{
objvCourseLearningCase4App_TEN.IdCourseLearningCase = objRow[convCourseLearningCase4App_T.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4App_TEN.CourseLearningCaseID = objRow[convCourseLearningCase4App_T.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4App_TEN.CourseLearningCaseName = objRow[convCourseLearningCase4App_T.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4App_TEN.CourseId = objRow[convCourseLearningCase4App_T.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4App_TEN.CourseChapterId = objRow[convCourseLearningCase4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4App_TEN.ChapterId = objRow[convCourseLearningCase4App_T.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4App_TEN.ChapterName = objRow[convCourseLearningCase4App_T.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4App_TEN.ChapterNameSim = objRow[convCourseLearningCase4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4App_TEN.OrderNum4Chapter = objRow[convCourseLearningCase4App_T.OrderNum4Chapter] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App_T.OrderNum4Chapter].ToString().Trim()); //OrderNum4Chapter
objvCourseLearningCase4App_TEN.RecommendedDegreeId = objRow[convCourseLearningCase4App_T.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase4App_TEN.ImageUrl = objRow[convCourseLearningCase4App_T.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ImageUrl].ToString().Trim(); //ImageUrl
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4App_TEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4App_TEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCourseLearningCase4App_TEN> GetSubObjLstCache(clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TCond)
{
List<clsvCourseLearningCase4App_TEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCase4App_TEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningCase4App_T.AttributeName)
{
if (objvCourseLearningCase4App_TCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningCase4App_TCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCase4App_TCond[strFldName].ToString());
}
else
{
if (objvCourseLearningCase4App_TCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningCase4App_TCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCase4App_TCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningCase4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningCase4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningCase4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningCase4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningCase4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningCase4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningCase4App_TCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCase4App_TCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCase4App_TCond[strFldName]));
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
public static List<clsvCourseLearningCase4App_TEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCourseLearningCase4App_TEN> arrObjLst = new List<clsvCourseLearningCase4App_TEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN = new clsvCourseLearningCase4App_TEN();
try
{
objvCourseLearningCase4App_TEN.IdCourseLearningCase = objRow[convCourseLearningCase4App_T.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4App_TEN.CourseLearningCaseID = objRow[convCourseLearningCase4App_T.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4App_TEN.CourseLearningCaseName = objRow[convCourseLearningCase4App_T.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4App_TEN.CourseId = objRow[convCourseLearningCase4App_T.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4App_TEN.CourseChapterId = objRow[convCourseLearningCase4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4App_TEN.ChapterId = objRow[convCourseLearningCase4App_T.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4App_TEN.ChapterName = objRow[convCourseLearningCase4App_T.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4App_TEN.ChapterNameSim = objRow[convCourseLearningCase4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4App_TEN.OrderNum4Chapter = objRow[convCourseLearningCase4App_T.OrderNum4Chapter] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App_T.OrderNum4Chapter].ToString().Trim()); //OrderNum4Chapter
objvCourseLearningCase4App_TEN.RecommendedDegreeId = objRow[convCourseLearningCase4App_T.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase4App_TEN.ImageUrl = objRow[convCourseLearningCase4App_T.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ImageUrl].ToString().Trim(); //ImageUrl
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4App_TEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4App_TEN);
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
public static List<clsvCourseLearningCase4App_TEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCourseLearningCase4App_TEN> arrObjLst = new List<clsvCourseLearningCase4App_TEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN = new clsvCourseLearningCase4App_TEN();
try
{
objvCourseLearningCase4App_TEN.IdCourseLearningCase = objRow[convCourseLearningCase4App_T.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4App_TEN.CourseLearningCaseID = objRow[convCourseLearningCase4App_T.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4App_TEN.CourseLearningCaseName = objRow[convCourseLearningCase4App_T.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4App_TEN.CourseId = objRow[convCourseLearningCase4App_T.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4App_TEN.CourseChapterId = objRow[convCourseLearningCase4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4App_TEN.ChapterId = objRow[convCourseLearningCase4App_T.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4App_TEN.ChapterName = objRow[convCourseLearningCase4App_T.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4App_TEN.ChapterNameSim = objRow[convCourseLearningCase4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4App_TEN.OrderNum4Chapter = objRow[convCourseLearningCase4App_T.OrderNum4Chapter] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App_T.OrderNum4Chapter].ToString().Trim()); //OrderNum4Chapter
objvCourseLearningCase4App_TEN.RecommendedDegreeId = objRow[convCourseLearningCase4App_T.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase4App_TEN.ImageUrl = objRow[convCourseLearningCase4App_T.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ImageUrl].ToString().Trim(); //ImageUrl
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4App_TEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4App_TEN);
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
List<clsvCourseLearningCase4App_TEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCourseLearningCase4App_TEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase4App_TEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCourseLearningCase4App_TEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningCase4App_TEN> arrObjLst = new List<clsvCourseLearningCase4App_TEN>(); 
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
	clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN = new clsvCourseLearningCase4App_TEN();
try
{
objvCourseLearningCase4App_TEN.IdCourseLearningCase = objRow[convCourseLearningCase4App_T.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4App_TEN.CourseLearningCaseID = objRow[convCourseLearningCase4App_T.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4App_TEN.CourseLearningCaseName = objRow[convCourseLearningCase4App_T.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4App_TEN.CourseId = objRow[convCourseLearningCase4App_T.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4App_TEN.CourseChapterId = objRow[convCourseLearningCase4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4App_TEN.ChapterId = objRow[convCourseLearningCase4App_T.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4App_TEN.ChapterName = objRow[convCourseLearningCase4App_T.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4App_TEN.ChapterNameSim = objRow[convCourseLearningCase4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4App_TEN.OrderNum4Chapter = objRow[convCourseLearningCase4App_T.OrderNum4Chapter] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App_T.OrderNum4Chapter].ToString().Trim()); //OrderNum4Chapter
objvCourseLearningCase4App_TEN.RecommendedDegreeId = objRow[convCourseLearningCase4App_T.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase4App_TEN.ImageUrl = objRow[convCourseLearningCase4App_T.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ImageUrl].ToString().Trim(); //ImageUrl
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4App_TEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4App_TEN);
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
public static List<clsvCourseLearningCase4App_TEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningCase4App_TEN> arrObjLst = new List<clsvCourseLearningCase4App_TEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN = new clsvCourseLearningCase4App_TEN();
try
{
objvCourseLearningCase4App_TEN.IdCourseLearningCase = objRow[convCourseLearningCase4App_T.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4App_TEN.CourseLearningCaseID = objRow[convCourseLearningCase4App_T.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4App_TEN.CourseLearningCaseName = objRow[convCourseLearningCase4App_T.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4App_TEN.CourseId = objRow[convCourseLearningCase4App_T.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4App_TEN.CourseChapterId = objRow[convCourseLearningCase4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4App_TEN.ChapterId = objRow[convCourseLearningCase4App_T.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4App_TEN.ChapterName = objRow[convCourseLearningCase4App_T.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4App_TEN.ChapterNameSim = objRow[convCourseLearningCase4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4App_TEN.OrderNum4Chapter = objRow[convCourseLearningCase4App_T.OrderNum4Chapter] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App_T.OrderNum4Chapter].ToString().Trim()); //OrderNum4Chapter
objvCourseLearningCase4App_TEN.RecommendedDegreeId = objRow[convCourseLearningCase4App_T.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase4App_TEN.ImageUrl = objRow[convCourseLearningCase4App_T.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ImageUrl].ToString().Trim(); //ImageUrl
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4App_TEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4App_TEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCourseLearningCase4App_TEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCourseLearningCase4App_TEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningCase4App_TEN> arrObjLst = new List<clsvCourseLearningCase4App_TEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN = new clsvCourseLearningCase4App_TEN();
try
{
objvCourseLearningCase4App_TEN.IdCourseLearningCase = objRow[convCourseLearningCase4App_T.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4App_TEN.CourseLearningCaseID = objRow[convCourseLearningCase4App_T.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4App_TEN.CourseLearningCaseName = objRow[convCourseLearningCase4App_T.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4App_TEN.CourseId = objRow[convCourseLearningCase4App_T.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4App_TEN.CourseChapterId = objRow[convCourseLearningCase4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4App_TEN.ChapterId = objRow[convCourseLearningCase4App_T.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4App_TEN.ChapterName = objRow[convCourseLearningCase4App_T.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4App_TEN.ChapterNameSim = objRow[convCourseLearningCase4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4App_TEN.OrderNum4Chapter = objRow[convCourseLearningCase4App_T.OrderNum4Chapter] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App_T.OrderNum4Chapter].ToString().Trim()); //OrderNum4Chapter
objvCourseLearningCase4App_TEN.RecommendedDegreeId = objRow[convCourseLearningCase4App_T.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase4App_TEN.ImageUrl = objRow[convCourseLearningCase4App_T.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ImageUrl].ToString().Trim(); //ImageUrl
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4App_TEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4App_TEN);
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
public static List<clsvCourseLearningCase4App_TEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCourseLearningCase4App_TEN> arrObjLst = new List<clsvCourseLearningCase4App_TEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN = new clsvCourseLearningCase4App_TEN();
try
{
objvCourseLearningCase4App_TEN.IdCourseLearningCase = objRow[convCourseLearningCase4App_T.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4App_TEN.CourseLearningCaseID = objRow[convCourseLearningCase4App_T.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4App_TEN.CourseLearningCaseName = objRow[convCourseLearningCase4App_T.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4App_TEN.CourseId = objRow[convCourseLearningCase4App_T.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4App_TEN.CourseChapterId = objRow[convCourseLearningCase4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4App_TEN.ChapterId = objRow[convCourseLearningCase4App_T.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4App_TEN.ChapterName = objRow[convCourseLearningCase4App_T.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4App_TEN.ChapterNameSim = objRow[convCourseLearningCase4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4App_TEN.OrderNum4Chapter = objRow[convCourseLearningCase4App_T.OrderNum4Chapter] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App_T.OrderNum4Chapter].ToString().Trim()); //OrderNum4Chapter
objvCourseLearningCase4App_TEN.RecommendedDegreeId = objRow[convCourseLearningCase4App_T.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase4App_TEN.ImageUrl = objRow[convCourseLearningCase4App_T.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ImageUrl].ToString().Trim(); //ImageUrl
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4App_TEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4App_TEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase4App_TEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCourseLearningCase4App_TEN> arrObjLst = new List<clsvCourseLearningCase4App_TEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN = new clsvCourseLearningCase4App_TEN();
try
{
objvCourseLearningCase4App_TEN.IdCourseLearningCase = objRow[convCourseLearningCase4App_T.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCase4App_TEN.CourseLearningCaseID = objRow[convCourseLearningCase4App_T.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCase4App_TEN.CourseLearningCaseName = objRow[convCourseLearningCase4App_T.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCase4App_TEN.CourseId = objRow[convCourseLearningCase4App_T.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCase4App_TEN.CourseChapterId = objRow[convCourseLearningCase4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCase4App_TEN.ChapterId = objRow[convCourseLearningCase4App_T.ChapterId] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterId].ToString().Trim(); //章Id
objvCourseLearningCase4App_TEN.ChapterName = objRow[convCourseLearningCase4App_T.ChapterName] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterName].ToString().Trim(); //章名
objvCourseLearningCase4App_TEN.ChapterNameSim = objRow[convCourseLearningCase4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvCourseLearningCase4App_TEN.OrderNum4Chapter = objRow[convCourseLearningCase4App_T.OrderNum4Chapter] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCase4App_T.OrderNum4Chapter].ToString().Trim()); //OrderNum4Chapter
objvCourseLearningCase4App_TEN.RecommendedDegreeId = objRow[convCourseLearningCase4App_T.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCase4App_TEN.ImageUrl = objRow[convCourseLearningCase4App_T.ImageUrl] == DBNull.Value ? null : objRow[convCourseLearningCase4App_T.ImageUrl].ToString().Trim(); //ImageUrl
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningCase4App_TEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningCase4App_TEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCourseLearningCase4App_T(ref clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN)
{
bool bolResult = vCourseLearningCase4App_TDA.GetvCourseLearningCase4App_T(ref objvCourseLearningCase4App_TEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCase4App_TEN GetObjByIdCourseLearningCase(string strIdCourseLearningCase)
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
clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN = vCourseLearningCase4App_TDA.GetObjByIdCourseLearningCase(strIdCourseLearningCase);
return objvCourseLearningCase4App_TEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCourseLearningCase4App_TEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN = vCourseLearningCase4App_TDA.GetFirstObj(strWhereCond);
 return objvCourseLearningCase4App_TEN;
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
public static clsvCourseLearningCase4App_TEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN = vCourseLearningCase4App_TDA.GetObjByDataRow(objRow);
 return objvCourseLearningCase4App_TEN;
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
public static clsvCourseLearningCase4App_TEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN = vCourseLearningCase4App_TDA.GetObjByDataRow(objRow);
 return objvCourseLearningCase4App_TEN;
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
 /// <param name = "lstvCourseLearningCase4App_TObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCase4App_TEN GetObjByIdCourseLearningCaseFromList(string strIdCourseLearningCase, List<clsvCourseLearningCase4App_TEN> lstvCourseLearningCase4App_TObjLst)
{
foreach (clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN in lstvCourseLearningCase4App_TObjLst)
{
if (objvCourseLearningCase4App_TEN.IdCourseLearningCase == strIdCourseLearningCase)
{
return objvCourseLearningCase4App_TEN;
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
 strIdCourseLearningCase = new clsvCourseLearningCase4App_TDA().GetFirstID(strWhereCond);
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
 arrList = vCourseLearningCase4App_TDA.GetID(strWhereCond);
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
bool bolIsExist = vCourseLearningCase4App_TDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vCourseLearningCase4App_TDA.IsExist(strIdCourseLearningCase);
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
 bolIsExist = clsvCourseLearningCase4App_TDA.IsExistTable();
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
 bolIsExist = vCourseLearningCase4App_TDA.IsExistTable(strTabName);
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
 /// <param name = "objvCourseLearningCase4App_TENS">源对象</param>
 /// <param name = "objvCourseLearningCase4App_TENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TENS, clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TENT)
{
try
{
objvCourseLearningCase4App_TENT.IdCourseLearningCase = objvCourseLearningCase4App_TENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCase4App_TENT.CourseLearningCaseID = objvCourseLearningCase4App_TENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCase4App_TENT.CourseLearningCaseName = objvCourseLearningCase4App_TENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCase4App_TENT.CourseId = objvCourseLearningCase4App_TENS.CourseId; //课程Id
objvCourseLearningCase4App_TENT.CourseChapterId = objvCourseLearningCase4App_TENS.CourseChapterId; //课程章节ID
objvCourseLearningCase4App_TENT.ChapterId = objvCourseLearningCase4App_TENS.ChapterId; //章Id
objvCourseLearningCase4App_TENT.ChapterName = objvCourseLearningCase4App_TENS.ChapterName; //章名
objvCourseLearningCase4App_TENT.ChapterNameSim = objvCourseLearningCase4App_TENS.ChapterNameSim; //章名简称
objvCourseLearningCase4App_TENT.OrderNum4Chapter = objvCourseLearningCase4App_TENS.OrderNum4Chapter; //OrderNum4Chapter
objvCourseLearningCase4App_TENT.RecommendedDegreeId = objvCourseLearningCase4App_TENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCase4App_TENT.ImageUrl = objvCourseLearningCase4App_TENS.ImageUrl; //ImageUrl
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
 /// <param name = "objvCourseLearningCase4App_TEN">源简化对象</param>
 public static void SetUpdFlag(clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN)
{
try
{
objvCourseLearningCase4App_TEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCourseLearningCase4App_TEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCourseLearningCase4App_T.IdCourseLearningCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4App_TEN.IdCourseLearningCase = objvCourseLearningCase4App_TEN.IdCourseLearningCase; //课程学习案例流水号
}
if (arrFldSet.Contains(convCourseLearningCase4App_T.CourseLearningCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4App_TEN.CourseLearningCaseID = objvCourseLearningCase4App_TEN.CourseLearningCaseID; //课程学习案例ID
}
if (arrFldSet.Contains(convCourseLearningCase4App_T.CourseLearningCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4App_TEN.CourseLearningCaseName = objvCourseLearningCase4App_TEN.CourseLearningCaseName; //课程学习案例名称
}
if (arrFldSet.Contains(convCourseLearningCase4App_T.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4App_TEN.CourseId = objvCourseLearningCase4App_TEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convCourseLearningCase4App_T.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4App_TEN.CourseChapterId = objvCourseLearningCase4App_TEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convCourseLearningCase4App_T.ChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4App_TEN.ChapterId = objvCourseLearningCase4App_TEN.ChapterId == "[null]" ? null :  objvCourseLearningCase4App_TEN.ChapterId; //章Id
}
if (arrFldSet.Contains(convCourseLearningCase4App_T.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4App_TEN.ChapterName = objvCourseLearningCase4App_TEN.ChapterName == "[null]" ? null :  objvCourseLearningCase4App_TEN.ChapterName; //章名
}
if (arrFldSet.Contains(convCourseLearningCase4App_T.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4App_TEN.ChapterNameSim = objvCourseLearningCase4App_TEN.ChapterNameSim == "[null]" ? null :  objvCourseLearningCase4App_TEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convCourseLearningCase4App_T.OrderNum4Chapter, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4App_TEN.OrderNum4Chapter = objvCourseLearningCase4App_TEN.OrderNum4Chapter; //OrderNum4Chapter
}
if (arrFldSet.Contains(convCourseLearningCase4App_T.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4App_TEN.RecommendedDegreeId = objvCourseLearningCase4App_TEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convCourseLearningCase4App_T.ImageUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningCase4App_TEN.ImageUrl = objvCourseLearningCase4App_TEN.ImageUrl == "[null]" ? null :  objvCourseLearningCase4App_TEN.ImageUrl; //ImageUrl
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
 /// <param name = "objvCourseLearningCase4App_TEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN)
{
try
{
if (objvCourseLearningCase4App_TEN.ChapterId == "[null]") objvCourseLearningCase4App_TEN.ChapterId = null; //章Id
if (objvCourseLearningCase4App_TEN.ChapterName == "[null]") objvCourseLearningCase4App_TEN.ChapterName = null; //章名
if (objvCourseLearningCase4App_TEN.ChapterNameSim == "[null]") objvCourseLearningCase4App_TEN.ChapterNameSim = null; //章名简称
if (objvCourseLearningCase4App_TEN.ImageUrl == "[null]") objvCourseLearningCase4App_TEN.ImageUrl = null; //ImageUrl
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
public static void CheckProperty4Condition(clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN)
{
 vCourseLearningCase4App_TDA.CheckProperty4Condition(objvCourseLearningCase4App_TEN);
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
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCourseLearningCase");
//if (arrvCourseLearningCase4App_TObjLstCache == null)
//{
//arrvCourseLearningCase4App_TObjLstCache = vCourseLearningCase4App_TDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningCase4App_TEN GetObjByIdCourseLearningCaseCache(string strIdCourseLearningCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCourseLearningCase4App_TEN._CurrTabName);
List<clsvCourseLearningCase4App_TEN> arrvCourseLearningCase4App_TObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCase4App_TEN> arrvCourseLearningCase4App_TObjLst_Sel =
arrvCourseLearningCase4App_TObjLstCache
.Where(x=> x.IdCourseLearningCase == strIdCourseLearningCase 
);
if (arrvCourseLearningCase4App_TObjLst_Sel.Count() == 0)
{
   clsvCourseLearningCase4App_TEN obj = clsvCourseLearningCase4App_TBL.GetObjByIdCourseLearningCase(strIdCourseLearningCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCourseLearningCase4App_TObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningCase4App_TEN> GetAllvCourseLearningCase4App_TObjLstCache()
{
//获取缓存中的对象列表
List<clsvCourseLearningCase4App_TEN> arrvCourseLearningCase4App_TObjLstCache = GetObjLstCache(); 
return arrvCourseLearningCase4App_TObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningCase4App_TEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningCase4App_TEN._CurrTabName);
List<clsvCourseLearningCase4App_TEN> arrvCourseLearningCase4App_TObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningCase4App_TObjLstCache;
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
string strKey = string.Format("{0}", clsvCourseLearningCase4App_TEN._CurrTabName);
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
if (strInFldName != convCourseLearningCase4App_T.IdCourseLearningCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCourseLearningCase4App_T.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCourseLearningCase4App_T.AttributeName));
throw new Exception(strMsg);
}
var objvCourseLearningCase4App_T = clsvCourseLearningCase4App_TBL.GetObjByIdCourseLearningCaseCache(strIdCourseLearningCase);
if (objvCourseLearningCase4App_T == null) return "";
return objvCourseLearningCase4App_T[strOutFldName].ToString();
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
int intRecCount = clsvCourseLearningCase4App_TDA.GetRecCount(strTabName);
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
int intRecCount = clsvCourseLearningCase4App_TDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCourseLearningCase4App_TDA.GetRecCount();
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
int intRecCount = clsvCourseLearningCase4App_TDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TCond)
{
List<clsvCourseLearningCase4App_TEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningCase4App_TEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningCase4App_T.AttributeName)
{
if (objvCourseLearningCase4App_TCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningCase4App_TCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCase4App_TCond[strFldName].ToString());
}
else
{
if (objvCourseLearningCase4App_TCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningCase4App_TCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningCase4App_TCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningCase4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningCase4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningCase4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningCase4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningCase4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningCase4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningCase4App_TCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCase4App_TCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningCase4App_TCond[strFldName]));
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
 List<string> arrList = clsvCourseLearningCase4App_TDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningCase4App_TDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningCase4App_TDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}