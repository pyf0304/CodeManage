
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseCommonBaseBL
 表名:vCaseCommonBase(01120344)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:34
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
public static class  clsvCaseCommonBaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseCommonBaseEN GetObj(this K_IdCase_vCaseCommonBase myKey)
{
clsvCaseCommonBaseEN objvCaseCommonBaseEN = clsvCaseCommonBaseBL.vCaseCommonBaseDA.GetObjByIdCase(myKey.Value);
return objvCaseCommonBaseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetIdCase(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strIdCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCase, 8, convCaseCommonBase.IdCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCase, 8, convCaseCommonBase.IdCase);
}
objvCaseCommonBaseEN.IdCase = strIdCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.IdCase) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.IdCase, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.IdCase] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCaseId(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCaseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseId, 8, convCaseCommonBase.CaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, convCaseCommonBase.CaseId);
}
objvCaseCommonBaseEN.CaseId = strCaseId; //案例Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CaseId) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CaseId, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CaseId] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCaseName(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseName, 100, convCaseCommonBase.CaseName);
}
objvCaseCommonBaseEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CaseName) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CaseName, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CaseName] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCourseName(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCaseCommonBase.CourseName);
}
objvCaseCommonBaseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CourseName) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CourseName, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CourseName] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetFuncModuleId(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCaseCommonBase.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCaseCommonBase.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCaseCommonBase.FuncModuleId);
}
objvCaseCommonBaseEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.FuncModuleId) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.FuncModuleId, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.FuncModuleId] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetFuncModuleName(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convCaseCommonBase.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCaseCommonBase.FuncModuleName);
}
objvCaseCommonBaseEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.FuncModuleName) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.FuncModuleName, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.FuncModuleName] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetFuncModuleNameSim(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convCaseCommonBase.FuncModuleNameSim);
}
objvCaseCommonBaseEN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.FuncModuleNameSim) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.FuncModuleNameSim, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.FuncModuleNameSim] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetOwnerId(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, convCaseCommonBase.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convCaseCommonBase.OwnerId);
}
objvCaseCommonBaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.OwnerId) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.OwnerId, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.OwnerId] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetOwnerName(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convCaseCommonBase.OwnerName);
}
objvCaseCommonBaseEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.OwnerName) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.OwnerName, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.OwnerName] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCourseId(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCaseCommonBase.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCaseCommonBase.CourseId);
}
objvCaseCommonBaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CourseId) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CourseId, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CourseId] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCourseCode(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCaseCommonBase.CourseCode);
}
objvCaseCommonBaseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CourseCode) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CourseCode, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CourseCode] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCourseChapterId(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convCaseCommonBase.CourseChapterId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convCaseCommonBase.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convCaseCommonBase.CourseChapterId);
}
objvCaseCommonBaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CourseChapterId) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CourseChapterId, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CourseChapterId] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCourseChapterName(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterName, convCaseCommonBase.CourseChapterName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convCaseCommonBase.CourseChapterName);
}
objvCaseCommonBaseEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CourseChapterName) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CourseChapterName, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CourseChapterName] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCaseDate(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseDate, 8, convCaseCommonBase.CaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseDate, 8, convCaseCommonBase.CaseDate);
}
objvCaseCommonBaseEN.CaseDate = strCaseDate; //案例建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CaseDate) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CaseDate, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CaseDate] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCaseDateIn(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseDateIn, 8, convCaseCommonBase.CaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseDateIn, 8, convCaseCommonBase.CaseDateIn);
}
objvCaseCommonBaseEN.CaseDateIn = strCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CaseDateIn) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CaseDateIn, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CaseDateIn] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCaseText(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseText, 8000, convCaseCommonBase.CaseText);
}
objvCaseCommonBaseEN.CaseText = strCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CaseText) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CaseText, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CaseText] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCaseTheme(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseTheme, 200, convCaseCommonBase.CaseTheme);
}
objvCaseCommonBaseEN.CaseTheme = strCaseTheme; //案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CaseTheme) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CaseTheme, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CaseTheme] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCaseTime(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseTime, 6, convCaseCommonBase.CaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseTime, 6, convCaseCommonBase.CaseTime);
}
objvCaseCommonBaseEN.CaseTime = strCaseTime; //案例建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CaseTime) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CaseTime, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CaseTime] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCaseTimeIn(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseTimeIn, 6, convCaseCommonBase.CaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseTimeIn, 6, convCaseCommonBase.CaseTimeIn);
}
objvCaseCommonBaseEN.CaseTimeIn = strCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CaseTimeIn) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CaseTimeIn, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CaseTimeIn] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetIsVisible(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvCaseCommonBaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.IsVisible) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.IsVisible, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.IsVisible] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetIdTeachSkill(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, convCaseCommonBase.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convCaseCommonBase.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convCaseCommonBase.IdTeachSkill);
}
objvCaseCommonBaseEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.IdTeachSkill) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.IdTeachSkill, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.IdTeachSkill] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetIdDiscipline(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convCaseCommonBase.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convCaseCommonBase.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convCaseCommonBase.IdDiscipline);
}
objvCaseCommonBaseEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.IdDiscipline) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.IdDiscipline, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.IdDiscipline] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetIdStudyLevel(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudyLevel, convCaseCommonBase.IdStudyLevel);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convCaseCommonBase.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convCaseCommonBase.IdStudyLevel);
}
objvCaseCommonBaseEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.IdStudyLevel) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.IdStudyLevel, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.IdStudyLevel] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetIdCaseType(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strIdCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCaseType, convCaseCommonBase.IdCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, convCaseCommonBase.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, convCaseCommonBase.IdCaseType);
}
objvCaseCommonBaseEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.IdCaseType) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.IdCaseType, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.IdCaseType] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetIdTeachingPlan(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachingPlan, convCaseCommonBase.IdTeachingPlan);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convCaseCommonBase.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convCaseCommonBase.IdTeachingPlan);
}
objvCaseCommonBaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.IdTeachingPlan) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.IdTeachingPlan, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.IdTeachingPlan] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetIdXzMajor(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strIdXzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzMajor, convCaseCommonBase.IdXzMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convCaseCommonBase.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convCaseCommonBase.IdXzMajor);
}
objvCaseCommonBaseEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.IdXzMajor) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.IdXzMajor, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.IdXzMajor] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetBrowseCount(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, int? intBrowseCount, string strComparisonOp="")
	{
objvCaseCommonBaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.BrowseCount) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.BrowseCount, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.BrowseCount] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetIdSenateGaugeVersion(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSenateGaugeVersion, convCaseCommonBase.IdSenateGaugeVersion);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convCaseCommonBase.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convCaseCommonBase.IdSenateGaugeVersion);
}
objvCaseCommonBaseEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.IdSenateGaugeVersion) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetDocFile(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strDocFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDocFile, 200, convCaseCommonBase.DocFile);
}
objvCaseCommonBaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.DocFile) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.DocFile, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.DocFile] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetIsNeedGeneWord(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objvCaseCommonBaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.IsNeedGeneWord) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.IsNeedGeneWord, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.IsNeedGeneWord] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetMemo(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCaseCommonBase.Memo);
}
objvCaseCommonBaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.Memo) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.Memo, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.Memo] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetUpdUserId(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convCaseCommonBase.UpdUserId);
}
objvCaseCommonBaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.UpdUserId) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.UpdUserId, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.UpdUserId] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetIsDualVideo(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDualVideo, convCaseCommonBase.IsDualVideo);
objvCaseCommonBaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.IsDualVideo) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.IsDualVideo, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.IsDualVideo] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetLikeCount(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, long? lngLikeCount, string strComparisonOp="")
	{
objvCaseCommonBaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.LikeCount) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.LikeCount, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.LikeCount] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetWordCreateDate(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strWordCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, convCaseCommonBase.WordCreateDate);
}
objvCaseCommonBaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.WordCreateDate) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.WordCreateDate, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.WordCreateDate] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetUpdDate(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCaseCommonBase.UpdDate);
}
objvCaseCommonBaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.UpdDate) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.UpdDate, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.UpdDate] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCaseLevelId(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, convCaseCommonBase.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, convCaseCommonBase.CaseLevelId);
}
objvCaseCommonBaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CaseLevelId) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CaseLevelId, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CaseLevelId] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetViewCount(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, int? intViewCount, string strComparisonOp="")
	{
objvCaseCommonBaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.ViewCount) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.ViewCount, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.ViewCount] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetIsShow(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, bool bolIsShow, string strComparisonOp="")
	{
objvCaseCommonBaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.IsShow) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.IsShow, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.IsShow] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetDownloadNumber(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, int? intDownloadNumber, string strComparisonOp="")
	{
objvCaseCommonBaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.DownloadNumber) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.DownloadNumber, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.DownloadNumber] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetFileIntegration(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, int? intFileIntegration, string strComparisonOp="")
	{
objvCaseCommonBaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.FileIntegration) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.FileIntegration, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.FileIntegration] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseCommonBaseEN SetCollectionCount(this clsvCaseCommonBaseEN objvCaseCommonBaseEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvCaseCommonBaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(convCaseCommonBase.CollectionCount) == false)
{
objvCaseCommonBaseEN.dicFldComparisonOp.Add(convCaseCommonBase.CollectionCount, strComparisonOp);
}
else
{
objvCaseCommonBaseEN.dicFldComparisonOp[convCaseCommonBase.CollectionCount] = strComparisonOp;
}
}
return objvCaseCommonBaseEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCaseCommonBaseENS">源对象</param>
 /// <param name = "objvCaseCommonBaseENT">目标对象</param>
 public static void CopyTo(this clsvCaseCommonBaseEN objvCaseCommonBaseENS, clsvCaseCommonBaseEN objvCaseCommonBaseENT)
{
try
{
objvCaseCommonBaseENT.IdCase = objvCaseCommonBaseENS.IdCase; //案例流水号
objvCaseCommonBaseENT.CaseId = objvCaseCommonBaseENS.CaseId; //案例Id
objvCaseCommonBaseENT.CaseName = objvCaseCommonBaseENS.CaseName; //案例名称
objvCaseCommonBaseENT.CourseName = objvCaseCommonBaseENS.CourseName; //课程名称
objvCaseCommonBaseENT.FuncModuleId = objvCaseCommonBaseENS.FuncModuleId; //功能模块Id
objvCaseCommonBaseENT.FuncModuleName = objvCaseCommonBaseENS.FuncModuleName; //功能模块名称
objvCaseCommonBaseENT.FuncModuleNameSim = objvCaseCommonBaseENS.FuncModuleNameSim; //功能模块简称
objvCaseCommonBaseENT.OwnerId = objvCaseCommonBaseENS.OwnerId; //拥有者Id
objvCaseCommonBaseENT.OwnerName = objvCaseCommonBaseENS.OwnerName; //拥有者姓名
objvCaseCommonBaseENT.CourseId = objvCaseCommonBaseENS.CourseId; //课程Id
objvCaseCommonBaseENT.CourseCode = objvCaseCommonBaseENS.CourseCode; //课程代码
objvCaseCommonBaseENT.CourseChapterId = objvCaseCommonBaseENS.CourseChapterId; //课程章节ID
objvCaseCommonBaseENT.CourseChapterName = objvCaseCommonBaseENS.CourseChapterName; //课程章节名称
objvCaseCommonBaseENT.CaseDate = objvCaseCommonBaseENS.CaseDate; //案例建立日期
objvCaseCommonBaseENT.CaseDateIn = objvCaseCommonBaseENS.CaseDateIn; //案例入库日期
objvCaseCommonBaseENT.CaseText = objvCaseCommonBaseENS.CaseText; //案例文本内容
objvCaseCommonBaseENT.CaseTheme = objvCaseCommonBaseENS.CaseTheme; //案例主题词
objvCaseCommonBaseENT.CaseTime = objvCaseCommonBaseENS.CaseTime; //案例建立时间
objvCaseCommonBaseENT.CaseTimeIn = objvCaseCommonBaseENS.CaseTimeIn; //案例入库时间
objvCaseCommonBaseENT.IsVisible = objvCaseCommonBaseENS.IsVisible; //是否显示
objvCaseCommonBaseENT.IdTeachSkill = objvCaseCommonBaseENS.IdTeachSkill; //教学技能流水号
objvCaseCommonBaseENT.IdDiscipline = objvCaseCommonBaseENS.IdDiscipline; //学科流水号
objvCaseCommonBaseENT.IdStudyLevel = objvCaseCommonBaseENS.IdStudyLevel; //id_StudyLevel
objvCaseCommonBaseENT.IdCaseType = objvCaseCommonBaseENS.IdCaseType; //案例类型流水号
objvCaseCommonBaseENT.IdTeachingPlan = objvCaseCommonBaseENS.IdTeachingPlan; //教案流水号
objvCaseCommonBaseENT.IdXzMajor = objvCaseCommonBaseENS.IdXzMajor; //专业流水号
objvCaseCommonBaseENT.BrowseCount = objvCaseCommonBaseENS.BrowseCount; //浏览次数
objvCaseCommonBaseENT.IdSenateGaugeVersion = objvCaseCommonBaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCaseCommonBaseENT.DocFile = objvCaseCommonBaseENS.DocFile; //生成的Word文件名
objvCaseCommonBaseENT.IsNeedGeneWord = objvCaseCommonBaseENS.IsNeedGeneWord; //是否需要生成Word
objvCaseCommonBaseENT.Memo = objvCaseCommonBaseENS.Memo; //备注
objvCaseCommonBaseENT.UpdUserId = objvCaseCommonBaseENS.UpdUserId; //修改用户Id
objvCaseCommonBaseENT.IsDualVideo = objvCaseCommonBaseENS.IsDualVideo; //是否双视频
objvCaseCommonBaseENT.LikeCount = objvCaseCommonBaseENS.LikeCount; //资源喜欢数量
objvCaseCommonBaseENT.WordCreateDate = objvCaseCommonBaseENS.WordCreateDate; //Word生成日期
objvCaseCommonBaseENT.UpdDate = objvCaseCommonBaseENS.UpdDate; //修改日期
objvCaseCommonBaseENT.CaseLevelId = objvCaseCommonBaseENS.CaseLevelId; //课例等级Id
objvCaseCommonBaseENT.ViewCount = objvCaseCommonBaseENS.ViewCount; //浏览量
objvCaseCommonBaseENT.IsShow = objvCaseCommonBaseENS.IsShow; //是否启用
objvCaseCommonBaseENT.DownloadNumber = objvCaseCommonBaseENS.DownloadNumber; //下载数目
objvCaseCommonBaseENT.FileIntegration = objvCaseCommonBaseENS.FileIntegration; //文件积分
objvCaseCommonBaseENT.CollectionCount = objvCaseCommonBaseENS.CollectionCount; //收藏数量
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
 /// <param name = "objvCaseCommonBaseENS">源对象</param>
 /// <returns>目标对象=>clsvCaseCommonBaseEN:objvCaseCommonBaseENT</returns>
 public static clsvCaseCommonBaseEN CopyTo(this clsvCaseCommonBaseEN objvCaseCommonBaseENS)
{
try
{
 clsvCaseCommonBaseEN objvCaseCommonBaseENT = new clsvCaseCommonBaseEN()
{
IdCase = objvCaseCommonBaseENS.IdCase, //案例流水号
CaseId = objvCaseCommonBaseENS.CaseId, //案例Id
CaseName = objvCaseCommonBaseENS.CaseName, //案例名称
CourseName = objvCaseCommonBaseENS.CourseName, //课程名称
FuncModuleId = objvCaseCommonBaseENS.FuncModuleId, //功能模块Id
FuncModuleName = objvCaseCommonBaseENS.FuncModuleName, //功能模块名称
FuncModuleNameSim = objvCaseCommonBaseENS.FuncModuleNameSim, //功能模块简称
OwnerId = objvCaseCommonBaseENS.OwnerId, //拥有者Id
OwnerName = objvCaseCommonBaseENS.OwnerName, //拥有者姓名
CourseId = objvCaseCommonBaseENS.CourseId, //课程Id
CourseCode = objvCaseCommonBaseENS.CourseCode, //课程代码
CourseChapterId = objvCaseCommonBaseENS.CourseChapterId, //课程章节ID
CourseChapterName = objvCaseCommonBaseENS.CourseChapterName, //课程章节名称
CaseDate = objvCaseCommonBaseENS.CaseDate, //案例建立日期
CaseDateIn = objvCaseCommonBaseENS.CaseDateIn, //案例入库日期
CaseText = objvCaseCommonBaseENS.CaseText, //案例文本内容
CaseTheme = objvCaseCommonBaseENS.CaseTheme, //案例主题词
CaseTime = objvCaseCommonBaseENS.CaseTime, //案例建立时间
CaseTimeIn = objvCaseCommonBaseENS.CaseTimeIn, //案例入库时间
IsVisible = objvCaseCommonBaseENS.IsVisible, //是否显示
IdTeachSkill = objvCaseCommonBaseENS.IdTeachSkill, //教学技能流水号
IdDiscipline = objvCaseCommonBaseENS.IdDiscipline, //学科流水号
IdStudyLevel = objvCaseCommonBaseENS.IdStudyLevel, //id_StudyLevel
IdCaseType = objvCaseCommonBaseENS.IdCaseType, //案例类型流水号
IdTeachingPlan = objvCaseCommonBaseENS.IdTeachingPlan, //教案流水号
IdXzMajor = objvCaseCommonBaseENS.IdXzMajor, //专业流水号
BrowseCount = objvCaseCommonBaseENS.BrowseCount, //浏览次数
IdSenateGaugeVersion = objvCaseCommonBaseENS.IdSenateGaugeVersion, //评价量表版本流水号
DocFile = objvCaseCommonBaseENS.DocFile, //生成的Word文件名
IsNeedGeneWord = objvCaseCommonBaseENS.IsNeedGeneWord, //是否需要生成Word
Memo = objvCaseCommonBaseENS.Memo, //备注
UpdUserId = objvCaseCommonBaseENS.UpdUserId, //修改用户Id
IsDualVideo = objvCaseCommonBaseENS.IsDualVideo, //是否双视频
LikeCount = objvCaseCommonBaseENS.LikeCount, //资源喜欢数量
WordCreateDate = objvCaseCommonBaseENS.WordCreateDate, //Word生成日期
UpdDate = objvCaseCommonBaseENS.UpdDate, //修改日期
CaseLevelId = objvCaseCommonBaseENS.CaseLevelId, //课例等级Id
ViewCount = objvCaseCommonBaseENS.ViewCount, //浏览量
IsShow = objvCaseCommonBaseENS.IsShow, //是否启用
DownloadNumber = objvCaseCommonBaseENS.DownloadNumber, //下载数目
FileIntegration = objvCaseCommonBaseENS.FileIntegration, //文件积分
CollectionCount = objvCaseCommonBaseENS.CollectionCount, //收藏数量
};
 return objvCaseCommonBaseENT;
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
public static void CheckProperty4Condition(this clsvCaseCommonBaseEN objvCaseCommonBaseEN)
{
 clsvCaseCommonBaseBL.vCaseCommonBaseDA.CheckProperty4Condition(objvCaseCommonBaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCaseCommonBaseEN objvCaseCommonBaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.IdCase) == true)
{
string strComparisonOpIdCase = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.IdCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.IdCase, objvCaseCommonBaseCond.IdCase, strComparisonOpIdCase);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.CaseId) == true)
{
string strComparisonOpCaseId = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CaseId, objvCaseCommonBaseCond.CaseId, strComparisonOpCaseId);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.CaseName) == true)
{
string strComparisonOpCaseName = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CaseName, objvCaseCommonBaseCond.CaseName, strComparisonOpCaseName);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.CourseName) == true)
{
string strComparisonOpCourseName = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CourseName, objvCaseCommonBaseCond.CourseName, strComparisonOpCourseName);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.FuncModuleId, objvCaseCommonBaseCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.FuncModuleName, objvCaseCommonBaseCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.FuncModuleNameSim, objvCaseCommonBaseCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.OwnerId) == true)
{
string strComparisonOpOwnerId = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.OwnerId, objvCaseCommonBaseCond.OwnerId, strComparisonOpOwnerId);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.OwnerName) == true)
{
string strComparisonOpOwnerName = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.OwnerName, objvCaseCommonBaseCond.OwnerName, strComparisonOpOwnerName);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.CourseId) == true)
{
string strComparisonOpCourseId = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CourseId, objvCaseCommonBaseCond.CourseId, strComparisonOpCourseId);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.CourseCode) == true)
{
string strComparisonOpCourseCode = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CourseCode, objvCaseCommonBaseCond.CourseCode, strComparisonOpCourseCode);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CourseChapterId, objvCaseCommonBaseCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CourseChapterName, objvCaseCommonBaseCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.CaseDate) == true)
{
string strComparisonOpCaseDate = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.CaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CaseDate, objvCaseCommonBaseCond.CaseDate, strComparisonOpCaseDate);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.CaseDateIn) == true)
{
string strComparisonOpCaseDateIn = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.CaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CaseDateIn, objvCaseCommonBaseCond.CaseDateIn, strComparisonOpCaseDateIn);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.CaseText) == true)
{
string strComparisonOpCaseText = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.CaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CaseText, objvCaseCommonBaseCond.CaseText, strComparisonOpCaseText);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.CaseTheme) == true)
{
string strComparisonOpCaseTheme = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.CaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CaseTheme, objvCaseCommonBaseCond.CaseTheme, strComparisonOpCaseTheme);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.CaseTime) == true)
{
string strComparisonOpCaseTime = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.CaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CaseTime, objvCaseCommonBaseCond.CaseTime, strComparisonOpCaseTime);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.CaseTimeIn) == true)
{
string strComparisonOpCaseTimeIn = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.CaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CaseTimeIn, objvCaseCommonBaseCond.CaseTimeIn, strComparisonOpCaseTimeIn);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.IsVisible) == true)
{
if (objvCaseCommonBaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCaseCommonBase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCaseCommonBase.IsVisible);
}
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.IdTeachSkill, objvCaseCommonBaseCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.IdDiscipline, objvCaseCommonBaseCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.IdStudyLevel, objvCaseCommonBaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.IdCaseType, objvCaseCommonBaseCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.IdTeachingPlan, objvCaseCommonBaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.IdXzMajor, objvCaseCommonBaseCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCommonBase.BrowseCount, objvCaseCommonBaseCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.IdSenateGaugeVersion, objvCaseCommonBaseCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.DocFile) == true)
{
string strComparisonOpDocFile = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.DocFile, objvCaseCommonBaseCond.DocFile, strComparisonOpDocFile);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.IsNeedGeneWord) == true)
{
if (objvCaseCommonBaseCond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCaseCommonBase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCaseCommonBase.IsNeedGeneWord);
}
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.Memo) == true)
{
string strComparisonOpMemo = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.Memo, objvCaseCommonBaseCond.Memo, strComparisonOpMemo);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.UpdUserId, objvCaseCommonBaseCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.IsDualVideo) == true)
{
if (objvCaseCommonBaseCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCaseCommonBase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCaseCommonBase.IsDualVideo);
}
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.LikeCount) == true)
{
string strComparisonOpLikeCount = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCommonBase.LikeCount, objvCaseCommonBaseCond.LikeCount, strComparisonOpLikeCount);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.WordCreateDate) == true)
{
string strComparisonOpWordCreateDate = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.WordCreateDate, objvCaseCommonBaseCond.WordCreateDate, strComparisonOpWordCreateDate);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.UpdDate, objvCaseCommonBaseCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseCommonBase.CaseLevelId, objvCaseCommonBaseCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.ViewCount) == true)
{
string strComparisonOpViewCount = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCommonBase.ViewCount, objvCaseCommonBaseCond.ViewCount, strComparisonOpViewCount);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.IsShow) == true)
{
if (objvCaseCommonBaseCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCaseCommonBase.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCaseCommonBase.IsShow);
}
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCommonBase.DownloadNumber, objvCaseCommonBaseCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.FileIntegration) == true)
{
string strComparisonOpFileIntegration = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCommonBase.FileIntegration, objvCaseCommonBaseCond.FileIntegration, strComparisonOpFileIntegration);
}
if (objvCaseCommonBaseCond.IsUpdated(convCaseCommonBase.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvCaseCommonBaseCond.dicFldComparisonOp[convCaseCommonBase.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseCommonBase.CollectionCount, objvCaseCommonBaseCond.CollectionCount, strComparisonOpCollectionCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCaseCommonBase
{
public virtual bool UpdRelaTabDate(string strIdCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v案例公共基类(vCaseCommonBase)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCaseCommonBaseBL
{
public static RelatedActions_vCaseCommonBase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCaseCommonBaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCaseCommonBaseDA vCaseCommonBaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCaseCommonBaseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCaseCommonBaseBL()
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
if (string.IsNullOrEmpty(clsvCaseCommonBaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCaseCommonBaseEN._ConnectString);
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
public static DataTable GetDataTable_vCaseCommonBase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCaseCommonBaseDA.GetDataTable_vCaseCommonBase(strWhereCond);
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
objDT = vCaseCommonBaseDA.GetDataTable(strWhereCond);
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
objDT = vCaseCommonBaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCaseCommonBaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCaseCommonBaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCaseCommonBaseDA.GetDataTable_Top(objTopPara);
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
objDT = vCaseCommonBaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCaseCommonBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCaseCommonBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCaseCommonBaseEN> GetObjLstByIdCaseLst(List<string> arrIdCaseLst)
{
List<clsvCaseCommonBaseEN> arrObjLst = new List<clsvCaseCommonBaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCaseLst, true);
 string strWhereCond = string.Format("IdCase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCommonBaseEN objvCaseCommonBaseEN = new clsvCaseCommonBaseEN();
try
{
objvCaseCommonBaseEN.IdCase = objRow[convCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objvCaseCommonBaseEN.CaseId = objRow[convCaseCommonBase.CaseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objvCaseCommonBaseEN.CaseName = objRow[convCaseCommonBase.CaseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objvCaseCommonBaseEN.CourseName = objRow[convCaseCommonBase.CourseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseName].ToString().Trim(); //课程名称
objvCaseCommonBaseEN.FuncModuleId = objRow[convCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCommonBaseEN.FuncModuleName = objRow[convCaseCommonBase.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCommonBaseEN.FuncModuleNameSim = objRow[convCaseCommonBase.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCaseCommonBase.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCaseCommonBaseEN.OwnerId = objRow[convCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCommonBaseEN.OwnerName = objRow[convCaseCommonBase.OwnerName] == DBNull.Value ? null : objRow[convCaseCommonBase.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCommonBaseEN.CourseId = objRow[convCaseCommonBase.CourseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objvCaseCommonBaseEN.CourseCode = objRow[convCaseCommonBase.CourseCode] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseCode].ToString().Trim(); //课程代码
objvCaseCommonBaseEN.CourseChapterId = objRow[convCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCommonBaseEN.CourseChapterName = objRow[convCaseCommonBase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCaseCommonBaseEN.CaseDate = objRow[convCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objvCaseCommonBaseEN.CaseDateIn = objRow[convCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objvCaseCommonBaseEN.CaseText = objRow[convCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objvCaseCommonBaseEN.CaseTheme = objRow[convCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objvCaseCommonBaseEN.CaseTime = objRow[convCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objvCaseCommonBaseEN.CaseTimeIn = objRow[convCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objvCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objvCaseCommonBaseEN.IdTeachSkill = objRow[convCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCaseCommonBaseEN.IdDiscipline = objRow[convCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objvCaseCommonBaseEN.IdStudyLevel = objRow[convCaseCommonBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCaseCommonBaseEN.IdCaseType = objRow[convCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCaseCommonBaseEN.IdTeachingPlan = objRow[convCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCaseCommonBaseEN.IdXzMajor = objRow[convCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objvCaseCommonBaseEN.BrowseCount = objRow[convCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCommonBaseEN.IdSenateGaugeVersion = objRow[convCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCaseCommonBaseEN.DocFile = objRow[convCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[convCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objvCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCaseCommonBaseEN.Memo = objRow[convCaseCommonBase.Memo] == DBNull.Value ? null : objRow[convCaseCommonBase.Memo].ToString().Trim(); //备注
objvCaseCommonBaseEN.UpdUserId = objRow[convCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objvCaseCommonBaseEN.LikeCount = objRow[convCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCaseCommonBaseEN.WordCreateDate = objRow[convCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[convCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCaseCommonBaseEN.UpdDate = objRow[convCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objvCaseCommonBaseEN.CaseLevelId = objRow[convCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCaseCommonBaseEN.ViewCount = objRow[convCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objvCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objvCaseCommonBaseEN.DownloadNumber = objRow[convCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objvCaseCommonBaseEN.FileIntegration = objRow[convCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objvCaseCommonBaseEN.CollectionCount = objRow[convCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCommonBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCaseCommonBaseEN> GetObjLstByIdCaseLstCache(List<string> arrIdCaseLst)
{
string strKey = string.Format("{0}", clsvCaseCommonBaseEN._CurrTabName);
List<clsvCaseCommonBaseEN> arrvCaseCommonBaseObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseCommonBaseEN> arrvCaseCommonBaseObjLst_Sel =
arrvCaseCommonBaseObjLstCache
.Where(x => arrIdCaseLst.Contains(x.IdCase));
return arrvCaseCommonBaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseCommonBaseEN> GetObjLst(string strWhereCond)
{
List<clsvCaseCommonBaseEN> arrObjLst = new List<clsvCaseCommonBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCommonBaseEN objvCaseCommonBaseEN = new clsvCaseCommonBaseEN();
try
{
objvCaseCommonBaseEN.IdCase = objRow[convCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objvCaseCommonBaseEN.CaseId = objRow[convCaseCommonBase.CaseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objvCaseCommonBaseEN.CaseName = objRow[convCaseCommonBase.CaseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objvCaseCommonBaseEN.CourseName = objRow[convCaseCommonBase.CourseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseName].ToString().Trim(); //课程名称
objvCaseCommonBaseEN.FuncModuleId = objRow[convCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCommonBaseEN.FuncModuleName = objRow[convCaseCommonBase.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCommonBaseEN.FuncModuleNameSim = objRow[convCaseCommonBase.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCaseCommonBase.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCaseCommonBaseEN.OwnerId = objRow[convCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCommonBaseEN.OwnerName = objRow[convCaseCommonBase.OwnerName] == DBNull.Value ? null : objRow[convCaseCommonBase.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCommonBaseEN.CourseId = objRow[convCaseCommonBase.CourseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objvCaseCommonBaseEN.CourseCode = objRow[convCaseCommonBase.CourseCode] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseCode].ToString().Trim(); //课程代码
objvCaseCommonBaseEN.CourseChapterId = objRow[convCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCommonBaseEN.CourseChapterName = objRow[convCaseCommonBase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCaseCommonBaseEN.CaseDate = objRow[convCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objvCaseCommonBaseEN.CaseDateIn = objRow[convCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objvCaseCommonBaseEN.CaseText = objRow[convCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objvCaseCommonBaseEN.CaseTheme = objRow[convCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objvCaseCommonBaseEN.CaseTime = objRow[convCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objvCaseCommonBaseEN.CaseTimeIn = objRow[convCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objvCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objvCaseCommonBaseEN.IdTeachSkill = objRow[convCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCaseCommonBaseEN.IdDiscipline = objRow[convCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objvCaseCommonBaseEN.IdStudyLevel = objRow[convCaseCommonBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCaseCommonBaseEN.IdCaseType = objRow[convCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCaseCommonBaseEN.IdTeachingPlan = objRow[convCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCaseCommonBaseEN.IdXzMajor = objRow[convCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objvCaseCommonBaseEN.BrowseCount = objRow[convCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCommonBaseEN.IdSenateGaugeVersion = objRow[convCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCaseCommonBaseEN.DocFile = objRow[convCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[convCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objvCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCaseCommonBaseEN.Memo = objRow[convCaseCommonBase.Memo] == DBNull.Value ? null : objRow[convCaseCommonBase.Memo].ToString().Trim(); //备注
objvCaseCommonBaseEN.UpdUserId = objRow[convCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objvCaseCommonBaseEN.LikeCount = objRow[convCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCaseCommonBaseEN.WordCreateDate = objRow[convCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[convCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCaseCommonBaseEN.UpdDate = objRow[convCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objvCaseCommonBaseEN.CaseLevelId = objRow[convCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCaseCommonBaseEN.ViewCount = objRow[convCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objvCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objvCaseCommonBaseEN.DownloadNumber = objRow[convCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objvCaseCommonBaseEN.FileIntegration = objRow[convCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objvCaseCommonBaseEN.CollectionCount = objRow[convCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCommonBaseEN);
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
public static List<clsvCaseCommonBaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCaseCommonBaseEN> arrObjLst = new List<clsvCaseCommonBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCommonBaseEN objvCaseCommonBaseEN = new clsvCaseCommonBaseEN();
try
{
objvCaseCommonBaseEN.IdCase = objRow[convCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objvCaseCommonBaseEN.CaseId = objRow[convCaseCommonBase.CaseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objvCaseCommonBaseEN.CaseName = objRow[convCaseCommonBase.CaseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objvCaseCommonBaseEN.CourseName = objRow[convCaseCommonBase.CourseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseName].ToString().Trim(); //课程名称
objvCaseCommonBaseEN.FuncModuleId = objRow[convCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCommonBaseEN.FuncModuleName = objRow[convCaseCommonBase.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCommonBaseEN.FuncModuleNameSim = objRow[convCaseCommonBase.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCaseCommonBase.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCaseCommonBaseEN.OwnerId = objRow[convCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCommonBaseEN.OwnerName = objRow[convCaseCommonBase.OwnerName] == DBNull.Value ? null : objRow[convCaseCommonBase.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCommonBaseEN.CourseId = objRow[convCaseCommonBase.CourseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objvCaseCommonBaseEN.CourseCode = objRow[convCaseCommonBase.CourseCode] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseCode].ToString().Trim(); //课程代码
objvCaseCommonBaseEN.CourseChapterId = objRow[convCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCommonBaseEN.CourseChapterName = objRow[convCaseCommonBase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCaseCommonBaseEN.CaseDate = objRow[convCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objvCaseCommonBaseEN.CaseDateIn = objRow[convCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objvCaseCommonBaseEN.CaseText = objRow[convCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objvCaseCommonBaseEN.CaseTheme = objRow[convCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objvCaseCommonBaseEN.CaseTime = objRow[convCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objvCaseCommonBaseEN.CaseTimeIn = objRow[convCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objvCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objvCaseCommonBaseEN.IdTeachSkill = objRow[convCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCaseCommonBaseEN.IdDiscipline = objRow[convCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objvCaseCommonBaseEN.IdStudyLevel = objRow[convCaseCommonBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCaseCommonBaseEN.IdCaseType = objRow[convCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCaseCommonBaseEN.IdTeachingPlan = objRow[convCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCaseCommonBaseEN.IdXzMajor = objRow[convCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objvCaseCommonBaseEN.BrowseCount = objRow[convCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCommonBaseEN.IdSenateGaugeVersion = objRow[convCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCaseCommonBaseEN.DocFile = objRow[convCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[convCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objvCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCaseCommonBaseEN.Memo = objRow[convCaseCommonBase.Memo] == DBNull.Value ? null : objRow[convCaseCommonBase.Memo].ToString().Trim(); //备注
objvCaseCommonBaseEN.UpdUserId = objRow[convCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objvCaseCommonBaseEN.LikeCount = objRow[convCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCaseCommonBaseEN.WordCreateDate = objRow[convCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[convCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCaseCommonBaseEN.UpdDate = objRow[convCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objvCaseCommonBaseEN.CaseLevelId = objRow[convCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCaseCommonBaseEN.ViewCount = objRow[convCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objvCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objvCaseCommonBaseEN.DownloadNumber = objRow[convCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objvCaseCommonBaseEN.FileIntegration = objRow[convCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objvCaseCommonBaseEN.CollectionCount = objRow[convCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCommonBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCaseCommonBaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCaseCommonBaseEN> GetSubObjLstCache(clsvCaseCommonBaseEN objvCaseCommonBaseCond)
{
List<clsvCaseCommonBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseCommonBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCaseCommonBase.AttributeName)
{
if (objvCaseCommonBaseCond.IsUpdated(strFldName) == false) continue;
if (objvCaseCommonBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseCommonBaseCond[strFldName].ToString());
}
else
{
if (objvCaseCommonBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCaseCommonBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseCommonBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCaseCommonBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCaseCommonBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCaseCommonBaseCond[strFldName]));
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
public static List<clsvCaseCommonBaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCaseCommonBaseEN> arrObjLst = new List<clsvCaseCommonBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCommonBaseEN objvCaseCommonBaseEN = new clsvCaseCommonBaseEN();
try
{
objvCaseCommonBaseEN.IdCase = objRow[convCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objvCaseCommonBaseEN.CaseId = objRow[convCaseCommonBase.CaseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objvCaseCommonBaseEN.CaseName = objRow[convCaseCommonBase.CaseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objvCaseCommonBaseEN.CourseName = objRow[convCaseCommonBase.CourseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseName].ToString().Trim(); //课程名称
objvCaseCommonBaseEN.FuncModuleId = objRow[convCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCommonBaseEN.FuncModuleName = objRow[convCaseCommonBase.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCommonBaseEN.FuncModuleNameSim = objRow[convCaseCommonBase.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCaseCommonBase.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCaseCommonBaseEN.OwnerId = objRow[convCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCommonBaseEN.OwnerName = objRow[convCaseCommonBase.OwnerName] == DBNull.Value ? null : objRow[convCaseCommonBase.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCommonBaseEN.CourseId = objRow[convCaseCommonBase.CourseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objvCaseCommonBaseEN.CourseCode = objRow[convCaseCommonBase.CourseCode] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseCode].ToString().Trim(); //课程代码
objvCaseCommonBaseEN.CourseChapterId = objRow[convCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCommonBaseEN.CourseChapterName = objRow[convCaseCommonBase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCaseCommonBaseEN.CaseDate = objRow[convCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objvCaseCommonBaseEN.CaseDateIn = objRow[convCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objvCaseCommonBaseEN.CaseText = objRow[convCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objvCaseCommonBaseEN.CaseTheme = objRow[convCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objvCaseCommonBaseEN.CaseTime = objRow[convCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objvCaseCommonBaseEN.CaseTimeIn = objRow[convCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objvCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objvCaseCommonBaseEN.IdTeachSkill = objRow[convCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCaseCommonBaseEN.IdDiscipline = objRow[convCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objvCaseCommonBaseEN.IdStudyLevel = objRow[convCaseCommonBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCaseCommonBaseEN.IdCaseType = objRow[convCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCaseCommonBaseEN.IdTeachingPlan = objRow[convCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCaseCommonBaseEN.IdXzMajor = objRow[convCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objvCaseCommonBaseEN.BrowseCount = objRow[convCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCommonBaseEN.IdSenateGaugeVersion = objRow[convCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCaseCommonBaseEN.DocFile = objRow[convCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[convCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objvCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCaseCommonBaseEN.Memo = objRow[convCaseCommonBase.Memo] == DBNull.Value ? null : objRow[convCaseCommonBase.Memo].ToString().Trim(); //备注
objvCaseCommonBaseEN.UpdUserId = objRow[convCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objvCaseCommonBaseEN.LikeCount = objRow[convCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCaseCommonBaseEN.WordCreateDate = objRow[convCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[convCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCaseCommonBaseEN.UpdDate = objRow[convCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objvCaseCommonBaseEN.CaseLevelId = objRow[convCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCaseCommonBaseEN.ViewCount = objRow[convCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objvCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objvCaseCommonBaseEN.DownloadNumber = objRow[convCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objvCaseCommonBaseEN.FileIntegration = objRow[convCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objvCaseCommonBaseEN.CollectionCount = objRow[convCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCommonBaseEN);
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
public static List<clsvCaseCommonBaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCaseCommonBaseEN> arrObjLst = new List<clsvCaseCommonBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCommonBaseEN objvCaseCommonBaseEN = new clsvCaseCommonBaseEN();
try
{
objvCaseCommonBaseEN.IdCase = objRow[convCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objvCaseCommonBaseEN.CaseId = objRow[convCaseCommonBase.CaseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objvCaseCommonBaseEN.CaseName = objRow[convCaseCommonBase.CaseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objvCaseCommonBaseEN.CourseName = objRow[convCaseCommonBase.CourseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseName].ToString().Trim(); //课程名称
objvCaseCommonBaseEN.FuncModuleId = objRow[convCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCommonBaseEN.FuncModuleName = objRow[convCaseCommonBase.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCommonBaseEN.FuncModuleNameSim = objRow[convCaseCommonBase.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCaseCommonBase.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCaseCommonBaseEN.OwnerId = objRow[convCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCommonBaseEN.OwnerName = objRow[convCaseCommonBase.OwnerName] == DBNull.Value ? null : objRow[convCaseCommonBase.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCommonBaseEN.CourseId = objRow[convCaseCommonBase.CourseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objvCaseCommonBaseEN.CourseCode = objRow[convCaseCommonBase.CourseCode] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseCode].ToString().Trim(); //课程代码
objvCaseCommonBaseEN.CourseChapterId = objRow[convCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCommonBaseEN.CourseChapterName = objRow[convCaseCommonBase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCaseCommonBaseEN.CaseDate = objRow[convCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objvCaseCommonBaseEN.CaseDateIn = objRow[convCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objvCaseCommonBaseEN.CaseText = objRow[convCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objvCaseCommonBaseEN.CaseTheme = objRow[convCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objvCaseCommonBaseEN.CaseTime = objRow[convCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objvCaseCommonBaseEN.CaseTimeIn = objRow[convCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objvCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objvCaseCommonBaseEN.IdTeachSkill = objRow[convCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCaseCommonBaseEN.IdDiscipline = objRow[convCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objvCaseCommonBaseEN.IdStudyLevel = objRow[convCaseCommonBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCaseCommonBaseEN.IdCaseType = objRow[convCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCaseCommonBaseEN.IdTeachingPlan = objRow[convCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCaseCommonBaseEN.IdXzMajor = objRow[convCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objvCaseCommonBaseEN.BrowseCount = objRow[convCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCommonBaseEN.IdSenateGaugeVersion = objRow[convCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCaseCommonBaseEN.DocFile = objRow[convCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[convCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objvCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCaseCommonBaseEN.Memo = objRow[convCaseCommonBase.Memo] == DBNull.Value ? null : objRow[convCaseCommonBase.Memo].ToString().Trim(); //备注
objvCaseCommonBaseEN.UpdUserId = objRow[convCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objvCaseCommonBaseEN.LikeCount = objRow[convCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCaseCommonBaseEN.WordCreateDate = objRow[convCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[convCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCaseCommonBaseEN.UpdDate = objRow[convCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objvCaseCommonBaseEN.CaseLevelId = objRow[convCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCaseCommonBaseEN.ViewCount = objRow[convCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objvCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objvCaseCommonBaseEN.DownloadNumber = objRow[convCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objvCaseCommonBaseEN.FileIntegration = objRow[convCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objvCaseCommonBaseEN.CollectionCount = objRow[convCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCommonBaseEN);
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
List<clsvCaseCommonBaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCaseCommonBaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseCommonBaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCaseCommonBaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCaseCommonBaseEN> arrObjLst = new List<clsvCaseCommonBaseEN>(); 
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
	clsvCaseCommonBaseEN objvCaseCommonBaseEN = new clsvCaseCommonBaseEN();
try
{
objvCaseCommonBaseEN.IdCase = objRow[convCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objvCaseCommonBaseEN.CaseId = objRow[convCaseCommonBase.CaseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objvCaseCommonBaseEN.CaseName = objRow[convCaseCommonBase.CaseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objvCaseCommonBaseEN.CourseName = objRow[convCaseCommonBase.CourseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseName].ToString().Trim(); //课程名称
objvCaseCommonBaseEN.FuncModuleId = objRow[convCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCommonBaseEN.FuncModuleName = objRow[convCaseCommonBase.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCommonBaseEN.FuncModuleNameSim = objRow[convCaseCommonBase.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCaseCommonBase.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCaseCommonBaseEN.OwnerId = objRow[convCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCommonBaseEN.OwnerName = objRow[convCaseCommonBase.OwnerName] == DBNull.Value ? null : objRow[convCaseCommonBase.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCommonBaseEN.CourseId = objRow[convCaseCommonBase.CourseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objvCaseCommonBaseEN.CourseCode = objRow[convCaseCommonBase.CourseCode] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseCode].ToString().Trim(); //课程代码
objvCaseCommonBaseEN.CourseChapterId = objRow[convCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCommonBaseEN.CourseChapterName = objRow[convCaseCommonBase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCaseCommonBaseEN.CaseDate = objRow[convCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objvCaseCommonBaseEN.CaseDateIn = objRow[convCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objvCaseCommonBaseEN.CaseText = objRow[convCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objvCaseCommonBaseEN.CaseTheme = objRow[convCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objvCaseCommonBaseEN.CaseTime = objRow[convCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objvCaseCommonBaseEN.CaseTimeIn = objRow[convCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objvCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objvCaseCommonBaseEN.IdTeachSkill = objRow[convCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCaseCommonBaseEN.IdDiscipline = objRow[convCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objvCaseCommonBaseEN.IdStudyLevel = objRow[convCaseCommonBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCaseCommonBaseEN.IdCaseType = objRow[convCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCaseCommonBaseEN.IdTeachingPlan = objRow[convCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCaseCommonBaseEN.IdXzMajor = objRow[convCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objvCaseCommonBaseEN.BrowseCount = objRow[convCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCommonBaseEN.IdSenateGaugeVersion = objRow[convCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCaseCommonBaseEN.DocFile = objRow[convCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[convCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objvCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCaseCommonBaseEN.Memo = objRow[convCaseCommonBase.Memo] == DBNull.Value ? null : objRow[convCaseCommonBase.Memo].ToString().Trim(); //备注
objvCaseCommonBaseEN.UpdUserId = objRow[convCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objvCaseCommonBaseEN.LikeCount = objRow[convCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCaseCommonBaseEN.WordCreateDate = objRow[convCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[convCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCaseCommonBaseEN.UpdDate = objRow[convCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objvCaseCommonBaseEN.CaseLevelId = objRow[convCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCaseCommonBaseEN.ViewCount = objRow[convCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objvCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objvCaseCommonBaseEN.DownloadNumber = objRow[convCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objvCaseCommonBaseEN.FileIntegration = objRow[convCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objvCaseCommonBaseEN.CollectionCount = objRow[convCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCommonBaseEN);
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
public static List<clsvCaseCommonBaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCaseCommonBaseEN> arrObjLst = new List<clsvCaseCommonBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCommonBaseEN objvCaseCommonBaseEN = new clsvCaseCommonBaseEN();
try
{
objvCaseCommonBaseEN.IdCase = objRow[convCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objvCaseCommonBaseEN.CaseId = objRow[convCaseCommonBase.CaseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objvCaseCommonBaseEN.CaseName = objRow[convCaseCommonBase.CaseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objvCaseCommonBaseEN.CourseName = objRow[convCaseCommonBase.CourseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseName].ToString().Trim(); //课程名称
objvCaseCommonBaseEN.FuncModuleId = objRow[convCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCommonBaseEN.FuncModuleName = objRow[convCaseCommonBase.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCommonBaseEN.FuncModuleNameSim = objRow[convCaseCommonBase.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCaseCommonBase.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCaseCommonBaseEN.OwnerId = objRow[convCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCommonBaseEN.OwnerName = objRow[convCaseCommonBase.OwnerName] == DBNull.Value ? null : objRow[convCaseCommonBase.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCommonBaseEN.CourseId = objRow[convCaseCommonBase.CourseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objvCaseCommonBaseEN.CourseCode = objRow[convCaseCommonBase.CourseCode] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseCode].ToString().Trim(); //课程代码
objvCaseCommonBaseEN.CourseChapterId = objRow[convCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCommonBaseEN.CourseChapterName = objRow[convCaseCommonBase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCaseCommonBaseEN.CaseDate = objRow[convCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objvCaseCommonBaseEN.CaseDateIn = objRow[convCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objvCaseCommonBaseEN.CaseText = objRow[convCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objvCaseCommonBaseEN.CaseTheme = objRow[convCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objvCaseCommonBaseEN.CaseTime = objRow[convCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objvCaseCommonBaseEN.CaseTimeIn = objRow[convCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objvCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objvCaseCommonBaseEN.IdTeachSkill = objRow[convCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCaseCommonBaseEN.IdDiscipline = objRow[convCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objvCaseCommonBaseEN.IdStudyLevel = objRow[convCaseCommonBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCaseCommonBaseEN.IdCaseType = objRow[convCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCaseCommonBaseEN.IdTeachingPlan = objRow[convCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCaseCommonBaseEN.IdXzMajor = objRow[convCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objvCaseCommonBaseEN.BrowseCount = objRow[convCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCommonBaseEN.IdSenateGaugeVersion = objRow[convCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCaseCommonBaseEN.DocFile = objRow[convCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[convCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objvCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCaseCommonBaseEN.Memo = objRow[convCaseCommonBase.Memo] == DBNull.Value ? null : objRow[convCaseCommonBase.Memo].ToString().Trim(); //备注
objvCaseCommonBaseEN.UpdUserId = objRow[convCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objvCaseCommonBaseEN.LikeCount = objRow[convCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCaseCommonBaseEN.WordCreateDate = objRow[convCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[convCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCaseCommonBaseEN.UpdDate = objRow[convCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objvCaseCommonBaseEN.CaseLevelId = objRow[convCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCaseCommonBaseEN.ViewCount = objRow[convCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objvCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objvCaseCommonBaseEN.DownloadNumber = objRow[convCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objvCaseCommonBaseEN.FileIntegration = objRow[convCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objvCaseCommonBaseEN.CollectionCount = objRow[convCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCommonBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCaseCommonBaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCaseCommonBaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCaseCommonBaseEN> arrObjLst = new List<clsvCaseCommonBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCommonBaseEN objvCaseCommonBaseEN = new clsvCaseCommonBaseEN();
try
{
objvCaseCommonBaseEN.IdCase = objRow[convCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objvCaseCommonBaseEN.CaseId = objRow[convCaseCommonBase.CaseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objvCaseCommonBaseEN.CaseName = objRow[convCaseCommonBase.CaseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objvCaseCommonBaseEN.CourseName = objRow[convCaseCommonBase.CourseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseName].ToString().Trim(); //课程名称
objvCaseCommonBaseEN.FuncModuleId = objRow[convCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCommonBaseEN.FuncModuleName = objRow[convCaseCommonBase.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCommonBaseEN.FuncModuleNameSim = objRow[convCaseCommonBase.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCaseCommonBase.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCaseCommonBaseEN.OwnerId = objRow[convCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCommonBaseEN.OwnerName = objRow[convCaseCommonBase.OwnerName] == DBNull.Value ? null : objRow[convCaseCommonBase.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCommonBaseEN.CourseId = objRow[convCaseCommonBase.CourseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objvCaseCommonBaseEN.CourseCode = objRow[convCaseCommonBase.CourseCode] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseCode].ToString().Trim(); //课程代码
objvCaseCommonBaseEN.CourseChapterId = objRow[convCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCommonBaseEN.CourseChapterName = objRow[convCaseCommonBase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCaseCommonBaseEN.CaseDate = objRow[convCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objvCaseCommonBaseEN.CaseDateIn = objRow[convCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objvCaseCommonBaseEN.CaseText = objRow[convCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objvCaseCommonBaseEN.CaseTheme = objRow[convCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objvCaseCommonBaseEN.CaseTime = objRow[convCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objvCaseCommonBaseEN.CaseTimeIn = objRow[convCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objvCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objvCaseCommonBaseEN.IdTeachSkill = objRow[convCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCaseCommonBaseEN.IdDiscipline = objRow[convCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objvCaseCommonBaseEN.IdStudyLevel = objRow[convCaseCommonBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCaseCommonBaseEN.IdCaseType = objRow[convCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCaseCommonBaseEN.IdTeachingPlan = objRow[convCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCaseCommonBaseEN.IdXzMajor = objRow[convCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objvCaseCommonBaseEN.BrowseCount = objRow[convCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCommonBaseEN.IdSenateGaugeVersion = objRow[convCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCaseCommonBaseEN.DocFile = objRow[convCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[convCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objvCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCaseCommonBaseEN.Memo = objRow[convCaseCommonBase.Memo] == DBNull.Value ? null : objRow[convCaseCommonBase.Memo].ToString().Trim(); //备注
objvCaseCommonBaseEN.UpdUserId = objRow[convCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objvCaseCommonBaseEN.LikeCount = objRow[convCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCaseCommonBaseEN.WordCreateDate = objRow[convCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[convCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCaseCommonBaseEN.UpdDate = objRow[convCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objvCaseCommonBaseEN.CaseLevelId = objRow[convCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCaseCommonBaseEN.ViewCount = objRow[convCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objvCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objvCaseCommonBaseEN.DownloadNumber = objRow[convCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objvCaseCommonBaseEN.FileIntegration = objRow[convCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objvCaseCommonBaseEN.CollectionCount = objRow[convCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCommonBaseEN);
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
public static List<clsvCaseCommonBaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCaseCommonBaseEN> arrObjLst = new List<clsvCaseCommonBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCommonBaseEN objvCaseCommonBaseEN = new clsvCaseCommonBaseEN();
try
{
objvCaseCommonBaseEN.IdCase = objRow[convCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objvCaseCommonBaseEN.CaseId = objRow[convCaseCommonBase.CaseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objvCaseCommonBaseEN.CaseName = objRow[convCaseCommonBase.CaseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objvCaseCommonBaseEN.CourseName = objRow[convCaseCommonBase.CourseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseName].ToString().Trim(); //课程名称
objvCaseCommonBaseEN.FuncModuleId = objRow[convCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCommonBaseEN.FuncModuleName = objRow[convCaseCommonBase.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCommonBaseEN.FuncModuleNameSim = objRow[convCaseCommonBase.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCaseCommonBase.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCaseCommonBaseEN.OwnerId = objRow[convCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCommonBaseEN.OwnerName = objRow[convCaseCommonBase.OwnerName] == DBNull.Value ? null : objRow[convCaseCommonBase.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCommonBaseEN.CourseId = objRow[convCaseCommonBase.CourseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objvCaseCommonBaseEN.CourseCode = objRow[convCaseCommonBase.CourseCode] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseCode].ToString().Trim(); //课程代码
objvCaseCommonBaseEN.CourseChapterId = objRow[convCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCommonBaseEN.CourseChapterName = objRow[convCaseCommonBase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCaseCommonBaseEN.CaseDate = objRow[convCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objvCaseCommonBaseEN.CaseDateIn = objRow[convCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objvCaseCommonBaseEN.CaseText = objRow[convCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objvCaseCommonBaseEN.CaseTheme = objRow[convCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objvCaseCommonBaseEN.CaseTime = objRow[convCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objvCaseCommonBaseEN.CaseTimeIn = objRow[convCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objvCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objvCaseCommonBaseEN.IdTeachSkill = objRow[convCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCaseCommonBaseEN.IdDiscipline = objRow[convCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objvCaseCommonBaseEN.IdStudyLevel = objRow[convCaseCommonBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCaseCommonBaseEN.IdCaseType = objRow[convCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCaseCommonBaseEN.IdTeachingPlan = objRow[convCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCaseCommonBaseEN.IdXzMajor = objRow[convCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objvCaseCommonBaseEN.BrowseCount = objRow[convCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCommonBaseEN.IdSenateGaugeVersion = objRow[convCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCaseCommonBaseEN.DocFile = objRow[convCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[convCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objvCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCaseCommonBaseEN.Memo = objRow[convCaseCommonBase.Memo] == DBNull.Value ? null : objRow[convCaseCommonBase.Memo].ToString().Trim(); //备注
objvCaseCommonBaseEN.UpdUserId = objRow[convCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objvCaseCommonBaseEN.LikeCount = objRow[convCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCaseCommonBaseEN.WordCreateDate = objRow[convCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[convCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCaseCommonBaseEN.UpdDate = objRow[convCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objvCaseCommonBaseEN.CaseLevelId = objRow[convCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCaseCommonBaseEN.ViewCount = objRow[convCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objvCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objvCaseCommonBaseEN.DownloadNumber = objRow[convCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objvCaseCommonBaseEN.FileIntegration = objRow[convCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objvCaseCommonBaseEN.CollectionCount = objRow[convCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCommonBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseCommonBaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCaseCommonBaseEN> arrObjLst = new List<clsvCaseCommonBaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCommonBaseEN objvCaseCommonBaseEN = new clsvCaseCommonBaseEN();
try
{
objvCaseCommonBaseEN.IdCase = objRow[convCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objvCaseCommonBaseEN.CaseId = objRow[convCaseCommonBase.CaseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objvCaseCommonBaseEN.CaseName = objRow[convCaseCommonBase.CaseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objvCaseCommonBaseEN.CourseName = objRow[convCaseCommonBase.CourseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseName].ToString().Trim(); //课程名称
objvCaseCommonBaseEN.FuncModuleId = objRow[convCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCommonBaseEN.FuncModuleName = objRow[convCaseCommonBase.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCommonBaseEN.FuncModuleNameSim = objRow[convCaseCommonBase.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCaseCommonBase.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCaseCommonBaseEN.OwnerId = objRow[convCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCommonBaseEN.OwnerName = objRow[convCaseCommonBase.OwnerName] == DBNull.Value ? null : objRow[convCaseCommonBase.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCommonBaseEN.CourseId = objRow[convCaseCommonBase.CourseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objvCaseCommonBaseEN.CourseCode = objRow[convCaseCommonBase.CourseCode] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseCode].ToString().Trim(); //课程代码
objvCaseCommonBaseEN.CourseChapterId = objRow[convCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCommonBaseEN.CourseChapterName = objRow[convCaseCommonBase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCaseCommonBaseEN.CaseDate = objRow[convCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objvCaseCommonBaseEN.CaseDateIn = objRow[convCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objvCaseCommonBaseEN.CaseText = objRow[convCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objvCaseCommonBaseEN.CaseTheme = objRow[convCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objvCaseCommonBaseEN.CaseTime = objRow[convCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objvCaseCommonBaseEN.CaseTimeIn = objRow[convCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objvCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objvCaseCommonBaseEN.IdTeachSkill = objRow[convCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCaseCommonBaseEN.IdDiscipline = objRow[convCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objvCaseCommonBaseEN.IdStudyLevel = objRow[convCaseCommonBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCaseCommonBaseEN.IdCaseType = objRow[convCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCaseCommonBaseEN.IdTeachingPlan = objRow[convCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCaseCommonBaseEN.IdXzMajor = objRow[convCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objvCaseCommonBaseEN.BrowseCount = objRow[convCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCommonBaseEN.IdSenateGaugeVersion = objRow[convCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCaseCommonBaseEN.DocFile = objRow[convCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[convCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objvCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCaseCommonBaseEN.Memo = objRow[convCaseCommonBase.Memo] == DBNull.Value ? null : objRow[convCaseCommonBase.Memo].ToString().Trim(); //备注
objvCaseCommonBaseEN.UpdUserId = objRow[convCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objvCaseCommonBaseEN.LikeCount = objRow[convCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCaseCommonBaseEN.WordCreateDate = objRow[convCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[convCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCaseCommonBaseEN.UpdDate = objRow[convCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objvCaseCommonBaseEN.CaseLevelId = objRow[convCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCaseCommonBaseEN.ViewCount = objRow[convCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objvCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objvCaseCommonBaseEN.DownloadNumber = objRow[convCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objvCaseCommonBaseEN.FileIntegration = objRow[convCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objvCaseCommonBaseEN.CollectionCount = objRow[convCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseCommonBaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCaseCommonBase(ref clsvCaseCommonBaseEN objvCaseCommonBaseEN)
{
bool bolResult = vCaseCommonBaseDA.GetvCaseCommonBase(ref objvCaseCommonBaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseCommonBaseEN GetObjByIdCase(string strIdCase)
{
if (strIdCase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdCase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdCase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdCase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvCaseCommonBaseEN objvCaseCommonBaseEN = vCaseCommonBaseDA.GetObjByIdCase(strIdCase);
return objvCaseCommonBaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCaseCommonBaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCaseCommonBaseEN objvCaseCommonBaseEN = vCaseCommonBaseDA.GetFirstObj(strWhereCond);
 return objvCaseCommonBaseEN;
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
public static clsvCaseCommonBaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCaseCommonBaseEN objvCaseCommonBaseEN = vCaseCommonBaseDA.GetObjByDataRow(objRow);
 return objvCaseCommonBaseEN;
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
public static clsvCaseCommonBaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCaseCommonBaseEN objvCaseCommonBaseEN = vCaseCommonBaseDA.GetObjByDataRow(objRow);
 return objvCaseCommonBaseEN;
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
 /// <param name = "strIdCase">所给的关键字</param>
 /// <param name = "lstvCaseCommonBaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseCommonBaseEN GetObjByIdCaseFromList(string strIdCase, List<clsvCaseCommonBaseEN> lstvCaseCommonBaseObjLst)
{
foreach (clsvCaseCommonBaseEN objvCaseCommonBaseEN in lstvCaseCommonBaseObjLst)
{
if (objvCaseCommonBaseEN.IdCase == strIdCase)
{
return objvCaseCommonBaseEN;
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
 string strIdCase;
 try
 {
 strIdCase = new clsvCaseCommonBaseDA().GetFirstID(strWhereCond);
 return strIdCase;
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
 arrList = vCaseCommonBaseDA.GetID(strWhereCond);
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
bool bolIsExist = vCaseCommonBaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdCase)
{
if (string.IsNullOrEmpty(strIdCase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdCase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vCaseCommonBaseDA.IsExist(strIdCase);
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
 bolIsExist = clsvCaseCommonBaseDA.IsExistTable();
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
 bolIsExist = vCaseCommonBaseDA.IsExistTable(strTabName);
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
 /// <param name = "objvCaseCommonBaseENS">源对象</param>
 /// <param name = "objvCaseCommonBaseENT">目标对象</param>
 public static void CopyTo(clsvCaseCommonBaseEN objvCaseCommonBaseENS, clsvCaseCommonBaseEN objvCaseCommonBaseENT)
{
try
{
objvCaseCommonBaseENT.IdCase = objvCaseCommonBaseENS.IdCase; //案例流水号
objvCaseCommonBaseENT.CaseId = objvCaseCommonBaseENS.CaseId; //案例Id
objvCaseCommonBaseENT.CaseName = objvCaseCommonBaseENS.CaseName; //案例名称
objvCaseCommonBaseENT.CourseName = objvCaseCommonBaseENS.CourseName; //课程名称
objvCaseCommonBaseENT.FuncModuleId = objvCaseCommonBaseENS.FuncModuleId; //功能模块Id
objvCaseCommonBaseENT.FuncModuleName = objvCaseCommonBaseENS.FuncModuleName; //功能模块名称
objvCaseCommonBaseENT.FuncModuleNameSim = objvCaseCommonBaseENS.FuncModuleNameSim; //功能模块简称
objvCaseCommonBaseENT.OwnerId = objvCaseCommonBaseENS.OwnerId; //拥有者Id
objvCaseCommonBaseENT.OwnerName = objvCaseCommonBaseENS.OwnerName; //拥有者姓名
objvCaseCommonBaseENT.CourseId = objvCaseCommonBaseENS.CourseId; //课程Id
objvCaseCommonBaseENT.CourseCode = objvCaseCommonBaseENS.CourseCode; //课程代码
objvCaseCommonBaseENT.CourseChapterId = objvCaseCommonBaseENS.CourseChapterId; //课程章节ID
objvCaseCommonBaseENT.CourseChapterName = objvCaseCommonBaseENS.CourseChapterName; //课程章节名称
objvCaseCommonBaseENT.CaseDate = objvCaseCommonBaseENS.CaseDate; //案例建立日期
objvCaseCommonBaseENT.CaseDateIn = objvCaseCommonBaseENS.CaseDateIn; //案例入库日期
objvCaseCommonBaseENT.CaseText = objvCaseCommonBaseENS.CaseText; //案例文本内容
objvCaseCommonBaseENT.CaseTheme = objvCaseCommonBaseENS.CaseTheme; //案例主题词
objvCaseCommonBaseENT.CaseTime = objvCaseCommonBaseENS.CaseTime; //案例建立时间
objvCaseCommonBaseENT.CaseTimeIn = objvCaseCommonBaseENS.CaseTimeIn; //案例入库时间
objvCaseCommonBaseENT.IsVisible = objvCaseCommonBaseENS.IsVisible; //是否显示
objvCaseCommonBaseENT.IdTeachSkill = objvCaseCommonBaseENS.IdTeachSkill; //教学技能流水号
objvCaseCommonBaseENT.IdDiscipline = objvCaseCommonBaseENS.IdDiscipline; //学科流水号
objvCaseCommonBaseENT.IdStudyLevel = objvCaseCommonBaseENS.IdStudyLevel; //id_StudyLevel
objvCaseCommonBaseENT.IdCaseType = objvCaseCommonBaseENS.IdCaseType; //案例类型流水号
objvCaseCommonBaseENT.IdTeachingPlan = objvCaseCommonBaseENS.IdTeachingPlan; //教案流水号
objvCaseCommonBaseENT.IdXzMajor = objvCaseCommonBaseENS.IdXzMajor; //专业流水号
objvCaseCommonBaseENT.BrowseCount = objvCaseCommonBaseENS.BrowseCount; //浏览次数
objvCaseCommonBaseENT.IdSenateGaugeVersion = objvCaseCommonBaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCaseCommonBaseENT.DocFile = objvCaseCommonBaseENS.DocFile; //生成的Word文件名
objvCaseCommonBaseENT.IsNeedGeneWord = objvCaseCommonBaseENS.IsNeedGeneWord; //是否需要生成Word
objvCaseCommonBaseENT.Memo = objvCaseCommonBaseENS.Memo; //备注
objvCaseCommonBaseENT.UpdUserId = objvCaseCommonBaseENS.UpdUserId; //修改用户Id
objvCaseCommonBaseENT.IsDualVideo = objvCaseCommonBaseENS.IsDualVideo; //是否双视频
objvCaseCommonBaseENT.LikeCount = objvCaseCommonBaseENS.LikeCount; //资源喜欢数量
objvCaseCommonBaseENT.WordCreateDate = objvCaseCommonBaseENS.WordCreateDate; //Word生成日期
objvCaseCommonBaseENT.UpdDate = objvCaseCommonBaseENS.UpdDate; //修改日期
objvCaseCommonBaseENT.CaseLevelId = objvCaseCommonBaseENS.CaseLevelId; //课例等级Id
objvCaseCommonBaseENT.ViewCount = objvCaseCommonBaseENS.ViewCount; //浏览量
objvCaseCommonBaseENT.IsShow = objvCaseCommonBaseENS.IsShow; //是否启用
objvCaseCommonBaseENT.DownloadNumber = objvCaseCommonBaseENS.DownloadNumber; //下载数目
objvCaseCommonBaseENT.FileIntegration = objvCaseCommonBaseENS.FileIntegration; //文件积分
objvCaseCommonBaseENT.CollectionCount = objvCaseCommonBaseENS.CollectionCount; //收藏数量
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
 /// <param name = "objvCaseCommonBaseEN">源简化对象</param>
 public static void SetUpdFlag(clsvCaseCommonBaseEN objvCaseCommonBaseEN)
{
try
{
objvCaseCommonBaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCaseCommonBaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCaseCommonBase.IdCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.IdCase = objvCaseCommonBaseEN.IdCase; //案例流水号
}
if (arrFldSet.Contains(convCaseCommonBase.CaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.CaseId = objvCaseCommonBaseEN.CaseId == "[null]" ? null :  objvCaseCommonBaseEN.CaseId; //案例Id
}
if (arrFldSet.Contains(convCaseCommonBase.CaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.CaseName = objvCaseCommonBaseEN.CaseName == "[null]" ? null :  objvCaseCommonBaseEN.CaseName; //案例名称
}
if (arrFldSet.Contains(convCaseCommonBase.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.CourseName = objvCaseCommonBaseEN.CourseName == "[null]" ? null :  objvCaseCommonBaseEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convCaseCommonBase.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.FuncModuleId = objvCaseCommonBaseEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convCaseCommonBase.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.FuncModuleName = objvCaseCommonBaseEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convCaseCommonBase.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.FuncModuleNameSim = objvCaseCommonBaseEN.FuncModuleNameSim == "[null]" ? null :  objvCaseCommonBaseEN.FuncModuleNameSim; //功能模块简称
}
if (arrFldSet.Contains(convCaseCommonBase.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.OwnerId = objvCaseCommonBaseEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convCaseCommonBase.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.OwnerName = objvCaseCommonBaseEN.OwnerName == "[null]" ? null :  objvCaseCommonBaseEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convCaseCommonBase.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.CourseId = objvCaseCommonBaseEN.CourseId == "[null]" ? null :  objvCaseCommonBaseEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convCaseCommonBase.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.CourseCode = objvCaseCommonBaseEN.CourseCode == "[null]" ? null :  objvCaseCommonBaseEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convCaseCommonBase.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.CourseChapterId = objvCaseCommonBaseEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convCaseCommonBase.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.CourseChapterName = objvCaseCommonBaseEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(convCaseCommonBase.CaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.CaseDate = objvCaseCommonBaseEN.CaseDate == "[null]" ? null :  objvCaseCommonBaseEN.CaseDate; //案例建立日期
}
if (arrFldSet.Contains(convCaseCommonBase.CaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.CaseDateIn = objvCaseCommonBaseEN.CaseDateIn == "[null]" ? null :  objvCaseCommonBaseEN.CaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convCaseCommonBase.CaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.CaseText = objvCaseCommonBaseEN.CaseText == "[null]" ? null :  objvCaseCommonBaseEN.CaseText; //案例文本内容
}
if (arrFldSet.Contains(convCaseCommonBase.CaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.CaseTheme = objvCaseCommonBaseEN.CaseTheme == "[null]" ? null :  objvCaseCommonBaseEN.CaseTheme; //案例主题词
}
if (arrFldSet.Contains(convCaseCommonBase.CaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.CaseTime = objvCaseCommonBaseEN.CaseTime == "[null]" ? null :  objvCaseCommonBaseEN.CaseTime; //案例建立时间
}
if (arrFldSet.Contains(convCaseCommonBase.CaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.CaseTimeIn = objvCaseCommonBaseEN.CaseTimeIn == "[null]" ? null :  objvCaseCommonBaseEN.CaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convCaseCommonBase.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.IsVisible = objvCaseCommonBaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convCaseCommonBase.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.IdTeachSkill = objvCaseCommonBaseEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convCaseCommonBase.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.IdDiscipline = objvCaseCommonBaseEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convCaseCommonBase.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.IdStudyLevel = objvCaseCommonBaseEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convCaseCommonBase.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.IdCaseType = objvCaseCommonBaseEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(convCaseCommonBase.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.IdTeachingPlan = objvCaseCommonBaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convCaseCommonBase.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.IdXzMajor = objvCaseCommonBaseEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convCaseCommonBase.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.BrowseCount = objvCaseCommonBaseEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convCaseCommonBase.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.IdSenateGaugeVersion = objvCaseCommonBaseEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convCaseCommonBase.DocFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.DocFile = objvCaseCommonBaseEN.DocFile == "[null]" ? null :  objvCaseCommonBaseEN.DocFile; //生成的Word文件名
}
if (arrFldSet.Contains(convCaseCommonBase.IsNeedGeneWord, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.IsNeedGeneWord = objvCaseCommonBaseEN.IsNeedGeneWord; //是否需要生成Word
}
if (arrFldSet.Contains(convCaseCommonBase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.Memo = objvCaseCommonBaseEN.Memo == "[null]" ? null :  objvCaseCommonBaseEN.Memo; //备注
}
if (arrFldSet.Contains(convCaseCommonBase.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.UpdUserId = objvCaseCommonBaseEN.UpdUserId == "[null]" ? null :  objvCaseCommonBaseEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convCaseCommonBase.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.IsDualVideo = objvCaseCommonBaseEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convCaseCommonBase.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.LikeCount = objvCaseCommonBaseEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(convCaseCommonBase.WordCreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.WordCreateDate = objvCaseCommonBaseEN.WordCreateDate == "[null]" ? null :  objvCaseCommonBaseEN.WordCreateDate; //Word生成日期
}
if (arrFldSet.Contains(convCaseCommonBase.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.UpdDate = objvCaseCommonBaseEN.UpdDate == "[null]" ? null :  objvCaseCommonBaseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCaseCommonBase.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.CaseLevelId = objvCaseCommonBaseEN.CaseLevelId == "[null]" ? null :  objvCaseCommonBaseEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(convCaseCommonBase.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.ViewCount = objvCaseCommonBaseEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convCaseCommonBase.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.IsShow = objvCaseCommonBaseEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convCaseCommonBase.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.DownloadNumber = objvCaseCommonBaseEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(convCaseCommonBase.FileIntegration, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.FileIntegration = objvCaseCommonBaseEN.FileIntegration; //文件积分
}
if (arrFldSet.Contains(convCaseCommonBase.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseCommonBaseEN.CollectionCount = objvCaseCommonBaseEN.CollectionCount; //收藏数量
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
 /// <param name = "objvCaseCommonBaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCaseCommonBaseEN objvCaseCommonBaseEN)
{
try
{
if (objvCaseCommonBaseEN.CaseId == "[null]") objvCaseCommonBaseEN.CaseId = null; //案例Id
if (objvCaseCommonBaseEN.CaseName == "[null]") objvCaseCommonBaseEN.CaseName = null; //案例名称
if (objvCaseCommonBaseEN.CourseName == "[null]") objvCaseCommonBaseEN.CourseName = null; //课程名称
if (objvCaseCommonBaseEN.FuncModuleNameSim == "[null]") objvCaseCommonBaseEN.FuncModuleNameSim = null; //功能模块简称
if (objvCaseCommonBaseEN.OwnerName == "[null]") objvCaseCommonBaseEN.OwnerName = null; //拥有者姓名
if (objvCaseCommonBaseEN.CourseId == "[null]") objvCaseCommonBaseEN.CourseId = null; //课程Id
if (objvCaseCommonBaseEN.CourseCode == "[null]") objvCaseCommonBaseEN.CourseCode = null; //课程代码
if (objvCaseCommonBaseEN.CaseDate == "[null]") objvCaseCommonBaseEN.CaseDate = null; //案例建立日期
if (objvCaseCommonBaseEN.CaseDateIn == "[null]") objvCaseCommonBaseEN.CaseDateIn = null; //案例入库日期
if (objvCaseCommonBaseEN.CaseText == "[null]") objvCaseCommonBaseEN.CaseText = null; //案例文本内容
if (objvCaseCommonBaseEN.CaseTheme == "[null]") objvCaseCommonBaseEN.CaseTheme = null; //案例主题词
if (objvCaseCommonBaseEN.CaseTime == "[null]") objvCaseCommonBaseEN.CaseTime = null; //案例建立时间
if (objvCaseCommonBaseEN.CaseTimeIn == "[null]") objvCaseCommonBaseEN.CaseTimeIn = null; //案例入库时间
if (objvCaseCommonBaseEN.DocFile == "[null]") objvCaseCommonBaseEN.DocFile = null; //生成的Word文件名
if (objvCaseCommonBaseEN.Memo == "[null]") objvCaseCommonBaseEN.Memo = null; //备注
if (objvCaseCommonBaseEN.UpdUserId == "[null]") objvCaseCommonBaseEN.UpdUserId = null; //修改用户Id
if (objvCaseCommonBaseEN.WordCreateDate == "[null]") objvCaseCommonBaseEN.WordCreateDate = null; //Word生成日期
if (objvCaseCommonBaseEN.UpdDate == "[null]") objvCaseCommonBaseEN.UpdDate = null; //修改日期
if (objvCaseCommonBaseEN.CaseLevelId == "[null]") objvCaseCommonBaseEN.CaseLevelId = null; //课例等级Id
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
public static void CheckProperty4Condition(clsvCaseCommonBaseEN objvCaseCommonBaseEN)
{
 vCaseCommonBaseDA.CheckProperty4Condition(objvCaseCommonBaseEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdCase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convCaseCommonBase.IdCase); 
List<clsvCaseCommonBaseEN> arrObjLst = clsvCaseCommonBaseBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvCaseCommonBaseEN objvCaseCommonBaseEN = new clsvCaseCommonBaseEN()
{
IdCase = "0",
CaseName = "选[v案例公共基类]..."
};
arrObjLst.Insert(0, objvCaseCommonBaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convCaseCommonBase.IdCase;
objComboBox.DisplayMember = convCaseCommonBase.CaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdCase(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v案例公共基类]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convCaseCommonBase.IdCase); 
IEnumerable<clsvCaseCommonBaseEN> arrObjLst = clsvCaseCommonBaseBL.GetObjLst(strCondition);
objDDL.DataValueField = convCaseCommonBase.IdCase;
objDDL.DataTextField = convCaseCommonBase.CaseName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdCaseCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v案例公共基类]...","0");
List<clsvCaseCommonBaseEN> arrvCaseCommonBaseObjLst = GetAllvCaseCommonBaseObjLstCache(); 
objDDL.DataValueField = convCaseCommonBase.IdCase;
objDDL.DataTextField = convCaseCommonBase.CaseName;
objDDL.DataSource = arrvCaseCommonBaseObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseCommonBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseCommonBaseBL没有刷新缓存机制(clsCaseCommonBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCase");
//if (arrvCaseCommonBaseObjLstCache == null)
//{
//arrvCaseCommonBaseObjLstCache = vCaseCommonBaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseCommonBaseEN GetObjByIdCaseCache(string strIdCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCaseCommonBaseEN._CurrTabName);
List<clsvCaseCommonBaseEN> arrvCaseCommonBaseObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseCommonBaseEN> arrvCaseCommonBaseObjLst_Sel =
arrvCaseCommonBaseObjLstCache
.Where(x=> x.IdCase == strIdCase 
);
if (arrvCaseCommonBaseObjLst_Sel.Count() == 0)
{
   clsvCaseCommonBaseEN obj = clsvCaseCommonBaseBL.GetObjByIdCase(strIdCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCaseCommonBaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCaseNameByIdCaseCache(string strIdCase)
{
if (string.IsNullOrEmpty(strIdCase) == true) return "";
//获取缓存中的对象列表
clsvCaseCommonBaseEN objvCaseCommonBase = GetObjByIdCaseCache(strIdCase);
if (objvCaseCommonBase == null) return "";
return objvCaseCommonBase.CaseName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdCaseCache(string strIdCase)
{
if (string.IsNullOrEmpty(strIdCase) == true) return "";
//获取缓存中的对象列表
clsvCaseCommonBaseEN objvCaseCommonBase = GetObjByIdCaseCache(strIdCase);
if (objvCaseCommonBase == null) return "";
return objvCaseCommonBase.CaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCaseCommonBaseEN> GetAllvCaseCommonBaseObjLstCache()
{
//获取缓存中的对象列表
List<clsvCaseCommonBaseEN> arrvCaseCommonBaseObjLstCache = GetObjLstCache(); 
return arrvCaseCommonBaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCaseCommonBaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCaseCommonBaseEN._CurrTabName);
List<clsvCaseCommonBaseEN> arrvCaseCommonBaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCaseCommonBaseObjLstCache;
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
string strKey = string.Format("{0}", clsvCaseCommonBaseEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdCase)
{
if (strInFldName != convCaseCommonBase.IdCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCaseCommonBase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCaseCommonBase.AttributeName));
throw new Exception(strMsg);
}
var objvCaseCommonBase = clsvCaseCommonBaseBL.GetObjByIdCaseCache(strIdCase);
if (objvCaseCommonBase == null) return "";
return objvCaseCommonBase[strOutFldName].ToString();
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
int intRecCount = clsvCaseCommonBaseDA.GetRecCount(strTabName);
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
int intRecCount = clsvCaseCommonBaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCaseCommonBaseDA.GetRecCount();
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
int intRecCount = clsvCaseCommonBaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCaseCommonBaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCaseCommonBaseEN objvCaseCommonBaseCond)
{
List<clsvCaseCommonBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseCommonBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCaseCommonBase.AttributeName)
{
if (objvCaseCommonBaseCond.IsUpdated(strFldName) == false) continue;
if (objvCaseCommonBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseCommonBaseCond[strFldName].ToString());
}
else
{
if (objvCaseCommonBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCaseCommonBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseCommonBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCaseCommonBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCaseCommonBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCaseCommonBaseCond[strFldName]));
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
 List<string> arrList = clsvCaseCommonBaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCaseCommonBaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCaseCommonBaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}