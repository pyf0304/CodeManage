
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseExWApi
 表名:vcc_CourseEx(01120213)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:27
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理
 模块英文名:CourseManage
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
public static class clsvcc_CourseExWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetCourseId(this clsvcc_CourseExEN objvcc_CourseExEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseEx.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseEx.CourseId);
objvcc_CourseExEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.CourseId) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.CourseId, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.CourseId] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetLikeCount(this clsvcc_CourseExEN objvcc_CourseExEN, int intLikeCount, string strComparisonOp="")
	{
objvcc_CourseExEN.LikeCount = intLikeCount; //LikeCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.LikeCount) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.LikeCount, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.LikeCount] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetCourseCode(this clsvcc_CourseExEN objvcc_CourseExEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convcc_CourseEx.CourseCode);
objvcc_CourseExEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.CourseCode) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.CourseCode, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.CourseCode] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetCourseDescription(this clsvcc_CourseExEN objvcc_CourseExEN, string strCourseDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, convcc_CourseEx.CourseDescription);
objvcc_CourseExEN.CourseDescription = strCourseDescription; //课程描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.CourseDescription) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.CourseDescription, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.CourseDescription] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetCourseName(this clsvcc_CourseExEN objvcc_CourseExEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseName, convcc_CourseEx.CourseName);
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseEx.CourseName);
objvcc_CourseExEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.CourseName) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.CourseName, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.CourseName] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetCourseTypeID(this clsvcc_CourseExEN objvcc_CourseExEN, string strCourseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, convcc_CourseEx.CourseTypeID);
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, convcc_CourseEx.CourseTypeID);
objvcc_CourseExEN.CourseTypeID = strCourseTypeID; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.CourseTypeID) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.CourseTypeID, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.CourseTypeID] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetCourseTypeName(this clsvcc_CourseExEN objvcc_CourseExEN, string strCourseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, convcc_CourseEx.CourseTypeName);
objvcc_CourseExEN.CourseTypeName = strCourseTypeName; //课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.CourseTypeName) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.CourseTypeName, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.CourseTypeName] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetCreateDate(this clsvcc_CourseExEN objvcc_CourseExEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_CourseEx.CreateDate);
objvcc_CourseExEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.CreateDate) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.CreateDate, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.CreateDate] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetExcellentTypeId(this clsvcc_CourseExEN objvcc_CourseExEN, string strExcellentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExcellentTypeId, 4, convcc_CourseEx.ExcellentTypeId);
clsCheckSql.CheckFieldForeignKey(strExcellentTypeId, 4, convcc_CourseEx.ExcellentTypeId);
objvcc_CourseExEN.ExcellentTypeId = strExcellentTypeId; //精品课程类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.ExcellentTypeId) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.ExcellentTypeId, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.ExcellentTypeId] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetExcellentTypeName(this clsvcc_CourseExEN objvcc_CourseExEN, string strExcellentTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExcellentTypeName, 30, convcc_CourseEx.ExcellentTypeName);
objvcc_CourseExEN.ExcellentTypeName = strExcellentTypeName; //精品课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.ExcellentTypeName) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.ExcellentTypeName, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.ExcellentTypeName] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetExcellentYear(this clsvcc_CourseExEN objvcc_CourseExEN, int intExcellentYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intExcellentYear, convcc_CourseEx.ExcellentYear);
objvcc_CourseExEN.ExcellentYear = intExcellentYear; //课程年份
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.ExcellentYear) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.ExcellentYear, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.ExcellentYear] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetIsBuildingCourse(this clsvcc_CourseExEN objvcc_CourseExEN, bool bolIsBuildingCourse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsBuildingCourse, convcc_CourseEx.IsBuildingCourse);
objvcc_CourseExEN.IsBuildingCourse = bolIsBuildingCourse; //是否已建设课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.IsBuildingCourse) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.IsBuildingCourse, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.IsBuildingCourse] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetIsDoubleLanguageCourse(this clsvcc_CourseExEN objvcc_CourseExEN, bool bolIsDoubleLanguageCourse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDoubleLanguageCourse, convcc_CourseEx.IsDoubleLanguageCourse);
objvcc_CourseExEN.IsDoubleLanguageCourse = bolIsDoubleLanguageCourse; //是否双语课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.IsDoubleLanguageCourse) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.IsDoubleLanguageCourse, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.IsDoubleLanguageCourse] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetIsOpen(this clsvcc_CourseExEN objvcc_CourseExEN, bool bolIsOpen, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsOpen, convcc_CourseEx.IsOpen);
objvcc_CourseExEN.IsOpen = bolIsOpen; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.IsOpen) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.IsOpen, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.IsOpen] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetIsRecommendedCourse(this clsvcc_CourseExEN objvcc_CourseExEN, bool bolIsRecommendedCourse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsRecommendedCourse, convcc_CourseEx.IsRecommendedCourse);
objvcc_CourseExEN.IsRecommendedCourse = bolIsRecommendedCourse; //是否推荐课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.IsRecommendedCourse) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.IsRecommendedCourse, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.IsRecommendedCourse] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetIsSelfPropelledCourse(this clsvcc_CourseExEN objvcc_CourseExEN, bool bolIsSelfPropelledCourse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsSelfPropelledCourse, convcc_CourseEx.IsSelfPropelledCourse);
objvcc_CourseExEN.IsSelfPropelledCourse = bolIsSelfPropelledCourse; //是否自荐课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.IsSelfPropelledCourse) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.IsSelfPropelledCourse, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.IsSelfPropelledCourse] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetOperationDate(this clsvcc_CourseExEN objvcc_CourseExEN, string strOperationDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOperationDate, 20, convcc_CourseEx.OperationDate);
objvcc_CourseExEN.OperationDate = strOperationDate; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.OperationDate) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.OperationDate, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.OperationDate] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetOrderNum(this clsvcc_CourseExEN objvcc_CourseExEN, int intOrderNum, string strComparisonOp="")
	{
objvcc_CourseExEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.OrderNum) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.OrderNum, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.OrderNum] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetOuterLink(this clsvcc_CourseExEN objvcc_CourseExEN, string strOuterLink, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOuterLink, 500, convcc_CourseEx.OuterLink);
objvcc_CourseExEN.OuterLink = strOuterLink; //外链地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.OuterLink) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.OuterLink, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.OuterLink] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetViewCount(this clsvcc_CourseExEN objvcc_CourseExEN, int intViewCount, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intViewCount, convcc_CourseEx.ViewCount);
objvcc_CourseExEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.ViewCount) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.ViewCount, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.ViewCount] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetThemeId(this clsvcc_CourseExEN objvcc_CourseExEN, string strThemeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strThemeId, 4, convcc_CourseEx.ThemeId);
clsCheckSql.CheckFieldForeignKey(strThemeId, 4, convcc_CourseEx.ThemeId);
objvcc_CourseExEN.ThemeId = strThemeId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.ThemeId) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.ThemeId, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.ThemeId] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetThemeName(this clsvcc_CourseExEN objvcc_CourseExEN, string strThemeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strThemeName, 200, convcc_CourseEx.ThemeName);
objvcc_CourseExEN.ThemeName = strThemeName; //主题名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.ThemeName) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.ThemeName, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.ThemeName] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetExampleImgPath(this clsvcc_CourseExEN objvcc_CourseExEN, string strExampleImgPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExampleImgPath, 300, convcc_CourseEx.ExampleImgPath);
objvcc_CourseExEN.ExampleImgPath = strExampleImgPath; //示例图路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.ExampleImgPath) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.ExampleImgPath, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.ExampleImgPath] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN Setid_XzMajor(this clsvcc_CourseExEN objvcc_CourseExEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convcc_CourseEx.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convcc_CourseEx.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convcc_CourseEx.id_XzMajor);
objvcc_CourseExEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.id_XzMajor) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.id_XzMajor, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.id_XzMajor] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetMajorID(this clsvcc_CourseExEN objvcc_CourseExEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convcc_CourseEx.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convcc_CourseEx.MajorID);
objvcc_CourseExEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.MajorID) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.MajorID, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.MajorID] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetMajorName(this clsvcc_CourseExEN objvcc_CourseExEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_CourseEx.MajorName);
objvcc_CourseExEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.MajorName) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.MajorName, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.MajorName] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN Setid_XzCollege(this clsvcc_CourseExEN objvcc_CourseExEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzCollege, convcc_CourseEx.id_XzCollege);
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convcc_CourseEx.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convcc_CourseEx.id_XzCollege);
objvcc_CourseExEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.id_XzCollege) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.id_XzCollege, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.id_XzCollege] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetCollegeID(this clsvcc_CourseExEN objvcc_CourseExEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convcc_CourseEx.CollegeID);
objvcc_CourseExEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.CollegeID) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.CollegeID, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.CollegeID] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetCollegeName(this clsvcc_CourseExEN objvcc_CourseExEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_CourseEx.CollegeName);
objvcc_CourseExEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.CollegeName) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.CollegeName, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.CollegeName] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetCollegeNameA(this clsvcc_CourseExEN objvcc_CourseExEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_CourseEx.CollegeNameA);
objvcc_CourseExEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.CollegeNameA) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.CollegeNameA, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.CollegeNameA] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetMemo(this clsvcc_CourseExEN objvcc_CourseExEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseEx.Memo);
objvcc_CourseExEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.Memo) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.Memo, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.Memo] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetQuestionNum(this clsvcc_CourseExEN objvcc_CourseExEN, int intQuestionNum, string strComparisonOp="")
	{
objvcc_CourseExEN.QuestionNum = intQuestionNum; //题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.QuestionNum) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.QuestionNum, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.QuestionNum] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetKnowledgesNum(this clsvcc_CourseExEN objvcc_CourseExEN, int intKnowledgesNum, string strComparisonOp="")
	{
objvcc_CourseExEN.KnowledgesNum = intKnowledgesNum; //知识点数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.KnowledgesNum) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.KnowledgesNum, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.KnowledgesNum] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetTeacherNum(this clsvcc_CourseExEN objvcc_CourseExEN, int intTeacherNum, string strComparisonOp="")
	{
objvcc_CourseExEN.TeacherNum = intTeacherNum; //教师数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.TeacherNum) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.TeacherNum, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.TeacherNum] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseExEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseExEN SetChapterNum(this clsvcc_CourseExEN objvcc_CourseExEN, int intChapterNum, string strComparisonOp="")
	{
objvcc_CourseExEN.ChapterNum = intChapterNum; //章节数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseExEN.dicFldComparisonOp.ContainsKey(convcc_CourseEx.ChapterNum) == false)
{
objvcc_CourseExEN.dicFldComparisonOp.Add(convcc_CourseEx.ChapterNum, strComparisonOp);
}
else
{
objvcc_CourseExEN.dicFldComparisonOp[convcc_CourseEx.ChapterNum] = strComparisonOp;
}
}
return objvcc_CourseExEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseExEN objvcc_CourseEx_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.CourseId, objvcc_CourseEx_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseEx.LikeCount, objvcc_CourseEx_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.CourseCode, objvcc_CourseEx_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.CourseDescription) == true)
{
string strComparisonOp_CourseDescription = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.CourseDescription, objvcc_CourseEx_Cond.CourseDescription, strComparisonOp_CourseDescription);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.CourseName, objvcc_CourseEx_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.CourseTypeID) == true)
{
string strComparisonOp_CourseTypeID = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.CourseTypeID, objvcc_CourseEx_Cond.CourseTypeID, strComparisonOp_CourseTypeID);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.CourseTypeName) == true)
{
string strComparisonOp_CourseTypeName = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.CourseTypeName, objvcc_CourseEx_Cond.CourseTypeName, strComparisonOp_CourseTypeName);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.CreateDate) == true)
{
string strComparisonOp_CreateDate = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.CreateDate, objvcc_CourseEx_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.ExcellentTypeId) == true)
{
string strComparisonOp_ExcellentTypeId = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.ExcellentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.ExcellentTypeId, objvcc_CourseEx_Cond.ExcellentTypeId, strComparisonOp_ExcellentTypeId);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.ExcellentTypeName) == true)
{
string strComparisonOp_ExcellentTypeName = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.ExcellentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.ExcellentTypeName, objvcc_CourseEx_Cond.ExcellentTypeName, strComparisonOp_ExcellentTypeName);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.ExcellentYear) == true)
{
string strComparisonOp_ExcellentYear = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.ExcellentYear];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseEx.ExcellentYear, objvcc_CourseEx_Cond.ExcellentYear, strComparisonOp_ExcellentYear);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.IsBuildingCourse) == true)
{
if (objvcc_CourseEx_Cond.IsBuildingCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseEx.IsBuildingCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseEx.IsBuildingCourse);
}
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.IsDoubleLanguageCourse) == true)
{
if (objvcc_CourseEx_Cond.IsDoubleLanguageCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseEx.IsDoubleLanguageCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseEx.IsDoubleLanguageCourse);
}
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.IsOpen) == true)
{
if (objvcc_CourseEx_Cond.IsOpen == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseEx.IsOpen);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseEx.IsOpen);
}
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.IsRecommendedCourse) == true)
{
if (objvcc_CourseEx_Cond.IsRecommendedCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseEx.IsRecommendedCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseEx.IsRecommendedCourse);
}
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.IsSelfPropelledCourse) == true)
{
if (objvcc_CourseEx_Cond.IsSelfPropelledCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseEx.IsSelfPropelledCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseEx.IsSelfPropelledCourse);
}
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.OperationDate) == true)
{
string strComparisonOp_OperationDate = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.OperationDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.OperationDate, objvcc_CourseEx_Cond.OperationDate, strComparisonOp_OperationDate);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseEx.OrderNum, objvcc_CourseEx_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.OuterLink) == true)
{
string strComparisonOp_OuterLink = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.OuterLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.OuterLink, objvcc_CourseEx_Cond.OuterLink, strComparisonOp_OuterLink);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseEx.ViewCount, objvcc_CourseEx_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.ThemeId) == true)
{
string strComparisonOp_ThemeId = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.ThemeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.ThemeId, objvcc_CourseEx_Cond.ThemeId, strComparisonOp_ThemeId);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.ThemeName) == true)
{
string strComparisonOp_ThemeName = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.ThemeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.ThemeName, objvcc_CourseEx_Cond.ThemeName, strComparisonOp_ThemeName);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.ExampleImgPath) == true)
{
string strComparisonOp_ExampleImgPath = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.ExampleImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.ExampleImgPath, objvcc_CourseEx_Cond.ExampleImgPath, strComparisonOp_ExampleImgPath);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.id_XzMajor, objvcc_CourseEx_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.MajorID) == true)
{
string strComparisonOp_MajorID = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.MajorID, objvcc_CourseEx_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.MajorName) == true)
{
string strComparisonOp_MajorName = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.MajorName, objvcc_CourseEx_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.id_XzCollege, objvcc_CourseEx_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.CollegeID, objvcc_CourseEx_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.CollegeName, objvcc_CourseEx_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.CollegeNameA, objvcc_CourseEx_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.Memo) == true)
{
string strComparisonOp_Memo = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseEx.Memo, objvcc_CourseEx_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.QuestionNum) == true)
{
string strComparisonOp_QuestionNum = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.QuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseEx.QuestionNum, objvcc_CourseEx_Cond.QuestionNum, strComparisonOp_QuestionNum);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.KnowledgesNum) == true)
{
string strComparisonOp_KnowledgesNum = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.KnowledgesNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseEx.KnowledgesNum, objvcc_CourseEx_Cond.KnowledgesNum, strComparisonOp_KnowledgesNum);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.TeacherNum) == true)
{
string strComparisonOp_TeacherNum = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.TeacherNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseEx.TeacherNum, objvcc_CourseEx_Cond.TeacherNum, strComparisonOp_TeacherNum);
}
if (objvcc_CourseEx_Cond.IsUpdated(convcc_CourseEx.ChapterNum) == true)
{
string strComparisonOp_ChapterNum = objvcc_CourseEx_Cond.dicFldComparisonOp[convcc_CourseEx.ChapterNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseEx.ChapterNum, objvcc_CourseEx_Cond.ChapterNum, strComparisonOp_ChapterNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程Ex(vcc_CourseEx)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseExWApi
{
private static readonly string mstrApiControllerName = "vcc_CourseExApi";

 public clsvcc_CourseExWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseExEN GetObjByCourseId(string strCourseId)
{
string strAction = "GetObjByCourseId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseExEN objvcc_CourseExEN = null;
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
objvcc_CourseExEN = JsonConvert.DeserializeObject<clsvcc_CourseExEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseExEN;
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
public static clsvcc_CourseExEN GetObjByCourseId_WA_Cache(string strCourseId)
{
string strAction = "GetObjByCourseId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseExEN objvcc_CourseExEN = null;
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
objvcc_CourseExEN = JsonConvert.DeserializeObject<clsvcc_CourseExEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseExEN;
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
public static clsvcc_CourseExEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseExEN objvcc_CourseExEN = null;
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
objvcc_CourseExEN = JsonConvert.DeserializeObject<clsvcc_CourseExEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseExEN;
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
public static clsvcc_CourseExEN GetObjByCourseId_Cache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_CourseExEN._CurrTabName_S);
List<clsvcc_CourseExEN> arrvcc_CourseExObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_CourseExEN> arrvcc_CourseExObjLst_Sel =
from objvcc_CourseExEN in arrvcc_CourseExObjLst_Cache
where objvcc_CourseExEN.CourseId == strCourseId
select objvcc_CourseExEN;
if (arrvcc_CourseExObjLst_Sel.Count() == 0)
{
   clsvcc_CourseExEN obj = clsvcc_CourseExWApi.GetObjByCourseId(strCourseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_CourseExObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseExEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_CourseExEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExEN> GetObjLstByCourseIdLst(List<string> arrCourseId)
{
 List<clsvcc_CourseExEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvcc_CourseExEN> GetObjLstByCourseIdLst_Cache(List<string> arrCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_CourseExEN._CurrTabName_S);
List<clsvcc_CourseExEN> arrvcc_CourseExObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_CourseExEN> arrvcc_CourseExObjLst_Sel =
from objvcc_CourseExEN in arrvcc_CourseExObjLst_Cache
where arrCourseId.Contains(objvcc_CourseExEN.CourseId)
select objvcc_CourseExEN;
return arrvcc_CourseExObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseExEN> GetObjLstByCourseIdLst_WA_Cache(List<string> arrCourseId)
{
 List<clsvcc_CourseExEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_CourseExEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_CourseExEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseExEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseExEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseExEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseExEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvcc_CourseExENS">源对象</param>
 /// <param name = "objvcc_CourseExENT">目标对象</param>
 public static void CopyTo(clsvcc_CourseExEN objvcc_CourseExENS, clsvcc_CourseExEN objvcc_CourseExENT)
{
try
{
objvcc_CourseExENT.CourseId = objvcc_CourseExENS.CourseId; //课程Id
objvcc_CourseExENT.LikeCount = objvcc_CourseExENS.LikeCount; //LikeCount
objvcc_CourseExENT.CourseCode = objvcc_CourseExENS.CourseCode; //课程代码
objvcc_CourseExENT.CourseDescription = objvcc_CourseExENS.CourseDescription; //课程描述
objvcc_CourseExENT.CourseName = objvcc_CourseExENS.CourseName; //课程名称
objvcc_CourseExENT.CourseTypeID = objvcc_CourseExENS.CourseTypeID; //课程类型ID
objvcc_CourseExENT.CourseTypeName = objvcc_CourseExENS.CourseTypeName; //课程类型名称
objvcc_CourseExENT.CreateDate = objvcc_CourseExENS.CreateDate; //建立日期
objvcc_CourseExENT.ExcellentTypeId = objvcc_CourseExENS.ExcellentTypeId; //精品课程类型Id
objvcc_CourseExENT.ExcellentTypeName = objvcc_CourseExENS.ExcellentTypeName; //精品课程类型名称
objvcc_CourseExENT.ExcellentYear = objvcc_CourseExENS.ExcellentYear; //课程年份
objvcc_CourseExENT.IsBuildingCourse = objvcc_CourseExENS.IsBuildingCourse; //是否已建设课程
objvcc_CourseExENT.IsDoubleLanguageCourse = objvcc_CourseExENS.IsDoubleLanguageCourse; //是否双语课程
objvcc_CourseExENT.IsOpen = objvcc_CourseExENS.IsOpen; //是否公开
objvcc_CourseExENT.IsRecommendedCourse = objvcc_CourseExENS.IsRecommendedCourse; //是否推荐课程
objvcc_CourseExENT.IsSelfPropelledCourse = objvcc_CourseExENS.IsSelfPropelledCourse; //是否自荐课程
objvcc_CourseExENT.OperationDate = objvcc_CourseExENS.OperationDate; //操作时间
objvcc_CourseExENT.OrderNum = objvcc_CourseExENS.OrderNum; //序号
objvcc_CourseExENT.OuterLink = objvcc_CourseExENS.OuterLink; //外链地址
objvcc_CourseExENT.ViewCount = objvcc_CourseExENS.ViewCount; //浏览量
objvcc_CourseExENT.ThemeId = objvcc_CourseExENS.ThemeId; //主题Id
objvcc_CourseExENT.ThemeName = objvcc_CourseExENS.ThemeName; //主题名
objvcc_CourseExENT.ExampleImgPath = objvcc_CourseExENS.ExampleImgPath; //示例图路径
objvcc_CourseExENT.id_XzMajor = objvcc_CourseExENS.id_XzMajor; //专业流水号
objvcc_CourseExENT.MajorID = objvcc_CourseExENS.MajorID; //专业ID
objvcc_CourseExENT.MajorName = objvcc_CourseExENS.MajorName; //专业名称
objvcc_CourseExENT.id_XzCollege = objvcc_CourseExENS.id_XzCollege; //学院流水号
objvcc_CourseExENT.CollegeID = objvcc_CourseExENS.CollegeID; //学院ID
objvcc_CourseExENT.CollegeName = objvcc_CourseExENS.CollegeName; //学院名称
objvcc_CourseExENT.CollegeNameA = objvcc_CourseExENS.CollegeNameA; //学院名称简写
objvcc_CourseExENT.Memo = objvcc_CourseExENS.Memo; //备注
objvcc_CourseExENT.QuestionNum = objvcc_CourseExENS.QuestionNum; //题目数
objvcc_CourseExENT.KnowledgesNum = objvcc_CourseExENS.KnowledgesNum; //知识点数
objvcc_CourseExENT.TeacherNum = objvcc_CourseExENS.TeacherNum; //教师数
objvcc_CourseExENT.ChapterNum = objvcc_CourseExENS.ChapterNum; //章节数
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
public static DataTable ToDataTable(List<clsvcc_CourseExEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_CourseExEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_CourseExEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_CourseExEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_CourseExEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_CourseExEN.AttributeName)
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
//string strWhereCond = string.Format("1 = 1 order by CourseId");
//if (arrvcc_CourseExObjLst_Cache == null)
//{
//arrvcc_CourseExObjLst_Cache = await clsvcc_CourseExWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_CourseExEN._CurrTabName_S);
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
public static List<clsvcc_CourseExEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_CourseExEN._CurrTabName_S);
List<clsvcc_CourseExEN> arrvcc_CourseExObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_CourseExObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_CourseExEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_CourseEx.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.LikeCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseEx.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.CourseDescription, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.CourseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.CourseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.ExcellentTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.ExcellentTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.ExcellentYear, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseEx.IsBuildingCourse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseEx.IsDoubleLanguageCourse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseEx.IsOpen, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseEx.IsRecommendedCourse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseEx.IsSelfPropelledCourse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseEx.OperationDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseEx.OuterLink, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseEx.ThemeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.ThemeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.ExampleImgPath, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseEx.QuestionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseEx.KnowledgesNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseEx.TeacherNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseEx.ChapterNum, Type.GetType("System.Int32"));
foreach (clsvcc_CourseExEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_CourseEx.CourseId] = objInFor[convcc_CourseEx.CourseId];
objDR[convcc_CourseEx.LikeCount] = objInFor[convcc_CourseEx.LikeCount];
objDR[convcc_CourseEx.CourseCode] = objInFor[convcc_CourseEx.CourseCode];
objDR[convcc_CourseEx.CourseDescription] = objInFor[convcc_CourseEx.CourseDescription];
objDR[convcc_CourseEx.CourseName] = objInFor[convcc_CourseEx.CourseName];
objDR[convcc_CourseEx.CourseTypeID] = objInFor[convcc_CourseEx.CourseTypeID];
objDR[convcc_CourseEx.CourseTypeName] = objInFor[convcc_CourseEx.CourseTypeName];
objDR[convcc_CourseEx.CreateDate] = objInFor[convcc_CourseEx.CreateDate];
objDR[convcc_CourseEx.ExcellentTypeId] = objInFor[convcc_CourseEx.ExcellentTypeId];
objDR[convcc_CourseEx.ExcellentTypeName] = objInFor[convcc_CourseEx.ExcellentTypeName];
objDR[convcc_CourseEx.ExcellentYear] = objInFor[convcc_CourseEx.ExcellentYear];
objDR[convcc_CourseEx.IsBuildingCourse] = objInFor[convcc_CourseEx.IsBuildingCourse];
objDR[convcc_CourseEx.IsDoubleLanguageCourse] = objInFor[convcc_CourseEx.IsDoubleLanguageCourse];
objDR[convcc_CourseEx.IsOpen] = objInFor[convcc_CourseEx.IsOpen];
objDR[convcc_CourseEx.IsRecommendedCourse] = objInFor[convcc_CourseEx.IsRecommendedCourse];
objDR[convcc_CourseEx.IsSelfPropelledCourse] = objInFor[convcc_CourseEx.IsSelfPropelledCourse];
objDR[convcc_CourseEx.OperationDate] = objInFor[convcc_CourseEx.OperationDate];
objDR[convcc_CourseEx.OrderNum] = objInFor[convcc_CourseEx.OrderNum];
objDR[convcc_CourseEx.OuterLink] = objInFor[convcc_CourseEx.OuterLink];
objDR[convcc_CourseEx.ViewCount] = objInFor[convcc_CourseEx.ViewCount];
objDR[convcc_CourseEx.ThemeId] = objInFor[convcc_CourseEx.ThemeId];
objDR[convcc_CourseEx.ThemeName] = objInFor[convcc_CourseEx.ThemeName];
objDR[convcc_CourseEx.ExampleImgPath] = objInFor[convcc_CourseEx.ExampleImgPath];
objDR[convcc_CourseEx.id_XzMajor] = objInFor[convcc_CourseEx.id_XzMajor];
objDR[convcc_CourseEx.MajorID] = objInFor[convcc_CourseEx.MajorID];
objDR[convcc_CourseEx.MajorName] = objInFor[convcc_CourseEx.MajorName];
objDR[convcc_CourseEx.id_XzCollege] = objInFor[convcc_CourseEx.id_XzCollege];
objDR[convcc_CourseEx.CollegeID] = objInFor[convcc_CourseEx.CollegeID];
objDR[convcc_CourseEx.CollegeName] = objInFor[convcc_CourseEx.CollegeName];
objDR[convcc_CourseEx.CollegeNameA] = objInFor[convcc_CourseEx.CollegeNameA];
objDR[convcc_CourseEx.Memo] = objInFor[convcc_CourseEx.Memo];
objDR[convcc_CourseEx.QuestionNum] = objInFor[convcc_CourseEx.QuestionNum];
objDR[convcc_CourseEx.KnowledgesNum] = objInFor[convcc_CourseEx.KnowledgesNum];
objDR[convcc_CourseEx.TeacherNum] = objInFor[convcc_CourseEx.TeacherNum];
objDR[convcc_CourseEx.ChapterNum] = objInFor[convcc_CourseEx.ChapterNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}