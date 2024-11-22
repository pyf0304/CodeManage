
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseTeacherRelationBL
 表名:vcc_CourseTeacherRelation(01120096)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:55
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理(CourseManage)
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
public static class  clsvcc_CourseTeacherRelationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngCourseTeacherRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseTeacherRelationEN GetObj(this K_CourseTeacherRelationId_vcc_CourseTeacherRelation myKey)
{
clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN = clsvcc_CourseTeacherRelationBL.vcc_CourseTeacherRelationDA.GetObjByCourseTeacherRelationId(myKey.Value);
return objvcc_CourseTeacherRelationEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetCourseId(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convcc_CourseTeacherRelation.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseTeacherRelation.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseTeacherRelation.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetCourseCode(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convcc_CourseTeacherRelation.CourseCode);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetCourseDescription(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strCourseDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, convcc_CourseTeacherRelation.CourseDescription);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetCourseName(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseTeacherRelation.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetCourseTypeID(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strCourseTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, convcc_CourseTeacherRelation.CourseTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, convcc_CourseTeacherRelation.CourseTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetCreateDate(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_CourseTeacherRelation.CreateDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetExcellentTypeId(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strExcellentTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExcellentTypeId, 4, convcc_CourseTeacherRelation.ExcellentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExcellentTypeId, 4, convcc_CourseTeacherRelation.ExcellentTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetExcellentYear(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, int? intExcellentYear, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetOperationDate(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strOperationDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationDate, 20, convcc_CourseTeacherRelation.OperationDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetOrderNum(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, int? intOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetOuterLink(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strOuterLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOuterLink, 500, convcc_CourseTeacherRelation.OuterLink);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetViewCount(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, int? intViewCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetThemeId(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strThemeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThemeId, 4, convcc_CourseTeacherRelation.ThemeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strThemeId, 4, convcc_CourseTeacherRelation.ThemeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetExampleImgPath(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strExampleImgPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExampleImgPath, 300, convcc_CourseTeacherRelation.ExampleImgPath);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetIdXzMajor(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convcc_CourseTeacherRelation.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convcc_CourseTeacherRelation.IdXzMajor);
}
objvcc_CourseTeacherRelationEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.IdXzMajor) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.IdXzMajor, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.IdXzMajor] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetIdXzCollege(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convcc_CourseTeacherRelation.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convcc_CourseTeacherRelation.IdXzCollege);
}
objvcc_CourseTeacherRelationEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.IdXzCollege) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.IdXzCollege, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.IdXzCollege] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetIdTeacher(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strIdTeacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeacher, convcc_CourseTeacherRelation.IdTeacher);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeacher, 8, convcc_CourseTeacherRelation.IdTeacher);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeacher, 8, convcc_CourseTeacherRelation.IdTeacher);
}
objvcc_CourseTeacherRelationEN.IdTeacher = strIdTeacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelationEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation.IdTeacher) == false)
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation.IdTeacher, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelationEN.dicFldComparisonOp[convcc_CourseTeacherRelation.IdTeacher] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetTeacherID(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strTeacherID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherID, 12, convcc_CourseTeacherRelation.TeacherID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetTeacherName(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strTeacherName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convcc_CourseTeacherRelation.TeacherName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetCardNo(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCardNo, 18, convcc_CourseTeacherRelation.CardNo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetLastVisitedDate(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strLastVisitedDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastVisitedDate, 14, convcc_CourseTeacherRelation.LastVisitedDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetUpdDate(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_CourseTeacherRelation.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseTeacherRelation.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetUpdUser(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convcc_CourseTeacherRelation.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_CourseTeacherRelation.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelationEN SetMemo(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseTeacherRelation.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationENS">源对象</param>
 /// <param name = "objvcc_CourseTeacherRelationENT">目标对象</param>
 public static void CopyTo(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationENS, clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationENT)
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
objvcc_CourseTeacherRelationENT.IdXzMajor = objvcc_CourseTeacherRelationENS.IdXzMajor; //专业流水号
objvcc_CourseTeacherRelationENT.IdXzCollege = objvcc_CourseTeacherRelationENS.IdXzCollege; //学院流水号
objvcc_CourseTeacherRelationENT.IdTeacher = objvcc_CourseTeacherRelationENS.IdTeacher; //教师流水号
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
 /// <param name = "objvcc_CourseTeacherRelationENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseTeacherRelationEN:objvcc_CourseTeacherRelationENT</returns>
 public static clsvcc_CourseTeacherRelationEN CopyTo(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationENS)
{
try
{
 clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationENT = new clsvcc_CourseTeacherRelationEN()
{
CourseTeacherRelationId = objvcc_CourseTeacherRelationENS.CourseTeacherRelationId, //课程教师关系表流水号
CourseId = objvcc_CourseTeacherRelationENS.CourseId, //课程Id
CourseCode = objvcc_CourseTeacherRelationENS.CourseCode, //课程代码
CourseDescription = objvcc_CourseTeacherRelationENS.CourseDescription, //课程描述
CourseName = objvcc_CourseTeacherRelationENS.CourseName, //课程名称
CourseTypeID = objvcc_CourseTeacherRelationENS.CourseTypeID, //课程类型ID
CreateDate = objvcc_CourseTeacherRelationENS.CreateDate, //建立日期
ExcellentTypeId = objvcc_CourseTeacherRelationENS.ExcellentTypeId, //精品课程类型Id
ExcellentYear = objvcc_CourseTeacherRelationENS.ExcellentYear, //课程年份
IsBuildingCourse = objvcc_CourseTeacherRelationENS.IsBuildingCourse, //是否已建设课程
IsDoubleLanguageCourse = objvcc_CourseTeacherRelationENS.IsDoubleLanguageCourse, //是否双语课程
IsOpen = objvcc_CourseTeacherRelationENS.IsOpen, //是否公开
IsRecommendedCourse = objvcc_CourseTeacherRelationENS.IsRecommendedCourse, //是否推荐课程
IsSelfPropelledCourse = objvcc_CourseTeacherRelationENS.IsSelfPropelledCourse, //是否自荐课程
OperationDate = objvcc_CourseTeacherRelationENS.OperationDate, //操作时间
OrderNum = objvcc_CourseTeacherRelationENS.OrderNum, //序号
OuterLink = objvcc_CourseTeacherRelationENS.OuterLink, //外链地址
ViewCount = objvcc_CourseTeacherRelationENS.ViewCount, //浏览量
ThemeId = objvcc_CourseTeacherRelationENS.ThemeId, //主题Id
ExampleImgPath = objvcc_CourseTeacherRelationENS.ExampleImgPath, //示例图路径
IdXzMajor = objvcc_CourseTeacherRelationENS.IdXzMajor, //专业流水号
IdXzCollege = objvcc_CourseTeacherRelationENS.IdXzCollege, //学院流水号
IdTeacher = objvcc_CourseTeacherRelationENS.IdTeacher, //教师流水号
TeacherID = objvcc_CourseTeacherRelationENS.TeacherID, //教师工号
TeacherName = objvcc_CourseTeacherRelationENS.TeacherName, //教师姓名
CardNo = objvcc_CourseTeacherRelationENS.CardNo, //卡号
IsCourseManager = objvcc_CourseTeacherRelationENS.IsCourseManager, //是否课程主要人
LastVisitedDate = objvcc_CourseTeacherRelationENS.LastVisitedDate, //最后访问时间
UpdDate = objvcc_CourseTeacherRelationENS.UpdDate, //修改日期
UpdUser = objvcc_CourseTeacherRelationENS.UpdUser, //修改人
Memo = objvcc_CourseTeacherRelationENS.Memo, //备注
};
 return objvcc_CourseTeacherRelationENT;
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
public static void CheckProperty4Condition(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN)
{
 clsvcc_CourseTeacherRelationBL.vcc_CourseTeacherRelationDA.CheckProperty4Condition(objvcc_CourseTeacherRelationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.CourseTeacherRelationId) == true)
{
string strComparisonOpCourseTeacherRelationId = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.CourseTeacherRelationId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseTeacherRelation.CourseTeacherRelationId, objvcc_CourseTeacherRelationCond.CourseTeacherRelationId, strComparisonOpCourseTeacherRelationId);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.CourseId, objvcc_CourseTeacherRelationCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.CourseCode) == true)
{
string strComparisonOpCourseCode = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.CourseCode, objvcc_CourseTeacherRelationCond.CourseCode, strComparisonOpCourseCode);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.CourseDescription) == true)
{
string strComparisonOpCourseDescription = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.CourseDescription, objvcc_CourseTeacherRelationCond.CourseDescription, strComparisonOpCourseDescription);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.CourseName, objvcc_CourseTeacherRelationCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.CourseTypeID) == true)
{
string strComparisonOpCourseTypeID = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.CourseTypeID, objvcc_CourseTeacherRelationCond.CourseTypeID, strComparisonOpCourseTypeID);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.CreateDate) == true)
{
string strComparisonOpCreateDate = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.CreateDate, objvcc_CourseTeacherRelationCond.CreateDate, strComparisonOpCreateDate);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.ExcellentTypeId) == true)
{
string strComparisonOpExcellentTypeId = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.ExcellentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.ExcellentTypeId, objvcc_CourseTeacherRelationCond.ExcellentTypeId, strComparisonOpExcellentTypeId);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.ExcellentYear) == true)
{
string strComparisonOpExcellentYear = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.ExcellentYear];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseTeacherRelation.ExcellentYear, objvcc_CourseTeacherRelationCond.ExcellentYear, strComparisonOpExcellentYear);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.IsBuildingCourse) == true)
{
if (objvcc_CourseTeacherRelationCond.IsBuildingCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseTeacherRelation.IsBuildingCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseTeacherRelation.IsBuildingCourse);
}
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.IsDoubleLanguageCourse) == true)
{
if (objvcc_CourseTeacherRelationCond.IsDoubleLanguageCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseTeacherRelation.IsDoubleLanguageCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseTeacherRelation.IsDoubleLanguageCourse);
}
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.IsOpen) == true)
{
if (objvcc_CourseTeacherRelationCond.IsOpen == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseTeacherRelation.IsOpen);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseTeacherRelation.IsOpen);
}
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.IsRecommendedCourse) == true)
{
if (objvcc_CourseTeacherRelationCond.IsRecommendedCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseTeacherRelation.IsRecommendedCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseTeacherRelation.IsRecommendedCourse);
}
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.IsSelfPropelledCourse) == true)
{
if (objvcc_CourseTeacherRelationCond.IsSelfPropelledCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseTeacherRelation.IsSelfPropelledCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseTeacherRelation.IsSelfPropelledCourse);
}
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.OperationDate) == true)
{
string strComparisonOpOperationDate = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.OperationDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.OperationDate, objvcc_CourseTeacherRelationCond.OperationDate, strComparisonOpOperationDate);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.OrderNum) == true)
{
string strComparisonOpOrderNum = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseTeacherRelation.OrderNum, objvcc_CourseTeacherRelationCond.OrderNum, strComparisonOpOrderNum);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.OuterLink) == true)
{
string strComparisonOpOuterLink = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.OuterLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.OuterLink, objvcc_CourseTeacherRelationCond.OuterLink, strComparisonOpOuterLink);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.ViewCount) == true)
{
string strComparisonOpViewCount = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseTeacherRelation.ViewCount, objvcc_CourseTeacherRelationCond.ViewCount, strComparisonOpViewCount);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.ThemeId) == true)
{
string strComparisonOpThemeId = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.ThemeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.ThemeId, objvcc_CourseTeacherRelationCond.ThemeId, strComparisonOpThemeId);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.ExampleImgPath) == true)
{
string strComparisonOpExampleImgPath = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.ExampleImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.ExampleImgPath, objvcc_CourseTeacherRelationCond.ExampleImgPath, strComparisonOpExampleImgPath);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.IdXzMajor, objvcc_CourseTeacherRelationCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.IdXzCollege, objvcc_CourseTeacherRelationCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.IdTeacher) == true)
{
string strComparisonOpIdTeacher = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.IdTeacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.IdTeacher, objvcc_CourseTeacherRelationCond.IdTeacher, strComparisonOpIdTeacher);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.TeacherID) == true)
{
string strComparisonOpTeacherID = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.TeacherID, objvcc_CourseTeacherRelationCond.TeacherID, strComparisonOpTeacherID);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.TeacherName) == true)
{
string strComparisonOpTeacherName = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.TeacherName, objvcc_CourseTeacherRelationCond.TeacherName, strComparisonOpTeacherName);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.CardNo) == true)
{
string strComparisonOpCardNo = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.CardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.CardNo, objvcc_CourseTeacherRelationCond.CardNo, strComparisonOpCardNo);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.IsCourseManager) == true)
{
if (objvcc_CourseTeacherRelationCond.IsCourseManager == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseTeacherRelation.IsCourseManager);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseTeacherRelation.IsCourseManager);
}
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.LastVisitedDate) == true)
{
string strComparisonOpLastVisitedDate = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.LastVisitedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.LastVisitedDate, objvcc_CourseTeacherRelationCond.LastVisitedDate, strComparisonOpLastVisitedDate);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.UpdDate, objvcc_CourseTeacherRelationCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.UpdUser) == true)
{
string strComparisonOpUpdUser = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.UpdUser, objvcc_CourseTeacherRelationCond.UpdUser, strComparisonOpUpdUser);
}
if (objvcc_CourseTeacherRelationCond.IsUpdated(convcc_CourseTeacherRelation.Memo) == true)
{
string strComparisonOpMemo = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[convcc_CourseTeacherRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation.Memo, objvcc_CourseTeacherRelationCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_CourseTeacherRelation
{
public virtual bool UpdRelaTabDate(long lngCourseTeacherRelationId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程和教师关系(vcc_CourseTeacherRelation)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseTeacherRelationBL
{
public static RelatedActions_vcc_CourseTeacherRelation relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_CourseTeacherRelationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_CourseTeacherRelationDA vcc_CourseTeacherRelationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_CourseTeacherRelationDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_CourseTeacherRelationBL()
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
if (string.IsNullOrEmpty(clsvcc_CourseTeacherRelationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseTeacherRelationEN._ConnectString);
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
public static DataTable GetDataTable_vcc_CourseTeacherRelation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_CourseTeacherRelationDA.GetDataTable_vcc_CourseTeacherRelation(strWhereCond);
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
objDT = vcc_CourseTeacherRelationDA.GetDataTable(strWhereCond);
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
objDT = vcc_CourseTeacherRelationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_CourseTeacherRelationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_CourseTeacherRelationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_CourseTeacherRelationDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_CourseTeacherRelationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_CourseTeacherRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_CourseTeacherRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCourseTeacherRelationIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_CourseTeacherRelationEN> GetObjLstByCourseTeacherRelationIdLst(List<long> arrCourseTeacherRelationIdLst)
{
List<clsvcc_CourseTeacherRelationEN> arrObjLst = new List<clsvcc_CourseTeacherRelationEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCourseTeacherRelationIdLst);
 string strWhereCond = string.Format("CourseTeacherRelationId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN = new clsvcc_CourseTeacherRelationEN();
try
{
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelationEN.CourseId = objRow[convcc_CourseTeacherRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelationEN.CourseCode = objRow[convcc_CourseTeacherRelation.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelationEN.CourseDescription = objRow[convcc_CourseTeacherRelation.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelationEN.CourseName = objRow[convcc_CourseTeacherRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelationEN.CourseTypeID = objRow[convcc_CourseTeacherRelation.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelationEN.CreateDate = objRow[convcc_CourseTeacherRelation.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelationEN.ExcellentTypeId = objRow[convcc_CourseTeacherRelation.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseTeacherRelationEN.ExcellentYear = objRow[convcc_CourseTeacherRelation.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseTeacherRelationEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseTeacherRelationEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseTeacherRelationEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelationEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelationEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseTeacherRelationEN.OperationDate = objRow[convcc_CourseTeacherRelation.OperationDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseTeacherRelationEN.OrderNum = objRow[convcc_CourseTeacherRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelationEN.OuterLink = objRow[convcc_CourseTeacherRelation.OuterLink] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseTeacherRelationEN.ViewCount = objRow[convcc_CourseTeacherRelation.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelationEN.ThemeId = objRow[convcc_CourseTeacherRelation.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseTeacherRelationEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelationEN.IdXzMajor = objRow[convcc_CourseTeacherRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelationEN.IdXzCollege = objRow[convcc_CourseTeacherRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelationEN.IdTeacher = objRow[convcc_CourseTeacherRelation.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelationEN.TeacherID = objRow[convcc_CourseTeacherRelation.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelationEN.TeacherName = objRow[convcc_CourseTeacherRelation.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelationEN.CardNo = objRow[convcc_CourseTeacherRelation.CardNo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CardNo].ToString().Trim(); //卡号
objvcc_CourseTeacherRelationEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelationEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelationEN.UpdDate = objRow[convcc_CourseTeacherRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelationEN.UpdUser = objRow[convcc_CourseTeacherRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelationEN.Memo = objRow[convcc_CourseTeacherRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseTeacherRelationIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_CourseTeacherRelationEN> GetObjLstByCourseTeacherRelationIdLstCache(List<long> arrCourseTeacherRelationIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvcc_CourseTeacherRelationEN._CurrTabName, strCourseId);
List<clsvcc_CourseTeacherRelationEN> arrvcc_CourseTeacherRelationObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseTeacherRelationEN> arrvcc_CourseTeacherRelationObjLst_Sel =
arrvcc_CourseTeacherRelationObjLstCache
.Where(x => arrCourseTeacherRelationIdLst.Contains(x.CourseTeacherRelationId));
return arrvcc_CourseTeacherRelationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseTeacherRelationEN> GetObjLst(string strWhereCond)
{
List<clsvcc_CourseTeacherRelationEN> arrObjLst = new List<clsvcc_CourseTeacherRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN = new clsvcc_CourseTeacherRelationEN();
try
{
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelationEN.CourseId = objRow[convcc_CourseTeacherRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelationEN.CourseCode = objRow[convcc_CourseTeacherRelation.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelationEN.CourseDescription = objRow[convcc_CourseTeacherRelation.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelationEN.CourseName = objRow[convcc_CourseTeacherRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelationEN.CourseTypeID = objRow[convcc_CourseTeacherRelation.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelationEN.CreateDate = objRow[convcc_CourseTeacherRelation.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelationEN.ExcellentTypeId = objRow[convcc_CourseTeacherRelation.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseTeacherRelationEN.ExcellentYear = objRow[convcc_CourseTeacherRelation.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseTeacherRelationEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseTeacherRelationEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseTeacherRelationEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelationEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelationEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseTeacherRelationEN.OperationDate = objRow[convcc_CourseTeacherRelation.OperationDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseTeacherRelationEN.OrderNum = objRow[convcc_CourseTeacherRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelationEN.OuterLink = objRow[convcc_CourseTeacherRelation.OuterLink] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseTeacherRelationEN.ViewCount = objRow[convcc_CourseTeacherRelation.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelationEN.ThemeId = objRow[convcc_CourseTeacherRelation.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseTeacherRelationEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelationEN.IdXzMajor = objRow[convcc_CourseTeacherRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelationEN.IdXzCollege = objRow[convcc_CourseTeacherRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelationEN.IdTeacher = objRow[convcc_CourseTeacherRelation.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelationEN.TeacherID = objRow[convcc_CourseTeacherRelation.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelationEN.TeacherName = objRow[convcc_CourseTeacherRelation.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelationEN.CardNo = objRow[convcc_CourseTeacherRelation.CardNo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CardNo].ToString().Trim(); //卡号
objvcc_CourseTeacherRelationEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelationEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelationEN.UpdDate = objRow[convcc_CourseTeacherRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelationEN.UpdUser = objRow[convcc_CourseTeacherRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelationEN.Memo = objRow[convcc_CourseTeacherRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelationEN);
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
public static List<clsvcc_CourseTeacherRelationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseTeacherRelationEN> arrObjLst = new List<clsvcc_CourseTeacherRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN = new clsvcc_CourseTeacherRelationEN();
try
{
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelationEN.CourseId = objRow[convcc_CourseTeacherRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelationEN.CourseCode = objRow[convcc_CourseTeacherRelation.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelationEN.CourseDescription = objRow[convcc_CourseTeacherRelation.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelationEN.CourseName = objRow[convcc_CourseTeacherRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelationEN.CourseTypeID = objRow[convcc_CourseTeacherRelation.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelationEN.CreateDate = objRow[convcc_CourseTeacherRelation.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelationEN.ExcellentTypeId = objRow[convcc_CourseTeacherRelation.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseTeacherRelationEN.ExcellentYear = objRow[convcc_CourseTeacherRelation.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseTeacherRelationEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseTeacherRelationEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseTeacherRelationEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelationEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelationEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseTeacherRelationEN.OperationDate = objRow[convcc_CourseTeacherRelation.OperationDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseTeacherRelationEN.OrderNum = objRow[convcc_CourseTeacherRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelationEN.OuterLink = objRow[convcc_CourseTeacherRelation.OuterLink] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseTeacherRelationEN.ViewCount = objRow[convcc_CourseTeacherRelation.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelationEN.ThemeId = objRow[convcc_CourseTeacherRelation.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseTeacherRelationEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelationEN.IdXzMajor = objRow[convcc_CourseTeacherRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelationEN.IdXzCollege = objRow[convcc_CourseTeacherRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelationEN.IdTeacher = objRow[convcc_CourseTeacherRelation.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelationEN.TeacherID = objRow[convcc_CourseTeacherRelation.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelationEN.TeacherName = objRow[convcc_CourseTeacherRelation.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelationEN.CardNo = objRow[convcc_CourseTeacherRelation.CardNo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CardNo].ToString().Trim(); //卡号
objvcc_CourseTeacherRelationEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelationEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelationEN.UpdDate = objRow[convcc_CourseTeacherRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelationEN.UpdUser = objRow[convcc_CourseTeacherRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelationEN.Memo = objRow[convcc_CourseTeacherRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_CourseTeacherRelationEN> GetSubObjLstCache(clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationCond)
{
 string strCourseId = objvcc_CourseTeacherRelationCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvcc_CourseTeacherRelationBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvcc_CourseTeacherRelationEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseTeacherRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseTeacherRelation.AttributeName)
{
if (objvcc_CourseTeacherRelationCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseTeacherRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseTeacherRelationCond[strFldName].ToString());
}
else
{
if (objvcc_CourseTeacherRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseTeacherRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseTeacherRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseTeacherRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseTeacherRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseTeacherRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseTeacherRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseTeacherRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseTeacherRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseTeacherRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseTeacherRelationCond[strFldName]));
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
public static List<clsvcc_CourseTeacherRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_CourseTeacherRelationEN> arrObjLst = new List<clsvcc_CourseTeacherRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN = new clsvcc_CourseTeacherRelationEN();
try
{
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelationEN.CourseId = objRow[convcc_CourseTeacherRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelationEN.CourseCode = objRow[convcc_CourseTeacherRelation.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelationEN.CourseDescription = objRow[convcc_CourseTeacherRelation.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelationEN.CourseName = objRow[convcc_CourseTeacherRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelationEN.CourseTypeID = objRow[convcc_CourseTeacherRelation.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelationEN.CreateDate = objRow[convcc_CourseTeacherRelation.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelationEN.ExcellentTypeId = objRow[convcc_CourseTeacherRelation.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseTeacherRelationEN.ExcellentYear = objRow[convcc_CourseTeacherRelation.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseTeacherRelationEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseTeacherRelationEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseTeacherRelationEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelationEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelationEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseTeacherRelationEN.OperationDate = objRow[convcc_CourseTeacherRelation.OperationDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseTeacherRelationEN.OrderNum = objRow[convcc_CourseTeacherRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelationEN.OuterLink = objRow[convcc_CourseTeacherRelation.OuterLink] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseTeacherRelationEN.ViewCount = objRow[convcc_CourseTeacherRelation.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelationEN.ThemeId = objRow[convcc_CourseTeacherRelation.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseTeacherRelationEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelationEN.IdXzMajor = objRow[convcc_CourseTeacherRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelationEN.IdXzCollege = objRow[convcc_CourseTeacherRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelationEN.IdTeacher = objRow[convcc_CourseTeacherRelation.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelationEN.TeacherID = objRow[convcc_CourseTeacherRelation.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelationEN.TeacherName = objRow[convcc_CourseTeacherRelation.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelationEN.CardNo = objRow[convcc_CourseTeacherRelation.CardNo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CardNo].ToString().Trim(); //卡号
objvcc_CourseTeacherRelationEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelationEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelationEN.UpdDate = objRow[convcc_CourseTeacherRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelationEN.UpdUser = objRow[convcc_CourseTeacherRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelationEN.Memo = objRow[convcc_CourseTeacherRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelationEN);
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
public static List<clsvcc_CourseTeacherRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_CourseTeacherRelationEN> arrObjLst = new List<clsvcc_CourseTeacherRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN = new clsvcc_CourseTeacherRelationEN();
try
{
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelationEN.CourseId = objRow[convcc_CourseTeacherRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelationEN.CourseCode = objRow[convcc_CourseTeacherRelation.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelationEN.CourseDescription = objRow[convcc_CourseTeacherRelation.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelationEN.CourseName = objRow[convcc_CourseTeacherRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelationEN.CourseTypeID = objRow[convcc_CourseTeacherRelation.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelationEN.CreateDate = objRow[convcc_CourseTeacherRelation.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelationEN.ExcellentTypeId = objRow[convcc_CourseTeacherRelation.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseTeacherRelationEN.ExcellentYear = objRow[convcc_CourseTeacherRelation.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseTeacherRelationEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseTeacherRelationEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseTeacherRelationEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelationEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelationEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseTeacherRelationEN.OperationDate = objRow[convcc_CourseTeacherRelation.OperationDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseTeacherRelationEN.OrderNum = objRow[convcc_CourseTeacherRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelationEN.OuterLink = objRow[convcc_CourseTeacherRelation.OuterLink] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseTeacherRelationEN.ViewCount = objRow[convcc_CourseTeacherRelation.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelationEN.ThemeId = objRow[convcc_CourseTeacherRelation.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseTeacherRelationEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelationEN.IdXzMajor = objRow[convcc_CourseTeacherRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelationEN.IdXzCollege = objRow[convcc_CourseTeacherRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelationEN.IdTeacher = objRow[convcc_CourseTeacherRelation.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelationEN.TeacherID = objRow[convcc_CourseTeacherRelation.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelationEN.TeacherName = objRow[convcc_CourseTeacherRelation.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelationEN.CardNo = objRow[convcc_CourseTeacherRelation.CardNo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CardNo].ToString().Trim(); //卡号
objvcc_CourseTeacherRelationEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelationEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelationEN.UpdDate = objRow[convcc_CourseTeacherRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelationEN.UpdUser = objRow[convcc_CourseTeacherRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelationEN.Memo = objRow[convcc_CourseTeacherRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelationEN);
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
List<clsvcc_CourseTeacherRelationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_CourseTeacherRelationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseTeacherRelationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_CourseTeacherRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseTeacherRelationEN> arrObjLst = new List<clsvcc_CourseTeacherRelationEN>(); 
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
	clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN = new clsvcc_CourseTeacherRelationEN();
try
{
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelationEN.CourseId = objRow[convcc_CourseTeacherRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelationEN.CourseCode = objRow[convcc_CourseTeacherRelation.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelationEN.CourseDescription = objRow[convcc_CourseTeacherRelation.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelationEN.CourseName = objRow[convcc_CourseTeacherRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelationEN.CourseTypeID = objRow[convcc_CourseTeacherRelation.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelationEN.CreateDate = objRow[convcc_CourseTeacherRelation.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelationEN.ExcellentTypeId = objRow[convcc_CourseTeacherRelation.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseTeacherRelationEN.ExcellentYear = objRow[convcc_CourseTeacherRelation.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseTeacherRelationEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseTeacherRelationEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseTeacherRelationEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelationEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelationEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseTeacherRelationEN.OperationDate = objRow[convcc_CourseTeacherRelation.OperationDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseTeacherRelationEN.OrderNum = objRow[convcc_CourseTeacherRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelationEN.OuterLink = objRow[convcc_CourseTeacherRelation.OuterLink] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseTeacherRelationEN.ViewCount = objRow[convcc_CourseTeacherRelation.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelationEN.ThemeId = objRow[convcc_CourseTeacherRelation.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseTeacherRelationEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelationEN.IdXzMajor = objRow[convcc_CourseTeacherRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelationEN.IdXzCollege = objRow[convcc_CourseTeacherRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelationEN.IdTeacher = objRow[convcc_CourseTeacherRelation.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelationEN.TeacherID = objRow[convcc_CourseTeacherRelation.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelationEN.TeacherName = objRow[convcc_CourseTeacherRelation.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelationEN.CardNo = objRow[convcc_CourseTeacherRelation.CardNo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CardNo].ToString().Trim(); //卡号
objvcc_CourseTeacherRelationEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelationEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelationEN.UpdDate = objRow[convcc_CourseTeacherRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelationEN.UpdUser = objRow[convcc_CourseTeacherRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelationEN.Memo = objRow[convcc_CourseTeacherRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelationEN);
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
public static List<clsvcc_CourseTeacherRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseTeacherRelationEN> arrObjLst = new List<clsvcc_CourseTeacherRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN = new clsvcc_CourseTeacherRelationEN();
try
{
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelationEN.CourseId = objRow[convcc_CourseTeacherRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelationEN.CourseCode = objRow[convcc_CourseTeacherRelation.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelationEN.CourseDescription = objRow[convcc_CourseTeacherRelation.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelationEN.CourseName = objRow[convcc_CourseTeacherRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelationEN.CourseTypeID = objRow[convcc_CourseTeacherRelation.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelationEN.CreateDate = objRow[convcc_CourseTeacherRelation.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelationEN.ExcellentTypeId = objRow[convcc_CourseTeacherRelation.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseTeacherRelationEN.ExcellentYear = objRow[convcc_CourseTeacherRelation.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseTeacherRelationEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseTeacherRelationEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseTeacherRelationEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelationEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelationEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseTeacherRelationEN.OperationDate = objRow[convcc_CourseTeacherRelation.OperationDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseTeacherRelationEN.OrderNum = objRow[convcc_CourseTeacherRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelationEN.OuterLink = objRow[convcc_CourseTeacherRelation.OuterLink] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseTeacherRelationEN.ViewCount = objRow[convcc_CourseTeacherRelation.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelationEN.ThemeId = objRow[convcc_CourseTeacherRelation.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseTeacherRelationEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelationEN.IdXzMajor = objRow[convcc_CourseTeacherRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelationEN.IdXzCollege = objRow[convcc_CourseTeacherRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelationEN.IdTeacher = objRow[convcc_CourseTeacherRelation.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelationEN.TeacherID = objRow[convcc_CourseTeacherRelation.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelationEN.TeacherName = objRow[convcc_CourseTeacherRelation.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelationEN.CardNo = objRow[convcc_CourseTeacherRelation.CardNo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CardNo].ToString().Trim(); //卡号
objvcc_CourseTeacherRelationEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelationEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelationEN.UpdDate = objRow[convcc_CourseTeacherRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelationEN.UpdUser = objRow[convcc_CourseTeacherRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelationEN.Memo = objRow[convcc_CourseTeacherRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_CourseTeacherRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_CourseTeacherRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseTeacherRelationEN> arrObjLst = new List<clsvcc_CourseTeacherRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN = new clsvcc_CourseTeacherRelationEN();
try
{
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelationEN.CourseId = objRow[convcc_CourseTeacherRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelationEN.CourseCode = objRow[convcc_CourseTeacherRelation.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelationEN.CourseDescription = objRow[convcc_CourseTeacherRelation.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelationEN.CourseName = objRow[convcc_CourseTeacherRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelationEN.CourseTypeID = objRow[convcc_CourseTeacherRelation.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelationEN.CreateDate = objRow[convcc_CourseTeacherRelation.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelationEN.ExcellentTypeId = objRow[convcc_CourseTeacherRelation.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseTeacherRelationEN.ExcellentYear = objRow[convcc_CourseTeacherRelation.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseTeacherRelationEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseTeacherRelationEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseTeacherRelationEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelationEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelationEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseTeacherRelationEN.OperationDate = objRow[convcc_CourseTeacherRelation.OperationDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseTeacherRelationEN.OrderNum = objRow[convcc_CourseTeacherRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelationEN.OuterLink = objRow[convcc_CourseTeacherRelation.OuterLink] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseTeacherRelationEN.ViewCount = objRow[convcc_CourseTeacherRelation.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelationEN.ThemeId = objRow[convcc_CourseTeacherRelation.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseTeacherRelationEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelationEN.IdXzMajor = objRow[convcc_CourseTeacherRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelationEN.IdXzCollege = objRow[convcc_CourseTeacherRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelationEN.IdTeacher = objRow[convcc_CourseTeacherRelation.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelationEN.TeacherID = objRow[convcc_CourseTeacherRelation.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelationEN.TeacherName = objRow[convcc_CourseTeacherRelation.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelationEN.CardNo = objRow[convcc_CourseTeacherRelation.CardNo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CardNo].ToString().Trim(); //卡号
objvcc_CourseTeacherRelationEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelationEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelationEN.UpdDate = objRow[convcc_CourseTeacherRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelationEN.UpdUser = objRow[convcc_CourseTeacherRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelationEN.Memo = objRow[convcc_CourseTeacherRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelationEN);
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
public static List<clsvcc_CourseTeacherRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_CourseTeacherRelationEN> arrObjLst = new List<clsvcc_CourseTeacherRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN = new clsvcc_CourseTeacherRelationEN();
try
{
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelationEN.CourseId = objRow[convcc_CourseTeacherRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelationEN.CourseCode = objRow[convcc_CourseTeacherRelation.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelationEN.CourseDescription = objRow[convcc_CourseTeacherRelation.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelationEN.CourseName = objRow[convcc_CourseTeacherRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelationEN.CourseTypeID = objRow[convcc_CourseTeacherRelation.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelationEN.CreateDate = objRow[convcc_CourseTeacherRelation.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelationEN.ExcellentTypeId = objRow[convcc_CourseTeacherRelation.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseTeacherRelationEN.ExcellentYear = objRow[convcc_CourseTeacherRelation.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseTeacherRelationEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseTeacherRelationEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseTeacherRelationEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelationEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelationEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseTeacherRelationEN.OperationDate = objRow[convcc_CourseTeacherRelation.OperationDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseTeacherRelationEN.OrderNum = objRow[convcc_CourseTeacherRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelationEN.OuterLink = objRow[convcc_CourseTeacherRelation.OuterLink] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseTeacherRelationEN.ViewCount = objRow[convcc_CourseTeacherRelation.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelationEN.ThemeId = objRow[convcc_CourseTeacherRelation.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseTeacherRelationEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelationEN.IdXzMajor = objRow[convcc_CourseTeacherRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelationEN.IdXzCollege = objRow[convcc_CourseTeacherRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelationEN.IdTeacher = objRow[convcc_CourseTeacherRelation.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelationEN.TeacherID = objRow[convcc_CourseTeacherRelation.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelationEN.TeacherName = objRow[convcc_CourseTeacherRelation.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelationEN.CardNo = objRow[convcc_CourseTeacherRelation.CardNo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CardNo].ToString().Trim(); //卡号
objvcc_CourseTeacherRelationEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelationEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelationEN.UpdDate = objRow[convcc_CourseTeacherRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelationEN.UpdUser = objRow[convcc_CourseTeacherRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelationEN.Memo = objRow[convcc_CourseTeacherRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseTeacherRelationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_CourseTeacherRelationEN> arrObjLst = new List<clsvcc_CourseTeacherRelationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN = new clsvcc_CourseTeacherRelationEN();
try
{
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelationEN.CourseId = objRow[convcc_CourseTeacherRelation.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelationEN.CourseCode = objRow[convcc_CourseTeacherRelation.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelationEN.CourseDescription = objRow[convcc_CourseTeacherRelation.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelationEN.CourseName = objRow[convcc_CourseTeacherRelation.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelationEN.CourseTypeID = objRow[convcc_CourseTeacherRelation.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelationEN.CreateDate = objRow[convcc_CourseTeacherRelation.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelationEN.ExcellentTypeId = objRow[convcc_CourseTeacherRelation.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseTeacherRelationEN.ExcellentYear = objRow[convcc_CourseTeacherRelation.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseTeacherRelationEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseTeacherRelationEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseTeacherRelationEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelationEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelationEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseTeacherRelationEN.OperationDate = objRow[convcc_CourseTeacherRelation.OperationDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseTeacherRelationEN.OrderNum = objRow[convcc_CourseTeacherRelation.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelationEN.OuterLink = objRow[convcc_CourseTeacherRelation.OuterLink] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseTeacherRelationEN.ViewCount = objRow[convcc_CourseTeacherRelation.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelationEN.ThemeId = objRow[convcc_CourseTeacherRelation.ThemeId] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseTeacherRelationEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelationEN.IdXzMajor = objRow[convcc_CourseTeacherRelation.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelationEN.IdXzCollege = objRow[convcc_CourseTeacherRelation.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelationEN.IdTeacher = objRow[convcc_CourseTeacherRelation.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelationEN.TeacherID = objRow[convcc_CourseTeacherRelation.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelationEN.TeacherName = objRow[convcc_CourseTeacherRelation.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelationEN.CardNo = objRow[convcc_CourseTeacherRelation.CardNo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.CardNo].ToString().Trim(); //卡号
objvcc_CourseTeacherRelationEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelationEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelationEN.UpdDate = objRow[convcc_CourseTeacherRelation.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelationEN.UpdUser = objRow[convcc_CourseTeacherRelation.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelationEN.Memo = objRow[convcc_CourseTeacherRelation.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_CourseTeacherRelation(ref clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN)
{
bool bolResult = vcc_CourseTeacherRelationDA.Getvcc_CourseTeacherRelation(ref objvcc_CourseTeacherRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngCourseTeacherRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseTeacherRelationEN GetObjByCourseTeacherRelationId(long lngCourseTeacherRelationId)
{
clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN = vcc_CourseTeacherRelationDA.GetObjByCourseTeacherRelationId(lngCourseTeacherRelationId);
return objvcc_CourseTeacherRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_CourseTeacherRelationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN = vcc_CourseTeacherRelationDA.GetFirstObj(strWhereCond);
 return objvcc_CourseTeacherRelationEN;
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
public static clsvcc_CourseTeacherRelationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN = vcc_CourseTeacherRelationDA.GetObjByDataRow(objRow);
 return objvcc_CourseTeacherRelationEN;
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
public static clsvcc_CourseTeacherRelationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN = vcc_CourseTeacherRelationDA.GetObjByDataRow(objRow);
 return objvcc_CourseTeacherRelationEN;
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
 /// <param name = "lngCourseTeacherRelationId">所给的关键字</param>
 /// <param name = "lstvcc_CourseTeacherRelationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseTeacherRelationEN GetObjByCourseTeacherRelationIdFromList(long lngCourseTeacherRelationId, List<clsvcc_CourseTeacherRelationEN> lstvcc_CourseTeacherRelationObjLst)
{
foreach (clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN in lstvcc_CourseTeacherRelationObjLst)
{
if (objvcc_CourseTeacherRelationEN.CourseTeacherRelationId == lngCourseTeacherRelationId)
{
return objvcc_CourseTeacherRelationEN;
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
 long lngCourseTeacherRelationId;
 try
 {
 lngCourseTeacherRelationId = new clsvcc_CourseTeacherRelationDA().GetFirstID(strWhereCond);
 return lngCourseTeacherRelationId;
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
 arrList = vcc_CourseTeacherRelationDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_CourseTeacherRelationDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngCourseTeacherRelationId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngCourseTeacherRelationId)
{
//检测记录是否存在
bool bolIsExist = vcc_CourseTeacherRelationDA.IsExist(lngCourseTeacherRelationId);
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
 bolIsExist = clsvcc_CourseTeacherRelationDA.IsExistTable();
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
 bolIsExist = vcc_CourseTeacherRelationDA.IsExistTable(strTabName);
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
objvcc_CourseTeacherRelationENT.IdXzMajor = objvcc_CourseTeacherRelationENS.IdXzMajor; //专业流水号
objvcc_CourseTeacherRelationENT.IdXzCollege = objvcc_CourseTeacherRelationENS.IdXzCollege; //学院流水号
objvcc_CourseTeacherRelationENT.IdTeacher = objvcc_CourseTeacherRelationENS.IdTeacher; //教师流水号
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
 /// <param name = "objvcc_CourseTeacherRelationEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN)
{
try
{
objvcc_CourseTeacherRelationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_CourseTeacherRelationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_CourseTeacherRelation.CourseTeacherRelationId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.CourseTeacherRelationId = objvcc_CourseTeacherRelationEN.CourseTeacherRelationId; //课程教师关系表流水号
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.CourseId = objvcc_CourseTeacherRelationEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.CourseCode = objvcc_CourseTeacherRelationEN.CourseCode == "[null]" ? null :  objvcc_CourseTeacherRelationEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.CourseDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.CourseDescription = objvcc_CourseTeacherRelationEN.CourseDescription == "[null]" ? null :  objvcc_CourseTeacherRelationEN.CourseDescription; //课程描述
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.CourseName = objvcc_CourseTeacherRelationEN.CourseName == "[null]" ? null :  objvcc_CourseTeacherRelationEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.CourseTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.CourseTypeID = objvcc_CourseTeacherRelationEN.CourseTypeID == "[null]" ? null :  objvcc_CourseTeacherRelationEN.CourseTypeID; //课程类型ID
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.CreateDate = objvcc_CourseTeacherRelationEN.CreateDate == "[null]" ? null :  objvcc_CourseTeacherRelationEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.ExcellentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.ExcellentTypeId = objvcc_CourseTeacherRelationEN.ExcellentTypeId == "[null]" ? null :  objvcc_CourseTeacherRelationEN.ExcellentTypeId; //精品课程类型Id
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.ExcellentYear, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.ExcellentYear = objvcc_CourseTeacherRelationEN.ExcellentYear; //课程年份
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.IsBuildingCourse, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.IsBuildingCourse = objvcc_CourseTeacherRelationEN.IsBuildingCourse; //是否已建设课程
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.IsDoubleLanguageCourse, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.IsDoubleLanguageCourse = objvcc_CourseTeacherRelationEN.IsDoubleLanguageCourse; //是否双语课程
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.IsOpen, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.IsOpen = objvcc_CourseTeacherRelationEN.IsOpen; //是否公开
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.IsRecommendedCourse, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.IsRecommendedCourse = objvcc_CourseTeacherRelationEN.IsRecommendedCourse; //是否推荐课程
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.IsSelfPropelledCourse, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.IsSelfPropelledCourse = objvcc_CourseTeacherRelationEN.IsSelfPropelledCourse; //是否自荐课程
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.OperationDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.OperationDate = objvcc_CourseTeacherRelationEN.OperationDate == "[null]" ? null :  objvcc_CourseTeacherRelationEN.OperationDate; //操作时间
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.OrderNum = objvcc_CourseTeacherRelationEN.OrderNum; //序号
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.OuterLink, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.OuterLink = objvcc_CourseTeacherRelationEN.OuterLink == "[null]" ? null :  objvcc_CourseTeacherRelationEN.OuterLink; //外链地址
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.ViewCount = objvcc_CourseTeacherRelationEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.ThemeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.ThemeId = objvcc_CourseTeacherRelationEN.ThemeId == "[null]" ? null :  objvcc_CourseTeacherRelationEN.ThemeId; //主题Id
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.ExampleImgPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.ExampleImgPath = objvcc_CourseTeacherRelationEN.ExampleImgPath == "[null]" ? null :  objvcc_CourseTeacherRelationEN.ExampleImgPath; //示例图路径
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.IdXzMajor = objvcc_CourseTeacherRelationEN.IdXzMajor == "[null]" ? null :  objvcc_CourseTeacherRelationEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.IdXzCollege = objvcc_CourseTeacherRelationEN.IdXzCollege == "[null]" ? null :  objvcc_CourseTeacherRelationEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.IdTeacher, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.IdTeacher = objvcc_CourseTeacherRelationEN.IdTeacher; //教师流水号
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.TeacherID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.TeacherID = objvcc_CourseTeacherRelationEN.TeacherID == "[null]" ? null :  objvcc_CourseTeacherRelationEN.TeacherID; //教师工号
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.TeacherName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.TeacherName = objvcc_CourseTeacherRelationEN.TeacherName == "[null]" ? null :  objvcc_CourseTeacherRelationEN.TeacherName; //教师姓名
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.CardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.CardNo = objvcc_CourseTeacherRelationEN.CardNo == "[null]" ? null :  objvcc_CourseTeacherRelationEN.CardNo; //卡号
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.IsCourseManager, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.IsCourseManager = objvcc_CourseTeacherRelationEN.IsCourseManager; //是否课程主要人
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.LastVisitedDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.LastVisitedDate = objvcc_CourseTeacherRelationEN.LastVisitedDate == "[null]" ? null :  objvcc_CourseTeacherRelationEN.LastVisitedDate; //最后访问时间
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.UpdDate = objvcc_CourseTeacherRelationEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.UpdUser = objvcc_CourseTeacherRelationEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelationEN.Memo = objvcc_CourseTeacherRelationEN.Memo == "[null]" ? null :  objvcc_CourseTeacherRelationEN.Memo; //备注
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
 /// <param name = "objvcc_CourseTeacherRelationEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN)
{
try
{
if (objvcc_CourseTeacherRelationEN.CourseCode == "[null]") objvcc_CourseTeacherRelationEN.CourseCode = null; //课程代码
if (objvcc_CourseTeacherRelationEN.CourseDescription == "[null]") objvcc_CourseTeacherRelationEN.CourseDescription = null; //课程描述
if (objvcc_CourseTeacherRelationEN.CourseName == "[null]") objvcc_CourseTeacherRelationEN.CourseName = null; //课程名称
if (objvcc_CourseTeacherRelationEN.CourseTypeID == "[null]") objvcc_CourseTeacherRelationEN.CourseTypeID = null; //课程类型ID
if (objvcc_CourseTeacherRelationEN.CreateDate == "[null]") objvcc_CourseTeacherRelationEN.CreateDate = null; //建立日期
if (objvcc_CourseTeacherRelationEN.ExcellentTypeId == "[null]") objvcc_CourseTeacherRelationEN.ExcellentTypeId = null; //精品课程类型Id
if (objvcc_CourseTeacherRelationEN.OperationDate == "[null]") objvcc_CourseTeacherRelationEN.OperationDate = null; //操作时间
if (objvcc_CourseTeacherRelationEN.OuterLink == "[null]") objvcc_CourseTeacherRelationEN.OuterLink = null; //外链地址
if (objvcc_CourseTeacherRelationEN.ThemeId == "[null]") objvcc_CourseTeacherRelationEN.ThemeId = null; //主题Id
if (objvcc_CourseTeacherRelationEN.ExampleImgPath == "[null]") objvcc_CourseTeacherRelationEN.ExampleImgPath = null; //示例图路径
if (objvcc_CourseTeacherRelationEN.IdXzMajor == "[null]") objvcc_CourseTeacherRelationEN.IdXzMajor = null; //专业流水号
if (objvcc_CourseTeacherRelationEN.IdXzCollege == "[null]") objvcc_CourseTeacherRelationEN.IdXzCollege = null; //学院流水号
if (objvcc_CourseTeacherRelationEN.TeacherID == "[null]") objvcc_CourseTeacherRelationEN.TeacherID = null; //教师工号
if (objvcc_CourseTeacherRelationEN.TeacherName == "[null]") objvcc_CourseTeacherRelationEN.TeacherName = null; //教师姓名
if (objvcc_CourseTeacherRelationEN.CardNo == "[null]") objvcc_CourseTeacherRelationEN.CardNo = null; //卡号
if (objvcc_CourseTeacherRelationEN.LastVisitedDate == "[null]") objvcc_CourseTeacherRelationEN.LastVisitedDate = null; //最后访问时间
if (objvcc_CourseTeacherRelationEN.Memo == "[null]") objvcc_CourseTeacherRelationEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationEN)
{
 vcc_CourseTeacherRelationDA.CheckProperty4Condition(objvcc_CourseTeacherRelationEN);
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
if (clsTeacherInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoBL没有刷新缓存机制(clsTeacherInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTeacherRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTeacherRelationBL没有刷新缓存机制(clscc_CourseTeacherRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by CourseTeacherRelationId");
//if (arrvcc_CourseTeacherRelationObjLstCache == null)
//{
//arrvcc_CourseTeacherRelationObjLstCache = vcc_CourseTeacherRelationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngCourseTeacherRelationId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseTeacherRelationEN GetObjByCourseTeacherRelationIdCache(long lngCourseTeacherRelationId, string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvcc_CourseTeacherRelationEN._CurrTabName, strCourseId);
List<clsvcc_CourseTeacherRelationEN> arrvcc_CourseTeacherRelationObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseTeacherRelationEN> arrvcc_CourseTeacherRelationObjLst_Sel =
arrvcc_CourseTeacherRelationObjLstCache
.Where(x=> x.CourseTeacherRelationId == lngCourseTeacherRelationId 
);
if (arrvcc_CourseTeacherRelationObjLst_Sel.Count() == 0)
{
   clsvcc_CourseTeacherRelationEN obj = clsvcc_CourseTeacherRelationBL.GetObjByCourseTeacherRelationId(lngCourseTeacherRelationId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngCourseTeacherRelationId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvcc_CourseTeacherRelationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseTeacherRelationEN> GetAllvcc_CourseTeacherRelationObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvcc_CourseTeacherRelationEN> arrvcc_CourseTeacherRelationObjLstCache = GetObjLstCache(strCourseId); 
return arrvcc_CourseTeacherRelationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseTeacherRelationEN> GetObjLstCache(string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_CourseTeacherRelationEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvcc_CourseTeacherRelationEN> arrvcc_CourseTeacherRelationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvcc_CourseTeacherRelationObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvcc_CourseTeacherRelationEN._CurrTabName, strCourseId);
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
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngCourseTeacherRelationId, string strCourseId)
{
if (strInFldName != convcc_CourseTeacherRelation.CourseTeacherRelationId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_CourseTeacherRelation.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_CourseTeacherRelation.AttributeName));
throw new Exception(strMsg);
}
var objvcc_CourseTeacherRelation = clsvcc_CourseTeacherRelationBL.GetObjByCourseTeacherRelationIdCache(lngCourseTeacherRelationId, strCourseId);
if (objvcc_CourseTeacherRelation == null) return "";
return objvcc_CourseTeacherRelation[strOutFldName].ToString();
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
int intRecCount = clsvcc_CourseTeacherRelationDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_CourseTeacherRelationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_CourseTeacherRelationDA.GetRecCount();
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
int intRecCount = clsvcc_CourseTeacherRelationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_CourseTeacherRelationEN objvcc_CourseTeacherRelationCond)
{
 string strCourseId = objvcc_CourseTeacherRelationCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvcc_CourseTeacherRelationBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvcc_CourseTeacherRelationEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseTeacherRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseTeacherRelation.AttributeName)
{
if (objvcc_CourseTeacherRelationCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseTeacherRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseTeacherRelationCond[strFldName].ToString());
}
else
{
if (objvcc_CourseTeacherRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseTeacherRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseTeacherRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseTeacherRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseTeacherRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseTeacherRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseTeacherRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseTeacherRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseTeacherRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseTeacherRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseTeacherRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseTeacherRelationCond[strFldName]));
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
 List<string> arrList = clsvcc_CourseTeacherRelationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseTeacherRelationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseTeacherRelationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}