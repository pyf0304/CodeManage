
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseProBL
 表名:vcc_CoursePro(01120213)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:44
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
public static class  clsvcc_CourseProBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseProEN GetObj(this K_CourseId_vcc_CoursePro myKey)
{
clsvcc_CourseProEN objvcc_CourseProEN = clsvcc_CourseProBL.vcc_CourseProDA.GetObjByCourseId(myKey.Value);
return objvcc_CourseProEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetCourseId(this clsvcc_CourseProEN objvcc_CourseProEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CoursePro.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CoursePro.CourseId);
}
objvcc_CourseProEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.CourseId) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.CourseId, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.CourseId] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetLikeCount(this clsvcc_CourseProEN objvcc_CourseProEN, int? intLikeCount, string strComparisonOp="")
	{
objvcc_CourseProEN.LikeCount = intLikeCount; //LikeCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.LikeCount) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.LikeCount, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.LikeCount] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetCourseCode(this clsvcc_CourseProEN objvcc_CourseProEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convcc_CoursePro.CourseCode);
}
objvcc_CourseProEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.CourseCode) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.CourseCode, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.CourseCode] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetCourseDescription(this clsvcc_CourseProEN objvcc_CourseProEN, string strCourseDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, convcc_CoursePro.CourseDescription);
}
objvcc_CourseProEN.CourseDescription = strCourseDescription; //课程描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.CourseDescription) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.CourseDescription, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.CourseDescription] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetCourseName(this clsvcc_CourseProEN objvcc_CourseProEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseName, convcc_CoursePro.CourseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CoursePro.CourseName);
}
objvcc_CourseProEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.CourseName) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.CourseName, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.CourseName] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetCourseTypeId(this clsvcc_CourseProEN objvcc_CourseProEN, string strCourseTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseTypeId, 4, convcc_CoursePro.CourseTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseTypeId, 4, convcc_CoursePro.CourseTypeId);
}
objvcc_CourseProEN.CourseTypeId = strCourseTypeId; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.CourseTypeId) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.CourseTypeId, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.CourseTypeId] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetCourseTypeName(this clsvcc_CourseProEN objvcc_CourseProEN, string strCourseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, convcc_CoursePro.CourseTypeName);
}
objvcc_CourseProEN.CourseTypeName = strCourseTypeName; //课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.CourseTypeName) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.CourseTypeName, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.CourseTypeName] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetCreateDate(this clsvcc_CourseProEN objvcc_CourseProEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_CoursePro.CreateDate);
}
objvcc_CourseProEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.CreateDate) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.CreateDate, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.CreateDate] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetExcellentTypeId(this clsvcc_CourseProEN objvcc_CourseProEN, string strExcellentTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExcellentTypeId, 4, convcc_CoursePro.ExcellentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExcellentTypeId, 4, convcc_CoursePro.ExcellentTypeId);
}
objvcc_CourseProEN.ExcellentTypeId = strExcellentTypeId; //精品课程类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.ExcellentTypeId) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.ExcellentTypeId, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.ExcellentTypeId] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetExcellentTypeName(this clsvcc_CourseProEN objvcc_CourseProEN, string strExcellentTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExcellentTypeName, 30, convcc_CoursePro.ExcellentTypeName);
}
objvcc_CourseProEN.ExcellentTypeName = strExcellentTypeName; //精品课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.ExcellentTypeName) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.ExcellentTypeName, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.ExcellentTypeName] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetExcellentYear(this clsvcc_CourseProEN objvcc_CourseProEN, int intExcellentYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intExcellentYear, convcc_CoursePro.ExcellentYear);
objvcc_CourseProEN.ExcellentYear = intExcellentYear; //课程年份
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.ExcellentYear) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.ExcellentYear, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.ExcellentYear] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetIsBuildingCourse(this clsvcc_CourseProEN objvcc_CourseProEN, bool bolIsBuildingCourse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsBuildingCourse, convcc_CoursePro.IsBuildingCourse);
objvcc_CourseProEN.IsBuildingCourse = bolIsBuildingCourse; //是否已建设课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.IsBuildingCourse) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.IsBuildingCourse, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.IsBuildingCourse] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetIsDoubleLanguageCourse(this clsvcc_CourseProEN objvcc_CourseProEN, bool bolIsDoubleLanguageCourse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDoubleLanguageCourse, convcc_CoursePro.IsDoubleLanguageCourse);
objvcc_CourseProEN.IsDoubleLanguageCourse = bolIsDoubleLanguageCourse; //是否双语课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.IsDoubleLanguageCourse) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.IsDoubleLanguageCourse, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.IsDoubleLanguageCourse] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetIsOpen(this clsvcc_CourseProEN objvcc_CourseProEN, bool bolIsOpen, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsOpen, convcc_CoursePro.IsOpen);
objvcc_CourseProEN.IsOpen = bolIsOpen; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.IsOpen) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.IsOpen, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.IsOpen] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetIsRecommendedCourse(this clsvcc_CourseProEN objvcc_CourseProEN, bool bolIsRecommendedCourse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsRecommendedCourse, convcc_CoursePro.IsRecommendedCourse);
objvcc_CourseProEN.IsRecommendedCourse = bolIsRecommendedCourse; //是否推荐课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.IsRecommendedCourse) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.IsRecommendedCourse, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.IsRecommendedCourse] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetIsSelfPropelledCourse(this clsvcc_CourseProEN objvcc_CourseProEN, bool bolIsSelfPropelledCourse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsSelfPropelledCourse, convcc_CoursePro.IsSelfPropelledCourse);
objvcc_CourseProEN.IsSelfPropelledCourse = bolIsSelfPropelledCourse; //是否自荐课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.IsSelfPropelledCourse) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.IsSelfPropelledCourse, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.IsSelfPropelledCourse] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetOperationDate(this clsvcc_CourseProEN objvcc_CourseProEN, string strOperationDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationDate, 20, convcc_CoursePro.OperationDate);
}
objvcc_CourseProEN.OperationDate = strOperationDate; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.OperationDate) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.OperationDate, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.OperationDate] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetOrderNum(this clsvcc_CourseProEN objvcc_CourseProEN, int? intOrderNum, string strComparisonOp="")
	{
objvcc_CourseProEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.OrderNum) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.OrderNum, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.OrderNum] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetOuterLink(this clsvcc_CourseProEN objvcc_CourseProEN, string strOuterLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOuterLink, 500, convcc_CoursePro.OuterLink);
}
objvcc_CourseProEN.OuterLink = strOuterLink; //外链地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.OuterLink) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.OuterLink, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.OuterLink] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetViewCount(this clsvcc_CourseProEN objvcc_CourseProEN, int intViewCount, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intViewCount, convcc_CoursePro.ViewCount);
objvcc_CourseProEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.ViewCount) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.ViewCount, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.ViewCount] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetThemeId(this clsvcc_CourseProEN objvcc_CourseProEN, string strThemeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThemeId, 4, convcc_CoursePro.ThemeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strThemeId, 4, convcc_CoursePro.ThemeId);
}
objvcc_CourseProEN.ThemeId = strThemeId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.ThemeId) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.ThemeId, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.ThemeId] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetThemeName(this clsvcc_CourseProEN objvcc_CourseProEN, string strThemeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThemeName, 200, convcc_CoursePro.ThemeName);
}
objvcc_CourseProEN.ThemeName = strThemeName; //主题名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.ThemeName) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.ThemeName, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.ThemeName] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetExampleImgPath(this clsvcc_CourseProEN objvcc_CourseProEN, string strExampleImgPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExampleImgPath, 300, convcc_CoursePro.ExampleImgPath);
}
objvcc_CourseProEN.ExampleImgPath = strExampleImgPath; //示例图路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.ExampleImgPath) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.ExampleImgPath, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.ExampleImgPath] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetIdXzMajor(this clsvcc_CourseProEN objvcc_CourseProEN, string strIdXzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzMajor, convcc_CoursePro.IdXzMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convcc_CoursePro.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convcc_CoursePro.IdXzMajor);
}
objvcc_CourseProEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.IdXzMajor) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.IdXzMajor, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.IdXzMajor] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetMajorID(this clsvcc_CourseProEN objvcc_CourseProEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convcc_CoursePro.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convcc_CoursePro.MajorID);
}
objvcc_CourseProEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.MajorID) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.MajorID, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.MajorID] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetMajorName(this clsvcc_CourseProEN objvcc_CourseProEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_CoursePro.MajorName);
}
objvcc_CourseProEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.MajorName) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.MajorName, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.MajorName] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetIdXzCollege(this clsvcc_CourseProEN objvcc_CourseProEN, string strIdXzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzCollege, convcc_CoursePro.IdXzCollege);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convcc_CoursePro.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convcc_CoursePro.IdXzCollege);
}
objvcc_CourseProEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.IdXzCollege) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.IdXzCollege, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.IdXzCollege] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetCollegeId(this clsvcc_CourseProEN objvcc_CourseProEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convcc_CoursePro.CollegeId);
}
objvcc_CourseProEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.CollegeId) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.CollegeId, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.CollegeId] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetCollegeName(this clsvcc_CourseProEN objvcc_CourseProEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_CoursePro.CollegeName);
}
objvcc_CourseProEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.CollegeName) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.CollegeName, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.CollegeName] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetCollegeNameA(this clsvcc_CourseProEN objvcc_CourseProEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_CoursePro.CollegeNameA);
}
objvcc_CourseProEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.CollegeNameA) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.CollegeNameA, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.CollegeNameA] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetMemo(this clsvcc_CourseProEN objvcc_CourseProEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CoursePro.Memo);
}
objvcc_CourseProEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.Memo) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.Memo, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.Memo] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetQuestionNum(this clsvcc_CourseProEN objvcc_CourseProEN, int? intQuestionNum, string strComparisonOp="")
	{
objvcc_CourseProEN.QuestionNum = intQuestionNum; //题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.QuestionNum) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.QuestionNum, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.QuestionNum] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetKnowledgesNum(this clsvcc_CourseProEN objvcc_CourseProEN, int? intKnowledgesNum, string strComparisonOp="")
	{
objvcc_CourseProEN.KnowledgesNum = intKnowledgesNum; //知识点数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.KnowledgesNum) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.KnowledgesNum, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.KnowledgesNum] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetTeacherNum(this clsvcc_CourseProEN objvcc_CourseProEN, int? intTeacherNum, string strComparisonOp="")
	{
objvcc_CourseProEN.TeacherNum = intTeacherNum; //教师数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.TeacherNum) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.TeacherNum, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.TeacherNum] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseProEN SetChapterNum(this clsvcc_CourseProEN objvcc_CourseProEN, int? intChapterNum, string strComparisonOp="")
	{
objvcc_CourseProEN.ChapterNum = intChapterNum; //章节数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseProEN.dicFldComparisonOp.ContainsKey(convcc_CoursePro.ChapterNum) == false)
{
objvcc_CourseProEN.dicFldComparisonOp.Add(convcc_CoursePro.ChapterNum, strComparisonOp);
}
else
{
objvcc_CourseProEN.dicFldComparisonOp[convcc_CoursePro.ChapterNum] = strComparisonOp;
}
}
return objvcc_CourseProEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_CourseProENS">源对象</param>
 /// <param name = "objvcc_CourseProENT">目标对象</param>
 public static void CopyTo(this clsvcc_CourseProEN objvcc_CourseProENS, clsvcc_CourseProEN objvcc_CourseProENT)
{
try
{
objvcc_CourseProENT.CourseId = objvcc_CourseProENS.CourseId; //课程Id
objvcc_CourseProENT.LikeCount = objvcc_CourseProENS.LikeCount; //LikeCount
objvcc_CourseProENT.CourseCode = objvcc_CourseProENS.CourseCode; //课程代码
objvcc_CourseProENT.CourseDescription = objvcc_CourseProENS.CourseDescription; //课程描述
objvcc_CourseProENT.CourseName = objvcc_CourseProENS.CourseName; //课程名称
objvcc_CourseProENT.CourseTypeId = objvcc_CourseProENS.CourseTypeId; //课程类型ID
objvcc_CourseProENT.CourseTypeName = objvcc_CourseProENS.CourseTypeName; //课程类型名称
objvcc_CourseProENT.CreateDate = objvcc_CourseProENS.CreateDate; //建立日期
objvcc_CourseProENT.ExcellentTypeId = objvcc_CourseProENS.ExcellentTypeId; //精品课程类型Id
objvcc_CourseProENT.ExcellentTypeName = objvcc_CourseProENS.ExcellentTypeName; //精品课程类型名称
objvcc_CourseProENT.ExcellentYear = objvcc_CourseProENS.ExcellentYear; //课程年份
objvcc_CourseProENT.IsBuildingCourse = objvcc_CourseProENS.IsBuildingCourse; //是否已建设课程
objvcc_CourseProENT.IsDoubleLanguageCourse = objvcc_CourseProENS.IsDoubleLanguageCourse; //是否双语课程
objvcc_CourseProENT.IsOpen = objvcc_CourseProENS.IsOpen; //是否公开
objvcc_CourseProENT.IsRecommendedCourse = objvcc_CourseProENS.IsRecommendedCourse; //是否推荐课程
objvcc_CourseProENT.IsSelfPropelledCourse = objvcc_CourseProENS.IsSelfPropelledCourse; //是否自荐课程
objvcc_CourseProENT.OperationDate = objvcc_CourseProENS.OperationDate; //操作时间
objvcc_CourseProENT.OrderNum = objvcc_CourseProENS.OrderNum; //序号
objvcc_CourseProENT.OuterLink = objvcc_CourseProENS.OuterLink; //外链地址
objvcc_CourseProENT.ViewCount = objvcc_CourseProENS.ViewCount; //浏览量
objvcc_CourseProENT.ThemeId = objvcc_CourseProENS.ThemeId; //主题Id
objvcc_CourseProENT.ThemeName = objvcc_CourseProENS.ThemeName; //主题名
objvcc_CourseProENT.ExampleImgPath = objvcc_CourseProENS.ExampleImgPath; //示例图路径
objvcc_CourseProENT.IdXzMajor = objvcc_CourseProENS.IdXzMajor; //专业流水号
objvcc_CourseProENT.MajorID = objvcc_CourseProENS.MajorID; //专业ID
objvcc_CourseProENT.MajorName = objvcc_CourseProENS.MajorName; //专业名称
objvcc_CourseProENT.IdXzCollege = objvcc_CourseProENS.IdXzCollege; //学院流水号
objvcc_CourseProENT.CollegeId = objvcc_CourseProENS.CollegeId; //学院ID
objvcc_CourseProENT.CollegeName = objvcc_CourseProENS.CollegeName; //学院名称
objvcc_CourseProENT.CollegeNameA = objvcc_CourseProENS.CollegeNameA; //学院名称简写
objvcc_CourseProENT.Memo = objvcc_CourseProENS.Memo; //备注
objvcc_CourseProENT.QuestionNum = objvcc_CourseProENS.QuestionNum; //题目数
objvcc_CourseProENT.KnowledgesNum = objvcc_CourseProENS.KnowledgesNum; //知识点数
objvcc_CourseProENT.TeacherNum = objvcc_CourseProENS.TeacherNum; //教师数
objvcc_CourseProENT.ChapterNum = objvcc_CourseProENS.ChapterNum; //章节数
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
 /// <param name = "objvcc_CourseProENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseProEN:objvcc_CourseProENT</returns>
 public static clsvcc_CourseProEN CopyTo(this clsvcc_CourseProEN objvcc_CourseProENS)
{
try
{
 clsvcc_CourseProEN objvcc_CourseProENT = new clsvcc_CourseProEN()
{
CourseId = objvcc_CourseProENS.CourseId, //课程Id
LikeCount = objvcc_CourseProENS.LikeCount, //LikeCount
CourseCode = objvcc_CourseProENS.CourseCode, //课程代码
CourseDescription = objvcc_CourseProENS.CourseDescription, //课程描述
CourseName = objvcc_CourseProENS.CourseName, //课程名称
CourseTypeId = objvcc_CourseProENS.CourseTypeId, //课程类型ID
CourseTypeName = objvcc_CourseProENS.CourseTypeName, //课程类型名称
CreateDate = objvcc_CourseProENS.CreateDate, //建立日期
ExcellentTypeId = objvcc_CourseProENS.ExcellentTypeId, //精品课程类型Id
ExcellentTypeName = objvcc_CourseProENS.ExcellentTypeName, //精品课程类型名称
ExcellentYear = objvcc_CourseProENS.ExcellentYear, //课程年份
IsBuildingCourse = objvcc_CourseProENS.IsBuildingCourse, //是否已建设课程
IsDoubleLanguageCourse = objvcc_CourseProENS.IsDoubleLanguageCourse, //是否双语课程
IsOpen = objvcc_CourseProENS.IsOpen, //是否公开
IsRecommendedCourse = objvcc_CourseProENS.IsRecommendedCourse, //是否推荐课程
IsSelfPropelledCourse = objvcc_CourseProENS.IsSelfPropelledCourse, //是否自荐课程
OperationDate = objvcc_CourseProENS.OperationDate, //操作时间
OrderNum = objvcc_CourseProENS.OrderNum, //序号
OuterLink = objvcc_CourseProENS.OuterLink, //外链地址
ViewCount = objvcc_CourseProENS.ViewCount, //浏览量
ThemeId = objvcc_CourseProENS.ThemeId, //主题Id
ThemeName = objvcc_CourseProENS.ThemeName, //主题名
ExampleImgPath = objvcc_CourseProENS.ExampleImgPath, //示例图路径
IdXzMajor = objvcc_CourseProENS.IdXzMajor, //专业流水号
MajorID = objvcc_CourseProENS.MajorID, //专业ID
MajorName = objvcc_CourseProENS.MajorName, //专业名称
IdXzCollege = objvcc_CourseProENS.IdXzCollege, //学院流水号
CollegeId = objvcc_CourseProENS.CollegeId, //学院ID
CollegeName = objvcc_CourseProENS.CollegeName, //学院名称
CollegeNameA = objvcc_CourseProENS.CollegeNameA, //学院名称简写
Memo = objvcc_CourseProENS.Memo, //备注
QuestionNum = objvcc_CourseProENS.QuestionNum, //题目数
KnowledgesNum = objvcc_CourseProENS.KnowledgesNum, //知识点数
TeacherNum = objvcc_CourseProENS.TeacherNum, //教师数
ChapterNum = objvcc_CourseProENS.ChapterNum, //章节数
};
 return objvcc_CourseProENT;
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
public static void CheckProperty4Condition(this clsvcc_CourseProEN objvcc_CourseProEN)
{
 clsvcc_CourseProBL.vcc_CourseProDA.CheckProperty4Condition(objvcc_CourseProEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseProEN objvcc_CourseProCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.CourseId, objvcc_CourseProCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.LikeCount) == true)
{
string strComparisonOpLikeCount = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CoursePro.LikeCount, objvcc_CourseProCond.LikeCount, strComparisonOpLikeCount);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.CourseCode) == true)
{
string strComparisonOpCourseCode = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.CourseCode, objvcc_CourseProCond.CourseCode, strComparisonOpCourseCode);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.CourseDescription) == true)
{
string strComparisonOpCourseDescription = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.CourseDescription, objvcc_CourseProCond.CourseDescription, strComparisonOpCourseDescription);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.CourseName, objvcc_CourseProCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.CourseTypeId) == true)
{
string strComparisonOpCourseTypeId = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.CourseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.CourseTypeId, objvcc_CourseProCond.CourseTypeId, strComparisonOpCourseTypeId);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.CourseTypeName) == true)
{
string strComparisonOpCourseTypeName = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.CourseTypeName, objvcc_CourseProCond.CourseTypeName, strComparisonOpCourseTypeName);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.CreateDate) == true)
{
string strComparisonOpCreateDate = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.CreateDate, objvcc_CourseProCond.CreateDate, strComparisonOpCreateDate);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.ExcellentTypeId) == true)
{
string strComparisonOpExcellentTypeId = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.ExcellentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.ExcellentTypeId, objvcc_CourseProCond.ExcellentTypeId, strComparisonOpExcellentTypeId);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.ExcellentTypeName) == true)
{
string strComparisonOpExcellentTypeName = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.ExcellentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.ExcellentTypeName, objvcc_CourseProCond.ExcellentTypeName, strComparisonOpExcellentTypeName);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.ExcellentYear) == true)
{
string strComparisonOpExcellentYear = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.ExcellentYear];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CoursePro.ExcellentYear, objvcc_CourseProCond.ExcellentYear, strComparisonOpExcellentYear);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.IsBuildingCourse) == true)
{
if (objvcc_CourseProCond.IsBuildingCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CoursePro.IsBuildingCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CoursePro.IsBuildingCourse);
}
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.IsDoubleLanguageCourse) == true)
{
if (objvcc_CourseProCond.IsDoubleLanguageCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CoursePro.IsDoubleLanguageCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CoursePro.IsDoubleLanguageCourse);
}
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.IsOpen) == true)
{
if (objvcc_CourseProCond.IsOpen == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CoursePro.IsOpen);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CoursePro.IsOpen);
}
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.IsRecommendedCourse) == true)
{
if (objvcc_CourseProCond.IsRecommendedCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CoursePro.IsRecommendedCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CoursePro.IsRecommendedCourse);
}
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.IsSelfPropelledCourse) == true)
{
if (objvcc_CourseProCond.IsSelfPropelledCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CoursePro.IsSelfPropelledCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CoursePro.IsSelfPropelledCourse);
}
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.OperationDate) == true)
{
string strComparisonOpOperationDate = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.OperationDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.OperationDate, objvcc_CourseProCond.OperationDate, strComparisonOpOperationDate);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.OrderNum) == true)
{
string strComparisonOpOrderNum = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CoursePro.OrderNum, objvcc_CourseProCond.OrderNum, strComparisonOpOrderNum);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.OuterLink) == true)
{
string strComparisonOpOuterLink = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.OuterLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.OuterLink, objvcc_CourseProCond.OuterLink, strComparisonOpOuterLink);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.ViewCount) == true)
{
string strComparisonOpViewCount = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CoursePro.ViewCount, objvcc_CourseProCond.ViewCount, strComparisonOpViewCount);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.ThemeId) == true)
{
string strComparisonOpThemeId = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.ThemeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.ThemeId, objvcc_CourseProCond.ThemeId, strComparisonOpThemeId);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.ThemeName) == true)
{
string strComparisonOpThemeName = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.ThemeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.ThemeName, objvcc_CourseProCond.ThemeName, strComparisonOpThemeName);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.ExampleImgPath) == true)
{
string strComparisonOpExampleImgPath = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.ExampleImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.ExampleImgPath, objvcc_CourseProCond.ExampleImgPath, strComparisonOpExampleImgPath);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.IdXzMajor, objvcc_CourseProCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.MajorID) == true)
{
string strComparisonOpMajorID = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.MajorID, objvcc_CourseProCond.MajorID, strComparisonOpMajorID);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.MajorName) == true)
{
string strComparisonOpMajorName = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.MajorName, objvcc_CourseProCond.MajorName, strComparisonOpMajorName);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.IdXzCollege, objvcc_CourseProCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.CollegeId) == true)
{
string strComparisonOpCollegeId = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.CollegeId, objvcc_CourseProCond.CollegeId, strComparisonOpCollegeId);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.CollegeName) == true)
{
string strComparisonOpCollegeName = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.CollegeName, objvcc_CourseProCond.CollegeName, strComparisonOpCollegeName);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.CollegeNameA, objvcc_CourseProCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.Memo) == true)
{
string strComparisonOpMemo = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CoursePro.Memo, objvcc_CourseProCond.Memo, strComparisonOpMemo);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.QuestionNum) == true)
{
string strComparisonOpQuestionNum = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.QuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CoursePro.QuestionNum, objvcc_CourseProCond.QuestionNum, strComparisonOpQuestionNum);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.KnowledgesNum) == true)
{
string strComparisonOpKnowledgesNum = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.KnowledgesNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CoursePro.KnowledgesNum, objvcc_CourseProCond.KnowledgesNum, strComparisonOpKnowledgesNum);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.TeacherNum) == true)
{
string strComparisonOpTeacherNum = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.TeacherNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CoursePro.TeacherNum, objvcc_CourseProCond.TeacherNum, strComparisonOpTeacherNum);
}
if (objvcc_CourseProCond.IsUpdated(convcc_CoursePro.ChapterNum) == true)
{
string strComparisonOpChapterNum = objvcc_CourseProCond.dicFldComparisonOp[convcc_CoursePro.ChapterNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CoursePro.ChapterNum, objvcc_CourseProCond.ChapterNum, strComparisonOpChapterNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_CoursePro
{
public virtual bool UpdRelaTabDate(string strCourseId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程Pro(vcc_CoursePro)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseProBL
{
public static RelatedActions_vcc_CoursePro relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_CourseProDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_CourseProDA vcc_CourseProDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_CourseProDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_CourseProBL()
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
if (string.IsNullOrEmpty(clsvcc_CourseProEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseProEN._ConnectString);
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
public static DataTable GetDataTable_vcc_CoursePro(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_CourseProDA.GetDataTable_vcc_CoursePro(strWhereCond);
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
objDT = vcc_CourseProDA.GetDataTable(strWhereCond);
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
objDT = vcc_CourseProDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_CourseProDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_CourseProDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_CourseProDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_CourseProDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_CourseProDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_CourseProDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvcc_CourseProEN> GetObjLstByCourseIdLst(List<string> arrCourseIdLst)
{
List<clsvcc_CourseProEN> arrObjLst = new List<clsvcc_CourseProEN>(); 
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
	clsvcc_CourseProEN objvcc_CourseProEN = new clsvcc_CourseProEN();
try
{
objvcc_CourseProEN.CourseId = objRow[convcc_CoursePro.CourseId].ToString().Trim(); //课程Id
objvcc_CourseProEN.LikeCount = objRow[convcc_CoursePro.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseProEN.CourseCode = objRow[convcc_CoursePro.CourseCode] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseProEN.CourseDescription = objRow[convcc_CoursePro.CourseDescription] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseProEN.CourseName = objRow[convcc_CoursePro.CourseName].ToString().Trim(); //课程名称
objvcc_CourseProEN.CourseTypeId = objRow[convcc_CoursePro.CourseTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseProEN.CourseTypeName = objRow[convcc_CoursePro.CourseTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseProEN.CreateDate = objRow[convcc_CoursePro.CreateDate] == DBNull.Value ? null : objRow[convcc_CoursePro.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseProEN.ExcellentTypeId = objRow[convcc_CoursePro.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseProEN.ExcellentTypeName = objRow[convcc_CoursePro.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseProEN.ExcellentYear = Int32.Parse(objRow[convcc_CoursePro.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseProEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseProEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseProEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseProEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseProEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseProEN.OperationDate = objRow[convcc_CoursePro.OperationDate] == DBNull.Value ? null : objRow[convcc_CoursePro.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseProEN.OrderNum = objRow[convcc_CoursePro.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.OrderNum].ToString().Trim()); //序号
objvcc_CourseProEN.OuterLink = objRow[convcc_CoursePro.OuterLink] == DBNull.Value ? null : objRow[convcc_CoursePro.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseProEN.ViewCount = Int32.Parse(objRow[convcc_CoursePro.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseProEN.ThemeId = objRow[convcc_CoursePro.ThemeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseProEN.ThemeName = objRow[convcc_CoursePro.ThemeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeName].ToString().Trim(); //主题名
objvcc_CourseProEN.ExampleImgPath = objRow[convcc_CoursePro.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CoursePro.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseProEN.IdXzMajor = objRow[convcc_CoursePro.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseProEN.MajorID = objRow[convcc_CoursePro.MajorID] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorID].ToString().Trim(); //专业ID
objvcc_CourseProEN.MajorName = objRow[convcc_CoursePro.MajorName] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorName].ToString().Trim(); //专业名称
objvcc_CourseProEN.IdXzCollege = objRow[convcc_CoursePro.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseProEN.CollegeId = objRow[convcc_CoursePro.CollegeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseProEN.CollegeName = objRow[convcc_CoursePro.CollegeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseProEN.CollegeNameA = objRow[convcc_CoursePro.CollegeNameA] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseProEN.Memo = objRow[convcc_CoursePro.Memo] == DBNull.Value ? null : objRow[convcc_CoursePro.Memo].ToString().Trim(); //备注
objvcc_CourseProEN.QuestionNum = objRow[convcc_CoursePro.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseProEN.KnowledgesNum = objRow[convcc_CoursePro.KnowledgesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.KnowledgesNum].ToString().Trim()); //知识点数
objvcc_CourseProEN.TeacherNum = objRow[convcc_CoursePro.TeacherNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.TeacherNum].ToString().Trim()); //教师数
objvcc_CourseProEN.ChapterNum = objRow[convcc_CoursePro.ChapterNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.ChapterNum].ToString().Trim()); //章节数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseProEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseProEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_CourseProEN> GetObjLstByCourseIdLstCache(List<string> arrCourseIdLst)
{
string strKey = string.Format("{0}", clsvcc_CourseProEN._CurrTabName);
List<clsvcc_CourseProEN> arrvcc_CourseProObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseProEN> arrvcc_CourseProObjLst_Sel =
arrvcc_CourseProObjLstCache
.Where(x => arrCourseIdLst.Contains(x.CourseId));
return arrvcc_CourseProObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseProEN> GetObjLst(string strWhereCond)
{
List<clsvcc_CourseProEN> arrObjLst = new List<clsvcc_CourseProEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseProEN objvcc_CourseProEN = new clsvcc_CourseProEN();
try
{
objvcc_CourseProEN.CourseId = objRow[convcc_CoursePro.CourseId].ToString().Trim(); //课程Id
objvcc_CourseProEN.LikeCount = objRow[convcc_CoursePro.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseProEN.CourseCode = objRow[convcc_CoursePro.CourseCode] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseProEN.CourseDescription = objRow[convcc_CoursePro.CourseDescription] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseProEN.CourseName = objRow[convcc_CoursePro.CourseName].ToString().Trim(); //课程名称
objvcc_CourseProEN.CourseTypeId = objRow[convcc_CoursePro.CourseTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseProEN.CourseTypeName = objRow[convcc_CoursePro.CourseTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseProEN.CreateDate = objRow[convcc_CoursePro.CreateDate] == DBNull.Value ? null : objRow[convcc_CoursePro.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseProEN.ExcellentTypeId = objRow[convcc_CoursePro.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseProEN.ExcellentTypeName = objRow[convcc_CoursePro.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseProEN.ExcellentYear = Int32.Parse(objRow[convcc_CoursePro.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseProEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseProEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseProEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseProEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseProEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseProEN.OperationDate = objRow[convcc_CoursePro.OperationDate] == DBNull.Value ? null : objRow[convcc_CoursePro.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseProEN.OrderNum = objRow[convcc_CoursePro.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.OrderNum].ToString().Trim()); //序号
objvcc_CourseProEN.OuterLink = objRow[convcc_CoursePro.OuterLink] == DBNull.Value ? null : objRow[convcc_CoursePro.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseProEN.ViewCount = Int32.Parse(objRow[convcc_CoursePro.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseProEN.ThemeId = objRow[convcc_CoursePro.ThemeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseProEN.ThemeName = objRow[convcc_CoursePro.ThemeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeName].ToString().Trim(); //主题名
objvcc_CourseProEN.ExampleImgPath = objRow[convcc_CoursePro.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CoursePro.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseProEN.IdXzMajor = objRow[convcc_CoursePro.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseProEN.MajorID = objRow[convcc_CoursePro.MajorID] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorID].ToString().Trim(); //专业ID
objvcc_CourseProEN.MajorName = objRow[convcc_CoursePro.MajorName] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorName].ToString().Trim(); //专业名称
objvcc_CourseProEN.IdXzCollege = objRow[convcc_CoursePro.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseProEN.CollegeId = objRow[convcc_CoursePro.CollegeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseProEN.CollegeName = objRow[convcc_CoursePro.CollegeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseProEN.CollegeNameA = objRow[convcc_CoursePro.CollegeNameA] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseProEN.Memo = objRow[convcc_CoursePro.Memo] == DBNull.Value ? null : objRow[convcc_CoursePro.Memo].ToString().Trim(); //备注
objvcc_CourseProEN.QuestionNum = objRow[convcc_CoursePro.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseProEN.KnowledgesNum = objRow[convcc_CoursePro.KnowledgesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.KnowledgesNum].ToString().Trim()); //知识点数
objvcc_CourseProEN.TeacherNum = objRow[convcc_CoursePro.TeacherNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.TeacherNum].ToString().Trim()); //教师数
objvcc_CourseProEN.ChapterNum = objRow[convcc_CoursePro.ChapterNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.ChapterNum].ToString().Trim()); //章节数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseProEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseProEN);
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
public static List<clsvcc_CourseProEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseProEN> arrObjLst = new List<clsvcc_CourseProEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseProEN objvcc_CourseProEN = new clsvcc_CourseProEN();
try
{
objvcc_CourseProEN.CourseId = objRow[convcc_CoursePro.CourseId].ToString().Trim(); //课程Id
objvcc_CourseProEN.LikeCount = objRow[convcc_CoursePro.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseProEN.CourseCode = objRow[convcc_CoursePro.CourseCode] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseProEN.CourseDescription = objRow[convcc_CoursePro.CourseDescription] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseProEN.CourseName = objRow[convcc_CoursePro.CourseName].ToString().Trim(); //课程名称
objvcc_CourseProEN.CourseTypeId = objRow[convcc_CoursePro.CourseTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseProEN.CourseTypeName = objRow[convcc_CoursePro.CourseTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseProEN.CreateDate = objRow[convcc_CoursePro.CreateDate] == DBNull.Value ? null : objRow[convcc_CoursePro.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseProEN.ExcellentTypeId = objRow[convcc_CoursePro.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseProEN.ExcellentTypeName = objRow[convcc_CoursePro.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseProEN.ExcellentYear = Int32.Parse(objRow[convcc_CoursePro.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseProEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseProEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseProEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseProEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseProEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseProEN.OperationDate = objRow[convcc_CoursePro.OperationDate] == DBNull.Value ? null : objRow[convcc_CoursePro.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseProEN.OrderNum = objRow[convcc_CoursePro.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.OrderNum].ToString().Trim()); //序号
objvcc_CourseProEN.OuterLink = objRow[convcc_CoursePro.OuterLink] == DBNull.Value ? null : objRow[convcc_CoursePro.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseProEN.ViewCount = Int32.Parse(objRow[convcc_CoursePro.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseProEN.ThemeId = objRow[convcc_CoursePro.ThemeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseProEN.ThemeName = objRow[convcc_CoursePro.ThemeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeName].ToString().Trim(); //主题名
objvcc_CourseProEN.ExampleImgPath = objRow[convcc_CoursePro.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CoursePro.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseProEN.IdXzMajor = objRow[convcc_CoursePro.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseProEN.MajorID = objRow[convcc_CoursePro.MajorID] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorID].ToString().Trim(); //专业ID
objvcc_CourseProEN.MajorName = objRow[convcc_CoursePro.MajorName] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorName].ToString().Trim(); //专业名称
objvcc_CourseProEN.IdXzCollege = objRow[convcc_CoursePro.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseProEN.CollegeId = objRow[convcc_CoursePro.CollegeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseProEN.CollegeName = objRow[convcc_CoursePro.CollegeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseProEN.CollegeNameA = objRow[convcc_CoursePro.CollegeNameA] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseProEN.Memo = objRow[convcc_CoursePro.Memo] == DBNull.Value ? null : objRow[convcc_CoursePro.Memo].ToString().Trim(); //备注
objvcc_CourseProEN.QuestionNum = objRow[convcc_CoursePro.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseProEN.KnowledgesNum = objRow[convcc_CoursePro.KnowledgesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.KnowledgesNum].ToString().Trim()); //知识点数
objvcc_CourseProEN.TeacherNum = objRow[convcc_CoursePro.TeacherNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.TeacherNum].ToString().Trim()); //教师数
objvcc_CourseProEN.ChapterNum = objRow[convcc_CoursePro.ChapterNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.ChapterNum].ToString().Trim()); //章节数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseProEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseProEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_CourseProCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_CourseProEN> GetSubObjLstCache(clsvcc_CourseProEN objvcc_CourseProCond)
{
List<clsvcc_CourseProEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseProEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CoursePro.AttributeName)
{
if (objvcc_CourseProCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseProCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseProCond[strFldName].ToString());
}
else
{
if (objvcc_CourseProCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseProCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseProCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseProCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseProCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseProCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseProCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseProCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseProCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseProCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseProCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseProCond[strFldName]));
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
public static List<clsvcc_CourseProEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_CourseProEN> arrObjLst = new List<clsvcc_CourseProEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseProEN objvcc_CourseProEN = new clsvcc_CourseProEN();
try
{
objvcc_CourseProEN.CourseId = objRow[convcc_CoursePro.CourseId].ToString().Trim(); //课程Id
objvcc_CourseProEN.LikeCount = objRow[convcc_CoursePro.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseProEN.CourseCode = objRow[convcc_CoursePro.CourseCode] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseProEN.CourseDescription = objRow[convcc_CoursePro.CourseDescription] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseProEN.CourseName = objRow[convcc_CoursePro.CourseName].ToString().Trim(); //课程名称
objvcc_CourseProEN.CourseTypeId = objRow[convcc_CoursePro.CourseTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseProEN.CourseTypeName = objRow[convcc_CoursePro.CourseTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseProEN.CreateDate = objRow[convcc_CoursePro.CreateDate] == DBNull.Value ? null : objRow[convcc_CoursePro.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseProEN.ExcellentTypeId = objRow[convcc_CoursePro.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseProEN.ExcellentTypeName = objRow[convcc_CoursePro.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseProEN.ExcellentYear = Int32.Parse(objRow[convcc_CoursePro.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseProEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseProEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseProEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseProEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseProEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseProEN.OperationDate = objRow[convcc_CoursePro.OperationDate] == DBNull.Value ? null : objRow[convcc_CoursePro.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseProEN.OrderNum = objRow[convcc_CoursePro.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.OrderNum].ToString().Trim()); //序号
objvcc_CourseProEN.OuterLink = objRow[convcc_CoursePro.OuterLink] == DBNull.Value ? null : objRow[convcc_CoursePro.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseProEN.ViewCount = Int32.Parse(objRow[convcc_CoursePro.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseProEN.ThemeId = objRow[convcc_CoursePro.ThemeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseProEN.ThemeName = objRow[convcc_CoursePro.ThemeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeName].ToString().Trim(); //主题名
objvcc_CourseProEN.ExampleImgPath = objRow[convcc_CoursePro.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CoursePro.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseProEN.IdXzMajor = objRow[convcc_CoursePro.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseProEN.MajorID = objRow[convcc_CoursePro.MajorID] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorID].ToString().Trim(); //专业ID
objvcc_CourseProEN.MajorName = objRow[convcc_CoursePro.MajorName] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorName].ToString().Trim(); //专业名称
objvcc_CourseProEN.IdXzCollege = objRow[convcc_CoursePro.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseProEN.CollegeId = objRow[convcc_CoursePro.CollegeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseProEN.CollegeName = objRow[convcc_CoursePro.CollegeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseProEN.CollegeNameA = objRow[convcc_CoursePro.CollegeNameA] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseProEN.Memo = objRow[convcc_CoursePro.Memo] == DBNull.Value ? null : objRow[convcc_CoursePro.Memo].ToString().Trim(); //备注
objvcc_CourseProEN.QuestionNum = objRow[convcc_CoursePro.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseProEN.KnowledgesNum = objRow[convcc_CoursePro.KnowledgesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.KnowledgesNum].ToString().Trim()); //知识点数
objvcc_CourseProEN.TeacherNum = objRow[convcc_CoursePro.TeacherNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.TeacherNum].ToString().Trim()); //教师数
objvcc_CourseProEN.ChapterNum = objRow[convcc_CoursePro.ChapterNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.ChapterNum].ToString().Trim()); //章节数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseProEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseProEN);
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
public static List<clsvcc_CourseProEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_CourseProEN> arrObjLst = new List<clsvcc_CourseProEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseProEN objvcc_CourseProEN = new clsvcc_CourseProEN();
try
{
objvcc_CourseProEN.CourseId = objRow[convcc_CoursePro.CourseId].ToString().Trim(); //课程Id
objvcc_CourseProEN.LikeCount = objRow[convcc_CoursePro.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseProEN.CourseCode = objRow[convcc_CoursePro.CourseCode] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseProEN.CourseDescription = objRow[convcc_CoursePro.CourseDescription] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseProEN.CourseName = objRow[convcc_CoursePro.CourseName].ToString().Trim(); //课程名称
objvcc_CourseProEN.CourseTypeId = objRow[convcc_CoursePro.CourseTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseProEN.CourseTypeName = objRow[convcc_CoursePro.CourseTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseProEN.CreateDate = objRow[convcc_CoursePro.CreateDate] == DBNull.Value ? null : objRow[convcc_CoursePro.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseProEN.ExcellentTypeId = objRow[convcc_CoursePro.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseProEN.ExcellentTypeName = objRow[convcc_CoursePro.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseProEN.ExcellentYear = Int32.Parse(objRow[convcc_CoursePro.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseProEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseProEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseProEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseProEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseProEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseProEN.OperationDate = objRow[convcc_CoursePro.OperationDate] == DBNull.Value ? null : objRow[convcc_CoursePro.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseProEN.OrderNum = objRow[convcc_CoursePro.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.OrderNum].ToString().Trim()); //序号
objvcc_CourseProEN.OuterLink = objRow[convcc_CoursePro.OuterLink] == DBNull.Value ? null : objRow[convcc_CoursePro.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseProEN.ViewCount = Int32.Parse(objRow[convcc_CoursePro.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseProEN.ThemeId = objRow[convcc_CoursePro.ThemeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseProEN.ThemeName = objRow[convcc_CoursePro.ThemeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeName].ToString().Trim(); //主题名
objvcc_CourseProEN.ExampleImgPath = objRow[convcc_CoursePro.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CoursePro.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseProEN.IdXzMajor = objRow[convcc_CoursePro.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseProEN.MajorID = objRow[convcc_CoursePro.MajorID] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorID].ToString().Trim(); //专业ID
objvcc_CourseProEN.MajorName = objRow[convcc_CoursePro.MajorName] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorName].ToString().Trim(); //专业名称
objvcc_CourseProEN.IdXzCollege = objRow[convcc_CoursePro.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseProEN.CollegeId = objRow[convcc_CoursePro.CollegeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseProEN.CollegeName = objRow[convcc_CoursePro.CollegeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseProEN.CollegeNameA = objRow[convcc_CoursePro.CollegeNameA] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseProEN.Memo = objRow[convcc_CoursePro.Memo] == DBNull.Value ? null : objRow[convcc_CoursePro.Memo].ToString().Trim(); //备注
objvcc_CourseProEN.QuestionNum = objRow[convcc_CoursePro.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseProEN.KnowledgesNum = objRow[convcc_CoursePro.KnowledgesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.KnowledgesNum].ToString().Trim()); //知识点数
objvcc_CourseProEN.TeacherNum = objRow[convcc_CoursePro.TeacherNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.TeacherNum].ToString().Trim()); //教师数
objvcc_CourseProEN.ChapterNum = objRow[convcc_CoursePro.ChapterNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.ChapterNum].ToString().Trim()); //章节数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseProEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseProEN);
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
List<clsvcc_CourseProEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_CourseProEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseProEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_CourseProEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseProEN> arrObjLst = new List<clsvcc_CourseProEN>(); 
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
	clsvcc_CourseProEN objvcc_CourseProEN = new clsvcc_CourseProEN();
try
{
objvcc_CourseProEN.CourseId = objRow[convcc_CoursePro.CourseId].ToString().Trim(); //课程Id
objvcc_CourseProEN.LikeCount = objRow[convcc_CoursePro.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseProEN.CourseCode = objRow[convcc_CoursePro.CourseCode] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseProEN.CourseDescription = objRow[convcc_CoursePro.CourseDescription] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseProEN.CourseName = objRow[convcc_CoursePro.CourseName].ToString().Trim(); //课程名称
objvcc_CourseProEN.CourseTypeId = objRow[convcc_CoursePro.CourseTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseProEN.CourseTypeName = objRow[convcc_CoursePro.CourseTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseProEN.CreateDate = objRow[convcc_CoursePro.CreateDate] == DBNull.Value ? null : objRow[convcc_CoursePro.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseProEN.ExcellentTypeId = objRow[convcc_CoursePro.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseProEN.ExcellentTypeName = objRow[convcc_CoursePro.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseProEN.ExcellentYear = Int32.Parse(objRow[convcc_CoursePro.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseProEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseProEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseProEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseProEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseProEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseProEN.OperationDate = objRow[convcc_CoursePro.OperationDate] == DBNull.Value ? null : objRow[convcc_CoursePro.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseProEN.OrderNum = objRow[convcc_CoursePro.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.OrderNum].ToString().Trim()); //序号
objvcc_CourseProEN.OuterLink = objRow[convcc_CoursePro.OuterLink] == DBNull.Value ? null : objRow[convcc_CoursePro.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseProEN.ViewCount = Int32.Parse(objRow[convcc_CoursePro.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseProEN.ThemeId = objRow[convcc_CoursePro.ThemeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseProEN.ThemeName = objRow[convcc_CoursePro.ThemeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeName].ToString().Trim(); //主题名
objvcc_CourseProEN.ExampleImgPath = objRow[convcc_CoursePro.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CoursePro.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseProEN.IdXzMajor = objRow[convcc_CoursePro.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseProEN.MajorID = objRow[convcc_CoursePro.MajorID] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorID].ToString().Trim(); //专业ID
objvcc_CourseProEN.MajorName = objRow[convcc_CoursePro.MajorName] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorName].ToString().Trim(); //专业名称
objvcc_CourseProEN.IdXzCollege = objRow[convcc_CoursePro.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseProEN.CollegeId = objRow[convcc_CoursePro.CollegeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseProEN.CollegeName = objRow[convcc_CoursePro.CollegeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseProEN.CollegeNameA = objRow[convcc_CoursePro.CollegeNameA] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseProEN.Memo = objRow[convcc_CoursePro.Memo] == DBNull.Value ? null : objRow[convcc_CoursePro.Memo].ToString().Trim(); //备注
objvcc_CourseProEN.QuestionNum = objRow[convcc_CoursePro.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseProEN.KnowledgesNum = objRow[convcc_CoursePro.KnowledgesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.KnowledgesNum].ToString().Trim()); //知识点数
objvcc_CourseProEN.TeacherNum = objRow[convcc_CoursePro.TeacherNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.TeacherNum].ToString().Trim()); //教师数
objvcc_CourseProEN.ChapterNum = objRow[convcc_CoursePro.ChapterNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.ChapterNum].ToString().Trim()); //章节数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseProEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseProEN);
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
public static List<clsvcc_CourseProEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseProEN> arrObjLst = new List<clsvcc_CourseProEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseProEN objvcc_CourseProEN = new clsvcc_CourseProEN();
try
{
objvcc_CourseProEN.CourseId = objRow[convcc_CoursePro.CourseId].ToString().Trim(); //课程Id
objvcc_CourseProEN.LikeCount = objRow[convcc_CoursePro.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseProEN.CourseCode = objRow[convcc_CoursePro.CourseCode] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseProEN.CourseDescription = objRow[convcc_CoursePro.CourseDescription] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseProEN.CourseName = objRow[convcc_CoursePro.CourseName].ToString().Trim(); //课程名称
objvcc_CourseProEN.CourseTypeId = objRow[convcc_CoursePro.CourseTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseProEN.CourseTypeName = objRow[convcc_CoursePro.CourseTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseProEN.CreateDate = objRow[convcc_CoursePro.CreateDate] == DBNull.Value ? null : objRow[convcc_CoursePro.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseProEN.ExcellentTypeId = objRow[convcc_CoursePro.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseProEN.ExcellentTypeName = objRow[convcc_CoursePro.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseProEN.ExcellentYear = Int32.Parse(objRow[convcc_CoursePro.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseProEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseProEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseProEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseProEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseProEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseProEN.OperationDate = objRow[convcc_CoursePro.OperationDate] == DBNull.Value ? null : objRow[convcc_CoursePro.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseProEN.OrderNum = objRow[convcc_CoursePro.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.OrderNum].ToString().Trim()); //序号
objvcc_CourseProEN.OuterLink = objRow[convcc_CoursePro.OuterLink] == DBNull.Value ? null : objRow[convcc_CoursePro.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseProEN.ViewCount = Int32.Parse(objRow[convcc_CoursePro.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseProEN.ThemeId = objRow[convcc_CoursePro.ThemeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseProEN.ThemeName = objRow[convcc_CoursePro.ThemeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeName].ToString().Trim(); //主题名
objvcc_CourseProEN.ExampleImgPath = objRow[convcc_CoursePro.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CoursePro.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseProEN.IdXzMajor = objRow[convcc_CoursePro.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseProEN.MajorID = objRow[convcc_CoursePro.MajorID] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorID].ToString().Trim(); //专业ID
objvcc_CourseProEN.MajorName = objRow[convcc_CoursePro.MajorName] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorName].ToString().Trim(); //专业名称
objvcc_CourseProEN.IdXzCollege = objRow[convcc_CoursePro.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseProEN.CollegeId = objRow[convcc_CoursePro.CollegeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseProEN.CollegeName = objRow[convcc_CoursePro.CollegeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseProEN.CollegeNameA = objRow[convcc_CoursePro.CollegeNameA] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseProEN.Memo = objRow[convcc_CoursePro.Memo] == DBNull.Value ? null : objRow[convcc_CoursePro.Memo].ToString().Trim(); //备注
objvcc_CourseProEN.QuestionNum = objRow[convcc_CoursePro.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseProEN.KnowledgesNum = objRow[convcc_CoursePro.KnowledgesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.KnowledgesNum].ToString().Trim()); //知识点数
objvcc_CourseProEN.TeacherNum = objRow[convcc_CoursePro.TeacherNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.TeacherNum].ToString().Trim()); //教师数
objvcc_CourseProEN.ChapterNum = objRow[convcc_CoursePro.ChapterNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.ChapterNum].ToString().Trim()); //章节数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseProEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseProEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_CourseProEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_CourseProEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseProEN> arrObjLst = new List<clsvcc_CourseProEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseProEN objvcc_CourseProEN = new clsvcc_CourseProEN();
try
{
objvcc_CourseProEN.CourseId = objRow[convcc_CoursePro.CourseId].ToString().Trim(); //课程Id
objvcc_CourseProEN.LikeCount = objRow[convcc_CoursePro.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseProEN.CourseCode = objRow[convcc_CoursePro.CourseCode] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseProEN.CourseDescription = objRow[convcc_CoursePro.CourseDescription] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseProEN.CourseName = objRow[convcc_CoursePro.CourseName].ToString().Trim(); //课程名称
objvcc_CourseProEN.CourseTypeId = objRow[convcc_CoursePro.CourseTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseProEN.CourseTypeName = objRow[convcc_CoursePro.CourseTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseProEN.CreateDate = objRow[convcc_CoursePro.CreateDate] == DBNull.Value ? null : objRow[convcc_CoursePro.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseProEN.ExcellentTypeId = objRow[convcc_CoursePro.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseProEN.ExcellentTypeName = objRow[convcc_CoursePro.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseProEN.ExcellentYear = Int32.Parse(objRow[convcc_CoursePro.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseProEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseProEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseProEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseProEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseProEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseProEN.OperationDate = objRow[convcc_CoursePro.OperationDate] == DBNull.Value ? null : objRow[convcc_CoursePro.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseProEN.OrderNum = objRow[convcc_CoursePro.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.OrderNum].ToString().Trim()); //序号
objvcc_CourseProEN.OuterLink = objRow[convcc_CoursePro.OuterLink] == DBNull.Value ? null : objRow[convcc_CoursePro.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseProEN.ViewCount = Int32.Parse(objRow[convcc_CoursePro.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseProEN.ThemeId = objRow[convcc_CoursePro.ThemeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseProEN.ThemeName = objRow[convcc_CoursePro.ThemeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeName].ToString().Trim(); //主题名
objvcc_CourseProEN.ExampleImgPath = objRow[convcc_CoursePro.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CoursePro.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseProEN.IdXzMajor = objRow[convcc_CoursePro.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseProEN.MajorID = objRow[convcc_CoursePro.MajorID] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorID].ToString().Trim(); //专业ID
objvcc_CourseProEN.MajorName = objRow[convcc_CoursePro.MajorName] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorName].ToString().Trim(); //专业名称
objvcc_CourseProEN.IdXzCollege = objRow[convcc_CoursePro.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseProEN.CollegeId = objRow[convcc_CoursePro.CollegeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseProEN.CollegeName = objRow[convcc_CoursePro.CollegeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseProEN.CollegeNameA = objRow[convcc_CoursePro.CollegeNameA] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseProEN.Memo = objRow[convcc_CoursePro.Memo] == DBNull.Value ? null : objRow[convcc_CoursePro.Memo].ToString().Trim(); //备注
objvcc_CourseProEN.QuestionNum = objRow[convcc_CoursePro.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseProEN.KnowledgesNum = objRow[convcc_CoursePro.KnowledgesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.KnowledgesNum].ToString().Trim()); //知识点数
objvcc_CourseProEN.TeacherNum = objRow[convcc_CoursePro.TeacherNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.TeacherNum].ToString().Trim()); //教师数
objvcc_CourseProEN.ChapterNum = objRow[convcc_CoursePro.ChapterNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.ChapterNum].ToString().Trim()); //章节数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseProEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseProEN);
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
public static List<clsvcc_CourseProEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_CourseProEN> arrObjLst = new List<clsvcc_CourseProEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseProEN objvcc_CourseProEN = new clsvcc_CourseProEN();
try
{
objvcc_CourseProEN.CourseId = objRow[convcc_CoursePro.CourseId].ToString().Trim(); //课程Id
objvcc_CourseProEN.LikeCount = objRow[convcc_CoursePro.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseProEN.CourseCode = objRow[convcc_CoursePro.CourseCode] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseProEN.CourseDescription = objRow[convcc_CoursePro.CourseDescription] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseProEN.CourseName = objRow[convcc_CoursePro.CourseName].ToString().Trim(); //课程名称
objvcc_CourseProEN.CourseTypeId = objRow[convcc_CoursePro.CourseTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseProEN.CourseTypeName = objRow[convcc_CoursePro.CourseTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseProEN.CreateDate = objRow[convcc_CoursePro.CreateDate] == DBNull.Value ? null : objRow[convcc_CoursePro.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseProEN.ExcellentTypeId = objRow[convcc_CoursePro.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseProEN.ExcellentTypeName = objRow[convcc_CoursePro.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseProEN.ExcellentYear = Int32.Parse(objRow[convcc_CoursePro.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseProEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseProEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseProEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseProEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseProEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseProEN.OperationDate = objRow[convcc_CoursePro.OperationDate] == DBNull.Value ? null : objRow[convcc_CoursePro.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseProEN.OrderNum = objRow[convcc_CoursePro.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.OrderNum].ToString().Trim()); //序号
objvcc_CourseProEN.OuterLink = objRow[convcc_CoursePro.OuterLink] == DBNull.Value ? null : objRow[convcc_CoursePro.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseProEN.ViewCount = Int32.Parse(objRow[convcc_CoursePro.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseProEN.ThemeId = objRow[convcc_CoursePro.ThemeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseProEN.ThemeName = objRow[convcc_CoursePro.ThemeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeName].ToString().Trim(); //主题名
objvcc_CourseProEN.ExampleImgPath = objRow[convcc_CoursePro.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CoursePro.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseProEN.IdXzMajor = objRow[convcc_CoursePro.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseProEN.MajorID = objRow[convcc_CoursePro.MajorID] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorID].ToString().Trim(); //专业ID
objvcc_CourseProEN.MajorName = objRow[convcc_CoursePro.MajorName] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorName].ToString().Trim(); //专业名称
objvcc_CourseProEN.IdXzCollege = objRow[convcc_CoursePro.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseProEN.CollegeId = objRow[convcc_CoursePro.CollegeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseProEN.CollegeName = objRow[convcc_CoursePro.CollegeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseProEN.CollegeNameA = objRow[convcc_CoursePro.CollegeNameA] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseProEN.Memo = objRow[convcc_CoursePro.Memo] == DBNull.Value ? null : objRow[convcc_CoursePro.Memo].ToString().Trim(); //备注
objvcc_CourseProEN.QuestionNum = objRow[convcc_CoursePro.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseProEN.KnowledgesNum = objRow[convcc_CoursePro.KnowledgesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.KnowledgesNum].ToString().Trim()); //知识点数
objvcc_CourseProEN.TeacherNum = objRow[convcc_CoursePro.TeacherNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.TeacherNum].ToString().Trim()); //教师数
objvcc_CourseProEN.ChapterNum = objRow[convcc_CoursePro.ChapterNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.ChapterNum].ToString().Trim()); //章节数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseProEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseProEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseProEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_CourseProEN> arrObjLst = new List<clsvcc_CourseProEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseProEN objvcc_CourseProEN = new clsvcc_CourseProEN();
try
{
objvcc_CourseProEN.CourseId = objRow[convcc_CoursePro.CourseId].ToString().Trim(); //课程Id
objvcc_CourseProEN.LikeCount = objRow[convcc_CoursePro.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseProEN.CourseCode = objRow[convcc_CoursePro.CourseCode] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseProEN.CourseDescription = objRow[convcc_CoursePro.CourseDescription] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseProEN.CourseName = objRow[convcc_CoursePro.CourseName].ToString().Trim(); //课程名称
objvcc_CourseProEN.CourseTypeId = objRow[convcc_CoursePro.CourseTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseProEN.CourseTypeName = objRow[convcc_CoursePro.CourseTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseProEN.CreateDate = objRow[convcc_CoursePro.CreateDate] == DBNull.Value ? null : objRow[convcc_CoursePro.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseProEN.ExcellentTypeId = objRow[convcc_CoursePro.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseProEN.ExcellentTypeName = objRow[convcc_CoursePro.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseProEN.ExcellentYear = Int32.Parse(objRow[convcc_CoursePro.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseProEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseProEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseProEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseProEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseProEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseProEN.OperationDate = objRow[convcc_CoursePro.OperationDate] == DBNull.Value ? null : objRow[convcc_CoursePro.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseProEN.OrderNum = objRow[convcc_CoursePro.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.OrderNum].ToString().Trim()); //序号
objvcc_CourseProEN.OuterLink = objRow[convcc_CoursePro.OuterLink] == DBNull.Value ? null : objRow[convcc_CoursePro.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseProEN.ViewCount = Int32.Parse(objRow[convcc_CoursePro.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseProEN.ThemeId = objRow[convcc_CoursePro.ThemeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseProEN.ThemeName = objRow[convcc_CoursePro.ThemeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeName].ToString().Trim(); //主题名
objvcc_CourseProEN.ExampleImgPath = objRow[convcc_CoursePro.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CoursePro.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseProEN.IdXzMajor = objRow[convcc_CoursePro.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseProEN.MajorID = objRow[convcc_CoursePro.MajorID] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorID].ToString().Trim(); //专业ID
objvcc_CourseProEN.MajorName = objRow[convcc_CoursePro.MajorName] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorName].ToString().Trim(); //专业名称
objvcc_CourseProEN.IdXzCollege = objRow[convcc_CoursePro.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseProEN.CollegeId = objRow[convcc_CoursePro.CollegeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseProEN.CollegeName = objRow[convcc_CoursePro.CollegeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseProEN.CollegeNameA = objRow[convcc_CoursePro.CollegeNameA] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseProEN.Memo = objRow[convcc_CoursePro.Memo] == DBNull.Value ? null : objRow[convcc_CoursePro.Memo].ToString().Trim(); //备注
objvcc_CourseProEN.QuestionNum = objRow[convcc_CoursePro.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseProEN.KnowledgesNum = objRow[convcc_CoursePro.KnowledgesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.KnowledgesNum].ToString().Trim()); //知识点数
objvcc_CourseProEN.TeacherNum = objRow[convcc_CoursePro.TeacherNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.TeacherNum].ToString().Trim()); //教师数
objvcc_CourseProEN.ChapterNum = objRow[convcc_CoursePro.ChapterNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.ChapterNum].ToString().Trim()); //章节数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseProEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseProEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_CoursePro(ref clsvcc_CourseProEN objvcc_CourseProEN)
{
bool bolResult = vcc_CourseProDA.Getvcc_CoursePro(ref objvcc_CourseProEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseProEN GetObjByCourseId(string strCourseId)
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
clsvcc_CourseProEN objvcc_CourseProEN = vcc_CourseProDA.GetObjByCourseId(strCourseId);
return objvcc_CourseProEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_CourseProEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_CourseProEN objvcc_CourseProEN = vcc_CourseProDA.GetFirstObj(strWhereCond);
 return objvcc_CourseProEN;
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
public static clsvcc_CourseProEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_CourseProEN objvcc_CourseProEN = vcc_CourseProDA.GetObjByDataRow(objRow);
 return objvcc_CourseProEN;
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
public static clsvcc_CourseProEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_CourseProEN objvcc_CourseProEN = vcc_CourseProDA.GetObjByDataRow(objRow);
 return objvcc_CourseProEN;
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
 /// <param name = "lstvcc_CourseProObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseProEN GetObjByCourseIdFromList(string strCourseId, List<clsvcc_CourseProEN> lstvcc_CourseProObjLst)
{
foreach (clsvcc_CourseProEN objvcc_CourseProEN in lstvcc_CourseProObjLst)
{
if (objvcc_CourseProEN.CourseId == strCourseId)
{
return objvcc_CourseProEN;
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
 strMaxCourseId = clsvcc_CourseProDA.GetMaxStrId();
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
 strCourseId = new clsvcc_CourseProDA().GetFirstID(strWhereCond);
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
 arrList = vcc_CourseProDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_CourseProDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vcc_CourseProDA.IsExist(strCourseId);
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
 bolIsExist = clsvcc_CourseProDA.IsExistTable();
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
 bolIsExist = vcc_CourseProDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_CourseProENS">源对象</param>
 /// <param name = "objvcc_CourseProENT">目标对象</param>
 public static void CopyTo(clsvcc_CourseProEN objvcc_CourseProENS, clsvcc_CourseProEN objvcc_CourseProENT)
{
try
{
objvcc_CourseProENT.CourseId = objvcc_CourseProENS.CourseId; //课程Id
objvcc_CourseProENT.LikeCount = objvcc_CourseProENS.LikeCount; //LikeCount
objvcc_CourseProENT.CourseCode = objvcc_CourseProENS.CourseCode; //课程代码
objvcc_CourseProENT.CourseDescription = objvcc_CourseProENS.CourseDescription; //课程描述
objvcc_CourseProENT.CourseName = objvcc_CourseProENS.CourseName; //课程名称
objvcc_CourseProENT.CourseTypeId = objvcc_CourseProENS.CourseTypeId; //课程类型ID
objvcc_CourseProENT.CourseTypeName = objvcc_CourseProENS.CourseTypeName; //课程类型名称
objvcc_CourseProENT.CreateDate = objvcc_CourseProENS.CreateDate; //建立日期
objvcc_CourseProENT.ExcellentTypeId = objvcc_CourseProENS.ExcellentTypeId; //精品课程类型Id
objvcc_CourseProENT.ExcellentTypeName = objvcc_CourseProENS.ExcellentTypeName; //精品课程类型名称
objvcc_CourseProENT.ExcellentYear = objvcc_CourseProENS.ExcellentYear; //课程年份
objvcc_CourseProENT.IsBuildingCourse = objvcc_CourseProENS.IsBuildingCourse; //是否已建设课程
objvcc_CourseProENT.IsDoubleLanguageCourse = objvcc_CourseProENS.IsDoubleLanguageCourse; //是否双语课程
objvcc_CourseProENT.IsOpen = objvcc_CourseProENS.IsOpen; //是否公开
objvcc_CourseProENT.IsRecommendedCourse = objvcc_CourseProENS.IsRecommendedCourse; //是否推荐课程
objvcc_CourseProENT.IsSelfPropelledCourse = objvcc_CourseProENS.IsSelfPropelledCourse; //是否自荐课程
objvcc_CourseProENT.OperationDate = objvcc_CourseProENS.OperationDate; //操作时间
objvcc_CourseProENT.OrderNum = objvcc_CourseProENS.OrderNum; //序号
objvcc_CourseProENT.OuterLink = objvcc_CourseProENS.OuterLink; //外链地址
objvcc_CourseProENT.ViewCount = objvcc_CourseProENS.ViewCount; //浏览量
objvcc_CourseProENT.ThemeId = objvcc_CourseProENS.ThemeId; //主题Id
objvcc_CourseProENT.ThemeName = objvcc_CourseProENS.ThemeName; //主题名
objvcc_CourseProENT.ExampleImgPath = objvcc_CourseProENS.ExampleImgPath; //示例图路径
objvcc_CourseProENT.IdXzMajor = objvcc_CourseProENS.IdXzMajor; //专业流水号
objvcc_CourseProENT.MajorID = objvcc_CourseProENS.MajorID; //专业ID
objvcc_CourseProENT.MajorName = objvcc_CourseProENS.MajorName; //专业名称
objvcc_CourseProENT.IdXzCollege = objvcc_CourseProENS.IdXzCollege; //学院流水号
objvcc_CourseProENT.CollegeId = objvcc_CourseProENS.CollegeId; //学院ID
objvcc_CourseProENT.CollegeName = objvcc_CourseProENS.CollegeName; //学院名称
objvcc_CourseProENT.CollegeNameA = objvcc_CourseProENS.CollegeNameA; //学院名称简写
objvcc_CourseProENT.Memo = objvcc_CourseProENS.Memo; //备注
objvcc_CourseProENT.QuestionNum = objvcc_CourseProENS.QuestionNum; //题目数
objvcc_CourseProENT.KnowledgesNum = objvcc_CourseProENS.KnowledgesNum; //知识点数
objvcc_CourseProENT.TeacherNum = objvcc_CourseProENS.TeacherNum; //教师数
objvcc_CourseProENT.ChapterNum = objvcc_CourseProENS.ChapterNum; //章节数
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
 /// <param name = "objvcc_CourseProEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_CourseProEN objvcc_CourseProEN)
{
try
{
objvcc_CourseProEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_CourseProEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_CoursePro.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.CourseId = objvcc_CourseProEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_CoursePro.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.LikeCount = objvcc_CourseProEN.LikeCount; //LikeCount
}
if (arrFldSet.Contains(convcc_CoursePro.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.CourseCode = objvcc_CourseProEN.CourseCode == "[null]" ? null :  objvcc_CourseProEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convcc_CoursePro.CourseDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.CourseDescription = objvcc_CourseProEN.CourseDescription == "[null]" ? null :  objvcc_CourseProEN.CourseDescription; //课程描述
}
if (arrFldSet.Contains(convcc_CoursePro.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.CourseName = objvcc_CourseProEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_CoursePro.CourseTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.CourseTypeId = objvcc_CourseProEN.CourseTypeId == "[null]" ? null :  objvcc_CourseProEN.CourseTypeId; //课程类型ID
}
if (arrFldSet.Contains(convcc_CoursePro.CourseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.CourseTypeName = objvcc_CourseProEN.CourseTypeName == "[null]" ? null :  objvcc_CourseProEN.CourseTypeName; //课程类型名称
}
if (arrFldSet.Contains(convcc_CoursePro.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.CreateDate = objvcc_CourseProEN.CreateDate == "[null]" ? null :  objvcc_CourseProEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convcc_CoursePro.ExcellentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.ExcellentTypeId = objvcc_CourseProEN.ExcellentTypeId == "[null]" ? null :  objvcc_CourseProEN.ExcellentTypeId; //精品课程类型Id
}
if (arrFldSet.Contains(convcc_CoursePro.ExcellentTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.ExcellentTypeName = objvcc_CourseProEN.ExcellentTypeName == "[null]" ? null :  objvcc_CourseProEN.ExcellentTypeName; //精品课程类型名称
}
if (arrFldSet.Contains(convcc_CoursePro.ExcellentYear, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.ExcellentYear = objvcc_CourseProEN.ExcellentYear; //课程年份
}
if (arrFldSet.Contains(convcc_CoursePro.IsBuildingCourse, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.IsBuildingCourse = objvcc_CourseProEN.IsBuildingCourse; //是否已建设课程
}
if (arrFldSet.Contains(convcc_CoursePro.IsDoubleLanguageCourse, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.IsDoubleLanguageCourse = objvcc_CourseProEN.IsDoubleLanguageCourse; //是否双语课程
}
if (arrFldSet.Contains(convcc_CoursePro.IsOpen, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.IsOpen = objvcc_CourseProEN.IsOpen; //是否公开
}
if (arrFldSet.Contains(convcc_CoursePro.IsRecommendedCourse, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.IsRecommendedCourse = objvcc_CourseProEN.IsRecommendedCourse; //是否推荐课程
}
if (arrFldSet.Contains(convcc_CoursePro.IsSelfPropelledCourse, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.IsSelfPropelledCourse = objvcc_CourseProEN.IsSelfPropelledCourse; //是否自荐课程
}
if (arrFldSet.Contains(convcc_CoursePro.OperationDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.OperationDate = objvcc_CourseProEN.OperationDate == "[null]" ? null :  objvcc_CourseProEN.OperationDate; //操作时间
}
if (arrFldSet.Contains(convcc_CoursePro.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.OrderNum = objvcc_CourseProEN.OrderNum; //序号
}
if (arrFldSet.Contains(convcc_CoursePro.OuterLink, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.OuterLink = objvcc_CourseProEN.OuterLink == "[null]" ? null :  objvcc_CourseProEN.OuterLink; //外链地址
}
if (arrFldSet.Contains(convcc_CoursePro.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.ViewCount = objvcc_CourseProEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convcc_CoursePro.ThemeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.ThemeId = objvcc_CourseProEN.ThemeId == "[null]" ? null :  objvcc_CourseProEN.ThemeId; //主题Id
}
if (arrFldSet.Contains(convcc_CoursePro.ThemeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.ThemeName = objvcc_CourseProEN.ThemeName == "[null]" ? null :  objvcc_CourseProEN.ThemeName; //主题名
}
if (arrFldSet.Contains(convcc_CoursePro.ExampleImgPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.ExampleImgPath = objvcc_CourseProEN.ExampleImgPath == "[null]" ? null :  objvcc_CourseProEN.ExampleImgPath; //示例图路径
}
if (arrFldSet.Contains(convcc_CoursePro.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.IdXzMajor = objvcc_CourseProEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convcc_CoursePro.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.MajorID = objvcc_CourseProEN.MajorID == "[null]" ? null :  objvcc_CourseProEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convcc_CoursePro.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.MajorName = objvcc_CourseProEN.MajorName == "[null]" ? null :  objvcc_CourseProEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convcc_CoursePro.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.IdXzCollege = objvcc_CourseProEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convcc_CoursePro.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.CollegeId = objvcc_CourseProEN.CollegeId == "[null]" ? null :  objvcc_CourseProEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convcc_CoursePro.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.CollegeName = objvcc_CourseProEN.CollegeName == "[null]" ? null :  objvcc_CourseProEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convcc_CoursePro.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.CollegeNameA = objvcc_CourseProEN.CollegeNameA == "[null]" ? null :  objvcc_CourseProEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convcc_CoursePro.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.Memo = objvcc_CourseProEN.Memo == "[null]" ? null :  objvcc_CourseProEN.Memo; //备注
}
if (arrFldSet.Contains(convcc_CoursePro.QuestionNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.QuestionNum = objvcc_CourseProEN.QuestionNum; //题目数
}
if (arrFldSet.Contains(convcc_CoursePro.KnowledgesNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.KnowledgesNum = objvcc_CourseProEN.KnowledgesNum; //知识点数
}
if (arrFldSet.Contains(convcc_CoursePro.TeacherNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.TeacherNum = objvcc_CourseProEN.TeacherNum; //教师数
}
if (arrFldSet.Contains(convcc_CoursePro.ChapterNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseProEN.ChapterNum = objvcc_CourseProEN.ChapterNum; //章节数
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
 /// <param name = "objvcc_CourseProEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_CourseProEN objvcc_CourseProEN)
{
try
{
if (objvcc_CourseProEN.CourseCode == "[null]") objvcc_CourseProEN.CourseCode = null; //课程代码
if (objvcc_CourseProEN.CourseDescription == "[null]") objvcc_CourseProEN.CourseDescription = null; //课程描述
if (objvcc_CourseProEN.CourseTypeId == "[null]") objvcc_CourseProEN.CourseTypeId = null; //课程类型ID
if (objvcc_CourseProEN.CourseTypeName == "[null]") objvcc_CourseProEN.CourseTypeName = null; //课程类型名称
if (objvcc_CourseProEN.CreateDate == "[null]") objvcc_CourseProEN.CreateDate = null; //建立日期
if (objvcc_CourseProEN.ExcellentTypeId == "[null]") objvcc_CourseProEN.ExcellentTypeId = null; //精品课程类型Id
if (objvcc_CourseProEN.ExcellentTypeName == "[null]") objvcc_CourseProEN.ExcellentTypeName = null; //精品课程类型名称
if (objvcc_CourseProEN.OperationDate == "[null]") objvcc_CourseProEN.OperationDate = null; //操作时间
if (objvcc_CourseProEN.OuterLink == "[null]") objvcc_CourseProEN.OuterLink = null; //外链地址
if (objvcc_CourseProEN.ThemeId == "[null]") objvcc_CourseProEN.ThemeId = null; //主题Id
if (objvcc_CourseProEN.ThemeName == "[null]") objvcc_CourseProEN.ThemeName = null; //主题名
if (objvcc_CourseProEN.ExampleImgPath == "[null]") objvcc_CourseProEN.ExampleImgPath = null; //示例图路径
if (objvcc_CourseProEN.MajorID == "[null]") objvcc_CourseProEN.MajorID = null; //专业ID
if (objvcc_CourseProEN.MajorName == "[null]") objvcc_CourseProEN.MajorName = null; //专业名称
if (objvcc_CourseProEN.CollegeId == "[null]") objvcc_CourseProEN.CollegeId = null; //学院ID
if (objvcc_CourseProEN.CollegeName == "[null]") objvcc_CourseProEN.CollegeName = null; //学院名称
if (objvcc_CourseProEN.CollegeNameA == "[null]") objvcc_CourseProEN.CollegeNameA = null; //学院名称简写
if (objvcc_CourseProEN.Memo == "[null]") objvcc_CourseProEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvcc_CourseProEN objvcc_CourseProEN)
{
 vcc_CourseProDA.CheckProperty4Condition(objvcc_CourseProEN);
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
//if (arrvcc_CourseProObjLstCache == null)
//{
//arrvcc_CourseProObjLstCache = vcc_CourseProDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCourseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseProEN GetObjByCourseIdCache(string strCourseId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvcc_CourseProEN._CurrTabName);
List<clsvcc_CourseProEN> arrvcc_CourseProObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseProEN> arrvcc_CourseProObjLst_Sel =
arrvcc_CourseProObjLstCache
.Where(x=> x.CourseId == strCourseId 
);
if (arrvcc_CourseProObjLst_Sel.Count() == 0)
{
   clsvcc_CourseProEN obj = clsvcc_CourseProBL.GetObjByCourseId(strCourseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvcc_CourseProObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseProEN> GetAllvcc_CourseProObjLstCache()
{
//获取缓存中的对象列表
List<clsvcc_CourseProEN> arrvcc_CourseProObjLstCache = GetObjLstCache(); 
return arrvcc_CourseProObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseProEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvcc_CourseProEN._CurrTabName);
List<clsvcc_CourseProEN> arrvcc_CourseProObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_CourseProObjLstCache;
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
string strKey = string.Format("{0}", clsvcc_CourseProEN._CurrTabName);
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
if (strInFldName != convcc_CoursePro.CourseId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_CoursePro.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_CoursePro.AttributeName));
throw new Exception(strMsg);
}
var objvcc_CoursePro = clsvcc_CourseProBL.GetObjByCourseIdCache(strCourseId);
if (objvcc_CoursePro == null) return "";
return objvcc_CoursePro[strOutFldName].ToString();
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
int intRecCount = clsvcc_CourseProDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_CourseProDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_CourseProDA.GetRecCount();
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
int intRecCount = clsvcc_CourseProDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_CourseProCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_CourseProEN objvcc_CourseProCond)
{
List<clsvcc_CourseProEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_CourseProEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CoursePro.AttributeName)
{
if (objvcc_CourseProCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseProCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseProCond[strFldName].ToString());
}
else
{
if (objvcc_CourseProCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseProCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseProCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseProCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseProCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseProCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseProCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseProCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseProCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseProCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseProCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseProCond[strFldName]));
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
 List<string> arrList = clsvcc_CourseProDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseProDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseProDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}