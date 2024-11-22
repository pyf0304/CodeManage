
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvKnowledgeLearnDetailWApi
 表名:vKnowledgeLearnDetail(01120157)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:17
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
public static class clsvKnowledgeLearnDetailWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetUserId(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convKnowledgeLearnDetail.UserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetUserName(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convKnowledgeLearnDetail.UserName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetCourseKnowledgeId(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, convKnowledgeLearnDetail.CourseKnowledgeId);
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, convKnowledgeLearnDetail.CourseKnowledgeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetKnowledgeName(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strKnowledgeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKnowledgeName, convKnowledgeLearnDetail.KnowledgeName);
clsCheckSql.CheckFieldLen(strKnowledgeName, 100, convKnowledgeLearnDetail.KnowledgeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetCourseId(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convKnowledgeLearnDetail.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convKnowledgeLearnDetail.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetCourseName(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convKnowledgeLearnDetail.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetCourseChapterId(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convKnowledgeLearnDetail.CourseChapterId);
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convKnowledgeLearnDetail.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convKnowledgeLearnDetail.CourseChapterId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetLearnDate(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strLearnDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLearnDate, convKnowledgeLearnDetail.LearnDate);
clsCheckSql.CheckFieldLen(strLearnDate, 14, convKnowledgeLearnDetail.LearnDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetLearnModeId(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strLearnModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLearnModeId, convKnowledgeLearnDetail.LearnModeId);
clsCheckSql.CheckFieldLen(strLearnModeId, 4, convKnowledgeLearnDetail.LearnModeId);
clsCheckSql.CheckFieldForeignKey(strLearnModeId, 4, convKnowledgeLearnDetail.LearnModeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetLearnModeName(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strLearnModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLearnModeName, convKnowledgeLearnDetail.LearnModeName);
clsCheckSql.CheckFieldLen(strLearnModeName, 30, convKnowledgeLearnDetail.LearnModeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetId_Case(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strId_Case, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_Case, convKnowledgeLearnDetail.Id_Case);
clsCheckSql.CheckFieldLen(strId_Case, 8, convKnowledgeLearnDetail.Id_Case);
clsCheckSql.CheckFieldForeignKey(strId_Case, 8, convKnowledgeLearnDetail.Id_Case);
objvKnowledgeLearnDetailEN.Id_Case = strId_Case; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.Id_Case) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.Id_Case, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.Id_Case] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetId_CaseType(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, convKnowledgeLearnDetail.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, convKnowledgeLearnDetail.Id_CaseType);
objvKnowledgeLearnDetailEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(convKnowledgeLearnDetail.Id_CaseType) == false)
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp.Add(convKnowledgeLearnDetail.Id_CaseType, strComparisonOp);
}
else
{
objvKnowledgeLearnDetailEN.dicFldComparisonOp[convKnowledgeLearnDetail.Id_CaseType] = strComparisonOp;
}
}
return objvKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetMarkerId(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strMarkerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkerId, 20, convKnowledgeLearnDetail.MarkerId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetMarkTime(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strMarkTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkTime, 14, convKnowledgeLearnDetail.MarkTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetUpdDate(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convKnowledgeLearnDetail.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convKnowledgeLearnDetail.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetUpdUser(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convKnowledgeLearnDetail.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convKnowledgeLearnDetail.UpdUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvKnowledgeLearnDetailEN SetMemo(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convKnowledgeLearnDetail.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetail_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.mId) == true)
{
string strComparisonOp_mId = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convKnowledgeLearnDetail.mId, objvKnowledgeLearnDetail_Cond.mId, strComparisonOp_mId);
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.UserId) == true)
{
string strComparisonOp_UserId = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.UserId, objvKnowledgeLearnDetail_Cond.UserId, strComparisonOp_UserId);
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.UserName) == true)
{
string strComparisonOp_UserName = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.UserName, objvKnowledgeLearnDetail_Cond.UserName, strComparisonOp_UserName);
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.CourseKnowledgeId) == true)
{
string strComparisonOp_CourseKnowledgeId = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.CourseKnowledgeId, objvKnowledgeLearnDetail_Cond.CourseKnowledgeId, strComparisonOp_CourseKnowledgeId);
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.KnowledgeName) == true)
{
string strComparisonOp_KnowledgeName = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.KnowledgeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.KnowledgeName, objvKnowledgeLearnDetail_Cond.KnowledgeName, strComparisonOp_KnowledgeName);
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.CourseId) == true)
{
string strComparisonOp_CourseId = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.CourseId, objvKnowledgeLearnDetail_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.CourseName) == true)
{
string strComparisonOp_CourseName = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.CourseName, objvKnowledgeLearnDetail_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.CourseChapterId, objvKnowledgeLearnDetail_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.LearnDate) == true)
{
string strComparisonOp_LearnDate = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.LearnDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.LearnDate, objvKnowledgeLearnDetail_Cond.LearnDate, strComparisonOp_LearnDate);
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.LearnModeId) == true)
{
string strComparisonOp_LearnModeId = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.LearnModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.LearnModeId, objvKnowledgeLearnDetail_Cond.LearnModeId, strComparisonOp_LearnModeId);
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.LearnModeName) == true)
{
string strComparisonOp_LearnModeName = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.LearnModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.LearnModeName, objvKnowledgeLearnDetail_Cond.LearnModeName, strComparisonOp_LearnModeName);
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.Id_Case) == true)
{
string strComparisonOp_Id_Case = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.Id_Case];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.Id_Case, objvKnowledgeLearnDetail_Cond.Id_Case, strComparisonOp_Id_Case);
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.Id_CaseType, objvKnowledgeLearnDetail_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.IsMaster) == true)
{
if (objvKnowledgeLearnDetail_Cond.IsMaster == true)
{
strWhereCond += string.Format(" And {0} = '1'", convKnowledgeLearnDetail.IsMaster);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convKnowledgeLearnDetail.IsMaster);
}
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.MasterDegree) == true)
{
string strComparisonOp_MasterDegree = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.MasterDegree];
strWhereCond += string.Format(" And {0} {2} {1}", convKnowledgeLearnDetail.MasterDegree, objvKnowledgeLearnDetail_Cond.MasterDegree, strComparisonOp_MasterDegree);
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.MarkerId) == true)
{
string strComparisonOp_MarkerId = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.MarkerId, objvKnowledgeLearnDetail_Cond.MarkerId, strComparisonOp_MarkerId);
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.MarkTime) == true)
{
string strComparisonOp_MarkTime = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.MarkTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.MarkTime, objvKnowledgeLearnDetail_Cond.MarkTime, strComparisonOp_MarkTime);
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.UpdDate, objvKnowledgeLearnDetail_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.UpdUser, objvKnowledgeLearnDetail_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvKnowledgeLearnDetail_Cond.IsUpdated(convKnowledgeLearnDetail.Memo) == true)
{
string strComparisonOp_Memo = objvKnowledgeLearnDetail_Cond.dicFldComparisonOp[convKnowledgeLearnDetail.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convKnowledgeLearnDetail.Memo, objvKnowledgeLearnDetail_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v知识点学习情况(vKnowledgeLearnDetail)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvKnowledgeLearnDetailWApi
{
private static readonly string mstrApiControllerName = "vKnowledgeLearnDetailApi";

 public clsvKnowledgeLearnDetailWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvKnowledgeLearnDetailEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = null;
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
objvKnowledgeLearnDetailEN = JsonConvert.DeserializeObject<clsvKnowledgeLearnDetailEN>((string)jobjReturn["ReturnObj"]);
return objvKnowledgeLearnDetailEN;
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
public static clsvKnowledgeLearnDetailEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = null;
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
objvKnowledgeLearnDetailEN = JsonConvert.DeserializeObject<clsvKnowledgeLearnDetailEN>((string)jobjReturn["ReturnObj"]);
return objvKnowledgeLearnDetailEN;
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
public static clsvKnowledgeLearnDetailEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvKnowledgeLearnDetailEN objvKnowledgeLearnDetailEN = null;
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
objvKnowledgeLearnDetailEN = JsonConvert.DeserializeObject<clsvKnowledgeLearnDetailEN>((string)jobjReturn["ReturnObj"]);
return objvKnowledgeLearnDetailEN;
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
public static clsvKnowledgeLearnDetailEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvKnowledgeLearnDetailEN._CurrTabName_S);
List<clsvKnowledgeLearnDetailEN> arrvKnowledgeLearnDetailObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvKnowledgeLearnDetailEN> arrvKnowledgeLearnDetailObjLst_Sel =
from objvKnowledgeLearnDetailEN in arrvKnowledgeLearnDetailObjLst_Cache
where objvKnowledgeLearnDetailEN.mId == lngmId
select objvKnowledgeLearnDetailEN;
if (arrvKnowledgeLearnDetailObjLst_Sel.Count() == 0)
{
   clsvKnowledgeLearnDetailEN obj = clsvKnowledgeLearnDetailWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvKnowledgeLearnDetailObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvKnowledgeLearnDetailEN> GetObjLst(string strWhereCond)
{
 List<clsvKnowledgeLearnDetailEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvKnowledgeLearnDetailEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvKnowledgeLearnDetailEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvKnowledgeLearnDetailEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvKnowledgeLearnDetailEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvKnowledgeLearnDetailEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvKnowledgeLearnDetailEN._CurrTabName_S);
List<clsvKnowledgeLearnDetailEN> arrvKnowledgeLearnDetailObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvKnowledgeLearnDetailEN> arrvKnowledgeLearnDetailObjLst_Sel =
from objvKnowledgeLearnDetailEN in arrvKnowledgeLearnDetailObjLst_Cache
where arrMId.Contains(objvKnowledgeLearnDetailEN.mId)
select objvKnowledgeLearnDetailEN;
return arrvKnowledgeLearnDetailObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvKnowledgeLearnDetailEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvKnowledgeLearnDetailEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvKnowledgeLearnDetailEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvKnowledgeLearnDetailEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvKnowledgeLearnDetailEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvKnowledgeLearnDetailEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvKnowledgeLearnDetailEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvKnowledgeLearnDetailEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvKnowledgeLearnDetailEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvKnowledgeLearnDetailEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvKnowledgeLearnDetailEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvKnowledgeLearnDetailEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvKnowledgeLearnDetailEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvKnowledgeLearnDetailEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvKnowledgeLearnDetailEN>>((string)jobjReturn["ReturnObjLst"]);
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
objvKnowledgeLearnDetailENT.Id_Case = objvKnowledgeLearnDetailENS.Id_Case; //案例流水号
objvKnowledgeLearnDetailENT.Id_CaseType = objvKnowledgeLearnDetailENS.Id_CaseType; //案例类型流水号
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
public static DataTable ToDataTable(List<clsvKnowledgeLearnDetailEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvKnowledgeLearnDetailEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvKnowledgeLearnDetailEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvKnowledgeLearnDetailEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvKnowledgeLearnDetailEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvKnowledgeLearnDetailEN.AttributeName)
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
if (clsKnowledgeLearnDetailWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsKnowledgeLearnDetailWApi没有刷新缓存机制(clsKnowledgeLearnDetailWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsLearnModeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsLearnModeWApi没有刷新缓存机制(clsLearnModeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvKnowledgeLearnDetailObjLst_Cache == null)
//{
//arrvKnowledgeLearnDetailObjLst_Cache = await clsvKnowledgeLearnDetailWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvKnowledgeLearnDetailEN._CurrTabName_S);
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
public static List<clsvKnowledgeLearnDetailEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvKnowledgeLearnDetailEN._CurrTabName_S);
List<clsvKnowledgeLearnDetailEN> arrvKnowledgeLearnDetailObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvKnowledgeLearnDetailObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvKnowledgeLearnDetailEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convKnowledgeLearnDetail.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convKnowledgeLearnDetail.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnDetail.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnDetail.CourseKnowledgeId, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnDetail.KnowledgeName, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnDetail.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnDetail.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnDetail.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnDetail.LearnDate, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnDetail.LearnModeId, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnDetail.LearnModeName, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnDetail.Id_Case, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnDetail.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnDetail.IsMaster, Type.GetType("System.Boolean"));
objDT.Columns.Add(convKnowledgeLearnDetail.MasterDegree, Type.GetType("System.Int32"));
objDT.Columns.Add(convKnowledgeLearnDetail.MarkerId, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnDetail.MarkTime, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnDetail.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnDetail.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convKnowledgeLearnDetail.Memo, Type.GetType("System.String"));
foreach (clsvKnowledgeLearnDetailEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convKnowledgeLearnDetail.mId] = objInFor[convKnowledgeLearnDetail.mId];
objDR[convKnowledgeLearnDetail.UserId] = objInFor[convKnowledgeLearnDetail.UserId];
objDR[convKnowledgeLearnDetail.UserName] = objInFor[convKnowledgeLearnDetail.UserName];
objDR[convKnowledgeLearnDetail.CourseKnowledgeId] = objInFor[convKnowledgeLearnDetail.CourseKnowledgeId];
objDR[convKnowledgeLearnDetail.KnowledgeName] = objInFor[convKnowledgeLearnDetail.KnowledgeName];
objDR[convKnowledgeLearnDetail.CourseId] = objInFor[convKnowledgeLearnDetail.CourseId];
objDR[convKnowledgeLearnDetail.CourseName] = objInFor[convKnowledgeLearnDetail.CourseName];
objDR[convKnowledgeLearnDetail.CourseChapterId] = objInFor[convKnowledgeLearnDetail.CourseChapterId];
objDR[convKnowledgeLearnDetail.LearnDate] = objInFor[convKnowledgeLearnDetail.LearnDate];
objDR[convKnowledgeLearnDetail.LearnModeId] = objInFor[convKnowledgeLearnDetail.LearnModeId];
objDR[convKnowledgeLearnDetail.LearnModeName] = objInFor[convKnowledgeLearnDetail.LearnModeName];
objDR[convKnowledgeLearnDetail.Id_Case] = objInFor[convKnowledgeLearnDetail.Id_Case];
objDR[convKnowledgeLearnDetail.Id_CaseType] = objInFor[convKnowledgeLearnDetail.Id_CaseType];
objDR[convKnowledgeLearnDetail.IsMaster] = objInFor[convKnowledgeLearnDetail.IsMaster];
objDR[convKnowledgeLearnDetail.MasterDegree] = objInFor[convKnowledgeLearnDetail.MasterDegree];
objDR[convKnowledgeLearnDetail.MarkerId] = objInFor[convKnowledgeLearnDetail.MarkerId];
objDR[convKnowledgeLearnDetail.MarkTime] = objInFor[convKnowledgeLearnDetail.MarkTime];
objDR[convKnowledgeLearnDetail.UpdDate] = objInFor[convKnowledgeLearnDetail.UpdDate];
objDR[convKnowledgeLearnDetail.UpdUser] = objInFor[convKnowledgeLearnDetail.UpdUser];
objDR[convKnowledgeLearnDetail.Memo] = objInFor[convKnowledgeLearnDetail.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}