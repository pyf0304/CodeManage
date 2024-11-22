
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseTeacherRelationWApi
 表名:vcc_CourseTeacherRelation(01120096)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:36
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
public static class clsvcc_CourseTeacherRelationWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetCourseTeacherRelationId(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, long lngCourseTeacherRelationId, string strComparisonOp="")
	{
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId = lngCourseTeacherRelationId; //课程教师关系表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.CourseTeacherRelationId) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.CourseTeacherRelationId, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.CourseTeacherRelationId] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetCourseId(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convcc_CourseTeacherRelation.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseTeacherRelation.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseTeacherRelation.CourseId);
objvcc_CourseTeacherRelationEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.CourseId) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.CourseId, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.CourseId] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetCourseCode(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convcc_CourseTeacherRelation.CourseCode);
objvcc_CourseTeacherRelationEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.CourseCode) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.CourseCode, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.CourseCode] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetCourseDescription(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strCourseDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, convcc_CourseTeacherRelation.CourseDescription);
objvcc_CourseTeacherRelationEN.CourseDescription = strCourseDescription; //课程描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.CourseDescription) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.CourseDescription, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.CourseDescription] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetCourseName(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseTeacherRelation.CourseName);
objvcc_CourseTeacherRelationEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.CourseName) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.CourseName, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.CourseName] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetCourseTypeID(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strCourseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, convcc_CourseTeacherRelation.CourseTypeID);
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, convcc_CourseTeacherRelation.CourseTypeID);
objvcc_CourseTeacherRelationEN.CourseTypeID = strCourseTypeID; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.CourseTypeID) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.CourseTypeID, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.CourseTypeID] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetCreateDate(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_CourseTeacherRelation.CreateDate);
objvcc_CourseTeacherRelationEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.CreateDate) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.CreateDate, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.CreateDate] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetExcellentTypeId(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strExcellentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExcellentTypeId, 4, convcc_CourseTeacherRelation.ExcellentTypeId);
clsCheckSql.CheckFieldForeignKey(strExcellentTypeId, 4, convcc_CourseTeacherRelation.ExcellentTypeId);
objvcc_CourseTeacherRelationEN.ExcellentTypeId = strExcellentTypeId; //精品课程类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.ExcellentTypeId) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.ExcellentTypeId, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.ExcellentTypeId] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetExcellentYear(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, int intExcellentYear, string strComparisonOp="")
	{
objvcc_CourseTeacherRelationEN.ExcellentYear = intExcellentYear; //课程年份
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.ExcellentYear) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.ExcellentYear, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.ExcellentYear] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetIsBuildingCourse(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, bool bolIsBuildingCourse, string strComparisonOp="")
	{
objvcc_CourseTeacherRelationEN.IsBuildingCourse = bolIsBuildingCourse; //是否已建设课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.IsBuildingCourse) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.IsBuildingCourse, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.IsBuildingCourse] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetIsDoubleLanguageCourse(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, bool bolIsDoubleLanguageCourse, string strComparisonOp="")
	{
objvcc_CourseTeacherRelationEN.IsDoubleLanguageCourse = bolIsDoubleLanguageCourse; //是否双语课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.IsDoubleLanguageCourse) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.IsDoubleLanguageCourse, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.IsDoubleLanguageCourse] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetIsOpen(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, bool bolIsOpen, string strComparisonOp="")
	{
objvcc_CourseTeacherRelationEN.IsOpen = bolIsOpen; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.IsOpen) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.IsOpen, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.IsOpen] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetIsRecommendedCourse(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, bool bolIsRecommendedCourse, string strComparisonOp="")
	{
objvcc_CourseTeacherRelationEN.IsRecommendedCourse = bolIsRecommendedCourse; //是否推荐课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.IsRecommendedCourse) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.IsRecommendedCourse, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.IsRecommendedCourse] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetIsSelfPropelledCourse(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, bool bolIsSelfPropelledCourse, string strComparisonOp="")
	{
objvcc_CourseTeacherRelationEN.IsSelfPropelledCourse = bolIsSelfPropelledCourse; //是否自荐课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.IsSelfPropelledCourse) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.IsSelfPropelledCourse, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.IsSelfPropelledCourse] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetOperationDate(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strOperationDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOperationDate, 20, convcc_CourseTeacherRelation.OperationDate);
objvcc_CourseTeacherRelationEN.OperationDate = strOperationDate; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.OperationDate) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.OperationDate, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.OperationDate] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetOrderNum(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, int intOrderNum, string strComparisonOp="")
	{
objvcc_CourseTeacherRelationEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.OrderNum) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.OrderNum, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.OrderNum] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetOuterLink(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strOuterLink, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOuterLink, 500, convcc_CourseTeacherRelation.OuterLink);
objvcc_CourseTeacherRelationEN.OuterLink = strOuterLink; //外链地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.OuterLink) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.OuterLink, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.OuterLink] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetViewCount(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, int intViewCount, string strComparisonOp="")
	{
objvcc_CourseTeacherRelationEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.ViewCount) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.ViewCount, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.ViewCount] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetThemeId(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strThemeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strThemeId, 4, convcc_CourseTeacherRelation.ThemeId);
clsCheckSql.CheckFieldForeignKey(strThemeId, 4, convcc_CourseTeacherRelation.ThemeId);
objvcc_CourseTeacherRelationEN.ThemeId = strThemeId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.ThemeId) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.ThemeId, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.ThemeId] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetExampleImgPath(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strExampleImgPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExampleImgPath, 300, convcc_CourseTeacherRelation.ExampleImgPath);
objvcc_CourseTeacherRelationEN.ExampleImgPath = strExampleImgPath; //示例图路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.ExampleImgPath) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.ExampleImgPath, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.ExampleImgPath] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN Setid_XzMajor(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convcc_CourseTeacherRelation.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convcc_CourseTeacherRelation.id_XzMajor);
objvcc_CourseTeacherRelationEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.id_XzMajor) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.id_XzMajor, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.id_XzMajor] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN Setid_XzCollege(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convcc_CourseTeacherRelation.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convcc_CourseTeacherRelation.id_XzCollege);
objvcc_CourseTeacherRelationEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.id_XzCollege) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.id_XzCollege, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.id_XzCollege] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN Setid_Teacher(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strid_Teacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Teacher, convcc_CourseTeacherRelation.id_Teacher);
clsCheckSql.CheckFieldLen(strid_Teacher, 8, convcc_CourseTeacherRelation.id_Teacher);
clsCheckSql.CheckFieldForeignKey(strid_Teacher, 8, convcc_CourseTeacherRelation.id_Teacher);
objvcc_CourseTeacherRelationEN.id_Teacher = strid_Teacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.id_Teacher) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.id_Teacher, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.id_Teacher] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetTeacherID(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherID, 12, convcc_CourseTeacherRelation.TeacherID);
objvcc_CourseTeacherRelationEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.TeacherID) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.TeacherID, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.TeacherID] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetTeacherName(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convcc_CourseTeacherRelation.TeacherName);
objvcc_CourseTeacherRelationEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.TeacherName) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.TeacherName, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.TeacherName] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetCardNo(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCardNo, 18, convcc_CourseTeacherRelation.CardNo);
objvcc_CourseTeacherRelationEN.CardNo = strCardNo; //卡号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.CardNo) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.CardNo, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.CardNo] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetIsCourseManager(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, bool bolIsCourseManager, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCourseManager, convcc_CourseTeacherRelation.IsCourseManager);
objvcc_CourseTeacherRelationEN.IsCourseManager = bolIsCourseManager; //是否课程主要人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.IsCourseManager) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.IsCourseManager, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.IsCourseManager] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetLastVisitedDate(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strLastVisitedDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLastVisitedDate, 14, convcc_CourseTeacherRelation.LastVisitedDate);
objvcc_CourseTeacherRelationEN.LastVisitedDate = strLastVisitedDate; //最后访问时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.LastVisitedDate) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.LastVisitedDate, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.LastVisitedDate] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetUpdDate(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_CourseTeacherRelation.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseTeacherRelation.UpdDate);
objvcc_CourseTeacherRelationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.UpdDate) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.UpdDate, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.UpdDate] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetUpdUser(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convcc_CourseTeacherRelation.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_CourseTeacherRelation.UpdUser);
objvcc_CourseTeacherRelationEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.UpdUser) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.UpdUser, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.UpdUser] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetMemo(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseTeacherRelation.Memo);
objvcc_CourseTeacherRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.Memo) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.Memo, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.Memo] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelation_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.CourseTeacherRelationId) == true)
{
string strComparisonOp_CourseTeacherRelationId = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.CourseTeacherRelationId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseTeacherRelation.CourseTeacherRelationId, objvcc_CourseTeacherRelation_Cond.CourseTeacherRelationId, strComparisonOp_CourseTeacherRelationId);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.CourseId, objvcc_CourseTeacherRelation_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.CourseCode, objvcc_CourseTeacherRelation_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.CourseDescription) == true)
{
string strComparisonOp_CourseDescription = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.CourseDescription, objvcc_CourseTeacherRelation_Cond.CourseDescription, strComparisonOp_CourseDescription);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.CourseName, objvcc_CourseTeacherRelation_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.CourseTypeID) == true)
{
string strComparisonOp_CourseTypeID = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.CourseTypeID, objvcc_CourseTeacherRelation_Cond.CourseTypeID, strComparisonOp_CourseTypeID);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.CreateDate) == true)
{
string strComparisonOp_CreateDate = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.CreateDate, objvcc_CourseTeacherRelation_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.ExcellentTypeId) == true)
{
string strComparisonOp_ExcellentTypeId = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.ExcellentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.ExcellentTypeId, objvcc_CourseTeacherRelation_Cond.ExcellentTypeId, strComparisonOp_ExcellentTypeId);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.ExcellentYear) == true)
{
string strComparisonOp_ExcellentYear = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.ExcellentYear];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseTeacherRelation.ExcellentYear, objvcc_CourseTeacherRelation_Cond.ExcellentYear, strComparisonOp_ExcellentYear);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.IsBuildingCourse) == true)
{
if (objvcc_CourseTeacherRelation_Cond.IsBuildingCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseTeacherRelation.IsBuildingCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseTeacherRelation.IsBuildingCourse);
}
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.IsDoubleLanguageCourse) == true)
{
if (objvcc_CourseTeacherRelation_Cond.IsDoubleLanguageCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseTeacherRelation.IsDoubleLanguageCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseTeacherRelation.IsDoubleLanguageCourse);
}
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.IsOpen) == true)
{
if (objvcc_CourseTeacherRelation_Cond.IsOpen == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseTeacherRelation.IsOpen);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseTeacherRelation.IsOpen);
}
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.IsRecommendedCourse) == true)
{
if (objvcc_CourseTeacherRelation_Cond.IsRecommendedCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseTeacherRelation.IsRecommendedCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseTeacherRelation.IsRecommendedCourse);
}
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.IsSelfPropelledCourse) == true)
{
if (objvcc_CourseTeacherRelation_Cond.IsSelfPropelledCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseTeacherRelation.IsSelfPropelledCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseTeacherRelation.IsSelfPropelledCourse);
}
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.OperationDate) == true)
{
string strComparisonOp_OperationDate = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.OperationDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.OperationDate, objvcc_CourseTeacherRelation_Cond.OperationDate, strComparisonOp_OperationDate);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseTeacherRelation.OrderNum, objvcc_CourseTeacherRelation_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.OuterLink) == true)
{
string strComparisonOp_OuterLink = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.OuterLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.OuterLink, objvcc_CourseTeacherRelation_Cond.OuterLink, strComparisonOp_OuterLink);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseTeacherRelation.ViewCount, objvcc_CourseTeacherRelation_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.ThemeId) == true)
{
string strComparisonOp_ThemeId = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.ThemeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.ThemeId, objvcc_CourseTeacherRelation_Cond.ThemeId, strComparisonOp_ThemeId);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.ExampleImgPath) == true)
{
string strComparisonOp_ExampleImgPath = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.ExampleImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.ExampleImgPath, objvcc_CourseTeacherRelation_Cond.ExampleImgPath, strComparisonOp_ExampleImgPath);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.id_XzMajor, objvcc_CourseTeacherRelation_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.id_XzCollege, objvcc_CourseTeacherRelation_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.id_Teacher) == true)
{
string strComparisonOp_id_Teacher = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.id_Teacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.id_Teacher, objvcc_CourseTeacherRelation_Cond.id_Teacher, strComparisonOp_id_Teacher);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.TeacherID, objvcc_CourseTeacherRelation_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.TeacherName) == true)
{
string strComparisonOp_TeacherName = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.TeacherName, objvcc_CourseTeacherRelation_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.CardNo) == true)
{
string strComparisonOp_CardNo = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.CardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.CardNo, objvcc_CourseTeacherRelation_Cond.CardNo, strComparisonOp_CardNo);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.IsCourseManager) == true)
{
if (objvcc_CourseTeacherRelation_Cond.IsCourseManager == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseTeacherRelation.IsCourseManager);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseTeacherRelation.IsCourseManager);
}
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.LastVisitedDate) == true)
{
string strComparisonOp_LastVisitedDate = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.LastVisitedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.LastVisitedDate, objvcc_CourseTeacherRelation_Cond.LastVisitedDate, strComparisonOp_LastVisitedDate);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.UpdDate, objvcc_CourseTeacherRelation_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.UpdUser, objvcc_CourseTeacherRelation_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvcc_CourseTeacherRelation_Cond.IsUpdated(convcc_CourseTeacherRelation.Memo) == true)
{
string strComparisonOp_Memo = objvcc_CourseTeacherRelation_Cond.dicFldComparisonOp[convcc_CourseTeacherRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.Memo, objvcc_CourseTeacherRelation_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程和教师关系(vcc_CourseTeacherRelation)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseTeacherRelationWApi
{
private static readonly string mstrApiControllerName = "vcc_CourseTeacherRelationApi";

 public clsvcc_CourseTeacherRelationWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngCourseTeacherRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseTeacherRelationEN GetObjByCourseTeacherRelationId(long lngCourseTeacherRelationId)
{
string strAction = "GetObjByCourseTeacherRelationId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseTeacherRelationId"] = lngCourseTeacherRelationId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_CourseTeacherRelationEN = JsonConvert.DeserializeObject<clsvcc_CourseTeacherRelationEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseTeacherRelationEN;
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
 /// <param name = "lngCourseTeacherRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseTeacherRelationEN GetObjByCourseTeacherRelationId_WA_Cache(long lngCourseTeacherRelationId, string strCourseId)
{
string strAction = "GetObjByCourseTeacherRelationId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseTeacherRelationId"] = lngCourseTeacherRelationId.ToString(),
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_CourseTeacherRelationEN = JsonConvert.DeserializeObject<clsvcc_CourseTeacherRelationEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseTeacherRelationEN;
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
public static clsvcc_CourseTeacherRelationEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN = null;
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
objvcc_CourseTeacherRelationEN = JsonConvert.DeserializeObject<clsvcc_CourseTeacherRelationEN>((string)jobjReturn["ReturnObj"]);
return objvcc_CourseTeacherRelationEN;
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
 /// <param name = "lngCourseTeacherRelationId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseTeacherRelationEN GetObjByCourseTeacherRelationId_Cache(long lngCourseTeacherRelationId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseTeacherRelationEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseTeacherRelationEN> arrvcc_CourseTeacherRelationObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseTeacherRelationEN> arrvcc_CourseTeacherRelationObjLst_Sel =
from objvcc_CourseTeacherRelationEN in arrvcc_CourseTeacherRelationObjLst_Cache
where objvcc_CourseTeacherRelationEN.CourseTeacherRelationId == lngCourseTeacherRelationId
select objvcc_CourseTeacherRelationEN;
if (arrvcc_CourseTeacherRelationObjLst_Sel.Count() == 0)
{
   clsvcc_CourseTeacherRelationEN obj = clsvcc_CourseTeacherRelationWApi.GetObjByCourseTeacherRelationId(lngCourseTeacherRelationId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_CourseTeacherRelationObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseTeacherRelationEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_CourseTeacherRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTeacherRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseTeacherRelationEN> GetObjLstByCourseTeacherRelationIdLst(List<long> arrCourseTeacherRelationId)
{
 List<clsvcc_CourseTeacherRelationEN> arrObjLst = null; 
string strAction = "GetObjLstByCourseTeacherRelationIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseTeacherRelationId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTeacherRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngCourseTeacherRelationId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_CourseTeacherRelationEN> GetObjLstByCourseTeacherRelationIdLst_Cache(List<long> arrCourseTeacherRelationId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_CourseTeacherRelationEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseTeacherRelationEN> arrvcc_CourseTeacherRelationObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvcc_CourseTeacherRelationEN> arrvcc_CourseTeacherRelationObjLst_Sel =
from objvcc_CourseTeacherRelationEN in arrvcc_CourseTeacherRelationObjLst_Cache
where arrCourseTeacherRelationId.Contains(objvcc_CourseTeacherRelationEN.CourseTeacherRelationId)
select objvcc_CourseTeacherRelationEN;
return arrvcc_CourseTeacherRelationObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseTeacherRelationEN> GetObjLstByCourseTeacherRelationIdLst_WA_Cache(List<long> arrCourseTeacherRelationId, string strCourseId)
{
 List<clsvcc_CourseTeacherRelationEN> arrObjLst = null; 
string strAction = "GetObjLstByCourseTeacherRelationIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseTeacherRelationId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTeacherRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseTeacherRelationEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_CourseTeacherRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTeacherRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseTeacherRelationEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_CourseTeacherRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTeacherRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseTeacherRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseTeacherRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTeacherRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_CourseTeacherRelationEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_CourseTeacherRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_CourseTeacherRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngCourseTeacherRelationId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseTeacherRelationId"] = lngCourseTeacherRelationId.ToString()
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
 /// <param name = "objvcc_CourseTeacherRelationENS">源对象</param>
 /// <param name = "objvcc_CourseTeacherRelationENT">目标对象</param>
 public static void CopyTo(clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationENS, clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationENT)
{
try
{
objvcc_CourseTeacherRelationENT.CourseTeacherRelationId = objvcc_CourseTeacherRelationENS.CourseTeacherRelationId; //课程教师关系表流水号
objvcc_CourseTeacherRelationENT.CourseId = objvcc_CourseTeacherRelationENS.CourseId; //课程Id
objvcc_CourseTeacherRelationENT.CourseCode = objvcc_CourseTeacherRelationENS.CourseCode; //课程代码
objvcc_CourseTeacherRelationENT.CourseDescription = objvcc_CourseTeacherRelationENS.CourseDescription; //课程描述
objvcc_CourseTeacherRelationENT.CourseName = objvcc_CourseTeacherRelationENS.CourseName; //课程名称
objvcc_CourseTeacherRelationENT.CourseTypeID = objvcc_CourseTeacherRelationENS.CourseTypeID; //课程类型ID
objvcc_CourseTeacherRelationENT.CreateDate = objvcc_CourseTeacherRelationENS.CreateDate; //建立日期
objvcc_CourseTeacherRelationENT.ExcellentTypeId = objvcc_CourseTeacherRelationENS.ExcellentTypeId; //精品课程类型Id
objvcc_CourseTeacherRelationENT.ExcellentYear = objvcc_CourseTeacherRelationENS.ExcellentYear; //课程年份
objvcc_CourseTeacherRelationENT.IsBuildingCourse = objvcc_CourseTeacherRelationENS.IsBuildingCourse; //是否已建设课程
objvcc_CourseTeacherRelationENT.IsDoubleLanguageCourse = objvcc_CourseTeacherRelationENS.IsDoubleLanguageCourse; //是否双语课程
objvcc_CourseTeacherRelationENT.IsOpen = objvcc_CourseTeacherRelationENS.IsOpen; //是否公开
objvcc_CourseTeacherRelationENT.IsRecommendedCourse = objvcc_CourseTeacherRelationENS.IsRecommendedCourse; //是否推荐课程
objvcc_CourseTeacherRelationENT.IsSelfPropelledCourse = objvcc_CourseTeacherRelationENS.IsSelfPropelledCourse; //是否自荐课程
objvcc_CourseTeacherRelationENT.OperationDate = objvcc_CourseTeacherRelationENS.OperationDate; //操作时间
objvcc_CourseTeacherRelationENT.OrderNum = objvcc_CourseTeacherRelationENS.OrderNum; //序号
objvcc_CourseTeacherRelationENT.OuterLink = objvcc_CourseTeacherRelationENS.OuterLink; //外链地址
objvcc_CourseTeacherRelationENT.ViewCount = objvcc_CourseTeacherRelationENS.ViewCount; //浏览量
objvcc_CourseTeacherRelationENT.ThemeId = objvcc_CourseTeacherRelationENS.ThemeId; //主题Id
objvcc_CourseTeacherRelationENT.ExampleImgPath = objvcc_CourseTeacherRelationENS.ExampleImgPath; //示例图路径
objvcc_CourseTeacherRelationENT.id_XzMajor = objvcc_CourseTeacherRelationENS.id_XzMajor; //专业流水号
objvcc_CourseTeacherRelationENT.id_XzCollege = objvcc_CourseTeacherRelationENS.id_XzCollege; //学院流水号
objvcc_CourseTeacherRelationENT.id_Teacher = objvcc_CourseTeacherRelationENS.id_Teacher; //教师流水号
objvcc_CourseTeacherRelationENT.TeacherID = objvcc_CourseTeacherRelationENS.TeacherID; //教师工号
objvcc_CourseTeacherRelationENT.TeacherName = objvcc_CourseTeacherRelationENS.TeacherName; //教师姓名
objvcc_CourseTeacherRelationENT.CardNo = objvcc_CourseTeacherRelationENS.CardNo; //卡号
objvcc_CourseTeacherRelationENT.IsCourseManager = objvcc_CourseTeacherRelationENS.IsCourseManager; //是否课程主要人
objvcc_CourseTeacherRelationENT.LastVisitedDate = objvcc_CourseTeacherRelationENS.LastVisitedDate; //最后访问时间
objvcc_CourseTeacherRelationENT.UpdDate = objvcc_CourseTeacherRelationENS.UpdDate; //修改日期
objvcc_CourseTeacherRelationENT.UpdUser = objvcc_CourseTeacherRelationENS.UpdUser; //修改人
objvcc_CourseTeacherRelationENT.Memo = objvcc_CourseTeacherRelationENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvcc_CourseTeacherRelationEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_CourseTeacherRelationEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_CourseTeacherRelationEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_CourseTeacherRelationEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_CourseTeacherRelationEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_CourseTeacherRelationEN.AttributeName)
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
if (clsTeacherInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoWApi没有刷新缓存机制(clsTeacherInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTeacherRelationWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTeacherRelationWApi没有刷新缓存机制(clscc_CourseTeacherRelationWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//string strWhereCond = string.Format("1 = 1 order by CourseTeacherRelationId");
//if (arrvcc_CourseTeacherRelationObjLst_Cache == null)
//{
//arrvcc_CourseTeacherRelationObjLst_Cache = await clsvcc_CourseTeacherRelationWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvcc_CourseTeacherRelationEN._CurrTabName_S, strCourseId);
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
public static List<clsvcc_CourseTeacherRelationEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_CourseTeacherRelationEN._CurrTabName_S, strCourseId);
List<clsvcc_CourseTeacherRelationEN> arrvcc_CourseTeacherRelationObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvcc_CourseTeacherRelationObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_CourseTeacherRelationEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_CourseTeacherRelation.CourseTeacherRelationId, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_CourseTeacherRelation.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.CourseDescription, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.CourseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.ExcellentTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.ExcellentYear, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseTeacherRelation.IsBuildingCourse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseTeacherRelation.IsDoubleLanguageCourse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseTeacherRelation.IsOpen, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseTeacherRelation.IsRecommendedCourse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseTeacherRelation.IsSelfPropelledCourse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseTeacherRelation.OperationDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseTeacherRelation.OuterLink, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_CourseTeacherRelation.ThemeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.ExampleImgPath, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.id_Teacher, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.CardNo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.IsCourseManager, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_CourseTeacherRelation.LastVisitedDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convcc_CourseTeacherRelation.Memo, Type.GetType("System.String"));
foreach (clsvcc_CourseTeacherRelationEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_CourseTeacherRelation.CourseTeacherRelationId] = objInFor[convcc_CourseTeacherRelation.CourseTeacherRelationId];
objDR[convcc_CourseTeacherRelation.CourseId] = objInFor[convcc_CourseTeacherRelation.CourseId];
objDR[convcc_CourseTeacherRelation.CourseCode] = objInFor[convcc_CourseTeacherRelation.CourseCode];
objDR[convcc_CourseTeacherRelation.CourseDescription] = objInFor[convcc_CourseTeacherRelation.CourseDescription];
objDR[convcc_CourseTeacherRelation.CourseName] = objInFor[convcc_CourseTeacherRelation.CourseName];
objDR[convcc_CourseTeacherRelation.CourseTypeID] = objInFor[convcc_CourseTeacherRelation.CourseTypeID];
objDR[convcc_CourseTeacherRelation.CreateDate] = objInFor[convcc_CourseTeacherRelation.CreateDate];
objDR[convcc_CourseTeacherRelation.ExcellentTypeId] = objInFor[convcc_CourseTeacherRelation.ExcellentTypeId];
objDR[convcc_CourseTeacherRelation.ExcellentYear] = objInFor[convcc_CourseTeacherRelation.ExcellentYear];
objDR[convcc_CourseTeacherRelation.IsBuildingCourse] = objInFor[convcc_CourseTeacherRelation.IsBuildingCourse];
objDR[convcc_CourseTeacherRelation.IsDoubleLanguageCourse] = objInFor[convcc_CourseTeacherRelation.IsDoubleLanguageCourse];
objDR[convcc_CourseTeacherRelation.IsOpen] = objInFor[convcc_CourseTeacherRelation.IsOpen];
objDR[convcc_CourseTeacherRelation.IsRecommendedCourse] = objInFor[convcc_CourseTeacherRelation.IsRecommendedCourse];
objDR[convcc_CourseTeacherRelation.IsSelfPropelledCourse] = objInFor[convcc_CourseTeacherRelation.IsSelfPropelledCourse];
objDR[convcc_CourseTeacherRelation.OperationDate] = objInFor[convcc_CourseTeacherRelation.OperationDate];
objDR[convcc_CourseTeacherRelation.OrderNum] = objInFor[convcc_CourseTeacherRelation.OrderNum];
objDR[convcc_CourseTeacherRelation.OuterLink] = objInFor[convcc_CourseTeacherRelation.OuterLink];
objDR[convcc_CourseTeacherRelation.ViewCount] = objInFor[convcc_CourseTeacherRelation.ViewCount];
objDR[convcc_CourseTeacherRelation.ThemeId] = objInFor[convcc_CourseTeacherRelation.ThemeId];
objDR[convcc_CourseTeacherRelation.ExampleImgPath] = objInFor[convcc_CourseTeacherRelation.ExampleImgPath];
objDR[convcc_CourseTeacherRelation.id_XzMajor] = objInFor[convcc_CourseTeacherRelation.id_XzMajor];
objDR[convcc_CourseTeacherRelation.id_XzCollege] = objInFor[convcc_CourseTeacherRelation.id_XzCollege];
objDR[convcc_CourseTeacherRelation.id_Teacher] = objInFor[convcc_CourseTeacherRelation.id_Teacher];
objDR[convcc_CourseTeacherRelation.TeacherID] = objInFor[convcc_CourseTeacherRelation.TeacherID];
objDR[convcc_CourseTeacherRelation.TeacherName] = objInFor[convcc_CourseTeacherRelation.TeacherName];
objDR[convcc_CourseTeacherRelation.CardNo] = objInFor[convcc_CourseTeacherRelation.CardNo];
objDR[convcc_CourseTeacherRelation.IsCourseManager] = objInFor[convcc_CourseTeacherRelation.IsCourseManager];
objDR[convcc_CourseTeacherRelation.LastVisitedDate] = objInFor[convcc_CourseTeacherRelation.LastVisitedDate];
objDR[convcc_CourseTeacherRelation.UpdDate] = objInFor[convcc_CourseTeacherRelation.UpdDate];
objDR[convcc_CourseTeacherRelation.UpdUser] = objInFor[convcc_CourseTeacherRelation.UpdUser];
objDR[convcc_CourseTeacherRelation.Memo] = objInFor[convcc_CourseTeacherRelation.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}