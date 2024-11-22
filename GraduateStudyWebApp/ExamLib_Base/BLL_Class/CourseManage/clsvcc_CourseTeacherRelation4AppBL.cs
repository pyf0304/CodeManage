
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseTeacherRelation4AppBL
 表名:vcc_CourseTeacherRelation4App(01120260)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:56
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
public static class  clsvcc_CourseTeacherRelation4AppBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngCourseTeacherRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseTeacherRelation4AppEN GetObj(this K_CourseTeacherRelationId_vcc_CourseTeacherRelation4App myKey)
{
clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = clsvcc_CourseTeacherRelation4AppBL.vcc_CourseTeacherRelation4AppDA.GetObjByCourseTeacherRelationId(myKey.Value);
return objvcc_CourseTeacherRelation4AppEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetCourseTeacherRelationId(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, long lngCourseTeacherRelationId, string strComparisonOp="")
	{
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = lngCourseTeacherRelationId; //课程教师关系表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.CourseTeacherRelationId) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.CourseTeacherRelationId, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseTeacherRelationId] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetCourseId(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, convcc_CourseTeacherRelation4App.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_CourseTeacherRelation4App.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_CourseTeacherRelation4App.CourseId);
}
objvcc_CourseTeacherRelation4AppEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.CourseId) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.CourseId, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseId] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetCourseCode(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convcc_CourseTeacherRelation4App.CourseCode);
}
objvcc_CourseTeacherRelation4AppEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.CourseCode) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.CourseCode, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseCode] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetCourseDescription(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strCourseDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, convcc_CourseTeacherRelation4App.CourseDescription);
}
objvcc_CourseTeacherRelation4AppEN.CourseDescription = strCourseDescription; //课程描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.CourseDescription) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.CourseDescription, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseDescription] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetCourseName(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_CourseTeacherRelation4App.CourseName);
}
objvcc_CourseTeacherRelation4AppEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.CourseName) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.CourseName, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseName] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetCourseTypeID(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strCourseTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, convcc_CourseTeacherRelation4App.CourseTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, convcc_CourseTeacherRelation4App.CourseTypeID);
}
objvcc_CourseTeacherRelation4AppEN.CourseTypeID = strCourseTypeID; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.CourseTypeID) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.CourseTypeID, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseTypeID] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetCreateDate(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convcc_CourseTeacherRelation4App.CreateDate);
}
objvcc_CourseTeacherRelation4AppEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.CreateDate) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.CreateDate, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CreateDate] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetIsOpen(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, bool bolIsOpen, string strComparisonOp="")
	{
objvcc_CourseTeacherRelation4AppEN.IsOpen = bolIsOpen; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.IsOpen) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.IsOpen, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.IsOpen] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetIsRecommendedCourse(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, bool bolIsRecommendedCourse, string strComparisonOp="")
	{
objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = bolIsRecommendedCourse; //是否推荐课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.IsRecommendedCourse) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.IsRecommendedCourse, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.IsRecommendedCourse] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetOrderNum(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, int? intOrderNum, string strComparisonOp="")
	{
objvcc_CourseTeacherRelation4AppEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.OrderNum) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.OrderNum, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.OrderNum] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetExampleImgPath(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strExampleImgPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExampleImgPath, 300, convcc_CourseTeacherRelation4App.ExampleImgPath);
}
objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = strExampleImgPath; //示例图路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.ExampleImgPath) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.ExampleImgPath, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.ExampleImgPath] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetViewCount(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, int? intViewCount, string strComparisonOp="")
	{
objvcc_CourseTeacherRelation4AppEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.ViewCount) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.ViewCount, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.ViewCount] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetIdXzMajor(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convcc_CourseTeacherRelation4App.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convcc_CourseTeacherRelation4App.IdXzMajor);
}
objvcc_CourseTeacherRelation4AppEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.IdXzMajor) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.IdXzMajor, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.IdXzMajor] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetIdXzCollege(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convcc_CourseTeacherRelation4App.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convcc_CourseTeacherRelation4App.IdXzCollege);
}
objvcc_CourseTeacherRelation4AppEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.IdXzCollege) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.IdXzCollege, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.IdXzCollege] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetIdTeacher(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strIdTeacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeacher, convcc_CourseTeacherRelation4App.IdTeacher);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeacher, 8, convcc_CourseTeacherRelation4App.IdTeacher);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeacher, 8, convcc_CourseTeacherRelation4App.IdTeacher);
}
objvcc_CourseTeacherRelation4AppEN.IdTeacher = strIdTeacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.IdTeacher) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.IdTeacher, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.IdTeacher] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetTeacherID(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strTeacherID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherID, 12, convcc_CourseTeacherRelation4App.TeacherID);
}
objvcc_CourseTeacherRelation4AppEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.TeacherID) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.TeacherID, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.TeacherID] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetTeacherName(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strTeacherName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convcc_CourseTeacherRelation4App.TeacherName);
}
objvcc_CourseTeacherRelation4AppEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.TeacherName) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.TeacherName, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.TeacherName] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetIsCourseManager(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, bool bolIsCourseManager, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCourseManager, convcc_CourseTeacherRelation4App.IsCourseManager);
objvcc_CourseTeacherRelation4AppEN.IsCourseManager = bolIsCourseManager; //是否课程主要人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.IsCourseManager) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.IsCourseManager, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.IsCourseManager] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetLastVisitedDate(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strLastVisitedDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastVisitedDate, 14, convcc_CourseTeacherRelation4App.LastVisitedDate);
}
objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = strLastVisitedDate; //最后访问时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.LastVisitedDate) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.LastVisitedDate, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.LastVisitedDate] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetUpdDate(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_CourseTeacherRelation4App.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_CourseTeacherRelation4App.UpdDate);
}
objvcc_CourseTeacherRelation4AppEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.UpdDate) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.UpdDate, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.UpdDate] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetUpdUser(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convcc_CourseTeacherRelation4App.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_CourseTeacherRelation4App.UpdUser);
}
objvcc_CourseTeacherRelation4AppEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.UpdUser) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.UpdUser, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.UpdUser] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_CourseTeacherRelation4AppEN SetMemo(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_CourseTeacherRelation4App.Memo);
}
objvcc_CourseTeacherRelation4AppEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_CourseTeacherRelation4App.Memo) == false)
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp.Add(convcc_CourseTeacherRelation4App.Memo, strComparisonOp);
}
else
{
objvcc_CourseTeacherRelation4AppEN.dicFldComparisonOp[convcc_CourseTeacherRelation4App.Memo] = strComparisonOp;
}
}
return objvcc_CourseTeacherRelation4AppEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppENS">源对象</param>
 /// <param name = "objvcc_CourseTeacherRelation4AppENT">目标对象</param>
 public static void CopyTo(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppENS, clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppENT)
{
try
{
objvcc_CourseTeacherRelation4AppENT.CourseTeacherRelationId = objvcc_CourseTeacherRelation4AppENS.CourseTeacherRelationId; //课程教师关系表流水号
objvcc_CourseTeacherRelation4AppENT.CourseId = objvcc_CourseTeacherRelation4AppENS.CourseId; //课程Id
objvcc_CourseTeacherRelation4AppENT.CourseCode = objvcc_CourseTeacherRelation4AppENS.CourseCode; //课程代码
objvcc_CourseTeacherRelation4AppENT.CourseDescription = objvcc_CourseTeacherRelation4AppENS.CourseDescription; //课程描述
objvcc_CourseTeacherRelation4AppENT.CourseName = objvcc_CourseTeacherRelation4AppENS.CourseName; //课程名称
objvcc_CourseTeacherRelation4AppENT.CourseTypeID = objvcc_CourseTeacherRelation4AppENS.CourseTypeID; //课程类型ID
objvcc_CourseTeacherRelation4AppENT.CreateDate = objvcc_CourseTeacherRelation4AppENS.CreateDate; //建立日期
objvcc_CourseTeacherRelation4AppENT.IsOpen = objvcc_CourseTeacherRelation4AppENS.IsOpen; //是否公开
objvcc_CourseTeacherRelation4AppENT.IsRecommendedCourse = objvcc_CourseTeacherRelation4AppENS.IsRecommendedCourse; //是否推荐课程
objvcc_CourseTeacherRelation4AppENT.OrderNum = objvcc_CourseTeacherRelation4AppENS.OrderNum; //序号
objvcc_CourseTeacherRelation4AppENT.ExampleImgPath = objvcc_CourseTeacherRelation4AppENS.ExampleImgPath; //示例图路径
objvcc_CourseTeacherRelation4AppENT.ViewCount = objvcc_CourseTeacherRelation4AppENS.ViewCount; //浏览量
objvcc_CourseTeacherRelation4AppENT.IdXzMajor = objvcc_CourseTeacherRelation4AppENS.IdXzMajor; //专业流水号
objvcc_CourseTeacherRelation4AppENT.IdXzCollege = objvcc_CourseTeacherRelation4AppENS.IdXzCollege; //学院流水号
objvcc_CourseTeacherRelation4AppENT.IdTeacher = objvcc_CourseTeacherRelation4AppENS.IdTeacher; //教师流水号
objvcc_CourseTeacherRelation4AppENT.TeacherID = objvcc_CourseTeacherRelation4AppENS.TeacherID; //教师工号
objvcc_CourseTeacherRelation4AppENT.TeacherName = objvcc_CourseTeacherRelation4AppENS.TeacherName; //教师姓名
objvcc_CourseTeacherRelation4AppENT.IsCourseManager = objvcc_CourseTeacherRelation4AppENS.IsCourseManager; //是否课程主要人
objvcc_CourseTeacherRelation4AppENT.LastVisitedDate = objvcc_CourseTeacherRelation4AppENS.LastVisitedDate; //最后访问时间
objvcc_CourseTeacherRelation4AppENT.UpdDate = objvcc_CourseTeacherRelation4AppENS.UpdDate; //修改日期
objvcc_CourseTeacherRelation4AppENT.UpdUser = objvcc_CourseTeacherRelation4AppENS.UpdUser; //修改人
objvcc_CourseTeacherRelation4AppENT.Memo = objvcc_CourseTeacherRelation4AppENS.Memo; //备注
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
 /// <param name = "objvcc_CourseTeacherRelation4AppENS">源对象</param>
 /// <returns>目标对象=>clsvcc_CourseTeacherRelation4AppEN:objvcc_CourseTeacherRelation4AppENT</returns>
 public static clsvcc_CourseTeacherRelation4AppEN CopyTo(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppENS)
{
try
{
 clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppENT = new clsvcc_CourseTeacherRelation4AppEN()
{
CourseTeacherRelationId = objvcc_CourseTeacherRelation4AppENS.CourseTeacherRelationId, //课程教师关系表流水号
CourseId = objvcc_CourseTeacherRelation4AppENS.CourseId, //课程Id
CourseCode = objvcc_CourseTeacherRelation4AppENS.CourseCode, //课程代码
CourseDescription = objvcc_CourseTeacherRelation4AppENS.CourseDescription, //课程描述
CourseName = objvcc_CourseTeacherRelation4AppENS.CourseName, //课程名称
CourseTypeID = objvcc_CourseTeacherRelation4AppENS.CourseTypeID, //课程类型ID
CreateDate = objvcc_CourseTeacherRelation4AppENS.CreateDate, //建立日期
IsOpen = objvcc_CourseTeacherRelation4AppENS.IsOpen, //是否公开
IsRecommendedCourse = objvcc_CourseTeacherRelation4AppENS.IsRecommendedCourse, //是否推荐课程
OrderNum = objvcc_CourseTeacherRelation4AppENS.OrderNum, //序号
ExampleImgPath = objvcc_CourseTeacherRelation4AppENS.ExampleImgPath, //示例图路径
ViewCount = objvcc_CourseTeacherRelation4AppENS.ViewCount, //浏览量
IdXzMajor = objvcc_CourseTeacherRelation4AppENS.IdXzMajor, //专业流水号
IdXzCollege = objvcc_CourseTeacherRelation4AppENS.IdXzCollege, //学院流水号
IdTeacher = objvcc_CourseTeacherRelation4AppENS.IdTeacher, //教师流水号
TeacherID = objvcc_CourseTeacherRelation4AppENS.TeacherID, //教师工号
TeacherName = objvcc_CourseTeacherRelation4AppENS.TeacherName, //教师姓名
IsCourseManager = objvcc_CourseTeacherRelation4AppENS.IsCourseManager, //是否课程主要人
LastVisitedDate = objvcc_CourseTeacherRelation4AppENS.LastVisitedDate, //最后访问时间
UpdDate = objvcc_CourseTeacherRelation4AppENS.UpdDate, //修改日期
UpdUser = objvcc_CourseTeacherRelation4AppENS.UpdUser, //修改人
Memo = objvcc_CourseTeacherRelation4AppENS.Memo, //备注
};
 return objvcc_CourseTeacherRelation4AppENT;
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
public static void CheckProperty4Condition(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN)
{
 clsvcc_CourseTeacherRelation4AppBL.vcc_CourseTeacherRelation4AppDA.CheckProperty4Condition(objvcc_CourseTeacherRelation4AppEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.CourseTeacherRelationId) == true)
{
string strComparisonOpCourseTeacherRelationId = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseTeacherRelationId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseTeacherRelation4App.CourseTeacherRelationId, objvcc_CourseTeacherRelation4AppCond.CourseTeacherRelationId, strComparisonOpCourseTeacherRelationId);
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.CourseId, objvcc_CourseTeacherRelation4AppCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.CourseCode) == true)
{
string strComparisonOpCourseCode = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.CourseCode, objvcc_CourseTeacherRelation4AppCond.CourseCode, strComparisonOpCourseCode);
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.CourseDescription) == true)
{
string strComparisonOpCourseDescription = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.CourseDescription, objvcc_CourseTeacherRelation4AppCond.CourseDescription, strComparisonOpCourseDescription);
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.CourseName, objvcc_CourseTeacherRelation4AppCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.CourseTypeID) == true)
{
string strComparisonOpCourseTypeID = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.CourseTypeID, objvcc_CourseTeacherRelation4AppCond.CourseTypeID, strComparisonOpCourseTypeID);
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.CreateDate) == true)
{
string strComparisonOpCreateDate = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.CreateDate, objvcc_CourseTeacherRelation4AppCond.CreateDate, strComparisonOpCreateDate);
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.IsOpen) == true)
{
if (objvcc_CourseTeacherRelation4AppCond.IsOpen == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseTeacherRelation4App.IsOpen);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseTeacherRelation4App.IsOpen);
}
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.IsRecommendedCourse) == true)
{
if (objvcc_CourseTeacherRelation4AppCond.IsRecommendedCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseTeacherRelation4App.IsRecommendedCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseTeacherRelation4App.IsRecommendedCourse);
}
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.OrderNum) == true)
{
string strComparisonOpOrderNum = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseTeacherRelation4App.OrderNum, objvcc_CourseTeacherRelation4AppCond.OrderNum, strComparisonOpOrderNum);
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.ExampleImgPath) == true)
{
string strComparisonOpExampleImgPath = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.ExampleImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.ExampleImgPath, objvcc_CourseTeacherRelation4AppCond.ExampleImgPath, strComparisonOpExampleImgPath);
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.ViewCount) == true)
{
string strComparisonOpViewCount = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_CourseTeacherRelation4App.ViewCount, objvcc_CourseTeacherRelation4AppCond.ViewCount, strComparisonOpViewCount);
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.IdXzMajor, objvcc_CourseTeacherRelation4AppCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.IdXzCollege, objvcc_CourseTeacherRelation4AppCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.IdTeacher) == true)
{
string strComparisonOpIdTeacher = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.IdTeacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.IdTeacher, objvcc_CourseTeacherRelation4AppCond.IdTeacher, strComparisonOpIdTeacher);
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.TeacherID) == true)
{
string strComparisonOpTeacherID = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.TeacherID, objvcc_CourseTeacherRelation4AppCond.TeacherID, strComparisonOpTeacherID);
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.TeacherName) == true)
{
string strComparisonOpTeacherName = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.TeacherName, objvcc_CourseTeacherRelation4AppCond.TeacherName, strComparisonOpTeacherName);
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.IsCourseManager) == true)
{
if (objvcc_CourseTeacherRelation4AppCond.IsCourseManager == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_CourseTeacherRelation4App.IsCourseManager);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_CourseTeacherRelation4App.IsCourseManager);
}
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.LastVisitedDate) == true)
{
string strComparisonOpLastVisitedDate = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.LastVisitedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.LastVisitedDate, objvcc_CourseTeacherRelation4AppCond.LastVisitedDate, strComparisonOpLastVisitedDate);
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.UpdDate, objvcc_CourseTeacherRelation4AppCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.UpdUser) == true)
{
string strComparisonOpUpdUser = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.UpdUser, objvcc_CourseTeacherRelation4AppCond.UpdUser, strComparisonOpUpdUser);
}
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(convcc_CourseTeacherRelation4App.Memo) == true)
{
string strComparisonOpMemo = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[convcc_CourseTeacherRelation4App.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_CourseTeacherRelation4App.Memo, objvcc_CourseTeacherRelation4AppCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_CourseTeacherRelation4App
{
public virtual bool UpdRelaTabDate(long lngCourseTeacherRelationId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程和教师关系4App(vcc_CourseTeacherRelation4App)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_CourseTeacherRelation4AppBL
{
public static RelatedActions_vcc_CourseTeacherRelation4App relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_CourseTeacherRelation4AppDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_CourseTeacherRelation4AppDA vcc_CourseTeacherRelation4AppDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_CourseTeacherRelation4AppDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_CourseTeacherRelation4AppBL()
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
if (string.IsNullOrEmpty(clsvcc_CourseTeacherRelation4AppEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseTeacherRelation4AppEN._ConnectString);
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
public static DataTable GetDataTable_vcc_CourseTeacherRelation4App(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_CourseTeacherRelation4AppDA.GetDataTable_vcc_CourseTeacherRelation4App(strWhereCond);
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
objDT = vcc_CourseTeacherRelation4AppDA.GetDataTable(strWhereCond);
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
objDT = vcc_CourseTeacherRelation4AppDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_CourseTeacherRelation4AppDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_CourseTeacherRelation4AppDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_CourseTeacherRelation4AppDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_CourseTeacherRelation4AppDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_CourseTeacherRelation4AppDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_CourseTeacherRelation4AppDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvcc_CourseTeacherRelation4AppEN> GetObjLstByCourseTeacherRelationIdLst(List<long> arrCourseTeacherRelationIdLst)
{
List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = new List<clsvcc_CourseTeacherRelation4AppEN>(); 
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
	clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = new clsvcc_CourseTeacherRelation4AppEN();
try
{
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation4App.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelation4AppEN.CourseId = objRow[convcc_CourseTeacherRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelation4AppEN.CourseCode = objRow[convcc_CourseTeacherRelation4App.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelation4AppEN.CourseDescription = objRow[convcc_CourseTeacherRelation4App.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelation4AppEN.CourseName = objRow[convcc_CourseTeacherRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelation4AppEN.CourseTypeID = objRow[convcc_CourseTeacherRelation4App.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelation4AppEN.CreateDate = objRow[convcc_CourseTeacherRelation4App.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelation4AppEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelation4AppEN.OrderNum = objRow[convcc_CourseTeacherRelation4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation4App.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelation4AppEN.ViewCount = objRow[convcc_CourseTeacherRelation4App.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelation4AppEN.IdXzMajor = objRow[convcc_CourseTeacherRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelation4AppEN.IdXzCollege = objRow[convcc_CourseTeacherRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelation4AppEN.IdTeacher = objRow[convcc_CourseTeacherRelation4App.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelation4AppEN.TeacherID = objRow[convcc_CourseTeacherRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelation4AppEN.TeacherName = objRow[convcc_CourseTeacherRelation4App.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelation4AppEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation4App.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelation4AppEN.UpdDate = objRow[convcc_CourseTeacherRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelation4AppEN.UpdUser = objRow[convcc_CourseTeacherRelation4App.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelation4AppEN.Memo = objRow[convcc_CourseTeacherRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelation4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseTeacherRelationIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_CourseTeacherRelation4AppEN> GetObjLstByCourseTeacherRelationIdLstCache(List<long> arrCourseTeacherRelationIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvcc_CourseTeacherRelation4AppEN._CurrTabName, strCourseId);
List<clsvcc_CourseTeacherRelation4AppEN> arrvcc_CourseTeacherRelation4AppObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseTeacherRelation4AppEN> arrvcc_CourseTeacherRelation4AppObjLst_Sel =
arrvcc_CourseTeacherRelation4AppObjLstCache
.Where(x => arrCourseTeacherRelationIdLst.Contains(x.CourseTeacherRelationId));
return arrvcc_CourseTeacherRelation4AppObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseTeacherRelation4AppEN> GetObjLst(string strWhereCond)
{
List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = new List<clsvcc_CourseTeacherRelation4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = new clsvcc_CourseTeacherRelation4AppEN();
try
{
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation4App.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelation4AppEN.CourseId = objRow[convcc_CourseTeacherRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelation4AppEN.CourseCode = objRow[convcc_CourseTeacherRelation4App.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelation4AppEN.CourseDescription = objRow[convcc_CourseTeacherRelation4App.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelation4AppEN.CourseName = objRow[convcc_CourseTeacherRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelation4AppEN.CourseTypeID = objRow[convcc_CourseTeacherRelation4App.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelation4AppEN.CreateDate = objRow[convcc_CourseTeacherRelation4App.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelation4AppEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelation4AppEN.OrderNum = objRow[convcc_CourseTeacherRelation4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation4App.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelation4AppEN.ViewCount = objRow[convcc_CourseTeacherRelation4App.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelation4AppEN.IdXzMajor = objRow[convcc_CourseTeacherRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelation4AppEN.IdXzCollege = objRow[convcc_CourseTeacherRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelation4AppEN.IdTeacher = objRow[convcc_CourseTeacherRelation4App.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelation4AppEN.TeacherID = objRow[convcc_CourseTeacherRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelation4AppEN.TeacherName = objRow[convcc_CourseTeacherRelation4App.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelation4AppEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation4App.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelation4AppEN.UpdDate = objRow[convcc_CourseTeacherRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelation4AppEN.UpdUser = objRow[convcc_CourseTeacherRelation4App.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelation4AppEN.Memo = objRow[convcc_CourseTeacherRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelation4AppEN);
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
public static List<clsvcc_CourseTeacherRelation4AppEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = new List<clsvcc_CourseTeacherRelation4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = new clsvcc_CourseTeacherRelation4AppEN();
try
{
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation4App.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelation4AppEN.CourseId = objRow[convcc_CourseTeacherRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelation4AppEN.CourseCode = objRow[convcc_CourseTeacherRelation4App.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelation4AppEN.CourseDescription = objRow[convcc_CourseTeacherRelation4App.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelation4AppEN.CourseName = objRow[convcc_CourseTeacherRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelation4AppEN.CourseTypeID = objRow[convcc_CourseTeacherRelation4App.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelation4AppEN.CreateDate = objRow[convcc_CourseTeacherRelation4App.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelation4AppEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelation4AppEN.OrderNum = objRow[convcc_CourseTeacherRelation4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation4App.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelation4AppEN.ViewCount = objRow[convcc_CourseTeacherRelation4App.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelation4AppEN.IdXzMajor = objRow[convcc_CourseTeacherRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelation4AppEN.IdXzCollege = objRow[convcc_CourseTeacherRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelation4AppEN.IdTeacher = objRow[convcc_CourseTeacherRelation4App.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelation4AppEN.TeacherID = objRow[convcc_CourseTeacherRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelation4AppEN.TeacherName = objRow[convcc_CourseTeacherRelation4App.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelation4AppEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation4App.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelation4AppEN.UpdDate = objRow[convcc_CourseTeacherRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelation4AppEN.UpdUser = objRow[convcc_CourseTeacherRelation4App.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelation4AppEN.Memo = objRow[convcc_CourseTeacherRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelation4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_CourseTeacherRelation4AppEN> GetSubObjLstCache(clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppCond)
{
 string strCourseId = objvcc_CourseTeacherRelation4AppCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvcc_CourseTeacherRelation4AppBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvcc_CourseTeacherRelation4AppEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseTeacherRelation4AppEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseTeacherRelation4App.AttributeName)
{
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseTeacherRelation4AppCond[strFldName].ToString());
}
else
{
if (objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseTeacherRelation4AppCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseTeacherRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseTeacherRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseTeacherRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseTeacherRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseTeacherRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseTeacherRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseTeacherRelation4AppCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseTeacherRelation4AppCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseTeacherRelation4AppCond[strFldName]));
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
public static List<clsvcc_CourseTeacherRelation4AppEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = new List<clsvcc_CourseTeacherRelation4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = new clsvcc_CourseTeacherRelation4AppEN();
try
{
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation4App.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelation4AppEN.CourseId = objRow[convcc_CourseTeacherRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelation4AppEN.CourseCode = objRow[convcc_CourseTeacherRelation4App.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelation4AppEN.CourseDescription = objRow[convcc_CourseTeacherRelation4App.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelation4AppEN.CourseName = objRow[convcc_CourseTeacherRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelation4AppEN.CourseTypeID = objRow[convcc_CourseTeacherRelation4App.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelation4AppEN.CreateDate = objRow[convcc_CourseTeacherRelation4App.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelation4AppEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelation4AppEN.OrderNum = objRow[convcc_CourseTeacherRelation4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation4App.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelation4AppEN.ViewCount = objRow[convcc_CourseTeacherRelation4App.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelation4AppEN.IdXzMajor = objRow[convcc_CourseTeacherRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelation4AppEN.IdXzCollege = objRow[convcc_CourseTeacherRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelation4AppEN.IdTeacher = objRow[convcc_CourseTeacherRelation4App.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelation4AppEN.TeacherID = objRow[convcc_CourseTeacherRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelation4AppEN.TeacherName = objRow[convcc_CourseTeacherRelation4App.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelation4AppEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation4App.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelation4AppEN.UpdDate = objRow[convcc_CourseTeacherRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelation4AppEN.UpdUser = objRow[convcc_CourseTeacherRelation4App.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelation4AppEN.Memo = objRow[convcc_CourseTeacherRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelation4AppEN);
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
public static List<clsvcc_CourseTeacherRelation4AppEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = new List<clsvcc_CourseTeacherRelation4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = new clsvcc_CourseTeacherRelation4AppEN();
try
{
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation4App.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelation4AppEN.CourseId = objRow[convcc_CourseTeacherRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelation4AppEN.CourseCode = objRow[convcc_CourseTeacherRelation4App.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelation4AppEN.CourseDescription = objRow[convcc_CourseTeacherRelation4App.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelation4AppEN.CourseName = objRow[convcc_CourseTeacherRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelation4AppEN.CourseTypeID = objRow[convcc_CourseTeacherRelation4App.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelation4AppEN.CreateDate = objRow[convcc_CourseTeacherRelation4App.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelation4AppEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelation4AppEN.OrderNum = objRow[convcc_CourseTeacherRelation4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation4App.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelation4AppEN.ViewCount = objRow[convcc_CourseTeacherRelation4App.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelation4AppEN.IdXzMajor = objRow[convcc_CourseTeacherRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelation4AppEN.IdXzCollege = objRow[convcc_CourseTeacherRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelation4AppEN.IdTeacher = objRow[convcc_CourseTeacherRelation4App.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelation4AppEN.TeacherID = objRow[convcc_CourseTeacherRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelation4AppEN.TeacherName = objRow[convcc_CourseTeacherRelation4App.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelation4AppEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation4App.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelation4AppEN.UpdDate = objRow[convcc_CourseTeacherRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelation4AppEN.UpdUser = objRow[convcc_CourseTeacherRelation4App.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelation4AppEN.Memo = objRow[convcc_CourseTeacherRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelation4AppEN);
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
List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseTeacherRelation4AppEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_CourseTeacherRelation4AppEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = new List<clsvcc_CourseTeacherRelation4AppEN>(); 
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
	clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = new clsvcc_CourseTeacherRelation4AppEN();
try
{
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation4App.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelation4AppEN.CourseId = objRow[convcc_CourseTeacherRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelation4AppEN.CourseCode = objRow[convcc_CourseTeacherRelation4App.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelation4AppEN.CourseDescription = objRow[convcc_CourseTeacherRelation4App.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelation4AppEN.CourseName = objRow[convcc_CourseTeacherRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelation4AppEN.CourseTypeID = objRow[convcc_CourseTeacherRelation4App.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelation4AppEN.CreateDate = objRow[convcc_CourseTeacherRelation4App.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelation4AppEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelation4AppEN.OrderNum = objRow[convcc_CourseTeacherRelation4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation4App.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelation4AppEN.ViewCount = objRow[convcc_CourseTeacherRelation4App.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelation4AppEN.IdXzMajor = objRow[convcc_CourseTeacherRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelation4AppEN.IdXzCollege = objRow[convcc_CourseTeacherRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelation4AppEN.IdTeacher = objRow[convcc_CourseTeacherRelation4App.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelation4AppEN.TeacherID = objRow[convcc_CourseTeacherRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelation4AppEN.TeacherName = objRow[convcc_CourseTeacherRelation4App.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelation4AppEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation4App.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelation4AppEN.UpdDate = objRow[convcc_CourseTeacherRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelation4AppEN.UpdUser = objRow[convcc_CourseTeacherRelation4App.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelation4AppEN.Memo = objRow[convcc_CourseTeacherRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelation4AppEN);
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
public static List<clsvcc_CourseTeacherRelation4AppEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = new List<clsvcc_CourseTeacherRelation4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = new clsvcc_CourseTeacherRelation4AppEN();
try
{
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation4App.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelation4AppEN.CourseId = objRow[convcc_CourseTeacherRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelation4AppEN.CourseCode = objRow[convcc_CourseTeacherRelation4App.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelation4AppEN.CourseDescription = objRow[convcc_CourseTeacherRelation4App.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelation4AppEN.CourseName = objRow[convcc_CourseTeacherRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelation4AppEN.CourseTypeID = objRow[convcc_CourseTeacherRelation4App.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelation4AppEN.CreateDate = objRow[convcc_CourseTeacherRelation4App.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelation4AppEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelation4AppEN.OrderNum = objRow[convcc_CourseTeacherRelation4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation4App.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelation4AppEN.ViewCount = objRow[convcc_CourseTeacherRelation4App.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelation4AppEN.IdXzMajor = objRow[convcc_CourseTeacherRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelation4AppEN.IdXzCollege = objRow[convcc_CourseTeacherRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelation4AppEN.IdTeacher = objRow[convcc_CourseTeacherRelation4App.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelation4AppEN.TeacherID = objRow[convcc_CourseTeacherRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelation4AppEN.TeacherName = objRow[convcc_CourseTeacherRelation4App.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelation4AppEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation4App.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelation4AppEN.UpdDate = objRow[convcc_CourseTeacherRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelation4AppEN.UpdUser = objRow[convcc_CourseTeacherRelation4App.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelation4AppEN.Memo = objRow[convcc_CourseTeacherRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelation4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_CourseTeacherRelation4AppEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_CourseTeacherRelation4AppEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = new List<clsvcc_CourseTeacherRelation4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = new clsvcc_CourseTeacherRelation4AppEN();
try
{
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation4App.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelation4AppEN.CourseId = objRow[convcc_CourseTeacherRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelation4AppEN.CourseCode = objRow[convcc_CourseTeacherRelation4App.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelation4AppEN.CourseDescription = objRow[convcc_CourseTeacherRelation4App.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelation4AppEN.CourseName = objRow[convcc_CourseTeacherRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelation4AppEN.CourseTypeID = objRow[convcc_CourseTeacherRelation4App.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelation4AppEN.CreateDate = objRow[convcc_CourseTeacherRelation4App.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelation4AppEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelation4AppEN.OrderNum = objRow[convcc_CourseTeacherRelation4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation4App.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelation4AppEN.ViewCount = objRow[convcc_CourseTeacherRelation4App.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelation4AppEN.IdXzMajor = objRow[convcc_CourseTeacherRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelation4AppEN.IdXzCollege = objRow[convcc_CourseTeacherRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelation4AppEN.IdTeacher = objRow[convcc_CourseTeacherRelation4App.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelation4AppEN.TeacherID = objRow[convcc_CourseTeacherRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelation4AppEN.TeacherName = objRow[convcc_CourseTeacherRelation4App.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelation4AppEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation4App.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelation4AppEN.UpdDate = objRow[convcc_CourseTeacherRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelation4AppEN.UpdUser = objRow[convcc_CourseTeacherRelation4App.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelation4AppEN.Memo = objRow[convcc_CourseTeacherRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelation4AppEN);
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
public static List<clsvcc_CourseTeacherRelation4AppEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = new List<clsvcc_CourseTeacherRelation4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = new clsvcc_CourseTeacherRelation4AppEN();
try
{
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation4App.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelation4AppEN.CourseId = objRow[convcc_CourseTeacherRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelation4AppEN.CourseCode = objRow[convcc_CourseTeacherRelation4App.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelation4AppEN.CourseDescription = objRow[convcc_CourseTeacherRelation4App.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelation4AppEN.CourseName = objRow[convcc_CourseTeacherRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelation4AppEN.CourseTypeID = objRow[convcc_CourseTeacherRelation4App.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelation4AppEN.CreateDate = objRow[convcc_CourseTeacherRelation4App.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelation4AppEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelation4AppEN.OrderNum = objRow[convcc_CourseTeacherRelation4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation4App.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelation4AppEN.ViewCount = objRow[convcc_CourseTeacherRelation4App.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelation4AppEN.IdXzMajor = objRow[convcc_CourseTeacherRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelation4AppEN.IdXzCollege = objRow[convcc_CourseTeacherRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelation4AppEN.IdTeacher = objRow[convcc_CourseTeacherRelation4App.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelation4AppEN.TeacherID = objRow[convcc_CourseTeacherRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelation4AppEN.TeacherName = objRow[convcc_CourseTeacherRelation4App.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelation4AppEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation4App.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelation4AppEN.UpdDate = objRow[convcc_CourseTeacherRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelation4AppEN.UpdUser = objRow[convcc_CourseTeacherRelation4App.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelation4AppEN.Memo = objRow[convcc_CourseTeacherRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelation4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_CourseTeacherRelation4AppEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = new List<clsvcc_CourseTeacherRelation4AppEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = new clsvcc_CourseTeacherRelation4AppEN();
try
{
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation4App.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelation4AppEN.CourseId = objRow[convcc_CourseTeacherRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelation4AppEN.CourseCode = objRow[convcc_CourseTeacherRelation4App.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelation4AppEN.CourseDescription = objRow[convcc_CourseTeacherRelation4App.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelation4AppEN.CourseName = objRow[convcc_CourseTeacherRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelation4AppEN.CourseTypeID = objRow[convcc_CourseTeacherRelation4App.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelation4AppEN.CreateDate = objRow[convcc_CourseTeacherRelation4App.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelation4AppEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelation4AppEN.OrderNum = objRow[convcc_CourseTeacherRelation4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation4App.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelation4AppEN.ViewCount = objRow[convcc_CourseTeacherRelation4App.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelation4AppEN.IdXzMajor = objRow[convcc_CourseTeacherRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelation4AppEN.IdXzCollege = objRow[convcc_CourseTeacherRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelation4AppEN.IdTeacher = objRow[convcc_CourseTeacherRelation4App.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelation4AppEN.TeacherID = objRow[convcc_CourseTeacherRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelation4AppEN.TeacherName = objRow[convcc_CourseTeacherRelation4App.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelation4AppEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation4App.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelation4AppEN.UpdDate = objRow[convcc_CourseTeacherRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelation4AppEN.UpdUser = objRow[convcc_CourseTeacherRelation4App.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelation4AppEN.Memo = objRow[convcc_CourseTeacherRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_CourseTeacherRelation4AppEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_CourseTeacherRelation4App(ref clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN)
{
bool bolResult = vcc_CourseTeacherRelation4AppDA.Getvcc_CourseTeacherRelation4App(ref objvcc_CourseTeacherRelation4AppEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngCourseTeacherRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_CourseTeacherRelation4AppEN GetObjByCourseTeacherRelationId(long lngCourseTeacherRelationId)
{
clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = vcc_CourseTeacherRelation4AppDA.GetObjByCourseTeacherRelationId(lngCourseTeacherRelationId);
return objvcc_CourseTeacherRelation4AppEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_CourseTeacherRelation4AppEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = vcc_CourseTeacherRelation4AppDA.GetFirstObj(strWhereCond);
 return objvcc_CourseTeacherRelation4AppEN;
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
public static clsvcc_CourseTeacherRelation4AppEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = vcc_CourseTeacherRelation4AppDA.GetObjByDataRow(objRow);
 return objvcc_CourseTeacherRelation4AppEN;
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
public static clsvcc_CourseTeacherRelation4AppEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = vcc_CourseTeacherRelation4AppDA.GetObjByDataRow(objRow);
 return objvcc_CourseTeacherRelation4AppEN;
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
 /// <param name = "lstvcc_CourseTeacherRelation4AppObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseTeacherRelation4AppEN GetObjByCourseTeacherRelationIdFromList(long lngCourseTeacherRelationId, List<clsvcc_CourseTeacherRelation4AppEN> lstvcc_CourseTeacherRelation4AppObjLst)
{
foreach (clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN in lstvcc_CourseTeacherRelation4AppObjLst)
{
if (objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId == lngCourseTeacherRelationId)
{
return objvcc_CourseTeacherRelation4AppEN;
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
 lngCourseTeacherRelationId = new clsvcc_CourseTeacherRelation4AppDA().GetFirstID(strWhereCond);
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
 arrList = vcc_CourseTeacherRelation4AppDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_CourseTeacherRelation4AppDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vcc_CourseTeacherRelation4AppDA.IsExist(lngCourseTeacherRelationId);
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
 bolIsExist = clsvcc_CourseTeacherRelation4AppDA.IsExistTable();
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
 bolIsExist = vcc_CourseTeacherRelation4AppDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_CourseTeacherRelation4AppENS">源对象</param>
 /// <param name = "objvcc_CourseTeacherRelation4AppENT">目标对象</param>
 public static void CopyTo(clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppENS, clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppENT)
{
try
{
objvcc_CourseTeacherRelation4AppENT.CourseTeacherRelationId = objvcc_CourseTeacherRelation4AppENS.CourseTeacherRelationId; //课程教师关系表流水号
objvcc_CourseTeacherRelation4AppENT.CourseId = objvcc_CourseTeacherRelation4AppENS.CourseId; //课程Id
objvcc_CourseTeacherRelation4AppENT.CourseCode = objvcc_CourseTeacherRelation4AppENS.CourseCode; //课程代码
objvcc_CourseTeacherRelation4AppENT.CourseDescription = objvcc_CourseTeacherRelation4AppENS.CourseDescription; //课程描述
objvcc_CourseTeacherRelation4AppENT.CourseName = objvcc_CourseTeacherRelation4AppENS.CourseName; //课程名称
objvcc_CourseTeacherRelation4AppENT.CourseTypeID = objvcc_CourseTeacherRelation4AppENS.CourseTypeID; //课程类型ID
objvcc_CourseTeacherRelation4AppENT.CreateDate = objvcc_CourseTeacherRelation4AppENS.CreateDate; //建立日期
objvcc_CourseTeacherRelation4AppENT.IsOpen = objvcc_CourseTeacherRelation4AppENS.IsOpen; //是否公开
objvcc_CourseTeacherRelation4AppENT.IsRecommendedCourse = objvcc_CourseTeacherRelation4AppENS.IsRecommendedCourse; //是否推荐课程
objvcc_CourseTeacherRelation4AppENT.OrderNum = objvcc_CourseTeacherRelation4AppENS.OrderNum; //序号
objvcc_CourseTeacherRelation4AppENT.ExampleImgPath = objvcc_CourseTeacherRelation4AppENS.ExampleImgPath; //示例图路径
objvcc_CourseTeacherRelation4AppENT.ViewCount = objvcc_CourseTeacherRelation4AppENS.ViewCount; //浏览量
objvcc_CourseTeacherRelation4AppENT.IdXzMajor = objvcc_CourseTeacherRelation4AppENS.IdXzMajor; //专业流水号
objvcc_CourseTeacherRelation4AppENT.IdXzCollege = objvcc_CourseTeacherRelation4AppENS.IdXzCollege; //学院流水号
objvcc_CourseTeacherRelation4AppENT.IdTeacher = objvcc_CourseTeacherRelation4AppENS.IdTeacher; //教师流水号
objvcc_CourseTeacherRelation4AppENT.TeacherID = objvcc_CourseTeacherRelation4AppENS.TeacherID; //教师工号
objvcc_CourseTeacherRelation4AppENT.TeacherName = objvcc_CourseTeacherRelation4AppENS.TeacherName; //教师姓名
objvcc_CourseTeacherRelation4AppENT.IsCourseManager = objvcc_CourseTeacherRelation4AppENS.IsCourseManager; //是否课程主要人
objvcc_CourseTeacherRelation4AppENT.LastVisitedDate = objvcc_CourseTeacherRelation4AppENS.LastVisitedDate; //最后访问时间
objvcc_CourseTeacherRelation4AppENT.UpdDate = objvcc_CourseTeacherRelation4AppENS.UpdDate; //修改日期
objvcc_CourseTeacherRelation4AppENT.UpdUser = objvcc_CourseTeacherRelation4AppENS.UpdUser; //修改人
objvcc_CourseTeacherRelation4AppENT.Memo = objvcc_CourseTeacherRelation4AppENS.Memo; //备注
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
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN)
{
try
{
objvcc_CourseTeacherRelation4AppEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_CourseTeacherRelation4AppEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.CourseTeacherRelationId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId; //课程教师关系表流水号
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.CourseId = objvcc_CourseTeacherRelation4AppEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.CourseCode = objvcc_CourseTeacherRelation4AppEN.CourseCode == "[null]" ? null :  objvcc_CourseTeacherRelation4AppEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.CourseDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.CourseDescription = objvcc_CourseTeacherRelation4AppEN.CourseDescription == "[null]" ? null :  objvcc_CourseTeacherRelation4AppEN.CourseDescription; //课程描述
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.CourseName = objvcc_CourseTeacherRelation4AppEN.CourseName == "[null]" ? null :  objvcc_CourseTeacherRelation4AppEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.CourseTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.CourseTypeID = objvcc_CourseTeacherRelation4AppEN.CourseTypeID == "[null]" ? null :  objvcc_CourseTeacherRelation4AppEN.CourseTypeID; //课程类型ID
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.CreateDate = objvcc_CourseTeacherRelation4AppEN.CreateDate == "[null]" ? null :  objvcc_CourseTeacherRelation4AppEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.IsOpen, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.IsOpen = objvcc_CourseTeacherRelation4AppEN.IsOpen; //是否公开
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.IsRecommendedCourse, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse; //是否推荐课程
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.OrderNum = objvcc_CourseTeacherRelation4AppEN.OrderNum; //序号
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.ExampleImgPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = objvcc_CourseTeacherRelation4AppEN.ExampleImgPath == "[null]" ? null :  objvcc_CourseTeacherRelation4AppEN.ExampleImgPath; //示例图路径
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.ViewCount = objvcc_CourseTeacherRelation4AppEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.IdXzMajor = objvcc_CourseTeacherRelation4AppEN.IdXzMajor == "[null]" ? null :  objvcc_CourseTeacherRelation4AppEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.IdXzCollege = objvcc_CourseTeacherRelation4AppEN.IdXzCollege == "[null]" ? null :  objvcc_CourseTeacherRelation4AppEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.IdTeacher, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.IdTeacher = objvcc_CourseTeacherRelation4AppEN.IdTeacher; //教师流水号
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.TeacherID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.TeacherID = objvcc_CourseTeacherRelation4AppEN.TeacherID == "[null]" ? null :  objvcc_CourseTeacherRelation4AppEN.TeacherID; //教师工号
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.TeacherName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.TeacherName = objvcc_CourseTeacherRelation4AppEN.TeacherName == "[null]" ? null :  objvcc_CourseTeacherRelation4AppEN.TeacherName; //教师姓名
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.IsCourseManager, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.IsCourseManager = objvcc_CourseTeacherRelation4AppEN.IsCourseManager; //是否课程主要人
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.LastVisitedDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = objvcc_CourseTeacherRelation4AppEN.LastVisitedDate == "[null]" ? null :  objvcc_CourseTeacherRelation4AppEN.LastVisitedDate; //最后访问时间
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.UpdDate = objvcc_CourseTeacherRelation4AppEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.UpdUser = objvcc_CourseTeacherRelation4AppEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convcc_CourseTeacherRelation4App.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_CourseTeacherRelation4AppEN.Memo = objvcc_CourseTeacherRelation4AppEN.Memo == "[null]" ? null :  objvcc_CourseTeacherRelation4AppEN.Memo; //备注
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
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN)
{
try
{
if (objvcc_CourseTeacherRelation4AppEN.CourseCode == "[null]") objvcc_CourseTeacherRelation4AppEN.CourseCode = null; //课程代码
if (objvcc_CourseTeacherRelation4AppEN.CourseDescription == "[null]") objvcc_CourseTeacherRelation4AppEN.CourseDescription = null; //课程描述
if (objvcc_CourseTeacherRelation4AppEN.CourseName == "[null]") objvcc_CourseTeacherRelation4AppEN.CourseName = null; //课程名称
if (objvcc_CourseTeacherRelation4AppEN.CourseTypeID == "[null]") objvcc_CourseTeacherRelation4AppEN.CourseTypeID = null; //课程类型ID
if (objvcc_CourseTeacherRelation4AppEN.CreateDate == "[null]") objvcc_CourseTeacherRelation4AppEN.CreateDate = null; //建立日期
if (objvcc_CourseTeacherRelation4AppEN.ExampleImgPath == "[null]") objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = null; //示例图路径
if (objvcc_CourseTeacherRelation4AppEN.IdXzMajor == "[null]") objvcc_CourseTeacherRelation4AppEN.IdXzMajor = null; //专业流水号
if (objvcc_CourseTeacherRelation4AppEN.IdXzCollege == "[null]") objvcc_CourseTeacherRelation4AppEN.IdXzCollege = null; //学院流水号
if (objvcc_CourseTeacherRelation4AppEN.TeacherID == "[null]") objvcc_CourseTeacherRelation4AppEN.TeacherID = null; //教师工号
if (objvcc_CourseTeacherRelation4AppEN.TeacherName == "[null]") objvcc_CourseTeacherRelation4AppEN.TeacherName = null; //教师姓名
if (objvcc_CourseTeacherRelation4AppEN.LastVisitedDate == "[null]") objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = null; //最后访问时间
if (objvcc_CourseTeacherRelation4AppEN.Memo == "[null]") objvcc_CourseTeacherRelation4AppEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN)
{
 vcc_CourseTeacherRelation4AppDA.CheckProperty4Condition(objvcc_CourseTeacherRelation4AppEN);
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
//if (arrvcc_CourseTeacherRelation4AppObjLstCache == null)
//{
//arrvcc_CourseTeacherRelation4AppObjLstCache = vcc_CourseTeacherRelation4AppDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngCourseTeacherRelationId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_CourseTeacherRelation4AppEN GetObjByCourseTeacherRelationIdCache(long lngCourseTeacherRelationId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseTeacherRelation4AppEN._CurrTabName, strCourseId);
List<clsvcc_CourseTeacherRelation4AppEN> arrvcc_CourseTeacherRelation4AppObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseTeacherRelation4AppEN> arrvcc_CourseTeacherRelation4AppObjLst_Sel =
arrvcc_CourseTeacherRelation4AppObjLstCache
.Where(x=> x.CourseTeacherRelationId == lngCourseTeacherRelationId 
);
if (arrvcc_CourseTeacherRelation4AppObjLst_Sel.Count() == 0)
{
   clsvcc_CourseTeacherRelation4AppEN obj = clsvcc_CourseTeacherRelation4AppBL.GetObjByCourseTeacherRelationId(lngCourseTeacherRelationId);
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
return arrvcc_CourseTeacherRelation4AppObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseTeacherRelation4AppEN> GetAllvcc_CourseTeacherRelation4AppObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvcc_CourseTeacherRelation4AppEN> arrvcc_CourseTeacherRelation4AppObjLstCache = GetObjLstCache(strCourseId); 
return arrvcc_CourseTeacherRelation4AppObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_CourseTeacherRelation4AppEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseTeacherRelation4AppEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvcc_CourseTeacherRelation4AppEN> arrvcc_CourseTeacherRelation4AppObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvcc_CourseTeacherRelation4AppObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvcc_CourseTeacherRelation4AppEN._CurrTabName, strCourseId);
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
if (strInFldName != convcc_CourseTeacherRelation4App.CourseTeacherRelationId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_CourseTeacherRelation4App.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_CourseTeacherRelation4App.AttributeName));
throw new Exception(strMsg);
}
var objvcc_CourseTeacherRelation4App = clsvcc_CourseTeacherRelation4AppBL.GetObjByCourseTeacherRelationIdCache(lngCourseTeacherRelationId, strCourseId);
if (objvcc_CourseTeacherRelation4App == null) return "";
return objvcc_CourseTeacherRelation4App[strOutFldName].ToString();
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
int intRecCount = clsvcc_CourseTeacherRelation4AppDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_CourseTeacherRelation4AppDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_CourseTeacherRelation4AppDA.GetRecCount();
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
int intRecCount = clsvcc_CourseTeacherRelation4AppDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppCond)
{
 string strCourseId = objvcc_CourseTeacherRelation4AppCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvcc_CourseTeacherRelation4AppBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvcc_CourseTeacherRelation4AppEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvcc_CourseTeacherRelation4AppEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_CourseTeacherRelation4App.AttributeName)
{
if (objvcc_CourseTeacherRelation4AppCond.IsUpdated(strFldName) == false) continue;
if (objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseTeacherRelation4AppCond[strFldName].ToString());
}
else
{
if (objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_CourseTeacherRelation4AppCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_CourseTeacherRelation4AppCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_CourseTeacherRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_CourseTeacherRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_CourseTeacherRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_CourseTeacherRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_CourseTeacherRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_CourseTeacherRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_CourseTeacherRelation4AppCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_CourseTeacherRelation4AppCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_CourseTeacherRelation4AppCond[strFldName]));
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
 List<string> arrList = clsvcc_CourseTeacherRelation4AppDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseTeacherRelation4AppDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_CourseTeacherRelation4AppDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}