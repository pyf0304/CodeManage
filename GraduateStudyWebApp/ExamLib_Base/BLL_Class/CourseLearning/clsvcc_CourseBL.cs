
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseBL
 表名:vcc_Course(01120058)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:26
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
public static class  clsvcc_CourseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseEN GetObj(this K_CourseId_vcc_Course myKey)
{
clsvcc_CourseEN objvcc_CourseEN = clsvcc_CourseBL.vcc_CourseDA.GetObjByCourseId(myKey.Value);
return objvcc_CourseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetCourseId(this clsvcc_CourseEN objvcc_CourseEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_Course.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_Course.CourseId);
}
objvcc_CourseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.CourseId) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.CourseId, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.CourseId] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetLikeCount(this clsvcc_CourseEN objvcc_CourseEN, int? intLikeCount, string strComparisonOp="")
	{
objvcc_CourseEN.LikeCount = intLikeCount; //LikeCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.LikeCount) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.LikeCount, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.LikeCount] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetCourseCode(this clsvcc_CourseEN objvcc_CourseEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convcc_Course.CourseCode);
}
objvcc_CourseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.CourseCode) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.CourseCode, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.CourseCode] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetCourseDescription(this clsvcc_CourseEN objvcc_CourseEN, string strCourseDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, convcc_Course.CourseDescription);
}
objvcc_CourseEN.CourseDescription = strCourseDescription; //课程描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.CourseDescription) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.CourseDescription, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.CourseDescription] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetCourseName(this clsvcc_CourseEN objvcc_CourseEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_Course.CourseName);
}
objvcc_CourseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.CourseName) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.CourseName, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.CourseName] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetCourseTypeId(this clsvcc_CourseEN objvcc_CourseEN, string strCourseTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseTypeId, convcc_Course.CourseTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseTypeId, 4, convcc_Course.CourseTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseTypeId, 4, convcc_Course.CourseTypeId);
}
objvcc_CourseEN.CourseTypeId = strCourseTypeId; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.CourseTypeId) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.CourseTypeId, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.CourseTypeId] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetCourseTypeName(this clsvcc_CourseEN objvcc_CourseEN, string strCourseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseTypeName, convcc_Course.CourseTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, convcc_Course.CourseTypeName);
}
objvcc_CourseEN.CourseTypeName = strCourseTypeName; //课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.CourseTypeName) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.CourseTypeName, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.CourseTypeName] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetCreateDate(this clsvcc_CourseEN objvcc_CourseEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_Course.CreateDate);
}
objvcc_CourseEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.CreateDate) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.CreateDate, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.CreateDate] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetExcellentTypeId(this clsvcc_CourseEN objvcc_CourseEN, string strExcellentTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExcellentTypeId, 4, convcc_Course.ExcellentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExcellentTypeId, 4, convcc_Course.ExcellentTypeId);
}
objvcc_CourseEN.ExcellentTypeId = strExcellentTypeId; //精品课程类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.ExcellentTypeId) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.ExcellentTypeId, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.ExcellentTypeId] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetExcellentTypeName(this clsvcc_CourseEN objvcc_CourseEN, string strExcellentTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExcellentTypeName, 30, convcc_Course.ExcellentTypeName);
}
objvcc_CourseEN.ExcellentTypeName = strExcellentTypeName; //精品课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.ExcellentTypeName) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.ExcellentTypeName, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.ExcellentTypeName] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetExcellentYear(this clsvcc_CourseEN objvcc_CourseEN, int? intExcellentYear, string strComparisonOp="")
	{
objvcc_CourseEN.ExcellentYear = intExcellentYear; //课程年份
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.ExcellentYear) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.ExcellentYear, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.ExcellentYear] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetIsBuildingCourse(this clsvcc_CourseEN objvcc_CourseEN, bool bolIsBuildingCourse, string strComparisonOp="")
	{
objvcc_CourseEN.IsBuildingCourse = bolIsBuildingCourse; //是否已建设课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.IsBuildingCourse) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.IsBuildingCourse, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.IsBuildingCourse] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetIsDoubleLanguageCourse(this clsvcc_CourseEN objvcc_CourseEN, bool bolIsDoubleLanguageCourse, string strComparisonOp="")
	{
objvcc_CourseEN.IsDoubleLanguageCourse = bolIsDoubleLanguageCourse; //是否双语课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.IsDoubleLanguageCourse) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.IsDoubleLanguageCourse, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.IsDoubleLanguageCourse] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetIsOpen(this clsvcc_CourseEN objvcc_CourseEN, bool bolIsOpen, string strComparisonOp="")
	{
objvcc_CourseEN.IsOpen = bolIsOpen; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.IsOpen) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.IsOpen, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.IsOpen] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetIsRecommendedCourse(this clsvcc_CourseEN objvcc_CourseEN, bool bolIsRecommendedCourse, string strComparisonOp="")
	{
objvcc_CourseEN.IsRecommendedCourse = bolIsRecommendedCourse; //是否推荐课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.IsRecommendedCourse) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.IsRecommendedCourse, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.IsRecommendedCourse] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetIsSelfPropelledCourse(this clsvcc_CourseEN objvcc_CourseEN, bool bolIsSelfPropelledCourse, string strComparisonOp="")
	{
objvcc_CourseEN.IsSelfPropelledCourse = bolIsSelfPropelledCourse; //是否自荐课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.IsSelfPropelledCourse) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.IsSelfPropelledCourse, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.IsSelfPropelledCourse] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetOperationDate(this clsvcc_CourseEN objvcc_CourseEN, string strOperationDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationDate, 20, convcc_Course.OperationDate);
}
objvcc_CourseEN.OperationDate = strOperationDate; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.OperationDate) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.OperationDate, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.OperationDate] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetOrderNum(this clsvcc_CourseEN objvcc_CourseEN, int? intOrderNum, string strComparisonOp="")
	{
objvcc_CourseEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.OrderNum) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.OrderNum, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.OrderNum] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetOuterLink(this clsvcc_CourseEN objvcc_CourseEN, string strOuterLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOuterLink, 500, convcc_Course.OuterLink);
}
objvcc_CourseEN.OuterLink = strOuterLink; //外链地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.OuterLink) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.OuterLink, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.OuterLink] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetViewCount(this clsvcc_CourseEN objvcc_CourseEN, int? intViewCount, string strComparisonOp="")
	{
objvcc_CourseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.ViewCount) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.ViewCount, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.ViewCount] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetThemeId(this clsvcc_CourseEN objvcc_CourseEN, string strThemeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThemeId, 4, convcc_Course.ThemeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strThemeId, 4, convcc_Course.ThemeId);
}
objvcc_CourseEN.ThemeId = strThemeId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.ThemeId) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.ThemeId, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.ThemeId] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetThemeName(this clsvcc_CourseEN objvcc_CourseEN, string strThemeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThemeName, 200, convcc_Course.ThemeName);
}
objvcc_CourseEN.ThemeName = strThemeName; //主题名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.ThemeName) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.ThemeName, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.ThemeName] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetExampleImgPath(this clsvcc_CourseEN objvcc_CourseEN, string strExampleImgPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExampleImgPath, 300, convcc_Course.ExampleImgPath);
}
objvcc_CourseEN.ExampleImgPath = strExampleImgPath; //示例图路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.ExampleImgPath) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.ExampleImgPath, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.ExampleImgPath] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetIdXzMajor(this clsvcc_CourseEN objvcc_CourseEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convcc_Course.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convcc_Course.IdXzMajor);
}
objvcc_CourseEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.IdXzMajor) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.IdXzMajor, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.IdXzMajor] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetMajorID(this clsvcc_CourseEN objvcc_CourseEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convcc_Course.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convcc_Course.MajorID);
}
objvcc_CourseEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.MajorID) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.MajorID, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.MajorID] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetMajorName(this clsvcc_CourseEN objvcc_CourseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convcc_Course.MajorName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_Course.MajorName);
}
objvcc_CourseEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.MajorName) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.MajorName, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.MajorName] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetIdXzCollege(this clsvcc_CourseEN objvcc_CourseEN, string strIdXzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzCollege, convcc_Course.IdXzCollege);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convcc_Course.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convcc_Course.IdXzCollege);
}
objvcc_CourseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.IdXzCollege) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.IdXzCollege, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.IdXzCollege] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetCollegeId(this clsvcc_CourseEN objvcc_CourseEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convcc_Course.CollegeId);
}
objvcc_CourseEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.CollegeId) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.CollegeId, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.CollegeId] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetCollegeName(this clsvcc_CourseEN objvcc_CourseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convcc_Course.CollegeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_Course.CollegeName);
}
objvcc_CourseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.CollegeName) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.CollegeName, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.CollegeName] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetCollegeNameA(this clsvcc_CourseEN objvcc_CourseEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_Course.CollegeNameA);
}
objvcc_CourseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.CollegeNameA) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.CollegeNameA, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.CollegeNameA] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseEN SetMemo(this clsvcc_CourseEN objvcc_CourseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_Course.Memo);
}
objvcc_CourseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.Memo) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.Memo, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.Memo] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_CourseENS">源对象</param>
 /// <param name = "objvcc_CourseENT">目标对象</param>
 public static void CopyTo(this clsvcc_CourseEN objvcc_CourseENS, clsvcc_CourseEN objvcc_CourseENT)
{
try
{
objvcc_CourseENT.CourseId = objvcc_CourseENS.CourseId; //课程Id
objvcc_CourseENT.LikeCount = objvcc_CourseENS.LikeCount; //LikeCount
objvcc_CourseENT.CourseCode = objvcc_CourseENS.CourseCode; //课程代码
objvcc_CourseENT.CourseDescription = objvcc_CourseENS.CourseDescription; //课程描述
objvcc_CourseENT.CourseName = objvcc_CourseENS.CourseName; //课程名称
objvcc_CourseENT.CourseTypeId = objvcc_CourseENS.CourseTypeId; //课程类型ID
objvcc_CourseENT.CourseTypeName = objvcc_CourseENS.CourseTypeName; //课程类型名称
objvcc_CourseENT.CreateDate = objvcc_CourseENS.CreateDate; //建立日期
objvcc_CourseENT.ExcellentTypeId = objvcc_CourseENS.ExcellentTypeId; //精品课程类型Id
objvcc_CourseENT.ExcellentTypeName = objvcc_CourseENS.ExcellentTypeName; //精品课程类型名称
objvcc_CourseENT.ExcellentYear = objvcc_CourseENS.ExcellentYear; //课程年份
objvcc_CourseENT.IsBuildingCourse = objvcc_CourseENS.IsBuildingCourse; //是否已建设课程
objvcc_CourseENT.IsDoubleLanguageCourse = objvcc_CourseENS.IsDoubleLanguageCourse; //是否双语课程
objvcc_CourseENT.IsOpen = objvcc_CourseENS.IsOpen; //是否公开
objvcc_CourseENT.IsRecommendedCourse = objvcc_CourseENS.IsRecommendedCourse; //是否推荐课程
objvcc_CourseENT.IsSelfPropelledCourse = objvcc_CourseENS.IsSelfPropelledCourse; //是否自荐课程
objvcc_CourseENT.OperationDate = objvcc_CourseENS.OperationDate; //操作时间
objvcc_CourseENT.OrderNum = objvcc_CourseENS.OrderNum; //序号
objvcc_CourseENT.OuterLink = objvcc_CourseENS.OuterLink; //外链地址
objvcc_CourseENT.ViewCount = objvcc_CourseENS.ViewCount; //浏览量
objvcc_CourseENT.ThemeId = objvcc_CourseENS.ThemeId; //主题Id
objvcc_CourseENT.ThemeName = objvcc_CourseENS.ThemeName; //主题名
objvcc_CourseENT.ExampleImgPath = objvcc_CourseENS.ExampleImgPath; //示例图路径
objvcc_CourseENT.IdXzMajor = objvcc_CourseENS.IdXzMajor; //专业流水号
objvcc_CourseENT.MajorID = objvcc_CourseENS.MajorID; //专业ID
objvcc_CourseENT.MajorName = objvcc_CourseENS.MajorName; //专业名称
objvcc_CourseENT.IdXzCollege = objvcc_CourseENS.IdXzCollege; //学院流水号
objvcc_CourseENT.CollegeId = objvcc_CourseENS.CollegeId; //学院ID
objvcc_CourseENT.CollegeName = objvcc_CourseENS.CollegeName; //学院名称
objvcc_CourseENT.CollegeNameA = objvcc_CourseENS.CollegeNameA; //学院名称简写
objvcc_CourseENT.Memo = objvcc_CourseENS.Memo; //备注
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
 /// <param name = "objvcc_CourseENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseEN:objvcc_CourseENT</returns>
 public static clsvcc_CourseEN CopyTo(this clsvcc_CourseEN objvcc_CourseENS)
{
try
{
 clsvcc_CourseEN objvcc_CourseENT = new clsvcc_CourseEN()
{
CourseId = objvcc_CourseENS.CourseId, //课程Id
LikeCount = objvcc_CourseENS.LikeCount, //LikeCount
CourseCode = objvcc_CourseENS.CourseCode, //课程代码
CourseDescription = objvcc_CourseENS.CourseDescription, //课程描述
CourseName = objvcc_CourseENS.CourseName, //课程名称
CourseTypeId = objvcc_CourseENS.CourseTypeId, //课程类型ID
CourseTypeName = objvcc_CourseENS.CourseTypeName, //课程类型名称
CreateDate = objvcc_CourseENS.CreateDate, //建立日期
ExcellentTypeId = objvcc_CourseENS.ExcellentTypeId, //精品课程类型Id
ExcellentTypeName = objvcc_CourseENS.ExcellentTypeName, //精品课程类型名称
ExcellentYear = objvcc_CourseENS.ExcellentYear, //课程年份
IsBuildingCourse = objvcc_CourseENS.IsBuildingCourse, //是否已建设课程
IsDoubleLanguageCourse = objvcc_CourseENS.IsDoubleLanguageCourse, //是否双语课程
IsOpen = objvcc_CourseENS.IsOpen, //是否公开
IsRecommendedCourse = objvcc_CourseENS.IsRecommendedCourse, //是否推荐课程
IsSelfPropelledCourse = objvcc_CourseENS.IsSelfPropelledCourse, //是否自荐课程
OperationDate = objvcc_CourseENS.OperationDate, //操作时间
OrderNum = objvcc_CourseENS.OrderNum, //序号
OuterLink = objvcc_CourseENS.OuterLink, //外链地址
ViewCount = objvcc_CourseENS.ViewCount, //浏览量
ThemeId = objvcc_CourseENS.ThemeId, //主题Id
ThemeName = objvcc_CourseENS.ThemeName, //主题名
ExampleImgPath = objvcc_CourseENS.ExampleImgPath, //示例图路径
IdXzMajor = objvcc_CourseENS.IdXzMajor, //专业流水号
MajorID = objvcc_CourseENS.MajorID, //专业ID
MajorName = objvcc_CourseENS.MajorName, //专业名称
IdXzCollege = objvcc_CourseENS.IdXzCollege, //学院流水号
CollegeId = objvcc_CourseENS.CollegeId, //学院ID
CollegeName = objvcc_CourseENS.CollegeName, //学院名称
CollegeNameA = objvcc_CourseENS.CollegeNameA, //学院名称简写
Memo = objvcc_CourseENS.Memo, //备注
};
 return objvcc_CourseENT;
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
public static void CheckProperty4Condition(this clsvcc_CourseEN objvcc_CourseEN)
{
 clsvcc_CourseBL.vcc_CourseDA.CheckProperty4Condition(objvcc_CourseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseEN objvcc_CourseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseCond.IsUpdated(convcc_Course.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CourseId, objvcc_CourseCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.LikeCount) == true)
{
string strComparisonOpLikeCount = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Course.LikeCount, objvcc_CourseCond.LikeCount, strComparisonOpLikeCount);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.CourseCode) == true)
{
string strComparisonOpCourseCode = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CourseCode, objvcc_CourseCond.CourseCode, strComparisonOpCourseCode);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.CourseDescription) == true)
{
string strComparisonOpCourseDescription = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CourseDescription, objvcc_CourseCond.CourseDescription, strComparisonOpCourseDescription);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CourseName, objvcc_CourseCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.CourseTypeId) == true)
{
string strComparisonOpCourseTypeId = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.CourseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CourseTypeId, objvcc_CourseCond.CourseTypeId, strComparisonOpCourseTypeId);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.CourseTypeName) == true)
{
string strComparisonOpCourseTypeName = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CourseTypeName, objvcc_CourseCond.CourseTypeName, strComparisonOpCourseTypeName);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.CreateDate) == true)
{
string strComparisonOpCreateDate = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CreateDate, objvcc_CourseCond.CreateDate, strComparisonOpCreateDate);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.ExcellentTypeId) == true)
{
string strComparisonOpExcellentTypeId = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.ExcellentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.ExcellentTypeId, objvcc_CourseCond.ExcellentTypeId, strComparisonOpExcellentTypeId);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.ExcellentTypeName) == true)
{
string strComparisonOpExcellentTypeName = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.ExcellentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.ExcellentTypeName, objvcc_CourseCond.ExcellentTypeName, strComparisonOpExcellentTypeName);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.ExcellentYear) == true)
{
string strComparisonOpExcellentYear = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.ExcellentYear];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Course.ExcellentYear, objvcc_CourseCond.ExcellentYear, strComparisonOpExcellentYear);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.IsBuildingCourse) == true)
{
if (objvcc_CourseCond.IsBuildingCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_Course.IsBuildingCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_Course.IsBuildingCourse);
}
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.IsDoubleLanguageCourse) == true)
{
if (objvcc_CourseCond.IsDoubleLanguageCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_Course.IsDoubleLanguageCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_Course.IsDoubleLanguageCourse);
}
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.IsOpen) == true)
{
if (objvcc_CourseCond.IsOpen == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_Course.IsOpen);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_Course.IsOpen);
}
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.IsRecommendedCourse) == true)
{
if (objvcc_CourseCond.IsRecommendedCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_Course.IsRecommendedCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_Course.IsRecommendedCourse);
}
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.IsSelfPropelledCourse) == true)
{
if (objvcc_CourseCond.IsSelfPropelledCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_Course.IsSelfPropelledCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_Course.IsSelfPropelledCourse);
}
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.OperationDate) == true)
{
string strComparisonOpOperationDate = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.OperationDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.OperationDate, objvcc_CourseCond.OperationDate, strComparisonOpOperationDate);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.OrderNum) == true)
{
string strComparisonOpOrderNum = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Course.OrderNum, objvcc_CourseCond.OrderNum, strComparisonOpOrderNum);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.OuterLink) == true)
{
string strComparisonOpOuterLink = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.OuterLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.OuterLink, objvcc_CourseCond.OuterLink, strComparisonOpOuterLink);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.ViewCount) == true)
{
string strComparisonOpViewCount = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Course.ViewCount, objvcc_CourseCond.ViewCount, strComparisonOpViewCount);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.ThemeId) == true)
{
string strComparisonOpThemeId = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.ThemeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.ThemeId, objvcc_CourseCond.ThemeId, strComparisonOpThemeId);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.ThemeName) == true)
{
string strComparisonOpThemeName = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.ThemeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.ThemeName, objvcc_CourseCond.ThemeName, strComparisonOpThemeName);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.ExampleImgPath) == true)
{
string strComparisonOpExampleImgPath = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.ExampleImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.ExampleImgPath, objvcc_CourseCond.ExampleImgPath, strComparisonOpExampleImgPath);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.IdXzMajor, objvcc_CourseCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.MajorID) == true)
{
string strComparisonOpMajorID = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.MajorID, objvcc_CourseCond.MajorID, strComparisonOpMajorID);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.MajorName) == true)
{
string strComparisonOpMajorName = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.MajorName, objvcc_CourseCond.MajorName, strComparisonOpMajorName);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.IdXzCollege, objvcc_CourseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.CollegeId) == true)
{
string strComparisonOpCollegeId = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CollegeId, objvcc_CourseCond.CollegeId, strComparisonOpCollegeId);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.CollegeName) == true)
{
string strComparisonOpCollegeName = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CollegeName, objvcc_CourseCond.CollegeName, strComparisonOpCollegeName);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CollegeNameA, objvcc_CourseCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvcc_CourseCond.IsUpdated(convcc_Course.Memo) == true)
{
string strComparisonOpMemo = objvcc_CourseCond.dicFldComparisonOp[convcc_Course.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.Memo, objvcc_CourseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_Course
{
public virtual bool UpdRelaTabDate(string strCourseId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程(vcc_Course)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseBL
{
public static RelatedActions_vcc_Course relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_CourseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_CourseDA vcc_CourseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_CourseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_CourseBL()
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
if (string.IsNullOrEmpty(clsvcc_CourseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseEN._ConnectString);
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
public static DataTable GetDataTable_vcc_Course(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_CourseDA.GetDataTable_vcc_Course(strWhereCond);
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
objDT = vcc_CourseDA.GetDataTable(strWhereCond);
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
objDT = vcc_CourseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_CourseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_CourseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_CourseDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_CourseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_CourseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_CourseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCourseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_CourseEN> GetObjLstByCourseIdLst(List<string> arrCourseIdLst)
{
List<clsvcc_CourseEN> arrObjLst = new List<clsvcc_CourseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCourseIdLst, true);
 string strWhereCond = string.Format("CourseId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseEN objvcc_CourseEN = new clsvcc_CourseEN();
try
{
objvcc_CourseEN.CourseId = objRow[convcc_Course.CourseId].ToString().Trim(); //课程Id
objvcc_CourseEN.LikeCount = objRow[convcc_Course.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseEN.CourseCode = objRow[convcc_Course.CourseCode] == DBNull.Value ? null : objRow[convcc_Course.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseEN.CourseDescription = objRow[convcc_Course.CourseDescription] == DBNull.Value ? null : objRow[convcc_Course.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseEN.CourseName = objRow[convcc_Course.CourseName] == DBNull.Value ? null : objRow[convcc_Course.CourseName].ToString().Trim(); //课程名称
objvcc_CourseEN.CourseTypeId = objRow[convcc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseEN.CourseTypeName = objRow[convcc_Course.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseEN.CreateDate = objRow[convcc_Course.CreateDate] == DBNull.Value ? null : objRow[convcc_Course.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseEN.ExcellentTypeId = objRow[convcc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseEN.ExcellentTypeName = objRow[convcc_Course.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseEN.ExcellentYear = objRow[convcc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseEN.OperationDate = objRow[convcc_Course.OperationDate] == DBNull.Value ? null : objRow[convcc_Course.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseEN.OrderNum = objRow[convcc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.OrderNum].ToString().Trim()); //序号
objvcc_CourseEN.OuterLink = objRow[convcc_Course.OuterLink] == DBNull.Value ? null : objRow[convcc_Course.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseEN.ViewCount = objRow[convcc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseEN.ThemeId = objRow[convcc_Course.ThemeId] == DBNull.Value ? null : objRow[convcc_Course.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseEN.ThemeName = objRow[convcc_Course.ThemeName] == DBNull.Value ? null : objRow[convcc_Course.ThemeName].ToString().Trim(); //主题名
objvcc_CourseEN.ExampleImgPath = objRow[convcc_Course.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_Course.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseEN.IdXzMajor = objRow[convcc_Course.IdXzMajor] == DBNull.Value ? null : objRow[convcc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseEN.MajorID = objRow[convcc_Course.MajorID] == DBNull.Value ? null : objRow[convcc_Course.MajorID].ToString().Trim(); //专业ID
objvcc_CourseEN.MajorName = objRow[convcc_Course.MajorName].ToString().Trim(); //专业名称
objvcc_CourseEN.IdXzCollege = objRow[convcc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseEN.CollegeId = objRow[convcc_Course.CollegeId] == DBNull.Value ? null : objRow[convcc_Course.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseEN.CollegeName = objRow[convcc_Course.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseEN.CollegeNameA = objRow[convcc_Course.CollegeNameA] == DBNull.Value ? null : objRow[convcc_Course.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseEN.Memo = objRow[convcc_Course.Memo] == DBNull.Value ? null : objRow[convcc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_CourseEN> GetObjLstByCourseIdLstCache(List<string> arrCourseIdLst)
{
string strKey = string.Format("{0}", clsvcc_CourseEN._CurrTabName);
List<clsvcc_CourseEN> arrvcc_CourseObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseEN> arrvcc_CourseObjLst_Sel =
arrvcc_CourseObjLstCache
.Where(x => arrCourseIdLst.Contains(x.CourseId));
return arrvcc_CourseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseEN> GetObjLst(string strWhereCond)
{
List<clsvcc_CourseEN> arrObjLst = new List<clsvcc_CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseEN objvcc_CourseEN = new clsvcc_CourseEN();
try
{
objvcc_CourseEN.CourseId = objRow[convcc_Course.CourseId].ToString().Trim(); //课程Id
objvcc_CourseEN.LikeCount = objRow[convcc_Course.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseEN.CourseCode = objRow[convcc_Course.CourseCode] == DBNull.Value ? null : objRow[convcc_Course.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseEN.CourseDescription = objRow[convcc_Course.CourseDescription] == DBNull.Value ? null : objRow[convcc_Course.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseEN.CourseName = objRow[convcc_Course.CourseName] == DBNull.Value ? null : objRow[convcc_Course.CourseName].ToString().Trim(); //课程名称
objvcc_CourseEN.CourseTypeId = objRow[convcc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseEN.CourseTypeName = objRow[convcc_Course.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseEN.CreateDate = objRow[convcc_Course.CreateDate] == DBNull.Value ? null : objRow[convcc_Course.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseEN.ExcellentTypeId = objRow[convcc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseEN.ExcellentTypeName = objRow[convcc_Course.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseEN.ExcellentYear = objRow[convcc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseEN.OperationDate = objRow[convcc_Course.OperationDate] == DBNull.Value ? null : objRow[convcc_Course.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseEN.OrderNum = objRow[convcc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.OrderNum].ToString().Trim()); //序号
objvcc_CourseEN.OuterLink = objRow[convcc_Course.OuterLink] == DBNull.Value ? null : objRow[convcc_Course.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseEN.ViewCount = objRow[convcc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseEN.ThemeId = objRow[convcc_Course.ThemeId] == DBNull.Value ? null : objRow[convcc_Course.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseEN.ThemeName = objRow[convcc_Course.ThemeName] == DBNull.Value ? null : objRow[convcc_Course.ThemeName].ToString().Trim(); //主题名
objvcc_CourseEN.ExampleImgPath = objRow[convcc_Course.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_Course.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseEN.IdXzMajor = objRow[convcc_Course.IdXzMajor] == DBNull.Value ? null : objRow[convcc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseEN.MajorID = objRow[convcc_Course.MajorID] == DBNull.Value ? null : objRow[convcc_Course.MajorID].ToString().Trim(); //专业ID
objvcc_CourseEN.MajorName = objRow[convcc_Course.MajorName].ToString().Trim(); //专业名称
objvcc_CourseEN.IdXzCollege = objRow[convcc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseEN.CollegeId = objRow[convcc_Course.CollegeId] == DBNull.Value ? null : objRow[convcc_Course.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseEN.CollegeName = objRow[convcc_Course.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseEN.CollegeNameA = objRow[convcc_Course.CollegeNameA] == DBNull.Value ? null : objRow[convcc_Course.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseEN.Memo = objRow[convcc_Course.Memo] == DBNull.Value ? null : objRow[convcc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseEN);
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
public static List<clsvcc_CourseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseEN> arrObjLst = new List<clsvcc_CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseEN objvcc_CourseEN = new clsvcc_CourseEN();
try
{
objvcc_CourseEN.CourseId = objRow[convcc_Course.CourseId].ToString().Trim(); //课程Id
objvcc_CourseEN.LikeCount = objRow[convcc_Course.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseEN.CourseCode = objRow[convcc_Course.CourseCode] == DBNull.Value ? null : objRow[convcc_Course.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseEN.CourseDescription = objRow[convcc_Course.CourseDescription] == DBNull.Value ? null : objRow[convcc_Course.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseEN.CourseName = objRow[convcc_Course.CourseName] == DBNull.Value ? null : objRow[convcc_Course.CourseName].ToString().Trim(); //课程名称
objvcc_CourseEN.CourseTypeId = objRow[convcc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseEN.CourseTypeName = objRow[convcc_Course.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseEN.CreateDate = objRow[convcc_Course.CreateDate] == DBNull.Value ? null : objRow[convcc_Course.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseEN.ExcellentTypeId = objRow[convcc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseEN.ExcellentTypeName = objRow[convcc_Course.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseEN.ExcellentYear = objRow[convcc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseEN.OperationDate = objRow[convcc_Course.OperationDate] == DBNull.Value ? null : objRow[convcc_Course.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseEN.OrderNum = objRow[convcc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.OrderNum].ToString().Trim()); //序号
objvcc_CourseEN.OuterLink = objRow[convcc_Course.OuterLink] == DBNull.Value ? null : objRow[convcc_Course.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseEN.ViewCount = objRow[convcc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseEN.ThemeId = objRow[convcc_Course.ThemeId] == DBNull.Value ? null : objRow[convcc_Course.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseEN.ThemeName = objRow[convcc_Course.ThemeName] == DBNull.Value ? null : objRow[convcc_Course.ThemeName].ToString().Trim(); //主题名
objvcc_CourseEN.ExampleImgPath = objRow[convcc_Course.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_Course.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseEN.IdXzMajor = objRow[convcc_Course.IdXzMajor] == DBNull.Value ? null : objRow[convcc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseEN.MajorID = objRow[convcc_Course.MajorID] == DBNull.Value ? null : objRow[convcc_Course.MajorID].ToString().Trim(); //专业ID
objvcc_CourseEN.MajorName = objRow[convcc_Course.MajorName].ToString().Trim(); //专业名称
objvcc_CourseEN.IdXzCollege = objRow[convcc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseEN.CollegeId = objRow[convcc_Course.CollegeId] == DBNull.Value ? null : objRow[convcc_Course.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseEN.CollegeName = objRow[convcc_Course.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseEN.CollegeNameA = objRow[convcc_Course.CollegeNameA] == DBNull.Value ? null : objRow[convcc_Course.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseEN.Memo = objRow[convcc_Course.Memo] == DBNull.Value ? null : objRow[convcc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_CourseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_CourseEN> GetSubObjLstCache(clsvcc_CourseEN objvcc_CourseCond)
{
List<clsvcc_CourseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_Course.AttributeName)
{
if (objvcc_CourseCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseCond[strFldName].ToString());
}
else
{
if (objvcc_CourseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseCond[strFldName]));
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
public static List<clsvcc_CourseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_CourseEN> arrObjLst = new List<clsvcc_CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseEN objvcc_CourseEN = new clsvcc_CourseEN();
try
{
objvcc_CourseEN.CourseId = objRow[convcc_Course.CourseId].ToString().Trim(); //课程Id
objvcc_CourseEN.LikeCount = objRow[convcc_Course.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseEN.CourseCode = objRow[convcc_Course.CourseCode] == DBNull.Value ? null : objRow[convcc_Course.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseEN.CourseDescription = objRow[convcc_Course.CourseDescription] == DBNull.Value ? null : objRow[convcc_Course.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseEN.CourseName = objRow[convcc_Course.CourseName] == DBNull.Value ? null : objRow[convcc_Course.CourseName].ToString().Trim(); //课程名称
objvcc_CourseEN.CourseTypeId = objRow[convcc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseEN.CourseTypeName = objRow[convcc_Course.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseEN.CreateDate = objRow[convcc_Course.CreateDate] == DBNull.Value ? null : objRow[convcc_Course.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseEN.ExcellentTypeId = objRow[convcc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseEN.ExcellentTypeName = objRow[convcc_Course.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseEN.ExcellentYear = objRow[convcc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseEN.OperationDate = objRow[convcc_Course.OperationDate] == DBNull.Value ? null : objRow[convcc_Course.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseEN.OrderNum = objRow[convcc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.OrderNum].ToString().Trim()); //序号
objvcc_CourseEN.OuterLink = objRow[convcc_Course.OuterLink] == DBNull.Value ? null : objRow[convcc_Course.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseEN.ViewCount = objRow[convcc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseEN.ThemeId = objRow[convcc_Course.ThemeId] == DBNull.Value ? null : objRow[convcc_Course.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseEN.ThemeName = objRow[convcc_Course.ThemeName] == DBNull.Value ? null : objRow[convcc_Course.ThemeName].ToString().Trim(); //主题名
objvcc_CourseEN.ExampleImgPath = objRow[convcc_Course.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_Course.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseEN.IdXzMajor = objRow[convcc_Course.IdXzMajor] == DBNull.Value ? null : objRow[convcc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseEN.MajorID = objRow[convcc_Course.MajorID] == DBNull.Value ? null : objRow[convcc_Course.MajorID].ToString().Trim(); //专业ID
objvcc_CourseEN.MajorName = objRow[convcc_Course.MajorName].ToString().Trim(); //专业名称
objvcc_CourseEN.IdXzCollege = objRow[convcc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseEN.CollegeId = objRow[convcc_Course.CollegeId] == DBNull.Value ? null : objRow[convcc_Course.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseEN.CollegeName = objRow[convcc_Course.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseEN.CollegeNameA = objRow[convcc_Course.CollegeNameA] == DBNull.Value ? null : objRow[convcc_Course.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseEN.Memo = objRow[convcc_Course.Memo] == DBNull.Value ? null : objRow[convcc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseEN);
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
public static List<clsvcc_CourseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_CourseEN> arrObjLst = new List<clsvcc_CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseEN objvcc_CourseEN = new clsvcc_CourseEN();
try
{
objvcc_CourseEN.CourseId = objRow[convcc_Course.CourseId].ToString().Trim(); //课程Id
objvcc_CourseEN.LikeCount = objRow[convcc_Course.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseEN.CourseCode = objRow[convcc_Course.CourseCode] == DBNull.Value ? null : objRow[convcc_Course.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseEN.CourseDescription = objRow[convcc_Course.CourseDescription] == DBNull.Value ? null : objRow[convcc_Course.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseEN.CourseName = objRow[convcc_Course.CourseName] == DBNull.Value ? null : objRow[convcc_Course.CourseName].ToString().Trim(); //课程名称
objvcc_CourseEN.CourseTypeId = objRow[convcc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseEN.CourseTypeName = objRow[convcc_Course.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseEN.CreateDate = objRow[convcc_Course.CreateDate] == DBNull.Value ? null : objRow[convcc_Course.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseEN.ExcellentTypeId = objRow[convcc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseEN.ExcellentTypeName = objRow[convcc_Course.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseEN.ExcellentYear = objRow[convcc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseEN.OperationDate = objRow[convcc_Course.OperationDate] == DBNull.Value ? null : objRow[convcc_Course.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseEN.OrderNum = objRow[convcc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.OrderNum].ToString().Trim()); //序号
objvcc_CourseEN.OuterLink = objRow[convcc_Course.OuterLink] == DBNull.Value ? null : objRow[convcc_Course.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseEN.ViewCount = objRow[convcc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseEN.ThemeId = objRow[convcc_Course.ThemeId] == DBNull.Value ? null : objRow[convcc_Course.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseEN.ThemeName = objRow[convcc_Course.ThemeName] == DBNull.Value ? null : objRow[convcc_Course.ThemeName].ToString().Trim(); //主题名
objvcc_CourseEN.ExampleImgPath = objRow[convcc_Course.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_Course.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseEN.IdXzMajor = objRow[convcc_Course.IdXzMajor] == DBNull.Value ? null : objRow[convcc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseEN.MajorID = objRow[convcc_Course.MajorID] == DBNull.Value ? null : objRow[convcc_Course.MajorID].ToString().Trim(); //专业ID
objvcc_CourseEN.MajorName = objRow[convcc_Course.MajorName].ToString().Trim(); //专业名称
objvcc_CourseEN.IdXzCollege = objRow[convcc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseEN.CollegeId = objRow[convcc_Course.CollegeId] == DBNull.Value ? null : objRow[convcc_Course.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseEN.CollegeName = objRow[convcc_Course.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseEN.CollegeNameA = objRow[convcc_Course.CollegeNameA] == DBNull.Value ? null : objRow[convcc_Course.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseEN.Memo = objRow[convcc_Course.Memo] == DBNull.Value ? null : objRow[convcc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseEN);
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
List<clsvcc_CourseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_CourseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_CourseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseEN> arrObjLst = new List<clsvcc_CourseEN>(); 
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
	clsvcc_CourseEN objvcc_CourseEN = new clsvcc_CourseEN();
try
{
objvcc_CourseEN.CourseId = objRow[convcc_Course.CourseId].ToString().Trim(); //课程Id
objvcc_CourseEN.LikeCount = objRow[convcc_Course.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseEN.CourseCode = objRow[convcc_Course.CourseCode] == DBNull.Value ? null : objRow[convcc_Course.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseEN.CourseDescription = objRow[convcc_Course.CourseDescription] == DBNull.Value ? null : objRow[convcc_Course.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseEN.CourseName = objRow[convcc_Course.CourseName] == DBNull.Value ? null : objRow[convcc_Course.CourseName].ToString().Trim(); //课程名称
objvcc_CourseEN.CourseTypeId = objRow[convcc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseEN.CourseTypeName = objRow[convcc_Course.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseEN.CreateDate = objRow[convcc_Course.CreateDate] == DBNull.Value ? null : objRow[convcc_Course.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseEN.ExcellentTypeId = objRow[convcc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseEN.ExcellentTypeName = objRow[convcc_Course.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseEN.ExcellentYear = objRow[convcc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseEN.OperationDate = objRow[convcc_Course.OperationDate] == DBNull.Value ? null : objRow[convcc_Course.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseEN.OrderNum = objRow[convcc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.OrderNum].ToString().Trim()); //序号
objvcc_CourseEN.OuterLink = objRow[convcc_Course.OuterLink] == DBNull.Value ? null : objRow[convcc_Course.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseEN.ViewCount = objRow[convcc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseEN.ThemeId = objRow[convcc_Course.ThemeId] == DBNull.Value ? null : objRow[convcc_Course.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseEN.ThemeName = objRow[convcc_Course.ThemeName] == DBNull.Value ? null : objRow[convcc_Course.ThemeName].ToString().Trim(); //主题名
objvcc_CourseEN.ExampleImgPath = objRow[convcc_Course.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_Course.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseEN.IdXzMajor = objRow[convcc_Course.IdXzMajor] == DBNull.Value ? null : objRow[convcc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseEN.MajorID = objRow[convcc_Course.MajorID] == DBNull.Value ? null : objRow[convcc_Course.MajorID].ToString().Trim(); //专业ID
objvcc_CourseEN.MajorName = objRow[convcc_Course.MajorName].ToString().Trim(); //专业名称
objvcc_CourseEN.IdXzCollege = objRow[convcc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseEN.CollegeId = objRow[convcc_Course.CollegeId] == DBNull.Value ? null : objRow[convcc_Course.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseEN.CollegeName = objRow[convcc_Course.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseEN.CollegeNameA = objRow[convcc_Course.CollegeNameA] == DBNull.Value ? null : objRow[convcc_Course.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseEN.Memo = objRow[convcc_Course.Memo] == DBNull.Value ? null : objRow[convcc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseEN);
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
public static List<clsvcc_CourseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseEN> arrObjLst = new List<clsvcc_CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseEN objvcc_CourseEN = new clsvcc_CourseEN();
try
{
objvcc_CourseEN.CourseId = objRow[convcc_Course.CourseId].ToString().Trim(); //课程Id
objvcc_CourseEN.LikeCount = objRow[convcc_Course.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseEN.CourseCode = objRow[convcc_Course.CourseCode] == DBNull.Value ? null : objRow[convcc_Course.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseEN.CourseDescription = objRow[convcc_Course.CourseDescription] == DBNull.Value ? null : objRow[convcc_Course.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseEN.CourseName = objRow[convcc_Course.CourseName] == DBNull.Value ? null : objRow[convcc_Course.CourseName].ToString().Trim(); //课程名称
objvcc_CourseEN.CourseTypeId = objRow[convcc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseEN.CourseTypeName = objRow[convcc_Course.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseEN.CreateDate = objRow[convcc_Course.CreateDate] == DBNull.Value ? null : objRow[convcc_Course.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseEN.ExcellentTypeId = objRow[convcc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseEN.ExcellentTypeName = objRow[convcc_Course.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseEN.ExcellentYear = objRow[convcc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseEN.OperationDate = objRow[convcc_Course.OperationDate] == DBNull.Value ? null : objRow[convcc_Course.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseEN.OrderNum = objRow[convcc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.OrderNum].ToString().Trim()); //序号
objvcc_CourseEN.OuterLink = objRow[convcc_Course.OuterLink] == DBNull.Value ? null : objRow[convcc_Course.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseEN.ViewCount = objRow[convcc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseEN.ThemeId = objRow[convcc_Course.ThemeId] == DBNull.Value ? null : objRow[convcc_Course.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseEN.ThemeName = objRow[convcc_Course.ThemeName] == DBNull.Value ? null : objRow[convcc_Course.ThemeName].ToString().Trim(); //主题名
objvcc_CourseEN.ExampleImgPath = objRow[convcc_Course.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_Course.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseEN.IdXzMajor = objRow[convcc_Course.IdXzMajor] == DBNull.Value ? null : objRow[convcc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseEN.MajorID = objRow[convcc_Course.MajorID] == DBNull.Value ? null : objRow[convcc_Course.MajorID].ToString().Trim(); //专业ID
objvcc_CourseEN.MajorName = objRow[convcc_Course.MajorName].ToString().Trim(); //专业名称
objvcc_CourseEN.IdXzCollege = objRow[convcc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseEN.CollegeId = objRow[convcc_Course.CollegeId] == DBNull.Value ? null : objRow[convcc_Course.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseEN.CollegeName = objRow[convcc_Course.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseEN.CollegeNameA = objRow[convcc_Course.CollegeNameA] == DBNull.Value ? null : objRow[convcc_Course.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseEN.Memo = objRow[convcc_Course.Memo] == DBNull.Value ? null : objRow[convcc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_CourseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_CourseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseEN> arrObjLst = new List<clsvcc_CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseEN objvcc_CourseEN = new clsvcc_CourseEN();
try
{
objvcc_CourseEN.CourseId = objRow[convcc_Course.CourseId].ToString().Trim(); //课程Id
objvcc_CourseEN.LikeCount = objRow[convcc_Course.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseEN.CourseCode = objRow[convcc_Course.CourseCode] == DBNull.Value ? null : objRow[convcc_Course.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseEN.CourseDescription = objRow[convcc_Course.CourseDescription] == DBNull.Value ? null : objRow[convcc_Course.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseEN.CourseName = objRow[convcc_Course.CourseName] == DBNull.Value ? null : objRow[convcc_Course.CourseName].ToString().Trim(); //课程名称
objvcc_CourseEN.CourseTypeId = objRow[convcc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseEN.CourseTypeName = objRow[convcc_Course.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseEN.CreateDate = objRow[convcc_Course.CreateDate] == DBNull.Value ? null : objRow[convcc_Course.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseEN.ExcellentTypeId = objRow[convcc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseEN.ExcellentTypeName = objRow[convcc_Course.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseEN.ExcellentYear = objRow[convcc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseEN.OperationDate = objRow[convcc_Course.OperationDate] == DBNull.Value ? null : objRow[convcc_Course.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseEN.OrderNum = objRow[convcc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.OrderNum].ToString().Trim()); //序号
objvcc_CourseEN.OuterLink = objRow[convcc_Course.OuterLink] == DBNull.Value ? null : objRow[convcc_Course.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseEN.ViewCount = objRow[convcc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseEN.ThemeId = objRow[convcc_Course.ThemeId] == DBNull.Value ? null : objRow[convcc_Course.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseEN.ThemeName = objRow[convcc_Course.ThemeName] == DBNull.Value ? null : objRow[convcc_Course.ThemeName].ToString().Trim(); //主题名
objvcc_CourseEN.ExampleImgPath = objRow[convcc_Course.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_Course.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseEN.IdXzMajor = objRow[convcc_Course.IdXzMajor] == DBNull.Value ? null : objRow[convcc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseEN.MajorID = objRow[convcc_Course.MajorID] == DBNull.Value ? null : objRow[convcc_Course.MajorID].ToString().Trim(); //专业ID
objvcc_CourseEN.MajorName = objRow[convcc_Course.MajorName].ToString().Trim(); //专业名称
objvcc_CourseEN.IdXzCollege = objRow[convcc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseEN.CollegeId = objRow[convcc_Course.CollegeId] == DBNull.Value ? null : objRow[convcc_Course.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseEN.CollegeName = objRow[convcc_Course.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseEN.CollegeNameA = objRow[convcc_Course.CollegeNameA] == DBNull.Value ? null : objRow[convcc_Course.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseEN.Memo = objRow[convcc_Course.Memo] == DBNull.Value ? null : objRow[convcc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseEN);
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
public static List<clsvcc_CourseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_CourseEN> arrObjLst = new List<clsvcc_CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseEN objvcc_CourseEN = new clsvcc_CourseEN();
try
{
objvcc_CourseEN.CourseId = objRow[convcc_Course.CourseId].ToString().Trim(); //课程Id
objvcc_CourseEN.LikeCount = objRow[convcc_Course.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseEN.CourseCode = objRow[convcc_Course.CourseCode] == DBNull.Value ? null : objRow[convcc_Course.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseEN.CourseDescription = objRow[convcc_Course.CourseDescription] == DBNull.Value ? null : objRow[convcc_Course.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseEN.CourseName = objRow[convcc_Course.CourseName] == DBNull.Value ? null : objRow[convcc_Course.CourseName].ToString().Trim(); //课程名称
objvcc_CourseEN.CourseTypeId = objRow[convcc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseEN.CourseTypeName = objRow[convcc_Course.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseEN.CreateDate = objRow[convcc_Course.CreateDate] == DBNull.Value ? null : objRow[convcc_Course.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseEN.ExcellentTypeId = objRow[convcc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseEN.ExcellentTypeName = objRow[convcc_Course.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseEN.ExcellentYear = objRow[convcc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseEN.OperationDate = objRow[convcc_Course.OperationDate] == DBNull.Value ? null : objRow[convcc_Course.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseEN.OrderNum = objRow[convcc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.OrderNum].ToString().Trim()); //序号
objvcc_CourseEN.OuterLink = objRow[convcc_Course.OuterLink] == DBNull.Value ? null : objRow[convcc_Course.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseEN.ViewCount = objRow[convcc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseEN.ThemeId = objRow[convcc_Course.ThemeId] == DBNull.Value ? null : objRow[convcc_Course.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseEN.ThemeName = objRow[convcc_Course.ThemeName] == DBNull.Value ? null : objRow[convcc_Course.ThemeName].ToString().Trim(); //主题名
objvcc_CourseEN.ExampleImgPath = objRow[convcc_Course.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_Course.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseEN.IdXzMajor = objRow[convcc_Course.IdXzMajor] == DBNull.Value ? null : objRow[convcc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseEN.MajorID = objRow[convcc_Course.MajorID] == DBNull.Value ? null : objRow[convcc_Course.MajorID].ToString().Trim(); //专业ID
objvcc_CourseEN.MajorName = objRow[convcc_Course.MajorName].ToString().Trim(); //专业名称
objvcc_CourseEN.IdXzCollege = objRow[convcc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseEN.CollegeId = objRow[convcc_Course.CollegeId] == DBNull.Value ? null : objRow[convcc_Course.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseEN.CollegeName = objRow[convcc_Course.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseEN.CollegeNameA = objRow[convcc_Course.CollegeNameA] == DBNull.Value ? null : objRow[convcc_Course.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseEN.Memo = objRow[convcc_Course.Memo] == DBNull.Value ? null : objRow[convcc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_CourseEN> arrObjLst = new List<clsvcc_CourseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseEN objvcc_CourseEN = new clsvcc_CourseEN();
try
{
objvcc_CourseEN.CourseId = objRow[convcc_Course.CourseId].ToString().Trim(); //课程Id
objvcc_CourseEN.LikeCount = objRow[convcc_Course.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseEN.CourseCode = objRow[convcc_Course.CourseCode] == DBNull.Value ? null : objRow[convcc_Course.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseEN.CourseDescription = objRow[convcc_Course.CourseDescription] == DBNull.Value ? null : objRow[convcc_Course.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseEN.CourseName = objRow[convcc_Course.CourseName] == DBNull.Value ? null : objRow[convcc_Course.CourseName].ToString().Trim(); //课程名称
objvcc_CourseEN.CourseTypeId = objRow[convcc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseEN.CourseTypeName = objRow[convcc_Course.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseEN.CreateDate = objRow[convcc_Course.CreateDate] == DBNull.Value ? null : objRow[convcc_Course.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseEN.ExcellentTypeId = objRow[convcc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseEN.ExcellentTypeName = objRow[convcc_Course.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseEN.ExcellentYear = objRow[convcc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseEN.OperationDate = objRow[convcc_Course.OperationDate] == DBNull.Value ? null : objRow[convcc_Course.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseEN.OrderNum = objRow[convcc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.OrderNum].ToString().Trim()); //序号
objvcc_CourseEN.OuterLink = objRow[convcc_Course.OuterLink] == DBNull.Value ? null : objRow[convcc_Course.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseEN.ViewCount = objRow[convcc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseEN.ThemeId = objRow[convcc_Course.ThemeId] == DBNull.Value ? null : objRow[convcc_Course.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseEN.ThemeName = objRow[convcc_Course.ThemeName] == DBNull.Value ? null : objRow[convcc_Course.ThemeName].ToString().Trim(); //主题名
objvcc_CourseEN.ExampleImgPath = objRow[convcc_Course.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_Course.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseEN.IdXzMajor = objRow[convcc_Course.IdXzMajor] == DBNull.Value ? null : objRow[convcc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseEN.MajorID = objRow[convcc_Course.MajorID] == DBNull.Value ? null : objRow[convcc_Course.MajorID].ToString().Trim(); //专业ID
objvcc_CourseEN.MajorName = objRow[convcc_Course.MajorName].ToString().Trim(); //专业名称
objvcc_CourseEN.IdXzCollege = objRow[convcc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseEN.CollegeId = objRow[convcc_Course.CollegeId] == DBNull.Value ? null : objRow[convcc_Course.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseEN.CollegeName = objRow[convcc_Course.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseEN.CollegeNameA = objRow[convcc_Course.CollegeNameA] == DBNull.Value ? null : objRow[convcc_Course.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseEN.Memo = objRow[convcc_Course.Memo] == DBNull.Value ? null : objRow[convcc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_CourseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_Course(ref clsvcc_CourseEN objvcc_CourseEN)
{
bool bolResult = vcc_CourseDA.Getvcc_Course(ref objvcc_CourseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseEN GetObjByCourseId(string strCourseId)
{
if (strCourseId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCourseId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCourseId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCourseId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvcc_CourseEN objvcc_CourseEN = vcc_CourseDA.GetObjByCourseId(strCourseId);
return objvcc_CourseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_CourseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_CourseEN objvcc_CourseEN = vcc_CourseDA.GetFirstObj(strWhereCond);
 return objvcc_CourseEN;
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
public static clsvcc_CourseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_CourseEN objvcc_CourseEN = vcc_CourseDA.GetObjByDataRow(objRow);
 return objvcc_CourseEN;
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
public static clsvcc_CourseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_CourseEN objvcc_CourseEN = vcc_CourseDA.GetObjByDataRow(objRow);
 return objvcc_CourseEN;
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
 /// <param name = "strCourseId">所给的关键字</param>
 /// <param name = "lstvcc_CourseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseEN GetObjByCourseIdFromList(string strCourseId, List<clsvcc_CourseEN> lstvcc_CourseObjLst)
{
foreach (clsvcc_CourseEN objvcc_CourseEN in lstvcc_CourseObjLst)
{
if (objvcc_CourseEN.CourseId == strCourseId)
{
return objvcc_CourseEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxCourseId;
 try
 {
 strMaxCourseId = clsvcc_CourseDA.GetMaxStrId();
 return strMaxCourseId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strCourseId;
 try
 {
 strCourseId = new clsvcc_CourseDA().GetFirstID(strWhereCond);
 return strCourseId;
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
 arrList = vcc_CourseDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_CourseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCourseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCourseId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vcc_CourseDA.IsExist(strCourseId);
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
 bolIsExist = clsvcc_CourseDA.IsExistTable();
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
 bolIsExist = vcc_CourseDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_CourseENS">源对象</param>
 /// <param name = "objvcc_CourseENT">目标对象</param>
 public static void CopyTo(clsvcc_CourseEN objvcc_CourseENS, clsvcc_CourseEN objvcc_CourseENT)
{
try
{
objvcc_CourseENT.CourseId = objvcc_CourseENS.CourseId; //课程Id
objvcc_CourseENT.LikeCount = objvcc_CourseENS.LikeCount; //LikeCount
objvcc_CourseENT.CourseCode = objvcc_CourseENS.CourseCode; //课程代码
objvcc_CourseENT.CourseDescription = objvcc_CourseENS.CourseDescription; //课程描述
objvcc_CourseENT.CourseName = objvcc_CourseENS.CourseName; //课程名称
objvcc_CourseENT.CourseTypeId = objvcc_CourseENS.CourseTypeId; //课程类型ID
objvcc_CourseENT.CourseTypeName = objvcc_CourseENS.CourseTypeName; //课程类型名称
objvcc_CourseENT.CreateDate = objvcc_CourseENS.CreateDate; //建立日期
objvcc_CourseENT.ExcellentTypeId = objvcc_CourseENS.ExcellentTypeId; //精品课程类型Id
objvcc_CourseENT.ExcellentTypeName = objvcc_CourseENS.ExcellentTypeName; //精品课程类型名称
objvcc_CourseENT.ExcellentYear = objvcc_CourseENS.ExcellentYear; //课程年份
objvcc_CourseENT.IsBuildingCourse = objvcc_CourseENS.IsBuildingCourse; //是否已建设课程
objvcc_CourseENT.IsDoubleLanguageCourse = objvcc_CourseENS.IsDoubleLanguageCourse; //是否双语课程
objvcc_CourseENT.IsOpen = objvcc_CourseENS.IsOpen; //是否公开
objvcc_CourseENT.IsRecommendedCourse = objvcc_CourseENS.IsRecommendedCourse; //是否推荐课程
objvcc_CourseENT.IsSelfPropelledCourse = objvcc_CourseENS.IsSelfPropelledCourse; //是否自荐课程
objvcc_CourseENT.OperationDate = objvcc_CourseENS.OperationDate; //操作时间
objvcc_CourseENT.OrderNum = objvcc_CourseENS.OrderNum; //序号
objvcc_CourseENT.OuterLink = objvcc_CourseENS.OuterLink; //外链地址
objvcc_CourseENT.ViewCount = objvcc_CourseENS.ViewCount; //浏览量
objvcc_CourseENT.ThemeId = objvcc_CourseENS.ThemeId; //主题Id
objvcc_CourseENT.ThemeName = objvcc_CourseENS.ThemeName; //主题名
objvcc_CourseENT.ExampleImgPath = objvcc_CourseENS.ExampleImgPath; //示例图路径
objvcc_CourseENT.IdXzMajor = objvcc_CourseENS.IdXzMajor; //专业流水号
objvcc_CourseENT.MajorID = objvcc_CourseENS.MajorID; //专业ID
objvcc_CourseENT.MajorName = objvcc_CourseENS.MajorName; //专业名称
objvcc_CourseENT.IdXzCollege = objvcc_CourseENS.IdXzCollege; //学院流水号
objvcc_CourseENT.CollegeId = objvcc_CourseENS.CollegeId; //学院ID
objvcc_CourseENT.CollegeName = objvcc_CourseENS.CollegeName; //学院名称
objvcc_CourseENT.CollegeNameA = objvcc_CourseENS.CollegeNameA; //学院名称简写
objvcc_CourseENT.Memo = objvcc_CourseENS.Memo; //备注
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
 /// <param name = "objvcc_CourseEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_CourseEN objvcc_CourseEN)
{
try
{
objvcc_CourseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_CourseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_Course.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.CourseId = objvcc_CourseEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_Course.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.LikeCount = objvcc_CourseEN.LikeCount; //LikeCount
}
if (arrFldSet.Contains(convcc_Course.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.CourseCode = objvcc_CourseEN.CourseCode == "[null]" ? null :  objvcc_CourseEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convcc_Course.CourseDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.CourseDescription = objvcc_CourseEN.CourseDescription == "[null]" ? null :  objvcc_CourseEN.CourseDescription; //课程描述
}
if (arrFldSet.Contains(convcc_Course.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.CourseName = objvcc_CourseEN.CourseName == "[null]" ? null :  objvcc_CourseEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_Course.CourseTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.CourseTypeId = objvcc_CourseEN.CourseTypeId; //课程类型ID
}
if (arrFldSet.Contains(convcc_Course.CourseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.CourseTypeName = objvcc_CourseEN.CourseTypeName; //课程类型名称
}
if (arrFldSet.Contains(convcc_Course.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.CreateDate = objvcc_CourseEN.CreateDate == "[null]" ? null :  objvcc_CourseEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convcc_Course.ExcellentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.ExcellentTypeId = objvcc_CourseEN.ExcellentTypeId == "[null]" ? null :  objvcc_CourseEN.ExcellentTypeId; //精品课程类型Id
}
if (arrFldSet.Contains(convcc_Course.ExcellentTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.ExcellentTypeName = objvcc_CourseEN.ExcellentTypeName == "[null]" ? null :  objvcc_CourseEN.ExcellentTypeName; //精品课程类型名称
}
if (arrFldSet.Contains(convcc_Course.ExcellentYear, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.ExcellentYear = objvcc_CourseEN.ExcellentYear; //课程年份
}
if (arrFldSet.Contains(convcc_Course.IsBuildingCourse, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.IsBuildingCourse = objvcc_CourseEN.IsBuildingCourse; //是否已建设课程
}
if (arrFldSet.Contains(convcc_Course.IsDoubleLanguageCourse, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.IsDoubleLanguageCourse = objvcc_CourseEN.IsDoubleLanguageCourse; //是否双语课程
}
if (arrFldSet.Contains(convcc_Course.IsOpen, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.IsOpen = objvcc_CourseEN.IsOpen; //是否公开
}
if (arrFldSet.Contains(convcc_Course.IsRecommendedCourse, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.IsRecommendedCourse = objvcc_CourseEN.IsRecommendedCourse; //是否推荐课程
}
if (arrFldSet.Contains(convcc_Course.IsSelfPropelledCourse, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.IsSelfPropelledCourse = objvcc_CourseEN.IsSelfPropelledCourse; //是否自荐课程
}
if (arrFldSet.Contains(convcc_Course.OperationDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.OperationDate = objvcc_CourseEN.OperationDate == "[null]" ? null :  objvcc_CourseEN.OperationDate; //操作时间
}
if (arrFldSet.Contains(convcc_Course.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.OrderNum = objvcc_CourseEN.OrderNum; //序号
}
if (arrFldSet.Contains(convcc_Course.OuterLink, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.OuterLink = objvcc_CourseEN.OuterLink == "[null]" ? null :  objvcc_CourseEN.OuterLink; //外链地址
}
if (arrFldSet.Contains(convcc_Course.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.ViewCount = objvcc_CourseEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convcc_Course.ThemeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.ThemeId = objvcc_CourseEN.ThemeId == "[null]" ? null :  objvcc_CourseEN.ThemeId; //主题Id
}
if (arrFldSet.Contains(convcc_Course.ThemeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.ThemeName = objvcc_CourseEN.ThemeName == "[null]" ? null :  objvcc_CourseEN.ThemeName; //主题名
}
if (arrFldSet.Contains(convcc_Course.ExampleImgPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.ExampleImgPath = objvcc_CourseEN.ExampleImgPath == "[null]" ? null :  objvcc_CourseEN.ExampleImgPath; //示例图路径
}
if (arrFldSet.Contains(convcc_Course.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.IdXzMajor = objvcc_CourseEN.IdXzMajor == "[null]" ? null :  objvcc_CourseEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convcc_Course.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.MajorID = objvcc_CourseEN.MajorID == "[null]" ? null :  objvcc_CourseEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convcc_Course.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.MajorName = objvcc_CourseEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convcc_Course.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.IdXzCollege = objvcc_CourseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convcc_Course.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.CollegeId = objvcc_CourseEN.CollegeId == "[null]" ? null :  objvcc_CourseEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convcc_Course.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.CollegeName = objvcc_CourseEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convcc_Course.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.CollegeNameA = objvcc_CourseEN.CollegeNameA == "[null]" ? null :  objvcc_CourseEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convcc_Course.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseEN.Memo = objvcc_CourseEN.Memo == "[null]" ? null :  objvcc_CourseEN.Memo; //备注
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
 /// <param name = "objvcc_CourseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_CourseEN objvcc_CourseEN)
{
try
{
if (objvcc_CourseEN.CourseCode == "[null]") objvcc_CourseEN.CourseCode = null; //课程代码
if (objvcc_CourseEN.CourseDescription == "[null]") objvcc_CourseEN.CourseDescription = null; //课程描述
if (objvcc_CourseEN.CourseName == "[null]") objvcc_CourseEN.CourseName = null; //课程名称
if (objvcc_CourseEN.CreateDate == "[null]") objvcc_CourseEN.CreateDate = null; //建立日期
if (objvcc_CourseEN.ExcellentTypeId == "[null]") objvcc_CourseEN.ExcellentTypeId = null; //精品课程类型Id
if (objvcc_CourseEN.ExcellentTypeName == "[null]") objvcc_CourseEN.ExcellentTypeName = null; //精品课程类型名称
if (objvcc_CourseEN.OperationDate == "[null]") objvcc_CourseEN.OperationDate = null; //操作时间
if (objvcc_CourseEN.OuterLink == "[null]") objvcc_CourseEN.OuterLink = null; //外链地址
if (objvcc_CourseEN.ThemeId == "[null]") objvcc_CourseEN.ThemeId = null; //主题Id
if (objvcc_CourseEN.ThemeName == "[null]") objvcc_CourseEN.ThemeName = null; //主题名
if (objvcc_CourseEN.ExampleImgPath == "[null]") objvcc_CourseEN.ExampleImgPath = null; //示例图路径
if (objvcc_CourseEN.IdXzMajor == "[null]") objvcc_CourseEN.IdXzMajor = null; //专业流水号
if (objvcc_CourseEN.MajorID == "[null]") objvcc_CourseEN.MajorID = null; //专业ID
if (objvcc_CourseEN.CollegeId == "[null]") objvcc_CourseEN.CollegeId = null; //学院ID
if (objvcc_CourseEN.CollegeNameA == "[null]") objvcc_CourseEN.CollegeNameA = null; //学院名称简写
if (objvcc_CourseEN.Memo == "[null]") objvcc_CourseEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvcc_CourseEN objvcc_CourseEN)
{
 vcc_CourseDA.CheckProperty4Condition(objvcc_CourseEN);
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
//string strWhereCond = string.Format("1 = 1 order by CourseId");
//if (arrvcc_CourseObjLstCache == null)
//{
//arrvcc_CourseObjLstCache = vcc_CourseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCourseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseEN GetObjByCourseIdCache(string strCourseId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvcc_CourseEN._CurrTabName);
List<clsvcc_CourseEN> arrvcc_CourseObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseEN> arrvcc_CourseObjLst_Sel =
arrvcc_CourseObjLstCache
.Where(x=> x.CourseId == strCourseId 
);
if (arrvcc_CourseObjLst_Sel.Count() == 0)
{
   clsvcc_CourseEN obj = clsvcc_CourseBL.GetObjByCourseId(strCourseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvcc_CourseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseEN> GetAllvcc_CourseObjLstCache()
{
//获取缓存中的对象列表
List<clsvcc_CourseEN> arrvcc_CourseObjLstCache = GetObjLstCache(); 
return arrvcc_CourseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvcc_CourseEN._CurrTabName);
List<clsvcc_CourseEN> arrvcc_CourseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_CourseObjLstCache;
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
string strKey = string.Format("{0}", clsvcc_CourseEN._CurrTabName);
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
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strCourseId)
{
if (strInFldName != convcc_Course.CourseId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_Course.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_Course.AttributeName));
throw new Exception(strMsg);
}
var objvcc_Course = clsvcc_CourseBL.GetObjByCourseIdCache(strCourseId);
if (objvcc_Course == null) return "";
return objvcc_Course[strOutFldName].ToString();
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
int intRecCount = clsvcc_CourseDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_CourseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_CourseDA.GetRecCount();
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
int intRecCount = clsvcc_CourseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_CourseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_CourseEN objvcc_CourseCond)
{
List<clsvcc_CourseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_Course.AttributeName)
{
if (objvcc_CourseCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseCond[strFldName].ToString());
}
else
{
if (objvcc_CourseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseCond[strFldName]));
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
 List<string> arrList = clsvcc_CourseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}