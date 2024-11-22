
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_ExamPaperStuRelationWApi
 表名:vcc_ExamPaperStuRelation(01120236)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:59
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
public static class clsvcc_ExamPaperStuRelationWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetId_ExamPaperStuRelation(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, long lngId_ExamPaperStuRelation, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.Id_ExamPaperStuRelation = lngId_ExamPaperStuRelation; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.Id_ExamPaperStuRelation) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.Id_ExamPaperStuRelation, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.Id_ExamPaperStuRelation] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetCourseExamPaperId(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convcc_ExamPaperStuRelation.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convcc_ExamPaperStuRelation.CourseExamPaperId);
objvcc_ExamPaperStuRelationEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.CourseExamPaperId) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.CourseExamPaperId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.CourseExamPaperId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetId_ExamPaperEduClsRela(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, long lngId_ExamPaperEduClsRela, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.Id_ExamPaperEduClsRela = lngId_ExamPaperEduClsRela; //作业教学班关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.Id_ExamPaperEduClsRela) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.Id_ExamPaperEduClsRela, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.Id_ExamPaperEduClsRela] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetCourseId(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convcc_ExamPaperStuRelation.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convcc_ExamPaperStuRelation.CourseId);
objvcc_ExamPaperStuRelationEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.CourseId) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.CourseId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.CourseId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetCourseName(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convcc_ExamPaperStuRelation.CourseName);
objvcc_ExamPaperStuRelationEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.CourseName) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.CourseName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.CourseName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetExamPaperName(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strExamPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, convcc_ExamPaperStuRelation.ExamPaperName);
objvcc_ExamPaperStuRelationEN.ExamPaperName = strExamPaperName; //考卷名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.ExamPaperName) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.ExamPaperName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.ExamPaperName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetPaperIndex(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, int intPaperIndex, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.PaperIndex = intPaperIndex; //试卷序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.PaperIndex) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.PaperIndex, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.PaperIndex] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetExamPaperTypeId(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strExamPaperTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeId, convcc_ExamPaperStuRelation.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, convcc_ExamPaperStuRelation.ExamPaperTypeId);
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, convcc_ExamPaperStuRelation.ExamPaperTypeId);
objvcc_ExamPaperStuRelationEN.ExamPaperTypeId = strExamPaperTypeId; //试卷类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.ExamPaperTypeId) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.ExamPaperTypeId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.ExamPaperTypeId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetExamPaperTypeName(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strExamPaperTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeName, convcc_ExamPaperStuRelation.ExamPaperTypeName);
clsCheckSql.CheckFieldLen(strExamPaperTypeName, 30, convcc_ExamPaperStuRelation.ExamPaperTypeName);
objvcc_ExamPaperStuRelationEN.ExamPaperTypeName = strExamPaperTypeName; //试卷类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.ExamPaperTypeName) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.ExamPaperTypeName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.ExamPaperTypeName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetPaperDispModeName(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strPaperDispModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperDispModeName, 30, convcc_ExamPaperStuRelation.PaperDispModeName);
objvcc_ExamPaperStuRelationEN.PaperDispModeName = strPaperDispModeName; //试卷显示模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.PaperDispModeName) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.PaperDispModeName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.PaperDispModeName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetExamCreateTime(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strExamCreateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExamCreateTime, 14, convcc_ExamPaperStuRelation.ExamCreateTime);
objvcc_ExamPaperStuRelationEN.ExamCreateTime = strExamCreateTime; //考卷建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.ExamCreateTime) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.ExamCreateTime, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.ExamCreateTime] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetCourseChapterId(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convcc_ExamPaperStuRelation.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convcc_ExamPaperStuRelation.CourseChapterId);
objvcc_ExamPaperStuRelationEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.CourseChapterId) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.CourseChapterId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.CourseChapterId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetCourseChapterName(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, convcc_ExamPaperStuRelation.CourseChapterName);
objvcc_ExamPaperStuRelationEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.CourseChapterName) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.CourseChapterName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.CourseChapterName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetChapterId(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convcc_ExamPaperStuRelation.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convcc_ExamPaperStuRelation.ChapterId);
objvcc_ExamPaperStuRelationEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.ChapterId) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.ChapterId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.ChapterId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetSectionId(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convcc_ExamPaperStuRelation.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convcc_ExamPaperStuRelation.SectionId);
objvcc_ExamPaperStuRelationEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.SectionId) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.SectionId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.SectionId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetChapterName(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convcc_ExamPaperStuRelation.ChapterName);
objvcc_ExamPaperStuRelationEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.ChapterName) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.ChapterName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.ChapterName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetSectionName(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convcc_ExamPaperStuRelation.SectionName);
objvcc_ExamPaperStuRelationEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.SectionName) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.SectionName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.SectionName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetChapterName_Sim(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convcc_ExamPaperStuRelation.ChapterName_Sim);
objvcc_ExamPaperStuRelationEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.ChapterName_Sim) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.ChapterName_Sim, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.ChapterName_Sim] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetSectionName_Sim(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convcc_ExamPaperStuRelation.SectionName_Sim);
objvcc_ExamPaperStuRelationEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.SectionName_Sim) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.SectionName_Sim, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.SectionName_Sim] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetIsAutoGeneQuestion(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, bool bolIsAutoGeneQuestion, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.IsAutoGeneQuestion = bolIsAutoGeneQuestion; //是否自动生成题目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.IsAutoGeneQuestion) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.IsAutoGeneQuestion, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.IsAutoGeneQuestion] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetIsCanMultiDo(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, bool bolIsCanMultiDo, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.IsCanMultiDo = bolIsCanMultiDo; //是否可以做多次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.IsCanMultiDo) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.IsCanMultiDo, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.IsCanMultiDo] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetQuestionNum(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, int intQuestionNum, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.QuestionNum = intQuestionNum; //题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.QuestionNum) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.QuestionNum, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.QuestionNum] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetCurrEduClsId(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convcc_ExamPaperStuRelation.CurrEduClsId);
objvcc_ExamPaperStuRelationEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.CurrEduClsId) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.CurrEduClsId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.CurrEduClsId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetEduClsName(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convcc_ExamPaperStuRelation.EduClsName);
clsCheckSql.CheckFieldLen(strEduClsName, 100, convcc_ExamPaperStuRelation.EduClsName);
objvcc_ExamPaperStuRelationEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.EduClsName) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.EduClsName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.EduClsName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetTeacherID(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherID, convcc_ExamPaperStuRelation.TeacherID);
clsCheckSql.CheckFieldLen(strTeacherID, 12, convcc_ExamPaperStuRelation.TeacherID);
objvcc_ExamPaperStuRelationEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.TeacherID) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.TeacherID, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.TeacherID] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetPubDate(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strPubDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubDate, convcc_ExamPaperStuRelation.PubDate);
clsCheckSql.CheckFieldLen(strPubDate, 14, convcc_ExamPaperStuRelation.PubDate);
objvcc_ExamPaperStuRelationEN.PubDate = strPubDate; //发布日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.PubDate) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.PubDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.PubDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetIsCurrEduCls(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, bool bolIsCurrEduCls, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.IsCurrEduCls = bolIsCurrEduCls; //是否为教学班作业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.IsCurrEduCls) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.IsCurrEduCls, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.IsCurrEduCls] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetIsGroupWork(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, bool bolIsGroupWork, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.IsGroupWork = bolIsGroupWork; //是否为小组作业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.IsGroupWork) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.IsGroupWork, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.IsGroupWork] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetCourseStudentGroupId(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, long lngCourseStudentGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngCourseStudentGroupId, convcc_ExamPaperStuRelation.CourseStudentGroupId);
objvcc_ExamPaperStuRelationEN.CourseStudentGroupId = lngCourseStudentGroupId; //学生分组表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.CourseStudentGroupId) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.CourseStudentGroupId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.CourseStudentGroupId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetWorkTypeName(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strWorkTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkTypeName, convcc_ExamPaperStuRelation.WorkTypeName);
clsCheckSql.CheckFieldLen(strWorkTypeName, 30, convcc_ExamPaperStuRelation.WorkTypeName);
objvcc_ExamPaperStuRelationEN.WorkTypeName = strWorkTypeName; //作业类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.WorkTypeName) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.WorkTypeName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.WorkTypeName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN Setid_CurrEduCls(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, convcc_ExamPaperStuRelation.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convcc_ExamPaperStuRelation.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convcc_ExamPaperStuRelation.id_CurrEduCls);
objvcc_ExamPaperStuRelationEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.id_CurrEduCls) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.id_CurrEduCls, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.id_CurrEduCls] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetScores(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, double dblScores, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.Scores) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.Scores, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.Scores] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetSpecifyCompletionDate(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strSpecifyCompletionDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSpecifyCompletionDate, convcc_ExamPaperStuRelation.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(strSpecifyCompletionDate, 14, convcc_ExamPaperStuRelation.SpecifyCompletionDate);
objvcc_ExamPaperStuRelationEN.SpecifyCompletionDate = strSpecifyCompletionDate; //指定完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.SpecifyCompletionDate) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.SpecifyCompletionDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.SpecifyCompletionDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN Setid_StudentInfo(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, convcc_ExamPaperStuRelation.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convcc_ExamPaperStuRelation.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convcc_ExamPaperStuRelation.id_StudentInfo);
objvcc_ExamPaperStuRelationEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.id_StudentInfo) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.id_StudentInfo, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.id_StudentInfo] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetStuID(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convcc_ExamPaperStuRelation.StuID);
objvcc_ExamPaperStuRelationEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.StuID) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.StuID, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.StuID] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetStuName(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convcc_ExamPaperStuRelation.StuName);
objvcc_ExamPaperStuRelationEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.StuName) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.StuName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.StuName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN Setid_XzCollege(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convcc_ExamPaperStuRelation.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convcc_ExamPaperStuRelation.id_XzCollege);
objvcc_ExamPaperStuRelationEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.id_XzCollege) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.id_XzCollege, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.id_XzCollege] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetCollegeName(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convcc_ExamPaperStuRelation.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convcc_ExamPaperStuRelation.CollegeName);
objvcc_ExamPaperStuRelationEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.CollegeName) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.CollegeName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.CollegeName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetCollegeNameA(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convcc_ExamPaperStuRelation.CollegeNameA);
objvcc_ExamPaperStuRelationEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.CollegeNameA) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.CollegeNameA, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.CollegeNameA] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN Setid_XzMajor(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convcc_ExamPaperStuRelation.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convcc_ExamPaperStuRelation.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convcc_ExamPaperStuRelation.id_XzMajor);
objvcc_ExamPaperStuRelationEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.id_XzMajor) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.id_XzMajor, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.id_XzMajor] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetMajorID(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorID, convcc_ExamPaperStuRelation.MajorID);
clsCheckSql.CheckFieldLen(strMajorID, 4, convcc_ExamPaperStuRelation.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convcc_ExamPaperStuRelation.MajorID);
objvcc_ExamPaperStuRelationEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.MajorID) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.MajorID, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.MajorID] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetMajorName(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convcc_ExamPaperStuRelation.MajorName);
clsCheckSql.CheckFieldLen(strMajorName, 100, convcc_ExamPaperStuRelation.MajorName);
objvcc_ExamPaperStuRelationEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.MajorName) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.MajorName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.MajorName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN Setid_GradeBase(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convcc_ExamPaperStuRelation.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convcc_ExamPaperStuRelation.id_GradeBase);
objvcc_ExamPaperStuRelationEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.id_GradeBase) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.id_GradeBase, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.id_GradeBase] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetGradeBaseName(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseName, convcc_ExamPaperStuRelation.GradeBaseName);
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convcc_ExamPaperStuRelation.GradeBaseName);
objvcc_ExamPaperStuRelationEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.GradeBaseName) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.GradeBaseName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.GradeBaseName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetAdminClsName(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convcc_ExamPaperStuRelation.AdminClsName);
objvcc_ExamPaperStuRelationEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.AdminClsName) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.AdminClsName, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.AdminClsName] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetAdminClsId(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convcc_ExamPaperStuRelation.AdminClsId);
objvcc_ExamPaperStuRelationEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.AdminClsId) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.AdminClsId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.AdminClsId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetAnswerModeId(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convcc_ExamPaperStuRelation.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convcc_ExamPaperStuRelation.AnswerModeId);
objvcc_ExamPaperStuRelationEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.AnswerModeId) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.AnswerModeId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.AnswerModeId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetAnswerOptionId(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strAnswerOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, convcc_ExamPaperStuRelation.AnswerOptionId);
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, convcc_ExamPaperStuRelation.AnswerOptionId);
objvcc_ExamPaperStuRelationEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.AnswerOptionId) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.AnswerOptionId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.AnswerOptionId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetAnswerMultiOptions(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strAnswerMultiOptions, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerMultiOptions, 300, convcc_ExamPaperStuRelation.AnswerMultiOptions);
objvcc_ExamPaperStuRelationEN.AnswerMultiOptions = strAnswerMultiOptions; //多选项答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.AnswerMultiOptions) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.AnswerMultiOptions, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.AnswerMultiOptions] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetStuAnswerText(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strStuAnswerText, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.StuAnswerText = strStuAnswerText; //学生回答文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.StuAnswerText) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.StuAnswerText, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.StuAnswerText] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetIsPublish(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, bool bolIsPublish, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.IsPublish) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.IsPublish, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.IsPublish] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetIsLook(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, bool bolIsLook, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.IsLook = bolIsLook; //是否查看
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.IsLook) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.IsLook, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.IsLook] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetIsSave(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, bool bolIsSave, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.IsSave = bolIsSave; //是否保存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.IsSave) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.IsSave, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.IsSave] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetIsSubmit(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.IsSubmit) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.IsSubmit, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.IsSubmit] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetApplySendBackDate(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strApplySendBackDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplySendBackDate, 14, convcc_ExamPaperStuRelation.ApplySendBackDate);
objvcc_ExamPaperStuRelationEN.ApplySendBackDate = strApplySendBackDate; //申请退回日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.ApplySendBackDate) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.ApplySendBackDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.ApplySendBackDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetIsApplySendBack(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, bool bolIsApplySendBack, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.IsApplySendBack = bolIsApplySendBack; //是否申请退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.IsApplySendBack) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.IsApplySendBack, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.IsApplySendBack] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetRealFinishDate(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strRealFinishDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, convcc_ExamPaperStuRelation.RealFinishDate);
objvcc_ExamPaperStuRelationEN.RealFinishDate = strRealFinishDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.RealFinishDate) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.RealFinishDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.RealFinishDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetOperateTime(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strOperateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOperateTime, 14, convcc_ExamPaperStuRelation.OperateTime);
objvcc_ExamPaperStuRelationEN.OperateTime = strOperateTime; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.OperateTime) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.OperateTime, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.OperateTime] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetScore(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, double dblScore, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.Score) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.Score, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.Score] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetComment(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strComment, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.Comment = strComment; //批注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.Comment) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.Comment, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.Comment] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetIsMarking(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, bool bolIsMarking, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.IsMarking) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.IsMarking, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.IsMarking] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetMarkerId(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strMarkerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkerId, 20, convcc_ExamPaperStuRelation.MarkerId);
objvcc_ExamPaperStuRelationEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.MarkerId) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.MarkerId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.MarkerId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetMarkDate(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strMarkDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkDate, 14, convcc_ExamPaperStuRelation.MarkDate);
objvcc_ExamPaperStuRelationEN.MarkDate = strMarkDate; //打分日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.MarkDate) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.MarkDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.MarkDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetIsSendBack(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, bool bolIsSendBack, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.IsSendBack = bolIsSendBack; //是否退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.IsSendBack) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.IsSendBack, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.IsSendBack] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetIsInErrorQuestion(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, bool bolIsInErrorQuestion, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.IsInErrorQuestion = bolIsInErrorQuestion; //是否进入错题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.IsInErrorQuestion) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.IsInErrorQuestion, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.IsInErrorQuestion] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetWorkTypeId(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strWorkTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkTypeId, convcc_ExamPaperStuRelation.WorkTypeId);
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, convcc_ExamPaperStuRelation.WorkTypeId);
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, convcc_ExamPaperStuRelation.WorkTypeId);
objvcc_ExamPaperStuRelationEN.WorkTypeId = strWorkTypeId; //作业类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.WorkTypeId) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.WorkTypeId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.WorkTypeId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetAnswerIP(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strAnswerIP, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, convcc_ExamPaperStuRelation.AnswerIP);
objvcc_ExamPaperStuRelationEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.AnswerIP) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.AnswerIP, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.AnswerIP] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetAnswerDate(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strAnswerDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, convcc_ExamPaperStuRelation.AnswerDate);
objvcc_ExamPaperStuRelationEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.AnswerDate) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.AnswerDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.AnswerDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetAnswerTime(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strAnswerTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, convcc_ExamPaperStuRelation.AnswerTime);
objvcc_ExamPaperStuRelationEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.AnswerTime) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.AnswerTime, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.AnswerTime] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetIsRight(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, bool bolIsRight, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.IsRight) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.IsRight, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.IsRight] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetIsAccessKnowledge(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, bool bolIsAccessKnowledge, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.IsAccessKnowledge = bolIsAccessKnowledge; //是否处理知识点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.IsAccessKnowledge) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.IsAccessKnowledge, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.IsAccessKnowledge] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetIsNotProcessTimeout(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, bool bolIsNotProcessTimeout, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.IsNotProcessTimeout = bolIsNotProcessTimeout; //是否不处理超时
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.IsNotProcessTimeout) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.IsNotProcessTimeout, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.IsNotProcessTimeout] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetSchoolYear(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convcc_ExamPaperStuRelation.SchoolYear);
objvcc_ExamPaperStuRelationEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.SchoolYear) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.SchoolYear, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.SchoolYear] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetSchoolTerm(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convcc_ExamPaperStuRelation.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convcc_ExamPaperStuRelation.SchoolTerm);
objvcc_ExamPaperStuRelationEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.SchoolTerm) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.SchoolTerm, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.SchoolTerm] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetUpdDate(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_ExamPaperStuRelation.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_ExamPaperStuRelation.UpdDate);
objvcc_ExamPaperStuRelationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.UpdDate) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.UpdDate, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.UpdDate] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetUpdUserId(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convcc_ExamPaperStuRelation.UpdUserId);
objvcc_ExamPaperStuRelationEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.UpdUserId) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.UpdUserId, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.UpdUserId] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetMemo(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_ExamPaperStuRelation.Memo);
objvcc_ExamPaperStuRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.Memo) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.Memo, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.Memo] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetNoSubmitBatchNum(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, int intNoSubmitBatchNum, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.NoSubmitBatchNum = intNoSubmitBatchNum; //未提交批次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.NoSubmitBatchNum) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.NoSubmitBatchNum, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.NoSubmitBatchNum] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_ExamPaperStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_ExamPaperStuRelationEN SetSubmitBatchNum(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN, int intSubmitBatchNum, string strComparisonOp="")
	{
objvcc_ExamPaperStuRelationEN.SubmitBatchNum = intSubmitBatchNum; //提交批次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.ContainsKey(convcc_ExamPaperStuRelation.SubmitBatchNum) == false)
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp.Add(convcc_ExamPaperStuRelation.SubmitBatchNum, strComparisonOp);
}
else
{
objvcc_ExamPaperStuRelationEN.dicFldComparisonOp[convcc_ExamPaperStuRelation.SubmitBatchNum] = strComparisonOp;
}
}
return objvcc_ExamPaperStuRelationEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelation_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.Id_ExamPaperStuRelation) == true)
{
string strComparisonOp_Id_ExamPaperStuRelation = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.Id_ExamPaperStuRelation];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation.Id_ExamPaperStuRelation, objvcc_ExamPaperStuRelation_Cond.Id_ExamPaperStuRelation, strComparisonOp_Id_ExamPaperStuRelation);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.CourseExamPaperId, objvcc_ExamPaperStuRelation_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.Id_ExamPaperEduClsRela) == true)
{
string strComparisonOp_Id_ExamPaperEduClsRela = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.Id_ExamPaperEduClsRela];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation.Id_ExamPaperEduClsRela, objvcc_ExamPaperStuRelation_Cond.Id_ExamPaperEduClsRela, strComparisonOp_Id_ExamPaperEduClsRela);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.CourseId) == true)
{
string strComparisonOp_CourseId = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.CourseId, objvcc_ExamPaperStuRelation_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.CourseName) == true)
{
string strComparisonOp_CourseName = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.CourseName, objvcc_ExamPaperStuRelation_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.ExamPaperName) == true)
{
string strComparisonOp_ExamPaperName = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.ExamPaperName, objvcc_ExamPaperStuRelation_Cond.ExamPaperName, strComparisonOp_ExamPaperName);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.PaperIndex) == true)
{
string strComparisonOp_PaperIndex = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.PaperIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation.PaperIndex, objvcc_ExamPaperStuRelation_Cond.PaperIndex, strComparisonOp_PaperIndex);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.ExamPaperTypeId) == true)
{
string strComparisonOp_ExamPaperTypeId = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.ExamPaperTypeId, objvcc_ExamPaperStuRelation_Cond.ExamPaperTypeId, strComparisonOp_ExamPaperTypeId);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.ExamPaperTypeName) == true)
{
string strComparisonOp_ExamPaperTypeName = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.ExamPaperTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.ExamPaperTypeName, objvcc_ExamPaperStuRelation_Cond.ExamPaperTypeName, strComparisonOp_ExamPaperTypeName);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.PaperDispModeName) == true)
{
string strComparisonOp_PaperDispModeName = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.PaperDispModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.PaperDispModeName, objvcc_ExamPaperStuRelation_Cond.PaperDispModeName, strComparisonOp_PaperDispModeName);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.ExamCreateTime) == true)
{
string strComparisonOp_ExamCreateTime = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.ExamCreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.ExamCreateTime, objvcc_ExamPaperStuRelation_Cond.ExamCreateTime, strComparisonOp_ExamCreateTime);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.CourseChapterId, objvcc_ExamPaperStuRelation_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.CourseChapterName) == true)
{
string strComparisonOp_CourseChapterName = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.CourseChapterName, objvcc_ExamPaperStuRelation_Cond.CourseChapterName, strComparisonOp_CourseChapterName);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.ChapterId, objvcc_ExamPaperStuRelation_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.SectionId) == true)
{
string strComparisonOp_SectionId = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.SectionId, objvcc_ExamPaperStuRelation_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.ChapterName, objvcc_ExamPaperStuRelation_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.SectionName) == true)
{
string strComparisonOp_SectionName = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.SectionName, objvcc_ExamPaperStuRelation_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.ChapterName_Sim, objvcc_ExamPaperStuRelation_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.SectionName_Sim, objvcc_ExamPaperStuRelation_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.IsAutoGeneQuestion) == true)
{
if (objvcc_ExamPaperStuRelation_Cond.IsAutoGeneQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation.IsAutoGeneQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation.IsAutoGeneQuestion);
}
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.IsCanMultiDo) == true)
{
if (objvcc_ExamPaperStuRelation_Cond.IsCanMultiDo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation.IsCanMultiDo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation.IsCanMultiDo);
}
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.QuestionNum) == true)
{
string strComparisonOp_QuestionNum = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.QuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation.QuestionNum, objvcc_ExamPaperStuRelation_Cond.QuestionNum, strComparisonOp_QuestionNum);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.CurrEduClsId, objvcc_ExamPaperStuRelation_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.EduClsName, objvcc_ExamPaperStuRelation_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.TeacherID, objvcc_ExamPaperStuRelation_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.PubDate) == true)
{
string strComparisonOp_PubDate = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.PubDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.PubDate, objvcc_ExamPaperStuRelation_Cond.PubDate, strComparisonOp_PubDate);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.IsCurrEduCls) == true)
{
if (objvcc_ExamPaperStuRelation_Cond.IsCurrEduCls == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation.IsCurrEduCls);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation.IsCurrEduCls);
}
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.IsGroupWork) == true)
{
if (objvcc_ExamPaperStuRelation_Cond.IsGroupWork == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation.IsGroupWork);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation.IsGroupWork);
}
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.CourseStudentGroupId) == true)
{
string strComparisonOp_CourseStudentGroupId = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.CourseStudentGroupId];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation.CourseStudentGroupId, objvcc_ExamPaperStuRelation_Cond.CourseStudentGroupId, strComparisonOp_CourseStudentGroupId);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.WorkTypeName) == true)
{
string strComparisonOp_WorkTypeName = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.WorkTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.WorkTypeName, objvcc_ExamPaperStuRelation_Cond.WorkTypeName, strComparisonOp_WorkTypeName);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.id_CurrEduCls, objvcc_ExamPaperStuRelation_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.Scores) == true)
{
string strComparisonOp_Scores = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation.Scores, objvcc_ExamPaperStuRelation_Cond.Scores, strComparisonOp_Scores);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.SpecifyCompletionDate) == true)
{
string strComparisonOp_SpecifyCompletionDate = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.SpecifyCompletionDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.SpecifyCompletionDate, objvcc_ExamPaperStuRelation_Cond.SpecifyCompletionDate, strComparisonOp_SpecifyCompletionDate);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.id_StudentInfo, objvcc_ExamPaperStuRelation_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.StuID) == true)
{
string strComparisonOp_StuID = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.StuID, objvcc_ExamPaperStuRelation_Cond.StuID, strComparisonOp_StuID);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.StuName) == true)
{
string strComparisonOp_StuName = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.StuName, objvcc_ExamPaperStuRelation_Cond.StuName, strComparisonOp_StuName);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.id_XzCollege, objvcc_ExamPaperStuRelation_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.CollegeName, objvcc_ExamPaperStuRelation_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.CollegeNameA, objvcc_ExamPaperStuRelation_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.id_XzMajor, objvcc_ExamPaperStuRelation_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.MajorID) == true)
{
string strComparisonOp_MajorID = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.MajorID, objvcc_ExamPaperStuRelation_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.MajorName) == true)
{
string strComparisonOp_MajorName = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.MajorName, objvcc_ExamPaperStuRelation_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.id_GradeBase, objvcc_ExamPaperStuRelation_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.GradeBaseName, objvcc_ExamPaperStuRelation_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.AdminClsName, objvcc_ExamPaperStuRelation_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.AdminClsId, objvcc_ExamPaperStuRelation_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.AnswerModeId, objvcc_ExamPaperStuRelation_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.AnswerOptionId) == true)
{
string strComparisonOp_AnswerOptionId = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.AnswerOptionId, objvcc_ExamPaperStuRelation_Cond.AnswerOptionId, strComparisonOp_AnswerOptionId);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.AnswerMultiOptions) == true)
{
string strComparisonOp_AnswerMultiOptions = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.AnswerMultiOptions];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.AnswerMultiOptions, objvcc_ExamPaperStuRelation_Cond.AnswerMultiOptions, strComparisonOp_AnswerMultiOptions);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.IsPublish) == true)
{
if (objvcc_ExamPaperStuRelation_Cond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation.IsPublish);
}
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.IsLook) == true)
{
if (objvcc_ExamPaperStuRelation_Cond.IsLook == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation.IsLook);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation.IsLook);
}
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.IsSave) == true)
{
if (objvcc_ExamPaperStuRelation_Cond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation.IsSave);
}
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.IsSubmit) == true)
{
if (objvcc_ExamPaperStuRelation_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation.IsSubmit);
}
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.ApplySendBackDate) == true)
{
string strComparisonOp_ApplySendBackDate = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.ApplySendBackDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.ApplySendBackDate, objvcc_ExamPaperStuRelation_Cond.ApplySendBackDate, strComparisonOp_ApplySendBackDate);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.IsApplySendBack) == true)
{
if (objvcc_ExamPaperStuRelation_Cond.IsApplySendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation.IsApplySendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation.IsApplySendBack);
}
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.RealFinishDate) == true)
{
string strComparisonOp_RealFinishDate = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.RealFinishDate, objvcc_ExamPaperStuRelation_Cond.RealFinishDate, strComparisonOp_RealFinishDate);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.OperateTime) == true)
{
string strComparisonOp_OperateTime = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.OperateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.OperateTime, objvcc_ExamPaperStuRelation_Cond.OperateTime, strComparisonOp_OperateTime);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.Score) == true)
{
string strComparisonOp_Score = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation.Score, objvcc_ExamPaperStuRelation_Cond.Score, strComparisonOp_Score);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.IsMarking) == true)
{
if (objvcc_ExamPaperStuRelation_Cond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation.IsMarking);
}
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.MarkerId) == true)
{
string strComparisonOp_MarkerId = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.MarkerId, objvcc_ExamPaperStuRelation_Cond.MarkerId, strComparisonOp_MarkerId);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.MarkDate) == true)
{
string strComparisonOp_MarkDate = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.MarkDate, objvcc_ExamPaperStuRelation_Cond.MarkDate, strComparisonOp_MarkDate);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.IsSendBack) == true)
{
if (objvcc_ExamPaperStuRelation_Cond.IsSendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation.IsSendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation.IsSendBack);
}
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.IsInErrorQuestion) == true)
{
if (objvcc_ExamPaperStuRelation_Cond.IsInErrorQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation.IsInErrorQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation.IsInErrorQuestion);
}
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.WorkTypeId) == true)
{
string strComparisonOp_WorkTypeId = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.WorkTypeId, objvcc_ExamPaperStuRelation_Cond.WorkTypeId, strComparisonOp_WorkTypeId);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.AnswerIP) == true)
{
string strComparisonOp_AnswerIP = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.AnswerIP, objvcc_ExamPaperStuRelation_Cond.AnswerIP, strComparisonOp_AnswerIP);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.AnswerDate) == true)
{
string strComparisonOp_AnswerDate = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.AnswerDate, objvcc_ExamPaperStuRelation_Cond.AnswerDate, strComparisonOp_AnswerDate);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.AnswerTime) == true)
{
string strComparisonOp_AnswerTime = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.AnswerTime, objvcc_ExamPaperStuRelation_Cond.AnswerTime, strComparisonOp_AnswerTime);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.IsRight) == true)
{
if (objvcc_ExamPaperStuRelation_Cond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation.IsRight);
}
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.IsAccessKnowledge) == true)
{
if (objvcc_ExamPaperStuRelation_Cond.IsAccessKnowledge == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation.IsAccessKnowledge);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation.IsAccessKnowledge);
}
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.IsNotProcessTimeout) == true)
{
if (objvcc_ExamPaperStuRelation_Cond.IsNotProcessTimeout == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcc_ExamPaperStuRelation.IsNotProcessTimeout);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcc_ExamPaperStuRelation.IsNotProcessTimeout);
}
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.SchoolYear, objvcc_ExamPaperStuRelation_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.SchoolTerm, objvcc_ExamPaperStuRelation_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.UpdDate, objvcc_ExamPaperStuRelation_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.UpdUserId, objvcc_ExamPaperStuRelation_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.Memo) == true)
{
string strComparisonOp_Memo = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_ExamPaperStuRelation.Memo, objvcc_ExamPaperStuRelation_Cond.Memo, strComparisonOp_Memo);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.NoSubmitBatchNum) == true)
{
string strComparisonOp_NoSubmitBatchNum = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.NoSubmitBatchNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation.NoSubmitBatchNum, objvcc_ExamPaperStuRelation_Cond.NoSubmitBatchNum, strComparisonOp_NoSubmitBatchNum);
}
if (objvcc_ExamPaperStuRelation_Cond.IsUpdated(convcc_ExamPaperStuRelation.SubmitBatchNum) == true)
{
string strComparisonOp_SubmitBatchNum = objvcc_ExamPaperStuRelation_Cond.dicFldComparisonOp[convcc_ExamPaperStuRelation.SubmitBatchNum];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_ExamPaperStuRelation.SubmitBatchNum, objvcc_ExamPaperStuRelation_Cond.SubmitBatchNum, strComparisonOp_SubmitBatchNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v考卷与学生关系(vcc_ExamPaperStuRelation)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_ExamPaperStuRelationWApi
{
private static readonly string mstrApiControllerName = "vcc_ExamPaperStuRelationApi";

 public clsvcc_ExamPaperStuRelationWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_ExamPaperStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_ExamPaperStuRelationEN GetObjById_ExamPaperStuRelation(long lngId_ExamPaperStuRelation)
{
string strAction = "GetObjById_ExamPaperStuRelation";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN = null;
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
objvcc_ExamPaperStuRelationEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperStuRelationEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperStuRelationEN;
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
public static clsvcc_ExamPaperStuRelationEN GetObjById_ExamPaperStuRelation_WA_Cache(long lngId_ExamPaperStuRelation, string strid_CurrEduCls)
{
string strAction = "GetObjById_ExamPaperStuRelation_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN = null;
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
objvcc_ExamPaperStuRelationEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperStuRelationEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperStuRelationEN;
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
public static clsvcc_ExamPaperStuRelationEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationEN = null;
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
objvcc_ExamPaperStuRelationEN = JsonConvert.DeserializeObject<clsvcc_ExamPaperStuRelationEN>((string)jobjReturn["ReturnObj"]);
return objvcc_ExamPaperStuRelationEN;
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
public static clsvcc_ExamPaperStuRelationEN GetObjById_ExamPaperStuRelation_Cache(long lngId_ExamPaperStuRelation, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuRelationEN._CurrTabName_S, strid_CurrEduCls);
List<clsvcc_ExamPaperStuRelationEN> arrvcc_ExamPaperStuRelationObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsvcc_ExamPaperStuRelationEN> arrvcc_ExamPaperStuRelationObjLst_Sel =
from objvcc_ExamPaperStuRelationEN in arrvcc_ExamPaperStuRelationObjLst_Cache
where objvcc_ExamPaperStuRelationEN.Id_ExamPaperStuRelation == lngId_ExamPaperStuRelation
select objvcc_ExamPaperStuRelationEN;
if (arrvcc_ExamPaperStuRelationObjLst_Sel.Count() == 0)
{
   clsvcc_ExamPaperStuRelationEN obj = clsvcc_ExamPaperStuRelationWApi.GetObjById_ExamPaperStuRelation(lngId_ExamPaperStuRelation);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_ExamPaperStuRelationObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperStuRelationEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_ExamPaperStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuRelationEN> GetObjLstById_ExamPaperStuRelationLst(List<long> arrId_ExamPaperStuRelation)
{
 List<clsvcc_ExamPaperStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvcc_ExamPaperStuRelationEN> GetObjLstById_ExamPaperStuRelationLst_Cache(List<long> arrId_ExamPaperStuRelation, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuRelationEN._CurrTabName_S, strid_CurrEduCls);
List<clsvcc_ExamPaperStuRelationEN> arrvcc_ExamPaperStuRelationObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsvcc_ExamPaperStuRelationEN> arrvcc_ExamPaperStuRelationObjLst_Sel =
from objvcc_ExamPaperStuRelationEN in arrvcc_ExamPaperStuRelationObjLst_Cache
where arrId_ExamPaperStuRelation.Contains(objvcc_ExamPaperStuRelationEN.Id_ExamPaperStuRelation)
select objvcc_ExamPaperStuRelationEN;
return arrvcc_ExamPaperStuRelationObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_ExamPaperStuRelationEN> GetObjLstById_ExamPaperStuRelationLst_WA_Cache(List<long> arrId_ExamPaperStuRelation, string strid_CurrEduCls)
{
 List<clsvcc_ExamPaperStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuRelationEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_ExamPaperStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuRelationEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_ExamPaperStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_ExamPaperStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_ExamPaperStuRelationEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_ExamPaperStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_ExamPaperStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvcc_ExamPaperStuRelationENS">源对象</param>
 /// <param name = "objvcc_ExamPaperStuRelationENT">目标对象</param>
 public static void CopyTo(clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationENS, clsvcc_ExamPaperStuRelationEN objvcc_ExamPaperStuRelationENT)
{
try
{
objvcc_ExamPaperStuRelationENT.Id_ExamPaperStuRelation = objvcc_ExamPaperStuRelationENS.Id_ExamPaperStuRelation; //流水号
objvcc_ExamPaperStuRelationENT.CourseExamPaperId = objvcc_ExamPaperStuRelationENS.CourseExamPaperId; //考卷流水号
objvcc_ExamPaperStuRelationENT.Id_ExamPaperEduClsRela = objvcc_ExamPaperStuRelationENS.Id_ExamPaperEduClsRela; //作业教学班关系流水号
objvcc_ExamPaperStuRelationENT.CourseId = objvcc_ExamPaperStuRelationENS.CourseId; //课程Id
objvcc_ExamPaperStuRelationENT.CourseName = objvcc_ExamPaperStuRelationENS.CourseName; //课程名称
objvcc_ExamPaperStuRelationENT.ExamPaperName = objvcc_ExamPaperStuRelationENS.ExamPaperName; //考卷名称
objvcc_ExamPaperStuRelationENT.PaperIndex = objvcc_ExamPaperStuRelationENS.PaperIndex; //试卷序号
objvcc_ExamPaperStuRelationENT.ExamPaperTypeId = objvcc_ExamPaperStuRelationENS.ExamPaperTypeId; //试卷类型Id
objvcc_ExamPaperStuRelationENT.ExamPaperTypeName = objvcc_ExamPaperStuRelationENS.ExamPaperTypeName; //试卷类型名称
objvcc_ExamPaperStuRelationENT.PaperDispModeName = objvcc_ExamPaperStuRelationENS.PaperDispModeName; //试卷显示模式名称
objvcc_ExamPaperStuRelationENT.ExamCreateTime = objvcc_ExamPaperStuRelationENS.ExamCreateTime; //考卷建立时间
objvcc_ExamPaperStuRelationENT.CourseChapterId = objvcc_ExamPaperStuRelationENS.CourseChapterId; //课程章节ID
objvcc_ExamPaperStuRelationENT.CourseChapterName = objvcc_ExamPaperStuRelationENS.CourseChapterName; //课程章节名称
objvcc_ExamPaperStuRelationENT.ChapterId = objvcc_ExamPaperStuRelationENS.ChapterId; //章Id
objvcc_ExamPaperStuRelationENT.SectionId = objvcc_ExamPaperStuRelationENS.SectionId; //节Id
objvcc_ExamPaperStuRelationENT.ChapterName = objvcc_ExamPaperStuRelationENS.ChapterName; //章名
objvcc_ExamPaperStuRelationENT.SectionName = objvcc_ExamPaperStuRelationENS.SectionName; //节名
objvcc_ExamPaperStuRelationENT.ChapterName_Sim = objvcc_ExamPaperStuRelationENS.ChapterName_Sim; //章名简称
objvcc_ExamPaperStuRelationENT.SectionName_Sim = objvcc_ExamPaperStuRelationENS.SectionName_Sim; //节名简称
objvcc_ExamPaperStuRelationENT.IsAutoGeneQuestion = objvcc_ExamPaperStuRelationENS.IsAutoGeneQuestion; //是否自动生成题目
objvcc_ExamPaperStuRelationENT.IsCanMultiDo = objvcc_ExamPaperStuRelationENS.IsCanMultiDo; //是否可以做多次
objvcc_ExamPaperStuRelationENT.QuestionNum = objvcc_ExamPaperStuRelationENS.QuestionNum; //题目数
objvcc_ExamPaperStuRelationENT.CurrEduClsId = objvcc_ExamPaperStuRelationENS.CurrEduClsId; //当前教学班Id
objvcc_ExamPaperStuRelationENT.EduClsName = objvcc_ExamPaperStuRelationENS.EduClsName; //教学班名称
objvcc_ExamPaperStuRelationENT.TeacherID = objvcc_ExamPaperStuRelationENS.TeacherID; //教师工号
objvcc_ExamPaperStuRelationENT.PubDate = objvcc_ExamPaperStuRelationENS.PubDate; //发布日期
objvcc_ExamPaperStuRelationENT.IsCurrEduCls = objvcc_ExamPaperStuRelationENS.IsCurrEduCls; //是否为教学班作业
objvcc_ExamPaperStuRelationENT.IsGroupWork = objvcc_ExamPaperStuRelationENS.IsGroupWork; //是否为小组作业
objvcc_ExamPaperStuRelationENT.CourseStudentGroupId = objvcc_ExamPaperStuRelationENS.CourseStudentGroupId; //学生分组表流水号
objvcc_ExamPaperStuRelationENT.WorkTypeName = objvcc_ExamPaperStuRelationENS.WorkTypeName; //作业类型名称
objvcc_ExamPaperStuRelationENT.id_CurrEduCls = objvcc_ExamPaperStuRelationENS.id_CurrEduCls; //当前教学班流水号
objvcc_ExamPaperStuRelationENT.Scores = objvcc_ExamPaperStuRelationENS.Scores; //分值
objvcc_ExamPaperStuRelationENT.SpecifyCompletionDate = objvcc_ExamPaperStuRelationENS.SpecifyCompletionDate; //指定完成日期
objvcc_ExamPaperStuRelationENT.id_StudentInfo = objvcc_ExamPaperStuRelationENS.id_StudentInfo; //学生流水号
objvcc_ExamPaperStuRelationENT.StuID = objvcc_ExamPaperStuRelationENS.StuID; //学号
objvcc_ExamPaperStuRelationENT.StuName = objvcc_ExamPaperStuRelationENS.StuName; //姓名
objvcc_ExamPaperStuRelationENT.id_XzCollege = objvcc_ExamPaperStuRelationENS.id_XzCollege; //学院流水号
objvcc_ExamPaperStuRelationENT.CollegeName = objvcc_ExamPaperStuRelationENS.CollegeName; //学院名称
objvcc_ExamPaperStuRelationENT.CollegeNameA = objvcc_ExamPaperStuRelationENS.CollegeNameA; //学院名称简写
objvcc_ExamPaperStuRelationENT.id_XzMajor = objvcc_ExamPaperStuRelationENS.id_XzMajor; //专业流水号
objvcc_ExamPaperStuRelationENT.MajorID = objvcc_ExamPaperStuRelationENS.MajorID; //专业ID
objvcc_ExamPaperStuRelationENT.MajorName = objvcc_ExamPaperStuRelationENS.MajorName; //专业名称
objvcc_ExamPaperStuRelationENT.id_GradeBase = objvcc_ExamPaperStuRelationENS.id_GradeBase; //年级流水号
objvcc_ExamPaperStuRelationENT.GradeBaseName = objvcc_ExamPaperStuRelationENS.GradeBaseName; //年级名称
objvcc_ExamPaperStuRelationENT.AdminClsName = objvcc_ExamPaperStuRelationENS.AdminClsName; //行政班名称
objvcc_ExamPaperStuRelationENT.AdminClsId = objvcc_ExamPaperStuRelationENS.AdminClsId; //行政班代号
objvcc_ExamPaperStuRelationENT.AnswerModeId = objvcc_ExamPaperStuRelationENS.AnswerModeId; //答案模式Id
objvcc_ExamPaperStuRelationENT.AnswerOptionId = objvcc_ExamPaperStuRelationENS.AnswerOptionId; //回答选项Id
objvcc_ExamPaperStuRelationENT.AnswerMultiOptions = objvcc_ExamPaperStuRelationENS.AnswerMultiOptions; //多选项答案
objvcc_ExamPaperStuRelationENT.StuAnswerText = objvcc_ExamPaperStuRelationENS.StuAnswerText; //学生回答文本
objvcc_ExamPaperStuRelationENT.IsPublish = objvcc_ExamPaperStuRelationENS.IsPublish; //是否发布
objvcc_ExamPaperStuRelationENT.IsLook = objvcc_ExamPaperStuRelationENS.IsLook; //是否查看
objvcc_ExamPaperStuRelationENT.IsSave = objvcc_ExamPaperStuRelationENS.IsSave; //是否保存
objvcc_ExamPaperStuRelationENT.IsSubmit = objvcc_ExamPaperStuRelationENS.IsSubmit; //是否提交
objvcc_ExamPaperStuRelationENT.ApplySendBackDate = objvcc_ExamPaperStuRelationENS.ApplySendBackDate; //申请退回日期
objvcc_ExamPaperStuRelationENT.IsApplySendBack = objvcc_ExamPaperStuRelationENS.IsApplySendBack; //是否申请退回
objvcc_ExamPaperStuRelationENT.RealFinishDate = objvcc_ExamPaperStuRelationENS.RealFinishDate; //实际完成日期
objvcc_ExamPaperStuRelationENT.OperateTime = objvcc_ExamPaperStuRelationENS.OperateTime; //操作时间
objvcc_ExamPaperStuRelationENT.Score = objvcc_ExamPaperStuRelationENS.Score; //得分
objvcc_ExamPaperStuRelationENT.Comment = objvcc_ExamPaperStuRelationENS.Comment; //批注
objvcc_ExamPaperStuRelationENT.IsMarking = objvcc_ExamPaperStuRelationENS.IsMarking; //是否批阅
objvcc_ExamPaperStuRelationENT.MarkerId = objvcc_ExamPaperStuRelationENS.MarkerId; //打分者
objvcc_ExamPaperStuRelationENT.MarkDate = objvcc_ExamPaperStuRelationENS.MarkDate; //打分日期
objvcc_ExamPaperStuRelationENT.IsSendBack = objvcc_ExamPaperStuRelationENS.IsSendBack; //是否退回
objvcc_ExamPaperStuRelationENT.IsInErrorQuestion = objvcc_ExamPaperStuRelationENS.IsInErrorQuestion; //是否进入错题
objvcc_ExamPaperStuRelationENT.WorkTypeId = objvcc_ExamPaperStuRelationENS.WorkTypeId; //作业类型Id
objvcc_ExamPaperStuRelationENT.AnswerIP = objvcc_ExamPaperStuRelationENS.AnswerIP; //回答IP
objvcc_ExamPaperStuRelationENT.AnswerDate = objvcc_ExamPaperStuRelationENS.AnswerDate; //回答日期
objvcc_ExamPaperStuRelationENT.AnswerTime = objvcc_ExamPaperStuRelationENS.AnswerTime; //回答时间
objvcc_ExamPaperStuRelationENT.IsRight = objvcc_ExamPaperStuRelationENS.IsRight; //是否正确
objvcc_ExamPaperStuRelationENT.IsAccessKnowledge = objvcc_ExamPaperStuRelationENS.IsAccessKnowledge; //是否处理知识点
objvcc_ExamPaperStuRelationENT.IsNotProcessTimeout = objvcc_ExamPaperStuRelationENS.IsNotProcessTimeout; //是否不处理超时
objvcc_ExamPaperStuRelationENT.SchoolYear = objvcc_ExamPaperStuRelationENS.SchoolYear; //学年
objvcc_ExamPaperStuRelationENT.SchoolTerm = objvcc_ExamPaperStuRelationENS.SchoolTerm; //学期
objvcc_ExamPaperStuRelationENT.UpdDate = objvcc_ExamPaperStuRelationENS.UpdDate; //修改日期
objvcc_ExamPaperStuRelationENT.UpdUserId = objvcc_ExamPaperStuRelationENS.UpdUserId; //修改用户Id
objvcc_ExamPaperStuRelationENT.Memo = objvcc_ExamPaperStuRelationENS.Memo; //备注
objvcc_ExamPaperStuRelationENT.NoSubmitBatchNum = objvcc_ExamPaperStuRelationENS.NoSubmitBatchNum; //未提交批次数
objvcc_ExamPaperStuRelationENT.SubmitBatchNum = objvcc_ExamPaperStuRelationENS.SubmitBatchNum; //提交批次数
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
public static DataTable ToDataTable(List<clsvcc_ExamPaperStuRelationEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_ExamPaperStuRelationEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_ExamPaperStuRelationEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_ExamPaperStuRelationEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_ExamPaperStuRelationEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_ExamPaperStuRelationEN.AttributeName)
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
//if (arrvcc_ExamPaperStuRelationObjLst_Cache == null)
//{
//arrvcc_ExamPaperStuRelationObjLst_Cache = await clsvcc_ExamPaperStuRelationWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuRelationEN._CurrTabName_S, strid_CurrEduCls);
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
public static List<clsvcc_ExamPaperStuRelationEN> GetObjLst_Cache(string strid_CurrEduCls)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvcc_ExamPaperStuRelationEN._CurrTabName_S, strid_CurrEduCls);
List<clsvcc_ExamPaperStuRelationEN> arrvcc_ExamPaperStuRelationObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("id_CurrEduCls='{0}'", strid_CurrEduCls)); });
return arrvcc_ExamPaperStuRelationObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_ExamPaperStuRelationEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_ExamPaperStuRelation.Id_ExamPaperStuRelation, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.Id_ExamPaperEduClsRela, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.ExamPaperName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.PaperIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.ExamPaperTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.ExamPaperTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.PaperDispModeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.ExamCreateTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.CourseChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.IsAutoGeneQuestion, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.IsCanMultiDo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.QuestionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.PubDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.IsCurrEduCls, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.IsGroupWork, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.CourseStudentGroupId, Type.GetType("System.Int64"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.WorkTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.SpecifyCompletionDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.AnswerOptionId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.AnswerMultiOptions, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.StuAnswerText, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.IsPublish, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.IsLook, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.IsSave, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.ApplySendBackDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.IsApplySendBack, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.RealFinishDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.OperateTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.Comment, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.IsMarking, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.MarkerId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.MarkDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.IsSendBack, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.IsInErrorQuestion, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.WorkTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.AnswerIP, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.AnswerDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.AnswerTime, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.IsRight, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.IsAccessKnowledge, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.IsNotProcessTimeout, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.NoSubmitBatchNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_ExamPaperStuRelation.SubmitBatchNum, Type.GetType("System.Int32"));
foreach (clsvcc_ExamPaperStuRelationEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_ExamPaperStuRelation.Id_ExamPaperStuRelation] = objInFor[convcc_ExamPaperStuRelation.Id_ExamPaperStuRelation];
objDR[convcc_ExamPaperStuRelation.CourseExamPaperId] = objInFor[convcc_ExamPaperStuRelation.CourseExamPaperId];
objDR[convcc_ExamPaperStuRelation.Id_ExamPaperEduClsRela] = objInFor[convcc_ExamPaperStuRelation.Id_ExamPaperEduClsRela];
objDR[convcc_ExamPaperStuRelation.CourseId] = objInFor[convcc_ExamPaperStuRelation.CourseId];
objDR[convcc_ExamPaperStuRelation.CourseName] = objInFor[convcc_ExamPaperStuRelation.CourseName];
objDR[convcc_ExamPaperStuRelation.ExamPaperName] = objInFor[convcc_ExamPaperStuRelation.ExamPaperName];
objDR[convcc_ExamPaperStuRelation.PaperIndex] = objInFor[convcc_ExamPaperStuRelation.PaperIndex];
objDR[convcc_ExamPaperStuRelation.ExamPaperTypeId] = objInFor[convcc_ExamPaperStuRelation.ExamPaperTypeId];
objDR[convcc_ExamPaperStuRelation.ExamPaperTypeName] = objInFor[convcc_ExamPaperStuRelation.ExamPaperTypeName];
objDR[convcc_ExamPaperStuRelation.PaperDispModeName] = objInFor[convcc_ExamPaperStuRelation.PaperDispModeName];
objDR[convcc_ExamPaperStuRelation.ExamCreateTime] = objInFor[convcc_ExamPaperStuRelation.ExamCreateTime];
objDR[convcc_ExamPaperStuRelation.CourseChapterId] = objInFor[convcc_ExamPaperStuRelation.CourseChapterId];
objDR[convcc_ExamPaperStuRelation.CourseChapterName] = objInFor[convcc_ExamPaperStuRelation.CourseChapterName];
objDR[convcc_ExamPaperStuRelation.ChapterId] = objInFor[convcc_ExamPaperStuRelation.ChapterId];
objDR[convcc_ExamPaperStuRelation.SectionId] = objInFor[convcc_ExamPaperStuRelation.SectionId];
objDR[convcc_ExamPaperStuRelation.ChapterName] = objInFor[convcc_ExamPaperStuRelation.ChapterName];
objDR[convcc_ExamPaperStuRelation.SectionName] = objInFor[convcc_ExamPaperStuRelation.SectionName];
objDR[convcc_ExamPaperStuRelation.ChapterName_Sim] = objInFor[convcc_ExamPaperStuRelation.ChapterName_Sim];
objDR[convcc_ExamPaperStuRelation.SectionName_Sim] = objInFor[convcc_ExamPaperStuRelation.SectionName_Sim];
objDR[convcc_ExamPaperStuRelation.IsAutoGeneQuestion] = objInFor[convcc_ExamPaperStuRelation.IsAutoGeneQuestion];
objDR[convcc_ExamPaperStuRelation.IsCanMultiDo] = objInFor[convcc_ExamPaperStuRelation.IsCanMultiDo];
objDR[convcc_ExamPaperStuRelation.QuestionNum] = objInFor[convcc_ExamPaperStuRelation.QuestionNum];
objDR[convcc_ExamPaperStuRelation.CurrEduClsId] = objInFor[convcc_ExamPaperStuRelation.CurrEduClsId];
objDR[convcc_ExamPaperStuRelation.EduClsName] = objInFor[convcc_ExamPaperStuRelation.EduClsName];
objDR[convcc_ExamPaperStuRelation.TeacherID] = objInFor[convcc_ExamPaperStuRelation.TeacherID];
objDR[convcc_ExamPaperStuRelation.PubDate] = objInFor[convcc_ExamPaperStuRelation.PubDate];
objDR[convcc_ExamPaperStuRelation.IsCurrEduCls] = objInFor[convcc_ExamPaperStuRelation.IsCurrEduCls];
objDR[convcc_ExamPaperStuRelation.IsGroupWork] = objInFor[convcc_ExamPaperStuRelation.IsGroupWork];
objDR[convcc_ExamPaperStuRelation.CourseStudentGroupId] = objInFor[convcc_ExamPaperStuRelation.CourseStudentGroupId];
objDR[convcc_ExamPaperStuRelation.WorkTypeName] = objInFor[convcc_ExamPaperStuRelation.WorkTypeName];
objDR[convcc_ExamPaperStuRelation.id_CurrEduCls] = objInFor[convcc_ExamPaperStuRelation.id_CurrEduCls];
objDR[convcc_ExamPaperStuRelation.Scores] = objInFor[convcc_ExamPaperStuRelation.Scores];
objDR[convcc_ExamPaperStuRelation.SpecifyCompletionDate] = objInFor[convcc_ExamPaperStuRelation.SpecifyCompletionDate];
objDR[convcc_ExamPaperStuRelation.id_StudentInfo] = objInFor[convcc_ExamPaperStuRelation.id_StudentInfo];
objDR[convcc_ExamPaperStuRelation.StuID] = objInFor[convcc_ExamPaperStuRelation.StuID];
objDR[convcc_ExamPaperStuRelation.StuName] = objInFor[convcc_ExamPaperStuRelation.StuName];
objDR[convcc_ExamPaperStuRelation.id_XzCollege] = objInFor[convcc_ExamPaperStuRelation.id_XzCollege];
objDR[convcc_ExamPaperStuRelation.CollegeName] = objInFor[convcc_ExamPaperStuRelation.CollegeName];
objDR[convcc_ExamPaperStuRelation.CollegeNameA] = objInFor[convcc_ExamPaperStuRelation.CollegeNameA];
objDR[convcc_ExamPaperStuRelation.id_XzMajor] = objInFor[convcc_ExamPaperStuRelation.id_XzMajor];
objDR[convcc_ExamPaperStuRelation.MajorID] = objInFor[convcc_ExamPaperStuRelation.MajorID];
objDR[convcc_ExamPaperStuRelation.MajorName] = objInFor[convcc_ExamPaperStuRelation.MajorName];
objDR[convcc_ExamPaperStuRelation.id_GradeBase] = objInFor[convcc_ExamPaperStuRelation.id_GradeBase];
objDR[convcc_ExamPaperStuRelation.GradeBaseName] = objInFor[convcc_ExamPaperStuRelation.GradeBaseName];
objDR[convcc_ExamPaperStuRelation.AdminClsName] = objInFor[convcc_ExamPaperStuRelation.AdminClsName];
objDR[convcc_ExamPaperStuRelation.AdminClsId] = objInFor[convcc_ExamPaperStuRelation.AdminClsId];
objDR[convcc_ExamPaperStuRelation.AnswerModeId] = objInFor[convcc_ExamPaperStuRelation.AnswerModeId];
objDR[convcc_ExamPaperStuRelation.AnswerOptionId] = objInFor[convcc_ExamPaperStuRelation.AnswerOptionId];
objDR[convcc_ExamPaperStuRelation.AnswerMultiOptions] = objInFor[convcc_ExamPaperStuRelation.AnswerMultiOptions];
objDR[convcc_ExamPaperStuRelation.StuAnswerText] = objInFor[convcc_ExamPaperStuRelation.StuAnswerText];
objDR[convcc_ExamPaperStuRelation.IsPublish] = objInFor[convcc_ExamPaperStuRelation.IsPublish];
objDR[convcc_ExamPaperStuRelation.IsLook] = objInFor[convcc_ExamPaperStuRelation.IsLook];
objDR[convcc_ExamPaperStuRelation.IsSave] = objInFor[convcc_ExamPaperStuRelation.IsSave];
objDR[convcc_ExamPaperStuRelation.IsSubmit] = objInFor[convcc_ExamPaperStuRelation.IsSubmit];
objDR[convcc_ExamPaperStuRelation.ApplySendBackDate] = objInFor[convcc_ExamPaperStuRelation.ApplySendBackDate];
objDR[convcc_ExamPaperStuRelation.IsApplySendBack] = objInFor[convcc_ExamPaperStuRelation.IsApplySendBack];
objDR[convcc_ExamPaperStuRelation.RealFinishDate] = objInFor[convcc_ExamPaperStuRelation.RealFinishDate];
objDR[convcc_ExamPaperStuRelation.OperateTime] = objInFor[convcc_ExamPaperStuRelation.OperateTime];
objDR[convcc_ExamPaperStuRelation.Score] = objInFor[convcc_ExamPaperStuRelation.Score];
objDR[convcc_ExamPaperStuRelation.Comment] = objInFor[convcc_ExamPaperStuRelation.Comment];
objDR[convcc_ExamPaperStuRelation.IsMarking] = objInFor[convcc_ExamPaperStuRelation.IsMarking];
objDR[convcc_ExamPaperStuRelation.MarkerId] = objInFor[convcc_ExamPaperStuRelation.MarkerId];
objDR[convcc_ExamPaperStuRelation.MarkDate] = objInFor[convcc_ExamPaperStuRelation.MarkDate];
objDR[convcc_ExamPaperStuRelation.IsSendBack] = objInFor[convcc_ExamPaperStuRelation.IsSendBack];
objDR[convcc_ExamPaperStuRelation.IsInErrorQuestion] = objInFor[convcc_ExamPaperStuRelation.IsInErrorQuestion];
objDR[convcc_ExamPaperStuRelation.WorkTypeId] = objInFor[convcc_ExamPaperStuRelation.WorkTypeId];
objDR[convcc_ExamPaperStuRelation.AnswerIP] = objInFor[convcc_ExamPaperStuRelation.AnswerIP];
objDR[convcc_ExamPaperStuRelation.AnswerDate] = objInFor[convcc_ExamPaperStuRelation.AnswerDate];
objDR[convcc_ExamPaperStuRelation.AnswerTime] = objInFor[convcc_ExamPaperStuRelation.AnswerTime];
objDR[convcc_ExamPaperStuRelation.IsRight] = objInFor[convcc_ExamPaperStuRelation.IsRight];
objDR[convcc_ExamPaperStuRelation.IsAccessKnowledge] = objInFor[convcc_ExamPaperStuRelation.IsAccessKnowledge];
objDR[convcc_ExamPaperStuRelation.IsNotProcessTimeout] = objInFor[convcc_ExamPaperStuRelation.IsNotProcessTimeout];
objDR[convcc_ExamPaperStuRelation.SchoolYear] = objInFor[convcc_ExamPaperStuRelation.SchoolYear];
objDR[convcc_ExamPaperStuRelation.SchoolTerm] = objInFor[convcc_ExamPaperStuRelation.SchoolTerm];
objDR[convcc_ExamPaperStuRelation.UpdDate] = objInFor[convcc_ExamPaperStuRelation.UpdDate];
objDR[convcc_ExamPaperStuRelation.UpdUserId] = objInFor[convcc_ExamPaperStuRelation.UpdUserId];
objDR[convcc_ExamPaperStuRelation.Memo] = objInFor[convcc_ExamPaperStuRelation.Memo];
objDR[convcc_ExamPaperStuRelation.NoSubmitBatchNum] = objInFor[convcc_ExamPaperStuRelation.NoSubmitBatchNum];
objDR[convcc_ExamPaperStuRelation.SubmitBatchNum] = objInFor[convcc_ExamPaperStuRelation.SubmitBatchNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}