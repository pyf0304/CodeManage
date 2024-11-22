
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseWApi
 表名:cc_Course(01120056)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:17
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
public static class clscc_CourseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetCourseId(this clscc_CourseEN objcc_CourseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_Course.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_Course.CourseId);
objcc_CourseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.CourseId) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.CourseId, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.CourseId] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetCourseCode(this clscc_CourseEN objcc_CourseEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, concc_Course.CourseCode);
objcc_CourseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.CourseCode) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.CourseCode, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.CourseCode] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetCourseDescription(this clscc_CourseEN objcc_CourseEN, string strCourseDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, concc_Course.CourseDescription);
objcc_CourseEN.CourseDescription = strCourseDescription; //课程描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.CourseDescription) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.CourseDescription, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.CourseDescription] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetCourseName(this clscc_CourseEN objcc_CourseEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseName, concc_Course.CourseName);
clsCheckSql.CheckFieldLen(strCourseName, 100, concc_Course.CourseName);
objcc_CourseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.CourseName) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.CourseName, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.CourseName] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetCourseTypeID(this clscc_CourseEN objcc_CourseEN, string strCourseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, concc_Course.CourseTypeID);
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, concc_Course.CourseTypeID);
objcc_CourseEN.CourseTypeID = strCourseTypeID; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.CourseTypeID) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.CourseTypeID, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.CourseTypeID] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetCreateDate(this clscc_CourseEN objcc_CourseEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, concc_Course.CreateDate);
objcc_CourseEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.CreateDate) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.CreateDate, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.CreateDate] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetExcellentTypeId(this clscc_CourseEN objcc_CourseEN, string strExcellentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExcellentTypeId, 4, concc_Course.ExcellentTypeId);
clsCheckSql.CheckFieldForeignKey(strExcellentTypeId, 4, concc_Course.ExcellentTypeId);
objcc_CourseEN.ExcellentTypeId = strExcellentTypeId; //精品课程类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.ExcellentTypeId) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.ExcellentTypeId, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.ExcellentTypeId] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetExcellentYear(this clscc_CourseEN objcc_CourseEN, int intExcellentYear, string strComparisonOp="")
	{
objcc_CourseEN.ExcellentYear = intExcellentYear; //课程年份
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.ExcellentYear) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.ExcellentYear, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.ExcellentYear] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetIsBuildingCourse(this clscc_CourseEN objcc_CourseEN, bool bolIsBuildingCourse, string strComparisonOp="")
	{
objcc_CourseEN.IsBuildingCourse = bolIsBuildingCourse; //是否已建设课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.IsBuildingCourse) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.IsBuildingCourse, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.IsBuildingCourse] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetIsDoubleLanguageCourse(this clscc_CourseEN objcc_CourseEN, bool bolIsDoubleLanguageCourse, string strComparisonOp="")
	{
objcc_CourseEN.IsDoubleLanguageCourse = bolIsDoubleLanguageCourse; //是否双语课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.IsDoubleLanguageCourse) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.IsDoubleLanguageCourse, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.IsDoubleLanguageCourse] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetIsOpen(this clscc_CourseEN objcc_CourseEN, bool bolIsOpen, string strComparisonOp="")
	{
objcc_CourseEN.IsOpen = bolIsOpen; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.IsOpen) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.IsOpen, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.IsOpen] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetIsRecommendedCourse(this clscc_CourseEN objcc_CourseEN, bool bolIsRecommendedCourse, string strComparisonOp="")
	{
objcc_CourseEN.IsRecommendedCourse = bolIsRecommendedCourse; //是否推荐课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.IsRecommendedCourse) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.IsRecommendedCourse, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.IsRecommendedCourse] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetIsSelfPropelledCourse(this clscc_CourseEN objcc_CourseEN, bool bolIsSelfPropelledCourse, string strComparisonOp="")
	{
objcc_CourseEN.IsSelfPropelledCourse = bolIsSelfPropelledCourse; //是否自荐课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.IsSelfPropelledCourse) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.IsSelfPropelledCourse, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.IsSelfPropelledCourse] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetOperationDate(this clscc_CourseEN objcc_CourseEN, string strOperationDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOperationDate, 20, concc_Course.OperationDate);
objcc_CourseEN.OperationDate = strOperationDate; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.OperationDate) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.OperationDate, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.OperationDate] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetOrderNum(this clscc_CourseEN objcc_CourseEN, int intOrderNum, string strComparisonOp="")
	{
objcc_CourseEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.OrderNum) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.OrderNum, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.OrderNum] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetOuterLink(this clscc_CourseEN objcc_CourseEN, string strOuterLink, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOuterLink, 500, concc_Course.OuterLink);
objcc_CourseEN.OuterLink = strOuterLink; //外链地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.OuterLink) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.OuterLink, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.OuterLink] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetViewCount(this clscc_CourseEN objcc_CourseEN, int intViewCount, string strComparisonOp="")
	{
objcc_CourseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.ViewCount) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.ViewCount, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.ViewCount] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetThemeId(this clscc_CourseEN objcc_CourseEN, string strThemeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strThemeId, 4, concc_Course.ThemeId);
clsCheckSql.CheckFieldForeignKey(strThemeId, 4, concc_Course.ThemeId);
objcc_CourseEN.ThemeId = strThemeId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.ThemeId) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.ThemeId, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.ThemeId] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN Setid_School(this clscc_CourseEN objcc_CourseEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, concc_Course.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, concc_Course.id_School);
objcc_CourseEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.id_School) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.id_School, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.id_School] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN Setid_XzMajor(this clscc_CourseEN objcc_CourseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, concc_Course.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, concc_Course.id_XzMajor);
objcc_CourseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.id_XzMajor) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.id_XzMajor, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.id_XzMajor] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN Setid_XzCollege(this clscc_CourseEN objcc_CourseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, concc_Course.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, concc_Course.id_XzCollege);
objcc_CourseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.id_XzCollege) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.id_XzCollege, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.id_XzCollege] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetUpdDate(this clscc_CourseEN objcc_CourseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_Course.UpdDate);
objcc_CourseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.UpdDate) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.UpdDate, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.UpdDate] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetUpdUserId(this clscc_CourseEN objcc_CourseEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_Course.UpdUserId);
objcc_CourseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.UpdUserId) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.UpdUserId, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.UpdUserId] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseEN SetMemo(this clscc_CourseEN objcc_CourseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_Course.Memo);
objcc_CourseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.Memo) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.Memo, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.Memo] = strComparisonOp;
}
}
return objcc_CourseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_CourseEN objcc_Course_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_Course_Cond.IsUpdated(concc_Course.CourseId) == true)
{
string strComparisonOp_CourseId = objcc_Course_Cond.dicFldComparisonOp[concc_Course.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.CourseId, objcc_Course_Cond.CourseId, strComparisonOp_CourseId);
}
if (objcc_Course_Cond.IsUpdated(concc_Course.CourseCode) == true)
{
string strComparisonOp_CourseCode = objcc_Course_Cond.dicFldComparisonOp[concc_Course.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.CourseCode, objcc_Course_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objcc_Course_Cond.IsUpdated(concc_Course.CourseDescription) == true)
{
string strComparisonOp_CourseDescription = objcc_Course_Cond.dicFldComparisonOp[concc_Course.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.CourseDescription, objcc_Course_Cond.CourseDescription, strComparisonOp_CourseDescription);
}
if (objcc_Course_Cond.IsUpdated(concc_Course.CourseName) == true)
{
string strComparisonOp_CourseName = objcc_Course_Cond.dicFldComparisonOp[concc_Course.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.CourseName, objcc_Course_Cond.CourseName, strComparisonOp_CourseName);
}
if (objcc_Course_Cond.IsUpdated(concc_Course.CourseTypeID) == true)
{
string strComparisonOp_CourseTypeID = objcc_Course_Cond.dicFldComparisonOp[concc_Course.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.CourseTypeID, objcc_Course_Cond.CourseTypeID, strComparisonOp_CourseTypeID);
}
if (objcc_Course_Cond.IsUpdated(concc_Course.CreateDate) == true)
{
string strComparisonOp_CreateDate = objcc_Course_Cond.dicFldComparisonOp[concc_Course.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.CreateDate, objcc_Course_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objcc_Course_Cond.IsUpdated(concc_Course.ExcellentTypeId) == true)
{
string strComparisonOp_ExcellentTypeId = objcc_Course_Cond.dicFldComparisonOp[concc_Course.ExcellentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.ExcellentTypeId, objcc_Course_Cond.ExcellentTypeId, strComparisonOp_ExcellentTypeId);
}
if (objcc_Course_Cond.IsUpdated(concc_Course.ExcellentYear) == true)
{
string strComparisonOp_ExcellentYear = objcc_Course_Cond.dicFldComparisonOp[concc_Course.ExcellentYear];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Course.ExcellentYear, objcc_Course_Cond.ExcellentYear, strComparisonOp_ExcellentYear);
}
if (objcc_Course_Cond.IsUpdated(concc_Course.IsBuildingCourse) == true)
{
if (objcc_Course_Cond.IsBuildingCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_Course.IsBuildingCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_Course.IsBuildingCourse);
}
}
if (objcc_Course_Cond.IsUpdated(concc_Course.IsDoubleLanguageCourse) == true)
{
if (objcc_Course_Cond.IsDoubleLanguageCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_Course.IsDoubleLanguageCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_Course.IsDoubleLanguageCourse);
}
}
if (objcc_Course_Cond.IsUpdated(concc_Course.IsOpen) == true)
{
if (objcc_Course_Cond.IsOpen == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_Course.IsOpen);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_Course.IsOpen);
}
}
if (objcc_Course_Cond.IsUpdated(concc_Course.IsRecommendedCourse) == true)
{
if (objcc_Course_Cond.IsRecommendedCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_Course.IsRecommendedCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_Course.IsRecommendedCourse);
}
}
if (objcc_Course_Cond.IsUpdated(concc_Course.IsSelfPropelledCourse) == true)
{
if (objcc_Course_Cond.IsSelfPropelledCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_Course.IsSelfPropelledCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_Course.IsSelfPropelledCourse);
}
}
if (objcc_Course_Cond.IsUpdated(concc_Course.OperationDate) == true)
{
string strComparisonOp_OperationDate = objcc_Course_Cond.dicFldComparisonOp[concc_Course.OperationDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.OperationDate, objcc_Course_Cond.OperationDate, strComparisonOp_OperationDate);
}
if (objcc_Course_Cond.IsUpdated(concc_Course.OrderNum) == true)
{
string strComparisonOp_OrderNum = objcc_Course_Cond.dicFldComparisonOp[concc_Course.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Course.OrderNum, objcc_Course_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objcc_Course_Cond.IsUpdated(concc_Course.OuterLink) == true)
{
string strComparisonOp_OuterLink = objcc_Course_Cond.dicFldComparisonOp[concc_Course.OuterLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.OuterLink, objcc_Course_Cond.OuterLink, strComparisonOp_OuterLink);
}
if (objcc_Course_Cond.IsUpdated(concc_Course.ViewCount) == true)
{
string strComparisonOp_ViewCount = objcc_Course_Cond.dicFldComparisonOp[concc_Course.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Course.ViewCount, objcc_Course_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objcc_Course_Cond.IsUpdated(concc_Course.ThemeId) == true)
{
string strComparisonOp_ThemeId = objcc_Course_Cond.dicFldComparisonOp[concc_Course.ThemeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.ThemeId, objcc_Course_Cond.ThemeId, strComparisonOp_ThemeId);
}
if (objcc_Course_Cond.IsUpdated(concc_Course.id_School) == true)
{
string strComparisonOp_id_School = objcc_Course_Cond.dicFldComparisonOp[concc_Course.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.id_School, objcc_Course_Cond.id_School, strComparisonOp_id_School);
}
if (objcc_Course_Cond.IsUpdated(concc_Course.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objcc_Course_Cond.dicFldComparisonOp[concc_Course.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.id_XzMajor, objcc_Course_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objcc_Course_Cond.IsUpdated(concc_Course.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objcc_Course_Cond.dicFldComparisonOp[concc_Course.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.id_XzCollege, objcc_Course_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objcc_Course_Cond.IsUpdated(concc_Course.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_Course_Cond.dicFldComparisonOp[concc_Course.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.UpdDate, objcc_Course_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_Course_Cond.IsUpdated(concc_Course.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objcc_Course_Cond.dicFldComparisonOp[concc_Course.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.UpdUserId, objcc_Course_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objcc_Course_Cond.IsUpdated(concc_Course.Memo) == true)
{
string strComparisonOp_Memo = objcc_Course_Cond.dicFldComparisonOp[concc_Course.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.Memo, objcc_Course_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseEN objcc_CourseEN)
{
 if (string.IsNullOrEmpty(objcc_CourseEN.CourseId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_CourseEN.sf_UpdFldSetStr = objcc_CourseEN.getsf_UpdFldSetStr();
clscc_CourseWApi.CheckPropertyNew(objcc_CourseEN); 
bool bolResult = clscc_CourseWApi.UpdateRecord(objcc_CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_Course(课程), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_CourseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_CourseId(this clscc_CourseEN objcc_CourseEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseEN == null) return "";
if (objcc_CourseEN.CourseId == null || objcc_CourseEN.CourseId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseEN.CourseId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CourseId !=  '{0}'", objcc_CourseEN.CourseId);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseEN.CourseId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_CourseEN objcc_CourseEN)
{
try
{
 if (string.IsNullOrEmpty(objcc_CourseEN.CourseId) == true || clscc_CourseWApi.IsExist(objcc_CourseEN.CourseId) == true)
 {
     objcc_CourseEN.CourseId = clscc_CourseWApi.GetMaxStrId();
 }
clscc_CourseWApi.CheckPropertyNew(objcc_CourseEN); 
bool bolResult = clscc_CourseWApi.AddNewRecord(objcc_CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscc_CourseEN objcc_CourseEN)
{
try
{
clscc_CourseWApi.CheckPropertyNew(objcc_CourseEN); 
string strCourseId = clscc_CourseWApi.AddNewRecordWithMaxId(objcc_CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseWApi.ReFreshCache();
return strCourseId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseEN objcc_CourseEN, string strWhereCond)
{
try
{
clscc_CourseWApi.CheckPropertyNew(objcc_CourseEN); 
bool bolResult = clscc_CourseWApi.UpdateWithCondition(objcc_CourseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 课程(cc_Course)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_CourseWApi
{
private static readonly string mstrApiControllerName = "cc_CourseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clscc_CourseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CourseId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[课程]...","0");
List<clscc_CourseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="CourseId";
objDDL.DataTextField="CourseName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_CourseId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", concc_Course.CourseId); 
List<clscc_CourseEN> arrObjLst = clscc_CourseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clscc_CourseEN objcc_CourseEN = new clscc_CourseEN()
{
CourseId = "0",
CourseName = "选[课程]..."
};
arrObjLst.Insert(0, objcc_CourseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = concc_Course.CourseId;
objComboBox.DisplayMember = concc_Course.CourseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_CourseEN objcc_CourseEN)
{
if (!Object.Equals(null, objcc_CourseEN.CourseId) && GetStrLen(objcc_CourseEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseEN.CourseCode) && GetStrLen(objcc_CourseEN.CourseCode) > 20)
{
 throw new Exception("字段[课程代码]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseEN.CourseDescription) && GetStrLen(objcc_CourseEN.CourseDescription) > 8000)
{
 throw new Exception("字段[课程描述]的长度不能超过8000!");
}
if (!Object.Equals(null, objcc_CourseEN.CourseName) && GetStrLen(objcc_CourseEN.CourseName) > 100)
{
 throw new Exception("字段[课程名称]的长度不能超过100!");
}
if (!Object.Equals(null, objcc_CourseEN.CourseTypeID) && GetStrLen(objcc_CourseEN.CourseTypeID) > 4)
{
 throw new Exception("字段[课程类型ID]的长度不能超过4!");
}
if (!Object.Equals(null, objcc_CourseEN.CreateDate) && GetStrLen(objcc_CourseEN.CreateDate) > 20)
{
 throw new Exception("字段[建立日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseEN.ExcellentTypeId) && GetStrLen(objcc_CourseEN.ExcellentTypeId) > 4)
{
 throw new Exception("字段[精品课程类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objcc_CourseEN.OperationDate) && GetStrLen(objcc_CourseEN.OperationDate) > 20)
{
 throw new Exception("字段[操作时间]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseEN.OuterLink) && GetStrLen(objcc_CourseEN.OuterLink) > 500)
{
 throw new Exception("字段[外链地址]的长度不能超过500!");
}
if (!Object.Equals(null, objcc_CourseEN.ThemeId) && GetStrLen(objcc_CourseEN.ThemeId) > 4)
{
 throw new Exception("字段[主题Id]的长度不能超过4!");
}
if (!Object.Equals(null, objcc_CourseEN.id_School) && GetStrLen(objcc_CourseEN.id_School) > 4)
{
 throw new Exception("字段[学校流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objcc_CourseEN.id_XzMajor) && GetStrLen(objcc_CourseEN.id_XzMajor) > 8)
{
 throw new Exception("字段[专业流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseEN.id_XzCollege) && GetStrLen(objcc_CourseEN.id_XzCollege) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objcc_CourseEN.UpdDate) && GetStrLen(objcc_CourseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseEN.UpdUserId) && GetStrLen(objcc_CourseEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseEN.Memo) && GetStrLen(objcc_CourseEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_CourseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseEN GetObjByCourseId(string strCourseId)
{
string strAction = "GetObjByCourseId";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseEN objcc_CourseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_CourseEN = JsonConvert.DeserializeObject<clscc_CourseEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseEN;
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
 /// <param name = "strCourseId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseEN GetObjByCourseId_WA_Cache(string strCourseId)
{
string strAction = "GetObjByCourseId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseEN objcc_CourseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_CourseEN = JsonConvert.DeserializeObject<clscc_CourseEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseEN;
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
public static clscc_CourseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseEN objcc_CourseEN = null;
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
objcc_CourseEN = JsonConvert.DeserializeObject<clscc_CourseEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseEN;
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
 /// <param name = "strCourseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseEN GetObjByCourseId_Cache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clscc_CourseEN._CurrTabName_S);
List<clscc_CourseEN> arrcc_CourseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_CourseEN> arrcc_CourseObjLst_Sel =
from objcc_CourseEN in arrcc_CourseObjLst_Cache
where objcc_CourseEN.CourseId == strCourseId
select objcc_CourseEN;
if (arrcc_CourseObjLst_Sel.Count() == 0)
{
   clscc_CourseEN obj = clscc_CourseWApi.GetObjByCourseId(strCourseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_CourseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strCourseId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCourseNameByCourseId_Cache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clscc_CourseEN._CurrTabName_S);
List<clscc_CourseEN> arrcc_CourseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_CourseEN> arrcc_CourseObjLst_Sel1 =
from objcc_CourseEN in arrcc_CourseObjLst_Cache
where objcc_CourseEN.CourseId == strCourseId
select objcc_CourseEN;
List <clscc_CourseEN> arrcc_CourseObjLst_Sel = new List<clscc_CourseEN>();
foreach (clscc_CourseEN obj in arrcc_CourseObjLst_Sel1)
{
arrcc_CourseObjLst_Sel.Add(obj);
}
if (arrcc_CourseObjLst_Sel.Count > 0)
{
return arrcc_CourseObjLst_Sel[0].CourseName;
}
string strErrMsgForGetObjById = string.Format("在cc_Course对象缓存列表中,找不到记录[CourseId = {0}](函数:{1})", strCourseId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clscc_CourseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strCourseId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCourseId_Cache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clscc_CourseEN._CurrTabName_S);
List<clscc_CourseEN> arrcc_CourseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_CourseEN> arrcc_CourseObjLst_Sel1 =
from objcc_CourseEN in arrcc_CourseObjLst_Cache
where objcc_CourseEN.CourseId == strCourseId
select objcc_CourseEN;
List <clscc_CourseEN> arrcc_CourseObjLst_Sel = new List<clscc_CourseEN>();
foreach (clscc_CourseEN obj in arrcc_CourseObjLst_Sel1)
{
arrcc_CourseObjLst_Sel.Add(obj);
}
if (arrcc_CourseObjLst_Sel.Count > 0)
{
return arrcc_CourseObjLst_Sel[0].CourseName;
}
string strErrMsgForGetObjById = string.Format("在cc_Course对象缓存列表中,找不到记录的相关名称[CourseId = {0}](函数:{1})", strCourseId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clscc_CourseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseEN> GetObjLst(string strWhereCond)
{
 List<clscc_CourseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseEN> GetObjLstByCourseIdLst(List<string> arrCourseId)
{
 List<clscc_CourseEN> arrObjLst = null; 
string strAction = "GetObjLstByCourseIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strCourseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clscc_CourseEN> GetObjLstByCourseIdLst_Cache(List<string> arrCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_CourseEN._CurrTabName_S);
List<clscc_CourseEN> arrcc_CourseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_CourseEN> arrcc_CourseObjLst_Sel =
from objcc_CourseEN in arrcc_CourseObjLst_Cache
where arrCourseId.Contains(objcc_CourseEN.CourseId)
select objcc_CourseEN;
return arrcc_CourseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseEN> GetObjLstByCourseIdLst_WA_Cache(List<string> arrCourseId)
{
 List<clscc_CourseEN> arrObjLst = null; 
string strAction = "GetObjLstByCourseIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_CourseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_CourseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_CourseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_CourseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strCourseId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_CourseEN objcc_CourseEN = clscc_CourseWApi.GetObjByCourseId(strCourseId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strCourseId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_CourseWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int Delcc_Courses(List<string> arrCourseId)
{
string strAction = "Delcc_Courses";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_CourseWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int Delcc_CoursesByCond(string strWhereCond)
{
string strAction = "Delcc_CoursesByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clscc_CourseEN objcc_CourseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseEN>(objcc_CourseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clscc_CourseEN objcc_CourseEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseEN>(objcc_CourseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseWApi.ReFreshCache();
var strCourseId = (string)jobjReturn["ReturnStr"];
return strCourseId;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clscc_CourseEN objcc_CourseEN)
{
if (string.IsNullOrEmpty(objcc_CourseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseEN.CourseId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseEN>(objcc_CourseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_CourseEN objcc_CourseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_CourseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseEN.CourseId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseEN.CourseId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseEN>(objcc_CourseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
public static bool IsExist(string strCourseId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objcc_CourseENS">源对象</param>
 /// <param name = "objcc_CourseENT">目标对象</param>
 public static void CopyTo(clscc_CourseEN objcc_CourseENS, clscc_CourseEN objcc_CourseENT)
{
try
{
objcc_CourseENT.CourseId = objcc_CourseENS.CourseId; //课程Id
objcc_CourseENT.CourseCode = objcc_CourseENS.CourseCode; //课程代码
objcc_CourseENT.CourseDescription = objcc_CourseENS.CourseDescription; //课程描述
objcc_CourseENT.CourseName = objcc_CourseENS.CourseName; //课程名称
objcc_CourseENT.CourseTypeID = objcc_CourseENS.CourseTypeID; //课程类型ID
objcc_CourseENT.CreateDate = objcc_CourseENS.CreateDate; //建立日期
objcc_CourseENT.ExcellentTypeId = objcc_CourseENS.ExcellentTypeId; //精品课程类型Id
objcc_CourseENT.ExcellentYear = objcc_CourseENS.ExcellentYear; //课程年份
objcc_CourseENT.IsBuildingCourse = objcc_CourseENS.IsBuildingCourse; //是否已建设课程
objcc_CourseENT.IsDoubleLanguageCourse = objcc_CourseENS.IsDoubleLanguageCourse; //是否双语课程
objcc_CourseENT.IsOpen = objcc_CourseENS.IsOpen; //是否公开
objcc_CourseENT.IsRecommendedCourse = objcc_CourseENS.IsRecommendedCourse; //是否推荐课程
objcc_CourseENT.IsSelfPropelledCourse = objcc_CourseENS.IsSelfPropelledCourse; //是否自荐课程
objcc_CourseENT.OperationDate = objcc_CourseENS.OperationDate; //操作时间
objcc_CourseENT.OrderNum = objcc_CourseENS.OrderNum; //序号
objcc_CourseENT.OuterLink = objcc_CourseENS.OuterLink; //外链地址
objcc_CourseENT.ViewCount = objcc_CourseENS.ViewCount; //浏览量
objcc_CourseENT.ThemeId = objcc_CourseENS.ThemeId; //主题Id
objcc_CourseENT.id_School = objcc_CourseENS.id_School; //学校流水号
objcc_CourseENT.id_XzMajor = objcc_CourseENS.id_XzMajor; //专业流水号
objcc_CourseENT.id_XzCollege = objcc_CourseENS.id_XzCollege; //学院流水号
objcc_CourseENT.UpdDate = objcc_CourseENS.UpdDate; //修改日期
objcc_CourseENT.UpdUserId = objcc_CourseENS.UpdUserId; //修改用户Id
objcc_CourseENT.Memo = objcc_CourseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_CourseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_CourseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_CourseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_CourseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_CourseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_CourseEN.AttributeName)
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
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseId");
//if (arrcc_CourseObjLst_Cache == null)
//{
//arrcc_CourseObjLst_Cache = await clscc_CourseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clscc_CourseEN._CurrTabName_S);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clscc_CourseWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_CourseEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clscc_CourseWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clscc_CourseEN._CurrTabName_S);
List<clscc_CourseEN> arrcc_CourseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_CourseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_CourseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_Course.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(concc_Course.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(concc_Course.CourseDescription, Type.GetType("System.String"));
objDT.Columns.Add(concc_Course.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(concc_Course.CourseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(concc_Course.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_Course.ExcellentTypeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_Course.ExcellentYear, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_Course.IsBuildingCourse, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_Course.IsDoubleLanguageCourse, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_Course.IsOpen, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_Course.IsRecommendedCourse, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_Course.IsSelfPropelledCourse, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_Course.OperationDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_Course.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_Course.OuterLink, Type.GetType("System.String"));
objDT.Columns.Add(concc_Course.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_Course.ThemeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_Course.id_School, Type.GetType("System.String"));
objDT.Columns.Add(concc_Course.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(concc_Course.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(concc_Course.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_Course.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(concc_Course.Memo, Type.GetType("System.String"));
foreach (clscc_CourseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_Course.CourseId] = objInFor[concc_Course.CourseId];
objDR[concc_Course.CourseCode] = objInFor[concc_Course.CourseCode];
objDR[concc_Course.CourseDescription] = objInFor[concc_Course.CourseDescription];
objDR[concc_Course.CourseName] = objInFor[concc_Course.CourseName];
objDR[concc_Course.CourseTypeID] = objInFor[concc_Course.CourseTypeID];
objDR[concc_Course.CreateDate] = objInFor[concc_Course.CreateDate];
objDR[concc_Course.ExcellentTypeId] = objInFor[concc_Course.ExcellentTypeId];
objDR[concc_Course.ExcellentYear] = objInFor[concc_Course.ExcellentYear];
objDR[concc_Course.IsBuildingCourse] = objInFor[concc_Course.IsBuildingCourse];
objDR[concc_Course.IsDoubleLanguageCourse] = objInFor[concc_Course.IsDoubleLanguageCourse];
objDR[concc_Course.IsOpen] = objInFor[concc_Course.IsOpen];
objDR[concc_Course.IsRecommendedCourse] = objInFor[concc_Course.IsRecommendedCourse];
objDR[concc_Course.IsSelfPropelledCourse] = objInFor[concc_Course.IsSelfPropelledCourse];
objDR[concc_Course.OperationDate] = objInFor[concc_Course.OperationDate];
objDR[concc_Course.OrderNum] = objInFor[concc_Course.OrderNum];
objDR[concc_Course.OuterLink] = objInFor[concc_Course.OuterLink];
objDR[concc_Course.ViewCount] = objInFor[concc_Course.ViewCount];
objDR[concc_Course.ThemeId] = objInFor[concc_Course.ThemeId];
objDR[concc_Course.id_School] = objInFor[concc_Course.id_School];
objDR[concc_Course.id_XzMajor] = objInFor[concc_Course.id_XzMajor];
objDR[concc_Course.id_XzCollege] = objInFor[concc_Course.id_XzCollege];
objDR[concc_Course.UpdDate] = objInFor[concc_Course.UpdDate];
objDR[concc_Course.UpdUserId] = objInFor[concc_Course.UpdUserId];
objDR[concc_Course.Memo] = objInFor[concc_Course.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 课程(cc_Course)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_Course : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseWApi.ReFreshThisCache();
clsvcc_CourseWApi.ReFreshThisCache();
}
}

}