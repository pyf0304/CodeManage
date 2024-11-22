
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_ExamPaperStuRelation4AppBL
 表名:vcc_ExamPaperStuRelation4App(01120255)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clsvcc_ExamPaperStuRelation4AppBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdExamPaperStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExamPaperStuRelation4AppEN GetObj(this K_IdExamPaperStuRelation_vcc_ExamPaperStuRelation4App myKey)
{
clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN = clsvcc_ExamPaperStuRelation4AppBL.vcc_ExamPaperStuRelation4AppDA.GetObjByIdExamPaperStuRelation(myKey.Value);
return objvcc_ExamPaperStuRelation4AppEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetIdExamPaperStuRelation(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, long lngIdExamPaperStuRelation, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation = lngIdExamPaperStuRelation; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.IdExamPaperStuRelation) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.IdExamPaperStuRelation, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IdExamPaperStuRelation] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetCourseExamPaperId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strCourseExamPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_ExamPaperStuRelation4App.CourseExamPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_ExamPaperStuRelation4App.CourseExamPaperId);
}
objvcc_ExamPaperStuRelation4AppEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.CourseExamPaperId) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.CourseExamPaperId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.CourseExamPaperId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetIdExamPaperEduClsRela(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, long? lngIdExamPaperEduClsRela, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperEduClsRela = lngIdExamPaperEduClsRela; //作业教学班关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetCourseId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_ExamPaperStuRelation4App.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_ExamPaperStuRelation4App.CourseId);
}
objvcc_ExamPaperStuRelation4AppEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.CourseId) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.CourseId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.CourseId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetCourseName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_ExamPaperStuRelation4App.CourseName);
}
objvcc_ExamPaperStuRelation4AppEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.CourseName) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.CourseName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.CourseName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetExamPaperName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strExamPaperName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_ExamPaperStuRelation4App.ExamPaperName);
}
objvcc_ExamPaperStuRelation4AppEN.ExamPaperName = strExamPaperName; //考卷名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.ExamPaperName) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.ExamPaperName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ExamPaperName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetPaperIndex(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, int? intPaperIndex, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.PaperIndex = intPaperIndex; //试卷序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.PaperIndex) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.PaperIndex, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.PaperIndex] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetExamPaperTypeId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strExamPaperTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, convcc_ExamPaperStuRelation4App.ExamPaperTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, convcc_ExamPaperStuRelation4App.ExamPaperTypeId);
}
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeId = strExamPaperTypeId; //试卷类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.ExamPaperTypeId) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.ExamPaperTypeId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ExamPaperTypeId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetExamPaperTypeName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strExamPaperTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPaperTypeName, 30, convcc_ExamPaperStuRelation4App.ExamPaperTypeName);
}
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeName = strExamPaperTypeName; //试卷类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.ExamPaperTypeName) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.ExamPaperTypeName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ExamPaperTypeName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetExamCreateTime(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strExamCreateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamCreateTime, 14, convcc_ExamPaperStuRelation4App.ExamCreateTime);
}
objvcc_ExamPaperStuRelation4AppEN.ExamCreateTime = strExamCreateTime; //考卷建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.ExamCreateTime) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.ExamCreateTime, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ExamCreateTime] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetChapterId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_ExamPaperStuRelation4App.ChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_ExamPaperStuRelation4App.ChapterId);
}
objvcc_ExamPaperStuRelation4AppEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.ChapterId) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.ChapterId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ChapterId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetSectionId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_ExamPaperStuRelation4App.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_ExamPaperStuRelation4App.SectionId);
}
objvcc_ExamPaperStuRelation4AppEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.SectionId) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.SectionId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.SectionId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetChapterName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_ExamPaperStuRelation4App.ChapterName);
}
objvcc_ExamPaperStuRelation4AppEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.ChapterName) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.ChapterName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ChapterName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetSectionName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_ExamPaperStuRelation4App.SectionName);
}
objvcc_ExamPaperStuRelation4AppEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.SectionName) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.SectionName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.SectionName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetChapterNameSim(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convcc_ExamPaperStuRelation4App.ChapterNameSim);
}
objvcc_ExamPaperStuRelation4AppEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.ChapterNameSim) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.ChapterNameSim, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ChapterNameSim] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetSectionNameSim(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convcc_ExamPaperStuRelation4App.SectionNameSim);
}
objvcc_ExamPaperStuRelation4AppEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.SectionNameSim) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.SectionNameSim, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.SectionNameSim] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetIsAutoGeneQuestion(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, bool bolIsAutoGeneQuestion, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.IsAutoGeneQuestion = bolIsAutoGeneQuestion; //是否自动生成题目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetIsCanMultiDo(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, bool bolIsCanMultiDo, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.IsCanMultiDo = bolIsCanMultiDo; //是否可以做多次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.IsCanMultiDo) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.IsCanMultiDo, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IsCanMultiDo] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetEduClsName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strEduClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_ExamPaperStuRelation4App.EduClsName);
}
objvcc_ExamPaperStuRelation4AppEN.EduClsName = strEduClsName; //教学班名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.EduClsName) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.EduClsName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.EduClsName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetTeacherID(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strTeacherID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherID, 12, convcc_ExamPaperStuRelation4App.TeacherID);
}
objvcc_ExamPaperStuRelation4AppEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.TeacherID) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.TeacherID, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.TeacherID] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetPubDate(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strPubDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubDate, 14, convcc_ExamPaperStuRelation4App.PubDate);
}
objvcc_ExamPaperStuRelation4AppEN.PubDate = strPubDate; //发布日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.PubDate) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.PubDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.PubDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetIsCurrEduCls(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, bool bolIsCurrEduCls, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.IsCurrEduCls = bolIsCurrEduCls; //是否为教学班作业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.IsCurrEduCls) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.IsCurrEduCls, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IsCurrEduCls] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetWorkTypeName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strWorkTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkTypeName, 30, convcc_ExamPaperStuRelation4App.WorkTypeName);
}
objvcc_ExamPaperStuRelation4AppEN.WorkTypeName = strWorkTypeName; //作业类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.WorkTypeName) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.WorkTypeName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.WorkTypeName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetIdCurrEduCls(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, convcc_ExamPaperStuRelation4App.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convcc_ExamPaperStuRelation4App.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convcc_ExamPaperStuRelation4App.IdCurrEduCls);
}
objvcc_ExamPaperStuRelation4AppEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.IdCurrEduCls) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.IdCurrEduCls, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IdCurrEduCls] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetScores(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, double? dblScores, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.Scores) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.Scores, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.Scores] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetSpecifyCompletionDate(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strSpecifyCompletionDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSpecifyCompletionDate, convcc_ExamPaperStuRelation4App.SpecifyCompletionDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSpecifyCompletionDate, 14, convcc_ExamPaperStuRelation4App.SpecifyCompletionDate);
}
objvcc_ExamPaperStuRelation4AppEN.SpecifyCompletionDate = strSpecifyCompletionDate; //指定完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.SpecifyCompletionDate) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.SpecifyCompletionDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.SpecifyCompletionDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetIdStudentInfo(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strIdStudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudentInfo, convcc_ExamPaperStuRelation4App.IdStudentInfo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, convcc_ExamPaperStuRelation4App.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, convcc_ExamPaperStuRelation4App.IdStudentInfo);
}
objvcc_ExamPaperStuRelation4AppEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.IdStudentInfo) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.IdStudentInfo, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IdStudentInfo] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetStuID(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strStuID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_ExamPaperStuRelation4App.StuID);
}
objvcc_ExamPaperStuRelation4AppEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.StuID) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.StuID, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.StuID] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetStuName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strStuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_ExamPaperStuRelation4App.StuName);
}
objvcc_ExamPaperStuRelation4AppEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.StuName) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.StuName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.StuName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetIdXzCollege(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convcc_ExamPaperStuRelation4App.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convcc_ExamPaperStuRelation4App.IdXzCollege);
}
objvcc_ExamPaperStuRelation4AppEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.IdXzCollege) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.IdXzCollege, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IdXzCollege] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetCollegeName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_ExamPaperStuRelation4App.CollegeName);
}
objvcc_ExamPaperStuRelation4AppEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.CollegeName) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.CollegeName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.CollegeName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetCollegeNameA(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_ExamPaperStuRelation4App.CollegeNameA);
}
objvcc_ExamPaperStuRelation4AppEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.CollegeNameA) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.CollegeNameA, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.CollegeNameA] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetIdXzMajor(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convcc_ExamPaperStuRelation4App.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convcc_ExamPaperStuRelation4App.IdXzMajor);
}
objvcc_ExamPaperStuRelation4AppEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.IdXzMajor) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.IdXzMajor, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IdXzMajor] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetMajorName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_ExamPaperStuRelation4App.MajorName);
}
objvcc_ExamPaperStuRelation4AppEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.MajorName) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.MajorName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.MajorName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetGradeBaseName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convcc_ExamPaperStuRelation4App.GradeBaseName);
}
objvcc_ExamPaperStuRelation4AppEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.GradeBaseName) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.GradeBaseName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.GradeBaseName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetAnswerOptionId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strAnswerOptionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, convcc_ExamPaperStuRelation4App.AnswerOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, convcc_ExamPaperStuRelation4App.AnswerOptionId);
}
objvcc_ExamPaperStuRelation4AppEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.AnswerOptionId) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.AnswerOptionId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.AnswerOptionId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetAnswerMultiOptions(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strAnswerMultiOptions, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerMultiOptions, 300, convcc_ExamPaperStuRelation4App.AnswerMultiOptions);
}
objvcc_ExamPaperStuRelation4AppEN.AnswerMultiOptions = strAnswerMultiOptions; //多选项答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.AnswerMultiOptions) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.AnswerMultiOptions, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.AnswerMultiOptions] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetStuAnswerText(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strStuAnswerText, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.StuAnswerText = strStuAnswerText; //学生回答文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.StuAnswerText) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.StuAnswerText, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.StuAnswerText] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetIsPublish(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, bool bolIsPublish, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.IsPublish) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.IsPublish, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IsPublish] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetIsSave(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, bool bolIsSave, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.IsSave = bolIsSave; //是否保存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.IsSave) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.IsSave, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IsSave] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetIsSubmit(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.IsSubmit) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.IsSubmit, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IsSubmit] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetRealFinishDate(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strRealFinishDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, convcc_ExamPaperStuRelation4App.RealFinishDate);
}
objvcc_ExamPaperStuRelation4AppEN.RealFinishDate = strRealFinishDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.RealFinishDate) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.RealFinishDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.RealFinishDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetScore(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, double? dblScore, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.Score) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.Score, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.Score] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetComment(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strComment, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.Comment = strComment; //批注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.Comment) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.Comment, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.Comment] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetIsMarking(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, bool bolIsMarking, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.IsMarking) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.IsMarking, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IsMarking] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetMarkerId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strMarkerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkerId, 20, convcc_ExamPaperStuRelation4App.MarkerId);
}
objvcc_ExamPaperStuRelation4AppEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.MarkerId) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.MarkerId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.MarkerId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetMarkDate(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strMarkDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkDate, 14, convcc_ExamPaperStuRelation4App.MarkDate);
}
objvcc_ExamPaperStuRelation4AppEN.MarkDate = strMarkDate; //打分日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.MarkDate) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.MarkDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.MarkDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetIsSendBack(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, bool bolIsSendBack, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.IsSendBack = bolIsSendBack; //是否退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.IsSendBack) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.IsSendBack, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IsSendBack] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetIsInErrorQuestion(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, bool bolIsInErrorQuestion, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.IsInErrorQuestion = bolIsInErrorQuestion; //是否进入错题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.IsInErrorQuestion) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.IsInErrorQuestion, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IsInErrorQuestion] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetWorkTypeId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strWorkTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, convcc_ExamPaperStuRelation4App.WorkTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, convcc_ExamPaperStuRelation4App.WorkTypeId);
}
objvcc_ExamPaperStuRelation4AppEN.WorkTypeId = strWorkTypeId; //作业类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.WorkTypeId) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.WorkTypeId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.WorkTypeId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetAnswerIP(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strAnswerIP, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, convcc_ExamPaperStuRelation4App.AnswerIP);
}
objvcc_ExamPaperStuRelation4AppEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.AnswerIP) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.AnswerIP, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.AnswerIP] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetAnswerDate(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strAnswerDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, convcc_ExamPaperStuRelation4App.AnswerDate);
}
objvcc_ExamPaperStuRelation4AppEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.AnswerDate) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.AnswerDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.AnswerDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetAnswerTime(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strAnswerTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, convcc_ExamPaperStuRelation4App.AnswerTime);
}
objvcc_ExamPaperStuRelation4AppEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.AnswerTime) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.AnswerTime, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.AnswerTime] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetIsRight(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, bool bolIsRight, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.IsRight) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.IsRight, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IsRight] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetIsNotProcessTimeout(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, bool bolIsNotProcessTimeout, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.IsNotProcessTimeout = bolIsNotProcessTimeout; //是否不处理超时
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.IsNotProcessTimeout) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.IsNotProcessTimeout, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IsNotProcessTimeout] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetUpdDate(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_ExamPaperStuRelation4App.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_ExamPaperStuRelation4App.UpdDate);
}
objvcc_ExamPaperStuRelation4AppEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.UpdDate) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.UpdDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.UpdDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetUpdUserId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_ExamPaperStuRelation4App.UpdUserId);
}
objvcc_ExamPaperStuRelation4AppEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.UpdUserId) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.UpdUserId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.UpdUserId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetMemo(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_ExamPaperStuRelation4App.Memo);
}
objvcc_ExamPaperStuRelation4AppEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.Memo) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.Memo, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.Memo] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetNoSubmitBatchNum(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, int? intNoSubmitBatchNum, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.NoSubmitBatchNum = intNoSubmitBatchNum; //未提交批次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.NoSubmitBatchNum) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.NoSubmitBatchNum, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetSubmitBatchNum(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, int? intSubmitBatchNum, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.SubmitBatchNum = intSubmitBatchNum; //提交批次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.SubmitBatchNum) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.SubmitBatchNum, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.SubmitBatchNum] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppENS">源对象</param>
 /// <param name = "objvcc_ExamPaperStuRelation4AppENT">目标对象</param>
 public static void CopyTo(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppENS, clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppENT)
{
try
{
objvcc_ExamPaperStuRelation4AppENT.IdExamPaperStuRelation = objvcc_ExamPaperStuRelation4AppENS.IdExamPaperStuRelation; //流水号
objvcc_ExamPaperStuRelation4AppENT.CourseExamPaperId = objvcc_ExamPaperStuRelation4AppENS.CourseExamPaperId; //考卷流水号
objvcc_ExamPaperStuRelation4AppENT.IdExamPaperEduClsRela = objvcc_ExamPaperStuRelation4AppENS.IdExamPaperEduClsRela; //作业教学班关系流水号
objvcc_ExamPaperStuRelation4AppENT.CourseId = objvcc_ExamPaperStuRelation4AppENS.CourseId; //课程Id
objvcc_ExamPaperStuRelation4AppENT.CourseName = objvcc_ExamPaperStuRelation4AppENS.CourseName; //课程名称
objvcc_ExamPaperStuRelation4AppENT.ExamPaperName = objvcc_ExamPaperStuRelation4AppENS.ExamPaperName; //考卷名称
objvcc_ExamPaperStuRelation4AppENT.PaperIndex = objvcc_ExamPaperStuRelation4AppENS.PaperIndex; //试卷序号
objvcc_ExamPaperStuRelation4AppENT.ExamPaperTypeId = objvcc_ExamPaperStuRelation4AppENS.ExamPaperTypeId; //试卷类型Id
objvcc_ExamPaperStuRelation4AppENT.ExamPaperTypeName = objvcc_ExamPaperStuRelation4AppENS.ExamPaperTypeName; //试卷类型名称
objvcc_ExamPaperStuRelation4AppENT.ExamCreateTime = objvcc_ExamPaperStuRelation4AppENS.ExamCreateTime; //考卷建立时间
objvcc_ExamPaperStuRelation4AppENT.ChapterId = objvcc_ExamPaperStuRelation4AppENS.ChapterId; //章Id
objvcc_ExamPaperStuRelation4AppENT.SectionId = objvcc_ExamPaperStuRelation4AppENS.SectionId; //节Id
objvcc_ExamPaperStuRelation4AppENT.ChapterName = objvcc_ExamPaperStuRelation4AppENS.ChapterName; //章名
objvcc_ExamPaperStuRelation4AppENT.SectionName = objvcc_ExamPaperStuRelation4AppENS.SectionName; //节名
objvcc_ExamPaperStuRelation4AppENT.ChapterNameSim = objvcc_ExamPaperStuRelation4AppENS.ChapterNameSim; //章名简称
objvcc_ExamPaperStuRelation4AppENT.SectionNameSim = objvcc_ExamPaperStuRelation4AppENS.SectionNameSim; //节名简称
objvcc_ExamPaperStuRelation4AppENT.IsAutoGeneQuestion = objvcc_ExamPaperStuRelation4AppENS.IsAutoGeneQuestion; //是否自动生成题目
objvcc_ExamPaperStuRelation4AppENT.IsCanMultiDo = objvcc_ExamPaperStuRelation4AppENS.IsCanMultiDo; //是否可以做多次
objvcc_ExamPaperStuRelation4AppENT.EduClsName = objvcc_ExamPaperStuRelation4AppENS.EduClsName; //教学班名
objvcc_ExamPaperStuRelation4AppENT.TeacherID = objvcc_ExamPaperStuRelation4AppENS.TeacherID; //教师工号
objvcc_ExamPaperStuRelation4AppENT.PubDate = objvcc_ExamPaperStuRelation4AppENS.PubDate; //发布日期
objvcc_ExamPaperStuRelation4AppENT.IsCurrEduCls = objvcc_ExamPaperStuRelation4AppENS.IsCurrEduCls; //是否为教学班作业
objvcc_ExamPaperStuRelation4AppENT.WorkTypeName = objvcc_ExamPaperStuRelation4AppENS.WorkTypeName; //作业类型名称
objvcc_ExamPaperStuRelation4AppENT.IdCurrEduCls = objvcc_ExamPaperStuRelation4AppENS.IdCurrEduCls; //教学班流水号
objvcc_ExamPaperStuRelation4AppENT.Scores = objvcc_ExamPaperStuRelation4AppENS.Scores; //分值
objvcc_ExamPaperStuRelation4AppENT.SpecifyCompletionDate = objvcc_ExamPaperStuRelation4AppENS.SpecifyCompletionDate; //指定完成日期
objvcc_ExamPaperStuRelation4AppENT.IdStudentInfo = objvcc_ExamPaperStuRelation4AppENS.IdStudentInfo; //学生流水号
objvcc_ExamPaperStuRelation4AppENT.StuID = objvcc_ExamPaperStuRelation4AppENS.StuID; //学号
objvcc_ExamPaperStuRelation4AppENT.StuName = objvcc_ExamPaperStuRelation4AppENS.StuName; //姓名
objvcc_ExamPaperStuRelation4AppENT.IdXzCollege = objvcc_ExamPaperStuRelation4AppENS.IdXzCollege; //学院流水号
objvcc_ExamPaperStuRelation4AppENT.CollegeName = objvcc_ExamPaperStuRelation4AppENS.CollegeName; //学院名称
objvcc_ExamPaperStuRelation4AppENT.CollegeNameA = objvcc_ExamPaperStuRelation4AppENS.CollegeNameA; //学院名称简写
objvcc_ExamPaperStuRelation4AppENT.IdXzMajor = objvcc_ExamPaperStuRelation4AppENS.IdXzMajor; //专业流水号
objvcc_ExamPaperStuRelation4AppENT.MajorName = objvcc_ExamPaperStuRelation4AppENS.MajorName; //专业名称
objvcc_ExamPaperStuRelation4AppENT.GradeBaseName = objvcc_ExamPaperStuRelation4AppENS.GradeBaseName; //年级名称
objvcc_ExamPaperStuRelation4AppENT.AnswerOptionId = objvcc_ExamPaperStuRelation4AppENS.AnswerOptionId; //回答选项Id
objvcc_ExamPaperStuRelation4AppENT.AnswerMultiOptions = objvcc_ExamPaperStuRelation4AppENS.AnswerMultiOptions; //多选项答案
objvcc_ExamPaperStuRelation4AppENT.StuAnswerText = objvcc_ExamPaperStuRelation4AppENS.StuAnswerText; //学生回答文本
objvcc_ExamPaperStuRelation4AppENT.IsPublish = objvcc_ExamPaperStuRelation4AppENS.IsPublish; //是否发布
objvcc_ExamPaperStuRelation4AppENT.IsSave = objvcc_ExamPaperStuRelation4AppENS.IsSave; //是否保存
objvcc_ExamPaperStuRelation4AppENT.IsSubmit = objvcc_ExamPaperStuRelation4AppENS.IsSubmit; //是否提交
objvcc_ExamPaperStuRelation4AppENT.RealFinishDate = objvcc_ExamPaperStuRelation4AppENS.RealFinishDate; //实际完成日期
objvcc_ExamPaperStuRelation4AppENT.Score = objvcc_ExamPaperStuRelation4AppENS.Score; //得分
objvcc_ExamPaperStuRelation4AppENT.Comment = objvcc_ExamPaperStuRelation4AppENS.Comment; //批注
objvcc_ExamPaperStuRelation4AppENT.IsMarking = objvcc_ExamPaperStuRelation4AppENS.IsMarking; //是否批阅
objvcc_ExamPaperStuRelation4AppENT.MarkerId = objvcc_ExamPaperStuRelation4AppENS.MarkerId; //打分者
objvcc_ExamPaperStuRelation4AppENT.MarkDate = objvcc_ExamPaperStuRelation4AppENS.MarkDate; //打分日期
objvcc_ExamPaperStuRelation4AppENT.IsSendBack = objvcc_ExamPaperStuRelation4AppENS.IsSendBack; //是否退回
objvcc_ExamPaperStuRelation4AppENT.IsInErrorQuestion = objvcc_ExamPaperStuRelation4AppENS.IsInErrorQuestion; //是否进入错题
objvcc_ExamPaperStuRelation4AppENT.WorkTypeId = objvcc_ExamPaperStuRelation4AppENS.WorkTypeId; //作业类型Id
objvcc_ExamPaperStuRelation4AppENT.AnswerIP = objvcc_ExamPaperStuRelation4AppENS.AnswerIP; //回答IP
objvcc_ExamPaperStuRelation4AppENT.AnswerDate = objvcc_ExamPaperStuRelation4AppENS.AnswerDate; //回答日期
objvcc_ExamPaperStuRelation4AppENT.AnswerTime = objvcc_ExamPaperStuRelation4AppENS.AnswerTime; //回答时间
objvcc_ExamPaperStuRelation4AppENT.IsRight = objvcc_ExamPaperStuRelation4AppENS.IsRight; //是否正确
objvcc_ExamPaperStuRelation4AppENT.IsNotProcessTimeout = objvcc_ExamPaperStuRelation4AppENS.IsNotProcessTimeout; //是否不处理超时
objvcc_ExamPaperStuRelation4AppENT.UpdDate = objvcc_ExamPaperStuRelation4AppENS.UpdDate; //修改日期
objvcc_ExamPaperStuRelation4AppENT.UpdUserId = objvcc_ExamPaperStuRelation4AppENS.UpdUserId; //修改用户Id
objvcc_ExamPaperStuRelation4AppENT.Memo = objvcc_ExamPaperStuRelation4AppENS.Memo; //备注
objvcc_ExamPaperStuRelation4AppENT.NoSubmitBatchNum = objvcc_ExamPaperStuRelation4AppENS.NoSubmitBatchNum; //未提交批次数
objvcc_ExamPaperStuRelation4AppENT.SubmitBatchNum = objvcc_ExamPaperStuRelation4AppENS.SubmitBatchNum; //提交批次数
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
 /// <param name = "objvcc_ExamPaperStuRelation4AppENS">源对象</param>
 /// <returns>目标对象=>clsvcc_ExamPaperStuRelation4AppEN:objvcc_ExamPaperStuRelation4AppENT</returns>
 public static clsvcc_ExamPaperStuRelation4AppEN CopyTo(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppENS)
{
try
{
 clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppENT = new clsvcc_ExamPaperStuRelation4AppEN()
{
IdExamPaperStuRelation = objvcc_ExamPaperStuRelation4AppENS.IdExamPaperStuRelation, //流水号
CourseExamPaperId = objvcc_ExamPaperStuRelation4AppENS.CourseExamPaperId, //考卷流水号
IdExamPaperEduClsRela = objvcc_ExamPaperStuRelation4AppENS.IdExamPaperEduClsRela, //作业教学班关系流水号
CourseId = objvcc_ExamPaperStuRelation4AppENS.CourseId, //课程Id
CourseName = objvcc_ExamPaperStuRelation4AppENS.CourseName, //课程名称
ExamPaperName = objvcc_ExamPaperStuRelation4AppENS.ExamPaperName, //考卷名称
PaperIndex = objvcc_ExamPaperStuRelation4AppENS.PaperIndex, //试卷序号
ExamPaperTypeId = objvcc_ExamPaperStuRelation4AppENS.ExamPaperTypeId, //试卷类型Id
ExamPaperTypeName = objvcc_ExamPaperStuRelation4AppENS.ExamPaperTypeName, //试卷类型名称
ExamCreateTime = objvcc_ExamPaperStuRelation4AppENS.ExamCreateTime, //考卷建立时间
ChapterId = objvcc_ExamPaperStuRelation4AppENS.ChapterId, //章Id
SectionId = objvcc_ExamPaperStuRelation4AppENS.SectionId, //节Id
ChapterName = objvcc_ExamPaperStuRelation4AppENS.ChapterName, //章名
SectionName = objvcc_ExamPaperStuRelation4AppENS.SectionName, //节名
ChapterNameSim = objvcc_ExamPaperStuRelation4AppENS.ChapterNameSim, //章名简称
SectionNameSim = objvcc_ExamPaperStuRelation4AppENS.SectionNameSim, //节名简称
IsAutoGeneQuestion = objvcc_ExamPaperStuRelation4AppENS.IsAutoGeneQuestion, //是否自动生成题目
IsCanMultiDo = objvcc_ExamPaperStuRelation4AppENS.IsCanMultiDo, //是否可以做多次
EduClsName = objvcc_ExamPaperStuRelation4AppENS.EduClsName, //教学班名
TeacherID = objvcc_ExamPaperStuRelation4AppENS.TeacherID, //教师工号
PubDate = objvcc_ExamPaperStuRelation4AppENS.PubDate, //发布日期
IsCurrEduCls = objvcc_ExamPaperStuRelation4AppENS.IsCurrEduCls, //是否为教学班作业
WorkTypeName = objvcc_ExamPaperStuRelation4AppENS.WorkTypeName, //作业类型名称
IdCurrEduCls = objvcc_ExamPaperStuRelation4AppENS.IdCurrEduCls, //教学班流水号
Scores = objvcc_ExamPaperStuRelation4AppENS.Scores, //分值
SpecifyCompletionDate = objvcc_ExamPaperStuRelation4AppENS.SpecifyCompletionDate, //指定完成日期
IdStudentInfo = objvcc_ExamPaperStuRelation4AppENS.IdStudentInfo, //学生流水号
StuID = objvcc_ExamPaperStuRelation4AppENS.StuID, //学号
StuName = objvcc_ExamPaperStuRelation4AppENS.StuName, //姓名
IdXzCollege = objvcc_ExamPaperStuRelation4AppENS.IdXzCollege, //学院流水号
CollegeName = objvcc_ExamPaperStuRelation4AppENS.CollegeName, //学院名称
CollegeNameA = objvcc_ExamPaperStuRelation4AppENS.CollegeNameA, //学院名称简写
IdXzMajor = objvcc_ExamPaperStuRelation4AppENS.IdXzMajor, //专业流水号
MajorName = objvcc_ExamPaperStuRelation4AppENS.MajorName, //专业名称
GradeBaseName = objvcc_ExamPaperStuRelation4AppENS.GradeBaseName, //年级名称
AnswerOptionId = objvcc_ExamPaperStuRelation4AppENS.AnswerOptionId, //回答选项Id
AnswerMultiOptions = objvcc_ExamPaperStuRelation4AppENS.AnswerMultiOptions, //多选项答案
StuAnswerText = objvcc_ExamPaperStuRelation4AppENS.StuAnswerText, //学生回答文本
IsPublish = objvcc_ExamPaperStuRelation4AppENS.IsPublish, //是否发布
IsSave = objvcc_ExamPaperStuRelation4AppENS.IsSave, //是否保存
IsSubmit = objvcc_ExamPaperStuRelation4AppENS.IsSubmit, //是否提交
RealFinishDate = objvcc_ExamPaperStuRelation4AppENS.RealFinishDate, //实际完成日期
Score = objvcc_ExamPaperStuRelation4AppENS.Score, //得分
Comment = objvcc_ExamPaperStuRelation4AppENS.Comment, //批注
IsMarking = objvcc_ExamPaperStuRelation4AppENS.IsMarking, //是否批阅
MarkerId = objvcc_ExamPaperStuRelation4AppENS.MarkerId, //打分者
MarkDate = objvcc_ExamPaperStuRelation4AppENS.MarkDate, //打分日期
IsSendBack = objvcc_ExamPaperStuRelation4AppENS.IsSendBack, //是否退回
IsInErrorQuestion = objvcc_ExamPaperStuRelation4AppENS.IsInErrorQuestion, //是否进入错题
WorkTypeId = objvcc_ExamPaperStuRelation4AppENS.WorkTypeId, //作业类型Id
AnswerIP = objvcc_ExamPaperStuRelation4AppENS.AnswerIP, //回答IP
AnswerDate = objvcc_ExamPaperStuRelation4AppENS.AnswerDate, //回答日期
AnswerTime = objvcc_ExamPaperStuRelation4AppENS.AnswerTime, //回答时间
IsRight = objvcc_ExamPaperStuRelation4AppENS.IsRight, //是否正确
IsNotProcessTimeout = objvcc_ExamPaperStuRelation4AppENS.IsNotProcessTimeout, //是否不处理超时
UpdDate = objvcc_ExamPaperStuRelation4AppENS.UpdDate, //修改日期
UpdUserId = objvcc_ExamPaperStuRelation4AppENS.UpdUserId, //修改用户Id
Memo = objvcc_ExamPaperStuRelation4AppENS.Memo, //备注
NoSubmitBatchNum = objvcc_ExamPaperStuRelation4AppENS.NoSubmitBatchNum, //未提交批次数
SubmitBatchNum = objvcc_ExamPaperStuRelation4AppENS.SubmitBatchNum, //提交批次数
};
 return objvcc_ExamPaperStuRelation4AppENT;
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
public static void CheckProperty4Condition(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN)
{
 clsvcc_ExamPaperStuRelation4AppBL.vcc_ExamPaperStuRelation4AppDA.CheckProperty4Condition(objvcc_ExamPaperStuRelation4AppEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.IdExamPaperStuRelation) == true)
{
string strComparisonOpIdExamPaperStuRelation = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IdExamPaperStuRelation];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation4App.IdExamPaperStuRelation, objvcc_ExamPaperStuRelation4AppCond.IdExamPaperStuRelation, strComparisonOpIdExamPaperStuRelation);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.CourseExamPaperId) == true)
{
string strComparisonOpCourseExamPaperId = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.CourseExamPaperId, objvcc_ExamPaperStuRelation4AppCond.CourseExamPaperId, strComparisonOpCourseExamPaperId);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela) == true)
{
string strComparisonOpIdExamPaperEduClsRela = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela, objvcc_ExamPaperStuRelation4AppCond.IdExamPaperEduClsRela, strComparisonOpIdExamPaperEduClsRela);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.CourseId) == true)
{
string strComparisonOpCourseId = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.CourseId, objvcc_ExamPaperStuRelation4AppCond.CourseId, strComparisonOpCourseId);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.CourseName) == true)
{
string strComparisonOpCourseName = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.CourseName, objvcc_ExamPaperStuRelation4AppCond.CourseName, strComparisonOpCourseName);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.ExamPaperName) == true)
{
string strComparisonOpExamPaperName = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.ExamPaperName, objvcc_ExamPaperStuRelation4AppCond.ExamPaperName, strComparisonOpExamPaperName);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.PaperIndex) == true)
{
string strComparisonOpPaperIndex = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.PaperIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation4App.PaperIndex, objvcc_ExamPaperStuRelation4AppCond.PaperIndex, strComparisonOpPaperIndex);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.ExamPaperTypeId) == true)
{
string strComparisonOpExamPaperTypeId = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.ExamPaperTypeId, objvcc_ExamPaperStuRelation4AppCond.ExamPaperTypeId, strComparisonOpExamPaperTypeId);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.ExamPaperTypeName) == true)
{
string strComparisonOpExamPaperTypeName = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ExamPaperTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.ExamPaperTypeName, objvcc_ExamPaperStuRelation4AppCond.ExamPaperTypeName, strComparisonOpExamPaperTypeName);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.ExamCreateTime) == true)
{
string strComparisonOpExamCreateTime = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ExamCreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.ExamCreateTime, objvcc_ExamPaperStuRelation4AppCond.ExamCreateTime, strComparisonOpExamCreateTime);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.ChapterId) == true)
{
string strComparisonOpChapterId = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.ChapterId, objvcc_ExamPaperStuRelation4AppCond.ChapterId, strComparisonOpChapterId);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.SectionId) == true)
{
string strComparisonOpSectionId = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.SectionId, objvcc_ExamPaperStuRelation4AppCond.SectionId, strComparisonOpSectionId);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.ChapterName) == true)
{
string strComparisonOpChapterName = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.ChapterName, objvcc_ExamPaperStuRelation4AppCond.ChapterName, strComparisonOpChapterName);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.SectionName) == true)
{
string strComparisonOpSectionName = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.SectionName, objvcc_ExamPaperStuRelation4AppCond.SectionName, strComparisonOpSectionName);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.ChapterNameSim, objvcc_ExamPaperStuRelation4AppCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.SectionNameSim, objvcc_ExamPaperStuRelation4AppCond.SectionNameSim, strComparisonOpSectionNameSim);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion) == true)
{
if (objvcc_ExamPaperStuRelation4AppCond.IsAutoGeneQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion);
}
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.IsCanMultiDo) == true)
{
if (objvcc_ExamPaperStuRelation4AppCond.IsCanMultiDo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsCanMultiDo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsCanMultiDo);
}
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.EduClsName) == true)
{
string strComparisonOpEduClsName = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.EduClsName, objvcc_ExamPaperStuRelation4AppCond.EduClsName, strComparisonOpEduClsName);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.TeacherID) == true)
{
string strComparisonOpTeacherID = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.TeacherID, objvcc_ExamPaperStuRelation4AppCond.TeacherID, strComparisonOpTeacherID);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.PubDate) == true)
{
string strComparisonOpPubDate = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.PubDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.PubDate, objvcc_ExamPaperStuRelation4AppCond.PubDate, strComparisonOpPubDate);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.IsCurrEduCls) == true)
{
if (objvcc_ExamPaperStuRelation4AppCond.IsCurrEduCls == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsCurrEduCls);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsCurrEduCls);
}
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.WorkTypeName) == true)
{
string strComparisonOpWorkTypeName = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.WorkTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.WorkTypeName, objvcc_ExamPaperStuRelation4AppCond.WorkTypeName, strComparisonOpWorkTypeName);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.IdCurrEduCls, objvcc_ExamPaperStuRelation4AppCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.Scores) == true)
{
string strComparisonOpScores = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation4App.Scores, objvcc_ExamPaperStuRelation4AppCond.Scores, strComparisonOpScores);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.SpecifyCompletionDate) == true)
{
string strComparisonOpSpecifyCompletionDate = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.SpecifyCompletionDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.SpecifyCompletionDate, objvcc_ExamPaperStuRelation4AppCond.SpecifyCompletionDate, strComparisonOpSpecifyCompletionDate);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.IdStudentInfo, objvcc_ExamPaperStuRelation4AppCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.StuID) == true)
{
string strComparisonOpStuID = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.StuID, objvcc_ExamPaperStuRelation4AppCond.StuID, strComparisonOpStuID);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.StuName) == true)
{
string strComparisonOpStuName = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.StuName, objvcc_ExamPaperStuRelation4AppCond.StuName, strComparisonOpStuName);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.IdXzCollege, objvcc_ExamPaperStuRelation4AppCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.CollegeName) == true)
{
string strComparisonOpCollegeName = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.CollegeName, objvcc_ExamPaperStuRelation4AppCond.CollegeName, strComparisonOpCollegeName);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.CollegeNameA, objvcc_ExamPaperStuRelation4AppCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.IdXzMajor, objvcc_ExamPaperStuRelation4AppCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.MajorName) == true)
{
string strComparisonOpMajorName = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.MajorName, objvcc_ExamPaperStuRelation4AppCond.MajorName, strComparisonOpMajorName);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.GradeBaseName, objvcc_ExamPaperStuRelation4AppCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.AnswerOptionId) == true)
{
string strComparisonOpAnswerOptionId = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.AnswerOptionId, objvcc_ExamPaperStuRelation4AppCond.AnswerOptionId, strComparisonOpAnswerOptionId);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.AnswerMultiOptions) == true)
{
string strComparisonOpAnswerMultiOptions = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.AnswerMultiOptions];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.AnswerMultiOptions, objvcc_ExamPaperStuRelation4AppCond.AnswerMultiOptions, strComparisonOpAnswerMultiOptions);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.IsPublish) == true)
{
if (objvcc_ExamPaperStuRelation4AppCond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsPublish);
}
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.IsSave) == true)
{
if (objvcc_ExamPaperStuRelation4AppCond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsSave);
}
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.IsSubmit) == true)
{
if (objvcc_ExamPaperStuRelation4AppCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsSubmit);
}
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.RealFinishDate) == true)
{
string strComparisonOpRealFinishDate = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.RealFinishDate, objvcc_ExamPaperStuRelation4AppCond.RealFinishDate, strComparisonOpRealFinishDate);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.Score) == true)
{
string strComparisonOpScore = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation4App.Score, objvcc_ExamPaperStuRelation4AppCond.Score, strComparisonOpScore);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.IsMarking) == true)
{
if (objvcc_ExamPaperStuRelation4AppCond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsMarking);
}
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.MarkerId) == true)
{
string strComparisonOpMarkerId = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.MarkerId, objvcc_ExamPaperStuRelation4AppCond.MarkerId, strComparisonOpMarkerId);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.MarkDate) == true)
{
string strComparisonOpMarkDate = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.MarkDate, objvcc_ExamPaperStuRelation4AppCond.MarkDate, strComparisonOpMarkDate);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.IsSendBack) == true)
{
if (objvcc_ExamPaperStuRelation4AppCond.IsSendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsSendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsSendBack);
}
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.IsInErrorQuestion) == true)
{
if (objvcc_ExamPaperStuRelation4AppCond.IsInErrorQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsInErrorQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsInErrorQuestion);
}
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.WorkTypeId) == true)
{
string strComparisonOpWorkTypeId = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.WorkTypeId, objvcc_ExamPaperStuRelation4AppCond.WorkTypeId, strComparisonOpWorkTypeId);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.AnswerIP) == true)
{
string strComparisonOpAnswerIP = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.AnswerIP, objvcc_ExamPaperStuRelation4AppCond.AnswerIP, strComparisonOpAnswerIP);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.AnswerDate) == true)
{
string strComparisonOpAnswerDate = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.AnswerDate, objvcc_ExamPaperStuRelation4AppCond.AnswerDate, strComparisonOpAnswerDate);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.AnswerTime) == true)
{
string strComparisonOpAnswerTime = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.AnswerTime, objvcc_ExamPaperStuRelation4AppCond.AnswerTime, strComparisonOpAnswerTime);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.IsRight) == true)
{
if (objvcc_ExamPaperStuRelation4AppCond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsRight);
}
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.IsNotProcessTimeout) == true)
{
if (objvcc_ExamPaperStuRelation4AppCond.IsNotProcessTimeout == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsNotProcessTimeout);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsNotProcessTimeout);
}
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.UpdDate, objvcc_ExamPaperStuRelation4AppCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.UpdUserId, objvcc_ExamPaperStuRelation4AppCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.Memo) == true)
{
string strComparisonOpMemo = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.Memo, objvcc_ExamPaperStuRelation4AppCond.Memo, strComparisonOpMemo);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.NoSubmitBatchNum) == true)
{
string strComparisonOpNoSubmitBatchNum = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation4App.NoSubmitBatchNum, objvcc_ExamPaperStuRelation4AppCond.NoSubmitBatchNum, strComparisonOpNoSubmitBatchNum);
}
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(convcc_ExamPaperStuRelation4App.SubmitBatchNum) == true)
{
string strComparisonOpSubmitBatchNum = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.SubmitBatchNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation4App.SubmitBatchNum, objvcc_ExamPaperStuRelation4AppCond.SubmitBatchNum, strComparisonOpSubmitBatchNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_ExamPaperStuRelation4App
{
public virtual bool UpdRelaTabDate(long lngIdExamPaperStuRelation, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v考卷与学生关系表4App(vcc_ExamPaperStuRelation4App)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_ExamPaperStuRelation4AppBL
{
public static RelatedActions_vcc_ExamPaperStuRelation4App relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_ExamPaperStuRelation4AppDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_ExamPaperStuRelation4AppDA vcc_ExamPaperStuRelation4AppDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_ExamPaperStuRelation4AppDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_ExamPaperStuRelation4AppBL()
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
if (string.IsNullOrEmpty(clsvcc_ExamPaperStuRelation4AppEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_ExamPaperStuRelation4AppEN._ConnectString);
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
public static DataTable GetDataTable_vcc_ExamPaperStuRelation4App(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_ExamPaperStuRelation4AppDA.GetDataTable_vcc_ExamPaperStuRelation4App(strWhereCond);
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
objDT = vcc_ExamPaperStuRelation4AppDA.GetDataTable(strWhereCond);
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
objDT = vcc_ExamPaperStuRelation4AppDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_ExamPaperStuRelation4AppDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_ExamPaperStuRelation4AppDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_ExamPaperStuRelation4AppDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_ExamPaperStuRelation4AppDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_ExamPaperStuRelation4AppDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_ExamPaperStuRelation4AppDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdExamPaperStuRelationLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetObjLstByIdExamPaperStuRelationLst(List<long> arrIdExamPaperStuRelationLst)
{
List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = new List<clsvcc_ExamPaperStuRelation4AppEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdExamPaperStuRelationLst);
 string strWhereCond = string.Format("IdExamPaperStuRelation in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN = new clsvcc_ExamPaperStuRelation4AppEN();
try
{
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation = Int32.Parse(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperStuRelation].ToString().Trim()); //流水号
objvcc_ExamPaperStuRelation4AppEN.CourseExamPaperId = objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperEduClsRela = objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_ExamPaperStuRelation4AppEN.CourseId = objRow[convcc_ExamPaperStuRelation4App.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuRelation4AppEN.CourseName = objRow[convcc_ExamPaperStuRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuRelation4AppEN.ExamPaperName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuRelation4AppEN.PaperIndex = objRow[convcc_ExamPaperStuRelation4App.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuRelation4AppEN.ExamCreateTime = objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuRelation4AppEN.ChapterId = objRow[convcc_ExamPaperStuRelation4App.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuRelation4AppEN.SectionId = objRow[convcc_ExamPaperStuRelation4App.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuRelation4AppEN.ChapterName = objRow[convcc_ExamPaperStuRelation4App.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuRelation4AppEN.SectionName = objRow[convcc_ExamPaperStuRelation4App.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuRelation4AppEN.ChapterNameSim = objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuRelation4AppEN.SectionNameSim = objRow[convcc_ExamPaperStuRelation4App.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuRelation4AppEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuRelation4AppEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuRelation4AppEN.EduClsName = objRow[convcc_ExamPaperStuRelation4App.EduClsName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuRelation4AppEN.TeacherID = objRow[convcc_ExamPaperStuRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_ExamPaperStuRelation4AppEN.PubDate = objRow[convcc_ExamPaperStuRelation4App.PubDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.PubDate].ToString().Trim(); //发布日期
objvcc_ExamPaperStuRelation4AppEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_ExamPaperStuRelation4AppEN.WorkTypeName = objRow[convcc_ExamPaperStuRelation4App.WorkTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_ExamPaperStuRelation4AppEN.IdCurrEduCls = objRow[convcc_ExamPaperStuRelation4App.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuRelation4AppEN.Scores = objRow[convcc_ExamPaperStuRelation4App.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuRelation4AppEN.SpecifyCompletionDate = objRow[convcc_ExamPaperStuRelation4App.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_ExamPaperStuRelation4AppEN.IdStudentInfo = objRow[convcc_ExamPaperStuRelation4App.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuRelation4AppEN.StuID = objRow[convcc_ExamPaperStuRelation4App.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuRelation4AppEN.StuName = objRow[convcc_ExamPaperStuRelation4App.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuRelation4AppEN.IdXzCollege = objRow[convcc_ExamPaperStuRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuRelation4AppEN.CollegeName = objRow[convcc_ExamPaperStuRelation4App.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuRelation4AppEN.CollegeNameA = objRow[convcc_ExamPaperStuRelation4App.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuRelation4AppEN.IdXzMajor = objRow[convcc_ExamPaperStuRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuRelation4AppEN.MajorName = objRow[convcc_ExamPaperStuRelation4App.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuRelation4AppEN.GradeBaseName = objRow[convcc_ExamPaperStuRelation4App.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuRelation4AppEN.AnswerOptionId = objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_ExamPaperStuRelation4AppEN.AnswerMultiOptions = objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_ExamPaperStuRelation4AppEN.StuAnswerText = objRow[convcc_ExamPaperStuRelation4App.StuAnswerText] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_ExamPaperStuRelation4AppEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsPublish].ToString().Trim()); //是否发布
objvcc_ExamPaperStuRelation4AppEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuRelation4AppEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuRelation4AppEN.RealFinishDate = objRow[convcc_ExamPaperStuRelation4App.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuRelation4AppEN.Score = objRow[convcc_ExamPaperStuRelation4App.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Score].ToString().Trim()); //得分
objvcc_ExamPaperStuRelation4AppEN.Comment = objRow[convcc_ExamPaperStuRelation4App.Comment] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Comment].ToString().Trim(); //批注
objvcc_ExamPaperStuRelation4AppEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuRelation4AppEN.MarkerId = objRow[convcc_ExamPaperStuRelation4App.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuRelation4AppEN.MarkDate = objRow[convcc_ExamPaperStuRelation4App.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuRelation4AppEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSendBack].ToString().Trim()); //是否退回
objvcc_ExamPaperStuRelation4AppEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_ExamPaperStuRelation4AppEN.WorkTypeId = objRow[convcc_ExamPaperStuRelation4App.WorkTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_ExamPaperStuRelation4AppEN.AnswerIP = objRow[convcc_ExamPaperStuRelation4App.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuRelation4AppEN.AnswerDate = objRow[convcc_ExamPaperStuRelation4App.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuRelation4AppEN.AnswerTime = objRow[convcc_ExamPaperStuRelation4App.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuRelation4AppEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsRight].ToString().Trim()); //是否正确
objvcc_ExamPaperStuRelation4AppEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_ExamPaperStuRelation4AppEN.UpdDate = objRow[convcc_ExamPaperStuRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuRelation4AppEN.UpdUserId = objRow[convcc_ExamPaperStuRelation4App.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuRelation4AppEN.Memo = objRow[convcc_ExamPaperStuRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuRelation4AppEN.NoSubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum].ToString().Trim()); //未提交批次数
objvcc_ExamPaperStuRelation4AppEN.SubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum].ToString().Trim()); //提交批次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuRelation4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdExamPaperStuRelationLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_ExamPaperStuRelation4AppEN> GetObjLstByIdExamPaperStuRelationLstCache(List<long> arrIdExamPaperStuRelationLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuRelation4AppEN._CurrTabName, strIdCurrEduCls);
List<clsvcc_ExamPaperStuRelation4AppEN> arrvcc_ExamPaperStuRelation4AppObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvcc_ExamPaperStuRelation4AppEN> arrvcc_ExamPaperStuRelation4AppObjLst_Sel =
arrvcc_ExamPaperStuRelation4AppObjLstCache
.Where(x => arrIdExamPaperStuRelationLst.Contains(x.IdExamPaperStuRelation));
return arrvcc_ExamPaperStuRelation4AppObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetObjLst(string strWhereCond)
{
List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = new List<clsvcc_ExamPaperStuRelation4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN = new clsvcc_ExamPaperStuRelation4AppEN();
try
{
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation = Int32.Parse(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperStuRelation].ToString().Trim()); //流水号
objvcc_ExamPaperStuRelation4AppEN.CourseExamPaperId = objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperEduClsRela = objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_ExamPaperStuRelation4AppEN.CourseId = objRow[convcc_ExamPaperStuRelation4App.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuRelation4AppEN.CourseName = objRow[convcc_ExamPaperStuRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuRelation4AppEN.ExamPaperName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuRelation4AppEN.PaperIndex = objRow[convcc_ExamPaperStuRelation4App.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuRelation4AppEN.ExamCreateTime = objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuRelation4AppEN.ChapterId = objRow[convcc_ExamPaperStuRelation4App.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuRelation4AppEN.SectionId = objRow[convcc_ExamPaperStuRelation4App.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuRelation4AppEN.ChapterName = objRow[convcc_ExamPaperStuRelation4App.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuRelation4AppEN.SectionName = objRow[convcc_ExamPaperStuRelation4App.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuRelation4AppEN.ChapterNameSim = objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuRelation4AppEN.SectionNameSim = objRow[convcc_ExamPaperStuRelation4App.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuRelation4AppEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuRelation4AppEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuRelation4AppEN.EduClsName = objRow[convcc_ExamPaperStuRelation4App.EduClsName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuRelation4AppEN.TeacherID = objRow[convcc_ExamPaperStuRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_ExamPaperStuRelation4AppEN.PubDate = objRow[convcc_ExamPaperStuRelation4App.PubDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.PubDate].ToString().Trim(); //发布日期
objvcc_ExamPaperStuRelation4AppEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_ExamPaperStuRelation4AppEN.WorkTypeName = objRow[convcc_ExamPaperStuRelation4App.WorkTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_ExamPaperStuRelation4AppEN.IdCurrEduCls = objRow[convcc_ExamPaperStuRelation4App.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuRelation4AppEN.Scores = objRow[convcc_ExamPaperStuRelation4App.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuRelation4AppEN.SpecifyCompletionDate = objRow[convcc_ExamPaperStuRelation4App.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_ExamPaperStuRelation4AppEN.IdStudentInfo = objRow[convcc_ExamPaperStuRelation4App.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuRelation4AppEN.StuID = objRow[convcc_ExamPaperStuRelation4App.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuRelation4AppEN.StuName = objRow[convcc_ExamPaperStuRelation4App.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuRelation4AppEN.IdXzCollege = objRow[convcc_ExamPaperStuRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuRelation4AppEN.CollegeName = objRow[convcc_ExamPaperStuRelation4App.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuRelation4AppEN.CollegeNameA = objRow[convcc_ExamPaperStuRelation4App.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuRelation4AppEN.IdXzMajor = objRow[convcc_ExamPaperStuRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuRelation4AppEN.MajorName = objRow[convcc_ExamPaperStuRelation4App.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuRelation4AppEN.GradeBaseName = objRow[convcc_ExamPaperStuRelation4App.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuRelation4AppEN.AnswerOptionId = objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_ExamPaperStuRelation4AppEN.AnswerMultiOptions = objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_ExamPaperStuRelation4AppEN.StuAnswerText = objRow[convcc_ExamPaperStuRelation4App.StuAnswerText] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_ExamPaperStuRelation4AppEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsPublish].ToString().Trim()); //是否发布
objvcc_ExamPaperStuRelation4AppEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuRelation4AppEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuRelation4AppEN.RealFinishDate = objRow[convcc_ExamPaperStuRelation4App.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuRelation4AppEN.Score = objRow[convcc_ExamPaperStuRelation4App.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Score].ToString().Trim()); //得分
objvcc_ExamPaperStuRelation4AppEN.Comment = objRow[convcc_ExamPaperStuRelation4App.Comment] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Comment].ToString().Trim(); //批注
objvcc_ExamPaperStuRelation4AppEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuRelation4AppEN.MarkerId = objRow[convcc_ExamPaperStuRelation4App.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuRelation4AppEN.MarkDate = objRow[convcc_ExamPaperStuRelation4App.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuRelation4AppEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSendBack].ToString().Trim()); //是否退回
objvcc_ExamPaperStuRelation4AppEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_ExamPaperStuRelation4AppEN.WorkTypeId = objRow[convcc_ExamPaperStuRelation4App.WorkTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_ExamPaperStuRelation4AppEN.AnswerIP = objRow[convcc_ExamPaperStuRelation4App.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuRelation4AppEN.AnswerDate = objRow[convcc_ExamPaperStuRelation4App.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuRelation4AppEN.AnswerTime = objRow[convcc_ExamPaperStuRelation4App.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuRelation4AppEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsRight].ToString().Trim()); //是否正确
objvcc_ExamPaperStuRelation4AppEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_ExamPaperStuRelation4AppEN.UpdDate = objRow[convcc_ExamPaperStuRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuRelation4AppEN.UpdUserId = objRow[convcc_ExamPaperStuRelation4App.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuRelation4AppEN.Memo = objRow[convcc_ExamPaperStuRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuRelation4AppEN.NoSubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum].ToString().Trim()); //未提交批次数
objvcc_ExamPaperStuRelation4AppEN.SubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum].ToString().Trim()); //提交批次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuRelation4AppEN);
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
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = new List<clsvcc_ExamPaperStuRelation4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN = new clsvcc_ExamPaperStuRelation4AppEN();
try
{
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation = Int32.Parse(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperStuRelation].ToString().Trim()); //流水号
objvcc_ExamPaperStuRelation4AppEN.CourseExamPaperId = objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperEduClsRela = objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_ExamPaperStuRelation4AppEN.CourseId = objRow[convcc_ExamPaperStuRelation4App.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuRelation4AppEN.CourseName = objRow[convcc_ExamPaperStuRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuRelation4AppEN.ExamPaperName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuRelation4AppEN.PaperIndex = objRow[convcc_ExamPaperStuRelation4App.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuRelation4AppEN.ExamCreateTime = objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuRelation4AppEN.ChapterId = objRow[convcc_ExamPaperStuRelation4App.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuRelation4AppEN.SectionId = objRow[convcc_ExamPaperStuRelation4App.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuRelation4AppEN.ChapterName = objRow[convcc_ExamPaperStuRelation4App.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuRelation4AppEN.SectionName = objRow[convcc_ExamPaperStuRelation4App.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuRelation4AppEN.ChapterNameSim = objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuRelation4AppEN.SectionNameSim = objRow[convcc_ExamPaperStuRelation4App.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuRelation4AppEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuRelation4AppEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuRelation4AppEN.EduClsName = objRow[convcc_ExamPaperStuRelation4App.EduClsName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuRelation4AppEN.TeacherID = objRow[convcc_ExamPaperStuRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_ExamPaperStuRelation4AppEN.PubDate = objRow[convcc_ExamPaperStuRelation4App.PubDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.PubDate].ToString().Trim(); //发布日期
objvcc_ExamPaperStuRelation4AppEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_ExamPaperStuRelation4AppEN.WorkTypeName = objRow[convcc_ExamPaperStuRelation4App.WorkTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_ExamPaperStuRelation4AppEN.IdCurrEduCls = objRow[convcc_ExamPaperStuRelation4App.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuRelation4AppEN.Scores = objRow[convcc_ExamPaperStuRelation4App.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuRelation4AppEN.SpecifyCompletionDate = objRow[convcc_ExamPaperStuRelation4App.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_ExamPaperStuRelation4AppEN.IdStudentInfo = objRow[convcc_ExamPaperStuRelation4App.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuRelation4AppEN.StuID = objRow[convcc_ExamPaperStuRelation4App.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuRelation4AppEN.StuName = objRow[convcc_ExamPaperStuRelation4App.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuRelation4AppEN.IdXzCollege = objRow[convcc_ExamPaperStuRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuRelation4AppEN.CollegeName = objRow[convcc_ExamPaperStuRelation4App.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuRelation4AppEN.CollegeNameA = objRow[convcc_ExamPaperStuRelation4App.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuRelation4AppEN.IdXzMajor = objRow[convcc_ExamPaperStuRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuRelation4AppEN.MajorName = objRow[convcc_ExamPaperStuRelation4App.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuRelation4AppEN.GradeBaseName = objRow[convcc_ExamPaperStuRelation4App.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuRelation4AppEN.AnswerOptionId = objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_ExamPaperStuRelation4AppEN.AnswerMultiOptions = objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_ExamPaperStuRelation4AppEN.StuAnswerText = objRow[convcc_ExamPaperStuRelation4App.StuAnswerText] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_ExamPaperStuRelation4AppEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsPublish].ToString().Trim()); //是否发布
objvcc_ExamPaperStuRelation4AppEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuRelation4AppEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuRelation4AppEN.RealFinishDate = objRow[convcc_ExamPaperStuRelation4App.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuRelation4AppEN.Score = objRow[convcc_ExamPaperStuRelation4App.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Score].ToString().Trim()); //得分
objvcc_ExamPaperStuRelation4AppEN.Comment = objRow[convcc_ExamPaperStuRelation4App.Comment] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Comment].ToString().Trim(); //批注
objvcc_ExamPaperStuRelation4AppEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuRelation4AppEN.MarkerId = objRow[convcc_ExamPaperStuRelation4App.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuRelation4AppEN.MarkDate = objRow[convcc_ExamPaperStuRelation4App.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuRelation4AppEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSendBack].ToString().Trim()); //是否退回
objvcc_ExamPaperStuRelation4AppEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_ExamPaperStuRelation4AppEN.WorkTypeId = objRow[convcc_ExamPaperStuRelation4App.WorkTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_ExamPaperStuRelation4AppEN.AnswerIP = objRow[convcc_ExamPaperStuRelation4App.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuRelation4AppEN.AnswerDate = objRow[convcc_ExamPaperStuRelation4App.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuRelation4AppEN.AnswerTime = objRow[convcc_ExamPaperStuRelation4App.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuRelation4AppEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsRight].ToString().Trim()); //是否正确
objvcc_ExamPaperStuRelation4AppEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_ExamPaperStuRelation4AppEN.UpdDate = objRow[convcc_ExamPaperStuRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuRelation4AppEN.UpdUserId = objRow[convcc_ExamPaperStuRelation4App.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuRelation4AppEN.Memo = objRow[convcc_ExamPaperStuRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuRelation4AppEN.NoSubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum].ToString().Trim()); //未提交批次数
objvcc_ExamPaperStuRelation4AppEN.SubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum].ToString().Trim()); //提交批次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuRelation4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_ExamPaperStuRelation4AppEN> GetSubObjLstCache(clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppCond)
{
 string strIdCurrEduCls = objvcc_ExamPaperStuRelation4AppCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvcc_ExamPaperStuRelation4AppBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvcc_ExamPaperStuRelation4AppEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_ExamPaperStuRelation4App.AttributeName)
{
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(strFldName) == false) continue;
if (objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_ExamPaperStuRelation4AppCond[strFldName].ToString());
}
else
{
if (objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_ExamPaperStuRelation4AppCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_ExamPaperStuRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_ExamPaperStuRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_ExamPaperStuRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_ExamPaperStuRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_ExamPaperStuRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_ExamPaperStuRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_ExamPaperStuRelation4AppCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_ExamPaperStuRelation4AppCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_ExamPaperStuRelation4AppCond[strFldName]));
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
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = new List<clsvcc_ExamPaperStuRelation4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN = new clsvcc_ExamPaperStuRelation4AppEN();
try
{
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation = Int32.Parse(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperStuRelation].ToString().Trim()); //流水号
objvcc_ExamPaperStuRelation4AppEN.CourseExamPaperId = objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperEduClsRela = objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_ExamPaperStuRelation4AppEN.CourseId = objRow[convcc_ExamPaperStuRelation4App.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuRelation4AppEN.CourseName = objRow[convcc_ExamPaperStuRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuRelation4AppEN.ExamPaperName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuRelation4AppEN.PaperIndex = objRow[convcc_ExamPaperStuRelation4App.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuRelation4AppEN.ExamCreateTime = objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuRelation4AppEN.ChapterId = objRow[convcc_ExamPaperStuRelation4App.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuRelation4AppEN.SectionId = objRow[convcc_ExamPaperStuRelation4App.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuRelation4AppEN.ChapterName = objRow[convcc_ExamPaperStuRelation4App.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuRelation4AppEN.SectionName = objRow[convcc_ExamPaperStuRelation4App.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuRelation4AppEN.ChapterNameSim = objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuRelation4AppEN.SectionNameSim = objRow[convcc_ExamPaperStuRelation4App.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuRelation4AppEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuRelation4AppEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuRelation4AppEN.EduClsName = objRow[convcc_ExamPaperStuRelation4App.EduClsName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuRelation4AppEN.TeacherID = objRow[convcc_ExamPaperStuRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_ExamPaperStuRelation4AppEN.PubDate = objRow[convcc_ExamPaperStuRelation4App.PubDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.PubDate].ToString().Trim(); //发布日期
objvcc_ExamPaperStuRelation4AppEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_ExamPaperStuRelation4AppEN.WorkTypeName = objRow[convcc_ExamPaperStuRelation4App.WorkTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_ExamPaperStuRelation4AppEN.IdCurrEduCls = objRow[convcc_ExamPaperStuRelation4App.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuRelation4AppEN.Scores = objRow[convcc_ExamPaperStuRelation4App.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuRelation4AppEN.SpecifyCompletionDate = objRow[convcc_ExamPaperStuRelation4App.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_ExamPaperStuRelation4AppEN.IdStudentInfo = objRow[convcc_ExamPaperStuRelation4App.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuRelation4AppEN.StuID = objRow[convcc_ExamPaperStuRelation4App.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuRelation4AppEN.StuName = objRow[convcc_ExamPaperStuRelation4App.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuRelation4AppEN.IdXzCollege = objRow[convcc_ExamPaperStuRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuRelation4AppEN.CollegeName = objRow[convcc_ExamPaperStuRelation4App.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuRelation4AppEN.CollegeNameA = objRow[convcc_ExamPaperStuRelation4App.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuRelation4AppEN.IdXzMajor = objRow[convcc_ExamPaperStuRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuRelation4AppEN.MajorName = objRow[convcc_ExamPaperStuRelation4App.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuRelation4AppEN.GradeBaseName = objRow[convcc_ExamPaperStuRelation4App.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuRelation4AppEN.AnswerOptionId = objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_ExamPaperStuRelation4AppEN.AnswerMultiOptions = objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_ExamPaperStuRelation4AppEN.StuAnswerText = objRow[convcc_ExamPaperStuRelation4App.StuAnswerText] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_ExamPaperStuRelation4AppEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsPublish].ToString().Trim()); //是否发布
objvcc_ExamPaperStuRelation4AppEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuRelation4AppEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuRelation4AppEN.RealFinishDate = objRow[convcc_ExamPaperStuRelation4App.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuRelation4AppEN.Score = objRow[convcc_ExamPaperStuRelation4App.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Score].ToString().Trim()); //得分
objvcc_ExamPaperStuRelation4AppEN.Comment = objRow[convcc_ExamPaperStuRelation4App.Comment] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Comment].ToString().Trim(); //批注
objvcc_ExamPaperStuRelation4AppEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuRelation4AppEN.MarkerId = objRow[convcc_ExamPaperStuRelation4App.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuRelation4AppEN.MarkDate = objRow[convcc_ExamPaperStuRelation4App.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuRelation4AppEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSendBack].ToString().Trim()); //是否退回
objvcc_ExamPaperStuRelation4AppEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_ExamPaperStuRelation4AppEN.WorkTypeId = objRow[convcc_ExamPaperStuRelation4App.WorkTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_ExamPaperStuRelation4AppEN.AnswerIP = objRow[convcc_ExamPaperStuRelation4App.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuRelation4AppEN.AnswerDate = objRow[convcc_ExamPaperStuRelation4App.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuRelation4AppEN.AnswerTime = objRow[convcc_ExamPaperStuRelation4App.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuRelation4AppEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsRight].ToString().Trim()); //是否正确
objvcc_ExamPaperStuRelation4AppEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_ExamPaperStuRelation4AppEN.UpdDate = objRow[convcc_ExamPaperStuRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuRelation4AppEN.UpdUserId = objRow[convcc_ExamPaperStuRelation4App.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuRelation4AppEN.Memo = objRow[convcc_ExamPaperStuRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuRelation4AppEN.NoSubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum].ToString().Trim()); //未提交批次数
objvcc_ExamPaperStuRelation4AppEN.SubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum].ToString().Trim()); //提交批次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuRelation4AppEN);
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
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = new List<clsvcc_ExamPaperStuRelation4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN = new clsvcc_ExamPaperStuRelation4AppEN();
try
{
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation = Int32.Parse(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperStuRelation].ToString().Trim()); //流水号
objvcc_ExamPaperStuRelation4AppEN.CourseExamPaperId = objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperEduClsRela = objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_ExamPaperStuRelation4AppEN.CourseId = objRow[convcc_ExamPaperStuRelation4App.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuRelation4AppEN.CourseName = objRow[convcc_ExamPaperStuRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuRelation4AppEN.ExamPaperName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuRelation4AppEN.PaperIndex = objRow[convcc_ExamPaperStuRelation4App.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuRelation4AppEN.ExamCreateTime = objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuRelation4AppEN.ChapterId = objRow[convcc_ExamPaperStuRelation4App.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuRelation4AppEN.SectionId = objRow[convcc_ExamPaperStuRelation4App.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuRelation4AppEN.ChapterName = objRow[convcc_ExamPaperStuRelation4App.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuRelation4AppEN.SectionName = objRow[convcc_ExamPaperStuRelation4App.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuRelation4AppEN.ChapterNameSim = objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuRelation4AppEN.SectionNameSim = objRow[convcc_ExamPaperStuRelation4App.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuRelation4AppEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuRelation4AppEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuRelation4AppEN.EduClsName = objRow[convcc_ExamPaperStuRelation4App.EduClsName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuRelation4AppEN.TeacherID = objRow[convcc_ExamPaperStuRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_ExamPaperStuRelation4AppEN.PubDate = objRow[convcc_ExamPaperStuRelation4App.PubDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.PubDate].ToString().Trim(); //发布日期
objvcc_ExamPaperStuRelation4AppEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_ExamPaperStuRelation4AppEN.WorkTypeName = objRow[convcc_ExamPaperStuRelation4App.WorkTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_ExamPaperStuRelation4AppEN.IdCurrEduCls = objRow[convcc_ExamPaperStuRelation4App.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuRelation4AppEN.Scores = objRow[convcc_ExamPaperStuRelation4App.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuRelation4AppEN.SpecifyCompletionDate = objRow[convcc_ExamPaperStuRelation4App.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_ExamPaperStuRelation4AppEN.IdStudentInfo = objRow[convcc_ExamPaperStuRelation4App.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuRelation4AppEN.StuID = objRow[convcc_ExamPaperStuRelation4App.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuRelation4AppEN.StuName = objRow[convcc_ExamPaperStuRelation4App.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuRelation4AppEN.IdXzCollege = objRow[convcc_ExamPaperStuRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuRelation4AppEN.CollegeName = objRow[convcc_ExamPaperStuRelation4App.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuRelation4AppEN.CollegeNameA = objRow[convcc_ExamPaperStuRelation4App.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuRelation4AppEN.IdXzMajor = objRow[convcc_ExamPaperStuRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuRelation4AppEN.MajorName = objRow[convcc_ExamPaperStuRelation4App.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuRelation4AppEN.GradeBaseName = objRow[convcc_ExamPaperStuRelation4App.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuRelation4AppEN.AnswerOptionId = objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_ExamPaperStuRelation4AppEN.AnswerMultiOptions = objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_ExamPaperStuRelation4AppEN.StuAnswerText = objRow[convcc_ExamPaperStuRelation4App.StuAnswerText] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_ExamPaperStuRelation4AppEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsPublish].ToString().Trim()); //是否发布
objvcc_ExamPaperStuRelation4AppEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuRelation4AppEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuRelation4AppEN.RealFinishDate = objRow[convcc_ExamPaperStuRelation4App.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuRelation4AppEN.Score = objRow[convcc_ExamPaperStuRelation4App.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Score].ToString().Trim()); //得分
objvcc_ExamPaperStuRelation4AppEN.Comment = objRow[convcc_ExamPaperStuRelation4App.Comment] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Comment].ToString().Trim(); //批注
objvcc_ExamPaperStuRelation4AppEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuRelation4AppEN.MarkerId = objRow[convcc_ExamPaperStuRelation4App.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuRelation4AppEN.MarkDate = objRow[convcc_ExamPaperStuRelation4App.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuRelation4AppEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSendBack].ToString().Trim()); //是否退回
objvcc_ExamPaperStuRelation4AppEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_ExamPaperStuRelation4AppEN.WorkTypeId = objRow[convcc_ExamPaperStuRelation4App.WorkTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_ExamPaperStuRelation4AppEN.AnswerIP = objRow[convcc_ExamPaperStuRelation4App.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuRelation4AppEN.AnswerDate = objRow[convcc_ExamPaperStuRelation4App.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuRelation4AppEN.AnswerTime = objRow[convcc_ExamPaperStuRelation4App.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuRelation4AppEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsRight].ToString().Trim()); //是否正确
objvcc_ExamPaperStuRelation4AppEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_ExamPaperStuRelation4AppEN.UpdDate = objRow[convcc_ExamPaperStuRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuRelation4AppEN.UpdUserId = objRow[convcc_ExamPaperStuRelation4App.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuRelation4AppEN.Memo = objRow[convcc_ExamPaperStuRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuRelation4AppEN.NoSubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum].ToString().Trim()); //未提交批次数
objvcc_ExamPaperStuRelation4AppEN.SubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum].ToString().Trim()); //提交批次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuRelation4AppEN);
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
List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = new List<clsvcc_ExamPaperStuRelation4AppEN>(); 
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
	clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN = new clsvcc_ExamPaperStuRelation4AppEN();
try
{
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation = Int32.Parse(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperStuRelation].ToString().Trim()); //流水号
objvcc_ExamPaperStuRelation4AppEN.CourseExamPaperId = objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperEduClsRela = objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_ExamPaperStuRelation4AppEN.CourseId = objRow[convcc_ExamPaperStuRelation4App.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuRelation4AppEN.CourseName = objRow[convcc_ExamPaperStuRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuRelation4AppEN.ExamPaperName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuRelation4AppEN.PaperIndex = objRow[convcc_ExamPaperStuRelation4App.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuRelation4AppEN.ExamCreateTime = objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuRelation4AppEN.ChapterId = objRow[convcc_ExamPaperStuRelation4App.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuRelation4AppEN.SectionId = objRow[convcc_ExamPaperStuRelation4App.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuRelation4AppEN.ChapterName = objRow[convcc_ExamPaperStuRelation4App.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuRelation4AppEN.SectionName = objRow[convcc_ExamPaperStuRelation4App.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuRelation4AppEN.ChapterNameSim = objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuRelation4AppEN.SectionNameSim = objRow[convcc_ExamPaperStuRelation4App.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuRelation4AppEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuRelation4AppEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuRelation4AppEN.EduClsName = objRow[convcc_ExamPaperStuRelation4App.EduClsName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuRelation4AppEN.TeacherID = objRow[convcc_ExamPaperStuRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_ExamPaperStuRelation4AppEN.PubDate = objRow[convcc_ExamPaperStuRelation4App.PubDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.PubDate].ToString().Trim(); //发布日期
objvcc_ExamPaperStuRelation4AppEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_ExamPaperStuRelation4AppEN.WorkTypeName = objRow[convcc_ExamPaperStuRelation4App.WorkTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_ExamPaperStuRelation4AppEN.IdCurrEduCls = objRow[convcc_ExamPaperStuRelation4App.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuRelation4AppEN.Scores = objRow[convcc_ExamPaperStuRelation4App.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuRelation4AppEN.SpecifyCompletionDate = objRow[convcc_ExamPaperStuRelation4App.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_ExamPaperStuRelation4AppEN.IdStudentInfo = objRow[convcc_ExamPaperStuRelation4App.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuRelation4AppEN.StuID = objRow[convcc_ExamPaperStuRelation4App.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuRelation4AppEN.StuName = objRow[convcc_ExamPaperStuRelation4App.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuRelation4AppEN.IdXzCollege = objRow[convcc_ExamPaperStuRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuRelation4AppEN.CollegeName = objRow[convcc_ExamPaperStuRelation4App.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuRelation4AppEN.CollegeNameA = objRow[convcc_ExamPaperStuRelation4App.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuRelation4AppEN.IdXzMajor = objRow[convcc_ExamPaperStuRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuRelation4AppEN.MajorName = objRow[convcc_ExamPaperStuRelation4App.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuRelation4AppEN.GradeBaseName = objRow[convcc_ExamPaperStuRelation4App.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuRelation4AppEN.AnswerOptionId = objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_ExamPaperStuRelation4AppEN.AnswerMultiOptions = objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_ExamPaperStuRelation4AppEN.StuAnswerText = objRow[convcc_ExamPaperStuRelation4App.StuAnswerText] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_ExamPaperStuRelation4AppEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsPublish].ToString().Trim()); //是否发布
objvcc_ExamPaperStuRelation4AppEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuRelation4AppEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuRelation4AppEN.RealFinishDate = objRow[convcc_ExamPaperStuRelation4App.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuRelation4AppEN.Score = objRow[convcc_ExamPaperStuRelation4App.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Score].ToString().Trim()); //得分
objvcc_ExamPaperStuRelation4AppEN.Comment = objRow[convcc_ExamPaperStuRelation4App.Comment] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Comment].ToString().Trim(); //批注
objvcc_ExamPaperStuRelation4AppEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuRelation4AppEN.MarkerId = objRow[convcc_ExamPaperStuRelation4App.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuRelation4AppEN.MarkDate = objRow[convcc_ExamPaperStuRelation4App.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuRelation4AppEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSendBack].ToString().Trim()); //是否退回
objvcc_ExamPaperStuRelation4AppEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_ExamPaperStuRelation4AppEN.WorkTypeId = objRow[convcc_ExamPaperStuRelation4App.WorkTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_ExamPaperStuRelation4AppEN.AnswerIP = objRow[convcc_ExamPaperStuRelation4App.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuRelation4AppEN.AnswerDate = objRow[convcc_ExamPaperStuRelation4App.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuRelation4AppEN.AnswerTime = objRow[convcc_ExamPaperStuRelation4App.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuRelation4AppEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsRight].ToString().Trim()); //是否正确
objvcc_ExamPaperStuRelation4AppEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_ExamPaperStuRelation4AppEN.UpdDate = objRow[convcc_ExamPaperStuRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuRelation4AppEN.UpdUserId = objRow[convcc_ExamPaperStuRelation4App.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuRelation4AppEN.Memo = objRow[convcc_ExamPaperStuRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuRelation4AppEN.NoSubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum].ToString().Trim()); //未提交批次数
objvcc_ExamPaperStuRelation4AppEN.SubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum].ToString().Trim()); //提交批次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuRelation4AppEN);
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
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = new List<clsvcc_ExamPaperStuRelation4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN = new clsvcc_ExamPaperStuRelation4AppEN();
try
{
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation = Int32.Parse(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperStuRelation].ToString().Trim()); //流水号
objvcc_ExamPaperStuRelation4AppEN.CourseExamPaperId = objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperEduClsRela = objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_ExamPaperStuRelation4AppEN.CourseId = objRow[convcc_ExamPaperStuRelation4App.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuRelation4AppEN.CourseName = objRow[convcc_ExamPaperStuRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuRelation4AppEN.ExamPaperName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuRelation4AppEN.PaperIndex = objRow[convcc_ExamPaperStuRelation4App.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuRelation4AppEN.ExamCreateTime = objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuRelation4AppEN.ChapterId = objRow[convcc_ExamPaperStuRelation4App.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuRelation4AppEN.SectionId = objRow[convcc_ExamPaperStuRelation4App.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuRelation4AppEN.ChapterName = objRow[convcc_ExamPaperStuRelation4App.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuRelation4AppEN.SectionName = objRow[convcc_ExamPaperStuRelation4App.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuRelation4AppEN.ChapterNameSim = objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuRelation4AppEN.SectionNameSim = objRow[convcc_ExamPaperStuRelation4App.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuRelation4AppEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuRelation4AppEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuRelation4AppEN.EduClsName = objRow[convcc_ExamPaperStuRelation4App.EduClsName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuRelation4AppEN.TeacherID = objRow[convcc_ExamPaperStuRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_ExamPaperStuRelation4AppEN.PubDate = objRow[convcc_ExamPaperStuRelation4App.PubDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.PubDate].ToString().Trim(); //发布日期
objvcc_ExamPaperStuRelation4AppEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_ExamPaperStuRelation4AppEN.WorkTypeName = objRow[convcc_ExamPaperStuRelation4App.WorkTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_ExamPaperStuRelation4AppEN.IdCurrEduCls = objRow[convcc_ExamPaperStuRelation4App.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuRelation4AppEN.Scores = objRow[convcc_ExamPaperStuRelation4App.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuRelation4AppEN.SpecifyCompletionDate = objRow[convcc_ExamPaperStuRelation4App.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_ExamPaperStuRelation4AppEN.IdStudentInfo = objRow[convcc_ExamPaperStuRelation4App.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuRelation4AppEN.StuID = objRow[convcc_ExamPaperStuRelation4App.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuRelation4AppEN.StuName = objRow[convcc_ExamPaperStuRelation4App.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuRelation4AppEN.IdXzCollege = objRow[convcc_ExamPaperStuRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuRelation4AppEN.CollegeName = objRow[convcc_ExamPaperStuRelation4App.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuRelation4AppEN.CollegeNameA = objRow[convcc_ExamPaperStuRelation4App.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuRelation4AppEN.IdXzMajor = objRow[convcc_ExamPaperStuRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuRelation4AppEN.MajorName = objRow[convcc_ExamPaperStuRelation4App.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuRelation4AppEN.GradeBaseName = objRow[convcc_ExamPaperStuRelation4App.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuRelation4AppEN.AnswerOptionId = objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_ExamPaperStuRelation4AppEN.AnswerMultiOptions = objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_ExamPaperStuRelation4AppEN.StuAnswerText = objRow[convcc_ExamPaperStuRelation4App.StuAnswerText] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_ExamPaperStuRelation4AppEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsPublish].ToString().Trim()); //是否发布
objvcc_ExamPaperStuRelation4AppEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuRelation4AppEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuRelation4AppEN.RealFinishDate = objRow[convcc_ExamPaperStuRelation4App.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuRelation4AppEN.Score = objRow[convcc_ExamPaperStuRelation4App.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Score].ToString().Trim()); //得分
objvcc_ExamPaperStuRelation4AppEN.Comment = objRow[convcc_ExamPaperStuRelation4App.Comment] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Comment].ToString().Trim(); //批注
objvcc_ExamPaperStuRelation4AppEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuRelation4AppEN.MarkerId = objRow[convcc_ExamPaperStuRelation4App.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuRelation4AppEN.MarkDate = objRow[convcc_ExamPaperStuRelation4App.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuRelation4AppEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSendBack].ToString().Trim()); //是否退回
objvcc_ExamPaperStuRelation4AppEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_ExamPaperStuRelation4AppEN.WorkTypeId = objRow[convcc_ExamPaperStuRelation4App.WorkTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_ExamPaperStuRelation4AppEN.AnswerIP = objRow[convcc_ExamPaperStuRelation4App.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuRelation4AppEN.AnswerDate = objRow[convcc_ExamPaperStuRelation4App.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuRelation4AppEN.AnswerTime = objRow[convcc_ExamPaperStuRelation4App.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuRelation4AppEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsRight].ToString().Trim()); //是否正确
objvcc_ExamPaperStuRelation4AppEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_ExamPaperStuRelation4AppEN.UpdDate = objRow[convcc_ExamPaperStuRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuRelation4AppEN.UpdUserId = objRow[convcc_ExamPaperStuRelation4App.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuRelation4AppEN.Memo = objRow[convcc_ExamPaperStuRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuRelation4AppEN.NoSubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum].ToString().Trim()); //未提交批次数
objvcc_ExamPaperStuRelation4AppEN.SubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum].ToString().Trim()); //提交批次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuRelation4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = new List<clsvcc_ExamPaperStuRelation4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN = new clsvcc_ExamPaperStuRelation4AppEN();
try
{
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation = Int32.Parse(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperStuRelation].ToString().Trim()); //流水号
objvcc_ExamPaperStuRelation4AppEN.CourseExamPaperId = objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperEduClsRela = objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_ExamPaperStuRelation4AppEN.CourseId = objRow[convcc_ExamPaperStuRelation4App.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuRelation4AppEN.CourseName = objRow[convcc_ExamPaperStuRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuRelation4AppEN.ExamPaperName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuRelation4AppEN.PaperIndex = objRow[convcc_ExamPaperStuRelation4App.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuRelation4AppEN.ExamCreateTime = objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuRelation4AppEN.ChapterId = objRow[convcc_ExamPaperStuRelation4App.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuRelation4AppEN.SectionId = objRow[convcc_ExamPaperStuRelation4App.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuRelation4AppEN.ChapterName = objRow[convcc_ExamPaperStuRelation4App.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuRelation4AppEN.SectionName = objRow[convcc_ExamPaperStuRelation4App.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuRelation4AppEN.ChapterNameSim = objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuRelation4AppEN.SectionNameSim = objRow[convcc_ExamPaperStuRelation4App.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuRelation4AppEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuRelation4AppEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuRelation4AppEN.EduClsName = objRow[convcc_ExamPaperStuRelation4App.EduClsName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuRelation4AppEN.TeacherID = objRow[convcc_ExamPaperStuRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_ExamPaperStuRelation4AppEN.PubDate = objRow[convcc_ExamPaperStuRelation4App.PubDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.PubDate].ToString().Trim(); //发布日期
objvcc_ExamPaperStuRelation4AppEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_ExamPaperStuRelation4AppEN.WorkTypeName = objRow[convcc_ExamPaperStuRelation4App.WorkTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_ExamPaperStuRelation4AppEN.IdCurrEduCls = objRow[convcc_ExamPaperStuRelation4App.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuRelation4AppEN.Scores = objRow[convcc_ExamPaperStuRelation4App.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuRelation4AppEN.SpecifyCompletionDate = objRow[convcc_ExamPaperStuRelation4App.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_ExamPaperStuRelation4AppEN.IdStudentInfo = objRow[convcc_ExamPaperStuRelation4App.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuRelation4AppEN.StuID = objRow[convcc_ExamPaperStuRelation4App.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuRelation4AppEN.StuName = objRow[convcc_ExamPaperStuRelation4App.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuRelation4AppEN.IdXzCollege = objRow[convcc_ExamPaperStuRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuRelation4AppEN.CollegeName = objRow[convcc_ExamPaperStuRelation4App.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuRelation4AppEN.CollegeNameA = objRow[convcc_ExamPaperStuRelation4App.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuRelation4AppEN.IdXzMajor = objRow[convcc_ExamPaperStuRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuRelation4AppEN.MajorName = objRow[convcc_ExamPaperStuRelation4App.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuRelation4AppEN.GradeBaseName = objRow[convcc_ExamPaperStuRelation4App.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuRelation4AppEN.AnswerOptionId = objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_ExamPaperStuRelation4AppEN.AnswerMultiOptions = objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_ExamPaperStuRelation4AppEN.StuAnswerText = objRow[convcc_ExamPaperStuRelation4App.StuAnswerText] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_ExamPaperStuRelation4AppEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsPublish].ToString().Trim()); //是否发布
objvcc_ExamPaperStuRelation4AppEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuRelation4AppEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuRelation4AppEN.RealFinishDate = objRow[convcc_ExamPaperStuRelation4App.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuRelation4AppEN.Score = objRow[convcc_ExamPaperStuRelation4App.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Score].ToString().Trim()); //得分
objvcc_ExamPaperStuRelation4AppEN.Comment = objRow[convcc_ExamPaperStuRelation4App.Comment] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Comment].ToString().Trim(); //批注
objvcc_ExamPaperStuRelation4AppEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuRelation4AppEN.MarkerId = objRow[convcc_ExamPaperStuRelation4App.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuRelation4AppEN.MarkDate = objRow[convcc_ExamPaperStuRelation4App.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuRelation4AppEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSendBack].ToString().Trim()); //是否退回
objvcc_ExamPaperStuRelation4AppEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_ExamPaperStuRelation4AppEN.WorkTypeId = objRow[convcc_ExamPaperStuRelation4App.WorkTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_ExamPaperStuRelation4AppEN.AnswerIP = objRow[convcc_ExamPaperStuRelation4App.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuRelation4AppEN.AnswerDate = objRow[convcc_ExamPaperStuRelation4App.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuRelation4AppEN.AnswerTime = objRow[convcc_ExamPaperStuRelation4App.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuRelation4AppEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsRight].ToString().Trim()); //是否正确
objvcc_ExamPaperStuRelation4AppEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_ExamPaperStuRelation4AppEN.UpdDate = objRow[convcc_ExamPaperStuRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuRelation4AppEN.UpdUserId = objRow[convcc_ExamPaperStuRelation4App.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuRelation4AppEN.Memo = objRow[convcc_ExamPaperStuRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuRelation4AppEN.NoSubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum].ToString().Trim()); //未提交批次数
objvcc_ExamPaperStuRelation4AppEN.SubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum].ToString().Trim()); //提交批次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuRelation4AppEN);
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
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = new List<clsvcc_ExamPaperStuRelation4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN = new clsvcc_ExamPaperStuRelation4AppEN();
try
{
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation = Int32.Parse(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperStuRelation].ToString().Trim()); //流水号
objvcc_ExamPaperStuRelation4AppEN.CourseExamPaperId = objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperEduClsRela = objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_ExamPaperStuRelation4AppEN.CourseId = objRow[convcc_ExamPaperStuRelation4App.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuRelation4AppEN.CourseName = objRow[convcc_ExamPaperStuRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuRelation4AppEN.ExamPaperName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuRelation4AppEN.PaperIndex = objRow[convcc_ExamPaperStuRelation4App.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuRelation4AppEN.ExamCreateTime = objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuRelation4AppEN.ChapterId = objRow[convcc_ExamPaperStuRelation4App.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuRelation4AppEN.SectionId = objRow[convcc_ExamPaperStuRelation4App.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuRelation4AppEN.ChapterName = objRow[convcc_ExamPaperStuRelation4App.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuRelation4AppEN.SectionName = objRow[convcc_ExamPaperStuRelation4App.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuRelation4AppEN.ChapterNameSim = objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuRelation4AppEN.SectionNameSim = objRow[convcc_ExamPaperStuRelation4App.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuRelation4AppEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuRelation4AppEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuRelation4AppEN.EduClsName = objRow[convcc_ExamPaperStuRelation4App.EduClsName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuRelation4AppEN.TeacherID = objRow[convcc_ExamPaperStuRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_ExamPaperStuRelation4AppEN.PubDate = objRow[convcc_ExamPaperStuRelation4App.PubDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.PubDate].ToString().Trim(); //发布日期
objvcc_ExamPaperStuRelation4AppEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_ExamPaperStuRelation4AppEN.WorkTypeName = objRow[convcc_ExamPaperStuRelation4App.WorkTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_ExamPaperStuRelation4AppEN.IdCurrEduCls = objRow[convcc_ExamPaperStuRelation4App.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuRelation4AppEN.Scores = objRow[convcc_ExamPaperStuRelation4App.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuRelation4AppEN.SpecifyCompletionDate = objRow[convcc_ExamPaperStuRelation4App.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_ExamPaperStuRelation4AppEN.IdStudentInfo = objRow[convcc_ExamPaperStuRelation4App.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuRelation4AppEN.StuID = objRow[convcc_ExamPaperStuRelation4App.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuRelation4AppEN.StuName = objRow[convcc_ExamPaperStuRelation4App.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuRelation4AppEN.IdXzCollege = objRow[convcc_ExamPaperStuRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuRelation4AppEN.CollegeName = objRow[convcc_ExamPaperStuRelation4App.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuRelation4AppEN.CollegeNameA = objRow[convcc_ExamPaperStuRelation4App.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuRelation4AppEN.IdXzMajor = objRow[convcc_ExamPaperStuRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuRelation4AppEN.MajorName = objRow[convcc_ExamPaperStuRelation4App.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuRelation4AppEN.GradeBaseName = objRow[convcc_ExamPaperStuRelation4App.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuRelation4AppEN.AnswerOptionId = objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_ExamPaperStuRelation4AppEN.AnswerMultiOptions = objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_ExamPaperStuRelation4AppEN.StuAnswerText = objRow[convcc_ExamPaperStuRelation4App.StuAnswerText] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_ExamPaperStuRelation4AppEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsPublish].ToString().Trim()); //是否发布
objvcc_ExamPaperStuRelation4AppEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuRelation4AppEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuRelation4AppEN.RealFinishDate = objRow[convcc_ExamPaperStuRelation4App.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuRelation4AppEN.Score = objRow[convcc_ExamPaperStuRelation4App.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Score].ToString().Trim()); //得分
objvcc_ExamPaperStuRelation4AppEN.Comment = objRow[convcc_ExamPaperStuRelation4App.Comment] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Comment].ToString().Trim(); //批注
objvcc_ExamPaperStuRelation4AppEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuRelation4AppEN.MarkerId = objRow[convcc_ExamPaperStuRelation4App.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuRelation4AppEN.MarkDate = objRow[convcc_ExamPaperStuRelation4App.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuRelation4AppEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSendBack].ToString().Trim()); //是否退回
objvcc_ExamPaperStuRelation4AppEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_ExamPaperStuRelation4AppEN.WorkTypeId = objRow[convcc_ExamPaperStuRelation4App.WorkTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_ExamPaperStuRelation4AppEN.AnswerIP = objRow[convcc_ExamPaperStuRelation4App.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuRelation4AppEN.AnswerDate = objRow[convcc_ExamPaperStuRelation4App.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuRelation4AppEN.AnswerTime = objRow[convcc_ExamPaperStuRelation4App.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuRelation4AppEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsRight].ToString().Trim()); //是否正确
objvcc_ExamPaperStuRelation4AppEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_ExamPaperStuRelation4AppEN.UpdDate = objRow[convcc_ExamPaperStuRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuRelation4AppEN.UpdUserId = objRow[convcc_ExamPaperStuRelation4App.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuRelation4AppEN.Memo = objRow[convcc_ExamPaperStuRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuRelation4AppEN.NoSubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum].ToString().Trim()); //未提交批次数
objvcc_ExamPaperStuRelation4AppEN.SubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum].ToString().Trim()); //提交批次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuRelation4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = new List<clsvcc_ExamPaperStuRelation4AppEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN = new clsvcc_ExamPaperStuRelation4AppEN();
try
{
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation = Int32.Parse(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperStuRelation].ToString().Trim()); //流水号
objvcc_ExamPaperStuRelation4AppEN.CourseExamPaperId = objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperEduClsRela = objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela].ToString().Trim()); //作业教学班关系流水号
objvcc_ExamPaperStuRelation4AppEN.CourseId = objRow[convcc_ExamPaperStuRelation4App.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperStuRelation4AppEN.CourseName = objRow[convcc_ExamPaperStuRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperStuRelation4AppEN.ExamPaperName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperStuRelation4AppEN.PaperIndex = objRow[convcc_ExamPaperStuRelation4App.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.PaperIndex].ToString().Trim()); //试卷序号
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeId = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeName = objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperStuRelation4AppEN.ExamCreateTime = objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperStuRelation4AppEN.ChapterId = objRow[convcc_ExamPaperStuRelation4App.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperStuRelation4AppEN.SectionId = objRow[convcc_ExamPaperStuRelation4App.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperStuRelation4AppEN.ChapterName = objRow[convcc_ExamPaperStuRelation4App.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperStuRelation4AppEN.SectionName = objRow[convcc_ExamPaperStuRelation4App.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperStuRelation4AppEN.ChapterNameSim = objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperStuRelation4AppEN.SectionNameSim = objRow[convcc_ExamPaperStuRelation4App.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperStuRelation4AppEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objvcc_ExamPaperStuRelation4AppEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objvcc_ExamPaperStuRelation4AppEN.EduClsName = objRow[convcc_ExamPaperStuRelation4App.EduClsName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.EduClsName].ToString().Trim(); //教学班名
objvcc_ExamPaperStuRelation4AppEN.TeacherID = objRow[convcc_ExamPaperStuRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_ExamPaperStuRelation4AppEN.PubDate = objRow[convcc_ExamPaperStuRelation4App.PubDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.PubDate].ToString().Trim(); //发布日期
objvcc_ExamPaperStuRelation4AppEN.IsCurrEduCls = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsCurrEduCls].ToString().Trim()); //是否为教学班作业
objvcc_ExamPaperStuRelation4AppEN.WorkTypeName = objRow[convcc_ExamPaperStuRelation4App.WorkTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeName].ToString().Trim(); //作业类型名称
objvcc_ExamPaperStuRelation4AppEN.IdCurrEduCls = objRow[convcc_ExamPaperStuRelation4App.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvcc_ExamPaperStuRelation4AppEN.Scores = objRow[convcc_ExamPaperStuRelation4App.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Scores].ToString().Trim()); //分值
objvcc_ExamPaperStuRelation4AppEN.SpecifyCompletionDate = objRow[convcc_ExamPaperStuRelation4App.SpecifyCompletionDate].ToString().Trim(); //指定完成日期
objvcc_ExamPaperStuRelation4AppEN.IdStudentInfo = objRow[convcc_ExamPaperStuRelation4App.IdStudentInfo].ToString().Trim(); //学生流水号
objvcc_ExamPaperStuRelation4AppEN.StuID = objRow[convcc_ExamPaperStuRelation4App.StuID] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuID].ToString().Trim(); //学号
objvcc_ExamPaperStuRelation4AppEN.StuName = objRow[convcc_ExamPaperStuRelation4App.StuName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuName].ToString().Trim(); //姓名
objvcc_ExamPaperStuRelation4AppEN.IdXzCollege = objRow[convcc_ExamPaperStuRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_ExamPaperStuRelation4AppEN.CollegeName = objRow[convcc_ExamPaperStuRelation4App.CollegeName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeName].ToString().Trim(); //学院名称
objvcc_ExamPaperStuRelation4AppEN.CollegeNameA = objRow[convcc_ExamPaperStuRelation4App.CollegeNameA] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_ExamPaperStuRelation4AppEN.IdXzMajor = objRow[convcc_ExamPaperStuRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_ExamPaperStuRelation4AppEN.MajorName = objRow[convcc_ExamPaperStuRelation4App.MajorName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MajorName].ToString().Trim(); //专业名称
objvcc_ExamPaperStuRelation4AppEN.GradeBaseName = objRow[convcc_ExamPaperStuRelation4App.GradeBaseName] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.GradeBaseName].ToString().Trim(); //年级名称
objvcc_ExamPaperStuRelation4AppEN.AnswerOptionId = objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerOptionId].ToString().Trim(); //回答选项Id
objvcc_ExamPaperStuRelation4AppEN.AnswerMultiOptions = objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerMultiOptions].ToString().Trim(); //多选项答案
objvcc_ExamPaperStuRelation4AppEN.StuAnswerText = objRow[convcc_ExamPaperStuRelation4App.StuAnswerText] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.StuAnswerText].ToString().Trim(); //学生回答文本
objvcc_ExamPaperStuRelation4AppEN.IsPublish = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsPublish].ToString().Trim()); //是否发布
objvcc_ExamPaperStuRelation4AppEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSave].ToString().Trim()); //是否保存
objvcc_ExamPaperStuRelation4AppEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSubmit].ToString().Trim()); //是否提交
objvcc_ExamPaperStuRelation4AppEN.RealFinishDate = objRow[convcc_ExamPaperStuRelation4App.RealFinishDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.RealFinishDate].ToString().Trim(); //实际完成日期
objvcc_ExamPaperStuRelation4AppEN.Score = objRow[convcc_ExamPaperStuRelation4App.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperStuRelation4App.Score].ToString().Trim()); //得分
objvcc_ExamPaperStuRelation4AppEN.Comment = objRow[convcc_ExamPaperStuRelation4App.Comment] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Comment].ToString().Trim(); //批注
objvcc_ExamPaperStuRelation4AppEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsMarking].ToString().Trim()); //是否批阅
objvcc_ExamPaperStuRelation4AppEN.MarkerId = objRow[convcc_ExamPaperStuRelation4App.MarkerId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkerId].ToString().Trim(); //打分者
objvcc_ExamPaperStuRelation4AppEN.MarkDate = objRow[convcc_ExamPaperStuRelation4App.MarkDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.MarkDate].ToString().Trim(); //打分日期
objvcc_ExamPaperStuRelation4AppEN.IsSendBack = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsSendBack].ToString().Trim()); //是否退回
objvcc_ExamPaperStuRelation4AppEN.IsInErrorQuestion = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsInErrorQuestion].ToString().Trim()); //是否进入错题
objvcc_ExamPaperStuRelation4AppEN.WorkTypeId = objRow[convcc_ExamPaperStuRelation4App.WorkTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.WorkTypeId].ToString().Trim(); //作业类型Id
objvcc_ExamPaperStuRelation4AppEN.AnswerIP = objRow[convcc_ExamPaperStuRelation4App.AnswerIP] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerIP].ToString().Trim(); //回答IP
objvcc_ExamPaperStuRelation4AppEN.AnswerDate = objRow[convcc_ExamPaperStuRelation4App.AnswerDate] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerDate].ToString().Trim(); //回答日期
objvcc_ExamPaperStuRelation4AppEN.AnswerTime = objRow[convcc_ExamPaperStuRelation4App.AnswerTime] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.AnswerTime].ToString().Trim(); //回答时间
objvcc_ExamPaperStuRelation4AppEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsRight].ToString().Trim()); //是否正确
objvcc_ExamPaperStuRelation4AppEN.IsNotProcessTimeout = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperStuRelation4App.IsNotProcessTimeout].ToString().Trim()); //是否不处理超时
objvcc_ExamPaperStuRelation4AppEN.UpdDate = objRow[convcc_ExamPaperStuRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperStuRelation4AppEN.UpdUserId = objRow[convcc_ExamPaperStuRelation4App.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperStuRelation4AppEN.Memo = objRow[convcc_ExamPaperStuRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperStuRelation4App.Memo].ToString().Trim(); //备注
objvcc_ExamPaperStuRelation4AppEN.NoSubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum].ToString().Trim()); //未提交批次数
objvcc_ExamPaperStuRelation4AppEN.SubmitBatchNum = objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperStuRelation4App.SubmitBatchNum].ToString().Trim()); //提交批次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_ExamPaperStuRelation4AppEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_ExamPaperStuRelation4App(ref clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN)
{
bool bolResult = vcc_ExamPaperStuRelation4AppDA.Getvcc_ExamPaperStuRelation4App(ref objvcc_ExamPaperStuRelation4AppEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdExamPaperStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExamPaperStuRelation4AppEN GetObjByIdExamPaperStuRelation(long lngIdExamPaperStuRelation)
{
clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN = vcc_ExamPaperStuRelation4AppDA.GetObjByIdExamPaperStuRelation(lngIdExamPaperStuRelation);
return objvcc_ExamPaperStuRelation4AppEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_ExamPaperStuRelation4AppEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN = vcc_ExamPaperStuRelation4AppDA.GetFirstObj(strWhereCond);
 return objvcc_ExamPaperStuRelation4AppEN;
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
public static clsvcc_ExamPaperStuRelation4AppEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN = vcc_ExamPaperStuRelation4AppDA.GetObjByDataRow(objRow);
 return objvcc_ExamPaperStuRelation4AppEN;
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
public static clsvcc_ExamPaperStuRelation4AppEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN = vcc_ExamPaperStuRelation4AppDA.GetObjByDataRow(objRow);
 return objvcc_ExamPaperStuRelation4AppEN;
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
 /// <param name = "lngIdExamPaperStuRelation">所给的关键字</param>
 /// <param name = "lstvcc_ExamPaperStuRelation4AppObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_ExamPaperStuRelation4AppEN GetObjByIdExamPaperStuRelationFromList(long lngIdExamPaperStuRelation, List<clsvcc_ExamPaperStuRelation4AppEN> lstvcc_ExamPaperStuRelation4AppObjLst)
{
foreach (clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN in lstvcc_ExamPaperStuRelation4AppObjLst)
{
if (objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation == lngIdExamPaperStuRelation)
{
return objvcc_ExamPaperStuRelation4AppEN;
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
 long lngIdExamPaperStuRelation;
 try
 {
 lngIdExamPaperStuRelation = new clsvcc_ExamPaperStuRelation4AppDA().GetFirstID(strWhereCond);
 return lngIdExamPaperStuRelation;
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
 arrList = vcc_ExamPaperStuRelation4AppDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_ExamPaperStuRelation4AppDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdExamPaperStuRelation">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdExamPaperStuRelation)
{
//检测记录是否存在
bool bolIsExist = vcc_ExamPaperStuRelation4AppDA.IsExist(lngIdExamPaperStuRelation);
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
 bolIsExist = clsvcc_ExamPaperStuRelation4AppDA.IsExistTable();
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
 bolIsExist = vcc_ExamPaperStuRelation4AppDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_ExamPaperStuRelation4AppENS">源对象</param>
 /// <param name = "objvcc_ExamPaperStuRelation4AppENT">目标对象</param>
 public static void CopyTo(clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppENS, clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppENT)
{
try
{
objvcc_ExamPaperStuRelation4AppENT.IdExamPaperStuRelation = objvcc_ExamPaperStuRelation4AppENS.IdExamPaperStuRelation; //流水号
objvcc_ExamPaperStuRelation4AppENT.CourseExamPaperId = objvcc_ExamPaperStuRelation4AppENS.CourseExamPaperId; //考卷流水号
objvcc_ExamPaperStuRelation4AppENT.IdExamPaperEduClsRela = objvcc_ExamPaperStuRelation4AppENS.IdExamPaperEduClsRela; //作业教学班关系流水号
objvcc_ExamPaperStuRelation4AppENT.CourseId = objvcc_ExamPaperStuRelation4AppENS.CourseId; //课程Id
objvcc_ExamPaperStuRelation4AppENT.CourseName = objvcc_ExamPaperStuRelation4AppENS.CourseName; //课程名称
objvcc_ExamPaperStuRelation4AppENT.ExamPaperName = objvcc_ExamPaperStuRelation4AppENS.ExamPaperName; //考卷名称
objvcc_ExamPaperStuRelation4AppENT.PaperIndex = objvcc_ExamPaperStuRelation4AppENS.PaperIndex; //试卷序号
objvcc_ExamPaperStuRelation4AppENT.ExamPaperTypeId = objvcc_ExamPaperStuRelation4AppENS.ExamPaperTypeId; //试卷类型Id
objvcc_ExamPaperStuRelation4AppENT.ExamPaperTypeName = objvcc_ExamPaperStuRelation4AppENS.ExamPaperTypeName; //试卷类型名称
objvcc_ExamPaperStuRelation4AppENT.ExamCreateTime = objvcc_ExamPaperStuRelation4AppENS.ExamCreateTime; //考卷建立时间
objvcc_ExamPaperStuRelation4AppENT.ChapterId = objvcc_ExamPaperStuRelation4AppENS.ChapterId; //章Id
objvcc_ExamPaperStuRelation4AppENT.SectionId = objvcc_ExamPaperStuRelation4AppENS.SectionId; //节Id
objvcc_ExamPaperStuRelation4AppENT.ChapterName = objvcc_ExamPaperStuRelation4AppENS.ChapterName; //章名
objvcc_ExamPaperStuRelation4AppENT.SectionName = objvcc_ExamPaperStuRelation4AppENS.SectionName; //节名
objvcc_ExamPaperStuRelation4AppENT.ChapterNameSim = objvcc_ExamPaperStuRelation4AppENS.ChapterNameSim; //章名简称
objvcc_ExamPaperStuRelation4AppENT.SectionNameSim = objvcc_ExamPaperStuRelation4AppENS.SectionNameSim; //节名简称
objvcc_ExamPaperStuRelation4AppENT.IsAutoGeneQuestion = objvcc_ExamPaperStuRelation4AppENS.IsAutoGeneQuestion; //是否自动生成题目
objvcc_ExamPaperStuRelation4AppENT.IsCanMultiDo = objvcc_ExamPaperStuRelation4AppENS.IsCanMultiDo; //是否可以做多次
objvcc_ExamPaperStuRelation4AppENT.EduClsName = objvcc_ExamPaperStuRelation4AppENS.EduClsName; //教学班名
objvcc_ExamPaperStuRelation4AppENT.TeacherID = objvcc_ExamPaperStuRelation4AppENS.TeacherID; //教师工号
objvcc_ExamPaperStuRelation4AppENT.PubDate = objvcc_ExamPaperStuRelation4AppENS.PubDate; //发布日期
objvcc_ExamPaperStuRelation4AppENT.IsCurrEduCls = objvcc_ExamPaperStuRelation4AppENS.IsCurrEduCls; //是否为教学班作业
objvcc_ExamPaperStuRelation4AppENT.WorkTypeName = objvcc_ExamPaperStuRelation4AppENS.WorkTypeName; //作业类型名称
objvcc_ExamPaperStuRelation4AppENT.IdCurrEduCls = objvcc_ExamPaperStuRelation4AppENS.IdCurrEduCls; //教学班流水号
objvcc_ExamPaperStuRelation4AppENT.Scores = objvcc_ExamPaperStuRelation4AppENS.Scores; //分值
objvcc_ExamPaperStuRelation4AppENT.SpecifyCompletionDate = objvcc_ExamPaperStuRelation4AppENS.SpecifyCompletionDate; //指定完成日期
objvcc_ExamPaperStuRelation4AppENT.IdStudentInfo = objvcc_ExamPaperStuRelation4AppENS.IdStudentInfo; //学生流水号
objvcc_ExamPaperStuRelation4AppENT.StuID = objvcc_ExamPaperStuRelation4AppENS.StuID; //学号
objvcc_ExamPaperStuRelation4AppENT.StuName = objvcc_ExamPaperStuRelation4AppENS.StuName; //姓名
objvcc_ExamPaperStuRelation4AppENT.IdXzCollege = objvcc_ExamPaperStuRelation4AppENS.IdXzCollege; //学院流水号
objvcc_ExamPaperStuRelation4AppENT.CollegeName = objvcc_ExamPaperStuRelation4AppENS.CollegeName; //学院名称
objvcc_ExamPaperStuRelation4AppENT.CollegeNameA = objvcc_ExamPaperStuRelation4AppENS.CollegeNameA; //学院名称简写
objvcc_ExamPaperStuRelation4AppENT.IdXzMajor = objvcc_ExamPaperStuRelation4AppENS.IdXzMajor; //专业流水号
objvcc_ExamPaperStuRelation4AppENT.MajorName = objvcc_ExamPaperStuRelation4AppENS.MajorName; //专业名称
objvcc_ExamPaperStuRelation4AppENT.GradeBaseName = objvcc_ExamPaperStuRelation4AppENS.GradeBaseName; //年级名称
objvcc_ExamPaperStuRelation4AppENT.AnswerOptionId = objvcc_ExamPaperStuRelation4AppENS.AnswerOptionId; //回答选项Id
objvcc_ExamPaperStuRelation4AppENT.AnswerMultiOptions = objvcc_ExamPaperStuRelation4AppENS.AnswerMultiOptions; //多选项答案
objvcc_ExamPaperStuRelation4AppENT.StuAnswerText = objvcc_ExamPaperStuRelation4AppENS.StuAnswerText; //学生回答文本
objvcc_ExamPaperStuRelation4AppENT.IsPublish = objvcc_ExamPaperStuRelation4AppENS.IsPublish; //是否发布
objvcc_ExamPaperStuRelation4AppENT.IsSave = objvcc_ExamPaperStuRelation4AppENS.IsSave; //是否保存
objvcc_ExamPaperStuRelation4AppENT.IsSubmit = objvcc_ExamPaperStuRelation4AppENS.IsSubmit; //是否提交
objvcc_ExamPaperStuRelation4AppENT.RealFinishDate = objvcc_ExamPaperStuRelation4AppENS.RealFinishDate; //实际完成日期
objvcc_ExamPaperStuRelation4AppENT.Score = objvcc_ExamPaperStuRelation4AppENS.Score; //得分
objvcc_ExamPaperStuRelation4AppENT.Comment = objvcc_ExamPaperStuRelation4AppENS.Comment; //批注
objvcc_ExamPaperStuRelation4AppENT.IsMarking = objvcc_ExamPaperStuRelation4AppENS.IsMarking; //是否批阅
objvcc_ExamPaperStuRelation4AppENT.MarkerId = objvcc_ExamPaperStuRelation4AppENS.MarkerId; //打分者
objvcc_ExamPaperStuRelation4AppENT.MarkDate = objvcc_ExamPaperStuRelation4AppENS.MarkDate; //打分日期
objvcc_ExamPaperStuRelation4AppENT.IsSendBack = objvcc_ExamPaperStuRelation4AppENS.IsSendBack; //是否退回
objvcc_ExamPaperStuRelation4AppENT.IsInErrorQuestion = objvcc_ExamPaperStuRelation4AppENS.IsInErrorQuestion; //是否进入错题
objvcc_ExamPaperStuRelation4AppENT.WorkTypeId = objvcc_ExamPaperStuRelation4AppENS.WorkTypeId; //作业类型Id
objvcc_ExamPaperStuRelation4AppENT.AnswerIP = objvcc_ExamPaperStuRelation4AppENS.AnswerIP; //回答IP
objvcc_ExamPaperStuRelation4AppENT.AnswerDate = objvcc_ExamPaperStuRelation4AppENS.AnswerDate; //回答日期
objvcc_ExamPaperStuRelation4AppENT.AnswerTime = objvcc_ExamPaperStuRelation4AppENS.AnswerTime; //回答时间
objvcc_ExamPaperStuRelation4AppENT.IsRight = objvcc_ExamPaperStuRelation4AppENS.IsRight; //是否正确
objvcc_ExamPaperStuRelation4AppENT.IsNotProcessTimeout = objvcc_ExamPaperStuRelation4AppENS.IsNotProcessTimeout; //是否不处理超时
objvcc_ExamPaperStuRelation4AppENT.UpdDate = objvcc_ExamPaperStuRelation4AppENS.UpdDate; //修改日期
objvcc_ExamPaperStuRelation4AppENT.UpdUserId = objvcc_ExamPaperStuRelation4AppENS.UpdUserId; //修改用户Id
objvcc_ExamPaperStuRelation4AppENT.Memo = objvcc_ExamPaperStuRelation4AppENS.Memo; //备注
objvcc_ExamPaperStuRelation4AppENT.NoSubmitBatchNum = objvcc_ExamPaperStuRelation4AppENS.NoSubmitBatchNum; //未提交批次数
objvcc_ExamPaperStuRelation4AppENT.SubmitBatchNum = objvcc_ExamPaperStuRelation4AppENS.SubmitBatchNum; //提交批次数
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
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN)
{
try
{
objvcc_ExamPaperStuRelation4AppEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_ExamPaperStuRelation4AppEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.IdExamPaperStuRelation, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation = objvcc_ExamPaperStuRelation4AppEN.IdExamPaperStuRelation; //流水号
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.CourseExamPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.CourseExamPaperId = objvcc_ExamPaperStuRelation4AppEN.CourseExamPaperId == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.CourseExamPaperId; //考卷流水号
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.IdExamPaperEduClsRela, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.IdExamPaperEduClsRela = objvcc_ExamPaperStuRelation4AppEN.IdExamPaperEduClsRela; //作业教学班关系流水号
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.CourseId = objvcc_ExamPaperStuRelation4AppEN.CourseId == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.CourseName = objvcc_ExamPaperStuRelation4AppEN.CourseName == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.ExamPaperName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.ExamPaperName = objvcc_ExamPaperStuRelation4AppEN.ExamPaperName == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.ExamPaperName; //考卷名称
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.PaperIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.PaperIndex = objvcc_ExamPaperStuRelation4AppEN.PaperIndex; //试卷序号
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.ExamPaperTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeId = objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeId == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeId; //试卷类型Id
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.ExamPaperTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeName = objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeName == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeName; //试卷类型名称
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.ExamCreateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.ExamCreateTime = objvcc_ExamPaperStuRelation4AppEN.ExamCreateTime == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.ExamCreateTime; //考卷建立时间
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.ChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.ChapterId = objvcc_ExamPaperStuRelation4AppEN.ChapterId == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.ChapterId; //章Id
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.SectionId = objvcc_ExamPaperStuRelation4AppEN.SectionId == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.SectionId; //节Id
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.ChapterName = objvcc_ExamPaperStuRelation4AppEN.ChapterName == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.ChapterName; //章名
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.SectionName = objvcc_ExamPaperStuRelation4AppEN.SectionName == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.SectionName; //节名
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.ChapterNameSim = objvcc_ExamPaperStuRelation4AppEN.ChapterNameSim == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.SectionNameSim = objvcc_ExamPaperStuRelation4AppEN.SectionNameSim == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.IsAutoGeneQuestion = objvcc_ExamPaperStuRelation4AppEN.IsAutoGeneQuestion; //是否自动生成题目
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.IsCanMultiDo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.IsCanMultiDo = objvcc_ExamPaperStuRelation4AppEN.IsCanMultiDo; //是否可以做多次
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.EduClsName = objvcc_ExamPaperStuRelation4AppEN.EduClsName == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.TeacherID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.TeacherID = objvcc_ExamPaperStuRelation4AppEN.TeacherID == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.TeacherID; //教师工号
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.PubDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.PubDate = objvcc_ExamPaperStuRelation4AppEN.PubDate == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.PubDate; //发布日期
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.IsCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.IsCurrEduCls = objvcc_ExamPaperStuRelation4AppEN.IsCurrEduCls; //是否为教学班作业
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.WorkTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.WorkTypeName = objvcc_ExamPaperStuRelation4AppEN.WorkTypeName == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.WorkTypeName; //作业类型名称
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.IdCurrEduCls = objvcc_ExamPaperStuRelation4AppEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.Scores, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.Scores = objvcc_ExamPaperStuRelation4AppEN.Scores; //分值
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.SpecifyCompletionDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.SpecifyCompletionDate = objvcc_ExamPaperStuRelation4AppEN.SpecifyCompletionDate; //指定完成日期
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.IdStudentInfo = objvcc_ExamPaperStuRelation4AppEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.StuID, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.StuID = objvcc_ExamPaperStuRelation4AppEN.StuID == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.StuID; //学号
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.StuName = objvcc_ExamPaperStuRelation4AppEN.StuName == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.StuName; //姓名
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.IdXzCollege = objvcc_ExamPaperStuRelation4AppEN.IdXzCollege == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.CollegeName = objvcc_ExamPaperStuRelation4AppEN.CollegeName == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.CollegeNameA = objvcc_ExamPaperStuRelation4AppEN.CollegeNameA == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.IdXzMajor = objvcc_ExamPaperStuRelation4AppEN.IdXzMajor == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.MajorName = objvcc_ExamPaperStuRelation4AppEN.MajorName == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.GradeBaseName = objvcc_ExamPaperStuRelation4AppEN.GradeBaseName == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.AnswerOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.AnswerOptionId = objvcc_ExamPaperStuRelation4AppEN.AnswerOptionId == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.AnswerOptionId; //回答选项Id
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.AnswerMultiOptions, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.AnswerMultiOptions = objvcc_ExamPaperStuRelation4AppEN.AnswerMultiOptions == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.AnswerMultiOptions; //多选项答案
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.StuAnswerText, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.StuAnswerText = objvcc_ExamPaperStuRelation4AppEN.StuAnswerText == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.StuAnswerText; //学生回答文本
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.IsPublish, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.IsPublish = objvcc_ExamPaperStuRelation4AppEN.IsPublish; //是否发布
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.IsSave, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.IsSave = objvcc_ExamPaperStuRelation4AppEN.IsSave; //是否保存
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.IsSubmit = objvcc_ExamPaperStuRelation4AppEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.RealFinishDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.RealFinishDate = objvcc_ExamPaperStuRelation4AppEN.RealFinishDate == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.RealFinishDate; //实际完成日期
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.Score = objvcc_ExamPaperStuRelation4AppEN.Score; //得分
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.Comment, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.Comment = objvcc_ExamPaperStuRelation4AppEN.Comment == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.Comment; //批注
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.IsMarking, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.IsMarking = objvcc_ExamPaperStuRelation4AppEN.IsMarking; //是否批阅
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.MarkerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.MarkerId = objvcc_ExamPaperStuRelation4AppEN.MarkerId == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.MarkerId; //打分者
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.MarkDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.MarkDate = objvcc_ExamPaperStuRelation4AppEN.MarkDate == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.MarkDate; //打分日期
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.IsSendBack, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.IsSendBack = objvcc_ExamPaperStuRelation4AppEN.IsSendBack; //是否退回
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.IsInErrorQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.IsInErrorQuestion = objvcc_ExamPaperStuRelation4AppEN.IsInErrorQuestion; //是否进入错题
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.WorkTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.WorkTypeId = objvcc_ExamPaperStuRelation4AppEN.WorkTypeId == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.WorkTypeId; //作业类型Id
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.AnswerIP, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.AnswerIP = objvcc_ExamPaperStuRelation4AppEN.AnswerIP == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.AnswerIP; //回答IP
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.AnswerDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.AnswerDate = objvcc_ExamPaperStuRelation4AppEN.AnswerDate == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.AnswerDate; //回答日期
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.AnswerTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.AnswerTime = objvcc_ExamPaperStuRelation4AppEN.AnswerTime == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.AnswerTime; //回答时间
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.IsRight, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.IsRight = objvcc_ExamPaperStuRelation4AppEN.IsRight; //是否正确
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.IsNotProcessTimeout, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.IsNotProcessTimeout = objvcc_ExamPaperStuRelation4AppEN.IsNotProcessTimeout; //是否不处理超时
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.UpdDate = objvcc_ExamPaperStuRelation4AppEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.UpdUserId = objvcc_ExamPaperStuRelation4AppEN.UpdUserId == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.Memo = objvcc_ExamPaperStuRelation4AppEN.Memo == "[null]" ? null :  objvcc_ExamPaperStuRelation4AppEN.Memo; //备注
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.NoSubmitBatchNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.NoSubmitBatchNum = objvcc_ExamPaperStuRelation4AppEN.NoSubmitBatchNum; //未提交批次数
}
if (arrFldSet.Contains(convcc_ExamPaperStuRelation4App.SubmitBatchNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_ExamPaperStuRelation4AppEN.SubmitBatchNum = objvcc_ExamPaperStuRelation4AppEN.SubmitBatchNum; //提交批次数
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
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN)
{
try
{
if (objvcc_ExamPaperStuRelation4AppEN.CourseExamPaperId == "[null]") objvcc_ExamPaperStuRelation4AppEN.CourseExamPaperId = null; //考卷流水号
if (objvcc_ExamPaperStuRelation4AppEN.CourseId == "[null]") objvcc_ExamPaperStuRelation4AppEN.CourseId = null; //课程Id
if (objvcc_ExamPaperStuRelation4AppEN.CourseName == "[null]") objvcc_ExamPaperStuRelation4AppEN.CourseName = null; //课程名称
if (objvcc_ExamPaperStuRelation4AppEN.ExamPaperName == "[null]") objvcc_ExamPaperStuRelation4AppEN.ExamPaperName = null; //考卷名称
if (objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeId == "[null]") objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeId = null; //试卷类型Id
if (objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeName == "[null]") objvcc_ExamPaperStuRelation4AppEN.ExamPaperTypeName = null; //试卷类型名称
if (objvcc_ExamPaperStuRelation4AppEN.ExamCreateTime == "[null]") objvcc_ExamPaperStuRelation4AppEN.ExamCreateTime = null; //考卷建立时间
if (objvcc_ExamPaperStuRelation4AppEN.ChapterId == "[null]") objvcc_ExamPaperStuRelation4AppEN.ChapterId = null; //章Id
if (objvcc_ExamPaperStuRelation4AppEN.SectionId == "[null]") objvcc_ExamPaperStuRelation4AppEN.SectionId = null; //节Id
if (objvcc_ExamPaperStuRelation4AppEN.ChapterName == "[null]") objvcc_ExamPaperStuRelation4AppEN.ChapterName = null; //章名
if (objvcc_ExamPaperStuRelation4AppEN.SectionName == "[null]") objvcc_ExamPaperStuRelation4AppEN.SectionName = null; //节名
if (objvcc_ExamPaperStuRelation4AppEN.ChapterNameSim == "[null]") objvcc_ExamPaperStuRelation4AppEN.ChapterNameSim = null; //章名简称
if (objvcc_ExamPaperStuRelation4AppEN.SectionNameSim == "[null]") objvcc_ExamPaperStuRelation4AppEN.SectionNameSim = null; //节名简称
if (objvcc_ExamPaperStuRelation4AppEN.EduClsName == "[null]") objvcc_ExamPaperStuRelation4AppEN.EduClsName = null; //教学班名
if (objvcc_ExamPaperStuRelation4AppEN.TeacherID == "[null]") objvcc_ExamPaperStuRelation4AppEN.TeacherID = null; //教师工号
if (objvcc_ExamPaperStuRelation4AppEN.PubDate == "[null]") objvcc_ExamPaperStuRelation4AppEN.PubDate = null; //发布日期
if (objvcc_ExamPaperStuRelation4AppEN.WorkTypeName == "[null]") objvcc_ExamPaperStuRelation4AppEN.WorkTypeName = null; //作业类型名称
if (objvcc_ExamPaperStuRelation4AppEN.StuID == "[null]") objvcc_ExamPaperStuRelation4AppEN.StuID = null; //学号
if (objvcc_ExamPaperStuRelation4AppEN.StuName == "[null]") objvcc_ExamPaperStuRelation4AppEN.StuName = null; //姓名
if (objvcc_ExamPaperStuRelation4AppEN.IdXzCollege == "[null]") objvcc_ExamPaperStuRelation4AppEN.IdXzCollege = null; //学院流水号
if (objvcc_ExamPaperStuRelation4AppEN.CollegeName == "[null]") objvcc_ExamPaperStuRelation4AppEN.CollegeName = null; //学院名称
if (objvcc_ExamPaperStuRelation4AppEN.CollegeNameA == "[null]") objvcc_ExamPaperStuRelation4AppEN.CollegeNameA = null; //学院名称简写
if (objvcc_ExamPaperStuRelation4AppEN.IdXzMajor == "[null]") objvcc_ExamPaperStuRelation4AppEN.IdXzMajor = null; //专业流水号
if (objvcc_ExamPaperStuRelation4AppEN.MajorName == "[null]") objvcc_ExamPaperStuRelation4AppEN.MajorName = null; //专业名称
if (objvcc_ExamPaperStuRelation4AppEN.GradeBaseName == "[null]") objvcc_ExamPaperStuRelation4AppEN.GradeBaseName = null; //年级名称
if (objvcc_ExamPaperStuRelation4AppEN.AnswerOptionId == "[null]") objvcc_ExamPaperStuRelation4AppEN.AnswerOptionId = null; //回答选项Id
if (objvcc_ExamPaperStuRelation4AppEN.AnswerMultiOptions == "[null]") objvcc_ExamPaperStuRelation4AppEN.AnswerMultiOptions = null; //多选项答案
if (objvcc_ExamPaperStuRelation4AppEN.StuAnswerText == "[null]") objvcc_ExamPaperStuRelation4AppEN.StuAnswerText = null; //学生回答文本
if (objvcc_ExamPaperStuRelation4AppEN.RealFinishDate == "[null]") objvcc_ExamPaperStuRelation4AppEN.RealFinishDate = null; //实际完成日期
if (objvcc_ExamPaperStuRelation4AppEN.Comment == "[null]") objvcc_ExamPaperStuRelation4AppEN.Comment = null; //批注
if (objvcc_ExamPaperStuRelation4AppEN.MarkerId == "[null]") objvcc_ExamPaperStuRelation4AppEN.MarkerId = null; //打分者
if (objvcc_ExamPaperStuRelation4AppEN.MarkDate == "[null]") objvcc_ExamPaperStuRelation4AppEN.MarkDate = null; //打分日期
if (objvcc_ExamPaperStuRelation4AppEN.WorkTypeId == "[null]") objvcc_ExamPaperStuRelation4AppEN.WorkTypeId = null; //作业类型Id
if (objvcc_ExamPaperStuRelation4AppEN.AnswerIP == "[null]") objvcc_ExamPaperStuRelation4AppEN.AnswerIP = null; //回答IP
if (objvcc_ExamPaperStuRelation4AppEN.AnswerDate == "[null]") objvcc_ExamPaperStuRelation4AppEN.AnswerDate = null; //回答日期
if (objvcc_ExamPaperStuRelation4AppEN.AnswerTime == "[null]") objvcc_ExamPaperStuRelation4AppEN.AnswerTime = null; //回答时间
if (objvcc_ExamPaperStuRelation4AppEN.UpdUserId == "[null]") objvcc_ExamPaperStuRelation4AppEN.UpdUserId = null; //修改用户Id
if (objvcc_ExamPaperStuRelation4AppEN.Memo == "[null]") objvcc_ExamPaperStuRelation4AppEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN)
{
 vcc_ExamPaperStuRelation4AppDA.CheckProperty4Condition(objvcc_ExamPaperStuRelation4AppEN);
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
if (clscc_ExamPaperStuRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperStuRelationBL没有刷新缓存机制(clscc_ExamPaperStuRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexBL没有刷新缓存机制(clsSexBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicBL没有刷新缓存机制(clsRsEthnicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsBL没有刷新缓存机制(clsRsPoliticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoBL没有刷新缓存机制(clsStudentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeBL没有刷新缓存机制(clsRsStuTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCurrEduClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsBL没有刷新缓存机制(clsCurrEduClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsWorkTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsWorkTypeBL没有刷新缓存机制(clsWorkTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamPaperEduClsRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperEduClsRelaBL没有刷新缓存机制(clscc_ExamPaperEduClsRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsBL没有刷新缓存机制(clsXzAdminClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeBL没有刷新缓存机制(clsXzAdminClsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
if (clscc_CourseExamPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperBL没有刷新缓存机制(clscc_CourseExamPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_PaperDispModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PaperDispModeBL没有刷新缓存机制(clscc_PaperDispModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamPaperTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperTypeBL没有刷新缓存机制(clscc_ExamPaperTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdExamPaperStuRelation");
//if (arrvcc_ExamPaperStuRelation4AppObjLstCache == null)
//{
//arrvcc_ExamPaperStuRelation4AppObjLstCache = vcc_ExamPaperStuRelation4AppDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdExamPaperStuRelation">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_ExamPaperStuRelation4AppEN GetObjByIdExamPaperStuRelationCache(long lngIdExamPaperStuRelation, string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuRelation4AppEN._CurrTabName, strIdCurrEduCls);
List<clsvcc_ExamPaperStuRelation4AppEN> arrvcc_ExamPaperStuRelation4AppObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvcc_ExamPaperStuRelation4AppEN> arrvcc_ExamPaperStuRelation4AppObjLst_Sel =
arrvcc_ExamPaperStuRelation4AppObjLstCache
.Where(x=> x.IdExamPaperStuRelation == lngIdExamPaperStuRelation 
);
if (arrvcc_ExamPaperStuRelation4AppObjLst_Sel.Count() == 0)
{
   clsvcc_ExamPaperStuRelation4AppEN obj = clsvcc_ExamPaperStuRelation4AppBL.GetObjByIdExamPaperStuRelation(lngIdExamPaperStuRelation);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngIdExamPaperStuRelation, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvcc_ExamPaperStuRelation4AppObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetAllvcc_ExamPaperStuRelation4AppObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvcc_ExamPaperStuRelation4AppEN> arrvcc_ExamPaperStuRelation4AppObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvcc_ExamPaperStuRelation4AppObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetObjLstCache(string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuRelation4AppEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvcc_ExamPaperStuRelation4AppEN> arrvcc_ExamPaperStuRelation4AppObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvcc_ExamPaperStuRelation4AppObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strIdCurrEduCls = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuRelation4AppEN._CurrTabName, strIdCurrEduCls);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngIdExamPaperStuRelation, string strIdCurrEduCls)
{
if (strInFldName != convcc_ExamPaperStuRelation4App.IdExamPaperStuRelation)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_ExamPaperStuRelation4App.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_ExamPaperStuRelation4App.AttributeName));
throw new Exception(strMsg);
}
var objvcc_ExamPaperStuRelation4App = clsvcc_ExamPaperStuRelation4AppBL.GetObjByIdExamPaperStuRelationCache(lngIdExamPaperStuRelation, strIdCurrEduCls);
if (objvcc_ExamPaperStuRelation4App == null) return "";
return objvcc_ExamPaperStuRelation4App[strOutFldName].ToString();
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
int intRecCount = clsvcc_ExamPaperStuRelation4AppDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_ExamPaperStuRelation4AppDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_ExamPaperStuRelation4AppDA.GetRecCount();
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
int intRecCount = clsvcc_ExamPaperStuRelation4AppDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppCond)
{
 string strIdCurrEduCls = objvcc_ExamPaperStuRelation4AppCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvcc_ExamPaperStuRelation4AppBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvcc_ExamPaperStuRelation4AppEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_ExamPaperStuRelation4App.AttributeName)
{
if (objvcc_ExamPaperStuRelation4AppCond.IsUpdated(strFldName) == false) continue;
if (objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_ExamPaperStuRelation4AppCond[strFldName].ToString());
}
else
{
if (objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_ExamPaperStuRelation4AppCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_ExamPaperStuRelation4AppCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_ExamPaperStuRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_ExamPaperStuRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_ExamPaperStuRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_ExamPaperStuRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_ExamPaperStuRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_ExamPaperStuRelation4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_ExamPaperStuRelation4AppCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_ExamPaperStuRelation4AppCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_ExamPaperStuRelation4AppCond[strFldName]));
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
 List<string> arrList = clsvcc_ExamPaperStuRelation4AppDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_ExamPaperStuRelation4AppDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_ExamPaperStuRelation4AppDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}