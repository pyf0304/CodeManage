
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvKnowledgeLearnTotalBL
 表名:vKnowledgeLearnTotal(01120156)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:49:30
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
public static class  clsvKnowledgeLearnTotalBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvKnowledgeLearnTotalEN GetObj(this K_mId_vKnowledgeLearnTotal myKey)
{
clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = clsvKnowledgeLearnTotalBL.vKnowledgeLearnTotalDA.GetObjBymId(myKey.Value);
return objvKnowledgeLearnTotalEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetmId(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, long lngmId, string strComparisonOp="")
	{
objvKnowledgeLearnTotalEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnTotal.mId) == false)
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp.Add(convKnowledgeLearnTotal.mId, strComparisonOp);
}
else
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp[convKnowledgeLearnTotal.mId] = strComparisonOp;
}
}
return objvKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetUserId(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convKnowledgeLearnTotal.UserId);
}
objvKnowledgeLearnTotalEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnTotal.UserId) == false)
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp.Add(convKnowledgeLearnTotal.UserId, strComparisonOp);
}
else
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp[convKnowledgeLearnTotal.UserId] = strComparisonOp;
}
}
return objvKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetUserName(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convKnowledgeLearnTotal.UserName);
}
objvKnowledgeLearnTotalEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnTotal.UserName) == false)
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp.Add(convKnowledgeLearnTotal.UserName, strComparisonOp);
}
else
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp[convKnowledgeLearnTotal.UserName] = strComparisonOp;
}
}
return objvKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetCourseKnowledgeId(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, convKnowledgeLearnTotal.CourseKnowledgeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, convKnowledgeLearnTotal.CourseKnowledgeId);
}
objvKnowledgeLearnTotalEN.CourseKnowledgeId = strCourseKnowledgeId; //知识点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnTotal.CourseKnowledgeId) == false)
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp.Add(convKnowledgeLearnTotal.CourseKnowledgeId, strComparisonOp);
}
else
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp[convKnowledgeLearnTotal.CourseKnowledgeId] = strComparisonOp;
}
}
return objvKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetKnowledgeName(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strKnowledgeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKnowledgeName, convKnowledgeLearnTotal.KnowledgeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeName, 100, convKnowledgeLearnTotal.KnowledgeName);
}
objvKnowledgeLearnTotalEN.KnowledgeName = strKnowledgeName; //知识点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnTotal.KnowledgeName) == false)
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp.Add(convKnowledgeLearnTotal.KnowledgeName, strComparisonOp);
}
else
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp[convKnowledgeLearnTotal.KnowledgeName] = strComparisonOp;
}
}
return objvKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetCourseId(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convKnowledgeLearnTotal.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convKnowledgeLearnTotal.CourseId);
}
objvKnowledgeLearnTotalEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnTotal.CourseId) == false)
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp.Add(convKnowledgeLearnTotal.CourseId, strComparisonOp);
}
else
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp[convKnowledgeLearnTotal.CourseId] = strComparisonOp;
}
}
return objvKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetCourseName(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convKnowledgeLearnTotal.CourseName);
}
objvKnowledgeLearnTotalEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnTotal.CourseName) == false)
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp.Add(convKnowledgeLearnTotal.CourseName, strComparisonOp);
}
else
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp[convKnowledgeLearnTotal.CourseName] = strComparisonOp;
}
}
return objvKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetCourseChapterId(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convKnowledgeLearnTotal.CourseChapterId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convKnowledgeLearnTotal.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convKnowledgeLearnTotal.CourseChapterId);
}
objvKnowledgeLearnTotalEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnTotal.CourseChapterId) == false)
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp.Add(convKnowledgeLearnTotal.CourseChapterId, strComparisonOp);
}
else
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp[convKnowledgeLearnTotal.CourseChapterId] = strComparisonOp;
}
}
return objvKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetMasterDegree(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, int intMasterDegree, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intMasterDegree, convKnowledgeLearnTotal.MasterDegree);
objvKnowledgeLearnTotalEN.MasterDegree = intMasterDegree; //掌握程度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnTotal.MasterDegree) == false)
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp.Add(convKnowledgeLearnTotal.MasterDegree, strComparisonOp);
}
else
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp[convKnowledgeLearnTotal.MasterDegree] = strComparisonOp;
}
}
return objvKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetLearnCount(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, int? intLearnCount, string strComparisonOp="")
	{
objvKnowledgeLearnTotalEN.LearnCount = intLearnCount; //学习次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnTotal.LearnCount) == false)
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp.Add(convKnowledgeLearnTotal.LearnCount, strComparisonOp);
}
else
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp[convKnowledgeLearnTotal.LearnCount] = strComparisonOp;
}
}
return objvKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetSuccessCount(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, int? intSuccessCount, string strComparisonOp="")
	{
objvKnowledgeLearnTotalEN.SuccessCount = intSuccessCount; //成功次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnTotal.SuccessCount) == false)
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp.Add(convKnowledgeLearnTotal.SuccessCount, strComparisonOp);
}
else
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp[convKnowledgeLearnTotal.SuccessCount] = strComparisonOp;
}
}
return objvKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetFailCount(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, int? intFailCount, string strComparisonOp="")
	{
objvKnowledgeLearnTotalEN.FailCount = intFailCount; //失败次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnTotal.FailCount) == false)
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp.Add(convKnowledgeLearnTotal.FailCount, strComparisonOp);
}
else
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp[convKnowledgeLearnTotal.FailCount] = strComparisonOp;
}
}
return objvKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetLastLearnDate(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strLastLearnDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastLearnDate, 14, convKnowledgeLearnTotal.LastLearnDate);
}
objvKnowledgeLearnTotalEN.LastLearnDate = strLastLearnDate; //最后学习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnTotal.LastLearnDate) == false)
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp.Add(convKnowledgeLearnTotal.LastLearnDate, strComparisonOp);
}
else
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp[convKnowledgeLearnTotal.LastLearnDate] = strComparisonOp;
}
}
return objvKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetRecommendedNextReviewDate(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strRecommendedNextReviewDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedNextReviewDate, 14, convKnowledgeLearnTotal.RecommendedNextReviewDate);
}
objvKnowledgeLearnTotalEN.RecommendedNextReviewDate = strRecommendedNextReviewDate; //推荐下次复习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnTotal.RecommendedNextReviewDate) == false)
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp.Add(convKnowledgeLearnTotal.RecommendedNextReviewDate, strComparisonOp);
}
else
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp[convKnowledgeLearnTotal.RecommendedNextReviewDate] = strComparisonOp;
}
}
return objvKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetUpdDate(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convKnowledgeLearnTotal.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convKnowledgeLearnTotal.UpdDate);
}
objvKnowledgeLearnTotalEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnTotal.UpdDate) == false)
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp.Add(convKnowledgeLearnTotal.UpdDate, strComparisonOp);
}
else
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp[convKnowledgeLearnTotal.UpdDate] = strComparisonOp;
}
}
return objvKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetUpdUser(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convKnowledgeLearnTotal.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convKnowledgeLearnTotal.UpdUser);
}
objvKnowledgeLearnTotalEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnTotal.UpdUser) == false)
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp.Add(convKnowledgeLearnTotal.UpdUser, strComparisonOp);
}
else
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp[convKnowledgeLearnTotal.UpdUser] = strComparisonOp;
}
}
return objvKnowledgeLearnTotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetMemo(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convKnowledgeLearnTotal.Memo);
}
objvKnowledgeLearnTotalEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnTotalEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnTotal.Memo) == false)
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp.Add(convKnowledgeLearnTotal.Memo, strComparisonOp);
}
else
{
objvKnowledgeLearnTotalEN.dicFldComparisonOp[convKnowledgeLearnTotal.Memo] = strComparisonOp;
}
}
return objvKnowledgeLearnTotalEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalENS">源对象</param>
 /// <param name = "objvKnowledgeLearnTotalENT">目标对象</param>
 public static void CopyTo(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalENS, clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalENT)
{
try
{
objvKnowledgeLearnTotalENT.mId = objvKnowledgeLearnTotalENS.mId; //mId
objvKnowledgeLearnTotalENT.UserId = objvKnowledgeLearnTotalENS.UserId; //用户ID
objvKnowledgeLearnTotalENT.UserName = objvKnowledgeLearnTotalENS.UserName; //用户名
objvKnowledgeLearnTotalENT.CourseKnowledgeId = objvKnowledgeLearnTotalENS.CourseKnowledgeId; //知识点Id
objvKnowledgeLearnTotalENT.KnowledgeName = objvKnowledgeLearnTotalENS.KnowledgeName; //知识点名称
objvKnowledgeLearnTotalENT.CourseId = objvKnowledgeLearnTotalENS.CourseId; //课程Id
objvKnowledgeLearnTotalENT.CourseName = objvKnowledgeLearnTotalENS.CourseName; //课程名称
objvKnowledgeLearnTotalENT.CourseChapterId = objvKnowledgeLearnTotalENS.CourseChapterId; //课程章节ID
objvKnowledgeLearnTotalENT.MasterDegree = objvKnowledgeLearnTotalENS.MasterDegree; //掌握程度
objvKnowledgeLearnTotalENT.LearnCount = objvKnowledgeLearnTotalENS.LearnCount; //学习次数
objvKnowledgeLearnTotalENT.SuccessCount = objvKnowledgeLearnTotalENS.SuccessCount; //成功次数
objvKnowledgeLearnTotalENT.FailCount = objvKnowledgeLearnTotalENS.FailCount; //失败次数
objvKnowledgeLearnTotalENT.LastLearnDate = objvKnowledgeLearnTotalENS.LastLearnDate; //最后学习日期
objvKnowledgeLearnTotalENT.RecommendedNextReviewDate = objvKnowledgeLearnTotalENS.RecommendedNextReviewDate; //推荐下次复习日期
objvKnowledgeLearnTotalENT.UpdDate = objvKnowledgeLearnTotalENS.UpdDate; //修改日期
objvKnowledgeLearnTotalENT.UpdUser = objvKnowledgeLearnTotalENS.UpdUser; //修改人
objvKnowledgeLearnTotalENT.Memo = objvKnowledgeLearnTotalENS.Memo; //备注
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
 /// <param name = "objvKnowledgeLearnTotalENS">源对象</param>
 /// <returns>目标对象=>clsvKnowledgeLearnTotalEN:objvKnowledgeLearnTotalENT</returns>
 public static clsvKnowledgeLearnTotalEN CopyTo(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalENS)
{
try
{
 clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalENT = new clsvKnowledgeLearnTotalEN()
{
mId = objvKnowledgeLearnTotalENS.mId, //mId
UserId = objvKnowledgeLearnTotalENS.UserId, //用户ID
UserName = objvKnowledgeLearnTotalENS.UserName, //用户名
CourseKnowledgeId = objvKnowledgeLearnTotalENS.CourseKnowledgeId, //知识点Id
KnowledgeName = objvKnowledgeLearnTotalENS.KnowledgeName, //知识点名称
CourseId = objvKnowledgeLearnTotalENS.CourseId, //课程Id
CourseName = objvKnowledgeLearnTotalENS.CourseName, //课程名称
CourseChapterId = objvKnowledgeLearnTotalENS.CourseChapterId, //课程章节ID
MasterDegree = objvKnowledgeLearnTotalENS.MasterDegree, //掌握程度
LearnCount = objvKnowledgeLearnTotalENS.LearnCount, //学习次数
SuccessCount = objvKnowledgeLearnTotalENS.SuccessCount, //成功次数
FailCount = objvKnowledgeLearnTotalENS.FailCount, //失败次数
LastLearnDate = objvKnowledgeLearnTotalENS.LastLearnDate, //最后学习日期
RecommendedNextReviewDate = objvKnowledgeLearnTotalENS.RecommendedNextReviewDate, //推荐下次复习日期
UpdDate = objvKnowledgeLearnTotalENS.UpdDate, //修改日期
UpdUser = objvKnowledgeLearnTotalENS.UpdUser, //修改人
Memo = objvKnowledgeLearnTotalENS.Memo, //备注
};
 return objvKnowledgeLearnTotalENT;
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
public static void CheckProperty4Condition(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN)
{
 clsvKnowledgeLearnTotalBL.vKnowledgeLearnTotalDA.CheckProperty4Condition(objvKnowledgeLearnTotalEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvKnowledgeLearnTotalCond.IsUpdated(convKnowledgeLearnTotal.mId) == true)
{
string strComparisonOpmId = objvKnowledgeLearnTotalCond.dicFldComparisonOp[convKnowledgeLearnTotal.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convKnowledgeLearnTotal.mId, objvKnowledgeLearnTotalCond.mId, strComparisonOpmId);
}
if (objvKnowledgeLearnTotalCond.IsUpdated(convKnowledgeLearnTotal.UserId) == true)
{
string strComparisonOpUserId = objvKnowledgeLearnTotalCond.dicFldComparisonOp[convKnowledgeLearnTotal.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.UserId, objvKnowledgeLearnTotalCond.UserId, strComparisonOpUserId);
}
if (objvKnowledgeLearnTotalCond.IsUpdated(convKnowledgeLearnTotal.UserName) == true)
{
string strComparisonOpUserName = objvKnowledgeLearnTotalCond.dicFldComparisonOp[convKnowledgeLearnTotal.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.UserName, objvKnowledgeLearnTotalCond.UserName, strComparisonOpUserName);
}
if (objvKnowledgeLearnTotalCond.IsUpdated(convKnowledgeLearnTotal.CourseKnowledgeId) == true)
{
string strComparisonOpCourseKnowledgeId = objvKnowledgeLearnTotalCond.dicFldComparisonOp[convKnowledgeLearnTotal.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.CourseKnowledgeId, objvKnowledgeLearnTotalCond.CourseKnowledgeId, strComparisonOpCourseKnowledgeId);
}
if (objvKnowledgeLearnTotalCond.IsUpdated(convKnowledgeLearnTotal.KnowledgeName) == true)
{
string strComparisonOpKnowledgeName = objvKnowledgeLearnTotalCond.dicFldComparisonOp[convKnowledgeLearnTotal.KnowledgeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.KnowledgeName, objvKnowledgeLearnTotalCond.KnowledgeName, strComparisonOpKnowledgeName);
}
if (objvKnowledgeLearnTotalCond.IsUpdated(convKnowledgeLearnTotal.CourseId) == true)
{
string strComparisonOpCourseId = objvKnowledgeLearnTotalCond.dicFldComparisonOp[convKnowledgeLearnTotal.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.CourseId, objvKnowledgeLearnTotalCond.CourseId, strComparisonOpCourseId);
}
if (objvKnowledgeLearnTotalCond.IsUpdated(convKnowledgeLearnTotal.CourseName) == true)
{
string strComparisonOpCourseName = objvKnowledgeLearnTotalCond.dicFldComparisonOp[convKnowledgeLearnTotal.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.CourseName, objvKnowledgeLearnTotalCond.CourseName, strComparisonOpCourseName);
}
if (objvKnowledgeLearnTotalCond.IsUpdated(convKnowledgeLearnTotal.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvKnowledgeLearnTotalCond.dicFldComparisonOp[convKnowledgeLearnTotal.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.CourseChapterId, objvKnowledgeLearnTotalCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvKnowledgeLearnTotalCond.IsUpdated(convKnowledgeLearnTotal.MasterDegree) == true)
{
string strComparisonOpMasterDegree = objvKnowledgeLearnTotalCond.dicFldComparisonOp[convKnowledgeLearnTotal.MasterDegree];
strWhereCond += string.Format(" And {0} {2} {1}", convKnowledgeLearnTotal.MasterDegree, objvKnowledgeLearnTotalCond.MasterDegree, strComparisonOpMasterDegree);
}
if (objvKnowledgeLearnTotalCond.IsUpdated(convKnowledgeLearnTotal.LearnCount) == true)
{
string strComparisonOpLearnCount = objvKnowledgeLearnTotalCond.dicFldComparisonOp[convKnowledgeLearnTotal.LearnCount];
strWhereCond += string.Format(" And {0} {2} {1}", convKnowledgeLearnTotal.LearnCount, objvKnowledgeLearnTotalCond.LearnCount, strComparisonOpLearnCount);
}
if (objvKnowledgeLearnTotalCond.IsUpdated(convKnowledgeLearnTotal.SuccessCount) == true)
{
string strComparisonOpSuccessCount = objvKnowledgeLearnTotalCond.dicFldComparisonOp[convKnowledgeLearnTotal.SuccessCount];
strWhereCond += string.Format(" And {0} {2} {1}", convKnowledgeLearnTotal.SuccessCount, objvKnowledgeLearnTotalCond.SuccessCount, strComparisonOpSuccessCount);
}
if (objvKnowledgeLearnTotalCond.IsUpdated(convKnowledgeLearnTotal.FailCount) == true)
{
string strComparisonOpFailCount = objvKnowledgeLearnTotalCond.dicFldComparisonOp[convKnowledgeLearnTotal.FailCount];
strWhereCond += string.Format(" And {0} {2} {1}", convKnowledgeLearnTotal.FailCount, objvKnowledgeLearnTotalCond.FailCount, strComparisonOpFailCount);
}
if (objvKnowledgeLearnTotalCond.IsUpdated(convKnowledgeLearnTotal.LastLearnDate) == true)
{
string strComparisonOpLastLearnDate = objvKnowledgeLearnTotalCond.dicFldComparisonOp[convKnowledgeLearnTotal.LastLearnDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.LastLearnDate, objvKnowledgeLearnTotalCond.LastLearnDate, strComparisonOpLastLearnDate);
}
if (objvKnowledgeLearnTotalCond.IsUpdated(convKnowledgeLearnTotal.RecommendedNextReviewDate) == true)
{
string strComparisonOpRecommendedNextReviewDate = objvKnowledgeLearnTotalCond.dicFldComparisonOp[convKnowledgeLearnTotal.RecommendedNextReviewDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.RecommendedNextReviewDate, objvKnowledgeLearnTotalCond.RecommendedNextReviewDate, strComparisonOpRecommendedNextReviewDate);
}
if (objvKnowledgeLearnTotalCond.IsUpdated(convKnowledgeLearnTotal.UpdDate) == true)
{
string strComparisonOpUpdDate = objvKnowledgeLearnTotalCond.dicFldComparisonOp[convKnowledgeLearnTotal.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.UpdDate, objvKnowledgeLearnTotalCond.UpdDate, strComparisonOpUpdDate);
}
if (objvKnowledgeLearnTotalCond.IsUpdated(convKnowledgeLearnTotal.UpdUser) == true)
{
string strComparisonOpUpdUser = objvKnowledgeLearnTotalCond.dicFldComparisonOp[convKnowledgeLearnTotal.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.UpdUser, objvKnowledgeLearnTotalCond.UpdUser, strComparisonOpUpdUser);
}
if (objvKnowledgeLearnTotalCond.IsUpdated(convKnowledgeLearnTotal.Memo) == true)
{
string strComparisonOpMemo = objvKnowledgeLearnTotalCond.dicFldComparisonOp[convKnowledgeLearnTotal.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.Memo, objvKnowledgeLearnTotalCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vKnowledgeLearnTotal
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v知识点学习汇总表(vKnowledgeLearnTotal)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvKnowledgeLearnTotalBL
{
public static RelatedActions_vKnowledgeLearnTotal relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvKnowledgeLearnTotalDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvKnowledgeLearnTotalDA vKnowledgeLearnTotalDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvKnowledgeLearnTotalDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvKnowledgeLearnTotalBL()
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
if (string.IsNullOrEmpty(clsvKnowledgeLearnTotalEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvKnowledgeLearnTotalEN._ConnectString);
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
public static DataTable GetDataTable_vKnowledgeLearnTotal(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vKnowledgeLearnTotalDA.GetDataTable_vKnowledgeLearnTotal(strWhereCond);
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
objDT = vKnowledgeLearnTotalDA.GetDataTable(strWhereCond);
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
objDT = vKnowledgeLearnTotalDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vKnowledgeLearnTotalDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vKnowledgeLearnTotalDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vKnowledgeLearnTotalDA.GetDataTable_Top(objTopPara);
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
objDT = vKnowledgeLearnTotalDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vKnowledgeLearnTotalDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vKnowledgeLearnTotalDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvKnowledgeLearnTotalEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvKnowledgeLearnTotalEN> arrObjLst = new List<clsvKnowledgeLearnTotalEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = new clsvKnowledgeLearnTotalEN();
try
{
objvKnowledgeLearnTotalEN.mId = Int32.Parse(objRow[convKnowledgeLearnTotal.mId].ToString().Trim()); //mId
objvKnowledgeLearnTotalEN.UserId = objRow[convKnowledgeLearnTotal.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnTotalEN.UserName = objRow[convKnowledgeLearnTotal.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnTotalEN.CourseKnowledgeId = objRow[convKnowledgeLearnTotal.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnTotalEN.KnowledgeName = objRow[convKnowledgeLearnTotal.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnTotalEN.CourseId = objRow[convKnowledgeLearnTotal.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnTotalEN.CourseName = objRow[convKnowledgeLearnTotal.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnTotalEN.CourseChapterId = objRow[convKnowledgeLearnTotal.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnTotalEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnTotal.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnTotalEN.LearnCount = objRow[convKnowledgeLearnTotal.LearnCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.LearnCount].ToString().Trim()); //学习次数
objvKnowledgeLearnTotalEN.SuccessCount = objRow[convKnowledgeLearnTotal.SuccessCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.SuccessCount].ToString().Trim()); //成功次数
objvKnowledgeLearnTotalEN.FailCount = objRow[convKnowledgeLearnTotal.FailCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.FailCount].ToString().Trim()); //失败次数
objvKnowledgeLearnTotalEN.LastLearnDate = objRow[convKnowledgeLearnTotal.LastLearnDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.LastLearnDate].ToString().Trim(); //最后学习日期
objvKnowledgeLearnTotalEN.RecommendedNextReviewDate = objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate].ToString().Trim(); //推荐下次复习日期
objvKnowledgeLearnTotalEN.UpdDate = objRow[convKnowledgeLearnTotal.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnTotalEN.UpdUser = objRow[convKnowledgeLearnTotal.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnTotalEN.Memo = objRow[convKnowledgeLearnTotal.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnTotalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnTotalEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvKnowledgeLearnTotalEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvKnowledgeLearnTotalEN._CurrTabName);
List<clsvKnowledgeLearnTotalEN> arrvKnowledgeLearnTotalObjLstCache = GetObjLstCache();
IEnumerable <clsvKnowledgeLearnTotalEN> arrvKnowledgeLearnTotalObjLst_Sel =
arrvKnowledgeLearnTotalObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvKnowledgeLearnTotalObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvKnowledgeLearnTotalEN> GetObjLst(string strWhereCond)
{
List<clsvKnowledgeLearnTotalEN> arrObjLst = new List<clsvKnowledgeLearnTotalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = new clsvKnowledgeLearnTotalEN();
try
{
objvKnowledgeLearnTotalEN.mId = Int32.Parse(objRow[convKnowledgeLearnTotal.mId].ToString().Trim()); //mId
objvKnowledgeLearnTotalEN.UserId = objRow[convKnowledgeLearnTotal.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnTotalEN.UserName = objRow[convKnowledgeLearnTotal.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnTotalEN.CourseKnowledgeId = objRow[convKnowledgeLearnTotal.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnTotalEN.KnowledgeName = objRow[convKnowledgeLearnTotal.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnTotalEN.CourseId = objRow[convKnowledgeLearnTotal.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnTotalEN.CourseName = objRow[convKnowledgeLearnTotal.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnTotalEN.CourseChapterId = objRow[convKnowledgeLearnTotal.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnTotalEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnTotal.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnTotalEN.LearnCount = objRow[convKnowledgeLearnTotal.LearnCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.LearnCount].ToString().Trim()); //学习次数
objvKnowledgeLearnTotalEN.SuccessCount = objRow[convKnowledgeLearnTotal.SuccessCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.SuccessCount].ToString().Trim()); //成功次数
objvKnowledgeLearnTotalEN.FailCount = objRow[convKnowledgeLearnTotal.FailCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.FailCount].ToString().Trim()); //失败次数
objvKnowledgeLearnTotalEN.LastLearnDate = objRow[convKnowledgeLearnTotal.LastLearnDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.LastLearnDate].ToString().Trim(); //最后学习日期
objvKnowledgeLearnTotalEN.RecommendedNextReviewDate = objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate].ToString().Trim(); //推荐下次复习日期
objvKnowledgeLearnTotalEN.UpdDate = objRow[convKnowledgeLearnTotal.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnTotalEN.UpdUser = objRow[convKnowledgeLearnTotal.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnTotalEN.Memo = objRow[convKnowledgeLearnTotal.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnTotalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnTotalEN);
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
public static List<clsvKnowledgeLearnTotalEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvKnowledgeLearnTotalEN> arrObjLst = new List<clsvKnowledgeLearnTotalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = new clsvKnowledgeLearnTotalEN();
try
{
objvKnowledgeLearnTotalEN.mId = Int32.Parse(objRow[convKnowledgeLearnTotal.mId].ToString().Trim()); //mId
objvKnowledgeLearnTotalEN.UserId = objRow[convKnowledgeLearnTotal.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnTotalEN.UserName = objRow[convKnowledgeLearnTotal.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnTotalEN.CourseKnowledgeId = objRow[convKnowledgeLearnTotal.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnTotalEN.KnowledgeName = objRow[convKnowledgeLearnTotal.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnTotalEN.CourseId = objRow[convKnowledgeLearnTotal.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnTotalEN.CourseName = objRow[convKnowledgeLearnTotal.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnTotalEN.CourseChapterId = objRow[convKnowledgeLearnTotal.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnTotalEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnTotal.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnTotalEN.LearnCount = objRow[convKnowledgeLearnTotal.LearnCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.LearnCount].ToString().Trim()); //学习次数
objvKnowledgeLearnTotalEN.SuccessCount = objRow[convKnowledgeLearnTotal.SuccessCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.SuccessCount].ToString().Trim()); //成功次数
objvKnowledgeLearnTotalEN.FailCount = objRow[convKnowledgeLearnTotal.FailCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.FailCount].ToString().Trim()); //失败次数
objvKnowledgeLearnTotalEN.LastLearnDate = objRow[convKnowledgeLearnTotal.LastLearnDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.LastLearnDate].ToString().Trim(); //最后学习日期
objvKnowledgeLearnTotalEN.RecommendedNextReviewDate = objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate].ToString().Trim(); //推荐下次复习日期
objvKnowledgeLearnTotalEN.UpdDate = objRow[convKnowledgeLearnTotal.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnTotalEN.UpdUser = objRow[convKnowledgeLearnTotal.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnTotalEN.Memo = objRow[convKnowledgeLearnTotal.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnTotalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnTotalEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvKnowledgeLearnTotalEN> GetSubObjLstCache(clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalCond)
{
List<clsvKnowledgeLearnTotalEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvKnowledgeLearnTotalEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convKnowledgeLearnTotal.AttributeName)
{
if (objvKnowledgeLearnTotalCond.IsUpdated(strFldName) == false) continue;
if (objvKnowledgeLearnTotalCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvKnowledgeLearnTotalCond[strFldName].ToString());
}
else
{
if (objvKnowledgeLearnTotalCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvKnowledgeLearnTotalCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvKnowledgeLearnTotalCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvKnowledgeLearnTotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvKnowledgeLearnTotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvKnowledgeLearnTotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvKnowledgeLearnTotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvKnowledgeLearnTotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvKnowledgeLearnTotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvKnowledgeLearnTotalCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvKnowledgeLearnTotalCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvKnowledgeLearnTotalCond[strFldName]));
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
public static List<clsvKnowledgeLearnTotalEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvKnowledgeLearnTotalEN> arrObjLst = new List<clsvKnowledgeLearnTotalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = new clsvKnowledgeLearnTotalEN();
try
{
objvKnowledgeLearnTotalEN.mId = Int32.Parse(objRow[convKnowledgeLearnTotal.mId].ToString().Trim()); //mId
objvKnowledgeLearnTotalEN.UserId = objRow[convKnowledgeLearnTotal.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnTotalEN.UserName = objRow[convKnowledgeLearnTotal.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnTotalEN.CourseKnowledgeId = objRow[convKnowledgeLearnTotal.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnTotalEN.KnowledgeName = objRow[convKnowledgeLearnTotal.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnTotalEN.CourseId = objRow[convKnowledgeLearnTotal.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnTotalEN.CourseName = objRow[convKnowledgeLearnTotal.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnTotalEN.CourseChapterId = objRow[convKnowledgeLearnTotal.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnTotalEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnTotal.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnTotalEN.LearnCount = objRow[convKnowledgeLearnTotal.LearnCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.LearnCount].ToString().Trim()); //学习次数
objvKnowledgeLearnTotalEN.SuccessCount = objRow[convKnowledgeLearnTotal.SuccessCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.SuccessCount].ToString().Trim()); //成功次数
objvKnowledgeLearnTotalEN.FailCount = objRow[convKnowledgeLearnTotal.FailCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.FailCount].ToString().Trim()); //失败次数
objvKnowledgeLearnTotalEN.LastLearnDate = objRow[convKnowledgeLearnTotal.LastLearnDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.LastLearnDate].ToString().Trim(); //最后学习日期
objvKnowledgeLearnTotalEN.RecommendedNextReviewDate = objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate].ToString().Trim(); //推荐下次复习日期
objvKnowledgeLearnTotalEN.UpdDate = objRow[convKnowledgeLearnTotal.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnTotalEN.UpdUser = objRow[convKnowledgeLearnTotal.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnTotalEN.Memo = objRow[convKnowledgeLearnTotal.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnTotalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnTotalEN);
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
public static List<clsvKnowledgeLearnTotalEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvKnowledgeLearnTotalEN> arrObjLst = new List<clsvKnowledgeLearnTotalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = new clsvKnowledgeLearnTotalEN();
try
{
objvKnowledgeLearnTotalEN.mId = Int32.Parse(objRow[convKnowledgeLearnTotal.mId].ToString().Trim()); //mId
objvKnowledgeLearnTotalEN.UserId = objRow[convKnowledgeLearnTotal.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnTotalEN.UserName = objRow[convKnowledgeLearnTotal.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnTotalEN.CourseKnowledgeId = objRow[convKnowledgeLearnTotal.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnTotalEN.KnowledgeName = objRow[convKnowledgeLearnTotal.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnTotalEN.CourseId = objRow[convKnowledgeLearnTotal.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnTotalEN.CourseName = objRow[convKnowledgeLearnTotal.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnTotalEN.CourseChapterId = objRow[convKnowledgeLearnTotal.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnTotalEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnTotal.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnTotalEN.LearnCount = objRow[convKnowledgeLearnTotal.LearnCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.LearnCount].ToString().Trim()); //学习次数
objvKnowledgeLearnTotalEN.SuccessCount = objRow[convKnowledgeLearnTotal.SuccessCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.SuccessCount].ToString().Trim()); //成功次数
objvKnowledgeLearnTotalEN.FailCount = objRow[convKnowledgeLearnTotal.FailCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.FailCount].ToString().Trim()); //失败次数
objvKnowledgeLearnTotalEN.LastLearnDate = objRow[convKnowledgeLearnTotal.LastLearnDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.LastLearnDate].ToString().Trim(); //最后学习日期
objvKnowledgeLearnTotalEN.RecommendedNextReviewDate = objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate].ToString().Trim(); //推荐下次复习日期
objvKnowledgeLearnTotalEN.UpdDate = objRow[convKnowledgeLearnTotal.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnTotalEN.UpdUser = objRow[convKnowledgeLearnTotal.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnTotalEN.Memo = objRow[convKnowledgeLearnTotal.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnTotalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnTotalEN);
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
List<clsvKnowledgeLearnTotalEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvKnowledgeLearnTotalEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvKnowledgeLearnTotalEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvKnowledgeLearnTotalEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvKnowledgeLearnTotalEN> arrObjLst = new List<clsvKnowledgeLearnTotalEN>(); 
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
	clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = new clsvKnowledgeLearnTotalEN();
try
{
objvKnowledgeLearnTotalEN.mId = Int32.Parse(objRow[convKnowledgeLearnTotal.mId].ToString().Trim()); //mId
objvKnowledgeLearnTotalEN.UserId = objRow[convKnowledgeLearnTotal.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnTotalEN.UserName = objRow[convKnowledgeLearnTotal.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnTotalEN.CourseKnowledgeId = objRow[convKnowledgeLearnTotal.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnTotalEN.KnowledgeName = objRow[convKnowledgeLearnTotal.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnTotalEN.CourseId = objRow[convKnowledgeLearnTotal.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnTotalEN.CourseName = objRow[convKnowledgeLearnTotal.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnTotalEN.CourseChapterId = objRow[convKnowledgeLearnTotal.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnTotalEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnTotal.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnTotalEN.LearnCount = objRow[convKnowledgeLearnTotal.LearnCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.LearnCount].ToString().Trim()); //学习次数
objvKnowledgeLearnTotalEN.SuccessCount = objRow[convKnowledgeLearnTotal.SuccessCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.SuccessCount].ToString().Trim()); //成功次数
objvKnowledgeLearnTotalEN.FailCount = objRow[convKnowledgeLearnTotal.FailCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.FailCount].ToString().Trim()); //失败次数
objvKnowledgeLearnTotalEN.LastLearnDate = objRow[convKnowledgeLearnTotal.LastLearnDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.LastLearnDate].ToString().Trim(); //最后学习日期
objvKnowledgeLearnTotalEN.RecommendedNextReviewDate = objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate].ToString().Trim(); //推荐下次复习日期
objvKnowledgeLearnTotalEN.UpdDate = objRow[convKnowledgeLearnTotal.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnTotalEN.UpdUser = objRow[convKnowledgeLearnTotal.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnTotalEN.Memo = objRow[convKnowledgeLearnTotal.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnTotalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnTotalEN);
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
public static List<clsvKnowledgeLearnTotalEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvKnowledgeLearnTotalEN> arrObjLst = new List<clsvKnowledgeLearnTotalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = new clsvKnowledgeLearnTotalEN();
try
{
objvKnowledgeLearnTotalEN.mId = Int32.Parse(objRow[convKnowledgeLearnTotal.mId].ToString().Trim()); //mId
objvKnowledgeLearnTotalEN.UserId = objRow[convKnowledgeLearnTotal.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnTotalEN.UserName = objRow[convKnowledgeLearnTotal.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnTotalEN.CourseKnowledgeId = objRow[convKnowledgeLearnTotal.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnTotalEN.KnowledgeName = objRow[convKnowledgeLearnTotal.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnTotalEN.CourseId = objRow[convKnowledgeLearnTotal.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnTotalEN.CourseName = objRow[convKnowledgeLearnTotal.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnTotalEN.CourseChapterId = objRow[convKnowledgeLearnTotal.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnTotalEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnTotal.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnTotalEN.LearnCount = objRow[convKnowledgeLearnTotal.LearnCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.LearnCount].ToString().Trim()); //学习次数
objvKnowledgeLearnTotalEN.SuccessCount = objRow[convKnowledgeLearnTotal.SuccessCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.SuccessCount].ToString().Trim()); //成功次数
objvKnowledgeLearnTotalEN.FailCount = objRow[convKnowledgeLearnTotal.FailCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.FailCount].ToString().Trim()); //失败次数
objvKnowledgeLearnTotalEN.LastLearnDate = objRow[convKnowledgeLearnTotal.LastLearnDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.LastLearnDate].ToString().Trim(); //最后学习日期
objvKnowledgeLearnTotalEN.RecommendedNextReviewDate = objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate].ToString().Trim(); //推荐下次复习日期
objvKnowledgeLearnTotalEN.UpdDate = objRow[convKnowledgeLearnTotal.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnTotalEN.UpdUser = objRow[convKnowledgeLearnTotal.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnTotalEN.Memo = objRow[convKnowledgeLearnTotal.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnTotalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnTotalEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvKnowledgeLearnTotalEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvKnowledgeLearnTotalEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvKnowledgeLearnTotalEN> arrObjLst = new List<clsvKnowledgeLearnTotalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = new clsvKnowledgeLearnTotalEN();
try
{
objvKnowledgeLearnTotalEN.mId = Int32.Parse(objRow[convKnowledgeLearnTotal.mId].ToString().Trim()); //mId
objvKnowledgeLearnTotalEN.UserId = objRow[convKnowledgeLearnTotal.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnTotalEN.UserName = objRow[convKnowledgeLearnTotal.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnTotalEN.CourseKnowledgeId = objRow[convKnowledgeLearnTotal.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnTotalEN.KnowledgeName = objRow[convKnowledgeLearnTotal.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnTotalEN.CourseId = objRow[convKnowledgeLearnTotal.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnTotalEN.CourseName = objRow[convKnowledgeLearnTotal.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnTotalEN.CourseChapterId = objRow[convKnowledgeLearnTotal.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnTotalEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnTotal.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnTotalEN.LearnCount = objRow[convKnowledgeLearnTotal.LearnCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.LearnCount].ToString().Trim()); //学习次数
objvKnowledgeLearnTotalEN.SuccessCount = objRow[convKnowledgeLearnTotal.SuccessCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.SuccessCount].ToString().Trim()); //成功次数
objvKnowledgeLearnTotalEN.FailCount = objRow[convKnowledgeLearnTotal.FailCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.FailCount].ToString().Trim()); //失败次数
objvKnowledgeLearnTotalEN.LastLearnDate = objRow[convKnowledgeLearnTotal.LastLearnDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.LastLearnDate].ToString().Trim(); //最后学习日期
objvKnowledgeLearnTotalEN.RecommendedNextReviewDate = objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate].ToString().Trim(); //推荐下次复习日期
objvKnowledgeLearnTotalEN.UpdDate = objRow[convKnowledgeLearnTotal.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnTotalEN.UpdUser = objRow[convKnowledgeLearnTotal.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnTotalEN.Memo = objRow[convKnowledgeLearnTotal.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnTotalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnTotalEN);
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
public static List<clsvKnowledgeLearnTotalEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvKnowledgeLearnTotalEN> arrObjLst = new List<clsvKnowledgeLearnTotalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = new clsvKnowledgeLearnTotalEN();
try
{
objvKnowledgeLearnTotalEN.mId = Int32.Parse(objRow[convKnowledgeLearnTotal.mId].ToString().Trim()); //mId
objvKnowledgeLearnTotalEN.UserId = objRow[convKnowledgeLearnTotal.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnTotalEN.UserName = objRow[convKnowledgeLearnTotal.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnTotalEN.CourseKnowledgeId = objRow[convKnowledgeLearnTotal.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnTotalEN.KnowledgeName = objRow[convKnowledgeLearnTotal.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnTotalEN.CourseId = objRow[convKnowledgeLearnTotal.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnTotalEN.CourseName = objRow[convKnowledgeLearnTotal.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnTotalEN.CourseChapterId = objRow[convKnowledgeLearnTotal.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnTotalEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnTotal.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnTotalEN.LearnCount = objRow[convKnowledgeLearnTotal.LearnCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.LearnCount].ToString().Trim()); //学习次数
objvKnowledgeLearnTotalEN.SuccessCount = objRow[convKnowledgeLearnTotal.SuccessCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.SuccessCount].ToString().Trim()); //成功次数
objvKnowledgeLearnTotalEN.FailCount = objRow[convKnowledgeLearnTotal.FailCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.FailCount].ToString().Trim()); //失败次数
objvKnowledgeLearnTotalEN.LastLearnDate = objRow[convKnowledgeLearnTotal.LastLearnDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.LastLearnDate].ToString().Trim(); //最后学习日期
objvKnowledgeLearnTotalEN.RecommendedNextReviewDate = objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate].ToString().Trim(); //推荐下次复习日期
objvKnowledgeLearnTotalEN.UpdDate = objRow[convKnowledgeLearnTotal.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnTotalEN.UpdUser = objRow[convKnowledgeLearnTotal.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnTotalEN.Memo = objRow[convKnowledgeLearnTotal.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnTotalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnTotalEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvKnowledgeLearnTotalEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvKnowledgeLearnTotalEN> arrObjLst = new List<clsvKnowledgeLearnTotalEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = new clsvKnowledgeLearnTotalEN();
try
{
objvKnowledgeLearnTotalEN.mId = Int32.Parse(objRow[convKnowledgeLearnTotal.mId].ToString().Trim()); //mId
objvKnowledgeLearnTotalEN.UserId = objRow[convKnowledgeLearnTotal.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnTotalEN.UserName = objRow[convKnowledgeLearnTotal.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnTotalEN.CourseKnowledgeId = objRow[convKnowledgeLearnTotal.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnTotalEN.KnowledgeName = objRow[convKnowledgeLearnTotal.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnTotalEN.CourseId = objRow[convKnowledgeLearnTotal.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnTotalEN.CourseName = objRow[convKnowledgeLearnTotal.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnTotalEN.CourseChapterId = objRow[convKnowledgeLearnTotal.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnTotalEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnTotal.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnTotalEN.LearnCount = objRow[convKnowledgeLearnTotal.LearnCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.LearnCount].ToString().Trim()); //学习次数
objvKnowledgeLearnTotalEN.SuccessCount = objRow[convKnowledgeLearnTotal.SuccessCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.SuccessCount].ToString().Trim()); //成功次数
objvKnowledgeLearnTotalEN.FailCount = objRow[convKnowledgeLearnTotal.FailCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convKnowledgeLearnTotal.FailCount].ToString().Trim()); //失败次数
objvKnowledgeLearnTotalEN.LastLearnDate = objRow[convKnowledgeLearnTotal.LastLearnDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.LastLearnDate].ToString().Trim(); //最后学习日期
objvKnowledgeLearnTotalEN.RecommendedNextReviewDate = objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.RecommendedNextReviewDate].ToString().Trim(); //推荐下次复习日期
objvKnowledgeLearnTotalEN.UpdDate = objRow[convKnowledgeLearnTotal.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnTotalEN.UpdUser = objRow[convKnowledgeLearnTotal.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnTotalEN.Memo = objRow[convKnowledgeLearnTotal.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnTotal.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnTotalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnTotalEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvKnowledgeLearnTotal(ref clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN)
{
bool bolResult = vKnowledgeLearnTotalDA.GetvKnowledgeLearnTotal(ref objvKnowledgeLearnTotalEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvKnowledgeLearnTotalEN GetObjBymId(long lngmId)
{
clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = vKnowledgeLearnTotalDA.GetObjBymId(lngmId);
return objvKnowledgeLearnTotalEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvKnowledgeLearnTotalEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = vKnowledgeLearnTotalDA.GetFirstObj(strWhereCond);
 return objvKnowledgeLearnTotalEN;
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
public static clsvKnowledgeLearnTotalEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = vKnowledgeLearnTotalDA.GetObjByDataRow(objRow);
 return objvKnowledgeLearnTotalEN;
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
public static clsvKnowledgeLearnTotalEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = vKnowledgeLearnTotalDA.GetObjByDataRow(objRow);
 return objvKnowledgeLearnTotalEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvKnowledgeLearnTotalObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvKnowledgeLearnTotalEN GetObjBymIdFromList(long lngmId, List<clsvKnowledgeLearnTotalEN> lstvKnowledgeLearnTotalObjLst)
{
foreach (clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN in lstvKnowledgeLearnTotalObjLst)
{
if (objvKnowledgeLearnTotalEN.mId == lngmId)
{
return objvKnowledgeLearnTotalEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvKnowledgeLearnTotalDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vKnowledgeLearnTotalDA.GetID(strWhereCond);
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
bool bolIsExist = vKnowledgeLearnTotalDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vKnowledgeLearnTotalDA.IsExist(lngmId);
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
 bolIsExist = clsvKnowledgeLearnTotalDA.IsExistTable();
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
 bolIsExist = vKnowledgeLearnTotalDA.IsExistTable(strTabName);
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
 /// <param name = "objvKnowledgeLearnTotalENS">源对象</param>
 /// <param name = "objvKnowledgeLearnTotalENT">目标对象</param>
 public static void CopyTo(clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalENS, clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalENT)
{
try
{
objvKnowledgeLearnTotalENT.mId = objvKnowledgeLearnTotalENS.mId; //mId
objvKnowledgeLearnTotalENT.UserId = objvKnowledgeLearnTotalENS.UserId; //用户ID
objvKnowledgeLearnTotalENT.UserName = objvKnowledgeLearnTotalENS.UserName; //用户名
objvKnowledgeLearnTotalENT.CourseKnowledgeId = objvKnowledgeLearnTotalENS.CourseKnowledgeId; //知识点Id
objvKnowledgeLearnTotalENT.KnowledgeName = objvKnowledgeLearnTotalENS.KnowledgeName; //知识点名称
objvKnowledgeLearnTotalENT.CourseId = objvKnowledgeLearnTotalENS.CourseId; //课程Id
objvKnowledgeLearnTotalENT.CourseName = objvKnowledgeLearnTotalENS.CourseName; //课程名称
objvKnowledgeLearnTotalENT.CourseChapterId = objvKnowledgeLearnTotalENS.CourseChapterId; //课程章节ID
objvKnowledgeLearnTotalENT.MasterDegree = objvKnowledgeLearnTotalENS.MasterDegree; //掌握程度
objvKnowledgeLearnTotalENT.LearnCount = objvKnowledgeLearnTotalENS.LearnCount; //学习次数
objvKnowledgeLearnTotalENT.SuccessCount = objvKnowledgeLearnTotalENS.SuccessCount; //成功次数
objvKnowledgeLearnTotalENT.FailCount = objvKnowledgeLearnTotalENS.FailCount; //失败次数
objvKnowledgeLearnTotalENT.LastLearnDate = objvKnowledgeLearnTotalENS.LastLearnDate; //最后学习日期
objvKnowledgeLearnTotalENT.RecommendedNextReviewDate = objvKnowledgeLearnTotalENS.RecommendedNextReviewDate; //推荐下次复习日期
objvKnowledgeLearnTotalENT.UpdDate = objvKnowledgeLearnTotalENS.UpdDate; //修改日期
objvKnowledgeLearnTotalENT.UpdUser = objvKnowledgeLearnTotalENS.UpdUser; //修改人
objvKnowledgeLearnTotalENT.Memo = objvKnowledgeLearnTotalENS.Memo; //备注
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
 /// <param name = "objvKnowledgeLearnTotalEN">源简化对象</param>
 public static void SetUpdFlag(clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN)
{
try
{
objvKnowledgeLearnTotalEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvKnowledgeLearnTotalEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convKnowledgeLearnTotal.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnTotalEN.mId = objvKnowledgeLearnTotalEN.mId; //mId
}
if (arrFldSet.Contains(convKnowledgeLearnTotal.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnTotalEN.UserId = objvKnowledgeLearnTotalEN.UserId == "[null]" ? null :  objvKnowledgeLearnTotalEN.UserId; //用户ID
}
if (arrFldSet.Contains(convKnowledgeLearnTotal.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnTotalEN.UserName = objvKnowledgeLearnTotalEN.UserName == "[null]" ? null :  objvKnowledgeLearnTotalEN.UserName; //用户名
}
if (arrFldSet.Contains(convKnowledgeLearnTotal.CourseKnowledgeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnTotalEN.CourseKnowledgeId = objvKnowledgeLearnTotalEN.CourseKnowledgeId == "[null]" ? null :  objvKnowledgeLearnTotalEN.CourseKnowledgeId; //知识点Id
}
if (arrFldSet.Contains(convKnowledgeLearnTotal.KnowledgeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnTotalEN.KnowledgeName = objvKnowledgeLearnTotalEN.KnowledgeName; //知识点名称
}
if (arrFldSet.Contains(convKnowledgeLearnTotal.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnTotalEN.CourseId = objvKnowledgeLearnTotalEN.CourseId == "[null]" ? null :  objvKnowledgeLearnTotalEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convKnowledgeLearnTotal.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnTotalEN.CourseName = objvKnowledgeLearnTotalEN.CourseName == "[null]" ? null :  objvKnowledgeLearnTotalEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convKnowledgeLearnTotal.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnTotalEN.CourseChapterId = objvKnowledgeLearnTotalEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convKnowledgeLearnTotal.MasterDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnTotalEN.MasterDegree = objvKnowledgeLearnTotalEN.MasterDegree; //掌握程度
}
if (arrFldSet.Contains(convKnowledgeLearnTotal.LearnCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnTotalEN.LearnCount = objvKnowledgeLearnTotalEN.LearnCount; //学习次数
}
if (arrFldSet.Contains(convKnowledgeLearnTotal.SuccessCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnTotalEN.SuccessCount = objvKnowledgeLearnTotalEN.SuccessCount; //成功次数
}
if (arrFldSet.Contains(convKnowledgeLearnTotal.FailCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnTotalEN.FailCount = objvKnowledgeLearnTotalEN.FailCount; //失败次数
}
if (arrFldSet.Contains(convKnowledgeLearnTotal.LastLearnDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnTotalEN.LastLearnDate = objvKnowledgeLearnTotalEN.LastLearnDate == "[null]" ? null :  objvKnowledgeLearnTotalEN.LastLearnDate; //最后学习日期
}
if (arrFldSet.Contains(convKnowledgeLearnTotal.RecommendedNextReviewDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnTotalEN.RecommendedNextReviewDate = objvKnowledgeLearnTotalEN.RecommendedNextReviewDate == "[null]" ? null :  objvKnowledgeLearnTotalEN.RecommendedNextReviewDate; //推荐下次复习日期
}
if (arrFldSet.Contains(convKnowledgeLearnTotal.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnTotalEN.UpdDate = objvKnowledgeLearnTotalEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convKnowledgeLearnTotal.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnTotalEN.UpdUser = objvKnowledgeLearnTotalEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convKnowledgeLearnTotal.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnTotalEN.Memo = objvKnowledgeLearnTotalEN.Memo == "[null]" ? null :  objvKnowledgeLearnTotalEN.Memo; //备注
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
 /// <param name = "objvKnowledgeLearnTotalEN">源简化对象</param>
 public static void AccessFldValueNull(clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN)
{
try
{
if (objvKnowledgeLearnTotalEN.UserId == "[null]") objvKnowledgeLearnTotalEN.UserId = null; //用户ID
if (objvKnowledgeLearnTotalEN.UserName == "[null]") objvKnowledgeLearnTotalEN.UserName = null; //用户名
if (objvKnowledgeLearnTotalEN.CourseKnowledgeId == "[null]") objvKnowledgeLearnTotalEN.CourseKnowledgeId = null; //知识点Id
if (objvKnowledgeLearnTotalEN.CourseId == "[null]") objvKnowledgeLearnTotalEN.CourseId = null; //课程Id
if (objvKnowledgeLearnTotalEN.CourseName == "[null]") objvKnowledgeLearnTotalEN.CourseName = null; //课程名称
if (objvKnowledgeLearnTotalEN.LastLearnDate == "[null]") objvKnowledgeLearnTotalEN.LastLearnDate = null; //最后学习日期
if (objvKnowledgeLearnTotalEN.RecommendedNextReviewDate == "[null]") objvKnowledgeLearnTotalEN.RecommendedNextReviewDate = null; //推荐下次复习日期
if (objvKnowledgeLearnTotalEN.Memo == "[null]") objvKnowledgeLearnTotalEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN)
{
 vKnowledgeLearnTotalDA.CheckProperty4Condition(objvKnowledgeLearnTotalEN);
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
if (clsKnowledgeLearnTotalBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsKnowledgeLearnTotalBL没有刷新缓存机制(clsKnowledgeLearnTotalBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseKnowledgesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseKnowledgesBL没有刷新缓存机制(clscc_CourseKnowledgesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsKnowledgeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsKnowledgeTypeBL没有刷新缓存机制(clsKnowledgeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvKnowledgeLearnTotalObjLstCache == null)
//{
//arrvKnowledgeLearnTotalObjLstCache = vKnowledgeLearnTotalDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvKnowledgeLearnTotalEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvKnowledgeLearnTotalEN._CurrTabName);
List<clsvKnowledgeLearnTotalEN> arrvKnowledgeLearnTotalObjLstCache = GetObjLstCache();
IEnumerable <clsvKnowledgeLearnTotalEN> arrvKnowledgeLearnTotalObjLst_Sel =
arrvKnowledgeLearnTotalObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvKnowledgeLearnTotalObjLst_Sel.Count() == 0)
{
   clsvKnowledgeLearnTotalEN obj = clsvKnowledgeLearnTotalBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvKnowledgeLearnTotalObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvKnowledgeLearnTotalEN> GetAllvKnowledgeLearnTotalObjLstCache()
{
//获取缓存中的对象列表
List<clsvKnowledgeLearnTotalEN> arrvKnowledgeLearnTotalObjLstCache = GetObjLstCache(); 
return arrvKnowledgeLearnTotalObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvKnowledgeLearnTotalEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvKnowledgeLearnTotalEN._CurrTabName);
List<clsvKnowledgeLearnTotalEN> arrvKnowledgeLearnTotalObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvKnowledgeLearnTotalObjLstCache;
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
string strKey = string.Format("{0}", clsvKnowledgeLearnTotalEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convKnowledgeLearnTotal.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convKnowledgeLearnTotal.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convKnowledgeLearnTotal.AttributeName));
throw new Exception(strMsg);
}
var objvKnowledgeLearnTotal = clsvKnowledgeLearnTotalBL.GetObjBymIdCache(lngmId);
if (objvKnowledgeLearnTotal == null) return "";
return objvKnowledgeLearnTotal[strOutFldName].ToString();
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
int intRecCount = clsvKnowledgeLearnTotalDA.GetRecCount(strTabName);
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
int intRecCount = clsvKnowledgeLearnTotalDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvKnowledgeLearnTotalDA.GetRecCount();
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
int intRecCount = clsvKnowledgeLearnTotalDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalCond)
{
List<clsvKnowledgeLearnTotalEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvKnowledgeLearnTotalEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convKnowledgeLearnTotal.AttributeName)
{
if (objvKnowledgeLearnTotalCond.IsUpdated(strFldName) == false) continue;
if (objvKnowledgeLearnTotalCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvKnowledgeLearnTotalCond[strFldName].ToString());
}
else
{
if (objvKnowledgeLearnTotalCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvKnowledgeLearnTotalCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvKnowledgeLearnTotalCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvKnowledgeLearnTotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvKnowledgeLearnTotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvKnowledgeLearnTotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvKnowledgeLearnTotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvKnowledgeLearnTotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvKnowledgeLearnTotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvKnowledgeLearnTotalCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvKnowledgeLearnTotalCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvKnowledgeLearnTotalCond[strFldName]));
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
 List<string> arrList = clsvKnowledgeLearnTotalDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vKnowledgeLearnTotalDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vKnowledgeLearnTotalDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}