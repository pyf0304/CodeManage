
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvKnowledgeLearnDetailBL
 表名:vKnowledgeLearnDetail(01120157)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:49:27
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
public static class  clsvKnowledgeLearnDetailBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvKnowledgeLearnDetailEN GetObj(this K_mId_vKnowledgeLearnDetail myKey)
{
clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = clsvKnowledgeLearnDetailBL.vKnowledgeLearnDetailDA.GetObjBymId(myKey.Value);
return objvKnowledgeLearnDetailEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetmId(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, long lngmId, string strComparisonOp="")
	{
objvKnowledgeLearnDetailEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.mId) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.mId, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.mId] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetUserId(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convKnowledgeLearnDetail.UserId);
}
objvKnowledgeLearnDetailEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.UserId) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.UserId, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.UserId] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetUserName(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convKnowledgeLearnDetail.UserName);
}
objvKnowledgeLearnDetailEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.UserName) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.UserName, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.UserName] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetCourseKnowledgeId(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, convKnowledgeLearnDetail.CourseKnowledgeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, convKnowledgeLearnDetail.CourseKnowledgeId);
}
objvKnowledgeLearnDetailEN.CourseKnowledgeId = strCourseKnowledgeId; //知识点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.CourseKnowledgeId) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.CourseKnowledgeId, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.CourseKnowledgeId] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetKnowledgeName(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strKnowledgeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKnowledgeName, convKnowledgeLearnDetail.KnowledgeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeName, 100, convKnowledgeLearnDetail.KnowledgeName);
}
objvKnowledgeLearnDetailEN.KnowledgeName = strKnowledgeName; //知识点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.KnowledgeName) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.KnowledgeName, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.KnowledgeName] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetCourseId(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convKnowledgeLearnDetail.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convKnowledgeLearnDetail.CourseId);
}
objvKnowledgeLearnDetailEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.CourseId) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.CourseId, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.CourseId] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetCourseName(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convKnowledgeLearnDetail.CourseName);
}
objvKnowledgeLearnDetailEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.CourseName) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.CourseName, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.CourseName] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetCourseChapterId(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convKnowledgeLearnDetail.CourseChapterId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convKnowledgeLearnDetail.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convKnowledgeLearnDetail.CourseChapterId);
}
objvKnowledgeLearnDetailEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.CourseChapterId) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.CourseChapterId, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.CourseChapterId] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetLearnDate(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strLearnDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLearnDate, convKnowledgeLearnDetail.LearnDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLearnDate, 14, convKnowledgeLearnDetail.LearnDate);
}
objvKnowledgeLearnDetailEN.LearnDate = strLearnDate; //学习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.LearnDate) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.LearnDate, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.LearnDate] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetLearnModeId(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strLearnModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLearnModeId, convKnowledgeLearnDetail.LearnModeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLearnModeId, 4, convKnowledgeLearnDetail.LearnModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLearnModeId, 4, convKnowledgeLearnDetail.LearnModeId);
}
objvKnowledgeLearnDetailEN.LearnModeId = strLearnModeId; //学习模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.LearnModeId) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.LearnModeId, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.LearnModeId] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetLearnModeName(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strLearnModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLearnModeName, convKnowledgeLearnDetail.LearnModeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLearnModeName, 30, convKnowledgeLearnDetail.LearnModeName);
}
objvKnowledgeLearnDetailEN.LearnModeName = strLearnModeName; //学习模式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.LearnModeName) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.LearnModeName, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.LearnModeName] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetIdCase(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strIdCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCase, convKnowledgeLearnDetail.IdCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCase, 8, convKnowledgeLearnDetail.IdCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCase, 8, convKnowledgeLearnDetail.IdCase);
}
objvKnowledgeLearnDetailEN.IdCase = strIdCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.IdCase) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.IdCase, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.IdCase] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetIdCaseType(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strIdCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, convKnowledgeLearnDetail.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, convKnowledgeLearnDetail.IdCaseType);
}
objvKnowledgeLearnDetailEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.IdCaseType) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.IdCaseType, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.IdCaseType] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetIsMaster(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, bool bolIsMaster, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsMaster, convKnowledgeLearnDetail.IsMaster);
objvKnowledgeLearnDetailEN.IsMaster = bolIsMaster; //是否掌握
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.IsMaster) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.IsMaster, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.IsMaster] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetMasterDegree(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, int intMasterDegree, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intMasterDegree, convKnowledgeLearnDetail.MasterDegree);
objvKnowledgeLearnDetailEN.MasterDegree = intMasterDegree; //掌握程度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.MasterDegree) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.MasterDegree, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.MasterDegree] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetMarkerId(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strMarkerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkerId, 20, convKnowledgeLearnDetail.MarkerId);
}
objvKnowledgeLearnDetailEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.MarkerId) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.MarkerId, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.MarkerId] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetMarkTime(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strMarkTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkTime, 14, convKnowledgeLearnDetail.MarkTime);
}
objvKnowledgeLearnDetailEN.MarkTime = strMarkTime; //批改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.MarkTime) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.MarkTime, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.MarkTime] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetUpdDate(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convKnowledgeLearnDetail.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convKnowledgeLearnDetail.UpdDate);
}
objvKnowledgeLearnDetailEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.UpdDate) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.UpdDate, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.UpdDate] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetUpdUser(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convKnowledgeLearnDetail.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convKnowledgeLearnDetail.UpdUser);
}
objvKnowledgeLearnDetailEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.UpdUser) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.UpdUser, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.UpdUser] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetMemo(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convKnowledgeLearnDetail.Memo);
}
objvKnowledgeLearnDetailEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.Memo) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.Memo, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.Memo] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailENS">源对象</param>
 /// <param name = "objvKnowledgeLearnDetailENT">目标对象</param>
 public static void CopyTo(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailENS, clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailENT)
{
try
{
objvKnowledgeLearnDetailENT.mId = objvKnowledgeLearnDetailENS.mId; //mId
objvKnowledgeLearnDetailENT.UserId = objvKnowledgeLearnDetailENS.UserId; //用户ID
objvKnowledgeLearnDetailENT.UserName = objvKnowledgeLearnDetailENS.UserName; //用户名
objvKnowledgeLearnDetailENT.CourseKnowledgeId = objvKnowledgeLearnDetailENS.CourseKnowledgeId; //知识点Id
objvKnowledgeLearnDetailENT.KnowledgeName = objvKnowledgeLearnDetailENS.KnowledgeName; //知识点名称
objvKnowledgeLearnDetailENT.CourseId = objvKnowledgeLearnDetailENS.CourseId; //课程Id
objvKnowledgeLearnDetailENT.CourseName = objvKnowledgeLearnDetailENS.CourseName; //课程名称
objvKnowledgeLearnDetailENT.CourseChapterId = objvKnowledgeLearnDetailENS.CourseChapterId; //课程章节ID
objvKnowledgeLearnDetailENT.LearnDate = objvKnowledgeLearnDetailENS.LearnDate; //学习日期
objvKnowledgeLearnDetailENT.LearnModeId = objvKnowledgeLearnDetailENS.LearnModeId; //学习模式Id
objvKnowledgeLearnDetailENT.LearnModeName = objvKnowledgeLearnDetailENS.LearnModeName; //学习模式名
objvKnowledgeLearnDetailENT.IdCase = objvKnowledgeLearnDetailENS.IdCase; //案例流水号
objvKnowledgeLearnDetailENT.IdCaseType = objvKnowledgeLearnDetailENS.IdCaseType; //案例类型流水号
objvKnowledgeLearnDetailENT.IsMaster = objvKnowledgeLearnDetailENS.IsMaster; //是否掌握
objvKnowledgeLearnDetailENT.MasterDegree = objvKnowledgeLearnDetailENS.MasterDegree; //掌握程度
objvKnowledgeLearnDetailENT.MarkerId = objvKnowledgeLearnDetailENS.MarkerId; //打分者
objvKnowledgeLearnDetailENT.MarkTime = objvKnowledgeLearnDetailENS.MarkTime; //批改时间
objvKnowledgeLearnDetailENT.UpdDate = objvKnowledgeLearnDetailENS.UpdDate; //修改日期
objvKnowledgeLearnDetailENT.UpdUser = objvKnowledgeLearnDetailENS.UpdUser; //修改人
objvKnowledgeLearnDetailENT.Memo = objvKnowledgeLearnDetailENS.Memo; //备注
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
 /// <param name = "objvKnowledgeLearnDetailENS">源对象</param>
 /// <returns>目标对象=>clsvKnowledgeLearnDetailEN:objvKnowledgeLearnDetailENT</returns>
 public static clsvKnowledgeLearnDetailEN CopyTo(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailENS)
{
try
{
 clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailENT = new clsvKnowledgeLearnDetailEN()
{
mId = objvKnowledgeLearnDetailENS.mId, //mId
UserId = objvKnowledgeLearnDetailENS.UserId, //用户ID
UserName = objvKnowledgeLearnDetailENS.UserName, //用户名
CourseKnowledgeId = objvKnowledgeLearnDetailENS.CourseKnowledgeId, //知识点Id
KnowledgeName = objvKnowledgeLearnDetailENS.KnowledgeName, //知识点名称
CourseId = objvKnowledgeLearnDetailENS.CourseId, //课程Id
CourseName = objvKnowledgeLearnDetailENS.CourseName, //课程名称
CourseChapterId = objvKnowledgeLearnDetailENS.CourseChapterId, //课程章节ID
LearnDate = objvKnowledgeLearnDetailENS.LearnDate, //学习日期
LearnModeId = objvKnowledgeLearnDetailENS.LearnModeId, //学习模式Id
LearnModeName = objvKnowledgeLearnDetailENS.LearnModeName, //学习模式名
IdCase = objvKnowledgeLearnDetailENS.IdCase, //案例流水号
IdCaseType = objvKnowledgeLearnDetailENS.IdCaseType, //案例类型流水号
IsMaster = objvKnowledgeLearnDetailENS.IsMaster, //是否掌握
MasterDegree = objvKnowledgeLearnDetailENS.MasterDegree, //掌握程度
MarkerId = objvKnowledgeLearnDetailENS.MarkerId, //打分者
MarkTime = objvKnowledgeLearnDetailENS.MarkTime, //批改时间
UpdDate = objvKnowledgeLearnDetailENS.UpdDate, //修改日期
UpdUser = objvKnowledgeLearnDetailENS.UpdUser, //修改人
Memo = objvKnowledgeLearnDetailENS.Memo, //备注
};
 return objvKnowledgeLearnDetailENT;
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
public static void CheckProperty4Condition(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN)
{
 clsvKnowledgeLearnDetailBL.vKnowledgeLearnDetailDA.CheckProperty4Condition(objvKnowledgeLearnDetailEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.mId) == true)
{
string strComparisonOpmId = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convKnowledgeLearnDetail.mId, objvKnowledgeLearnDetailCond.mId, strComparisonOpmId);
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.UserId) == true)
{
string strComparisonOpUserId = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.UserId, objvKnowledgeLearnDetailCond.UserId, strComparisonOpUserId);
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.UserName) == true)
{
string strComparisonOpUserName = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.UserName, objvKnowledgeLearnDetailCond.UserName, strComparisonOpUserName);
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.CourseKnowledgeId) == true)
{
string strComparisonOpCourseKnowledgeId = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.CourseKnowledgeId, objvKnowledgeLearnDetailCond.CourseKnowledgeId, strComparisonOpCourseKnowledgeId);
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.KnowledgeName) == true)
{
string strComparisonOpKnowledgeName = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.KnowledgeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.KnowledgeName, objvKnowledgeLearnDetailCond.KnowledgeName, strComparisonOpKnowledgeName);
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.CourseId) == true)
{
string strComparisonOpCourseId = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.CourseId, objvKnowledgeLearnDetailCond.CourseId, strComparisonOpCourseId);
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.CourseName) == true)
{
string strComparisonOpCourseName = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.CourseName, objvKnowledgeLearnDetailCond.CourseName, strComparisonOpCourseName);
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.CourseChapterId, objvKnowledgeLearnDetailCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.LearnDate) == true)
{
string strComparisonOpLearnDate = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.LearnDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.LearnDate, objvKnowledgeLearnDetailCond.LearnDate, strComparisonOpLearnDate);
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.LearnModeId) == true)
{
string strComparisonOpLearnModeId = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.LearnModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.LearnModeId, objvKnowledgeLearnDetailCond.LearnModeId, strComparisonOpLearnModeId);
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.LearnModeName) == true)
{
string strComparisonOpLearnModeName = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.LearnModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.LearnModeName, objvKnowledgeLearnDetailCond.LearnModeName, strComparisonOpLearnModeName);
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.IdCase) == true)
{
string strComparisonOpIdCase = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.IdCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.IdCase, objvKnowledgeLearnDetailCond.IdCase, strComparisonOpIdCase);
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.IdCaseType, objvKnowledgeLearnDetailCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.IsMaster) == true)
{
if (objvKnowledgeLearnDetailCond.IsMaster == true)
{
strWhereCond += string.Format(" And {0} = '1'", convKnowledgeLearnDetail.IsMaster);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convKnowledgeLearnDetail.IsMaster);
}
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.MasterDegree) == true)
{
string strComparisonOpMasterDegree = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.MasterDegree];
strWhereCond += string.Format(" And {0} {2} {1}", convKnowledgeLearnDetail.MasterDegree, objvKnowledgeLearnDetailCond.MasterDegree, strComparisonOpMasterDegree);
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.MarkerId) == true)
{
string strComparisonOpMarkerId = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.MarkerId, objvKnowledgeLearnDetailCond.MarkerId, strComparisonOpMarkerId);
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.MarkTime) == true)
{
string strComparisonOpMarkTime = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.MarkTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.MarkTime, objvKnowledgeLearnDetailCond.MarkTime, strComparisonOpMarkTime);
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.UpdDate) == true)
{
string strComparisonOpUpdDate = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.UpdDate, objvKnowledgeLearnDetailCond.UpdDate, strComparisonOpUpdDate);
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.UpdUser) == true)
{
string strComparisonOpUpdUser = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.UpdUser, objvKnowledgeLearnDetailCond.UpdUser, strComparisonOpUpdUser);
}
if (objvKnowledgeLearnDetailCond.IsUpdated(convKnowledgeLearnDetail.Memo) == true)
{
string strComparisonOpMemo = objvKnowledgeLearnDetailCond.dicFldComparisonOp[convKnowledgeLearnDetail.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.Memo, objvKnowledgeLearnDetailCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vKnowledgeLearnDetail
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v知识点学习情况(vKnowledgeLearnDetail)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvKnowledgeLearnDetailBL
{
public static RelatedActions_vKnowledgeLearnDetail relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvKnowledgeLearnDetailDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvKnowledgeLearnDetailDA vKnowledgeLearnDetailDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvKnowledgeLearnDetailDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvKnowledgeLearnDetailBL()
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
if (string.IsNullOrEmpty(clsvKnowledgeLearnDetailEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvKnowledgeLearnDetailEN._ConnectString);
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
public static DataTable GetDataTable_vKnowledgeLearnDetail(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vKnowledgeLearnDetailDA.GetDataTable_vKnowledgeLearnDetail(strWhereCond);
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
objDT = vKnowledgeLearnDetailDA.GetDataTable(strWhereCond);
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
objDT = vKnowledgeLearnDetailDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vKnowledgeLearnDetailDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vKnowledgeLearnDetailDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vKnowledgeLearnDetailDA.GetDataTable_Top(objTopPara);
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
objDT = vKnowledgeLearnDetailDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vKnowledgeLearnDetailDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vKnowledgeLearnDetailDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvKnowledgeLearnDetailEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvKnowledgeLearnDetailEN> arrObjLst = new List<clsvKnowledgeLearnDetailEN>(); 
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
	clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = new clsvKnowledgeLearnDetailEN();
try
{
objvKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[convKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objvKnowledgeLearnDetailEN.UserId = objRow[convKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnDetailEN.UserName = objRow[convKnowledgeLearnDetail.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[convKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnDetailEN.KnowledgeName = objRow[convKnowledgeLearnDetail.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnDetailEN.CourseId = objRow[convKnowledgeLearnDetail.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnDetailEN.CourseName = objRow[convKnowledgeLearnDetail.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnDetailEN.CourseChapterId = objRow[convKnowledgeLearnDetail.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnDetailEN.LearnDate = objRow[convKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objvKnowledgeLearnDetailEN.LearnModeId = objRow[convKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objvKnowledgeLearnDetailEN.LearnModeName = objRow[convKnowledgeLearnDetail.LearnModeName].ToString().Trim(); //学习模式名
objvKnowledgeLearnDetailEN.IdCase = objRow[convKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objvKnowledgeLearnDetailEN.IdCaseType = objRow[convKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objvKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[convKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objvKnowledgeLearnDetailEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnDetailEN.MarkerId = objRow[convKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objvKnowledgeLearnDetailEN.MarkTime = objRow[convKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objvKnowledgeLearnDetailEN.UpdDate = objRow[convKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnDetailEN.UpdUser = objRow[convKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnDetailEN.Memo = objRow[convKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvKnowledgeLearnDetailEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvKnowledgeLearnDetailEN._CurrTabName, strCourseId);
List<clsvKnowledgeLearnDetailEN> arrvKnowledgeLearnDetailObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvKnowledgeLearnDetailEN> arrvKnowledgeLearnDetailObjLst_Sel =
arrvKnowledgeLearnDetailObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvKnowledgeLearnDetailObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvKnowledgeLearnDetailEN> GetObjLst(string strWhereCond)
{
List<clsvKnowledgeLearnDetailEN> arrObjLst = new List<clsvKnowledgeLearnDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = new clsvKnowledgeLearnDetailEN();
try
{
objvKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[convKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objvKnowledgeLearnDetailEN.UserId = objRow[convKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnDetailEN.UserName = objRow[convKnowledgeLearnDetail.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[convKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnDetailEN.KnowledgeName = objRow[convKnowledgeLearnDetail.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnDetailEN.CourseId = objRow[convKnowledgeLearnDetail.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnDetailEN.CourseName = objRow[convKnowledgeLearnDetail.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnDetailEN.CourseChapterId = objRow[convKnowledgeLearnDetail.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnDetailEN.LearnDate = objRow[convKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objvKnowledgeLearnDetailEN.LearnModeId = objRow[convKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objvKnowledgeLearnDetailEN.LearnModeName = objRow[convKnowledgeLearnDetail.LearnModeName].ToString().Trim(); //学习模式名
objvKnowledgeLearnDetailEN.IdCase = objRow[convKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objvKnowledgeLearnDetailEN.IdCaseType = objRow[convKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objvKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[convKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objvKnowledgeLearnDetailEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnDetailEN.MarkerId = objRow[convKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objvKnowledgeLearnDetailEN.MarkTime = objRow[convKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objvKnowledgeLearnDetailEN.UpdDate = objRow[convKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnDetailEN.UpdUser = objRow[convKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnDetailEN.Memo = objRow[convKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnDetailEN);
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
public static List<clsvKnowledgeLearnDetailEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvKnowledgeLearnDetailEN> arrObjLst = new List<clsvKnowledgeLearnDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = new clsvKnowledgeLearnDetailEN();
try
{
objvKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[convKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objvKnowledgeLearnDetailEN.UserId = objRow[convKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnDetailEN.UserName = objRow[convKnowledgeLearnDetail.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[convKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnDetailEN.KnowledgeName = objRow[convKnowledgeLearnDetail.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnDetailEN.CourseId = objRow[convKnowledgeLearnDetail.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnDetailEN.CourseName = objRow[convKnowledgeLearnDetail.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnDetailEN.CourseChapterId = objRow[convKnowledgeLearnDetail.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnDetailEN.LearnDate = objRow[convKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objvKnowledgeLearnDetailEN.LearnModeId = objRow[convKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objvKnowledgeLearnDetailEN.LearnModeName = objRow[convKnowledgeLearnDetail.LearnModeName].ToString().Trim(); //学习模式名
objvKnowledgeLearnDetailEN.IdCase = objRow[convKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objvKnowledgeLearnDetailEN.IdCaseType = objRow[convKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objvKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[convKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objvKnowledgeLearnDetailEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnDetailEN.MarkerId = objRow[convKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objvKnowledgeLearnDetailEN.MarkTime = objRow[convKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objvKnowledgeLearnDetailEN.UpdDate = objRow[convKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnDetailEN.UpdUser = objRow[convKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnDetailEN.Memo = objRow[convKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvKnowledgeLearnDetailEN> GetSubObjLstCache(clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailCond)
{
 string strCourseId = objvKnowledgeLearnDetailCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvKnowledgeLearnDetailBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvKnowledgeLearnDetailEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvKnowledgeLearnDetailEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convKnowledgeLearnDetail.AttributeName)
{
if (objvKnowledgeLearnDetailCond.IsUpdated(strFldName) == false) continue;
if (objvKnowledgeLearnDetailCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvKnowledgeLearnDetailCond[strFldName].ToString());
}
else
{
if (objvKnowledgeLearnDetailCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvKnowledgeLearnDetailCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvKnowledgeLearnDetailCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvKnowledgeLearnDetailCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvKnowledgeLearnDetailCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvKnowledgeLearnDetailCond[strFldName]));
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
public static List<clsvKnowledgeLearnDetailEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvKnowledgeLearnDetailEN> arrObjLst = new List<clsvKnowledgeLearnDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = new clsvKnowledgeLearnDetailEN();
try
{
objvKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[convKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objvKnowledgeLearnDetailEN.UserId = objRow[convKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnDetailEN.UserName = objRow[convKnowledgeLearnDetail.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[convKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnDetailEN.KnowledgeName = objRow[convKnowledgeLearnDetail.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnDetailEN.CourseId = objRow[convKnowledgeLearnDetail.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnDetailEN.CourseName = objRow[convKnowledgeLearnDetail.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnDetailEN.CourseChapterId = objRow[convKnowledgeLearnDetail.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnDetailEN.LearnDate = objRow[convKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objvKnowledgeLearnDetailEN.LearnModeId = objRow[convKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objvKnowledgeLearnDetailEN.LearnModeName = objRow[convKnowledgeLearnDetail.LearnModeName].ToString().Trim(); //学习模式名
objvKnowledgeLearnDetailEN.IdCase = objRow[convKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objvKnowledgeLearnDetailEN.IdCaseType = objRow[convKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objvKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[convKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objvKnowledgeLearnDetailEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnDetailEN.MarkerId = objRow[convKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objvKnowledgeLearnDetailEN.MarkTime = objRow[convKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objvKnowledgeLearnDetailEN.UpdDate = objRow[convKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnDetailEN.UpdUser = objRow[convKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnDetailEN.Memo = objRow[convKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnDetailEN);
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
public static List<clsvKnowledgeLearnDetailEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvKnowledgeLearnDetailEN> arrObjLst = new List<clsvKnowledgeLearnDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = new clsvKnowledgeLearnDetailEN();
try
{
objvKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[convKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objvKnowledgeLearnDetailEN.UserId = objRow[convKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnDetailEN.UserName = objRow[convKnowledgeLearnDetail.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[convKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnDetailEN.KnowledgeName = objRow[convKnowledgeLearnDetail.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnDetailEN.CourseId = objRow[convKnowledgeLearnDetail.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnDetailEN.CourseName = objRow[convKnowledgeLearnDetail.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnDetailEN.CourseChapterId = objRow[convKnowledgeLearnDetail.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnDetailEN.LearnDate = objRow[convKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objvKnowledgeLearnDetailEN.LearnModeId = objRow[convKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objvKnowledgeLearnDetailEN.LearnModeName = objRow[convKnowledgeLearnDetail.LearnModeName].ToString().Trim(); //学习模式名
objvKnowledgeLearnDetailEN.IdCase = objRow[convKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objvKnowledgeLearnDetailEN.IdCaseType = objRow[convKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objvKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[convKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objvKnowledgeLearnDetailEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnDetailEN.MarkerId = objRow[convKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objvKnowledgeLearnDetailEN.MarkTime = objRow[convKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objvKnowledgeLearnDetailEN.UpdDate = objRow[convKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnDetailEN.UpdUser = objRow[convKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnDetailEN.Memo = objRow[convKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnDetailEN);
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
List<clsvKnowledgeLearnDetailEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvKnowledgeLearnDetailEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvKnowledgeLearnDetailEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvKnowledgeLearnDetailEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvKnowledgeLearnDetailEN> arrObjLst = new List<clsvKnowledgeLearnDetailEN>(); 
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
	clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = new clsvKnowledgeLearnDetailEN();
try
{
objvKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[convKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objvKnowledgeLearnDetailEN.UserId = objRow[convKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnDetailEN.UserName = objRow[convKnowledgeLearnDetail.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[convKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnDetailEN.KnowledgeName = objRow[convKnowledgeLearnDetail.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnDetailEN.CourseId = objRow[convKnowledgeLearnDetail.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnDetailEN.CourseName = objRow[convKnowledgeLearnDetail.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnDetailEN.CourseChapterId = objRow[convKnowledgeLearnDetail.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnDetailEN.LearnDate = objRow[convKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objvKnowledgeLearnDetailEN.LearnModeId = objRow[convKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objvKnowledgeLearnDetailEN.LearnModeName = objRow[convKnowledgeLearnDetail.LearnModeName].ToString().Trim(); //学习模式名
objvKnowledgeLearnDetailEN.IdCase = objRow[convKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objvKnowledgeLearnDetailEN.IdCaseType = objRow[convKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objvKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[convKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objvKnowledgeLearnDetailEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnDetailEN.MarkerId = objRow[convKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objvKnowledgeLearnDetailEN.MarkTime = objRow[convKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objvKnowledgeLearnDetailEN.UpdDate = objRow[convKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnDetailEN.UpdUser = objRow[convKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnDetailEN.Memo = objRow[convKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnDetailEN);
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
public static List<clsvKnowledgeLearnDetailEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvKnowledgeLearnDetailEN> arrObjLst = new List<clsvKnowledgeLearnDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = new clsvKnowledgeLearnDetailEN();
try
{
objvKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[convKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objvKnowledgeLearnDetailEN.UserId = objRow[convKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnDetailEN.UserName = objRow[convKnowledgeLearnDetail.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[convKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnDetailEN.KnowledgeName = objRow[convKnowledgeLearnDetail.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnDetailEN.CourseId = objRow[convKnowledgeLearnDetail.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnDetailEN.CourseName = objRow[convKnowledgeLearnDetail.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnDetailEN.CourseChapterId = objRow[convKnowledgeLearnDetail.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnDetailEN.LearnDate = objRow[convKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objvKnowledgeLearnDetailEN.LearnModeId = objRow[convKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objvKnowledgeLearnDetailEN.LearnModeName = objRow[convKnowledgeLearnDetail.LearnModeName].ToString().Trim(); //学习模式名
objvKnowledgeLearnDetailEN.IdCase = objRow[convKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objvKnowledgeLearnDetailEN.IdCaseType = objRow[convKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objvKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[convKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objvKnowledgeLearnDetailEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnDetailEN.MarkerId = objRow[convKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objvKnowledgeLearnDetailEN.MarkTime = objRow[convKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objvKnowledgeLearnDetailEN.UpdDate = objRow[convKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnDetailEN.UpdUser = objRow[convKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnDetailEN.Memo = objRow[convKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvKnowledgeLearnDetailEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvKnowledgeLearnDetailEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvKnowledgeLearnDetailEN> arrObjLst = new List<clsvKnowledgeLearnDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = new clsvKnowledgeLearnDetailEN();
try
{
objvKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[convKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objvKnowledgeLearnDetailEN.UserId = objRow[convKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnDetailEN.UserName = objRow[convKnowledgeLearnDetail.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[convKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnDetailEN.KnowledgeName = objRow[convKnowledgeLearnDetail.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnDetailEN.CourseId = objRow[convKnowledgeLearnDetail.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnDetailEN.CourseName = objRow[convKnowledgeLearnDetail.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnDetailEN.CourseChapterId = objRow[convKnowledgeLearnDetail.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnDetailEN.LearnDate = objRow[convKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objvKnowledgeLearnDetailEN.LearnModeId = objRow[convKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objvKnowledgeLearnDetailEN.LearnModeName = objRow[convKnowledgeLearnDetail.LearnModeName].ToString().Trim(); //学习模式名
objvKnowledgeLearnDetailEN.IdCase = objRow[convKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objvKnowledgeLearnDetailEN.IdCaseType = objRow[convKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objvKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[convKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objvKnowledgeLearnDetailEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnDetailEN.MarkerId = objRow[convKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objvKnowledgeLearnDetailEN.MarkTime = objRow[convKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objvKnowledgeLearnDetailEN.UpdDate = objRow[convKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnDetailEN.UpdUser = objRow[convKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnDetailEN.Memo = objRow[convKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnDetailEN);
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
public static List<clsvKnowledgeLearnDetailEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvKnowledgeLearnDetailEN> arrObjLst = new List<clsvKnowledgeLearnDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = new clsvKnowledgeLearnDetailEN();
try
{
objvKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[convKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objvKnowledgeLearnDetailEN.UserId = objRow[convKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnDetailEN.UserName = objRow[convKnowledgeLearnDetail.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[convKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnDetailEN.KnowledgeName = objRow[convKnowledgeLearnDetail.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnDetailEN.CourseId = objRow[convKnowledgeLearnDetail.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnDetailEN.CourseName = objRow[convKnowledgeLearnDetail.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnDetailEN.CourseChapterId = objRow[convKnowledgeLearnDetail.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnDetailEN.LearnDate = objRow[convKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objvKnowledgeLearnDetailEN.LearnModeId = objRow[convKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objvKnowledgeLearnDetailEN.LearnModeName = objRow[convKnowledgeLearnDetail.LearnModeName].ToString().Trim(); //学习模式名
objvKnowledgeLearnDetailEN.IdCase = objRow[convKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objvKnowledgeLearnDetailEN.IdCaseType = objRow[convKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objvKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[convKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objvKnowledgeLearnDetailEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnDetailEN.MarkerId = objRow[convKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objvKnowledgeLearnDetailEN.MarkTime = objRow[convKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objvKnowledgeLearnDetailEN.UpdDate = objRow[convKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnDetailEN.UpdUser = objRow[convKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnDetailEN.Memo = objRow[convKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvKnowledgeLearnDetailEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvKnowledgeLearnDetailEN> arrObjLst = new List<clsvKnowledgeLearnDetailEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = new clsvKnowledgeLearnDetailEN();
try
{
objvKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[convKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objvKnowledgeLearnDetailEN.UserId = objRow[convKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objvKnowledgeLearnDetailEN.UserName = objRow[convKnowledgeLearnDetail.UserName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.UserName].ToString().Trim(); //用户名
objvKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[convKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvKnowledgeLearnDetailEN.KnowledgeName = objRow[convKnowledgeLearnDetail.KnowledgeName].ToString().Trim(); //知识点名称
objvKnowledgeLearnDetailEN.CourseId = objRow[convKnowledgeLearnDetail.CourseId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objvKnowledgeLearnDetailEN.CourseName = objRow[convKnowledgeLearnDetail.CourseName] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.CourseName].ToString().Trim(); //课程名称
objvKnowledgeLearnDetailEN.CourseChapterId = objRow[convKnowledgeLearnDetail.CourseChapterId].ToString().Trim(); //课程章节ID
objvKnowledgeLearnDetailEN.LearnDate = objRow[convKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objvKnowledgeLearnDetailEN.LearnModeId = objRow[convKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objvKnowledgeLearnDetailEN.LearnModeName = objRow[convKnowledgeLearnDetail.LearnModeName].ToString().Trim(); //学习模式名
objvKnowledgeLearnDetailEN.IdCase = objRow[convKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objvKnowledgeLearnDetailEN.IdCaseType = objRow[convKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objvKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[convKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objvKnowledgeLearnDetailEN.MasterDegree = Int32.Parse(objRow[convKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objvKnowledgeLearnDetailEN.MarkerId = objRow[convKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objvKnowledgeLearnDetailEN.MarkTime = objRow[convKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objvKnowledgeLearnDetailEN.UpdDate = objRow[convKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objvKnowledgeLearnDetailEN.UpdUser = objRow[convKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objvKnowledgeLearnDetailEN.Memo = objRow[convKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[convKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvKnowledgeLearnDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvKnowledgeLearnDetailEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvKnowledgeLearnDetail(ref clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN)
{
bool bolResult = vKnowledgeLearnDetailDA.GetvKnowledgeLearnDetail(ref objvKnowledgeLearnDetailEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvKnowledgeLearnDetailEN GetObjBymId(long lngmId)
{
clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = vKnowledgeLearnDetailDA.GetObjBymId(lngmId);
return objvKnowledgeLearnDetailEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvKnowledgeLearnDetailEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = vKnowledgeLearnDetailDA.GetFirstObj(strWhereCond);
 return objvKnowledgeLearnDetailEN;
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
public static clsvKnowledgeLearnDetailEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = vKnowledgeLearnDetailDA.GetObjByDataRow(objRow);
 return objvKnowledgeLearnDetailEN;
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
public static clsvKnowledgeLearnDetailEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = vKnowledgeLearnDetailDA.GetObjByDataRow(objRow);
 return objvKnowledgeLearnDetailEN;
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
 /// <param name = "lstvKnowledgeLearnDetailObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvKnowledgeLearnDetailEN GetObjBymIdFromList(long lngmId, List<clsvKnowledgeLearnDetailEN> lstvKnowledgeLearnDetailObjLst)
{
foreach (clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN in lstvKnowledgeLearnDetailObjLst)
{
if (objvKnowledgeLearnDetailEN.mId == lngmId)
{
return objvKnowledgeLearnDetailEN;
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
 lngmId = new clsvKnowledgeLearnDetailDA().GetFirstID(strWhereCond);
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
 arrList = vKnowledgeLearnDetailDA.GetID(strWhereCond);
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
bool bolIsExist = vKnowledgeLearnDetailDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vKnowledgeLearnDetailDA.IsExist(lngmId);
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
 bolIsExist = clsvKnowledgeLearnDetailDA.IsExistTable();
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
 bolIsExist = vKnowledgeLearnDetailDA.IsExistTable(strTabName);
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
 /// <param name = "objvKnowledgeLearnDetailENS">源对象</param>
 /// <param name = "objvKnowledgeLearnDetailENT">目标对象</param>
 public static void CopyTo(clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailENS, clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailENT)
{
try
{
objvKnowledgeLearnDetailENT.mId = objvKnowledgeLearnDetailENS.mId; //mId
objvKnowledgeLearnDetailENT.UserId = objvKnowledgeLearnDetailENS.UserId; //用户ID
objvKnowledgeLearnDetailENT.UserName = objvKnowledgeLearnDetailENS.UserName; //用户名
objvKnowledgeLearnDetailENT.CourseKnowledgeId = objvKnowledgeLearnDetailENS.CourseKnowledgeId; //知识点Id
objvKnowledgeLearnDetailENT.KnowledgeName = objvKnowledgeLearnDetailENS.KnowledgeName; //知识点名称
objvKnowledgeLearnDetailENT.CourseId = objvKnowledgeLearnDetailENS.CourseId; //课程Id
objvKnowledgeLearnDetailENT.CourseName = objvKnowledgeLearnDetailENS.CourseName; //课程名称
objvKnowledgeLearnDetailENT.CourseChapterId = objvKnowledgeLearnDetailENS.CourseChapterId; //课程章节ID
objvKnowledgeLearnDetailENT.LearnDate = objvKnowledgeLearnDetailENS.LearnDate; //学习日期
objvKnowledgeLearnDetailENT.LearnModeId = objvKnowledgeLearnDetailENS.LearnModeId; //学习模式Id
objvKnowledgeLearnDetailENT.LearnModeName = objvKnowledgeLearnDetailENS.LearnModeName; //学习模式名
objvKnowledgeLearnDetailENT.IdCase = objvKnowledgeLearnDetailENS.IdCase; //案例流水号
objvKnowledgeLearnDetailENT.IdCaseType = objvKnowledgeLearnDetailENS.IdCaseType; //案例类型流水号
objvKnowledgeLearnDetailENT.IsMaster = objvKnowledgeLearnDetailENS.IsMaster; //是否掌握
objvKnowledgeLearnDetailENT.MasterDegree = objvKnowledgeLearnDetailENS.MasterDegree; //掌握程度
objvKnowledgeLearnDetailENT.MarkerId = objvKnowledgeLearnDetailENS.MarkerId; //打分者
objvKnowledgeLearnDetailENT.MarkTime = objvKnowledgeLearnDetailENS.MarkTime; //批改时间
objvKnowledgeLearnDetailENT.UpdDate = objvKnowledgeLearnDetailENS.UpdDate; //修改日期
objvKnowledgeLearnDetailENT.UpdUser = objvKnowledgeLearnDetailENS.UpdUser; //修改人
objvKnowledgeLearnDetailENT.Memo = objvKnowledgeLearnDetailENS.Memo; //备注
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
 /// <param name = "objvKnowledgeLearnDetailEN">源简化对象</param>
 public static void SetUpdFlag(clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN)
{
try
{
objvKnowledgeLearnDetailEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvKnowledgeLearnDetailEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convKnowledgeLearnDetail.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.mId = objvKnowledgeLearnDetailEN.mId; //mId
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.UserId = objvKnowledgeLearnDetailEN.UserId == "[null]" ? null :  objvKnowledgeLearnDetailEN.UserId; //用户ID
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.UserName = objvKnowledgeLearnDetailEN.UserName == "[null]" ? null :  objvKnowledgeLearnDetailEN.UserName; //用户名
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.CourseKnowledgeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.CourseKnowledgeId = objvKnowledgeLearnDetailEN.CourseKnowledgeId == "[null]" ? null :  objvKnowledgeLearnDetailEN.CourseKnowledgeId; //知识点Id
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.KnowledgeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.KnowledgeName = objvKnowledgeLearnDetailEN.KnowledgeName; //知识点名称
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.CourseId = objvKnowledgeLearnDetailEN.CourseId == "[null]" ? null :  objvKnowledgeLearnDetailEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.CourseName = objvKnowledgeLearnDetailEN.CourseName == "[null]" ? null :  objvKnowledgeLearnDetailEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.CourseChapterId = objvKnowledgeLearnDetailEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.LearnDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.LearnDate = objvKnowledgeLearnDetailEN.LearnDate; //学习日期
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.LearnModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.LearnModeId = objvKnowledgeLearnDetailEN.LearnModeId; //学习模式Id
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.LearnModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.LearnModeName = objvKnowledgeLearnDetailEN.LearnModeName; //学习模式名
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.IdCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.IdCase = objvKnowledgeLearnDetailEN.IdCase; //案例流水号
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.IdCaseType = objvKnowledgeLearnDetailEN.IdCaseType == "[null]" ? null :  objvKnowledgeLearnDetailEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.IsMaster, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.IsMaster = objvKnowledgeLearnDetailEN.IsMaster; //是否掌握
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.MasterDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.MasterDegree = objvKnowledgeLearnDetailEN.MasterDegree; //掌握程度
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.MarkerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.MarkerId = objvKnowledgeLearnDetailEN.MarkerId == "[null]" ? null :  objvKnowledgeLearnDetailEN.MarkerId; //打分者
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.MarkTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.MarkTime = objvKnowledgeLearnDetailEN.MarkTime == "[null]" ? null :  objvKnowledgeLearnDetailEN.MarkTime; //批改时间
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.UpdDate = objvKnowledgeLearnDetailEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.UpdUser = objvKnowledgeLearnDetailEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convKnowledgeLearnDetail.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvKnowledgeLearnDetailEN.Memo = objvKnowledgeLearnDetailEN.Memo == "[null]" ? null :  objvKnowledgeLearnDetailEN.Memo; //备注
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
 /// <param name = "objvKnowledgeLearnDetailEN">源简化对象</param>
 public static void AccessFldValueNull(clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN)
{
try
{
if (objvKnowledgeLearnDetailEN.UserId == "[null]") objvKnowledgeLearnDetailEN.UserId = null; //用户ID
if (objvKnowledgeLearnDetailEN.UserName == "[null]") objvKnowledgeLearnDetailEN.UserName = null; //用户名
if (objvKnowledgeLearnDetailEN.CourseKnowledgeId == "[null]") objvKnowledgeLearnDetailEN.CourseKnowledgeId = null; //知识点Id
if (objvKnowledgeLearnDetailEN.CourseId == "[null]") objvKnowledgeLearnDetailEN.CourseId = null; //课程Id
if (objvKnowledgeLearnDetailEN.CourseName == "[null]") objvKnowledgeLearnDetailEN.CourseName = null; //课程名称
if (objvKnowledgeLearnDetailEN.IdCaseType == "[null]") objvKnowledgeLearnDetailEN.IdCaseType = null; //案例类型流水号
if (objvKnowledgeLearnDetailEN.MarkerId == "[null]") objvKnowledgeLearnDetailEN.MarkerId = null; //打分者
if (objvKnowledgeLearnDetailEN.MarkTime == "[null]") objvKnowledgeLearnDetailEN.MarkTime = null; //批改时间
if (objvKnowledgeLearnDetailEN.Memo == "[null]") objvKnowledgeLearnDetailEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN)
{
 vKnowledgeLearnDetailDA.CheckProperty4Condition(objvKnowledgeLearnDetailEN);
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
if (clsKnowledgeLearnDetailBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsKnowledgeLearnDetailBL没有刷新缓存机制(clsKnowledgeLearnDetailBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsLearnModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsLearnModeBL没有刷新缓存机制(clsLearnModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvKnowledgeLearnDetailObjLstCache == null)
//{
//arrvKnowledgeLearnDetailObjLstCache = vKnowledgeLearnDetailDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvKnowledgeLearnDetailEN GetObjBymIdCache(long lngmId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvKnowledgeLearnDetailEN._CurrTabName, strCourseId);
List<clsvKnowledgeLearnDetailEN> arrvKnowledgeLearnDetailObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvKnowledgeLearnDetailEN> arrvKnowledgeLearnDetailObjLst_Sel =
arrvKnowledgeLearnDetailObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvKnowledgeLearnDetailObjLst_Sel.Count() == 0)
{
   clsvKnowledgeLearnDetailEN obj = clsvKnowledgeLearnDetailBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvKnowledgeLearnDetailObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvKnowledgeLearnDetailEN> GetAllvKnowledgeLearnDetailObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvKnowledgeLearnDetailEN> arrvKnowledgeLearnDetailObjLstCache = GetObjLstCache(strCourseId); 
return arrvKnowledgeLearnDetailObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvKnowledgeLearnDetailEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvKnowledgeLearnDetailEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvKnowledgeLearnDetailEN> arrvKnowledgeLearnDetailObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvKnowledgeLearnDetailObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvKnowledgeLearnDetailEN._CurrTabName, strCourseId);
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
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strCourseId)
{
if (strInFldName != convKnowledgeLearnDetail.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convKnowledgeLearnDetail.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convKnowledgeLearnDetail.AttributeName));
throw new Exception(strMsg);
}
var objvKnowledgeLearnDetail = clsvKnowledgeLearnDetailBL.GetObjBymIdCache(lngmId, strCourseId);
if (objvKnowledgeLearnDetail == null) return "";
return objvKnowledgeLearnDetail[strOutFldName].ToString();
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
int intRecCount = clsvKnowledgeLearnDetailDA.GetRecCount(strTabName);
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
int intRecCount = clsvKnowledgeLearnDetailDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvKnowledgeLearnDetailDA.GetRecCount();
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
int intRecCount = clsvKnowledgeLearnDetailDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailCond)
{
 string strCourseId = objvKnowledgeLearnDetailCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvKnowledgeLearnDetailBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvKnowledgeLearnDetailEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvKnowledgeLearnDetailEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convKnowledgeLearnDetail.AttributeName)
{
if (objvKnowledgeLearnDetailCond.IsUpdated(strFldName) == false) continue;
if (objvKnowledgeLearnDetailCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvKnowledgeLearnDetailCond[strFldName].ToString());
}
else
{
if (objvKnowledgeLearnDetailCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvKnowledgeLearnDetailCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvKnowledgeLearnDetailCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvKnowledgeLearnDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvKnowledgeLearnDetailCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvKnowledgeLearnDetailCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvKnowledgeLearnDetailCond[strFldName]));
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
 List<string> arrList = clsvKnowledgeLearnDetailDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vKnowledgeLearnDetailDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vKnowledgeLearnDetailDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}