
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_ExamPaperStuRelation4AppWApi
 表名:vcc_ExamPaperStuRelation4App(01120255)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:09
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理
 模块英文名:InteractManage
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
public static class clsvcc_ExamPaperStuRelation4AppWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetId_ExamPaperStuRelation(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, long lngId_ExamPaperStuRelation, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.Id_ExamPaperStuRelation = lngId_ExamPaperStuRelation; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.Id_ExamPaperStuRelation) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.Id_ExamPaperStuRelation, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.Id_ExamPaperStuRelation] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetCourseExamPaperId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_ExamPaperStuRelation4App.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_ExamPaperStuRelation4App.CourseExamPaperId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetId_ExamPaperEduClsRela(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, long lngId_ExamPaperEduClsRela, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelation4AppEN.Id_ExamPaperEduClsRela = lngId_ExamPaperEduClsRela; //作业教学班关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.Id_ExamPaperEduClsRela) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.Id_ExamPaperEduClsRela, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.Id_ExamPaperEduClsRela] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetCourseId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_ExamPaperStuRelation4App.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_ExamPaperStuRelation4App.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetCourseName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_ExamPaperStuRelation4App.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetExamPaperName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strExamPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_ExamPaperStuRelation4App.ExamPaperName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetPaperIndex(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, int intPaperIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetExamPaperTypeId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strExamPaperTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, convcc_ExamPaperStuRelation4App.ExamPaperTypeId);
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, convcc_ExamPaperStuRelation4App.ExamPaperTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetExamPaperTypeName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strExamPaperTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperTypeName, 30, convcc_ExamPaperStuRelation4App.ExamPaperTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetExamCreateTime(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strExamCreateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamCreateTime, 14, convcc_ExamPaperStuRelation4App.ExamCreateTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetChapterId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_ExamPaperStuRelation4App.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_ExamPaperStuRelation4App.ChapterId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetSectionId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_ExamPaperStuRelation4App.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_ExamPaperStuRelation4App.SectionId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetChapterName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_ExamPaperStuRelation4App.ChapterName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetSectionName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_ExamPaperStuRelation4App.SectionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetChapterName_Sim(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_ExamPaperStuRelation4App.ChapterName_Sim);
objvcc_ExamPaperStuRelation4AppEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.ChapterName_Sim) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetSectionName_Sim(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_ExamPaperStuRelation4App.SectionName_Sim);
objvcc_ExamPaperStuRelation4AppEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.SectionName_Sim) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetCurrEduClsId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convcc_ExamPaperStuRelation4App.CurrEduClsId);
objvcc_ExamPaperStuRelation4AppEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.CurrEduClsId) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.CurrEduClsId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.CurrEduClsId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetEduClsName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_ExamPaperStuRelation4App.EduClsName);
objvcc_ExamPaperStuRelation4AppEN.EduClsName = strEduClsName; //教学班名称
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetTeacherID(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherID, 12, convcc_ExamPaperStuRelation4App.TeacherID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetPubDate(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strPubDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubDate, 14, convcc_ExamPaperStuRelation4App.PubDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetWorkTypeName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strWorkTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWorkTypeName, 30, convcc_ExamPaperStuRelation4App.WorkTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN Setid_CurrEduCls(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, convcc_ExamPaperStuRelation4App.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convcc_ExamPaperStuRelation4App.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convcc_ExamPaperStuRelation4App.id_CurrEduCls);
objvcc_ExamPaperStuRelation4AppEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.id_CurrEduCls) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.id_CurrEduCls, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.id_CurrEduCls] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetScores(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, double dblScores, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetSpecifyCompletionDate(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strSpecifyCompletionDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSpecifyCompletionDate, convcc_ExamPaperStuRelation4App.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(strSpecifyCompletionDate, 14, convcc_ExamPaperStuRelation4App.SpecifyCompletionDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN Setid_StudentInfo(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, convcc_ExamPaperStuRelation4App.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convcc_ExamPaperStuRelation4App.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convcc_ExamPaperStuRelation4App.id_StudentInfo);
objvcc_ExamPaperStuRelation4AppEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.id_StudentInfo) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.id_StudentInfo, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.id_StudentInfo] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetStuID(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_ExamPaperStuRelation4App.StuID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetStuName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_ExamPaperStuRelation4App.StuName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN Setid_XzCollege(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convcc_ExamPaperStuRelation4App.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convcc_ExamPaperStuRelation4App.id_XzCollege);
objvcc_ExamPaperStuRelation4AppEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.id_XzCollege) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.id_XzCollege, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.id_XzCollege] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetCollegeName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_ExamPaperStuRelation4App.CollegeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetCollegeNameA(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_ExamPaperStuRelation4App.CollegeNameA);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN Setid_XzMajor(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convcc_ExamPaperStuRelation4App.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convcc_ExamPaperStuRelation4App.id_XzMajor);
objvcc_ExamPaperStuRelation4AppEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.id_XzMajor) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.id_XzMajor, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.id_XzMajor] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetMajorName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_ExamPaperStuRelation4App.MajorName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetGradeBaseName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convcc_ExamPaperStuRelation4App.GradeBaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetAdminClsName(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convcc_ExamPaperStuRelation4App.AdminClsName);
objvcc_ExamPaperStuRelation4AppEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation4App.AdminClsName) == false)
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation4App.AdminClsName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelation4AppEN.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.AdminClsName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelation4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetAnswerOptionId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strAnswerOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, convcc_ExamPaperStuRelation4App.AnswerOptionId);
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, convcc_ExamPaperStuRelation4App.AnswerOptionId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetAnswerMultiOptions(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strAnswerMultiOptions, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerMultiOptions, 300, convcc_ExamPaperStuRelation4App.AnswerMultiOptions);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetRealFinishDate(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strRealFinishDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, convcc_ExamPaperStuRelation4App.RealFinishDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetScore(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, double dblScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetMarkerId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strMarkerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkerId, 20, convcc_ExamPaperStuRelation4App.MarkerId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetMarkDate(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strMarkDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkDate, 14, convcc_ExamPaperStuRelation4App.MarkDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetWorkTypeId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strWorkTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, convcc_ExamPaperStuRelation4App.WorkTypeId);
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, convcc_ExamPaperStuRelation4App.WorkTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetAnswerIP(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strAnswerIP, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, convcc_ExamPaperStuRelation4App.AnswerIP);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetAnswerDate(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strAnswerDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, convcc_ExamPaperStuRelation4App.AnswerDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetAnswerTime(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strAnswerTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, convcc_ExamPaperStuRelation4App.AnswerTime);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetUpdDate(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_ExamPaperStuRelation4App.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_ExamPaperStuRelation4App.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetUpdUserId(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_ExamPaperStuRelation4App.UpdUserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetMemo(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_ExamPaperStuRelation4App.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetNoSubmitBatchNum(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, int intNoSubmitBatchNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelation4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelation4AppEN SetSubmitBatchNum(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN, int intSubmitBatchNum, string strComparisonOp="")
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4App_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.Id_ExamPaperStuRelation) == true)
{
string strComparisonOp_Id_ExamPaperStuRelation = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.Id_ExamPaperStuRelation];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation4App.Id_ExamPaperStuRelation, objvcc_ExamPaperStuRelation4App_Cond.Id_ExamPaperStuRelation, strComparisonOp_Id_ExamPaperStuRelation);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.CourseExamPaperId, objvcc_ExamPaperStuRelation4App_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.Id_ExamPaperEduClsRela) == true)
{
string strComparisonOp_Id_ExamPaperEduClsRela = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.Id_ExamPaperEduClsRela];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation4App.Id_ExamPaperEduClsRela, objvcc_ExamPaperStuRelation4App_Cond.Id_ExamPaperEduClsRela, strComparisonOp_Id_ExamPaperEduClsRela);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.CourseId, objvcc_ExamPaperStuRelation4App_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.CourseName, objvcc_ExamPaperStuRelation4App_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.ExamPaperName) == true)
{
string strComparisonOp_ExamPaperName = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.ExamPaperName, objvcc_ExamPaperStuRelation4App_Cond.ExamPaperName, strComparisonOp_ExamPaperName);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.PaperIndex) == true)
{
string strComparisonOp_PaperIndex = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.PaperIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation4App.PaperIndex, objvcc_ExamPaperStuRelation4App_Cond.PaperIndex, strComparisonOp_PaperIndex);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.ExamPaperTypeId) == true)
{
string strComparisonOp_ExamPaperTypeId = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.ExamPaperTypeId, objvcc_ExamPaperStuRelation4App_Cond.ExamPaperTypeId, strComparisonOp_ExamPaperTypeId);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.ExamPaperTypeName) == true)
{
string strComparisonOp_ExamPaperTypeName = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ExamPaperTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.ExamPaperTypeName, objvcc_ExamPaperStuRelation4App_Cond.ExamPaperTypeName, strComparisonOp_ExamPaperTypeName);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.ExamCreateTime) == true)
{
string strComparisonOp_ExamCreateTime = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ExamCreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.ExamCreateTime, objvcc_ExamPaperStuRelation4App_Cond.ExamCreateTime, strComparisonOp_ExamCreateTime);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.ChapterId, objvcc_ExamPaperStuRelation4App_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.SectionId) == true)
{
string strComparisonOp_SectionId = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.SectionId, objvcc_ExamPaperStuRelation4App_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.ChapterName, objvcc_ExamPaperStuRelation4App_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.SectionName, objvcc_ExamPaperStuRelation4App_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.ChapterName_Sim, objvcc_ExamPaperStuRelation4App_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.SectionName_Sim, objvcc_ExamPaperStuRelation4App_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion) == true)
{
if (objvcc_ExamPaperStuRelation4App_Cond.IsAutoGeneQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion);
}
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.IsCanMultiDo) == true)
{
if (objvcc_ExamPaperStuRelation4App_Cond.IsCanMultiDo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsCanMultiDo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsCanMultiDo);
}
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.CurrEduClsId, objvcc_ExamPaperStuRelation4App_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.EduClsName, objvcc_ExamPaperStuRelation4App_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.TeacherID, objvcc_ExamPaperStuRelation4App_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.PubDate) == true)
{
string strComparisonOp_PubDate = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.PubDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.PubDate, objvcc_ExamPaperStuRelation4App_Cond.PubDate, strComparisonOp_PubDate);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.IsCurrEduCls) == true)
{
if (objvcc_ExamPaperStuRelation4App_Cond.IsCurrEduCls == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsCurrEduCls);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsCurrEduCls);
}
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.WorkTypeName) == true)
{
string strComparisonOp_WorkTypeName = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.WorkTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.WorkTypeName, objvcc_ExamPaperStuRelation4App_Cond.WorkTypeName, strComparisonOp_WorkTypeName);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.id_CurrEduCls, objvcc_ExamPaperStuRelation4App_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.Scores) == true)
{
string strComparisonOp_Scores = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation4App.Scores, objvcc_ExamPaperStuRelation4App_Cond.Scores, strComparisonOp_Scores);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.SpecifyCompletionDate) == true)
{
string strComparisonOp_SpecifyCompletionDate = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.SpecifyCompletionDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.SpecifyCompletionDate, objvcc_ExamPaperStuRelation4App_Cond.SpecifyCompletionDate, strComparisonOp_SpecifyCompletionDate);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.id_StudentInfo, objvcc_ExamPaperStuRelation4App_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.StuID) == true)
{
string strComparisonOp_StuID = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.StuID, objvcc_ExamPaperStuRelation4App_Cond.StuID, strComparisonOp_StuID);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.StuName) == true)
{
string strComparisonOp_StuName = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.StuName, objvcc_ExamPaperStuRelation4App_Cond.StuName, strComparisonOp_StuName);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.id_XzCollege, objvcc_ExamPaperStuRelation4App_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.CollegeName, objvcc_ExamPaperStuRelation4App_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.CollegeNameA, objvcc_ExamPaperStuRelation4App_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.id_XzMajor, objvcc_ExamPaperStuRelation4App_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.MajorName) == true)
{
string strComparisonOp_MajorName = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.MajorName, objvcc_ExamPaperStuRelation4App_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.GradeBaseName, objvcc_ExamPaperStuRelation4App_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.AdminClsName, objvcc_ExamPaperStuRelation4App_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.AnswerOptionId) == true)
{
string strComparisonOp_AnswerOptionId = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.AnswerOptionId, objvcc_ExamPaperStuRelation4App_Cond.AnswerOptionId, strComparisonOp_AnswerOptionId);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.AnswerMultiOptions) == true)
{
string strComparisonOp_AnswerMultiOptions = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.AnswerMultiOptions];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.AnswerMultiOptions, objvcc_ExamPaperStuRelation4App_Cond.AnswerMultiOptions, strComparisonOp_AnswerMultiOptions);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.IsPublish) == true)
{
if (objvcc_ExamPaperStuRelation4App_Cond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsPublish);
}
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.IsSave) == true)
{
if (objvcc_ExamPaperStuRelation4App_Cond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsSave);
}
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.IsSubmit) == true)
{
if (objvcc_ExamPaperStuRelation4App_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsSubmit);
}
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.RealFinishDate) == true)
{
string strComparisonOp_RealFinishDate = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.RealFinishDate, objvcc_ExamPaperStuRelation4App_Cond.RealFinishDate, strComparisonOp_RealFinishDate);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.Score) == true)
{
string strComparisonOp_Score = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation4App.Score, objvcc_ExamPaperStuRelation4App_Cond.Score, strComparisonOp_Score);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.IsMarking) == true)
{
if (objvcc_ExamPaperStuRelation4App_Cond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsMarking);
}
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.MarkerId) == true)
{
string strComparisonOp_MarkerId = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.MarkerId, objvcc_ExamPaperStuRelation4App_Cond.MarkerId, strComparisonOp_MarkerId);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.MarkDate) == true)
{
string strComparisonOp_MarkDate = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.MarkDate, objvcc_ExamPaperStuRelation4App_Cond.MarkDate, strComparisonOp_MarkDate);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.IsSendBack) == true)
{
if (objvcc_ExamPaperStuRelation4App_Cond.IsSendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsSendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsSendBack);
}
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.IsInErrorQuestion) == true)
{
if (objvcc_ExamPaperStuRelation4App_Cond.IsInErrorQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsInErrorQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsInErrorQuestion);
}
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.WorkTypeId) == true)
{
string strComparisonOp_WorkTypeId = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.WorkTypeId, objvcc_ExamPaperStuRelation4App_Cond.WorkTypeId, strComparisonOp_WorkTypeId);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.AnswerIP) == true)
{
string strComparisonOp_AnswerIP = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.AnswerIP, objvcc_ExamPaperStuRelation4App_Cond.AnswerIP, strComparisonOp_AnswerIP);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.AnswerDate) == true)
{
string strComparisonOp_AnswerDate = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.AnswerDate, objvcc_ExamPaperStuRelation4App_Cond.AnswerDate, strComparisonOp_AnswerDate);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.AnswerTime) == true)
{
string strComparisonOp_AnswerTime = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.AnswerTime, objvcc_ExamPaperStuRelation4App_Cond.AnswerTime, strComparisonOp_AnswerTime);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.IsRight) == true)
{
if (objvcc_ExamPaperStuRelation4App_Cond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsRight);
}
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.IsNotProcessTimeout) == true)
{
if (objvcc_ExamPaperStuRelation4App_Cond.IsNotProcessTimeout == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation4App.IsNotProcessTimeout);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation4App.IsNotProcessTimeout);
}
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.UpdDate, objvcc_ExamPaperStuRelation4App_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.UpdUserId, objvcc_ExamPaperStuRelation4App_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.Memo) == true)
{
string strComparisonOp_Memo = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation4App.Memo, objvcc_ExamPaperStuRelation4App_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.NoSubmitBatchNum) == true)
{
string strComparisonOp_NoSubmitBatchNum = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation4App.NoSubmitBatchNum, objvcc_ExamPaperStuRelation4App_Cond.NoSubmitBatchNum, strComparisonOp_NoSubmitBatchNum);
}
if (objvcc_ExamPaperStuRelation4App_Cond.IsUpdated(convcc_ExamPaperStuRelation4App.SubmitBatchNum) == true)
{
string strComparisonOp_SubmitBatchNum = objvcc_ExamPaperStuRelation4App_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation4App.SubmitBatchNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation4App.SubmitBatchNum, objvcc_ExamPaperStuRelation4App_Cond.SubmitBatchNum, strComparisonOp_SubmitBatchNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v考卷与学生关系表4App(vcc_ExamPaperStuRelation4App)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_ExamPaperStuRelation4AppWApi
{
private static readonly string mstrApiControllerName = "vcc_ExamPaperStuRelation4AppApi";

 public clsvcc_ExamPaperStuRelation4AppWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_ExamPaperStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExamPaperStuRelation4AppEN GetObjById_ExamPaperStuRelation(long lngId_ExamPaperStuRelation)
{
string strAction = "GetObjById_ExamPaperStuRelation";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ExamPaperStuRelation"] = lngId_ExamPaperStuRelation.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_ExamPaperStuRelation4AppEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperStuRelation4AppEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperStuRelation4AppEN;
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
 /// <param name = "lngId_ExamPaperStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExamPaperStuRelation4AppEN GetObjById_ExamPaperStuRelation_WA_Cache(long lngId_ExamPaperStuRelation, string strid_CurrEduCls)
{
string strAction = "GetObjById_ExamPaperStuRelation_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ExamPaperStuRelation"] = lngId_ExamPaperStuRelation.ToString(),
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_ExamPaperStuRelation4AppEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperStuRelation4AppEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperStuRelation4AppEN;
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
public static clsvcc_ExamPaperStuRelation4AppEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppEN = null;
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
objvcc_ExamPaperStuRelation4AppEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperStuRelation4AppEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperStuRelation4AppEN;
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
 /// <param name = "lngId_ExamPaperStuRelation">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_ExamPaperStuRelation4AppEN GetObjById_ExamPaperStuRelation_Cache(long lngId_ExamPaperStuRelation, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuRelation4AppEN._CurrTabName_S, strid_CurrEduCls);
List<clsvcc_ExamPaperStuRelation4AppEN> arrvcc_ExamPaperStuRelation4AppObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsvcc_ExamPaperStuRelation4AppEN> arrvcc_ExamPaperStuRelation4AppObjLst_Sel =
from objvcc_ExamPaperStuRelation4AppEN in arrvcc_ExamPaperStuRelation4AppObjLst_Cache
where objvcc_ExamPaperStuRelation4AppEN.Id_ExamPaperStuRelation == lngId_ExamPaperStuRelation
select objvcc_ExamPaperStuRelation4AppEN;
if (arrvcc_ExamPaperStuRelation4AppObjLst_Sel.Count() == 0)
{
   clsvcc_ExamPaperStuRelation4AppEN obj = clsvcc_ExamPaperStuRelation4AppWApi.GetObjById_ExamPaperStuRelation(lngId_ExamPaperStuRelation);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_ExamPaperStuRelation4AppObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetObjLstById_ExamPaperStuRelationLst(List<long> arrId_ExamPaperStuRelation)
{
 List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = null; 
string strAction = "GetObjLstById_ExamPaperStuRelationLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ExamPaperStuRelation);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_ExamPaperStuRelation">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_ExamPaperStuRelation4AppEN> GetObjLstById_ExamPaperStuRelationLst_Cache(List<long> arrId_ExamPaperStuRelation, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuRelation4AppEN._CurrTabName_S, strid_CurrEduCls);
List<clsvcc_ExamPaperStuRelation4AppEN> arrvcc_ExamPaperStuRelation4AppObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsvcc_ExamPaperStuRelation4AppEN> arrvcc_ExamPaperStuRelation4AppObjLst_Sel =
from objvcc_ExamPaperStuRelation4AppEN in arrvcc_ExamPaperStuRelation4AppObjLst_Cache
where arrId_ExamPaperStuRelation.Contains(objvcc_ExamPaperStuRelation4AppEN.Id_ExamPaperStuRelation)
select objvcc_ExamPaperStuRelation4AppEN;
return arrvcc_ExamPaperStuRelation4AppObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetObjLstById_ExamPaperStuRelationLst_WA_Cache(List<long> arrId_ExamPaperStuRelation, string strid_CurrEduCls)
{
 List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = null; 
string strAction = "GetObjLstById_ExamPaperStuRelationLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ExamPaperStuRelation);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuRelation4AppEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngId_ExamPaperStuRelation)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ExamPaperStuRelation"] = lngId_ExamPaperStuRelation.ToString()
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
 /// <param name = "objvcc_ExamPaperStuRelation4AppENS">源对象</param>
 /// <param name = "objvcc_ExamPaperStuRelation4AppENT">目标对象</param>
 public static void CopyTo(clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppENS, clsvcc_ExamPaperStuRelation4AppEN objvcc_ExamPaperStuRelation4AppENT)
{
try
{
objvcc_ExamPaperStuRelation4AppENT.Id_ExamPaperStuRelation = objvcc_ExamPaperStuRelation4AppENS.Id_ExamPaperStuRelation; //流水号
objvcc_ExamPaperStuRelation4AppENT.CourseExamPaperId = objvcc_ExamPaperStuRelation4AppENS.CourseExamPaperId; //考卷流水号
objvcc_ExamPaperStuRelation4AppENT.Id_ExamPaperEduClsRela = objvcc_ExamPaperStuRelation4AppENS.Id_ExamPaperEduClsRela; //作业教学班关系流水号
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
objvcc_ExamPaperStuRelation4AppENT.ChapterName_Sim = objvcc_ExamPaperStuRelation4AppENS.ChapterName_Sim; //章名简称
objvcc_ExamPaperStuRelation4AppENT.SectionName_Sim = objvcc_ExamPaperStuRelation4AppENS.SectionName_Sim; //节名简称
objvcc_ExamPaperStuRelation4AppENT.IsAutoGeneQuestion = objvcc_ExamPaperStuRelation4AppENS.IsAutoGeneQuestion; //是否自动生成题目
objvcc_ExamPaperStuRelation4AppENT.IsCanMultiDo = objvcc_ExamPaperStuRelation4AppENS.IsCanMultiDo; //是否可以做多次
objvcc_ExamPaperStuRelation4AppENT.CurrEduClsId = objvcc_ExamPaperStuRelation4AppENS.CurrEduClsId; //当前教学班Id
objvcc_ExamPaperStuRelation4AppENT.EduClsName = objvcc_ExamPaperStuRelation4AppENS.EduClsName; //教学班名称
objvcc_ExamPaperStuRelation4AppENT.TeacherID = objvcc_ExamPaperStuRelation4AppENS.TeacherID; //教师工号
objvcc_ExamPaperStuRelation4AppENT.PubDate = objvcc_ExamPaperStuRelation4AppENS.PubDate; //发布日期
objvcc_ExamPaperStuRelation4AppENT.IsCurrEduCls = objvcc_ExamPaperStuRelation4AppENS.IsCurrEduCls; //是否为教学班作业
objvcc_ExamPaperStuRelation4AppENT.WorkTypeName = objvcc_ExamPaperStuRelation4AppENS.WorkTypeName; //作业类型名称
objvcc_ExamPaperStuRelation4AppENT.id_CurrEduCls = objvcc_ExamPaperStuRelation4AppENS.id_CurrEduCls; //当前教学班流水号
objvcc_ExamPaperStuRelation4AppENT.Scores = objvcc_ExamPaperStuRelation4AppENS.Scores; //分值
objvcc_ExamPaperStuRelation4AppENT.SpecifyCompletionDate = objvcc_ExamPaperStuRelation4AppENS.SpecifyCompletionDate; //指定完成日期
objvcc_ExamPaperStuRelation4AppENT.id_StudentInfo = objvcc_ExamPaperStuRelation4AppENS.id_StudentInfo; //学生流水号
objvcc_ExamPaperStuRelation4AppENT.StuID = objvcc_ExamPaperStuRelation4AppENS.StuID; //学号
objvcc_ExamPaperStuRelation4AppENT.StuName = objvcc_ExamPaperStuRelation4AppENS.StuName; //姓名
objvcc_ExamPaperStuRelation4AppENT.id_XzCollege = objvcc_ExamPaperStuRelation4AppENS.id_XzCollege; //学院流水号
objvcc_ExamPaperStuRelation4AppENT.CollegeName = objvcc_ExamPaperStuRelation4AppENS.CollegeName; //学院名称
objvcc_ExamPaperStuRelation4AppENT.CollegeNameA = objvcc_ExamPaperStuRelation4AppENS.CollegeNameA; //学院名称简写
objvcc_ExamPaperStuRelation4AppENT.id_XzMajor = objvcc_ExamPaperStuRelation4AppENS.id_XzMajor; //专业流水号
objvcc_ExamPaperStuRelation4AppENT.MajorName = objvcc_ExamPaperStuRelation4AppENS.MajorName; //专业名称
objvcc_ExamPaperStuRelation4AppENT.GradeBaseName = objvcc_ExamPaperStuRelation4AppENS.GradeBaseName; //年级名称
objvcc_ExamPaperStuRelation4AppENT.AdminClsName = objvcc_ExamPaperStuRelation4AppENS.AdminClsName; //行政班名称
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
public static DataTable ToDataTable(List<clsvcc_ExamPaperStuRelation4AppEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_ExamPaperStuRelation4AppEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_ExamPaperStuRelation4AppEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_ExamPaperStuRelation4AppEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_ExamPaperStuRelation4AppEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_ExamPaperStuRelation4AppEN.AttributeName)
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
if (clscc_ExamPaperStuRelationWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperStuRelationWApi没有刷新缓存机制(clscc_ExamPaperStuRelationWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoWApi没有刷新缓存机制(clsStudentInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeWApi没有刷新缓存机制(clsRsStuTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCurrEduClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsWApi没有刷新缓存机制(clsCurrEduClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsWorkTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsWorkTypeWApi没有刷新缓存机制(clsWorkTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamPaperEduClsRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperEduClsRelaWApi没有刷新缓存机制(clscc_ExamPaperEduClsRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsWApi没有刷新缓存机制(clsXzAdminClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeWApi没有刷新缓存机制(clsXzAdminClsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseExamPaperWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperWApi没有刷新缓存机制(clscc_CourseExamPaperWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_PaperDispModeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PaperDispModeWApi没有刷新缓存机制(clscc_PaperDispModeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamPaperTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperTypeWApi没有刷新缓存机制(clscc_ExamPaperTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by Id_ExamPaperStuRelation");
//if (arrvcc_ExamPaperStuRelation4AppObjLst_Cache == null)
//{
//arrvcc_ExamPaperStuRelation4AppObjLst_Cache = await clsvcc_ExamPaperStuRelation4AppWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strid_CurrEduCls = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuRelation4AppEN._CurrTabName_S, strid_CurrEduCls);
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
public static List<clsvcc_ExamPaperStuRelation4AppEN> GetObjLst_Cache(string strid_CurrEduCls)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuRelation4AppEN._CurrTabName_S, strid_CurrEduCls);
List<clsvcc_ExamPaperStuRelation4AppEN> arrvcc_ExamPaperStuRelation4AppObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("id_CurrEduCls='{0}'", strid_CurrEduCls)); });
return arrvcc_ExamPaperStuRelation4AppObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_ExamPaperStuRelation4AppEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.Id_ExamPaperStuRelation, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.Id_ExamPaperEduClsRela, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.ExamPaperName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.PaperIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.ExamPaperTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.ExamPaperTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.ExamCreateTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.IsCanMultiDo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.PubDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.IsCurrEduCls, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.WorkTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.SpecifyCompletionDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.AnswerOptionId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.AnswerMultiOptions, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.StuAnswerText, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.IsPublish, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.IsSave, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.RealFinishDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.Comment, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.IsMarking, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.MarkerId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.MarkDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.IsSendBack, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.IsInErrorQuestion, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.WorkTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.AnswerIP, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.AnswerDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.AnswerTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.IsRight, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.IsNotProcessTimeout, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.NoSubmitBatchNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperStuRelation4App.SubmitBatchNum, Type.GetType("System.Int32"));
foreach (clsvcc_ExamPaperStuRelation4AppEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_ExamPaperStuRelation4App.Id_ExamPaperStuRelation] = objInFor[convcc_ExamPaperStuRelation4App.Id_ExamPaperStuRelation];
objDR[convcc_ExamPaperStuRelation4App.CourseExamPaperId] = objInFor[convcc_ExamPaperStuRelation4App.CourseExamPaperId];
objDR[convcc_ExamPaperStuRelation4App.Id_ExamPaperEduClsRela] = objInFor[convcc_ExamPaperStuRelation4App.Id_ExamPaperEduClsRela];
objDR[convcc_ExamPaperStuRelation4App.CourseId] = objInFor[convcc_ExamPaperStuRelation4App.CourseId];
objDR[convcc_ExamPaperStuRelation4App.CourseName] = objInFor[convcc_ExamPaperStuRelation4App.CourseName];
objDR[convcc_ExamPaperStuRelation4App.ExamPaperName] = objInFor[convcc_ExamPaperStuRelation4App.ExamPaperName];
objDR[convcc_ExamPaperStuRelation4App.PaperIndex] = objInFor[convcc_ExamPaperStuRelation4App.PaperIndex];
objDR[convcc_ExamPaperStuRelation4App.ExamPaperTypeId] = objInFor[convcc_ExamPaperStuRelation4App.ExamPaperTypeId];
objDR[convcc_ExamPaperStuRelation4App.ExamPaperTypeName] = objInFor[convcc_ExamPaperStuRelation4App.ExamPaperTypeName];
objDR[convcc_ExamPaperStuRelation4App.ExamCreateTime] = objInFor[convcc_ExamPaperStuRelation4App.ExamCreateTime];
objDR[convcc_ExamPaperStuRelation4App.ChapterId] = objInFor[convcc_ExamPaperStuRelation4App.ChapterId];
objDR[convcc_ExamPaperStuRelation4App.SectionId] = objInFor[convcc_ExamPaperStuRelation4App.SectionId];
objDR[convcc_ExamPaperStuRelation4App.ChapterName] = objInFor[convcc_ExamPaperStuRelation4App.ChapterName];
objDR[convcc_ExamPaperStuRelation4App.SectionName] = objInFor[convcc_ExamPaperStuRelation4App.SectionName];
objDR[convcc_ExamPaperStuRelation4App.ChapterName_Sim] = objInFor[convcc_ExamPaperStuRelation4App.ChapterName_Sim];
objDR[convcc_ExamPaperStuRelation4App.SectionName_Sim] = objInFor[convcc_ExamPaperStuRelation4App.SectionName_Sim];
objDR[convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion] = objInFor[convcc_ExamPaperStuRelation4App.IsAutoGeneQuestion];
objDR[convcc_ExamPaperStuRelation4App.IsCanMultiDo] = objInFor[convcc_ExamPaperStuRelation4App.IsCanMultiDo];
objDR[convcc_ExamPaperStuRelation4App.CurrEduClsId] = objInFor[convcc_ExamPaperStuRelation4App.CurrEduClsId];
objDR[convcc_ExamPaperStuRelation4App.EduClsName] = objInFor[convcc_ExamPaperStuRelation4App.EduClsName];
objDR[convcc_ExamPaperStuRelation4App.TeacherID] = objInFor[convcc_ExamPaperStuRelation4App.TeacherID];
objDR[convcc_ExamPaperStuRelation4App.PubDate] = objInFor[convcc_ExamPaperStuRelation4App.PubDate];
objDR[convcc_ExamPaperStuRelation4App.IsCurrEduCls] = objInFor[convcc_ExamPaperStuRelation4App.IsCurrEduCls];
objDR[convcc_ExamPaperStuRelation4App.WorkTypeName] = objInFor[convcc_ExamPaperStuRelation4App.WorkTypeName];
objDR[convcc_ExamPaperStuRelation4App.id_CurrEduCls] = objInFor[convcc_ExamPaperStuRelation4App.id_CurrEduCls];
objDR[convcc_ExamPaperStuRelation4App.Scores] = objInFor[convcc_ExamPaperStuRelation4App.Scores];
objDR[convcc_ExamPaperStuRelation4App.SpecifyCompletionDate] = objInFor[convcc_ExamPaperStuRelation4App.SpecifyCompletionDate];
objDR[convcc_ExamPaperStuRelation4App.id_StudentInfo] = objInFor[convcc_ExamPaperStuRelation4App.id_StudentInfo];
objDR[convcc_ExamPaperStuRelation4App.StuID] = objInFor[convcc_ExamPaperStuRelation4App.StuID];
objDR[convcc_ExamPaperStuRelation4App.StuName] = objInFor[convcc_ExamPaperStuRelation4App.StuName];
objDR[convcc_ExamPaperStuRelation4App.id_XzCollege] = objInFor[convcc_ExamPaperStuRelation4App.id_XzCollege];
objDR[convcc_ExamPaperStuRelation4App.CollegeName] = objInFor[convcc_ExamPaperStuRelation4App.CollegeName];
objDR[convcc_ExamPaperStuRelation4App.CollegeNameA] = objInFor[convcc_ExamPaperStuRelation4App.CollegeNameA];
objDR[convcc_ExamPaperStuRelation4App.id_XzMajor] = objInFor[convcc_ExamPaperStuRelation4App.id_XzMajor];
objDR[convcc_ExamPaperStuRelation4App.MajorName] = objInFor[convcc_ExamPaperStuRelation4App.MajorName];
objDR[convcc_ExamPaperStuRelation4App.GradeBaseName] = objInFor[convcc_ExamPaperStuRelation4App.GradeBaseName];
objDR[convcc_ExamPaperStuRelation4App.AdminClsName] = objInFor[convcc_ExamPaperStuRelation4App.AdminClsName];
objDR[convcc_ExamPaperStuRelation4App.AnswerOptionId] = objInFor[convcc_ExamPaperStuRelation4App.AnswerOptionId];
objDR[convcc_ExamPaperStuRelation4App.AnswerMultiOptions] = objInFor[convcc_ExamPaperStuRelation4App.AnswerMultiOptions];
objDR[convcc_ExamPaperStuRelation4App.StuAnswerText] = objInFor[convcc_ExamPaperStuRelation4App.StuAnswerText];
objDR[convcc_ExamPaperStuRelation4App.IsPublish] = objInFor[convcc_ExamPaperStuRelation4App.IsPublish];
objDR[convcc_ExamPaperStuRelation4App.IsSave] = objInFor[convcc_ExamPaperStuRelation4App.IsSave];
objDR[convcc_ExamPaperStuRelation4App.IsSubmit] = objInFor[convcc_ExamPaperStuRelation4App.IsSubmit];
objDR[convcc_ExamPaperStuRelation4App.RealFinishDate] = objInFor[convcc_ExamPaperStuRelation4App.RealFinishDate];
objDR[convcc_ExamPaperStuRelation4App.Score] = objInFor[convcc_ExamPaperStuRelation4App.Score];
objDR[convcc_ExamPaperStuRelation4App.Comment] = objInFor[convcc_ExamPaperStuRelation4App.Comment];
objDR[convcc_ExamPaperStuRelation4App.IsMarking] = objInFor[convcc_ExamPaperStuRelation4App.IsMarking];
objDR[convcc_ExamPaperStuRelation4App.MarkerId] = objInFor[convcc_ExamPaperStuRelation4App.MarkerId];
objDR[convcc_ExamPaperStuRelation4App.MarkDate] = objInFor[convcc_ExamPaperStuRelation4App.MarkDate];
objDR[convcc_ExamPaperStuRelation4App.IsSendBack] = objInFor[convcc_ExamPaperStuRelation4App.IsSendBack];
objDR[convcc_ExamPaperStuRelation4App.IsInErrorQuestion] = objInFor[convcc_ExamPaperStuRelation4App.IsInErrorQuestion];
objDR[convcc_ExamPaperStuRelation4App.WorkTypeId] = objInFor[convcc_ExamPaperStuRelation4App.WorkTypeId];
objDR[convcc_ExamPaperStuRelation4App.AnswerIP] = objInFor[convcc_ExamPaperStuRelation4App.AnswerIP];
objDR[convcc_ExamPaperStuRelation4App.AnswerDate] = objInFor[convcc_ExamPaperStuRelation4App.AnswerDate];
objDR[convcc_ExamPaperStuRelation4App.AnswerTime] = objInFor[convcc_ExamPaperStuRelation4App.AnswerTime];
objDR[convcc_ExamPaperStuRelation4App.IsRight] = objInFor[convcc_ExamPaperStuRelation4App.IsRight];
objDR[convcc_ExamPaperStuRelation4App.IsNotProcessTimeout] = objInFor[convcc_ExamPaperStuRelation4App.IsNotProcessTimeout];
objDR[convcc_ExamPaperStuRelation4App.UpdDate] = objInFor[convcc_ExamPaperStuRelation4App.UpdDate];
objDR[convcc_ExamPaperStuRelation4App.UpdUserId] = objInFor[convcc_ExamPaperStuRelation4App.UpdUserId];
objDR[convcc_ExamPaperStuRelation4App.Memo] = objInFor[convcc_ExamPaperStuRelation4App.Memo];
objDR[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum] = objInFor[convcc_ExamPaperStuRelation4App.NoSubmitBatchNum];
objDR[convcc_ExamPaperStuRelation4App.SubmitBatchNum] = objInFor[convcc_ExamPaperStuRelation4App.SubmitBatchNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}