
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvKnowledgeLearnTotalWApi
 表名:vKnowledgeLearnTotal(01120156)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:02
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
public static class clsvKnowledgeLearnTotalWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetUserId(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convKnowledgeLearnTotal.UserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetUserName(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convKnowledgeLearnTotal.UserName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetCourseKnowledgeId(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, convKnowledgeLearnTotal.CourseKnowledgeId);
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, convKnowledgeLearnTotal.CourseKnowledgeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetKnowledgeName(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strKnowledgeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKnowledgeName, convKnowledgeLearnTotal.KnowledgeName);
clsCheckSql.CheckFieldLen(strKnowledgeName, 100, convKnowledgeLearnTotal.KnowledgeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetCourseId(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convKnowledgeLearnTotal.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convKnowledgeLearnTotal.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetCourseName(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convKnowledgeLearnTotal.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetCourseChapterId(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convKnowledgeLearnTotal.CourseChapterId);
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convKnowledgeLearnTotal.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convKnowledgeLearnTotal.CourseChapterId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetLearnCount(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, int intLearnCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetSuccessCount(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, int intSuccessCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetFailCount(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, int intFailCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetLastLearnDate(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strLastLearnDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLastLearnDate, 14, convKnowledgeLearnTotal.LastLearnDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetRecommendedNextReviewDate(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strRecommendedNextReviewDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedNextReviewDate, 14, convKnowledgeLearnTotal.RecommendedNextReviewDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetUpdDate(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convKnowledgeLearnTotal.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convKnowledgeLearnTotal.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetUpdUser(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convKnowledgeLearnTotal.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convKnowledgeLearnTotal.UpdUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnTotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnTotalEN SetMemo(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convKnowledgeLearnTotal.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotal_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvKnowledgeLearnTotal_Cond.IsUpdated(convKnowledgeLearnTotal.mId) == true)
{
string strComparisonOp_mId = objvKnowledgeLearnTotal_Cond.dicFldComparisonOp[convKnowledgeLearnTotal.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convKnowledgeLearnTotal.mId, objvKnowledgeLearnTotal_Cond.mId, strComparisonOp_mId);
}
if (objvKnowledgeLearnTotal_Cond.IsUpdated(convKnowledgeLearnTotal.UserId) == true)
{
string strComparisonOp_UserId = objvKnowledgeLearnTotal_Cond.dicFldComparisonOp[convKnowledgeLearnTotal.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.UserId, objvKnowledgeLearnTotal_Cond.UserId, strComparisonOp_UserId);
}
if (objvKnowledgeLearnTotal_Cond.IsUpdated(convKnowledgeLearnTotal.UserName) == true)
{
string strComparisonOp_UserName = objvKnowledgeLearnTotal_Cond.dicFldComparisonOp[convKnowledgeLearnTotal.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.UserName, objvKnowledgeLearnTotal_Cond.UserName, strComparisonOp_UserName);
}
if (objvKnowledgeLearnTotal_Cond.IsUpdated(convKnowledgeLearnTotal.CourseKnowledgeId) == true)
{
string strComparisonOp_CourseKnowledgeId = objvKnowledgeLearnTotal_Cond.dicFldComparisonOp[convKnowledgeLearnTotal.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.CourseKnowledgeId, objvKnowledgeLearnTotal_Cond.CourseKnowledgeId, strComparisonOp_CourseKnowledgeId);
}
if (objvKnowledgeLearnTotal_Cond.IsUpdated(convKnowledgeLearnTotal.KnowledgeName) == true)
{
string strComparisonOp_KnowledgeName = objvKnowledgeLearnTotal_Cond.dicFldComparisonOp[convKnowledgeLearnTotal.KnowledgeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.KnowledgeName, objvKnowledgeLearnTotal_Cond.KnowledgeName, strComparisonOp_KnowledgeName);
}
if (objvKnowledgeLearnTotal_Cond.IsUpdated(convKnowledgeLearnTotal.CourseId) == true)
{
string strComparisonOp_CourseId = objvKnowledgeLearnTotal_Cond.dicFldComparisonOp[convKnowledgeLearnTotal.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.CourseId, objvKnowledgeLearnTotal_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvKnowledgeLearnTotal_Cond.IsUpdated(convKnowledgeLearnTotal.CourseName) == true)
{
string strComparisonOp_CourseName = objvKnowledgeLearnTotal_Cond.dicFldComparisonOp[convKnowledgeLearnTotal.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.CourseName, objvKnowledgeLearnTotal_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvKnowledgeLearnTotal_Cond.IsUpdated(convKnowledgeLearnTotal.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvKnowledgeLearnTotal_Cond.dicFldComparisonOp[convKnowledgeLearnTotal.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.CourseChapterId, objvKnowledgeLearnTotal_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvKnowledgeLearnTotal_Cond.IsUpdated(convKnowledgeLearnTotal.MasterDegree) == true)
{
string strComparisonOp_MasterDegree = objvKnowledgeLearnTotal_Cond.dicFldComparisonOp[convKnowledgeLearnTotal.MasterDegree];
strWhereCond += string.Format(" And {0} {2} {1}", convKnowledgeLearnTotal.MasterDegree, objvKnowledgeLearnTotal_Cond.MasterDegree, strComparisonOp_MasterDegree);
}
if (objvKnowledgeLearnTotal_Cond.IsUpdated(convKnowledgeLearnTotal.LearnCount) == true)
{
string strComparisonOp_LearnCount = objvKnowledgeLearnTotal_Cond.dicFldComparisonOp[convKnowledgeLearnTotal.LearnCount];
strWhereCond += string.Format(" And {0} {2} {1}", convKnowledgeLearnTotal.LearnCount, objvKnowledgeLearnTotal_Cond.LearnCount, strComparisonOp_LearnCount);
}
if (objvKnowledgeLearnTotal_Cond.IsUpdated(convKnowledgeLearnTotal.SuccessCount) == true)
{
string strComparisonOp_SuccessCount = objvKnowledgeLearnTotal_Cond.dicFldComparisonOp[convKnowledgeLearnTotal.SuccessCount];
strWhereCond += string.Format(" And {0} {2} {1}", convKnowledgeLearnTotal.SuccessCount, objvKnowledgeLearnTotal_Cond.SuccessCount, strComparisonOp_SuccessCount);
}
if (objvKnowledgeLearnTotal_Cond.IsUpdated(convKnowledgeLearnTotal.FailCount) == true)
{
string strComparisonOp_FailCount = objvKnowledgeLearnTotal_Cond.dicFldComparisonOp[convKnowledgeLearnTotal.FailCount];
strWhereCond += string.Format(" And {0} {2} {1}", convKnowledgeLearnTotal.FailCount, objvKnowledgeLearnTotal_Cond.FailCount, strComparisonOp_FailCount);
}
if (objvKnowledgeLearnTotal_Cond.IsUpdated(convKnowledgeLearnTotal.LastLearnDate) == true)
{
string strComparisonOp_LastLearnDate = objvKnowledgeLearnTotal_Cond.dicFldComparisonOp[convKnowledgeLearnTotal.LastLearnDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.LastLearnDate, objvKnowledgeLearnTotal_Cond.LastLearnDate, strComparisonOp_LastLearnDate);
}
if (objvKnowledgeLearnTotal_Cond.IsUpdated(convKnowledgeLearnTotal.RecommendedNextReviewDate) == true)
{
string strComparisonOp_RecommendedNextReviewDate = objvKnowledgeLearnTotal_Cond.dicFldComparisonOp[convKnowledgeLearnTotal.RecommendedNextReviewDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.RecommendedNextReviewDate, objvKnowledgeLearnTotal_Cond.RecommendedNextReviewDate, strComparisonOp_RecommendedNextReviewDate);
}
if (objvKnowledgeLearnTotal_Cond.IsUpdated(convKnowledgeLearnTotal.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvKnowledgeLearnTotal_Cond.dicFldComparisonOp[convKnowledgeLearnTotal.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.UpdDate, objvKnowledgeLearnTotal_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvKnowledgeLearnTotal_Cond.IsUpdated(convKnowledgeLearnTotal.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvKnowledgeLearnTotal_Cond.dicFldComparisonOp[convKnowledgeLearnTotal.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.UpdUser, objvKnowledgeLearnTotal_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvKnowledgeLearnTotal_Cond.IsUpdated(convKnowledgeLearnTotal.Memo) == true)
{
string strComparisonOp_Memo = objvKnowledgeLearnTotal_Cond.dicFldComparisonOp[convKnowledgeLearnTotal.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnTotal.Memo, objvKnowledgeLearnTotal_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v知识点学习汇总表(vKnowledgeLearnTotal)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvKnowledgeLearnTotalWApi
{
private static readonly string mstrApiControllerName = "vKnowledgeLearnTotalApi";

 public clsvKnowledgeLearnTotalWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvKnowledgeLearnTotalEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvKnowledgeLearnTotalEN = JsonConvert.DeserializeObject<clsvKnowledgeLearnTotalEN>((string)jobjReturn["ReturnObj"]);
return objvKnowledgeLearnTotalEN;
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
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvKnowledgeLearnTotalEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvKnowledgeLearnTotalEN = JsonConvert.DeserializeObject<clsvKnowledgeLearnTotalEN>((string)jobjReturn["ReturnObj"]);
return objvKnowledgeLearnTotalEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvKnowledgeLearnTotalEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvKnowledgeLearnTotalEN objvKnowledgeLearnTotalEN = null;
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
objvKnowledgeLearnTotalEN = JsonConvert.DeserializeObject<clsvKnowledgeLearnTotalEN>((string)jobjReturn["ReturnObj"]);
return objvKnowledgeLearnTotalEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvKnowledgeLearnTotalEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvKnowledgeLearnTotalEN._CurrTabName_S);
List<clsvKnowledgeLearnTotalEN> arrvKnowledgeLearnTotalObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvKnowledgeLearnTotalEN> arrvKnowledgeLearnTotalObjLst_Sel =
from objvKnowledgeLearnTotalEN in arrvKnowledgeLearnTotalObjLst_Cache
where objvKnowledgeLearnTotalEN.mId == lngmId
select objvKnowledgeLearnTotalEN;
if (arrvKnowledgeLearnTotalObjLst_Sel.Count() == 0)
{
   clsvKnowledgeLearnTotalEN obj = clsvKnowledgeLearnTotalWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvKnowledgeLearnTotalObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvKnowledgeLearnTotalEN> GetObjLst(string strWhereCond)
{
 List<clsvKnowledgeLearnTotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvKnowledgeLearnTotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvKnowledgeLearnTotalEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvKnowledgeLearnTotalEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvKnowledgeLearnTotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvKnowledgeLearnTotalEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvKnowledgeLearnTotalEN._CurrTabName_S);
List<clsvKnowledgeLearnTotalEN> arrvKnowledgeLearnTotalObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvKnowledgeLearnTotalEN> arrvKnowledgeLearnTotalObjLst_Sel =
from objvKnowledgeLearnTotalEN in arrvKnowledgeLearnTotalObjLst_Cache
where arrMId.Contains(objvKnowledgeLearnTotalEN.mId)
select objvKnowledgeLearnTotalEN;
return arrvKnowledgeLearnTotalObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvKnowledgeLearnTotalEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvKnowledgeLearnTotalEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvKnowledgeLearnTotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvKnowledgeLearnTotalEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvKnowledgeLearnTotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvKnowledgeLearnTotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvKnowledgeLearnTotalEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvKnowledgeLearnTotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvKnowledgeLearnTotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvKnowledgeLearnTotalEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvKnowledgeLearnTotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvKnowledgeLearnTotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvKnowledgeLearnTotalEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvKnowledgeLearnTotalEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvKnowledgeLearnTotalEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
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
public static DataTable ToDataTable(List<clsvKnowledgeLearnTotalEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvKnowledgeLearnTotalEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvKnowledgeLearnTotalEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvKnowledgeLearnTotalEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvKnowledgeLearnTotalEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvKnowledgeLearnTotalEN.AttributeName)
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
if (clsKnowledgeLearnTotalWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsKnowledgeLearnTotalWApi没有刷新缓存机制(clsKnowledgeLearnTotalWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseKnowledgesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseKnowledgesWApi没有刷新缓存机制(clscc_CourseKnowledgesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsKnowledgeTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsKnowledgeTypeWApi没有刷新缓存机制(clsKnowledgeTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvKnowledgeLearnTotalObjLst_Cache == null)
//{
//arrvKnowledgeLearnTotalObjLst_Cache = await clsvKnowledgeLearnTotalWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvKnowledgeLearnTotalEN._CurrTabName_S);
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
public static List<clsvKnowledgeLearnTotalEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvKnowledgeLearnTotalEN._CurrTabName_S);
List<clsvKnowledgeLearnTotalEN> arrvKnowledgeLearnTotalObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvKnowledgeLearnTotalObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvKnowledgeLearnTotalEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convKnowledgeLearnTotal.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convKnowledgeLearnTotal.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnTotal.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnTotal.CourseKnowledgeId, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnTotal.KnowledgeName, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnTotal.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnTotal.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnTotal.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnTotal.MasterDegree, Type.GetType("System.Int32"));
objDT.Columns.Add(convKnowledgeLearnTotal.LearnCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convKnowledgeLearnTotal.SuccessCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convKnowledgeLearnTotal.FailCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convKnowledgeLearnTotal.LastLearnDate, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnTotal.RecommendedNextReviewDate, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnTotal.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnTotal.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnTotal.Memo, Type.GetType("System.String"));
foreach (clsvKnowledgeLearnTotalEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convKnowledgeLearnTotal.mId] = objInFor[convKnowledgeLearnTotal.mId];
objDR[convKnowledgeLearnTotal.UserId] = objInFor[convKnowledgeLearnTotal.UserId];
objDR[convKnowledgeLearnTotal.UserName] = objInFor[convKnowledgeLearnTotal.UserName];
objDR[convKnowledgeLearnTotal.CourseKnowledgeId] = objInFor[convKnowledgeLearnTotal.CourseKnowledgeId];
objDR[convKnowledgeLearnTotal.KnowledgeName] = objInFor[convKnowledgeLearnTotal.KnowledgeName];
objDR[convKnowledgeLearnTotal.CourseId] = objInFor[convKnowledgeLearnTotal.CourseId];
objDR[convKnowledgeLearnTotal.CourseName] = objInFor[convKnowledgeLearnTotal.CourseName];
objDR[convKnowledgeLearnTotal.CourseChapterId] = objInFor[convKnowledgeLearnTotal.CourseChapterId];
objDR[convKnowledgeLearnTotal.MasterDegree] = objInFor[convKnowledgeLearnTotal.MasterDegree];
objDR[convKnowledgeLearnTotal.LearnCount] = objInFor[convKnowledgeLearnTotal.LearnCount];
objDR[convKnowledgeLearnTotal.SuccessCount] = objInFor[convKnowledgeLearnTotal.SuccessCount];
objDR[convKnowledgeLearnTotal.FailCount] = objInFor[convKnowledgeLearnTotal.FailCount];
objDR[convKnowledgeLearnTotal.LastLearnDate] = objInFor[convKnowledgeLearnTotal.LastLearnDate];
objDR[convKnowledgeLearnTotal.RecommendedNextReviewDate] = objInFor[convKnowledgeLearnTotal.RecommendedNextReviewDate];
objDR[convKnowledgeLearnTotal.UpdDate] = objInFor[convKnowledgeLearnTotal.UpdDate];
objDR[convKnowledgeLearnTotal.UpdUser] = objInFor[convKnowledgeLearnTotal.UpdUser];
objDR[convKnowledgeLearnTotal.Memo] = objInFor[convKnowledgeLearnTotal.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}