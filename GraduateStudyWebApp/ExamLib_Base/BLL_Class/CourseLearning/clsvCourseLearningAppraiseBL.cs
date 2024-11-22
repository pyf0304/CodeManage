
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningAppraiseBL
 表名:vCourseLearningAppraise(01120269)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:32
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
public static class  clsvCourseLearningAppraiseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningAppraiseEN GetObj(this K_IdMicroteachAppraise_vCourseLearningAppraise myKey)
{
clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = clsvCourseLearningAppraiseBL.vCourseLearningAppraiseDA.GetObjByIdMicroteachAppraise(myKey.Value);
return objvCourseLearningAppraiseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetIdCourseLearningCase(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strIdCourseLearningCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseLearningCase, 8, convCourseLearningAppraise.IdCourseLearningCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseLearningCase, 8, convCourseLearningAppraise.IdCourseLearningCase);
}
objvCourseLearningAppraiseEN.IdCourseLearningCase = strIdCourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.IdCourseLearningCase) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.IdCourseLearningCase, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.IdCourseLearningCase] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseLearningCaseID(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, convCourseLearningAppraise.CourseLearningCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, convCourseLearningAppraise.CourseLearningCaseID);
}
objvCourseLearningAppraiseEN.CourseLearningCaseID = strCourseLearningCaseID; //课程学习案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseLearningCaseID) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseLearningCaseID, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseID] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseLearningCaseName(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningAppraise.CourseLearningCaseName);
}
objvCourseLearningAppraiseEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseLearningCaseName) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseLearningCaseName, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseName] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseLearningCaseTheme(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseLearningCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTheme, 200, convCourseLearningAppraise.CourseLearningCaseTheme);
}
objvCourseLearningAppraiseEN.CourseLearningCaseTheme = strCourseLearningCaseTheme; //课程学习案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseLearningCaseTheme) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseLearningCaseTheme, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseTheme] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseLearningCaseDate(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseLearningCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDate, 8, convCourseLearningAppraise.CourseLearningCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDate, 8, convCourseLearningAppraise.CourseLearningCaseDate);
}
objvCourseLearningAppraiseEN.CourseLearningCaseDate = strCourseLearningCaseDate; //课程学习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseLearningCaseDate) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseLearningCaseDate, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseDate] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseLearningCaseTime(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseLearningCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTime, 6, convCourseLearningAppraise.CourseLearningCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTime, 6, convCourseLearningAppraise.CourseLearningCaseTime);
}
objvCourseLearningAppraiseEN.CourseLearningCaseTime = strCourseLearningCaseTime; //课程学习时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseLearningCaseTime) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseLearningCaseTime, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseTime] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseLearningCaseDateIn(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseLearningCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDateIn, 8, convCourseLearningAppraise.CourseLearningCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDateIn, 8, convCourseLearningAppraise.CourseLearningCaseDateIn);
}
objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = strCourseLearningCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseLearningCaseDateIn) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseLearningCaseDateIn, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseDateIn] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseLearningCaseTimeIn(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseLearningCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTimeIn, 6, convCourseLearningAppraise.CourseLearningCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTimeIn, 6, convCourseLearningAppraise.CourseLearningCaseTimeIn);
}
objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = strCourseLearningCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseLearningCaseTimeIn) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseLearningCaseTimeIn, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseTimeIn] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseLearningCaseTypeName(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseLearningCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTypeName, 30, convCourseLearningAppraise.CourseLearningCaseTypeName);
}
objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = strCourseLearningCaseTypeName; //课程学习案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseLearningCaseTypeName) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseLearningCaseTypeName, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseTypeName] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetUserNameWithUserId(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strUserNameWithUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convCourseLearningAppraise.UserNameWithUserId);
}
objvCourseLearningAppraiseEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.UserNameWithUserId) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.UserNameWithUserId, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.UserNameWithUserId] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetIdXzCollege(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convCourseLearningAppraise.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convCourseLearningAppraise.IdXzCollege);
}
objvCourseLearningAppraiseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.IdXzCollege) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.IdXzCollege, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.IdXzCollege] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCollegeID(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCourseLearningAppraise.CollegeID);
}
objvCourseLearningAppraiseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CollegeID) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CollegeID, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CollegeID] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCollegeName(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCourseLearningAppraise.CollegeName);
}
objvCourseLearningAppraiseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CollegeName) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CollegeName, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CollegeName] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetIdXzMajor(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convCourseLearningAppraise.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convCourseLearningAppraise.IdXzMajor);
}
objvCourseLearningAppraiseEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.IdXzMajor) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.IdXzMajor, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.IdXzMajor] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetMajorID(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convCourseLearningAppraise.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convCourseLearningAppraise.MajorID);
}
objvCourseLearningAppraiseEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.MajorID) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.MajorID, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.MajorID] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetMajorName(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convCourseLearningAppraise.MajorName);
}
objvCourseLearningAppraiseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.MajorName) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.MajorName, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.MajorName] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseId(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCourseLearningAppraise.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCourseLearningAppraise.CourseId);
}
objvCourseLearningAppraiseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseId) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseId, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseId] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseCode(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCourseLearningAppraise.CourseCode);
}
objvCourseLearningAppraiseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseCode) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseCode, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseCode] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCourseName(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCourseLearningAppraise.CourseName);
}
objvCourseLearningAppraiseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CourseName) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CourseName, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CourseName] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetCollegeNameA(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCourseLearningAppraise.CollegeNameA);
}
objvCourseLearningAppraiseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.CollegeNameA) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.CollegeNameA, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.CollegeNameA] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetIdMicroteachAppraise(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, long lngIdMicroteachAppraise, string strComparisonOp="")
	{
objvCourseLearningAppraiseEN.IdMicroteachAppraise = lngIdMicroteachAppraise; //评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.IdMicroteachAppraise) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.IdMicroteachAppraise, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.IdMicroteachAppraise] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetFuncModuleId(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCourseLearningAppraise.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCourseLearningAppraise.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCourseLearningAppraise.FuncModuleId);
}
objvCourseLearningAppraiseEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.FuncModuleId) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.FuncModuleId, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.FuncModuleId] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetFuncModuleName(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCourseLearningAppraise.FuncModuleName);
}
objvCourseLearningAppraiseEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.FuncModuleName) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.FuncModuleName, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.FuncModuleName] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetIdMicroteachCase(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convCourseLearningAppraise.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convCourseLearningAppraise.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convCourseLearningAppraise.IdMicroteachCase);
}
objvCourseLearningAppraiseEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.IdMicroteachCase) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.IdMicroteachCase, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.IdMicroteachCase] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetIdAppraiseType(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strIdAppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdAppraiseType, convCourseLearningAppraise.IdAppraiseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAppraiseType, 4, convCourseLearningAppraise.IdAppraiseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAppraiseType, 4, convCourseLearningAppraise.IdAppraiseType);
}
objvCourseLearningAppraiseEN.IdAppraiseType = strIdAppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.IdAppraiseType) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.IdAppraiseType, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.IdAppraiseType] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetAppraiseTypeName(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strAppraiseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convCourseLearningAppraise.AppraiseTypeName);
}
objvCourseLearningAppraiseEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.AppraiseTypeName) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.AppraiseTypeName, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.AppraiseTypeName] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetAppraiseTheme(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strAppraiseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTheme, 200, convCourseLearningAppraise.AppraiseTheme);
}
objvCourseLearningAppraiseEN.AppraiseTheme = strAppraiseTheme; //评议主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.AppraiseTheme) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.AppraiseTheme, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.AppraiseTheme] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetAppraiseContent(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strAppraiseContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseContent, 2000, convCourseLearningAppraise.AppraiseContent);
}
objvCourseLearningAppraiseEN.AppraiseContent = strAppraiseContent; //评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.AppraiseContent) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.AppraiseContent, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.AppraiseContent] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetAppraiseDate(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strAppraiseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseDate, 8, convCourseLearningAppraise.AppraiseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAppraiseDate, 8, convCourseLearningAppraise.AppraiseDate);
}
objvCourseLearningAppraiseEN.AppraiseDate = strAppraiseDate; //评议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.AppraiseDate) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.AppraiseDate, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.AppraiseDate] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetAppraiseTime(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strAppraiseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTime, 6, convCourseLearningAppraise.AppraiseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAppraiseTime, 6, convCourseLearningAppraise.AppraiseTime);
}
objvCourseLearningAppraiseEN.AppraiseTime = strAppraiseTime; //评议时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.AppraiseTime) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.AppraiseTime, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.AppraiseTime] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetIsVisual(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, bool bolIsVisual, string strComparisonOp="")
	{
objvCourseLearningAppraiseEN.IsVisual = bolIsVisual; //隐藏标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.IsVisual) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.IsVisual, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.IsVisual] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetIsElite(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, bool bolIsElite, string strComparisonOp="")
	{
objvCourseLearningAppraiseEN.IsElite = bolIsElite; //精华标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.IsElite) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.IsElite, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.IsElite] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetUserId(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convCourseLearningAppraise.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convCourseLearningAppraise.UserId);
}
objvCourseLearningAppraiseEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.UserId) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.UserId, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.UserId] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetExcellentOne(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strExcellentOne, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExcellentOne, 1000, convCourseLearningAppraise.ExcellentOne);
}
objvCourseLearningAppraiseEN.ExcellentOne = strExcellentOne; //优点1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.ExcellentOne) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.ExcellentOne, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.ExcellentOne] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetExcellentTwo(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strExcellentTwo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExcellentTwo, 1000, convCourseLearningAppraise.ExcellentTwo);
}
objvCourseLearningAppraiseEN.ExcellentTwo = strExcellentTwo; //优点2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.ExcellentTwo) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.ExcellentTwo, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.ExcellentTwo] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetSuggestOne(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strSuggestOne, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSuggestOne, 1000, convCourseLearningAppraise.SuggestOne);
}
objvCourseLearningAppraiseEN.SuggestOne = strSuggestOne; //建议1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.SuggestOne) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.SuggestOne, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.SuggestOne] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetSuggestTwo(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strSuggestTwo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSuggestTwo, 1000, convCourseLearningAppraise.SuggestTwo);
}
objvCourseLearningAppraiseEN.SuggestTwo = strSuggestTwo; //建议2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.SuggestTwo) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.SuggestTwo, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.SuggestTwo] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetMicroteachAppriseScore(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, float? fltMicroteachAppriseScore, string strComparisonOp="")
	{
objvCourseLearningAppraiseEN.MicroteachAppriseScore = fltMicroteachAppriseScore; //打分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.MicroteachAppriseScore) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.MicroteachAppriseScore, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.MicroteachAppriseScore] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetVideoStopTime(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strVideoStopTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoStopTime, 48, convCourseLearningAppraise.VideoStopTime);
}
objvCourseLearningAppraiseEN.VideoStopTime = strVideoStopTime; //公开课案例视频暂停时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.VideoStopTime) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.VideoStopTime, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.VideoStopTime] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetBrowseCount(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, int? intBrowseCount, string strComparisonOp="")
	{
objvCourseLearningAppraiseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.BrowseCount) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.BrowseCount, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.BrowseCount] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetBrowseCount4Case(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, int? intBrowseCount4Case, string strComparisonOp="")
	{
objvCourseLearningAppraiseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.BrowseCount4Case) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.BrowseCount4Case, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.BrowseCount4Case] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraiseEN SetUserName(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convCourseLearningAppraise.UserName);
}
objvCourseLearningAppraiseEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraiseEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise.UserName) == false)
{
objvCourseLearningAppraiseEN.dicFldComparisonOp.Add(convCourseLearningAppraise.UserName, strComparisonOp);
}
else
{
objvCourseLearningAppraiseEN.dicFldComparisonOp[convCourseLearningAppraise.UserName] = strComparisonOp;
}
}
return objvCourseLearningAppraiseEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseENS">源对象</param>
 /// <param name = "objvCourseLearningAppraiseENT">目标对象</param>
 public static void CopyTo(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseENS, clsvCourseLearningAppraiseEN objvCourseLearningAppraiseENT)
{
try
{
objvCourseLearningAppraiseENT.IdCourseLearningCase = objvCourseLearningAppraiseENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningAppraiseENT.CourseLearningCaseID = objvCourseLearningAppraiseENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningAppraiseENT.CourseLearningCaseName = objvCourseLearningAppraiseENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningAppraiseENT.CourseLearningCaseTheme = objvCourseLearningAppraiseENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningAppraiseENT.CourseLearningCaseDate = objvCourseLearningAppraiseENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningAppraiseENT.CourseLearningCaseTime = objvCourseLearningAppraiseENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningAppraiseENT.CourseLearningCaseDateIn = objvCourseLearningAppraiseENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningAppraiseENT.CourseLearningCaseTimeIn = objvCourseLearningAppraiseENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningAppraiseENT.CourseLearningCaseTypeName = objvCourseLearningAppraiseENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningAppraiseENT.UserNameWithUserId = objvCourseLearningAppraiseENS.UserNameWithUserId; //UserNameWithUserId
objvCourseLearningAppraiseENT.IdXzCollege = objvCourseLearningAppraiseENS.IdXzCollege; //学院流水号
objvCourseLearningAppraiseENT.CollegeID = objvCourseLearningAppraiseENS.CollegeID; //学院ID
objvCourseLearningAppraiseENT.CollegeName = objvCourseLearningAppraiseENS.CollegeName; //学院名称
objvCourseLearningAppraiseENT.IdXzMajor = objvCourseLearningAppraiseENS.IdXzMajor; //专业流水号
objvCourseLearningAppraiseENT.MajorID = objvCourseLearningAppraiseENS.MajorID; //专业ID
objvCourseLearningAppraiseENT.MajorName = objvCourseLearningAppraiseENS.MajorName; //专业名称
objvCourseLearningAppraiseENT.CourseId = objvCourseLearningAppraiseENS.CourseId; //课程Id
objvCourseLearningAppraiseENT.CourseCode = objvCourseLearningAppraiseENS.CourseCode; //课程代码
objvCourseLearningAppraiseENT.CourseName = objvCourseLearningAppraiseENS.CourseName; //课程名称
objvCourseLearningAppraiseENT.CollegeNameA = objvCourseLearningAppraiseENS.CollegeNameA; //学院名称简写
objvCourseLearningAppraiseENT.IdMicroteachAppraise = objvCourseLearningAppraiseENS.IdMicroteachAppraise; //评议流水号
objvCourseLearningAppraiseENT.FuncModuleId = objvCourseLearningAppraiseENS.FuncModuleId; //功能模块Id
objvCourseLearningAppraiseENT.FuncModuleName = objvCourseLearningAppraiseENS.FuncModuleName; //功能模块名称
objvCourseLearningAppraiseENT.IdMicroteachCase = objvCourseLearningAppraiseENS.IdMicroteachCase; //微格教学案例流水号
objvCourseLearningAppraiseENT.IdAppraiseType = objvCourseLearningAppraiseENS.IdAppraiseType; //评议类型流水号
objvCourseLearningAppraiseENT.AppraiseTypeName = objvCourseLearningAppraiseENS.AppraiseTypeName; //评议类型名称
objvCourseLearningAppraiseENT.AppraiseTheme = objvCourseLearningAppraiseENS.AppraiseTheme; //评议主题
objvCourseLearningAppraiseENT.AppraiseContent = objvCourseLearningAppraiseENS.AppraiseContent; //评议内容
objvCourseLearningAppraiseENT.AppraiseDate = objvCourseLearningAppraiseENS.AppraiseDate; //评议日期
objvCourseLearningAppraiseENT.AppraiseTime = objvCourseLearningAppraiseENS.AppraiseTime; //评议时间
objvCourseLearningAppraiseENT.IsVisual = objvCourseLearningAppraiseENS.IsVisual; //隐藏标志
objvCourseLearningAppraiseENT.IsElite = objvCourseLearningAppraiseENS.IsElite; //精华标志
objvCourseLearningAppraiseENT.UserId = objvCourseLearningAppraiseENS.UserId; //用户ID
objvCourseLearningAppraiseENT.ExcellentOne = objvCourseLearningAppraiseENS.ExcellentOne; //优点1
objvCourseLearningAppraiseENT.ExcellentTwo = objvCourseLearningAppraiseENS.ExcellentTwo; //优点2
objvCourseLearningAppraiseENT.SuggestOne = objvCourseLearningAppraiseENS.SuggestOne; //建议1
objvCourseLearningAppraiseENT.SuggestTwo = objvCourseLearningAppraiseENS.SuggestTwo; //建议2
objvCourseLearningAppraiseENT.MicroteachAppriseScore = objvCourseLearningAppraiseENS.MicroteachAppriseScore; //打分
objvCourseLearningAppraiseENT.VideoStopTime = objvCourseLearningAppraiseENS.VideoStopTime; //公开课案例视频暂停时间
objvCourseLearningAppraiseENT.BrowseCount = objvCourseLearningAppraiseENS.BrowseCount; //浏览次数
objvCourseLearningAppraiseENT.BrowseCount4Case = objvCourseLearningAppraiseENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningAppraiseENT.UserName = objvCourseLearningAppraiseENS.UserName; //用户名
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
 /// <param name = "objvCourseLearningAppraiseENS">源对象</param>
 /// <returns>目标对象=>clsvCourseLearningAppraiseEN:objvCourseLearningAppraiseENT</returns>
 public static clsvCourseLearningAppraiseEN CopyTo(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseENS)
{
try
{
 clsvCourseLearningAppraiseEN objvCourseLearningAppraiseENT = new clsvCourseLearningAppraiseEN()
{
IdCourseLearningCase = objvCourseLearningAppraiseENS.IdCourseLearningCase, //课程学习案例流水号
CourseLearningCaseID = objvCourseLearningAppraiseENS.CourseLearningCaseID, //课程学习案例ID
CourseLearningCaseName = objvCourseLearningAppraiseENS.CourseLearningCaseName, //课程学习案例名称
CourseLearningCaseTheme = objvCourseLearningAppraiseENS.CourseLearningCaseTheme, //课程学习案例主题词
CourseLearningCaseDate = objvCourseLearningAppraiseENS.CourseLearningCaseDate, //课程学习日期
CourseLearningCaseTime = objvCourseLearningAppraiseENS.CourseLearningCaseTime, //课程学习时间
CourseLearningCaseDateIn = objvCourseLearningAppraiseENS.CourseLearningCaseDateIn, //案例入库日期
CourseLearningCaseTimeIn = objvCourseLearningAppraiseENS.CourseLearningCaseTimeIn, //案例入库时间
CourseLearningCaseTypeName = objvCourseLearningAppraiseENS.CourseLearningCaseTypeName, //课程学习案例类型名称
UserNameWithUserId = objvCourseLearningAppraiseENS.UserNameWithUserId, //UserNameWithUserId
IdXzCollege = objvCourseLearningAppraiseENS.IdXzCollege, //学院流水号
CollegeID = objvCourseLearningAppraiseENS.CollegeID, //学院ID
CollegeName = objvCourseLearningAppraiseENS.CollegeName, //学院名称
IdXzMajor = objvCourseLearningAppraiseENS.IdXzMajor, //专业流水号
MajorID = objvCourseLearningAppraiseENS.MajorID, //专业ID
MajorName = objvCourseLearningAppraiseENS.MajorName, //专业名称
CourseId = objvCourseLearningAppraiseENS.CourseId, //课程Id
CourseCode = objvCourseLearningAppraiseENS.CourseCode, //课程代码
CourseName = objvCourseLearningAppraiseENS.CourseName, //课程名称
CollegeNameA = objvCourseLearningAppraiseENS.CollegeNameA, //学院名称简写
IdMicroteachAppraise = objvCourseLearningAppraiseENS.IdMicroteachAppraise, //评议流水号
FuncModuleId = objvCourseLearningAppraiseENS.FuncModuleId, //功能模块Id
FuncModuleName = objvCourseLearningAppraiseENS.FuncModuleName, //功能模块名称
IdMicroteachCase = objvCourseLearningAppraiseENS.IdMicroteachCase, //微格教学案例流水号
IdAppraiseType = objvCourseLearningAppraiseENS.IdAppraiseType, //评议类型流水号
AppraiseTypeName = objvCourseLearningAppraiseENS.AppraiseTypeName, //评议类型名称
AppraiseTheme = objvCourseLearningAppraiseENS.AppraiseTheme, //评议主题
AppraiseContent = objvCourseLearningAppraiseENS.AppraiseContent, //评议内容
AppraiseDate = objvCourseLearningAppraiseENS.AppraiseDate, //评议日期
AppraiseTime = objvCourseLearningAppraiseENS.AppraiseTime, //评议时间
IsVisual = objvCourseLearningAppraiseENS.IsVisual, //隐藏标志
IsElite = objvCourseLearningAppraiseENS.IsElite, //精华标志
UserId = objvCourseLearningAppraiseENS.UserId, //用户ID
ExcellentOne = objvCourseLearningAppraiseENS.ExcellentOne, //优点1
ExcellentTwo = objvCourseLearningAppraiseENS.ExcellentTwo, //优点2
SuggestOne = objvCourseLearningAppraiseENS.SuggestOne, //建议1
SuggestTwo = objvCourseLearningAppraiseENS.SuggestTwo, //建议2
MicroteachAppriseScore = objvCourseLearningAppraiseENS.MicroteachAppriseScore, //打分
VideoStopTime = objvCourseLearningAppraiseENS.VideoStopTime, //公开课案例视频暂停时间
BrowseCount = objvCourseLearningAppraiseENS.BrowseCount, //浏览次数
BrowseCount4Case = objvCourseLearningAppraiseENS.BrowseCount4Case, //课例浏览次数
UserName = objvCourseLearningAppraiseENS.UserName, //用户名
};
 return objvCourseLearningAppraiseENT;
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
public static void CheckProperty4Condition(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN)
{
 clsvCourseLearningAppraiseBL.vCourseLearningAppraiseDA.CheckProperty4Condition(objvCourseLearningAppraiseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningAppraiseEN objvCourseLearningAppraiseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.IdCourseLearningCase) == true)
{
string strComparisonOpIdCourseLearningCase = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.IdCourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.IdCourseLearningCase, objvCourseLearningAppraiseCond.IdCourseLearningCase, strComparisonOpIdCourseLearningCase);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.CourseLearningCaseID) == true)
{
string strComparisonOpCourseLearningCaseID = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseLearningCaseID, objvCourseLearningAppraiseCond.CourseLearningCaseID, strComparisonOpCourseLearningCaseID);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.CourseLearningCaseName) == true)
{
string strComparisonOpCourseLearningCaseName = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseLearningCaseName, objvCourseLearningAppraiseCond.CourseLearningCaseName, strComparisonOpCourseLearningCaseName);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.CourseLearningCaseTheme) == true)
{
string strComparisonOpCourseLearningCaseTheme = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseLearningCaseTheme, objvCourseLearningAppraiseCond.CourseLearningCaseTheme, strComparisonOpCourseLearningCaseTheme);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.CourseLearningCaseDate) == true)
{
string strComparisonOpCourseLearningCaseDate = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseLearningCaseDate, objvCourseLearningAppraiseCond.CourseLearningCaseDate, strComparisonOpCourseLearningCaseDate);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.CourseLearningCaseTime) == true)
{
string strComparisonOpCourseLearningCaseTime = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseLearningCaseTime, objvCourseLearningAppraiseCond.CourseLearningCaseTime, strComparisonOpCourseLearningCaseTime);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.CourseLearningCaseDateIn) == true)
{
string strComparisonOpCourseLearningCaseDateIn = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseLearningCaseDateIn, objvCourseLearningAppraiseCond.CourseLearningCaseDateIn, strComparisonOpCourseLearningCaseDateIn);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.CourseLearningCaseTimeIn) == true)
{
string strComparisonOpCourseLearningCaseTimeIn = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseLearningCaseTimeIn, objvCourseLearningAppraiseCond.CourseLearningCaseTimeIn, strComparisonOpCourseLearningCaseTimeIn);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.CourseLearningCaseTypeName) == true)
{
string strComparisonOpCourseLearningCaseTypeName = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.CourseLearningCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseLearningCaseTypeName, objvCourseLearningAppraiseCond.CourseLearningCaseTypeName, strComparisonOpCourseLearningCaseTypeName);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.UserNameWithUserId) == true)
{
string strComparisonOpUserNameWithUserId = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.UserNameWithUserId, objvCourseLearningAppraiseCond.UserNameWithUserId, strComparisonOpUserNameWithUserId);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.IdXzCollege, objvCourseLearningAppraiseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.CollegeID) == true)
{
string strComparisonOpCollegeID = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CollegeID, objvCourseLearningAppraiseCond.CollegeID, strComparisonOpCollegeID);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.CollegeName) == true)
{
string strComparisonOpCollegeName = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CollegeName, objvCourseLearningAppraiseCond.CollegeName, strComparisonOpCollegeName);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.IdXzMajor, objvCourseLearningAppraiseCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.MajorID) == true)
{
string strComparisonOpMajorID = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.MajorID, objvCourseLearningAppraiseCond.MajorID, strComparisonOpMajorID);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.MajorName) == true)
{
string strComparisonOpMajorName = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.MajorName, objvCourseLearningAppraiseCond.MajorName, strComparisonOpMajorName);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.CourseId) == true)
{
string strComparisonOpCourseId = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseId, objvCourseLearningAppraiseCond.CourseId, strComparisonOpCourseId);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.CourseCode) == true)
{
string strComparisonOpCourseCode = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseCode, objvCourseLearningAppraiseCond.CourseCode, strComparisonOpCourseCode);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.CourseName) == true)
{
string strComparisonOpCourseName = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CourseName, objvCourseLearningAppraiseCond.CourseName, strComparisonOpCourseName);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.CollegeNameA, objvCourseLearningAppraiseCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.IdMicroteachAppraise) == true)
{
string strComparisonOpIdMicroteachAppraise = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.IdMicroteachAppraise];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningAppraise.IdMicroteachAppraise, objvCourseLearningAppraiseCond.IdMicroteachAppraise, strComparisonOpIdMicroteachAppraise);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.FuncModuleId, objvCourseLearningAppraiseCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.FuncModuleName, objvCourseLearningAppraiseCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.IdMicroteachCase, objvCourseLearningAppraiseCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.IdAppraiseType) == true)
{
string strComparisonOpIdAppraiseType = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.IdAppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.IdAppraiseType, objvCourseLearningAppraiseCond.IdAppraiseType, strComparisonOpIdAppraiseType);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.AppraiseTypeName) == true)
{
string strComparisonOpAppraiseTypeName = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.AppraiseTypeName, objvCourseLearningAppraiseCond.AppraiseTypeName, strComparisonOpAppraiseTypeName);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.AppraiseTheme) == true)
{
string strComparisonOpAppraiseTheme = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.AppraiseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.AppraiseTheme, objvCourseLearningAppraiseCond.AppraiseTheme, strComparisonOpAppraiseTheme);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.AppraiseContent) == true)
{
string strComparisonOpAppraiseContent = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.AppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.AppraiseContent, objvCourseLearningAppraiseCond.AppraiseContent, strComparisonOpAppraiseContent);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.AppraiseDate) == true)
{
string strComparisonOpAppraiseDate = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.AppraiseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.AppraiseDate, objvCourseLearningAppraiseCond.AppraiseDate, strComparisonOpAppraiseDate);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.AppraiseTime) == true)
{
string strComparisonOpAppraiseTime = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.AppraiseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.AppraiseTime, objvCourseLearningAppraiseCond.AppraiseTime, strComparisonOpAppraiseTime);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.IsVisual) == true)
{
if (objvCourseLearningAppraiseCond.IsVisual == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningAppraise.IsVisual);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningAppraise.IsVisual);
}
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.IsElite) == true)
{
if (objvCourseLearningAppraiseCond.IsElite == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCourseLearningAppraise.IsElite);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCourseLearningAppraise.IsElite);
}
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.UserId) == true)
{
string strComparisonOpUserId = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.UserId, objvCourseLearningAppraiseCond.UserId, strComparisonOpUserId);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.ExcellentOne) == true)
{
string strComparisonOpExcellentOne = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.ExcellentOne];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.ExcellentOne, objvCourseLearningAppraiseCond.ExcellentOne, strComparisonOpExcellentOne);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.ExcellentTwo) == true)
{
string strComparisonOpExcellentTwo = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.ExcellentTwo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.ExcellentTwo, objvCourseLearningAppraiseCond.ExcellentTwo, strComparisonOpExcellentTwo);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.SuggestOne) == true)
{
string strComparisonOpSuggestOne = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.SuggestOne];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.SuggestOne, objvCourseLearningAppraiseCond.SuggestOne, strComparisonOpSuggestOne);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.SuggestTwo) == true)
{
string strComparisonOpSuggestTwo = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.SuggestTwo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.SuggestTwo, objvCourseLearningAppraiseCond.SuggestTwo, strComparisonOpSuggestTwo);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.MicroteachAppriseScore) == true)
{
string strComparisonOpMicroteachAppriseScore = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.MicroteachAppriseScore];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningAppraise.MicroteachAppriseScore, objvCourseLearningAppraiseCond.MicroteachAppriseScore, strComparisonOpMicroteachAppriseScore);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.VideoStopTime) == true)
{
string strComparisonOpVideoStopTime = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.VideoStopTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.VideoStopTime, objvCourseLearningAppraiseCond.VideoStopTime, strComparisonOpVideoStopTime);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningAppraise.BrowseCount, objvCourseLearningAppraiseCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningAppraise.BrowseCount4Case, objvCourseLearningAppraiseCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvCourseLearningAppraiseCond.IsUpdated(convCourseLearningAppraise.UserName) == true)
{
string strComparisonOpUserName = objvCourseLearningAppraiseCond.dicFldComparisonOp[convCourseLearningAppraise.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise.UserName, objvCourseLearningAppraiseCond.UserName, strComparisonOpUserName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCourseLearningAppraise
{
public virtual bool UpdRelaTabDate(long lngIdMicroteachAppraise, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程学习定性评议(vCourseLearningAppraise)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningAppraiseBL
{
public static RelatedActions_vCourseLearningAppraise relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCourseLearningAppraiseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCourseLearningAppraiseDA vCourseLearningAppraiseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCourseLearningAppraiseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCourseLearningAppraiseBL()
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
if (string.IsNullOrEmpty(clsvCourseLearningAppraiseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCourseLearningAppraiseEN._ConnectString);
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
public static DataTable GetDataTable_vCourseLearningAppraise(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCourseLearningAppraiseDA.GetDataTable_vCourseLearningAppraise(strWhereCond);
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
objDT = vCourseLearningAppraiseDA.GetDataTable(strWhereCond);
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
objDT = vCourseLearningAppraiseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCourseLearningAppraiseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCourseLearningAppraiseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCourseLearningAppraiseDA.GetDataTable_Top(objTopPara);
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
objDT = vCourseLearningAppraiseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCourseLearningAppraiseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCourseLearningAppraiseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroteachAppraiseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCourseLearningAppraiseEN> GetObjLstByIdMicroteachAppraiseLst(List<long> arrIdMicroteachAppraiseLst)
{
List<clsvCourseLearningAppraiseEN> arrObjLst = new List<clsvCourseLearningAppraiseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroteachAppraiseLst);
 string strWhereCond = string.Format("IdMicroteachAppraise in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = new clsvCourseLearningAppraiseEN();
try
{
objvCourseLearningAppraiseEN.IdCourseLearningCase = objRow[convCourseLearningAppraise.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraiseEN.CourseLearningCaseID = objRow[convCourseLearningAppraise.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningAppraiseEN.CourseLearningCaseName = objRow[convCourseLearningAppraise.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraiseEN.CourseLearningCaseTheme = objRow[convCourseLearningAppraise.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningAppraiseEN.CourseLearningCaseDate = objRow[convCourseLearningAppraise.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningAppraiseEN.CourseLearningCaseTime = objRow[convCourseLearningAppraise.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = objRow[convCourseLearningAppraise.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = objRow[convCourseLearningAppraise.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningAppraiseEN.UserNameWithUserId = objRow[convCourseLearningAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningAppraiseEN.IdXzCollege = objRow[convCourseLearningAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningAppraiseEN.CollegeID = objRow[convCourseLearningAppraise.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningAppraiseEN.CollegeName = objRow[convCourseLearningAppraise.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningAppraiseEN.IdXzMajor = objRow[convCourseLearningAppraise.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningAppraiseEN.MajorID = objRow[convCourseLearningAppraise.MajorID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorID].ToString().Trim(); //专业ID
objvCourseLearningAppraiseEN.MajorName = objRow[convCourseLearningAppraise.MajorName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorName].ToString().Trim(); //专业名称
objvCourseLearningAppraiseEN.CourseId = objRow[convCourseLearningAppraise.CourseId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseId].ToString().Trim(); //课程Id
objvCourseLearningAppraiseEN.CourseCode = objRow[convCourseLearningAppraise.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningAppraiseEN.CourseName = objRow[convCourseLearningAppraise.CourseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseName].ToString().Trim(); //课程名称
objvCourseLearningAppraiseEN.CollegeNameA = objRow[convCourseLearningAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraiseEN.FuncModuleId = objRow[convCourseLearningAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraiseEN.FuncModuleName = objRow[convCourseLearningAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraiseEN.IdMicroteachCase = objRow[convCourseLearningAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraiseEN.IdAppraiseType = objRow[convCourseLearningAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraiseEN.AppraiseTypeName = objRow[convCourseLearningAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraiseEN.AppraiseTheme = objRow[convCourseLearningAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvCourseLearningAppraiseEN.AppraiseContent = objRow[convCourseLearningAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraiseEN.AppraiseDate = objRow[convCourseLearningAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraiseEN.AppraiseTime = objRow[convCourseLearningAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvCourseLearningAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsElite].ToString().Trim()); //精华标志
objvCourseLearningAppraiseEN.UserId = objRow[convCourseLearningAppraise.UserId].ToString().Trim(); //用户ID
objvCourseLearningAppraiseEN.ExcellentOne = objRow[convCourseLearningAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentOne].ToString().Trim(); //优点1
objvCourseLearningAppraiseEN.ExcellentTwo = objRow[convCourseLearningAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvCourseLearningAppraiseEN.SuggestOne = objRow[convCourseLearningAppraise.SuggestOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestOne].ToString().Trim(); //建议1
objvCourseLearningAppraiseEN.SuggestTwo = objRow[convCourseLearningAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestTwo].ToString().Trim(); //建议2
objvCourseLearningAppraiseEN.MicroteachAppriseScore = objRow[convCourseLearningAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvCourseLearningAppraiseEN.VideoStopTime = objRow[convCourseLearningAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvCourseLearningAppraiseEN.BrowseCount = objRow[convCourseLearningAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningAppraiseEN.BrowseCount4Case = objRow[convCourseLearningAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningAppraiseEN.UserName = objRow[convCourseLearningAppraise.UserName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachAppraiseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCourseLearningAppraiseEN> GetObjLstByIdMicroteachAppraiseLstCache(List<long> arrIdMicroteachAppraiseLst)
{
string strKey = string.Format("{0}", clsvCourseLearningAppraiseEN._CurrTabName);
List<clsvCourseLearningAppraiseEN> arrvCourseLearningAppraiseObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningAppraiseEN> arrvCourseLearningAppraiseObjLst_Sel =
arrvCourseLearningAppraiseObjLstCache
.Where(x => arrIdMicroteachAppraiseLst.Contains(x.IdMicroteachAppraise));
return arrvCourseLearningAppraiseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningAppraiseEN> GetObjLst(string strWhereCond)
{
List<clsvCourseLearningAppraiseEN> arrObjLst = new List<clsvCourseLearningAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = new clsvCourseLearningAppraiseEN();
try
{
objvCourseLearningAppraiseEN.IdCourseLearningCase = objRow[convCourseLearningAppraise.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraiseEN.CourseLearningCaseID = objRow[convCourseLearningAppraise.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningAppraiseEN.CourseLearningCaseName = objRow[convCourseLearningAppraise.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraiseEN.CourseLearningCaseTheme = objRow[convCourseLearningAppraise.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningAppraiseEN.CourseLearningCaseDate = objRow[convCourseLearningAppraise.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningAppraiseEN.CourseLearningCaseTime = objRow[convCourseLearningAppraise.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = objRow[convCourseLearningAppraise.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = objRow[convCourseLearningAppraise.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningAppraiseEN.UserNameWithUserId = objRow[convCourseLearningAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningAppraiseEN.IdXzCollege = objRow[convCourseLearningAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningAppraiseEN.CollegeID = objRow[convCourseLearningAppraise.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningAppraiseEN.CollegeName = objRow[convCourseLearningAppraise.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningAppraiseEN.IdXzMajor = objRow[convCourseLearningAppraise.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningAppraiseEN.MajorID = objRow[convCourseLearningAppraise.MajorID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorID].ToString().Trim(); //专业ID
objvCourseLearningAppraiseEN.MajorName = objRow[convCourseLearningAppraise.MajorName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorName].ToString().Trim(); //专业名称
objvCourseLearningAppraiseEN.CourseId = objRow[convCourseLearningAppraise.CourseId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseId].ToString().Trim(); //课程Id
objvCourseLearningAppraiseEN.CourseCode = objRow[convCourseLearningAppraise.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningAppraiseEN.CourseName = objRow[convCourseLearningAppraise.CourseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseName].ToString().Trim(); //课程名称
objvCourseLearningAppraiseEN.CollegeNameA = objRow[convCourseLearningAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraiseEN.FuncModuleId = objRow[convCourseLearningAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraiseEN.FuncModuleName = objRow[convCourseLearningAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraiseEN.IdMicroteachCase = objRow[convCourseLearningAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraiseEN.IdAppraiseType = objRow[convCourseLearningAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraiseEN.AppraiseTypeName = objRow[convCourseLearningAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraiseEN.AppraiseTheme = objRow[convCourseLearningAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvCourseLearningAppraiseEN.AppraiseContent = objRow[convCourseLearningAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraiseEN.AppraiseDate = objRow[convCourseLearningAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraiseEN.AppraiseTime = objRow[convCourseLearningAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvCourseLearningAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsElite].ToString().Trim()); //精华标志
objvCourseLearningAppraiseEN.UserId = objRow[convCourseLearningAppraise.UserId].ToString().Trim(); //用户ID
objvCourseLearningAppraiseEN.ExcellentOne = objRow[convCourseLearningAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentOne].ToString().Trim(); //优点1
objvCourseLearningAppraiseEN.ExcellentTwo = objRow[convCourseLearningAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvCourseLearningAppraiseEN.SuggestOne = objRow[convCourseLearningAppraise.SuggestOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestOne].ToString().Trim(); //建议1
objvCourseLearningAppraiseEN.SuggestTwo = objRow[convCourseLearningAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestTwo].ToString().Trim(); //建议2
objvCourseLearningAppraiseEN.MicroteachAppriseScore = objRow[convCourseLearningAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvCourseLearningAppraiseEN.VideoStopTime = objRow[convCourseLearningAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvCourseLearningAppraiseEN.BrowseCount = objRow[convCourseLearningAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningAppraiseEN.BrowseCount4Case = objRow[convCourseLearningAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningAppraiseEN.UserName = objRow[convCourseLearningAppraise.UserName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraiseEN);
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
public static List<clsvCourseLearningAppraiseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningAppraiseEN> arrObjLst = new List<clsvCourseLearningAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = new clsvCourseLearningAppraiseEN();
try
{
objvCourseLearningAppraiseEN.IdCourseLearningCase = objRow[convCourseLearningAppraise.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraiseEN.CourseLearningCaseID = objRow[convCourseLearningAppraise.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningAppraiseEN.CourseLearningCaseName = objRow[convCourseLearningAppraise.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraiseEN.CourseLearningCaseTheme = objRow[convCourseLearningAppraise.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningAppraiseEN.CourseLearningCaseDate = objRow[convCourseLearningAppraise.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningAppraiseEN.CourseLearningCaseTime = objRow[convCourseLearningAppraise.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = objRow[convCourseLearningAppraise.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = objRow[convCourseLearningAppraise.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningAppraiseEN.UserNameWithUserId = objRow[convCourseLearningAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningAppraiseEN.IdXzCollege = objRow[convCourseLearningAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningAppraiseEN.CollegeID = objRow[convCourseLearningAppraise.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningAppraiseEN.CollegeName = objRow[convCourseLearningAppraise.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningAppraiseEN.IdXzMajor = objRow[convCourseLearningAppraise.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningAppraiseEN.MajorID = objRow[convCourseLearningAppraise.MajorID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorID].ToString().Trim(); //专业ID
objvCourseLearningAppraiseEN.MajorName = objRow[convCourseLearningAppraise.MajorName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorName].ToString().Trim(); //专业名称
objvCourseLearningAppraiseEN.CourseId = objRow[convCourseLearningAppraise.CourseId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseId].ToString().Trim(); //课程Id
objvCourseLearningAppraiseEN.CourseCode = objRow[convCourseLearningAppraise.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningAppraiseEN.CourseName = objRow[convCourseLearningAppraise.CourseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseName].ToString().Trim(); //课程名称
objvCourseLearningAppraiseEN.CollegeNameA = objRow[convCourseLearningAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraiseEN.FuncModuleId = objRow[convCourseLearningAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraiseEN.FuncModuleName = objRow[convCourseLearningAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraiseEN.IdMicroteachCase = objRow[convCourseLearningAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraiseEN.IdAppraiseType = objRow[convCourseLearningAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraiseEN.AppraiseTypeName = objRow[convCourseLearningAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraiseEN.AppraiseTheme = objRow[convCourseLearningAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvCourseLearningAppraiseEN.AppraiseContent = objRow[convCourseLearningAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraiseEN.AppraiseDate = objRow[convCourseLearningAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraiseEN.AppraiseTime = objRow[convCourseLearningAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvCourseLearningAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsElite].ToString().Trim()); //精华标志
objvCourseLearningAppraiseEN.UserId = objRow[convCourseLearningAppraise.UserId].ToString().Trim(); //用户ID
objvCourseLearningAppraiseEN.ExcellentOne = objRow[convCourseLearningAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentOne].ToString().Trim(); //优点1
objvCourseLearningAppraiseEN.ExcellentTwo = objRow[convCourseLearningAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvCourseLearningAppraiseEN.SuggestOne = objRow[convCourseLearningAppraise.SuggestOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestOne].ToString().Trim(); //建议1
objvCourseLearningAppraiseEN.SuggestTwo = objRow[convCourseLearningAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestTwo].ToString().Trim(); //建议2
objvCourseLearningAppraiseEN.MicroteachAppriseScore = objRow[convCourseLearningAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvCourseLearningAppraiseEN.VideoStopTime = objRow[convCourseLearningAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvCourseLearningAppraiseEN.BrowseCount = objRow[convCourseLearningAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningAppraiseEN.BrowseCount4Case = objRow[convCourseLearningAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningAppraiseEN.UserName = objRow[convCourseLearningAppraise.UserName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCourseLearningAppraiseEN> GetSubObjLstCache(clsvCourseLearningAppraiseEN objvCourseLearningAppraiseCond)
{
List<clsvCourseLearningAppraiseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningAppraiseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningAppraise.AttributeName)
{
if (objvCourseLearningAppraiseCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningAppraiseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningAppraiseCond[strFldName].ToString());
}
else
{
if (objvCourseLearningAppraiseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningAppraiseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningAppraiseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningAppraiseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningAppraiseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningAppraiseCond[strFldName]));
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
public static List<clsvCourseLearningAppraiseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCourseLearningAppraiseEN> arrObjLst = new List<clsvCourseLearningAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = new clsvCourseLearningAppraiseEN();
try
{
objvCourseLearningAppraiseEN.IdCourseLearningCase = objRow[convCourseLearningAppraise.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraiseEN.CourseLearningCaseID = objRow[convCourseLearningAppraise.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningAppraiseEN.CourseLearningCaseName = objRow[convCourseLearningAppraise.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraiseEN.CourseLearningCaseTheme = objRow[convCourseLearningAppraise.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningAppraiseEN.CourseLearningCaseDate = objRow[convCourseLearningAppraise.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningAppraiseEN.CourseLearningCaseTime = objRow[convCourseLearningAppraise.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = objRow[convCourseLearningAppraise.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = objRow[convCourseLearningAppraise.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningAppraiseEN.UserNameWithUserId = objRow[convCourseLearningAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningAppraiseEN.IdXzCollege = objRow[convCourseLearningAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningAppraiseEN.CollegeID = objRow[convCourseLearningAppraise.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningAppraiseEN.CollegeName = objRow[convCourseLearningAppraise.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningAppraiseEN.IdXzMajor = objRow[convCourseLearningAppraise.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningAppraiseEN.MajorID = objRow[convCourseLearningAppraise.MajorID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorID].ToString().Trim(); //专业ID
objvCourseLearningAppraiseEN.MajorName = objRow[convCourseLearningAppraise.MajorName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorName].ToString().Trim(); //专业名称
objvCourseLearningAppraiseEN.CourseId = objRow[convCourseLearningAppraise.CourseId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseId].ToString().Trim(); //课程Id
objvCourseLearningAppraiseEN.CourseCode = objRow[convCourseLearningAppraise.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningAppraiseEN.CourseName = objRow[convCourseLearningAppraise.CourseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseName].ToString().Trim(); //课程名称
objvCourseLearningAppraiseEN.CollegeNameA = objRow[convCourseLearningAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraiseEN.FuncModuleId = objRow[convCourseLearningAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraiseEN.FuncModuleName = objRow[convCourseLearningAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraiseEN.IdMicroteachCase = objRow[convCourseLearningAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraiseEN.IdAppraiseType = objRow[convCourseLearningAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraiseEN.AppraiseTypeName = objRow[convCourseLearningAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraiseEN.AppraiseTheme = objRow[convCourseLearningAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvCourseLearningAppraiseEN.AppraiseContent = objRow[convCourseLearningAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraiseEN.AppraiseDate = objRow[convCourseLearningAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraiseEN.AppraiseTime = objRow[convCourseLearningAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvCourseLearningAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsElite].ToString().Trim()); //精华标志
objvCourseLearningAppraiseEN.UserId = objRow[convCourseLearningAppraise.UserId].ToString().Trim(); //用户ID
objvCourseLearningAppraiseEN.ExcellentOne = objRow[convCourseLearningAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentOne].ToString().Trim(); //优点1
objvCourseLearningAppraiseEN.ExcellentTwo = objRow[convCourseLearningAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvCourseLearningAppraiseEN.SuggestOne = objRow[convCourseLearningAppraise.SuggestOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestOne].ToString().Trim(); //建议1
objvCourseLearningAppraiseEN.SuggestTwo = objRow[convCourseLearningAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestTwo].ToString().Trim(); //建议2
objvCourseLearningAppraiseEN.MicroteachAppriseScore = objRow[convCourseLearningAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvCourseLearningAppraiseEN.VideoStopTime = objRow[convCourseLearningAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvCourseLearningAppraiseEN.BrowseCount = objRow[convCourseLearningAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningAppraiseEN.BrowseCount4Case = objRow[convCourseLearningAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningAppraiseEN.UserName = objRow[convCourseLearningAppraise.UserName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraiseEN);
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
public static List<clsvCourseLearningAppraiseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCourseLearningAppraiseEN> arrObjLst = new List<clsvCourseLearningAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = new clsvCourseLearningAppraiseEN();
try
{
objvCourseLearningAppraiseEN.IdCourseLearningCase = objRow[convCourseLearningAppraise.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraiseEN.CourseLearningCaseID = objRow[convCourseLearningAppraise.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningAppraiseEN.CourseLearningCaseName = objRow[convCourseLearningAppraise.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraiseEN.CourseLearningCaseTheme = objRow[convCourseLearningAppraise.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningAppraiseEN.CourseLearningCaseDate = objRow[convCourseLearningAppraise.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningAppraiseEN.CourseLearningCaseTime = objRow[convCourseLearningAppraise.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = objRow[convCourseLearningAppraise.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = objRow[convCourseLearningAppraise.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningAppraiseEN.UserNameWithUserId = objRow[convCourseLearningAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningAppraiseEN.IdXzCollege = objRow[convCourseLearningAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningAppraiseEN.CollegeID = objRow[convCourseLearningAppraise.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningAppraiseEN.CollegeName = objRow[convCourseLearningAppraise.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningAppraiseEN.IdXzMajor = objRow[convCourseLearningAppraise.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningAppraiseEN.MajorID = objRow[convCourseLearningAppraise.MajorID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorID].ToString().Trim(); //专业ID
objvCourseLearningAppraiseEN.MajorName = objRow[convCourseLearningAppraise.MajorName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorName].ToString().Trim(); //专业名称
objvCourseLearningAppraiseEN.CourseId = objRow[convCourseLearningAppraise.CourseId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseId].ToString().Trim(); //课程Id
objvCourseLearningAppraiseEN.CourseCode = objRow[convCourseLearningAppraise.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningAppraiseEN.CourseName = objRow[convCourseLearningAppraise.CourseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseName].ToString().Trim(); //课程名称
objvCourseLearningAppraiseEN.CollegeNameA = objRow[convCourseLearningAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraiseEN.FuncModuleId = objRow[convCourseLearningAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraiseEN.FuncModuleName = objRow[convCourseLearningAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraiseEN.IdMicroteachCase = objRow[convCourseLearningAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraiseEN.IdAppraiseType = objRow[convCourseLearningAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraiseEN.AppraiseTypeName = objRow[convCourseLearningAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraiseEN.AppraiseTheme = objRow[convCourseLearningAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvCourseLearningAppraiseEN.AppraiseContent = objRow[convCourseLearningAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraiseEN.AppraiseDate = objRow[convCourseLearningAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraiseEN.AppraiseTime = objRow[convCourseLearningAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvCourseLearningAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsElite].ToString().Trim()); //精华标志
objvCourseLearningAppraiseEN.UserId = objRow[convCourseLearningAppraise.UserId].ToString().Trim(); //用户ID
objvCourseLearningAppraiseEN.ExcellentOne = objRow[convCourseLearningAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentOne].ToString().Trim(); //优点1
objvCourseLearningAppraiseEN.ExcellentTwo = objRow[convCourseLearningAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvCourseLearningAppraiseEN.SuggestOne = objRow[convCourseLearningAppraise.SuggestOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestOne].ToString().Trim(); //建议1
objvCourseLearningAppraiseEN.SuggestTwo = objRow[convCourseLearningAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestTwo].ToString().Trim(); //建议2
objvCourseLearningAppraiseEN.MicroteachAppriseScore = objRow[convCourseLearningAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvCourseLearningAppraiseEN.VideoStopTime = objRow[convCourseLearningAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvCourseLearningAppraiseEN.BrowseCount = objRow[convCourseLearningAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningAppraiseEN.BrowseCount4Case = objRow[convCourseLearningAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningAppraiseEN.UserName = objRow[convCourseLearningAppraise.UserName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraiseEN);
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
List<clsvCourseLearningAppraiseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCourseLearningAppraiseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningAppraiseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCourseLearningAppraiseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningAppraiseEN> arrObjLst = new List<clsvCourseLearningAppraiseEN>(); 
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
	clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = new clsvCourseLearningAppraiseEN();
try
{
objvCourseLearningAppraiseEN.IdCourseLearningCase = objRow[convCourseLearningAppraise.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraiseEN.CourseLearningCaseID = objRow[convCourseLearningAppraise.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningAppraiseEN.CourseLearningCaseName = objRow[convCourseLearningAppraise.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraiseEN.CourseLearningCaseTheme = objRow[convCourseLearningAppraise.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningAppraiseEN.CourseLearningCaseDate = objRow[convCourseLearningAppraise.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningAppraiseEN.CourseLearningCaseTime = objRow[convCourseLearningAppraise.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = objRow[convCourseLearningAppraise.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = objRow[convCourseLearningAppraise.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningAppraiseEN.UserNameWithUserId = objRow[convCourseLearningAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningAppraiseEN.IdXzCollege = objRow[convCourseLearningAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningAppraiseEN.CollegeID = objRow[convCourseLearningAppraise.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningAppraiseEN.CollegeName = objRow[convCourseLearningAppraise.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningAppraiseEN.IdXzMajor = objRow[convCourseLearningAppraise.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningAppraiseEN.MajorID = objRow[convCourseLearningAppraise.MajorID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorID].ToString().Trim(); //专业ID
objvCourseLearningAppraiseEN.MajorName = objRow[convCourseLearningAppraise.MajorName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorName].ToString().Trim(); //专业名称
objvCourseLearningAppraiseEN.CourseId = objRow[convCourseLearningAppraise.CourseId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseId].ToString().Trim(); //课程Id
objvCourseLearningAppraiseEN.CourseCode = objRow[convCourseLearningAppraise.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningAppraiseEN.CourseName = objRow[convCourseLearningAppraise.CourseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseName].ToString().Trim(); //课程名称
objvCourseLearningAppraiseEN.CollegeNameA = objRow[convCourseLearningAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraiseEN.FuncModuleId = objRow[convCourseLearningAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraiseEN.FuncModuleName = objRow[convCourseLearningAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraiseEN.IdMicroteachCase = objRow[convCourseLearningAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraiseEN.IdAppraiseType = objRow[convCourseLearningAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraiseEN.AppraiseTypeName = objRow[convCourseLearningAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraiseEN.AppraiseTheme = objRow[convCourseLearningAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvCourseLearningAppraiseEN.AppraiseContent = objRow[convCourseLearningAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraiseEN.AppraiseDate = objRow[convCourseLearningAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraiseEN.AppraiseTime = objRow[convCourseLearningAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvCourseLearningAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsElite].ToString().Trim()); //精华标志
objvCourseLearningAppraiseEN.UserId = objRow[convCourseLearningAppraise.UserId].ToString().Trim(); //用户ID
objvCourseLearningAppraiseEN.ExcellentOne = objRow[convCourseLearningAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentOne].ToString().Trim(); //优点1
objvCourseLearningAppraiseEN.ExcellentTwo = objRow[convCourseLearningAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvCourseLearningAppraiseEN.SuggestOne = objRow[convCourseLearningAppraise.SuggestOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestOne].ToString().Trim(); //建议1
objvCourseLearningAppraiseEN.SuggestTwo = objRow[convCourseLearningAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestTwo].ToString().Trim(); //建议2
objvCourseLearningAppraiseEN.MicroteachAppriseScore = objRow[convCourseLearningAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvCourseLearningAppraiseEN.VideoStopTime = objRow[convCourseLearningAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvCourseLearningAppraiseEN.BrowseCount = objRow[convCourseLearningAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningAppraiseEN.BrowseCount4Case = objRow[convCourseLearningAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningAppraiseEN.UserName = objRow[convCourseLearningAppraise.UserName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraiseEN);
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
public static List<clsvCourseLearningAppraiseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningAppraiseEN> arrObjLst = new List<clsvCourseLearningAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = new clsvCourseLearningAppraiseEN();
try
{
objvCourseLearningAppraiseEN.IdCourseLearningCase = objRow[convCourseLearningAppraise.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraiseEN.CourseLearningCaseID = objRow[convCourseLearningAppraise.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningAppraiseEN.CourseLearningCaseName = objRow[convCourseLearningAppraise.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraiseEN.CourseLearningCaseTheme = objRow[convCourseLearningAppraise.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningAppraiseEN.CourseLearningCaseDate = objRow[convCourseLearningAppraise.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningAppraiseEN.CourseLearningCaseTime = objRow[convCourseLearningAppraise.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = objRow[convCourseLearningAppraise.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = objRow[convCourseLearningAppraise.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningAppraiseEN.UserNameWithUserId = objRow[convCourseLearningAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningAppraiseEN.IdXzCollege = objRow[convCourseLearningAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningAppraiseEN.CollegeID = objRow[convCourseLearningAppraise.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningAppraiseEN.CollegeName = objRow[convCourseLearningAppraise.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningAppraiseEN.IdXzMajor = objRow[convCourseLearningAppraise.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningAppraiseEN.MajorID = objRow[convCourseLearningAppraise.MajorID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorID].ToString().Trim(); //专业ID
objvCourseLearningAppraiseEN.MajorName = objRow[convCourseLearningAppraise.MajorName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorName].ToString().Trim(); //专业名称
objvCourseLearningAppraiseEN.CourseId = objRow[convCourseLearningAppraise.CourseId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseId].ToString().Trim(); //课程Id
objvCourseLearningAppraiseEN.CourseCode = objRow[convCourseLearningAppraise.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningAppraiseEN.CourseName = objRow[convCourseLearningAppraise.CourseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseName].ToString().Trim(); //课程名称
objvCourseLearningAppraiseEN.CollegeNameA = objRow[convCourseLearningAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraiseEN.FuncModuleId = objRow[convCourseLearningAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraiseEN.FuncModuleName = objRow[convCourseLearningAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraiseEN.IdMicroteachCase = objRow[convCourseLearningAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraiseEN.IdAppraiseType = objRow[convCourseLearningAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraiseEN.AppraiseTypeName = objRow[convCourseLearningAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraiseEN.AppraiseTheme = objRow[convCourseLearningAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvCourseLearningAppraiseEN.AppraiseContent = objRow[convCourseLearningAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraiseEN.AppraiseDate = objRow[convCourseLearningAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraiseEN.AppraiseTime = objRow[convCourseLearningAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvCourseLearningAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsElite].ToString().Trim()); //精华标志
objvCourseLearningAppraiseEN.UserId = objRow[convCourseLearningAppraise.UserId].ToString().Trim(); //用户ID
objvCourseLearningAppraiseEN.ExcellentOne = objRow[convCourseLearningAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentOne].ToString().Trim(); //优点1
objvCourseLearningAppraiseEN.ExcellentTwo = objRow[convCourseLearningAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvCourseLearningAppraiseEN.SuggestOne = objRow[convCourseLearningAppraise.SuggestOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestOne].ToString().Trim(); //建议1
objvCourseLearningAppraiseEN.SuggestTwo = objRow[convCourseLearningAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestTwo].ToString().Trim(); //建议2
objvCourseLearningAppraiseEN.MicroteachAppriseScore = objRow[convCourseLearningAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvCourseLearningAppraiseEN.VideoStopTime = objRow[convCourseLearningAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvCourseLearningAppraiseEN.BrowseCount = objRow[convCourseLearningAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningAppraiseEN.BrowseCount4Case = objRow[convCourseLearningAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningAppraiseEN.UserName = objRow[convCourseLearningAppraise.UserName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCourseLearningAppraiseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCourseLearningAppraiseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningAppraiseEN> arrObjLst = new List<clsvCourseLearningAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = new clsvCourseLearningAppraiseEN();
try
{
objvCourseLearningAppraiseEN.IdCourseLearningCase = objRow[convCourseLearningAppraise.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraiseEN.CourseLearningCaseID = objRow[convCourseLearningAppraise.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningAppraiseEN.CourseLearningCaseName = objRow[convCourseLearningAppraise.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraiseEN.CourseLearningCaseTheme = objRow[convCourseLearningAppraise.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningAppraiseEN.CourseLearningCaseDate = objRow[convCourseLearningAppraise.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningAppraiseEN.CourseLearningCaseTime = objRow[convCourseLearningAppraise.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = objRow[convCourseLearningAppraise.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = objRow[convCourseLearningAppraise.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningAppraiseEN.UserNameWithUserId = objRow[convCourseLearningAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningAppraiseEN.IdXzCollege = objRow[convCourseLearningAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningAppraiseEN.CollegeID = objRow[convCourseLearningAppraise.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningAppraiseEN.CollegeName = objRow[convCourseLearningAppraise.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningAppraiseEN.IdXzMajor = objRow[convCourseLearningAppraise.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningAppraiseEN.MajorID = objRow[convCourseLearningAppraise.MajorID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorID].ToString().Trim(); //专业ID
objvCourseLearningAppraiseEN.MajorName = objRow[convCourseLearningAppraise.MajorName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorName].ToString().Trim(); //专业名称
objvCourseLearningAppraiseEN.CourseId = objRow[convCourseLearningAppraise.CourseId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseId].ToString().Trim(); //课程Id
objvCourseLearningAppraiseEN.CourseCode = objRow[convCourseLearningAppraise.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningAppraiseEN.CourseName = objRow[convCourseLearningAppraise.CourseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseName].ToString().Trim(); //课程名称
objvCourseLearningAppraiseEN.CollegeNameA = objRow[convCourseLearningAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraiseEN.FuncModuleId = objRow[convCourseLearningAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraiseEN.FuncModuleName = objRow[convCourseLearningAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraiseEN.IdMicroteachCase = objRow[convCourseLearningAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraiseEN.IdAppraiseType = objRow[convCourseLearningAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraiseEN.AppraiseTypeName = objRow[convCourseLearningAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraiseEN.AppraiseTheme = objRow[convCourseLearningAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvCourseLearningAppraiseEN.AppraiseContent = objRow[convCourseLearningAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraiseEN.AppraiseDate = objRow[convCourseLearningAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraiseEN.AppraiseTime = objRow[convCourseLearningAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvCourseLearningAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsElite].ToString().Trim()); //精华标志
objvCourseLearningAppraiseEN.UserId = objRow[convCourseLearningAppraise.UserId].ToString().Trim(); //用户ID
objvCourseLearningAppraiseEN.ExcellentOne = objRow[convCourseLearningAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentOne].ToString().Trim(); //优点1
objvCourseLearningAppraiseEN.ExcellentTwo = objRow[convCourseLearningAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvCourseLearningAppraiseEN.SuggestOne = objRow[convCourseLearningAppraise.SuggestOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestOne].ToString().Trim(); //建议1
objvCourseLearningAppraiseEN.SuggestTwo = objRow[convCourseLearningAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestTwo].ToString().Trim(); //建议2
objvCourseLearningAppraiseEN.MicroteachAppriseScore = objRow[convCourseLearningAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvCourseLearningAppraiseEN.VideoStopTime = objRow[convCourseLearningAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvCourseLearningAppraiseEN.BrowseCount = objRow[convCourseLearningAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningAppraiseEN.BrowseCount4Case = objRow[convCourseLearningAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningAppraiseEN.UserName = objRow[convCourseLearningAppraise.UserName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraiseEN);
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
public static List<clsvCourseLearningAppraiseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCourseLearningAppraiseEN> arrObjLst = new List<clsvCourseLearningAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = new clsvCourseLearningAppraiseEN();
try
{
objvCourseLearningAppraiseEN.IdCourseLearningCase = objRow[convCourseLearningAppraise.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraiseEN.CourseLearningCaseID = objRow[convCourseLearningAppraise.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningAppraiseEN.CourseLearningCaseName = objRow[convCourseLearningAppraise.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraiseEN.CourseLearningCaseTheme = objRow[convCourseLearningAppraise.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningAppraiseEN.CourseLearningCaseDate = objRow[convCourseLearningAppraise.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningAppraiseEN.CourseLearningCaseTime = objRow[convCourseLearningAppraise.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = objRow[convCourseLearningAppraise.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = objRow[convCourseLearningAppraise.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningAppraiseEN.UserNameWithUserId = objRow[convCourseLearningAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningAppraiseEN.IdXzCollege = objRow[convCourseLearningAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningAppraiseEN.CollegeID = objRow[convCourseLearningAppraise.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningAppraiseEN.CollegeName = objRow[convCourseLearningAppraise.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningAppraiseEN.IdXzMajor = objRow[convCourseLearningAppraise.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningAppraiseEN.MajorID = objRow[convCourseLearningAppraise.MajorID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorID].ToString().Trim(); //专业ID
objvCourseLearningAppraiseEN.MajorName = objRow[convCourseLearningAppraise.MajorName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorName].ToString().Trim(); //专业名称
objvCourseLearningAppraiseEN.CourseId = objRow[convCourseLearningAppraise.CourseId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseId].ToString().Trim(); //课程Id
objvCourseLearningAppraiseEN.CourseCode = objRow[convCourseLearningAppraise.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningAppraiseEN.CourseName = objRow[convCourseLearningAppraise.CourseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseName].ToString().Trim(); //课程名称
objvCourseLearningAppraiseEN.CollegeNameA = objRow[convCourseLearningAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraiseEN.FuncModuleId = objRow[convCourseLearningAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraiseEN.FuncModuleName = objRow[convCourseLearningAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraiseEN.IdMicroteachCase = objRow[convCourseLearningAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraiseEN.IdAppraiseType = objRow[convCourseLearningAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraiseEN.AppraiseTypeName = objRow[convCourseLearningAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraiseEN.AppraiseTheme = objRow[convCourseLearningAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvCourseLearningAppraiseEN.AppraiseContent = objRow[convCourseLearningAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraiseEN.AppraiseDate = objRow[convCourseLearningAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraiseEN.AppraiseTime = objRow[convCourseLearningAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvCourseLearningAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsElite].ToString().Trim()); //精华标志
objvCourseLearningAppraiseEN.UserId = objRow[convCourseLearningAppraise.UserId].ToString().Trim(); //用户ID
objvCourseLearningAppraiseEN.ExcellentOne = objRow[convCourseLearningAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentOne].ToString().Trim(); //优点1
objvCourseLearningAppraiseEN.ExcellentTwo = objRow[convCourseLearningAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvCourseLearningAppraiseEN.SuggestOne = objRow[convCourseLearningAppraise.SuggestOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestOne].ToString().Trim(); //建议1
objvCourseLearningAppraiseEN.SuggestTwo = objRow[convCourseLearningAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestTwo].ToString().Trim(); //建议2
objvCourseLearningAppraiseEN.MicroteachAppriseScore = objRow[convCourseLearningAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvCourseLearningAppraiseEN.VideoStopTime = objRow[convCourseLearningAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvCourseLearningAppraiseEN.BrowseCount = objRow[convCourseLearningAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningAppraiseEN.BrowseCount4Case = objRow[convCourseLearningAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningAppraiseEN.UserName = objRow[convCourseLearningAppraise.UserName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningAppraiseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCourseLearningAppraiseEN> arrObjLst = new List<clsvCourseLearningAppraiseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = new clsvCourseLearningAppraiseEN();
try
{
objvCourseLearningAppraiseEN.IdCourseLearningCase = objRow[convCourseLearningAppraise.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraiseEN.CourseLearningCaseID = objRow[convCourseLearningAppraise.CourseLearningCaseID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningAppraiseEN.CourseLearningCaseName = objRow[convCourseLearningAppraise.CourseLearningCaseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraiseEN.CourseLearningCaseTheme = objRow[convCourseLearningAppraise.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningAppraiseEN.CourseLearningCaseDate = objRow[convCourseLearningAppraise.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningAppraiseEN.CourseLearningCaseTime = objRow[convCourseLearningAppraise.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = objRow[convCourseLearningAppraise.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = objRow[convCourseLearningAppraise.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningAppraiseEN.UserNameWithUserId = objRow[convCourseLearningAppraise.UserNameWithUserId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvCourseLearningAppraiseEN.IdXzCollege = objRow[convCourseLearningAppraise.IdXzCollege] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningAppraiseEN.CollegeID = objRow[convCourseLearningAppraise.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningAppraiseEN.CollegeName = objRow[convCourseLearningAppraise.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningAppraiseEN.IdXzMajor = objRow[convCourseLearningAppraise.IdXzMajor] == DBNull.Value ? null : objRow[convCourseLearningAppraise.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningAppraiseEN.MajorID = objRow[convCourseLearningAppraise.MajorID] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorID].ToString().Trim(); //专业ID
objvCourseLearningAppraiseEN.MajorName = objRow[convCourseLearningAppraise.MajorName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.MajorName].ToString().Trim(); //专业名称
objvCourseLearningAppraiseEN.CourseId = objRow[convCourseLearningAppraise.CourseId] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseId].ToString().Trim(); //课程Id
objvCourseLearningAppraiseEN.CourseCode = objRow[convCourseLearningAppraise.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningAppraiseEN.CourseName = objRow[convCourseLearningAppraise.CourseName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CourseName].ToString().Trim(); //课程名称
objvCourseLearningAppraiseEN.CollegeNameA = objRow[convCourseLearningAppraise.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningAppraise.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraiseEN.FuncModuleId = objRow[convCourseLearningAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraiseEN.FuncModuleName = objRow[convCourseLearningAppraise.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraiseEN.IdMicroteachCase = objRow[convCourseLearningAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraiseEN.IdAppraiseType = objRow[convCourseLearningAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraiseEN.AppraiseTypeName = objRow[convCourseLearningAppraise.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraiseEN.AppraiseTheme = objRow[convCourseLearningAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objvCourseLearningAppraiseEN.AppraiseContent = objRow[convCourseLearningAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraiseEN.AppraiseDate = objRow[convCourseLearningAppraise.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraiseEN.AppraiseTime = objRow[convCourseLearningAppraise.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsVisual].ToString().Trim()); //隐藏标志
objvCourseLearningAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningAppraise.IsElite].ToString().Trim()); //精华标志
objvCourseLearningAppraiseEN.UserId = objRow[convCourseLearningAppraise.UserId].ToString().Trim(); //用户ID
objvCourseLearningAppraiseEN.ExcellentOne = objRow[convCourseLearningAppraise.ExcellentOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentOne].ToString().Trim(); //优点1
objvCourseLearningAppraiseEN.ExcellentTwo = objRow[convCourseLearningAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.ExcellentTwo].ToString().Trim(); //优点2
objvCourseLearningAppraiseEN.SuggestOne = objRow[convCourseLearningAppraise.SuggestOne] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestOne].ToString().Trim(); //建议1
objvCourseLearningAppraiseEN.SuggestTwo = objRow[convCourseLearningAppraise.SuggestTwo] == DBNull.Value ? null : objRow[convCourseLearningAppraise.SuggestTwo].ToString().Trim(); //建议2
objvCourseLearningAppraiseEN.MicroteachAppriseScore = objRow[convCourseLearningAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objvCourseLearningAppraiseEN.VideoStopTime = objRow[convCourseLearningAppraise.VideoStopTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objvCourseLearningAppraiseEN.BrowseCount = objRow[convCourseLearningAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningAppraiseEN.BrowseCount4Case = objRow[convCourseLearningAppraise.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningAppraise.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningAppraiseEN.UserName = objRow[convCourseLearningAppraise.UserName] == DBNull.Value ? null : objRow[convCourseLearningAppraise.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraiseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCourseLearningAppraise(ref clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN)
{
bool bolResult = vCourseLearningAppraiseDA.GetvCourseLearningAppraise(ref objvCourseLearningAppraiseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningAppraiseEN GetObjByIdMicroteachAppraise(long lngIdMicroteachAppraise)
{
clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = vCourseLearningAppraiseDA.GetObjByIdMicroteachAppraise(lngIdMicroteachAppraise);
return objvCourseLearningAppraiseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCourseLearningAppraiseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = vCourseLearningAppraiseDA.GetFirstObj(strWhereCond);
 return objvCourseLearningAppraiseEN;
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
public static clsvCourseLearningAppraiseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = vCourseLearningAppraiseDA.GetObjByDataRow(objRow);
 return objvCourseLearningAppraiseEN;
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
public static clsvCourseLearningAppraiseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN = vCourseLearningAppraiseDA.GetObjByDataRow(objRow);
 return objvCourseLearningAppraiseEN;
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
 /// <param name = "lngIdMicroteachAppraise">所给的关键字</param>
 /// <param name = "lstvCourseLearningAppraiseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningAppraiseEN GetObjByIdMicroteachAppraiseFromList(long lngIdMicroteachAppraise, List<clsvCourseLearningAppraiseEN> lstvCourseLearningAppraiseObjLst)
{
foreach (clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN in lstvCourseLearningAppraiseObjLst)
{
if (objvCourseLearningAppraiseEN.IdMicroteachAppraise == lngIdMicroteachAppraise)
{
return objvCourseLearningAppraiseEN;
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
 long lngIdMicroteachAppraise;
 try
 {
 lngIdMicroteachAppraise = new clsvCourseLearningAppraiseDA().GetFirstID(strWhereCond);
 return lngIdMicroteachAppraise;
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
 arrList = vCourseLearningAppraiseDA.GetID(strWhereCond);
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
bool bolIsExist = vCourseLearningAppraiseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdMicroteachAppraise)
{
//检测记录是否存在
bool bolIsExist = vCourseLearningAppraiseDA.IsExist(lngIdMicroteachAppraise);
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
 bolIsExist = clsvCourseLearningAppraiseDA.IsExistTable();
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
 bolIsExist = vCourseLearningAppraiseDA.IsExistTable(strTabName);
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
 /// <param name = "objvCourseLearningAppraiseENS">源对象</param>
 /// <param name = "objvCourseLearningAppraiseENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningAppraiseEN objvCourseLearningAppraiseENS, clsvCourseLearningAppraiseEN objvCourseLearningAppraiseENT)
{
try
{
objvCourseLearningAppraiseENT.IdCourseLearningCase = objvCourseLearningAppraiseENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningAppraiseENT.CourseLearningCaseID = objvCourseLearningAppraiseENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningAppraiseENT.CourseLearningCaseName = objvCourseLearningAppraiseENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningAppraiseENT.CourseLearningCaseTheme = objvCourseLearningAppraiseENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningAppraiseENT.CourseLearningCaseDate = objvCourseLearningAppraiseENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningAppraiseENT.CourseLearningCaseTime = objvCourseLearningAppraiseENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningAppraiseENT.CourseLearningCaseDateIn = objvCourseLearningAppraiseENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningAppraiseENT.CourseLearningCaseTimeIn = objvCourseLearningAppraiseENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningAppraiseENT.CourseLearningCaseTypeName = objvCourseLearningAppraiseENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningAppraiseENT.UserNameWithUserId = objvCourseLearningAppraiseENS.UserNameWithUserId; //UserNameWithUserId
objvCourseLearningAppraiseENT.IdXzCollege = objvCourseLearningAppraiseENS.IdXzCollege; //学院流水号
objvCourseLearningAppraiseENT.CollegeID = objvCourseLearningAppraiseENS.CollegeID; //学院ID
objvCourseLearningAppraiseENT.CollegeName = objvCourseLearningAppraiseENS.CollegeName; //学院名称
objvCourseLearningAppraiseENT.IdXzMajor = objvCourseLearningAppraiseENS.IdXzMajor; //专业流水号
objvCourseLearningAppraiseENT.MajorID = objvCourseLearningAppraiseENS.MajorID; //专业ID
objvCourseLearningAppraiseENT.MajorName = objvCourseLearningAppraiseENS.MajorName; //专业名称
objvCourseLearningAppraiseENT.CourseId = objvCourseLearningAppraiseENS.CourseId; //课程Id
objvCourseLearningAppraiseENT.CourseCode = objvCourseLearningAppraiseENS.CourseCode; //课程代码
objvCourseLearningAppraiseENT.CourseName = objvCourseLearningAppraiseENS.CourseName; //课程名称
objvCourseLearningAppraiseENT.CollegeNameA = objvCourseLearningAppraiseENS.CollegeNameA; //学院名称简写
objvCourseLearningAppraiseENT.IdMicroteachAppraise = objvCourseLearningAppraiseENS.IdMicroteachAppraise; //评议流水号
objvCourseLearningAppraiseENT.FuncModuleId = objvCourseLearningAppraiseENS.FuncModuleId; //功能模块Id
objvCourseLearningAppraiseENT.FuncModuleName = objvCourseLearningAppraiseENS.FuncModuleName; //功能模块名称
objvCourseLearningAppraiseENT.IdMicroteachCase = objvCourseLearningAppraiseENS.IdMicroteachCase; //微格教学案例流水号
objvCourseLearningAppraiseENT.IdAppraiseType = objvCourseLearningAppraiseENS.IdAppraiseType; //评议类型流水号
objvCourseLearningAppraiseENT.AppraiseTypeName = objvCourseLearningAppraiseENS.AppraiseTypeName; //评议类型名称
objvCourseLearningAppraiseENT.AppraiseTheme = objvCourseLearningAppraiseENS.AppraiseTheme; //评议主题
objvCourseLearningAppraiseENT.AppraiseContent = objvCourseLearningAppraiseENS.AppraiseContent; //评议内容
objvCourseLearningAppraiseENT.AppraiseDate = objvCourseLearningAppraiseENS.AppraiseDate; //评议日期
objvCourseLearningAppraiseENT.AppraiseTime = objvCourseLearningAppraiseENS.AppraiseTime; //评议时间
objvCourseLearningAppraiseENT.IsVisual = objvCourseLearningAppraiseENS.IsVisual; //隐藏标志
objvCourseLearningAppraiseENT.IsElite = objvCourseLearningAppraiseENS.IsElite; //精华标志
objvCourseLearningAppraiseENT.UserId = objvCourseLearningAppraiseENS.UserId; //用户ID
objvCourseLearningAppraiseENT.ExcellentOne = objvCourseLearningAppraiseENS.ExcellentOne; //优点1
objvCourseLearningAppraiseENT.ExcellentTwo = objvCourseLearningAppraiseENS.ExcellentTwo; //优点2
objvCourseLearningAppraiseENT.SuggestOne = objvCourseLearningAppraiseENS.SuggestOne; //建议1
objvCourseLearningAppraiseENT.SuggestTwo = objvCourseLearningAppraiseENS.SuggestTwo; //建议2
objvCourseLearningAppraiseENT.MicroteachAppriseScore = objvCourseLearningAppraiseENS.MicroteachAppriseScore; //打分
objvCourseLearningAppraiseENT.VideoStopTime = objvCourseLearningAppraiseENS.VideoStopTime; //公开课案例视频暂停时间
objvCourseLearningAppraiseENT.BrowseCount = objvCourseLearningAppraiseENS.BrowseCount; //浏览次数
objvCourseLearningAppraiseENT.BrowseCount4Case = objvCourseLearningAppraiseENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningAppraiseENT.UserName = objvCourseLearningAppraiseENS.UserName; //用户名
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
 /// <param name = "objvCourseLearningAppraiseEN">源简化对象</param>
 public static void SetUpdFlag(clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN)
{
try
{
objvCourseLearningAppraiseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCourseLearningAppraiseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCourseLearningAppraise.IdCourseLearningCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.IdCourseLearningCase = objvCourseLearningAppraiseEN.IdCourseLearningCase == "[null]" ? null :  objvCourseLearningAppraiseEN.IdCourseLearningCase; //课程学习案例流水号
}
if (arrFldSet.Contains(convCourseLearningAppraise.CourseLearningCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.CourseLearningCaseID = objvCourseLearningAppraiseEN.CourseLearningCaseID == "[null]" ? null :  objvCourseLearningAppraiseEN.CourseLearningCaseID; //课程学习案例ID
}
if (arrFldSet.Contains(convCourseLearningAppraise.CourseLearningCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.CourseLearningCaseName = objvCourseLearningAppraiseEN.CourseLearningCaseName == "[null]" ? null :  objvCourseLearningAppraiseEN.CourseLearningCaseName; //课程学习案例名称
}
if (arrFldSet.Contains(convCourseLearningAppraise.CourseLearningCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.CourseLearningCaseTheme = objvCourseLearningAppraiseEN.CourseLearningCaseTheme == "[null]" ? null :  objvCourseLearningAppraiseEN.CourseLearningCaseTheme; //课程学习案例主题词
}
if (arrFldSet.Contains(convCourseLearningAppraise.CourseLearningCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.CourseLearningCaseDate = objvCourseLearningAppraiseEN.CourseLearningCaseDate == "[null]" ? null :  objvCourseLearningAppraiseEN.CourseLearningCaseDate; //课程学习日期
}
if (arrFldSet.Contains(convCourseLearningAppraise.CourseLearningCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.CourseLearningCaseTime = objvCourseLearningAppraiseEN.CourseLearningCaseTime == "[null]" ? null :  objvCourseLearningAppraiseEN.CourseLearningCaseTime; //课程学习时间
}
if (arrFldSet.Contains(convCourseLearningAppraise.CourseLearningCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = objvCourseLearningAppraiseEN.CourseLearningCaseDateIn == "[null]" ? null :  objvCourseLearningAppraiseEN.CourseLearningCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convCourseLearningAppraise.CourseLearningCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn == "[null]" ? null :  objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convCourseLearningAppraise.CourseLearningCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = objvCourseLearningAppraiseEN.CourseLearningCaseTypeName == "[null]" ? null :  objvCourseLearningAppraiseEN.CourseLearningCaseTypeName; //课程学习案例类型名称
}
if (arrFldSet.Contains(convCourseLearningAppraise.UserNameWithUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.UserNameWithUserId = objvCourseLearningAppraiseEN.UserNameWithUserId == "[null]" ? null :  objvCourseLearningAppraiseEN.UserNameWithUserId; //UserNameWithUserId
}
if (arrFldSet.Contains(convCourseLearningAppraise.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.IdXzCollege = objvCourseLearningAppraiseEN.IdXzCollege == "[null]" ? null :  objvCourseLearningAppraiseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convCourseLearningAppraise.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.CollegeID = objvCourseLearningAppraiseEN.CollegeID == "[null]" ? null :  objvCourseLearningAppraiseEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convCourseLearningAppraise.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.CollegeName = objvCourseLearningAppraiseEN.CollegeName == "[null]" ? null :  objvCourseLearningAppraiseEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convCourseLearningAppraise.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.IdXzMajor = objvCourseLearningAppraiseEN.IdXzMajor == "[null]" ? null :  objvCourseLearningAppraiseEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convCourseLearningAppraise.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.MajorID = objvCourseLearningAppraiseEN.MajorID == "[null]" ? null :  objvCourseLearningAppraiseEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convCourseLearningAppraise.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.MajorName = objvCourseLearningAppraiseEN.MajorName == "[null]" ? null :  objvCourseLearningAppraiseEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convCourseLearningAppraise.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.CourseId = objvCourseLearningAppraiseEN.CourseId == "[null]" ? null :  objvCourseLearningAppraiseEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convCourseLearningAppraise.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.CourseCode = objvCourseLearningAppraiseEN.CourseCode == "[null]" ? null :  objvCourseLearningAppraiseEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convCourseLearningAppraise.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.CourseName = objvCourseLearningAppraiseEN.CourseName == "[null]" ? null :  objvCourseLearningAppraiseEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convCourseLearningAppraise.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.CollegeNameA = objvCourseLearningAppraiseEN.CollegeNameA == "[null]" ? null :  objvCourseLearningAppraiseEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convCourseLearningAppraise.IdMicroteachAppraise, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.IdMicroteachAppraise = objvCourseLearningAppraiseEN.IdMicroteachAppraise; //评议流水号
}
if (arrFldSet.Contains(convCourseLearningAppraise.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.FuncModuleId = objvCourseLearningAppraiseEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convCourseLearningAppraise.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.FuncModuleName = objvCourseLearningAppraiseEN.FuncModuleName == "[null]" ? null :  objvCourseLearningAppraiseEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convCourseLearningAppraise.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.IdMicroteachCase = objvCourseLearningAppraiseEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convCourseLearningAppraise.IdAppraiseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.IdAppraiseType = objvCourseLearningAppraiseEN.IdAppraiseType; //评议类型流水号
}
if (arrFldSet.Contains(convCourseLearningAppraise.AppraiseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.AppraiseTypeName = objvCourseLearningAppraiseEN.AppraiseTypeName == "[null]" ? null :  objvCourseLearningAppraiseEN.AppraiseTypeName; //评议类型名称
}
if (arrFldSet.Contains(convCourseLearningAppraise.AppraiseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.AppraiseTheme = objvCourseLearningAppraiseEN.AppraiseTheme == "[null]" ? null :  objvCourseLearningAppraiseEN.AppraiseTheme; //评议主题
}
if (arrFldSet.Contains(convCourseLearningAppraise.AppraiseContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.AppraiseContent = objvCourseLearningAppraiseEN.AppraiseContent == "[null]" ? null :  objvCourseLearningAppraiseEN.AppraiseContent; //评议内容
}
if (arrFldSet.Contains(convCourseLearningAppraise.AppraiseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.AppraiseDate = objvCourseLearningAppraiseEN.AppraiseDate == "[null]" ? null :  objvCourseLearningAppraiseEN.AppraiseDate; //评议日期
}
if (arrFldSet.Contains(convCourseLearningAppraise.AppraiseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.AppraiseTime = objvCourseLearningAppraiseEN.AppraiseTime == "[null]" ? null :  objvCourseLearningAppraiseEN.AppraiseTime; //评议时间
}
if (arrFldSet.Contains(convCourseLearningAppraise.IsVisual, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.IsVisual = objvCourseLearningAppraiseEN.IsVisual; //隐藏标志
}
if (arrFldSet.Contains(convCourseLearningAppraise.IsElite, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.IsElite = objvCourseLearningAppraiseEN.IsElite; //精华标志
}
if (arrFldSet.Contains(convCourseLearningAppraise.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.UserId = objvCourseLearningAppraiseEN.UserId; //用户ID
}
if (arrFldSet.Contains(convCourseLearningAppraise.ExcellentOne, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.ExcellentOne = objvCourseLearningAppraiseEN.ExcellentOne == "[null]" ? null :  objvCourseLearningAppraiseEN.ExcellentOne; //优点1
}
if (arrFldSet.Contains(convCourseLearningAppraise.ExcellentTwo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.ExcellentTwo = objvCourseLearningAppraiseEN.ExcellentTwo == "[null]" ? null :  objvCourseLearningAppraiseEN.ExcellentTwo; //优点2
}
if (arrFldSet.Contains(convCourseLearningAppraise.SuggestOne, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.SuggestOne = objvCourseLearningAppraiseEN.SuggestOne == "[null]" ? null :  objvCourseLearningAppraiseEN.SuggestOne; //建议1
}
if (arrFldSet.Contains(convCourseLearningAppraise.SuggestTwo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.SuggestTwo = objvCourseLearningAppraiseEN.SuggestTwo == "[null]" ? null :  objvCourseLearningAppraiseEN.SuggestTwo; //建议2
}
if (arrFldSet.Contains(convCourseLearningAppraise.MicroteachAppriseScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.MicroteachAppriseScore = objvCourseLearningAppraiseEN.MicroteachAppriseScore; //打分
}
if (arrFldSet.Contains(convCourseLearningAppraise.VideoStopTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.VideoStopTime = objvCourseLearningAppraiseEN.VideoStopTime == "[null]" ? null :  objvCourseLearningAppraiseEN.VideoStopTime; //公开课案例视频暂停时间
}
if (arrFldSet.Contains(convCourseLearningAppraise.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.BrowseCount = objvCourseLearningAppraiseEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convCourseLearningAppraise.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.BrowseCount4Case = objvCourseLearningAppraiseEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convCourseLearningAppraise.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraiseEN.UserName = objvCourseLearningAppraiseEN.UserName == "[null]" ? null :  objvCourseLearningAppraiseEN.UserName; //用户名
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
 /// <param name = "objvCourseLearningAppraiseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN)
{
try
{
if (objvCourseLearningAppraiseEN.IdCourseLearningCase == "[null]") objvCourseLearningAppraiseEN.IdCourseLearningCase = null; //课程学习案例流水号
if (objvCourseLearningAppraiseEN.CourseLearningCaseID == "[null]") objvCourseLearningAppraiseEN.CourseLearningCaseID = null; //课程学习案例ID
if (objvCourseLearningAppraiseEN.CourseLearningCaseName == "[null]") objvCourseLearningAppraiseEN.CourseLearningCaseName = null; //课程学习案例名称
if (objvCourseLearningAppraiseEN.CourseLearningCaseTheme == "[null]") objvCourseLearningAppraiseEN.CourseLearningCaseTheme = null; //课程学习案例主题词
if (objvCourseLearningAppraiseEN.CourseLearningCaseDate == "[null]") objvCourseLearningAppraiseEN.CourseLearningCaseDate = null; //课程学习日期
if (objvCourseLearningAppraiseEN.CourseLearningCaseTime == "[null]") objvCourseLearningAppraiseEN.CourseLearningCaseTime = null; //课程学习时间
if (objvCourseLearningAppraiseEN.CourseLearningCaseDateIn == "[null]") objvCourseLearningAppraiseEN.CourseLearningCaseDateIn = null; //案例入库日期
if (objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn == "[null]") objvCourseLearningAppraiseEN.CourseLearningCaseTimeIn = null; //案例入库时间
if (objvCourseLearningAppraiseEN.CourseLearningCaseTypeName == "[null]") objvCourseLearningAppraiseEN.CourseLearningCaseTypeName = null; //课程学习案例类型名称
if (objvCourseLearningAppraiseEN.UserNameWithUserId == "[null]") objvCourseLearningAppraiseEN.UserNameWithUserId = null; //UserNameWithUserId
if (objvCourseLearningAppraiseEN.IdXzCollege == "[null]") objvCourseLearningAppraiseEN.IdXzCollege = null; //学院流水号
if (objvCourseLearningAppraiseEN.CollegeID == "[null]") objvCourseLearningAppraiseEN.CollegeID = null; //学院ID
if (objvCourseLearningAppraiseEN.CollegeName == "[null]") objvCourseLearningAppraiseEN.CollegeName = null; //学院名称
if (objvCourseLearningAppraiseEN.IdXzMajor == "[null]") objvCourseLearningAppraiseEN.IdXzMajor = null; //专业流水号
if (objvCourseLearningAppraiseEN.MajorID == "[null]") objvCourseLearningAppraiseEN.MajorID = null; //专业ID
if (objvCourseLearningAppraiseEN.MajorName == "[null]") objvCourseLearningAppraiseEN.MajorName = null; //专业名称
if (objvCourseLearningAppraiseEN.CourseId == "[null]") objvCourseLearningAppraiseEN.CourseId = null; //课程Id
if (objvCourseLearningAppraiseEN.CourseCode == "[null]") objvCourseLearningAppraiseEN.CourseCode = null; //课程代码
if (objvCourseLearningAppraiseEN.CourseName == "[null]") objvCourseLearningAppraiseEN.CourseName = null; //课程名称
if (objvCourseLearningAppraiseEN.CollegeNameA == "[null]") objvCourseLearningAppraiseEN.CollegeNameA = null; //学院名称简写
if (objvCourseLearningAppraiseEN.FuncModuleName == "[null]") objvCourseLearningAppraiseEN.FuncModuleName = null; //功能模块名称
if (objvCourseLearningAppraiseEN.AppraiseTypeName == "[null]") objvCourseLearningAppraiseEN.AppraiseTypeName = null; //评议类型名称
if (objvCourseLearningAppraiseEN.AppraiseTheme == "[null]") objvCourseLearningAppraiseEN.AppraiseTheme = null; //评议主题
if (objvCourseLearningAppraiseEN.AppraiseContent == "[null]") objvCourseLearningAppraiseEN.AppraiseContent = null; //评议内容
if (objvCourseLearningAppraiseEN.AppraiseDate == "[null]") objvCourseLearningAppraiseEN.AppraiseDate = null; //评议日期
if (objvCourseLearningAppraiseEN.AppraiseTime == "[null]") objvCourseLearningAppraiseEN.AppraiseTime = null; //评议时间
if (objvCourseLearningAppraiseEN.ExcellentOne == "[null]") objvCourseLearningAppraiseEN.ExcellentOne = null; //优点1
if (objvCourseLearningAppraiseEN.ExcellentTwo == "[null]") objvCourseLearningAppraiseEN.ExcellentTwo = null; //优点2
if (objvCourseLearningAppraiseEN.SuggestOne == "[null]") objvCourseLearningAppraiseEN.SuggestOne = null; //建议1
if (objvCourseLearningAppraiseEN.SuggestTwo == "[null]") objvCourseLearningAppraiseEN.SuggestTwo = null; //建议2
if (objvCourseLearningAppraiseEN.VideoStopTime == "[null]") objvCourseLearningAppraiseEN.VideoStopTime = null; //公开课案例视频暂停时间
if (objvCourseLearningAppraiseEN.UserName == "[null]") objvCourseLearningAppraiseEN.UserName = null; //用户名
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
public static void CheckProperty4Condition(clsvCourseLearningAppraiseEN objvCourseLearningAppraiseEN)
{
 vCourseLearningAppraiseDA.CheckProperty4Condition(objvCourseLearningAppraiseEN);
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
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachAppraiseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachAppraiseBL没有刷新缓存机制(clsMicroteachAppraiseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeBL没有刷新缓存机制(clsAppraiseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateBL没有刷新缓存机制(clsUserStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityBL没有刷新缓存机制(clsUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseBL没有刷新缓存机制(clsCourseLearningCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseTypeBL没有刷新缓存机制(clsCourseLearningCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeBL没有刷新缓存机制(clsRecommendedDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionBL没有刷新缓存机制(clsSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelBL没有刷新缓存机制(clsCaseLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseTypeBL没有刷新缓存机制(clsCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzDegreeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeBL没有刷新缓存机制(clsXzDegreeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeBL没有刷新缓存机制(clsXzMajorTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeBL没有刷新缓存机制(clsXzMajorShoolTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeBL没有刷新缓存机制(clsSkillTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillBL没有刷新缓存机制(clsTeachSkillBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachAppraise");
//if (arrvCourseLearningAppraiseObjLstCache == null)
//{
//arrvCourseLearningAppraiseObjLstCache = vCourseLearningAppraiseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningAppraiseEN GetObjByIdMicroteachAppraiseCache(long lngIdMicroteachAppraise)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCourseLearningAppraiseEN._CurrTabName);
List<clsvCourseLearningAppraiseEN> arrvCourseLearningAppraiseObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningAppraiseEN> arrvCourseLearningAppraiseObjLst_Sel =
arrvCourseLearningAppraiseObjLstCache
.Where(x=> x.IdMicroteachAppraise == lngIdMicroteachAppraise 
);
if (arrvCourseLearningAppraiseObjLst_Sel.Count() == 0)
{
   clsvCourseLearningAppraiseEN obj = clsvCourseLearningAppraiseBL.GetObjByIdMicroteachAppraise(lngIdMicroteachAppraise);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCourseLearningAppraiseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningAppraiseEN> GetAllvCourseLearningAppraiseObjLstCache()
{
//获取缓存中的对象列表
List<clsvCourseLearningAppraiseEN> arrvCourseLearningAppraiseObjLstCache = GetObjLstCache(); 
return arrvCourseLearningAppraiseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningAppraiseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningAppraiseEN._CurrTabName);
List<clsvCourseLearningAppraiseEN> arrvCourseLearningAppraiseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningAppraiseObjLstCache;
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
string strKey = string.Format("{0}", clsvCourseLearningAppraiseEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdMicroteachAppraise)
{
if (strInFldName != convCourseLearningAppraise.IdMicroteachAppraise)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCourseLearningAppraise.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCourseLearningAppraise.AttributeName));
throw new Exception(strMsg);
}
var objvCourseLearningAppraise = clsvCourseLearningAppraiseBL.GetObjByIdMicroteachAppraiseCache(lngIdMicroteachAppraise);
if (objvCourseLearningAppraise == null) return "";
return objvCourseLearningAppraise[strOutFldName].ToString();
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
int intRecCount = clsvCourseLearningAppraiseDA.GetRecCount(strTabName);
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
int intRecCount = clsvCourseLearningAppraiseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCourseLearningAppraiseDA.GetRecCount();
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
int intRecCount = clsvCourseLearningAppraiseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCourseLearningAppraiseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCourseLearningAppraiseEN objvCourseLearningAppraiseCond)
{
List<clsvCourseLearningAppraiseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningAppraiseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningAppraise.AttributeName)
{
if (objvCourseLearningAppraiseCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningAppraiseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningAppraiseCond[strFldName].ToString());
}
else
{
if (objvCourseLearningAppraiseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningAppraiseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningAppraiseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningAppraiseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningAppraiseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningAppraiseCond[strFldName]));
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
 List<string> arrList = clsvCourseLearningAppraiseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningAppraiseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningAppraiseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}