
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseCourseKnowledgeRelaBL
 表名:vCaseCourseKnowledgeRela(01120393)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:40
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
public static class  clsvCaseCourseKnowledgeRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdCaseCourseKnowledgeRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseCourseKnowledgeRelaEN GetObj(this K_IdCaseCourseKnowledgeRela_vCaseCourseKnowledgeRela myKey)
{
clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = clsvCaseCourseKnowledgeRelaBL.vCaseCourseKnowledgeRelaDA.GetObjByIdCaseCourseKnowledgeRela(myKey.Value);
return objvCaseCourseKnowledgeRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetIdCaseCourseKnowledgeRela(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, long lngIdCaseCourseKnowledgeRela, string strComparisonOp="")
	{
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = lngIdCaseCourseKnowledgeRela; //案例知识点关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetFuncModuleId(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCaseCourseKnowledgeRela.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCaseCourseKnowledgeRela.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCaseCourseKnowledgeRela.FuncModuleId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetFuncModuleName(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convCaseCourseKnowledgeRela.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCaseCourseKnowledgeRela.FuncModuleName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetCaseId(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strCaseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseId, 8, convCaseCourseKnowledgeRela.CaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, convCaseCourseKnowledgeRela.CaseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetCaseName(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseName, 100, convCaseCourseKnowledgeRela.CaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetOwnerId(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convCaseCourseKnowledgeRela.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCaseCourseKnowledgeRela.OwnerId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetOwnerName(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCaseCourseKnowledgeRela.OwnerName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetCourseKnowledgeId(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, convCaseCourseKnowledgeRela.CourseKnowledgeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, convCaseCourseKnowledgeRela.CourseKnowledgeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetKnowledgeName(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strKnowledgeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeName, 100, convCaseCourseKnowledgeRela.KnowledgeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetKnowledgeTitle(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strKnowledgeTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeTitle, 100, convCaseCourseKnowledgeRela.KnowledgeTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetCourseId(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCaseCourseKnowledgeRela.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCaseCourseKnowledgeRela.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetCourseName(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCaseCourseKnowledgeRela.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetCourseChapterId(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCaseCourseKnowledgeRela.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCaseCourseKnowledgeRela.CourseChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetIdCaseCourseKnowledgeRelaType(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strIdCaseCourseKnowledgeRelaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCaseCourseKnowledgeRelaType, convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseCourseKnowledgeRelaType, 4, convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseCourseKnowledgeRelaType, 4, convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
}
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = strIdCaseCourseKnowledgeRelaType; //案例知识点关系类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType) == false)
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType, strComparisonOp);
}
else
{
objvCaseCourseKnowledgeRelaEN.dicFldComparisonOp[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType] = strComparisonOp;
}
}
return objvCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetCaseCourseKnowledgeRelaTypeName(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strCaseCourseKnowledgeRelaTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseCourseKnowledgeRelaTypeName, convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseCourseKnowledgeRelaTypeName, 50, convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetBrowseCount(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, int? intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetOrderNum(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, int? intOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetUpdDate(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCaseCourseKnowledgeRela.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetUpdUserId(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convCaseCourseKnowledgeRela.UpdUserId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCourseKnowledgeRelaEN SetMemo(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCaseCourseKnowledgeRela.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaENS">源对象</param>
 /// <param name = "objvCaseCourseKnowledgeRelaENT">目标对象</param>
 public static void CopyTo(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaENS, clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaENT)
{
try
{
objvCaseCourseKnowledgeRelaENT.IdCaseCourseKnowledgeRela = objvCaseCourseKnowledgeRelaENS.IdCaseCourseKnowledgeRela; //案例知识点关系流水号
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
objvCaseCourseKnowledgeRelaENT.IdCaseCourseKnowledgeRelaType = objvCaseCourseKnowledgeRelaENS.IdCaseCourseKnowledgeRelaType; //案例知识点关系类型流水号
objvCaseCourseKnowledgeRelaENT.CaseCourseKnowledgeRelaTypeName = objvCaseCourseKnowledgeRelaENS.CaseCourseKnowledgeRelaTypeName; //案例知识点关系类型名称
objvCaseCourseKnowledgeRelaENT.BrowseCount = objvCaseCourseKnowledgeRelaENS.BrowseCount; //浏览次数
objvCaseCourseKnowledgeRelaENT.OrderNum = objvCaseCourseKnowledgeRelaENS.OrderNum; //序号
objvCaseCourseKnowledgeRelaENT.UpdDate = objvCaseCourseKnowledgeRelaENS.UpdDate; //修改日期
objvCaseCourseKnowledgeRelaENT.UpdUserId = objvCaseCourseKnowledgeRelaENS.UpdUserId; //修改用户Id
objvCaseCourseKnowledgeRelaENT.Memo = objvCaseCourseKnowledgeRelaENS.Memo; //备注
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
 /// <param name = "objvCaseCourseKnowledgeRelaENS">源对象</param>
 /// <returns>目标对象=>clsvCaseCourseKnowledgeRelaEN:objvCaseCourseKnowledgeRelaENT</returns>
 public static clsvCaseCourseKnowledgeRelaEN CopyTo(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaENS)
{
try
{
 clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaENT = new clsvCaseCourseKnowledgeRelaEN()
{
IdCaseCourseKnowledgeRela = objvCaseCourseKnowledgeRelaENS.IdCaseCourseKnowledgeRela, //案例知识点关系流水号
FuncModuleId = objvCaseCourseKnowledgeRelaENS.FuncModuleId, //功能模块Id
FuncModuleName = objvCaseCourseKnowledgeRelaENS.FuncModuleName, //功能模块名称
CaseId = objvCaseCourseKnowledgeRelaENS.CaseId, //案例Id
CaseName = objvCaseCourseKnowledgeRelaENS.CaseName, //案例名称
OwnerId = objvCaseCourseKnowledgeRelaENS.OwnerId, //拥有者Id
OwnerName = objvCaseCourseKnowledgeRelaENS.OwnerName, //拥有者姓名
CourseKnowledgeId = objvCaseCourseKnowledgeRelaENS.CourseKnowledgeId, //知识点Id
KnowledgeName = objvCaseCourseKnowledgeRelaENS.KnowledgeName, //知识点名称
KnowledgeTitle = objvCaseCourseKnowledgeRelaENS.KnowledgeTitle, //知识点标题
KnowledgeContent = objvCaseCourseKnowledgeRelaENS.KnowledgeContent, //知识点内容
RelationsDegree = objvCaseCourseKnowledgeRelaENS.RelationsDegree, //关系度
CourseId = objvCaseCourseKnowledgeRelaENS.CourseId, //课程Id
CourseName = objvCaseCourseKnowledgeRelaENS.CourseName, //课程名称
CourseChapterId = objvCaseCourseKnowledgeRelaENS.CourseChapterId, //课程章节ID
IdCaseCourseKnowledgeRelaType = objvCaseCourseKnowledgeRelaENS.IdCaseCourseKnowledgeRelaType, //案例知识点关系类型流水号
CaseCourseKnowledgeRelaTypeName = objvCaseCourseKnowledgeRelaENS.CaseCourseKnowledgeRelaTypeName, //案例知识点关系类型名称
BrowseCount = objvCaseCourseKnowledgeRelaENS.BrowseCount, //浏览次数
OrderNum = objvCaseCourseKnowledgeRelaENS.OrderNum, //序号
UpdDate = objvCaseCourseKnowledgeRelaENS.UpdDate, //修改日期
UpdUserId = objvCaseCourseKnowledgeRelaENS.UpdUserId, //修改用户Id
Memo = objvCaseCourseKnowledgeRelaENS.Memo, //备注
};
 return objvCaseCourseKnowledgeRelaENT;
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
public static void CheckProperty4Condition(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN)
{
 clsvCaseCourseKnowledgeRelaBL.vCaseCourseKnowledgeRelaDA.CheckProperty4Condition(objvCaseCourseKnowledgeRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela) == true)
{
string strComparisonOpIdCaseCourseKnowledgeRela = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela, objvCaseCourseKnowledgeRelaCond.IdCaseCourseKnowledgeRela, strComparisonOpIdCaseCourseKnowledgeRela);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.FuncModuleId, objvCaseCourseKnowledgeRelaCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.FuncModuleName, objvCaseCourseKnowledgeRelaCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.CaseId) == true)
{
string strComparisonOpCaseId = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.CaseId, objvCaseCourseKnowledgeRelaCond.CaseId, strComparisonOpCaseId);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.CaseName) == true)
{
string strComparisonOpCaseName = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.CaseName, objvCaseCourseKnowledgeRelaCond.CaseName, strComparisonOpCaseName);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.OwnerId) == true)
{
string strComparisonOpOwnerId = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.OwnerId, objvCaseCourseKnowledgeRelaCond.OwnerId, strComparisonOpOwnerId);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.OwnerName) == true)
{
string strComparisonOpOwnerName = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.OwnerName, objvCaseCourseKnowledgeRelaCond.OwnerName, strComparisonOpOwnerName);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.CourseKnowledgeId) == true)
{
string strComparisonOpCourseKnowledgeId = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.CourseKnowledgeId, objvCaseCourseKnowledgeRelaCond.CourseKnowledgeId, strComparisonOpCourseKnowledgeId);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.KnowledgeName) == true)
{
string strComparisonOpKnowledgeName = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.KnowledgeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.KnowledgeName, objvCaseCourseKnowledgeRelaCond.KnowledgeName, strComparisonOpKnowledgeName);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.KnowledgeTitle) == true)
{
string strComparisonOpKnowledgeTitle = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.KnowledgeTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.KnowledgeTitle, objvCaseCourseKnowledgeRelaCond.KnowledgeTitle, strComparisonOpKnowledgeTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.RelationsDegree) == true)
{
string strComparisonOpRelationsDegree = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.RelationsDegree];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCourseKnowledgeRela.RelationsDegree, objvCaseCourseKnowledgeRelaCond.RelationsDegree, strComparisonOpRelationsDegree);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.CourseId) == true)
{
string strComparisonOpCourseId = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.CourseId, objvCaseCourseKnowledgeRelaCond.CourseId, strComparisonOpCourseId);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.CourseName) == true)
{
string strComparisonOpCourseName = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.CourseName, objvCaseCourseKnowledgeRelaCond.CourseName, strComparisonOpCourseName);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.CourseChapterId, objvCaseCourseKnowledgeRelaCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType) == true)
{
string strComparisonOpIdCaseCourseKnowledgeRelaType = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType, objvCaseCourseKnowledgeRelaCond.IdCaseCourseKnowledgeRelaType, strComparisonOpIdCaseCourseKnowledgeRelaType);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName) == true)
{
string strComparisonOpCaseCourseKnowledgeRelaTypeName = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName, objvCaseCourseKnowledgeRelaCond.CaseCourseKnowledgeRelaTypeName, strComparisonOpCaseCourseKnowledgeRelaTypeName);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCourseKnowledgeRela.BrowseCount, objvCaseCourseKnowledgeRelaCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCourseKnowledgeRela.OrderNum, objvCaseCourseKnowledgeRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.UpdDate, objvCaseCourseKnowledgeRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.UpdUserId, objvCaseCourseKnowledgeRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(convCaseCourseKnowledgeRela.Memo) == true)
{
string strComparisonOpMemo = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[convCaseCourseKnowledgeRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCourseKnowledgeRela.Memo, objvCaseCourseKnowledgeRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCaseCourseKnowledgeRela
{
public virtual bool UpdRelaTabDate(long lngIdCaseCourseKnowledgeRela, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v案例知识点关系(vCaseCourseKnowledgeRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCaseCourseKnowledgeRelaBL
{
public static RelatedActions_vCaseCourseKnowledgeRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCaseCourseKnowledgeRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCaseCourseKnowledgeRelaDA vCaseCourseKnowledgeRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCaseCourseKnowledgeRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCaseCourseKnowledgeRelaBL()
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
if (string.IsNullOrEmpty(clsvCaseCourseKnowledgeRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCaseCourseKnowledgeRelaEN._ConnectString);
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
public static DataTable GetDataTable_vCaseCourseKnowledgeRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCaseCourseKnowledgeRelaDA.GetDataTable_vCaseCourseKnowledgeRela(strWhereCond);
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
objDT = vCaseCourseKnowledgeRelaDA.GetDataTable(strWhereCond);
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
objDT = vCaseCourseKnowledgeRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCaseCourseKnowledgeRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCaseCourseKnowledgeRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCaseCourseKnowledgeRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vCaseCourseKnowledgeRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCaseCourseKnowledgeRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCaseCourseKnowledgeRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCaseCourseKnowledgeRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCaseCourseKnowledgeRelaEN> GetObjLstByIdCaseCourseKnowledgeRelaLst(List<long> arrIdCaseCourseKnowledgeRelaLst)
{
List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsvCaseCourseKnowledgeRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCaseCourseKnowledgeRelaLst);
 string strWhereCond = string.Format("IdCaseCourseKnowledgeRela in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = new clsvCaseCourseKnowledgeRelaEN();
try
{
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objvCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[convCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseKnowledgeRelaEN.FuncModuleName = objRow[convCaseCourseKnowledgeRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseKnowledgeRelaEN.CaseId = objRow[convCaseCourseKnowledgeRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseKnowledgeRelaEN.CaseName = objRow[convCaseCourseKnowledgeRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseKnowledgeRelaEN.OwnerId = objRow[convCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseKnowledgeRelaEN.OwnerName = objRow[convCaseCourseKnowledgeRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvCaseCourseKnowledgeRelaEN.KnowledgeName = objRow[convCaseCourseKnowledgeRela.KnowledgeName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeName].ToString().Trim(); //知识点名称
objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = objRow[convCaseCourseKnowledgeRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvCaseCourseKnowledgeRelaEN.KnowledgeContent = objRow[convCaseCourseKnowledgeRela.KnowledgeContent] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[convCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objvCaseCourseKnowledgeRelaEN.CourseId = objRow[convCaseCourseKnowledgeRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseKnowledgeRelaEN.CourseName = objRow[convCaseCourseKnowledgeRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseKnowledgeRelaEN.CourseChapterId = objRow[convCaseCourseKnowledgeRela.CourseChapterId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName = objRow[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName].ToString().Trim(); //案例知识点关系类型名称
objvCaseCourseKnowledgeRelaEN.BrowseCount = objRow[convCaseCourseKnowledgeRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseKnowledgeRelaEN.OrderNum = objRow[convCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseKnowledgeRelaEN.UpdDate = objRow[convCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseKnowledgeRelaEN.UpdUserId = objRow[convCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseKnowledgeRelaEN.Memo = objRow[convCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseKnowledgeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCaseCourseKnowledgeRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCaseCourseKnowledgeRelaEN> GetObjLstByIdCaseCourseKnowledgeRelaLstCache(List<long> arrIdCaseCourseKnowledgeRelaLst)
{
string strKey = string.Format("{0}", clsvCaseCourseKnowledgeRelaEN._CurrTabName);
List<clsvCaseCourseKnowledgeRelaEN> arrvCaseCourseKnowledgeRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseCourseKnowledgeRelaEN> arrvCaseCourseKnowledgeRelaObjLst_Sel =
arrvCaseCourseKnowledgeRelaObjLstCache
.Where(x => arrIdCaseCourseKnowledgeRelaLst.Contains(x.IdCaseCourseKnowledgeRela));
return arrvCaseCourseKnowledgeRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseCourseKnowledgeRelaEN> GetObjLst(string strWhereCond)
{
List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsvCaseCourseKnowledgeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = new clsvCaseCourseKnowledgeRelaEN();
try
{
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objvCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[convCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseKnowledgeRelaEN.FuncModuleName = objRow[convCaseCourseKnowledgeRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseKnowledgeRelaEN.CaseId = objRow[convCaseCourseKnowledgeRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseKnowledgeRelaEN.CaseName = objRow[convCaseCourseKnowledgeRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseKnowledgeRelaEN.OwnerId = objRow[convCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseKnowledgeRelaEN.OwnerName = objRow[convCaseCourseKnowledgeRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvCaseCourseKnowledgeRelaEN.KnowledgeName = objRow[convCaseCourseKnowledgeRela.KnowledgeName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeName].ToString().Trim(); //知识点名称
objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = objRow[convCaseCourseKnowledgeRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvCaseCourseKnowledgeRelaEN.KnowledgeContent = objRow[convCaseCourseKnowledgeRela.KnowledgeContent] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[convCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objvCaseCourseKnowledgeRelaEN.CourseId = objRow[convCaseCourseKnowledgeRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseKnowledgeRelaEN.CourseName = objRow[convCaseCourseKnowledgeRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseKnowledgeRelaEN.CourseChapterId = objRow[convCaseCourseKnowledgeRela.CourseChapterId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName = objRow[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName].ToString().Trim(); //案例知识点关系类型名称
objvCaseCourseKnowledgeRelaEN.BrowseCount = objRow[convCaseCourseKnowledgeRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseKnowledgeRelaEN.OrderNum = objRow[convCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseKnowledgeRelaEN.UpdDate = objRow[convCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseKnowledgeRelaEN.UpdUserId = objRow[convCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseKnowledgeRelaEN.Memo = objRow[convCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseKnowledgeRelaEN);
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
public static List<clsvCaseCourseKnowledgeRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsvCaseCourseKnowledgeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = new clsvCaseCourseKnowledgeRelaEN();
try
{
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objvCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[convCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseKnowledgeRelaEN.FuncModuleName = objRow[convCaseCourseKnowledgeRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseKnowledgeRelaEN.CaseId = objRow[convCaseCourseKnowledgeRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseKnowledgeRelaEN.CaseName = objRow[convCaseCourseKnowledgeRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseKnowledgeRelaEN.OwnerId = objRow[convCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseKnowledgeRelaEN.OwnerName = objRow[convCaseCourseKnowledgeRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvCaseCourseKnowledgeRelaEN.KnowledgeName = objRow[convCaseCourseKnowledgeRela.KnowledgeName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeName].ToString().Trim(); //知识点名称
objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = objRow[convCaseCourseKnowledgeRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvCaseCourseKnowledgeRelaEN.KnowledgeContent = objRow[convCaseCourseKnowledgeRela.KnowledgeContent] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[convCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objvCaseCourseKnowledgeRelaEN.CourseId = objRow[convCaseCourseKnowledgeRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseKnowledgeRelaEN.CourseName = objRow[convCaseCourseKnowledgeRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseKnowledgeRelaEN.CourseChapterId = objRow[convCaseCourseKnowledgeRela.CourseChapterId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName = objRow[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName].ToString().Trim(); //案例知识点关系类型名称
objvCaseCourseKnowledgeRelaEN.BrowseCount = objRow[convCaseCourseKnowledgeRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseKnowledgeRelaEN.OrderNum = objRow[convCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseKnowledgeRelaEN.UpdDate = objRow[convCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseKnowledgeRelaEN.UpdUserId = objRow[convCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseKnowledgeRelaEN.Memo = objRow[convCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseKnowledgeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCaseCourseKnowledgeRelaEN> GetSubObjLstCache(clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaCond)
{
List<clsvCaseCourseKnowledgeRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseCourseKnowledgeRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCaseCourseKnowledgeRela.AttributeName)
{
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(strFldName) == false) continue;
if (objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseCourseKnowledgeRelaCond[strFldName].ToString());
}
else
{
if (objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseCourseKnowledgeRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCaseCourseKnowledgeRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCaseCourseKnowledgeRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCaseCourseKnowledgeRelaCond[strFldName]));
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
public static List<clsvCaseCourseKnowledgeRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsvCaseCourseKnowledgeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = new clsvCaseCourseKnowledgeRelaEN();
try
{
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objvCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[convCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseKnowledgeRelaEN.FuncModuleName = objRow[convCaseCourseKnowledgeRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseKnowledgeRelaEN.CaseId = objRow[convCaseCourseKnowledgeRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseKnowledgeRelaEN.CaseName = objRow[convCaseCourseKnowledgeRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseKnowledgeRelaEN.OwnerId = objRow[convCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseKnowledgeRelaEN.OwnerName = objRow[convCaseCourseKnowledgeRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvCaseCourseKnowledgeRelaEN.KnowledgeName = objRow[convCaseCourseKnowledgeRela.KnowledgeName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeName].ToString().Trim(); //知识点名称
objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = objRow[convCaseCourseKnowledgeRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvCaseCourseKnowledgeRelaEN.KnowledgeContent = objRow[convCaseCourseKnowledgeRela.KnowledgeContent] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[convCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objvCaseCourseKnowledgeRelaEN.CourseId = objRow[convCaseCourseKnowledgeRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseKnowledgeRelaEN.CourseName = objRow[convCaseCourseKnowledgeRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseKnowledgeRelaEN.CourseChapterId = objRow[convCaseCourseKnowledgeRela.CourseChapterId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName = objRow[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName].ToString().Trim(); //案例知识点关系类型名称
objvCaseCourseKnowledgeRelaEN.BrowseCount = objRow[convCaseCourseKnowledgeRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseKnowledgeRelaEN.OrderNum = objRow[convCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseKnowledgeRelaEN.UpdDate = objRow[convCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseKnowledgeRelaEN.UpdUserId = objRow[convCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseKnowledgeRelaEN.Memo = objRow[convCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseKnowledgeRelaEN);
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
public static List<clsvCaseCourseKnowledgeRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsvCaseCourseKnowledgeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = new clsvCaseCourseKnowledgeRelaEN();
try
{
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objvCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[convCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseKnowledgeRelaEN.FuncModuleName = objRow[convCaseCourseKnowledgeRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseKnowledgeRelaEN.CaseId = objRow[convCaseCourseKnowledgeRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseKnowledgeRelaEN.CaseName = objRow[convCaseCourseKnowledgeRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseKnowledgeRelaEN.OwnerId = objRow[convCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseKnowledgeRelaEN.OwnerName = objRow[convCaseCourseKnowledgeRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvCaseCourseKnowledgeRelaEN.KnowledgeName = objRow[convCaseCourseKnowledgeRela.KnowledgeName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeName].ToString().Trim(); //知识点名称
objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = objRow[convCaseCourseKnowledgeRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvCaseCourseKnowledgeRelaEN.KnowledgeContent = objRow[convCaseCourseKnowledgeRela.KnowledgeContent] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[convCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objvCaseCourseKnowledgeRelaEN.CourseId = objRow[convCaseCourseKnowledgeRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseKnowledgeRelaEN.CourseName = objRow[convCaseCourseKnowledgeRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseKnowledgeRelaEN.CourseChapterId = objRow[convCaseCourseKnowledgeRela.CourseChapterId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName = objRow[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName].ToString().Trim(); //案例知识点关系类型名称
objvCaseCourseKnowledgeRelaEN.BrowseCount = objRow[convCaseCourseKnowledgeRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseKnowledgeRelaEN.OrderNum = objRow[convCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseKnowledgeRelaEN.UpdDate = objRow[convCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseKnowledgeRelaEN.UpdUserId = objRow[convCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseKnowledgeRelaEN.Memo = objRow[convCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseKnowledgeRelaEN);
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
List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseCourseKnowledgeRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCaseCourseKnowledgeRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsvCaseCourseKnowledgeRelaEN>(); 
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
	clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = new clsvCaseCourseKnowledgeRelaEN();
try
{
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objvCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[convCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseKnowledgeRelaEN.FuncModuleName = objRow[convCaseCourseKnowledgeRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseKnowledgeRelaEN.CaseId = objRow[convCaseCourseKnowledgeRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseKnowledgeRelaEN.CaseName = objRow[convCaseCourseKnowledgeRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseKnowledgeRelaEN.OwnerId = objRow[convCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseKnowledgeRelaEN.OwnerName = objRow[convCaseCourseKnowledgeRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvCaseCourseKnowledgeRelaEN.KnowledgeName = objRow[convCaseCourseKnowledgeRela.KnowledgeName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeName].ToString().Trim(); //知识点名称
objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = objRow[convCaseCourseKnowledgeRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvCaseCourseKnowledgeRelaEN.KnowledgeContent = objRow[convCaseCourseKnowledgeRela.KnowledgeContent] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[convCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objvCaseCourseKnowledgeRelaEN.CourseId = objRow[convCaseCourseKnowledgeRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseKnowledgeRelaEN.CourseName = objRow[convCaseCourseKnowledgeRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseKnowledgeRelaEN.CourseChapterId = objRow[convCaseCourseKnowledgeRela.CourseChapterId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName = objRow[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName].ToString().Trim(); //案例知识点关系类型名称
objvCaseCourseKnowledgeRelaEN.BrowseCount = objRow[convCaseCourseKnowledgeRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseKnowledgeRelaEN.OrderNum = objRow[convCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseKnowledgeRelaEN.UpdDate = objRow[convCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseKnowledgeRelaEN.UpdUserId = objRow[convCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseKnowledgeRelaEN.Memo = objRow[convCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseKnowledgeRelaEN);
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
public static List<clsvCaseCourseKnowledgeRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsvCaseCourseKnowledgeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = new clsvCaseCourseKnowledgeRelaEN();
try
{
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objvCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[convCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseKnowledgeRelaEN.FuncModuleName = objRow[convCaseCourseKnowledgeRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseKnowledgeRelaEN.CaseId = objRow[convCaseCourseKnowledgeRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseKnowledgeRelaEN.CaseName = objRow[convCaseCourseKnowledgeRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseKnowledgeRelaEN.OwnerId = objRow[convCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseKnowledgeRelaEN.OwnerName = objRow[convCaseCourseKnowledgeRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvCaseCourseKnowledgeRelaEN.KnowledgeName = objRow[convCaseCourseKnowledgeRela.KnowledgeName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeName].ToString().Trim(); //知识点名称
objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = objRow[convCaseCourseKnowledgeRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvCaseCourseKnowledgeRelaEN.KnowledgeContent = objRow[convCaseCourseKnowledgeRela.KnowledgeContent] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[convCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objvCaseCourseKnowledgeRelaEN.CourseId = objRow[convCaseCourseKnowledgeRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseKnowledgeRelaEN.CourseName = objRow[convCaseCourseKnowledgeRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseKnowledgeRelaEN.CourseChapterId = objRow[convCaseCourseKnowledgeRela.CourseChapterId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName = objRow[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName].ToString().Trim(); //案例知识点关系类型名称
objvCaseCourseKnowledgeRelaEN.BrowseCount = objRow[convCaseCourseKnowledgeRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseKnowledgeRelaEN.OrderNum = objRow[convCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseKnowledgeRelaEN.UpdDate = objRow[convCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseKnowledgeRelaEN.UpdUserId = objRow[convCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseKnowledgeRelaEN.Memo = objRow[convCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseKnowledgeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCaseCourseKnowledgeRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCaseCourseKnowledgeRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsvCaseCourseKnowledgeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = new clsvCaseCourseKnowledgeRelaEN();
try
{
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objvCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[convCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseKnowledgeRelaEN.FuncModuleName = objRow[convCaseCourseKnowledgeRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseKnowledgeRelaEN.CaseId = objRow[convCaseCourseKnowledgeRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseKnowledgeRelaEN.CaseName = objRow[convCaseCourseKnowledgeRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseKnowledgeRelaEN.OwnerId = objRow[convCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseKnowledgeRelaEN.OwnerName = objRow[convCaseCourseKnowledgeRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvCaseCourseKnowledgeRelaEN.KnowledgeName = objRow[convCaseCourseKnowledgeRela.KnowledgeName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeName].ToString().Trim(); //知识点名称
objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = objRow[convCaseCourseKnowledgeRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvCaseCourseKnowledgeRelaEN.KnowledgeContent = objRow[convCaseCourseKnowledgeRela.KnowledgeContent] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[convCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objvCaseCourseKnowledgeRelaEN.CourseId = objRow[convCaseCourseKnowledgeRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseKnowledgeRelaEN.CourseName = objRow[convCaseCourseKnowledgeRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseKnowledgeRelaEN.CourseChapterId = objRow[convCaseCourseKnowledgeRela.CourseChapterId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName = objRow[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName].ToString().Trim(); //案例知识点关系类型名称
objvCaseCourseKnowledgeRelaEN.BrowseCount = objRow[convCaseCourseKnowledgeRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseKnowledgeRelaEN.OrderNum = objRow[convCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseKnowledgeRelaEN.UpdDate = objRow[convCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseKnowledgeRelaEN.UpdUserId = objRow[convCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseKnowledgeRelaEN.Memo = objRow[convCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseKnowledgeRelaEN);
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
public static List<clsvCaseCourseKnowledgeRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsvCaseCourseKnowledgeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = new clsvCaseCourseKnowledgeRelaEN();
try
{
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objvCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[convCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseKnowledgeRelaEN.FuncModuleName = objRow[convCaseCourseKnowledgeRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseKnowledgeRelaEN.CaseId = objRow[convCaseCourseKnowledgeRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseKnowledgeRelaEN.CaseName = objRow[convCaseCourseKnowledgeRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseKnowledgeRelaEN.OwnerId = objRow[convCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseKnowledgeRelaEN.OwnerName = objRow[convCaseCourseKnowledgeRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvCaseCourseKnowledgeRelaEN.KnowledgeName = objRow[convCaseCourseKnowledgeRela.KnowledgeName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeName].ToString().Trim(); //知识点名称
objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = objRow[convCaseCourseKnowledgeRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvCaseCourseKnowledgeRelaEN.KnowledgeContent = objRow[convCaseCourseKnowledgeRela.KnowledgeContent] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[convCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objvCaseCourseKnowledgeRelaEN.CourseId = objRow[convCaseCourseKnowledgeRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseKnowledgeRelaEN.CourseName = objRow[convCaseCourseKnowledgeRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseKnowledgeRelaEN.CourseChapterId = objRow[convCaseCourseKnowledgeRela.CourseChapterId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName = objRow[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName].ToString().Trim(); //案例知识点关系类型名称
objvCaseCourseKnowledgeRelaEN.BrowseCount = objRow[convCaseCourseKnowledgeRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseKnowledgeRelaEN.OrderNum = objRow[convCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseKnowledgeRelaEN.UpdDate = objRow[convCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseKnowledgeRelaEN.UpdUserId = objRow[convCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseKnowledgeRelaEN.Memo = objRow[convCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseKnowledgeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseCourseKnowledgeRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsvCaseCourseKnowledgeRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = new clsvCaseCourseKnowledgeRelaEN();
try
{
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objvCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[convCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCourseKnowledgeRelaEN.FuncModuleName = objRow[convCaseCourseKnowledgeRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCourseKnowledgeRelaEN.CaseId = objRow[convCaseCourseKnowledgeRela.CaseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objvCaseCourseKnowledgeRelaEN.CaseName = objRow[convCaseCourseKnowledgeRela.CaseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objvCaseCourseKnowledgeRelaEN.OwnerId = objRow[convCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCourseKnowledgeRelaEN.OwnerName = objRow[convCaseCourseKnowledgeRela.OwnerName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvCaseCourseKnowledgeRelaEN.KnowledgeName = objRow[convCaseCourseKnowledgeRela.KnowledgeName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeName].ToString().Trim(); //知识点名称
objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = objRow[convCaseCourseKnowledgeRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvCaseCourseKnowledgeRelaEN.KnowledgeContent = objRow[convCaseCourseKnowledgeRela.KnowledgeContent] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[convCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objvCaseCourseKnowledgeRelaEN.CourseId = objRow[convCaseCourseKnowledgeRela.CourseId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseId].ToString().Trim(); //课程Id
objvCaseCourseKnowledgeRelaEN.CourseName = objRow[convCaseCourseKnowledgeRela.CourseName] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseName].ToString().Trim(); //课程名称
objvCaseCourseKnowledgeRelaEN.CourseChapterId = objRow[convCaseCourseKnowledgeRela.CourseChapterId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName = objRow[convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName].ToString().Trim(); //案例知识点关系类型名称
objvCaseCourseKnowledgeRelaEN.BrowseCount = objRow[convCaseCourseKnowledgeRela.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCourseKnowledgeRelaEN.OrderNum = objRow[convCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objvCaseCourseKnowledgeRelaEN.UpdDate = objRow[convCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objvCaseCourseKnowledgeRelaEN.UpdUserId = objRow[convCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCourseKnowledgeRelaEN.Memo = objRow[convCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[convCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCourseKnowledgeRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCaseCourseKnowledgeRela(ref clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN)
{
bool bolResult = vCaseCourseKnowledgeRelaDA.GetvCaseCourseKnowledgeRela(ref objvCaseCourseKnowledgeRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdCaseCourseKnowledgeRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseCourseKnowledgeRelaEN GetObjByIdCaseCourseKnowledgeRela(long lngIdCaseCourseKnowledgeRela)
{
clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = vCaseCourseKnowledgeRelaDA.GetObjByIdCaseCourseKnowledgeRela(lngIdCaseCourseKnowledgeRela);
return objvCaseCourseKnowledgeRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCaseCourseKnowledgeRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = vCaseCourseKnowledgeRelaDA.GetFirstObj(strWhereCond);
 return objvCaseCourseKnowledgeRelaEN;
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
public static clsvCaseCourseKnowledgeRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = vCaseCourseKnowledgeRelaDA.GetObjByDataRow(objRow);
 return objvCaseCourseKnowledgeRelaEN;
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
public static clsvCaseCourseKnowledgeRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN = vCaseCourseKnowledgeRelaDA.GetObjByDataRow(objRow);
 return objvCaseCourseKnowledgeRelaEN;
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
 /// <param name = "lngIdCaseCourseKnowledgeRela">所给的关键字</param>
 /// <param name = "lstvCaseCourseKnowledgeRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseCourseKnowledgeRelaEN GetObjByIdCaseCourseKnowledgeRelaFromList(long lngIdCaseCourseKnowledgeRela, List<clsvCaseCourseKnowledgeRelaEN> lstvCaseCourseKnowledgeRelaObjLst)
{
foreach (clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN in lstvCaseCourseKnowledgeRelaObjLst)
{
if (objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela == lngIdCaseCourseKnowledgeRela)
{
return objvCaseCourseKnowledgeRelaEN;
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
 long lngIdCaseCourseKnowledgeRela;
 try
 {
 lngIdCaseCourseKnowledgeRela = new clsvCaseCourseKnowledgeRelaDA().GetFirstID(strWhereCond);
 return lngIdCaseCourseKnowledgeRela;
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
 arrList = vCaseCourseKnowledgeRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vCaseCourseKnowledgeRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdCaseCourseKnowledgeRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdCaseCourseKnowledgeRela)
{
//检测记录是否存在
bool bolIsExist = vCaseCourseKnowledgeRelaDA.IsExist(lngIdCaseCourseKnowledgeRela);
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
 bolIsExist = clsvCaseCourseKnowledgeRelaDA.IsExistTable();
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
 bolIsExist = vCaseCourseKnowledgeRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvCaseCourseKnowledgeRelaENS">源对象</param>
 /// <param name = "objvCaseCourseKnowledgeRelaENT">目标对象</param>
 public static void CopyTo(clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaENS, clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaENT)
{
try
{
objvCaseCourseKnowledgeRelaENT.IdCaseCourseKnowledgeRela = objvCaseCourseKnowledgeRelaENS.IdCaseCourseKnowledgeRela; //案例知识点关系流水号
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
objvCaseCourseKnowledgeRelaENT.IdCaseCourseKnowledgeRelaType = objvCaseCourseKnowledgeRelaENS.IdCaseCourseKnowledgeRelaType; //案例知识点关系类型流水号
objvCaseCourseKnowledgeRelaENT.CaseCourseKnowledgeRelaTypeName = objvCaseCourseKnowledgeRelaENS.CaseCourseKnowledgeRelaTypeName; //案例知识点关系类型名称
objvCaseCourseKnowledgeRelaENT.BrowseCount = objvCaseCourseKnowledgeRelaENS.BrowseCount; //浏览次数
objvCaseCourseKnowledgeRelaENT.OrderNum = objvCaseCourseKnowledgeRelaENS.OrderNum; //序号
objvCaseCourseKnowledgeRelaENT.UpdDate = objvCaseCourseKnowledgeRelaENS.UpdDate; //修改日期
objvCaseCourseKnowledgeRelaENT.UpdUserId = objvCaseCourseKnowledgeRelaENS.UpdUserId; //修改用户Id
objvCaseCourseKnowledgeRelaENT.Memo = objvCaseCourseKnowledgeRelaENS.Memo; //备注
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
 /// <param name = "objvCaseCourseKnowledgeRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN)
{
try
{
objvCaseCourseKnowledgeRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCaseCourseKnowledgeRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela; //案例知识点关系流水号
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.FuncModuleId = objvCaseCourseKnowledgeRelaEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.FuncModuleName = objvCaseCourseKnowledgeRelaEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.CaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.CaseId = objvCaseCourseKnowledgeRelaEN.CaseId == "[null]" ? null :  objvCaseCourseKnowledgeRelaEN.CaseId; //案例Id
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.CaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.CaseName = objvCaseCourseKnowledgeRelaEN.CaseName == "[null]" ? null :  objvCaseCourseKnowledgeRelaEN.CaseName; //案例名称
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.OwnerId = objvCaseCourseKnowledgeRelaEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.OwnerName = objvCaseCourseKnowledgeRelaEN.OwnerName == "[null]" ? null :  objvCaseCourseKnowledgeRelaEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.CourseKnowledgeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId == "[null]" ? null :  objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId; //知识点Id
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.KnowledgeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.KnowledgeName = objvCaseCourseKnowledgeRelaEN.KnowledgeName == "[null]" ? null :  objvCaseCourseKnowledgeRelaEN.KnowledgeName; //知识点名称
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.KnowledgeTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = objvCaseCourseKnowledgeRelaEN.KnowledgeTitle == "[null]" ? null :  objvCaseCourseKnowledgeRelaEN.KnowledgeTitle; //知识点标题
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.KnowledgeContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.KnowledgeContent = objvCaseCourseKnowledgeRelaEN.KnowledgeContent == "[null]" ? null :  objvCaseCourseKnowledgeRelaEN.KnowledgeContent; //知识点内容
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.RelationsDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.RelationsDegree = objvCaseCourseKnowledgeRelaEN.RelationsDegree; //关系度
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.CourseId = objvCaseCourseKnowledgeRelaEN.CourseId == "[null]" ? null :  objvCaseCourseKnowledgeRelaEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.CourseName = objvCaseCourseKnowledgeRelaEN.CourseName == "[null]" ? null :  objvCaseCourseKnowledgeRelaEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.CourseChapterId = objvCaseCourseKnowledgeRelaEN.CourseChapterId == "[null]" ? null :  objvCaseCourseKnowledgeRelaEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objvCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType; //案例知识点关系类型流水号
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.CaseCourseKnowledgeRelaTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName = objvCaseCourseKnowledgeRelaEN.CaseCourseKnowledgeRelaTypeName; //案例知识点关系类型名称
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.BrowseCount = objvCaseCourseKnowledgeRelaEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.OrderNum = objvCaseCourseKnowledgeRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.UpdDate = objvCaseCourseKnowledgeRelaEN.UpdDate == "[null]" ? null :  objvCaseCourseKnowledgeRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.UpdUserId = objvCaseCourseKnowledgeRelaEN.UpdUserId == "[null]" ? null :  objvCaseCourseKnowledgeRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convCaseCourseKnowledgeRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCourseKnowledgeRelaEN.Memo = objvCaseCourseKnowledgeRelaEN.Memo == "[null]" ? null :  objvCaseCourseKnowledgeRelaEN.Memo; //备注
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
 /// <param name = "objvCaseCourseKnowledgeRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN)
{
try
{
if (objvCaseCourseKnowledgeRelaEN.CaseId == "[null]") objvCaseCourseKnowledgeRelaEN.CaseId = null; //案例Id
if (objvCaseCourseKnowledgeRelaEN.CaseName == "[null]") objvCaseCourseKnowledgeRelaEN.CaseName = null; //案例名称
if (objvCaseCourseKnowledgeRelaEN.OwnerName == "[null]") objvCaseCourseKnowledgeRelaEN.OwnerName = null; //拥有者姓名
if (objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId == "[null]") objvCaseCourseKnowledgeRelaEN.CourseKnowledgeId = null; //知识点Id
if (objvCaseCourseKnowledgeRelaEN.KnowledgeName == "[null]") objvCaseCourseKnowledgeRelaEN.KnowledgeName = null; //知识点名称
if (objvCaseCourseKnowledgeRelaEN.KnowledgeTitle == "[null]") objvCaseCourseKnowledgeRelaEN.KnowledgeTitle = null; //知识点标题
if (objvCaseCourseKnowledgeRelaEN.KnowledgeContent == "[null]") objvCaseCourseKnowledgeRelaEN.KnowledgeContent = null; //知识点内容
if (objvCaseCourseKnowledgeRelaEN.CourseId == "[null]") objvCaseCourseKnowledgeRelaEN.CourseId = null; //课程Id
if (objvCaseCourseKnowledgeRelaEN.CourseName == "[null]") objvCaseCourseKnowledgeRelaEN.CourseName = null; //课程名称
if (objvCaseCourseKnowledgeRelaEN.CourseChapterId == "[null]") objvCaseCourseKnowledgeRelaEN.CourseChapterId = null; //课程章节ID
if (objvCaseCourseKnowledgeRelaEN.UpdDate == "[null]") objvCaseCourseKnowledgeRelaEN.UpdDate = null; //修改日期
if (objvCaseCourseKnowledgeRelaEN.UpdUserId == "[null]") objvCaseCourseKnowledgeRelaEN.UpdUserId = null; //修改用户Id
if (objvCaseCourseKnowledgeRelaEN.Memo == "[null]") objvCaseCourseKnowledgeRelaEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaEN)
{
 vCaseCourseKnowledgeRelaDA.CheckProperty4Condition(objvCaseCourseKnowledgeRelaEN);
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
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseCourseKnowledgeRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseCourseKnowledgeRelaBL没有刷新缓存机制(clsCaseCourseKnowledgeRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseCourseKnowledgeRelaTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseCourseKnowledgeRelaTypeBL没有刷新缓存机制(clsCaseCourseKnowledgeRelaTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by IdCaseCourseKnowledgeRela");
//if (arrvCaseCourseKnowledgeRelaObjLstCache == null)
//{
//arrvCaseCourseKnowledgeRelaObjLstCache = vCaseCourseKnowledgeRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdCaseCourseKnowledgeRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseCourseKnowledgeRelaEN GetObjByIdCaseCourseKnowledgeRelaCache(long lngIdCaseCourseKnowledgeRela)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCaseCourseKnowledgeRelaEN._CurrTabName);
List<clsvCaseCourseKnowledgeRelaEN> arrvCaseCourseKnowledgeRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseCourseKnowledgeRelaEN> arrvCaseCourseKnowledgeRelaObjLst_Sel =
arrvCaseCourseKnowledgeRelaObjLstCache
.Where(x=> x.IdCaseCourseKnowledgeRela == lngIdCaseCourseKnowledgeRela 
);
if (arrvCaseCourseKnowledgeRelaObjLst_Sel.Count() == 0)
{
   clsvCaseCourseKnowledgeRelaEN obj = clsvCaseCourseKnowledgeRelaBL.GetObjByIdCaseCourseKnowledgeRela(lngIdCaseCourseKnowledgeRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCaseCourseKnowledgeRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCaseCourseKnowledgeRelaEN> GetAllvCaseCourseKnowledgeRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvCaseCourseKnowledgeRelaEN> arrvCaseCourseKnowledgeRelaObjLstCache = GetObjLstCache(); 
return arrvCaseCourseKnowledgeRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCaseCourseKnowledgeRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCaseCourseKnowledgeRelaEN._CurrTabName);
List<clsvCaseCourseKnowledgeRelaEN> arrvCaseCourseKnowledgeRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCaseCourseKnowledgeRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvCaseCourseKnowledgeRelaEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdCaseCourseKnowledgeRela)
{
if (strInFldName != convCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCaseCourseKnowledgeRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCaseCourseKnowledgeRela.AttributeName));
throw new Exception(strMsg);
}
var objvCaseCourseKnowledgeRela = clsvCaseCourseKnowledgeRelaBL.GetObjByIdCaseCourseKnowledgeRelaCache(lngIdCaseCourseKnowledgeRela);
if (objvCaseCourseKnowledgeRela == null) return "";
return objvCaseCourseKnowledgeRela[strOutFldName].ToString();
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
int intRecCount = clsvCaseCourseKnowledgeRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvCaseCourseKnowledgeRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCaseCourseKnowledgeRelaDA.GetRecCount();
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
int intRecCount = clsvCaseCourseKnowledgeRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCaseCourseKnowledgeRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCaseCourseKnowledgeRelaEN objvCaseCourseKnowledgeRelaCond)
{
List<clsvCaseCourseKnowledgeRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseCourseKnowledgeRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCaseCourseKnowledgeRela.AttributeName)
{
if (objvCaseCourseKnowledgeRelaCond.IsUpdated(strFldName) == false) continue;
if (objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseCourseKnowledgeRelaCond[strFldName].ToString());
}
else
{
if (objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCaseCourseKnowledgeRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseCourseKnowledgeRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCaseCourseKnowledgeRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCaseCourseKnowledgeRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCaseCourseKnowledgeRelaCond[strFldName]));
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
 List<string> arrList = clsvCaseCourseKnowledgeRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCaseCourseKnowledgeRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCaseCourseKnowledgeRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}