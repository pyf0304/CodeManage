
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseWApi
 表名:vcc_Course(01120058)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:07
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
public static class clsvcc_CourseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetCourseId(this clsvcc_CourseEN objvcc_CourseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_Course.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_Course.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetLikeCount(this clsvcc_CourseEN objvcc_CourseEN, int intLikeCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetCourseCode(this clsvcc_CourseEN objvcc_CourseEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convcc_Course.CourseCode);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetCourseDescription(this clsvcc_CourseEN objvcc_CourseEN, string strCourseDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, convcc_Course.CourseDescription);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetCourseName(this clsvcc_CourseEN objvcc_CourseEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_Course.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetCourseTypeID(this clsvcc_CourseEN objvcc_CourseEN, string strCourseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseTypeID, convcc_Course.CourseTypeID);
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, convcc_Course.CourseTypeID);
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, convcc_Course.CourseTypeID);
objvcc_CourseEN.CourseTypeID = strCourseTypeID; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.CourseTypeID) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.CourseTypeID, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.CourseTypeID] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetCourseTypeName(this clsvcc_CourseEN objvcc_CourseEN, string strCourseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseTypeName, convcc_Course.CourseTypeName);
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, convcc_Course.CourseTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetCreateDate(this clsvcc_CourseEN objvcc_CourseEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_Course.CreateDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetExcellentTypeId(this clsvcc_CourseEN objvcc_CourseEN, string strExcellentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExcellentTypeId, 4, convcc_Course.ExcellentTypeId);
clsCheckSql.CheckFieldForeignKey(strExcellentTypeId, 4, convcc_Course.ExcellentTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetExcellentTypeName(this clsvcc_CourseEN objvcc_CourseEN, string strExcellentTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExcellentTypeName, 30, convcc_Course.ExcellentTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetExcellentYear(this clsvcc_CourseEN objvcc_CourseEN, int intExcellentYear, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetOperationDate(this clsvcc_CourseEN objvcc_CourseEN, string strOperationDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOperationDate, 20, convcc_Course.OperationDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetOrderNum(this clsvcc_CourseEN objvcc_CourseEN, int intOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetOuterLink(this clsvcc_CourseEN objvcc_CourseEN, string strOuterLink, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOuterLink, 500, convcc_Course.OuterLink);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetViewCount(this clsvcc_CourseEN objvcc_CourseEN, int intViewCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetThemeId(this clsvcc_CourseEN objvcc_CourseEN, string strThemeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strThemeId, 4, convcc_Course.ThemeId);
clsCheckSql.CheckFieldForeignKey(strThemeId, 4, convcc_Course.ThemeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetThemeName(this clsvcc_CourseEN objvcc_CourseEN, string strThemeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strThemeName, 200, convcc_Course.ThemeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetExampleImgPath(this clsvcc_CourseEN objvcc_CourseEN, string strExampleImgPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExampleImgPath, 300, convcc_Course.ExampleImgPath);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN Setid_XzMajor(this clsvcc_CourseEN objvcc_CourseEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convcc_Course.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convcc_Course.id_XzMajor);
objvcc_CourseEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.id_XzMajor) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.id_XzMajor, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.id_XzMajor] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetMajorID(this clsvcc_CourseEN objvcc_CourseEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convcc_Course.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convcc_Course.MajorID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetMajorName(this clsvcc_CourseEN objvcc_CourseEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convcc_Course.MajorName);
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_Course.MajorName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN Setid_XzCollege(this clsvcc_CourseEN objvcc_CourseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzCollege, convcc_Course.id_XzCollege);
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convcc_Course.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convcc_Course.id_XzCollege);
objvcc_CourseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.id_XzCollege) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.id_XzCollege, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.id_XzCollege] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetCollegeID(this clsvcc_CourseEN objvcc_CourseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convcc_Course.CollegeID);
objvcc_CourseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseEN.dicFldComparisonOp.ContainsKey(convcc_Course.CollegeID) == false)
{
objvcc_CourseEN.dicFldComparisonOp.Add(convcc_Course.CollegeID, strComparisonOp);
}
else
{
objvcc_CourseEN.dicFldComparisonOp[convcc_Course.CollegeID] = strComparisonOp;
}
}
return objvcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetCollegeName(this clsvcc_CourseEN objvcc_CourseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convcc_Course.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_Course.CollegeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetCollegeNameA(this clsvcc_CourseEN objvcc_CourseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_Course.CollegeNameA);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseEN SetMemo(this clsvcc_CourseEN objvcc_CourseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_Course.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseEN objvcc_Course_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_Course_Cond.IsUpdated(convcc_Course.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CourseId, objvcc_Course_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.LikeCount) == true)
{
string strComparisonOp_LikeCount = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Course.LikeCount, objvcc_Course_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CourseCode, objvcc_Course_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.CourseDescription) == true)
{
string strComparisonOp_CourseDescription = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CourseDescription, objvcc_Course_Cond.CourseDescription, strComparisonOp_CourseDescription);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CourseName, objvcc_Course_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.CourseTypeID) == true)
{
string strComparisonOp_CourseTypeID = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CourseTypeID, objvcc_Course_Cond.CourseTypeID, strComparisonOp_CourseTypeID);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.CourseTypeName) == true)
{
string strComparisonOp_CourseTypeName = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CourseTypeName, objvcc_Course_Cond.CourseTypeName, strComparisonOp_CourseTypeName);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.CreateDate) == true)
{
string strComparisonOp_CreateDate = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CreateDate, objvcc_Course_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.ExcellentTypeId) == true)
{
string strComparisonOp_ExcellentTypeId = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.ExcellentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.ExcellentTypeId, objvcc_Course_Cond.ExcellentTypeId, strComparisonOp_ExcellentTypeId);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.ExcellentTypeName) == true)
{
string strComparisonOp_ExcellentTypeName = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.ExcellentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.ExcellentTypeName, objvcc_Course_Cond.ExcellentTypeName, strComparisonOp_ExcellentTypeName);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.ExcellentYear) == true)
{
string strComparisonOp_ExcellentYear = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.ExcellentYear];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Course.ExcellentYear, objvcc_Course_Cond.ExcellentYear, strComparisonOp_ExcellentYear);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.IsBuildingCourse) == true)
{
if (objvcc_Course_Cond.IsBuildingCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_Course.IsBuildingCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_Course.IsBuildingCourse);
}
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.IsDoubleLanguageCourse) == true)
{
if (objvcc_Course_Cond.IsDoubleLanguageCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_Course.IsDoubleLanguageCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_Course.IsDoubleLanguageCourse);
}
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.IsOpen) == true)
{
if (objvcc_Course_Cond.IsOpen == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_Course.IsOpen);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_Course.IsOpen);
}
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.IsRecommendedCourse) == true)
{
if (objvcc_Course_Cond.IsRecommendedCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_Course.IsRecommendedCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_Course.IsRecommendedCourse);
}
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.IsSelfPropelledCourse) == true)
{
if (objvcc_Course_Cond.IsSelfPropelledCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_Course.IsSelfPropelledCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_Course.IsSelfPropelledCourse);
}
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.OperationDate) == true)
{
string strComparisonOp_OperationDate = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.OperationDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.OperationDate, objvcc_Course_Cond.OperationDate, strComparisonOp_OperationDate);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Course.OrderNum, objvcc_Course_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.OuterLink) == true)
{
string strComparisonOp_OuterLink = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.OuterLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.OuterLink, objvcc_Course_Cond.OuterLink, strComparisonOp_OuterLink);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_Course.ViewCount, objvcc_Course_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.ThemeId) == true)
{
string strComparisonOp_ThemeId = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.ThemeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.ThemeId, objvcc_Course_Cond.ThemeId, strComparisonOp_ThemeId);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.ThemeName) == true)
{
string strComparisonOp_ThemeName = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.ThemeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.ThemeName, objvcc_Course_Cond.ThemeName, strComparisonOp_ThemeName);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.ExampleImgPath) == true)
{
string strComparisonOp_ExampleImgPath = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.ExampleImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.ExampleImgPath, objvcc_Course_Cond.ExampleImgPath, strComparisonOp_ExampleImgPath);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.id_XzMajor, objvcc_Course_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.MajorID) == true)
{
string strComparisonOp_MajorID = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.MajorID, objvcc_Course_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.MajorName) == true)
{
string strComparisonOp_MajorName = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.MajorName, objvcc_Course_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.id_XzCollege, objvcc_Course_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CollegeID, objvcc_Course_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CollegeName, objvcc_Course_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.CollegeNameA, objvcc_Course_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvcc_Course_Cond.IsUpdated(convcc_Course.Memo) == true)
{
string strComparisonOp_Memo = objvcc_Course_Cond.dicFldComparisonOp[convcc_Course.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_Course.Memo, objvcc_Course_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程(vcc_Course)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseWApi
{
private static readonly string mstrApiControllerName = "vcc_CourseApi";

 public clsvcc_CourseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseEN GetObjByCourseId(string strCourseId)
{
string strAction = "GetObjByCourseId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseEN objvcc_CourseEN = null;
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
objvcc_CourseEN = JsonConvert.DeserializeObject<clsvcc_CourseEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseEN;
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
public static clsvcc_CourseEN GetObjByCourseId_WA_Cache(string strCourseId)
{
string strAction = "GetObjByCourseId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseEN objvcc_CourseEN = null;
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
objvcc_CourseEN = JsonConvert.DeserializeObject<clsvcc_CourseEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseEN;
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
public static clsvcc_CourseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseEN objvcc_CourseEN = null;
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
objvcc_CourseEN = JsonConvert.DeserializeObject<clsvcc_CourseEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseEN;
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
public static clsvcc_CourseEN GetObjByCourseId_Cache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_CourseEN._CurrTabName_S);
List<clsvcc_CourseEN> arrvcc_CourseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_CourseEN> arrvcc_CourseObjLst_Sel =
from objvcc_CourseEN in arrvcc_CourseObjLst_Cache
where objvcc_CourseEN.CourseId == strCourseId
select objvcc_CourseEN;
if (arrvcc_CourseObjLst_Sel.Count() == 0)
{
   clsvcc_CourseEN obj = clsvcc_CourseWApi.GetObjByCourseId(strCourseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_CourseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_CourseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseEN> GetObjLstByCourseIdLst(List<string> arrCourseId)
{
 List<clsvcc_CourseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvcc_CourseEN> GetObjLstByCourseIdLst_Cache(List<string> arrCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_CourseEN._CurrTabName_S);
List<clsvcc_CourseEN> arrvcc_CourseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_CourseEN> arrvcc_CourseObjLst_Sel =
from objvcc_CourseEN in arrvcc_CourseObjLst_Cache
where arrCourseId.Contains(objvcc_CourseEN.CourseId)
select objvcc_CourseEN;
return arrvcc_CourseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseEN> GetObjLstByCourseIdLst_WA_Cache(List<string> arrCourseId)
{
 List<clsvcc_CourseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_CourseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_CourseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
objvcc_CourseENT.CourseTypeID = objvcc_CourseENS.CourseTypeID; //课程类型ID
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
objvcc_CourseENT.id_XzMajor = objvcc_CourseENS.id_XzMajor; //专业流水号
objvcc_CourseENT.MajorID = objvcc_CourseENS.MajorID; //专业ID
objvcc_CourseENT.MajorName = objvcc_CourseENS.MajorName; //专业名称
objvcc_CourseENT.id_XzCollege = objvcc_CourseENS.id_XzCollege; //学院流水号
objvcc_CourseENT.CollegeID = objvcc_CourseENS.CollegeID; //学院ID
objvcc_CourseENT.CollegeName = objvcc_CourseENS.CollegeName; //学院名称
objvcc_CourseENT.CollegeNameA = objvcc_CourseENS.CollegeNameA; //学院名称简写
objvcc_CourseENT.Memo = objvcc_CourseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvcc_CourseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_CourseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_CourseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_CourseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_CourseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_CourseEN.AttributeName)
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
//if (arrvcc_CourseObjLst_Cache == null)
//{
//arrvcc_CourseObjLst_Cache = await clsvcc_CourseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_CourseEN._CurrTabName_S);
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
public static List<clsvcc_CourseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_CourseEN._CurrTabName_S);
List<clsvcc_CourseEN> arrvcc_CourseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_CourseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_CourseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_Course.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.LikeCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_Course.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.CourseDescription, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.CourseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.CourseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.ExcellentTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.ExcellentTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.ExcellentYear, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_Course.IsBuildingCourse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_Course.IsDoubleLanguageCourse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_Course.IsOpen, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_Course.IsRecommendedCourse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_Course.IsSelfPropelledCourse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_Course.OperationDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_Course.OuterLink, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_Course.ThemeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.ThemeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.ExampleImgPath, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convcc_Course.Memo, Type.GetType("System.String"));
foreach (clsvcc_CourseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_Course.CourseId] = objInFor[convcc_Course.CourseId];
objDR[convcc_Course.LikeCount] = objInFor[convcc_Course.LikeCount];
objDR[convcc_Course.CourseCode] = objInFor[convcc_Course.CourseCode];
objDR[convcc_Course.CourseDescription] = objInFor[convcc_Course.CourseDescription];
objDR[convcc_Course.CourseName] = objInFor[convcc_Course.CourseName];
objDR[convcc_Course.CourseTypeID] = objInFor[convcc_Course.CourseTypeID];
objDR[convcc_Course.CourseTypeName] = objInFor[convcc_Course.CourseTypeName];
objDR[convcc_Course.CreateDate] = objInFor[convcc_Course.CreateDate];
objDR[convcc_Course.ExcellentTypeId] = objInFor[convcc_Course.ExcellentTypeId];
objDR[convcc_Course.ExcellentTypeName] = objInFor[convcc_Course.ExcellentTypeName];
objDR[convcc_Course.ExcellentYear] = objInFor[convcc_Course.ExcellentYear];
objDR[convcc_Course.IsBuildingCourse] = objInFor[convcc_Course.IsBuildingCourse];
objDR[convcc_Course.IsDoubleLanguageCourse] = objInFor[convcc_Course.IsDoubleLanguageCourse];
objDR[convcc_Course.IsOpen] = objInFor[convcc_Course.IsOpen];
objDR[convcc_Course.IsRecommendedCourse] = objInFor[convcc_Course.IsRecommendedCourse];
objDR[convcc_Course.IsSelfPropelledCourse] = objInFor[convcc_Course.IsSelfPropelledCourse];
objDR[convcc_Course.OperationDate] = objInFor[convcc_Course.OperationDate];
objDR[convcc_Course.OrderNum] = objInFor[convcc_Course.OrderNum];
objDR[convcc_Course.OuterLink] = objInFor[convcc_Course.OuterLink];
objDR[convcc_Course.ViewCount] = objInFor[convcc_Course.ViewCount];
objDR[convcc_Course.ThemeId] = objInFor[convcc_Course.ThemeId];
objDR[convcc_Course.ThemeName] = objInFor[convcc_Course.ThemeName];
objDR[convcc_Course.ExampleImgPath] = objInFor[convcc_Course.ExampleImgPath];
objDR[convcc_Course.id_XzMajor] = objInFor[convcc_Course.id_XzMajor];
objDR[convcc_Course.MajorID] = objInFor[convcc_Course.MajorID];
objDR[convcc_Course.MajorName] = objInFor[convcc_Course.MajorName];
objDR[convcc_Course.id_XzCollege] = objInFor[convcc_Course.id_XzCollege];
objDR[convcc_Course.CollegeID] = objInFor[convcc_Course.CollegeID];
objDR[convcc_Course.CollegeName] = objInFor[convcc_Course.CollegeName];
objDR[convcc_Course.CollegeNameA] = objInFor[convcc_Course.CollegeNameA];
objDR[convcc_Course.Memo] = objInFor[convcc_Course.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}