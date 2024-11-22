
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseCourseKnowledgeRelaWApi
 表名:vCaseCourseKnowledgeRela(01120393)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:17
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
public static class clsvCaseCourseKnowledgeRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN Setid_CaseCourseKnowledgeRela(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, long lngid_CaseCourseKnowledgeRela, string strComparisonOp="")
	{
objvCaseCourseKnowledgeRelaEN.id_CaseCourseKnowledgeRela = lngid_CaseCourseKnowledgeRela; //案例知识点关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRela) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRela, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRela] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetFuncModuleId(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCaseCourseKnowledgeRela.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCaseCourseKnowledgeRela.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCaseCourseKnowledgeRela.FuncModuleId);
objvCaseCourseKnowledgeRelaEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.FuncModuleId) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.FuncModuleId, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.FuncModuleId] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetFuncModuleName(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convCaseCourseKnowledgeRela.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCaseCourseKnowledgeRela.FuncModuleName);
objvCaseCourseKnowledgeRelaEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.FuncModuleName) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.FuncModuleName, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.FuncModuleName] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetCaseId(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strCaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseId, 8, convCaseCourseKnowledgeRela.CaseId);
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, convCaseCourseKnowledgeRela.CaseId);
objvCaseCourseKnowledgeRelaEN.CaseId = strCaseId; //案例Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.CaseId) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.CaseId, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.CaseId] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetCaseName(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseName, 100, convCaseCourseKnowledgeRela.CaseName);
objvCaseCourseKnowledgeRelaEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.CaseName) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.CaseName, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.CaseName] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetOwnerId(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convCaseCourseKnowledgeRela.OwnerId);
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCaseCourseKnowledgeRela.OwnerId);
objvCaseCourseKnowledgeRelaEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.OwnerId) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.OwnerId, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.OwnerId] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetOwnerName(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCaseCourseKnowledgeRela.OwnerName);
objvCaseCourseKnowledgeRelaEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.OwnerName) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.OwnerName, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.OwnerName] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetCourseKnowledgeId(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, convCaseCourseKnowledgeRela.CourseKnowledgeId);
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, convCaseCourseKnowledgeRela.CourseKnowledgeId);
objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = strCourseKnowledgeId; //知识点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.CourseKnowledgeId) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.CourseKnowledgeId, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.CourseKnowledgeId] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetKnowledgeName(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strKnowledgeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKnowledgeName, 100, convCaseCourseKnowledgeRela.KnowledgeName);
objvCaseCourseKnowledgeRelaEN.KnowledgeName = strKnowledgeName; //知识点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.KnowledgeName) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.KnowledgeName, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.KnowledgeName] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetKnowledgeTitle(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strKnowledgeTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKnowledgeTitle, 100, convCaseCourseKnowledgeRela.KnowledgeTitle);
objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = strKnowledgeTitle; //知识点标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.KnowledgeTitle) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.KnowledgeTitle, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.KnowledgeTitle] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetKnowledgeContent(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strKnowledgeContent, string strComparisonOp="")
	{
objvCaseCourseKnowledgeRelaEN.KnowledgeContent = strKnowledgeContent; //知识点内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.KnowledgeContent) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.KnowledgeContent, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.KnowledgeContent] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetRelationsDegree(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, int intRelationsDegree, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intRelationsDegree, convCaseCourseKnowledgeRela.RelationsDegree);
objvCaseCourseKnowledgeRelaEN.RelationsDegree = intRelationsDegree; //关系度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.RelationsDegree) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.RelationsDegree, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.RelationsDegree] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetCourseId(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCaseCourseKnowledgeRela.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCaseCourseKnowledgeRela.CourseId);
objvCaseCourseKnowledgeRelaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.CourseId) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.CourseId, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.CourseId] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetCourseName(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCaseCourseKnowledgeRela.CourseName);
objvCaseCourseKnowledgeRelaEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.CourseName) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.CourseName, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.CourseName] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetCourseChapterId(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCaseCourseKnowledgeRela.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCaseCourseKnowledgeRela.CourseChapterId);
objvCaseCourseKnowledgeRelaEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.CourseChapterId) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.CourseChapterId, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.CourseChapterId] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN Setid_CaseCourseKnowledgeRelaType(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strid_CaseCourseKnowledgeRelaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CaseCourseKnowledgeRelaType, convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType);
clsCheckSql.CheckFieldLen(strid_CaseCourseKnowledgeRelaType, 4, convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType);
clsCheckSql.CheckFieldForeignKey(strid_CaseCourseKnowledgeRelaType, 4, convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType);
objvCaseCourseKnowledgeRelaEN.id_CaseCourseKnowledgeRelaType = strid_CaseCourseKnowledgeRelaType; //案例知识点关系类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetCaseCourseKnowledgeRelaTypeName(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strCaseCourseKnowledgeRelaTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseCourseKnowledgeRelaTypeName, convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName);
clsCheckSql.CheckFieldLen(strCaseCourseKnowledgeRelaTypeName, 50, convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName);
objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName = strCaseCourseKnowledgeRelaTypeName; //案例知识点关系类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetBrowseCount(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, int intBrowseCount, string strComparisonOp="")
	{
objvCaseCourseKnowledgeRelaEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.BrowseCount) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.BrowseCount, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.BrowseCount] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetOrderNum(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, int intOrderNum, string strComparisonOp="")
	{
objvCaseCourseKnowledgeRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.OrderNum) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.OrderNum, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.OrderNum] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetUpdDate(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCaseCourseKnowledgeRela.UpdDate);
objvCaseCourseKnowledgeRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.UpdDate) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.UpdDate, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.UpdDate] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetUpdUserId(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convCaseCourseKnowledgeRela.UpdUserId);
objvCaseCourseKnowledgeRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.UpdUserId) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.UpdUserId, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.UpdUserId] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetMemo(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCaseCourseKnowledgeRela.Memo);
objvCaseCourseKnowledgeRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.Memo) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.Memo, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.Memo] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRela) == true)
{
string strComparisonOp_id_CaseCourseKnowledgeRela = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRela];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRela, objvCaseCourseKnowledgeRela_Cond.id_CaseCourseKnowledgeRela, strComparisonOp_id_CaseCourseKnowledgeRela);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.FuncModuleId, objvCaseCourseKnowledgeRela_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.FuncModuleName, objvCaseCourseKnowledgeRela_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.CaseId) == true)
{
string strComparisonOp_CaseId = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.CaseId, objvCaseCourseKnowledgeRela_Cond.CaseId, strComparisonOp_CaseId);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.CaseName) == true)
{
string strComparisonOp_CaseName = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.CaseName, objvCaseCourseKnowledgeRela_Cond.CaseName, strComparisonOp_CaseName);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.OwnerId, objvCaseCourseKnowledgeRela_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.OwnerName, objvCaseCourseKnowledgeRela_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.CourseKnowledgeId) == true)
{
string strComparisonOp_CourseKnowledgeId = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.CourseKnowledgeId, objvCaseCourseKnowledgeRela_Cond.CourseKnowledgeId, strComparisonOp_CourseKnowledgeId);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.KnowledgeName) == true)
{
string strComparisonOp_KnowledgeName = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.KnowledgeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.KnowledgeName, objvCaseCourseKnowledgeRela_Cond.KnowledgeName, strComparisonOp_KnowledgeName);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.KnowledgeTitle) == true)
{
string strComparisonOp_KnowledgeTitle = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.KnowledgeTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.KnowledgeTitle, objvCaseCourseKnowledgeRela_Cond.KnowledgeTitle, strComparisonOp_KnowledgeTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.RelationsDegree) == true)
{
string strComparisonOp_RelationsDegree = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.RelationsDegree];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCourseKnowledgeRela.RelationsDegree, objvCaseCourseKnowledgeRela_Cond.RelationsDegree, strComparisonOp_RelationsDegree);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.CourseId) == true)
{
string strComparisonOp_CourseId = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.CourseId, objvCaseCourseKnowledgeRela_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.CourseName) == true)
{
string strComparisonOp_CourseName = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.CourseName, objvCaseCourseKnowledgeRela_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.CourseChapterId, objvCaseCourseKnowledgeRela_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType) == true)
{
string strComparisonOp_id_CaseCourseKnowledgeRelaType = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType, objvCaseCourseKnowledgeRela_Cond.id_CaseCourseKnowledgeRelaType, strComparisonOp_id_CaseCourseKnowledgeRelaType);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName) == true)
{
string strComparisonOp_CaseCourseKnowledgeRelaTypeName = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName, objvCaseCourseKnowledgeRela_Cond.CaseCourseKnowledgeRelaTypeName, strComparisonOp_CaseCourseKnowledgeRelaTypeName);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCourseKnowledgeRela.BrowseCount, objvCaseCourseKnowledgeRela_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCourseKnowledgeRela.OrderNum, objvCaseCourseKnowledgeRela_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.UpdDate, objvCaseCourseKnowledgeRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.UpdUserId, objvCaseCourseKnowledgeRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvCaseCourseKnowledgeRela_Cond.IsUpdated(convCaseCourseKnowledgeRela.Memo) == true)
{
string strComparisonOp_Memo = objvCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[convCaseCourseKnowledgeRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.Memo, objvCaseCourseKnowledgeRela_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v案例知识点关系(vCaseCourseKnowledgeRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCaseCourseKnowledgeRelaWApi
{
private static readonly string mstrApiControllerName = "vCaseCourseKnowledgeRelaApi";

 public clsvCaseCourseKnowledgeRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_CaseCourseKnowledgeRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseCourseKnowledgeRelaEN GetObjByid_CaseCourseKnowledgeRela(long lngid_CaseCourseKnowledgeRela)
{
string strAction = "GetObjByid_CaseCourseKnowledgeRela";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseCourseKnowledgeRela"] = lngid_CaseCourseKnowledgeRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCaseCourseKnowledgeRelaEN = JsonConvert.DeserializeObject<clsvCaseCourseKnowledgeRelaEN>((string)jobjReturn["ReturnObj"]);
return objvCaseCourseKnowledgeRelaEN;
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
 /// <param name = "lngid_CaseCourseKnowledgeRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseCourseKnowledgeRelaEN GetObjByid_CaseCourseKnowledgeRela_WA_Cache(long lngid_CaseCourseKnowledgeRela)
{
string strAction = "GetObjByid_CaseCourseKnowledgeRela_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseCourseKnowledgeRela"] = lngid_CaseCourseKnowledgeRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCaseCourseKnowledgeRelaEN = JsonConvert.DeserializeObject<clsvCaseCourseKnowledgeRelaEN>((string)jobjReturn["ReturnObj"]);
return objvCaseCourseKnowledgeRelaEN;
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
public static clsvCaseCourseKnowledgeRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = null;
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
objvCaseCourseKnowledgeRelaEN = JsonConvert.DeserializeObject<clsvCaseCourseKnowledgeRelaEN>((string)jobjReturn["ReturnObj"]);
return objvCaseCourseKnowledgeRelaEN;
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
 /// <param name = "lngid_CaseCourseKnowledgeRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseCourseKnowledgeRelaEN GetObjByid_CaseCourseKnowledgeRela_Cache(long lngid_CaseCourseKnowledgeRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCaseCourseKnowledgeRelaEN._CurrTabName_S);
List<clsvCaseCourseKnowledgeRelaEN> arrvCaseCourseKnowledgeRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCaseCourseKnowledgeRelaEN> arrvCaseCourseKnowledgeRelaObjLst_Sel =
from objvCaseCourseKnowledgeRelaEN in arrvCaseCourseKnowledgeRelaObjLst_Cache
where objvCaseCourseKnowledgeRelaEN.id_CaseCourseKnowledgeRela == lngid_CaseCourseKnowledgeRela
select objvCaseCourseKnowledgeRelaEN;
if (arrvCaseCourseKnowledgeRelaObjLst_Sel.Count() == 0)
{
   clsvCaseCourseKnowledgeRelaEN obj = clsvCaseCourseKnowledgeRelaWApi.GetObjByid_CaseCourseKnowledgeRela(lngid_CaseCourseKnowledgeRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCaseCourseKnowledgeRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseCourseKnowledgeRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCourseKnowledgeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseCourseKnowledgeRelaEN> GetObjLstById_CaseCourseKnowledgeRelaLst(List<long> arrId_CaseCourseKnowledgeRela)
{
 List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseCourseKnowledgeRelaLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CaseCourseKnowledgeRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCourseKnowledgeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_CaseCourseKnowledgeRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCaseCourseKnowledgeRelaEN> GetObjLstById_CaseCourseKnowledgeRelaLst_Cache(List<long> arrId_CaseCourseKnowledgeRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCaseCourseKnowledgeRelaEN._CurrTabName_S);
List<clsvCaseCourseKnowledgeRelaEN> arrvCaseCourseKnowledgeRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCaseCourseKnowledgeRelaEN> arrvCaseCourseKnowledgeRelaObjLst_Sel =
from objvCaseCourseKnowledgeRelaEN in arrvCaseCourseKnowledgeRelaObjLst_Cache
where arrId_CaseCourseKnowledgeRela.Contains(objvCaseCourseKnowledgeRelaEN.id_CaseCourseKnowledgeRela)
select objvCaseCourseKnowledgeRelaEN;
return arrvCaseCourseKnowledgeRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseCourseKnowledgeRelaEN> GetObjLstById_CaseCourseKnowledgeRelaLst_WA_Cache(List<long> arrId_CaseCourseKnowledgeRela)
{
 List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseCourseKnowledgeRelaLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CaseCourseKnowledgeRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCourseKnowledgeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseCourseKnowledgeRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCourseKnowledgeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseCourseKnowledgeRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCourseKnowledgeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseCourseKnowledgeRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCourseKnowledgeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseCourseKnowledgeRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseCourseKnowledgeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_CaseCourseKnowledgeRela)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseCourseKnowledgeRela"] = lngid_CaseCourseKnowledgeRela.ToString()
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
 /// <param name = "objvCaseCourseKnowledgeRelaENS">源对象</param>
 /// <param name = "objvCaseCourseKnowledgeRelaENT">目标对象</param>
 public static void CopyTo(clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaENS, clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaENT)
{
try
{
objvCaseCourseKnowledgeRelaENT.id_CaseCourseKnowledgeRela = objvCaseCourseKnowledgeRelaENS.id_CaseCourseKnowledgeRela; //案例知识点关系流水号
objvCaseCourseKnowledgeRelaENT.FuncModuleId = objvCaseCourseKnowledgeRelaENS.FuncModuleId; //功能模块Id
objvCaseCourseKnowledgeRelaENT.FuncModuleName = objvCaseCourseKnowledgeRelaENS.FuncModuleName; //功能模块名称
objvCaseCourseKnowledgeRelaENT.CaseId = objvCaseCourseKnowledgeRelaENS.CaseId; //案例Id
objvCaseCourseKnowledgeRelaENT.CaseName = objvCaseCourseKnowledgeRelaENS.CaseName; //案例名称
objvCaseCourseKnowledgeRelaENT.OwnerId = objvCaseCourseKnowledgeRelaENS.OwnerId; //拥有者Id
objvCaseCourseKnowledgeRelaENT.OwnerName = objvCaseCourseKnowledgeRelaENS.OwnerName; //拥有者姓名
objvCaseCourseKnowledgeRelaENT.CourseKnowledgeId = objvCaseCourseKnowledgeRelaENS.CourseKnowledgeId; //知识点Id
objvCaseCourseKnowledgeRelaENT.KnowledgeName = objvCaseCourseKnowledgeRelaENS.KnowledgeName; //知识点名称
objvCaseCourseKnowledgeRelaENT.KnowledgeTitle = objvCaseCourseKnowledgeRelaENS.KnowledgeTitle; //知识点标题
objvCaseCourseKnowledgeRelaENT.KnowledgeContent = objvCaseCourseKnowledgeRelaENS.KnowledgeContent; //知识点内容
objvCaseCourseKnowledgeRelaENT.RelationsDegree = objvCaseCourseKnowledgeRelaENS.RelationsDegree; //关系度
objvCaseCourseKnowledgeRelaENT.CourseId = objvCaseCourseKnowledgeRelaENS.CourseId; //课程Id
objvCaseCourseKnowledgeRelaENT.CourseName = objvCaseCourseKnowledgeRelaENS.CourseName; //课程名称
objvCaseCourseKnowledgeRelaENT.CourseChapterId = objvCaseCourseKnowledgeRelaENS.CourseChapterId; //课程章节ID
objvCaseCourseKnowledgeRelaENT.id_CaseCourseKnowledgeRelaType = objvCaseCourseKnowledgeRelaENS.id_CaseCourseKnowledgeRelaType; //案例知识点关系类型流水号
objvCaseCourseKnowledgeRelaENT.CaseCourseKnowledgeRelaTypeName = objvCaseCourseKnowledgeRelaENS.CaseCourseKnowledgeRelaTypeName; //案例知识点关系类型名称
objvCaseCourseKnowledgeRelaENT.BrowseCount = objvCaseCourseKnowledgeRelaENS.BrowseCount; //浏览次数
objvCaseCourseKnowledgeRelaENT.OrderNum = objvCaseCourseKnowledgeRelaENS.OrderNum; //序号
objvCaseCourseKnowledgeRelaENT.UpdDate = objvCaseCourseKnowledgeRelaENS.UpdDate; //修改日期
objvCaseCourseKnowledgeRelaENT.UpdUserId = objvCaseCourseKnowledgeRelaENS.UpdUserId; //修改用户Id
objvCaseCourseKnowledgeRelaENT.Memo = objvCaseCourseKnowledgeRelaENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvCaseCourseKnowledgeRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCaseCourseKnowledgeRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCaseCourseKnowledgeRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCaseCourseKnowledgeRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCaseCourseKnowledgeRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCaseCourseKnowledgeRelaEN.AttributeName)
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
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseCourseKnowledgeRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseCourseKnowledgeRelaWApi没有刷新缓存机制(clsCaseCourseKnowledgeRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseCourseKnowledgeRelaTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseCourseKnowledgeRelaTypeWApi没有刷新缓存机制(clsCaseCourseKnowledgeRelaTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_CaseCourseKnowledgeRela");
//if (arrvCaseCourseKnowledgeRelaObjLst_Cache == null)
//{
//arrvCaseCourseKnowledgeRelaObjLst_Cache = await clsvCaseCourseKnowledgeRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCaseCourseKnowledgeRelaEN._CurrTabName_S);
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
public static List<clsvCaseCourseKnowledgeRelaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCaseCourseKnowledgeRelaEN._CurrTabName_S);
List<clsvCaseCourseKnowledgeRelaEN> arrvCaseCourseKnowledgeRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCaseCourseKnowledgeRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCaseCourseKnowledgeRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRela, Type.GetType("System.Int64"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.CaseId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.CaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.CourseKnowledgeId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.KnowledgeName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.KnowledgeTitle, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.KnowledgeContent, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.RelationsDegree, Type.GetType("System.Int32"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseCourseKnowledgeRela.Memo, Type.GetType("System.String"));
foreach (clsvCaseCourseKnowledgeRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRela] = objInFor[convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRela];
objDR[convCaseCourseKnowledgeRela.FuncModuleId] = objInFor[convCaseCourseKnowledgeRela.FuncModuleId];
objDR[convCaseCourseKnowledgeRela.FuncModuleName] = objInFor[convCaseCourseKnowledgeRela.FuncModuleName];
objDR[convCaseCourseKnowledgeRela.CaseId] = objInFor[convCaseCourseKnowledgeRela.CaseId];
objDR[convCaseCourseKnowledgeRela.CaseName] = objInFor[convCaseCourseKnowledgeRela.CaseName];
objDR[convCaseCourseKnowledgeRela.OwnerId] = objInFor[convCaseCourseKnowledgeRela.OwnerId];
objDR[convCaseCourseKnowledgeRela.OwnerName] = objInFor[convCaseCourseKnowledgeRela.OwnerName];
objDR[convCaseCourseKnowledgeRela.CourseKnowledgeId] = objInFor[convCaseCourseKnowledgeRela.CourseKnowledgeId];
objDR[convCaseCourseKnowledgeRela.KnowledgeName] = objInFor[convCaseCourseKnowledgeRela.KnowledgeName];
objDR[convCaseCourseKnowledgeRela.KnowledgeTitle] = objInFor[convCaseCourseKnowledgeRela.KnowledgeTitle];
objDR[convCaseCourseKnowledgeRela.KnowledgeContent] = objInFor[convCaseCourseKnowledgeRela.KnowledgeContent];
objDR[convCaseCourseKnowledgeRela.RelationsDegree] = objInFor[convCaseCourseKnowledgeRela.RelationsDegree];
objDR[convCaseCourseKnowledgeRela.CourseId] = objInFor[convCaseCourseKnowledgeRela.CourseId];
objDR[convCaseCourseKnowledgeRela.CourseName] = objInFor[convCaseCourseKnowledgeRela.CourseName];
objDR[convCaseCourseKnowledgeRela.CourseChapterId] = objInFor[convCaseCourseKnowledgeRela.CourseChapterId];
objDR[convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType] = objInFor[convCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType];
objDR[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName] = objInFor[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName];
objDR[convCaseCourseKnowledgeRela.BrowseCount] = objInFor[convCaseCourseKnowledgeRela.BrowseCount];
objDR[convCaseCourseKnowledgeRela.OrderNum] = objInFor[convCaseCourseKnowledgeRela.OrderNum];
objDR[convCaseCourseKnowledgeRela.UpdDate] = objInFor[convCaseCourseKnowledgeRela.UpdDate];
objDR[convCaseCourseKnowledgeRela.UpdUserId] = objInFor[convCaseCourseKnowledgeRela.UpdUserId];
objDR[convCaseCourseKnowledgeRela.Memo] = objInFor[convCaseCourseKnowledgeRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}