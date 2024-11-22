
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCase4App_TWApi
 表名:vCourseLearningCase4App_T(01120272)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:15
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
public static class clsvCourseLearningCase4App_TWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetId_CourseLearningCase(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strId_CourseLearningCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CourseLearningCase, 8, convCourseLearningCase4App_T.Id_CourseLearningCase);
clsCheckSql.CheckFieldForeignKey(strId_CourseLearningCase, 8, convCourseLearningCase4App_T.Id_CourseLearningCase);
objvCourseLearningCase4App_TEN.Id_CourseLearningCase = strId_CourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4App_TEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App_T.Id_CourseLearningCase) == false)
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp.Add(convCourseLearningCase4App_T.Id_CourseLearningCase, strComparisonOp);
}
else
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp[convCourseLearningCase4App_T.Id_CourseLearningCase] = strComparisonOp;
}
}
return objvCourseLearningCase4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetCourseLearningCaseID(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseID, convCourseLearningCase4App_T.CourseLearningCaseID);
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, convCourseLearningCase4App_T.CourseLearningCaseID);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, convCourseLearningCase4App_T.CourseLearningCaseID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetCourseLearningCaseName(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseName, convCourseLearningCase4App_T.CourseLearningCaseName);
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningCase4App_T.CourseLearningCaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetCourseId(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convCourseLearningCase4App_T.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convCourseLearningCase4App_T.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCourseLearningCase4App_T.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetCourseChapterId(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convCourseLearningCase4App_T.CourseChapterId);
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCourseLearningCase4App_T.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCourseLearningCase4App_T.CourseChapterId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetChapterId(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convCourseLearningCase4App_T.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convCourseLearningCase4App_T.ChapterId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetChapterName(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convCourseLearningCase4App_T.ChapterName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetChapterName_Sim(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convCourseLearningCase4App_T.ChapterName_Sim);
objvCourseLearningCase4App_TEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCase4App_TEN.dicFldComparisonOp.ContainsKey(convCourseLearningCase4App_T.ChapterName_Sim) == false)
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp.Add(convCourseLearningCase4App_T.ChapterName_Sim, strComparisonOp);
}
else
{
objvCourseLearningCase4App_TEN.dicFldComparisonOp[convCourseLearningCase4App_T.ChapterName_Sim] = strComparisonOp;
}
}
return objvCourseLearningCase4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetOrderNum4Chapter(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, int intOrderNum4Chapter, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetRecommendedDegreeId(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convCourseLearningCase4App_T.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convCourseLearningCase4App_T.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convCourseLearningCase4App_T.RecommendedDegreeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCase4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCase4App_TEN SetImageUrl(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN, string strImageUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImageUrl, 50, convCourseLearningCase4App_T.ImageUrl);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_T_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningCase4App_T_Cond.IsUpdated(convCourseLearningCase4App_T.Id_CourseLearningCase) == true)
{
string strComparisonOp_Id_CourseLearningCase = objvCourseLearningCase4App_T_Cond.dicFldComparisonOp[convCourseLearningCase4App_T.Id_CourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.Id_CourseLearningCase, objvCourseLearningCase4App_T_Cond.Id_CourseLearningCase, strComparisonOp_Id_CourseLearningCase);
}
if (objvCourseLearningCase4App_T_Cond.IsUpdated(convCourseLearningCase4App_T.CourseLearningCaseID) == true)
{
string strComparisonOp_CourseLearningCaseID = objvCourseLearningCase4App_T_Cond.dicFldComparisonOp[convCourseLearningCase4App_T.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.CourseLearningCaseID, objvCourseLearningCase4App_T_Cond.CourseLearningCaseID, strComparisonOp_CourseLearningCaseID);
}
if (objvCourseLearningCase4App_T_Cond.IsUpdated(convCourseLearningCase4App_T.CourseLearningCaseName) == true)
{
string strComparisonOp_CourseLearningCaseName = objvCourseLearningCase4App_T_Cond.dicFldComparisonOp[convCourseLearningCase4App_T.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.CourseLearningCaseName, objvCourseLearningCase4App_T_Cond.CourseLearningCaseName, strComparisonOp_CourseLearningCaseName);
}
if (objvCourseLearningCase4App_T_Cond.IsUpdated(convCourseLearningCase4App_T.CourseId) == true)
{
string strComparisonOp_CourseId = objvCourseLearningCase4App_T_Cond.dicFldComparisonOp[convCourseLearningCase4App_T.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.CourseId, objvCourseLearningCase4App_T_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCourseLearningCase4App_T_Cond.IsUpdated(convCourseLearningCase4App_T.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvCourseLearningCase4App_T_Cond.dicFldComparisonOp[convCourseLearningCase4App_T.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.CourseChapterId, objvCourseLearningCase4App_T_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvCourseLearningCase4App_T_Cond.IsUpdated(convCourseLearningCase4App_T.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvCourseLearningCase4App_T_Cond.dicFldComparisonOp[convCourseLearningCase4App_T.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.ChapterId, objvCourseLearningCase4App_T_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvCourseLearningCase4App_T_Cond.IsUpdated(convCourseLearningCase4App_T.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvCourseLearningCase4App_T_Cond.dicFldComparisonOp[convCourseLearningCase4App_T.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.ChapterName, objvCourseLearningCase4App_T_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvCourseLearningCase4App_T_Cond.IsUpdated(convCourseLearningCase4App_T.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvCourseLearningCase4App_T_Cond.dicFldComparisonOp[convCourseLearningCase4App_T.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.ChapterName_Sim, objvCourseLearningCase4App_T_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvCourseLearningCase4App_T_Cond.IsUpdated(convCourseLearningCase4App_T.OrderNum4Chapter) == true)
{
string strComparisonOp_OrderNum4Chapter = objvCourseLearningCase4App_T_Cond.dicFldComparisonOp[convCourseLearningCase4App_T.OrderNum4Chapter];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCase4App_T.OrderNum4Chapter, objvCourseLearningCase4App_T_Cond.OrderNum4Chapter, strComparisonOp_OrderNum4Chapter);
}
if (objvCourseLearningCase4App_T_Cond.IsUpdated(convCourseLearningCase4App_T.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvCourseLearningCase4App_T_Cond.dicFldComparisonOp[convCourseLearningCase4App_T.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.RecommendedDegreeId, objvCourseLearningCase4App_T_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvCourseLearningCase4App_T_Cond.IsUpdated(convCourseLearningCase4App_T.ImageUrl) == true)
{
string strComparisonOp_ImageUrl = objvCourseLearningCase4App_T_Cond.dicFldComparisonOp[convCourseLearningCase4App_T.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCase4App_T.ImageUrl, objvCourseLearningCase4App_T_Cond.ImageUrl, strComparisonOp_ImageUrl);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程学习案例4App_T(vCourseLearningCase4App_T)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningCase4App_TWApi
{
private static readonly string mstrApiControllerName = "vCourseLearningCase4App_TApi";

 public clsvCourseLearningCase4App_TWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_CourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCase4App_TEN GetObjById_CourseLearningCase(string strId_CourseLearningCase)
{
string strAction = "GetObjById_CourseLearningCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN = null;
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
objvCourseLearningCase4App_TEN = JsonConvert.DeserializeObject<clsvCourseLearningCase4App_TEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCase4App_TEN;
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
public static clsvCourseLearningCase4App_TEN GetObjById_CourseLearningCase_WA_Cache(string strId_CourseLearningCase)
{
string strAction = "GetObjById_CourseLearningCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN = null;
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
objvCourseLearningCase4App_TEN = JsonConvert.DeserializeObject<clsvCourseLearningCase4App_TEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCase4App_TEN;
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
public static clsvCourseLearningCase4App_TEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TEN = null;
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
objvCourseLearningCase4App_TEN = JsonConvert.DeserializeObject<clsvCourseLearningCase4App_TEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCase4App_TEN;
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
public static clsvCourseLearningCase4App_TEN GetObjById_CourseLearningCase_Cache(string strId_CourseLearningCase)
{
if (string.IsNullOrEmpty(strId_CourseLearningCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCase4App_TEN._CurrTabName_S);
List<clsvCourseLearningCase4App_TEN> arrvCourseLearningCase4App_TObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCase4App_TEN> arrvCourseLearningCase4App_TObjLst_Sel =
from objvCourseLearningCase4App_TEN in arrvCourseLearningCase4App_TObjLst_Cache
where objvCourseLearningCase4App_TEN.Id_CourseLearningCase == strId_CourseLearningCase
select objvCourseLearningCase4App_TEN;
if (arrvCourseLearningCase4App_TObjLst_Sel.Count() == 0)
{
   clsvCourseLearningCase4App_TEN obj = clsvCourseLearningCase4App_TWApi.GetObjById_CourseLearningCase(strId_CourseLearningCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCourseLearningCase4App_TObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase4App_TEN> GetObjLst(string strWhereCond)
{
 List<clsvCourseLearningCase4App_TEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase4App_TEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase4App_TEN> GetObjLstById_CourseLearningCaseLst(List<string> arrId_CourseLearningCase)
{
 List<clsvCourseLearningCase4App_TEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase4App_TEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvCourseLearningCase4App_TEN> GetObjLstById_CourseLearningCaseLst_Cache(List<string> arrId_CourseLearningCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCase4App_TEN._CurrTabName_S);
List<clsvCourseLearningCase4App_TEN> arrvCourseLearningCase4App_TObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCase4App_TEN> arrvCourseLearningCase4App_TObjLst_Sel =
from objvCourseLearningCase4App_TEN in arrvCourseLearningCase4App_TObjLst_Cache
where arrId_CourseLearningCase.Contains(objvCourseLearningCase4App_TEN.Id_CourseLearningCase)
select objvCourseLearningCase4App_TEN;
return arrvCourseLearningCase4App_TObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCase4App_TEN> GetObjLstById_CourseLearningCaseLst_WA_Cache(List<string> arrId_CourseLearningCase)
{
 List<clsvCourseLearningCase4App_TEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase4App_TEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase4App_TEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCourseLearningCase4App_TEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase4App_TEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase4App_TEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCourseLearningCase4App_TEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase4App_TEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase4App_TEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningCase4App_TEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase4App_TEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCase4App_TEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningCase4App_TEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCase4App_TEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvCourseLearningCase4App_TENS">源对象</param>
 /// <param name = "objvCourseLearningCase4App_TENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TENS, clsvCourseLearningCase4App_TEN objvCourseLearningCase4App_TENT)
{
try
{
objvCourseLearningCase4App_TENT.Id_CourseLearningCase = objvCourseLearningCase4App_TENS.Id_CourseLearningCase; //课程学习案例流水号
objvCourseLearningCase4App_TENT.CourseLearningCaseID = objvCourseLearningCase4App_TENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCase4App_TENT.CourseLearningCaseName = objvCourseLearningCase4App_TENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCase4App_TENT.CourseId = objvCourseLearningCase4App_TENS.CourseId; //课程Id
objvCourseLearningCase4App_TENT.CourseChapterId = objvCourseLearningCase4App_TENS.CourseChapterId; //课程章节ID
objvCourseLearningCase4App_TENT.ChapterId = objvCourseLearningCase4App_TENS.ChapterId; //章Id
objvCourseLearningCase4App_TENT.ChapterName = objvCourseLearningCase4App_TENS.ChapterName; //章名
objvCourseLearningCase4App_TENT.ChapterName_Sim = objvCourseLearningCase4App_TENS.ChapterName_Sim; //章名简称
objvCourseLearningCase4App_TENT.OrderNum4Chapter = objvCourseLearningCase4App_TENS.OrderNum4Chapter; //OrderNum4Chapter
objvCourseLearningCase4App_TENT.RecommendedDegreeId = objvCourseLearningCase4App_TENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCase4App_TENT.ImageUrl = objvCourseLearningCase4App_TENS.ImageUrl; //ImageUrl
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
public static DataTable ToDataTable(List<clsvCourseLearningCase4App_TEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCourseLearningCase4App_TEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCourseLearningCase4App_TEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCourseLearningCase4App_TEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCourseLearningCase4App_TEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCourseLearningCase4App_TEN.AttributeName)
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
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_CourseLearningCase");
//if (arrvCourseLearningCase4App_TObjLst_Cache == null)
//{
//arrvCourseLearningCase4App_TObjLst_Cache = await clsvCourseLearningCase4App_TWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCourseLearningCase4App_TEN._CurrTabName_S);
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
public static List<clsvCourseLearningCase4App_TEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningCase4App_TEN._CurrTabName_S);
List<clsvCourseLearningCase4App_TEN> arrvCourseLearningCase4App_TObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningCase4App_TObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCourseLearningCase4App_TEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCourseLearningCase4App_T.Id_CourseLearningCase, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App_T.CourseLearningCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App_T.CourseLearningCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App_T.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App_T.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App_T.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App_T.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App_T.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App_T.OrderNum4Chapter, Type.GetType("System.Int32"));
objDT.Columns.Add(convCourseLearningCase4App_T.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCase4App_T.ImageUrl, Type.GetType("System.String"));
foreach (clsvCourseLearningCase4App_TEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCourseLearningCase4App_T.Id_CourseLearningCase] = objInFor[convCourseLearningCase4App_T.Id_CourseLearningCase];
objDR[convCourseLearningCase4App_T.CourseLearningCaseID] = objInFor[convCourseLearningCase4App_T.CourseLearningCaseID];
objDR[convCourseLearningCase4App_T.CourseLearningCaseName] = objInFor[convCourseLearningCase4App_T.CourseLearningCaseName];
objDR[convCourseLearningCase4App_T.CourseId] = objInFor[convCourseLearningCase4App_T.CourseId];
objDR[convCourseLearningCase4App_T.CourseChapterId] = objInFor[convCourseLearningCase4App_T.CourseChapterId];
objDR[convCourseLearningCase4App_T.ChapterId] = objInFor[convCourseLearningCase4App_T.ChapterId];
objDR[convCourseLearningCase4App_T.ChapterName] = objInFor[convCourseLearningCase4App_T.ChapterName];
objDR[convCourseLearningCase4App_T.ChapterName_Sim] = objInFor[convCourseLearningCase4App_T.ChapterName_Sim];
objDR[convCourseLearningCase4App_T.OrderNum4Chapter] = objInFor[convCourseLearningCase4App_T.OrderNum4Chapter];
objDR[convCourseLearningCase4App_T.RecommendedDegreeId] = objInFor[convCourseLearningCase4App_T.RecommendedDegreeId];
objDR[convCourseLearningCase4App_T.ImageUrl] = objInFor[convCourseLearningCase4App_T.ImageUrl];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}